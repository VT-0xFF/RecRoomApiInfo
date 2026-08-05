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
	public class LogRegistrationIndex : IFEEDCBNDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6701210", Offset = "0x66FFA10", VA = "0x186701210", Slot = "4")]
		public override void MPPLGFJBDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8472C0", Offset = "0x845AC0", VA = "0x1808472C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6703A80", Offset = "0x6702280", VA = "0x186703A80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67039B0", Offset = "0x67021B0", VA = "0x1867039B0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6703A40", Offset = "0x6702240", VA = "0x186703A40")]
		public RecNetCDNAssetReference(RecNetCDNKey JOEHGGMHBAA)
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
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x844F30", Offset = "0x843730", VA = "0x180844F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84A250", Offset = "0x848A50", VA = "0x18084A250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6703B70", Offset = "0x6702370", VA = "0x186703B70")]
		public static RecNetCDNKey NHCNNCKHJBG(string DOMBDPDJFPE, string GCDOGHLEEPE = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F409C0", Offset = "0x5F3F1C0", VA = "0x185F409C0")]
		public void KMNNLMEJMBF(string IHIJOPBPLLF, string MOKMMDBCGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6703AC0", Offset = "0x67022C0", VA = "0x186703AC0")]
		public RecNetCDNKey KKHIAIIKLPN(string FBCDPDLLMPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6703C00", Offset = "0x6702400", VA = "0x186703C00")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[BFNFAOFCCLN]
public class IMPAIKGGMFE : INEILAMCNIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> GECFFPPLOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> LFMHDEMNBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> LAECNNNHJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> BENJCKCLNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> NECKFECHIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> JLNABMNNCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> KKLEGDJGGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator ECLECFLFFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected FDJPGHHMBBM FDJKCBLGDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte ANAGIKKDEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> BHEJPPMPEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> LKGHHOMBEIN;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x66EFCB0", Offset = "0x66EE4B0", VA = "0x1866EFCB0", Slot = "4")]
	public void LBIGDMPJGJN(Mesh NCHKGMDMAMN, Matrix4x4 CHNOCEINAMF, byte[] NPFMKPLKFPO, bool NAHPKGNMAEN = false, AIEGLCJJPJP.EDICGNCOMOB BJAPNHEICNI = (AIEGLCJJPJP.EDICGNCOMOB)0, int JCHCLNANBFF = -1, bool FPAKKHGLNBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66EFC70", Offset = "0x66EE470", VA = "0x1866EFC70", Slot = "5")]
	public void LBBKIONMPGC(Allocator KCJKALFMGMC, FDJPGHHMBBM JFELHCDOMDE, byte MPEOLLOMHAN, [Optional] IList<int> FIELINDHFCC, [Optional] IList<int> LNEJIKDDCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x66EFB40", Offset = "0x66EE340", VA = "0x1866EFB40")]
	private static void KBHPGOPIAEC(Mesh NCHKGMDMAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x66EFFD0", Offset = "0x66EE7D0", VA = "0x1866EFFD0")]
	public IMPAIKGGMFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BFNFAOFCCLN]
public struct MMOIEEDLDMD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public INDHGDNMBCA JDCPHFCFHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int PCANDBFCJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEHCCPIDPFK EJBGLMCEOGM;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6701690", Offset = "0x66FFE90", VA = "0x186701690", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BFNFAOFCCLN]
[NativeContainer]
public struct IEHCCPIDPFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct EANMHEDIFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 KNPIJKNLGEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 ANAAMNHLGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 APMGNNPLKKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct EIDBCDNJFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float GJMINIEILPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float JFLFECDFANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float CFNACNEIMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float HCLMAIDMNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte OBHMPLDMNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte KMFHIIMOIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte AMDKFPHFPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte BBJAFJLIJEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct ICFDFPEIOMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half GJMINIEILPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half JFLFECDFANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half CFNACNEIMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half HCLMAIDMNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte OBHMPLDMNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte KMFHIIMOIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte AMDKFPHFPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte BBJAFJLIJEK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct EOCDPKMHINJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 NLKAPPNAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 HJNJJHAHLPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct NIEAAHMFNJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 NLKAPPNAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 HJNJJHAHLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 MOAABAGPFIK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct HBEAFLIEDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 NLKAPPNAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 HJNJJHAHLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 MOAABAGPFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 JONBMJEALAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BLGLBCJFOBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 NLKAPPNAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 HJNJJHAHLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 MOAABAGPFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 JONBMJEALAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 IDPENAHEJAC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DOHBPKOFGLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float GJMINIEILPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float JFLFECDFANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float CFNACNEIMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float HCLMAIDMNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int OBHMPLDMNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int KMFHIIMOIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int AMDKFPHFPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int BBJAFJLIJEK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct JLBLELJOMJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color NLKAPPNAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 HJNJJHAHLPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct GNNECAMEPJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color NLKAPPNAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 HJNJJHAHLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 MOAABAGPFIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct IGOJDDNKBMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color NLKAPPNAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 HJNJJHAHLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 MOAABAGPFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 JONBMJEALAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct POCDGDNKLLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color NLKAPPNAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 HJNJJHAHLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 MOAABAGPFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 JONBMJEALAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 IDPENAHEJAC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool PEGKALLJJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<EANMHEDIFHD> PBCKKNGAFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<EOCDPKMHINJ> LEDJAAFMCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<NIEAAHMFNJJ> HHGDKGFKMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<HBEAFLIEDBM> KMIDGNIIJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BLGLBCJFOBM> JOMFKBEHDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ICFDFPEIOMG> IMDADMMPKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<EIDBCDNJFDN> OOOJPIFNCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<JLBLELJOMJL> EPMNANJIKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<GNNECAMEPJG> FPPHKPNFIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<IGOJDDNKBMD> DAMKLKGHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<POCDGDNKLLP> FEGALGFMHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<DOHBPKOFGLE> IFFEAOELIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> HEEIJFBDLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> CJAKEEODJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> FOFGGLDPHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> FNGHNPIJCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> KLCABEKIBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> HAKDHJAPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> NGCIOADIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> PDPMJKHGEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> EKJGIMBPPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool MJJNOKMOCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool GDHNFCOJALG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EBNOEEOOOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x66EDAD0", Offset = "0x66EC2D0", VA = "0x1866EDAD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66ECB60", Offset = "0x66EB360", VA = "0x1866ECB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NHGGBCACNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66EE650", Offset = "0x66ECE50", VA = "0x1866EE650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66EEA10", Offset = "0x66ED210", VA = "0x1866EEA10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CILLHOCKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x66EE660", Offset = "0x66ECE60", VA = "0x1866EE660")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x66ECB70", Offset = "0x66EB370", VA = "0x1866ECB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NKFPOJNDPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x66EE9A0", Offset = "0x66ED1A0", VA = "0x1866EE9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x66EEEB0", Offset = "0x66ED6B0", VA = "0x1866EEEB0")]
	public IEHCCPIDPFK(int FACEDKAEAJE, int EIMHNKJDFJK, int HKKBOHJKBLB, int OAKDFANNCAP, Allocator KCJKALFMGMC, int NPBFNDMLEML, CANMLLNEELM CMOOBNBJLPG, bool MJJNOKMOCIN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x66EEA20", Offset = "0x66ED220", VA = "0x1866EEA20")]
	public void MPHKMHEFJFD(int JBDLDJOINOF, Vector3 BLNBBLFAAGC, Vector3 FEGGJAIMAGC, Vector4 AFCJJMLHKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x66EDD40", Offset = "0x66EC540", VA = "0x1866EDD40")]
	public void FIMPKODIMGP(int JBDLDJOINOF, BoneWeight CBANBGMGEJA, NativeSlice<byte> NPFMKPLKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x66EE670", Offset = "0x66ECE70", VA = "0x1866EE670")]
	public Color LFLPHFBIBGD(int JBDLDJOINOF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x66EEAB0", Offset = "0x66ED2B0", VA = "0x1866EEAB0")]
	public void NIGALAAJCJJ(int JBDLDJOINOF, Color FFEGACHBGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x66EE1D0", Offset = "0x66EC9D0", VA = "0x1866EE1D0")]
	public void HHLAJJJHIPL(byte KHPFGABHAOE, int JBDLDJOINOF, Vector2 AOMFBAOLGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x66EDAC0", Offset = "0x66EC2C0", VA = "0x1866EDAC0")]
	public void DBLHEDKDDPJ(int JBDLDJOINOF, int EANKJDHJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x66EE170", Offset = "0x66EC970", VA = "0x1866EE170")]
	public bool GDMIMGDPPCA(int KHPFGABHAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x66EE580", Offset = "0x66ECD80", VA = "0x1866EE580")]
	public void JBNBLJLJAEH(int OEKIGHEKNMJ, int MFLLOPOPNNG, int IDGMEKAEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x66EDAE0", Offset = "0x66EC2E0", VA = "0x1866EDAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x66ECB80", Offset = "0x66EB380", VA = "0x1866ECB80")]
	public Mesh BNJPGPIDHDA([Optional] string LHKFGAMPHBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
[BFNFAOFCCLN]
[NativeContainer]
public struct INDHGDNMBCA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray NEGLMJMIFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> PLCKLEBBGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> FMIPJEICJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> PDPMJKHGEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> POPCOHHNBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> OBLAPOOFMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> MDAKMLCGEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> MPLHJAHGHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> ENGLKNHFNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> ACPONNFDECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> CDLPAMEOACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> FPAKKHGLNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> JCHCLNANBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool MJJNOKMOCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> EABFLLOPAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool GDHNFCOJALG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int LIGADHAIPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x66F0210", Offset = "0x66EEA10", VA = "0x1866F0210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KCEOECPEGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x66F07F0", Offset = "0x66EEFF0", VA = "0x1866F07F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GKGJNGLCHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x66F06C0", Offset = "0x66EEEC0", VA = "0x1866F06C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IAOOGPLECKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x66F07B0", Offset = "0x66EEFB0", VA = "0x1866F07B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x66F07A0", Offset = "0x66EEFA0", VA = "0x1866F07A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EBNOEEOOOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x66F0220", Offset = "0x66EEA20", VA = "0x1866F0220")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x66F0200", Offset = "0x66EEA00", VA = "0x1866F0200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OHEBEJPCDEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x66F0790", Offset = "0x66EEF90", VA = "0x1866F0790")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x66F07C0", Offset = "0x66EEFC0", VA = "0x1866F07C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public FDJPGHHMBBM CJLHBEBPNNO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x66F0810", Offset = "0x66EF010", VA = "0x1866F0810")]
		get
		{
			return default(FDJPGHHMBBM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x66F0800", Offset = "0x66EF000", VA = "0x1866F0800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte FIGEMIELLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x66F07D0", Offset = "0x66EEFD0", VA = "0x1866F07D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x66F07E0", Offset = "0x66EEFE0", VA = "0x1866F07E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public PDMDDCACJDF EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66F0470", Offset = "0x66EEC70", VA = "0x1866F0470")]
		get
		{
			return default(PDMDDCACJDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x66F0820", Offset = "0x66EF020", VA = "0x1866F0820")]
	public INDHGDNMBCA(IList<Mesh> KNGALABNAMG, IList<Matrix4x4> IHKHNBOOKKI, IList<bool> FPAKKHGLNBF, byte MPEOLLOMHAN, IList<byte[]> DBEDKCNMHNN, IList<int> FDFEOKBFILK, IList<bool> DJHDOGKACGB, IList<int> JCHCLNANBFF, IList<int> FIELINDHFCC, IList<int> PECOIKGCKBB, Allocator KCJKALFMGMC, FDJPGHHMBBM JFELHCDOMDE, bool MJJNOKMOCIN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x66F03A0", Offset = "0x66EEBA0", VA = "0x1866F03A0")]
	public IEHCCPIDPFK EAMNMJIOJDE(Allocator KCJKALFMGMC, CANMLLNEELM CMOOBNBJLPG)
	{
		return default(IEHCCPIDPFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x66F0230", Offset = "0x66EEA30", VA = "0x1866F0230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BFNFAOFCCLN]
public class CELNPJFEBLA : IMPAIKGGMFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool JAPMHDBNOCO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x66EC710", Offset = "0x66EAF10", VA = "0x1866EC710")]
	public INDHGDNMBCA LIGLOOHIIAL()
	{
		return default(INDHGDNMBCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x66EC830", Offset = "0x66EB030", VA = "0x1866EC830")]
	public CELNPJFEBLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PDMDDCACJDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Mesh.MeshData GFGODEMJCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeSlice<BoneWeight> PDPMJKHGEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<byte> FPKNBIMFLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int FCCEEAMNFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Matrix4x4 IPEIEEPNEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public int CBIDKDEMOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeSlice<byte> NPFMKPLKFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool ACHEACMAGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int CINIMBFPFEL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JCKGAIJDIGB : FAICNNGHKAN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class IAKIPPJHGDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly COKDDOEMBCP HHFLBDDINNN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual bool IFJIKIHJEOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool LDPPFCALAFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual AIEGLCJJPJP.EDICGNCOMOB CBIDKDEMOFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "6")]
			get
			{
				return default(AIEGLCJJPJP.EDICGNCOMOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool CDGNHGPGCOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1483540", Offset = "0x1481D40", VA = "0x181483540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool FEGNHGHAKBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x66ECB50", Offset = "0x66EB350", VA = "0x1866ECB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool APHBBJHAJFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x66ECB30", Offset = "0x66EB330", VA = "0x1866ECB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		protected IAKIPPJHGDP(COKDDOEMBCP PNAPGHGIDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract JHMBDMCOPKA FDMFIIDJIDE(int[] BLBPLNGEHMG, List<FAIOIOPAKIG> GMKHAGKMEOK, List<FAIOIOPAKIG> IOJLGHPBKBA);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract GCAENKOCPHA NPOCGIMBIID(uint IBPIKFEDDCD, AvatarSkinnedMeshBoneOrderRemapsData KGDCHEOCJLG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class PALNGNDKKBE : IAKIPPJHGDP
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class MDILAIDNMIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public MJMNDKPKIPJ<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public PALNGNDKKBE <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public MDILAIDNMIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x67012A0", Offset = "0x66FFAA0", VA = "0x1867012A0")]
			internal void FAJANLHECKP(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly AvatarSkinAssetItem.EOJNMCEGGDA LLFFMCDJEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly AssetReference ADDMHDFCBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly AIEGLCJJPJP.EDICGNCOMOB GMBDKLKNHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly CFAGBELJJDL? LLCJFLDPKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly Material[] ELGFOGFIHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private SkinnedMeshRenderer[] EPIOBNGHMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private AvatarSkinAssetItem JFOGBOFBBAI;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override AIEGLCJJPJP.EDICGNCOMOB CBIDKDEMOFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x84CE60", Offset = "0x84B660", VA = "0x18084CE60", Slot = "6")]
			get
			{
				return default(AIEGLCJJPJP.EDICGNCOMOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6703770", Offset = "0x6701F70", VA = "0x186703770")]
		public PALNGNDKKBE(AvatarSkinAssetItem.EOJNMCEGGDA NAGDBMEPCKG, AssetReference EICKPKDICBC, Material APNEFNFPNGN, COKDDOEMBCP MFKCOFBNOLB, AIEGLCJJPJP.EDICGNCOMOB PHBOEDJBDGG = (AIEGLCJJPJP.EDICGNCOMOB)0, [Optional] CFAGBELJJDL? AJBOABOCNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6703660", Offset = "0x6701E60", VA = "0x186703660")]
		public PALNGNDKKBE(AvatarSkinAssetItem.EOJNMCEGGDA NAGDBMEPCKG, AssetReference EICKPKDICBC, Material APNEFNFPNGN, AIEGLCJJPJP.EDICGNCOMOB PHBOEDJBDGG = (AIEGLCJJPJP.EDICGNCOMOB)0, [Optional] CFAGBELJJDL? AJBOABOCNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6703140", Offset = "0x6701940", VA = "0x186703140", Slot = "7")]
		public override JHMBDMCOPKA FDMFIIDJIDE(int[] BLBPLNGEHMG, List<FAIOIOPAKIG> GMKHAGKMEOK, List<FAIOIOPAKIG> IOJLGHPBKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6703310", Offset = "0x6701B10", VA = "0x186703310", Slot = "8")]
		public override GCAENKOCPHA NPOCGIMBIID(uint IBPIKFEDDCD, AvatarSkinnedMeshBoneOrderRemapsData KGDCHEOCJLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x67035F0", Offset = "0x6701DF0", VA = "0x1867035F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class JEJKHLEBCLO : IAKIPPJHGDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly POHNLJKEFAJ HIHEGIBCIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private MJMNDKPKIPJ<IILJNCAFAJH> EKFENELOCDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public IILJNCAFAJH APMHIEHJNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private MJMNDKPKIPJ<Material>[] AKHGINJHCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public List<Material> CEPDKJADOBA;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool IFJIKIHJEOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool LDPPFCALAFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x66FE4A0", Offset = "0x66FCCA0", VA = "0x1866FE4A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1CD60B0", Offset = "0x1CD48B0", VA = "0x181CD60B0")]
		public JEJKHLEBCLO(COKDDOEMBCP PNAPGHGIDOM, POHNLJKEFAJ DBFCNDIKGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x66FDF30", Offset = "0x66FC730", VA = "0x1866FDF30", Slot = "7")]
		public override JHMBDMCOPKA FDMFIIDJIDE(int[] BLBPLNGEHMG, List<FAIOIOPAKIG> GMKHAGKMEOK, List<FAIOIOPAKIG> IOJLGHPBKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x66FE9B0", Offset = "0x66FD1B0", VA = "0x1866FE9B0", Slot = "8")]
		public override GCAENKOCPHA NPOCGIMBIID(uint IBPIKFEDDCD, AvatarSkinnedMeshBoneOrderRemapsData KGDCHEOCJLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x66FE6A0", Offset = "0x66FCEA0", VA = "0x1866FE6A0")]
		public GCAENKOCPHA LNOHFOJKLHP(GameObject BDFGICJPENK, uint IBPIKFEDDCD, bool OCHECBEAIBH, bool HMENILHJCIL, AvatarSkinnedMeshBoneOrderRemapsData KGDCHEOCJLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x66FEAE0", Offset = "0x66FD2E0", VA = "0x1866FEAE0")]
		public static bool OKLIDEFJHKD(Renderer[] ENBDMIFLMCH, string NJLCCFDKENL, [Out] Renderer JBLHEKDBCAH, [Out] Renderer BILAKJIGGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x66FEE40", Offset = "0x66FD640", VA = "0x1866FEE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x66FE500", Offset = "0x66FCD00", VA = "0x1866FE500")]
		private (MJMNDKPKIPJ<IILJNCAFAJH>, MJMNDKPKIPJ<Material>[]) JCNNDOOPDGO()
		{
			return default((MJMNDKPKIPJ<IILJNCAFAJH>, MJMNDKPKIPJ<Material>[]));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x66FE890", Offset = "0x66FD090", VA = "0x1866FE890")]
		private MJMNDKPKIPJ<Material>[] MJNFNNNJHFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x41788C0", Offset = "0x41770C0", VA = "0x1841788C0")]
		[CompilerGenerated]
		private void JJAIOPLJIIF(IILJNCAFAJH KKBKNCNBBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x66FDE00", Offset = "0x66FC600", VA = "0x1866FDE00")]
		[CompilerGenerated]
		private void DJGNKDFAJDL(MJMNDKPKIPJ<Material> OJKGDJAFNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x66FDDA0", Offset = "0x66FC5A0", VA = "0x1866FDDA0")]
		[CompilerGenerated]
		private void BCCELMICDJJ(Material KKBKNCNBBJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HBKMLIDOEPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public JCKGAIJDIGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public PEJDBLFKJJN buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HBKMLIDOEPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x66ECAF0", Offset = "0x66EB2F0", VA = "0x1866ECAF0")]
		internal void HEPBGPNGFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x66ECB10", Offset = "0x66EB310", VA = "0x1866ECB10")]
		internal void HMCANOFJHEG(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x66ECA60", Offset = "0x66EB260", VA = "0x1866ECA60")]
		internal void CPADMIEMFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x66EC9D0", Offset = "0x66EB1D0", VA = "0x1866EC9D0")]
		internal void BPOKODPECBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		internal JHMBDMCOPKA INNBELNIFDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DJKGFNHFIPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public HBKMLIDOEPG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DJKGFNHFIPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x66EC8C0", Offset = "0x66EB0C0", VA = "0x1866EC8C0")]
		internal PDFHFOMMFMC KEBCEOEKGHH(int lod)
		{
			return default(PDFHFOMMFMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PCHMECBEBKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public List<PEJDBLFKJJN> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public PCHMECBEBKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6703880", Offset = "0x6702080", VA = "0x186703880")]
		internal void EMJMJNMNBMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IGCHODLPNJG : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public JCKGAIJDIGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<IAKIPPJHGDP> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public List<PEJDBLFKJJN> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Func<int, PDFHFOMMFMC> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public FLJFHNFMGOK materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public IGCHODLPNJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x66EF8E0", Offset = "0x66EE0E0", VA = "0x1866EF8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x66EFAF0", Offset = "0x66EE2F0", VA = "0x1866EFAF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DOIOKPOAJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public JCKGAIJDIGB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DOIOKPOAJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x66EC980", Offset = "0x66EB180", VA = "0x1866EC980")]
		internal JHMBDMCOPKA PFBIHAGOFMF(IAKIPPJHGDP p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CIPLAHFPLLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public LJHPANCFKIM cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CIPLAHFPLLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x93A7C0", Offset = "0x938FC0", VA = "0x18093A7C0")]
		internal void DCLLMDNPEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9D2440", Offset = "0x9D0C40", VA = "0x1809D2440")]
		internal void MMHGLFHBMIH(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JMGKPHEDJBJ
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
		public JCKGAIJDIGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public JMGKPHEDJBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class ANHIMFICKKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public IEHCCPIDPFK defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public INDHGDNMBCA defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public JMGKPHEDJBJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ANHIMFICKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x66EC240", Offset = "0x66EAA40", VA = "0x1866EC240")]
		internal void PJCCLOIIFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x66EC1D0", Offset = "0x66EA9D0", VA = "0x1866EC1D0")]
		internal void IOMDHILAKFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BBOFMJFLPJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CNLAKBENFCP legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public EKLPLPICHDF legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public JMGKPHEDJBJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BBOFMJFLPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x66EC4E0", Offset = "0x66EACE0", VA = "0x1866EC4E0")]
		internal void LHJAMKHINNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x66EC470", Offset = "0x66EAC70", VA = "0x1866EC470")]
		internal void IGCPFJPBLGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KIFLOKNJCAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public LJHPANCFKIM cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public POHNLJKEFAJ avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public JCKGAIJDIGB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KIFLOKNJCAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6700DD0", Offset = "0x66FF5D0", VA = "0x186700DD0")]
		internal JHMBDMCOPKA JJDBBDDEHDO(ENBCFCAPAEH item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6701180", Offset = "0x66FF980", VA = "0x186701180")]
		internal void KMPHEKMPHIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KNCEKCLLLFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public MJMNDKPKIPJ<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KNCEKCLLLFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x67011C0", Offset = "0x66FF9C0", VA = "0x1867011C0")]
		internal void CNEBLMNAJCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CFEDBLMFHIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public COKDDOEMBCP overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public CFEDBLMFHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x66EC840", Offset = "0x66EB040", VA = "0x1866EC840")]
		internal bool LNDNIGJBHCH(KeyValuePair<string, POHNLJKEFAJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AvatarConfiguration OLLEILADBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Transform CMNGIGFHKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private AssetReference ADDMHDFCBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private GameObject LOKCJIHEFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject GJMABNENMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private SkinnedMeshRenderer KALNOMLNKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private AvatarSkinnedMeshBoneOrderRemapsData OBFBEBBFALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Transform[] OOKGBBHCOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Matrix4x4[] GKADEEDDDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Material DJMODNFIPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material GPLOIMMBHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material CJLHHBNCFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Shader JDBNKEGEFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader PJFNLALDNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Animator EKKFHJNPGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Renderer[] NCLPHCKGCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private AIEGLCJJPJP.EDICGNCOMOB JPIDNHKMIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Color BFEPKMEDIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Color CINJEIEBHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Color HMNPOIOMOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Color? MEPDBIJFNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Color? MLBKOACDHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Color? KGOIGGKILFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Color? HGFDAEJNCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Texture2D KBFIIKDLCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Texture2D MNICMGDGHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[CanBeNull]
	private POHNLJKEFAJ GAOLBADGFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Texture DIKECGKPICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color JGKBODLMEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Dictionary<Renderer, FLJFHNFMGOK> HNEIAOEBHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Dictionary<Renderer, FLJFHNFMGOK> LKGGJGGGNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Dictionary<string, List<FJJLCODEKMD>> PMHEBCOKMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Dictionary<string, List<FJJLCODEKMD>> FFJHIMAAJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly List<FAIOIOPAKIG> HOFEGOCKKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly List<FAIOIOPAKIG> PBLEEGONLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<FAIOIOPAKIG> KCNIGPEKMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<FAIOIOPAKIG> PGEGDMKCMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<FJJLCODEKMD, Material> IAAEMMLHHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<FJJLCODEKMD, Material> IKACJIHFAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private SkinnedMeshRenderer[] GONPDJPIKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private SkinnedMeshRenderer[] JCHNKLIFPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private SkinnedMeshRenderer[] AOBJPCEBLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private SkinnedMeshRenderer[] ALLCPOOBHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<string, MJMNDKPKIPJ<Texture2D>> CNCCGFMLBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly Dictionary<string, MJMNDKPKIPJ<Texture2D>> LEFHPLFKMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private FitMeshHemisphere EMDOHHPAGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool AOBJBCIMAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private NCNMBJAGJBN HPABICLGLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool LEHGFJFCPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private AnchorParamsRestrictions NCFCEHDBADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool MCDGJGKFKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Transform NMMEBCGKIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Transform ODHPFFKDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool HDCMNIIBFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x209")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool KEFKANANLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Vector3 DPHLOAGMMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Quaternion NCEOHIJKOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Vector2 GFEAJJIGCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private FitMeshHemisphere LJOLHLNMGKG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material PAILEEODGIJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Material KACPJOLBPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, POHNLJKEFAJ> LGNBONEKNJH;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int LPPKGPPIIFG;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int IJKJIIIEKIG;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int PBEPHBMNKGF;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int PBAMHJFBEOK;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int MNABCMACBAA;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int CMLDKOIIKFF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int HBEPIENCNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly LFHDLKLNBFG MOIPEOLGBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly LFHDLKLNBFG DOPENALBCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool GMIGPOECFAE;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static Lazy<LKKABOLKPGL> GDLAHGAMDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Lazy<JFODBJJPJNC> LBLDIDFDLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Lazy<ANIHHFPOAFF> IEKGDCDCJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private MHEKKGCANGA LPICPNAIEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private List<Action> OOCDEFAAGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private MGCPAFPOIGG FHIOALCGNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] FOLNMCOKJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int OCPOAKHFLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool LAKFDODAPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int BJGGELOAHFO;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool NGKGIONCJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x95B320", Offset = "0x959B20", VA = "0x18095B320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x95A500", Offset = "0x958D00", VA = "0x18095A500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool KJINIGAANAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAB93A0", Offset = "0xAB7BA0", VA = "0x180AB93A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material MCJGBKBMDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x66F1B70", Offset = "0x66F0370", VA = "0x1866F1B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material JCHGMANAILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x66FA2D0", Offset = "0x66F8AD0", VA = "0x1866FA2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool OLDMCJPDODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static LKKABOLKPGL BLEJNPBMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x66F9720", Offset = "0x66F7F20", VA = "0x1866F9720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private JFODBJJPJNC EBCFICELLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x66F33C0", Offset = "0x66F1BC0", VA = "0x1866F33C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private ANIHHFPOAFF FBIMHOCBAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x66FAA50", Offset = "0x66F9250", VA = "0x1866FAA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private MHEKKGCANGA NAJGPFGINNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x66F6D10", Offset = "0x66F5510", VA = "0x1866F6D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LFHDLKLNBFG PGECFIABFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1382860", Offset = "0x1381060", VA = "0x181382860", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LFHDLKLNBFG NGCLEBKALHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x10DFAA0", Offset = "0x10DE2A0", VA = "0x1810DFAA0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] OAOGGAIMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAB8650", Offset = "0xAB6E50", VA = "0x180AB8650", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] AEHJDICFMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8512E0", Offset = "0x84FAE0", VA = "0x1808512E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MPPANDPIELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x66F95B0", Offset = "0x66F7DB0", VA = "0x1866F95B0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public AIEGLCJJPJP.EDICGNCOMOB GMFBEGCPIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x851420", Offset = "0x84FC20", VA = "0x180851420", Slot = "18")]
		get
		{
			return default(AIEGLCJJPJP.EDICGNCOMOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int ALMHLCNBCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x95AF10", Offset = "0x959710", VA = "0x18095AF10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x66F87B0", Offset = "0x66F6FB0", VA = "0x1866F87B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool FMNEODIBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x66F7F60", Offset = "0x66F6760", VA = "0x1866F7F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private static bool AJGLCLLAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x66F71A0", Offset = "0x66F59A0", VA = "0x1866F71A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x66FD4B0", Offset = "0x66FBCB0", VA = "0x1866FD4B0")]
	public JCKGAIJDIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x66F3EE0", Offset = "0x66F26E0", VA = "0x1866F3EE0", Slot = "21")]
	public void DIHNAABPOCM(IFJMLJCMIDP GAHPJMCFEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x66F3880", Offset = "0x66F2080", VA = "0x1866F3880", Slot = "22")]
	public void CEOJGNHEJMD(OEFBJFINLMA HDJAEJCANHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x66F87B0", Offset = "0x66F6FB0", VA = "0x1866F87B0", Slot = "4")]
	public void PEKEAPJIOCM(int IBPIKFEDDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x66F9DE0", Offset = "0x66F85E0", VA = "0x1866F9DE0", Slot = "9")]
	public void MOPFFCJAJGH(GCFDHHIHJHN OLPNKBGAKIC, Texture2D JHIAEMLCNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x66F8F00", Offset = "0x66F7700", VA = "0x1866F8F00", Slot = "10")]
	public void KDKKNCCAHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x66F6B00", Offset = "0x66F5300", VA = "0x1866F6B00", Slot = "11")]
	public bool GAFFFPILBKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x66FCD70", Offset = "0x66FB570", VA = "0x1866FCD70", Slot = "8")]
	public void PFEJELPNAHM(HIIOOJFIKFI OGHBHDDMEAI, Color? NLKAPPNAHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x66F9790", Offset = "0x66F7F90", VA = "0x1866F9790")]
	private void LKPCOMCIPFG(Action JGFGMINPNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x66F7340", Offset = "0x66F5B40", VA = "0x1866F7340", Slot = "5")]
	public void GHAAAKHOFNN(POHNLJKEFAJ ADIKOHHMAMJ, Texture OOFBKEMENMO, Color EHEBFAPPOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x95A500", Offset = "0x958D00", VA = "0x18095A500", Slot = "6")]
	public void PGNLNJMPOBI(bool GJGHIFCMKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1648B60", Offset = "0x1647360", VA = "0x181648B60", Slot = "7")]
	public void APPFCEPDKCD(MGCPAFPOIGG EKJGIMBPPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x66FB1A0", Offset = "0x66F99A0", VA = "0x1866FB1A0", Slot = "14")]
	public PEJDBLFKJJN OLJGJFNKBNH(ALDGHKAMMJA IKBMIAGBJGE, bool GBCNBKBCGHI, int[] GICLGOKDOKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x66FAE00", Offset = "0x66F9600", VA = "0x1866FAE00", Slot = "15")]
	public void OCACGGKKNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x66F8DA0", Offset = "0x66F75A0", VA = "0x1866F8DA0")]
	private bool JLAKJBADPID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x851430", Offset = "0x84FC30", VA = "0x180851430", Slot = "19")]
	public void NOKPLBONOFJ(AIEGLCJJPJP.EDICGNCOMOB JFMIBOGMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x66FB0E0", Offset = "0x66F98E0", VA = "0x1866FB0E0")]
	private bool OHNLIJGGHEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x66F22E0", Offset = "0x66F0AE0", VA = "0x1866F22E0")]
	private PEJDBLFKJJN AMMMBONPFPN(bool GBCNBKBCGHI, List<IAKIPPJHGDP> GHLNKEHBEMM, int[] GICLGOKDOKL, Func<int, PDFHFOMMFMC> DOPBMLCCLAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x66FD170", Offset = "0x66FB970", VA = "0x1866FD170")]
	[IteratorStateMachine(typeof(IGCHODLPNJG))]
	private IEnumerator<PENLHNEFADH> PHHABDBOBCB(bool GBCNBKBCGHI, List<IAKIPPJHGDP> GHLNKEHBEMM, int[] GICLGOKDOKL, Func<int, PDFHFOMMFMC> DOPBMLCCLAE, FLJFHNFMGOK GMJKBNAPJEP, Material PBIFKLGLNNP, List<PEJDBLFKJJN> NDLCLADLICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66F82E0", Offset = "0x66F6AE0", VA = "0x1866F82E0")]
	private PEJDBLFKJJN HPDHCMKEMEP(List<IAKIPPJHGDP> GHLNKEHBEMM, int[] GICLGOKDOKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x66F4E90", Offset = "0x66F3690", VA = "0x1866F4E90")]
	private JLAFAKOGFMB FHFBEHDEJOO(List<IAKIPPJHGDP> GHLNKEHBEMM, int IBPIKFEDDCD, bool GBCNBKBCGHI, PDFHFOMMFMC CKKMCLHJEBN, bool LCJBDMDJCFB, FLJFHNFMGOK GMJKBNAPJEP, Material PBIFKLGLNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x66FA8C0", Offset = "0x66F90C0", VA = "0x1866FA8C0")]
	private void NJIOEMCHFKO(SkinnedMeshRenderer ADPLJMPKLCO, Mesh NCHKGMDMAMN, List<Material> CJPAKJAGDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x66F7B20", Offset = "0x66F6320", VA = "0x1866F7B20")]
	private static Material GPNLONDKBKE(Dictionary<FJJLCODEKMD, Material> NHGIKEJIPMJ, Material OBOANGAOPGJ, HCEHMNJDCEM DEABCLPANPN, GABOPADGKJJ PHLPLEMCJJA, COKDDOEMBCP MFKCOFBNOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x66F4200", Offset = "0x66F2A00", VA = "0x1866F4200")]
	private static HCEHMNJDCEM EJIIMGHCGEH(IAKIPPJHGDP MIJLNJMIKLF, int OFLCHOBHALO)
	{
		return default(HCEHMNJDCEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x66F3440", Offset = "0x66F1C40", VA = "0x1866F3440")]
	private void CALGMHKJKAF(int HOLJBCALDHB, Material CLECAFFDEAA, IAKIPPJHGDP MIJLNJMIKLF, [Out] Texture2D CMEJLLELJIE, [Out] Vector4 HEPEGHLBFEE, [Out] Texture2D EMKLBEHKODE, [Out] Texture2D HEIMPLAEBLH, [Out] Texture2D NJMCBIMGKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x66FA3C0", Offset = "0x66F8BC0", VA = "0x1866FA3C0")]
	private void NGAEBKKMKCD(int HOLJBCALDHB, Material CLECAFFDEAA, IAKIPPJHGDP MIJLNJMIKLF, [Out] Color LGDHEMGKLBE, [Out] Color CPIMFMACGAI, [Out] Color PJABGEKPLCM, [Out] Color NNMKBAEPPEM, [Out] Color OJNAJOLEJHH, [Out] Color JBJMPAHMEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x66FA070", Offset = "0x66F8870", VA = "0x1866FA070")]
	private bool NBKLEKBKKNP(Material CLECAFFDEAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x66F9FF0", Offset = "0x66F87F0", VA = "0x1866F9FF0")]
	private static Material MPBABKIEMKA(int HOLJBCALDHB, JEJKHLEBCLO MIJLNJMIKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x66F7FE0", Offset = "0x66F67E0", VA = "0x1866F7FE0")]
	private static GABOPADGKJJ HKEGIDEGCBK(IAKIPPJHGDP MIJLNJMIKLF, int OFLCHOBHALO)
	{
		return default(GABOPADGKJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x66FC750", Offset = "0x66FAF50", VA = "0x1866FC750")]
	private static void ONCPGKOLHJE(Dictionary<string, List<FJJLCODEKMD>> DJIDBBHKILF, IAKIPPJHGDP JIGABOHBFGA, Material OBOANGAOPGJ, HCEHMNJDCEM OGHBHDDMEAI, GABOPADGKJJ OLPNKBGAKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x66F3CB0", Offset = "0x66F24B0", VA = "0x1866F3CB0")]
	private static SkinnedMeshRenderer DFJFIBKNBLB(Transform MMIAPCKNLIA, Transform OJIOLMELLNO, SkinnedMeshRenderer[] ENBDMIFLMCH, int IBPIKFEDDCD, PDFHFOMMFMC CKKMCLHJEBN, bool GBCNBKBCGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x66F7DA0", Offset = "0x66F65A0", VA = "0x1866F7DA0")]
	private void HEPHIJOBBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x66F9A30", Offset = "0x66F8230", VA = "0x1866F9A30")]
	private void LOAIKAOALGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x66F9BB0", Offset = "0x66F83B0", VA = "0x1866F9BB0")]
	private static void MMMFBHPHAOC(Dictionary<FJJLCODEKMD, Material> NHGIKEJIPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x66F68C0", Offset = "0x66F50C0", VA = "0x1866F68C0")]
	private static void FJFMFDPDIJI(Dictionary<Renderer, FLJFHNFMGOK> JMDJDJICFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x66F7C80", Offset = "0x66F6480", VA = "0x1866F7C80")]
	private void HENKIMMDJBC(SkinnedMeshRenderer[] ENBDMIFLMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x66F6C70", Offset = "0x66F5470", VA = "0x1866F6C70")]
	private void GBLCABDLOAJ(SkinnedMeshRenderer OAKHCOFCLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x66F3A10", Offset = "0x66F2210", VA = "0x1866F3A10")]
	private void COOHGPDKKKK(List<FAIOIOPAKIG> GOMGHCEOGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x66F98B0", Offset = "0x66F80B0", VA = "0x1866F98B0")]
	private void LMIFFAJCMPD(Dictionary<string, MJMNDKPKIPJ<Texture2D>> DJIDBBHKILF, bool FHKNBEHMDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x66F6A20", Offset = "0x66F5220", VA = "0x1866F6A20")]
	private void FLLEOOPKCOF(Dictionary<string, List<FJJLCODEKMD>> DJIDBBHKILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x66F8F80", Offset = "0x66F7780", VA = "0x1866F8F80")]
	private void KGCKMPHPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x66F9330", Offset = "0x66F7B30", VA = "0x1866F9330")]
	private void KJCHNKOPDEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x66F1D90", Offset = "0x66F0590", VA = "0x1866F1D90")]
	private void AILFGCMAIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x66F1AA0", Offset = "0x66F02A0", VA = "0x1866F1AA0")]
	private void ACEKKEGNBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x66F9B20", Offset = "0x66F8320", VA = "0x1866F9B20")]
	private void MGNONGIOMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x66F85A0", Offset = "0x66F6DA0", VA = "0x1866F85A0")]
	private void IAAFNNHJKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x66F9D10", Offset = "0x66F8510", VA = "0x1866F9D10")]
	private void MNICHIMENPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x66F87D0", Offset = "0x66F6FD0", VA = "0x1866F87D0")]
	private void JAPHGAIJNFC(bool PGLDEANAFGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x66F32F0", Offset = "0x66F1AF0", VA = "0x1866F32F0")]
	private void BKDCJLDNIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x66F9810", Offset = "0x66F8010", VA = "0x1866F9810")]
	private void LLPFOFAPBIA(bool PGLDEANAFGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x66F77E0", Offset = "0x66F5FE0", VA = "0x1866F77E0")]
	private void GOKAOLDMBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x66F28B0", Offset = "0x66F10B0", VA = "0x1866F28B0")]
	private void ANMCEMCPMLF(Material PBIFKLGLNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x66F8160", Offset = "0x66F6960", VA = "0x1866F8160")]
	private void HLNCBBJCOOF(Material PBIFKLGLNNP, Color CPIMFMACGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x66F3920", Offset = "0x66F2120", VA = "0x1866F3920")]
	private void CNCPLNHOJGJ(Material PBIFKLGLNNP, Color PJABGEKPLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x66F94C0", Offset = "0x66F7CC0", VA = "0x1866F94C0")]
	private void LHEIAPFKJEJ(Material PBIFKLGLNNP, Color LGDHEMGKLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x66FB000", Offset = "0x66F9800", VA = "0x1866FB000")]
	private void OHDALEFKHBN(Material PBIFKLGLNNP, Texture2D JHIAEMLCNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x66F9A40", Offset = "0x66F8240", VA = "0x1866F9A40")]
	private void MDAEIMMMNKI(Material PBIFKLGLNNP, Texture IGCHLBBAGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x66FCBB0", Offset = "0x66FB3B0", VA = "0x1866FCBB0")]
	private void PBHLNOJPJAF(Action<FLJFHNFMGOK> IIHKJICAPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x66FCA30", Offset = "0x66FB230", VA = "0x1866FCA30")]
	private void ONDAEJKFGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x66FAAA0", Offset = "0x66F92A0", VA = "0x1866FAAA0")]
	private void NOHLCFHHJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x66F2D00", Offset = "0x66F1500", VA = "0x1866F2D00")]
	private PEJDBLFKJJN BIDLGICECDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x66F73B0", Offset = "0x66F5BB0", VA = "0x1866F73B0")]
	private void GKDHONCCPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x66F8A10", Offset = "0x66F7210", VA = "0x1866F8A10")]
	public void JFJJOEJKGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x66FA9E0", Offset = "0x66F91E0", VA = "0x1866FA9E0")]
	private void NLPANEEKELD(Vector3 KIBDPDIBGMM, Quaternion PHONLGLKLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x66F6E10", Offset = "0x66F5610", VA = "0x1866F6E10")]
	private void GELFEFJGBCL(List<IAKIPPJHGDP> JEPBPDKNMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x66F49A0", Offset = "0x66F31A0", VA = "0x1866F49A0")]
	public void FBCBAOMOMEB(NCNMBJAGJBN OAFHEIMGCBE, bool DOHMEDIEIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x66F4320", Offset = "0x66F2B20", VA = "0x1866F4320")]
	public void FBCBAOMOMEB(NCNMBJAGJBN OAFHEIMGCBE, AnchorParamsRestrictions KMIAJODEDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9B7F20", Offset = "0x9B6720", VA = "0x1809B7F20")]
	private static void PGJCLHAHIGI(FitMeshHemisphere AHFAMLBBHIM, Transform LLMCADBJEJH, NCNMBJAGJBN OAFHEIMGCBE, AnchorParamsRestrictions EHHFMDIBAPE, [Out] Vector3 KKDCNJKFOII, [Out] Quaternion HGJODEDMNMO, [Out] NCNMBJAGJBN NIEBHOBGCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x66F90E0", Offset = "0x66F78E0", VA = "0x1866F90E0")]
	public void KGJJKHCALGC(Vector2 IPLPGLCDFCP, Vector3 COJLFJBMLEC, Vector3 KECHFLJHCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x66F8870", Offset = "0x66F7070", VA = "0x1866F8870")]
	private void JBDBNJJOOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x66F7760", Offset = "0x66F5F60", VA = "0x1866F7760")]
	private void GKKEIMPCEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x66F1D00", Offset = "0x66F0500", VA = "0x1866F1D00")]
	[CompilerGenerated]
	private void AHAKEJIHLPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x66F4140", Offset = "0x66F2940", VA = "0x1866F4140")]
	[CompilerGenerated]
	private void DJELMEGDKJO(FLJFHNFMGOK IPOLLNCDMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x66F6A70", Offset = "0x66F5270", VA = "0x1866F6A70")]
	[CompilerGenerated]
	private void FNPBFPJNMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x66F3900", Offset = "0x66F2100", VA = "0x1866F3900")]
	[CompilerGenerated]
	private void CMPPHBBNHJO(FLJFHNFMGOK IPOLLNCDMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x66F3C20", Offset = "0x66F2420", VA = "0x1866F3C20")]
	[CompilerGenerated]
	private void DANJEOJCCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x66F8EE0", Offset = "0x66F76E0", VA = "0x1866F8EE0")]
	[CompilerGenerated]
	private void KBNKFBGHNNC(FLJFHNFMGOK IPOLLNCDMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x66F4170", Offset = "0x66F2970", VA = "0x1866F4170")]
	[CompilerGenerated]
	private void EENMJAABOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x66F89E0", Offset = "0x66F71E0", VA = "0x1866F89E0")]
	[CompilerGenerated]
	private void JELKKGGFKJB(FLJFHNFMGOK IPOLLNCDMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x66F2C70", Offset = "0x66F1470", VA = "0x1866F2C70")]
	[CompilerGenerated]
	private void BECFJOBAIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x66F3410", Offset = "0x66F1C10", VA = "0x1866F3410")]
	[CompilerGenerated]
	private void BNKMBOLOKJK(FLJFHNFMGOK IPOLLNCDMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x66F8250", Offset = "0x66F6A50", VA = "0x1866F8250")]
	[CompilerGenerated]
	private void HPAIGHJCCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x66F8780", Offset = "0x66F6F80", VA = "0x1866F8780")]
	[CompilerGenerated]
	private void IIIOFJNFCDF(FLJFHNFMGOK IPOLLNCDMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x66F86F0", Offset = "0x66F6EF0", VA = "0x1866F86F0")]
	[CompilerGenerated]
	private void IEENIMHBGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x66F3BF0", Offset = "0x66F23F0", VA = "0x1866F3BF0")]
	[CompilerGenerated]
	private void DAGIMFMENFE(FLJFHNFMGOK IPOLLNCDMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x66F6D90", Offset = "0x66F5590", VA = "0x1866F6D90")]
	[CompilerGenerated]
	private void GEGKEGPHPAG(KeyValuePair<string, MJMNDKPKIPJ<Texture2D>> LDIAAJCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x66F92A0", Offset = "0x66F7AA0", VA = "0x1866F92A0")]
	[CompilerGenerated]
	private void KHODMPOGDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x66F2C10", Offset = "0x66F1410", VA = "0x1866F2C10")]
	[CompilerGenerated]
	private void APAFACNGHCM(FLJFHNFMGOK IPOLLNCDMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x66F80D0", Offset = "0x66F68D0", VA = "0x1866F80D0")]
	[CompilerGenerated]
	private void HLHKLIJKBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x66F2C40", Offset = "0x66F1440", VA = "0x1866F2C40")]
	[CompilerGenerated]
	private void BAJJIPLFDHH(FLJFHNFMGOK IPOLLNCDMPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JNLADMGFMMH : PNAOPNKBNGF
{
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int JJANNPHLILA;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int KOAPJGHPNGC;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int KOGLMBAHKEJ;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int KEMDDMILJMP;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int IOJGEDPFKLN;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int MJKELNDEADP;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int AKCBOIBAFFO;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int GABPINAJIPF;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int FABGMLNCIKG;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int DJMMGEKBBIE;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int OHEPDKJJBHO;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int OKGFKEJHCFG;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int OMDFLBDJGBE;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int IGJFHJEPNMM;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int NMDAEMOFFAK;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int JNNPBNMFJEH;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int JCGPCBHFFBC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int IBOKMIEIGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private Transform KKHPKAFBAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private Transform LMPECHNIFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Transform GOBPDKPBBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Transform MMNGHHOEJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Transform EGCPMMEBLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform PHPDFLGEKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform LHAEJHJONEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private GHHKPKIMDDB BAPOHANEIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private MaterialPropertyBlock MEFLEJDDPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private SkinnedMeshRenderer[] GBCPJIKLGLD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private MaterialPropertyBlock DBNNGJPDKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x66FF100", Offset = "0x66FD900", VA = "0x1866FF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x66FEF70", Offset = "0x66FD770", VA = "0x1866FEF70", Slot = "6")]
	public void DIHNAABPOCM(GHHKPKIMDDB OOJGOAFIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x66FF070", Offset = "0x66FD870", VA = "0x1866FF070", Slot = "7")]
	public void HANFKFOJABB(MBDCLDGGKAH NDOLEHPDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x66FF550", Offset = "0x66FDD50", VA = "0x1866FF550", Slot = "4")]
	public void MJPNPNHAOIH(FLNINPFGHMC JGNCNNDOMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x66FF0A0", Offset = "0x66FD8A0", VA = "0x1866FF0A0")]
	private Vector2 HMHHAOKHHCL(Vector2 GCMOEPMOODN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x66FF960", Offset = "0x66FE160", VA = "0x1866FF960", Slot = "5")]
	public void NDEGHDLHJEB(IAAAJAOKAHI NDOLEHPDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x66FF180", Offset = "0x66FD980", VA = "0x1866FF180")]
	private void JCEINCECIKO(IAAAJAOKAHI HEBGDFJHJFC, HEEGAGAGPHN DNCPGJKPFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x66FEE90", Offset = "0x66FD690", VA = "0x1866FEE90")]
	private void ABHEAOJMMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6700D70", Offset = "0x66FF570", VA = "0x186700D70")]
	public JNLADMGFMMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x66FF4C0", Offset = "0x66FDCC0", VA = "0x1866FF4C0")]
	[CompilerGenerated]
	internal static (float, float) JGGLKHEJOAM(float EEOOJLJOBMP)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x66FF030", Offset = "0x66FD830", VA = "0x1866FF030")]
	[CompilerGenerated]
	internal static Vector4 DPACOMFIHLF(Vector2 GBKEBGLIOFD, Vector2 KEONANJCBKH)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FLJFHNFMGOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private MaterialPropertyBlock BMPFNDCMBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Color? PLHAPHEMENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Color? LMPLPLLBJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public Color? ALCEKLIPCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Color? GALAFCCILAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public Color NMBOBEFJAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Color KDDMMMABIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Color KAOAGPOFJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Texture2D APEBBGDKAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Texture2D HNCBFAIBBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private Dictionary<FJJLCODEKMD, int> GAFKCNKDFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private HCEHMNJDCEM[] AJCEBIFIADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private GABOPADGKJJ[] FFBLGMFPDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Vector4[] HGBDLDBFCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Vector4[] MFPJDOJMBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Vector4[] MHCPNOEGMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Vector4[] BBFBBHEJPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public Vector4[] GGPAEGENCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Vector4[] DCKFHGIMAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private List<Texture2D> GAJNPIPMPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Vector4[] GNKANPFOIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private List<Texture2D> HMHJODDLMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private float[] GMGLOKHLPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Vector4[] LIAPOOHNCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private float[] HOBHBDBDLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public float[] AEPJCODMLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> HJNFHFHKHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private float[] KHBOCECMMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private List<Texture2D> AGPEKBHPGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Vector4[] IIKOLDKGIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private float[] FFMGCJGGLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private Vector4[] NJONIFPGMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float[] GFJFGKDFIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Texture2DArray JDDABDGHPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Texture2DArray NGHGNNPDAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Texture2DArray BPBKMJDHFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Texture2DArray BNDOEKFEOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private bool CEBPJPGKIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private int FAJNOADHMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Vector2? BKMELACJOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private TextureFormat ILOJGCNCNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private Vector2? EEANMDLFOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private TextureFormat CPAPFNFGFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private Vector2? JGBONDHMGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private TextureFormat IGFAEFLILJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private Vector2? FEBAJOIJCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private TextureFormat COLJBEAFBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool NIKEPOPPBPF;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int BEFMBOKAMAO;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int EHNJHAMMGBD;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int JECOBENILDB;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int FPIONJBFJBE;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int ONFCIFHDCOL;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int ECDFKCACCJK;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int PHNFBKJFLCN;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int BMGOMHEPIEE;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int OPBMPHFPNBB;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int HGCAAENJPCL;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int DMGCAJPLNKF;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int JPMNIKFOHFI;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int EEHGIIDGFDH;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int LICLHHLBDGC;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int NPDGENIPIAI;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int CPOEDNBIFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int DPOPMJBNCCE;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int LFNNIIBMMFB;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int PJHADHKGKFH;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int KAJKOFOMNJM;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x670BE30", Offset = "0x670A630", VA = "0x18670BE30")]
	private FLJFHNFMGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x670BD70", Offset = "0x670A570", VA = "0x18670BD70")]
	public FLJFHNFMGOK(Color HANJLNDFIDG, Color DIDKOBPAKMM, Color KKDPCJKBEHM, Color? NGEBFBANJEH, Color? GGALFJIMOGB, Color? OHHKMELAEBO, Texture2D FPPMNIHECPB, Texture2D GHBNJLJIICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x670B5E0", Offset = "0x6709DE0", VA = "0x18670B5E0")]
	internal int JBEGIFJLINK(Material DPODMHFDAEP, HCEHMNJDCEM DEABCLPANPN, GABOPADGKJJ PHLPLEMCJJA, COKDDOEMBCP MFKCOFBNOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x670B550", Offset = "0x6709D50", VA = "0x18670B550")]
	private int JBEGIFJLINK(FJJLCODEKMD JOEHGGMHBAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6709760", Offset = "0x6707F60", VA = "0x186709760")]
	internal int DFGBAINNKKH(Material DPODMHFDAEP, Color LGDHEMGKLBE, Color CPIMFMACGAI, Color PJABGEKPLCM, Color NNMKBAEPPEM, Color OJNAJOLEJHH, Texture2D AMGFHPFKJOC, Vector4 PLAHDBICAAI, Texture2D EAJIFNIKLEP, Vector4 JAAIIKOFNHC, float DIMMCOJKNIG, float ILCJJNDEMNN, Texture2D OGJLLFJGNPG, Vector4 MEOBMCKDIDP, float DCJDPCELCAJ, Texture2D PNCMPOIGIHA, Color JBJMPAHMEGG, Vector4 FODEPDGNLGC, HCEHMNJDCEM DEABCLPANPN, GABOPADGKJJ PHLPLEMCJJA, COKDDOEMBCP MFKCOFBNOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x670B190", Offset = "0x6709990", VA = "0x18670B190")]
	private void GJHACBFOFAC(List<Texture2D> GAJNPIPMPKC, [Out] Texture2DArray JAADNLEAFDJ, [Out] Texture2DArray FKCPHAFKBAI, [Out] Texture2DArray DAFHCLPIFFN, [Out] Texture2DArray JPHCGAPHDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x670B350", Offset = "0x6709B50", VA = "0x18670B350")]
	public void GLDDLODFPNJ(Shader KJIAKHGOBBI, Renderer GEPBJGBCLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x670A470", Offset = "0x6708C70", VA = "0x18670A470")]
	private void FHBAMALBOMP(Shader KJIAKHGOBBI, Renderer GEPBJGBCLCL, int ALIKOKAKAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x670B6D0", Offset = "0x6709ED0", VA = "0x18670B6D0")]
	private Color LFMCICHFADG(Color ECAGGKBFHFF, HCEHMNJDCEM OGHBHDDMEAI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x670B8D0", Offset = "0x670A0D0", VA = "0x18670B8D0")]
	private Color PKHMNMGBOHJ(Color LDCEHLNKHPO, HCEHMNJDCEM OGHBHDDMEAI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x670A370", Offset = "0x6708B70", VA = "0x18670A370")]
	private bool ELONFHHKLKI(Texture2D NDDONKFLDAA, GABOPADGKJJ OLPNKBGAKIC, [Out] Texture2D EBENOKEIGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x670B4A0", Offset = "0x6709CA0", VA = "0x18670B4A0")]
	private void HHHJFOFGJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x670A330", Offset = "0x6708B30", VA = "0x18670A330", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private AMCKELCMONE? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public NPEBPDPBEAI CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x67046F0", Offset = "0x6702EF0", VA = "0x1867046F0")]
			get
			{
				return default(NPEBPDPBEAI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AMCKELCMONE MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6704740", Offset = "0x6702F40", VA = "0x186704740")]
			get
			{
				return default(AMCKELCMONE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x843F90", Offset = "0x842790", VA = "0x180843F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8513B0", Offset = "0x84FBB0", VA = "0x1808513B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6704540", Offset = "0x6702D40", VA = "0x186704540")]
		public Material[] MDCOOAJFGOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6704380", Offset = "0x6702B80", VA = "0x186704380")]
		public static void IHJKDNEENFH(AvatarItemMaterial MJHOJMNBNEN, Material CLECAFFDEAA, int HOLJBCALDHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6704630", Offset = "0x6702E30", VA = "0x186704630")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BFNFAOFCCLN]
public struct ODBPJOLDDLO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[ReadOnly]
	public EKLPLPICHDF JDCPHFCFHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	[ReadOnly]
	public int PCANDBFCJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public CNLAKBENFCP EJBGLMCEOGM;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x670DEF0", Offset = "0x670C6F0", VA = "0x18670DEF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[BFNFAOFCCLN]
public struct CNLAKBENFCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public NativeArray<Vector3> OMKDECPMCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeArray<Vector3> OENPFFJCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public NativeArray<Vector4> OMHPGEPCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public NativeArray<Vector2> JOMHFGPKAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public NativeArray<Vector2> JONBMJEALAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Vector2> IDPENAHEJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<Vector2> BLCAFGLBGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Color> ELBFKCLDIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<int> HEEIJFBDLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<int> CJAKEEODJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private NativeArray<int> FOFGGLDPHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private NativeArray<int> FNGHNPIJCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<int> KLCABEKIBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<int> HAKDHJAPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> NGCIOADIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<BoneWeight> IHKGBIDFBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private NativeArray<int> EKJGIMBPPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private bool GDHNFCOJALG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int EBNOEEOOOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6705B40", Offset = "0x6704340", VA = "0x186705B40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6705710", Offset = "0x6703F10", VA = "0x186705710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NHGGBCACNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6705FF0", Offset = "0x67047F0", VA = "0x186705FF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6706030", Offset = "0x6704830", VA = "0x186706030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int CILLHOCKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6706000", Offset = "0x6704800", VA = "0x186706000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6705720", Offset = "0x6703F20", VA = "0x186705720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6706160", Offset = "0x6704960", VA = "0x186706160")]
	public CNLAKBENFCP(int FACEDKAEAJE, int EIMHNKJDFJK, int HKKBOHJKBLB, int OAKDFANNCAP, Allocator KCJKALFMGMC, int NPBFNDMLEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6706040", Offset = "0x6704840", VA = "0x186706040")]
	public void MPHKMHEFJFD(int JBDLDJOINOF, Vector3 BLNBBLFAAGC, Vector3 FEGGJAIMAGC, Vector4 AFCJJMLHKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6705D00", Offset = "0x6704500", VA = "0x186705D00")]
	public void FIMPKODIMGP(int JBDLDJOINOF, BoneWeight CBANBGMGEJA, NativeSlice<byte> NPFMKPLKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6706010", Offset = "0x6704810", VA = "0x186706010")]
	public Color LFLPHFBIBGD(int JBDLDJOINOF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x67060B0", Offset = "0x67048B0", VA = "0x1867060B0")]
	public void NIGALAAJCJJ(int JBDLDJOINOF, Color FFEGACHBGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6705ED0", Offset = "0x67046D0", VA = "0x186705ED0")]
	public void HHLAJJJHIPL(byte KHPFGABHAOE, int JBDLDJOINOF, Vector2 AOMFBAOLGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6705B30", Offset = "0x6704330", VA = "0x186705B30")]
	public void DBLHEDKDDPJ(int JBDLDJOINOF, int EANKJDHJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6705EA0", Offset = "0x67046A0", VA = "0x186705EA0")]
	public bool GDMIMGDPPCA(int KHPFGABHAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6705F20", Offset = "0x6704720", VA = "0x186705F20")]
	public void JBNBLJLJAEH(int OEKIGHEKNMJ, int MFLLOPOPNNG, int IDGMEKAEIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6705730", Offset = "0x6703F30", VA = "0x186705730")]
	public int[] BMHJEBOKFIF(int OEKIGHEKNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x67060D0", Offset = "0x67048D0", VA = "0x1867060D0")]
	private NativeSlice<int> OIINOGBNBPK(int OEKIGHEKNMJ)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6705B50", Offset = "0x6704350", VA = "0x186705B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x67057E0", Offset = "0x6703FE0", VA = "0x1867057E0")]
	public Mesh BNJPGPIDHDA([Optional] string LHKFGAMPHBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NativeContainer]
[DefaultMember("Item")]
[BFNFAOFCCLN]
public struct EKLPLPICHDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<Vector3> OMKDECPMCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<Vector3> OENPFFJCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Vector4> OMHPGEPCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector2> JOMHFGPKAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector2> JONBMJEALAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Vector2> IDPENAHEJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector2> BLCAFGLBGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Color> ELBFKCLDIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<int> CNNDJEOMOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<int> GFPMNHIKLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<int> ACLBNOFJFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> LCLLNNKCJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<bool> FPAKKHGLNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<int> JCHCLNANBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<int> FMIPJEICJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<BoneWeight> PDPMJKHGEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private NativeArray<Matrix4x4> POPCOHHNBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private NativeArray<int> OBLAPOOFMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<byte> MDAKMLCGEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private NativeArray<int> MPLHJAHGHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private NativeArray<int> ENGLKNHFNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<sbyte> ACPONNFDECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<byte> CDLPAMEOACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> EABFLLOPAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private bool GDHNFCOJALG;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int LIGADHAIPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1F5C7A0", Offset = "0x1F5AFA0", VA = "0x181F5C7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KCEOECPEGLP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xFC6860", Offset = "0xFC5060", VA = "0x180FC6860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int GKGJNGLCHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6706E10", Offset = "0x6705610", VA = "0x186706E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int IAOOGPLECKO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6706E60", Offset = "0x6705660", VA = "0x186706E60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6706E50", Offset = "0x6705650", VA = "0x186706E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int EBNOEEOOOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x67065B0", Offset = "0x6704DB0", VA = "0x1867065B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x67065A0", Offset = "0x6704DA0", VA = "0x1867065A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OHEBEJPCDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6706E40", Offset = "0x6705640", VA = "0x186706E40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6706E70", Offset = "0x6705670", VA = "0x186706E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public FDJPGHHMBBM CJLHBEBPNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6706EB0", Offset = "0x67056B0", VA = "0x186706EB0")]
		get
		{
			return default(FDJPGHHMBBM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6706EA0", Offset = "0x67056A0", VA = "0x186706EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public byte FIGEMIELLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6706E80", Offset = "0x6705680", VA = "0x186706E80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6706E90", Offset = "0x6705690", VA = "0x186706E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BHEBECKBDGP EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x67068F0", Offset = "0x67050F0", VA = "0x1867068F0")]
		get
		{
			return default(BHEBECKBDGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6706EC0", Offset = "0x67056C0", VA = "0x186706EC0")]
	public EKLPLPICHDF(IList<Mesh> KNGALABNAMG, IList<Matrix4x4> IHKHNBOOKKI, IList<bool> FPAKKHGLNBF, byte MPEOLLOMHAN, IList<byte[]> DBEDKCNMHNN, IList<int> FDFEOKBFILK, IList<bool> DJHDOGKACGB, IList<int> JCHCLNANBFF, IList<int> FIELINDHFCC, IList<int> PECOIKGCKBB, Allocator KCJKALFMGMC, FDJPGHHMBBM JFELHCDOMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6706820", Offset = "0x6705020", VA = "0x186706820")]
	public CNLAKBENFCP EAMNMJIOJDE(Allocator KCJKALFMGMC)
	{
		return default(CNLAKBENFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x67065C0", Offset = "0x6704DC0", VA = "0x1867065C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BFNFAOFCCLN]
public class LFEMGLKKDJF : IMPAIKGGMFE
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x670D590", Offset = "0x670BD90", VA = "0x18670D590")]
	public EKLPLPICHDF LIGLOOHIIAL()
	{
		return default(EKLPLPICHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x66EC830", Offset = "0x66EB030", VA = "0x1866EC830")]
	public LFEMGLKKDJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BHEBECKBDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeSlice<Vector3> OMKDECPMCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeSlice<Vector3> OENPFFJCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeSlice<Vector4> OMHPGEPCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeSlice<Vector2> JOMHFGPKAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeSlice<Vector2> JONBMJEALAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeSlice<Vector2> IDPENAHEJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<Vector2> BLCAFGLBGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Color> ELBFKCLDIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<int> KGLLBGHCOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<int> LCLLNNKCJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<BoneWeight> PDPMJKHGEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<byte> FPKNBIMFLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int FCCEEAMNFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public Matrix4x4 IPEIEEPNEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public int CBIDKDEMOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<byte> NPFMKPLKFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public bool ACHEACMAGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int CINIMBFPFEL;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct FJJLCODEKMD : IEquatable<FJJLCODEKMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	internal readonly Material OIIHCFBIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	internal readonly HCEHMNJDCEM GOGCBLKDCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	internal readonly GABOPADGKJJ OKLKBKCFGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	internal readonly COKDDOEMBCP JAPGDKCLPNB;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9D2970", Offset = "0x9D1170", VA = "0x1809D2970")]
	public FJJLCODEKMD(Material CLECAFFDEAA, HCEHMNJDCEM DEABCLPANPN, GABOPADGKJJ PHLPLEMCJJA, COKDDOEMBCP MFKCOFBNOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6708990", Offset = "0x6707190", VA = "0x186708990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x9D26C0", Offset = "0x9D0EC0", VA = "0x1809D26C0", Slot = "4")]
	public bool Equals(FJJLCODEKMD OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6708800", Offset = "0x6707000", VA = "0x186708800", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67088F0", Offset = "0x67070F0", VA = "0x1867088F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IHJOJGEDNBN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KBFHABKHKIP : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public KBFHABKHKIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9D3840", Offset = "0x9D2040", VA = "0x1809D3840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x670D540", Offset = "0x670BD40", VA = "0x18670D540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	public static void FKLPIGIIEIO(string EGNLNANJFMI, int IBPIKFEDDCD, long JKCOHIDIBOJ, long KJEJGLJIIDI, long MNOCBNMNCIL, long IHMKBGNLEFG, long FIKMHNKDGCB, long OFJEIDIPMOL, long JFHPPHDCBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x670CC70", Offset = "0x670B470", VA = "0x18670CC70")]
	public static JLAFAKOGFMB FMNJNIMPELN(JobHandle JIDJOJBLFHN, bool GNGLNBDOOCL, bool OLDMCJPDODO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x670CC00", Offset = "0x670B400", VA = "0x18670CC00")]
	[IteratorStateMachine(typeof(KBFHABKHKIP))]
	private static IEnumerator<PENLHNEFADH> EHPDGPALLKK(JobHandle PFACKKBJPID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BMBMNAMFEPG : ANIHHFPOAFF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private MOJECCFKIFI FOJNFGALJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private CFNPNADNLEC FAKICNNHLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private IRecRoomQualityConfigProvider BOHIBHHIPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private bool GDHNFCOJALG;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6704930", Offset = "0x6703130", VA = "0x186704930")]
	[ANLGLDAOJJE(ELBANFBEGNE.GameOnly)]
	private static void IOJDKJKPMEL(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5A71480", Offset = "0x5A6FC80", VA = "0x185A71480")]
	[UnityEngine.Scripting.Preserve]
	public BMBMNAMFEPG([GNKLNMHODGG(null)] CFNPNADNLEC LOBBAGHOEIH, [GNKLNMHODGG(null)] MOJECCFKIFI BJMMIPIEPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6704A90", Offset = "0x6703290", VA = "0x186704A90")]
	private void NJCFFJIBKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6704A30", Offset = "0x6703230", VA = "0x186704A30", Slot = "4")]
	public void KDKKNCCAHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6704B00", Offset = "0x6703300", VA = "0x186704B00", Slot = "5")]
	public MJMNDKPKIPJ<Texture2D> PDFJCGMDDFN(ENBCFCAPAEH HOPKDJJJEMJ, [Optional] MGCPAFPOIGG EKJGIMBPPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6704800", Offset = "0x6703000", VA = "0x186704800")]
	private uint EPHAGPAGKPI(ENBCFCAPAEH HOPKDJJJEMJ, MGCPAFPOIGG EKJGIMBPPBA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface INEILAMCNIN
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBIGDMPJGJN(Mesh NCHKGMDMAMN, Matrix4x4 CHNOCEINAMF, byte[] NPFMKPLKFPO, bool NAHPKGNMAEN = false, AIEGLCJJPJP.EDICGNCOMOB BJAPNHEICNI = (AIEGLCJJPJP.EDICGNCOMOB)0, int JCHCLNANBFF = -1, bool FPAKKHGLNBF = false);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBBKIONMPGC(Allocator KCJKALFMGMC, FDJPGHHMBBM JFELHCDOMDE, byte MPEOLLOMHAN, [Optional] IList<int> FIELINDHFCC, [Optional] IList<int> LNEJIKDDCIK);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct IILJNCAFAJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public readonly GameObject BDFGICJPENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly AvatarItemMaterial NEBGGOGPAHH;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
	public IILJNCAFAJH(GameObject BDFGICJPENK, AvatarItemMaterial NEBGGOGPAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x670CDC0", Offset = "0x670B5C0", VA = "0x18670CDC0")]
	public void LEOFIDPLLMO(Material CLECAFFDEAA, int HOLJBCALDHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CGHOLMGMDPH : IEPJLDNFPDO<Task<(GameObject, AvatarItemMaterial)>, IILJNCAFAJH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct JMNIKKDJJGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x670CFD0", Offset = "0x670B7D0", VA = "0x18670CFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x670D4D0", Offset = "0x670BCD0", VA = "0x18670D4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private MJMNDKPKIPJ<GameObject> FAAGHAAHAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private MJMNDKPKIPJ<AvatarItemMaterial> LDDEEHGJFNL;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6705680", Offset = "0x6703E80", VA = "0x186705680")]
	private CGHOLMGMDPH(Task<(GameObject, AvatarItemMaterial)> GECIOHOBBCH, MJMNDKPKIPJ<GameObject> IELHEECBEBG, MJMNDKPKIPJ<AvatarItemMaterial> BIAGAIGDMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6705020", Offset = "0x6703820", VA = "0x186705020")]
	public static CGHOLMGMDPH DLNFHNOLCMJ(AssetReference IIHBLEONNNF, [Optional] AssetReference FJNJOMDGOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x67055E0", Offset = "0x6703DE0", VA = "0x1867055E0", Slot = "11")]
	protected override IILJNCAFAJH OENINFANCFD(Task<(GameObject, AvatarItemMaterial)> JNLJBGECHEJ)
	{
		return default(IILJNCAFAJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6705560", Offset = "0x6703D60", VA = "0x186705560", Slot = "12")]
	protected override void LDFLPKEEIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6705430", Offset = "0x6703C30", VA = "0x186705430")]
	[AsyncStateMachine(typeof(JMNIKKDJJGJ))]
	private static Task<(GameObject, AvatarItemMaterial)> KACHJKEBPMH(Task<GameObject> CMJECABLNME, Task<AvatarItemMaterial> AGHKCICKPGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FLACFBAGKAH : IEPJLDNFPDO<Task<(Material, MaterialMapAsset)>, Material>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BOOGAOKGCJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public Material mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public MaterialEntry entry;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BOOGAOKGCJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6704FB0", Offset = "0x67037B0", VA = "0x186704FB0")]
		internal object LCJEGLBGCBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class MNGABAKJEMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public string shaderNameToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public BOOGAOKGCJC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MNGABAKJEMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x670DA30", Offset = "0x670C230", VA = "0x18670DA30")]
		internal object HNNKABNKBIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x670DC90", Offset = "0x670C490", VA = "0x18670DC90")]
		internal object HPGALKGJILK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct GJJLPONLDPG<T1, T2> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder<(T1, T2)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private T1 <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter<T1> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private TaskAwaiter<T2> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3BDEE70", Offset = "0x3BDD670", VA = "0x183BDEE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3BDF540", Offset = "0x3BDDD40", VA = "0x183BDF540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private MJMNDKPKIPJ<Material> NANLLCJHLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private MJMNDKPKIPJ<MaterialMapAsset> GEKAIOFGLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private bool CDIIEDJEDKF;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6708BC0", Offset = "0x67073C0", VA = "0x186708BC0")]
	public static FLACFBAGKAH DGEDDICCIJG(AssetReference KEOCCBAEOCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6709410", Offset = "0x6707C10", VA = "0x186709410")]
	private static MJMNDKPKIPJ<MaterialMapAsset> OMGGGDINAAK(AssetReference KEOCCBAEOCJ, [Out] bool CDIIEDJEDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x67096D0", Offset = "0x6707ED0", VA = "0x1867096D0")]
	private FLACFBAGKAH(Task<(Material, MaterialMapAsset)> GECIOHOBBCH, MJMNDKPKIPJ<Material> NANLLCJHLFE, MJMNDKPKIPJ<MaterialMapAsset> GLANACNDKEC, bool CDIIEDJEDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6709230", Offset = "0x6707A30", VA = "0x186709230", Slot = "11")]
	protected override Material OENINFANCFD(Task<(Material, MaterialMapAsset)> JNLJBGECHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6708E60", Offset = "0x6707660", VA = "0x186708E60")]
	private void NJHFKADIABM(Material LFAGPHMBIPK, MaterialMapAsset DJIDBBHKILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6708E00", Offset = "0x6707600", VA = "0x186708E00", Slot = "12")]
	protected override void LDFLPKEEIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2A77450", Offset = "0x2A75C50", VA = "0x182A77450")]
	[AsyncStateMachine(typeof(GJJLPONLDPG<, >))]
	private static Task<(T1, T2)> LCJJAAOAIBG<T1, T2>(Task<T1> OFKGJIGCMFG, Task<T2> HBODHCNKLJM)
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
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x670EE00", Offset = "0x670D600", VA = "0x18670EE00")]
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
		private struct MHIOGOOOFEF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public AsyncTaskMethodBuilder<APKNNJNMOCP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private TaskAwaiter<APKNNJNMOCP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x670D680", Offset = "0x670BE80", VA = "0x18670D680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x670D9C0", Offset = "0x670C1C0", VA = "0x18670D9C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private Dictionary<CFAGBELJJDL, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private Dictionary<CFAGBELJJDL, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private Dictionary<CFAGBELJJDL, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private Dictionary<CFAGBELJJDL, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private readonly Dictionary<CFAGBELJJDL, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private APKNNJNMOCP _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x670CBD0", Offset = "0x670B3D0", VA = "0x18670CBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x670C320", Offset = "0x670AB20", VA = "0x18670C320")]
		public APKNNJNMOCP EONBNCIKHBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x670C740", Offset = "0x670AF40", VA = "0x18670C740")]
		[AsyncStateMachine(typeof(MHIOGOOOFEF))]
		public Task<APKNNJNMOCP> JKPCJANIFMG(int KOJCIBGBFNF, int PMGFCCHOLNB, int PHADGOANHLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x670C870", Offset = "0x670B070", VA = "0x18670C870")]
		public NoseFaceOption LIGHKJBMAOI(int HKMHCAAIGIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x670C910", Offset = "0x670B110", VA = "0x18670C910")]
		public SelectableFaceOption NDMCOIAFHLP(FaceFeatureType MMFDDGOJNCB, CFAGBELJJDL KAGBLMNDIDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x670C5A0", Offset = "0x670ADA0", VA = "0x18670C5A0")]
		public int GPNPCIALGMD(CFAGBELJJDL KAGBLMNDIDM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x670C370", Offset = "0x670AB70", VA = "0x18670C370")]
		private void GKLHKPLGFCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2A82040", Offset = "0x2A80840", VA = "0x182A82040")]
		private void ICMPHLGLABN<T>(IDictionary<CFAGBELJJDL, T> MGOJPELCHEI, IReadOnlyList<T> KKHOMMAGKFC) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x670CA90", Offset = "0x670B290", VA = "0x18670CA90")]
		public CFAGBELJJDL OOEBJONCEFM(FaceFeatureType MMFDDGOJNCB)
		{
			return default(CFAGBELJJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x670C620", Offset = "0x670AE20", VA = "0x18670C620")]
		public CFAGBELJJDL HKCPNEOGBKJ(FaceFeatureType MMFDDGOJNCB)
		{
			return default(CFAGBELJJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x670CB40", Offset = "0x670B340", VA = "0x18670CB40")]
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
