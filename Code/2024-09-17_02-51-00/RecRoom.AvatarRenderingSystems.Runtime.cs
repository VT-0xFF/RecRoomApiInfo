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
using RecRoom.Avatars.Data.Shared;
using RecRoom.Core.Studio;
using RecRoom.DataLayer.Attributes;
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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AD97D0", Offset = "0x6AD81D0", VA = "0x186AD97D0", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAF30", Offset = "0x6AE9930", VA = "0x186AEAF30", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private RecNetCDNKey key;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x899AA0", Offset = "0x8984A0", VA = "0x180899AA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6AEA670", Offset = "0x6AE9070", VA = "0x186AEA670", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA5A0", Offset = "0x6AE8FA0", VA = "0x186AEA5A0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA630", Offset = "0x6AE9030", VA = "0x186AEA630")]
		public RecNetCDNAssetReference(RecNetCDNKey LFOBGDLOPID)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x89D6B0", Offset = "0x89C0B0", VA = "0x18089D6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA6B0", Offset = "0x6AE90B0", VA = "0x186AEA6B0")]
		public static RecNetCDNKey DKOOBCOMLMA(string HDCCEEPNAJF, string EAJPOHDKMOI = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62DF2F0", Offset = "0x62DDCF0", VA = "0x1862DF2F0")]
		public void EEBMOLCBBLP(string PMLFAIIFKFO, string DOAOBIHCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA7B0", Offset = "0x6AE91B0", VA = "0x186AEA7B0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHFFCNPJGMC]
public class HEANOGCFGMD : PAMCALHBGMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> KHBGBPJCNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> IBHMMFPAHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> PHDJBOPMDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> OLFIHHNPGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> JEPPHNHFIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> ECJGAKEJINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> CEHCJEPFOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator EOKMEOFLNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected BIKBNBBNMKK MONCDCDOBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte GNEOADFKGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> HHJICFFNLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> CDFOEELGPDI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4FC0", Offset = "0x6AD39C0", VA = "0x186AD4FC0", Slot = "4")]
	public void DPLAMNGCGIK(Mesh CBNKKMIFMKD, Matrix4x4 NHEPHNDBJMF, byte[] NLPIKJKCGDE, bool MFCNCFKKDDP = false, JAKMGBMNCCH.MGOIBKLDNOG MKKGHCPAFMJ = (JAKMGBMNCCH.MGOIBKLDNOG)0, int KMJEELBIBCF = -1, bool PDMABNCNBKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AD51D0", Offset = "0x6AD3BD0", VA = "0x186AD51D0", Slot = "5")]
	public void LCNLFABJEOE(Allocator NPNPKHEIOHB, BIKBNBBNMKK NKHOAFPCLDD, byte BDMHPMBHLLJ, [Optional] IList<int> MLIFMPNEECJ, [Optional] IList<int> COICNJBLAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4D70", Offset = "0x6AD3770", VA = "0x186AD4D70")]
	private static void ABLLFDHAPBF(Mesh CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5210", Offset = "0x6AD3C10", VA = "0x186AD5210")]
	public HEANOGCFGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NHFFCNPJGMC]
public struct JODJADKAICA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public PEKJFEHKPPE DPCOMNDNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int DGKDDBHAJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NIFBFOIEHLJ PILOCJLELBC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7D20", Offset = "0x6AD6720", VA = "0x186AD7D20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[NHFFCNPJGMC]
public struct NIFBFOIEHLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct CINIDLAAAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 KHBFNMGIMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 DBBPPLLNKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 DNAJPPCEHOF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct NEADGAKLAMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float JHCFGCKAFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float CAIDPIPHILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float CKDIOFNKOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float JGKPLGNIGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte LHNBBOKGAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte BILCPAFHCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte IAGABICNBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte FGINMMACODN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct AIJCFMJNHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half JHCFGCKAFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half CAIDPIPHILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half CKDIOFNKOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half JGKPLGNIGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte LHNBBOKGAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte BILCPAFHCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte IAGABICNBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte FGINMMACODN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JDMMJJAANOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 FEHNKBJAMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 OCIAABGJOLI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct OKFAFBIMBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 FEHNKBJAMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 OCIAABGJOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 PKJJFKPAHPA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct IONBADCJPNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 FEHNKBJAMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 OCIAABGJOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 PKJJFKPAHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 EJJNDJNHDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct HMEPOGGDGBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 FEHNKBJAMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 OCIAABGJOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 PKJJFKPAHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 EJJNDJNHDHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 BAGIALOKMNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct COOGIJIPDHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float JHCFGCKAFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float CAIDPIPHILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float CKDIOFNKOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float JGKPLGNIGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int LHNBBOKGAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int BILCPAFHCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int IAGABICNBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int FGINMMACODN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct PKABEIGOCGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color FEHNKBJAMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 OCIAABGJOLI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct INKBGNBPIGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color FEHNKBJAMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 OCIAABGJOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 PKJJFKPAHPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct AOGPJDDHOOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color FEHNKBJAMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 OCIAABGJOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 PKJJFKPAHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 EJJNDJNHDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct HJEPOOHENIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color FEHNKBJAMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 OCIAABGJOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 PKJJFKPAHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 EJJNDJNHDHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 BAGIALOKMNE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool IBMNJLNICOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<CINIDLAAAML> DDBOHFMCMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<JDMMJJAANOC> OLMOFBFAEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<OKFAFBIMBBA> CBBANHMGPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<IONBADCJPNC> IJDGLEOGLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<HMEPOGGDGBF> CNLPFDFNMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<AIJCFMJNHED> GMFDBOBIBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<NEADGAKLAMB> HEIBPDNFIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<PKABEIGOCGH> FOOMNNFHPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<INKBGNBPIGP> PLGPLBGPLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<AOGPJDDHOOL> NFCJPJCGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<HJEPOOHENIN> INFAJNPNHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<COOGIJIPDHJ> HKGPGNIAGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> DBGPEKBLMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> OGELDPFJLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> LGJINPCECFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> HNOJGGHOKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> ECFKGLNBMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> IEDLMINIJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> LJJCPCCEDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> NLAGCMHDAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> FCDCCFDNJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool AFMECNNANBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool OLPEDEELBCN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HANEOHLCILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7340", Offset = "0x6AE5D40", VA = "0x186AE7340")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7330", Offset = "0x6AE5D30", VA = "0x186AE7330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JLECLGBCMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7790", Offset = "0x6AE6190", VA = "0x186AE7790")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5C90", Offset = "0x6AE4690", VA = "0x186AE5C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BIHIJFKOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7320", Offset = "0x6AE5D20", VA = "0x186AE7320")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE77A0", Offset = "0x6AE61A0", VA = "0x186AE77A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JBAGGOLDPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6E40", Offset = "0x6AE5840", VA = "0x186AE6E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7FE0", Offset = "0x6AE69E0", VA = "0x186AE7FE0")]
	public NIFBFOIEHLJ(int MHLEDOPNJJB, int GBLGHDDGKKH, int IACKLHFPLBG, int NDDGOLHNMMJ, Allocator NPNPKHEIOHB, int OBCDFNDLGIA, PJGPDLJDDJG JGPBFOKLBKM, bool AFMECNNANBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7350", Offset = "0x6AE5D50", VA = "0x186AE7350")]
	public void LGLHHLDLMKA(int HGFDMIDEFHN, Vector3 LEKEIHPCIEI, Vector3 ODPGHJEEHCK, Vector4 KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7BB0", Offset = "0x6AE65B0", VA = "0x186AE7BB0")]
	public void PNNADMAMNGE(int HGFDMIDEFHN, BoneWeight PEGIGPBPPOP, NativeSlice<byte> NLPIKJKCGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6F80", Offset = "0x6AE5980", VA = "0x186AE6F80")]
	public Color ICFILIICPIM(int HGFDMIDEFHN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AE77B0", Offset = "0x6AE61B0", VA = "0x186AE77B0")]
	public void OHJPEPKHHKE(int HGFDMIDEFHN, Color DMIBFACOBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AE73E0", Offset = "0x6AE5DE0", VA = "0x186AE73E0")]
	public void NDMICBBMJHB(byte ABJCANHBLFI, int HGFDMIDEFHN, Vector2 HPJCHPFIKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7310", Offset = "0x6AE5D10", VA = "0x186AE7310")]
	public void IODPEOKFHBC(int HGFDMIDEFHN, int AOLDBHBMPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AE72B0", Offset = "0x6AE5CB0", VA = "0x186AE72B0")]
	public bool IJADCAINAHD(int ABJCANHBLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6EB0", Offset = "0x6AE58B0", VA = "0x186AE6EB0")]
	public void ICEHCMACBJI(int LOMGCOBFHAA, int IEHCONIHMPO, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5CA0", Offset = "0x6AE46A0", VA = "0x186AE5CA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5F00", Offset = "0x6AE4900", VA = "0x186AE5F00")]
	public Mesh EIMJPKFOAMG([Optional] string MCHHHNLFOOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NativeContainer]
[NHFFCNPJGMC]
[DefaultMember("Item")]
public struct PEKJFEHKPPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray AHEDLDEEPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> IFHFAMJKHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> OELPAGJKBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> NLAGCMHDAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> EHBENHGEBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> MHJIJAMOEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> NHLFOFGNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> AOJLKJCJJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> IIGLGAFMNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> HEDFEGAAPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> OEPJHKGFBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> PDMABNCNBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> KMJEELBIBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool AFMECNNANBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> IPDGODICMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool OLPEDEELBCN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int PAFEIBPNHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8C70", Offset = "0x6AE7670", VA = "0x186AE8C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DFCHJGCGBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8C60", Offset = "0x6AE7660", VA = "0x186AE8C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ICADOCLJJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8EE0", Offset = "0x6AE78E0", VA = "0x186AE8EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GFBGCLDAHLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9150", Offset = "0x6AE7B50", VA = "0x186AE9150")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9260", Offset = "0x6AE7C60", VA = "0x186AE9260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HANEOHLCILB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9140", Offset = "0x6AE7B40", VA = "0x186AE9140")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9130", Offset = "0x6AE7B30", VA = "0x186AE9130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ELFJBPIHLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8C80", Offset = "0x6AE7680", VA = "0x186AE8C80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9120", Offset = "0x6AE7B20", VA = "0x186AE9120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BIKBNBBNMKK LPMFIJLEMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9240", Offset = "0x6AE7C40", VA = "0x186AE9240")]
		get
		{
			return default(BIKBNBBNMKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9250", Offset = "0x6AE7C50", VA = "0x186AE9250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte EOCENEKKEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9230", Offset = "0x6AE7C30", VA = "0x186AE9230")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9270", Offset = "0x6AE7C70", VA = "0x186AE9270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public PHMACPGHBAP BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8C90", Offset = "0x6AE7690", VA = "0x186AE8C90")]
		get
		{
			return default(PHMACPGHBAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9280", Offset = "0x6AE7C80", VA = "0x186AE9280")]
	public PEKJFEHKPPE(IList<Mesh> AJPLJKKAOPN, IList<Matrix4x4> PEMMJFLIMJB, IList<bool> PDMABNCNBKK, byte BDMHPMBHLLJ, IList<byte[]> HICPBOAIIPC, IList<int> HNLKLPJPKEC, IList<bool> NEBDCLJPCED, IList<int> KMJEELBIBCF, IList<int> MLIFMPNEECJ, IList<int> ACLOIEGLKCD, Allocator NPNPKHEIOHB, BIKBNBBNMKK NKHOAFPCLDD, bool AFMECNNANBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9160", Offset = "0x6AE7B60", VA = "0x186AE9160")]
	public NIFBFOIEHLJ LJPFLAPIMKB(Allocator NPNPKHEIOHB, PJGPDLJDDJG JGPBFOKLBKM)
	{
		return default(NIFBFOIEHLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8FB0", Offset = "0x6AE79B0", VA = "0x186AE8FB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NHFFCNPJGMC]
public class IAGJEJIMMBD : HEANOGCFGMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool MJEHELAICCB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker JGBJMFNHCCC;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5830", Offset = "0x6AD4230", VA = "0x186AD5830")]
	public PEKJFEHKPPE GFDNKDGLHCC()
	{
		return default(PEKJFEHKPPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5B30", Offset = "0x6AD4530", VA = "0x186AD5B30")]
	public IAGJEJIMMBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PHMACPGHBAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData HKHAAGICECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> NLAGCMHDAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> KLMKNEGALHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int AACAGOGPPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 KAOHGLDIPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int KLEIINKAELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> NLPIKJKCGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool NOANPIGBJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int LLOCJOHKGAE;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MNENJKEIKJH : CDCGOHLJDLI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class DOKJHLECMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly GLHPDDDHLIA AEPKCJLNNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		protected bool NHJMJADMJHN;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool CJGGLDPBFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool BHGNEICDDEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual JAKMGBMNCCH.MGOIBKLDNOG KLEIINKAELF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "6")]
			get
			{
				return default(JAKMGBMNCCH.MGOIBKLDNOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool NAIFPHABKEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB7DBB0", Offset = "0xB7C5B0", VA = "0x180B7DBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool NHAEIKKBDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x180F7C0", Offset = "0x180E1C0", VA = "0x18180F7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IOHOJKLOILA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4160", Offset = "0x6AD2B60", VA = "0x186AD4160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool LNIBCJNBIHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6AD4140", Offset = "0x6AD2B40", VA = "0x186AD4140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		protected DOKJHLECMKG(GLHPDDDHLIA EEILADHJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract EOHNLEPDLDE OPJFOBEHCJC(int[] JEEAMHGBKFO, List<FCFAMILBOPJ> NNHMLNHCDOO, List<FCFAMILBOPJ> LCOJBDPHOMJ);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract MGCEPBEPFBJ DOOINGOAJDF(uint CLOHFODGPFM, AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM);
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class HACDLEJFDBB : DOKJHLECMKG
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HHFBDHEPPFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public POLPOFEBNLM<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public HACDLEJFDBB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public HHFBDHEPPFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6AD5440", Offset = "0x6AD3E40", VA = "0x186AD5440")]
			internal void FBFLJKJIDJD(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly AvatarSkinAssetItem.IDEHBGCIOLK HHMDKMGIHPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly AssetReference GBKGMGCEKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly JAKMGBMNCCH.MGOIBKLDNOG AFCDAOHBJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly DFIACMOLAPM? KPOKHJDKMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly Material[] FDAODAFABPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private SkinnedMeshRenderer[] CMBOHHPBHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private AvatarSkinAssetItem HDEMGACHHMN;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override JAKMGBMNCCH.MGOIBKLDNOG KLEIINKAELF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x898FD0", Offset = "0x8979D0", VA = "0x180898FD0", Slot = "6")]
			get
			{
				return default(JAKMGBMNCCH.MGOIBKLDNOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4B50", Offset = "0x6AD3550", VA = "0x186AD4B50")]
		public HACDLEJFDBB(AvatarSkinAssetItem.IDEHBGCIOLK MIACGHPGDLD, AssetReference NENGFLFCLLB, Material ECCFNPOHFPE, GLHPDDDHLIA NOLHAPCPHHI, JAKMGBMNCCH.MGOIBKLDNOG EOPONNJBIAI = (JAKMGBMNCCH.MGOIBKLDNOG)0, [Optional] DFIACMOLAPM? DHLLGPMIOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4C60", Offset = "0x6AD3660", VA = "0x186AD4C60")]
		public HACDLEJFDBB(AvatarSkinAssetItem.IDEHBGCIOLK MIACGHPGDLD, AssetReference NENGFLFCLLB, Material ECCFNPOHFPE, JAKMGBMNCCH.MGOIBKLDNOG EOPONNJBIAI = (JAKMGBMNCCH.MGOIBKLDNOG)0, [Optional] DFIACMOLAPM? DHLLGPMIOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4910", Offset = "0x6AD3310", VA = "0x186AD4910", Slot = "7")]
		public override EOHNLEPDLDE OPJFOBEHCJC(int[] JEEAMHGBKFO, List<FCFAMILBOPJ> NNHMLNHCDOO, List<FCFAMILBOPJ> LCOJBDPHOMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4630", Offset = "0x6AD3030", VA = "0x186AD4630", Slot = "8")]
		public override MGCEPBEPFBJ DOOINGOAJDF(uint CLOHFODGPFM, AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4AE0", Offset = "0x6AD34E0", VA = "0x186AD4AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class ACDONKGIPBJ : DOKJHLECMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly BEICOJMJHMH MDBDPKOMKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private POLPOFEBNLM<ALKPGNKPOMI> JHPNHOKCEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ALKPGNKPOMI IFDNFHDMBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private POLPOFEBNLM<Material[]> ELMOJDKEOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Material[] BLODNDKDHEI;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool CJGGLDPBFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool BHGNEICDDEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6AD34A0", Offset = "0x6AD1EA0", VA = "0x186AD34A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD39E0", Offset = "0x6AD23E0", VA = "0x186AD39E0")]
		public ACDONKGIPBJ(GLHPDDDHLIA EEILADHJPHD, BEICOJMJHMH IOHLELCHLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3500", Offset = "0x6AD1F00", VA = "0x186AD3500", Slot = "7")]
		public override EOHNLEPDLDE OPJFOBEHCJC(int[] JEEAMHGBKFO, List<FCFAMILBOPJ> NNHMLNHCDOO, List<FCFAMILBOPJ> LCOJBDPHOMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2D40", Offset = "0x6AD1740", VA = "0x186AD2D40", Slot = "8")]
		public override MGCEPBEPFBJ DOOINGOAJDF(uint CLOHFODGPFM, AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3290", Offset = "0x6AD1C90", VA = "0x186AD3290")]
		public MGCEPBEPFBJ KIIEBHGGCOA(GameObject FOGDNDDPAEP, uint CLOHFODGPFM, bool LLGOIEMDJKE, bool GGEJNEEHOFD, AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2E70", Offset = "0x6AD1870", VA = "0x186AD2E70")]
		public static bool EANDMLPANJC(Renderer[] DEFOCNCNONK, string BJEFKIFLIHD, [Out] Renderer MDPKIBFIKJN, [Out] Renderer IICFNBACCDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3990", Offset = "0x6AD2390", VA = "0x186AD3990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD31D0", Offset = "0x6AD1BD0", VA = "0x186AD31D0")]
		private (POLPOFEBNLM<ALKPGNKPOMI>, POLPOFEBNLM<Material[]>) FPMFLNMJIDP()
		{
			return default((POLPOFEBNLM<ALKPGNKPOMI>, POLPOFEBNLM<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4556440", Offset = "0x4554E40", VA = "0x184556440")]
		[CompilerGenerated]
		private void EHFDGPMGMMK(ALKPGNKPOMI POBDLJBBBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x899930", Offset = "0x898330", VA = "0x180899930")]
		[CompilerGenerated]
		private void OBHMINJOMPI(Material[] POBDLJBBBCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class APEPMAKNJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public ALFLIOIIDKL avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public IBILKJCONGN buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public APEPMAKNJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3BA0", Offset = "0x6AD25A0", VA = "0x186AD3BA0")]
		internal bool MCEAGPGBHHB(BEICOJMJHMH item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3A60", Offset = "0x6AD2460", VA = "0x186AD3A60")]
		internal void HFKDIBJJALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3A40", Offset = "0x6AD2440", VA = "0x186AD3A40")]
		internal void EIBIHBNIKBB(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3B10", Offset = "0x6AD2510", VA = "0x186AD3B10")]
		internal void LBDKJKOBODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3A80", Offset = "0x6AD2480", VA = "0x186AD3A80")]
		internal void INLDBOLOKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
		internal EOHNLEPDLDE INEGPBHJJEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MIIGJFGEFGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public APEPMAKNJAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MIIGJFGEFGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9860", Offset = "0x6AD8260", VA = "0x186AD9860")]
		internal MPPLOPGDAHM AODGDIPHGMG(int lod)
		{
			return default(MPPLOPGDAHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PKBKJJEMLPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<IBILKJCONGN> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public PKBKJJEMLPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA470", Offset = "0x6AE8E70", VA = "0x186AEA470")]
		internal void BGHDJHKDCDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OAKMILAIKKJ : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public List<DOKJHLECMKG> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public List<IBILKJCONGN> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Func<int, MPPLOPGDAHM> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NJOIGIAEIFG materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public OAKMILAIKKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8A10", Offset = "0x6AE7410", VA = "0x186AE8A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8C10", Offset = "0x6AE7610", VA = "0x186AE8C10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BIGBDCALHBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public BIGBDCALHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3C70", Offset = "0x6AD2670", VA = "0x186AD3C70")]
		internal EOHNLEPDLDE IOPEPLEFBAO(DOKJHLECMKG p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HDEMCLMNBBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public FNDBFEALHLE cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HDEMCLMNBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8EEFD0", Offset = "0x8ED9D0", VA = "0x1808EEFD0")]
		internal void HFDMPFKNNMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xC8B8D0", Offset = "0xC8A2D0", VA = "0x180C8B8D0")]
		internal void OFCGBIGBNPN(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class KHIEEIOBNIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public KHIEEIOBNIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class CKFKAMGCBMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public NIFBFOIEHLJ defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public PEKJFEHKPPE defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public KHIEEIOBNIB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CKFKAMGCBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3F00", Offset = "0x6AD2900", VA = "0x186AD3F00")]
		internal void MKFNPGFKFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xC8BB30", Offset = "0xC8A530", VA = "0x180C8BB30")]
		internal void LLJAJANHKMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class CCCJMKLAFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public NECDJLDGFLC legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public POHLBKKJHDB legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public KHIEEIOBNIB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CCCJMKLAFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3CC0", Offset = "0x6AD26C0", VA = "0x186AD3CC0")]
		internal void EKILOEEDAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC88850", Offset = "0xC87250", VA = "0x180C88850")]
		internal void PCGBAPCNBIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EIHNBNDHPOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public KeyValuePair<string, BEICOJMJHMH> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public FNDBFEALHLE cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public BEICOJMJHMH avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EIHNBNDHPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6AD41B0", Offset = "0x6AD2BB0", VA = "0x186AD41B0")]
		internal EOHNLEPDLDE NENLFDDCMDI(BBHCHJINLEI item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4170", Offset = "0x6AD2B70", VA = "0x186AD4170")]
		internal void HNODDFHGFHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class EKGOBKGHPCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public POLPOFEBNLM<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EKGOBKGHPCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD45E0", Offset = "0x6AD2FE0", VA = "0x186AD45E0")]
		internal void GJOIGDCIBDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class BDMKKFGMBAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public GLHPDDDHLIA overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public BDMKKFGMBAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3BF0", Offset = "0x6AD25F0", VA = "0x186AD3BF0")]
		internal bool FAFPJMDACAB(KeyValuePair<string, BEICOJMJHMH> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration DHJENGMDNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform JKDEMCLEDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference GBKGMGCEKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject AHACKCCNEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject IEMIKNBGCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer NMJFODJEMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData MEOHAFLGECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] GCAJAFEICEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] EOOFGFCBGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material KNCGDEIAFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material LPGKJKKCOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material ACOIPGGCJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader KDMLNBMHEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader HGGNJHHPMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator FIHFGMCJOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] FMIEKPKKEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private JAKMGBMNCCH.MGOIBKLDNOG MEOPKALNNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager IPNNFJHNNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> ONKMCMHBOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.EIAKKEDFMHH EOGCDFHHACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.GGAPFHCEDBE LLIBEJMJGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool JDIMKGOHPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool MCBBKPHKJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color OCLNBNFGEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color OMKHKOKOCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color JMDBFNNGFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? FJBOCPNNEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? JFEMEIKLIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? CLKBAGBGFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? EEIPDHIGFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D ADFABKEDGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D PKOECMNENFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private BEICOJMJHMH LBBNCMLPNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture MHOAFKJAJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color JEKBENGIFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, NJOIGIAEIFG> OBAMGKMAOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, NJOIGIAEIFG> NDPBHEEDBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<DNAMKONLNOL>> KCCADEHCBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<DNAMKONLNOL>> NJGOAFEALHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<FCFAMILBOPJ> LJCCCKOFMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<FCFAMILBOPJ> GLCOBIJOPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<FCFAMILBOPJ> CKIAPMELHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<FCFAMILBOPJ> IGMJJFOBINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<DNAMKONLNOL, Material> MLJOCJLNMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<DNAMKONLNOL, Material> HKPNEPDECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] HENOGPNOGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] JHPOFCHIJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] NAKJEFIMEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] MHBAMCJJDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, POLPOFEBNLM<Texture2D>> EADHHKGCFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, POLPOFEBNLM<Texture2D>> GIOLNCGNACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData HKEJECLFPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AdditionalHatData OFGBCMHCALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private HairData GKDEHAHCEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private HairData COCGGAJCNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private FMFJFNMKGFN HNAJNOLKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool? LKJCPOACPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation FECAAELFODI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material PKOBHAJBKHN;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Material EGHLLPBPGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, BEICOJMJHMH> DLHFICIMCMF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int DKOKIHIFNPE;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int DJDADAPKDLG;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int HBAAKKKFGEP;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int CHMALFIPMEF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int LDIBBEBNMEL;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int ACLKLEDNEHA;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int GPAHLJFKCLD;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int AIIAFOPGEGN;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int OGGAGBAKKHI;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int AOLFIKFJCEC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int GCNBEGOCCBL;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int GMOCHPAIIOH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int KPKFADPCJOL;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int OMAAOGOIBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly GHNLMGKLHKE ANLPCBAENGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly GHNLMGKLHKE BHKEPCAIMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool APICILGEFKN;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static Lazy<LEBBOCDPOJL> MMONEJKNGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Lazy<MKGABAOANDN> JICPBBOIKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Lazy<MCHGBKDKGEC> IKIAJKNAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private GDFLEMFPAMO NOHNCAAACED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private List<Action> HDKHJJBEJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private CCNPMMKEMIA ENHGDEHEIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private SkinnedMeshRenderer[] AIPCLFCOFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int KCFHMFBPHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool LIGIFPEENFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int GPHAHKKIHJG;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static bool OPOEGLKJEND;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HHIKDOEMOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xBF3330", Offset = "0xBF1D30", VA = "0x180BF3330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBF4270", Offset = "0xBF2C70", VA = "0x180BF4270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material HDPGKINAEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC390", Offset = "0x6ADAD90", VA = "0x186ADC390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material MMKMEAOKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0130", Offset = "0x6ADEB30", VA = "0x186AE0130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool IENKDKLDEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MMBBNHOOGFA OAENENEEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x923D80", Offset = "0x922780", VA = "0x180923D80", Slot = "21")]
		get
		{
			return default(MMBBNHOOGFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static LEBBOCDPOJL JGGOGAFIBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9D00", Offset = "0x6AD8700", VA = "0x186AD9D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private MKGABAOANDN LCGDBGCLAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC700", Offset = "0x6ADB100", VA = "0x186ADC700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private MCHGBKDKGEC PONPNLELBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC5C0", Offset = "0x6ADAFC0", VA = "0x186ADC5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private GDFLEMFPAMO GPIHFDLIICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0C00", Offset = "0x6ADF600", VA = "0x186AE0C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GHNLMGKLHKE EOCFHIOFMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xBF4650", Offset = "0xBF3050", VA = "0x180BF4650", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GHNLMGKLHKE NAAGCMCAHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x158D670", Offset = "0x158C070", VA = "0x18158D670", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] OKKAGIADBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1A217C0", Offset = "0x1A201C0", VA = "0x181A217C0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] EJNLLKCNLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x89F6E0", Offset = "0x89E0E0", VA = "0x18089F6E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool FHGDJHGAGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBBB0", Offset = "0x6ADA5B0", VA = "0x186ADBBB0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation DBMKINDEKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD8A0", Offset = "0x6ADC2A0", VA = "0x186ADD8A0", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public JAKMGBMNCCH.MGOIBKLDNOG JPPNAMPBJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x89F790", Offset = "0x89E190", VA = "0x18089F790", Slot = "18")]
		get
		{
			return default(JAKMGBMNCCH.MGOIBKLDNOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int GCBAHIGDCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1A38170", Offset = "0x1A36B70", VA = "0x181A38170")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA4F0", Offset = "0x6AD8EF0", VA = "0x186ADA4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool ABDLKGNACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBE10", Offset = "0x6ADA810", VA = "0x186ADBE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool GFMCJCJABHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4760", Offset = "0x6AE3160", VA = "0x186AE4760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6AE54E0", Offset = "0x6AE3EE0", VA = "0x186AE54E0")]
	public MNENJKEIKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9D70", Offset = "0x6AD8770", VA = "0x186AD9D70", Slot = "28")]
	public void AIFHKOLJDOL(HONBEFLPIDJ OABCPBHPCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA1D0", Offset = "0x6AD8BD0", VA = "0x186ADA1D0", Slot = "29")]
	public void AOBEGDFBGEF(OPAPCMIDHAJ EALPHDIJEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA4F0", Offset = "0x6AD8EF0", VA = "0x186ADA4F0", Slot = "4")]
	public void MDJBKKDLNHK(int CLOHFODGPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFA10", Offset = "0x6ADE410", VA = "0x186ADFA10", Slot = "9")]
	public void KPFEIFMFBMA(GFOGIFDMNJB FMAFCGPMJFK, Texture2D AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE30D0", Offset = "0x6AE1AD0", VA = "0x186AE30D0", Slot = "10")]
	public void OELBFLMPCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4990", Offset = "0x6AE3390", VA = "0x186AE4990", Slot = "11")]
	public bool ONCOADGCOPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDC60", Offset = "0x6ADC660", VA = "0x186ADDC60", Slot = "8")]
	public void IBNHEHMKGEM(BFLHHFOPLKK OKCHJHEBDDJ, Color? FEHNKBJAMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEDB0", Offset = "0x6ADD7B0", VA = "0x186ADEDB0")]
	private void KBCNBAFMGJB(Action IOLKPHMAHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFD80", Offset = "0x6ADE780", VA = "0x186ADFD80", Slot = "5")]
	public void LLHOPECOHPP(BEICOJMJHMH EPOECBLHBPA, Texture AMGHPGDDFLJ, Color LDGJBJLDJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xBF4270", Offset = "0xBF2C70", VA = "0x180BF4270", Slot = "6")]
	public void HNOELIGPCJN(bool DAOFCFKPKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x199B810", Offset = "0x199A210", VA = "0x18199B810", Slot = "7")]
	public void BNMOMDLPELD(CCNPMMKEMIA FCDCCFDNJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3150", Offset = "0x6AE1B50", VA = "0x186AE3150", Slot = "14")]
	public IBILKJCONGN OFAFPBMGCNF(ALFLIOIIDKL DEGOHMKMPKL, bool ENBJOJKEDIJ, int[] BMHAIHPMNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4EC0", Offset = "0x6AE38C0", VA = "0x186AE4EC0", Slot = "15")]
	public void PEGLLNMGGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCAF0", Offset = "0x6ADB4F0", VA = "0x186ADCAF0", Slot = "26")]
	public void GKNPIAMHBDN([Optional] FMFJFNMKGFN CMJJLELONED, [Optional] bool? NJJCNLJIMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC250", Offset = "0x6ADAC50", VA = "0x186ADC250")]
	private bool EAOPDKNAOEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9CE0", Offset = "0x6AD86E0", VA = "0x186AD9CE0", Slot = "19")]
	public bool AHGAOJJJDBO(JAKMGBMNCCH.MGOIBKLDNOG ADOEJKNOMFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBD20", Offset = "0x6ADA720", VA = "0x186ADBD20")]
	private bool DGLECDJPDKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2820", Offset = "0x6AE1220", VA = "0x186AE2820")]
	private IBILKJCONGN NEALEJBEFMP(bool ENBJOJKEDIJ, List<DOKJHLECMKG> MPENFNOCBOP, int[] BMHAIHPMNPJ, Func<int, MPPLOPGDAHM> FALOABLCNEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDB50", Offset = "0x6ADC550", VA = "0x186ADDB50")]
	[IteratorStateMachine(typeof(OAKMILAIKKJ))]
	private IEnumerator<GJDHNIMFMOA> IBBBGLGHLIH(bool ENBJOJKEDIJ, List<DOKJHLECMKG> MPENFNOCBOP, int[] BMHAIHPMNPJ, Func<int, MPPLOPGDAHM> FALOABLCNEH, NJOIGIAEIFG PIJDHFGMLNA, Material HCGFICBNDDJ, List<IBILKJCONGN> LODPIDCMFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4C00", Offset = "0x6AE3600", VA = "0x186AE4C00")]
	private IBILKJCONGN PANDMAIPLEO(List<DOKJHLECMKG> MPENFNOCBOP, int[] BMHAIHPMNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0CA0", Offset = "0x6ADF6A0", VA = "0x186AE0CA0")]
	private EPGCCCKMEBG NALPFJDFOGB(List<DOKJHLECMKG> MPENFNOCBOP, int CLOHFODGPFM, bool ENBJOJKEDIJ, MPPLOPGDAHM CEEMGDGDBHO, bool JHNHAJFKKDK, NJOIGIAEIFG PIJDHFGMLNA, Material HCGFICBNDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AE50C0", Offset = "0x6AE3AC0", VA = "0x186AE50C0", Slot = "22")]
	public void PJEJPDCHEEK(AvatarFaceShape KOMGNJEMGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA030", Offset = "0x6AD8A30", VA = "0x186ADA030", Slot = "23")]
	public void AJDKNFMBPCM(AvatarBodyShape NMCDICFFHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4B00", Offset = "0x6AE3500", VA = "0x186AE4B00", Slot = "25")]
	public void ONOLBJMALDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA5A0", Offset = "0x6AD8FA0", VA = "0x186ADA5A0", Slot = "24")]
	public void BGIIGPNHIHJ(bool LEHMLDCKFIA, bool BMPJMPGALEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC7E0", Offset = "0x6ADB1E0", VA = "0x186ADC7E0")]
	private void FKBHEGDOJOK(SkinnedMeshRenderer OPFEFHBMMKN, int CLOHFODGPFM, Mesh CBNKKMIFMKD, List<Material> CIPPENEAALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE330", Offset = "0x6ADCD30", VA = "0x186ADE330")]
	private static Material IKEONLBLABP(Dictionary<DNAMKONLNOL, Material> ODPCBOGBEMK, Material EGLGDAKJDKM, GABPAHOMPGH CIDOJAAGKLI, GFPOJCNDFBH CGGKKLLIJHE, GLHPDDDHLIA NOLHAPCPHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA250", Offset = "0x6AD8C50", VA = "0x186ADA250")]
	private static GABPAHOMPGH AOLEDKOAGAP(DOKJHLECMKG IIHEFEHICGN, int CJPMNEPPIBG)
	{
		return default(GABPAHOMPGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE03D0", Offset = "0x6ADEDD0", VA = "0x186AE03D0")]
	private void LPPLCDDGKOE(int HPANIDNNADA, Material KFGOIEOLDHF, DOKJHLECMKG IIHEFEHICGN, [Out] Texture2D JCEHHJHIMEJ, [Out] Vector4 JEMDANLGOOF, [Out] Texture2D HJKIOHHLCPB, [Out] Texture2D KIBKKDOAMJM, [Out] Texture2D OLGPLHLHDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE770", Offset = "0x6ADD170", VA = "0x186ADE770")]
	private void JEPGJCMMIJP(int HPANIDNNADA, Material KFGOIEOLDHF, DOKJHLECMKG IIHEFEHICGN, [Out] Color GECFOLMCGMM, [Out] Color HCPMMFPFJFH, [Out] Color JGGBKMPNMLA, [Out] Color OMFEKEMHIGG, [Out] Color EAENDLBEFOP, [Out] Color BOMPMFFAGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAFD0", Offset = "0x6AD99D0", VA = "0x186ADAFD0")]
	private bool DBBCACPDAKG(Material KFGOIEOLDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA0F0", Offset = "0x6AD8AF0", VA = "0x186ADA0F0")]
	private static Material AMOKNDIBFFH(int HPANIDNNADA, ACDONKGIPBJ IIHEFEHICGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC610", Offset = "0x6ADB010", VA = "0x186ADC610")]
	private static GFPOJCNDFBH FGCKAPNBMFN(DOKJHLECMKG IIHEFEHICGN, int CJPMNEPPIBG)
	{
		return default(GFPOJCNDFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE490", Offset = "0x6ADCE90", VA = "0x186ADE490")]
	private static void JENIJCHFMCO(Dictionary<string, List<DNAMKONLNOL>> MECAOIIIDEC, DOKJHLECMKG ICIPCKBNAJK, Material EGLGDAKJDKM, GABPAHOMPGH OKCHJHEBDDJ, GFPOJCNDFBH FMAFCGPMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE060", Offset = "0x6ADCA60", VA = "0x186ADE060")]
	private static SkinnedMeshRenderer IBPDGDANMNO(Transform KAGPFNBINEG, Transform NBLDBLADKCD, SkinnedMeshRenderer[] DEFOCNCNONK, int CLOHFODGPFM, MPPLOPGDAHM CEEMGDGDBHO, bool ENBJOJKEDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2DF0", Offset = "0x6AE17F0", VA = "0x186AE2DF0")]
	private void NHEHNIJAKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFC20", Offset = "0x6ADE620", VA = "0x186ADFC20")]
	private void LGCAAEOFNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEC50", Offset = "0x6ADD650", VA = "0x186ADEC50")]
	private static void JPJBFDJHAPC(Dictionary<DNAMKONLNOL, Material> ODPCBOGBEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AE09D0", Offset = "0x6ADF3D0", VA = "0x186AE09D0")]
	private static void MIKHMJPDCMH(Dictionary<Renderer, NJOIGIAEIFG> LOJNKOLBLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC9D0", Offset = "0x6ADB3D0", VA = "0x186ADC9D0")]
	private void GFJHGHPJAGJ(SkinnedMeshRenderer[] DEFOCNCNONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE290", Offset = "0x6ADCC90", VA = "0x186ADE290")]
	private void ICLEDEDGKJH(SkinnedMeshRenderer BFPEPDDOBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD8D0", Offset = "0x6ADC2D0", VA = "0x186ADD8D0")]
	private void HPIMFDFHGDN(List<FCFAMILBOPJ> OFCCOOPFIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA370", Offset = "0x6AD8D70", VA = "0x186ADA370")]
	private void BAOGPCFNDNP(Dictionary<string, POLPOFEBNLM<Texture2D>> MECAOIIIDEC, bool LACMGJCBJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3080", Offset = "0x6AE1A80", VA = "0x186AE3080")]
	private void NNIJGJKFHEL(Dictionary<string, List<DNAMKONLNOL>> MECAOIIIDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD99B0", Offset = "0x6AD83B0", VA = "0x186AD99B0")]
	private void ABFBBMJKIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD5A0", Offset = "0x6ADBFA0", VA = "0x186ADD5A0")]
	private void HCCLAMDJFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB600", Offset = "0x6ADA000", VA = "0x186ADB600")]
	private void DFECPKPIGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0B30", Offset = "0x6ADF530", VA = "0x186AE0B30")]
	private void MJHPPOMIIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC920", Offset = "0x6ADB320", VA = "0x186ADC920")]
	private void GCHNOLGLAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA7F0", Offset = "0x6AD91F0", VA = "0x186ADA7F0")]
	private void CCPCDCLHOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2FB0", Offset = "0x6AE19B0", VA = "0x186AE2FB0")]
	private void NMHILNCHOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDAB0", Offset = "0x6ADC4B0", VA = "0x186ADDAB0")]
	private void HPPAFCDHEKG(bool PIFAGIFFLCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6AE07E0", Offset = "0x6ADF1E0", VA = "0x186AE07E0")]
	private void MANFGPKNNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC520", Offset = "0x6ADAF20", VA = "0x186ADC520")]
	private void EEOJLLDAPIC(bool PIFAGIFFLCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFDF0", Offset = "0x6ADE7F0", VA = "0x186ADFDF0")]
	private void LMGADDCIPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEE30", Offset = "0x6ADD830", VA = "0x186ADEE30")]
	private void KFGNHEEGBIJ(Material HCGFICBNDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9B70", Offset = "0x6AD8570", VA = "0x186AD9B70")]
	private void AEJCMIIIKOO(Material HCGFICBNDDJ, Color KHEKLAKBAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD730", Offset = "0x6ADC130", VA = "0x186ADD730")]
	private void HKHKMJBEMMM(Material HCGFICBNDDJ, Color INFFOOLALEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF300", Offset = "0x6ADDD00", VA = "0x186ADF300")]
	private void KHEPGIOJHPK(Material HCGFICBNDDJ, Color GECFOLMCGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF890", Offset = "0x6ADE290", VA = "0x186ADF890")]
	private void KOPMJNOCLDL(Material HCGFICBNDDJ, Texture2D AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFC30", Offset = "0x6ADE630", VA = "0x186ADFC30")]
	private void LLGMPDABEFA(Material HCGFICBNDDJ, Texture ONPIBOCNDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA5B0", Offset = "0x6AD8FB0", VA = "0x186ADA5B0")]
	private void BJDDJJLKNHF(Action<NJOIGIAEIFG> EINODJLPJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0250", Offset = "0x6ADEC50", VA = "0x186AE0250")]
	private void LPIHPFJIPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBE90", Offset = "0x6ADA890", VA = "0x186ADBE90")]
	private void DLGNBIIJPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAA00", Offset = "0x6AD9400", VA = "0x186ADAA00")]
	private IBILKJCONGN CJEKCBHFMCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB230", Offset = "0x6AD9C30", VA = "0x186ADB230")]
	private void DDELILMCCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF470", Offset = "0x6ADDE70", VA = "0x186ADF470")]
	public void KKEMCGDBMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6AE08B0", Offset = "0x6ADF2B0", VA = "0x186AE08B0")]
	[CompilerGenerated]
	private void MEEFEPDFCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC1F0", Offset = "0x6ADABF0", VA = "0x186ADC1F0")]
	[CompilerGenerated]
	private void DLNEEJMHKCF(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4900", Offset = "0x6AE3300", VA = "0x186AE4900")]
	[CompilerGenerated]
	private void OLGGNIPFIEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5180", Offset = "0x6AE3B80", VA = "0x186AE5180")]
	[CompilerGenerated]
	private void PPECLIDMMIK(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF800", Offset = "0x6ADE200", VA = "0x186ADF800")]
	[CompilerGenerated]
	private void KNNMGMJAODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC9B0", Offset = "0x6ADB3B0", VA = "0x186ADC9B0")]
	[CompilerGenerated]
	private void GDECDNHCGNC(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA140", Offset = "0x6AD8B40", VA = "0x186ADA140")]
	[CompilerGenerated]
	private void ANNPFPOEILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA940", Offset = "0x6AD9340", VA = "0x186ADA940")]
	[CompilerGenerated]
	private void CHMAJOILBIN(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0940", Offset = "0x6ADF340", VA = "0x186AE0940")]
	[CompilerGenerated]
	private void MGFECFGJEOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9B10", Offset = "0x6AD8510", VA = "0x186AD9B10")]
	[CompilerGenerated]
	private void ADFKONFCEBO(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9920", Offset = "0x6AD8320", VA = "0x186AD9920")]
	[CompilerGenerated]
	private void AAONKGOANCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0220", Offset = "0x6ADEC20", VA = "0x186AE0220")]
	[CompilerGenerated]
	private void LPAJJLKNMJF(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA510", Offset = "0x6AD8F10", VA = "0x186ADA510")]
	[CompilerGenerated]
	private void BDHBCGFEDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBDE0", Offset = "0x6ADA7E0", VA = "0x186ADBDE0")]
	[CompilerGenerated]
	private void DJHHONECKNI(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA770", Offset = "0x6AD9170", VA = "0x186ADA770")]
	[CompilerGenerated]
	private void CAHNBJCIPNJ(KeyValuePair<string, POLPOFEBNLM<Texture2D>> ODPLKBJGFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA970", Offset = "0x6AD9370", VA = "0x186ADA970")]
	[CompilerGenerated]
	private void CIMCJMINCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9B40", Offset = "0x6AD8540", VA = "0x186AD9B40")]
	[CompilerGenerated]
	private void AEDFCCGMLDE(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC750", Offset = "0x6ADB150", VA = "0x186ADC750")]
	[CompilerGenerated]
	private void FJMJLEIEONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC220", Offset = "0x6ADAC20", VA = "0x186ADC220")]
	[CompilerGenerated]
	private void DPCEJGJPGGG(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JCIDAIIJICB : HBMOFOAEPNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int EBFLAFKKDOA;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int JFIBDPOGNOL;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int FBGEDAOBIBG;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int OLAAJFPHCGC;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int MFDOKGJLHCE;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int PNNBBEIALND;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int EKDMJLBCLIN;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int BOMNDEDGCKB;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int OKOMKACJPPM;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int NDADNIDAGDK;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int BNECONFMDGF;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int GIHLJJBCALC;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int HOGJCOBLADF;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int EBDCHLGBEFC;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int ANBAJMEAJBK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int GEOFIIJLHKF;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int MLCHMKBLMEI;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int EKLFLEAOCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform JAFKEFEMDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform EOHKGKPGBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform BKJKMMBHCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform KEGDBALJIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Transform IGAICKALIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Transform AIDMCNJKHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Transform EFLDGNGMLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private EPNEOLKGKFE NOMMJLCEHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private MaterialPropertyBlock NKAAHDMLCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private SkinnedMeshRenderer[] BONLDEFGIOI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock HPHIIMJMNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7450", Offset = "0x6AD5E50", VA = "0x186AD7450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CMFCJHGPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6AD74D0", Offset = "0x6AD5ED0", VA = "0x186AD74D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5BA0", Offset = "0x6AD45A0", VA = "0x186AD5BA0", Slot = "7")]
	public void AIFHKOLJDOL(EPNEOLKGKFE LAJMJOEIOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7990", Offset = "0x6AD6390", VA = "0x186AD7990", Slot = "8")]
	public void POEHEEJEBEI(DJLPGLPOCIN JLAGBOFNFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6EA0", Offset = "0x6AD58A0", VA = "0x186AD6EA0", Slot = "5")]
	public void GNJIPMOFJGC(GMCBLBHANHH DPHCBMIDLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5B40", Offset = "0x6AD4540", VA = "0x186AD5B40")]
	private Vector2 AECHAJJFIOH(Vector2 MDIIBEKBDPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5C70", Offset = "0x6AD4670", VA = "0x186AD5C70", Slot = "6")]
	public void BBBMGKKHLAJ(OOLHBCEMDGE JLAGBOFNFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7650", Offset = "0x6AD6050", VA = "0x186AD7650")]
	private void PKLNEIFFHID(OOLHBCEMDGE COALJJCDNNC, IFJHLKJHACL BHMEDJKAJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6DC0", Offset = "0x6AD57C0", VA = "0x186AD6DC0")]
	private void FALLIMHDOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7CC0", Offset = "0x6AD66C0", VA = "0x186AD7CC0")]
	public JCIDAIIJICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7380", Offset = "0x6AD5D80", VA = "0x186AD7380")]
	[CompilerGenerated]
	internal static (float, float) HHCILJNLPOB(float OECBCKBKLOM)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7410", Offset = "0x6AD5E10", VA = "0x186AD7410")]
	[CompilerGenerated]
	internal static Vector4 HHNLEEKMAIM(Vector2 LEELMECKGCG, Vector2 DKEHAFKGJAC)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private FEDCEIEOEHM? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public PELNEICAOKM CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB870", Offset = "0x6AEA270", VA = "0x186AEB870")]
			get
			{
				return default(PELNEICAOKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public FEDCEIEOEHM MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB8A0", Offset = "0x6AEA2A0", VA = "0x186AEB8A0")]
			get
			{
				return default(FEDCEIEOEHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x898850", Offset = "0x897250", VA = "0x180898850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB4E0", Offset = "0x6AE9EE0", VA = "0x186AEB4E0")]
		public Material[] IEAFKEAIBKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB5C0", Offset = "0x6AE9FC0", VA = "0x186AEB5C0")]
		public static void NPLPGNABKIP(AvatarItemMaterial BGHDEKEDABO, Material KFGOIEOLDHF, int HPANIDNNADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB330", Offset = "0x6AE9D30", VA = "0x186AEB330")]
		private static bool DFAJBFMHEBE(AvatarItemMaterial BGHDEKEDABO, int HPANIDNNADA, [Out] Material BFNGLAPEMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB7B0", Offset = "0x6AEA1B0", VA = "0x186AEB7B0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NHFFCNPJGMC]
public struct DCAAAJEPGDI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public POHLBKKJHDB DPCOMNDNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	public int DGKDDBHAJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NECDJLDGFLC PILOCJLELBC;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBDB0", Offset = "0x6AEA7B0", VA = "0x186AEBDB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[NHFFCNPJGMC]
public struct NECDJLDGFLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Vector3> DJGDLHMNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<Vector3> JNHDPLLEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<Vector4> KPEAPECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public NativeArray<Vector2> LKMGDFCFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public NativeArray<Vector2> EJJNDJNHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<Vector2> BAGIALOKMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public NativeArray<Vector2> OCJPBLDDJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public NativeArray<Color> BDKFBABMLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<int> DBGPEKBLMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public NativeArray<int> OGELDPFJLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private NativeArray<int> LGJINPCECFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private NativeArray<int> HNOJGGHOKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public NativeArray<int> ECFKGLNBMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public NativeArray<int> IEDLMINIJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<int> LJJCPCCEDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<BoneWeight> DMKPGFDBGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private NativeArray<int> FCDCCFDNJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool OLPEDEELBCN;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int HANEOHLCILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFF10", Offset = "0x6AEE910", VA = "0x186AEFF10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFF00", Offset = "0x6AEE900", VA = "0x186AEFF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JLECLGBCMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFFE0", Offset = "0x6AEE9E0", VA = "0x186AEFFE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6AEF820", Offset = "0x6AEE220", VA = "0x186AEF820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BIHIJFKOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFEF0", Offset = "0x6AEE8F0", VA = "0x186AEFEF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6AEFFF0", Offset = "0x6AEE9F0", VA = "0x186AEFFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF01C0", Offset = "0x6AEEBC0", VA = "0x186AF01C0")]
	public NECDJLDGFLC(int MHLEDOPNJJB, int GBLGHDDGKKH, int IACKLHFPLBG, int NDDGOLHNMMJ, Allocator NPNPKHEIOHB, int OBCDFNDLGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFF20", Offset = "0x6AEE920", VA = "0x186AEFF20")]
	public void LGLHHLDLMKA(int HGFDMIDEFHN, Vector3 LEKEIHPCIEI, Vector3 ODPGHJEEHCK, Vector4 KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0020", Offset = "0x6AEEA20", VA = "0x186AF0020")]
	public void PNNADMAMNGE(int HGFDMIDEFHN, BoneWeight PEGIGPBPPOP, NativeSlice<byte> NLPIKJKCGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFE90", Offset = "0x6AEE890", VA = "0x186AEFE90")]
	public Color ICFILIICPIM(int HGFDMIDEFHN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0000", Offset = "0x6AEEA00", VA = "0x186AF0000")]
	public void OHJPEPKHHKE(int HGFDMIDEFHN, Color DMIBFACOBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFF90", Offset = "0x6AEE990", VA = "0x186AEFF90")]
	public void NDMICBBMJHB(byte ABJCANHBLFI, int HGFDMIDEFHN, Vector2 HPJCHPFIKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFEE0", Offset = "0x6AEE8E0", VA = "0x186AEFEE0")]
	public void IODPEOKFHBC(int HGFDMIDEFHN, int AOLDBHBMPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFEB0", Offset = "0x6AEE8B0", VA = "0x186AEFEB0")]
	public bool IJADCAINAHD(int ABJCANHBLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFDC0", Offset = "0x6AEE7C0", VA = "0x186AEFDC0")]
	public void ICEHCMACBJI(int LOMGCOBFHAA, int IEHCONIHMPO, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF770", Offset = "0x6AEE170", VA = "0x186AEF770")]
	public int[] BMGAHDNKKDM(int LOMGCOBFHAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFD30", Offset = "0x6AEE730", VA = "0x186AEFD30")]
	private NativeSlice<int> GLDFDCKEDMD(int LOMGCOBFHAA)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF830", Offset = "0x6AEE230", VA = "0x186AEF830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF9E0", Offset = "0x6AEE3E0", VA = "0x186AEF9E0")]
	public Mesh EIMJPKFOAMG([Optional] string MCHHHNLFOOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
[NHFFCNPJGMC]
[NativeContainer]
public struct POHLBKKJHDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Vector3> DJGDLHMNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<Vector3> JNHDPLLEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<Vector4> KPEAPECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<Vector2> LKMGDFCFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<Vector2> EJJNDJNHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<Vector2> BAGIALOKMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<Vector2> OCJPBLDDJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<Color> BDKFBABMLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<int> NFMMFFMGNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public NativeArray<int> GEPBGGFKDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public NativeArray<int> DFOCJGINKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public NativeArray<int> JFBPBPFGOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public NativeArray<bool> PDMABNCNBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public NativeArray<int> KMJEELBIBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public NativeArray<int> OELPAGJKBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public NativeArray<BoneWeight> NLAGCMHDAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<Matrix4x4> EHBENHGEBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private NativeArray<int> MHJIJAMOEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private NativeArray<byte> NHLFOFGNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private NativeArray<int> AOJLKJCJJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private NativeArray<int> IIGLGAFMNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public NativeArray<sbyte> HEDFEGAAPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeArray<byte> OEPJHKGFBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> IPDGODICMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool OLPEDEELBCN;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int PAFEIBPNHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2154C90", Offset = "0x2153690", VA = "0x182154C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int DFCHJGCGBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x125FE30", Offset = "0x125E830", VA = "0x18125FE30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int ICADOCLJJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3C50", Offset = "0x6AF2650", VA = "0x186AF3C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int GFBGCLDAHLF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3F10", Offset = "0x6AF2910", VA = "0x186AF3F10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4020", Offset = "0x6AF2A20", VA = "0x186AF4020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int HANEOHLCILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3F00", Offset = "0x6AF2900", VA = "0x186AF3F00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3EF0", Offset = "0x6AF28F0", VA = "0x186AF3EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ELFJBPIHLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3720", Offset = "0x6AF2120", VA = "0x186AF3720")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3EE0", Offset = "0x6AF28E0", VA = "0x186AF3EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BIKBNBBNMKK LPMFIJLEMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4000", Offset = "0x6AF2A00", VA = "0x186AF4000")]
		get
		{
			return default(BIKBNBBNMKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4010", Offset = "0x6AF2A10", VA = "0x186AF4010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte EOCENEKKEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3FF0", Offset = "0x6AF29F0", VA = "0x186AF3FF0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4030", Offset = "0x6AF2A30", VA = "0x186AF4030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NJLCIKHJMDF BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3730", Offset = "0x6AF2130", VA = "0x186AF3730")]
		get
		{
			return default(NJLCIKHJMDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4040", Offset = "0x6AF2A40", VA = "0x186AF4040")]
	public POHLBKKJHDB(IList<Mesh> AJPLJKKAOPN, IList<Matrix4x4> PEMMJFLIMJB, IList<bool> PDMABNCNBKK, byte BDMHPMBHLLJ, IList<byte[]> HICPBOAIIPC, IList<int> HNLKLPJPKEC, IList<bool> NEBDCLJPCED, IList<int> KMJEELBIBCF, IList<int> MLIFMPNEECJ, IList<int> ACLOIEGLKCD, Allocator NPNPKHEIOHB, BIKBNBBNMKK NKHOAFPCLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3F20", Offset = "0x6AF2920", VA = "0x186AF3F20")]
	public NECDJLDGFLC LJPFLAPIMKB(Allocator NPNPKHEIOHB)
	{
		return default(NECDJLDGFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3C80", Offset = "0x6AF2680", VA = "0x186AF3C80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NHFFCNPJGMC]
public class MAHINAELPCL : HEANOGCFGMD
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE9E0", Offset = "0x6AED3E0", VA = "0x186AEE9E0")]
	public POHLBKKJHDB GFDNKDGLHCC()
	{
		return default(POHLBKKJHDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5B30", Offset = "0x6AD4530", VA = "0x186AD5B30")]
	public MAHINAELPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NJLCIKHJMDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Vector3> DJGDLHMNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<Vector3> JNHDPLLEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<Vector4> KPEAPECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<Vector2> LKMGDFCFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<Vector2> EJJNDJNHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeSlice<Vector2> BAGIALOKMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public NativeSlice<Vector2> OCJPBLDDJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public NativeSlice<Color> BDKFBABMLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public NativeSlice<int> HFLIHKOFCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public NativeSlice<int> JFBPBPFGOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public NativeSlice<BoneWeight> NLAGCMHDAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public NativeSlice<byte> KLMKNEGALHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public int AACAGOGPPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Matrix4x4 KAOHGLDIPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public int KLEIINKAELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeSlice<byte> NLPIKJKCGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public bool NOANPIGBJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public int LLOCJOHKGAE;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct DNAMKONLNOL : IEquatable<DNAMKONLNOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	internal readonly Material NJBPHLKMEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	internal readonly GABPAHOMPGH LMAGILEFDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	internal readonly GFPOJCNDFBH OFPNBBFHDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	internal readonly GLHPDDDHLIA DPHDPKFHBAD;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC86C20", VA = "0x180C88220")]
	public DNAMKONLNOL(Material KFGOIEOLDHF, GABPAHOMPGH CIDOJAAGKLI, GFPOJCNDFBH CGGKKLLIJHE, GLHPDDDHLIA NOLHAPCPHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6AECE40", Offset = "0x6AEB840", VA = "0x186AECE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xC87F80", Offset = "0xC86980", VA = "0x180C87F80", Slot = "4")]
	public bool Equals(DNAMKONLNOL PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6AECCC0", Offset = "0x6AEB6C0", VA = "0x186AECCC0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6AECDA0", Offset = "0x6AEB7A0", VA = "0x186AECDA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NJOIGIAEIFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private MaterialPropertyBlock NIJDNJBFGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Color? MCGAFOOCAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Color? GNKMGILODBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Color? GLAHKBKJDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Color? CEMHBAFJENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Color IEBOOHIALLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Color JHKEICODBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Color BCAHPLOOJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Texture2D ILDCBDBLLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Texture2D MANOMCKCGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private Dictionary<DNAMKONLNOL, int> NMFFJMEBPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private GABPAHOMPGH[] JPPNOCPPEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private GFPOJCNDFBH[] NNJCMONBPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector4[] FLNPALMDPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector4[] EMMFKFLDIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Vector4[] HNKHJNOFHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public Vector4[] NKBBIDJJHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Vector4[] FGKLPHFOKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector4[] ALNCKGNKPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<Texture2D> GFEGDFLAEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Vector4[] JKDEOMGNPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private List<Texture2D> MHJFEANIGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private float[] JNAPHOMBLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private Vector4[] HEJPEFIGBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private float[] MLEKDCOIGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float[] LKIMPAAKPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private List<Texture2D> DDHLFPCMLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private float[] NCMLHECPJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private List<Texture2D> GHAMFNOFHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private Vector4[] MCDAFKIJIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private float[] CEMNNKEOCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private Vector4[] MNCONJBOGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public float[] ELMBFCFPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public Texture2DArray DDHEOJBFEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public Texture2DArray FNOOLLJOKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public Texture2DArray DGEECBOPFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public Texture2DArray EIBIPEGLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private bool MIOKMMJNJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private int MDPEKGMEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Vector2? ACLBBFGOGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private TextureFormat FAHFDHKCAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private Vector2? OHMLFGPMDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private TextureFormat EAGBCNNFNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Vector2? ODHPDGEPDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private TextureFormat GJBBMOCKGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Vector2? DDBPCCGEHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private TextureFormat GEGMMOBKHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private bool HHCLANPDDNK;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int GKAILGLOAGL;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int JCDJCAHPLEG;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int DKPBAPKGNOP;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int KPCHICEBFAN;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int DJCCFHFNNBM;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int KBEIEHOIPKI;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int OJCKHPEACHI;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int KMOBIMIKEHJ;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int HAKONKKLGPJ;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int OIPJMNABDIC;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int GFIMMLOIANJ;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int CLLCNCCFJGP;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int HFFHCDOPDJI;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static int LAGFIDIJKKO;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static int PNIFOBENIDJ;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static int OPIOKMHNNJJ;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static int FFNAFHJAMII;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static int GECNMANHJFG;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static int LFBFKMDBMLF;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static int NEGAAADHFNP;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2CC0", Offset = "0x6AF16C0", VA = "0x186AF2CC0")]
	private NJOIGIAEIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2C00", Offset = "0x6AF1600", VA = "0x186AF2C00")]
	public NJOIGIAEIFG(Color GBOCAHMOMJJ, Color EHDBHIEMHCI, Color OEHAACMIHEA, Color? JGEGHKJHAFK, Color? GAHPAFPKPGH, Color? FLMEIALHKKK, Texture2D BPANEMPBHKF, Texture2D PIHEJEAFMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6AF27C0", Offset = "0x6AF11C0", VA = "0x186AF27C0")]
	internal int NIKJAAPFHJG(Material AIJHNMEMCHO, GABPAHOMPGH CIDOJAAGKLI, GFPOJCNDFBH CGGKKLLIJHE, GLHPDDDHLIA NOLHAPCPHHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2730", Offset = "0x6AF1130", VA = "0x186AF2730")]
	private int NIKJAAPFHJG(DNAMKONLNOL LFOBGDLOPID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF07F0", Offset = "0x6AEF1F0", VA = "0x186AF07F0")]
	internal int FDBFHJIJKIE(Material AIJHNMEMCHO, Color GECFOLMCGMM, Color HCPMMFPFJFH, Color JGGBKMPNMLA, Color OMFEKEMHIGG, Color EAENDLBEFOP, Texture2D BAIDCADJNHJ, Vector4 CMGGLHBMOCM, Texture2D JJJLDONACDO, Vector4 GEHNFBAHIIC, float OFHOLNJFPLB, float HKJEFDIEJGE, Texture2D OPEDNHKKIKA, Vector4 PENAFGDKHNB, float FCKBGOIMAAB, Texture2D OBBGMAHOBDP, Color BOMPMFFAGKG, Vector4 HCFPGMGOGKC, GABPAHOMPGH CIDOJAAGKLI, GFPOJCNDFBH CGGKKLLIJHE, GLHPDDDHLIA NOLHAPCPHHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF13C0", Offset = "0x6AEFDC0", VA = "0x186AF13C0")]
	private void JLECILCEEKE(List<Texture2D> GFEGDFLAEKO, [Out] Texture2DArray OOGMKALHBLA, [Out] Texture2DArray CPJGKIANFML, [Out] Texture2DArray PABNDJCICMK, [Out] Texture2DArray CJINILJENNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF25E0", Offset = "0x6AF0FE0", VA = "0x186AF25E0")]
	public void LJEAPIJIBND(Shader CMCFBFNJEIM, Renderer MGJKLBPNDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF1580", Offset = "0x6AEFF80", VA = "0x186AF1580")]
	private void KDHGJMBHGIE(Shader CMCFBFNJEIM, Renderer MGJKLBPNDCE, int MJPACIFMOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2290", Offset = "0x6AF0C90", VA = "0x186AF2290")]
	private Color LAOOOOBGMME(Color GMIOAJGCIBH, GABPAHOMPGH OKCHJHEBDDJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2490", Offset = "0x6AF0E90", VA = "0x186AF2490")]
	private Color LAPNGDIKBEC(Color MGDKNLABFLG, GABPAHOMPGH OKCHJHEBDDJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6AF06B0", Offset = "0x6AEF0B0", VA = "0x186AF06B0")]
	private bool BKFCCGLDLPL(Texture2D MMGHMIMKFJH, GFPOJCNDFBH FMAFCGPMJFK, [Out] Texture2D HMAKJCBONIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0600", Offset = "0x6AEF000", VA = "0x186AF0600")]
	private void BGNPBCKEMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6AF07B0", Offset = "0x6AEF1B0", VA = "0x186AF07B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IBOKLDMGLFO
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class HFHJCJFLOOA : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public HFHJCJFLOOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xC88560", Offset = "0xC86F60", VA = "0x180C88560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6AEE5D0", Offset = "0x6AECFD0", VA = "0x186AEE5D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	public static void HNFJHPFBCIM(string MCAKFNPAKIL, int CLOHFODGPFM, long AFDEELHPLGG, long OPNCPAJMFIB, long ACEABPDLKKL, long JPKMFHLAAIB, long DMDGOCLCAAE, long OGBNJLKNPFJ, long JMHAKEAEKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE690", Offset = "0x6AED090", VA = "0x186AEE690")]
	public static EPGCCCKMEBG MMCMLLODHCJ(JobHandle KDIBOMPFEDM, bool FINHCBNMBLF, bool IENKDKLDEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE620", Offset = "0x6AED020", VA = "0x186AEE620")]
	[IteratorStateMachine(typeof(HFHJCJFLOOA))]
	private static IEnumerator<GJDHNIMFMOA> CHGJMPPBGKK(JobHandle GPPOCIDKPII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MLMJMBGAMPA : MCHGBKDKGEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private NLOACFIFDII IOOLCIKJAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private EEILIJBGPBA HNONDHFHCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private IRecRoomQualityConfigProvider FFJDDMGNMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private bool OLPEDEELBCN;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF160", Offset = "0x6AEDB60", VA = "0x186AEF160")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void NHCNGJDKHBJ(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5E10410", Offset = "0x5E0EE10", VA = "0x185E10410")]
	[UnityEngine.Scripting.Preserve]
	public MLMJMBGAMPA([OLJNBPOCBCJ(null)] EEILIJBGPBA FFCMDNIHHNF, [OLJNBPOCBCJ(null)] NLOACFIFDII HLNJCPAGKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEFA0", Offset = "0x6AED9A0", VA = "0x186AEEFA0")]
	private void IDEPJKKKNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF260", Offset = "0x6AEDC60", VA = "0x186AEF260", Slot = "4")]
	public void OELBFLMPCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEAD0", Offset = "0x6AED4D0", VA = "0x186AEEAD0", Slot = "5")]
	public POLPOFEBNLM<Texture2D> EDAOMIHFJCM(BBHCHJINLEI DKJKDMIOKCP, [Optional] CCNPMMKEMIA FCDCCFDNJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF030", Offset = "0x6AEDA30", VA = "0x186AEF030")]
	private uint IJCICKAJGMC(BBHCHJINLEI DKJKDMIOKCP, CCNPMMKEMIA FCDCCFDNJHM)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface PAMCALHBGMP
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPLAMNGCGIK(Mesh CBNKKMIFMKD, Matrix4x4 NHEPHNDBJMF, byte[] NLPIKJKCGDE, bool MFCNCFKKDDP = false, JAKMGBMNCCH.MGOIBKLDNOG MKKGHCPAFMJ = (JAKMGBMNCCH.MGOIBKLDNOG)0, int KMJEELBIBCF = -1, bool PDMABNCNBKK = false);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCNLFABJEOE(Allocator NPNPKHEIOHB, BIKBNBBNMKK NKHOAFPCLDD, byte BDMHPMBHLLJ, [Optional] IList<int> MLIFMPNEECJ, [Optional] IList<int> COICNJBLAFH);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct ALKPGNKPOMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly GameObject FOGDNDDPAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private readonly AvatarItemMaterial NJGPEFGEGPF;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
	public ALKPGNKPOMI(GameObject FOGDNDDPAEP, AvatarItemMaterial NJGPEFGEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB100", Offset = "0x6AE9B00", VA = "0x186AEB100")]
	public void FBINPBFEDLN(Material KFGOIEOLDHF, int HPANIDNNADA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class GPIBMLKONHH : HPIKJDJNNFG<Task<(GameObject, AvatarItemMaterial)>, ALKPGNKPOMI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct POHBJBLKJMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6AF31B0", Offset = "0x6AF1BB0", VA = "0x186AF31B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6AF36B0", Offset = "0x6AF20B0", VA = "0x186AF36B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private POLPOFEBNLM<GameObject> MOLHPGNEKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private POLPOFEBNLM<AvatarItemMaterial> JFINANMLLBH;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE540", Offset = "0x6AECF40", VA = "0x186AEE540")]
	private GPIBMLKONHH(Task<(GameObject, AvatarItemMaterial)> KECDGIGMBNG, POLPOFEBNLM<GameObject> HMPILACGCON, POLPOFEBNLM<AvatarItemMaterial> LMGIDJJBFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE010", Offset = "0x6AECA10", VA = "0x186AEE010")]
	public static GPIBMLKONHH GMDNOGMNFLF(AssetReference IPNMODLOJND, [Optional] AssetReference DLOLIKIGONK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE420", Offset = "0x6AECE20", VA = "0x186AEE420", Slot = "11")]
	protected override ALKPGNKPOMI MNEGIKDGNGL(Task<(GameObject, AvatarItemMaterial)> NMDMLCAOIKH)
	{
		return default(ALKPGNKPOMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE4C0", Offset = "0x6AECEC0", VA = "0x186AEE4C0", Slot = "12")]
	protected override void OCFKJOBKHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDEE0", Offset = "0x6AEC8E0", VA = "0x186AEDEE0")]
	[AsyncStateMachine(typeof(POHBJBLKJMA))]
	private static Task<(GameObject, AvatarItemMaterial)> EJCJOGNPFPD(Task<GameObject> CMKHAGFOLFB, Task<AvatarItemMaterial> BAGJKEDHOOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NAIPLKIFJBL
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private class GCHFCOEMFPD : HPIKJDJNNFG<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private POLPOFEBNLM<MaterialMapAsset> GPPOCIDKPII;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6AEDE00", Offset = "0x6AEC800", VA = "0x186AEDE00")]
		public GCHFCOEMFPD(POLPOFEBNLM<MaterialMapAsset> GPPOCIDKPII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6AED980", Offset = "0x6AEC380", VA = "0x186AED980", Slot = "11")]
		protected override Material[] MNEGIKDGNGL(Task<MaterialMapAsset> KECDGIGMBNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6AEDDA0", Offset = "0x6AEC7A0", VA = "0x186AEDDA0", Slot = "12")]
		protected override void OCFKJOBKHJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private class IOBEOJBIAFJ : HPIKJDJNNFG<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private List<POLPOFEBNLM<Material>> ALLKFMONBNP;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEE970", Offset = "0x6AED370", VA = "0x186AEE970")]
		public IOBEOJBIAFJ(Task<Material[]> KECDGIGMBNG, List<POLPOFEBNLM<Material>> ALLKFMONBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6AEE7E0", Offset = "0x6AED1E0", VA = "0x186AEE7E0", Slot = "11")]
		protected override Material[] MNEGIKDGNGL(Task<Material[]> NMDMLCAOIKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6AEE830", Offset = "0x6AED230", VA = "0x186AEE830", Slot = "12")]
		protected override void OCFKJOBKHJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF2E0", Offset = "0x6AEDCE0", VA = "0x186AEF2E0")]
	public static POLPOFEBNLM<Material[]> EDCFALHKFMH(AssetReference[] NCNFLBCFFNG)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5890", Offset = "0x6AF4290", VA = "0x186AF5890")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct CKAJLHFGIBE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public AsyncTaskMethodBuilder<OJKMAKKPOEK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			private TaskAwaiter<OJKMAKKPOEK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB960", Offset = "0x6AEA360", VA = "0x186AEB960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x6AEBD40", Offset = "0x6AEA740", VA = "0x186AEBD40", Slot = "5")]
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
		private Dictionary<DFIACMOLAPM, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private Dictionary<DFIACMOLAPM, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private Dictionary<DFIACMOLAPM, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private Dictionary<DFIACMOLAPM, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private readonly Dictionary<DFIACMOLAPM, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private OJKMAKKPOEK _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private OJKMAKKPOEK _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6AED950", Offset = "0x6AEC350", VA = "0x186AED950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6AED100", Offset = "0x6AEBB00", VA = "0x186AED100")]
		public OJKMAKKPOEK CAAGAFNGFEC(MMBBNHOOGFA KLAGAOLBONF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6AED710", Offset = "0x6AEC110", VA = "0x186AED710")]
		[AsyncStateMachine(typeof(CKAJLHFGIBE))]
		public Task<OJKMAKKPOEK> KDMBLEJFMON(int? PHNNIPLCINI, int PNGADIHBOKA, int IMHJOCILKDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6AED060", Offset = "0x6AEBA60", VA = "0x186AED060")]
		public NoseFaceOption AJIELDICKAM(int CEJGMHBAEAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6AED3C0", Offset = "0x6AEBDC0", VA = "0x186AED3C0")]
		public SelectableFaceOption GFCOGPNGELK(FaceFeatureType KDLEIJBEDLO, DFIACMOLAPM HHLFIMLCCJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6AED840", Offset = "0x6AEC240", VA = "0x186AED840")]
		public int PIHOEIGCOOB(DFIACMOLAPM HHLFIMLCCJH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6AED190", Offset = "0x6AEBB90", VA = "0x186AED190")]
		private void EPFGJKAFDIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F650", Offset = "0x2D9E050", VA = "0x182D9F650")]
		private void GIKMHPOMLCC<T>(IDictionary<DFIACMOLAPM, T> HGEMHLLLPMH, IReadOnlyList<T> MCCJAGABPKN) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6AED660", Offset = "0x6AEC060", VA = "0x186AED660")]
		public DFIACMOLAPM JDMPCEDLMGF(FaceFeatureType KDLEIJBEDLO)
		{
			return default(DFIACMOLAPM);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6AED540", Offset = "0x6AEBF40", VA = "0x186AED540")]
		public DFIACMOLAPM HBDJECNPDDJ(FaceFeatureType KDLEIJBEDLO)
		{
			return default(DFIACMOLAPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6AED8C0", Offset = "0x6AEC2C0", VA = "0x186AED8C0")]
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
