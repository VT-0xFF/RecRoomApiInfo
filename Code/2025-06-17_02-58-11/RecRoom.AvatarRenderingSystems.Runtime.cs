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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B89100", Offset = "0x7B87B00", VA = "0x187B89100", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7B899C0", Offset = "0x7B883C0", VA = "0x187B899C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B89950", Offset = "0x7B88350", VA = "0x187B89950", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B89980", Offset = "0x7B88380", VA = "0x187B89980")]
		public RecNetCDNAssetReference(RecNetCDNKey KJNEHANBOBO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum NPJKPKBKNCC : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA38610", Offset = "0xA37010", VA = "0x180A38610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36D90", VA = "0x180A38390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NPJKPKBKNCC PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xE3C520", Offset = "0xE3AF20", VA = "0x180E3C520")]
			[CompilerGenerated]
			get
			{
				return default(NPJKPKBKNCC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1442EE0", Offset = "0x14418E0", VA = "0x181442EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7B89AD0", Offset = "0x7B884D0", VA = "0x187B89AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B89A00", Offset = "0x7B88400", VA = "0x187B89A00")]
		public static RecNetCDNKey HGMDOFOPCFP(string KBBELAIKEJC, NPJKPKBKNCC AONMCIPLHPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B89A80", Offset = "0x7B88480", VA = "0x187B89A80")]
		public void KDBIMDOJIMM(string DOADIGGJHCK, string IHCNKMENBKK, bool DEHDAFLPKDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHPBPJDIEFG]
public class CLOHKNGAFKG : JFHJMHADBJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> DNBJGMFONDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> HADMHFGODHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> ODGEHBCJHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> NCBHKIOHAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> OAIMDBKCPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> IPCBLLAMIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> JFKLEPPLCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator IAKODOHCFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected DNNCNPOKLAI MACPPIPPNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte NCNKJIEBJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> EELBMLNJPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> KNMLKBFFIGO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B77CE0", Offset = "0x7B766E0", VA = "0x187B77CE0", Slot = "4")]
	public void OEFFKJCLJOO(Mesh DLOFNMELGLP, Matrix4x4 CBPOFKNKLDF, byte[] FKNFEDOECAJ, bool MIDPIGILHEL = false, PNNNJKDMBBI.KEKJLMIKOAG IKNMPPOGLDF = (PNNNJKDMBBI.KEKJLMIKOAG)0L, int NDBGCPPBAKM = -1, bool OKCFMHEBLGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B77A40", Offset = "0x7B76440", VA = "0x187B77A40", Slot = "5")]
	public void NDFNGKDGNEG(Allocator NDKMELBEFLH, DNNCNPOKLAI CFMMKCBMKLL, byte JMDKOOCJJFM, [Optional] IList<int> LJGCICFOFOI, [Optional] IList<int> PGMDGFKFCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B77A80", Offset = "0x7B76480", VA = "0x187B77A80")]
	private static void NNECEDONGPN(Mesh DLOFNMELGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B780A0", Offset = "0x7B76AA0", VA = "0x187B780A0")]
	public CLOHKNGAFKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NHPBPJDIEFG]
public struct DDIBIBFFMDD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public EEKFHGCOCEF OJHHMPNFCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int KCFEBCNDOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public BFKBGLAGKED AAOCLNNFPLP;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B782F0", Offset = "0x7B76CF0", VA = "0x187B782F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NHPBPJDIEFG]
[NativeContainer]
public struct BFKBGLAGKED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct PADFMOBGBLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 EBFFJKEDCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 ODJALHAEEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 EEAGDBFPFCE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct KAGKLCEBCAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float LGNPJEENBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float OPPAHPHGGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float IBLBNFDONML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float NAAKPECLIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte KEAOEFMHGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte OEOEPMLHGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte BLMOBEJEKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte AOHCFKLHDEE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MEILCGCEBHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half LGNPJEENBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half OPPAHPHGGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half IBLBNFDONML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half NAAKPECLIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte KEAOEFMHGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte OEOEPMLHGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte BLMOBEJEKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte AOHCFKLHDEE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct CCHGMFNEAFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 JJNDBAIEAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 ICNAMLAIBPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NJHLLMPPBAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 JJNDBAIEAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 ICNAMLAIBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 DNNCCKDHBIO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AOMNFPMACDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 JJNDBAIEAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 ICNAMLAIBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 DNNCCKDHBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 GCKEAMJAHAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct HIJKIADFJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 JJNDBAIEAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 ICNAMLAIBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 DNNCCKDHBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 GCKEAMJAHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 MKPOPCKBHBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct MEFCOGAINIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float LGNPJEENBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float OPPAHPHGGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float IBLBNFDONML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float NAAKPECLIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int KEAOEFMHGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int OEOEPMLHGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int BLMOBEJEKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int AOHCFKLHDEE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct HECOBEIPFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color JJNDBAIEAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 ICNAMLAIBPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct JJCLLBEEIHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color JJNDBAIEAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 ICNAMLAIBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 DNNCCKDHBIO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct LECEPFPKDHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color JJNDBAIEAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 ICNAMLAIBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 DNNCCKDHBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 GCKEAMJAHAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct PBNIMNMEEJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color JJNDBAIEAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 ICNAMLAIBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 DNNCCKDHBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 GCKEAMJAHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 MKPOPCKBHBO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool KODBDGKEMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<PADFMOBGBLF> DNEOPLGMGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<CCHGMFNEAFA> AGHKOFAPGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<NJHLLMPPBAK> BKFLHFLOBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<AOMNFPMACDJ> NLPHBDENPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<HIJKIADFJLD> GNEKMCOJBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<MEILCGCEBHA> DGLMCIBCLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<KAGKLCEBCAI> NDJLLFAOPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<HECOBEIPFNM> MBKIDENKEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<JJCLLBEEIHG> DIDCEHKMLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<LECEPFPKDHH> CFMIKFHPDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<PBNIMNMEEJG> EBCEAKPENHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<MEFCOGAINIP> DOONGPALIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> AELEHHIKHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> HDBDFNLCECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> BEAOEHNKCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> BGGELHPOCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> BNNGFDNCCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> IAMJKFICAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> GHIEJOEPMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> BPAJOOPNEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> JKGCHKOAIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool LHAPKPNJNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool ALGNNAPDEJK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JNKKHDBOEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B75950", Offset = "0x7B74350", VA = "0x187B75950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B75250", Offset = "0x7B73C50", VA = "0x187B75250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OFBBMDMFBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B75A40", Offset = "0x7B74440", VA = "0x187B75A40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B76CD0", Offset = "0x7B756D0", VA = "0x187B76CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MDIDGNILNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B75A30", Offset = "0x7B74430", VA = "0x187B75A30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B75940", Offset = "0x7B74340", VA = "0x187B75940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EEHMAHHPICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B758D0", Offset = "0x7B742D0", VA = "0x187B758D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B77010", Offset = "0x7B75A10", VA = "0x187B77010")]
	public BFKBGLAGKED(int NIDOHGNBKLE, int FDBJFAEIHDB, int CCFJECOKPFF, int OIBFOGENFCL, Allocator NDKMELBEFLH, int OBIAHACFPNH, IAIACBBALCG PGMJHJODGBC, bool LHAPKPNJNDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B751C0", Offset = "0x7B73BC0", VA = "0x187B751C0")]
	public void DECJOGDIPPP(int MNFHMLCLFEB, Vector3 GEHEADBMGDC, Vector3 COCHOILMLGE, Vector4 ANAFNAJGANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7B74D80", Offset = "0x7B73780", VA = "0x187B74D80")]
	public void CFKNMPLHINL(int MNFHMLCLFEB, BoneWeight PLFLKKMHKLA, NativeSlice<byte> FKNFEDOECAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B76CE0", Offset = "0x7B756E0", VA = "0x187B76CE0")]
	public Color PFEKBLBKPMI(int MNFHMLCLFEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B768D0", Offset = "0x7B752D0", VA = "0x187B768D0")]
	public void OBCGCFMJKNG(int MNFHMLCLFEB, Color CIBCGCDEGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B75520", Offset = "0x7B73F20", VA = "0x187B75520")]
	public void GDGKBKAIJDJ(byte ONMJHGHEAPJ, int MNFHMLCLFEB, Vector2 CPBHKIEKBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B751B0", Offset = "0x7B73BB0", VA = "0x187B751B0")]
	public void DEBILPLBJDE(int MNFHMLCLFEB, int LAFKDIKAKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B754C0", Offset = "0x7B73EC0", VA = "0x187B754C0")]
	public bool GCIJMPFEDGP(int ONMJHGHEAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B75960", Offset = "0x7B74360", VA = "0x187B75960")]
	public void HDHAAEDEHJM(int PPPKEKEOOCO, int BACDJHJBLPL, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B75260", Offset = "0x7B73C60", VA = "0x187B75260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B75A50", Offset = "0x7B74450", VA = "0x187B75A50")]
	public Mesh NPFFEOJEJBB([Optional] string LICBELADCFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[NHPBPJDIEFG]
public struct EEKFHGCOCEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray HGGGCJKCHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> NGLPKGDGPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> FFPHDGPABDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> BPAJOOPNEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> BPNCBKKKIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> PAKDMIPAEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> JMCFDLJKGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> AALOMCFIGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> DJHEFMMMJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> FHJJEDODIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> BBHLIDICJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> OKCFMHEBLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> NDBGCPPBAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool LHAPKPNJNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> GMEKKELHGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool ALGNNAPDEJK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AMLIDOGOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A2D0", Offset = "0x7B78CD0", VA = "0x187B7A2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int JGLMMLDFDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A5C0", Offset = "0x7B78FC0", VA = "0x187B7A5C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CCBEPJFGIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A5D0", Offset = "0x7B78FD0", VA = "0x187B7A5D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AEACADPDEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A5B0", Offset = "0x7B78FB0", VA = "0x187B7A5B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A4A0", Offset = "0x7B78EA0", VA = "0x187B7A4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JNKKHDBOEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A4B0", Offset = "0x7B78EB0", VA = "0x187B7A4B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A300", Offset = "0x7B78D00", VA = "0x187B7A300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int GOAIKMPEEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A2E0", Offset = "0x7B78CE0", VA = "0x187B7A2E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A6A0", Offset = "0x7B790A0", VA = "0x187B7A6A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DNNCNPOKLAI EHBACBLDBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A5A0", Offset = "0x7B78FA0", VA = "0x187B7A5A0")]
		get
		{
			return default(DNNCNPOKLAI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A4C0", Offset = "0x7B78EC0", VA = "0x187B7A4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte FMLKBCNMKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A2F0", Offset = "0x7B78CF0", VA = "0x187B7A2F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A490", Offset = "0x7B78E90", VA = "0x187B7A490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public PCMMJGLELGK OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A080", Offset = "0x7B78A80", VA = "0x187B7A080")]
		get
		{
			return default(PCMMJGLELGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A6B0", Offset = "0x7B790B0", VA = "0x187B7A6B0")]
	public EEKFHGCOCEF(IList<Mesh> IAHKFOONMHD, IList<Matrix4x4> DJHCNFABKGC, IList<bool> OKCFMHEBLGA, byte JMDKOOCJJFM, IList<byte[]> ALBLECHENAP, IList<long> HCAPGIIIMGB, IList<bool> CGJAIOIKPMP, IList<int> NDBGCPPBAKM, IList<int> LJGCICFOFOI, IList<int> HGMFIDHIBMO, Allocator NDKMELBEFLH, DNNCNPOKLAI CFMMKCBMKLL, bool LHAPKPNJNDM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A4D0", Offset = "0x7B78ED0", VA = "0x187B7A4D0")]
	public BFKBGLAGKED INMLDLAHGAM(Allocator NDKMELBEFLH, IAIACBBALCG PGMJHJODGBC)
	{
		return default(BFKBGLAGKED);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A310", Offset = "0x7B78D10", VA = "0x187B7A310", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NHPBPJDIEFG]
public class NCFLNGBKEAE : CLOHKNGAFKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool CJDEOOKIDHG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker PNPLIANDJOC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7B89190", Offset = "0x7B87B90", VA = "0x187B89190")]
	public EEKFHGCOCEF LBGHFNOOAIB()
	{
		return default(EEKFHGCOCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B89490", Offset = "0x7B87E90", VA = "0x187B89490")]
	public NCFLNGBKEAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PCMMJGLELGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData IOODMFNIMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> BPAJOOPNEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> BIPDDBCLPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int HAODJCOCAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 HFJGJIHAMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long APLMPPCOIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> FKNFEDOECAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool IAFPCBBHCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int LCPFJMLOAGE;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IEMPAIAEGKL : LPODLLODNDM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KKBNLAKFOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public IEMPAIAEGKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LIJLGGILNGM buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action<KeyValuePair<string, ODDHNIEMFCD<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KKBNLAKFOFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B89000", Offset = "0x7B87A00", VA = "0x187B89000")]
		internal bool LJNJFBHFPKK(KJOKLAANNCB item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7B88F80", Offset = "0x7B87980", VA = "0x187B88F80")]
		internal void EGFONBNGLCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B88F60", Offset = "0x7B87960", VA = "0x187B88F60")]
		internal void DILAMMNGPEG(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B88F80", Offset = "0x7B87980", VA = "0x187B88F80")]
		internal void MLODJLGLIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B88F60", Offset = "0x7B87960", VA = "0x187B88F60")]
		internal void NNALKCLMPOD(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B88FD0", Offset = "0x7B879D0", VA = "0x187B88FD0")]
		internal void EPJKBGBOAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B88FA0", Offset = "0x7B879A0", VA = "0x187B88FA0")]
		internal void EGMKGDABJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B88EA0", Offset = "0x7B878A0", VA = "0x187B88EA0")]
		internal void AHPKMBJIBEO(Dictionary<string, ODDHNIEMFCD<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B89040", Offset = "0x7B87A40", VA = "0x187B89040")]
		internal void PEIBINPHPDC(KeyValuePair<string, ODDHNIEMFCD<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		internal FDBBAHKKNBB DJOBELLOKCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OOBBGOLJMCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public KKBNLAKFOFH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OOBBGOLJMCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B89890", Offset = "0x7B88290", VA = "0x187B89890")]
		internal GPEDBMKBACG COANEGPHIID(int lod)
		{
			return default(GPEDBMKBACG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CGAEPNHNDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public MPBOGDMHBIL<Dictionary<string, ODDHNIEMFCD<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public CGAEPNHNDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		internal MPBOGDMHBIL<Dictionary<string, ODDHNIEMFCD<Texture2D>>> JKAEKJODLMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ODDFLMPPGJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<LIJLGGILNGM> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public ODDFLMPPGJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B89760", Offset = "0x7B88160", VA = "0x187B89760")]
		internal void HNAFGMEKFEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ECOBCAPFIJP : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public IEMPAIAEGKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<NMJOLFALJAH> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<LIJLGGILNGM> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Func<int, GPEDBMKBACG> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public BHMFMGIOGCC materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public ECOBCAPFIJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B79DB0", Offset = "0x7B787B0", VA = "0x187B79DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A030", Offset = "0x7B78A30", VA = "0x187B7A030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KLHEKKPGHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public LKDGEJDIBFP cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KLHEKKPGHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xB17480", Offset = "0xB15E80", VA = "0x180B17480")]
		internal void HJKEAAFPPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xD85130", Offset = "0xD83B30", VA = "0x180D85130")]
		internal void MHMODDANAPK(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MIGDPMEFJNJ
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
		public IEMPAIAEGKL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MIGDPMEFJNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NGHHBHJLCNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public BFKBGLAGKED defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public EEKFHGCOCEF defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public MIGDPMEFJNJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NGHHBHJLCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B894A0", Offset = "0x7B87EA0", VA = "0x187B894A0")]
		internal void PKOHHBDEHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x13A6A30", Offset = "0x13A5430", VA = "0x1813A6A30")]
		internal void AABBGGNOPEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HGJBDDJHJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public LBKEJBFHFFF legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public IECACCEEPCH legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public MIGDPMEFJNJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HGJBDDJHJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B7B870", Offset = "0x7B7A270", VA = "0x187B7B870")]
		internal void JABHECDINDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x13A5100", Offset = "0x13A3B00", VA = "0x1813A5100")]
		internal void KBDKELOBPAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HIDAEDMJLDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public IEMPAIAEGKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HIDAEDMJLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B7BAB0", Offset = "0x7B7A4B0", VA = "0x187B7BAB0")]
		internal void MOGBAOMJHPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OBLLOPAPKCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public MFEGJNCJJMB overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OBLLOPAPKCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B896E0", Offset = "0x7B880E0", VA = "0x187B896E0")]
		internal bool NMPLAKBKHKK(KeyValuePair<string, KJOKLAANNCB> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly CNBOOGKDGFE OAJMNIDJENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CNBOOGKDGFE LKBDJKMEFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<LBHHPCALKIB, float> KBBKGNILGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<NKGKAKKIKNK, float> DJDAFKCOBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<DDEGJILJGIO, float> AKPAIOIJIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, CADHONJDOID> ADJPANMJILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, CADHONJDOID> GPLCFKEACPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, CADHONJDOID> HKEMIKLJNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, CADHONJDOID> DKIJGGCBKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private DNOLOOAELOA DHLDBPNMGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private DNOLOOAELOA MIKPKOMCIPP;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float DJGOGOAAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? APCDGIOHMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? GIMPOIFIAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? KCIIJOIDPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? OBPBBHAIDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration BBKMEDJDKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform FMKNEMLCIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem CBKAIMKGPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference KJIEIAACFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject DDJPCEDLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject KNLHMPMOCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer JHLKBBLKBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData MBODKKAKPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] BOCONPNDIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] OJMPEJAMKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material MGBNNDLFCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material CEOIPPGPKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material CPJDJNFKBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material DMHBLFPJNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader OJFKIGFMMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Shader NHBLDEMACLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator INMHPFILHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Renderer[] PDCLGMGHMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private PNNNJKDMBBI.KEKJLMIKOAG DCFLKKGOMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyPartShapesManager BDLIFCHKKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IReadOnlyDictionary<string, Transform> BLIIOFINICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarFaceShapeData.JECENMBCIMC HKNHELMBHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private AvatarBodyShapeData.LLMJAELKBJH EILCHFCKMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private IHBNBAEKKJN BGBIMDOOKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool HDOJOEKIEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool DOGNHHOHAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color PIKIEMDDKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color IONNIJHBNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color NJCCJGPGPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? LKHOPBENJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? KJIFFCBKKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? PKBLJLGLGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Color? EHHGDLGMFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D PKLNAEHKEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Texture2D MGOAPBJLPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[CanBeNull]
	private KJOKLAANNCB CHOOMEOAHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Texture KONAAFFDGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color PCCIAPIMAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Dictionary<Renderer, BHMFMGIOGCC> DOJIHNGIDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<Renderer, BHMFMGIOGCC> IDINLDFMKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<BIHJMGLIGML>> PDMCEGPJFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<string, List<BIHJMGLIGML>> LJBHEPBBJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<MCFGKKFEMKA> HPPCMNBIJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<MCFGKKFEMKA> LADMMACPPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<MCFGKKFEMKA> FCBNLKAEPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<MCFGKKFEMKA> KFHANAOAOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<BIHJMGLIGML, Material> EBEMPNALELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<BIHJMGLIGML, Material> IOIGINCNHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] IOKMJGPPMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] IIAKCNNAHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] IKALFPPGCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private SkinnedMeshRenderer[] AMJDCMEHIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, ODDHNIEMFCD<Texture2D>> EPBCEDDHBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Dictionary<string, ODDHNIEMFCD<Texture2D>> DEKHJEKONDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData MEMJLGONPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AdditionalHatData KCDICIMJNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData ANHOMDGABJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HairData FNEFPBIEBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private EBGNPCDLBGE FPNBKEFAPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool? GJHCALJBBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private PositionAndRotation JPBCHNIIEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Transform MJFAJEBDIEP;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material HNFELKGPECC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Material MPEFGKHGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<string, KJOKLAANNCB> GJKKBCBFHBJ;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int PDDPLKACNNP;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int NGNLALFHKKF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int MJICLEPAJIH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int NBDMNOIFDJE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int NGJLBOGOFBH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int HJHBCELDGNI;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int OPLGBBGBGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool PMPJDFBCJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> KBKKOPEMBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private BBNCMLFOPPH AJCEFMKMHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private SkinnedMeshRenderer[] BDBKBCANKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int HKOHPPGBNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool IANJINKEPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int ELMJJCJDIBP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CNBOOGKDGFE KAHHHJOCIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CNBOOGKDGFE DFGEJEGPOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private JJPMOJNHOLC CCEMKGCMKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B87870", Offset = "0x7B86270", VA = "0x187B87870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool MILFCJBMLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B7D900", Offset = "0x7B7C300", VA = "0x187B7D900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool HDKJDJDHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B872B0", Offset = "0x7B85CB0", VA = "0x187B872B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool PKPMBGDHILE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7B83BE0", Offset = "0x7B825E0", VA = "0x187B83BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool MOIFKMNEMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7B83000", Offset = "0x7B81A00", VA = "0x187B83000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration LNJLLPAJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PKCNPKDDDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7DA70", Offset = "0x7B7C470", VA = "0x187B7DA70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B7D050", Offset = "0x7B7BA50", VA = "0x187B7D050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material JOFGJEGECFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7B80150", Offset = "0x7B7EB50", VA = "0x187B80150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material KMBPHLCEENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7B87970", Offset = "0x7B86370", VA = "0x187B87970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool HMFOCDBNNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DOOHILAACHK FCKFJDMMJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x23DCE80", Offset = "0x23DB880", VA = "0x1823DCE80", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(DOOHILAACHK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7B7FCE0", Offset = "0x7B7E6E0", VA = "0x187B7FCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material JKEFOFOFEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA86FD0", Offset = "0xA859D0", VA = "0x180A86FD0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] GFJIFCPEBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1A460B0", Offset = "0x1A44AB0", VA = "0x181A460B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] ECJCIFPFFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA7A580", Offset = "0xA78F80", VA = "0x180A7A580", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KOCHGLLHDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B7BDD0", Offset = "0x7B7A7D0", VA = "0x187B7BDD0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public PNNNJKDMBBI.KEKJLMIKOAG CLHCKGIEHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA7F280", Offset = "0xA7DC80", VA = "0x180A7F280", Slot = "20")]
		get
		{
			return default(PNNNJKDMBBI.KEKJLMIKOAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PMNEGONJGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x27253F0", Offset = "0x2723DF0", VA = "0x1827253F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7B83400", Offset = "0x7B81E00", VA = "0x187B83400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool BOGBPLOOAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B82560", Offset = "0x7B80F60", VA = "0x187B82560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool KJJPPOEPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7B81930", Offset = "0x7B80330", VA = "0x187B81930", Slot = "15")]
	public LIJLGGILNGM FJIHPLKECNM(NCIDAGHDIGG EPJMIFCCLKB, bool OJGLHJECAGF, int[] PGOFKMBLHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7B7DDF0", Offset = "0x7B7C7F0", VA = "0x187B7DDF0", Slot = "14")]
	public LIJLGGILNGM DBMDOEBCKPK(NCIDAGHDIGG EPJMIFCCLKB, bool OJGLHJECAGF, int[] PGOFKMBLHNK, Func<Dictionary<string, KJOKLAANNCB>, (LIJLGGILNGM, MPBOGDMHBIL<Dictionary<string, ODDHNIEMFCD<Texture2D>>>)> KLHPOKMFANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B7E120", Offset = "0x7B7CB20", VA = "0x187B7E120")]
	public LIJLGGILNGM DGICEIMGMIE(NCIDAGHDIGG EPJMIFCCLKB, bool OJGLHJECAGF, int[] PGOFKMBLHNK, bool AFDKDAAOCGM, DNOLOOAELOA MNGNCDHIOBG, [Optional] Func<Dictionary<string, KJOKLAANNCB>, (LIJLGGILNGM, MPBOGDMHBIL<Dictionary<string, ODDHNIEMFCD<Texture2D>>>)> KLHPOKMFANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B82390", Offset = "0x7B80D90", VA = "0x187B82390")]
	private bool GKPBKGANEAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C2C0", Offset = "0x7B7ACC0", VA = "0x187B7C2C0")]
	private LIJLGGILNGM BCNGOEAMJGJ(bool OJGLHJECAGF, List<NMJOLFALJAH> DNKMBADMPDE, int[] PGOFKMBLHNK, Func<int, GPEDBMKBACG> IMLLJHGNENM, bool AFDKDAAOCGM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B81510", Offset = "0x7B7FF10", VA = "0x187B81510")]
	[IteratorStateMachine(typeof(ECOBCAPFIJP))]
	private IEnumerator<HGOIDBIKHMF> EKCNJAAOJHH(bool OJGLHJECAGF, List<NMJOLFALJAH> DNKMBADMPDE, int[] PGOFKMBLHNK, Func<int, GPEDBMKBACG> IMLLJHGNENM, BHMFMGIOGCC OCKKPAOFAOG, Material OMADNODHBAD, List<LIJLGGILNGM> LLNFKKGDKEE, bool IMLPDGIALBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B86C20", Offset = "0x7B85620", VA = "0x187B86C20")]
	private void MNCINPFONCC(List<NMJOLFALJAH> DNKMBADMPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B81DE0", Offset = "0x7B807E0", VA = "0x187B81DE0")]
	private LIJLGGILNGM GCCMENBNOJK(List<NMJOLFALJAH> DNKMBADMPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B844A0", Offset = "0x7B82EA0", VA = "0x187B844A0")]
	private IDJIHHOMEIC KEMNDMOPAJP(List<NMJOLFALJAH> DNKMBADMPDE, int GIFLHFGNGDL, bool OJGLHJECAGF, GPEDBMKBACG OLNBDAKOELL, bool KJDDMPGHDKF, BHMFMGIOGCC OCKKPAOFAOG, Material OMADNODHBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FF00", Offset = "0x7B7E900", VA = "0x187B7FF00", Slot = "27")]
	public void DPAHCMNHIED(LBHHPCALKIB MEGIFAHPIOO, float PCDAHJCDHHF, bool EPMPFCFEOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D820", Offset = "0x7B7C220", VA = "0x187B7D820", Slot = "29")]
	public void CIPPMCKMPID(NKGKAKKIKNK EKAFLDGJIMD, float PCDAHJCDHHF, bool DMDDJEDEJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7B82200", Offset = "0x7B80C00", VA = "0x187B82200", Slot = "30")]
	public void GJGBABNIBBA(DDEGJILJGIO FNBIOFOOBCD, float PCDAHJCDHHF, bool MAOEMDPCMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B87E70", Offset = "0x7B86870", VA = "0x187B87E70", Slot = "28")]
	public void PBNLCAGJEKC(bool HHHPKFFKMHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7B87250", Offset = "0x7B85C50", VA = "0x187B87250", Slot = "31")]
	public void NKLNPKPJBKO(bool HHHPKFFKMHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D9E0", Offset = "0x7B7C3E0", VA = "0x187B7D9E0", Slot = "32")]
	public void CMNNAOMHHIK(bool HHHPKFFKMHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B82030", Offset = "0x7B80A30", VA = "0x187B82030")]
	private void GDCIPHMBAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7B7DEE0", Offset = "0x7B7C8E0", VA = "0x187B7DEE0")]
	private void DFCAJJJFKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7B83A80", Offset = "0x7B82480", VA = "0x187B83A80")]
	private void JICNOCFIPNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B83FC0", Offset = "0x7B829C0", VA = "0x187B83FC0", Slot = "25")]
	public void KDJOHNAJBMH(AvatarFaceShape PPGKHPIGOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B882E0", Offset = "0x7B86CE0", VA = "0x187B882E0", Slot = "26")]
	public void PNMKLIOGGJH(AvatarBodyShape AHGGMDFNGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xB400B0", Offset = "0xB3EAB0", VA = "0x180B400B0", Slot = "33")]
	public void GCKJCFNINIE(IHBNBAEKKJN EDFNBFFGBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B82740", Offset = "0x7B81140", VA = "0x187B82740", Slot = "35")]
	public void HGEBJPEHNPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B820B0", Offset = "0x7B80AB0", VA = "0x187B820B0", Slot = "39")]
	public void GIKCFLLFEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D810", Offset = "0x7B7C210", VA = "0x187B7D810", Slot = "34")]
	public void CIIEAPNINJD(bool FGPHJJGNGKJ, bool FBMPCEJMLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B81960", Offset = "0x7B80360", VA = "0x187B81960")]
	private void FKHLGEKMGDK(SkinnedMeshRenderer NIKKPOANHLP, int GIFLHFGNGDL, Mesh DLOFNMELGLP, List<Material> IHGNFKMJJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B825E0", Offset = "0x7B80FE0", VA = "0x187B825E0")]
	private static Material HCHHGIOBKDN(Dictionary<BIHJMGLIGML, Material> KILDONHPMFN, Material BOINKEIDMGM, INENJPIGNGG FMOGBAPBKIE, MIPECIFKJHH BIEOJBHHNOM, MFEGJNCJJMB ODFAALAAHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B832F0", Offset = "0x7B81CF0", VA = "0x187B832F0")]
	private static INENJPIGNGG IEJCNFFCAAF(NMJOLFALJAH FCNNCHKGIAA, int BBPCOAOGCBJ)
	{
		return default(INENJPIGNGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B87A60", Offset = "0x7B86460", VA = "0x187B87A60")]
	private void OPHHJBPJGGP(int GHJBHDJCOIO, Material NJABANIHMHL, NMJOLFALJAH FCNNCHKGIAA, [Out] Texture2D AJOHMGHJCEO, [Out] Vector4 PMGNEAOCOKL, [Out] Texture2D CEJJMJODCNK, [Out] Texture2D CFCBPKFPNLA, [Out] Texture2D DDKMAIGGELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D350", Offset = "0x7B7BD50", VA = "0x187B7D350")]
	private void CHJJOBDGLAI(int GHJBHDJCOIO, Material NJABANIHMHL, NMJOLFALJAH FCNNCHKGIAA, [Out] Color PPNFPJDAMPK, [Out] Color HGMKCKGKKCJ, [Out] Color OOKCKJBPJLM, [Out] Color AOICBHAHJEN, [Out] Color FDGCCIBEOPI, [Out] Color IGIDJNJGMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7B87ED0", Offset = "0x7B868D0", VA = "0x187B87ED0")]
	private bool PEEFAFEKDMJ(Material NJABANIHMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C270", Offset = "0x7B7AC70", VA = "0x187B7C270")]
	private static Material BCNBKJNANIA(int GHJBHDJCOIO, JNFBAJFIKEK FCNNCHKGIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B83B00", Offset = "0x7B82500", VA = "0x187B83B00")]
	private static MIPECIFKJHH JJIKGNABLGC(NMJOLFALJAH FCNNCHKGIAA, int BBPCOAOGCBJ)
	{
		return default(MIPECIFKJHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B81B40", Offset = "0x7B80540", VA = "0x187B81B40")]
	private static void GCBEAEMJCFM(Dictionary<string, List<BIHJMGLIGML>> ICFOMKCGHDA, NMJOLFALJAH AEGAJMAEJHH, Material BOINKEIDMGM, INENJPIGNGG LIKPIPIHIML, MIPECIFKJHH FKNDFFHPDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B85E90", Offset = "0x7B84890", VA = "0x187B85E90")]
	private static SkinnedMeshRenderer LPDHOBKJNAP(Transform OEAKLEMJICM, Transform JGAAIGOBEAF, SkinnedMeshRenderer[] PAEBPJCHGPB, int GIFLHFGNGDL, GPEDBMKBACG OLNBDAKOELL, bool OJGLHJECAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B884F0", Offset = "0x7B86EF0", VA = "0x187B884F0")]
	public IEMPAIAEGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B7DA80", Offset = "0x7B7C480", VA = "0x187B7DA80")]
	public void DBILOAODCDE([In] BBFNHCDGHLC CDKBMKJLEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FFE0", Offset = "0x7B7E9E0", VA = "0x187B7FFE0")]
	public void MLDAOFMBOBO([In] HJJCHAGHMFJ LFJFLCCFFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B83400", Offset = "0x7B81E00", VA = "0x187B83400", Slot = "5")]
	public void MDFFPGDMPOF(int GIFLHFGNGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B87500", Offset = "0x7B85F00", VA = "0x187B87500", Slot = "10")]
	public void OCACAONHIPC(GJBOKECKPIJ FKNDFFHPDJM, Texture2D AELHKEIFLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
	public static bool CLPLDEINKGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D1E0", Offset = "0x7B7BBE0", VA = "0x187B7D1E0", Slot = "11")]
	public bool CEFIFLMCHDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CC50", Offset = "0x7B7B650", VA = "0x187B7CC50", Slot = "9")]
	public void BHHJHBHEBKL(KKBGFAOIEKF LIKPIPIHIML, Color? JJNDBAIEAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B82460", Offset = "0x7B80E60", VA = "0x187B82460")]
	private void GOELHAANLIE(Action MFPHJIHIDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C200", Offset = "0x7B7AC00", VA = "0x187B7C200", Slot = "6")]
	public void BCINGFMFHFA(KJOKLAANNCB CJIMBICMMNF, Texture ILBNFOMNDDE, Color KIONHFHFNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D050", Offset = "0x7B7BA50", VA = "0x187B7D050", Slot = "7")]
	public void BHJAALLPDMO(bool IMLPDGIALBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D89AE0", Offset = "0x1D884E0", VA = "0x181D89AE0", Slot = "8")]
	public void LEIAACPNCEH(BBNCMLFOPPH JKGCHKOAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C9F0", Offset = "0x7B7B3F0", VA = "0x187B7C9F0", Slot = "16")]
	public void BGMBHGDEGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CBF0", Offset = "0x7B7B5F0", VA = "0x187B7CBF0", Slot = "36")]
	public void BGMJNEFABHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7B802F0", Offset = "0x7B7ECF0", VA = "0x187B802F0", Slot = "37")]
	public void EHDHJPHBJHH([Optional] EBGNPCDLBGE FGDHFMBBPOC, [Optional] bool? DBPDOOFBNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7B87390", Offset = "0x7B85D90", VA = "0x187B87390")]
	private bool OAPNGHJGKJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7B82540", Offset = "0x7B80F40", VA = "0x187B82540", Slot = "21")]
	public bool GPFCJCDINJM(PNNNJKDMBBI.KEKJLMIKOAG EJAPGIHBEKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BC50", Offset = "0x7B7A650", VA = "0x187B7BC50", Slot = "38")]
	public void AGPDJMHFCJJ(float EHJENDCKJLA, Color JJNDBAIEAAG, bool GDMDGDKJEAJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7B85780", Offset = "0x7B84180", VA = "0x187B85780")]
	public void LCPAJOCIKOL(float EHJENDCKJLA, Color JJNDBAIEAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7B87790", Offset = "0x7B86190", VA = "0x187B87790")]
	private static bool OIPLEIMHNFL(Material OMADNODHBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7B7DF60", Offset = "0x7B7C960", VA = "0x187B7DF60")]
	private void DGGGENICFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B81AB0", Offset = "0x7B804B0", VA = "0x187B81AB0")]
	private void FKLEHHPHLCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B83100", Offset = "0x7B81B00", VA = "0x187B83100")]
	private static void HMLEHAEGMIP(Dictionary<BIHJMGLIGML, Material> KILDONHPMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7B838A0", Offset = "0x7B822A0", VA = "0x187B838A0")]
	private static void IOCEPMCKMGG(Dictionary<Renderer, BHMFMGIOGCC> DOBHACKHKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B881C0", Offset = "0x7B86BC0", VA = "0x187B881C0")]
	private void PFDBFAAFNCF(SkinnedMeshRenderer[] PAEBPJCHGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B822F0", Offset = "0x7B80CF0", VA = "0x187B822F0")]
	private void GKLPDGHBOEC(SkinnedMeshRenderer JCEEOOAMPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B855B0", Offset = "0x7B83FB0", VA = "0x187B855B0")]
	private void LBHKJELFDLC(List<MCFGKKFEMKA> IFALBLPACDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B86A50", Offset = "0x7B85450", VA = "0x187B86A50")]
	private void MICCABNPFMF(Dictionary<string, ODDHNIEMFCD<Texture2D>> ICFOMKCGHDA, bool EMEAJPKDIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B86BD0", Offset = "0x7B855D0", VA = "0x187B86BD0")]
	private void MKDLGGKHLKP(Dictionary<string, List<BIHJMGLIGML>> ICFOMKCGHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B83590", Offset = "0x7B81F90", VA = "0x187B83590")]
	private void IGGECOCPNMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7B836E0", Offset = "0x7B820E0", VA = "0x187B836E0")]
	private void IHOFLMGAAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7B86490", Offset = "0x7B84E90", VA = "0x187B86490")]
	private void MGONCMKHNOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7B80070", Offset = "0x7B7EA70", VA = "0x187B80070")]
	private void EEPHCGIFHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7B81480", Offset = "0x7B7FE80", VA = "0x187B81480")]
	private void EKABFNMKPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7B7C8A0", Offset = "0x7B7B2A0", VA = "0x187B7C8A0")]
	private void BFHHGEOGGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7B81AC0", Offset = "0x7B804C0", VA = "0x187B81AC0")]
	private void GAAJJGENBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7B83CC0", Offset = "0x7B826C0", VA = "0x187B83CC0")]
	private void JOBJKIAPNNN(bool OJEIJALJAFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BF40", Offset = "0x7B7A940", VA = "0x187B7BF40")]
	private void ANEEBDDLCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B817C0", Offset = "0x7B801C0", VA = "0x187B817C0")]
	private void FAFGPBPJOED(bool OJEIJALJAFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7B81130", Offset = "0x7B7FB30", VA = "0x187B81130")]
	private void EHLNIHIJKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B82B20", Offset = "0x7B81520", VA = "0x187B82B20")]
	private void HIBCLPEOFND(Material OMADNODHBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7B83420", Offset = "0x7B81E20", VA = "0x187B83420")]
	private void IGDFEKDOADA(Material OMADNODHBAD, Color MOFDJMGJMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BFC0", Offset = "0x7B7A9C0", VA = "0x187B7BFC0")]
	private void BBNDLOFOJFC(Material OMADNODHBAD, Color MOFDJMGJMJK, Color GJHKDLBDBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B81630", Offset = "0x7B80030", VA = "0x187B81630")]
	private void ENPDDELDIPM(Material OMADNODHBAD, Color PPNFPJDAMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B83DA0", Offset = "0x7B827A0", VA = "0x187B83DA0")]
	private void JPHGKJLIKLC(Material OMADNODHBAD, Texture2D AELHKEIFLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FD80", Offset = "0x7B7E780", VA = "0x187B7FD80")]
	private void DNBOLIPABIL(Material OMADNODHBAD, Texture OBMCBLPNLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BAF0", Offset = "0x7B7A4F0", VA = "0x187B7BAF0")]
	private void AGAJNFCGAMD(Action<BHMFMGIOGCC> KAMIKADMODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D060", Offset = "0x7B7BA60", VA = "0x187B7D060")]
	private void CDAJAHJBBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B84080", Offset = "0x7B82A80", VA = "0x187B84080")]
	private void KEGJKHDBCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B860C0", Offset = "0x7B84AC0", VA = "0x187B860C0")]
	private void MACLKDFKAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B85B00", Offset = "0x7B84500", VA = "0x187B85B00")]
	public void LIHGNFOMCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FFE0", Offset = "0x7B7E9E0", VA = "0x187B7FFE0", Slot = "4")]
	private void ECOLEHCJCIK([In] HJJCHAGHMFJ LFJFLCCFFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BD90", Offset = "0x7B7A790", VA = "0x187B7BD90")]
	[CompilerGenerated]
	private FDBBAHKKNBB AICIIMDGJHF(NMJOLFALJAH ADAFNPDOCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FCF0", Offset = "0x7B7E6F0", VA = "0x187B7FCF0")]
	[CompilerGenerated]
	private void DMMIHHLEIGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7B7DA40", Offset = "0x7B7C440", VA = "0x187B7DA40")]
	[CompilerGenerated]
	private void CNKCDOIIOGC(BHMFMGIOGCC OJHEKKHICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7B818A0", Offset = "0x7B802A0", VA = "0x187B818A0")]
	[CompilerGenerated]
	private void FHLGNJPLGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FEE0", Offset = "0x7B7E8E0", VA = "0x187B7FEE0")]
	[CompilerGenerated]
	private void DPAADOGCOCN(BHMFMGIOGCC OJHEKKHICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7B87700", Offset = "0x7B86100", VA = "0x187B87700")]
	[CompilerGenerated]
	private void OHCGAIDLGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B830E0", Offset = "0x7B81AE0", VA = "0x187B830E0")]
	[CompilerGenerated]
	private void HLDHOCLKIFO(BHMFMGIOGCC OJHEKKHICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7B88130", Offset = "0x7B86B30", VA = "0x187B88130")]
	[CompilerGenerated]
	private void PEJFPBPIAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7B83870", Offset = "0x7B82270", VA = "0x187B83870")]
	[CompilerGenerated]
	private void IIDFPOCJJDA(BHMFMGIOGCC OJHEKKHICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7B7DE50", Offset = "0x7B7C850", VA = "0x187B7DE50")]
	[CompilerGenerated]
	private void DCNFECKCFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BD60", Offset = "0x7B7A760", VA = "0x187B7BD60")]
	[CompilerGenerated]
	private void AHBIIIIGIAM(BHMFMGIOGCC OJHEKKHICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7B878E0", Offset = "0x7B862E0", VA = "0x187B878E0")]
	[CompilerGenerated]
	private void OMFJJDLEOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B7DE20", Offset = "0x7B7C820", VA = "0x187B7DE20")]
	[CompilerGenerated]
	private void DBNIKDMMLMN(BHMFMGIOGCC OJHEKKHICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7B83260", Offset = "0x7B81C60", VA = "0x187B83260")]
	[CompilerGenerated]
	private void IBMAGKHFDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B874D0", Offset = "0x7B85ED0", VA = "0x187B874D0")]
	[CompilerGenerated]
	private void OBKBIDAJFGD(BHMFMGIOGCC OJHEKKHICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7B83A00", Offset = "0x7B82400", VA = "0x187B83A00")]
	[CompilerGenerated]
	private void JCMKNFAJHDM(KeyValuePair<string, ODDHNIEMFCD<Texture2D>> FPBJFGGMDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7B80140", Offset = "0x7B7EB40", VA = "0x187B80140")]
	[CompilerGenerated]
	private void EFHNANCIOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B83F90", Offset = "0x7B82990", VA = "0x187B83F90")]
	[CompilerGenerated]
	private void KADKANNCAAL(BHMFMGIOGCC OJHEKKHICIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B80060", Offset = "0x7B7EA60", VA = "0x187B80060")]
	[CompilerGenerated]
	private void EEIGIFHIJLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B81450", Offset = "0x7B7FE50", VA = "0x187B81450")]
	[CompilerGenerated]
	private void EIMIEIEHONL(BHMFMGIOGCC OJHEKKHICIA)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, EKMGOOCJEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
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
		private Vector3? LHJEKPAPMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool GOOLNCPJMEM;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B73430", Offset = "0x7B71E30", VA = "0x187B73430", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B73A50", Offset = "0x7B72450", VA = "0x187B73A50", Slot = "4")]
		public void UpdateController(float HMAHKNFCDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xCDCC50", Offset = "0xCDB650", VA = "0x180CDCC50", Slot = "6")]
		public void SetEnabled(bool PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B73510", Offset = "0x7B71F10", VA = "0x187B73510")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B73F10", Offset = "0x7B72910", VA = "0x187B73F10")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, EKMGOOCJEJL
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private const float OKBKOPPFPEC = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
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
		private Vector3 LILADEHMLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Vector3 INMBOBDOFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private bool GOOLNCPJMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float AAJEJCBKPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private float LKFCEAACKOB;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7B74290", Offset = "0x7B72C90", VA = "0x187B74290", Slot = "4")]
		public void UpdateController(float HMAHKNFCDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xF11DB0", Offset = "0xF107B0", VA = "0x180F11DB0", Slot = "6")]
		public void SetEnabled(bool PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7B73FB0", Offset = "0x7B729B0", VA = "0x187B73FB0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B74D50", Offset = "0x7B73750", VA = "0x187B74D50")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class IHIKIEEIPMG : HBPKIIMPBKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int NGDCCIABDPG;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int LFHGPPCGGDP;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int IBCBHLFGBKA;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int NBHMOBBDJIP;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int LHFBDIHGDDF;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int MMHDCMIHMBB;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int JAPLKPPOIHB;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int CMOIOBLALEH;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int GJGPMCCGNND;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int IAODBHKNAAP;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int EKCNGKMOBOH;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int GGJOBLODIBF;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int CMDLNLFBOOO;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int JCIPFNHGKKH;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int DNOCPLABGEM;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int NALKMMBLFBF;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int AGPIIBLJMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform BMNJHAKONLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform IENBNBIJJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform PMGELGGOOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform NDJNOPNKCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform NKAFCNLEDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private Transform OEPNFBGLCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private LFCLGABFAJC BONHBLGJEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Material AKHEAAAEEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private SkinnedMeshRenderer[] MFBAINKEHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly List<Material> CHCFKDELMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private POHNCHBOIFI MFDGPDIPEIN;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CNBOOGKDGFE BCKLNEHEEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private POHNCHBOIFI BKFCEADFDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B968F0", Offset = "0x7B952F0", VA = "0x187B968F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ANNFNILDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B94DB0", Offset = "0x7B937B0", VA = "0x187B94DB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7B94C90", Offset = "0x7B93690", VA = "0x187B94C90")]
	public void DBILOAODCDE([In] LFCLGABFAJC JIBNIIFBFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7B94F00", Offset = "0x7B93900", VA = "0x187B94F00")]
	public void HFEPPEKHFED([In] NDCNKOKMCGM BKHIANMHGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7B95490", Offset = "0x7B93E90", VA = "0x187B95490", Slot = "6")]
	public void KNDBJKDLMNL(AGMIAOMADPI MEFNDOBOOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B96890", Offset = "0x7B95290", VA = "0x187B96890")]
	private Vector2 NGBBJPEJHAI(Vector2 EAIDAGGEGON)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7B959A0", Offset = "0x7B943A0", VA = "0x187B959A0")]
	public void NBHLIPLAMGE([In] CJENCHFANDL BKHIANMHGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7B94FE0", Offset = "0x7B939E0", VA = "0x187B94FE0")]
	private void IMKEBMCEGEF(PHBJDIEKAOM DCDEBEOLMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7B94900", Offset = "0x7B93300", VA = "0x187B94900")]
	private void CNIBCJJOGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7B94D40", Offset = "0x7B93740", VA = "0x187B94D40")]
	private void HGMLCPABAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7B94D40", Offset = "0x7B93740", VA = "0x187B94D40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7B96C50", Offset = "0x7B95650", VA = "0x187B96C50")]
	public IHIKIEEIPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7B94F00", Offset = "0x7B93900", VA = "0x187B94F00", Slot = "5")]
	private void KIGJDLMHLHD([In] NDCNKOKMCGM BKHIANMHGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7B948F0", Offset = "0x7B932F0", VA = "0x187B948F0", Slot = "7")]
	private void BELBDLCDOHF([In] CJENCHFANDL BKHIANMHGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B96970", Offset = "0x7B95370", VA = "0x187B96970")]
	[CompilerGenerated]
	internal static float PLHDPFOKNBI(float PCDAHJCDHHF, float HGPAFCDNHEI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B953A0", Offset = "0x7B93DA0", VA = "0x187B953A0")]
	[CompilerGenerated]
	internal static void JPHBNJPLHIM(Vector2 NGCMBNHLDIC, Vector2 ODMEPBIAGPP, Vector2 OPKPFANIILK, Vector2 FABCOJIGKOI, Vector2 EOFJEGBKIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7B94FA0", Offset = "0x7B939A0", VA = "0x187B94FA0")]
	[CompilerGenerated]
	internal static Vector4 ILHNNHDAEGC(Vector2 JFMEMBGKAOB, Vector2 JAHHKOMJJAE)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, EKMGOOCJEJL
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
		private float AAJEJCBKPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool GOOLNCPJMEM;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A770", Offset = "0x7B89170", VA = "0x187B8A770", Slot = "4")]
		public void UpdateController(float HMAHKNFCDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x20DC3B0", Offset = "0x20DADB0", VA = "0x1820DC3B0", Slot = "6")]
		public void SetEnabled(bool PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8AFD0", Offset = "0x7B899D0", VA = "0x187B8AFD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B8B000", Offset = "0x7B89A00", VA = "0x187B8B000")]
		public void JBAOHJPBOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B120", Offset = "0x7B89B20", VA = "0x187B8B120")]
		public int JGMIMPNMGPA(int EMMJEEBCCIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NJGIIBLFCND : IGHAMABMIGO
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7B9CF00", Offset = "0x7B9B900", VA = "0x187B9CF00", Slot = "24")]
	public override float HIGEMABFHGM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7B9CF50", Offset = "0x7B9B950", VA = "0x187B9CF50")]
	public NJGIIBLFCND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class IGHAMABMIGO : JPJMMHEAOFC
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int BGPDFKAOKEI;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int MMKGGNCNECD;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int FBBNAKNHJNG;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int MAPHAKBMINE;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int AIDAJOBOGPJ;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int PEKHFHEHABN;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int HFMJAJGFGED;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int[] DMMKHAEFLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private OIFBCCDBMLA BONHBLGJEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private DGFMJFOBGPG ELFJOCCDNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private int PMOPIBNDMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private float MOOMFGDLAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected Animator INMHPFILHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration HJBAOBIHIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int HCPKDNINONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int EEIHOCKNILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int IEOIFOCILEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool ANFMOBNAGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private CFEHALFBHCM MOBIMPKDDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int HEJEOMGCPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float ANLMDEOGLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings IJFIOHLFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private DOOHILAACHK DIPCBJFEBMN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform AAKNEOJDNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 NJJDALKFCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x17E7540", Offset = "0x17E5F40", VA = "0x1817E7540")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x17E7560", Offset = "0x17E5F60", VA = "0x1817E7560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion NBNJBEENFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xDC1130", Offset = "0xDBFB30", VA = "0x180DC1130")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xF945B0", Offset = "0xF92FB0", VA = "0x180F945B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool MPCHHPGENDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7B93E00", Offset = "0x7B92800", VA = "0x187B93E00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7B936C0", Offset = "0x7B920C0", VA = "0x187B936C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CDBNBGOMAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xBD1230", Offset = "0xBCFC30", VA = "0x180BD1230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 PBBJCKKHKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA37DE0", Offset = "0xA367E0", VA = "0x180A37DE0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA359E0", VA = "0x180A36FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion MLPDFJHPBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x113EFB0", Offset = "0x113D9B0", VA = "0x18113EFB0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1598E30", Offset = "0x1597830", VA = "0x181598E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public FDMGNGIPNID EJEFNOFIMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA8EA70", Offset = "0xA8D470", VA = "0x180A8EA70", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(FDMGNGIPNID);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA8E2E0", Offset = "0xA8CCE0", VA = "0x180A8E2E0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public FDMGNGIPNID OILAKGPHACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA8EA60", Offset = "0xA8D460", VA = "0x180A8EA60", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(FDMGNGIPNID);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA8E300", Offset = "0xA8CD00", VA = "0x180A8E300", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float FLEALNOHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xB40A40", Offset = "0xB3F440", VA = "0x180B40A40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xF9F810", Offset = "0xF9E210", VA = "0x180F9F810", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool GHPLLDMBAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B93DF0", Offset = "0x7B927F0", VA = "0x187B93DF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B936B0", Offset = "0x7B920B0", VA = "0x187B936B0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool IGKIDICIODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7B93F60", Offset = "0x7B92960", VA = "0x187B93F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GOKAHMECDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7B93F50", Offset = "0x7B92950", VA = "0x187B93F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool JAFPDABLFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7B93E80", Offset = "0x7B92880", VA = "0x187B93E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool ECPEKOOOCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7B93F30", Offset = "0x7B92930", VA = "0x187B93F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7B93710", Offset = "0x7B92110", VA = "0x187B93710", Slot = "23")]
	public void DBILOAODCDE(OIFBCCDBMLA JIBNIIFBFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7B93660", Offset = "0x7B92060", VA = "0x187B93660")]
	public void BLBCOLJDBIP(DGFMJFOBGPG PFEAEAELGJP, AvatarHandDisplaySettings BKOBIBOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7B93EA0", Offset = "0x7B928A0", VA = "0x187B93EA0", Slot = "14")]
	public void LBJDECGJIEN(bool NDMOBAIGJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7B938B0", Offset = "0x7B922B0", VA = "0x187B938B0", Slot = "13")]
	public void DMNMIKKMKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xB40A40", Offset = "0xB3F440", VA = "0x180B40A40", Slot = "24")]
	public virtual float HIGEMABFHGM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7B93C70", Offset = "0x7B92670", VA = "0x187B93C70")]
	private int GDCNJDKKMFN(FDMGNGIPNID PCFOJAEKGIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7B93F70", Offset = "0x7B92970", VA = "0x187B93F70")]
	private void PIAIMCGEDBK(int BDKOBFBKGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7B93640", Offset = "0x7B92040", VA = "0x187B93640", Slot = "15")]
	public bool ACIGDGBCFNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7B93E90", Offset = "0x7B92890", VA = "0x187B93E90", Slot = "16")]
	public bool KHFDDPIAEKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7B93E30", Offset = "0x7B92830", VA = "0x187B93E30")]
	private FDMGNGIPNID JHNOHGDKEIM()
	{
		return default(FDMGNGIPNID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1D56240", Offset = "0x1D54C40", VA = "0x181D56240", Slot = "17")]
	public void MLHDPFKJHOD(bool NDMOBAIGJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7B93600", Offset = "0x7B92000", VA = "0x187B93600", Slot = "12")]
	public void AAAEFOLPNKK(int BDKOBFBKGDL, float MLMKHJAKCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7B936F0", Offset = "0x7B920F0", VA = "0x187B936F0", Slot = "10")]
	public void CEFHPNBGNLJ(CFEHALFBHCM LOPOEJHIPKN, bool JJAMIIBHPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7B93F40", Offset = "0x7B92940", VA = "0x187B93F40", Slot = "11")]
	public void MDFHOIMNIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7B93C20", Offset = "0x7B92620", VA = "0x187B93C20", Slot = "18")]
	public void EECPAMAFADM(Transform EAGGHBKHKHF, Vector3 ABHKONGANMG, Quaternion MAHMLAMAOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7B943C0", Offset = "0x7B92DC0", VA = "0x187B943C0")]
	public IGHAMABMIGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JNFBAJFIKEK : NMJOLFALJAH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KHJCCBPBDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public JNFBAJFIKEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<MCFGKKFEMKA> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public List<MCFGKKFEMKA> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public ODDHNIEMFCD<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public ODDHNIEMFCD<NJLADKEKBGI> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KHJCCBPBDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7B99990", Offset = "0x7B98390", VA = "0x187B99990")]
		internal FDBBAHKKNBB ONPDMPGDDIJ(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public KJOKLAANNCB EKKALJOMLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NJLADKEKBGI NGEHELHOKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private ODDHNIEMFCD<NJLADKEKBGI> IONDGONCAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private ODDHNIEMFCD<Material[]> HOAIHDMHJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Material[] JKOFMGGCNOJ;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FPJINCJCODN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA38610", Offset = "0xA37010", VA = "0x180A38610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36D90", VA = "0x180A38390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public PNNNJKDMBBI.KEKJLMIKOAG GEAGDFKCLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
		[CompilerGenerated]
		get
		{
			return default(PNNNJKDMBBI.KEKJLMIKOAG);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A580", Offset = "0xA08F80", VA = "0x180A0A580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7B99920", Offset = "0x7B98320", VA = "0x187B99920")]
	public JNFBAJFIKEK(MFEGJNCJJMB FBEHCCDPIAK, KJOKLAANNCB PENJJHKMCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7B99400", Offset = "0x7B97E00", VA = "0x187B99400", Slot = "6")]
	public override FDBBAHKKNBB NKDCFBJAMBC(List<MCFGKKFEMKA> CFMJIOONCHE, List<MCFGKKFEMKA> NJPEAJPGBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7B98980", Offset = "0x7B97380", VA = "0x187B98980")]
	public FDBBAHKKNBB EDFADIJBPNG(List<MCFGKKFEMKA> CFMJIOONCHE, List<MCFGKKFEMKA> NJPEAJPGBKJ, ODDHNIEMFCD<Material[]> HOAIHDMHJEN, [Optional] ODDHNIEMFCD<NJLADKEKBGI> MDGKJGDHAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B98560", Offset = "0x7B96F60", VA = "0x187B98560")]
	public (ODDHNIEMFCD<Material[]>, ODDHNIEMFCD<NJLADKEKBGI>) BIILLBJEDDG(List<MCFGKKFEMKA> CFMJIOONCHE, List<MCFGKKFEMKA> NJPEAJPGBKJ)
	{
		return default((ODDHNIEMFCD<Material[]>, ODDHNIEMFCD<NJLADKEKBGI>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7B99200", Offset = "0x7B97C00", VA = "0x187B99200", Slot = "7")]
	public override DDFCOCGCPIF MHPHHKNJIFE(uint GIFLHFGNGDL, AvatarSkinnedMeshBoneOrderRemapsData MCGJPBJCLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7B98FF0", Offset = "0x7B979F0", VA = "0x187B98FF0")]
	public DDFCOCGCPIF JJBEMHGODPP(GameObject KNGBKGLJPMJ, uint GIFLHFGNGDL, bool HDGDEBPBLJH, bool KJGEEAGCIJK, AvatarSkinnedMeshBoneOrderRemapsData MCGJPBJCLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7B98C90", Offset = "0x7B97690", VA = "0x187B98C90")]
	public static bool IDBDJLHDMIA(Renderer[] PAEBPJCHGPB, string ODAGALMBPGD, [Out] Renderer MBDBAOJLKMH, [Out] Renderer ONCCNOGLPEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7B998D0", Offset = "0x7B982D0", VA = "0x187B998D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7B99330", Offset = "0x7B97D30", VA = "0x187B99330")]
	private (ODDHNIEMFCD<NJLADKEKBGI>, ODDHNIEMFCD<Material[]>) MIFDGIPCBOJ()
	{
		return default((ODDHNIEMFCD<NJLADKEKBGI>, ODDHNIEMFCD<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7B998B0", Offset = "0x7B982B0", VA = "0x187B998B0")]
	[CompilerGenerated]
	private void OKCJDKJIMDG(NJLADKEKBGI MGJNMKLFKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA10510", Offset = "0xA0EF10", VA = "0x180A10510")]
	[CompilerGenerated]
	private void INPMPPCPOPK(Material[] MGJNMKLFKCJ)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, EKMGOOCJEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
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
		private Vector3 LILADEHMLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 JBABHACDAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Vector3 DFEOIPIFJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private Matrix4x4 CDKPOHCPJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private bool GOOLNCPJMEM;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B600", Offset = "0x7B8A000", VA = "0x187B8B600", Slot = "4")]
		public void UpdateController(float HMAHKNFCDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B5F0", Offset = "0x7B89FF0", VA = "0x187B8B5F0", Slot = "6")]
		public void SetEnabled(bool PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B190", Offset = "0x7B89B90", VA = "0x187B8B190")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7B8BCC0", Offset = "0x7B8A6C0", VA = "0x187B8BCC0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NHPBPJDIEFG]
public struct JHKGEKKNEOO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public IECACCEEPCH OJHHMPNFCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[ReadOnly]
	public int KCFEBCNDOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public LBKEJBFHFFF AAOCLNNFPLP;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7B97480", Offset = "0x7B95E80", VA = "0x187B97480", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[NHPBPJDIEFG]
public struct LBKEJBFHFFF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> DEOGBKHNHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector3> MPCFGGLBFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector4> PNOFPKNFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> LGKDAFBLFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> GCKEAMJAHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> MKPOPCKBHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Vector2> FPBJFFFFGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<Color> GNFICLHAGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> AELEHHIKHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> HDBDFNLCECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> BEAOEHNKCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private NativeArray<int> BGGELHPOCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> BNNGFDNCCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> IAMJKFICAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<int> GHIEJOEPMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<BoneWeight> CHCBAPHFLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NativeArray<int> JKGCHKOAIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private bool ALGNNAPDEJK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JNKKHDBOEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7B9A770", Offset = "0x7B99170", VA = "0x187B9A770")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7B9A490", Offset = "0x7B98E90", VA = "0x187B9A490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int OFBBMDMFBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7B9A860", Offset = "0x7B99260", VA = "0x187B9A860")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7B9ABE0", Offset = "0x7B995E0", VA = "0x187B9ABE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int MDIDGNILNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7B9A850", Offset = "0x7B99250", VA = "0x187B9A850")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9A760", Offset = "0x7B99160", VA = "0x187B9A760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7B9AC10", Offset = "0x7B99610", VA = "0x187B9AC10")]
	public LBKEJBFHFFF(int NIDOHGNBKLE, int FDBJFAEIHDB, int CCFJECOKPFF, int OIBFOGENFCL, Allocator NDKMELBEFLH, int OBIAHACFPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A420", Offset = "0x7B98E20", VA = "0x187B9A420")]
	public void DECJOGDIPPP(int MNFHMLCLFEB, Vector3 GEHEADBMGDC, Vector3 COCHOILMLGE, Vector4 ANAFNAJGANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A1C0", Offset = "0x7B98BC0", VA = "0x187B9A1C0")]
	public void CFKNMPLHINL(int MNFHMLCLFEB, BoneWeight PLFLKKMHKLA, NativeSlice<byte> FKNFEDOECAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7B9ABF0", Offset = "0x7B995F0", VA = "0x187B9ABF0")]
	public Color PFEKBLBKPMI(int MNFHMLCLFEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7B9ABC0", Offset = "0x7B995C0", VA = "0x187B9ABC0")]
	public void OBCGCFMJKNG(int MNFHMLCLFEB, Color CIBCGCDEGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A680", Offset = "0x7B99080", VA = "0x187B9A680")]
	public void GDGKBKAIJDJ(byte ONMJHGHEAPJ, int MNFHMLCLFEB, Vector2 CPBHKIEKBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A410", Offset = "0x7B98E10", VA = "0x187B9A410")]
	public void DEBILPLBJDE(int MNFHMLCLFEB, int LAFKDIKAKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A650", Offset = "0x7B99050", VA = "0x187B9A650")]
	public bool GCIJMPFEDGP(int ONMJHGHEAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A780", Offset = "0x7B99180", VA = "0x187B9A780")]
	public void HDHAAEDEHJM(int PPPKEKEOOCO, int BACDJHJBLPL, int EIJGIDNMHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A360", Offset = "0x7B98D60", VA = "0x187B9A360")]
	public int[] COLLAFBEBFG(int PPPKEKEOOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A6D0", Offset = "0x7B990D0", VA = "0x187B9A6D0")]
	private NativeSlice<int> GFIIAAMHMEC(int PPPKEKEOOCO)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A4A0", Offset = "0x7B98EA0", VA = "0x187B9A4A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A870", Offset = "0x7B99270", VA = "0x187B9A870")]
	public Mesh NPFFEOJEJBB([Optional] string LICBELADCFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[NHPBPJDIEFG]
[DefaultMember("Item")]
[NativeContainer]
public struct IECACCEEPCH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> DEOGBKHNHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector3> MPCFGGLBFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector4> PNOFPKNFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> LGKDAFBLFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> GCKEAMJAHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> MKPOPCKBHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Vector2> FPBJFFFFGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<Color> GNFICLHAGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> JFFNOOIILAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> BJMGIFOCMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> DALPLDJLIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<int> FAFOAAEABNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<bool> OKCFMHEBLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> NDBGCPPBAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<int> FFPHDGPABDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<BoneWeight> BPAJOOPNEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<Matrix4x4> BPNCBKKKIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<long> PAKDMIPAEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<byte> JMCFDLJKGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> AALOMCFIGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private NativeArray<int> DJHEFMMMJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<sbyte> FHJJEDODIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<byte> BBHLIDICJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private NativeArray<int> GMEKKELHGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool ALGNNAPDEJK;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int AMLIDOGOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xE4ADD0", Offset = "0xE497D0", VA = "0x180E4ADD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int JGLMMLDFDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xCDF880", Offset = "0xCDE280", VA = "0x180CDF880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int CCBEPJFGIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7B91D30", Offset = "0x7B90730", VA = "0x187B91D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int AEACADPDEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7B91D20", Offset = "0x7B90720", VA = "0x187B91D20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7B91C10", Offset = "0x7B90610", VA = "0x187B91C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int JNKKHDBOEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7B91C20", Offset = "0x7B90620", VA = "0x187B91C20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7B91980", Offset = "0x7B90380", VA = "0x187B91980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int GOAIKMPEEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7B91960", Offset = "0x7B90360", VA = "0x187B91960")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7B91D60", Offset = "0x7B90760", VA = "0x187B91D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DNNCNPOKLAI EHBACBLDBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7B91D10", Offset = "0x7B90710", VA = "0x187B91D10")]
		get
		{
			return default(DNNCNPOKLAI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7B91C30", Offset = "0x7B90630", VA = "0x187B91C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte FMLKBCNMKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7B91970", Offset = "0x7B90370", VA = "0x187B91970")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7B91C00", Offset = "0x7B90600", VA = "0x187B91C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public FHLDKMJNLLI OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7B91430", Offset = "0x7B8FE30", VA = "0x187B91430")]
		get
		{
			return default(FHLDKMJNLLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7B91D70", Offset = "0x7B90770", VA = "0x187B91D70")]
	public IECACCEEPCH(IList<Mesh> IAHKFOONMHD, IList<Matrix4x4> DJHCNFABKGC, IList<bool> OKCFMHEBLGA, byte JMDKOOCJJFM, IList<byte[]> ALBLECHENAP, IList<long> HCAPGIIIMGB, IList<bool> CGJAIOIKPMP, IList<int> NDBGCPPBAKM, IList<int> LJGCICFOFOI, IList<int> HGMFIDHIBMO, Allocator NDKMELBEFLH, DNNCNPOKLAI CFMMKCBMKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7B91C40", Offset = "0x7B90640", VA = "0x187B91C40")]
	public LBKEJBFHFFF INMLDLAHGAM(Allocator NDKMELBEFLH)
	{
		return default(LBKEJBFHFFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7B91990", Offset = "0x7B90390", VA = "0x187B91990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[NHPBPJDIEFG]
public class PONDBMDEBEP : CLOHKNGAFKG
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D7F0", Offset = "0x7B9C1F0", VA = "0x187B9D7F0")]
	public IECACCEEPCH LBGHFNOOAIB()
	{
		return default(IECACCEEPCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7B89490", Offset = "0x7B87E90", VA = "0x187B89490")]
	public PONDBMDEBEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct FHLDKMJNLLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> DEOGBKHNHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector3> MPCFGGLBFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector4> PNOFPKNFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> LGKDAFBLFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> GCKEAMJAHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> MKPOPCKBHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Vector2> FPBJFFFFGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<Color> GNFICLHAGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> EIPEAECNBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<int> FAFOAAEABNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<BoneWeight> BPAJOOPNEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<byte> BIPDDBCLPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public int HAODJCOCAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public Matrix4x4 HFJGJIHAMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public long APLMPPCOIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<byte> FKNFEDOECAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public bool IAFPCBBHCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public int LCPFJMLOAGE;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct BIHJMGLIGML : IEquatable<BIHJMGLIGML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly Material BOKLPDEMDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly INENJPIGNGG FMFCNONHAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly MIPECIFKJHH COEHKAAGNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	internal readonly MFEGJNCJJMB MHEIBDEBCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	internal readonly bool HFAGGCFIAMA;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7B907F0", Offset = "0x7B8F1F0", VA = "0x187B907F0")]
	public BIHJMGLIGML(Material NJABANIHMHL, INENJPIGNGG FMOGBAPBKIE, MIPECIFKJHH BIEOJBHHNOM, MFEGJNCJJMB ODFAALAAHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7B90550", Offset = "0x7B8EF50", VA = "0x187B90550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7B903B0", Offset = "0x7B8EDB0", VA = "0x187B903B0", Slot = "4")]
	public bool Equals(BIHJMGLIGML NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7B902B0", Offset = "0x7B8ECB0", VA = "0x187B902B0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7B90440", Offset = "0x7B8EE40", VA = "0x187B90440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, HJLFCGBOLNG
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
		private DOOHILAACHK avatarBodyType;

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
		private LPODLLODNDM IHGOCKHGENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private HBPKIIMPBKO GIOBKFPCKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private JPJMMHEAOFC OADIJEGHPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private JPJMMHEAOFC JBPHMNAFEKP;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public LPODLLODNDM DIGIKALKHDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CD00", Offset = "0x7B8B700", VA = "0x187B8CD00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HBPKIIMPBKO MDPFEGBEMBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CD50", Offset = "0x7B8B750", VA = "0x187B8CD50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public JPJMMHEAOFC HKEPIPBLCGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CDA0", Offset = "0x7B8B7A0", VA = "0x187B8CDA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public JPJMMHEAOFC LGBOIAIIFND
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CDF0", Offset = "0x7B8B7F0", VA = "0x187B8CDF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform NNFKNGBGKPB
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CE40", Offset = "0x7B8B840", VA = "0x187B8CE40", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public DOOHILAACHK LBOIOJACFIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7C0", Offset = "0xA091C0", VA = "0x180A0A7C0", Slot = "12")]
			get
			{
				return default(DOOHILAACHK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7B8BF60", Offset = "0x7B8A960", VA = "0x187B8BF60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CAD0", Offset = "0x7B8B4D0", VA = "0x187B8CAD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C730", Offset = "0x7B8B130", VA = "0x187B8C730", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CAD0", Offset = "0x7B8B4D0", VA = "0x187B8CAD0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8BFD0", Offset = "0x7B8A9D0", VA = "0x187B8BFD0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CC10", Offset = "0x7B8B610", VA = "0x187B8CC10")]
		public void UpdatePostIKAnimControllers(float HMAHKNFCDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CB80", Offset = "0x7B8B580", VA = "0x187B8CB80")]
		private void PFLAOJJONGL(GameObject OJDHMKOBKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C3C0", Offset = "0x7B8ADC0", VA = "0x187B8C3C0")]
		private LPODLLODNDM IMODBNMCIJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C790", Offset = "0x7B8B190", VA = "0x187B8C790")]
		private HBPKIIMPBKO NEBMJBGOJNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8BCD0", Offset = "0x7B8A6D0", VA = "0x187B8BCD0")]
		private JPJMMHEAOFC ANEJKHHHKEA(AGKKKHJPICC AFFPKPHELBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CCF0", Offset = "0x7B8B6F0", VA = "0x187B8CCF0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BHMFMGIOGCC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private MaterialPropertyBlock LIBOJAFEHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? JEIJMOECMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? JODCABKNEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color? HJNHCFPJAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color? JMMFAIJEBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color ODGOAOJDMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Color KFFELPHGLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Color DEIAKLFBGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public float BANCIHGNHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Texture2D MJHEHHHIEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public Texture2D BCIPMADCAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private Dictionary<BIHJMGLIGML, int> GBLJMHHPIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private INENJPIGNGG[] ANBJFKBCDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private MIPECIFKJHH[] KPIMLDCBEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] GBAALDOALLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] IMIKFHJAPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] LOPOAGGBNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Vector4[] HCLHIMNHLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public Vector4[] FIDDPGNCLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Vector4[] LCGMOONEFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private List<Texture2D> IEBGANOJMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] ILALCLECNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private List<Texture2D> OEEGNOCHCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private float[] HLBEMAECKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector4[] LGEKCKDIPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] OOKOGPBBMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public float[] JCDAIHFCPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private List<Texture2D> OCPIGHPPNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] BBIFJGBPPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private List<Texture2D> MMCKEAODMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private Vector4[] MNACFNCKCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private float[] KMOFDNMCNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private Vector4[] KFPMGFNFKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public float[] CCBGGBFPHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray ODMGDJIIHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public Texture2DArray DLLJGAFHLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public Texture2DArray CKKIMLANLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public Texture2DArray MOMDHLNENGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private bool IJBPCDKPEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private int JKHFFEADDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector2? NJHOILAICEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private TextureFormat JGGBINOFPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Vector2? HDNAKEKMNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private TextureFormat JOOGJAGFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private Vector2? OEFACPMHOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private TextureFormat PPJKJOCBKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private Vector2? NCHIKEAHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private TextureFormat LNMBFPHJLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool CDPHAALIFLC;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int NIDLMCKDBFM;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int DLGJIPGCPJH;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int CDCAPNGDJGC;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int MDENMPJEEHL;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int AANBMMCHEAB;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int HOACLKGCKCD;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int HPDNHGGCBEA;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int HJHCCBDCFLL;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int BDFDMOFGMAI;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int FADGJIKBLIB;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int OFIGLGFELIN;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int EMCLONLMNCP;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int CNDHPFLGLIH;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int JIHFIPANGII;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int COENKNNKCHP;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int HCJBKALGFAL;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int JONAAAPCGKE;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static int OAEKNMDHEEK;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static int OKNOFLKFPJA;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static int IEBKPCGEAJK;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7B8FCF0", Offset = "0x7B8E6F0", VA = "0x187B8FCF0")]
	private BHMFMGIOGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B901F0", Offset = "0x7B8EBF0", VA = "0x187B901F0")]
	public BHMFMGIOGCC(Color PPCCKOGJPOI, Color CONNMGGHNOB, Color PCFIMBEDALD, Color? OLGAFDAMLHB, Color? KNJFFLHKKKK, Color? CMGHHNOOBFJ, Texture2D AGGBDLFBOGE, Texture2D NKGHPHHGIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D890", Offset = "0x7B8C290", VA = "0x187B8D890")]
	internal int FDOGDHGDEIF(Material DPDJBJBMPNF, INENJPIGNGG FMOGBAPBKIE, MIPECIFKJHH BIEOJBHHNOM, MFEGJNCJJMB ODFAALAAHIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D960", Offset = "0x7B8C360", VA = "0x187B8D960")]
	private int FDOGDHGDEIF(BIHJMGLIGML KJNEHANBOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E760", Offset = "0x7B8D160", VA = "0x187B8E760")]
	internal int JNMOJMOBEBB(Material DPDJBJBMPNF, Color PPNFPJDAMPK, Color HGMKCKGKKCJ, Color OOKCKJBPJLM, Color AOICBHAHJEN, Color FDGCCIBEOPI, Texture2D HFDMOFJOIIO, Vector4 BIDPNKIMODE, Texture2D GINCNDFAELD, Vector4 IELOIDEPGPC, float OFGJDKDMCFF, float NCEEHBIKBNC, Texture2D MAGBHCCODPP, Vector4 IAPOJPCEJIB, float HMIDAGCEPGE, Texture2D OPGIFMPIDAH, Color IGIDJNJGMOK, Vector4 CBLMMDCFBBN, INENJPIGNGG FMOGBAPBKIE, MIPECIFKJHH BIEOJBHHNOM, MFEGJNCJJMB ODFAALAAHIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F5E0", Offset = "0x7B8DFE0", VA = "0x187B8F5E0")]
	private void NPMHFGCBLKP(List<Texture2D> IEBGANOJMFM, [Out] Texture2DArray BBDLOFLNHJL, [Out] Texture2DArray FEKOGIKPIJM, [Out] Texture2DArray LKBFEMOCFGG, [Out] Texture2DArray EDDPEPDLMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F490", Offset = "0x7B8DE90", VA = "0x187B8F490")]
	public void NOLNPKEOFCC(Shader MPMAAKNHKOF, Renderer EDDLIJIPFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D9F0", Offset = "0x7B8C3F0", VA = "0x187B8D9F0")]
	private void GCKHAGNEDFI(Shader MPMAAKNHKOF, Renderer EDDLIJIPFEO, int MMKEDKNCFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F7A0", Offset = "0x7B8E1A0", VA = "0x187B8F7A0")]
	private Color PHCHCKIEPBJ(Color EDDJAGLDPMD, INENJPIGNGG LIKPIPIHIML)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D700", Offset = "0x7B8C100", VA = "0x187B8D700")]
	private Color CONHGGPFAGC(Color HDGKCHFDNNI, INENJPIGNGG LIKPIPIHIML)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F330", Offset = "0x7B8DD30", VA = "0x187B8F330")]
	private bool LKHOHOGLCHP(Texture2D AEOBNPJCJCE, MIPECIFKJHH FKNDFFHPDJM, [Out] Texture2D DAAHHGOHGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E6B0", Offset = "0x7B8D0B0", VA = "0x187B8E6B0")]
	private void JKEHIDFOBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D850", Offset = "0x7B8C250", VA = "0x187B8D850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class NMJOLFALJAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public readonly MFEGJNCJJMB OKAJAMPEMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	protected bool HNOCBDICLMI;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool MGMOCOEICDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA97A50", Offset = "0xA96450", VA = "0x180A97A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA979E0", Offset = "0xA963E0", VA = "0x180A979E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool OLLJIIKLCID
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA979F0", Offset = "0xA963F0", VA = "0x180A979F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA97A70", Offset = "0xA96470", VA = "0x180A97A70")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual PNNNJKDMBBI.KEKJLMIKOAG APLMPPCOIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(PNNNJKDMBBI.KEKJLMIKOAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xCF8030", Offset = "0xCF6A30", VA = "0x180CF8030", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool FOPCELBEDKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1414640", Offset = "0x1413040", VA = "0x181414640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool KHECOAOPBJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D040", Offset = "0x7B9BA40", VA = "0x187B9D040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool HMDMJHKDKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D070", Offset = "0x7B9BA70", VA = "0x187B9D070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool LEPOJCPAPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D050", Offset = "0x7B9BA50", VA = "0x187B9D050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D080", Offset = "0x7B9BA80", VA = "0x187B9D080")]
	protected NMJOLFALJAH(MFEGJNCJJMB FBEHCCDPIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract FDBBAHKKNBB NKDCFBJAMBC(List<MCFGKKFEMKA> CFMJIOONCHE, List<MCFGKKFEMKA> NJPEAJPGBKJ);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract DDFCOCGCPIF MHPHHKNJIFE(uint GIFLHFGNGDL, AvatarSkinnedMeshBoneOrderRemapsData MCGJPBJCLBJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KMDHLKDMAHE : PGKEALBLMBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private AvatarSkinAssetItem CBKAIMKGPKP;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A0C0", Offset = "0x7B98AC0", VA = "0x187B9A0C0")]
	public KMDHLKDMAHE(AvatarSkinAssetItem LOKGNAFOMJO, AvatarSkinAssetItem.DGMLNMJALGO POHEMHJPEBE, MFEGJNCJJMB ODFAALAAHIH, [Optional] MPLHHHEEMJC? GMNIBIDKMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B99E60", Offset = "0x7B98860", VA = "0x187B99E60", Slot = "6")]
	public override FDBBAHKKNBB NKDCFBJAMBC(List<MCFGKKFEMKA> CFMJIOONCHE, List<MCFGKKFEMKA> NJPEAJPGBKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KLCAIJGOLAP
{
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static readonly int[] FOHDMMDIACI;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static readonly int[] GHJABHNNCAE;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] JCGMGNFAPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B99C60", Offset = "0x7B98660", VA = "0x187B99C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7B99BE0", Offset = "0x7B985E0", VA = "0x187B99BE0")]
	public static int[] CLEOBEGNKCF(bool HAKBALEECGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B99CB0", Offset = "0x7B986B0", VA = "0x187B99CB0")]
	public static int EAOANLDKLIG(AMDCJLIPDMO PBHCNCJEAAF, bool HAKBALEECGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B99BD0", Offset = "0x7B985D0", VA = "0x187B99BD0")]
	private static int ALHFGBIEKIC(AMDCJLIPDMO PBHCNCJEAAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B99D40", Offset = "0x7B98740", VA = "0x187B99D40")]
	private static int PLAKHLDHNFD(AMDCJLIPDMO PBHCNCJEAAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JJJFOHBFCLL
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class AMFJGJGKNLF : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private HGOIDBIKHMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public AMFJGJGKNLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x13A6640", Offset = "0x13A5040", VA = "0x1813A6640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A720", Offset = "0x7B89120", VA = "0x187B8A720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	public static void BNNAACPLHGN(string KHNIMGKFPOO, int GIFLHFGNGDL, long KIGEHGKJIKJ, long BEOGINCJBJK, long FNGFBKKPPAC, long BHGDPHHBGDL, long HFMFFOALPPM, long IPFBJLJAKHI, long CEHLEMFBJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B98470", Offset = "0x7B96E70", VA = "0x187B98470")]
	public static IDJIHHOMEIC AOGPPHCAPFL(JobHandle AMFFAALFAII, bool GNKOHPIEBAJ, bool HMFOCDBNNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B98400", Offset = "0x7B96E00", VA = "0x187B98400")]
	[IteratorStateMachine(typeof(AMFJGJGKNLF))]
	private static IEnumerator<HGOIDBIKHMF> AHOCAPPFEDC(JobHandle GCKDJGKENJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BCFJKFMBNKK
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum IIKMGAGECEC
	{
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int MLCPLJLHNHM;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int NLJBDOLGKJD;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int BKHMJCPNGMN;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int MMOPGNJHPKN;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int JBIEJGGLMHI;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly int JLKCJKNBCKG;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly int PDIBFLBDJOE;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly int GGLAJGFLJEO;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly int PJFHHHOBKAN;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly int NMFBOIIOKGL;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly int PNEHGKBPHMN;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int NKJFEPEOHIA;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CF20", Offset = "0x7B8B920", VA = "0x187B8CF20")]
	public static bool JPGAODDALJH(Material NJABANIHMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CE60", Offset = "0x7B8B860", VA = "0x187B8CE60")]
	public static bool CLHPEMJEBCE(Material NJABANIHMHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PGKEALBLMBP : NMJOLFALJAH
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class IGNIKIBDAGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public ODDHNIEMFCD<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public PGKEALBLMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IGNIKIBDAGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B943E0", Offset = "0x7B92DE0", VA = "0x187B943E0")]
		internal void OGNOMFPCAOE(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B947B0", Offset = "0x7B931B0", VA = "0x187B947B0")]
		internal void ONPDMPGDDIJ(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	protected AvatarSkinAssetItem NHGHBOBNOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	protected Material[] JECAHAPIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private readonly AvatarSkinAssetItem.DGMLNMJALGO CKDHCMBIONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly AssetReference KJIEIAACFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly MPLHHHEEMJC? KFKAFDFMGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private SkinnedMeshRenderer[] AMNODAOGPCK;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override PNNNJKDMBBI.KEKJLMIKOAG APLMPPCOIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(PNNNJKDMBBI.KEKJLMIKOAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA10D50", Offset = "0xA0F750", VA = "0x180A10D50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D5A0", Offset = "0x7B9BFA0", VA = "0x187B9D5A0")]
	public PGKEALBLMBP(AvatarSkinAssetItem.DGMLNMJALGO POHEMHJPEBE, AssetReference HONGMMAONGA, Material LMEAAJDAGOO, MFEGJNCJJMB ODFAALAAHIH, PNNNJKDMBBI.KEKJLMIKOAG EHFFPHANMIF = (PNNNJKDMBBI.KEKJLMIKOAG)0L, [Optional] MPLHHHEEMJC? GMNIBIDKMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D6D0", Offset = "0x7B9C0D0", VA = "0x187B9D6D0")]
	public PGKEALBLMBP(AvatarSkinAssetItem.DGMLNMJALGO POHEMHJPEBE, AssetReference HONGMMAONGA, Material LMEAAJDAGOO, PNNNJKDMBBI.KEKJLMIKOAG EHFFPHANMIF = (PNNNJKDMBBI.KEKJLMIKOAG)0L, [Optional] MPLHHHEEMJC? GMNIBIDKMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D310", Offset = "0x7B9BD10", VA = "0x187B9D310", Slot = "6")]
	public override FDBBAHKKNBB NKDCFBJAMBC(List<MCFGKKFEMKA> CFMJIOONCHE, List<MCFGKKFEMKA> NJPEAJPGBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D100", Offset = "0x7B9BB00", VA = "0x187B9D100", Slot = "7")]
	public override DDFCOCGCPIF MHPHHKNJIFE(uint GIFLHFGNGDL, AvatarSkinnedMeshBoneOrderRemapsData MCGJPBJCLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D530", Offset = "0x7B9BF30", VA = "0x187B9D530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D0B0", Offset = "0x7B9BAB0", VA = "0x187B9D0B0")]
	protected void BJGNJIJOPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class LJPEOJMKLGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private List<int> GPPAGILDCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<ALMKEGEIDJL> HAPIBCKCMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private HashSet<Transform> AODHKIECCID;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7B9B390", Offset = "0x7B99D90", VA = "0x187B9B390")]
	public static LJPEOJMKLGF IPNCLFDAPMH(Transform ANAFNAJGANI, Dictionary<Transform, OutfitType?> EBHLNBFFIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B9B070", Offset = "0x7B99A70", VA = "0x187B9B070")]
	private void BJPKNILFEMA(Transform ANAFNAJGANI, MFEGJNCJJMB ODFAALAAHIH, Dictionary<Transform, OutfitType?> EBHLNBFFIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B9B520", Offset = "0x7B99F20", VA = "0x187B9B520")]
	private void JHKHMJOAKND(Transform KPMKNCPNCKG, MFEGJNCJJMB ODFAALAAHIH, bool GLCEDJAGEGM, OutfitType? MGGNIGMCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B9B6B0", Offset = "0x7B9A0B0", VA = "0x187B9B6B0")]
	public NHALAGLGJCE NKMCOJKBIMI(HashSet<string> IJHMCOKJJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B9BAA0", Offset = "0x7B9A4A0", VA = "0x187B9BAA0")]
	public LJPEOJMKLGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class NHALAGLGJCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private List<ALMKEGEIDJL> HAPIBCKCMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private List<Matrix4x4> CEPEHGLKEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private Transform[] GBEKJHMHEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private Matrix4x4[] IENNEAPKHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private Dictionary<EKMFLGPEINO, int> OFDGOHOAKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private List<CNCHKGJDNGP> NNACKCPCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private bool FADMNBNFOCG;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B9BBD0", Offset = "0x7B9A5D0", VA = "0x187B9BBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] AGJBKNCDNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C510", Offset = "0x7B9AF10", VA = "0x187B9C510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] LMKKGDNHJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B9BF40", Offset = "0x7B9A940", VA = "0x187B9BF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B9C320", Offset = "0x7B9AD20", VA = "0x187B9C320")]
	public void JHKHMJOAKND(Transform KPMKNCPNCKG, MFEGJNCJJMB ODFAALAAHIH, OutfitType? MGGNIGMCOGO, bool CBGNBBHIIII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B9BFB0", Offset = "0x7B9A9B0", VA = "0x187B9BFB0")]
	private void JHKHMJOAKND(Transform KPMKNCPNCKG, MFEGJNCJJMB ODFAALAAHIH, OutfitType? MGGNIGMCOGO, bool CBGNBBHIIII, Matrix4x4 COEOKFICFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7B9C670", Offset = "0x7B9B070", VA = "0x187B9C670")]
	public int NCKNFPMOLHC(EKMFLGPEINO KJNEHANBOBO, bool LBBCAFHMCHA, [Optional] OutfitType? MGGNIGMCOGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7B9BE40", Offset = "0x7B9A840", VA = "0x187B9BE40")]
	public int EGGOKLCLKAO(MFEGJNCJJMB ODFAALAAHIH, [Optional] OutfitType? MGGNIGMCOGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7B9BC10", Offset = "0x7B9A610", VA = "0x187B9BC10")]
	public void AKNOAHBOGIC(EKMFLGPEINO KJNEHANBOBO, Matrix4x4 LJBADLJBGIE, bool LBBCAFHMCHA = false, [Optional] OutfitType? MGGNIGMCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7B9BD00", Offset = "0x7B9A700", VA = "0x187B9BD00")]
	public Matrix4x4 DIIBHLDCMFO(EKMFLGPEINO KJNEHANBOBO, bool LBBCAFHMCHA, [Optional] OutfitType? MGGNIGMCOGO)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x14987F0", Offset = "0x14971F0", VA = "0x1814987F0")]
	public void ONMNOEKPMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7B9C820", Offset = "0x7B9B220", VA = "0x187B9C820")]
	public NHALAGLGJCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct EKMFLGPEINO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly string PLLOKHJOGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly MFEGJNCJJMB MHEIBDEBCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? JAMPLHICMEJ;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7B91390", Offset = "0x7B8FD90", VA = "0x187B91390")]
	public EKMFLGPEINO(string FEGPDLNJFDD, MFEGJNCJJMB ODFAALAAHIH, [Optional] OutfitType? MGGNIGMCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7B912E0", Offset = "0x7B8FCE0", VA = "0x187B912E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7B91220", Offset = "0x7B8FC20", VA = "0x187B91220")]
	public bool HDGGDDKGMOL(EKMFLGPEINO NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7B91100", Offset = "0x7B8FB00", VA = "0x187B91100", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B911B0", Offset = "0x7B8FBB0", VA = "0x187B911B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct CNCHKGJDNGP : IEquatable<CNCHKGJDNGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public readonly MFEGJNCJJMB MHEIBDEBCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public readonly OutfitType? JFBFFLGJGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public readonly int NHCOMFANHKG;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7B90C10", Offset = "0x7B8F610", VA = "0x187B90C10")]
	public CNCHKGJDNGP(MFEGJNCJJMB ODFAALAAHIH, int LEDKIGHJKCM, [Optional] OutfitType? GIGNEPNLDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B90B40", Offset = "0x7B8F540", VA = "0x187B90B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4CF0", Offset = "0x6DB36F0", VA = "0x186DB4CF0")]
	public bool EJNDGEMCCCI(MFEGJNCJJMB ODFAALAAHIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7B90930", Offset = "0x7B8F330", VA = "0x187B90930")]
	public bool CAAKILFPDBC(OutfitType? GIGNEPNLDLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7B90AA0", Offset = "0x7B8F4A0", VA = "0x187B90AA0", Slot = "4")]
	public bool Equals(CNCHKGJDNGP NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B909B0", Offset = "0x7B8F3B0", VA = "0x187B909B0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7B90AF0", Offset = "0x7B8F4F0", VA = "0x187B90AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct ALMKEGEIDJL : IEquatable<ALMKEGEIDJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public readonly Transform IOAKMONDLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public readonly bool GHFNOADPEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public readonly MFEGJNCJJMB NIMCPCMDKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public readonly OutfitType? JAMPLHICMEJ;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A6D0", Offset = "0x7B890D0", VA = "0x187B8A6D0")]
	public ALMKEGEIDJL(Transform KPMKNCPNCKG, bool GLCEDJAGEGM, MFEGJNCJJMB CNNMPMJBHKM, [Optional] OutfitType? BHFMNDPNMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A4B0", Offset = "0x7B88EB0", VA = "0x187B8A4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A250", Offset = "0x7B88C50", VA = "0x187B8A250", Slot = "4")]
	public bool Equals(ALMKEGEIDJL NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A350", Offset = "0x7B88D50", VA = "0x187B8A350", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A430", Offset = "0x7B88E30", VA = "0x187B8A430", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B913D0", Offset = "0x7B8FDD0", VA = "0x187B913D0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface JFHJMHADBJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEFFKJCLJOO(Mesh DLOFNMELGLP, Matrix4x4 CBPOFKNKLDF, byte[] FKNFEDOECAJ, bool MIDPIGILHEL = false, PNNNJKDMBBI.KEKJLMIKOAG IKNMPPOGLDF = (PNNNJKDMBBI.KEKJLMIKOAG)0L, int NDBGCPPBAKM = -1, bool OKCFMHEBLGA = false);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDFNGKDGNEG(Allocator NDKMELBEFLH, DNNCNPOKLAI CFMMKCBMKLL, byte JMDKOOCJJFM, [Optional] IList<int> LJGCICFOFOI, [Optional] IList<int> PGMDGFKFCBE);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct NJLADKEKBGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public readonly GameObject KNGBKGLJPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private readonly AvatarItemMaterial FJFGNKPCIAA;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
	public NJLADKEKBGI(GameObject KNGBKGLJPMJ, AvatarItemMaterial FJFGNKPCIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7B9CFB0", Offset = "0x7B9B9B0", VA = "0x187B9CFB0")]
	public void AGIBLONNIHN(Material NJABANIHMHL, int GHJBHDJCOIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class JEONFEMKBFL : PDKHPAHJCEI<Task<(GameObject, AvatarItemMaterial)>, NJLADKEKBGI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct NIPHBAIFLPC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7B9C990", Offset = "0x7B9B390", VA = "0x187B9C990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CE90", Offset = "0x7B9B890", VA = "0x187B9CE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private ODDHNIEMFCD<GameObject> KOCLOCPNGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private ODDHNIEMFCD<AvatarItemMaterial> MCLBDOHANPN;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7B973F0", Offset = "0x7B95DF0", VA = "0x187B973F0")]
	private JEONFEMKBFL(Task<(GameObject, AvatarItemMaterial)> HAAEKADIBMM, ODDHNIEMFCD<GameObject> NJCJAKBMHID, ODDHNIEMFCD<AvatarItemMaterial> BIHBBLEKDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7B96F60", Offset = "0x7B95960", VA = "0x187B96F60")]
	public static JEONFEMKBFL JEBOFNEMEAN(AssetReference DCLHCBEBGLF, [Optional] AssetReference JDPJHCDCGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7B96D90", Offset = "0x7B95790", VA = "0x187B96D90", Slot = "11")]
	protected override NJLADKEKBGI AFBILIDKDDK(Task<(GameObject, AvatarItemMaterial)> IIBJDKIFLAM)
	{
		return default(NJLADKEKBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7B97370", Offset = "0x7B95D70", VA = "0x187B97370", Slot = "12")]
	protected override void PBKNHAODEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7B96E30", Offset = "0x7B95830", VA = "0x187B96E30")]
	[AsyncStateMachine(typeof(NIPHBAIFLPC))]
	private static Task<(GameObject, AvatarItemMaterial)> HNEDIFNPMID(Task<GameObject> FLHKHGMBJJN, Task<AvatarItemMaterial> NCAMPDNEPKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class DCDOJPIBJBI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class BDDABJFPDGE : PDKHPAHJCEI<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private ODDHNIEMFCD<MaterialMapAsset> GCKDJGKENJL;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D620", Offset = "0x7B8C020", VA = "0x187B8D620")]
		public BDDABJFPDGE(ODDHNIEMFCD<MaterialMapAsset> GCKDJGKENJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D1A0", Offset = "0x7B8BBA0", VA = "0x187B8D1A0", Slot = "11")]
		protected override Material[] AFBILIDKDDK(Task<MaterialMapAsset> HAAEKADIBMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D5C0", Offset = "0x7B8BFC0", VA = "0x187B8D5C0", Slot = "12")]
		protected override void PBKNHAODEBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class ACMKKOEHIOL : PDKHPAHJCEI<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private List<ODDHNIEMFCD<Material>> FMPLMPHMMMJ;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A1E0", Offset = "0x7B88BE0", VA = "0x187B8A1E0")]
		public ACMKKOEHIOL(Task<Material[]> HAAEKADIBMM, List<ODDHNIEMFCD<Material>> FMPLMPHMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A050", Offset = "0x7B88A50", VA = "0x187B8A050", Slot = "11")]
		protected override Material[] AFBILIDKDDK(Task<Material[]> IIBJDKIFLAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A0A0", Offset = "0x7B88AA0", VA = "0x187B8A0A0", Slot = "12")]
		protected override void PBKNHAODEBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7B90C20", Offset = "0x7B8F620", VA = "0x187B90C20")]
	public static ODDHNIEMFCD<Material[]> KJENMKOAOIM(AssetReference[] FCMKPLEPOFG)
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
		public enum BFDEOJEINJL
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
		public enum JBFEEHDIECA
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
		public enum DHFNOBCAEBN : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct MFKDBPJJPNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public readonly Material BOKLPDEMDBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public readonly BFDEOJEINJL FMFCNONHAEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public readonly JBFEEHDIECA COEHKAAGNPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly MFEGJNCJJMB MHEIBDEBCIL;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3DA0", Offset = "0x7BB27A0", VA = "0x187BB3DA0")]
			public MFKDBPJJPNG(Material NJABANIHMHL, BFDEOJEINJL FMOGBAPBKIE, JBFEEHDIECA BIEOJBHHNOM, MFEGJNCJJMB ODFAALAAHIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3B70", Offset = "0x7BB2570", VA = "0x187BB3B70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3AF0", Offset = "0x7BB24F0", VA = "0x187BB3AF0")]
			public bool HDGGDDKGMOL(MFKDBPJJPNG NDNHELJMDCG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3960", Offset = "0x7BB2360", VA = "0x187BB3960", Slot = "0")]
			public override bool Equals(object OJDHMKOBKLD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3A50", Offset = "0x7BB2450", VA = "0x187BB3A50", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class BBOKEGCFKBK : IComparable<BBOKEGCFKBK>, IEquatable<BBOKEGCFKBK>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public int MNLNHHNGCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public PlayerAvatarDisplayBase BKOEAJIGHJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public IList<OBJIFNMAOMP> ANAMHCBIJJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public AvatarItemBodyType EALAOFIECOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public DNOLOOAELOA LPOOHNPDDFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public bool OFEMLHGBKMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public bool NHOIHKKDLOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public int[] PGOFKMBLHNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public float NGNDNJMMICE;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x7BACB60", Offset = "0x7BAB560", VA = "0x187BACB60", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x7BACA10", Offset = "0x7BAB410", VA = "0x187BACA10", Slot = "4")]
			public int CompareTo(BBOKEGCFKBK NDNHELJMDCG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x7BACA40", Offset = "0x7BAB440", VA = "0x187BACA40", Slot = "5")]
			public bool Equals(BBOKEGCFKBK NDNHELJMDCG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public BBOKEGCFKBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class FCNAHPOMKDF
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class DEICLILJOKD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public readonly Mesh CAFAIIEDDKN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public readonly Material[] KMJDHMJMCAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				public readonly Transform[] GNDIDLCPGMO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				public readonly Matrix4x4[] DHGLCCIOKNL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400036E")]
				public readonly Transform IMCGJHIMHAC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400036F")]
				public readonly bool DONFLGCJLMA;

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
				protected DEICLILJOKD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x7BAE490", Offset = "0x7BACE90", VA = "0x187BAE490")]
				public DEICLILJOKD(Mesh DLOFNMELGLP, Material[] CHOPHFDPGEE, bool MCGGDJMMMLD, Transform[] MLDILJLGELN, Transform BMKKJGCCEFI, Matrix4x4[] JNIINCEODCB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x7BAE3D0", Offset = "0x7BACDD0", VA = "0x187BAE3D0")]
				private DEICLILJOKD(SkinnedMeshRenderer JCEEOOAMPHB, Material[] BOMCEAOEMHP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x7BAE2E0", Offset = "0x7BACCE0", VA = "0x187BAE2E0")]
				private DEICLILJOKD(MeshRenderer FCCDEDDHKGJ, Transform BMKKJGCCEFI, Material[] BOMCEAOEMHP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x7BADFB0", Offset = "0x7BAC9B0", VA = "0x187BADFB0")]
				public static DEICLILJOKD FGPGONODOBF(Renderer EDDLIJIPFEO, Material[] BOMCEAOEMHP)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly MFEGJNCJJMB MHEIBDEBCIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public readonly Transform OHHJHAJLOPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public readonly bool KFOFCBMFGGJ;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool MGMOCOEICDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool OLLJIIKLCID
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual PNNNJKDMBBI.KEKJLMIKOAG APLMPPCOIBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "6")]
				get
				{
					return default(PNNNJKDMBBI.KEKJLMIKOAG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool IAFPCBBHCLC
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0x7BAECF0", Offset = "0x7BAD6F0", VA = "0x187BAECF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7BAED00", Offset = "0x7BAD700", VA = "0x187BAED00")]
			protected FCNAHPOMKDF(MFEGJNCJJMB ODFAALAAHIH, Transform FHFHDPJPPPG, bool BLKCCKEPBAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract FDBBAHKKNBB NKDCFBJAMBC(List<MCFGKKFEMKA> CFMJIOONCHE, List<MCFGKKFEMKA> NJPEAJPGBKJ);

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract DEICLILJOKD MHPHHKNJIFE(int GIFLHFGNGDL, PlayerHandBones CJCLANNONCH);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class KONEAIGHFPN : FCNAHPOMKDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly BodyPartLODs AMNODAOGPCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Material[] JECAHAPIPHK;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2AA0", Offset = "0x7BB14A0", VA = "0x187BB2AA0")]
			public KONEAIGHFPN(MFEGJNCJJMB ODFAALAAHIH, BodyPartLODs NPMAAIJAPHG, Material LMEAAJDAGOO, [Optional] Transform FHFHDPJPPPG, bool BLKCCKEPBAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7BB29A0", Offset = "0x7BB13A0", VA = "0x187BB29A0", Slot = "7")]
			public override FDBBAHKKNBB NKDCFBJAMBC(List<MCFGKKFEMKA> CFMJIOONCHE, List<MCFGKKFEMKA> NJPEAJPGBKJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB27E0", Offset = "0x7BB11E0", VA = "0x187BB27E0", Slot = "8")]
			public override DEICLILJOKD MHPHHKNJIFE(int GIFLHFGNGDL, PlayerHandBones CJCLANNONCH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2A30", Offset = "0x7BB1430", VA = "0x187BB2A30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class LOJIDKFPIJK : FCNAHPOMKDF
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool MGMOCOEICDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool OLLJIIKLCID
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x7BB37A0", Offset = "0x7BB21A0", VA = "0x187BB37A0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public AGHAHHACHKN IJLLENFCCAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x7BB38F0", Offset = "0x7BB22F0", VA = "0x187BB38F0")]
			public LOJIDKFPIJK(MFEGJNCJJMB ODFAALAAHIH, Transform FHFHDPJPPPG, AGHAHHACHKN JBOKDPHJHCN, bool BLKCCKEPBAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x7BB37F0", Offset = "0x7BB21F0", VA = "0x187BB37F0", Slot = "7")]
			public override FDBBAHKKNBB NKDCFBJAMBC(List<MCFGKKFEMKA> CFMJIOONCHE, List<MCFGKKFEMKA> NJPEAJPGBKJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "8")]
			public override DEICLILJOKD MHPHHKNJIFE(int GIFLHFGNGDL, PlayerHandBones CJCLANNONCH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3880", Offset = "0x7BB2280", VA = "0x187BB3880", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class BPDMNKCIHFF
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum ADFALKAAPJM
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
			public static readonly int CBGLLPPCBBC;

			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public static readonly int GMJGNGBGKOA;

			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public static readonly int DAJBMALGBHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected readonly AGKKKHJPICC AFFPKPHELBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected readonly NJMEEIICCAM CDJIMAHCKIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected readonly Animator KDCNEMLBOOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected readonly Transform JPGHEANMNAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Vector3 DDINDOJLDEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected readonly Transform NCPEEAFMMFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Vector3 NGJCIEKHFEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected bool OIPBIEAMKOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected JPJMMHEAOFC OPBKOBFACBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected bool MFCFHGAICDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected float JHAIPLFOFCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected KJJOAJGFHIL<FDMGNGIPNID> AFNLJJBBCIC;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public JPJMMHEAOFC CNBNCOCKPCL
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0xA10540", Offset = "0xA0EF40", VA = "0x180A10540")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool GCPMJAAACNA
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xC99F10", Offset = "0xC98910", VA = "0x180C99F10")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x7BACE20", Offset = "0x7BAB820", VA = "0x187BACE20")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool MBFINPHNDHF
			{
				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xA17C20", Offset = "0xA16620", VA = "0x180A17C20")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x7BAD410", Offset = "0x7BABE10", VA = "0x187BAD410")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float EPPCJLFGFCL
			{
				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0xD17B40", Offset = "0xD16540", VA = "0x180D17B40")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x7BAD650", Offset = "0x7BAC050", VA = "0x187BAD650")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public FDMGNGIPNID FOHKGIOHEKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x7BAD3D0", Offset = "0x7BABDD0", VA = "0x187BAD3D0")]
				get
				{
					return default(FDMGNGIPNID);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7BAD200", Offset = "0x7BABC00", VA = "0x187BAD200")]
			public bool KCNDCKNCPHM(FDMGNGIPNID JEDGNEMOJBE, object BECBHDDLOHA, ADFALKAAPJM JILFIKIPHBK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7BAD790", Offset = "0x7BAC190", VA = "0x187BAD790")]
			public bool PPEIFIEJFOD(object BECBHDDLOHA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7BADF20", Offset = "0x7BAC920", VA = "0x187BADF20")]
			protected BPDMNKCIHFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7BAD930", Offset = "0x7BAC330", VA = "0x187BAD930")]
			public BPDMNKCIHFF(AGKKKHJPICC AFFPKPHELBF, JPJMMHEAOFC KHAEHOKJEIJ, Animator KDCNEMLBOOB, Transform JPGHEANMNAK, Transform NCPEEAFMMFM, Vector3 DDINDOJLDEH, Vector3 NGJCIEKHFEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7BAD000", Offset = "0x7BABA00", VA = "0x187BAD000")]
			private void GNFFLFNKFGN(ushort EMHKLDGACOH, ushort AGGBEKFDFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7BAD110", Offset = "0x7BABB10", VA = "0x187BAD110")]
			protected void JMFIKLHCKLF(ushort EMHKLDGACOH, ushort AGGBEKFDFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7BAD310", Offset = "0x7BABD10", VA = "0x187BAD310")]
			protected void LEAHDHCJAEB(ushort EMHKLDGACOH, ushort AGGBEKFDFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7BACCB0", Offset = "0x7BAB6B0", VA = "0x187BACCB0")]
			protected void BNABBACAEJO(ushort EMHKLDGACOH, ushort AGGBEKFDFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7BACEF0", Offset = "0x7BAB8F0", VA = "0x187BACEF0")]
			protected void FHIFBEEIJNO(ushort EMHKLDGACOH, ushort AGGBEKFDFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7BAD0B0", Offset = "0x7BABAB0", VA = "0x187BAD0B0")]
			protected void HEFGMHGBBFK(ushort EMHKLDGACOH, ushort AGGBEKFDFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7BAD4E0", Offset = "0x7BABEE0", VA = "0x187BAD4E0")]
			protected void PBAADMNOAII(ushort EMHKLDGACOH, ushort AGGBEKFDFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7BACDD0", Offset = "0x7BAB7D0", VA = "0x187BACDD0")]
			protected void DBFNMBODFFI(ushort EMHKLDGACOH, ushort AGGBEKFDFDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7BAD530", Offset = "0x7BABF30", VA = "0x187BAD530")]
			protected void PFNJCBBDGIL(ushort EMHKLDGACOH, ushort AGGBEKFDFDM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class GOKCMAHGGIN : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public const int FDNDANIGECF = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected MaterialPropertyBlock LIBOJAFEHKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Color? JEIJMOECMKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Color? HJNHCFPJAKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Color? JMMFAIJEBKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Color ODGOAOJDMLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Color KFFELPHGLNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Color DEIAKLFBGNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public Texture2D MJHEHHHIEIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public Texture2D BCIPMADCAFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected Dictionary<MFKDBPJJPNG, int> GBLJMHHPIEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected BFDEOJEINJL[] ANBJFKBCDEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Vector4[] GBAALDOALLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Vector4[] IMIKFHJAPDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Vector4[] LOPOAGGBNDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Vector4[] HCLHIMNHLOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Vector4[] FIDDPGNCLKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public Vector4[] LCGMOONEFIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected List<Texture2D> IEBGANOJMFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected Vector4[] ILALCLECNDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected List<Texture2D> OEEGNOCHCGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected float[] HLBEMAECKBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected Vector4[] LGEKCKDIPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected float[] OOKOGPBBMJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public float[] JCDAIHFCPKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected List<Texture2D> OCPIGHPPNLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected float[] BBIFJGBPPAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected List<Texture2D> MMCKEAODMNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector4[] MNACFNCKCKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected float[] KMOFDNMCNBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector4[] KFPMGFNFKBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public float[] CCBGGBFPHLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Texture2DArray ODMGDJIIHPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Texture2DArray DLLJGAFHLHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Texture2DArray CKKIMLANLIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Texture2DArray MOMDHLNENGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool IJBPCDKPEPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected int JKHFFEADDLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Vector2? NJHOILAICEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected TextureFormat JGGBINOFPOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector2? HDNAKEKMNGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected TextureFormat JOOGJAGFAEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected Vector2? OEFACPMHOKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected TextureFormat PPJKJOCBKCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected Vector2? NCHIKEAHNFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected TextureFormat LNMBFPHJLDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected bool CDPHAALIFLC;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int NIDLMCKDBFM;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int DLGJIPGCPJH;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int CDCAPNGDJGC;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int MDENMPJEEHL;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int AANBMMCHEAB;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int HOACLKGCKCD;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int HPDNHGGCBEA;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int HJHCCBDCFLL;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int BDFDMOFGMAI;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int FADGJIKBLIB;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected static int OFIGLGFELIN;

			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected static int EMCLONLMNCP;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int CNDHPFLGLIH;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int JIHFIPANGII;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int COENKNNKCHP;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int HCJBKALGFAL;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int JONAAAPCGKE;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int OAEKNMDHEEK;

			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected static int OKNOFLKFPJA;

			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected static int IEBKPCGEAJK;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB1A50", Offset = "0x7BB0450", VA = "0x187BB1A50")]
			protected GOKCMAHGGIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7BB1F10", Offset = "0x7BB0910", VA = "0x187BB1F10")]
			public GOKCMAHGGIN(Color PPCCKOGJPOI, Color CONNMGGHNOB, Color PCFIMBEDALD, Color? OLGAFDAMLHB, Color? KNJFFLHKKKK, Color? CMGHHNOOBFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7BAF700", Offset = "0x7BAE100", VA = "0x187BAF700")]
			public int FDOGDHGDEIF(Material DPDJBJBMPNF, BFDEOJEINJL FMOGBAPBKIE, JBFEEHDIECA BIEOJBHHNOM, MFEGJNCJJMB ODFAALAAHIH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7BAF7F0", Offset = "0x7BAE1F0", VA = "0x187BAF7F0")]
			public int FDOGDHGDEIF(MFKDBPJJPNG KJNEHANBOBO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7BB0400", Offset = "0x7BAEE00", VA = "0x187BB0400")]
			public int JNMOJMOBEBB(Material DPDJBJBMPNF, Color PPNFPJDAMPK, Color HGMKCKGKKCJ, Color OOKCKJBPJLM, Color AOICBHAHJEN, Color FDGCCIBEOPI, Texture2D HFDMOFJOIIO, Vector4 BIDPNKIMODE, Texture2D GINCNDFAELD, Vector4 IELOIDEPGPC, float OFGJDKDMCFF, float NCEEHBIKBNC, Texture2D MAGBHCCODPP, Vector4 IAPOJPCEJIB, float HMIDAGCEPGE, Texture2D OPGIFMPIDAH, float OMOMKDLHODN, Color IGIDJNJGMOK, Vector4 CBLMMDCFBBN, BFDEOJEINJL FMOGBAPBKIE, JBFEEHDIECA BIEOJBHHNOM, MFEGJNCJJMB ODFAALAAHIH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7BB1350", Offset = "0x7BAFD50", VA = "0x187BB1350")]
			protected void NPMHFGCBLKP([Out] Texture2DArray BBDLOFLNHJL, [Out] Texture2DArray FEKOGIKPIJM, [Out] Texture2DArray LKBFEMOCFGG, [Out] Texture2DArray EDDPEPDLMAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7BB10F0", Offset = "0x7BAFAF0", VA = "0x187BB10F0")]
			public void NOLNPKEOFCC(PlayerAvatarDisplayBase NFFHPDEBIHC, Renderer EDDLIJIPFEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x7BAF880", Offset = "0x7BAE280", VA = "0x187BAF880")]
			protected void GCKHAGNEDFI(PlayerAvatarDisplayBase NFFHPDEBIHC, Renderer EDDLIJIPFEO, int MMKEDKNCFBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7BB1510", Offset = "0x7BAFF10", VA = "0x187BB1510")]
			private Color PHCHCKIEPBJ(Color EDDJAGLDPMD, BFDEOJEINJL LIKPIPIHIML)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7BAF570", Offset = "0x7BADF70", VA = "0x187BAF570")]
			private Color APKNHDMBDKC(Color HJDLIGNPJNB, BFDEOJEINJL LIKPIPIHIML)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7BB0370", Offset = "0x7BAED70", VA = "0x187BB0370")]
			protected void JKEHIDFOBMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7BAF6C0", Offset = "0x7BAE0C0", VA = "0x187BAF6C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BBB610", Offset = "0x7BBA010", VA = "0x187BBB610")]
			public void COKMKDPHFJE(MFEGJNCJJMB ODFAALAAHIH, [Out] Transform ALPBGLGCPNB, [Out] Transform[] MLDILJLGELN)
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
		private sealed class EJAJFDHBANJ : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
			[DebuggerHidden]
			public EJAJFDHBANJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x7BAE940", Offset = "0x7BAD340", VA = "0x187BAE940", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x7BAEBC0", Offset = "0x7BAD5C0", VA = "0x187BAEBC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7BAEB10", Offset = "0x7BAD510", VA = "0x187BAEB10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7BAEB10", Offset = "0x7BAD510", VA = "0x187BAEB10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class ENPLOPKEPGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public ENPLOPKEPGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7BAEC10", Offset = "0x7BAD610", VA = "0x187BAEC10")]
			internal bool DNGNKDBACKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class FPMOMCPPMGE : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			private HGOIDBIKHMF <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public FPMOMCPPMGE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7BAED60", Offset = "0x7BAD760", VA = "0x187BAED60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7BAF0A0", Offset = "0x7BADAA0", VA = "0x187BAF0A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct NAJBHKABPKF : IAsyncStateMachine
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
			public HEFJDHOHCHF avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4020", Offset = "0x7BB2A20", VA = "0x187BB4020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7BB43C0", Offset = "0x7BB2DC0", VA = "0x187BB43C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class KIIOBBCJOJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public KIIOBBCJOJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7BB27B0", Offset = "0x7BB11B0", VA = "0x187BB27B0")]
			internal bool NMPLAKBKHKK(OBJIFNMAOMP selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class IGMGAPHJMCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public Func<MPBOGDMHBIL<Dictionary<string, ODDHNIEMFCD<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public IGMGAPHJMCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB20D0", Offset = "0x7BB0AD0", VA = "0x187BB20D0")]
			internal (LIJLGGILNGM, MPBOGDMHBIL<Dictionary<string, ODDHNIEMFCD<Texture2D>>>) OCACMJNAIBM(Dictionary<string, KJOKLAANNCB> avatarItems)
			{
				return default((LIJLGGILNGM, MPBOGDMHBIL<Dictionary<string, ODDHNIEMFCD<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2020", Offset = "0x7BB0A20", VA = "0x187BB2020")]
			internal MPBOGDMHBIL<Dictionary<string, ODDHNIEMFCD<Texture2D>>> GABAJKJOHEE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2090", Offset = "0x7BB0A90", VA = "0x187BB2090")]
			internal void MDFFFMIBAGB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class KACKOOCFNMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public KACKOOCFNMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2700", Offset = "0x7BB1100", VA = "0x187BB2700")]
			internal bool NICNCEDNOKE(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct JBDJJLMGFLN : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x7BB22D0", Offset = "0x7BB0CD0", VA = "0x187BB22D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x7BB24A0", Offset = "0x7BB0EA0", VA = "0x187BB24A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int NGNLALFHKKF;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int MJICLEPAJIH;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int NBDMNOIFDJE;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int NGJLBOGOFBH;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int HJHBCELDGNI;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static readonly int OPLGBBGBGKC;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		protected static readonly int[] OAMFDHKKJNP;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected static readonly int[] AOOPCEDLOGC;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected static readonly int[] GHMHBMJFHIM;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected static readonly int[] FCCABENFFNB;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected static readonly int[] KIMMHNLCKJD;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected static readonly int[] HAOFMJGAOAM;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected static List<PlayerAvatarDisplayBase> PNGJAMIDEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected GHNNHOLHIND AFMOMKPNMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected bool FGPHJJGNGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected bool FBMPCEJMLLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected static readonly int[] MKLOEKIPAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected Dictionary<MFKDBPJJPNG, Material> ADJLABOJMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected Dictionary<MFKDBPJJPNG, Material> AGOCHLIKFBC;

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
		protected Material HNFELKGPECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected LPODLLODNDM JBJCMHMICML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private JPJMMHEAOFC OADIJEGHPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private JPJMMHEAOFC JBPHMNAFEKP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected Material MPEFGKHGOIA;

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
		protected FitMeshHemisphere HFIGPKJCEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool MNNCIEOHMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected EBGNPCDLBGE OGNOJFKDEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected bool OMAOEMAHGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected AnchorParamsRestrictions IANIKJEJPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected bool JLAEHGFILEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected Transform JPFAPNCJPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected bool KHNLHGMFKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected bool KNOBHEGPIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Vector3 FMEPKKGDLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected Quaternion LBEPBFPGPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected Vector2 LLJFEJPHMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected FitMeshHemisphere EEHDIENMBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		[EMFMMKKCPNF(MEAOHOOOBOD.SelfAndChildren, false, false, false)]
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
		protected Collider[] MBCCMHPEIHE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected Collider[] NHMCJFHDEDA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected BPDMNKCIHFF[] LAFFBNEHODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Dictionary<Renderer, GOKCMAHGGIN> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Dictionary<Renderer, GOKCMAHGGIN> GDGGPMNAEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected LJPEOJMKLGF DPPCLKDGBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected LIJLGGILNGM MHLAMFCNKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public AMDCJLIPDMO DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected int ELMJJCJDIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected (bool isLodForced, int forcedLOD) ILCDDGDDGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected KJJOAJGFHIL<NJMEEIICCAM> AFNLJJBBCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected bool HJBLFMNKHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected Dictionary<OBJIFNMAOMP, List<MFKDBPJJPNG>> NNPMIEAMDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Dictionary<OBJIFNMAOMP, List<MFKDBPJJPNG>> OIFBIIMLLLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected readonly Dictionary<string, ODDHNIEMFCD<Texture2D>> LLHGJJIOEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected readonly Dictionary<string, ODDHNIEMFCD<Texture2D>> AIAAPGIIBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected bool MFAAIHGDJFB;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected static int ABJICOGHALJ;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected static List<BBOKEGCFKBK> LCONHGDOONF;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected static List<BBOKEGCFKBK> DMMJJKPOMNI;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected static IDJIHHOMEIC NMEABHFJDIL;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected static Func<List<BBOKEGCFKBK>, BBOKEGCFKBK> FPMAFBFGION;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected static bool FKFMLMNMAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color? KOGHGKDFCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected bool IDLGHDDLJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected Color MMFODODFFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected Color KLIEACALCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color HHJLBBGBHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected AvatarHairPattern MFBNKJPKNIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected AGHAHHACHKN HCFCNMNAAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Color GKLDKJICMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color MGNIBCBCAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected AvatarHairPattern FPIMKINNNEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected AGHAHHACHKN DNOIJAMCGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected AGHAHHACHKN PINNDCBJMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Color LMCCFEONNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private AdditionalFeetData AGPFGNPBCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected OBJIFNMAOMP? EPMLIDEOEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected Texture GKMDAJNFFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected Color AGJGMMLLMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected readonly IList<OBJIFNMAOMP> GKMKHNIICPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected readonly IList<OBJIFNMAOMP> AIOJNHIEGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private AvatarItemBodyType LINDODBFLOG;

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
		protected IHBNBAEKKJN _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected DHFNOBCAEBN KMLEMDHALML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected int[] EDCPHJCHILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected bool LPAKNGFBMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected int[] OFGFDJKFPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected bool IPFBJFLLLEB;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private static readonly PNNNJKDMBBI.KEKJLMIKOAG KBDIFNPNCLE;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly PNNNJKDMBBI.KEKJLMIKOAG AILCMONFPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected bool AHLFDPPCAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		protected BBNCMLFOPPH AJCEFMKMHOD;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string AHEHILAJDGH
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool PKCNPKDDDPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xC930E0", Offset = "0xC91AE0", VA = "0x180C930E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xC92820", Offset = "0xC91220", VA = "0x180C92820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool ODKIFHDEFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool AHHNPHJAOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB410", Offset = "0x7BA9E10", VA = "0x187BAB410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool PLKCBPLGPNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool JEHINODLEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool OJHGPCJNFMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool BDOBLOHNFLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public LPODLLODNDM HAFHNEJIAMN
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB2C1A0", Offset = "0xB2ABA0", VA = "0x180B2C1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x7BABBE0", Offset = "0x7BAA5E0", VA = "0x187BABBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public JPJMMHEAOFC HKEPIPBLCGO
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xB302E0", Offset = "0xB2ECE0", VA = "0x180B302E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7BABFE0", Offset = "0x7BAA9E0", VA = "0x187BABFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public JPJMMHEAOFC LGBOIAIIFND
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB48D10", Offset = "0xB47710", VA = "0x180B48D10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7BAC2B0", Offset = "0x7BAACB0", VA = "0x187BAC2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material JOFGJEGECFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7BA1C70", Offset = "0x7BA0670", VA = "0x187BA1C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material KMBPHLCEENH
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7BA6120", Offset = "0x7BA4B20", VA = "0x187BA6120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool HDIKKHOPNLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2342CB0", Offset = "0x23416B0", VA = "0x182342CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase IDIKIDFHHKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xB48F10", Offset = "0xB47910", VA = "0x180B48F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public BPDMNKCIHFF[] IEMAIKPPNMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAFA0", Offset = "0x7BA99A0", VA = "0x187BAAFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public BPDMNKCIHFF OPPHPDDMPBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB610", Offset = "0x7BAA010", VA = "0x187BAB610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public BPDMNKCIHFF DPJBCFHOBHO
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB650", Offset = "0x7BAA050", VA = "0x187BAB650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh IHFOIPACPEF
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xB49660", Offset = "0xB48060", VA = "0x180B49660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected LJPEOJMKLGF NGGECOKDCAN
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7BA38A0", Offset = "0x7BA22A0", VA = "0x187BA38A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected LIJLGGILNGM NEHLIOLHGFI
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xB499F0", Offset = "0xB483F0", VA = "0x180B499F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2AA0", Offset = "0x7BA14A0", VA = "0x187BA2AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool HMFOCDBNNFA
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool AMDHLOBAHDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB600", Offset = "0x7BAA000", VA = "0x187BAB600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int PMNEGONJGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB640", Offset = "0x7BAA040", VA = "0x187BAB640")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7BAC1F0", Offset = "0x7BAABF0", VA = "0x187BAC1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int AAFEGLHLFNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7BABF30", Offset = "0x7BAA930", VA = "0x187BABF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool LNOILPAKAKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] OIKKGGDPEJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7B9F7F0", Offset = "0x7B9E1F0", VA = "0x187B9F7F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool BOGBPLOOAIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7BA33B0", Offset = "0x7BA1DB0", VA = "0x187BA33B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool KJJPPOEPCCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool HJEALEDJHJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x2725C70", Offset = "0x2724670", VA = "0x182725C70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x7BAC4C0", Offset = "0x7BAAEC0", VA = "0x187BAC4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> KICCBPPOADI
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAE20", Offset = "0x7BA9820", VA = "0x187BAAE20")]
			[IteratorStateMachine(typeof(EJAJFDHBANJ))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool ANNFNILDKLH
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB5F0", Offset = "0x7BA9FF0", VA = "0x187BAB5F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x7BA5840", Offset = "0x7BA4240", VA = "0x187BA5840")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public DOOHILAACHK FCKFJDMMJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAEA0", Offset = "0x7BA98A0", VA = "0x187BAAEA0")]
			get
			{
				return default(DOOHILAACHK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool PKJKIBDLKPO
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB340", Offset = "0x7BA9D40", VA = "0x187BAB340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static IDJIHHOMEIC MEMFDLKEJPO
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x7BA0710", Offset = "0x7B9F110", VA = "0x187BA0710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x7BA5CB0", Offset = "0x7BA46B0", VA = "0x187BA5CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color HJNHCFPJAKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7BA5FA0", Offset = "0x7BA49A0", VA = "0x187BA5FA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color JMMFAIJEBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2F40", Offset = "0x7BA1940", VA = "0x187BA2F40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D KBGJLEEGFGI
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x7BA37B0", Offset = "0x7BA21B0", VA = "0x187BA37B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color ODGOAOJDMLK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAF50", Offset = "0x7BA9950", VA = "0x187BAAF50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color KFFELPHGLNO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7B9D8E0", Offset = "0x7B9C2E0", VA = "0x187B9D8E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public AGHAHHACHKN LFFIDELKABP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAF10", Offset = "0x7BA9910", VA = "0x187BAAF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D EKKJCOALCCB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B9E130", Offset = "0x7B9CB30", VA = "0x187B9E130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float NODHLNFDNGL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAF30", Offset = "0x7BA9930", VA = "0x187BAAF30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float JPBOLFICGMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB3F0", Offset = "0x7BA9DF0", VA = "0x187BAB3F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool MPFIGPPAEEF
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAF00", Offset = "0x7BA9900", VA = "0x187BAAF00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB9C0", Offset = "0x7BAA3C0", VA = "0x187BAB9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KAHHHJOCIGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAB80", Offset = "0x7BA9580", VA = "0x187BAAB80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB720", Offset = "0x7BAA120", VA = "0x187BAB720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action LPPANAJIFEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAAE0", Offset = "0x7BA94E0", VA = "0x187BAAAE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB680", Offset = "0x7BAA080", VA = "0x187BAB680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action JEMLBJBCICO
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAC20", Offset = "0x7BA9620", VA = "0x187BAAC20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB7C0", Offset = "0x7BAA1C0", VA = "0x187BAB7C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action LMPHKEFBLNG
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7BAACC0", Offset = "0x7BA96C0", VA = "0x187BAACC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB860", Offset = "0x7BAA260", VA = "0x187BAB860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<AGKKKHJPICC, FDMGNGIPNID> GOOAOBKEGKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAD60", Offset = "0x7BA9760", VA = "0x187BAAD60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB900", Offset = "0x7BAA300", VA = "0x187BAB900")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7410", Offset = "0x7BA5E10", VA = "0x187BA7410")]
		public bool SetDeformation(bool FGPHJJGNGKJ, bool FBMPCEJMLLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3650", Offset = "0x7BA2050", VA = "0x187BA3650")]
		protected static Material HCHHGIOBKDN(Dictionary<MFKDBPJJPNG, Material> KILDONHPMFN, Material BOINKEIDMGM, BFDEOJEINJL FMOGBAPBKIE, JBFEEHDIECA BIEOJBHHNOM, MFEGJNCJJMB ODFAALAAHIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7BA27C0", Offset = "0x7BA11C0", VA = "0x187BA27C0")]
		protected void FAHFOONLLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3430", Offset = "0x7BA1E30", VA = "0x187BA3430")]
		protected bool HCHAMBJKHJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0810", Offset = "0x7B9F210", VA = "0x187BA0810")]
		protected void DHINNGKKAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4240", Offset = "0x7BA2C40", VA = "0x187BA4240", Slot = "11")]
		protected virtual void IHOFLMGAAAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5AB0", Offset = "0x7BA44B0", VA = "0x187BA5AB0")]
		public int MeshesAtLODCount(int KLLJKMFOGFJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2C80", Offset = "0x7BA1680", VA = "0x187BA2C80")]
		protected static void GCBEAEMJCFM(Dictionary<OBJIFNMAOMP, List<MFKDBPJJPNG>> ICFOMKCGHDA, FCNAHPOMKDF AEGAJMAEJHH, Material BOINKEIDMGM, BFDEOJEINJL LIKPIPIHIML, JBFEEHDIECA FKNDFFHPDJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EAF0", Offset = "0x7B9D4F0", VA = "0x187B9EAF0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4AA0", Offset = "0x7BA34A0", VA = "0x187BA4AA0")]
		protected void JPLEFKIKCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6410", Offset = "0x7BA4E10", VA = "0x187BA6410")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "12")]
		protected virtual void DOJHHPMDOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5B70", Offset = "0x7BA4570", VA = "0x187BA5B70")]
		protected static void NAALKALJLFP(List<Material> CMIJIEDGADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B90", Offset = "0x7BA2590", VA = "0x187BA3B90")]
		protected static void HMLEHAEGMIP(Dictionary<MFKDBPJJPNG, Material> KILDONHPMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7BA42A0", Offset = "0x7BA2CA0", VA = "0x187BA42A0")]
		protected static void IOCEPMCKMGG(Dictionary<Renderer, GOKCMAHGGIN> DOBHACKHKHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7BA66C0", Offset = "0x7BA50C0", VA = "0x187BA66C0")]
		protected void PFDBFAAFNCF(SkinnedMeshRenderer[] PAEBPJCHGPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3140", Offset = "0x7BA1B40", VA = "0x187BA3140")]
		protected void GKLPDGHBOEC(SkinnedMeshRenderer JCEEOOAMPHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA31E0", Offset = "0x7BA1BE0", VA = "0x187BA31E0")]
		protected void GKLPDGHBOEC(MeshRenderer FCCDEDDHKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5340", Offset = "0x7BA3D40", VA = "0x187BA5340")]
		protected void LBHKJELFDLC(List<MCFGKKFEMKA> IFALBLPACDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5930", Offset = "0x7BA4330", VA = "0x187BA5930")]
		protected void MICCABNPFMF(Dictionary<string, ODDHNIEMFCD<Texture2D>> ICFOMKCGHDA, bool EMEAJPKDIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA51F0", Offset = "0x7BA3BF0", VA = "0x187BA51F0")]
		protected void KHEAOKAKHDP(Dictionary<OBJIFNMAOMP, List<MFKDBPJJPNG>> ICFOMKCGHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA32B0", Offset = "0x7BA1CB0", VA = "0x187BA32B0")]
		public float GetHandOpenClosedAxis(AGKKKHJPICC AFFPKPHELBF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7CA0", Offset = "0x7BA66A0", VA = "0x187BA7CA0")]
		public void SetHandOpenClosedAxis(AGKKKHJPICC AFFPKPHELBF, float EKJJKOCPJLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7BA32F0", Offset = "0x7BA1CF0", VA = "0x187BA32F0")]
		public FDMGNGIPNID GetHandVisualState(AGKKKHJPICC AFFPKPHELBF)
		{
			return default(FDMGNGIPNID);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E230", Offset = "0x7B9CC30", VA = "0x187B9E230")]
		public bool AddHandVisualStateToken(AGKKKHJPICC AFFPKPHELBF, FDMGNGIPNID NDHCMGJFDGC, object BECBHDDLOHA, BPDMNKCIHFF.ADFALKAAPJM JILFIKIPHBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9500", Offset = "0x7BA7F00", VA = "0x187BA9500")]
		public void SetWatchHand(AGKKKHJPICC AFFPKPHELBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7BA95C0", Offset = "0x7BA7FC0", VA = "0x187BA95C0")]
		public void SetWatchHands(bool EPDIOCPMEDA, bool ACOONIKGABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6AD0", Offset = "0x7BA54D0", VA = "0x187BA6AD0")]
		public bool RemoveHandVisualStateToken(AGKKKHJPICC AFFPKPHELBF, object BECBHDDLOHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3370", Offset = "0x7BA1D70", VA = "0x187BA3370")]
		public bool GetThumbsUpActive(AGKKKHJPICC AFFPKPHELBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8F20", Offset = "0x7BA7920", VA = "0x187BA8F20")]
		public void SetThumbsUpActive(AGKKKHJPICC AFFPKPHELBF, bool EOJPBHKGKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3330", Offset = "0x7BA1D30", VA = "0x187BA3330")]
		public bool GetHandshakeActive(AGKKKHJPICC AFFPKPHELBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7CF0", Offset = "0x7BA66F0", VA = "0x187BA7CF0")]
		public void SetHandshakeActive(AGKKKHJPICC AFFPKPHELBF, bool HGDLPODDDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2C00", Offset = "0x7BA1600", VA = "0x187BA2C00")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA93F0", Offset = "0x7BA7DF0", VA = "0x187BA93F0")]
		public void SetUseClassicBeanHandScale(bool PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FE80", Offset = "0x7B9E880", VA = "0x187B9FE80")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5FF0", Offset = "0x7BA49F0", VA = "0x187BA5FF0")]
		private static void OOHMHKCMOOM(Scene JGPHIOPNBKA, LoadSceneMode KMALIDMGEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7BA26C0", Offset = "0x7BA10C0", VA = "0x187BA26C0")]
		protected static void ENEJEPHDNAE(PlayerAvatarDisplayBase JOMCENIBJFL, List<BBOKEGCFKBK> DCIHHIBDBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7BA67E0", Offset = "0x7BA51E0", VA = "0x187BA67E0")]
		public FDBBAHKKNBB Rebuild(bool FNBCMEALHPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F5C0", Offset = "0x7B9DFC0", VA = "0x187B9F5C0")]
		protected FDBBAHKKNBB CHKFHLIHHDP(bool FNBCMEALHPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F620", Offset = "0x7B9E020", VA = "0x187B9F620", Slot = "13")]
		protected virtual FDBBAHKKNBB CHKFHLIHHDP(IList<OBJIFNMAOMP> FOOMBBNJBJD, AvatarItemBodyType IMPGDHDOGGO, bool OJGLHJECAGF, bool DLGOJOIKGLA, int[] BDNMIJEKPFK, bool FNBCMEALHPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D930", Offset = "0x7B9C330", VA = "0x187B9D930")]
		protected static FDBBAHKKNBB ABMIDAIEDKH(BBOKEGCFKBK CGNMEBIJICI, List<BBOKEGCFKBK> DCIHHIBDBJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7BA57E0", Offset = "0x7BA41E0", VA = "0x187BA57E0")]
		[IteratorStateMachine(typeof(FPMOMCPPMGE))]
		protected static IEnumerator<HGOIDBIKHMF> LIHJPIKFDBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5E70", Offset = "0x7BA4870", VA = "0x187BA5E70")]
		protected static BBOKEGCFKBK NINIJPHKFLH(List<BBOKEGCFKBK> DCIHHIBDBJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7510", Offset = "0x7BA5F10", VA = "0x187BA7510")]
		[AsyncStateMachine(typeof(NAJBHKABPKF))]
		public Task SetFaceCustomizationSettings(HEFJDHOHCHF EJPDJBEBHDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9720", Offset = "0x7BA8120", VA = "0x187BA9720")]
		public bool UpdateFaceAndBodyCustomizationSettings(HEFJDHOHCHF EJPDJBEBHDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4450", Offset = "0x7BA2E50", VA = "0x187BA4450")]
		public void InitializeFaceFeatures(AvatarConfiguration KDOLPPIHLLP, DOOHILAACHK IOBACPOPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8C80", Offset = "0x7BA7680", VA = "0x187BA8C80")]
		public void SetTeamColors(Color? CMGHHNOOBFJ, bool NFJMFPOBEBN, Color DIEFHAMMBDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x13DA4F0", Offset = "0x13D8EF0", VA = "0x1813DA4F0")]
		private static void BAHLELNIBMM(Material NJABANIHMHL, Color PCDAHJCDHHF, params int[] OMCNMDJKKEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x13DAD50", Offset = "0x13D9750", VA = "0x1813DAD50")]
		private static void FJLKFJHFFMM(Material NJABANIHMHL, Texture PCDAHJCDHHF, params int[] OMCNMDJKKEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA38C0", Offset = "0x7BA22C0", VA = "0x187BA38C0")]
		protected void HIBCLPEOFND(Material OMADNODHBAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4120", Offset = "0x7BA2B20", VA = "0x187BA4120")]
		protected void IGDFEKDOADA(Material OMADNODHBAD, Color MOFDJMGJMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7B9ECD0", Offset = "0x7B9D6D0", VA = "0x187B9ECD0")]
		protected void BBNDLOFOJFC(Material OMADNODHBAD, Color MOFDJMGJMJK, Color GJHKDLBDBKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0500", Offset = "0x7B9EF00", VA = "0x187BA0500")]
		protected void DFINEIEGLNO(Material OMADNODHBAD, Texture2D AELHKEIFLFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0AA0", Offset = "0x7B9F4A0", VA = "0x187BA0AA0")]
		protected void DNBOLIPABIL(Material OMADNODHBAD, Texture OBMCBLPNLEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DFD0", Offset = "0x7B9C9D0", VA = "0x187B9DFD0")]
		protected void AGAJNFCGAMD(Action<GOKCMAHGGIN> KAMIKADMODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7BA23A0", Offset = "0x7BA0DA0", VA = "0x187BA23A0")]
		protected void EHLNIHIJKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F0F0", Offset = "0x7B9DAF0", VA = "0x187B9F0F0")]
		protected void CDAJAHJBBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4DD0", Offset = "0x7BA37D0", VA = "0x187BA4DD0")]
		protected void KEGJKHDBCPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E580", Offset = "0x7B9CF80", VA = "0x187B9E580")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6E90", Offset = "0x7BA5890", VA = "0x187BA6E90")]
		public void SetBeardPrimaryColor([Optional] Color? OEMAOANNLBK, bool NPEJKCDINMK = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA70B0", Offset = "0x7BA5AB0", VA = "0x187BA70B0")]
		public void SetBeardSecondaryColor([Optional] Color? OEMAOANNLBK, bool NPEJKCDINMK = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6D50", Offset = "0x7BA5750", VA = "0x187BA6D50")]
		public void SetBeardPattern([Optional] AvatarHairPattern JOAJLBMCLKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EF80", Offset = "0x7B9D980", VA = "0x187B9EF80")]
		private void BFOHGOJFLMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0760", Offset = "0x7B9F160", VA = "0x187BA0760")]
		private bool DGOKONLBMLI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7880", Offset = "0x7BA6280", VA = "0x187BA7880")]
		public void SetHairPrimaryColor([Optional] Color? ONJGEBMJKDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7A90", Offset = "0x7BA6490", VA = "0x187BA7A90")]
		public void SetHairSecondaryColor([Optional] Color? ONJGEBMJKDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7750", Offset = "0x7BA6150", VA = "0x187BA7750")]
		public void SetHairPattern([Optional] AvatarHairPattern JOAJLBMCLKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6970", Offset = "0x7BA5370", VA = "0x187BA6970")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4850", Offset = "0x7BA3250", VA = "0x187BA4850")]
		private bool JHLMPKGOEHN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8AC0", Offset = "0x7BA74C0", VA = "0x187BA8AC0")]
		public void SetSkinColor(Color PPCCKOGJPOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8F70", Offset = "0x7BA7970", VA = "0x187BA8F70")]
		public void SetUgcItemVisualOverrides(OBJIFNMAOMP CJIMBICMMNF, DOOHILAACHK IOBACPOPLDF, Texture HDPEIPNKNON, Color IMHJGEDBILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FF50", Offset = "0x7B9E950", VA = "0x187B9FF50")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7610", Offset = "0x7BA6010", VA = "0x187BA7610")]
		public bool SetFaceShape(AvatarFaceShape PPGKHPIGOIL, bool DHGNECFLCMJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0BB0", Offset = "0x7B9F5B0", VA = "0x187BA0BB0")]
		private void DPAHCMNHIED(LBHHPCALKIB MEGIFAHPIOO, float PCDAHJCDHHF, bool EPMPFCFEOGD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BA08A0", Offset = "0x7B9F2A0", VA = "0x187BA08A0")]
		private void DJEOAFIOCKK(PHFDDCKICIJ FCLKLHKIDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F750", Offset = "0x7B9E150", VA = "0x187B9F750")]
		private void CIPPMCKMPID(NKGKAKKIKNK EKAFLDGJIMD, float PCDAHJCDHHF, bool DMDDJEDEJAE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3010", Offset = "0x7BA1A10", VA = "0x187BA3010")]
		private void GJGBABNIBBA(DDEGJILJGIO FNBIOFOOBCD, float PCDAHJCDHHF, bool MAOEMDPCMDN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3D30", Offset = "0x7BA2730", VA = "0x187BA3D30")]
		private void HPHJGLJFPDO(FOJCKCBNAEO LDFGFBMKNEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F2B0", Offset = "0x7B9DCB0", VA = "0x187B9F2B0")]
		private void CFHABMCODDE(NHJEEGEOJDG BPPIPPMDDMK, float LJNKAMENPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA72D0", Offset = "0x7BA5CD0", VA = "0x187BA72D0")]
		public bool SetBodyShape(AvatarBodyShape AHGGMDFNGHH, bool DHGNECFLCMJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8950", Offset = "0x7BA7350", VA = "0x187BA8950")]
		public bool SetNoseType(IHBNBAEKKJN EDFNBFFGBEM, bool DHGNECFLCMJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9E00", Offset = "0x7BA8800", VA = "0x187BA9E00")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8930", Offset = "0x7BA7330", VA = "0x187BA8930")]
		public bool SetHideEars(bool FKLADOOKHMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8920", Offset = "0x7BA7320", VA = "0x187BA8920")]
		public bool SetHelmetHair(GHNNHOLHIND EBOEELAGNDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7D40", Offset = "0x7BA6740", VA = "0x187BA7D40")]
		public void SetHatAnchorParameters(EBGNPCDLBGE FKDCEOOEHFO, bool LMOCOGPBKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9690", Offset = "0x7BA8090", VA = "0x187BA9690")]
		public void SetupDisplayLODs(DHFNOBCAEBN EIKBNDKENMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BA28F0", Offset = "0x7BA12F0", VA = "0x187BA28F0")]
		protected int[] FIAMHIPMFHD(DHFNOBCAEBN EIKBNDKENMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8A80", Offset = "0x7BA7480", VA = "0x187BA8A80")]
		public void SetOutfitSelections(IList<OBJIFNMAOMP> FOOMBBNJBJD, AvatarItemBodyType IMPGDHDOGGO, bool DLGOJOIKGLA, bool FNBCMEALHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8A30", Offset = "0x7BA7430", VA = "0x187BA8A30")]
		public void SetOutfitSelections(IList<OBJIFNMAOMP> FOOMBBNJBJD, AvatarItemBodyType IMPGDHDOGGO, bool OJGLHJECAGF, bool DLGOJOIKGLA, bool FNBCMEALHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BA89F0", Offset = "0x7BA73F0", VA = "0x187BA89F0")]
		public FDBBAHKKNBB SetOutfitSelections(IList<OBJIFNMAOMP> FOOMBBNJBJD, AvatarItemBodyType IMPGDHDOGGO, DHFNOBCAEBN EIKBNDKENMI, bool OJGLHJECAGF, bool DLGOJOIKGLA, bool DHGNECFLCMJ = false, bool FNBCMEALHPJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4530", Offset = "0x7BA2F30", VA = "0x187BA4530", Slot = "14")]
		protected virtual FDBBAHKKNBB JBMIIONACHN(IList<OBJIFNMAOMP> FOOMBBNJBJD, AvatarItemBodyType IMPGDHDOGGO, bool OJGLHJECAGF, bool DLGOJOIKGLA, DHFNOBCAEBN EIKBNDKENMI, bool DHGNECFLCMJ, bool FNBCMEALHPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5240", Offset = "0x7BA3C40", VA = "0x187BA5240")]
		protected int[] KIBPFDLHNJF(DHFNOBCAEBN EIKBNDKENMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "15")]
		protected virtual LIJLGGILNGM DKMHELKKGCJ(AvatarItemBodyType CINPLABALEE, Dictionary<string, KJOKLAANNCB> MADNDPHKNPN, Dictionary<string, ODDHNIEMFCD<Texture2D>> FCODDICKBPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5510", Offset = "0x7BA3F10", VA = "0x187BA5510", Slot = "16")]
		protected virtual FDBBAHKKNBB LGLIMDDGLJN(IList<OBJIFNMAOMP> FOOMBBNJBJD, AvatarItemBodyType IMPGDHDOGGO, bool OJGLHJECAGF, bool DLGOJOIKGLA, int[] PGOFKMBLHNK, DNOLOOAELOA KKFLGFGIOJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1EB0", Offset = "0x7BA08B0", VA = "0x187BA1EB0", Slot = "17")]
		protected virtual KJOKLAANNCB EHFLMDKJBMN(AGHAHHACHKN JBOKDPHJHCN, AvatarItemBodyType CINPLABALEE, MFEGJNCJJMB ODFAALAAHIH, KJOKLAANNCB ADHAJNGDHEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "18")]
		protected virtual KJOKLAANNCB MBJFPFNCPJM(AvatarItemBodyType CINPLABALEE, MFEGJNCJJMB ODFAALAAHIH, KDDBOMMNAEG MKNDHMJOBPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA47B0", Offset = "0x7BA31B0", VA = "0x187BA47B0")]
		protected void JCHIJDDNHKE(NCIDAGHDIGG ILNODJJBMKB, PNNNJKDMBBI.KEKJLMIKOAG NGCPFLNMJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2F90", Offset = "0x7BA1990", VA = "0x187BA2F90")]
		protected void GEGMKFBFLOP(NCIDAGHDIGG ILNODJJBMKB, PNNNJKDMBBI.KEKJLMIKOAG NGCPFLNMJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA75B80", Offset = "0xA74580", VA = "0x180A75B80", Slot = "19")]
		protected virtual NCIDAGHDIGG MHOODDMFHGE(NCIDAGHDIGG ILNODJJBMKB, HelmetHairStyle HDGCEDCKGFM, bool LDOKBNOJDLB, AvatarItemBodyType IMPGDHDOGGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0C50", Offset = "0x7B9F650", VA = "0x187BA0C50")]
		protected NCIDAGHDIGG EGFHCOEINGI(IList<OBJIFNMAOMP> FOOMBBNJBJD, AvatarItemBodyType GEBBBHNMKMN, bool DLGOJOIKGLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FD60", Offset = "0x7B9E760", VA = "0x187B9FD60")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DF20", Offset = "0x7B9C920", VA = "0x187B9DF20")]
		protected void AFPGOPBFIBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7BA00B0", Offset = "0x7B9EAB0", VA = "0x187BA00B0")]
		protected void DDAHFJHIBGI(Transform BOJLOPPLJON, IEnumerable<SkinnedMeshRenderer> LBIAMHIGKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2B40", Offset = "0x7BA1540", VA = "0x187BA2B40")]
		protected PNNNJKDMBBI.KEKJLMIKOAG FOGOHHNOONI(PNNNJKDMBBI.KEKJLMIKOAG EJAPGIHBEKK, MFEGJNCJJMB FBEHCCDPIAK)
		{
			return default(PNNNJKDMBBI.KEKJLMIKOAG);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BA28E0", Offset = "0x7BA12E0", VA = "0x187BA28E0")]
		protected void FBJLLEFKEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x19075F0", Offset = "0x1905FF0", VA = "0x1819075F0")]
		protected void JLMPIJBGEKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B9FFA0", Offset = "0x7B9E9A0", VA = "0x187B9FFA0")]
		protected void DBBHBILJLMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3EB0", Offset = "0x7BA28B0", VA = "0x187BA3EB0")]
		[AsyncStateMachine(typeof(JBDJJLMGFLN))]
		protected Task IEDOAFJMELL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3F80", Offset = "0x7BA2980", VA = "0x187BA3F80")]
		protected static BFDEOJEINJL IEJCNFFCAAF(FCNAHPOMKDF FCNNCHKGIAA, int BBPCOAOGCBJ)
		{
			return default(BFDEOJEINJL);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4910", Offset = "0x7BA3310", VA = "0x187BA4910")]
		protected static JBFEEHDIECA JJIKGNABLGC(FCNAHPOMKDF FCNNCHKGIAA, int BBPCOAOGCBJ)
		{
			return default(JBFEEHDIECA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5850", Offset = "0x7BA4250", VA = "0x187BA5850")]
		protected Transform MALFFKFMJHM(MFEGJNCJJMB ODFAALAAHIH, OutfitType MGGNIGMCOGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6210", Offset = "0x7BA4C10", VA = "0x187BA6210")]
		protected void OPHHJBPJGGP(int GHJBHDJCOIO, Material NJABANIHMHL, FCNAHPOMKDF FCNNCHKGIAA, [Out] Texture2D AJOHMGHJCEO, [Out] Vector4 PMGNEAOCOKL, [Out] Texture2D CEJJMJODCNK, [Out] Texture2D CFCBPKFPNLA, [Out] Texture2D DDKMAIGGELI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F470", Offset = "0x7B9DE70", VA = "0x187B9F470")]
		protected void CHJJOBDGLAI(int GHJBHDJCOIO, Material NJABANIHMHL, FCNAHPOMKDF FCNNCHKGIAA, [Out] Color PPNFPJDAMPK, [Out] Color HGMKCKGKKCJ, [Out] Color OOKCKJBPJLM, [Out] Color AOICBHAHJEN, [Out] Color FDGCCIBEOPI, [Out] Color IGIDJNJGMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E40", Offset = "0x7BA2840", VA = "0x187BA3E40")]
		protected void IAJKKDONDKN(Vector3 ICJIGFAHILA, Quaternion ACEAKNBEHCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA82D0", Offset = "0x7BA6CD0", VA = "0x187BA82D0")]
		public void SetHatAnchorParameters(EBGNPCDLBGE FKDCEOOEHFO, AnchorParamsRestrictions GLPJMNHKKOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F880", Offset = "0x7B9E280", VA = "0x187B9F880")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere HFIGPKJCEID, Transform JPFAPNCJPFH, EBGNPCDLBGE FKDCEOOEHFO, AnchorParamsRestrictions IANIKJEJPHL, [Out] Vector3 ANDPKFCEGDK, [Out] Quaternion MCCAAFGCCDD, [Out] EBGNPCDLBGE PKJGNLDCBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6BE0", Offset = "0x7BA55E0", VA = "0x187BA6BE0")]
		public void ResetHatAnchor(Vector2 GNGMNMHEPGB, Vector3 AKCBONMCJIM, Vector3 IBPCJOIMPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xB25760", Offset = "0xB24160", VA = "0x180B25760")]
		public AOELCACNGBK GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E3B0", Offset = "0x7B9CDB0", VA = "0x187B9E3B0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E4F0", Offset = "0x7B9CEF0", VA = "0x187B9E4F0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E320", Offset = "0x7B9CD20", VA = "0x187B9E320")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BA96C0", Offset = "0x7BA80C0", VA = "0x187BA96C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5130", Offset = "0x7BA3B30", VA = "0x187BA5130")]
		protected void KGMOEGFEMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9480", Offset = "0x7BA7E80", VA = "0x187BA9480")]
		public void SetWaitForUgcTextureLoads(bool IMLPDGIALBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9300", Offset = "0x7BA7D00", VA = "0x187BA9300")]
		public void SetUgcTextureParameters(BBNCMLFOPPH JKGCHKOAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA4E0", Offset = "0x7BA8EE0", VA = "0x187BAA4E0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EEF0", Offset = "0x7B9D8F0", VA = "0x187B9EEF0")]
		[CompilerGenerated]
		private void BFKOAKDFINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2C50", Offset = "0x7BA1650", VA = "0x187BA2C50")]
		[CompilerGenerated]
		private void GBCAHKIMCBA(GOKCMAHGGIN OJHEKKHICIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA58A0", Offset = "0x7BA42A0", VA = "0x187BA58A0")]
		[CompilerGenerated]
		private void MGKAKELCMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DE80", Offset = "0x7B9C880", VA = "0x187B9DE80")]
		[CompilerGenerated]
		private void AEFPEFCOADD(GOKCMAHGGIN OJHEKKHICIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA03E0", Offset = "0x7B9EDE0", VA = "0x187BA03E0")]
		[CompilerGenerated]
		private void DEGCAPKBCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5F00", Offset = "0x7BA4900", VA = "0x187BA5F00")]
		[CompilerGenerated]
		private void ONGMNGGMPGM(GOKCMAHGGIN OJHEKKHICIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7BA30B0", Offset = "0x7BA1AB0", VA = "0x187BA30B0")]
		[CompilerGenerated]
		private void GKEPIJNBFFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4400", Offset = "0x7BA2E00", VA = "0x187BA4400")]
		[CompilerGenerated]
		private void IPGNKMFNBHH(GOKCMAHGGIN OJHEKKHICIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0470", Offset = "0x7B9EE70", VA = "0x187BA0470")]
		[CompilerGenerated]
		private void DEJAFKOENFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B40", Offset = "0x7BA2540", VA = "0x187BA3B40")]
		[CompilerGenerated]
		private void HKFMHLGCAEJ(GOKCMAHGGIN OJHEKKHICIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F3E0", Offset = "0x7B9DDE0", VA = "0x187B9F3E0")]
		[CompilerGenerated]
		private void CGDFLBAJMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4830", Offset = "0x7BA3230", VA = "0x187BA4830")]
		[CompilerGenerated]
		private void JHDGDBMKFLB(GOKCMAHGGIN OJHEKKHICIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA25E0", Offset = "0x7BA0FE0", VA = "0x187BA25E0")]
		[CompilerGenerated]
		internal static bool EJBHIEKLHJH(Transform EJLJAJPEGOD, IEnumerable<SkinnedMeshRenderer> DNBJGMFONDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4A60", Offset = "0x7BA3460", VA = "0x187BA4A60")]
		[CompilerGenerated]
		private void JKGGJMDBPOA(GOKCMAHGGIN OJHEKKHICIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3CF0", Offset = "0x7BA26F0", VA = "0x187BA3CF0")]
		[CompilerGenerated]
		private void HOEANPPGONI(GOKCMAHGGIN OJHEKKHICIA)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, INBJDGLCFFF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct OLGJCHMBEPN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public HEFJDHOHCHF avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4AC0", Offset = "0x7BB34C0", VA = "0x187BB4AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4D50", Offset = "0x7BB3750", VA = "0x187BB4D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct MODDBPPDGCN : IAsyncStateMachine
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
			public DOOHILAACHK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3DE0", Offset = "0x7BB27E0", VA = "0x187BB3DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3FC0", Offset = "0x7BB29C0", VA = "0x187BB3FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct LOFONKFLDCP : IAsyncStateMachine
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
			public DOOHILAACHK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7BB35A0", Offset = "0x7BB1FA0", VA = "0x187BB35A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3740", Offset = "0x7BB2140", VA = "0x187BB3740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct PKFIHHFPAPO : IAsyncStateMachine
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
			public HEFJDHOHCHF avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4DB0", Offset = "0x7BB37B0", VA = "0x187BB4DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4F60", Offset = "0x7BB3960", VA = "0x187BB4F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct LHMCGFHHHIL : IAsyncStateMachine
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
			public DOOHILAACHK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TaskAwaiter<AJCADFJLOFD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3100", Offset = "0x7BB1B00", VA = "0x187BB3100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3540", Offset = "0x7BB1F40", VA = "0x187BB3540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct GFNEFHAFGJK : IAsyncStateMachine
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
			public DOOHILAACHK avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7BAF0F0", Offset = "0x7BADAF0", VA = "0x187BAF0F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x7BAF510", Offset = "0x7BADF10", VA = "0x187BAF510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		protected const float GCMLLHEDOEE = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected const int MIIJNEAEFCN = 5;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int NGDCCIABDPG;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private static readonly int LFHGPPCGGDP;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly int NBHMOBBDJIP;

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
		protected static readonly Dictionary<NPKDCAKGIKA.IJCLFLMNDKI, int> PDMADOPBHBE;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> PMIDGIACCFI;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static readonly int HIBDJIKGILF;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static readonly int PKHAMPCFEBO;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static readonly int DCICDLCAFCE;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static readonly int BIBEKBPHMDO;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static readonly int NALKMMBLFBF;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 AGBIPJACOKD;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 HENIMAIKJFB;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected static Vector2 MMPFFNDJJAE;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected static Vector2 ONOKLHHKBLA;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected static Vector2 OICHGJMOPOF;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static Vector2 NDNEFHDKIAI;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected static Vector2 PGDFHGOCDBE;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static Vector2 MIMFOPCEOCN;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static Vector2 DGCLCAHEKFB;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static Vector2 JEMBMCIAFKJ;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected static Vector2 KLDOFCJNBBK;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected static Vector2 KPCKHOLNHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
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
		private DOOHILAACHK IJIBJALCAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private FaceStyleSet EMDGAJHCLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected const int PACOIEEAEBE = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected int BCLPPEMGBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected int KBIODFCBIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected int FMNNBHMMEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected int MKJCCMBOBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected Vector2 EIPFILOAFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float OJNHCLKDKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected float GINOBGLGONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float PGPPJEBFKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected Vector2 CECJJIAFENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float MPJFNADLLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected float BJJJCPKFJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected float PBEHNDFMELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected Vector2 DDKPPCEGPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected float DGILIICGGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected float KNBEMELPCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected float DBFJPFDGBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected Vector2 ICOIAAPKFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float MGGGABCPCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected float EEFNNPILKIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected float LFJJBMILGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected List<SelectableFaceOption> HMGGHHIDBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected List<SelectableFaceOption> HDLPHJBIMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected List<SelectableFaceOption> NHBDCHNMJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected List<SelectableFaceOption> AILCHCBFPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Coroutine APHFBACEAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected int? IHLINAMFICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected int MIPCMDNAGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected int EPPDJLJAPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected int HCIDHCGNPBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected int NDLKAAKCJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected Sprite JFGCGCBPPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected Sprite HLBFPBLLABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected Sprite ILMLNBFFLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected Sprite BGBECADJKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected bool JGLHAFMAJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected string LHKGKAPKIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected string GJFLNBMAHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected string BBEFPNFBFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected string DGJAKMJBGMN;

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
		protected AvatarConfiguration KDOLPPIHLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		protected AJCADFJLOFD EAJHJICHLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private readonly List<Material> CHCFKDELMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected POHNCHBOIFI FGIAMGFFNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		protected Dictionary<string, int> HPNKNPBCBBF;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet LPOLLPGJOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x7BBB360", Offset = "0x7BB9D60", VA = "0x187BBB360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool JBBKFJFGMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x2463570", Offset = "0x2461F70", VA = "0x182463570", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x253C070", Offset = "0x253AA70", VA = "0x18253C070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool BDGCCNIDNBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool NJIJLOMAOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int HIHDNLFOLAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x7BB61E0", Offset = "0x7BB4BE0", VA = "0x187BB61E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer HHLFFFPOMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool LABFGOIKBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x25443B0", Offset = "0x2542DB0", VA = "0x1825443B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x253E200", Offset = "0x253CC00", VA = "0x18253E200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] NEKDMALGIKI
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool HHCKGHLPGJG
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x7BBB3B0", Offset = "0x7BB9DB0", VA = "0x187BBB3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x7BBB570", Offset = "0x7BB9F70", VA = "0x187BBB570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int HPJINHCAOKG
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB6380", Offset = "0x7BB4D80", VA = "0x187BB6380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int GAANIDLLAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5070", Offset = "0x7BB3A70", VA = "0x187BB5070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float CHPOMJMGKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x7BBB390", Offset = "0x7BB9D90", VA = "0x187BBB390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x7BBB550", Offset = "0x7BB9F50", VA = "0x187BBB550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public HBPKIIMPBKO MDPFEGBEMBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xB49DE0", Offset = "0xB487E0", VA = "0x180B49DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xB71AC0", Offset = "0xB704C0", VA = "0x180B71AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public AJCADFJLOFD FNKPBJFGPEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xAD3C20", Offset = "0xAD2620", VA = "0x180AD3C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x7BBB4D0", Offset = "0x7BB9ED0", VA = "0x187BBB4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption FNOAKNFHPBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xAAE9C0", Offset = "0xAAD3C0", VA = "0x180AAE9C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xB382D0", Offset = "0xB36CD0", VA = "0x180B382D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected POHNCHBOIFI BKFCEADFDGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x7BB8570", Offset = "0x7BB6F70", VA = "0x187BB8570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action IADBEHLKBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7BBB2B0", Offset = "0x7BB9CB0", VA = "0x187BBB2B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7BBB420", Offset = "0x7BB9E20", VA = "0x187BBB420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8040", Offset = "0x7BB6A40", VA = "0x187BB8040")]
		public void LocalPlayEmote(NPKDCAKGIKA.IJCLFLMNDKI IBBFHCFFPCJ, float FAFIPLNCDKA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6DA0", Offset = "0x7BB57A0", VA = "0x187BB6DA0")]
		public bool IsEmotePlaying(NPKDCAKGIKA.IJCLFLMNDKI IBBFHCFFPCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7BB92D0", Offset = "0x7BB7CD0", VA = "0x187BB92D0")]
		public void SetIdleHappy(bool LIDLHPBPJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6520", Offset = "0x7BB4F20", VA = "0x187BB6520")]
		protected void GAPPIFGAJNJ(bool KFKOGPBFKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6EC0", Offset = "0x7BB58C0", VA = "0x187BB6EC0")]
		protected void JDIJKPGMBLP(bool JNHCBCLPBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6310", Offset = "0x7BB4D10", VA = "0x187BB6310")]
		protected void CNHOOALKODO(MFEGJNCJJMB ODFAALAAHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB64B0", Offset = "0x7BB4EB0", VA = "0x187BB64B0")]
		protected void EOIAGJFDKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB89A0", Offset = "0x7BB73A0", VA = "0x187BB89A0")]
		public void PlayExpression(int FEGBPJCJCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB4FC0", Offset = "0x7BB39C0", VA = "0x187BB4FC0")]
		protected void AMDHIBHIIJF(bool LECODNHMBOD, bool FKPGEFPPMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6770", Offset = "0x7BB5170", VA = "0x187BB6770")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType LOANHIAFHDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6890", Offset = "0x7BB5290", VA = "0x187BB6890")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration KDOLPPIHLLP, DOOHILAACHK IOBACPOPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7BB90A0", Offset = "0x7BB7AA0", VA = "0x187BB90A0")]
		[AsyncStateMachine(typeof(OLGJCHMBEPN))]
		public Task SetFaceSettings(HEFJDHOHCHF EJPDJBEBHDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8F70", Offset = "0x7BB7970", VA = "0x187BB8F70")]
		[AsyncStateMachine(typeof(MODDBPPDGCN))]
		public Task SetFaceSettings(int HDGDEENJNNP, int AJAHHGANJNG, int HMPGFMFDFHG, int AAHKIEJDAKF, DOOHILAACHK IOBACPOPLDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9350", Offset = "0x7BB7D50", VA = "0x187BB9350")]
		[AsyncStateMachine(typeof(LOFONKFLDCP))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType LOANHIAFHDB, int BLMPPGFJCND, DOOHILAACHK IOBACPOPLDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7BB7760", Offset = "0x7BB6160", VA = "0x187BB7760")]
		protected void LKCBIJOHOKO(FaceFeatureType LOANHIAFHDB, MPLHHHEEMJC JMCENMINCMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7BB78E0", Offset = "0x7BB62E0", VA = "0x187BB78E0")]
		protected void LNCGEEENBDK(FaceFeatureType LOANHIAFHDB, int BLMPPGFJCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7BB65A0", Offset = "0x7BB4FA0", VA = "0x187BB65A0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7BB7020", Offset = "0x7BB5A20", VA = "0x187BB7020")]
		[AsyncStateMachine(typeof(PKFIHHFPAPO))]
		protected Task JMEGFMHDMPI(HEFJDHOHCHF EJPDJBEBHDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7BB5960", Offset = "0x7BB4360", VA = "0x187BB5960")]
		protected void BPHBEBPJBOK(HEFJDHOHCHF EJPDJBEBHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7BB74F0", Offset = "0x7BB5EF0", VA = "0x187BB74F0")]
		protected static void KIAHHDJMDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7BB7290", Offset = "0x7BB5C90", VA = "0x187BB7290")]
		private void KEPGGLPFMFH(bool EELCKEIKLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB5D60", Offset = "0x7BB4760", VA = "0x187BB5D60")]
		protected void CLDIHKICGNI(FaceFeatureType LOANHIAFHDB, Vector2 DFLPIJGNBAJ, DOOHILAACHK IOBACPOPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB89C0", Offset = "0x7BB73C0", VA = "0x187BB89C0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType LOANHIAFHDB, Vector2 PCNFLGPADFK, DOOHILAACHK IOBACPOPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB7110", Offset = "0x7BB5B10", VA = "0x187BB7110")]
		protected void KBLICHJPDMM(FaceFeatureType LOANHIAFHDB, float IMBEPCLHEJK, DOOHILAACHK IOBACPOPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8140", Offset = "0x7BB6B40", VA = "0x187BB8140")]
		protected void NIEIFKHLBCC(FaceFeatureType LOANHIAFHDB, float NGPACIMGGNA, DOOHILAACHK IOBACPOPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB63E0", Offset = "0x7BB4DE0", VA = "0x187BB63E0")]
		protected void EGOCBPNJNCK(FaceFeatureType LOANHIAFHDB, float HGPAFCDNHEI, DOOHILAACHK IOBACPOPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8D50", Offset = "0x7BB7750", VA = "0x187BB8D50")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType LOANHIAFHDB, float ONJHJLBPMEP, DOOHILAACHK IOBACPOPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7BB7680", Offset = "0x7BB6080", VA = "0x187BB7680")]
		[AsyncStateMachine(typeof(LHMCGFHHHIL))]
		protected Task LBFKOHLEBBI(DOOHILAACHK IOBACPOPLDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6B90", Offset = "0x7BB5590", VA = "0x187BB6B90")]
		public void InitializeFaceFeatureStyleSet(DOOHILAACHK IOBACPOPLDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7BB67B0", Offset = "0x7BB51B0", VA = "0x187BB67B0")]
		protected bool HAGAPEAKMLO(string IPCDOFAEDHM, [Out] int MNFHMLCLFEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7BB50D0", Offset = "0x7BB3AD0", VA = "0x187BB50D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9460", Offset = "0x7BB7E60", VA = "0x187BB9460", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB85F0", Offset = "0x7BB6FF0", VA = "0x187BB85F0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7BBA450", Offset = "0x7BB8E50", VA = "0x187BBA450")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB5C60", Offset = "0x7BB4660", VA = "0x187BB5C60")]
		[AsyncStateMachine(typeof(GFNEFHAFGJK))]
		public Task BuildFaceStyleAsyncIfChanged(DOOHILAACHK IOBACPOPLDF, bool DHGNECFLCMJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9D60", Offset = "0x7BB8760", VA = "0x187BB9D60")]
		public void UpdateFaceDisplays(bool KBJGKCLJLCB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB5210", Offset = "0x7BB3C10", VA = "0x187BB5210")]
		protected bool BNKNELODOIA(bool KBJGKCLJLCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9AC0", Offset = "0x7BB84C0", VA = "0x187BB9AC0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9190", Offset = "0x7BB7B90", VA = "0x187BB9190")]
		public void SetFaceSpriteIndices(string AKKLBFKPMLO, string EPDOJIBGIME, string KFCAJOPADBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9470", Offset = "0x7BB7E70", VA = "0x187BB9470")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9F80", Offset = "0x7BB8980", VA = "0x187BB9F80")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7BBA170", Offset = "0x7BB8B70", VA = "0x187BBA170")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7BB60F0", Offset = "0x7BB4AF0", VA = "0x187BB60F0")]
		protected void CLNPELPIOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BB82C0", Offset = "0x7BB6CC0", VA = "0x187BB82C0")]
		private void NKLNPKPJBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8800", Offset = "0x7BB7200", VA = "0x187BB8800")]
		private void PLKJOCOOJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB060", Offset = "0x7BB9A60", VA = "0x187BBB060")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA37E00", Offset = "0xA36800", VA = "0x180A37E00", Slot = "4")]
		private bool KOELFKEGDPC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct PEGNKKJFCLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public string HMKINKIIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public int KIJDDDGOGCE;
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
		private struct JGIIKKEKKLI : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x7BB2500", Offset = "0x7BB0F00", VA = "0x187BB2500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct KPCKMFMNJFO : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x7BB2BB0", Offset = "0x7BB15B0", VA = "0x187BB2BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x7BB30A0", Offset = "0x7BB1AA0", VA = "0x187BB30A0", Slot = "5")]
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
		public DOOHILAACHK avatarBodyType;

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
		public GHNNHOLHIND useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public EBGNPCDLBGE hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public AOELCACNGBK HatAnchorRestrictions;

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
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private HJLFCGBOLNG AKCGIHCDHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
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
		private AnimatorOverrideController LILIIIKNDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> GPNKDCNBOOG;

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
		public readonly PEGNKKJFCLM[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public readonly (string, FDMGNGIPNID)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		protected bool ALGNNAPDEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		protected Guid PMCGJEIABJM;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		protected static Guid LKJENJPLHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private LPODLLODNDM IHGOCKHGENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private HBPKIIMPBKO GIOBKFPCKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private JPJMMHEAOFC OADIJEGHPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private JPJMMHEAOFC JBPHMNAFEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private AdditionalHatData DMIGAJCBDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private readonly Dictionary<GameObject, AGHAHHACHKN> JKPLKNHNCKN;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<KDDBOMMNAEG> JNOBDHHIHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7BC05D0", Offset = "0x7BBEFD0", VA = "0x187BC05D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x7BC0C10", Offset = "0x7BBF610", VA = "0x187BC0C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool JHLMPKGOEHN
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x7BC0730", Offset = "0x7BBF130", VA = "0x187BC0730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool DGOKONLBMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x7BC0620", Offset = "0x7BBF020", VA = "0x187BC0620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase NFFHPDEBIHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xB302E0", Offset = "0xB2ECE0", VA = "0x180B302E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid CDECECPJMNK
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x7BBE260", Offset = "0x7BBCC60", VA = "0x187BBE260")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, MFEGJNCJJMB)[] FHGCNGLOKJI
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x7BC0840", Offset = "0x7BBF240", VA = "0x187BC0840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE350", Offset = "0x7BBCD50", VA = "0x187BBE350")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDDD0", Offset = "0x7BBC7D0", VA = "0x187BBDDD0")]
		private IEnumerable<GameObject> PENCMLMNNOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE820", Offset = "0x7BBD220", VA = "0x187BBE820")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDC60", Offset = "0x7BBC660", VA = "0x187BBDC60")]
		private void LOPJGBDMKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x13BEDC0", Offset = "0x13BD7C0", VA = "0x1813BEDC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD240", Offset = "0x7BBBC40", VA = "0x187BBD240")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE830", Offset = "0x7BBD230", VA = "0x187BBE830")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE640", Offset = "0x7BBD040", VA = "0x187BBE640")]
		public void ShowPose(AnimationClip JNGKMPEJDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE7F0", Offset = "0x7BBD1F0", VA = "0x187BBE7F0")]
		public void ShowPose(string CFNJEMNBCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE4A0", Offset = "0x7BBCEA0", VA = "0x187BBE4A0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE360", Offset = "0x7BBCD60", VA = "0x187BBE360")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF300", Offset = "0x7BBDD00", VA = "0x187BBF300")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF150", Offset = "0x7BBDB50", VA = "0x187BBF150")]
		public void UpdateFaceAndBodyShapes(bool DHGNECFLCMJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF700", Offset = "0x7BBE100", VA = "0x187BBF700")]
		public void UpdateNoseShape(IHBNBAEKKJN EDFNBFFGBEM, bool DHGNECFLCMJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF6D0", Offset = "0x7BBE0D0", VA = "0x187BBF6D0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCA00", Offset = "0x7BBB400", VA = "0x187BBCA00", Slot = "4")]
		protected virtual void EIKFNKEJMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD940", Offset = "0x7BBC340", VA = "0x187BBD940", Slot = "5")]
		protected virtual void JKPPKMLLHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB880", Offset = "0x7BBA280", VA = "0x187BBB880")]
		public void ApplyHatData(AdditionalHatData HCELFHNKFEJ, bool JDCJGDNEHAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB6C0", Offset = "0x7BBA0C0", VA = "0x187BBB6C0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BBBBE0", Offset = "0x7BBA5E0", VA = "0x187BBBBE0")]
		public void ApplyHatUVOverride(Vector2 JLLMHDPIBLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BBBB00", Offset = "0x7BBA500", VA = "0x187BBBB00")]
		public void ApplyHatPositionAdjustment(Vector3 JCNIOGEMKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBBB70", Offset = "0x7BBA570", VA = "0x187BBBB70")]
		public void ApplyHatRotationAdjustment(Vector3 PADHAACHLON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7BBBC50", Offset = "0x7BBA650", VA = "0x187BBBC50")]
		public OBJIFNMAOMP BuildAvatarItemSelection(GameObject JMMIPOIGPBG, DOOHILAACHK CINPLABALEE, MFEGJNCJJMB LNEMOFGMHED)
		{
			return default(OBJIFNMAOMP);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BBBCF0", Offset = "0x7BBA6F0", VA = "0x187BBBCF0")]
		public void BuildAvatar(bool DHGNECFLCMJ = false, bool JDCJGDNEHAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEB90", Offset = "0x7BBD590", VA = "0x187BBEB90")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB800", Offset = "0x7BBA200", VA = "0x187BBB800")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF520", Offset = "0x7BBDF20", VA = "0x187BBF520")]
		public void UpdateHatAnchor(bool JDCJGDNEHAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF250", Offset = "0x7BBDC50", VA = "0x187BBF250")]
		[AsyncStateMachine(typeof(JGIIKKEKKLI))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC930", Offset = "0x7BBB330", VA = "0x187BBC930")]
		[AsyncStateMachine(typeof(KPCKMFMNJFO))]
		private Task DPHOFHKHPJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC670", Offset = "0x7BBB070", VA = "0x187BBC670")]
		private void DOIHIPDJIPK(FaceFeatureType ANJELGDBCJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDD40", Offset = "0x7BBC740", VA = "0x187BBDD40")]
		private void OJIKPCMIMPG(FaceFeatureType ANJELGDBCJM, [Out] float AHKNINCGDLL, [Out] float CLAPOHFCMPG, [Out] float JAHHKOMJJAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF010", Offset = "0x7BBDA10", VA = "0x187BBF010")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF3B0", Offset = "0x7BBDDB0", VA = "0x187BBF3B0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCD10", Offset = "0x7BBB710", VA = "0x187BBCD10")]
		private void HNDHOOMPCMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void ECLNEIPDJCM(AGHAHHACHKN JBOKDPHJHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void IJKJNEPBBNF(AGHAHHACHKN JBOKDPHJHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC310", Offset = "0x7BBAD10", VA = "0x187BBC310")]
		private void CMBKFDEECJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF780", Offset = "0x7BBE180", VA = "0x187BBF780")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDBB0", Offset = "0x7BBC5B0", VA = "0x187BBDBB0")]
		[CompilerGenerated]
		private OBJIFNMAOMP JOCDKNCFBCA((GameObject, MFEGJNCJJMB) ODPCKFCMAGB)
		{
			return default(OBJIFNMAOMP);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct OBJIFNMAOMP
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class HGNHDLNKAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HGNHDLNKAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1FA0", Offset = "0x7BB09A0", VA = "0x187BB1FA0")]
		internal bool CLHJBGIFNND(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private AGHAHHACHKN BBFPLJGCEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private MFEGJNCJJMB HMEIMFHGMHC;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public AGHAHHACHKN IJLLENFCCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public MFEGJNCJJMB MHEIBDEBCIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xDCCB50", Offset = "0xDCB550", VA = "0x180DCCB50")]
		get
		{
			return default(MFEGJNCJJMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string NJPCGFPFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BB49D0", Offset = "0x7BB33D0", VA = "0x187BB49D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool BHMLEBFFHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BB4980", Offset = "0x7BB3380", VA = "0x187BB4980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool DEBPBCFHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BB4680", Offset = "0x7BB3080", VA = "0x187BB4680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1919890", Offset = "0x1918290", VA = "0x181919890")]
	public OBJIFNMAOMP(AGHAHHACHKN JBOKDPHJHCN, MFEGJNCJJMB ODFAALAAHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BB46D0", Offset = "0x7BB30D0", VA = "0x187BB46D0")]
	public bool EFLGEACCLMF(OutfitType EMNDJLCBLBJ, MFEGJNCJJMB KPKHADJNNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4420", Offset = "0x7BB2E20", VA = "0x187BB4420")]
	public bool AOHDMANODGL(OutfitType EMNDJLCBLBJ, MFEGJNCJJMB KPKHADJNNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4790", Offset = "0x7BB3190", VA = "0x187BB4790")]
	public bool FCJLNPECNCF(OBJIFNMAOMP GLELKONCCDA)
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
