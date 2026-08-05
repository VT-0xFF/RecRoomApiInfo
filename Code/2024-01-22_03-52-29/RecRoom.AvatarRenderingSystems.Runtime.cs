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
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[LOKPKGJHMNM]
public class NJKGCNIDOCG : OJOLMKKMJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	protected readonly List<Mesh> GLOJDIJEBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly List<byte[]> EKJADIGMANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly List<Matrix4x4> LENOBBAKBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly List<int> PGAMDJELJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly List<bool> EHGDOOFDDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected Allocator AEDIBOBHPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected MCGJFBFAFOI HPJGNCLMCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected byte FPONKNHOABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected IList<int> NEJNKJFLLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected IList<int> BICFKBMKNIL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EFFF10", Offset = "0x5EFF310", VA = "0x185EFFF10", Slot = "4")]
	public void HAPNPDGECBJ(Mesh MOKLMJBIJAG, Matrix4x4 DHMHCKEGFMJ, byte[] HPBINHCPKAK, bool HGGNGGIIGOJ = false, INIJFLJBOFF.PCLLMINFBHH NFFFELCAKGN = (INIJFLJBOFF.PCLLMINFBHH)0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F00260", Offset = "0x5EFF660", VA = "0x185F00260", Slot = "5")]
	public void HDHFCDJHAPE(Allocator FHOLEANHCPH, MCGJFBFAFOI EACJFDDHMOF, byte HECJPECGIIB, [Optional] IList<int> EKEIPBAKOGF, [Optional] IList<int> AMCJMHMJINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F002A0", Offset = "0x5EFF6A0", VA = "0x185F002A0")]
	private static void LANPLHCFNNO(Mesh MOKLMJBIJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE160", Offset = "0x5EED560", VA = "0x185EEE160")]
	public NJKGCNIDOCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[LOKPKGJHMNM]
public struct ANJOFPKEHAF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[ReadOnly]
	public IGBKIMLDKJJ POOEPIJJOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[ReadOnly]
	public int CDINOHMDINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public GGFBMAHDCKG CAICGNFOHDC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA4A0", Offset = "0x5EE98A0", VA = "0x185EEA4A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[NativeContainer]
[LOKPKGJHMNM]
public struct GGFBMAHDCKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct GNFFKMNOBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Vector3 MIMOANBIALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Vector3 KELADLMJIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Vector4 HCIGGIBPMJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct JBNDGCPDIBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public half BEHDPMICNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public half FBOPCGDFJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public half CFGNKJFOMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public half MAMMFJEAKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public byte NLJCNMILBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public byte LPLGBACGCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte ONLAOGHKPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public byte GJCOPHEEBNL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CCIFCANJDFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public half4 JKOGDMNIBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public half2 JKEDABOBDLC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NNPDPBBJEAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public half4 JKOGDMNIBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public half2 JKEDABOBDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public half2 IANJGFPJOBH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct APKDKEOJNKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public half4 JKOGDMNIBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public half2 JKEDABOBDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public half2 IANJGFPJOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public half2 GGBJOILNGLK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct HDCAHFJFDOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public half4 JKOGDMNIBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half2 JKEDABOBDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half2 IANJGFPJOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half2 GGBJOILNGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half2 MIBMLIBLFJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct DFNKCPBHECC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float BEHDPMICNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public float FBOPCGDFJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public float CFGNKJFOMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float MAMMFJEAKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int NLJCNMILBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int LPLGBACGCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int ONLAOGHKPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int GJCOPHEEBNL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct LPPANPPDJNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Color JKOGDMNIBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Vector2 JKEDABOBDLC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NCMMGEBGMKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Color JKOGDMNIBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector2 JKEDABOBDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector2 IANJGFPJOBH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DDGJLBGALMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Color JKOGDMNIBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Vector2 JKEDABOBDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Vector2 IANJGFPJOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Vector2 GGBJOILNGLK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct EKCAFFKHGBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Color JKOGDMNIBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Vector2 JKEDABOBDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Vector2 IANJGFPJOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Vector2 GGBJOILNGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Vector2 MIBMLIBLFJI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HNDCHBDGKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<GNFFKMNOBLA> PFGMGKDONFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<CCIFCANJDFB> JBGIPPMGJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<NNPDPBBJEAK> LGHLCHMNFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<APKDKEOJNKJ> CPGPEFOENCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<HDCAHFJFDOP> CMDPEMMJEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<JBNDGCPDIBM> FPADLINFIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<LPPANPPDJNC> ONEPCKBJELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<NCMMGEBGMKE> NJHMJLFOJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<DDGJLBGALMM> HPIKCNKJHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<EKCAFFKHGBH> ELFBELDAGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<DFNKCPBHECC> DFHBDKCJCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<int> CBPMBMAJOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<int> BDBJBKLCIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private NativeArray<int> MDGOELLCGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NativeArray<int> MHEHKKLPCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> GHFJDGLIFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> FADHNBIIIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<int> FNIKAKLCPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<BoneWeight> IPMEKACHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> LALAKJLPIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool CNEHBJCCEPM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IJCNHGOJAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5EF06F0", Offset = "0x5EEFAF0", VA = "0x185EF06F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF8E0", Offset = "0x5EEECE0", VA = "0x185EEF8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HDNADINPPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1570", Offset = "0x5EF0970", VA = "0x185EF1570")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF8D0", Offset = "0x5EEECD0", VA = "0x185EEF8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ELBNJBMCNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF15E0", Offset = "0x5EF09E0", VA = "0x185EF15E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1560", Offset = "0x5EF0960", VA = "0x185EF1560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DHBMNEGBHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF530", Offset = "0x5EEE930", VA = "0x185EEF530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF15F0", Offset = "0x5EF09F0", VA = "0x185EF15F0")]
	public GGFBMAHDCKG(int IGCAGNGFCEC, int ILFBIIIDEED, int MIOOOANBGEH, int DCHAMAOBKDJ, Allocator FHOLEANHCPH, int KAHBMOEAAOE, NHANBNBAJOP JBPFBGEOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0DB0", Offset = "0x5EF01B0", VA = "0x185EF0DB0")]
	public void FCPPFOBCFBE(int FGBBDGJMFEH, Vector3 KEKNEOLOBCH, Vector3 LAMMHHOBAGL, Vector4 DMIDIFJGAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF5A0", Offset = "0x5EEE9A0", VA = "0x185EEF5A0")]
	public void BILBNAJCLDD(int FGBBDGJMFEH, BoneWeight OEEPKPBGIKC, NativeSlice<byte> HPBINHCPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1240", Offset = "0x5EF0640", VA = "0x185EF1240")]
	public Color GNLADNIFNAJ(int FGBBDGJMFEH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0E40", Offset = "0x5EF0240", VA = "0x185EF0E40")]
	public void GIIFKJCOPJP(int FGBBDGJMFEH, Color KGDDDEENGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0940", Offset = "0x5EEFD40", VA = "0x185EF0940")]
	public void EELICIANEBG(byte JNAGJHPGAAJ, int FGBBDGJMFEH, Vector2 KFHGLNMDHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF520", Offset = "0x5EEE920", VA = "0x185EEF520")]
	public void AEPPMNBFANK(int FGBBDGJMFEH, int KEEBFPBHMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1580", Offset = "0x5EF0980", VA = "0x185EF1580")]
	public bool MJOBPHJDPEC(int JNAGJHPGAAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0CE0", Offset = "0x5EF00E0", VA = "0x185EF0CE0")]
	public void ENKOBDKCDGN(int DGABIGGIMFC, int EIJFICIEABK, int OGHJPGGPGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0700", Offset = "0x5EEFB00", VA = "0x185EF0700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF8F0", Offset = "0x5EEECF0", VA = "0x185EEF8F0")]
	public Mesh CIABKIJJBEG([Optional] string CNMAEPOHDFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[LOKPKGJHMNM]
[DefaultMember("Item")]
[NativeContainer]
public struct IGBKIMLDKJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Mesh.MeshDataArray AEBIEGIFFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> LPEMIANJIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<int> OKFMAONEDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<BoneWeight> IPMEKACHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<Matrix4x4> NBHFNALLLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> HDKLBGJOEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<byte> MPGFKOLKGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private NativeArray<int> FJEKFCPGCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private NativeArray<int> PFLJLFMPAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<sbyte> ICFKFBABIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<byte> DIKJIAHNMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<int> GBMHNNFIDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool CNEHBJCCEPM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DOCDGKOIBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEAE0", Offset = "0x5EFDEE0", VA = "0x185EFEAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ODBNFCBBKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEA80", Offset = "0x5EFDE80", VA = "0x185EFEA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int OANCIGIOOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEB00", Offset = "0x5EFDF00", VA = "0x185EFEB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EALNNCMDKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE9B0", Offset = "0x5EFDDB0", VA = "0x185EFE9B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEAB0", Offset = "0x5EFDEB0", VA = "0x185EFEAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int IJCNHGOJAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE860", Offset = "0x5EFDC60", VA = "0x185EFE860")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE640", Offset = "0x5EFDA40", VA = "0x185EFE640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MPIGNFNKDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEA90", Offset = "0x5EFDE90", VA = "0x185EFEA90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEAC0", Offset = "0x5EFDEC0", VA = "0x185EFEAC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MCGJFBFAFOI LCDLFCBPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE9C0", Offset = "0x5EFDDC0", VA = "0x185EFE9C0")]
		get
		{
			return default(MCGJFBFAFOI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEAF0", Offset = "0x5EFDEF0", VA = "0x185EFEAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte PFOJAFPEMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEAD0", Offset = "0x5EFDED0", VA = "0x185EFEAD0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EFEAA0", Offset = "0x5EFDEA0", VA = "0x185EFEAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JICAEFOCEGN GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE650", Offset = "0x5EFDA50", VA = "0x185EFE650")]
		get
		{
			return default(JICAEFOCEGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EFEBD0", Offset = "0x5EFDFD0", VA = "0x185EFEBD0")]
	public IGBKIMLDKJJ(IList<Mesh> AEBGKENMHCH, IList<Matrix4x4> KGNPCANGBMN, byte HECJPECGIIB, IList<byte[]> EHPNKPMACMP, IList<int> BJKPACBGKAI, IList<bool> EEGCPCICEPM, IList<int> EKEIPBAKOGF, IList<int> AILLFLOPIKN, Allocator FHOLEANHCPH, MCGJFBFAFOI EACJFDDHMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EFE9D0", Offset = "0x5EFDDD0", VA = "0x185EFE9D0")]
	public GGFBMAHDCKG GGLHILCHPHJ(Allocator FHOLEANHCPH, NHANBNBAJOP JBPFBGEOFIK)
	{
		return default(GGFBMAHDCKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EFE870", Offset = "0x5EFDC70", VA = "0x185EFE870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[LOKPKGJHMNM]
public class EHHLIDFFGLL : NJKGCNIDOCG
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE090", Offset = "0x5EED490", VA = "0x185EEE090")]
	public IGBKIMLDKJJ DAEIKKJFFEO()
	{
		return default(IGBKIMLDKJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE160", Offset = "0x5EED560", VA = "0x185EEE160")]
	public EHHLIDFFGLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JICAEFOCEGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Mesh.MeshData ANCOKHPKPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public NativeSlice<BoneWeight> IPMEKACHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeSlice<byte> ANNBHKBEFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int PCHKHHIBJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Matrix4x4 CHNHAIFOHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int PBBKGEMBFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeSlice<byte> HPBINHCPKAK;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HDCKPJIIJBC : NCCJCMNKBEG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private abstract class HGHMGGBICFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly EGFGHFHFMGF EDECJEDGHLE;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual bool GMEGGJEDIBO
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual bool OGEBBPFHPML
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual INIJFLJBOFF.PCLLMINFBHH PBBKGEMBFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "6")]
			get
			{
				return default(INIJFLJBOFF.PCLLMINFBHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool HGPPLCKHFDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1273AE0", Offset = "0x1272EE0", VA = "0x181273AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool PEBFMNDDMKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5EFE5E0", Offset = "0x5EFD9E0", VA = "0x185EFE5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool IKHIJFHFLOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5EFE5C0", Offset = "0x5EFD9C0", VA = "0x185EFE5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		protected HGHMGGBICFC(EGFGHFHFMGF HCHBDBOEGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract DONEJHADFEN ONBLLDKFCNM(int[] NCDNOGDIBPK, List<KDJMNIAMELP> BJEGFDKMHEK, List<KDJMNIAMELP> JPHNINBPMBK);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract APNNODCFHDJ ECINPLHANED(uint NBPAIKKEFCG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private class FKAHGCBLNPO : HGHMGGBICFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly AvatarSkinAssetItem.IJKFKCMLPOE ILCGHDPHEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly AssetReference OHOOHMCBNNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly INIJFLJBOFF.PCLLMINFBHH JJBFLGNOLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly NNPNPEIPKPE? CLKLGLFHEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly Material[] KBOKELIFENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private SkinnedMeshRenderer[] DDAKINKJAPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private AvatarSkinAssetItem MENCBBPMLJF;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override INIJFLJBOFF.PCLLMINFBHH PBBKGEMBFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x797290", Offset = "0x796690", VA = "0x180797290", Slot = "6")]
			get
			{
				return default(INIJFLJBOFF.PCLLMINFBHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF410", Offset = "0x5EEE810", VA = "0x185EEF410")]
		public FKAHGCBLNPO(AvatarSkinAssetItem.IJKFKCMLPOE AEHCCLCACGG, AssetReference IGMNPMPHPOC, Material MEKHLNBJLGN, EGFGHFHFMGF MFAKGJABJHF, INIJFLJBOFF.PCLLMINFBHH MIPBCGJIEMJ = (INIJFLJBOFF.PCLLMINFBHH)0, [Optional] NNPNPEIPKPE? OMJJLANKBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF300", Offset = "0x5EEE700", VA = "0x185EEF300")]
		public FKAHGCBLNPO(AvatarSkinAssetItem.IJKFKCMLPOE AEHCCLCACGG, AssetReference IGMNPMPHPOC, Material MEKHLNBJLGN, INIJFLJBOFF.PCLLMINFBHH MIPBCGJIEMJ = (INIJFLJBOFF.PCLLMINFBHH)0, [Optional] NNPNPEIPKPE? OMJJLANKBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF100", Offset = "0x5EEE500", VA = "0x185EEF100", Slot = "7")]
		public override DONEJHADFEN ONBLLDKFCNM(int[] NCDNOGDIBPK, List<KDJMNIAMELP> BJEGFDKMHEK, List<KDJMNIAMELP> JPHNINBPMBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5EEED30", Offset = "0x5EEE130", VA = "0x185EEED30", Slot = "8")]
		public override APNNODCFHDJ ECINPLHANED(uint NBPAIKKEFCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF290", Offset = "0x5EEE690", VA = "0x185EEF290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEEE0", Offset = "0x5EEE2E0", VA = "0x185EEEEE0")]
		[CompilerGenerated]
		private void MHLCACENMFL(GameObject APCONDCGDJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class NKMJFFABABI : HGHMGGBICFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly ECMPBDIEDGD IPOBDOBCCKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private ILOEBLPKELJ<PGJHOFDAOBA> CBPKEDBPNCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public PGJHOFDAOBA EKKJMBGKIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private ILOEBLPKELJ<Material>[] IMCPEBNBCAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public List<Material> PAIPMBBCLCA;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool GMEGGJEDIBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool OGEBBPFHPML
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x5F00850", Offset = "0x5EFFC50", VA = "0x185F00850", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D6F0", Offset = "0x1A0CAF0", VA = "0x181A0D6F0")]
		public NKMJFFABABI(EGFGHFHFMGF HCHBDBOEGJC, ECMPBDIEDGD CJDINPFMEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5F00F00", Offset = "0x5F00300", VA = "0x185F00F00", Slot = "7")]
		public override DONEJHADFEN ONBLLDKFCNM(int[] NCDNOGDIBPK, List<KDJMNIAMELP> BJEGFDKMHEK, List<KDJMNIAMELP> JPHNINBPMBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5F004D0", Offset = "0x5EFF8D0", VA = "0x185F004D0", Slot = "8")]
		public override APNNODCFHDJ ECINPLHANED(uint NBPAIKKEFCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5F00600", Offset = "0x5EFFA00", VA = "0x185F00600")]
		public APNNODCFHDJ EHOIHNGJPCF(GameObject ODCDKFAJOFL, uint NBPAIKKEFCG, bool IOKAPIAOJLM, bool LHFCOECJFIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5F009E0", Offset = "0x5EFFDE0", VA = "0x185F009E0")]
		public static bool NFAPJPDPNOA(Renderer[] IOIOOAHKAHF, string DNEINAEEFDA, [Out] Renderer NLFCLECJBMK, [Out] Renderer OGLLGOMJCOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5F014A0", Offset = "0x5F008A0", VA = "0x185F014A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5F00D50", Offset = "0x5F00150", VA = "0x185F00D50")]
		private DLHKDALNNMM NMJKIJEMLHF(bool BOCFAADKBPP = false)
		{
			return default(DLHKDALNNMM);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5F003D0", Offset = "0x5EFF7D0", VA = "0x185F003D0")]
		private ILOEBLPKELJ<Material>[] CGCMBPCLBPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3C49F50", Offset = "0x3C49350", VA = "0x183C49F50")]
		[CompilerGenerated]
		private void BIMFMGDGILN(PGJHOFDAOBA APCONDCGDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5F008B0", Offset = "0x5EFFCB0", VA = "0x185F008B0")]
		[CompilerGenerated]
		private void LDHCFCCLMFB(ILOEBLPKELJ<Material> GOIPKNELGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5F007F0", Offset = "0x5EFFBF0", VA = "0x185F007F0")]
		[CompilerGenerated]
		private void EKFCEOHEBPN(Material APCONDCGDJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class FAKEIHBKKIH : FDOPDBKJEJA<Task<(GameObject, AvatarItemMaterial)>, PGJHOFDAOBA>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct BAFNKNJDEFM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public Task<GameObject> goTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public Task<AvatarItemMaterial> materialTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private GameObject <go>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter<AvatarItemMaterial> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5EEBE70", Offset = "0x5EEB270", VA = "0x185EEBE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5EEC370", Offset = "0x5EEB770", VA = "0x185EEC370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly ILOEBLPKELJ<GameObject> PIABELNIKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly ILOEBLPKELJ<AvatarItemMaterial> DEICHFGOKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private GameObject BANHLFMPCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private AvatarItemMaterial NINOGDEEPKF;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5EEECA0", Offset = "0x5EEE0A0", VA = "0x185EEECA0")]
		private FAKEIHBKKIH(Task<(GameObject, AvatarItemMaterial)> ADFIKOFONEM, ILOEBLPKELJ<GameObject> PPBAPFLNPAF, ILOEBLPKELJ<AvatarItemMaterial> BBIFMDHJBIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE670", Offset = "0x5EEDA70", VA = "0x185EEE670")]
		public static FAKEIHBKKIH DLPHBFOJIHH(ECMPBDIEDGD FEAFOJKMMAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEB70", Offset = "0x5EEDF70", VA = "0x185EEEB70")]
		[AsyncStateMachine(typeof(BAFNKNJDEFM))]
		private static Task<(GameObject, AvatarItemMaterial)> MBJEKMEBFAG(Task<GameObject> JFMELJHIEBE, Task<AvatarItemMaterial> ACPJELJJBGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEAB0", Offset = "0x5EEDEB0", VA = "0x185EEEAB0", Slot = "11")]
		protected override PGJHOFDAOBA LENGPFNOBJC(Task<(GameObject, AvatarItemMaterial)> ADPBGDELHKL)
		{
			return default(PGJHOFDAOBA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE610", Offset = "0x5EEDA10", VA = "0x185EEE610", Slot = "12")]
		protected override void DDANGDLIKOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct DLHKDALNNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private ILOEBLPKELJ<PGJHOFDAOBA> OBFJMFNPGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private ILOEBLPKELJ<Material>[] JPHNINBPMBK;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8635F0", Offset = "0x8629F0", VA = "0x1808635F0")]
		public void MGHNENELJHF([Out] ILOEBLPKELJ<PGJHOFDAOBA> AEBAPBHOHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDFF0", Offset = "0x5EED3F0", VA = "0x185EEDFF0")]
		public void ILMOGKHCCBI([Out] ILOEBLPKELJ<Material>[] DEEBIKGCDFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x863610", Offset = "0x862A10", VA = "0x180863610")]
		public DLHKDALNNMM(ILOEBLPKELJ<PGJHOFDAOBA> LGDLMIEMIKG, ILOEBLPKELJ<Material>[] DELNJNDMHJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HEAGBOPFJHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public HDCKPJIIJBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public NHJNJBGGLID buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public HEAGBOPFJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE340", Offset = "0x5EFD740", VA = "0x185EFE340")]
		internal void CMMFCMJGLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE360", Offset = "0x5EFD760", VA = "0x185EFE360")]
		internal void IGFBGJEDIOF(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		internal DONEJHADFEN OANAPIGEHJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LFNOINCKBPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HEAGBOPFJHM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public LFNOINCKBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5EFFD80", Offset = "0x5EFF180", VA = "0x185EFFD80")]
		internal EMNIJHGHJBN IBKCCIANDOD(int lod)
		{
			return default(EMNIJHGHJBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PNCIMNDKDAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public List<NHJNJBGGLID> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public PNCIMNDKDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5F01B30", Offset = "0x5F00F30", VA = "0x185F01B30")]
		internal void ENGIKHHDJNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HFKDLNFFLJG : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public HDCKPJIIJBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public List<HGHMGGBICFC> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<NHJNJBGGLID> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public Func<int, EMNIJHGHJBN> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public PDCDMPCMBOI materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public HFKDLNFFLJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE380", Offset = "0x5EFD780", VA = "0x185EFE380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE570", Offset = "0x5EFD970", VA = "0x185EFE570", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HGKINNCDAHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public HDCKPJIIJBC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public HGKINNCDAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5EFE5F0", Offset = "0x5EFD9F0", VA = "0x185EFE5F0")]
		internal DONEJHADFEN DHIKPIHNJIP(HGHMGGBICFC p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CMLPOHEKNDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public HOJPIMOIENL cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public CMLPOHEKNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x843E60", Offset = "0x843260", VA = "0x180843E60")]
		internal void LGGGLEJNIBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x843E80", Offset = "0x843280", VA = "0x180843E80")]
		internal void OIFHHCBODFP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KDEFBKGGDDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public HDCKPJIIJBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public KDEFBKGGDDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OGEADNODGFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public GGFBMAHDCKG defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public IGBKIMLDKJJ defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public KDEFBKGGDDK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public OGEADNODGFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5F01560", Offset = "0x5F00960", VA = "0x185F01560")]
		internal void OBINLGLNOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5F014F0", Offset = "0x5F008F0", VA = "0x185F014F0")]
		internal void GNIBFBBOEFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EHNAHAKDCFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public BLBELCNKOOP legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public KKINKMNDCFN legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public KDEFBKGGDDK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public EHNAHAKDCFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE320", Offset = "0x5EED720", VA = "0x185EEE320")]
		internal void ABFJIPMFDPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE5A0", Offset = "0x5EED9A0", VA = "0x185EEE5A0")]
		internal void IOCMCDPPPMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MOAOJKCAAJJ : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private LEOLCGBMIAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public MOAOJKCAAJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8462D0", Offset = "0x8456D0", VA = "0x1808462D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5EFFEC0", Offset = "0x5EFF2C0", VA = "0x185EFFEC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class ONLCGDNKPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public HOJPIMOIENL cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public ECMPBDIEDGD avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public HDCKPJIIJBC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public ONLCGDNKPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5F01820", Offset = "0x5F00C20", VA = "0x185F01820")]
		internal DONEJHADFEN LLFKGCHPKJJ(GDGHBCKEHMG item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5F017E0", Offset = "0x5F00BE0", VA = "0x185F017E0")]
		internal void DCMCLOBKNCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class AAIFDIEFDHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public ILOEBLPKELJ<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public AAIFDIEFDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA450", Offset = "0x5EE9850", VA = "0x185EEA450")]
		internal void NHLEAILLGJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MBHOPOBFLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public EGFGHFHFMGF overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public MBHOPOBFLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5EFFE40", Offset = "0x5EFF240", VA = "0x185EFFE40")]
		internal bool PMHCLCFMCFG(KeyValuePair<string, ECMPBDIEDGD> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int GKLFBLJAIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private AvatarConfiguration MEHBLJIHJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private Transform BEONLPPMJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private AssetReference OHOOHMCBNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private GameObject HNBODDHACNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private GameObject AANKLMGMNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private SkinnedMeshRenderer IIJBOAKPMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Transform[] KGIAJLHNAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Matrix4x4[] FLLJLIPLFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Material JDDLOFGJEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private Material KLFADGFBPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Material OEIKNBNBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private Shader JHFLOJNJKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Shader GIDIAJGBMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Animator IMGFJLHILGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private Renderer[] OAPALANJMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private INIJFLJBOFF.PCLLMINFBHH JEILEIKMCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private Color HOBPJFFPJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Color GKCAKEMBKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Color PIMPPKICBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Color? BPHECCFGACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Color? BLHFPIAKDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Color? FCPKPACFJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private Color? JDJOPBNNBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Texture2D FJBOOLKOBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Texture2D BKAANEPKGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[CanBeNull]
	private ECMPBDIEDGD OIHGBJFGMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private Texture NAJCIBHBPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Color JAFMBPMEKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Dictionary<Renderer, PDCDMPCMBOI> KELPELKKIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Dictionary<Renderer, PDCDMPCMBOI> NDHGFNDMPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Dictionary<string, List<LLCPDHIIHLL>> LBAOEABMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<string, List<LLCPDHIIHLL>> IFONMMBDKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<KDJMNIAMELP> CEEJJABBHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<KDJMNIAMELP> OIOIALJPONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly List<KDJMNIAMELP> EFMKGHMJCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly List<KDJMNIAMELP> NKCGGLEOBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<LLCPDHIIHLL, Material> IGMCCCILMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<LLCPDHIIHLL, Material> FBJAAOPCDPJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public SkinnedMeshRenderer[] BPKLJNAFNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private SkinnedMeshRenderer[] MHKBLECMMGA;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public SkinnedMeshRenderer[] IDLDJJFFMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private SkinnedMeshRenderer[] MGIPCFKGONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<string, ILOEBLPKELJ<Texture2D>> OGAADPIMDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<string, ILOEBLPKELJ<Texture2D>> DGFLJFAAAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private FitMeshHemisphere IAGIFHLBBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool NFCNAKLDFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private NBHOKLCMMDH HEFCILMCHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool EGNNHOBLHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AnchorParamsRestrictions ODNMFHLKJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool JAKGCGCHNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform INDMMELJINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Transform NJKMPNPDDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool IKIHLKKDHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x209")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool BDAIENALBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Vector3 DCOGFIMCOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Quaternion LFONCCINLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Vector2 BEFIEOGCELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private FitMeshHemisphere KHCLDGPJIBI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material OPGGMFNNLON;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Material DCEJPKMGDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<string, ECMPBDIEDGD> NGFHCEAKKKE;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly int NFLLNNGOCDG;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly int IPIBJHBMBAM;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly int FGNABDIDEED;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly int ELCHGKGALDG;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly int FOHCOKFMLKB;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly int ABFHMDIJAKP;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly int HOLIFGGDMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DECPPMKECOG KDJGAKMKCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly DECPPMKECOG OFJGGFDIDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool GPKMHDFGHNG;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static Lazy<ALPEHOGHKBH> GKLMEMCHCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Lazy<NLLKAKPEFDE> LAMGOOLKMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Lazy<LEGDBJACELL> HCIAJIODEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private List<Action> LIBFAOJANBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NOEMHNCDNAF AKNJAHBJDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private SkinnedMeshRenderer[] CBLAPNFINFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int DHANAODFMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool BFLKBNPNHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private int LFBCENHAKFH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JHMPHIKMJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF66B0", Offset = "0x5EF5AB0", VA = "0x185EF66B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5160", Offset = "0x5EF4560", VA = "0x185EF5160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IJHLCOLFOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8080", Offset = "0x5EF7480", VA = "0x185EF8080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Material GHNKFNCPKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA690", Offset = "0x5EF9A90", VA = "0x185EFA690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Material FLADEFLJKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2EE0", Offset = "0x5EF22E0", VA = "0x185EF2EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool GPKIGINLPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static ALPEHOGHKBH MMFAHDBJIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1F90", Offset = "0x5EF1390", VA = "0x185EF1F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private NLLKAKPEFDE HDCPBILOOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4700", Offset = "0x5EF3B00", VA = "0x185EF4700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private LEGDBJACELL GBKLDKPNNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7710", Offset = "0x5EF6B10", VA = "0x185EF7710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DECPPMKECOG FBMMBHNMMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F7BA0", Offset = "0x8F6FA0", VA = "0x1808F7BA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DECPPMKECOG HJIOLCPIOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8F68C0", Offset = "0x8F5CC0", VA = "0x1808F68C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public SkinnedMeshRenderer[] CDEAOMBAHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1170BA0", Offset = "0x116FFA0", VA = "0x181170BA0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public SkinnedMeshRenderer[] JDOEANHIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8556B0", Offset = "0x854AB0", VA = "0x1808556B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public SkinnedMeshRenderer[] KNPCAMAJACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x830AC0", Offset = "0x82FEC0", VA = "0x180830AC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Renderer[] CBGBMHBPJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x78F280", Offset = "0x78E680", VA = "0x18078F280", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool OGCFOHPDHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF48C0", Offset = "0x5EF3CC0", VA = "0x185EF48C0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public INIJFLJBOFF.PCLLMINFBHH AMHGBJAFFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x78F230", Offset = "0x78E630", VA = "0x18078F230", Slot = "20")]
		get
		{
			return default(INIJFLJBOFF.PCLLMINFBHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KFCHLNOACMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x16249A0", Offset = "0x1623DA0", VA = "0x1816249A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4260", Offset = "0x5EF3660", VA = "0x185EF4260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool IDCENMAKCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4170", Offset = "0x5EF3570", VA = "0x185EF4170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private static bool JJHOIJIAOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5EFCDB0", Offset = "0x5EFC1B0", VA = "0x185EFCDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EFD980", Offset = "0x5EFCD80", VA = "0x185EFD980")]
	public HDCKPJIIJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5780", Offset = "0x5EF4B80", VA = "0x185EF5780", Slot = "23")]
	public void FILODNFGCKM(HFEDCAPHLPH FLHBLANABFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4260", Offset = "0x5EF3660", VA = "0x185EF4260", Slot = "4")]
	public void HELPOGCLCKP(int NBPAIKKEFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2AC0", Offset = "0x5EF1EC0", VA = "0x185EF2AC0", Slot = "9")]
	public void AOALHIELGGM(IAEJEDOPMPI LLECCPBKEJM, Texture2D PGJDHNNPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6890", Offset = "0x5EF5C90", VA = "0x185EF6890", Slot = "10")]
	public void GPKKMBDCNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7760", Offset = "0x5EF6B60", VA = "0x185EF7760", Slot = "11")]
	public bool JGINCPCFMCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF26C0", Offset = "0x5EF1AC0", VA = "0x185EF26C0", Slot = "8")]
	public void AHGFMDPIPPC(LLCLIPHPFJI MANOCIHIENK, Color? JKOGDMNIBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6750", Offset = "0x5EF5B50", VA = "0x185EF6750")]
	private void GIMDBIAKHCE(Action KCKLJBGKGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF41F0", Offset = "0x5EF35F0", VA = "0x185EF41F0", Slot = "5")]
	public void COHJKCPFHPM(ECMPBDIEDGD HJPMCEBNFKM, Texture AMGKCOGCPDI, Color PNEHIOIBLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5160", Offset = "0x5EF4560", VA = "0x185EF5160", Slot = "6")]
	public void NLDMKJKBOID(bool DMCGCEOEGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1413CA0", Offset = "0x14130A0", VA = "0x181413CA0", Slot = "7")]
	public void GMGPJCJKOCI(NOEMHNCDNAF LALAKJLPIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8BC0", Offset = "0x5EF7FC0", VA = "0x185EF8BC0", Slot = "14")]
	public NHJNJBGGLID MNOOAEOAFPB(GLANMOHFJIL BCKFCBOKBLL, bool KGCPBIFGNCG, int[] BNLCOFPBLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6FF0", Offset = "0x5EF63F0", VA = "0x185EF6FF0", Slot = "15")]
	public void HEPEJPFCJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4A60", Offset = "0x5EF3E60", VA = "0x185EF4A60")]
	private bool EALONDEHICF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78E620", VA = "0x18078F220", Slot = "21")]
	public void FLFJGMALFAP(INIJFLJBOFF.PCLLMINFBHH KKFAKCFLBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA820", Offset = "0x5EF9C20", VA = "0x185EFA820")]
	private NHJNJBGGLID OABCCKLPBAF(bool KGCPBIFGNCG, List<HGHMGGBICFC> BHOBKKMHHPI, int[] BNLCOFPBLMI, Func<int, EMNIJHGHJBN> OHFEDOOELKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA1D0", Offset = "0x5EF95D0", VA = "0x185EFA1D0")]
	[IteratorStateMachine(typeof(HFKDLNFFLJG))]
	private IEnumerator<LEOLCGBMIAN> NNHKHGKIGCJ(bool KGCPBIFGNCG, List<HGHMGGBICFC> BHOBKKMHHPI, int[] BNLCOFPBLMI, Func<int, EMNIJHGHJBN> OHFEDOOELKE, PDCDMPCMBOI NJHMCEAEEHF, Material OJIONDHHLMP, List<NHJNJBGGLID> KIADMBHEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4440", Offset = "0x5EF3840", VA = "0x185EF4440")]
	private NHJNJBGGLID DHAMNKHFODO(List<HGHMGGBICFC> BHOBKKMHHPI, int[] BNLCOFPBLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5EFB0E0", Offset = "0x5EFA4E0", VA = "0x185EFB0E0")]
	private DEMHINFLCEG OJGGKNLAJEH(List<HGHMGGBICFC> BHOBKKMHHPI, int NBPAIKKEFCG, bool KGCPBIFGNCG, EMNIJHGHJBN FBFOMBJELAK, bool KFFFJNLPJBN, PDCDMPCMBOI NJHMCEAEEHF, Material OJIONDHHLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5EF67D0", Offset = "0x5EF5BD0", VA = "0x185EF67D0")]
	private DEMHINFLCEG GLFIOEEHANE(JobHandle EOPJMHHJPCK, bool DMKDMFDLJNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3130", Offset = "0x5EF2530", VA = "0x185EF3130")]
	private void BKNNDPCEONG(SkinnedMeshRenderer COPLGLBHDHB, Mesh MOKLMJBIJAG, List<Material> MHHICMOAJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
	private void IADEPNFNAKO(int NBPAIKKEFCG, long KHOHBBNIMJE, long ADIAGINOJEC, long LCBDFLDNFOC, long POJCFKIAFNO, long CPDGBCBPLDB, long DAIJHBDLJOF, long EAKAMCHGJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8360", Offset = "0x5EF7760", VA = "0x185EF8360")]
	[IteratorStateMachine(typeof(MOAOJKCAAJJ))]
	private IEnumerator<LEOLCGBMIAN> KLEJMAPFKAC(JobHandle AEBAPBHOHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5EF33E0", Offset = "0x5EF27E0", VA = "0x185EF33E0")]
	private static Material CCOEOOMAGPM(Dictionary<LLCPDHIIHLL, Material> LBCHLJDKLAO, Material HJOBBNELMHH, ABEEEAABIAJ AKENKGJALIC, GBMIKGJOHDB MMHEKJOHLAK, EGFGHFHFMGF MFAKGJABJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3540", Offset = "0x5EF2940", VA = "0x185EF3540")]
	private static ABEEEAABIAJ CFKFBLGGKLB(HGHMGGBICFC AIOJDOMNKKI, int JBAFFFMANLG)
	{
		return default(ABEEEAABIAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3660", Offset = "0x5EF2A60", VA = "0x185EF3660")]
	private void CFPHJFLAKBG(int OMKFAPMKJPK, Material DELNJNDMHJJ, HGHMGGBICFC AIOJDOMNKKI, [Out] Texture2D OEHOLNJCKEG, [Out] Vector4 PIHPNJMKJJJ, [Out] Texture2D JOHDGHMNLIN, [Out] Texture2D ANKBDONCIFF, [Out] Texture2D EGNLCFPDOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5170", Offset = "0x5EF4570", VA = "0x185EF5170")]
	private void EJPGHMOMHBL(int OMKFAPMKJPK, Material DELNJNDMHJJ, HGHMGGBICFC AIOJDOMNKKI, [Out] Color KDEDJMGHNOF, [Out] Color DFECPMONNKJ, [Out] Color EINHFBGMJKD, [Out] Color OLGDLGPPEPA, [Out] Color BAFIIGHJJPG, [Out] Color BFAJCPFNBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF78E0", Offset = "0x5EF6CE0", VA = "0x185EF78E0")]
	private bool JJBPJCDMJAJ(Material DELNJNDMHJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA150", Offset = "0x5EF9550", VA = "0x185EFA150")]
	private static Material NBFJLJGBGPD(int OMKFAPMKJPK, NKMJFFABABI AIOJDOMNKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EFD640", Offset = "0x5EFCA40", VA = "0x185EFD640")]
	private static GBMIKGJOHDB PPAHGEGAAGO(HGHMGGBICFC AIOJDOMNKKI, int JBAFFFMANLG)
	{
		return default(GBMIKGJOHDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8090", Offset = "0x5EF7490", VA = "0x185EF8090")]
	private static void KKPNLLDOMLC(Dictionary<string, List<LLCPDHIIHLL>> NODLFLFFLNG, HGHMGGBICFC NJBKPHCEDED, Material HJOBBNELMHH, ABEEEAABIAJ MANOCIHIENK, GBMIKGJOHDB LLECCPBKEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF87D0", Offset = "0x5EF7BD0", VA = "0x185EF87D0")]
	private static SkinnedMeshRenderer LPJKFHDGALF(Transform OCAMDMLFFIN, Transform PAKNLAKLPJG, SkinnedMeshRenderer[] IOIOOAHKAHF, int NBPAIKKEFCG, EMNIJHGHJBN FBFOMBJELAK, bool KGCPBIFGNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5EFD330", Offset = "0x5EFC730", VA = "0x185EFD330")]
	private void PNFMKCJLNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3AA0", Offset = "0x5EF2EA0", VA = "0x185EF3AA0")]
	private void CHLCLFGMGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2FD0", Offset = "0x5EF23D0", VA = "0x185EF2FD0")]
	private static void BKBJNHAODML(Dictionary<LLCPDHIIHLL, Material> LBCHLJDKLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EFADA0", Offset = "0x5EFA1A0", VA = "0x185EFADA0")]
	private static void OFCKJDKEIDI(Dictionary<Renderer, PDCDMPCMBOI> KOGODAKMOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EFD520", Offset = "0x5EFC920", VA = "0x185EFD520")]
	private void POBHBKEAOJG(SkinnedMeshRenderer[] IOIOOAHKAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8A00", Offset = "0x5EF7E00", VA = "0x185EF8A00")]
	private void MBJAJFBLDGC(SkinnedMeshRenderer EIPDDAHGMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EFAF00", Offset = "0x5EFA300", VA = "0x185EFAF00")]
	private void OJEDKBODFJH(List<KDJMNIAMELP> DJMBHCFFLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5EF71F0", Offset = "0x5EF65F0", VA = "0x185EF71F0")]
	private void HGJMAMCHBGD(Dictionary<string, ILOEBLPKELJ<Texture2D>> NODLFLFFLNG, bool BMLAJLFPEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5670", Offset = "0x5EF4A70", VA = "0x185EF5670")]
	private void EKJFKKKNIIM(Dictionary<string, List<LLCPDHIIHLL>> NODLFLFFLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7B00", Offset = "0x5EF6F00", VA = "0x185EF7B00")]
	private void JONJCGEIDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3250", Offset = "0x5EF2650", VA = "0x185EF3250")]
	private void CCHEEOADFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3BA0", Offset = "0x5EF2FA0", VA = "0x185EF3BA0")]
	private void CJCKAJJOBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5A60", Offset = "0x5EF4E60", VA = "0x185EF5A60")]
	private void FOLGMDECGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF56C0", Offset = "0x5EF4AC0", VA = "0x185EF56C0")]
	private void EOKBKIGMKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7400", Offset = "0x5EF6800", VA = "0x185EF7400")]
	private void HKMHIGLPBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5EFCFE0", Offset = "0x5EFC3E0", VA = "0x185EFCFE0")]
	private void PBBEIAMLAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4280", Offset = "0x5EF3680", VA = "0x185EF4280")]
	private void DDLCANKJBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2380", Offset = "0x5EF1780", VA = "0x185EF2380")]
	private void AGLDLEGALLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2010", Offset = "0x5EF1410", VA = "0x185EF2010")]
	private void AFOMOOEFFNB(Material OJIONDHHLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2DF0", Offset = "0x5EF21F0", VA = "0x185EF2DF0")]
	private void BDOCLIKICGI(Material OJIONDHHLMP, Color DFECPMONNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3AB0", Offset = "0x5EF2EB0", VA = "0x185EF3AB0")]
	private void CIBFNKHNEON(Material OJIONDHHLMP, Color EINHFBGMJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6F00", Offset = "0x5EF6300", VA = "0x185EF6F00")]
	private void HBGBAHEHLPO(Material OJIONDHHLMP, Color KDEDJMGHNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8AD0", Offset = "0x5EF7ED0", VA = "0x185EF8AD0")]
	private void MKOCGIDDHJH(Material OJIONDHHLMP, Texture2D PGJDHNNPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4350", Offset = "0x5EF3750", VA = "0x185EF4350")]
	private void DGBHFJPEJGE(Material OJIONDHHLMP, Texture CMMOHDPGIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EFD0B0", Offset = "0x5EFC4B0", VA = "0x185EFD0B0")]
	private void PEIDGLGILDJ(Action<PDCDMPCMBOI> KFLOKMKDOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4FB0", Offset = "0x5EF43B0", VA = "0x185EF4FB0")]
	private void EHNNDLDBNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4C50", Offset = "0x5EF4050", VA = "0x185EF4C50")]
	private void EGFCPNFEBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6910", Offset = "0x5EF5D10", VA = "0x185EF6910")]
	private NHJNJBGGLID GPOJGJLEIFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA2E0", Offset = "0x5EF96E0", VA = "0x185EFA2E0")]
	private void NNNFIBNGFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7C60", Offset = "0x5EF7060", VA = "0x185EF7C60")]
	public void KBDKAOOEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7A90", Offset = "0x5EF6E90", VA = "0x185EF7A90")]
	private void JOEBLMLNJHJ(Vector3 CNEKGDKGHGE, Quaternion LABHFJHFGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8490", Offset = "0x5EF7890", VA = "0x185EF8490")]
	private void LLBCFGNNEAN(List<HGHMGGBICFC> KKICPLOJFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EF61B0", Offset = "0x5EF55B0", VA = "0x185EF61B0")]
	public void GAABILIGLKO(NBHOKLCMMDH NNPOLFNAAPE, bool NKLNFHGOJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5B30", Offset = "0x5EF4F30", VA = "0x185EF5B30")]
	public void GAABILIGLKO(NBHOKLCMMDH NNPOLFNAAPE, AnchorParamsRestrictions EHKMKJKLLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82E100", Offset = "0x82D500", VA = "0x18082E100")]
	private static void CEDJLMLLLDP(FitMeshHemisphere GOIABPHAMNK, Transform LEPPGCIEFNC, NBHOKLCMMDH NNPOLFNAAPE, AnchorParamsRestrictions GPFJKFPFEAK, [Out] Vector3 OHOMLOMNFJE, [Out] Quaternion MCGHOJEKKGM, [Out] NBHOKLCMMDH BJJCKJDEFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7550", Offset = "0x5EF6950", VA = "0x185EF7550")]
	public void IDLECFNPOCI(Vector2 BEDFCDEFOFA, Vector3 AMBMBMIBMEN, Vector3 MDLHDBLNGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4750", Offset = "0x5EF3B50", VA = "0x185EF4750")]
	private void DMFGJFIIDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2D60", Offset = "0x5EF2160", VA = "0x185EF2D60")]
	private void BCDNAIOGDPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5EFD270", Offset = "0x5EFC670", VA = "0x185EFD270")]
	[CompilerGenerated]
	private void PFGGDHFOMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4A30", Offset = "0x5EF3E30", VA = "0x185EF4A30")]
	[CompilerGenerated]
	private void DOFGPLJMHNA(PDCDMPCMBOI LCDFLKLGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5EFAD10", Offset = "0x5EFA110", VA = "0x185EFAD10")]
	[CompilerGenerated]
	private void OEFKHIIGGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1F70", Offset = "0x5EF1370", VA = "0x185EF1F70")]
	[CompilerGenerated]
	private void AAFNBBGAHIJ(PDCDMPCMBOI LCDFLKLGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8400", Offset = "0x5EF7800", VA = "0x185EF8400")]
	[CompilerGenerated]
	private void LCCHEEKENFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4BA0", Offset = "0x5EF3FA0", VA = "0x185EF4BA0")]
	[CompilerGenerated]
	private void EEBMNPDKCDH(PDCDMPCMBOI LCDFLKLGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7370", Offset = "0x5EF6770", VA = "0x185EF7370")]
	[CompilerGenerated]
	private void HJBEENHCJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5EFD300", Offset = "0x5EFC700", VA = "0x185EFD300")]
	[CompilerGenerated]
	private void PINFDNBICNK(PDCDMPCMBOI LCDFLKLGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5EF66C0", Offset = "0x5EF5AC0", VA = "0x185EF66C0")]
	[CompilerGenerated]
	private void GDFNIHPJHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8AA0", Offset = "0x5EF7EA0", VA = "0x185EF8AA0")]
	[CompilerGenerated]
	private void MKAKAOFHGCD(PDCDMPCMBOI LCDFLKLGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EFCF50", Offset = "0x5EFC350", VA = "0x185EFCF50")]
	[CompilerGenerated]
	private void ONDFDALMICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5EF83D0", Offset = "0x5EF77D0", VA = "0x185EF83D0")]
	[CompilerGenerated]
	private void KMDDHAJPGKB(PDCDMPCMBOI LCDFLKLGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4BC0", Offset = "0x5EF3FC0", VA = "0x185EF4BC0")]
	[CompilerGenerated]
	private void EEKCCBMJCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5130", Offset = "0x5EF4530", VA = "0x185EF5130")]
	[CompilerGenerated]
	private void EJEKMJLNAOG(PDCDMPCMBOI LCDFLKLGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5EF40F0", Offset = "0x5EF34F0", VA = "0x185EF40F0")]
	[CompilerGenerated]
	private void CJKENFJHNMA(KeyValuePair<string, ILOEBLPKELJ<Texture2D>> KLCGGOMOBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2CD0", Offset = "0x5EF20D0", VA = "0x185EF2CD0")]
	[CompilerGenerated]
	private void AOGFPJJEFLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7A60", Offset = "0x5EF6E60", VA = "0x185EF7A60")]
	[CompilerGenerated]
	private void JMIOKCBJCIB(PDCDMPCMBOI LCDFLKLGKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7FF0", Offset = "0x5EF73F0", VA = "0x185EF7FF0")]
	[CompilerGenerated]
	private void KGCMAIGNAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5750", Offset = "0x5EF4B50", VA = "0x185EF5750")]
	[CompilerGenerated]
	private void FDMAKLHGIFK(PDCDMPCMBOI LCDFLKLGKMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DEPDGMGADNO : KLHNPJMCLCM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ODCHIBNGOOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public Vector2 DJEOOMFAPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Vector2 KCEIDJBGMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public Vector2 MAFJKPIOBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Vector2 IONCFACKGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Vector2 KHNECIONCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Vector2 ADLIFHKBJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Vector2 EAAGLLCKDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Vector2 EAFOBFAGGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Vector2 AMCEOJINDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector2 IMAGPGFCPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector2 CJNAHDPINDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Vector2 JCHLMGNGHPO;
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly int OANMFGAECBN;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly int ALNLEOGALJC;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly int ACDGCIOCEGB;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly int CEAENNFFDGK;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly int OCOIGIKOMLG;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly int FFLKLFLOCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly int JPLPEAFFPPC;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly int EKFFCNPPJGP;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int PANPPMPEFPK;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int KMCCMGHPPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int IOMPFMJIGFG;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int PCGCEGBHFKG;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int MPGHFOEPMGK;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int PDEOPFJAMJB;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int FONIAGGCMLD;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int BEJDKIJKPJJ;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int DCHENDHEJCB;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int JPJNGFBLPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Transform POEJLDBKFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private Transform HBDKCFHIGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private Transform HFCHPOKGOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Transform PPEFDNKBAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private Transform LKLPLJJNAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Transform ALEBMPHHLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private Transform GIFBKGADLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private MCKDFAKJDAI NINCAMKCKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private MaterialPropertyBlock CNJADDGDDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private SkinnedMeshRenderer[] LNJDCHCLKOI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private MaterialPropertyBlock JGDCJEIDOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC3E0", Offset = "0x5EEB7E0", VA = "0x185EEC3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC460", Offset = "0x5EEB860", VA = "0x185EEC460", Slot = "6")]
	public void FILODNFGCKM(MCKDFAKJDAI JNNPAGLPNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EED800", Offset = "0x5EECC00", VA = "0x185EED800", Slot = "7")]
	public void MLMPMMLLADD(LGEBBAIIBIC HLOJHALPPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5EED830", Offset = "0x5EECC30", VA = "0x185EED830", Slot = "4")]
	public void NHHMAMPEBFI(KKILFBKANPD PFKGHMHPLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5EECCC0", Offset = "0x5EEC0C0", VA = "0x185EECCC0", Slot = "5")]
	public void KOLAKCFLALE(JDODAPONPNE HLOJHALPPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC610", Offset = "0x5EEBA10", VA = "0x185EEC610")]
	private void HMPDOCNNHIE(JDODAPONPNE OAKCFHOGIPO, ODCHIBNGOOD KPNNKIBJLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5EECBE0", Offset = "0x5EEBFE0", VA = "0x185EECBE0")]
	private void JGKEBAPCKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDF90", Offset = "0x5EED390", VA = "0x185EEDF90")]
	public DEPDGMGADNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC520", Offset = "0x5EEB920", VA = "0x185EEC520")]
	[CompilerGenerated]
	private Vector4 FJMAPFPJGOM(Vector2 BCGGHPIMKDA, Vector2 GLDPLANNJMB)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC5A0", Offset = "0x5EEB9A0", VA = "0x185EEC5A0")]
	[CompilerGenerated]
	private Vector4 FLOANCGDJEK(float PGNCAMEFIBH, float ENGNCFDJFAM, float IPGAPCKOOHO, float HLCHIFCHBEA)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class PDCDMPCMBOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private MaterialPropertyBlock CPLAGMGNEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public Color? CCIEKHHEFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Color? FNILJJJEMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Color? OOAGGIMFLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color? KNJCOMEJAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color HMJKOONJMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color CLKBFPKFMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Color KLIJGMNGGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Texture2D EGCLNKIIHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Texture2D PNKIHIFOOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private Dictionary<LLCPDHIIHLL, int> JMDJDDENHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private ABEEEAABIAJ[] HEBCIKJMAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private GBMIKGJOHDB[] EMOHNIFBKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public Vector4[] INIAOGDOEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Vector4[] EJBDJHLAONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Vector4[] DLBKKDONDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] DGPJPIBOFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] HIOKKAHLMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4[] BOFJFAFPAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private List<Texture2D> JGKIMCEBLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private Vector4[] FCIOJIPIFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private List<Texture2D> FPBHOPIBMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private float[] CKBLIFEJLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector4[] ACKDDPGPIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float[] OHLICACBDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public float[] BBJFCMALPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private List<Texture2D> EMLKOIEGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private float[] IGONIBBFGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private List<Texture2D> FOPHDIJIONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private Vector4[] CIHEBAIFGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private float[] DMLOKPGICCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private Vector4[] BNGOFLMCNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public float[] OOHLDLMDONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public Texture2DArray JPAEFDIDEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public Texture2DArray JIBOLFEMELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Texture2DArray IFPKOOLFNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Texture2DArray FNAKOEMCMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private bool LMOCMGPLAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int BEFAINFDOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private Vector2? PKKKBJMOLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private TextureFormat HEICDIFNIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private Vector2? FIDBOHGNIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private TextureFormat FCIPIMJBPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private Vector2? JNNKDCDKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private TextureFormat EKBKBMLBDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private Vector2? FIDJCBNAIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private TextureFormat LBCGILIMGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private bool ENCMOAFILAH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int EHLFOKCNNJB;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int JJNFPMKMDMG;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int FPMFHNEPJKD;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int KBGGHGDHOOH;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int PBCMOCNLPAE;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int PDEFCGNFPFN;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int CPBFOGBPFHI;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int EPHIMJBJFNH;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int OJKKFHNDOAL;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int PHBHNPLGFCF;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int KKOLOPOPGPO;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int NELEPMIDDED;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int FILOJDMPHHB;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int LDBFEFDBOFG;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int JNANHFDLOEB;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int GEKAFINBJLJ;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int LHNMLIOBBCF;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int NHBPILIEKFH;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int FCEIONLNGLN;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int LDKMBHKFMHP;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5F0A650", Offset = "0x5F09A50", VA = "0x185F0A650")]
	private PDCDMPCMBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5F0AB40", Offset = "0x5F09F40", VA = "0x185F0AB40")]
	public PDCDMPCMBOI(Color MMADMEPCMLE, Color POGHCCBNCJI, Color ADBBGLBKEIM, Color? GCGEBKKIOMF, Color? AOOONFIMLFK, Color? KPKAKJHEHMN, Texture2D FMEAMLGFKNO, Texture2D KEFHGKFIBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5F09FF0", Offset = "0x5F093F0", VA = "0x185F09FF0")]
	internal int PCLADOOLACP(Material BLAJMEIOBGG, ABEEEAABIAJ AKENKGJALIC, GBMIKGJOHDB MMHEKJOHLAK, EGFGHFHFMGF MFAKGJABJHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5F0A0E0", Offset = "0x5F094E0", VA = "0x185F0A0E0")]
	private int PCLADOOLACP(LLCPDHIIHLL CONEAMPCFEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5F09120", Offset = "0x5F08520", VA = "0x185F09120")]
	internal int JLCELMILKPO(Material BLAJMEIOBGG, Color KDEDJMGHNOF, Color DFECPMONNKJ, Color EINHFBGMJKD, Color OLGDLGPPEPA, Color BAFIIGHJJPG, Texture2D MGGLGCKEAHN, Vector4 CECJDHHGKOM, Texture2D AOJCNJNDGJI, Vector4 IKIGOFDBBHP, float HKEHKGPEHJP, float MGGIBOFGCJM, Texture2D HKHFCDNCNIF, Vector4 KEMGAKOFKAD, float GMKBDOCDHOM, Texture2D FNBBJLJAAPA, float BILLHMCJPOJ, Color BFAJCPFNBDM, Vector4 KBFJMNAEJKC, ABEEEAABIAJ AKENKGJALIC, GBMIKGJOHDB MMHEKJOHLAK, EGFGHFHFMGF MFAKGJABJHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5F080B0", Offset = "0x5F074B0", VA = "0x185F080B0")]
	private void FDFAEDBAPJM(List<Texture2D> JGKIMCEBLHI, [Out] Texture2DArray GMIOLMCKMOA, [Out] Texture2DArray CGBBLCIBEMB, [Out] Texture2DArray JBJEACNLABP, [Out] Texture2DArray DOAKHAHKDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5F0A170", Offset = "0x5F09570", VA = "0x185F0A170")]
	public void PIFIFCDBCEO(Shader FDINGOBLEKE, Renderer MADIDHJDPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5F08270", Offset = "0x5F07670", VA = "0x185F08270")]
	private void HAJDONFDMNG(Shader FDINGOBLEKE, Renderer MADIDHJDPOK, int OBDDEGCKIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5F09CA0", Offset = "0x5F090A0", VA = "0x185F09CA0")]
	private Color KCAEFCHDGOO(Color NILNHJBPAJA, ABEEEAABIAJ MANOCIHIENK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5F09EA0", Offset = "0x5F092A0", VA = "0x185F09EA0")]
	private Color OEBABOIEEAB(Color GMALDEMIJIP, ABEEEAABIAJ MANOCIHIENK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5F09020", Offset = "0x5F08420", VA = "0x185F09020")]
	private bool HIOABMMNNKH(Texture2D DNDFKBLNNBK, GBMIKGJOHDB LLECCPBKEJM, [Out] Texture2D HDODOOPFFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5F07FE0", Offset = "0x5F073E0", VA = "0x185F07FE0")]
	private void ANEDGBLFLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5F08070", Offset = "0x5F07470", VA = "0x185F08070", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private GNJLGPKKIDD? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MKBBGPPCDJC CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x5F027E0", Offset = "0x5F01BE0", VA = "0x185F027E0")]
			get
			{
				return default(MKBBGPPCDJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public GNJLGPKKIDD MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5F02830", Offset = "0x5F01C30", VA = "0x185F02830")]
			get
			{
				return default(GNJLGPKKIDD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x793FA0", Offset = "0x7933A0", VA = "0x180793FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78E600", VA = "0x18078F200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5F02630", Offset = "0x5F01A30", VA = "0x185F02630")]
		public Material[] DJNPKKKPHBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5F02470", Offset = "0x5F01870", VA = "0x185F02470")]
		public static void DDLHAMBNFHG(AvatarItemMaterial IOBPMJEGPDF, Material DELNJNDMHJJ, int OMKFAPMKJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5F02710", Offset = "0x5F01B10", VA = "0x185F02710")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[LOKPKGJHMNM]
public struct LNGNJJBCNLN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	public KKINKMNDCFN POOEPIJJOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	public int CDINOHMDINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public BLBELCNKOOP CAICGNFOHDC;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5F07190", Offset = "0x5F06590", VA = "0x185F07190", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NativeContainer]
[LOKPKGJHMNM]
public struct BLBELCNKOOP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public NativeArray<Vector3> ODDAHFKNGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Vector3> ACFJFIFBHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<Vector4> LMMLMMHNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector2> CKMDJGEKLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector2> GGBJOILNGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector2> MIBMLIBLFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> GFHFGCBFLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Color> DNDKIAPDIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<int> CBPMBMAJOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<int> BDBJBKLCIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private NativeArray<int> MDGOELLCGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private NativeArray<int> MHEHKKLPCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<int> GHFJDGLIFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<int> FADHNBIIIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> FNIKAKLCPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<BoneWeight> PEBCPNJBCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private NativeArray<int> LALAKJLPIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private bool CNEHBJCCEPM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int IJCNHGOJAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5F02EC0", Offset = "0x5F022C0", VA = "0x185F02EC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5F02B60", Offset = "0x5F01F60", VA = "0x185F02B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int HDNADINPPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5F03260", Offset = "0x5F02660", VA = "0x185F03260")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5F02B50", Offset = "0x5F01F50", VA = "0x185F02B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int ELBNJBMCNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5F032A0", Offset = "0x5F026A0", VA = "0x185F032A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5F03250", Offset = "0x5F02650", VA = "0x185F03250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5F03340", Offset = "0x5F02740", VA = "0x185F03340")]
	public BLBELCNKOOP(int IGCAGNGFCEC, int ILFBIIIDEED, int MIOOOANBGEH, int DCHAMAOBKDJ, Allocator FHOLEANHCPH, int KAHBMOEAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5F031A0", Offset = "0x5F025A0", VA = "0x185F031A0")]
	public void FCPPFOBCFBE(int FGBBDGJMFEH, Vector3 KEKNEOLOBCH, Vector3 LAMMHHOBAGL, Vector4 DMIDIFJGAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5F029B0", Offset = "0x5F01DB0", VA = "0x185F029B0")]
	public void BILBNAJCLDD(int FGBBDGJMFEH, BoneWeight OEEPKPBGIKC, NativeSlice<byte> HPBINHCPKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5F03230", Offset = "0x5F02630", VA = "0x185F03230")]
	public Color GNLADNIFNAJ(int FGBBDGJMFEH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5F03210", Offset = "0x5F02610", VA = "0x185F03210")]
	public void GIIFKJCOPJP(int FGBBDGJMFEH, Color KGDDDEENGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5F03080", Offset = "0x5F02480", VA = "0x185F03080")]
	public void EELICIANEBG(byte JNAGJHPGAAJ, int FGBBDGJMFEH, Vector2 KFHGLNMDHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5F028F0", Offset = "0x5F01CF0", VA = "0x185F028F0")]
	public void AEPPMNBFANK(int FGBBDGJMFEH, int KEEBFPBHMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5F03270", Offset = "0x5F02670", VA = "0x185F03270")]
	public bool MJOBPHJDPEC(int JNAGJHPGAAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5F030D0", Offset = "0x5F024D0", VA = "0x185F030D0")]
	public void ENKOBDKCDGN(int DGABIGGIMFC, int EIJFICIEABK, int OGHJPGGPGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5F02900", Offset = "0x5F01D00", VA = "0x185F02900")]
	public int[] BHINOGAFDLB(int DGABIGGIMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5F032B0", Offset = "0x5F026B0", VA = "0x185F032B0")]
	private NativeSlice<int> OJBGNBBBMBK(int DGABIGGIMFC)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5F02ED0", Offset = "0x5F022D0", VA = "0x185F02ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5F02B70", Offset = "0x5F01F70", VA = "0x185F02B70")]
	public Mesh CIABKIJJBEG([Optional] string CNMAEPOHDFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NativeContainer]
[LOKPKGJHMNM]
[DefaultMember("Item")]
public struct KKINKMNDCFN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector3> ODDAHFKNGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Vector3> ACFJFIFBHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector4> LMMLMMHNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector2> CKMDJGEKLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector2> GGBJOILNGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector2> MIBMLIBLFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector2> GFHFGCBFLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Color> DNDKIAPDIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> BBKMLJOPPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<int> OHKCPEGJGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<int> EDPCPDDGABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> GINHEHPAFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> OKFMAONEDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<BoneWeight> IPMEKACHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<Matrix4x4> NBHFNALLLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private NativeArray<int> HDKLBGJOEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private NativeArray<byte> MPGFKOLKGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private NativeArray<int> FJEKFCPGCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NativeArray<int> PFLJLFMPAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<sbyte> ICFKFBABIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<byte> DIKJIAHNMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<int> GBMHNNFIDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private bool CNEHBJCCEPM;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int DOCDGKOIBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1D31860", Offset = "0x1D30C60", VA = "0x181D31860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int ODBNFCBBKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xDDF440", Offset = "0xDDE840", VA = "0x180DDF440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int OANCIGIOOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5F05550", Offset = "0x5F04950", VA = "0x185F05550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int EALNNCMDKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5F05400", Offset = "0x5F04800", VA = "0x185F05400")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5F05510", Offset = "0x5F04910", VA = "0x185F05510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int IJCNHGOJAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5F051C0", Offset = "0x5F045C0", VA = "0x185F051C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5F04CC0", Offset = "0x5F040C0", VA = "0x185F04CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MPIGNFNKDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5F054F0", Offset = "0x5F048F0", VA = "0x185F054F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5F05520", Offset = "0x5F04920", VA = "0x185F05520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MCGJFBFAFOI LCDLFCBPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5F05410", Offset = "0x5F04810", VA = "0x185F05410")]
		get
		{
			return default(MCGJFBFAFOI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5F05540", Offset = "0x5F04940", VA = "0x185F05540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public byte PFOJAFPEMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5F05530", Offset = "0x5F04930", VA = "0x185F05530")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5F05500", Offset = "0x5F04900", VA = "0x185F05500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FMGJGNCOFCK GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5F04CD0", Offset = "0x5F040D0", VA = "0x185F04CD0")]
		get
		{
			return default(FMGJGNCOFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5F05580", Offset = "0x5F04980", VA = "0x185F05580")]
	public KKINKMNDCFN(IList<Mesh> AEBGKENMHCH, IList<Matrix4x4> KGNPCANGBMN, byte HECJPECGIIB, IList<byte[]> EHPNKPMACMP, IList<int> BJKPACBGKAI, IList<bool> EEGCPCICEPM, IList<int> EKEIPBAKOGF, IList<int> AILLFLOPIKN, Allocator FHOLEANHCPH, MCGJFBFAFOI EACJFDDHMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5F05420", Offset = "0x5F04820", VA = "0x185F05420")]
	public BLBELCNKOOP GGLHILCHPHJ(Allocator FHOLEANHCPH)
	{
		return default(BLBELCNKOOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5F051D0", Offset = "0x5F045D0", VA = "0x185F051D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[LOKPKGJHMNM]
public class JCNGDKDMHKG : NJKGCNIDOCG
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5F04410", Offset = "0x5F03810", VA = "0x185F04410")]
	public KKINKMNDCFN DAEIKKJFFEO()
	{
		return default(KKINKMNDCFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5F044E0", Offset = "0x5F038E0", VA = "0x185F044E0")]
	public JCNGDKDMHKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct FMGJGNCOFCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeSlice<Vector3> ODDAHFKNGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeSlice<Vector3> ACFJFIFBHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeSlice<Vector4> LMMLMMHNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeSlice<Vector2> CKMDJGEKLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<Vector2> GGBJOILNGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector2> MIBMLIBLFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Vector2> GFHFGCBFLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<Color> DNDKIAPDIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<int> LHHLHOIEBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<int> GINHEHPAFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<BoneWeight> IPMEKACHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<byte> ANNBHKBEFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public int PCHKHHIBJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public Matrix4x4 CHNHAIFOHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public int PBBKGEMBFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<byte> HPBINHCPKAK;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal readonly struct LLCPDHIIHLL : IEquatable<LLCPDHIIHLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	internal readonly Material AEACPPPKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	internal readonly ABEEEAABIAJ AOFEIGNNDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	internal readonly GBMIKGJOHDB GDMJOILKGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	internal readonly EGFGHFHFMGF DCKOGFDHOBB;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x825FF0", Offset = "0x8253F0", VA = "0x180825FF0")]
	public LLCPDHIIHLL(Material DELNJNDMHJJ, ABEEEAABIAJ AKENKGJALIC, GBMIKGJOHDB MMHEKJOHLAK, EGFGHFHFMGF MFAKGJABJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5F06F70", Offset = "0x5F06370", VA = "0x185F06F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x825BD0", Offset = "0x824FD0", VA = "0x180825BD0", Slot = "4")]
	public bool Equals(LLCPDHIIHLL JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5F06DF0", Offset = "0x5F061F0", VA = "0x185F06DF0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5F06ED0", Offset = "0x5F062D0", VA = "0x185F06ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class KCIMCBKABCI : LEGDBJACELL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private CPDCMCFMFPM NOPGJIFCJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private OIPEGLIHJAJ LLKEONAIOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private IRecRoomQualityConfigProvider BJPJIFEHDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private bool CNEHBJCCEPM;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5F04BC0", Offset = "0x5F03FC0", VA = "0x185F04BC0")]
	[ABIGJEDBLLA(BMBIBJGPNHE.GameOnly)]
	private static void PIPKNOKJANG(DFNLNAANFCD MKEGOGNADMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5298710", Offset = "0x5297B10", VA = "0x185298710")]
	[Preserve]
	public KCIMCBKABCI([AKCMIAONCHN(null)] OIPEGLIHJAJ FNNHHHICFNE, [AKCMIAONCHN(null)] CPDCMCFMFPM KDHOAGDEMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5F04AF0", Offset = "0x5F03EF0", VA = "0x185F04AF0")]
	private void EBLEJNIPGLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5F04B60", Offset = "0x5F03F60", VA = "0x185F04B60", Slot = "4")]
	public void GPKKMBDCNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5F04630", Offset = "0x5F03A30", VA = "0x185F04630", Slot = "5")]
	public ILOEBLPKELJ<Texture2D> CHKOABCCFHM(GDGHBCKEHMG AOPBCHDKNLI, [Optional] NOEMHNCDNAF LALAKJLPIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5F044F0", Offset = "0x5F038F0", VA = "0x185F044F0")]
	private uint AGPIEJBIIGA(GDGHBCKEHMG AOPBCHDKNLI, NOEMHNCDNAF LALAKJLPIGH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface OJOLMKKMJEA
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAPNPDGECBJ(Mesh MOKLMJBIJAG, Matrix4x4 DHMHCKEGFMJ, byte[] HPBINHCPKAK, bool HGGNGGIIGOJ = false, INIJFLJBOFF.PCLLMINFBHH NFFFELCAKGN = (INIJFLJBOFF.PCLLMINFBHH)0);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDHFCDJHAPE(Allocator FHOLEANHCPH, MCGJFBFAFOI EACJFDDHMOF, byte HECJPECGIIB, [Optional] IList<int> EKEIPBAKOGF, [Optional] IList<int> AMCJMHMJINE);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct PGJHOFDAOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly GameObject ODCDKFAJOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly AvatarItemMaterial LKADAADGEDO;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x863610", Offset = "0x862A10", VA = "0x180863610")]
	public PGJHOFDAOBA(GameObject ODCDKFAJOFL, AvatarItemMaterial LKADAADGEDO)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[SerializeField]
		[CEJHJKODPLN(ELJJCPAPFEG.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5F0AC00", Offset = "0x5F0A000", VA = "0x185F0AC00")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct FKPAAGNFNBF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public AsyncTaskMethodBuilder<DEPEFJCDGGH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private TaskAwaiter<DEPEFJCDGGH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x5F03780", Offset = "0x5F02B80", VA = "0x185F03780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x5F03AC0", Offset = "0x5F02EC0", VA = "0x185F03AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private Dictionary<NNPNPEIPKPE, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private Dictionary<NNPNPEIPKPE, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private Dictionary<NNPNPEIPKPE, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private Dictionary<NNPNPEIPKPE, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private readonly Dictionary<NNPNPEIPKPE, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private DEPEFJCDGGH _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x5F043E0", Offset = "0x5F037E0", VA = "0x185F043E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5F03CB0", Offset = "0x5F030B0", VA = "0x185F03CB0")]
		public DEPEFJCDGGH AHKIALOMLAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5F03D00", Offset = "0x5F03100", VA = "0x185F03D00")]
		[AsyncStateMachine(typeof(FKPAAGNFNBF))]
		public Task<DEPEFJCDGGH> FFHDDJGFGOE(int KKOOANMEJNF, int LONHFNPBAPP, int BADMLJLLKDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5F03EE0", Offset = "0x5F032E0", VA = "0x185F03EE0")]
		public NoseFaceOption HCBFKGPKBOB(int LLNCOFCMJLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5F03B30", Offset = "0x5F02F30", VA = "0x185F03B30")]
		public SelectableFaceOption ADIGCBEAEAJ(FaceFeatureType CGLDKHPBNKD, NNPNPEIPKPE GKIPKILHHDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5F03F80", Offset = "0x5F03380", VA = "0x185F03F80")]
		public int IJADCDKNANN(NNPNPEIPKPE GKIPKILHHDD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5F04120", Offset = "0x5F03520", VA = "0x185F04120")]
		private void PGPNEFPDFCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x25EB720", Offset = "0x25EAB20", VA = "0x1825EB720")]
		private void LPOCPHLJAAP<T>(IDictionary<NNPNPEIPKPE, T> LOKAOHHOFAP, IReadOnlyList<T> ALMCJNPFCGG) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5F03E30", Offset = "0x5F03230", VA = "0x185F03E30")]
		public NNPNPEIPKPE FPHJOJFMMIK(FaceFeatureType CGLDKHPBNKD)
		{
			return default(NNPNPEIPKPE);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5F04000", Offset = "0x5F03400", VA = "0x185F04000")]
		public NNPNPEIPKPE NDPECPBJHAC(FaceFeatureType CGLDKHPBNKD)
		{
			return default(NNPNPEIPKPE);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5F04350", Offset = "0x5F03750", VA = "0x185F04350")]
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
