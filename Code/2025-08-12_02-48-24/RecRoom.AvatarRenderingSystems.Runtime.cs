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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x828BAC0", Offset = "0x828A0C0", VA = "0x18828BAC0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x828F380", Offset = "0x828D980", VA = "0x18828F380", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x828F310", Offset = "0x828D910", VA = "0x18828F310", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x828F340", Offset = "0x828D940", VA = "0x18828F340")]
		public RecNetCDNAssetReference(RecNetCDNKey HFLDIIIPBCG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum NMJGPCHINGI : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NMJGPCHINGI PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF51DC0", Offset = "0xF503C0", VA = "0x180F51DC0")]
			[CompilerGenerated]
			get
			{
				return default(NMJGPCHINGI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15CE8A0", Offset = "0x15CCEA0", VA = "0x1815CE8A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x828F490", Offset = "0x828DA90", VA = "0x18828F490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x828F410", Offset = "0x828DA10", VA = "0x18828F410")]
		public static RecNetCDNKey OGJKFODLOID(string KMMAJKFGGLA, NMJGPCHINGI EKJJOOPLHPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x828F3C0", Offset = "0x828D9C0", VA = "0x18828F3C0")]
		public void JNNONDJLDNE(string FEJHDCDDLHB, string PDDACHIAKKM, bool BIGNEIHIIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KALHGBCMMAN]
public class IOHHJGKADIO : BDAOGDLPNKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> PLHJIKGDAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> JLLFLLIJCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> DDCGAIEFIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> CKGOAGOELJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> LCBNBIIPMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> FNPJEFPNDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> CFLKLAIDCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator DDPHHJIHICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected ADFCGNJBKIO FMMGKKBFGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte CDJPKABLNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> DJBMDBNICDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> BBJMNJJOGCO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8289970", Offset = "0x8287F70", VA = "0x188289970", Slot = "4")]
	public void DEJDNKOJJPA(Mesh LJNJDNJBNIE, Matrix4x4 DDGMCJHIAAM, byte[] IPGCHIAEBJB, bool CKEKEJNKEOJ = false, LINIKLIADHK.NMCDOKKFLGH GPMPDPGHJDO = (LINIKLIADHK.NMCDOKKFLGH)0L, int EHEJJKOLIBO = -1, bool NPIJNAADGDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8289CA0", Offset = "0x82882A0", VA = "0x188289CA0", Slot = "5")]
	public void DIEOHGCKJHG(Allocator EKNOCGFFMAE, ADFCGNJBKIO IFLCEKHACJG, byte DGOBHPFHGDA, [Optional] IList<int> FBBIAMIOOHL, [Optional] IList<int> NKDFPOJPDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8289CE0", Offset = "0x82882E0", VA = "0x188289CE0")]
	private static void IGIKBGPPFNJ(Mesh LJNJDNJBNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8289F40", Offset = "0x8288540", VA = "0x188289F40")]
	public IOHHJGKADIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[KALHGBCMMAN]
public struct EHCGAPPDOBB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public JHAABMJEPGP MEHJHPEPCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int IKMLLDPNPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public MMDIFEOMDPG FGFCLJKFAMD;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8279B20", Offset = "0x8278120", VA = "0x188279B20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[KALHGBCMMAN]
public struct MMDIFEOMDPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct LBGGGFEIFIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 DJMAMEHMOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 NNMAALGIDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 KDCHPNLBIGB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct NBAMDKBBIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float BJAPDLAEILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float JIKLIIALPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float IDJFKJKFJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float DIAMLONAONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte BNFAEPLGCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte JIIJIHKHGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte HICDBGNFJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte ICIAKALKGIE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MADNLCPKEDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half BJAPDLAEILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half JIKLIIALPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half IDJFKJKFJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half DIAMLONAONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte BNFAEPLGCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte JIIJIHKHGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte HICDBGNFJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte ICIAKALKGIE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct KKACEDDPMPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 ONDGBPEOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 DGDOPBCAIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 JPIOLJGOFPF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct AJECLDHMNBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half4 ONDGBPEOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 DGDOPBCAIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 LNDHPDAIOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half4 JPIOLJGOFPF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PBIKPLEJPAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 ONDGBPEOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 DGDOPBCAIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half2 LNDHPDAIOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 CNGDGKPIOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half4 JPIOLJGOFPF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct FFMKKLNHMKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half4 ONDGBPEOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 DGDOPBCAIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public half2 LNDHPDAIOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public half2 CNGDGKPIOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public half2 NGGPFGBMKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public half4 JPIOLJGOFPF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct CCBMPMBIENE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float BJAPDLAEILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float JIKLIIALPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float IDJFKJKFJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float DIAMLONAONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int BNFAEPLGCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int JIIJIHKHGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int HICDBGNFJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int ICIAKALKGIE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EHCNLKLAJFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color ONDGBPEOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 DGDOPBCAIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4 JPIOLJGOFPF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PHNIMKNFFBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Color ONDGBPEOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 DGDOPBCAIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector2 LNDHPDAIOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4 JPIOLJGOFPF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct JJPFKLKAJKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Color ONDGBPEOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 DGDOPBCAIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 LNDHPDAIOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Vector2 CNGDGKPIOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector4 JPIOLJGOFPF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct KJIPHHBFFEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Color ONDGBPEOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector2 DGDOPBCAIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector2 LNDHPDAIOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Vector2 CNGDGKPIOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Vector2 NGGPFGBMKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Vector4 JPIOLJGOFPF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool PHJMHONIAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<LBGGGFEIFIJ> MEOIMILBBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<KKACEDDPMPE> EPNHMFFFJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<AJECLDHMNBB> LLNNPPJDHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<PBIKPLEJPAP> DPKHNOFCMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<FFMKKLNHMKI> CGDEMPFBDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<MADNLCPKEDB> OKFANPBHNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<NBAMDKBBIND> LLBDGCPEALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<EHCNLKLAJFG> BAGEACKLIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<PHNIMKNFFBD> JDDLNMDFAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<JJPFKLKAJKI> AKAHCBLCFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<KJIPHHBFFEP> AGIGOKHOMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<CCBMPMBIENE> MDPHBIBEINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> BPKDJABOMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> GAFCONBKJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> OAHFCKKPCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> BKIMOOJLINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> GMAANJBPIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> LIJEHPGGJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> NNBHFFIHODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> BPFJDCAFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> MHCCEBNBPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool JKPJGIONELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool IIKGJPNBKKO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GKLGPHAJCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x828BB60", Offset = "0x828A160", VA = "0x18828BB60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x828E2D0", Offset = "0x828C8D0", VA = "0x18828E2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OOBHPEMMHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x828BB50", Offset = "0x828A150", VA = "0x18828BB50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x828DBD0", Offset = "0x828C1D0", VA = "0x18828DBD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JLGFNNOHNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x828C7E0", Offset = "0x828ADE0", VA = "0x18828C7E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x828C7F0", Offset = "0x828ADF0", VA = "0x18828C7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HKHHDPOAFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x828E260", Offset = "0x828C860", VA = "0x18828E260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x828E3B0", Offset = "0x828C9B0", VA = "0x18828E3B0")]
	public MMDIFEOMDPG(int DJHLMNEKGGH, int LPLHHIKFNHD, int EHJPDOFDBIJ, int MEGPPNFBPJN, Allocator EKNOCGFFMAE, int GOPEAFJACOG, NPEBOIFLFMI HONLLOEGAFI, bool JKPJGIONELF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x828BB70", Offset = "0x828A170", VA = "0x18828BB70")]
	public void DHHJFOFAJFI(int LEPAEEGOBDO, Vector3 EFGJHINBPCN, Vector3 IODKHMMPFHJ, Vector4 IHNLGGEEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x828DE30", Offset = "0x828C430", VA = "0x18828DE30")]
	public void MIPBIFNOPNB(int LEPAEEGOBDO, BoneWeight NANKEGIIPHP, NativeSlice<byte> IPGCHIAEBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x828C3D0", Offset = "0x828A9D0", VA = "0x18828C3D0")]
	public Color FKHBONJDICM(int LEPAEEGOBDO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x828C800", Offset = "0x828AE00", VA = "0x18828C800")]
	public void HPPGGGIILAE(int LEPAEEGOBDO, Color JNNOBIJIOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x828C6F0", Offset = "0x828ACF0", VA = "0x18828C6F0")]
	public void FMFPPNEPHAM(int LEPAEEGOBDO, Vector3 DPLNHDFCMOI, Vector3 GMMMPDDILLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x828C280", Offset = "0x828A880", VA = "0x18828C280")]
	public void FJLOMAEFAFI(int LEPAEEGOBDO, half4 DOAMBHPAMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x828DBE0", Offset = "0x828C1E0", VA = "0x18828DBE0")]
	public void MIHFBDFODGF(int LEPAEEGOBDO, Vector3 DOAMBHPAMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x828BC00", Offset = "0x828A200", VA = "0x18828BC00")]
	public void DPLIMLLICBD(byte EDFOAAOPOJL, int LEPAEEGOBDO, Vector2 DOAMBHPAMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x828C270", Offset = "0x828A870", VA = "0x18828C270")]
	public void FGJPLABCFFD(int LEPAEEGOBDO, int FAEAOHJJNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x828DB70", Offset = "0x828C170", VA = "0x18828DB70")]
	public bool LAFEFGJEGOK(int EDFOAAOPOJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x828E2E0", Offset = "0x828C8E0", VA = "0x18828E2E0")]
	public void PKINOLABFPI(int MJEBNFGNEOI, int EFCGAKGCCGN, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x828C010", Offset = "0x828A610", VA = "0x18828C010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x828CC30", Offset = "0x828B230", VA = "0x18828CC30")]
	public Mesh IDLNFBDILNI([Optional] string PNCKMMICNLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[KALHGBCMMAN]
[NativeContainer]
public struct JHAABMJEPGP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Mesh.MeshDataArray MPCFEBDDMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> HCGPDCPJBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<int> ONEBKPHCIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<BoneWeight> BPFJDCAFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<Matrix4x4> HKMOPCNBNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<long> FFKBPPFPOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<byte> NBEPHCFMPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<int> MBJKFGLIJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<int> GLAFEAJOIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeArray<sbyte> JKDKHNCCDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<byte> FHIELFNIEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<bool> NPIJNAADGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<int> EHEJJKOLIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool JKPJGIONELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<int> KMMLIDEJMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool IIKGJPNBKKO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ONJGDLJHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x828A8A0", Offset = "0x8288EA0", VA = "0x18828A8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BPKKLGBELAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x828A3E0", Offset = "0x82889E0", VA = "0x18828A3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int MPICADOGIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x828A7D0", Offset = "0x8288DD0", VA = "0x18828A7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CKCHMDKICDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x828A8B0", Offset = "0x8288EB0", VA = "0x18828A8B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x828A8E0", Offset = "0x8288EE0", VA = "0x18828A8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GKLGPHAJCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x828A2E0", Offset = "0x82888E0", VA = "0x18828A2E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x828A8D0", Offset = "0x8288ED0", VA = "0x18828A8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int FAKIOMIKMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x828A3D0", Offset = "0x82889D0", VA = "0x18828A3D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x828A3F0", Offset = "0x82889F0", VA = "0x18828A3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ADFCGNJBKIO ANHMEBDCIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x828A2D0", Offset = "0x82888D0", VA = "0x18828A2D0")]
		get
		{
			return default(ADFCGNJBKIO);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x828A8C0", Offset = "0x8288EC0", VA = "0x18828A8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte LBHIHEAGHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x828A3C0", Offset = "0x82889C0", VA = "0x18828A3C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x828A2C0", Offset = "0x82888C0", VA = "0x18828A2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public PCKDECHKLNF BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x828A580", Offset = "0x8288B80", VA = "0x18828A580")]
		get
		{
			return default(PCKDECHKLNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x828A8F0", Offset = "0x8288EF0", VA = "0x18828A8F0")]
	public JHAABMJEPGP(IList<Mesh> AKGOPLCGDLC, IList<Matrix4x4> NJGEDNMKNCI, IList<bool> NPIJNAADGDM, byte DGOBHPFHGDA, IList<byte[]> GHGGCPCPHHP, IList<long> NMBECLDFFCM, IList<bool> EJGOBBKEOJN, IList<int> EHEJJKOLIBO, IList<int> FBBIAMIOOHL, IList<int> LONKAPJENKE, Allocator EKNOCGFFMAE, ADFCGNJBKIO IFLCEKHACJG, bool JKPJGIONELF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x828A2F0", Offset = "0x82888F0", VA = "0x18828A2F0")]
	public MMDIFEOMDPG CEGIEOMABNG(Allocator EKNOCGFFMAE, NPEBOIFLFMI HONLLOEGAFI)
	{
		return default(MMDIFEOMDPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x828A400", Offset = "0x8288A00", VA = "0x18828A400", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[KALHGBCMMAN]
public class PGKOLNHALHB : IOHHJGKADIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool MDKJGFDKCHE;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly ProfilerMarker HFMHGFNHCEN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x828F040", Offset = "0x828D640", VA = "0x18828F040")]
	public JHAABMJEPGP JBMOKGDPENM()
	{
		return default(JHAABMJEPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x828F300", Offset = "0x828D900", VA = "0x18828F300")]
	public PGKOLNHALHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PCKDECHKLNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Mesh.MeshData OPHIJEJDLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeSlice<BoneWeight> BPFJDCAFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeSlice<byte> OLHINAKEFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public int HHPKCPMHJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Matrix4x4 DMKLNODALDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public long OABHIGPHLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeSlice<byte> IPGCHIAEBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool BNIELKPGFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int JCFBJDPHJKC;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GJFNGGHJKCH : BGCOFBKKHJK
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NNOEKAJKOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GJFNGGHJKCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public BCEMNDENGIG buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Action<KeyValuePair<string, LHNBHFNPODB<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NNOEKAJKOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x828EF80", Offset = "0x828D580", VA = "0x18828EF80")]
		internal bool GFNLDELJLHE(FBGBKPGFJBB item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x828EDE0", Offset = "0x828D3E0", VA = "0x18828EDE0")]
		internal void AIDLOLAJDKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x828EFC0", Offset = "0x828D5C0", VA = "0x18828EFC0")]
		internal void GLAKCNDACCI(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x828EDE0", Offset = "0x828D3E0", VA = "0x18828EDE0")]
		internal void EDGLNNJKMBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x828EFC0", Offset = "0x828D5C0", VA = "0x18828EFC0")]
		internal void NEJCOFDOMBH(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x828EFE0", Offset = "0x828D5E0", VA = "0x18828EFE0")]
		internal void ICEKELLNKGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x828F010", Offset = "0x828D610", VA = "0x18828F010")]
		internal void PIBJFAELNLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x828EE00", Offset = "0x828D400", VA = "0x18828EE00")]
		internal void EEMFGIKCJNH(Dictionary<string, LHNBHFNPODB<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x828EEC0", Offset = "0x828D4C0", VA = "0x18828EEC0")]
		internal void FLONMOCDJJP(KeyValuePair<string, LHNBHFNPODB<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		internal CNOKEDEBLOH MIMJPEPAIOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EJDNFPHOFMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public NNOEKAJKOAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EJDNFPHOFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x827B4B0", Offset = "0x8279AB0", VA = "0x18827B4B0")]
		internal JMELGOAGEHE KFBGEDMBLHM(int lod)
		{
			return default(JMELGOAGEHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LOMJJLGLBBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public LDNIFFJFEMD<Dictionary<string, LHNBHFNPODB<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LOMJJLGLBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		internal LDNIFFJFEMD<Dictionary<string, LHNBHFNPODB<Texture2D>>> NLFMJAKPAPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IOLHLGILEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public List<BCEMNDENGIG> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IOLHLGILEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x828A190", Offset = "0x8288790", VA = "0x18828A190")]
		internal void HMIJLEBEOEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DOCHNLHBHDA : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public GJFNGGHJKCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<GBNDABFCGHN> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public List<BCEMNDENGIG> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Func<int, JMELGOAGEHE> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public DOCILOBOALA materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public DOCHNLHBHDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8279850", Offset = "0x8277E50", VA = "0x188279850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8279AD0", Offset = "0x82780D0", VA = "0x188279AD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OBLLLMLMHIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public PGFLBANDMJA cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public OBLLLMLMHIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xBE3D20", Offset = "0xBE2320", VA = "0x180BE3D20")]
		internal void OFIHNJNBDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xE4AA10", Offset = "0xE49010", VA = "0x180E4AA10")]
		internal void IBBBAOFHLGG(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MOMOPHGEANJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public GJFNGGHJKCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public List<(int mat, int part)> avatarItemMaterialPartIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public List<Bounds> avatarPartMeshBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MOMOPHGEANJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FDDHGAHJOHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public MMDIFEOMDPG defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public JHAABMJEPGP defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public MOMOPHGEANJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public FDDHGAHJOHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x827B5E0", Offset = "0x8279BE0", VA = "0x18827B5E0")]
		internal void OAOKHBFELEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x827B570", Offset = "0x8279B70", VA = "0x18827B570")]
		internal void CELNDEIPJDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DKNHPHIFBNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public PBNCKBPLNBK legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public BPMDLCHLKPK legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MOMOPHGEANJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public DKNHPHIFBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8279610", Offset = "0x8277C10", VA = "0x188279610")]
		internal void BINEFNFGMOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x82795A0", Offset = "0x8277BA0", VA = "0x1882795A0")]
		internal void BDNLHLPGFDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EGEMHHAAIDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GJFNGGHJKCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EGEMHHAAIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8299E30", Offset = "0x8298430", VA = "0x188299E30")]
		internal void HCGMOBGAOGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MFOFCLKEHFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CNFLLNFLBIO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MFOFCLKEHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x82A2510", Offset = "0x82A0B10", VA = "0x1882A2510")]
		internal bool KMGPCIFMEKJ(KeyValuePair<string, FBGBKPGFJBB> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly HBPNKKOKOOA LKONDBIOJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HBPNKKOKOOA DCMLPKJALOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Dictionary<LEJNJPPLAEC, float> GFMCFIEJHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Dictionary<JLMLEMJCHNF, float> LOBDCCFJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Dictionary<LFLPBIOKFCJ, float> NFLNGAOECMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, EELGJACIFLF> NKEMPMAPFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Dictionary<string, EELGJACIFLF> KIDKOKJBEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<string, EELGJACIFLF> GBDILAAAMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<string, EELGJACIFLF> OAIIEBLEJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private AMHMHHMNFOE CHODJEFKDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AMHMHHMNFOE GCBPKCDONIL;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static float EALECEKHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool? OFBPLOPFCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool? KOOCOIMDHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool? DEANINONPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool? IGCHGEMFODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private AvatarConfiguration AHDBGJKHBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Transform NDFKJFIKKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private AvatarSkinAssetItem MFGDKDBGIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AssetReference LLJLKGELBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private AssetReference LKDLHMKBNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private AssetReference KKJEFPJBIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private AssetReference FOHIOIHHPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private GameObject NOHAGMBONCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private GameObject INAKHBHGOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private GameObject FCHCBBNNKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private SkinnedMeshRenderer FFDIPHIELBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarSkinnedMeshBoneOrderRemapsData IMLPKFKEMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform[] KNNBJNOFLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Matrix4x4[] FOPFDKBCCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Material KOGCHELABDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Material IDPBCELHKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Material FLGHLIPMLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Material EAOIKPFPIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Material JOCFDIKCBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Shader DANCNFGAAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Shader PIFGCINPOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Animator CIJEHMNHDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Renderer[] KMLOOEBJMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private LINIKLIADHK.NMCDOKKFLGH KMPGNPOFPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private AvatarBodyPartShapesManager OIAJLPMOPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private IReadOnlyDictionary<string, Transform> POALGGILEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AvatarFaceShapeData.KOALFKINNKC DKNPPPKKEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private AvatarBodyShapeData.CFHDLNLOOGA BCDLJJNMGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private DNBLNCAFAFK MMEOFCCBBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool FAPDIOJGCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x145")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool FIICIPHDPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Color AOJGNAKAKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Color HMPKFKJBKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Color IDIKLDDPHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Color? CFCOENEBKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Color? KHKJHGEEJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Color? EPHIDMFFCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Color? NAHLDBGNFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Texture2D IEGEKILPAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Texture2D FBLCFIBIJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[CanBeNull]
	private FBGBKPGFJBB PBLPOLGEALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Texture IPCHALDNEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Color HCNHKOEABAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Dictionary<Renderer, DOCILOBOALA> DLNBBAACCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Dictionary<Renderer, DOCILOBOALA> DPPDCMIEIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Dictionary<string, List<GKAADCENOFF>> AEHOPIAPBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<string, List<GKAADCENOFF>> BBMBMBNHBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly List<LOOEBIAEJGK> FEDGHPJFOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly List<LOOEBIAEJGK> CCENLNEMIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly List<LOOEBIAEJGK> IDPHDMBAFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly List<LOOEBIAEJGK> FGOBNAOPJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Dictionary<GKAADCENOFF, Material> GLFPLBHHGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Dictionary<GKAADCENOFF, Material> MKGCMCPJFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private SkinnedMeshRenderer[] DGJMILLAOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private SkinnedMeshRenderer[] JFBAGDJNABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private SkinnedMeshRenderer[] FGKAAPFFEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private SkinnedMeshRenderer[] CCBFCEGIIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, LHNBHFNPODB<Texture2D>> BFBBDLAMACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<string, LHNBHFNPODB<Texture2D>> OBDHMJOKPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private AdditionalHatData BPDJKCBBCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private AdditionalHatData AAPBBPEBCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private HairData NEINDACBKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private HairData LMFJKECONHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private NKKOKKMIKCN NLCEHHCJDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool? OAMKHLODOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private PositionAndRotation MIBIEMOLIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Transform PNKGHEIDPND;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private Material MODLDOLMIJK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Material GHHKAANHMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Dictionary<string, FBGBKPGFJBB> BALIONCANHD;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int PFADGCEDFME;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int JENHCOGNGOB;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int EIOIBOFLAAO;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int JFOJEMMKKJK;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int MKBNFCKIODK;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int PPGFICFGCHO;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int JLNFIOKGPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool POGMPAKEDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private List<Action> BAGNKKLIFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private KJDPPPJGPNL MGDOPAOCHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private SkinnedMeshRenderer[] BGJJNCFHAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private int MIODFDGLKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool AFHKENDMHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int HDJHNCFDENH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HBPNKKOKOOA CNIAFDFLFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public HBPNKKOKOOA BELHGFIDPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private NLLNDLCIBOH GKOADHMGHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8282AB0", Offset = "0x82810B0", VA = "0x188282AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool DJLLKAPDGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8283090", Offset = "0x8281690", VA = "0x188283090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool DPNALHPJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8284E30", Offset = "0x8283430", VA = "0x188284E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool NGLCJDMOFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x827DC30", Offset = "0x827C230", VA = "0x18827DC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool JANCBCKGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x827FD70", Offset = "0x827E370", VA = "0x18827FD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration APOGJOMMIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HEJJKGFADJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8283C00", Offset = "0x8282200", VA = "0x188283C00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x827FF70", Offset = "0x827E570", VA = "0x18827FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material IGGIJEDOIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x827DD20", Offset = "0x827C320", VA = "0x18827DD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material IELPONMJIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8286DE0", Offset = "0x82853E0", VA = "0x188286DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool PDPNAFFOPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GAPGDDKJAHD JONCMKBDACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x827DD10", Offset = "0x827C310", VA = "0x18827DD10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(GAPGDDKJAHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8282610", Offset = "0x8280C10", VA = "0x188282610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material KNCHGFPOIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB229F0", Offset = "0xB20FF0", VA = "0x180B229F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] GGPFJOAENCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xBA8400", Offset = "0xBA6A00", VA = "0x180BA8400", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] BLPEOGDHMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAFB5F0", Offset = "0xAF9BF0", VA = "0x180AFB5F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JGEJILECMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8284F10", Offset = "0x8283510", VA = "0x188284F10", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public LINIKLIADHK.NMCDOKKFLGH BHOOAKONFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC010F0", Offset = "0xBFF6F0", VA = "0x180C010F0", Slot = "20")]
		get
		{
			return default(LINIKLIADHK.NMCDOKKFLGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NNIJBBGPGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x82850A0", Offset = "0x82836A0", VA = "0x1882850A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8282450", Offset = "0x8280A50", VA = "0x188282450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool DDGDMEJNLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8285730", Offset = "0x8283D30", VA = "0x188285730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool CBBHPDJKDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8282BD0", Offset = "0x82811D0", VA = "0x188282BD0", Slot = "15")]
	public BCEMNDENGIG JENLFENHCPF(DOCFJJABDFF JLHBCDBJOJK, bool JPNHFHJDILC, int[] KEEKDKJJLJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8282560", Offset = "0x8280B60", VA = "0x188282560", Slot = "14")]
	public BCEMNDENGIG IDMBIOFGAMG(DOCFJJABDFF JLHBCDBJOJK, bool JPNHFHJDILC, int[] KEEKDKJJLJA, Func<Dictionary<string, FBGBKPGFJBB>, (BCEMNDENGIG, LDNIFFJFEMD<Dictionary<string, LHNBHFNPODB<Texture2D>>>)> CIALMHNOILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x827BCC0", Offset = "0x827A2C0", VA = "0x18827BCC0")]
	public BCEMNDENGIG ACAEEMMHJBO(DOCFJJABDFF JLHBCDBJOJK, bool JPNHFHJDILC, int[] KEEKDKJJLJA, bool LJEPHEGFNLL, AMHMHHMNFOE JINDFKCKEEA, [Optional] Func<Dictionary<string, FBGBKPGFJBB>, (BCEMNDENGIG, LDNIFFJFEMD<Dictionary<string, LHNBHFNPODB<Texture2D>>>)> CIALMHNOILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8288D70", Offset = "0x8287370", VA = "0x188288D70")]
	private bool PNNABKBLNED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8283610", Offset = "0x8281C10", VA = "0x188283610")]
	private BCEMNDENGIG LBFDNDAHHGI(bool JPNHFHJDILC, List<GBNDABFCGHN> HPIIPAPEOFA, int[] KEEKDKJJLJA, Func<int, JMELGOAGEHE> PHOHIHIOIOJ, bool LJEPHEGFNLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8285610", Offset = "0x8283C10", VA = "0x188285610")]
	[IteratorStateMachine(typeof(DOCHNLHBHDA))]
	private IEnumerator<BJJPNELKDDJ> NDFCDAJAAEK(bool JPNHFHJDILC, List<GBNDABFCGHN> HPIIPAPEOFA, int[] KEEKDKJJLJA, Func<int, JMELGOAGEHE> PHOHIHIOIOJ, DOCILOBOALA PPMEMDAPBGM, Material BHCKBGCCDLE, List<BCEMNDENGIG> GDLEGDKPLJJ, bool BHECEDFCBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8281270", Offset = "0x827F870", VA = "0x188281270")]
	private void FPPKIJHMBEM(List<GBNDABFCGHN> HPIIPAPEOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8282D80", Offset = "0x8281380", VA = "0x188282D80")]
	private BCEMNDENGIG JHIJDIJLCME(List<GBNDABFCGHN> HPIIPAPEOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82859B0", Offset = "0x8283FB0", VA = "0x1882859B0")]
	private APLPOCKIJEJ NMDCODBPJBB(List<GBNDABFCGHN> HPIIPAPEOFA, int EEPEOPEEIMF, bool JPNHFHJDILC, JMELGOAGEHE CGCOAIEEKKE, bool NIPEAAIDKGA, DOCILOBOALA PPMEMDAPBGM, Material BHCKBGCCDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8284300", Offset = "0x8282900", VA = "0x188284300", Slot = "27")]
	public void LJMFLNJNOIC(LEJNJPPLAEC DPEDINMGGCJ, float FKMNCAKIOFK, bool MFEMPBPAPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8281C00", Offset = "0x8280200", VA = "0x188281C00", Slot = "29")]
	public void GIMOBFEKDJJ(JLMLEMJCHNF LBPJEIAHAMD, float FKMNCAKIOFK, bool HOGHHCEKAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8282470", Offset = "0x8280A70", VA = "0x188282470", Slot = "30")]
	public void HMHNMCLFFII(LFLPBIOKFCJ BIMFMAMODJM, float FKMNCAKIOFK, bool FNEIALKHIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8288690", Offset = "0x8286C90", VA = "0x188288690", Slot = "28")]
	public void PGBLNNPMMJA(bool JCFILGMKEAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8283170", Offset = "0x8281770", VA = "0x188283170", Slot = "31")]
	public void JLPIFKBHENO(bool JCFILGMKEAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8281CE0", Offset = "0x82802E0", VA = "0x188281CE0", Slot = "32")]
	public void GJLMEALDBOP(bool JCFILGMKEAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8282620", Offset = "0x8280C20", VA = "0x188282620")]
	private void IJCCDPMNLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8282B20", Offset = "0x8281120", VA = "0x188282B20")]
	private void IMABDEJJABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82832A0", Offset = "0x82818A0", VA = "0x1882832A0")]
	private void KBIAEPDACAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8282FD0", Offset = "0x82815D0", VA = "0x188282FD0", Slot = "25")]
	public void JJCEKIDIAIN(AvatarFaceShape GDEBJFFEGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8287550", Offset = "0x8285B50", VA = "0x188287550", Slot = "26")]
	public void OEELGFBLKLE(AvatarBodyShape MPOJLHMBMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8283600", Offset = "0x8281C00", VA = "0x188283600", Slot = "33")]
	public void LALKOPABAAG(DNBLNCAFAFK OAJAMIMOOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8288990", Offset = "0x8286F90", VA = "0x188288990", Slot = "35")]
	public void PKJLBFMJEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x827E8B0", Offset = "0x827CEB0", VA = "0x18827E8B0", Slot = "41")]
	public void CAOBIJIAHED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8281110", Offset = "0x827F710", VA = "0x188281110", Slot = "34")]
	public void FNEAJOJMAID(bool HABIFIEABOH, bool FICELEFKPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8280110", Offset = "0x827E710", VA = "0x188280110")]
	private void FCEOGEIOBFI(SkinnedMeshRenderer PCIHNDAFKLO, int EEPEOPEEIMF, Mesh LJNJDNJBNIE, List<Material> BOBMECGHEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x827FF80", Offset = "0x827E580", VA = "0x18827FF80")]
	private static Material FALFDHEKHHO(Dictionary<GKAADCENOFF, Material> LLINHEGJMKN, Material HFKOJHOBIIO, FGAMIEKEMIN MNAHCNBLCAI, AJKPMNIKDDJ MHAGPICIDAI, CNFLLNFLBIO CGKEIIDMLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x827E5C0", Offset = "0x827CBC0", VA = "0x18827E5C0")]
	private static FGAMIEKEMIN BCNFFFCMDMD(GBNDABFCGHN MPBAPJEHKLD, int COFJHONJGIJ)
	{
		return default(FGAMIEKEMIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82826A0", Offset = "0x8280CA0", VA = "0x1882826A0")]
	private void ILBNKMKGGHM(int LIJMKKBPIGG, Material JKDFAJLFBEL, GBNDABFCGHN MPBAPJEHKLD, [Out] Texture2D JJLFHHCIFOB, [Out] Vector4 LACEIOJGBFD, [Out] Texture2D NGGGBMLEFCB, [Out] Texture2D BMECKEAMLCK, [Out] Texture2D MNKKNFKOHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x827F2F0", Offset = "0x827D8F0", VA = "0x18827F2F0")]
	private void DDFDPDPAMND(int LIJMKKBPIGG, Material JKDFAJLFBEL, GBNDABFCGHN MPBAPJEHKLD, [Out] Color FLBNNCEFFNJ, [Out] Color EKIHOOEAHFC, [Out] Color GLIOJJENHLP, [Out] Color GNDAMCHEKMO, [Out] Color DIFAOKDGHJK, [Out] Color OBFDGEJHJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x82818D0", Offset = "0x827FED0", VA = "0x1882818D0")]
	private bool GAMDAOLKLMF(Material JKDFAJLFBEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x827FBB0", Offset = "0x827E1B0", VA = "0x18827FBB0")]
	private static Material DJOFLJOANIB(int LIJMKKBPIGG, ENJKNMNOLED MPBAPJEHKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x827FC90", Offset = "0x827E290", VA = "0x18827FC90")]
	private static AJKPMNIKDDJ EDDMIENGJBH(GBNDABFCGHN MPBAPJEHKLD, int COFJHONJGIJ)
	{
		return default(AJKPMNIKDDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8283C10", Offset = "0x8282210", VA = "0x188283C10")]
	private static void LCAOKMGLODL(Dictionary<string, List<GKAADCENOFF>> GKLIJOFCGJM, GBNDABFCGHN MJMCGHLLAPJ, Material HFKOJHOBIIO, FGAMIEKEMIN LKFLFFGPJIL, AJKPMNIKDDJ GKBBGLJBHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8282220", Offset = "0x8280820", VA = "0x188282220")]
	private static SkinnedMeshRenderer HLJJNLNDBNM(Transform ELFJLIPEJHG, Transform CHGBNCCONBP, SkinnedMeshRenderer[] GECBOGLJJBN, int EEPEOPEEIMF, JMELGOAGEHE CGCOAIEEKKE, bool JPNHFHJDILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8288FB0", Offset = "0x82875B0", VA = "0x188288FB0")]
	public GJFNGGHJKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8283F10", Offset = "0x8282510", VA = "0x188283F10")]
	public void LJDCNOCKLGC([In] MHLKPBLGENH EOIGNAKNLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x827E6D0", Offset = "0x827CCD0", VA = "0x18827E6D0")]
	public void OJBDAEJKGJC([In] DFGLAOHADBO PDENOHBPLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8282450", Offset = "0x8280A50", VA = "0x188282450", Slot = "5")]
	public void HMFOOONEBFL(int EEPEOPEEIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8282000", Offset = "0x8280600", VA = "0x188282000", Slot = "10")]
	public void HINNDMGFNKC(BLPLKKCPBII GKBBGLJBHBJ, Texture2D BHNOPLHICEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
	public static bool KPMEGLCFGNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8286C60", Offset = "0x8285260", VA = "0x188286C60", Slot = "11")]
	public bool NPMACEHGFGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x827F7B0", Offset = "0x827DDB0", VA = "0x18827F7B0", Slot = "9")]
	public void DFHFIDMMMIF(IIPBNGJJJBD LKFLFFGPJIL, Color? ONDGBPEOGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8282590", Offset = "0x8280B90", VA = "0x188282590")]
	private void IDNMJJCAFCK(Action EICFBFGKLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x827EF00", Offset = "0x827D500", VA = "0x18827EF00", Slot = "6")]
	public void CNLNLFPOGEG(FBGBKPGFJBB BNMBOEAPFJM, Texture KBFIBCCAFAF, Color FPJACMPEHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x827FF70", Offset = "0x827E570", VA = "0x18827FF70", Slot = "7")]
	public void EKOCMOPPAGP(bool BHECEDFCBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xB225E0", Offset = "0xB20BE0", VA = "0x180B225E0", Slot = "8")]
	public void JGPECJMOIMM(KJDPPPJGPNL MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x82857B0", Offset = "0x8283DB0", VA = "0x1882857B0", Slot = "16")]
	public void NHDIFLHDBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8283320", Offset = "0x8281920", VA = "0x188283320", Slot = "36")]
	public void KHEJILJBAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8287820", Offset = "0x8285E20", VA = "0x188287820", Slot = "37")]
	public void OOILDHBHDOA([Optional] NKKOKKMIKCN CMADCPGPGID, [Optional] bool? IIAAKFMEJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x82886F0", Offset = "0x8286CF0", VA = "0x1882886F0")]
	private bool PGDLIFDFDPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8288670", Offset = "0x8286C70", VA = "0x188288670", Slot = "21")]
	public bool PEHBAMAHLNO(LINIKLIADHK.NMCDOKKFLGH EPGJOCOOIBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8284820", Offset = "0x8282E20", VA = "0x188284820", Slot = "39")]
	public void MBNDFEDKKMD(float DOIPOHHHILF, Color ONDGBPEOGJF, bool OLEHEIMJCED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x827EB70", Offset = "0x827D170", VA = "0x18827EB70")]
	public void CKIKCEHJFAM(float DOIPOHHHILF, Color ONDGBPEOGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x82804D0", Offset = "0x827EAD0", VA = "0x1882804D0")]
	private static bool FJAGEFOJNFA(Material BHCKBGCCDLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x827E210", Offset = "0x827C810", VA = "0x18827E210", Slot = "40")]
	public void AOPCALDDFOB(NBNMALPKJAD KAKCBKKEIIO, LANCEJILHOH BCNHEEPDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8285080", Offset = "0x8283680", VA = "0x188285080")]
	private static bool MIGJCDGBKCD(GKAADCENOFF HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x827F0D0", Offset = "0x827D6D0", VA = "0x18827F0D0")]
	public void DBMFHJKEAEP(NBNMALPKJAD PJPJHLJDEMN, LANCEJILHOH DCHPKNCFGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8286ED0", Offset = "0x82854D0", VA = "0x188286ED0", Slot = "38")]
	public void ODANPEAKGFN(bool EGHPHHOMKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x82850B0", Offset = "0x82836B0", VA = "0x1882850B0")]
	private void MONLINOMFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8283EC0", Offset = "0x82824C0", VA = "0x188283EC0")]
	private void LIDANLHALBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8288830", Offset = "0x8286E30", VA = "0x188288830")]
	private static void PJCFIPGGDJO(Dictionary<GKAADCENOFF, Material> LLINHEGJMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x827EA00", Offset = "0x827D000", VA = "0x18827EA00")]
	private static void CICPNJKOKEE(Dictionary<Renderer, DOCILOBOALA> NCELNKGGKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x827DF60", Offset = "0x827C560", VA = "0x18827DF60")]
	private void AIGPPDKHCEC(SkinnedMeshRenderer[] GECBOGLJJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x827DEC0", Offset = "0x827C4C0", VA = "0x18827DEC0")]
	private void AIELABAICAL(SkinnedMeshRenderer ENBMIILLDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x827DA60", Offset = "0x827C060", VA = "0x18827DA60")]
	private void ADLAGOGOBBB(List<LOOEBIAEJGK> KEEGPMLIONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x82873D0", Offset = "0x82859D0", VA = "0x1882873D0")]
	private void OEAJCJKNLNL(Dictionary<string, LHNBHFNPODB<Texture2D>> GKLIJOFCGJM, bool OBPHEFOLMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x827FE70", Offset = "0x827E470", VA = "0x18827FE70")]
	private void EHFDDCNIJDK(Dictionary<string, List<GKAADCENOFF>> GKLIJOFCGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8281120", Offset = "0x827F720", VA = "0x188281120")]
	private void FNFCCMEIEGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x827E080", Offset = "0x827C680", VA = "0x18827E080")]
	private void AKNAFMMADLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8280AC0", Offset = "0x827F0C0", VA = "0x188280AC0")]
	private void FMPMNGJILLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x82846C0", Offset = "0x8282CC0", VA = "0x1882846C0")]
	private void MBBHNDANKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x82802C0", Offset = "0x827E8C0", VA = "0x1882802C0")]
	private void FIEIIJFOIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8281D40", Offset = "0x8280340", VA = "0x188281D40")]
	private void GLPOCNEACEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8281B30", Offset = "0x8280130", VA = "0x188281B30")]
	private void GCIOKMCNGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x827BBE0", Offset = "0x827A1E0", VA = "0x18827BBE0")]
	private void AALPAFJNFII(bool PLAMJNCNKLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x827E750", Offset = "0x827CD50", VA = "0x18827E750")]
	private void BOJEDMDBHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8283380", Offset = "0x8281980", VA = "0x188283380")]
	private void KLHIBDNNEKC(bool PLAMJNCNKLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x827E2A0", Offset = "0x827C8A0", VA = "0x18827E2A0")]
	private void BBCIPJLBGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x82805C0", Offset = "0x827EBC0", VA = "0x1882805C0")]
	private void FLOMACDPKFG(Material BHCKBGCCDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8282C00", Offset = "0x8281200", VA = "0x188282C00")]
	private void JGMCMOFOLJG(Material BHCKBGCCDLE, Color BBDNIGKKAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x82843E0", Offset = "0x82829E0", VA = "0x1882843E0")]
	private void LMECIHKDPJN(Material BHCKBGCCDLE, Color BBDNIGKKAHC, Color BAIKLJPKDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8283460", Offset = "0x8281A60", VA = "0x188283460")]
	private void KNGCIJAMJGH(Material BHCKBGCCDLE, Color FLBNNCEFFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8287610", Offset = "0x8285C10", VA = "0x188287610")]
	private void OEHEIAELIKO(Material BHCKBGCCDLE, Texture2D BHNOPLHICEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8281E90", Offset = "0x8280490", VA = "0x188281E90")]
	private void HDDKGBCACMI(Material BHCKBGCCDLE, Texture KEGFHNDCLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x827EF70", Offset = "0x827D570", VA = "0x18827EF70")]
	private void DBEHNBLMAPN(Action<DOCILOBOALA> IHOHNINDBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8280350", Offset = "0x827E950", VA = "0x188280350")]
	private void FIHBMGLDIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8284980", Offset = "0x8282F80", VA = "0x188284980")]
	private void MDOJGJDINMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8287000", Offset = "0x8285600", VA = "0x188287000")]
	private void ODOPCJIBEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8285280", Offset = "0x8283880", VA = "0x188285280")]
	public void MPGPMJDOPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x827E6D0", Offset = "0x827CCD0", VA = "0x18827E6D0", Slot = "4")]
	private void BMEPGHHNDOM([In] DFGLAOHADBO PDENOHBPLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8283ED0", Offset = "0x82824D0", VA = "0x188283ED0")]
	[CompilerGenerated]
	private CNOKEDEBLOH LIIELPBAKNO(GBNDABFCGHN JHCGOEHIHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8281080", Offset = "0x827F680", VA = "0x188281080")]
	[CompilerGenerated]
	private void FNAKJFJMDBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x827FF40", Offset = "0x827E540", VA = "0x18827FF40")]
	[CompilerGenerated]
	private void EJFJKKPBJKG(DOCILOBOALA MEEBPHIPHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x827FC00", Offset = "0x827E200", VA = "0x18827FC00")]
	[CompilerGenerated]
	private void ECFEKCOFHPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x827FE50", Offset = "0x827E450", VA = "0x18827FE50")]
	[CompilerGenerated]
	private void EEIKDMIOCAC(DOCILOBOALA MEEBPHIPHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8284790", Offset = "0x8282D90", VA = "0x188284790")]
	[CompilerGenerated]
	private void MBJIGJBNOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8287800", Offset = "0x8285E00", VA = "0x188287800")]
	[CompilerGenerated]
	private void OMPOANJPGHN(DOCILOBOALA MEEBPHIPHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8284630", Offset = "0x8282C30", VA = "0x188284630")]
	[CompilerGenerated]
	private void LNCELGHMOCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x82818A0", Offset = "0x827FEA0", VA = "0x1882818A0")]
	[CompilerGenerated]
	private void GAGJKGANECP(DOCILOBOALA MEEBPHIPHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8283210", Offset = "0x8281810", VA = "0x188283210")]
	[CompilerGenerated]
	private void KALAAMCJDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x82831D0", Offset = "0x82817D0", VA = "0x1882831D0")]
	[CompilerGenerated]
	private void JMNIMCCMLGJ(DOCILOBOALA MEEBPHIPHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8284DA0", Offset = "0x82833A0", VA = "0x188284DA0")]
	[CompilerGenerated]
	private void MEJDLHMDLGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8280290", Offset = "0x827E890", VA = "0x188280290")]
	[CompilerGenerated]
	private void FIDOMHEIHNN(DOCILOBOALA MEEBPHIPHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x827E820", Offset = "0x827CE20", VA = "0x18827E820")]
	[CompilerGenerated]
	private void CADJGEJAPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8280260", Offset = "0x827E860", VA = "0x188280260")]
	[CompilerGenerated]
	private void FDNPHEACEMC(DOCILOBOALA MEEBPHIPHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x827FEC0", Offset = "0x827E4C0", VA = "0x18827FEC0")]
	[CompilerGenerated]
	private void EJEFKOAFNEL(KeyValuePair<string, LHNBHFNPODB<Texture2D>> CCCCGIJJNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8283200", Offset = "0x8281800", VA = "0x188283200")]
	[CompilerGenerated]
	private void JNAFLKDJJEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x82800E0", Offset = "0x827E6E0", VA = "0x1882800E0")]
	[CompilerGenerated]
	private void FBKPIOAKAKD(DOCILOBOALA MEEBPHIPHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x827EB60", Offset = "0x827D160", VA = "0x18827EB60")]
	[CompilerGenerated]
	private void CKCJJMLNPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8282BA0", Offset = "0x82811A0", VA = "0x188282BA0")]
	[CompilerGenerated]
	private void JEACNGLIHOH(DOCILOBOALA MEEBPHIPHGL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, OKAANANKHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		[Header("Scale")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Vector3? KEMDDJNEPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private bool MELJMJPGMBE;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x828FA30", Offset = "0x828E030", VA = "0x18828FA30", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8290060", Offset = "0x828E660", VA = "0x188290060", Slot = "4")]
		public void UpdateController(float KNMJNADDDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xDB1540", Offset = "0xDAFB40", VA = "0x180DB1540", Slot = "6")]
		public void SetEnabled(bool FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x828FB10", Offset = "0x828E110", VA = "0x18828FB10")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8290480", Offset = "0x828EA80", VA = "0x188290480")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, OKAANANKHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private const float AFJAJNIIPNN = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Vector3 CHOKDANIMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Vector3 BDFBFKCMNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private bool MELJMJPGMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private float BODHFOGAJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private float GGLAGAFBGLK;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8290800", Offset = "0x828EE00", VA = "0x188290800", Slot = "4")]
		public void UpdateController(float KNMJNADDDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1010CD0", Offset = "0x100F2D0", VA = "0x181010CD0", Slot = "6")]
		public void SetEnabled(bool FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8290520", Offset = "0x828EB20", VA = "0x188290520")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x82912C0", Offset = "0x828F8C0", VA = "0x1882912C0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GAGPMCFOOIL : OBKFCAOBFHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int PGNDEJAKDPM;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int PAKGIFBKNPO;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static readonly int GMFMKJIDKPK;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly int AHGKDHOPLKB;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static readonly int PLLOIJOKGLP;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static readonly int LCNGNPGBKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly int HCINOBHLONL;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private static readonly int FHMAHJKAKHI;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly int JPGBIACGNGK;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static readonly int NODOPMAPBLB;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly int BHONAJPGDDL;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly int PMKKCDEMODJ;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly int HCIFEEDMEHG;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly int GJJPFABCCPN;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly int CMCAKJEIEOK;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly int AFBBOPBDMIE;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly int EABJACAINLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Transform PLGJMCNOBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private Transform NLENABLIKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Transform KDLDMOFFPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Transform JADOPNILLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private Transform ACAJEMFKLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Transform PBLFMJLIPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private ILPFPBBJFHD NHICJKHJFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private Material CEOJHCOBKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private SkinnedMeshRenderer[] GOLMPBAMDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly List<Material> DMCBLHIPBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private JBBHGGKGMPI KHEFPNDMDBP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HBPNKKOKOOA PIGCGNHKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private JBBHGGKGMPI IAOHOOCMDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x829B980", Offset = "0x8299F80", VA = "0x18829B980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x829BA00", Offset = "0x829A000", VA = "0x18829BA00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x829CA40", Offset = "0x829B040", VA = "0x18829CA40")]
	public void LJDCNOCKLGC([In] ILPFPBBJFHD KEFCGAIKGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x829C940", Offset = "0x829AF40", VA = "0x18829C940")]
	public void HGBFLHIOLLI([In] PIDPLDEKGBB PDOCNKCEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x829C010", Offset = "0x829A610", VA = "0x18829C010", Slot = "6")]
	public void CPDKMDNOANJ(CFLIBKNOGDA ODOLPEECCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x829D9E0", Offset = "0x829BFE0", VA = "0x18829D9E0")]
	private Vector2 PFIOICJPDCG(Vector2 EBKPJKKCBMO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x829CAF0", Offset = "0x829B0F0", VA = "0x18829CAF0")]
	public void MDKJKGLLGFN([In] EAAJOGBENOL PDOCNKCEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x829BB50", Offset = "0x829A150", VA = "0x18829BB50")]
	private void BNBCPOOMFAH(LKFKKJAOAKM JPHNCDJEELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x829C5B0", Offset = "0x829ABB0", VA = "0x18829C5B0")]
	private void EBPLFKBEDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x829C540", Offset = "0x829AB40", VA = "0x18829C540")]
	private void CPJCIIKCKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x829C540", Offset = "0x829AB40", VA = "0x18829C540", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x829DD50", Offset = "0x829C350", VA = "0x18829DD50")]
	public GAGPMCFOOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x829C940", Offset = "0x829AF40", VA = "0x18829C940", Slot = "5")]
	private void KIKHNJEFHJJ([In] PIDPLDEKGBB PDOCNKCEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x829CA30", Offset = "0x829B030", VA = "0x18829CA30", Slot = "7")]
	private void KHIGJBIIPJG([In] EAAJOGBENOL PDOCNKCEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x829CA20", Offset = "0x829B020", VA = "0x18829CA20")]
	[CompilerGenerated]
	internal static float JHEFOMEANOC(float FKMNCAKIOFK, float LKALHBEFAMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x829BF20", Offset = "0x829A520", VA = "0x18829BF20")]
	[CompilerGenerated]
	internal static void CBAGFFNFGPI(Vector2 IAOFCONEAAE, Vector2 DJMLAOGKINH, Vector2 MLMBLBFOLPC, Vector2 AJNNFOKDGKA, Vector2 BHCLOJJFNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x829C9E0", Offset = "0x829AFE0", VA = "0x18829C9E0")]
	[CompilerGenerated]
	internal static Vector4 IDAOFAKBHLL(Vector2 AANGPKCDGHO, Vector2 ILFCOODFNFF)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, OKAANANKHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private float BODHFOGAJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private bool MELJMJPGMBE;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x82912F0", Offset = "0x828F8F0", VA = "0x1882912F0", Slot = "4")]
		public void UpdateController(float KNMJNADDDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1065430", Offset = "0x1063A30", VA = "0x181065430", Slot = "6")]
		public void SetEnabled(bool FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8291B60", Offset = "0x8290160", VA = "0x188291B60")]
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
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8291C00", Offset = "0x8290200", VA = "0x188291C00")]
		public void PNHKIAJGEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8291B90", Offset = "0x8290190", VA = "0x188291B90")]
		public int AEAGPMIGOKJ(int JECPIAPPEJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MDHIIHIMHAG : JCMCGICHDKL
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x82A2460", Offset = "0x82A0A60", VA = "0x1882A2460", Slot = "24")]
	public override float ABAAPJJHNFP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x82A24B0", Offset = "0x82A0AB0", VA = "0x1882A24B0")]
	public MDHIIHIMHAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JCMCGICHDKL : PNBAICGDONK
{
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int AKDKMAMGPNG;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int LPPFKBHAOMH;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int NGLDCHKLCKJ;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int LJEDJNGOENN;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int AMNHNKFIOCO;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int CILIMDNLPPA;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int EAMNIGLDBJE;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int[] NIDBKCMJPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private GBHCMFENCML NHICJKHJFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private BFECENDFHHM PNKFJEKIFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private int KEFGDMNMMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private float FCBEGOBGCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	protected Animator CIJEHMNHDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	protected AvatarConfiguration AGKPJFGJMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	protected int LABDMKONOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int PDHDFCMHCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int PJKLFDKPLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private bool ELGAEADIFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private GKPDOBPODME IINKLMMNMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private int OOPFDHBBHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private float CKNGEMIAIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private AvatarHandDisplaySettings JKJICHBDAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private GAPGDDKJAHD HLCOLMGBOFF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform BMMLDILBBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 NHELJGNLCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x198DF80", Offset = "0x198C580", VA = "0x18198DF80")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x198DDA0", Offset = "0x198C3A0", VA = "0x18198DDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion DBAOMEOHMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xEA1DE0", Offset = "0xEA03E0", VA = "0x180EA1DE0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x10A58A0", Offset = "0x10A3EA0", VA = "0x1810A58A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GEAGJBBAEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x82A0B40", Offset = "0x829F140", VA = "0x1882A0B40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x82A0670", Offset = "0x829EC70", VA = "0x1882A0670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KOLPBBDLGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xB19E40", Offset = "0xB18440", VA = "0x180B19E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 MOMDNJICPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAC2200", Offset = "0xAC0800", VA = "0x180AC2200", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F60", Offset = "0xAC1560", VA = "0x180AC2F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion ONMOLMJIPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x128CC60", Offset = "0x128B260", VA = "0x18128CC60", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1722750", Offset = "0x1720D50", VA = "0x181722750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DMJJMIOILDN EOJKGMPNMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xB4F190", Offset = "0xB4D790", VA = "0x180B4F190", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(DMJJMIOILDN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xB4E860", Offset = "0xB4CE60", VA = "0x180B4E860", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DMJJMIOILDN NIOELDDCFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB4F180", Offset = "0xB4D780", VA = "0x180B4F180", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(DMJJMIOILDN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xB4E880", Offset = "0xB4CE80", VA = "0x180B4E880", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float KKCKINLDFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xC13000", Offset = "0xC11600", VA = "0x180C13000", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x10B8B40", Offset = "0x10B7140", VA = "0x1810B8B40", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HHMFAGPILLF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x82A0210", Offset = "0x829E810", VA = "0x1882A0210", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x82A0240", Offset = "0x829E840", VA = "0x1882A0240", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool ELGKHICLNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x82A0B20", Offset = "0x829F120", VA = "0x1882A0B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NEJKMHJJHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x82A0B10", Offset = "0x829F110", VA = "0x1882A0B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NMKJFNMDBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x82A0660", Offset = "0x829EC60", VA = "0x1882A0660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool NPDGLEABEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x82A0250", Offset = "0x829E850", VA = "0x1882A0250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x82A0970", Offset = "0x829EF70", VA = "0x1882A0970", Slot = "23")]
	public void LJDCNOCKLGC(GBHCMFENCML KEFCGAIKGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x82A0840", Offset = "0x829EE40", VA = "0x1882A0840")]
	public void HOBHBBLOFOD(BFECENDFHHM MLPODEELIJO, AvatarHandDisplaySettings FCMBNELMFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x82A08E0", Offset = "0x829EEE0", VA = "0x1882A08E0", Slot = "14")]
	public void LBOADPOENCD(bool COPJEOGEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x82A02B0", Offset = "0x829E8B0", VA = "0x1882A02B0", Slot = "13")]
	public void FEDAHDLLHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xC13000", Offset = "0xC11600", VA = "0x180C13000", Slot = "24")]
	public virtual float ABAAPJJHNFP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x82A06B0", Offset = "0x829ECB0", VA = "0x1882A06B0")]
	private int HGFOLMOJABL(DMJJMIOILDN DFGIJBAFLGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x82A0B70", Offset = "0x829F170", VA = "0x1882A0B70")]
	private void NLOMIFJIMJC(int KHFLEOGOBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x82A0220", Offset = "0x829E820", VA = "0x1882A0220", Slot = "15")]
	public bool ALGGCCEEAIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x82A0B30", Offset = "0x829F130", VA = "0x1882A0B30", Slot = "16")]
	public bool NHBKEIIJEJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x82A0890", Offset = "0x829EE90", VA = "0x1882A0890")]
	private DMJJMIOILDN KHOJCIOAAIJ()
	{
		return default(DMJJMIOILDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B320", Offset = "0x1F29920", VA = "0x181F2B320", Slot = "17")]
	public void JDGGBKKGKFM(bool COPJEOGEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x82A0620", Offset = "0x829EC20", VA = "0x1882A0620", Slot = "12")]
	public void FEGECMHBIHK(int KHFLEOGOBEG, float BPLFOMCHKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x82A0D30", Offset = "0x829F330", VA = "0x1882A0D30", Slot = "10")]
	public void PKPABJNPDMI(GKPDOBPODME BJGEPEKIJPC, bool LHMEEOHCMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x82A06A0", Offset = "0x829ECA0", VA = "0x1882A06A0", Slot = "11")]
	public void GHPPIIENFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x82A0260", Offset = "0x829E860", VA = "0x1882A0260", Slot = "18")]
	public void EPBMJDNLKFK(Transform IGDHFGFJBMG, Vector3 MAFINEEGDIM, Quaternion ANPPABHBCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x82A1020", Offset = "0x829F620", VA = "0x1882A1020")]
	public JCMCGICHDKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class ENJKNMNOLED : GBNDABFCGHN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GEAJOJMGHFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public ENJKNMNOLED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public List<LOOEBIAEJGK> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public List<LOOEBIAEJGK> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public LHNBHFNPODB<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LHNBHFNPODB<LIPMOGIAOOH> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GEAJOJMGHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x829DF00", Offset = "0x829C500", VA = "0x18829DF00")]
		internal CNOKEDEBLOH NLMKOEGGKGE(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public FBGBKPGFJBB AJOFMPAFLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public LIPMOGIAOOH ENOCGPKEKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private LHNBHFNPODB<LIPMOGIAOOH> CGNFIAKFCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private LHNBHFNPODB<Material[]> ADJNPCIHODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Material[] LJAOAHNJGOP;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DMCPMOKAHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LINIKLIADHK.NMCDOKKFLGH GFDDDMNIGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return default(LINIKLIADHK.NMCDOKKFLGH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F20", Offset = "0xAA0520", VA = "0x180AA1F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x829B1A0", Offset = "0x82997A0", VA = "0x18829B1A0")]
	public ENJKNMNOLED(CNFLLNFLBIO MMEODAJENEO, FBGBKPGFJBB AHPDCIJENBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x829ABA0", Offset = "0x82991A0", VA = "0x18829ABA0", Slot = "6")]
	public override CNOKEDEBLOH KMOBGACMPJD(List<LOOEBIAEJGK> OINGPGCKCPC, List<LOOEBIAEJGK> DGPJNLLAMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8299FA0", Offset = "0x82985A0", VA = "0x188299FA0")]
	public CNOKEDEBLOH FOGFPDPHMGL(List<LOOEBIAEJGK> OINGPGCKCPC, List<LOOEBIAEJGK> DGPJNLLAMNK, LHNBHFNPODB<Material[]> ADJNPCIHODH, [Optional] LHNBHFNPODB<LIPMOGIAOOH> MEAIAIDOKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x829A830", Offset = "0x8298E30", VA = "0x18829A830")]
	public (LHNBHFNPODB<Material[]>, LHNBHFNPODB<LIPMOGIAOOH>) HMCAPABJMII(List<LOOEBIAEJGK> OINGPGCKCPC, List<LOOEBIAEJGK> DGPJNLLAMNK)
	{
		return default((LHNBHFNPODB<Material[]>, LHNBHFNPODB<LIPMOGIAOOH>));
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8299E70", Offset = "0x8298470", VA = "0x188299E70", Slot = "7")]
	public override JLGDGBKBIEC DHMKECLMIMO(uint EEPEOPEEIMF, AvatarSkinnedMeshBoneOrderRemapsData DNFKOPAIHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x829A620", Offset = "0x8298C20", VA = "0x18829A620")]
	public JLGDGBKBIEC HLLOOCLLKAG(GameObject CMCAPKOEAMD, uint EEPEOPEEIMF, bool KODGKNJGDOA, bool AKLCNPOJAFF, AvatarSkinnedMeshBoneOrderRemapsData DNFKOPAIHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x829A2B0", Offset = "0x82988B0", VA = "0x18829A2B0")]
	public static bool GACIIPBPCND(Renderer[] GECBOGLJJBN, string DCBFHAGDBIN, [Out] Renderer IOPKPBKIDED, [Out] Renderer GNEFFLBGNBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x829B150", Offset = "0x8299750", VA = "0x18829B150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x829B060", Offset = "0x8299660", VA = "0x18829B060")]
	private (LHNBHFNPODB<LIPMOGIAOOH>, LHNBHFNPODB<Material[]>) PDGOKCHHPHA()
	{
		return default((LHNBHFNPODB<LIPMOGIAOOH>, LHNBHFNPODB<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x829B130", Offset = "0x8299730", VA = "0x18829B130")]
	[CompilerGenerated]
	private void POLOAHCMKOJ(LIPMOGIAOOH CENCPMGPALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xA962F0", Offset = "0xA948F0", VA = "0x180A962F0")]
	[CompilerGenerated]
	private void KCFIAMFMNFC(Material[] CENCPMGPALN)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, OKAANANKHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private Vector3 CHOKDANIMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private Vector3 MPBAIJCOIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private Vector3 PCEABCNJIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private Matrix4x4 FEDHLPGOMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private bool MELJMJPGMBE;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8292190", Offset = "0x8290790", VA = "0x188292190", Slot = "4")]
		public void UpdateController(float KNMJNADDDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8292180", Offset = "0x8290780", VA = "0x188292180", Slot = "6")]
		public void SetEnabled(bool FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8291D20", Offset = "0x8290320", VA = "0x188291D20")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8292850", Offset = "0x8290E50", VA = "0x188292850")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[KALHGBCMMAN]
public struct GPOECGAFPJD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[ReadOnly]
	public BPMDLCHLKPK MEHJHPEPCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ReadOnly]
	public int IKMLLDPNPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public PBNCKBPLNBK FGFCLJKFAMD;

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x829EA90", Offset = "0x829D090", VA = "0x18829EA90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[KALHGBCMMAN]
public struct PBNCKBPLNBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector3> PDLJDFBMEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector3> AFNAJNLLECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector4> KDNCCNPNEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector2> NIADOHFPFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector2> CNGDGKPIOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> NGGPFGBMKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> NFODMBDFOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Color> IEHJJOOMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> BPKDJABOMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> GAFCONBKJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private NativeArray<int> OAHFCKKPCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private NativeArray<int> BKIMOOJLINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> GMAANJBPIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> LIJEHPGGJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<int> NNBHFFIHODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<BoneWeight> KMGPLCKFKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NativeArray<int> MHCCEBNBPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private bool IIKGJPNBKKO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int GKLGPHAJCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x82A3E10", Offset = "0x82A2410", VA = "0x1882A3E10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x82A4770", Offset = "0x82A2D70", VA = "0x1882A4770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int OOBHPEMMHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82A3E00", Offset = "0x82A2400", VA = "0x1882A3E00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x82A45C0", Offset = "0x82A2BC0", VA = "0x1882A45C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int JLGFNNOHNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x82A4150", Offset = "0x82A2750", VA = "0x1882A4150")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x82A4160", Offset = "0x82A2760", VA = "0x1882A4160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x82A4850", Offset = "0x82A2E50", VA = "0x1882A4850")]
	public PBNCKBPLNBK(int DJHLMNEKGGH, int LPLHHIKFNHD, int EHJPDOFDBIJ, int MEGPPNFBPJN, Allocator EKNOCGFFMAE, int GOPEAFJACOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x82A3EB0", Offset = "0x82A24B0", VA = "0x1882A3EB0")]
	public void DHHJFOFAJFI(int LEPAEEGOBDO, Vector3 EFGJHINBPCN, Vector3 IODKHMMPFHJ, Vector4 IHNLGGEEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x82A45D0", Offset = "0x82A2BD0", VA = "0x1882A45D0")]
	public void MIPBIFNOPNB(int LEPAEEGOBDO, BoneWeight NANKEGIIPHP, NativeSlice<byte> IPGCHIAEBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x82A4130", Offset = "0x82A2730", VA = "0x1882A4130")]
	public Color FKHBONJDICM(int LEPAEEGOBDO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x82A4220", Offset = "0x82A2820", VA = "0x1882A4220")]
	public void HPPGGGIILAE(int LEPAEEGOBDO, Color JNNOBIJIOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x82A3F20", Offset = "0x82A2520", VA = "0x1882A3F20")]
	public void DPLIMLLICBD(byte EDFOAAOPOJL, int LEPAEEGOBDO, Vector2 DOAMBHPAMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x82A4120", Offset = "0x82A2720", VA = "0x1882A4120")]
	public void FGJPLABCFFD(int LEPAEEGOBDO, int FAEAOHJJNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x82A4590", Offset = "0x82A2B90", VA = "0x1882A4590")]
	public bool LAFEFGJEGOK(int EDFOAAOPOJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x82A4780", Offset = "0x82A2D80", VA = "0x1882A4780")]
	public void PKINOLABFPI(int MJEBNFGNEOI, int EFCGAKGCCGN, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x82A4170", Offset = "0x82A2770", VA = "0x1882A4170")]
	public int[] HNIEAJPLFHN(int MJEBNFGNEOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x82A3E20", Offset = "0x82A2420", VA = "0x1882A3E20")]
	private NativeSlice<int> BHIPNEDILGC(int MJEBNFGNEOI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x82A3F70", Offset = "0x82A2570", VA = "0x1882A3F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x82A4240", Offset = "0x82A2840", VA = "0x1882A4240")]
	public Mesh IDLNFBDILNI([Optional] string PNCKMMICNLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[KALHGBCMMAN]
[DefaultMember("Item")]
[NativeContainer]
public struct BPMDLCHLKPK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<Vector3> PDLJDFBMEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeArray<Vector3> AFNAJNLLECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeArray<Vector4> KDNCCNPNEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<Vector2> NIADOHFPFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeArray<Vector2> CNGDGKPIOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<Vector2> NGGPFGBMKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<Vector2> NFODMBDFOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<Color> IEHJJOOMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeArray<int> EBGAPOKKCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeArray<int> MBMJANLJKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeArray<int> NFPNLABAHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeArray<int> PFBLIDLCNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeArray<bool> NPIJNAADGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeArray<int> EHEJJKOLIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeArray<int> ONEBKPHCIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<BoneWeight> BPFJDCAFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private NativeArray<Matrix4x4> HKMOPCNBNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private NativeArray<long> FFKBPPFPOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private NativeArray<byte> NBEPHCFMPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private NativeArray<int> MBJKFGLIJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private NativeArray<int> GLAFEAJOIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeArray<sbyte> JKDKHNCCDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeArray<byte> FHIELFNIEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private NativeArray<int> KMMLIDEJMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private bool IIKGJPNBKKO;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int ONJGDLJHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xF4F310", Offset = "0xF4D910", VA = "0x180F4F310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int BPKKLGBELAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xDB3F60", Offset = "0xDB2560", VA = "0x180DB3F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int MPICADOGIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x82945F0", Offset = "0x8292BF0", VA = "0x1882945F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int CKCHMDKICDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8294620", Offset = "0x8292C20", VA = "0x188294620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8294650", Offset = "0x8292C50", VA = "0x188294650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int GKLGPHAJCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8293D40", Offset = "0x8292340", VA = "0x188293D40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8294640", Offset = "0x8292C40", VA = "0x188294640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int FAKIOMIKMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8293E30", Offset = "0x8292430", VA = "0x188293E30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8293E40", Offset = "0x8292440", VA = "0x188293E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public ADFCGNJBKIO ANHMEBDCIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8293D30", Offset = "0x8292330", VA = "0x188293D30")]
		get
		{
			return default(ADFCGNJBKIO);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8294630", Offset = "0x8292C30", VA = "0x188294630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte LBHIHEAGHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8293E20", Offset = "0x8292420", VA = "0x188293E20")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8293D20", Offset = "0x8292320", VA = "0x188293D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public OOHOBPDCKIA BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x82940C0", Offset = "0x82926C0", VA = "0x1882940C0")]
		get
		{
			return default(OOHOBPDCKIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8294660", Offset = "0x8292C60", VA = "0x188294660")]
	public BPMDLCHLKPK(IList<Mesh> AKGOPLCGDLC, IList<Matrix4x4> NJGEDNMKNCI, IList<bool> NPIJNAADGDM, byte DGOBHPFHGDA, IList<byte[]> GHGGCPCPHHP, IList<long> NMBECLDFFCM, IList<bool> EJGOBBKEOJN, IList<int> EHEJJKOLIBO, IList<int> FBBIAMIOOHL, IList<int> LONKAPJENKE, Allocator EKNOCGFFMAE, ADFCGNJBKIO IFLCEKHACJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8293D50", Offset = "0x8292350", VA = "0x188293D50")]
	public PBNCKBPLNBK CEGIEOMABNG(Allocator EKNOCGFFMAE)
	{
		return default(PBNCKBPLNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8293E50", Offset = "0x8292450", VA = "0x188293E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[KALHGBCMMAN]
public class BEMEMEEHDMG : IOHHJGKADIO
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8293990", Offset = "0x8291F90", VA = "0x188293990")]
	public BPMDLCHLKPK JBMOKGDPENM()
	{
		return default(BPMDLCHLKPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x828F300", Offset = "0x828D900", VA = "0x18828F300")]
	public BEMEMEEHDMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct OOHOBPDCKIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<Vector3> PDLJDFBMEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public NativeSlice<Vector3> AFNAJNLLECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public NativeSlice<Vector4> KDNCCNPNEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public NativeSlice<Vector2> NIADOHFPFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public NativeSlice<Vector2> CNGDGKPIOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public NativeSlice<Vector2> NGGPFGBMKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public NativeSlice<Vector2> NFODMBDFOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeSlice<Color> IEHJJOOMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public NativeSlice<int> CEBALMGOLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public NativeSlice<int> PFBLIDLCNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeSlice<BoneWeight> BPFJDCAFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public NativeSlice<byte> OLHINAKEFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public int HHPKCPMHJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public Matrix4x4 DMKLNODALDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public long OABHIGPHLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public NativeSlice<byte> IPGCHIAEBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public bool BNIELKPGFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public int JCFBJDPHJKC;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct GKAADCENOFF : IEquatable<GKAADCENOFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	internal readonly Material OHJGNAFEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	internal readonly FGAMIEKEMIN DPAMBCDPEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	internal readonly AJKPMNIKDDJ JMGDFJCHIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal readonly CNFLLNFLBIO KOLJEAGHCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	internal readonly bool JLJLDHKCDJC;

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x829E680", Offset = "0x829CC80", VA = "0x18829E680")]
	public GKAADCENOFF(Material JKDFAJLFBEL, FGAMIEKEMIN MNAHCNBLCAI, AJKPMNIKDDJ MHAGPICIDAI, CNFLLNFLBIO CGKEIIDMLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x829E3E0", Offset = "0x829C9E0", VA = "0x18829E3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x829E140", Offset = "0x829C740", VA = "0x18829E140", Slot = "4")]
	public bool Equals(GKAADCENOFF IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x829E1D0", Offset = "0x829C7D0", VA = "0x18829E1D0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x829E2D0", Offset = "0x829C8D0", VA = "0x18829E2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, OBNPPKBBOPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[Header("Configuration")]
		[SerializeField]
		private GAPGDDKJAHD avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AssetReference torsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AssetReference legsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AssetReference torsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private BGCOFBKKHJK CAOAEMADBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private OBKFCAOBFHI JMKADBAJPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private PNBAICGDONK MOMNMJCKIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private PNBAICGDONK JKNBNOKBEMD;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public BGCOFBKKHJK GDDNJGHOKIB
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x8293830", Offset = "0x8291E30", VA = "0x188293830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public OBKFCAOBFHI OBLFBDJMMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8293880", Offset = "0x8291E80", VA = "0x188293880", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public PNBAICGDONK MHHLPBEAKOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x82938D0", Offset = "0x8291ED0", VA = "0x1882938D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public PNBAICGDONK CDMAHCJHNHI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x8293920", Offset = "0x8291F20", VA = "0x188293920", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform FHINNFMIKGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8293970", Offset = "0x8291F70", VA = "0x188293970", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public GAPGDDKJAHD HCMEFIDAIBD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F10", Offset = "0xAA0510", VA = "0x180AA1F10", Slot = "12")]
			get
			{
				return default(GAPGDDKJAHD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8292860", Offset = "0x8290E60", VA = "0x188292860")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8293690", Offset = "0x8291C90", VA = "0x188293690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8292F10", Offset = "0x8291510", VA = "0x188292F10", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8293690", Offset = "0x8291C90", VA = "0x188293690", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x82928A0", Offset = "0x8290EA0", VA = "0x1882928A0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8293740", Offset = "0x8291D40", VA = "0x188293740")]
		public void UpdatePostIKAnimControllers(float KNMJNADDDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8293600", Offset = "0x8291C00", VA = "0x188293600")]
		private void MPPFEBLMIGO(GameObject NDBJJGOPOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x82931E0", Offset = "0x82917E0", VA = "0x1882931E0")]
		private BGCOFBKKHJK LAJFFFAHNOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8292BD0", Offset = "0x82911D0", VA = "0x188292BD0")]
		private OBKFCAOBFHI GNNPEJEEHMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8292F50", Offset = "0x8291550", VA = "0x188292F50")]
		private PNBAICGDONK JAGEBCLPPEA(ALJNENPBFBE DCPACHMEKCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8293820", Offset = "0x8291E20", VA = "0x188293820")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DOCILOBOALA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private MaterialPropertyBlock HHHIMCJHFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public Color? MGDFMEGDJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public Color? JABKLOMECDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public Color? FKKJDKGOJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public Color? OGBKKHLMFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public Color GGOMCLOPCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public Color ACAIPHBJOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public Color JJCHEACENKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public float DKBOMDFENOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Texture2D HPNLLDJIMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public Texture2D GPDAPBGFJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private Dictionary<GKAADCENOFF, int> GCAMDFBELJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private FGAMIEKEMIN[] PNGPBCDNPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private AJKPMNIKDDJ[] MEJINPHFOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Vector4[] BKPNEIFPNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public Vector4[] HOPLEPHDJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public Vector4[] PMOBLLOKBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public Vector4[] ALFBELAEOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public Vector4[] JLKDNGPOLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public Vector4[] PBCKEABEKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private List<Texture2D> FFADNFDELJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector4[] GOCOJJJDOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private List<Texture2D> HODPMPKJEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private float[] ILEPEIDMHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private Vector4[] KDFLLAHDFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private float[] PBEDLIJPLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public float[] MAHABCHLIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private List<Texture2D> EDODHLAENPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private float[] HMFIGGFPHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private List<Texture2D> BONHEHGDCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private Vector4[] KMLPIFHIELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private float[] JGIMEAEDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private Vector4[] AOLFNCJNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public float[] LLMKBJDMHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public Texture2DArray MDINOGALHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public Texture2DArray NEGJKFJPKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public Texture2DArray PBJKMJMOHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public Texture2DArray BHKKMCNBCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private bool MHOPELFEKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private int AFDJNJGILIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private Vector2? PCBJFGEPPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private TextureFormat JJOHKALEOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private Vector2? PJLPPNPCLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private TextureFormat ECJPHLEILEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private Vector2? GGCCCHKNAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private TextureFormat JCBICKLELCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private Vector2? AFKPNCCCDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private TextureFormat DAGAADMGDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private bool JBOBNJDEDEL;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static int CAJKBNIDCBA;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static int BBNPKLMDPCD;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private static int MOFNLEGBMBF;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static int ACLEFIOEHBN;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static int NKJDLGJEOHK;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private static int EBHJOAEPNNN;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static int LDDMLIPDKJH;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static int OGFDJLACKMA;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private static int FMIGKPIHNBE;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private static int LDBPGNGBKGD;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private static int DIOPJEGLPJG;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private static int GBDOLGBDFIM;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private static int MEMLBABGICI;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private static int GMKPEODGJDI;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private static int IEPLAFDNFJP;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private static int HGMELOPKEGN;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private static int CMCHBLGJALA;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private static int HGJEHEOFNEE;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private static int POEEIEHGBGA;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private static int HNBIHNMHAHL;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x82993C0", Offset = "0x82979C0", VA = "0x1882993C0")]
	private DOCILOBOALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8299300", Offset = "0x8297900", VA = "0x188299300")]
	public DOCILOBOALA(Color FLDOKNIDLGO, Color AKLBMJAJNPK, Color DONBDMEHNGE, Color? BGIGGHLDIIK, Color? LCIKJMINHIL, Color? MIGDDKOLMBD, Texture2D JGLMOKDEGOK, Texture2D KLKAKBCDKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8297CE0", Offset = "0x82962E0", VA = "0x188297CE0")]
	internal int FIFLMDEPDKK(Material NAMCJDEHGDL, FGAMIEKEMIN MNAHCNBLCAI, AJKPMNIKDDJ MHAGPICIDAI, CNFLLNFLBIO CGKEIIDMLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8297DB0", Offset = "0x82963B0", VA = "0x188297DB0")]
	private int FIFLMDEPDKK(GKAADCENOFF HFLDIIIPBCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x82983A0", Offset = "0x82969A0", VA = "0x1882983A0")]
	internal int LIGMHCCPMEM(Material NAMCJDEHGDL, Color FLBNNCEFFNJ, Color EKIHOOEAHFC, Color GLIOJJENHLP, Color GNDAMCHEKMO, Color DIFAOKDGHJK, Texture2D NMLJHKLJDEE, Vector4 CHDFOAJOBOO, Texture2D HDBPECDIOJE, Vector4 NJOILKOMKBF, float MOICAJJMLIC, float KHPHABFFCJN, Texture2D JELJAPOCCHL, Vector4 DOKEEPIKMOI, float JPNEBFGDELA, Texture2D LGHIGOHCIEO, Color OBFDGEJHJLE, Vector4 NGFCAKIINDM, FGAMIEKEMIN MNAHCNBLCAI, AJKPMNIKDDJ MHAGPICIDAI, CNFLLNFLBIO CGKEIIDMLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8297AE0", Offset = "0x82960E0", VA = "0x188297AE0")]
	private void CLPECMKBFOJ(List<Texture2D> FFADNFDELJH, [Out] Texture2DArray KDACPINKMCI, [Out] Texture2DArray OOOMEKGELCP, [Out] Texture2DArray ALBPOOOOPCP, [Out] Texture2DArray IPCGOMGODKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x8298250", Offset = "0x8296850", VA = "0x188298250")]
	public void KNJDNNBBKNJ(Shader KEKGGAJBBHN, Renderer PHHDHBAFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8296C90", Offset = "0x8295290", VA = "0x188296C90")]
	private void BCNCLFADLEK(Shader KEKGGAJBBHN, Renderer PHHDHBAFNEH, int NGBLELIHMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8297EF0", Offset = "0x82964F0", VA = "0x188297EF0")]
	private Color HPIIDMFPOMB(Color ALJEEBKCDKP, FGAMIEKEMIN LKFLFFGPJIL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8297990", Offset = "0x8295F90", VA = "0x188297990")]
	private Color BOJMIEABIKB(Color FCCIDGKCLME, FGAMIEKEMIN LKFLFFGPJIL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x82980F0", Offset = "0x82966F0", VA = "0x1882980F0")]
	private bool IMHGOKOABDB(Texture2D PLBBJIGKHIJ, AJKPMNIKDDJ GKBBGLJBHBJ, [Out] Texture2D KOPBEMFOEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8297E40", Offset = "0x8296440", VA = "0x188297E40")]
	private void HBHGOGPGEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8297CA0", Offset = "0x82962A0", VA = "0x188297CA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GBNDABFCGHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public readonly CNFLLNFLBIO IEFNKPIPFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	protected bool OGEBGKCFMIL;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool LBBJJDCFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xB72630", Offset = "0xB70C30", VA = "0x180B72630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xB72650", Offset = "0xB70C50", VA = "0x180B72650")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool EOHOBPHPPCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xB72670", Offset = "0xB70C70", VA = "0x180B72670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xB72660", Offset = "0xB70C60", VA = "0x180B72660")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual LINIKLIADHK.NMCDOKKFLGH OABHIGPHLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LINIKLIADHK.NMCDOKKFLGH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool LFFIGLCNGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x159F660", Offset = "0x159DC60", VA = "0x18159F660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool GDPJKGONOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x829DEB0", Offset = "0x829C4B0", VA = "0x18829DEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool JALMKFFIICP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x829DEC0", Offset = "0x829C4C0", VA = "0x18829DEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool DMAJPNGCGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x829DE90", Offset = "0x829C490", VA = "0x18829DE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x829DED0", Offset = "0x829C4D0", VA = "0x18829DED0")]
	protected GBNDABFCGHN(CNFLLNFLBIO MMEODAJENEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract CNOKEDEBLOH KMOBGACMPJD(List<LOOEBIAEJGK> OINGPGCKCPC, List<LOOEBIAEJGK> DGPJNLLAMNK);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract JLGDGBKBIEC DHMKECLMIMO(uint EEPEOPEEIMF, AvatarSkinnedMeshBoneOrderRemapsData DNFKOPAIHDE);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KNCCACFPDBN : DBLDDFGANNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private AvatarSkinAssetItem MFGDKDBGIMD;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x82A1F70", Offset = "0x82A0570", VA = "0x1882A1F70")]
	public KNCCACFPDBN(AvatarSkinAssetItem GFGFHHLMDPE, AvatarSkinAssetItem.POKCJPNIIIB MMFGHJELKNN, CNFLLNFLBIO CGKEIIDMLBB, [Optional] GJDKJPBGNBN? DGDDICJNHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x82A1D00", Offset = "0x82A0300", VA = "0x1882A1D00", Slot = "6")]
	public override CNOKEDEBLOH KMOBGACMPJD(List<LOOEBIAEJGK> OINGPGCKCPC, List<LOOEBIAEJGK> DGPJNLLAMNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BOOHNBOHKCM
{
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private static readonly int[] JPNHNEDFGHP;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private static readonly int[] HEMGMAPAPHM;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] IMLDDMDCKAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8293A80", Offset = "0x8292080", VA = "0x188293A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8293B90", Offset = "0x8292190", VA = "0x188293B90")]
	public static int[] PGCFNMJBHNE(bool MNKAPKKBLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8293B00", Offset = "0x8292100", VA = "0x188293B00")]
	public static int PANPMGAJNGC(JGCNGACGAAH DADKCMNBOHG, bool MNKAPKKBLOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8293AD0", Offset = "0x82920D0", VA = "0x188293AD0")]
	private static int FEAKAEBMBGK(JGCNGACGAAH DADKCMNBOHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x8293AE0", Offset = "0x82920E0", VA = "0x188293AE0")]
	private static int JPAPAFDDMJA(JGCNGACGAAH DADKCMNBOHG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JNGMHIKHCOC
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class PDIDJOBFFEK : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public PDIDJOBFFEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x15133A0", Offset = "0x15119A0", VA = "0x1815133A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x82A4CB0", Offset = "0x82A32B0", VA = "0x1882A4CB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	public static void LAODEMOHOBD(string JIEJOKBHEMF, int EEPEOPEEIMF, long LOCBKCIKDBI, long HELJOIPGMFE, long EFNANCPBOAO, long JKNAIGMHDAM, long NCDELMEIFIN, long GJIEHPGIODH, long EBICFKOMKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x82A10B0", Offset = "0x829F6B0", VA = "0x1882A10B0")]
	public static APLPOCKIJEJ DDNOAENEKED(JobHandle MNHPGBLEGJE, bool AOFBDIBLKGM, bool PDPNAFFOPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x82A1040", Offset = "0x829F640", VA = "0x1882A1040")]
	[IteratorStateMachine(typeof(PDIDJOBFFEK))]
	private static IEnumerator<BJJPNELKDDJ> CPFOGHJFOBJ(JobHandle IINGFCBPPPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LLIFJGHBLCF
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum DILAPJLPDIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly int BMPGGNPNCHC;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly int MLDLGKMGKNI;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly int OIJCDBKOJPP;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly int PJBKPKOGCLL;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly int MCOIMLPDIEJ;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly int JPCOCKKLALB;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly int BOGOELDMJGM;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly int OGCLPFAIPOA;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly int HNNGBKNKFDN;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly int HFPOJFHMFEF;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly int DFOINLOOHKG;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly int BHOJGJHFIBH;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x82A2100", Offset = "0x82A0700", VA = "0x1882A2100")]
	public static bool FDNOBCIIOAH(Material JKDFAJLFBEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x82A2170", Offset = "0x82A0770", VA = "0x1882A2170")]
	public static bool GMLAPKKPOFG(Material JKDFAJLFBEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class DBLDDFGANNM : GBNDABFCGHN
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class INGGFOINIOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public LHNBHFNPODB<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public DBLDDFGANNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public INGGFOINIOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x829FA10", Offset = "0x829E010", VA = "0x18829FA10")]
		internal void BAGCAOHGJHP(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x829FDE0", Offset = "0x829E3E0", VA = "0x18829FDE0")]
		internal void NLMKOEGGKGE(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	protected AvatarSkinAssetItem EHFNKOKODHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	protected Material[] PIKKLNHFNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly AvatarSkinAssetItem.POKCJPNIIIB KHEBCMCJIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly AssetReference LLJLKGELBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private readonly GJDKJPBGNBN? FBJFPNGKLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private SkinnedMeshRenderer[] FDGNNPEEBJH;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override LINIKLIADHK.NMCDOKKFLGH OABHIGPHLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LINIKLIADHK.NMCDOKKFLGH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA94FD0", Offset = "0xA935D0", VA = "0x180A94FD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x82966C0", Offset = "0x8294CC0", VA = "0x1882966C0")]
	public DBLDDFGANNM(AvatarSkinAssetItem.POKCJPNIIIB MMFGHJELKNN, AssetReference PCMCAGKFJNK, Material PEAGOFHBLBP, CNFLLNFLBIO CGKEIIDMLBB, LINIKLIADHK.NMCDOKKFLGH IJGJNOBJICM = (LINIKLIADHK.NMCDOKKFLGH)0L, [Optional] GJDKJPBGNBN? DGDDICJNHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x82965A0", Offset = "0x8294BA0", VA = "0x1882965A0")]
	public DBLDDFGANNM(AvatarSkinAssetItem.POKCJPNIIIB MMFGHJELKNN, AssetReference PCMCAGKFJNK, Material PEAGOFHBLBP, LINIKLIADHK.NMCDOKKFLGH IJGJNOBJICM = (LINIKLIADHK.NMCDOKKFLGH)0L, [Optional] GJDKJPBGNBN? DGDDICJNHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8296360", Offset = "0x8294960", VA = "0x188296360", Slot = "6")]
	public override CNOKEDEBLOH KMOBGACMPJD(List<LOOEBIAEJGK> OINGPGCKCPC, List<LOOEBIAEJGK> DGPJNLLAMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8296100", Offset = "0x8294700", VA = "0x188296100", Slot = "7")]
	public override JLGDGBKBIEC DHMKECLMIMO(uint EEPEOPEEIMF, AvatarSkinnedMeshBoneOrderRemapsData DNFKOPAIHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x8296530", Offset = "0x8294B30", VA = "0x188296530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8296310", Offset = "0x8294910", VA = "0x188296310")]
	protected void FPAJEHBDMPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class KCPENKNIELE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private List<int> FGJAGPFBCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private List<OCLEJHEDPDB> HNPNBGEJGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private HashSet<Transform> DNLNGOAMLCK;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x82A11A0", Offset = "0x829F7A0", VA = "0x1882A11A0")]
	public static KCPENKNIELE DIFMFOFBAHO(Transform IHNLGGEEIFC, Dictionary<Transform, OutfitType?> PDOIDADEPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x82A18B0", Offset = "0x829FEB0", VA = "0x1882A18B0")]
	private void KDNCPFDFGEB(Transform IHNLGGEEIFC, CNFLLNFLBIO CGKEIIDMLBB, Dictionary<Transform, OutfitType?> PDOIDADEPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x82A1330", Offset = "0x829F930", VA = "0x1882A1330")]
	private void EGEBNDIMMNB(Transform HBEBNIGOHHM, CNFLLNFLBIO CGKEIIDMLBB, bool PAILEGOGNFN, OutfitType? FPGBMFMFODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x82A14C0", Offset = "0x829FAC0", VA = "0x1882A14C0")]
	public MIKDLJNBAIM JKKMFKLPDBD(HashSet<string> KCJEJBCPPBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x82A1BD0", Offset = "0x82A01D0", VA = "0x1882A1BD0")]
	public KCPENKNIELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class MIKDLJNBAIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private List<OCLEJHEDPDB> HNPNBGEJGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private List<Matrix4x4> OFJLEECJOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private Transform[] BEPFKDIGKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private Matrix4x4[] BNANLJJHPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private Dictionary<GNPHOPPPGMD, int> JBFPCLFNLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private List<JBBDFCJNGKF> POJKPHBLFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private bool OMDEFAPEFJJ;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x82A2700", Offset = "0x82A0D00", VA = "0x1882A2700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] CFLIOAPCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x82A2590", Offset = "0x82A0B90", VA = "0x1882A2590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] NGCPFMKBNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x82A31A0", Offset = "0x82A17A0", VA = "0x1882A31A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x82A2740", Offset = "0x82A0D40", VA = "0x1882A2740")]
	public void EGEBNDIMMNB(Transform HBEBNIGOHHM, CNFLLNFLBIO CGKEIIDMLBB, OutfitType? FPGBMFMFODG, bool NBMAFEKAEAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x82A2940", Offset = "0x82A0F40", VA = "0x1882A2940")]
	private void EGEBNDIMMNB(Transform HBEBNIGOHHM, CNFLLNFLBIO CGKEIIDMLBB, OutfitType? FPGBMFMFODG, bool NBMAFEKAEAN, Matrix4x4 HIKFGEKANDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x82A2EA0", Offset = "0x82A14A0", VA = "0x1882A2EA0")]
	public int JGHHODHPGLC(GNPHOPPPGMD HFLDIIIPBCG, bool KIKLMHMLLIM, [Optional] OutfitType? FPGBMFMFODG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x82A2CB0", Offset = "0x82A12B0", VA = "0x1882A2CB0")]
	public int FMAHHPOPFPI(CNFLLNFLBIO CGKEIIDMLBB, [Optional] OutfitType? FPGBMFMFODG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x82A2DB0", Offset = "0x82A13B0", VA = "0x1882A2DB0")]
	public void HANLOHCKPMB(GNPHOPPPGMD HFLDIIIPBCG, Matrix4x4 JMKMDHIOHMI, bool KIKLMHMLLIM = false, [Optional] OutfitType? FPGBMFMFODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x82A3050", Offset = "0x82A1650", VA = "0x1882A3050")]
	public Matrix4x4 NBGAAEFOCCE(GNPHOPPPGMD HFLDIIIPBCG, bool KIKLMHMLLIM, [Optional] OutfitType? FPGBMFMFODG)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1279570", Offset = "0x1277B70", VA = "0x181279570")]
	public void LNNJCPHMILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x82A3210", Offset = "0x82A1810", VA = "0x1882A3210")]
	public MIKDLJNBAIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct GNPHOPPPGMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public readonly string IIEJFMIHDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public readonly CNFLLNFLBIO KOLJEAGHCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public readonly OutfitType? KHIAECJEOLL;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x829EA50", Offset = "0x829D050", VA = "0x18829EA50")]
	public GNPHOPPPGMD(string HDDBDNDCLLA, CNFLLNFLBIO CGKEIIDMLBB, [Optional] OutfitType? FPGBMFMFODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x829E9A0", Offset = "0x829CFA0", VA = "0x18829E9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x829E8E0", Offset = "0x829CEE0", VA = "0x18829E8E0")]
	public bool HILCECGHHLN(GNPHOPPPGMD IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x829E7C0", Offset = "0x829CDC0", VA = "0x18829E7C0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x829E870", Offset = "0x829CE70", VA = "0x18829E870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct JBBDFCJNGKF : IEquatable<JBBDFCJNGKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public readonly CNFLLNFLBIO KOLJEAGHCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public readonly OutfitType? GDDJDDIHBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public readonly int GHOCAGILBLB;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x82A0200", Offset = "0x829E800", VA = "0x1882A0200")]
	public JBBDFCJNGKF(CNFLLNFLBIO CGKEIIDMLBB, int GLHGILGANDJ, [Optional] OutfitType? AGPMADALMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x82A0130", Offset = "0x829E730", VA = "0x1882A0130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x745C220", Offset = "0x745A820", VA = "0x18745C220")]
	public bool ONFFIAKBADJ(CNFLLNFLBIO CGKEIIDMLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x82A0060", Offset = "0x829E660", VA = "0x1882A0060")]
	public bool GIJBJCJAKFK(OutfitType? AGPMADALMMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x82A0010", Offset = "0x829E610", VA = "0x1882A0010", Slot = "4")]
	public bool Equals(JBBDFCJNGKF IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x829FF20", Offset = "0x829E520", VA = "0x18829FF20", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x82A00E0", Offset = "0x829E6E0", VA = "0x1882A00E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct OCLEJHEDPDB : IEquatable<OCLEJHEDPDB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public readonly Transform GBACDPLFFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public readonly bool BBOBOFKICPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public readonly CNFLLNFLBIO IEBKOJFGJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public readonly OutfitType? KHIAECJEOLL;

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x82A3800", Offset = "0x82A1E00", VA = "0x1882A3800")]
	public OCLEJHEDPDB(Transform HBEBNIGOHHM, bool PAILEGOGNFN, CNFLLNFLBIO CHMIHJLDKAP, [Optional] OutfitType? NPLKBOHJANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x82A35E0", Offset = "0x82A1BE0", VA = "0x1882A35E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x82A3460", Offset = "0x82A1A60", VA = "0x1882A3460", Slot = "4")]
	public bool Equals(OCLEJHEDPDB IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x82A3380", Offset = "0x82A1980", VA = "0x1882A3380", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x82A3560", Offset = "0x82A1B60", VA = "0x1882A3560", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x829B910", Offset = "0x8299F10", VA = "0x18829B910")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface BDAOGDLPNKO
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEJDNKOJJPA(Mesh LJNJDNJBNIE, Matrix4x4 DDGMCJHIAAM, byte[] IPGCHIAEBJB, bool CKEKEJNKEOJ = false, LINIKLIADHK.NMCDOKKFLGH GPMPDPGHJDO = (LINIKLIADHK.NMCDOKKFLGH)0L, int EHEJJKOLIBO = -1, bool NPIJNAADGDM = false);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIEOHGCKJHG(Allocator EKNOCGFFMAE, ADFCGNJBKIO IFLCEKHACJG, byte DGOBHPFHGDA, [Optional] IList<int> FBBIAMIOOHL, [Optional] IList<int> NKDFPOJPDOA);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct LIPMOGIAOOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public readonly GameObject CMCAPKOEAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private readonly AvatarItemMaterial INAAAIMEKNH;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
	public LIPMOGIAOOH(GameObject CMCAPKOEAMD, AvatarItemMaterial INAAAIMEKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x82A2070", Offset = "0x82A0670", VA = "0x1882A2070")]
	public void LPGGALKDCEP(Material JKDFAJLFBEL, int LIJMKKBPIGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class FIOPGAKJOCD : IOCOKHAGBCG<Task<(GameObject, AvatarItemMaterial)>, LIPMOGIAOOH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct DPLPPBELJNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x82998C0", Offset = "0x8297EC0", VA = "0x1882998C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8299DC0", Offset = "0x82983C0", VA = "0x188299DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private LHNBHFNPODB<GameObject> IHHOMMEBILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private LHNBHFNPODB<AvatarItemMaterial> NFJOBCMNJAB;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x829B880", Offset = "0x8299E80", VA = "0x18829B880")]
	private FIOPGAKJOCD(Task<(GameObject, AvatarItemMaterial)> PIKAFIDPPMC, LHNBHFNPODB<GameObject> DAADKNMCILD, LHNBHFNPODB<AvatarItemMaterial> DKJBOKJKDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x829B3E0", Offset = "0x82999E0", VA = "0x18829B3E0")]
	public static FIOPGAKJOCD EEPJBIPIECL(AssetReference HDAKDMDNNGC, [Optional] AssetReference LAFFNKFPAOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x829B340", Offset = "0x8299940", VA = "0x18829B340", Slot = "11")]
	protected override LIPMOGIAOOH ECBJIHEMCDG(Task<(GameObject, AvatarItemMaterial)> PNHNJDDLKFA)
	{
		return default(LIPMOGIAOOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x829B800", Offset = "0x8299E00", VA = "0x18829B800", Slot = "12")]
	protected override void OHCKCEIJJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x829B210", Offset = "0x8299810", VA = "0x18829B210")]
	[AsyncStateMachine(typeof(DPLPPBELJNI))]
	private static Task<(GameObject, AvatarItemMaterial)> CLCPNNGEKEO(Task<GameObject> HMIBCOOLJGJ, Task<AvatarItemMaterial> HDEEPDIAEAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class DJGOMFNGAEE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class OEGOJKOEEBL : IOCOKHAGBCG<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private LHNBHFNPODB<MaterialMapAsset> IINGFCBPPPE;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x82A3D20", Offset = "0x82A2320", VA = "0x1882A3D20")]
		public OEGOJKOEEBL(LHNBHFNPODB<MaterialMapAsset> IINGFCBPPPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x82A3850", Offset = "0x82A1E50", VA = "0x1882A3850", Slot = "11")]
		protected override Material[] ECBJIHEMCDG(Task<MaterialMapAsset> PIKAFIDPPMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x82A3CC0", Offset = "0x82A22C0", VA = "0x1882A3CC0", Slot = "12")]
		protected override void OHCKCEIJJDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class CLNNDCLFJEK : IOCOKHAGBCG<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private List<LHNBHFNPODB<Material>> DEDILDEDBEA;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8296090", Offset = "0x8294690", VA = "0x188296090")]
		public CLNNDCLFJEK(Task<Material[]> PIKAFIDPPMC, List<LHNBHFNPODB<Material>> DEDILDEDBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8295F00", Offset = "0x8294500", VA = "0x188295F00", Slot = "11")]
		protected override Material[] ECBJIHEMCDG(Task<Material[]> PNHNJDDLKFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8295F50", Offset = "0x8294550", VA = "0x188295F50", Slot = "12")]
		protected override void OHCKCEIJJDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x82967F0", Offset = "0x8294DF0", VA = "0x1882967F0")]
	public static LHNBHFNPODB<Material[]> IHOPBJDBEMH(AssetReference[] DBKNDMLANCN)
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
		public enum LBKDHFCBEJK
		{
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum ODBONJPGMFN
		{
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public enum NNMHDKDDPPK : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct BBPLIFLJHDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public readonly Material OHJGNAFEKGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public readonly LBKDHFCBEJK DPAMBCDPEEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public readonly ODBONJPGMFN JMGDFJCHIDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public readonly CNFLLNFLBIO KOLJEAGHCLL;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x82B4710", Offset = "0x82B2D10", VA = "0x1882B4710")]
			public BBPLIFLJHDO(Material JKDFAJLFBEL, LBKDHFCBEJK MNAHCNBLCAI, ODBONJPGMFN MHAGPICIDAI, CNFLLNFLBIO CGKEIIDMLBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x82B44E0", Offset = "0x82B2AE0", VA = "0x1882B44E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x82B4460", Offset = "0x82B2A60", VA = "0x1882B4460")]
			public bool HILCECGHHLN(BBPLIFLJHDO IBCMCOKAJEM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x82B42D0", Offset = "0x82B28D0", VA = "0x1882B42D0", Slot = "0")]
			public override bool Equals(object NDBJJGOPOFO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x82B43C0", Offset = "0x82B29C0", VA = "0x1882B43C0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class GMGNJJGBNEF : IComparable<GMGNJJGBNEF>, IEquatable<GMGNJJGBNEF>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public int DEMMOFFEFHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public PlayerAvatarDisplayBase JBIKIOHHBGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public IList<JAEIIDNBJMP> CNCGMNBKKBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public AvatarItemBodyType AGENLCFHGKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public AMHMHHMNFOE IFALHLKKHFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public bool AMECIDDPHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public bool FFIMDHJOBLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public int[] KEEKDKJJLJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public float LFLEHKJBBGP;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x82B5A40", Offset = "0x82B4040", VA = "0x1882B5A40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x82B58F0", Offset = "0x82B3EF0", VA = "0x1882B58F0", Slot = "4")]
			public int CompareTo(GMGNJJGBNEF IBCMCOKAJEM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x82B5920", Offset = "0x82B3F20", VA = "0x1882B5920", Slot = "5")]
			public bool Equals(GMGNJJGBNEF IBCMCOKAJEM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public GMGNJJGBNEF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class ABGMHDGHPMI
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class OFNECPOEANJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400037F")]
				public readonly Mesh HIGMKBMNOEA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				public readonly Material[] FFMGNAMMKEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				public readonly Transform[] MCDALCGGMKN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000382")]
				public readonly Matrix4x4[] OLNOPDIPJCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000383")]
				public readonly Transform AHFGHHNLLJB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000384")]
				public readonly bool MJIKOBEJDNH;

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
				protected OFNECPOEANJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x82BB8C0", Offset = "0x82B9EC0", VA = "0x1882BB8C0")]
				public OFNECPOEANJ(Mesh LJNJDNJBNIE, Material[] HEBPEBCDEGI, bool OONKGIKHNKM, Transform[] KGGMFKPKBNC, Transform POMHFCMDDML, Matrix4x4[] AFPIEGDHHCH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x82BBE60", Offset = "0x82BA460", VA = "0x1882BBE60")]
				private OFNECPOEANJ(SkinnedMeshRenderer ENBMIILLDMB, Material[] KHAKGBDMNGN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x82BBD70", Offset = "0x82BA370", VA = "0x1882BBD70")]
				private OFNECPOEANJ(MeshRenderer AGMIMJIBEFK, Transform POMHFCMDDML, Material[] KHAKGBDMNGN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x82BB590", Offset = "0x82B9B90", VA = "0x1882BB590")]
				public static OFNECPOEANJ CJAIAGKPPKM(Renderer PHHDHBAFNEH, Material[] KHAKGBDMNGN)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public readonly CNFLLNFLBIO KOLJEAGHCLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public readonly Transform BINHDHEELBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public readonly bool DMOIEEOIPNA;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool LBBJJDCFLGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool EOHOBPHPPCD
			{
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual LINIKLIADHK.NMCDOKKFLGH OABHIGPHLPF
			{
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "6")]
				get
				{
					return default(LINIKLIADHK.NMCDOKKFLGH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool BNIELKPGFPD
			{
				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x82B3F80", Offset = "0x82B2580", VA = "0x1882B3F80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x82B3F90", Offset = "0x82B2590", VA = "0x1882B3F90")]
			protected ABGMHDGHPMI(CNFLLNFLBIO CGKEIIDMLBB, Transform GOEPPLECFAB, bool GGMBOFOHIBC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract CNOKEDEBLOH KMOBGACMPJD(List<LOOEBIAEJGK> OINGPGCKCPC, List<LOOEBIAEJGK> DGPJNLLAMNK);

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract OFNECPOEANJ DHMKECLMIMO(int EEPEOPEEIMF, PlayerHandBones HAPLLHEBPHF);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class FALBNENAOGM : ABGMHDGHPMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected readonly BodyPartLODs FDGNNPEEBJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			protected readonly Material[] PIKKLNHFNCK;

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x82B57E0", Offset = "0x82B3DE0", VA = "0x1882B57E0")]
			public FALBNENAOGM(CNFLLNFLBIO CGKEIIDMLBB, BodyPartLODs GLBGNIPMIDO, Material PEAGOFHBLBP, [Optional] Transform GOEPPLECFAB, bool GGMBOFOHIBC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x82B56E0", Offset = "0x82B3CE0", VA = "0x1882B56E0", Slot = "7")]
			public override CNOKEDEBLOH KMOBGACMPJD(List<LOOEBIAEJGK> OINGPGCKCPC, List<LOOEBIAEJGK> DGPJNLLAMNK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x82B5520", Offset = "0x82B3B20", VA = "0x1882B5520", Slot = "8")]
			public override OFNECPOEANJ DHMKECLMIMO(int EEPEOPEEIMF, PlayerHandBones HAPLLHEBPHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x82B5770", Offset = "0x82B3D70", VA = "0x1882B5770", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class PJPLHCEDGBK : ABGMHDGHPMI
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool LBBJJDCFLGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool EOHOBPHPPCD
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0x82BC470", Offset = "0x82BAA70", VA = "0x1882BC470", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public DOBBNIFBALE LBBDIIDGKCE
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x82BC5C0", Offset = "0x82BABC0", VA = "0x1882BC5C0")]
			public PJPLHCEDGBK(CNFLLNFLBIO CGKEIIDMLBB, Transform GOEPPLECFAB, DOBBNIFBALE MFIKOFMJJDD, bool GGMBOFOHIBC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x82BC4C0", Offset = "0x82BAAC0", VA = "0x1882BC4C0", Slot = "7")]
			public override CNOKEDEBLOH KMOBGACMPJD(List<LOOEBIAEJGK> OINGPGCKCPC, List<LOOEBIAEJGK> DGPJNLLAMNK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "8")]
			public override OFNECPOEANJ DHMKECLMIMO(int EEPEOPEEIMF, PlayerHandBones HAPLLHEBPHF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x82BC550", Offset = "0x82BAB50", VA = "0x1882BC550", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class LEPBIOOKEPB
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum HPCKELKAMBC
			{
				[Cpp2IlInjected.Token(Token = "0x4000398")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000399")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x400039A")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x400039B")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x400039C")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400039D")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400039E")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public static readonly int OOMCEBMGONF;

			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public static readonly int HGKMMLNLFFG;

			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public static readonly int JEAJJHDOFIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected readonly ALJNENPBFBE DCPACHMEKCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected readonly PCCAPIFPEFE CDNPNNAJHNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected readonly Animator ELKBOBBGHME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected readonly Transform GLLBAPFOBIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector3 DACPAPOAKEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected readonly Transform CGNGDPFCEHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector3 AGAGDPCCPLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected bool ELBEBNFIFNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected PNBAICGDONK PDCFIODAFDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected bool LLLALEPJAMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float HCAADDHBMNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected BJGHJEFJAHK<DMJJMIOILDN> CIKJKIGKPMJ;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public PNBAICGDONK IKBJFHGEJPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0xA962B0", Offset = "0xA948B0", VA = "0x180A962B0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000321")]
				[Cpp2IlInjected.Address(RVA = "0xA96300", Offset = "0xA94900", VA = "0x180A96300")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool LAGHNHNKLDL
			{
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xD664C0", Offset = "0xD64AC0", VA = "0x180D664C0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x82B7610", Offset = "0x82B5C10", VA = "0x1882B7610")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool JHNBNJGFHBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xA99370", Offset = "0xA97970", VA = "0x180A99370")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x82B76E0", Offset = "0x82B5CE0", VA = "0x1882B76E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float GBFBMIDDAJB
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xE14FE0", Offset = "0xE135E0", VA = "0x180E14FE0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x82B78D0", Offset = "0x82B5ED0", VA = "0x1882B78D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public DMJJMIOILDN AHOMICEDHLO
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x82B7480", Offset = "0x82B5A80", VA = "0x1882B7480")]
				get
				{
					return default(DMJJMIOILDN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x82B7030", Offset = "0x82B5630", VA = "0x1882B7030")]
			public bool BMNDONBLPAJ(DMJJMIOILDN KGILCHBPJKO, object HNGIMMGBLII, HPCKELKAMBC DLELGMMBCCC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x82B74C0", Offset = "0x82B5AC0", VA = "0x1882B74C0")]
			public bool GMPKGECIIEK(object HNGIMMGBLII)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x82B7AC0", Offset = "0x82B60C0", VA = "0x1882B7AC0")]
			protected LEPBIOOKEPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x82B7B50", Offset = "0x82B6150", VA = "0x1882B7B50")]
			public LEPBIOOKEPB(ALJNENPBFBE DCPACHMEKCM, PNBAICGDONK IJMMPOPLLKO, Animator ELKBOBBGHME, Transform GLLBAPFOBIH, Transform CGNGDPFCEHD, Vector3 DACPAPOAKEB, Vector3 AGAGDPCCPLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x82B7270", Offset = "0x82B5870", VA = "0x1882B7270")]
			private void DOBLNDCDJAH(ushort KPJKFIGAPGH, ushort MJJMOMPLGLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x82B6E20", Offset = "0x82B5420", VA = "0x1882B6E20")]
			protected void ADHGJDGPAOH(ushort KPJKFIGAPGH, ushort MJJMOMPLGLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x82B6F70", Offset = "0x82B5570", VA = "0x1882B6F70")]
			protected void BLDCLONCHMA(ushort KPJKFIGAPGH, ushort MJJMOMPLGLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x82B7140", Offset = "0x82B5740", VA = "0x1882B7140")]
			protected void DKIFDJHELGO(ushort KPJKFIGAPGH, ushort MJJMOMPLGLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x82B7370", Offset = "0x82B5970", VA = "0x1882B7370")]
			protected void FLHBMEIGJHL(ushort KPJKFIGAPGH, ushort MJJMOMPLGLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x82B6F10", Offset = "0x82B5510", VA = "0x1882B6F10")]
			protected void BEOBMINHKGD(ushort KPJKFIGAPGH, ushort MJJMOMPLGLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x82B7320", Offset = "0x82B5920", VA = "0x1882B7320")]
			protected void FIFJECNCDGA(ushort KPJKFIGAPGH, ushort MJJMOMPLGLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x82B75C0", Offset = "0x82B5BC0", VA = "0x1882B75C0")]
			protected void JCHKJGAFKNC(ushort KPJKFIGAPGH, ushort MJJMOMPLGLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x82B77B0", Offset = "0x82B5DB0", VA = "0x1882B77B0")]
			protected void OEKLLLGOOIH(ushort KPJKFIGAPGH, ushort MJJMOMPLGLN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class NOFDKHEFKJD : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public const int FPONNCKMLIG = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected MaterialPropertyBlock HHHIMCJHFLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Color? MGDFMEGDJPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Color? FKKJDKGOJIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Color? OGBKKHLMFDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public Color GGOMCLOPCDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public Color ACAIPHBJOKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public Color JJCHEACENKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public Texture2D HPNLLDJIMCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public Texture2D GPDAPBGFJHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected Dictionary<BBPLIFLJHDO, int> GCAMDFBELJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected LBKDHFCBEJK[] PNGPBCDNPGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Vector4[] BKPNEIFPNML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Vector4[] HOPLEPHDJJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Vector4[] PMOBLLOKBGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public Vector4[] ALFBELAEOOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			public Vector4[] JLKDNGPOLOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public Vector4[] PBCKEABEKBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected List<Texture2D> FFADNFDELJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector4[] GOCOJJJDOOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected List<Texture2D> HODPMPKJEMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected float[] ILEPEIDMHDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected Vector4[] KDFLLAHDFMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected float[] PBEDLIJPLFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public float[] MAHABCHLIEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected List<Texture2D> EDODHLAENPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected float[] HMFIGGFPHLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected List<Texture2D> BONHEHGDCNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected Vector4[] KMLPIFHIELO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected float[] JGIMEAEDJBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected Vector4[] AOLFNCJNCGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public float[] LLMKBJDMHHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public Texture2DArray MDINOGALHIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public Texture2DArray NEGJKFJPKBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public Texture2DArray PBJKMJMOHMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Texture2DArray BHKKMCNBCBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected bool MHOPELFEKNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected int AFDJNJGILIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected Vector2? PCBJFGEPPGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected TextureFormat JJOHKALEOAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected Vector2? PJLPPNPCLFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected TextureFormat ECJPHLEILEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected Vector2? GGCCCHKNAGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected TextureFormat JCBICKLELCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected Vector2? AFKPNCCCDKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected TextureFormat DAGAADMGDGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			protected bool JBOBNJDEDEL;

			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			protected static int CAJKBNIDCBA;

			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			protected static int BBNPKLMDPCD;

			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			protected static int MOFNLEGBMBF;

			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			protected static int ACLEFIOEHBN;

			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			protected static int NKJDLGJEOHK;

			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			protected static int EBHJOAEPNNN;

			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			protected static int LDDMLIPDKJH;

			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			protected static int OGFDJLACKMA;

			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			protected static int FMIGKPIHNBE;

			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			protected static int LDBPGNGBKGD;

			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			protected static int DIOPJEGLPJG;

			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			protected static int GBDOLGBDFIM;

			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			protected static int MEMLBABGICI;

			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			protected static int GMKPEODGJDI;

			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			protected static int IEPLAFDNFJP;

			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			protected static int HGMELOPKEGN;

			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			protected static int CMCHBLGJALA;

			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			protected static int HGJEHEOFNEE;

			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			protected static int POEEIEHGBGA;

			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			protected static int HNBIHNMHAHL;

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x82BAEA0", Offset = "0x82B94A0", VA = "0x1882BAEA0")]
			protected NOFDKHEFKJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x82BAE10", Offset = "0x82B9410", VA = "0x1882BAE10")]
			public NOFDKHEFKJD(Color FLDOKNIDLGO, Color AKLBMJAJNPK, Color DONBDMEHNGE, Color? BGIGGHLDIIK, Color? LCIKJMINHIL, Color? MIGDDKOLMBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x82B97A0", Offset = "0x82B7DA0", VA = "0x1882B97A0")]
			public int FIFLMDEPDKK(Material NAMCJDEHGDL, LBKDHFCBEJK MNAHCNBLCAI, ODBONJPGMFN MHAGPICIDAI, CNFLLNFLBIO CGKEIIDMLBB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x82B9710", Offset = "0x82B7D10", VA = "0x1882B9710")]
			public int FIFLMDEPDKK(BBPLIFLJHDO HFLDIIIPBCG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x82B9D80", Offset = "0x82B8380", VA = "0x1882B9D80")]
			public int LIGMHCCPMEM(Material NAMCJDEHGDL, Color FLBNNCEFFNJ, Color EKIHOOEAHFC, Color GLIOJJENHLP, Color GNDAMCHEKMO, Color DIFAOKDGHJK, Texture2D NMLJHKLJDEE, Vector4 CHDFOAJOBOO, Texture2D HDBPECDIOJE, Vector4 NJOILKOMKBF, float MOICAJJMLIC, float KHPHABFFCJN, Texture2D JELJAPOCCHL, Vector4 DOKEEPIKMOI, float JPNEBFGDELA, Texture2D LGHIGOHCIEO, float NBHDGOLFNIG, Color OBFDGEJHJLE, Vector4 NGFCAKIINDM, LBKDHFCBEJK MNAHCNBLCAI, ODBONJPGMFN MHAGPICIDAI, CNFLLNFLBIO CGKEIIDMLBB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x82B93C0", Offset = "0x82B79C0", VA = "0x1882B93C0")]
			protected void CLPECMKBFOJ([Out] Texture2DArray KDACPINKMCI, [Out] Texture2DArray OOOMEKGELCP, [Out] Texture2DArray ALBPOOOOPCP, [Out] Texture2DArray IPCGOMGODKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x82B9B10", Offset = "0x82B8110", VA = "0x1882B9B10")]
			public void KNJDNNBBKNJ(PlayerAvatarDisplayBase BINLPNDECNI, Renderer PHHDHBAFNEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x82B8890", Offset = "0x82B6E90", VA = "0x1882B8890")]
			protected void BCNCLFADLEK(PlayerAvatarDisplayBase BINLPNDECNI, Renderer PHHDHBAFNEH, int NGBLELIHMDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x82B9920", Offset = "0x82B7F20", VA = "0x1882B9920")]
			private Color HPIIDMFPOMB(Color ALJEEBKCDKP, LBKDHFCBEJK LKFLFFGPJIL)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x82B95C0", Offset = "0x82B7BC0", VA = "0x1882B95C0")]
			private Color FBOPEKKGJKB(Color NPBOFGOAKCN, LBKDHFCBEJK LKFLFFGPJIL)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x82B9890", Offset = "0x82B7E90", VA = "0x1882B9890")]
			protected void HBHGOGPGEBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x82B9580", Offset = "0x82B7B80", VA = "0x1882B9580", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x82C3020", Offset = "0x82C1620", VA = "0x1882C3020")]
			public void OFOBBJJOKOL(CNFLLNFLBIO CGKEIIDMLBB, [Out] Transform PPOKNBNEDHM, [Out] Transform[] KGGMFKPKBNC)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class DJIIABJMLPO : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
			[DebuggerHidden]
			public DJIIABJMLPO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x82B4FA0", Offset = "0x82B35A0", VA = "0x1882B4FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x82B5220", Offset = "0x82B3820", VA = "0x1882B5220", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x82B5170", Offset = "0x82B3770", VA = "0x1882B5170", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x82B5170", Offset = "0x82B3770", VA = "0x1882B5170", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class AJOEPKNKKPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public AJOEPKNKKPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x82B41F0", Offset = "0x82B27F0", VA = "0x1882B41F0")]
			internal bool OJPJJMDNCOD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class BGPKAKLPCLE : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private BJJPNELKDDJ <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public BGPKAKLPCLE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x82B4750", Offset = "0x82B2D50", VA = "0x1882B4750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x82B4AA0", Offset = "0x82B30A0", VA = "0x1882B4AA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct MFMCPANJIAM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public HKEIODNMLBG avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x82B83E0", Offset = "0x82B69E0", VA = "0x1882B83E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x82B8780", Offset = "0x82B6D80", VA = "0x1882B8780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class COFICJEAANJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public COFICJEAANJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x82B4F70", Offset = "0x82B3570", VA = "0x1882B4F70")]
			internal bool KMGPCIFMEKJ(JAEIIDNBJMP selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class DMDBEEMDJJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Func<LDNIFFJFEMD<Dictionary<string, LHNBHFNPODB<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public DMDBEEMDJJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x82B52E0", Offset = "0x82B38E0", VA = "0x1882B52E0")]
			internal (BCEMNDENGIG, LDNIFFJFEMD<Dictionary<string, LHNBHFNPODB<Texture2D>>>) KJOMHMKJDOG(Dictionary<string, FBGBKPGFJBB> avatarItems)
			{
				return default((BCEMNDENGIG, LDNIFFJFEMD<Dictionary<string, LHNBHFNPODB<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x82B5270", Offset = "0x82B3870", VA = "0x1882B5270")]
			internal LDNIFFJFEMD<Dictionary<string, LHNBHFNPODB<Texture2D>>> CAIGPIHBLIL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x82B54E0", Offset = "0x82B3AE0", VA = "0x1882B54E0")]
			internal void LDAKEJDNJMP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class MIAMCKLOPEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public MIAMCKLOPEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x82B87E0", Offset = "0x82B6DE0", VA = "0x1882B87E0")]
			internal bool HJEDCMBOKMK(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct OECBCDGHNED : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x82BB360", Offset = "0x82B9960", VA = "0x1882BB360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x82BB530", Offset = "0x82B9B30", VA = "0x1882BB530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected static readonly int JENHCOGNGOB;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		protected static readonly int EIOIBOFLAAO;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected static readonly int JFOJEMMKKJK;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected static readonly int MKBNFCKIODK;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		protected static readonly int PPGFICFGCHO;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		protected static readonly int JLNFIOKGPJI;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected static readonly int[] IBOEOHIODDP;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected static readonly int[] IBGKHBFFJFL;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected static readonly int[] NJFMDGJDMHL;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected static readonly int[] EAJLEJICPJH;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected static readonly int[] DKBLJKJGKJD;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		protected static readonly int[] ACMGGLHALKE;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected static List<PlayerAvatarDisplayBase> OLALMNBMCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected AEJMMPKIJPB KIJPDKNONKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		protected bool HABIFIEABOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected bool FICELEFKPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected static readonly int[] PIBKMMGJMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected Dictionary<BBPLIFLJHDO, Material> BPKNBIEJHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected Dictionary<BBPLIFLJHDO, Material> EPILPPNFDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected Material MODLDOLMIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected BGCOFBKKHJK ENPGJNPLFLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private PNBAICGDONK MOMNMJCKIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private PNBAICGDONK JKNBNOKBEMD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Material GHHKAANHMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected FitMeshHemisphere KDDAGELGNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected bool IEENNFKENCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected NKKOKKMIKCN NBLKKBHLIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected bool NECFFKPOKKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected AnchorParamsRestrictions PACLIDAAMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected bool ONNGPGMMJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected Transform GLOFEFCFBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected bool GPBKGKDLAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected bool PNLBPJCDNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected Vector3 DAKDMKDHOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Quaternion ANJLEJLFONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected Vector2 GLBFLCGNMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected FitMeshHemisphere CPIOENNKMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[SerializeField]
		[HPOJEGADLAJ(BMGFACECMPD.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Collider[] ACONCBADHHK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Collider[] OFJLMEIJECM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected LEPBIOOKEPB[] GNOIEFENKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public Dictionary<Renderer, NOFDKHEFKJD> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Dictionary<Renderer, NOFDKHEFKJD> IEGAPDEOMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected KCPENKNIELE PNFKLGJGHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected BCEMNDENGIG OBOBEHLAIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public JGCNGACGAAH DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected int HDJHNCFDENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected (bool isLodForced, int forcedLOD) MOPEANGDAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected BJGHJEFJAHK<PCCAPIFPEFE> CIKJKIGKPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected bool GLDBGJDEAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Dictionary<JAEIIDNBJMP, List<BBPLIFLJHDO>> CEINNBKJIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected Dictionary<JAEIIDNBJMP, List<BBPLIFLJHDO>> IANIGMJLOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected readonly Dictionary<string, LHNBHFNPODB<Texture2D>> FAINOHHMODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected readonly Dictionary<string, LHNBHFNPODB<Texture2D>> MAILNOIGNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected bool JNDDNJNJIJD;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected static int EKGFCDECGGG;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected static List<GMGNJJGBNEF> DAEHMLHLHIH;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected static List<GMGNJJGBNEF> KBCNGAIFDPL;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected static APLPOCKIJEJ HDNPLGLDOAJ;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected static Func<List<GMGNJJGBNEF>, GMGNJJGBNEF> IEPPFNEAJMD;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected static bool FBDOFCJKGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		protected Color? DINANAJOLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected bool CAFCPACJHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected Color PDKJGBFFNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected Color LIKDNFMEGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected Color CJEAOHBPHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected AvatarHairPattern PFILEMLFENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected DOBBNIFBALE DAKOBBNFFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected Color CIJKOCIKHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected Color FPFPLJBPNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		protected AvatarHairPattern GFNKMHHJAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		protected DOBBNIFBALE MCAMDEJIAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected DOBBNIFBALE CCJJNMOGGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		protected Color ENMIGGBDMDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private AdditionalFeetData PNNNDAGFOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		protected JAEIIDNBJMP? IFIDEILCLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		protected Texture CNLINAELPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected Color JDDBBBOAHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected readonly IList<JAEIIDNBJMP> JODILJDEGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected readonly IList<JAEIIDNBJMP> ICJGOKELGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private AvatarItemBodyType FJABMMHMEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[SerializeField]
		protected DNBLNCAFAFK _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		protected NNMHDKDDPPK MDHPAJMMNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		protected int[] ECFKAJGPDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		protected bool IDIKFDFBBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		protected int[] KNDFKOOCKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		protected bool LIKKAGLNALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		protected bool MGDEEBMGCLN;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private static readonly LINIKLIADHK.NMCDOKKFLGH MIBEMIHGAOM;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private static readonly LINIKLIADHK.NMCDOKKFLGH AFPAJBBCPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F2")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		protected bool DDLBIMBNJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		protected KJDPPPJGPNL MGDOPAOCHJD;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string MFICPJNOKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool HEJJKGFADJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xD59A60", Offset = "0xD58060", VA = "0x180D59A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xD58D60", Offset = "0xD57360", VA = "0x180D58D60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool NMKJIOCIAGA
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool AJKMOFJLBMG
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x82B2910", Offset = "0x82B0F10", VA = "0x1882B2910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool IKELAHAOBII
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool JGLNHJLIDBG
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool HPEGICNKKGB
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool GKAHJBADAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public BGCOFBKKHJK IOBNGAAAADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xC04210", Offset = "0xC02810", VA = "0x180C04210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x82B30F0", Offset = "0x82B16F0", VA = "0x1882B30F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public PNBAICGDONK MHHLPBEAKOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xC0ECE0", Offset = "0xC0D2E0", VA = "0x180C0ECE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x82B34F0", Offset = "0x82B1AF0", VA = "0x1882B34F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public PNBAICGDONK CDMAHCJHNHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xC1EDB0", Offset = "0xC1D3B0", VA = "0x180C1EDB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x82B37B0", Offset = "0x82B1DB0", VA = "0x1882B37B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material IGGIJEDOIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x82A5120", Offset = "0x82A3720", VA = "0x1882A5120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material IELPONMJIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x82ACAD0", Offset = "0x82AB0D0", VA = "0x1882ACAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool ONDOOFNIBME
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x25508E0", Offset = "0x254EEE0", VA = "0x1825508E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase AHBMDNHIJAH
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xC1EFC0", Offset = "0xC1D5C0", VA = "0x180C1EFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public LEPBIOOKEPB[] OHDANMOOLHI
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x82B2490", Offset = "0x82B0A90", VA = "0x1882B2490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public LEPBIOOKEPB FMEKHOKIANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x82B2B20", Offset = "0x82B1120", VA = "0x1882B2B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public LEPBIOOKEPB BNJJGLPNKAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x82B2B50", Offset = "0x82B1150", VA = "0x1882B2B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh ALDIJJDNLLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xBA81D0", Offset = "0xBA67D0", VA = "0x180BA81D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected KCPENKNIELE DNIACBFFPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x82A6890", Offset = "0x82A4E90", VA = "0x1882A6890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected BCEMNDENGIG PJPANPAHGHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xC1FA90", Offset = "0xC1E090", VA = "0x180C1FA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x82A7560", Offset = "0x82A5B60", VA = "0x1882A7560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool PDPNAFFOPPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool ECLKLFCFPAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x82B2B10", Offset = "0x82B1110", VA = "0x1882B2B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int NNIJBBGPGFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x13B3D10", Offset = "0x13B2310", VA = "0x1813B3D10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x82B3700", Offset = "0x82B1D00", VA = "0x1882B3700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int EPKEOIAGHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x82B3440", Offset = "0x82B1A40", VA = "0x1882B3440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool CHMMGONOPNB
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] NHOPFEKCEMG
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x82AC3B0", Offset = "0x82AA9B0", VA = "0x1882AC3B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool DDGDMEJNLEG
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x82AC290", Offset = "0x82AA890", VA = "0x1882AC290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool CBBHPDJKDMF
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool FEDGBLFBNMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x82B2B80", Offset = "0x82B1180", VA = "0x1882B2B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x82B39D0", Offset = "0x82B1FD0", VA = "0x1882B39D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> IEHBJDOFGOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x82B2310", Offset = "0x82B0910", VA = "0x1882B2310")]
			[IteratorStateMachine(typeof(DJIIABJMLPO))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool MMNPCHICOFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x82B2B00", Offset = "0x82B1100", VA = "0x1882B2B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x82AD310", Offset = "0x82AB910", VA = "0x1882AD310")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public GAPGDDKJAHD JONCMKBDACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x82B2390", Offset = "0x82B0990", VA = "0x1882B2390")]
			get
			{
				return default(GAPGDDKJAHD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool PJGHENGGGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x82B2840", Offset = "0x82B0E40", VA = "0x1882B2840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static APLPOCKIJEJ BLKJDCHLCJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x82A8870", Offset = "0x82A6E70", VA = "0x1882A8870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x82A79D0", Offset = "0x82A5FD0", VA = "0x1882A79D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color FKKJDKGOJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x82A4D00", Offset = "0x82A3300", VA = "0x1882A4D00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color OGBKKHLMFDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x82ABBA0", Offset = "0x82AA1A0", VA = "0x1882ABBA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D BFPFAICIEMK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x82A6710", Offset = "0x82A4D10", VA = "0x1882A6710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color GGOMCLOPCDK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x82B2440", Offset = "0x82B0A40", VA = "0x1882B2440")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color ACAIPHBJOKN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x82ABB50", Offset = "0x82AA150", VA = "0x1882ABB50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public DOBBNIFBALE PPGDKPENENJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x82B2400", Offset = "0x82B0A00", VA = "0x1882B2400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D IOPODKCPINC
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x82AD3D0", Offset = "0x82AB9D0", VA = "0x1882AD3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float EEJKBFCHJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x82B2420", Offset = "0x82B0A20", VA = "0x1882B2420")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float JNGCMHCPDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x82B28F0", Offset = "0x82B0EF0", VA = "0x1882B28F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool PABBLOHKNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x82B23F0", Offset = "0x82B09F0", VA = "0x1882B23F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x82B2ED0", Offset = "0x82B14D0", VA = "0x1882B2ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CNIAFDFLFEE
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x82B2070", Offset = "0x82B0670", VA = "0x1882B2070")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x82B2C30", Offset = "0x82B1230", VA = "0x1882B2C30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action COBFCLFJFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x82B1FD0", Offset = "0x82B05D0", VA = "0x1882B1FD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x82B2B90", Offset = "0x82B1190", VA = "0x1882B2B90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action GDFIONKBIHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x82B2110", Offset = "0x82B0710", VA = "0x1882B2110")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x82B2CD0", Offset = "0x82B12D0", VA = "0x1882B2CD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CBMIGJMFDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x82B21B0", Offset = "0x82B07B0", VA = "0x1882B21B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x82B2D70", Offset = "0x82B1370", VA = "0x1882B2D70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ALJNENPBFBE, DMJJMIOILDN> HDKONHGJGDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x82B2250", Offset = "0x82B0850", VA = "0x1882B2250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x82B2E10", Offset = "0x82B1410", VA = "0x1882B2E10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x82AE820", Offset = "0x82ACE20", VA = "0x1882AE820")]
		public bool SetDeformation(bool HABIFIEABOH, bool FICELEFKPKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x82A7EA0", Offset = "0x82A64A0", VA = "0x1882A7EA0")]
		protected static Material FALFDHEKHHO(Dictionary<BBPLIFLJHDO, Material> LLINHEGJMKN, Material HFKOJHOBIIO, LBKDHFCBEJK MNAHCNBLCAI, ODBONJPGMFN MHAGPICIDAI, CNFLLNFLBIO CGKEIIDMLBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x82A7280", Offset = "0x82A5880", VA = "0x1882A7280")]
		protected void DDGBCDLCFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x82A88C0", Offset = "0x82A6EC0", VA = "0x1882A88C0")]
		protected bool GIFHPPMCLGC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x82AAA30", Offset = "0x82A9030", VA = "0x1882AAA30")]
		protected void JILPFCHDJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x82A55F0", Offset = "0x82A3BF0", VA = "0x1882A55F0", Slot = "11")]
		protected virtual void AKNAFMMADLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x82AC0A0", Offset = "0x82AA6A0", VA = "0x1882AC0A0")]
		public int MeshesAtLODCount(int IHFNCIDONCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x82AAF20", Offset = "0x82A9520", VA = "0x1882AAF20")]
		protected static void LCAOKMGLODL(Dictionary<JAEIIDNBJMP, List<BBPLIFLJHDO>> GKLIJOFCGJM, ABGMHDGHPMI MJMCGHLLAPJ, Material HFKOJHOBIIO, LBKDHFCBEJK LKFLFFGPJIL, ODBONJPGMFN GKBBGLJBHBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F10", Offset = "0x82A4510", VA = "0x1882A5F10")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x82A8B80", Offset = "0x82A7180", VA = "0x1882A8B80")]
		protected void GJEMOILJIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x82AD060", Offset = "0x82AB660", VA = "0x1882AD060")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "12")]
		protected virtual void OPBHOFLAABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x82AA390", Offset = "0x82A8990", VA = "0x1882AA390")]
		protected static void IJFEPDAOBKP(List<Material> ECHMIKAECAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x82AD9E0", Offset = "0x82ABFE0", VA = "0x1882AD9E0")]
		protected static void PJCFIPGGDJO(Dictionary<BBPLIFLJHDO, Material> LLINHEGJMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x82A65B0", Offset = "0x82A4BB0", VA = "0x1882A65B0")]
		protected static void CICPNJKOKEE(Dictionary<Renderer, NOFDKHEFKJD> NCELNKGGKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x82A54D0", Offset = "0x82A3AD0", VA = "0x1882A54D0")]
		protected void AIGPPDKHCEC(SkinnedMeshRenderer[] GECBOGLJJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x82A5430", Offset = "0x82A3A30", VA = "0x1882A5430")]
		protected void AIELABAICAL(SkinnedMeshRenderer ENBMIILLDMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x82A5360", Offset = "0x82A3960", VA = "0x1882A5360")]
		protected void AIELABAICAL(MeshRenderer AGMIMJIBEFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x82A4F50", Offset = "0x82A3550", VA = "0x1882A4F50")]
		protected void ADLAGOGOBBB(List<LOOEBIAEJGK> KEEGPMLIONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x82ACCC0", Offset = "0x82AB2C0", VA = "0x1882ACCC0")]
		protected void OEAJCJKNLNL(Dictionary<string, LHNBHFNPODB<Texture2D>> GKLIJOFCGJM, bool OBPHEFOLMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x82A80D0", Offset = "0x82A66D0", VA = "0x1882A80D0")]
		protected void FGBIIGHJHHA(Dictionary<JAEIIDNBJMP, List<BBPLIFLJHDO>> GKLIJOFCGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x82A8F30", Offset = "0x82A7530", VA = "0x1882A8F30")]
		public float GetHandOpenClosedAxis(ALJNENPBFBE DCPACHMEKCM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x82AF0B0", Offset = "0x82AD6B0", VA = "0x1882AF0B0")]
		public void SetHandOpenClosedAxis(ALJNENPBFBE DCPACHMEKCM, float BBGBNGIOFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x82A8F70", Offset = "0x82A7570", VA = "0x1882A8F70")]
		public DMJJMIOILDN GetHandVisualState(ALJNENPBFBE DCPACHMEKCM)
		{
			return default(DMJJMIOILDN);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x82A5650", Offset = "0x82A3C50", VA = "0x1882A5650")]
		public bool AddHandVisualStateToken(ALJNENPBFBE DCPACHMEKCM, DMJJMIOILDN PEMDNILEHAF, object HNGIMMGBLII, LEPBIOOKEPB.HPCKELKAMBC DLELGMMBCCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x82B0950", Offset = "0x82AEF50", VA = "0x1882B0950")]
		public void SetWatchHand(ALJNENPBFBE DCPACHMEKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x82B0A10", Offset = "0x82AF010", VA = "0x1882B0A10")]
		public void SetWatchHands(bool JDFNHGINABF, bool HIOAJBPMPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x82ADEE0", Offset = "0x82AC4E0", VA = "0x1882ADEE0")]
		public bool RemoveHandVisualStateToken(ALJNENPBFBE DCPACHMEKCM, object HNGIMMGBLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x82A8FF0", Offset = "0x82A75F0", VA = "0x1882A8FF0")]
		public bool GetThumbsUpActive(ALJNENPBFBE DCPACHMEKCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x82B0360", Offset = "0x82AE960", VA = "0x1882B0360")]
		public void SetThumbsUpActive(ALJNENPBFBE DCPACHMEKCM, bool FDOHADEGFNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x82A8FB0", Offset = "0x82A75B0", VA = "0x1882A8FB0")]
		public bool GetHandshakeActive(ALJNENPBFBE DCPACHMEKCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x82AF100", Offset = "0x82AD700", VA = "0x1882AF100")]
		public void SetHandshakeActive(ALJNENPBFBE DCPACHMEKCM, bool ACGFIAEHMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x82A8820", Offset = "0x82A6E20", VA = "0x1882A8820")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x82B0840", Offset = "0x82AEE40", VA = "0x1882B0840")]
		public void SetUseClassicBeanHandScale(bool FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x82A6EB0", Offset = "0x82A54B0", VA = "0x1882A6EB0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x82AC160", Offset = "0x82AA760", VA = "0x1882AC160")]
		private static void NDMGHLGOINH(Scene PDFMOBOALJB, LoadSceneMode JDJJDFOGKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x82ACBC0", Offset = "0x82AB1C0", VA = "0x1882ACBC0")]
		protected static void ODPAGAOMBAD(PlayerAvatarDisplayBase PFEOBJDJLPO, List<GMGNJJGBNEF> JNHCCGDIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x82ADC00", Offset = "0x82AC200", VA = "0x1882ADC00")]
		public CNOKEDEBLOH Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x82AB3B0", Offset = "0x82A99B0", VA = "0x1882AB3B0")]
		protected CNOKEDEBLOH LJPEDIDADEB(bool NABDALPKBJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x82AB410", Offset = "0x82A9A10", VA = "0x1882AB410", Slot = "13")]
		protected virtual CNOKEDEBLOH LJPEDIDADEB(IList<JAEIIDNBJMP> ICMJAMELLMN, AvatarItemBodyType AGKAANOHBFL, bool JPNHFHJDILC, bool FFIHPNNJKOH, int[] GBPPIJINKJN, bool NABDALPKBJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x82AD4D0", Offset = "0x82ABAD0", VA = "0x1882AD4D0")]
		protected static CNOKEDEBLOH PGKPKBFCECC(GMGNJJGBNEF PPPLJIMDCPK, List<GMGNJJGBNEF> JNHCCGDIAGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x82AAEC0", Offset = "0x82A94C0", VA = "0x1882AAEC0")]
		[IteratorStateMachine(typeof(BGPKAKLPCLE))]
		protected static IEnumerator<BJJPNELKDDJ> KLPKMJBPIIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x82AA9A0", Offset = "0x82A8FA0", VA = "0x1882AA9A0")]
		protected static GMGNJJGBNEF JHCLILFAPPA(List<GMGNJJGBNEF> JNHCCGDIAGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x82AE920", Offset = "0x82ACF20", VA = "0x1882AE920")]
		[AsyncStateMachine(typeof(MFMCPANJIAM))]
		public Task SetFaceCustomizationSettings(HKEIODNMLBG EBBCNNOGLPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x82B0B70", Offset = "0x82AF170", VA = "0x1882B0B70")]
		public bool UpdateFaceAndBodyCustomizationSettings(HKEIODNMLBG EBBCNNOGLPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x82AA7A0", Offset = "0x82A8DA0", VA = "0x1882AA7A0")]
		public void InitializeFaceFeatures(AvatarConfiguration LOJIBPFKFPE, GAPGDDKJAHD JGCEJNPMHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x82B00C0", Offset = "0x82AE6C0", VA = "0x1882B00C0")]
		public void SetTeamColors(Color? MIGDDKOLMBD, bool AEBAMEKIEDH, Color IAOBMNMFPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1567680", Offset = "0x1565C80", VA = "0x181567680")]
		private static void HLKDPPFABNI(Material JKDFAJLFBEL, Color FKMNCAKIOFK, params int[] KHMMDELIDPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1567B70", Offset = "0x1566170", VA = "0x181567B70")]
		private static void KMKJOOIMGNC(Material JKDFAJLFBEL, Texture FKMNCAKIOFK, params int[] KHMMDELIDPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x82A8490", Offset = "0x82A6A90", VA = "0x1882A8490")]
		protected void FLOMACDPKFG(Material BHCKBGCCDLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x82AA880", Offset = "0x82A8E80", VA = "0x1882AA880")]
		protected void JGMCMOFOLJG(Material BHCKBGCCDLE, Color BBDNIGKKAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x82AB5F0", Offset = "0x82A9BF0", VA = "0x1882AB5F0")]
		protected void LMECIHKDPJN(Material BHCKBGCCDLE, Color BBDNIGKKAHC, Color BAIKLJPKDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x82ACE40", Offset = "0x82AB440", VA = "0x1882ACE40")]
		protected void OLDJOABCNAG(Material BHCKBGCCDLE, Texture2D BHNOPLHICEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x82A9030", Offset = "0x82A7630", VA = "0x1882A9030")]
		protected void HDDKGBCACMI(Material BHCKBGCCDLE, Texture KEGFHNDCLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x82A6FD0", Offset = "0x82A55D0", VA = "0x1882A6FD0")]
		protected void DBEHNBLMAPN(Action<NOFDKHEFKJD> IHOHNINDBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x82A60A0", Offset = "0x82A46A0", VA = "0x1882A60A0")]
		protected void BBCIPJLBGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x82A8220", Offset = "0x82A6820", VA = "0x1882A8220")]
		protected void FIHBMGLDIAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x82ABBF0", Offset = "0x82AA1F0", VA = "0x1882ABBF0")]
		protected void MDOJGJDINMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x82A59A0", Offset = "0x82A3FA0", VA = "0x1882A59A0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x82AE2A0", Offset = "0x82AC8A0", VA = "0x1882AE2A0")]
		public void SetBeardPrimaryColor([Optional] Color? CJNIBMEPPEK, bool NCPMOJBIINF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x82AE4C0", Offset = "0x82ACAC0", VA = "0x1882AE4C0")]
		public void SetBeardSecondaryColor([Optional] Color? CJNIBMEPPEK, bool NCPMOJBIINF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x82AE160", Offset = "0x82AC760", VA = "0x1882AE160")]
		public void SetBeardPattern([Optional] AvatarHairPattern DNJPLOOCCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x82AC440", Offset = "0x82AAA40", VA = "0x1882AC440")]
		private void OALHKIDAKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x82AB540", Offset = "0x82A9B40", VA = "0x1882AB540")]
		private bool LLACPBBPIFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x82AEC90", Offset = "0x82AD290", VA = "0x1882AEC90")]
		public void SetHairPrimaryColor([Optional] Color? FOBPLFIJKKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x82AEEA0", Offset = "0x82AD4A0", VA = "0x1882AEEA0")]
		public void SetHairSecondaryColor([Optional] Color? FOBPLFIJKKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x82AEB60", Offset = "0x82AD160", VA = "0x1882AEB60")]
		public void SetHairPattern([Optional] AvatarHairPattern DNJPLOOCCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x82ADD80", Offset = "0x82AC380", VA = "0x1882ADD80")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x82ABF50", Offset = "0x82AA550", VA = "0x1882ABF50")]
		private bool MGIEOLNKCMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF00", Offset = "0x82AE500", VA = "0x1882AFF00")]
		public void SetSkinColor(Color FLDOKNIDLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x82B03B0", Offset = "0x82AE9B0", VA = "0x1882B03B0")]
		public void SetUgcItemVisualOverrides(JAEIIDNBJMP BNMBOEAPFJM, GAPGDDKJAHD JGCEJNPMHBE, Texture HLFNCLBHPGO, Color HEKIKFPHLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x82A6F80", Offset = "0x82A5580", VA = "0x1882A6F80")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x82AEA20", Offset = "0x82AD020", VA = "0x1882AEA20")]
		public bool SetFaceShape(AvatarFaceShape GDEBJFFEGLC, bool PKJELNLDBFJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x82AB310", Offset = "0x82A9910", VA = "0x1882AB310")]
		private void LJMFLNJNOIC(LEJNJPPLAEC DPEDINMGGCJ, float FKMNCAKIOFK, bool MFEMPBPAPKD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x82A4D50", Offset = "0x82A3350", VA = "0x1882A4D50")]
		private void ABBPJNMMGCM(JDNHKKJDLNL FFCEAEGPHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x82A8AE0", Offset = "0x82A70E0", VA = "0x1882A8AE0")]
		private void GIMOBFEKDJJ(JLMLEMJCHNF LBPJEIAHAMD, float FKMNCAKIOFK, bool HOGHHCEKAGF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x82A9250", Offset = "0x82A7850", VA = "0x1882A9250")]
		private void HMHNMCLFFII(LFLPBIOKFCJ BIMFMAMODJM, float FKMNCAKIOFK, bool FNEIALKHIIL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x82A9140", Offset = "0x82A7740", VA = "0x1882A9140")]
		private void HMCOLKFGNEE(IFAIOAKKDBI OGMPDDOJIMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x82A6480", Offset = "0x82A4A80", VA = "0x1882A6480")]
		private void CAIEGFONDBC(HKFNKMLJFNF NJCNIJOFDCD, float LGACNMEMAAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x82AE6E0", Offset = "0x82ACCE0", VA = "0x1882AE6E0")]
		public bool SetBodyShape(AvatarBodyShape MPOJLHMBMMO, bool PKJELNLDBFJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x82AFD70", Offset = "0x82AE370", VA = "0x1882AFD70")]
		public bool SetNoseType(DNBLNCAFAFK OAJAMIMOOLF, bool PKJELNLDBFJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x82B1260", Offset = "0x82AF860", VA = "0x1882B1260")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x82AFD50", Offset = "0x82AE350", VA = "0x1882AFD50")]
		public bool SetHideEars(bool HKCDNACOHMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x82AFD40", Offset = "0x82AE340", VA = "0x1882AFD40")]
		public bool SetHelmetHair(AEJMMPKIJPB BCKKIPENNME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x82AF7A0", Offset = "0x82ADDA0", VA = "0x1882AF7A0")]
		public void SetHatAnchorParameters(NKKOKKMIKCN OEJFJGBMACK, bool BJCBNOGCHNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x82AFEE0", Offset = "0x82AE4E0", VA = "0x1882AFEE0")]
		public bool SetShowModestyAndValidationGuidelines(bool KMPHCDOCLNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x82B0AE0", Offset = "0x82AF0E0", VA = "0x1882B0AE0")]
		public void SetupDisplayLODs(NNMHDKDDPPK BANMIJELNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x82A73A0", Offset = "0x82A59A0", VA = "0x1882A73A0")]
		protected int[] DFELLKKILCL(NNMHDKDDPPK BANMIJELNKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE10", Offset = "0x82AE410", VA = "0x1882AFE10")]
		public void SetOutfitSelections(IList<JAEIIDNBJMP> ICMJAMELLMN, AvatarItemBodyType AGKAANOHBFL, bool FFIHPNNJKOH, bool NABDALPKBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE90", Offset = "0x82AE490", VA = "0x1882AFE90")]
		public void SetOutfitSelections(IList<JAEIIDNBJMP> ICMJAMELLMN, AvatarItemBodyType AGKAANOHBFL, bool JPNHFHJDILC, bool FFIHPNNJKOH, bool NABDALPKBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE50", Offset = "0x82AE450", VA = "0x1882AFE50")]
		public CNOKEDEBLOH SetOutfitSelections(IList<JAEIIDNBJMP> ICMJAMELLMN, AvatarItemBodyType AGKAANOHBFL, NNMHDKDDPPK BANMIJELNKD, bool JPNHFHJDILC, bool FFIHPNNJKOH, bool PKJELNLDBFJ = false, bool NABDALPKBJC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x82A7C10", Offset = "0x82A6210", VA = "0x1882A7C10", Slot = "14")]
		protected virtual CNOKEDEBLOH EJLCHJHFMJN(IList<JAEIIDNBJMP> ICMJAMELLMN, AvatarItemBodyType AGKAANOHBFL, bool JPNHFHJDILC, bool FFIHPNNJKOH, NNMHDKDDPPK BANMIJELNKD, bool PKJELNLDBFJ, bool NABDALPKBJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x82A8120", Offset = "0x82A6720", VA = "0x1882A8120")]
		protected int[] FHIMKBMJKFF(NNMHDKDDPPK BANMIJELNKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "15")]
		protected virtual BCEMNDENGIG JMNEKBJPJNC(AvatarItemBodyType JPMNEABEAJJ, Dictionary<string, FBGBKPGFJBB> BCBEHOGLCIA, Dictionary<string, LHNBHFNPODB<Texture2D>> NJOLBFAKPFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x82AABF0", Offset = "0x82A91F0", VA = "0x1882AABF0", Slot = "16")]
		protected virtual CNOKEDEBLOH KCNGGKLHGLP(IList<JAEIIDNBJMP> ICMJAMELLMN, AvatarItemBodyType AGKAANOHBFL, bool JPNHFHJDILC, bool FFIHPNNJKOH, int[] KEEKDKJJLJA, AMHMHHMNFOE EPBOJOCIIKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x82AC5B0", Offset = "0x82AABB0", VA = "0x1882AC5B0", Slot = "17")]
		protected virtual FBGBKPGFJBB OCFHNFOMJEI(DOBBNIFBALE MFIKOFMJJDD, AvatarItemBodyType JPMNEABEAJJ, CNFLLNFLBIO CGKEIIDMLBB, FBGBKPGFJBB AIFBFHFALKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "18")]
		protected virtual FBGBKPGFJBB DHNHPJPHNNC(AvatarItemBodyType JPMNEABEAJJ, CNFLLNFLBIO CGKEIIDMLBB, DINOEKMOGPF AEAKONLNGGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x82A8EB0", Offset = "0x82A74B0", VA = "0x1882A8EB0")]
		protected void GLBBMGBBGKH(DOCFJJABDFF DBKPHAFJDAP, LINIKLIADHK.NMCDOKKFLGH MEJBGKLCJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x82A8710", Offset = "0x82A6D10", VA = "0x1882A8710")]
		protected void FOOPHMEMNBO(DOCFJJABDFF DBKPHAFJDAP, LINIKLIADHK.NMCDOKKFLGH MEJBGKLCJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xAFB050", Offset = "0xAF9650", VA = "0x180AFB050", Slot = "19")]
		protected virtual DOCFJJABDFF DMBHCMFLNFL(DOCFJJABDFF DBKPHAFJDAP, HelmetHairStyle OMIFMBHEHLE, bool PMLFFCCCEKG, AvatarItemBodyType AGKAANOHBFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x82A92F0", Offset = "0x82A78F0", VA = "0x1882A92F0")]
		protected DOCFJJABDFF IBHANDIKEFN(IList<JAEIIDNBJMP> ICMJAMELLMN, AvatarItemBodyType JOGBOMPMPDI, bool FFIHPNNJKOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x82A6D90", Offset = "0x82A5390", VA = "0x1882A6D90")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x82AD320", Offset = "0x82AB920", VA = "0x1882AD320")]
		protected void PBOFBLOHCIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x82AB820", Offset = "0x82A9E20", VA = "0x1882AB820")]
		protected void MCJMDEFKBPM(Transform MIIBBBFHDMO, IEnumerable<SkinnedMeshRenderer> MDGMBCPLOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x82ADB40", Offset = "0x82AC140", VA = "0x1882ADB40")]
		protected LINIKLIADHK.NMCDOKKFLGH PMDHFAJKGBJ(LINIKLIADHK.NMCDOKKFLGH EPGJOCOOIBI, CNFLLNFLBIO MMEODAJENEO)
		{
			return default(LINIKLIADHK.NMCDOKKFLGH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x82A7E90", Offset = "0x82A6490", VA = "0x1882A7E90")]
		protected void ELIDJLINMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1AA6B40", Offset = "0x1AA5140", VA = "0x181AA6B40")]
		protected void EKMJPAJCLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x82A78C0", Offset = "0x82A5EC0", VA = "0x1882A78C0")]
		protected void EGPPIBLBHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x82A8000", Offset = "0x82A6600", VA = "0x1882A8000")]
		[AsyncStateMachine(typeof(OECBCDGHNED))]
		protected Task FFFDPOOMOFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x82A62E0", Offset = "0x82A48E0", VA = "0x1882A62E0")]
		protected static LBKDHFCBEJK BCNFFFCMDMD(ABGMHDGHPMI MPBAPJEHKLD, int COFJHONJGIJ)
		{
			return default(LBKDHFCBEJK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x82A7770", Offset = "0x82A5D70", VA = "0x1882A7770")]
		protected static ODBONJPGMFN EDDMIENGJBH(ABGMHDGHPMI MPBAPJEHKLD, int COFJHONJGIJ)
		{
			return default(ODBONJPGMFN);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x82AA340", Offset = "0x82A8940", VA = "0x1882AA340")]
		protected Transform IFBFOECNKCM(CNFLLNFLBIO CGKEIIDMLBB, OutfitType FPGBMFMFODG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x82AA510", Offset = "0x82A8B10", VA = "0x1882AA510")]
		protected void ILBNKMKGGHM(int LIJMKKBPIGG, Material JKDFAJLFBEL, ABGMHDGHPMI MPBAPJEHKLD, [Out] Texture2D JJLFHHCIFOB, [Out] Vector4 LACEIOJGBFD, [Out] Texture2D NGGGBMLEFCB, [Out] Texture2D BMECKEAMLCK, [Out] Texture2D MNKKNFKOHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x82A7130", Offset = "0x82A5730", VA = "0x1882A7130")]
		protected void DDFDPDPAMND(int LIJMKKBPIGG, Material JKDFAJLFBEL, ABGMHDGHPMI MPBAPJEHKLD, [Out] Color FLBNNCEFFNJ, [Out] Color EKIHOOEAHFC, [Out] Color GLIOJJENHLP, [Out] Color GNDAMCHEKMO, [Out] Color DIFAOKDGHJK, [Out] Color OBFDGEJHJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x82A7BA0", Offset = "0x82A61A0", VA = "0x1882A7BA0")]
		protected void EIEPPALMBMG(Vector3 IIKJNDDFMGG, Quaternion NEMGOCEHIKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x82AF150", Offset = "0x82AD750", VA = "0x1882AF150")]
		public void SetHatAnchorParameters(NKKOKKMIKCN OEJFJGBMACK, AnchorParamsRestrictions PJNHBKPKKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x82A68B0", Offset = "0x82A4EB0", VA = "0x1882A68B0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere KDDAGELGNDN, Transform GLOFEFCFBOK, NKKOKKMIKCN OEJFJGBMACK, AnchorParamsRestrictions PACLIDAAMLN, [Out] Vector3 AEDFHMKGLON, [Out] Quaternion IOCPNAEAJJE, [Out] NKKOKKMIKCN KMHLDLOOJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x82ADFF0", Offset = "0x82AC5F0", VA = "0x1882ADFF0")]
		public void ResetHatAnchor(Vector2 GGBJECBKPAO, Vector3 LDDEODCBKOL, Vector3 MHENPFCKHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xC02680", Offset = "0xC00C80", VA = "0x180C02680")]
		public BBLFEOKPNJH GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x82A57D0", Offset = "0x82A3DD0", VA = "0x1882A57D0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x82A5910", Offset = "0x82A3F10", VA = "0x1882A5910")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x82A5740", Offset = "0x82A3D40", VA = "0x1882A5740")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x82B0B10", Offset = "0x82AF110", VA = "0x1882B0B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x82A76A0", Offset = "0x82A5CA0", VA = "0x1882A76A0")]
		protected void EBCJFKCILHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x82B08D0", Offset = "0x82AEED0", VA = "0x1882B08D0")]
		public void SetWaitForUgcTextureLoads(bool BHECEDFCBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x82B0750", Offset = "0x82AED50", VA = "0x1882B0750")]
		public void SetUgcTextureParameters(KJDPPPJGPNL MHCCEBNBPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x82B19C0", Offset = "0x82AFFC0", VA = "0x1882B19C0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x82A8790", Offset = "0x82A6D90", VA = "0x1882A8790")]
		[CompilerGenerated]
		private void FPOICANPKGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x82ACAA0", Offset = "0x82AB0A0", VA = "0x1882ACAA0")]
		[CompilerGenerated]
		private void OCFHPMIMAGO(NOFDKHEFKJD MEEBPHIPHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x82AB280", Offset = "0x82A9880", VA = "0x1882AB280")]
		[CompilerGenerated]
		private void LDONENAHONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x82A7600", Offset = "0x82A5C00", VA = "0x1882A7600")]
		[CompilerGenerated]
		private void DPKJJDMPFLD(NOFDKHEFKJD MEEBPHIPHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x82A6800", Offset = "0x82A4E00", VA = "0x1882A6800")]
		[CompilerGenerated]
		private void CLHAIMDIEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x82AC310", Offset = "0x82AA910", VA = "0x1882AC310")]
		[CompilerGenerated]
		private void NGFFPNALNPP(NOFDKHEFKJD MEEBPHIPHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x82AC010", Offset = "0x82AA610", VA = "0x1882AC010")]
		[CompilerGenerated]
		private void MHNCNIIPKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x82AABA0", Offset = "0x82A91A0", VA = "0x1882AABA0")]
		[CompilerGenerated]
		private void KBEOAIFOBEE(NOFDKHEFKJD MEEBPHIPHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x82AB1F0", Offset = "0x82A97F0", VA = "0x1882AB1F0")]
		[CompilerGenerated]
		private void LCBBCBFLBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x82A8440", Offset = "0x82A6A40", VA = "0x1882A8440")]
		[CompilerGenerated]
		private void FLGEBHIJKAC(NOFDKHEFKJD MEEBPHIPHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x82AA710", Offset = "0x82A8D10", VA = "0x1882AA710")]
		[CompilerGenerated]
		private void INKEFEONKDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x82A8420", Offset = "0x82A6A20", VA = "0x1882A8420")]
		[CompilerGenerated]
		private void FLCPJNNEEAF(NOFDKHEFKJD MEEBPHIPHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x82AAAC0", Offset = "0x82A90C0", VA = "0x1882AAAC0")]
		[CompilerGenerated]
		internal static bool JOFCELKLDDM(Transform ANLOMDGBCDC, IEnumerable<SkinnedMeshRenderer> PLHJIKGDAII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x82A83E0", Offset = "0x82A69E0", VA = "0x1882A83E0")]
		[CompilerGenerated]
		private void FJGEJFNFLLD(NOFDKHEFKJD MEEBPHIPHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x82AA4D0", Offset = "0x82A8AD0", VA = "0x1882AA4D0")]
		[CompilerGenerated]
		private void IJFNMPCOFEL(NOFDKHEFKJD MEEBPHIPHGL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, AAJMNAIDLEH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct JGHPJFKFOCK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public HKEIODNMLBG avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x82B6B30", Offset = "0x82B5130", VA = "0x1882B6B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x82B6DC0", Offset = "0x82B53C0", VA = "0x1882B6DC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct HEOKOEOGIAG : IAsyncStateMachine
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
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public GAPGDDKJAHD avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x82B5B90", Offset = "0x82B4190", VA = "0x1882B5B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x82B5D70", Offset = "0x82B4370", VA = "0x1882B5D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct JFDANBCOIKL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			public GAPGDDKJAHD avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x82B6930", Offset = "0x82B4F30", VA = "0x1882B6930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x82B6AD0", Offset = "0x82B50D0", VA = "0x1882B6AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct PMKHGGOLIAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public HKEIODNMLBG avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x82BC630", Offset = "0x82BAC30", VA = "0x1882BC630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x82BC7E0", Offset = "0x82BADE0", VA = "0x1882BC7E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct HMPBDIILMDJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public GAPGDDKJAHD avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private TaskAwaiter<OGDJHLKPMIE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x82B5DD0", Offset = "0x82B43D0", VA = "0x1882B5DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x82B6210", Offset = "0x82B4810", VA = "0x1882B6210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct CCAMIJBPFBL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public GAPGDDKJAHD avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x82B4AF0", Offset = "0x82B30F0", VA = "0x1882B4AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x82B4F10", Offset = "0x82B3510", VA = "0x1882B4F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected const float AEEONAALGEN = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected const int DCFFEFFMOPK = 5;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private static readonly int PGNDEJAKDPM;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private static readonly int PAKGIFBKNPO;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private static readonly int AHGKDHOPLKB;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected static readonly Dictionary<BGGDANJGGNE.NFEMHKKOOOD, int> LOOAPCGPCNM;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> GJMAPCDFOIF;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected static readonly int OGMKBDDPADB;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected static readonly int JMPBOHGKCBM;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected static readonly int BJPOECHHEMG;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected static readonly int ONEKICOFLNO;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected static readonly int AFBBOPBDMIE;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected static Vector2 CHEIODELKGB;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected static Vector2 OGBCBMHKOBD;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected static Vector2 MHGNIFILCKM;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected static Vector2 FJMAPPIBODF;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected static Vector2 FCDGCLOIFGF;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected static Vector2 OLJAOCKILNJ;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected static Vector2 IANNEBMIGFO;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected static Vector2 KGJOMAHGFEM;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected static Vector2 CLOLNMMLPOL;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected static Vector2 MCEEGOJIGNB;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected static Vector2 KJJKIILHFNO;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected static Vector2 LIGBCFCLJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private GAPGDDKJAHD EHANFHNMPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private FaceStyleSet LDNDEKJEKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected const int CLLHFKLPFNC = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int GABOPJLLLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected int LGCLEBNNNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected int PMDJDFPOCEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected int AJHBPBCMFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Vector2 AAFGKEBKPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected float NPGEDLAEBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected float BGEEFMCNHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected float JIEHMNENLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected Vector2 ANEBMEGAAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected float OFADPFAOPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected float HCHCNKCFAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected float GCPCNMILJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected Vector2 GHNMOEJEGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected float BMGJBBINOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected float BDINJELLNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected float GPPDIIJHPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected Vector2 MPCIOLGNDLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected float PLAMDIDKGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected float ICNPFIFPDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		protected float GEEGOGOKGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		protected List<SelectableFaceOption> DGFKKAKPIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		protected List<SelectableFaceOption> BBEACIFMFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected List<SelectableFaceOption> KALIKPMOPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected List<SelectableFaceOption> KNMOCPEJLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		protected Coroutine EPCMMDIOJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		protected int? GCHGHHACEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected int LOPICEOPALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected int IIHJOACLPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected int JABIJHGHOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		protected int JFBINFOONIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		protected Sprite GDCMGBNGIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		protected Sprite OAJPPKCGMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		protected Sprite GBFLHBLAKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		protected Sprite GOOPAMBGOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected bool IJMFLOEICIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		protected string JPJCIHMBLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		protected string JHELCABFGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		protected string GCLNAAJKANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		protected string CNFOEMCGKGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		protected AvatarConfiguration LOJIBPFKFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		protected OGDJHLKPMIE PNDEKMGHMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private readonly List<Material> DMCBLHIPBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		protected JBBHGGKGMPI GGNNHCNDIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		protected Dictionary<string, int> KGFAEBBNPFO;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet BJLNLGDPJOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x82C2D70", Offset = "0x82C1370", VA = "0x1882C2D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool MLKJKKPIIAH
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xB47F20", Offset = "0xB46520", VA = "0x180B47F20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x272BD60", Offset = "0x272A360", VA = "0x18272BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool EKEFMCFAEBO
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool BIKPCELLBOK
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int BHJFGFCIGDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x82BFAD0", Offset = "0x82BE0D0", VA = "0x1882BFAD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer JBFJLKAOFKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IAFMNMIAAOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x27348B0", Offset = "0x2732EB0", VA = "0x1827348B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x272A680", Offset = "0x2728C80", VA = "0x18272A680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] CEFIJABJDGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool MBCKFIEAHOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x82C2DC0", Offset = "0x82C13C0", VA = "0x1882C2DC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x82C2F80", Offset = "0x82C1580", VA = "0x1882C2F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int NFBPGJNADKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x82BF2D0", Offset = "0x82BD8D0", VA = "0x1882BF2D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int GIANHOBPDDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x82BF7A0", Offset = "0x82BDDA0", VA = "0x1882BF7A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float KDLDNPACOJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x82C2DA0", Offset = "0x82C13A0", VA = "0x1882C2DA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x82C2F60", Offset = "0x82C1560", VA = "0x1882C2F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public OBKFCAOBFHI OBLFBDJMMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xB6DE00", Offset = "0xB6C400", VA = "0x180B6DE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xB69C80", Offset = "0xB68280", VA = "0x180B69C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public OGDJHLKPMIE PLKKJMBFBEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xBA8520", Offset = "0xBA6B20", VA = "0x180BA8520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x82C2EE0", Offset = "0x82C14E0", VA = "0x1882C2EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption PIFGGFPOAOA
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xB8AB80", Offset = "0xB89180", VA = "0x180B8AB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xC05D40", Offset = "0xC04340", VA = "0x180C05D40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected JBBHGGKGMPI IAOHOOCMDAH
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x82BC840", Offset = "0x82BAE40", VA = "0x1882BC840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action IICCHBCAKFM
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x82C2CC0", Offset = "0x82C12C0", VA = "0x1882C2CC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x82C2E30", Offset = "0x82C1430", VA = "0x1882C2E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x82BF800", Offset = "0x82BDE00", VA = "0x1882BF800")]
		public void LocalPlayEmote(BGGDANJGGNE.NFEMHKKOOOD GCGEBIHBMNE, float CODPKNIFPMA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x82BEEB0", Offset = "0x82BD4B0", VA = "0x1882BEEB0")]
		public bool IsEmotePlaying(BGGDANJGGNE.NFEMHKKOOOD GCGEBIHBMNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x82C0BE0", Offset = "0x82BF1E0", VA = "0x1882C0BE0")]
		public void SetIdleHappy(bool KCPOPBEEMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x82BD7E0", Offset = "0x82BBDE0", VA = "0x1882BD7E0")]
		protected void EMAMLHPNPAG(bool JFCKMGLJGDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x82BD860", Offset = "0x82BBE60", VA = "0x1882BD860")]
		protected void FBPMHKMOPEI(bool FACJDGAPCMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x82BD3E0", Offset = "0x82BB9E0", VA = "0x1882BD3E0")]
		protected void DFMFLODAFLL(CNFLLNFLBIO CGKEIIDMLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x82BFE10", Offset = "0x82BE410", VA = "0x1882BFE10")]
		protected void PAAJOADMDLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x82C02B0", Offset = "0x82BE8B0", VA = "0x1882C02B0")]
		public void PlayExpression(int NEADADHCFOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x82BDDA0", Offset = "0x82BC3A0", VA = "0x1882BDDA0")]
		protected void GKEENEMJGEI(bool KIJNMLBNFGN, bool HKDIPKCNION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x82BE040", Offset = "0x82BC640", VA = "0x1882BE040")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType NGACBOEIKEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x82BE980", Offset = "0x82BCF80", VA = "0x1882BE980")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration LOJIBPFKFPE, GAPGDDKJAHD JGCEJNPMHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x82C09B0", Offset = "0x82BEFB0", VA = "0x1882C09B0")]
		[AsyncStateMachine(typeof(JGHPJFKFOCK))]
		public Task SetFaceSettings(HKEIODNMLBG EBBCNNOGLPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x82C0880", Offset = "0x82BEE80", VA = "0x1882C0880")]
		[AsyncStateMachine(typeof(HEOKOEOGIAG))]
		public Task SetFaceSettings(int HOMLGMKKADL, int LOFJFPIHMCA, int LIGOCGBLMBA, int CDAIMGMMFDI, GAPGDDKJAHD JGCEJNPMHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x82C0C60", Offset = "0x82BF260", VA = "0x1882C0C60")]
		[AsyncStateMachine(typeof(JFDANBCOIKL))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType NGACBOEIKEB, int EKJLBPPBNEP, GAPGDDKJAHD JGCEJNPMHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x82BD260", Offset = "0x82BB860", VA = "0x1882BD260")]
		protected void COKOGGPNBAO(FaceFeatureType NGACBOEIKEB, GJDKJPBGNBN IHEKIFPCOBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x82BCB00", Offset = "0x82BB100", VA = "0x1882BCB00")]
		protected void CLFBPJLBPBL(FaceFeatureType NGACBOEIKEB, int EKJLBPPBNEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x82BDE60", Offset = "0x82BC460", VA = "0x1882BDE60")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x82BF6B0", Offset = "0x82BDCB0", VA = "0x1882BF6B0")]
		[AsyncStateMachine(typeof(PMKHGGOLIAI))]
		protected Task KGHCKHOHJCL(HKEIODNMLBG EBBCNNOGLPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x82BD9C0", Offset = "0x82BBFC0", VA = "0x1882BD9C0")]
		protected void FJHCIGJGNJJ(HKEIODNMLBG EBBCNNOGLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x82BFE80", Offset = "0x82BE480", VA = "0x1882BFE80")]
		protected static void PIHFNJNODHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x82C0020", Offset = "0x82BE620", VA = "0x1882C0020")]
		private void PKPFADPPJAI(bool DINLENIEIPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x82BD450", Offset = "0x82BBA50", VA = "0x1882BD450")]
		protected void EDKOALDKLLE(FaceFeatureType NGACBOEIKEB, Vector2 KEGGEPMEAPF, GAPGDDKJAHD JGCEJNPMHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x82C02D0", Offset = "0x82BE8D0", VA = "0x1882C02D0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType NGACBOEIKEB, Vector2 KFNGMMNEIAJ, GAPGDDKJAHD JGCEJNPMHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x82BEFD0", Offset = "0x82BD5D0", VA = "0x1882BEFD0")]
		protected void JILLFIOKCEP(FaceFeatureType NGACBOEIKEB, float LIPMNDGJIPO, GAPGDDKJAHD JGCEJNPMHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x82BF150", Offset = "0x82BD750", VA = "0x1882BF150")]
		protected void JLHHIOGDILI(FaceFeatureType NGACBOEIKEB, float NEOIPHFFLHF, GAPGDDKJAHD JGCEJNPMHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x82BF5E0", Offset = "0x82BDBE0", VA = "0x1882BF5E0")]
		protected void KDIPDIKPBIM(FaceFeatureType NGACBOEIKEB, float LKALHBEFAMA, GAPGDDKJAHD JGCEJNPMHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x82C0660", Offset = "0x82BEC60", VA = "0x1882C0660")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType NGACBOEIKEB, float JHBAMCDOAGL, GAPGDDKJAHD JGCEJNPMHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x82BDCC0", Offset = "0x82BC2C0", VA = "0x1882BDCC0")]
		[AsyncStateMachine(typeof(HMPBDIILMDJ))]
		protected Task GEOIDEOCOCD(GAPGDDKJAHD JGCEJNPMHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x82BECA0", Offset = "0x82BD2A0", VA = "0x1882BECA0")]
		public void InitializeFaceFeatureStyleSet(GAPGDDKJAHD JGCEJNPMHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x82BF900", Offset = "0x82BDF00", VA = "0x1882BF900")]
		protected bool MKAONHKKCBD(string GGCMODFFKHL, [Out] int LEPAEEGOBDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x82BC8C0", Offset = "0x82BAEC0", VA = "0x1882BC8C0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x82C0D70", Offset = "0x82BF370", VA = "0x1882C0D70", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x82BFC00", Offset = "0x82BE200", VA = "0x1882BFC00")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x82C1D70", Offset = "0x82C0370", VA = "0x1882C1D70")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x82BCA00", Offset = "0x82BB000", VA = "0x1882BCA00")]
		[AsyncStateMachine(typeof(CCAMIJBPFBL))]
		public Task BuildFaceStyleAsyncIfChanged(GAPGDDKJAHD JGCEJNPMHBE, bool PKJELNLDBFJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x82C1680", Offset = "0x82BFC80", VA = "0x1882C1680")]
		public void UpdateFaceDisplays(bool HLMIBFBPBNC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x82BE080", Offset = "0x82BC680", VA = "0x1882BE080")]
		protected bool HADHHHNHFNO(bool HLMIBFBPBNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x82C13E0", Offset = "0x82BF9E0", VA = "0x1882C13E0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x82C0AA0", Offset = "0x82BF0A0", VA = "0x1882C0AA0")]
		public void SetFaceSpriteIndices(string PODKNEOMEMC, string DMNIEBDHJML, string PPBAHCFBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x82C0D80", Offset = "0x82BF380", VA = "0x1882C0D80")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x82C18A0", Offset = "0x82BFEA0", VA = "0x1882C18A0")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x82C1A90", Offset = "0x82C0090", VA = "0x1882C1A90")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x82BF9E0", Offset = "0x82BDFE0", VA = "0x1882BF9E0")]
		protected void ONBDFKFPDNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x82BF330", Offset = "0x82BD930", VA = "0x1882BF330")]
		private void JLPIFKBHENO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x82BE7D0", Offset = "0x82BCDD0", VA = "0x1882BE7D0")]
		private void IKKLMCLEOHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x82C2A60", Offset = "0x82C1060", VA = "0x1882C2A60")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xAC1BD0", Offset = "0xAC01D0", VA = "0x180AC1BD0", Slot = "4")]
		private bool AOHMGIEGEBD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct HHPBCOIPKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public string CLGAHBNBCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public int AFPIOPNCMPM;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct AGLKCECEFCB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x82B3FF0", Offset = "0x82B25F0", VA = "0x1882B3FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct PFLGNCFNOKE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x82BBF20", Offset = "0x82BA520", VA = "0x1882BBF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x82BC410", Offset = "0x82BAA10", VA = "0x1882BC410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public GAPGDDKJAHD avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AEJMMPKIJPB useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public NKKOKKMIKCN hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public BBLFEOKPNJH HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public GameObject torsoModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public GameObject legsModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public GameObject validationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public bool showModestyAndValidationGuidelines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private OBNPPKBBOPE CJLABOKIEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private AnimatorOverrideController MMIDIJOOEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> JMNMEODMOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public readonly HHPBCOIPKHP[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public readonly (string, DMJJMIOILDN)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x249")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24A")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		protected bool IIKGJPNBKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		protected Guid NBGFJDADHPE;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		protected static Guid MEKKKJLEBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private BGCOFBKKHJK CAOAEMADBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private OBKFCAOBFHI JMKADBAJPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private PNBAICGDONK MOMNMJCKIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private PNBAICGDONK JKNBNOKBEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private AdditionalHatData DMGONBNCEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private readonly Dictionary<GameObject, DOBBNIFBALE> POKBNPLEMOB;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<DINOEKMOGPF> JNBMOIGCFCC
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x82C81E0", Offset = "0x82C67E0", VA = "0x1882C81E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x82C8820", Offset = "0x82C6E20", VA = "0x1882C8820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool MGIEOLNKCMP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x82C8340", Offset = "0x82C6940", VA = "0x1882C8340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool LLACPBBPIFG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x82C8230", Offset = "0x82C6830", VA = "0x1882C8230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase BINLPNDECNI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xC05B10", Offset = "0xC04110", VA = "0x180C05B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid PNDFAKAKGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x82C3B80", Offset = "0x82C2180", VA = "0x1882C3B80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, CNFLLNFLBIO)[] HPNKPJEAMID
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x82C8450", Offset = "0x82C6A50", VA = "0x1882C8450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x82C5EB0", Offset = "0x82C44B0", VA = "0x1882C5EB0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x82C36F0", Offset = "0x82C1CF0", VA = "0x1882C36F0")]
		private IEnumerable<GameObject> BECNCFHILJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x82C63D0", Offset = "0x82C49D0", VA = "0x1882C63D0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x82C4370", Offset = "0x82C2970", VA = "0x1882C4370")]
		private void DOOGMDNDLKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x154A4D0", Offset = "0x1548AD0", VA = "0x18154A4D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x82C4910", Offset = "0x82C2F10", VA = "0x1882C4910")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x82C63E0", Offset = "0x82C49E0", VA = "0x1882C63E0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x82C61F0", Offset = "0x82C47F0", VA = "0x1882C61F0")]
		public void ShowPose(AnimationClip EAMKMKADNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x82C63A0", Offset = "0x82C49A0", VA = "0x1882C63A0")]
		public void ShowPose(string GFKBHDOJBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x82C6020", Offset = "0x82C4620", VA = "0x1882C6020")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x82C5EC0", Offset = "0x82C44C0", VA = "0x1882C5EC0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x82C6EB0", Offset = "0x82C54B0", VA = "0x1882C6EB0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x82C6D00", Offset = "0x82C5300", VA = "0x1882C6D00")]
		public void UpdateFaceAndBodyShapes(bool PKJELNLDBFJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x82C72C0", Offset = "0x82C58C0", VA = "0x1882C72C0")]
		public void UpdateNoseShape(DNBLNCAFAFK OAJAMIMOOLF, bool PKJELNLDBFJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x82C7290", Offset = "0x82C5890", VA = "0x1882C7290")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x82C4530", Offset = "0x82C2B30", VA = "0x1882C4530", Slot = "4")]
		protected virtual void FINFAJJBLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x82C5710", Offset = "0x82C3D10", VA = "0x1882C5710", Slot = "5")]
		protected virtual void LPCAIJANFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x82C3320", Offset = "0x82C1920", VA = "0x1882C3320")]
		public void ApplyHatData(AdditionalHatData FLFBLLLNEMD, bool EOLDDNGKEKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x82C3160", Offset = "0x82C1760", VA = "0x1882C3160")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x82C3680", Offset = "0x82C1C80", VA = "0x1882C3680")]
		public void ApplyHatUVOverride(Vector2 NNCEGFBGPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x82C35A0", Offset = "0x82C1BA0", VA = "0x1882C35A0")]
		public void ApplyHatPositionAdjustment(Vector3 APAKBJFLPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x82C3610", Offset = "0x82C1C10", VA = "0x1882C3610")]
		public void ApplyHatRotationAdjustment(Vector3 ECENADNOIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x82C3C70", Offset = "0x82C2270", VA = "0x1882C3C70")]
		public JAEIIDNBJMP BuildAvatarItemSelection(GameObject MKPMEGNEIEO, GAPGDDKJAHD JPMNEABEAJJ, CNFLLNFLBIO ODAFEHBHNNA)
		{
			return default(JAEIIDNBJMP);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x82C3D10", Offset = "0x82C2310", VA = "0x1882C3D10")]
		public void BuildAvatar(bool PKJELNLDBFJ = false, bool EOLDDNGKEKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x82C6740", Offset = "0x82C4D40", VA = "0x1882C6740")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x82C32A0", Offset = "0x82C18A0", VA = "0x1882C32A0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x82C70E0", Offset = "0x82C56E0", VA = "0x1882C70E0")]
		public void UpdateHatAnchor(bool EOLDDNGKEKC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x82C6E00", Offset = "0x82C5400", VA = "0x1882C6E00")]
		[AsyncStateMachine(typeof(AGLKCECEFCB))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x82C4840", Offset = "0x82C2E40", VA = "0x1882C4840")]
		[AsyncStateMachine(typeof(PFLGNCFNOKE))]
		private Task GDMGCGPNIIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x82C5010", Offset = "0x82C3610", VA = "0x1882C5010")]
		private void JKACIDFBONB(FaceFeatureType HFINMKMAMGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x82C30D0", Offset = "0x82C16D0", VA = "0x1882C30D0")]
		private void AJGNJKGGOFF(FaceFeatureType HFINMKMAMGN, [Out] float AGPHIFHMJIG, [Out] float ICDGJHKJGDB, [Out] float ILFCOODFNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x82C6BC0", Offset = "0x82C51C0", VA = "0x1882C6BC0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x82C6F40", Offset = "0x82C5540", VA = "0x1882C6F40")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x82C5980", Offset = "0x82C3F80", VA = "0x1882C5980")]
		private void NEKNJAPHNBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		private void HHHEOOLLHCG(DOBBNIFBALE MFIKOFMJJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		private void GBHAFLIJMDD(DOBBNIFBALE MFIKOFMJJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x82C5390", Offset = "0x82C3990", VA = "0x1882C5390")]
		private void LGNCGIGPPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x82C7350", Offset = "0x82C5950", VA = "0x1882C7350")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x82C52E0", Offset = "0x82C38E0", VA = "0x1882C52E0")]
		[CompilerGenerated]
		private JAEIIDNBJMP LGCGGMAJFOE((GameObject, CNFLLNFLBIO) PKGDNHCKFCJ)
		{
			return default(JAEIIDNBJMP);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct JAEIIDNBJMP
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class MEFMMPBEENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MEFMMPBEENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x82B8360", Offset = "0x82B6960", VA = "0x1882B8360")]
		internal bool GOINHHLGNNP(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private DOBBNIFBALE AAAKGKBCJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private CNFLLNFLBIO KPGCBANLIJH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public DOBBNIFBALE LBBDIIDGKCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CNFLLNFLBIO KOLJEAGHCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xEB2940", Offset = "0xEB0F40", VA = "0x180EB2940")]
		get
		{
			return default(CNFLLNFLBIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string KJMDBDOADCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x82B6460", Offset = "0x82B4A60", VA = "0x1882B6460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool HHIJMLDLALN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x82B6620", Offset = "0x82B4C20", VA = "0x1882B6620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool BAOJJBHFLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x82B68E0", Offset = "0x82B4EE0", VA = "0x1882B68E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1AB9730", Offset = "0x1AB7D30", VA = "0x181AB9730")]
	public JAEIIDNBJMP(DOBBNIFBALE MFIKOFMJJDD, CNFLLNFLBIO CGKEIIDMLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x82B6550", Offset = "0x82B4B50", VA = "0x1882B6550")]
	public bool KKGCHJMDPIK(OutfitType GOJAIBDHJMC, CNFLLNFLBIO FDBDNHIIICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x82B6670", Offset = "0x82B4C70", VA = "0x1882B6670")]
	public bool NMIIJJIKMEA(OutfitType GOJAIBDHJMC, CNFLLNFLBIO FDBDNHIIICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x82B6270", Offset = "0x82B4870", VA = "0x1882B6270")]
	public bool BOCNKNCOHJJ(JAEIIDNBJMP EJJKEIEGGFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class LODGIDGABPI
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class LIHAMHPANIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LIHAMHPANIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x82B8140", Offset = "0x82B6740", VA = "0x1882B8140")]
		internal bool GOINHHLGNNP(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private DOBBNIFBALE AAAKGKBCJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private FJIDOAJCOFJ KPGCBANLIJH;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public DOBBNIFBALE LBBDIIDGKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public FJIDOAJCOFJ KOLJEAGHCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60")]
		get
		{
			return default(FJIDOAJCOFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Color JIIKHGGPGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xE87FD0", Offset = "0xE865D0", VA = "0x180E87FD0")]
		[CompilerGenerated]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE87E50", Offset = "0xE86450", VA = "0x180E87E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 NEMGOCEHIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xE9FD70", Offset = "0xE9E370", VA = "0x180E9FD70")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xE9FEB0", Offset = "0xE9E4B0", VA = "0x180E9FEB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x82B82F0", Offset = "0x82B68F0", VA = "0x1882B82F0")]
	public LODGIDGABPI(DOBBNIFBALE MFIKOFMJJDD, FJIDOAJCOFJ CGKEIIDMLBB, Color ONDGBPEOGJF, Vector3 NEOIPHFFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x82B81C0", Offset = "0x82B67C0", VA = "0x1882B81C0")]
	public bool BOCNKNCOHJJ(LODGIDGABPI EJJKEIEGGFD)
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
