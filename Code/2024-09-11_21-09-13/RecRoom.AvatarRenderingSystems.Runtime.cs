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
		[Cpp2IlInjected.Address(RVA = "0x69F5490", Offset = "0x69F3A90", VA = "0x1869F5490", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A06770", Offset = "0x6A04D70", VA = "0x186A06770", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
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
			[Cpp2IlInjected.Address(RVA = "0x887AA0", Offset = "0x8860A0", VA = "0x180887AA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6A05EA0", Offset = "0x6A044A0", VA = "0x186A05EA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A05DD0", Offset = "0x6A043D0", VA = "0x186A05DD0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A05E60", Offset = "0x6A04460", VA = "0x186A05E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x88B6B0", Offset = "0x889CB0", VA = "0x18088B6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A05EE0", Offset = "0x6A044E0", VA = "0x186A05EE0")]
		public static RecNetCDNKey DKOOBCOMLMA(string HDCCEEPNAJF, string EAJPOHDKMOI = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61FBB70", Offset = "0x61FA170", VA = "0x1861FBB70")]
		public void EEBMOLCBBLP(string PMLFAIIFKFO, string DOAOBIHCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A05FE0", Offset = "0x6A045E0", VA = "0x186A05FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69F0C80", Offset = "0x69EF280", VA = "0x1869F0C80", Slot = "4")]
	public void DPLAMNGCGIK(Mesh CBNKKMIFMKD, Matrix4x4 NHEPHNDBJMF, byte[] NLPIKJKCGDE, bool MFCNCFKKDDP = false, JAKMGBMNCCH.MGOIBKLDNOG MKKGHCPAFMJ = (JAKMGBMNCCH.MGOIBKLDNOG)0, int KMJEELBIBCF = -1, bool PDMABNCNBKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69F0E90", Offset = "0x69EF490", VA = "0x1869F0E90", Slot = "5")]
	public void LCNLFABJEOE(Allocator NPNPKHEIOHB, BIKBNBBNMKK NKHOAFPCLDD, byte BDMHPMBHLLJ, [Optional] IList<int> MLIFMPNEECJ, [Optional] IList<int> COICNJBLAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69F0A30", Offset = "0x69EF030", VA = "0x1869F0A30")]
	private static void ABLLFDHAPBF(Mesh CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69F0ED0", Offset = "0x69EF4D0", VA = "0x1869F0ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69F39E0", Offset = "0x69F1FE0", VA = "0x1869F39E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A02C10", Offset = "0x6A01210", VA = "0x186A02C10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A02C00", Offset = "0x6A01200", VA = "0x186A02C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JLECLGBCMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A03060", Offset = "0x6A01660", VA = "0x186A03060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A01560", Offset = "0x69FFB60", VA = "0x186A01560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BIHIJFKOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A02BF0", Offset = "0x6A011F0", VA = "0x186A02BF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A03070", Offset = "0x6A01670", VA = "0x186A03070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JBAGGOLDPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A02710", Offset = "0x6A00D10", VA = "0x186A02710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A038B0", Offset = "0x6A01EB0", VA = "0x186A038B0")]
	public NIFBFOIEHLJ(int MHLEDOPNJJB, int GBLGHDDGKKH, int IACKLHFPLBG, int NDDGOLHNMMJ, Allocator NPNPKHEIOHB, int OBCDFNDLGIA, PJGPDLJDDJG JGPBFOKLBKM, bool AFMECNNANBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A02C20", Offset = "0x6A01220", VA = "0x186A02C20")]
	public void LGLHHLDLMKA(int HGFDMIDEFHN, Vector3 LEKEIHPCIEI, Vector3 ODPGHJEEHCK, Vector4 KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A03480", Offset = "0x6A01A80", VA = "0x186A03480")]
	public void PNNADMAMNGE(int HGFDMIDEFHN, BoneWeight PEGIGPBPPOP, NativeSlice<byte> NLPIKJKCGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A02850", Offset = "0x6A00E50", VA = "0x186A02850")]
	public Color ICFILIICPIM(int HGFDMIDEFHN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A03080", Offset = "0x6A01680", VA = "0x186A03080")]
	public void OHJPEPKHHKE(int HGFDMIDEFHN, Color DMIBFACOBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A02CB0", Offset = "0x6A012B0", VA = "0x186A02CB0")]
	public void NDMICBBMJHB(byte ABJCANHBLFI, int HGFDMIDEFHN, Vector2 HPJCHPFIKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A02BE0", Offset = "0x6A011E0", VA = "0x186A02BE0")]
	public void IODPEOKFHBC(int HGFDMIDEFHN, int AOLDBHBMPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A02B80", Offset = "0x6A01180", VA = "0x186A02B80")]
	public bool IJADCAINAHD(int ABJCANHBLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A02780", Offset = "0x6A00D80", VA = "0x186A02780")]
	public void ICEHCMACBJI(int LOMGCOBFHAA, int IEHCONIHMPO, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A01570", Offset = "0x69FFB70", VA = "0x186A01570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A017D0", Offset = "0x69FFDD0", VA = "0x186A017D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A04580", Offset = "0x6A02B80", VA = "0x186A04580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DFCHJGCGBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A04570", Offset = "0x6A02B70", VA = "0x186A04570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ICADOCLJJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A047F0", Offset = "0x6A02DF0", VA = "0x186A047F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GFBGCLDAHLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A04A60", Offset = "0x6A03060", VA = "0x186A04A60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A04B70", Offset = "0x6A03170", VA = "0x186A04B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HANEOHLCILB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A04A50", Offset = "0x6A03050", VA = "0x186A04A50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A04A40", Offset = "0x6A03040", VA = "0x186A04A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ELFJBPIHLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A04590", Offset = "0x6A02B90", VA = "0x186A04590")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A04A30", Offset = "0x6A03030", VA = "0x186A04A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BIKBNBBNMKK LPMFIJLEMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A04B50", Offset = "0x6A03150", VA = "0x186A04B50")]
		get
		{
			return default(BIKBNBBNMKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A04B60", Offset = "0x6A03160", VA = "0x186A04B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte EOCENEKKEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A04B40", Offset = "0x6A03140", VA = "0x186A04B40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A04B80", Offset = "0x6A03180", VA = "0x186A04B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public PHMACPGHBAP BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A045A0", Offset = "0x6A02BA0", VA = "0x186A045A0")]
		get
		{
			return default(PHMACPGHBAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A04B90", Offset = "0x6A03190", VA = "0x186A04B90")]
	public PEKJFEHKPPE(IList<Mesh> AJPLJKKAOPN, IList<Matrix4x4> PEMMJFLIMJB, IList<bool> PDMABNCNBKK, byte BDMHPMBHLLJ, IList<byte[]> HICPBOAIIPC, IList<int> HNLKLPJPKEC, IList<bool> NEBDCLJPCED, IList<int> KMJEELBIBCF, IList<int> MLIFMPNEECJ, IList<int> ACLOIEGLKCD, Allocator NPNPKHEIOHB, BIKBNBBNMKK NKHOAFPCLDD, bool AFMECNNANBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A04A70", Offset = "0x6A03070", VA = "0x186A04A70")]
	public NIFBFOIEHLJ LJPFLAPIMKB(Allocator NPNPKHEIOHB, PJGPDLJDDJG JGPBFOKLBKM)
	{
		return default(NIFBFOIEHLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A048C0", Offset = "0x6A02EC0", VA = "0x186A048C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69F14F0", Offset = "0x69EFAF0", VA = "0x1869F14F0")]
	public PEKJFEHKPPE GFDNKDGLHCC()
	{
		return default(PEKJFEHKPPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69F17F0", Offset = "0x69EFDF0", VA = "0x1869F17F0")]
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
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly GLHPDDDHLIA AEPKCJLNNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		protected bool NHJMJADMJHN;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool CJGGLDPBFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool BHGNEICDDEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual JAKMGBMNCCH.MGOIBKLDNOG KLEIINKAELF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "6")]
			get
			{
				return default(JAKMGBMNCCH.MGOIBKLDNOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool NAIFPHABKEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xACA040", Offset = "0xAC8640", VA = "0x180ACA040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool NHAEIKKBDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x16E3960", Offset = "0x16E1F60", VA = "0x1816E3960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IOHOJKLOILA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x69EFAB0", Offset = "0x69EE0B0", VA = "0x1869EFAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool LNIBCJNBIHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x69EFA90", Offset = "0x69EE090", VA = "0x1869EFA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public POLPOFEBNLM<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public HACDLEJFDBB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public HHFBDHEPPFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x69F1100", Offset = "0x69EF700", VA = "0x1869F1100")]
			internal void FBFLJKJIDJD(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly AvatarSkinAssetItem.IDEHBGCIOLK HHMDKMGIHPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly AssetReference GBKGMGCEKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly JAKMGBMNCCH.MGOIBKLDNOG AFCDAOHBJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly DFIACMOLAPM? KPOKHJDKMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Material[] FDAODAFABPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private SkinnedMeshRenderer[] CMBOHHPBHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private AvatarSkinAssetItem HDEMGACHHMN;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override JAKMGBMNCCH.MGOIBKLDNOG KLEIINKAELF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x886FD0", Offset = "0x8855D0", VA = "0x180886FD0", Slot = "6")]
			get
			{
				return default(JAKMGBMNCCH.MGOIBKLDNOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69F0360", Offset = "0x69EE960", VA = "0x1869F0360")]
		public HACDLEJFDBB(AvatarSkinAssetItem.IDEHBGCIOLK MIACGHPGDLD, AssetReference NENGFLFCLLB, Material ECCFNPOHFPE, GLHPDDDHLIA NOLHAPCPHHI, JAKMGBMNCCH.MGOIBKLDNOG EOPONNJBIAI = (JAKMGBMNCCH.MGOIBKLDNOG)0, [Optional] DFIACMOLAPM? DHLLGPMIOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69F0470", Offset = "0x69EEA70", VA = "0x1869F0470")]
		public HACDLEJFDBB(AvatarSkinAssetItem.IDEHBGCIOLK MIACGHPGDLD, AssetReference NENGFLFCLLB, Material ECCFNPOHFPE, JAKMGBMNCCH.MGOIBKLDNOG EOPONNJBIAI = (JAKMGBMNCCH.MGOIBKLDNOG)0, [Optional] DFIACMOLAPM? DHLLGPMIOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x69F0120", Offset = "0x69EE720", VA = "0x1869F0120", Slot = "7")]
		public override EOHNLEPDLDE OPJFOBEHCJC(int[] JEEAMHGBKFO, List<FCFAMILBOPJ> NNHMLNHCDOO, List<FCFAMILBOPJ> LCOJBDPHOMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x69EFE40", Offset = "0x69EE440", VA = "0x1869EFE40", Slot = "8")]
		public override MGCEPBEPFBJ DOOINGOAJDF(uint CLOHFODGPFM, AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69F02F0", Offset = "0x69EE8F0", VA = "0x1869F02F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class ACDONKGIPBJ : DOKJHLECMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly BEICOJMJHMH MDBDPKOMKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private POLPOFEBNLM<ALKPGNKPOMI> JHPNHOKCEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public ALKPGNKPOMI IFDNFHDMBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private POLPOFEBNLM<Material[]> ELMOJDKEOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Material[] BLODNDKDHEI;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool CJGGLDPBFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool BHGNEICDDEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x69EF080", Offset = "0x69ED680", VA = "0x1869EF080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x69EF5C0", Offset = "0x69EDBC0", VA = "0x1869EF5C0")]
		public ACDONKGIPBJ(GLHPDDDHLIA EEILADHJPHD, BEICOJMJHMH IOHLELCHLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x69EF0E0", Offset = "0x69ED6E0", VA = "0x1869EF0E0", Slot = "7")]
		public override EOHNLEPDLDE OPJFOBEHCJC(int[] JEEAMHGBKFO, List<FCFAMILBOPJ> NNHMLNHCDOO, List<FCFAMILBOPJ> LCOJBDPHOMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69EE920", Offset = "0x69ECF20", VA = "0x1869EE920", Slot = "8")]
		public override MGCEPBEPFBJ DOOINGOAJDF(uint CLOHFODGPFM, AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69EEE70", Offset = "0x69ED470", VA = "0x1869EEE70")]
		public MGCEPBEPFBJ KIIEBHGGCOA(GameObject FOGDNDDPAEP, uint CLOHFODGPFM, bool LLGOIEMDJKE, bool GGEJNEEHOFD, AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69EEA50", Offset = "0x69ED050", VA = "0x1869EEA50")]
		public static bool EANDMLPANJC(Renderer[] DEFOCNCNONK, string BJEFKIFLIHD, [Out] Renderer MDPKIBFIKJN, [Out] Renderer IICFNBACCDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69EF570", Offset = "0x69EDB70", VA = "0x1869EF570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x69EEDB0", Offset = "0x69ED3B0", VA = "0x1869EEDB0")]
		private (POLPOFEBNLM<ALKPGNKPOMI>, POLPOFEBNLM<Material[]>) FPMFLNMJIDP()
		{
			return default((POLPOFEBNLM<ALKPGNKPOMI>, POLPOFEBNLM<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x447E460", Offset = "0x447CA60", VA = "0x18447E460")]
		[CompilerGenerated]
		private void EHFDGPMGMMK(ALKPGNKPOMI POBDLJBBBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x887930", Offset = "0x885F30", VA = "0x180887930")]
		[CompilerGenerated]
		private void OBHMINJOMPI(Material[] POBDLJBBBCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ADKPFGBDFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ALFLIOIIDKL avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public IBILKJCONGN buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ADKPFGBDFFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x69EF780", Offset = "0x69EDD80", VA = "0x1869EF780")]
		internal bool MCEAGPGBHHB(BEICOJMJHMH item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x69EF640", Offset = "0x69EDC40", VA = "0x1869EF640")]
		internal void HFKDIBJJALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x69EF620", Offset = "0x69EDC20", VA = "0x1869EF620")]
		internal void EIBIHBNIKBB(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x69EF6F0", Offset = "0x69EDCF0", VA = "0x1869EF6F0")]
		internal void LBDKJKOBODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x69EF660", Offset = "0x69EDC60", VA = "0x1869EF660")]
		internal void INLDBOLOKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		internal EOHNLEPDLDE INEGPBHJJEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ACAJDBNNBBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public ADKPFGBDFFJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ACAJDBNNBBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x69EE860", Offset = "0x69ECE60", VA = "0x1869EE860")]
		internal MPPLOPGDAHM AODGDIPHGMG(int lod)
		{
			return default(MPPLOPGDAHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EHFKKGMKEKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<IBILKJCONGN> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public EHFKKGMKEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x69EFAC0", Offset = "0x69EE0C0", VA = "0x1869EFAC0")]
		internal void BGHDJHKDCDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EONPCLDENBL : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<DOKJHLECMKG> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<IBILKJCONGN> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Func<int, MPPLOPGDAHM> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NJOIGIAEIFG materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public EONPCLDENBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x69EFBF0", Offset = "0x69EE1F0", VA = "0x1869EFBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x69EFDF0", Offset = "0x69EE3F0", VA = "0x1869EFDF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PKBKJJEMLPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public PKBKJJEMLPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A05D80", Offset = "0x6A04380", VA = "0x186A05D80")]
		internal EOHNLEPDLDE IOPEPLEFBAO(DOKJHLECMKG p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class DKDMBHDHLAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public FNDBFEALHLE cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public DKDMBHDHLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D0BE0", Offset = "0x8CF1E0", VA = "0x1808D0BE0")]
		internal void HFDMPFKNNMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xBBBB60", Offset = "0xBBA160", VA = "0x180BBBB60")]
		internal void OFCGBIGBNPN(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IIDNDHFNJJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public IIDNDHFNJJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ONGILCICCFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public NIFBFOIEHLJ defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public PEKJFEHKPPE defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public IIDNDHFNJJB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ONGILCICCFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6A04330", Offset = "0x6A02930", VA = "0x186A04330")]
		internal void MKFNPGFKFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xBBBDC0", Offset = "0xBBA3C0", VA = "0x180BBBDC0")]
		internal void LLJAJANHKMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class ANKCJCHNMPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public NECDJLDGFLC legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public POHLBKKJHDB legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public IIDNDHFNJJB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ANKCJCHNMPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x69EF7D0", Offset = "0x69EDDD0", VA = "0x1869EF7D0")]
		internal void EKILOEEDAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xBB8A00", Offset = "0xBB7000", VA = "0x180BB8A00")]
		internal void PCGBAPCNBIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HAKONFDNOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public KeyValuePair<string, BEICOJMJHMH> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public FNDBFEALHLE cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public BEICOJMJHMH avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public MNENJKEIKJH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HAKONFDNOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x69F05C0", Offset = "0x69EEBC0", VA = "0x1869F05C0")]
		internal EOHNLEPDLDE NENLFDDCMDI(BBHCHJINLEI item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69F0580", Offset = "0x69EEB80", VA = "0x1869F0580")]
		internal void HNODDFHGFHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OCHPMONEILH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public POLPOFEBNLM<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public OCHPMONEILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A042E0", Offset = "0x6A028E0", VA = "0x186A042E0")]
		internal void GJOIGDCIBDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class CAGJCPNNIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public GLHPDDDHLIA overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public CAGJCPNNIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69EFA10", Offset = "0x69EE010", VA = "0x1869EFA10")]
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
	private AdditionalHatData KEOMIDPKBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private FMFJFNMKGFN HNAJNOLKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private FitMeshHemisphere JOFCJJEEMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private PositionAndRotation FECAAELFODI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Material PKOBHAJBKHN;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Material EGHLLPBPGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Dictionary<string, BEICOJMJHMH> DLHFICIMCMF;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int DKOKIHIFNPE;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int DJDADAPKDLG;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int HBAAKKKFGEP;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int CHMALFIPMEF;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int LDIBBEBNMEL;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int ACLKLEDNEHA;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int GPAHLJFKCLD;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int AIIAFOPGEGN;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int OGGAGBAKKHI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int AOLFIKFJCEC;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int GCNBEGOCCBL;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int GMOCHPAIIOH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int KPKFADPCJOL;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int OMAAOGOIBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly GHNLMGKLHKE ANLPCBAENGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly GHNLMGKLHKE BHKEPCAIMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool APICILGEFKN;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static Lazy<LEBBOCDPOJL> MMONEJKNGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Lazy<MKGABAOANDN> JICPBBOIKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Lazy<MCHGBKDKGEC> IKIAJKNAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private GDFLEMFPAMO NOHNCAAACED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private List<Action> HDKHJJBEJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private CCNPMMKEMIA ENHGDEHEIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private SkinnedMeshRenderer[] AIPCLFCOFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int KCFHMFBPHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool LIGIFPEENFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int GPHAHKKIHJG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HHIKDOEMOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x69F63F0", Offset = "0x69F49F0", VA = "0x1869F63F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x69F9040", Offset = "0x69F7640", VA = "0x1869F9040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material HDPGKINAEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x69F7D80", Offset = "0x69F6380", VA = "0x1869F7D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material MMKMEAOKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69FB9F0", Offset = "0x69F9FF0", VA = "0x1869FB9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool IENKDKLDEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MMBBNHOOGFA OAENENEEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3E0", Offset = "0x8F99E0", VA = "0x1808FB3E0", Slot = "21")]
		get
		{
			return default(MMBBNHOOGFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static LEBBOCDPOJL JGGOGAFIBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69F5810", Offset = "0x69F3E10", VA = "0x1869F5810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private MKGABAOANDN LCGDBGCLAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x69F8180", Offset = "0x69F6780", VA = "0x1869F8180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private MCHGBKDKGEC PONPNLELBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x69F8040", Offset = "0x69F6640", VA = "0x1869F8040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private GDFLEMFPAMO GPIHFDLIICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69FC450", Offset = "0x69FAA50", VA = "0x1869FC450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GHNLMGKLHKE EOCFHIOFMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xD2DAF0", Offset = "0xD2C0F0", VA = "0x180D2DAF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GHNLMGKLHKE NAAGCMCAHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x142A6A0", Offset = "0x1428CA0", VA = "0x18142A6A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] OKKAGIADBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC9E9B0", Offset = "0xC9CFB0", VA = "0x180C9E9B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] EJNLLKCNLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x88D6E0", Offset = "0x88BCE0", VA = "0x18088D6E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool FHGDJHGAGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x69F7630", Offset = "0x69F5C30", VA = "0x1869F7630", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation DBMKINDEKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x69F9010", Offset = "0x69F7610", VA = "0x1869F9010", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public JAKMGBMNCCH.MGOIBKLDNOG JPPNAMPBJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88D790", Offset = "0x88BD90", VA = "0x18088D790", Slot = "18")]
		get
		{
			return default(JAKMGBMNCCH.MGOIBKLDNOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int GCBAHIGDCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x233D680", Offset = "0x233BC80", VA = "0x18233D680")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69F6000", Offset = "0x69F4600", VA = "0x1869F6000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool ABDLKGNACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69F7860", Offset = "0x69F5E60", VA = "0x1869F7860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool GFMCJCJABHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A00030", Offset = "0x69FE630", VA = "0x186A00030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A00DB0", Offset = "0x69FF3B0", VA = "0x186A00DB0")]
	public MNENJKEIKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69F5880", Offset = "0x69F3E80", VA = "0x1869F5880", Slot = "28")]
	public void AIFHKOLJDOL(HONBEFLPIDJ OABCPBHPCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69F5C50", Offset = "0x69F4250", VA = "0x1869F5C50", Slot = "29")]
	public void AOBEGDFBGEF(OPAPCMIDHAJ EALPHDIJEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69F6000", Offset = "0x69F4600", VA = "0x1869F6000", Slot = "4")]
	public void MDJBKKDLNHK(int CLOHFODGPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69FB250", Offset = "0x69F9850", VA = "0x1869FB250", Slot = "9")]
	public void KPFEIFMFBMA(GFOGIFDMNJB FMAFCGPMJFK, Texture2D AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69FE9E0", Offset = "0x69FCFE0", VA = "0x1869FE9E0", Slot = "10")]
	public void OELBFLMPCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A001D0", Offset = "0x69FE7D0", VA = "0x186A001D0", Slot = "11")]
	public bool ONCOADGCOPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69F93E0", Offset = "0x69F79E0", VA = "0x1869F93E0", Slot = "8")]
	public void IBNHEHMKGEM(BFLHHFOPLKK OKCHJHEBDDJ, Color? FEHNKBJAMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69FA5F0", Offset = "0x69F8BF0", VA = "0x1869FA5F0")]
	private void KBCNBAFMGJB(Action IOLKPHMAHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x69FB640", Offset = "0x69F9C40", VA = "0x1869FB640", Slot = "5")]
	public void LLHOPECOHPP(BEICOJMJHMH EPOECBLHBPA, Texture AMGHPGDDFLJ, Color LDGJBJLDJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69F9040", Offset = "0x69F7640", VA = "0x1869F9040", Slot = "6")]
	public void HNOELIGPCJN(bool DAOFCFKPKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1801920", Offset = "0x17FFF20", VA = "0x181801920", Slot = "7")]
	public void BNMOMDLPELD(CCNPMMKEMIA FCDCCFDNJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69FEA60", Offset = "0x69FD060", VA = "0x1869FEA60", Slot = "14")]
	public IBILKJCONGN OFAFPBMGCNF(ALFLIOIIDKL DEGOHMKMPKL, bool ENBJOJKEDIJ, int[] BMHAIHPMNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A00790", Offset = "0x69FED90", VA = "0x186A00790", Slot = "15")]
	public void PEGLLNMGGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69F84F0", Offset = "0x69F6AF0", VA = "0x1869F84F0", Slot = "26")]
	public void GKNPIAMHBDN([Optional] FMFJFNMKGFN CMJJLELONED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69F7C40", Offset = "0x69F6240", VA = "0x1869F7C40")]
	private bool EAOPDKNAOEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69F57F0", Offset = "0x69F3DF0", VA = "0x1869F57F0", Slot = "19")]
	public bool AHGAOJJJDBO(JAKMGBMNCCH.MGOIBKLDNOG ADOEJKNOMFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69F77A0", Offset = "0x69F5DA0", VA = "0x1869F77A0")]
	private bool DGLECDJPDKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69FE070", Offset = "0x69FC670", VA = "0x1869FE070")]
	private IBILKJCONGN NEALEJBEFMP(bool ENBJOJKEDIJ, List<DOKJHLECMKG> MPENFNOCBOP, int[] BMHAIHPMNPJ, Func<int, MPPLOPGDAHM> FALOABLCNEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69F92D0", Offset = "0x69F78D0", VA = "0x1869F92D0")]
	[IteratorStateMachine(typeof(EONPCLDENBL))]
	private IEnumerator<GJDHNIMFMOA> IBBBGLGHLIH(bool ENBJOJKEDIJ, List<DOKJHLECMKG> MPENFNOCBOP, int[] BMHAIHPMNPJ, Func<int, MPPLOPGDAHM> FALOABLCNEH, NJOIGIAEIFG PIJDHFGMLNA, Material HCGFICBNDDJ, List<IBILKJCONGN> LODPIDCMFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A00440", Offset = "0x69FEA40", VA = "0x186A00440")]
	private IBILKJCONGN PANDMAIPLEO(List<DOKJHLECMKG> MPENFNOCBOP, int[] BMHAIHPMNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69FC4F0", Offset = "0x69FAAF0", VA = "0x1869FC4F0")]
	private EPGCCCKMEBG NALPFJDFOGB(List<DOKJHLECMKG> MPENFNOCBOP, int CLOHFODGPFM, bool ENBJOJKEDIJ, MPPLOPGDAHM CEEMGDGDBHO, bool JHNHAJFKKDK, NJOIGIAEIFG PIJDHFGMLNA, Material HCGFICBNDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A00990", Offset = "0x69FEF90", VA = "0x186A00990", Slot = "22")]
	public void PJEJPDCHEEK(AvatarFaceShape KOMGNJEMGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69F5B40", Offset = "0x69F4140", VA = "0x1869F5B40", Slot = "23")]
	public void AJDKNFMBPCM(AvatarBodyShape NMCDICFFHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A00340", Offset = "0x69FE940", VA = "0x186A00340", Slot = "25")]
	public void ONOLBJMALDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69F6040", Offset = "0x69F4640", VA = "0x1869F6040", Slot = "24")]
	public void BGIIGPNHIHJ(bool LEHMLDCKFIA, bool BMPJMPGALEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x69F81D0", Offset = "0x69F67D0", VA = "0x1869F81D0")]
	private void FKBHEGDOJOK(SkinnedMeshRenderer OPFEFHBMMKN, int CLOHFODGPFM, Mesh CBNKKMIFMKD, List<Material> CIPPENEAALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69F9AB0", Offset = "0x69F80B0", VA = "0x1869F9AB0")]
	private static Material IKEONLBLABP(Dictionary<DNAMKONLNOL, Material> ODPCBOGBEMK, Material EGLGDAKJDKM, GABPAHOMPGH CIDOJAAGKLI, GFPOJCNDFBH CGGKKLLIJHE, GLHPDDDHLIA NOLHAPCPHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69F5CD0", Offset = "0x69F42D0", VA = "0x1869F5CD0")]
	private static GABPAHOMPGH AOLEDKOAGAP(DOKJHLECMKG IIHEFEHICGN, int CJPMNEPPIBG)
	{
		return default(GABPAHOMPGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69FBD20", Offset = "0x69FA320", VA = "0x1869FBD20")]
	private void LPPLCDDGKOE(int HPANIDNNADA, Material KFGOIEOLDHF, DOKJHLECMKG IIHEFEHICGN, [Out] Texture2D JCEHHJHIMEJ, [Out] Vector4 JEMDANLGOOF, [Out] Texture2D HJKIOHHLCPB, [Out] Texture2D KIBKKDOAMJM, [Out] Texture2D OLGPLHLHDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69F9FB0", Offset = "0x69F85B0", VA = "0x1869F9FB0")]
	private void JEPGJCMMIJP(int HPANIDNNADA, Material KFGOIEOLDHF, DOKJHLECMKG IIHEFEHICGN, [Out] Color GECFOLMCGMM, [Out] Color HCPMMFPFJFH, [Out] Color JGGBKMPNMLA, [Out] Color OMFEKEMHIGG, [Out] Color EAENDLBEFOP, [Out] Color BOMPMFFAGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69F6AB0", Offset = "0x69F50B0", VA = "0x1869F6AB0")]
	private bool DBBCACPDAKG(Material KFGOIEOLDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69F5C00", Offset = "0x69F4200", VA = "0x1869F5C00")]
	private static Material AMOKNDIBFFH(int HPANIDNNADA, ACDONKGIPBJ IIHEFEHICGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69F8090", Offset = "0x69F6690", VA = "0x1869F8090")]
	private static GFPOJCNDFBH FGCKAPNBMFN(DOKJHLECMKG IIHEFEHICGN, int CJPMNEPPIBG)
	{
		return default(GFPOJCNDFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69F9CD0", Offset = "0x69F82D0", VA = "0x1869F9CD0")]
	private static void JENIJCHFMCO(Dictionary<string, List<DNAMKONLNOL>> MECAOIIIDEC, DOKJHLECMKG ICIPCKBNAJK, Material EGLGDAKJDKM, GABPAHOMPGH OKCHJHEBDDJ, GFPOJCNDFBH FMAFCGPMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69F97E0", Offset = "0x69F7DE0", VA = "0x1869F97E0")]
	private static SkinnedMeshRenderer IBPDGDANMNO(Transform KAGPFNBINEG, Transform NBLDBLADKCD, SkinnedMeshRenderer[] DEFOCNCNONK, int CLOHFODGPFM, MPPLOPGDAHM CEEMGDGDBHO, bool ENBJOJKEDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69FE6D0", Offset = "0x69FCCD0", VA = "0x1869FE6D0")]
	private void NHEHNIJAKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69FB4E0", Offset = "0x69F9AE0", VA = "0x1869FB4E0")]
	private void LGCAAEOFNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69FA490", Offset = "0x69F8A90", VA = "0x1869FA490")]
	private static void JPJBFDJHAPC(Dictionary<DNAMKONLNOL, Material> ODPCBOGBEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69FC220", Offset = "0x69FA820", VA = "0x1869FC220")]
	private static void MIKHMJPDCMH(Dictionary<Renderer, NJOIGIAEIFG> LOJNKOLBLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69F83A0", Offset = "0x69F69A0", VA = "0x1869F83A0")]
	private void GFJHGHPJAGJ(SkinnedMeshRenderer[] DEFOCNCNONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69F9A10", Offset = "0x69F8010", VA = "0x1869F9A10")]
	private void ICLEDEDGKJH(SkinnedMeshRenderer BFPEPDDOBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69F9050", Offset = "0x69F7650", VA = "0x1869F9050")]
	private void HPIMFDFHGDN(List<FCFAMILBOPJ> OFCCOOPFIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69F5E80", Offset = "0x69F4480", VA = "0x1869F5E80")]
	private void BAOGPCFNDNP(Dictionary<string, POLPOFEBNLM<Texture2D>> MECAOIIIDEC, bool LACMGJCBJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x69FE960", Offset = "0x69FCF60", VA = "0x1869FE960")]
	private void NNIJGJKFHEL(Dictionary<string, List<DNAMKONLNOL>> MECAOIIIDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69F5520", Offset = "0x69F3B20", VA = "0x1869F5520")]
	private void ABFBBMJKIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x69F8D10", Offset = "0x69F7310", VA = "0x1869F8D10")]
	private void HCCLAMDJFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69F70E0", Offset = "0x69F56E0", VA = "0x1869F70E0")]
	private void DFECPKPIGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69FC380", Offset = "0x69FA980", VA = "0x1869FC380")]
	private void MJHPPOMIIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x69F8310", Offset = "0x69F6910", VA = "0x1869F8310")]
	private void GCHNOLGLAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69F62A0", Offset = "0x69F48A0", VA = "0x1869F62A0")]
	private void CCPCDCLHOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69FE890", Offset = "0x69FCE90", VA = "0x1869FE890")]
	private void NMHILNCHOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69F9230", Offset = "0x69F7830", VA = "0x1869F9230")]
	private void HPPAFCDHEKG(bool PIFAGIFFLCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69FC130", Offset = "0x69FA730", VA = "0x1869FC130")]
	private void MANFGPKNNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x69F7F10", Offset = "0x69F6510", VA = "0x1869F7F10")]
	private void EEOJLLDAPIC(bool PIFAGIFFLCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69FB6B0", Offset = "0x69F9CB0", VA = "0x1869FB6B0")]
	private void LMGADDCIPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x69FA700", Offset = "0x69F8D00", VA = "0x1869FA700")]
	private void KFGNHEEGBIJ(Material HCGFICBNDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69F5680", Offset = "0x69F3C80", VA = "0x1869F5680")]
	private void AEJCMIIIKOO(Material HCGFICBNDDJ, Color KHEKLAKBAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x69F8EA0", Offset = "0x69F74A0", VA = "0x1869F8EA0")]
	private void HKHKMJBEMMM(Material HCGFICBNDDJ, Color INFFOOLALEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69FABD0", Offset = "0x69F91D0", VA = "0x1869FABD0")]
	private void KHEPGIOJHPK(Material HCGFICBNDDJ, Color GECFOLMCGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69FB0D0", Offset = "0x69F96D0", VA = "0x1869FB0D0")]
	private void KOPMJNOCLDL(Material HCGFICBNDDJ, Texture2D AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x69FB4F0", Offset = "0x69F9AF0", VA = "0x1869FB4F0")]
	private void LLGMPDABEFA(Material HCGFICBNDDJ, Texture ONPIBOCNDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x69F6050", Offset = "0x69F4650", VA = "0x1869F6050")]
	private void BJDDJJLKNHF(Action<NJOIGIAEIFG> EINODJLPJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x69FBB70", Offset = "0x69FA170", VA = "0x1869FBB70")]
	private void LPIHPFJIPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x69F78E0", Offset = "0x69F5EE0", VA = "0x1869F78E0")]
	private void DLGNBIIJPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x69F6490", Offset = "0x69F4A90", VA = "0x1869F6490")]
	private IBILKJCONGN CJEKCBHFMCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x69F6D10", Offset = "0x69F5310", VA = "0x1869F6D10")]
	private void DDELILMCCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x69FAD40", Offset = "0x69F9340", VA = "0x1869FAD40")]
	public void KKEMCGDBMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69F7FB0", Offset = "0x69F65B0", VA = "0x1869F7FB0")]
	[CompilerGenerated]
	private void EKKDCHEEMMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x69FE9B0", Offset = "0x69FCFB0", VA = "0x1869FE9B0")]
	[CompilerGenerated]
	private void ODFGCIACDPD(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A00700", Offset = "0x69FED00", VA = "0x186A00700")]
	[CompilerGenerated]
	private void PDEFFDLODKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x69F6020", Offset = "0x69F4620", VA = "0x1869F6020")]
	[CompilerGenerated]
	private void BGEOINBHKKM(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69F9C10", Offset = "0x69F8210", VA = "0x1869F9C10")]
	[CompilerGenerated]
	private void IOMJMBJMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69FC200", Offset = "0x69FA800", VA = "0x1869FC200")]
	[CompilerGenerated]
	private void MHFFINHMFLF(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x69F6210", Offset = "0x69F4810", VA = "0x1869F6210")]
	[CompilerGenerated]
	private void CCEBGFOLAAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A00A50", Offset = "0x69FF050", VA = "0x186A00A50")]
	[CompilerGenerated]
	private void PJHKFGDMIEB(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69F6400", Offset = "0x69F4A00", VA = "0x1869F6400")]
	[CompilerGenerated]
	private void CIFDMKAEPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69FBCF0", Offset = "0x69FA2F0", VA = "0x1869FBCF0")]
	[CompilerGenerated]
	private void LPMCMCAGGFI(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69FA670", Offset = "0x69F8C70", VA = "0x1869FA670")]
	[CompilerGenerated]
	private void KCAIMLOOMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69F6A80", Offset = "0x69F5080", VA = "0x1869F6A80")]
	[CompilerGenerated]
	private void CNCKILPDNAN(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x69FBAE0", Offset = "0x69FA0E0", VA = "0x1869FBAE0")]
	[CompilerGenerated]
	private void LNKNOEDMGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x69F8CE0", Offset = "0x69F72E0", VA = "0x1869F8CE0")]
	[CompilerGenerated]
	private void GNDMPFNDELA(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69FB460", Offset = "0x69F9A60", VA = "0x1869FB460")]
	[CompilerGenerated]
	private void LCMPGJBOFHK(KeyValuePair<string, POLPOFEBNLM<Texture2D>> ODPLKBJGFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x69FE640", Offset = "0x69FCC40", VA = "0x1869FE640")]
	[CompilerGenerated]
	private void NGNJBLCGCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x69F84C0", Offset = "0x69F6AC0", VA = "0x1869F84C0")]
	[CompilerGenerated]
	private void GFPFMEHFKAM(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69F5DF0", Offset = "0x69F43F0", VA = "0x1869F5DF0")]
	[CompilerGenerated]
	private void AONIDCELBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69F9CA0", Offset = "0x69F82A0", VA = "0x1869F9CA0")]
	[CompilerGenerated]
	private void JDGHAPKJAPD(NJOIGIAEIFG FEHJAHNFEHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JCIDAIIJICB : HBMOFOAEPNJ
{
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int EBFLAFKKDOA;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int JFIBDPOGNOL;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int FBGEDAOBIBG;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int OLAAJFPHCGC;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int MFDOKGJLHCE;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int PNNBBEIALND;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int EKDMJLBCLIN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int BOMNDEDGCKB;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int OKOMKACJPPM;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int NDADNIDAGDK;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int BNECONFMDGF;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int GIHLJJBCALC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int HOGJCOBLADF;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int EBDCHLGBEFC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int ANBAJMEAJBK;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int GEOFIIJLHKF;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int MLCHMKBLMEI;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int EKLFLEAOCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform JAFKEFEMDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform EOHKGKPGBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform BKJKMMBHCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform KEGDBALJIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform IGAICKALIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform AIDMCNJKHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform EFLDGNGMLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private EPNEOLKGKFE NOMMJLCEHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private MaterialPropertyBlock NKAAHDMLCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private SkinnedMeshRenderer[] BONLDEFGIOI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock HPHIIMJMNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69F3110", Offset = "0x69F1710", VA = "0x1869F3110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CMFCJHGPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x69F3190", Offset = "0x69F1790", VA = "0x1869F3190", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69F1860", Offset = "0x69EFE60", VA = "0x1869F1860", Slot = "7")]
	public void AIFHKOLJDOL(EPNEOLKGKFE LAJMJOEIOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x69F3650", Offset = "0x69F1C50", VA = "0x1869F3650", Slot = "8")]
	public void POEHEEJEBEI(DJLPGLPOCIN JLAGBOFNFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x69F2B60", Offset = "0x69F1160", VA = "0x1869F2B60", Slot = "5")]
	public void GNJIPMOFJGC(GMCBLBHANHH DPHCBMIDLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x69F1800", Offset = "0x69EFE00", VA = "0x1869F1800")]
	private Vector2 AECHAJJFIOH(Vector2 MDIIBEKBDPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x69F1930", Offset = "0x69EFF30", VA = "0x1869F1930", Slot = "6")]
	public void BBBMGKKHLAJ(OOLHBCEMDGE JLAGBOFNFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x69F3310", Offset = "0x69F1910", VA = "0x1869F3310")]
	private void PKLNEIFFHID(OOLHBCEMDGE COALJJCDNNC, IFJHLKJHACL BHMEDJKAJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69F2A80", Offset = "0x69F1080", VA = "0x1869F2A80")]
	private void FALLIMHDOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69F3980", Offset = "0x69F1F80", VA = "0x1869F3980")]
	public JCIDAIIJICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x69F3040", Offset = "0x69F1640", VA = "0x1869F3040")]
	[CompilerGenerated]
	internal static (float, float) HHCILJNLPOB(float OECBCKBKLOM)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x69F30D0", Offset = "0x69F16D0", VA = "0x1869F30D0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private FEDCEIEOEHM? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public PELNEICAOKM CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6A070B0", Offset = "0x6A056B0", VA = "0x186A070B0")]
			get
			{
				return default(PELNEICAOKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public FEDCEIEOEHM MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6A070E0", Offset = "0x6A056E0", VA = "0x186A070E0")]
			get
			{
				return default(FEDCEIEOEHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8868B0", Offset = "0x884EB0", VA = "0x1808868B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x886850", Offset = "0x884E50", VA = "0x180886850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A06D20", Offset = "0x6A05320", VA = "0x186A06D20")]
		public Material[] IEAFKEAIBKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A06E00", Offset = "0x6A05400", VA = "0x186A06E00")]
		public static void NPLPGNABKIP(AvatarItemMaterial BGHDEKEDABO, Material KFGOIEOLDHF, int HPANIDNNADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A06B70", Offset = "0x6A05170", VA = "0x186A06B70")]
		private static bool DFAJBFMHEBE(AvatarItemMaterial BGHDEKEDABO, int HPANIDNNADA, [Out] Material BFNGLAPEMCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A06FF0", Offset = "0x6A055F0", VA = "0x186A06FF0")]
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
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	public POHLBKKJHDB DPCOMNDNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	public int DGKDDBHAJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public NECDJLDGFLC PILOCJLELBC;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A071A0", Offset = "0x6A057A0", VA = "0x186A071A0", Slot = "4")]
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
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector3> DJGDLHMNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector3> JNHDPLLEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector4> KPEAPECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> LKMGDFCFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Vector2> EJJNDJNHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<Vector2> BAGIALOKMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<Vector2> OCJPBLDDJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public NativeArray<Color> BDKFBABMLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public NativeArray<int> DBGPEKBLMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> OGELDPFJLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private NativeArray<int> LGJINPCECFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private NativeArray<int> HNOJGGHOKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<int> ECFKGLNBMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public NativeArray<int> IEDLMINIJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public NativeArray<int> LJJCPCCEDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<BoneWeight> DMKPGFDBGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private NativeArray<int> FCDCCFDNJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private bool OLPEDEELBCN;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int HANEOHLCILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B2C0", Offset = "0x6A098C0", VA = "0x186A0B2C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B2B0", Offset = "0x6A098B0", VA = "0x186A0B2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JLECLGBCMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B390", Offset = "0x6A09990", VA = "0x186A0B390")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A0ABD0", Offset = "0x6A091D0", VA = "0x186A0ABD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BIHIJFKOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B2A0", Offset = "0x6A098A0", VA = "0x186A0B2A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B3A0", Offset = "0x6A099A0", VA = "0x186A0B3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B570", Offset = "0x6A09B70", VA = "0x186A0B570")]
	public NECDJLDGFLC(int MHLEDOPNJJB, int GBLGHDDGKKH, int IACKLHFPLBG, int NDDGOLHNMMJ, Allocator NPNPKHEIOHB, int OBCDFNDLGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B2D0", Offset = "0x6A098D0", VA = "0x186A0B2D0")]
	public void LGLHHLDLMKA(int HGFDMIDEFHN, Vector3 LEKEIHPCIEI, Vector3 ODPGHJEEHCK, Vector4 KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B3D0", Offset = "0x6A099D0", VA = "0x186A0B3D0")]
	public void PNNADMAMNGE(int HGFDMIDEFHN, BoneWeight PEGIGPBPPOP, NativeSlice<byte> NLPIKJKCGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B240", Offset = "0x6A09840", VA = "0x186A0B240")]
	public Color ICFILIICPIM(int HGFDMIDEFHN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B3B0", Offset = "0x6A099B0", VA = "0x186A0B3B0")]
	public void OHJPEPKHHKE(int HGFDMIDEFHN, Color DMIBFACOBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B340", Offset = "0x6A09940", VA = "0x186A0B340")]
	public void NDMICBBMJHB(byte ABJCANHBLFI, int HGFDMIDEFHN, Vector2 HPJCHPFIKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B290", Offset = "0x6A09890", VA = "0x186A0B290")]
	public void IODPEOKFHBC(int HGFDMIDEFHN, int AOLDBHBMPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B260", Offset = "0x6A09860", VA = "0x186A0B260")]
	public bool IJADCAINAHD(int ABJCANHBLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B170", Offset = "0x6A09770", VA = "0x186A0B170")]
	public void ICEHCMACBJI(int LOMGCOBFHAA, int IEHCONIHMPO, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A0AB20", Offset = "0x6A09120", VA = "0x186A0AB20")]
	public int[] BMGAHDNKKDM(int LOMGCOBFHAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B0E0", Offset = "0x6A096E0", VA = "0x186A0B0E0")]
	private NativeSlice<int> GLDFDCKEDMD(int LOMGCOBFHAA)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6A0ABE0", Offset = "0x6A091E0", VA = "0x186A0ABE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0AD90", Offset = "0x6A09390", VA = "0x186A0AD90")]
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
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector3> DJGDLHMNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector3> JNHDPLLEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector4> KPEAPECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> LKMGDFCFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Vector2> EJJNDJNHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<Vector2> BAGIALOKMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<Vector2> OCJPBLDDJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<Color> BDKFBABMLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> NFMMFFMGNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<int> GEPBGGFKDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> DFOCJGINKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> JFBPBPFGOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<bool> PDMABNCNBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public NativeArray<int> KMJEELBIBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public NativeArray<int> OELPAGJKBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public NativeArray<BoneWeight> NLAGCMHDAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<Matrix4x4> EHBENHGEBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> MHJIJAMOEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeArray<byte> NHLFOFGNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeArray<int> AOJLKJCJJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> IIGLGAFMNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public NativeArray<sbyte> HEDFEGAAPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public NativeArray<byte> OEPJHKGFBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private NativeArray<int> IPDGODICMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool OLPEDEELBCN;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int PAFEIBPNHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x20E3390", Offset = "0x20E1990", VA = "0x1820E3390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int DFCHJGCGBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x11AE4E0", Offset = "0x11ACAE0", VA = "0x1811AE4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int ICADOCLJJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F3B0", Offset = "0x6A0D9B0", VA = "0x186A0F3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int GFBGCLDAHLF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F670", Offset = "0x6A0DC70", VA = "0x186A0F670")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F780", Offset = "0x6A0DD80", VA = "0x186A0F780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int HANEOHLCILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F660", Offset = "0x6A0DC60", VA = "0x186A0F660")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F650", Offset = "0x6A0DC50", VA = "0x186A0F650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ELFJBPIHLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A0EE80", Offset = "0x6A0D480", VA = "0x186A0EE80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F640", Offset = "0x6A0DC40", VA = "0x186A0F640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BIKBNBBNMKK LPMFIJLEMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F760", Offset = "0x6A0DD60", VA = "0x186A0F760")]
		get
		{
			return default(BIKBNBBNMKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F770", Offset = "0x6A0DD70", VA = "0x186A0F770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte EOCENEKKEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F750", Offset = "0x6A0DD50", VA = "0x186A0F750")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F790", Offset = "0x6A0DD90", VA = "0x186A0F790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NJLCIKHJMDF BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6A0EE90", Offset = "0x6A0D490", VA = "0x186A0EE90")]
		get
		{
			return default(NJLCIKHJMDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F7A0", Offset = "0x6A0DDA0", VA = "0x186A0F7A0")]
	public POHLBKKJHDB(IList<Mesh> AJPLJKKAOPN, IList<Matrix4x4> PEMMJFLIMJB, IList<bool> PDMABNCNBKK, byte BDMHPMBHLLJ, IList<byte[]> HICPBOAIIPC, IList<int> HNLKLPJPKEC, IList<bool> NEBDCLJPCED, IList<int> KMJEELBIBCF, IList<int> MLIFMPNEECJ, IList<int> ACLOIEGLKCD, Allocator NPNPKHEIOHB, BIKBNBBNMKK NKHOAFPCLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F680", Offset = "0x6A0DC80", VA = "0x186A0F680")]
	public NECDJLDGFLC LJPFLAPIMKB(Allocator NPNPKHEIOHB)
	{
		return default(NECDJLDGFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F3E0", Offset = "0x6A0D9E0", VA = "0x186A0F3E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NHFFCNPJGMC]
public class MAHINAELPCL : HEANOGCFGMD
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6A09D90", Offset = "0x6A08390", VA = "0x186A09D90")]
	public POHLBKKJHDB GFDNKDGLHCC()
	{
		return default(POHLBKKJHDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x69F17F0", Offset = "0x69EFDF0", VA = "0x1869F17F0")]
	public MAHINAELPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NJLCIKHJMDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector3> DJGDLHMNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector3> JNHDPLLEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector4> KPEAPECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> LKMGDFCFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Vector2> EJJNDJNHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<Vector2> BAGIALOKMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<Vector2> OCJPBLDDJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<Color> BDKFBABMLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<int> HFLIHKOFCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeSlice<int> JFBPBPFGOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public NativeSlice<BoneWeight> NLAGCMHDAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public NativeSlice<byte> KLMKNEGALHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public int AACAGOGPPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Matrix4x4 KAOHGLDIPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int KLEIINKAELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public NativeSlice<byte> NLPIKJKCGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public bool NOANPIGBJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public int LLOCJOHKGAE;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct DNAMKONLNOL : IEquatable<DNAMKONLNOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly Material NJBPHLKMEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	internal readonly GABPAHOMPGH LMAGILEFDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	internal readonly GFPOJCNDFBH OFPNBBFHDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	internal readonly GLHPDDDHLIA DPHDPKFHBAD;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xB9AFC0", Offset = "0xB995C0", VA = "0x180B9AFC0")]
	public DNAMKONLNOL(Material KFGOIEOLDHF, GABPAHOMPGH CIDOJAAGKLI, GFPOJCNDFBH CGGKKLLIJHE, GLHPDDDHLIA NOLHAPCPHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6A08230", Offset = "0x6A06830", VA = "0x186A08230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xB9AD20", Offset = "0xB99320", VA = "0x180B9AD20", Slot = "4")]
	public bool Equals(DNAMKONLNOL PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6A080B0", Offset = "0x6A066B0", VA = "0x186A080B0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6A08190", Offset = "0x6A06790", VA = "0x186A08190", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NJOIGIAEIFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private MaterialPropertyBlock NIJDNJBFGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? MCGAFOOCAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color? GNKMGILODBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color? GLAHKBKJDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color? CEMHBAFJENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Color IEBOOHIALLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Color JHKEICODBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Color BCAHPLOOJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Texture2D ILDCBDBLLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Texture2D MANOMCKCGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private Dictionary<DNAMKONLNOL, int> NMFFJMEBPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GABPAHOMPGH[] JPPNOCPPEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private GFPOJCNDFBH[] NNJCMONBPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] FLNPALMDPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] EMMFKFLDIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] HNKHJNOFHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector4[] NKBBIDJJHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector4[] FGKLPHFOKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector4[] ALNCKGNKPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private List<Texture2D> GFEGDFLAEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] JKDEOMGNPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private List<Texture2D> MHJFEANIGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private float[] JNAPHOMBLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private Vector4[] HEJPEFIGBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] MLEKDCOIGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float[] LKIMPAAKPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private List<Texture2D> DDHLFPCMLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] NCMLHECPJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private List<Texture2D> GHAMFNOFHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private Vector4[] MCDAFKIJIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private float[] CEMNNKEOCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Vector4[] MNCONJBOGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float[] ELMBFCFPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray DDHEOJBFEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public Texture2DArray FNOOLLJOKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public Texture2DArray DGEECBOPFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public Texture2DArray EIBIPEGLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private bool MIOKMMJNJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private int MDPEKGMEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private Vector2? ACLBBFGOGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private TextureFormat FAHFDHKCAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private Vector2? OHMLFGPMDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private TextureFormat EAGBCNNFNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Vector2? ODHPDGEPDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private TextureFormat GJBBMOCKGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private Vector2? DDBPCCGEHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private TextureFormat GEGMMOBKHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private bool HHCLANPDDNK;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int GKAILGLOAGL;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int JCDJCAHPLEG;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int DKPBAPKGNOP;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int KPCHICEBFAN;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int DJCCFHFNNBM;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int KBEIEHOIPKI;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int OJCKHPEACHI;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int KMOBIMIKEHJ;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int HAKONKKLGPJ;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int OIPJMNABDIC;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int GFIMMLOIANJ;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int CLLCNCCFJGP;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int HFFHCDOPDJI;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int LAGFIDIJKKO;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int PNIFOBENIDJ;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int OPIOKMHNNJJ;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int FFNAFHJAMII;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static int GECNMANHJFG;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static int LFBFKMDBMLF;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static int NEGAAADHFNP;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E420", Offset = "0x6A0CA20", VA = "0x186A0E420")]
	private NJOIGIAEIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E360", Offset = "0x6A0C960", VA = "0x186A0E360")]
	public NJOIGIAEIFG(Color GBOCAHMOMJJ, Color EHDBHIEMHCI, Color OEHAACMIHEA, Color? JGEGHKJHAFK, Color? GAHPAFPKPGH, Color? FLMEIALHKKK, Texture2D BPANEMPBHKF, Texture2D PIHEJEAFMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DF20", Offset = "0x6A0C520", VA = "0x186A0DF20")]
	internal int NIKJAAPFHJG(Material AIJHNMEMCHO, GABPAHOMPGH CIDOJAAGKLI, GFPOJCNDFBH CGGKKLLIJHE, GLHPDDDHLIA NOLHAPCPHHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DE90", Offset = "0x6A0C490", VA = "0x186A0DE90")]
	private int NIKJAAPFHJG(DNAMKONLNOL LFOBGDLOPID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0BF50", Offset = "0x6A0A550", VA = "0x186A0BF50")]
	internal int FDBFHJIJKIE(Material AIJHNMEMCHO, Color GECFOLMCGMM, Color HCPMMFPFJFH, Color JGGBKMPNMLA, Color OMFEKEMHIGG, Color EAENDLBEFOP, Texture2D BAIDCADJNHJ, Vector4 CMGGLHBMOCM, Texture2D JJJLDONACDO, Vector4 GEHNFBAHIIC, float OFHOLNJFPLB, float HKJEFDIEJGE, Texture2D OPEDNHKKIKA, Vector4 PENAFGDKHNB, float FCKBGOIMAAB, Texture2D OBBGMAHOBDP, Color BOMPMFFAGKG, Vector4 HCFPGMGOGKC, GABPAHOMPGH CIDOJAAGKLI, GFPOJCNDFBH CGGKKLLIJHE, GLHPDDDHLIA NOLHAPCPHHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CB20", Offset = "0x6A0B120", VA = "0x186A0CB20")]
	private void JLECILCEEKE(List<Texture2D> GFEGDFLAEKO, [Out] Texture2DArray OOGMKALHBLA, [Out] Texture2DArray CPJGKIANFML, [Out] Texture2DArray PABNDJCICMK, [Out] Texture2DArray CJINILJENNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DD40", Offset = "0x6A0C340", VA = "0x186A0DD40")]
	public void LJEAPIJIBND(Shader CMCFBFNJEIM, Renderer MGJKLBPNDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CCE0", Offset = "0x6A0B2E0", VA = "0x186A0CCE0")]
	private void KDHGJMBHGIE(Shader CMCFBFNJEIM, Renderer MGJKLBPNDCE, int MJPACIFMOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D9F0", Offset = "0x6A0BFF0", VA = "0x186A0D9F0")]
	private Color LAOOOOBGMME(Color GMIOAJGCIBH, GABPAHOMPGH OKCHJHEBDDJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DBF0", Offset = "0x6A0C1F0", VA = "0x186A0DBF0")]
	private Color LAPNGDIKBEC(Color MGDKNLABFLG, GABPAHOMPGH OKCHJHEBDDJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6A0BE10", Offset = "0x6A0A410", VA = "0x186A0BE10")]
	private bool BKFCCGLDLPL(Texture2D MMGHMIMKFJH, GFPOJCNDFBH FMAFCGPMJFK, [Out] Texture2D HMAKJCBONIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6A0BD60", Offset = "0x6A0A360", VA = "0x186A0BD60")]
	private void BGNPBCKEMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6A0BF10", Offset = "0x6A0A510", VA = "0x186A0BF10", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private GJDHNIMFMOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public HFHJCJFLOOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xBB8710", Offset = "0xBB6D10", VA = "0x180BB8710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6A09980", Offset = "0x6A07F80", VA = "0x186A09980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	public static void HNFJHPFBCIM(string MCAKFNPAKIL, int CLOHFODGPFM, long AFDEELHPLGG, long OPNCPAJMFIB, long ACEABPDLKKL, long JPKMFHLAAIB, long DMDGOCLCAAE, long OGBNJLKNPFJ, long JMHAKEAEKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6A09A40", Offset = "0x6A08040", VA = "0x186A09A40")]
	public static EPGCCCKMEBG MMCMLLODHCJ(JobHandle KDIBOMPFEDM, bool FINHCBNMBLF, bool IENKDKLDEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6A099D0", Offset = "0x6A07FD0", VA = "0x186A099D0")]
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
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private NLOACFIFDII IOOLCIKJAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private EEILIJBGPBA HNONDHFHCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private IRecRoomQualityConfigProvider FFJDDMGNMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool OLPEDEELBCN;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A510", Offset = "0x6A08B10", VA = "0x186A0A510")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void NHCNGJDKHBJ(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CCF0", Offset = "0x5D2B2F0", VA = "0x185D2CCF0")]
	[UnityEngine.Scripting.Preserve]
	public MLMJMBGAMPA([OLJNBPOCBCJ(null)] EEILIJBGPBA FFCMDNIHHNF, [OLJNBPOCBCJ(null)] NLOACFIFDII HLNJCPAGKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A350", Offset = "0x6A08950", VA = "0x186A0A350")]
	private void IDEPJKKKNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A610", Offset = "0x6A08C10", VA = "0x186A0A610", Slot = "4")]
	public void OELBFLMPCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6A09E80", Offset = "0x6A08480", VA = "0x186A09E80", Slot = "5")]
	public POLPOFEBNLM<Texture2D> EDAOMIHFJCM(BBHCHJINLEI DKJKDMIOKCP, [Optional] CCNPMMKEMIA FCDCCFDNJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A3E0", Offset = "0x6A089E0", VA = "0x186A0A3E0")]
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
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly GameObject FOGDNDDPAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly AvatarItemMaterial NJGPEFGEGPF;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0xC51880", Offset = "0xC4FE80", VA = "0x180C51880")]
	public ALKPGNKPOMI(GameObject FOGDNDDPAEP, AvatarItemMaterial NJGPEFGEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6A06940", Offset = "0x6A04F40", VA = "0x186A06940")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6A0E910", Offset = "0x6A0CF10", VA = "0x186A0E910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6A0EE10", Offset = "0x6A0D410", VA = "0x186A0EE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private POLPOFEBNLM<GameObject> MOLHPGNEKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private POLPOFEBNLM<AvatarItemMaterial> JFINANMLLBH;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6A098F0", Offset = "0x6A07EF0", VA = "0x186A098F0")]
	private GPIBMLKONHH(Task<(GameObject, AvatarItemMaterial)> KECDGIGMBNG, POLPOFEBNLM<GameObject> HMPILACGCON, POLPOFEBNLM<AvatarItemMaterial> LMGIDJJBFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6A093C0", Offset = "0x6A079C0", VA = "0x186A093C0")]
	public static GPIBMLKONHH GMDNOGMNFLF(AssetReference IPNMODLOJND, [Optional] AssetReference DLOLIKIGONK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6A097D0", Offset = "0x6A07DD0", VA = "0x186A097D0", Slot = "11")]
	protected override ALKPGNKPOMI MNEGIKDGNGL(Task<(GameObject, AvatarItemMaterial)> NMDMLCAOIKH)
	{
		return default(ALKPGNKPOMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6A09870", Offset = "0x6A07E70", VA = "0x186A09870", Slot = "12")]
	protected override void OCFKJOBKHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6A09290", Offset = "0x6A07890", VA = "0x186A09290")]
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
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private POLPOFEBNLM<MaterialMapAsset> GPPOCIDKPII;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6A091B0", Offset = "0x6A077B0", VA = "0x186A091B0")]
		public GCHFCOEMFPD(POLPOFEBNLM<MaterialMapAsset> GPPOCIDKPII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6A08D30", Offset = "0x6A07330", VA = "0x186A08D30", Slot = "11")]
		protected override Material[] MNEGIKDGNGL(Task<MaterialMapAsset> KECDGIGMBNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6A09150", Offset = "0x6A07750", VA = "0x186A09150", Slot = "12")]
		protected override void OCFKJOBKHJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private class IOBEOJBIAFJ : HPIKJDJNNFG<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private List<POLPOFEBNLM<Material>> ALLKFMONBNP;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6A09D20", Offset = "0x6A08320", VA = "0x186A09D20")]
		public IOBEOJBIAFJ(Task<Material[]> KECDGIGMBNG, List<POLPOFEBNLM<Material>> ALLKFMONBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6A09B90", Offset = "0x6A08190", VA = "0x186A09B90", Slot = "11")]
		protected override Material[] MNEGIKDGNGL(Task<Material[]> NMDMLCAOIKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6A09BE0", Offset = "0x6A081E0", VA = "0x186A09BE0", Slot = "12")]
		protected override void OCFKJOBKHJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6A0A690", Offset = "0x6A08C90", VA = "0x186A0A690")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6A10FF0", Offset = "0x6A0F5F0", VA = "0x186A10FF0")]
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
		private struct NGHNOLFJLDP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public AsyncTaskMethodBuilder<OJKMAKKPOEK> <>t__builder;

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
			private TaskAwaiter<OJKMAKKPOEK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6A0B9B0", Offset = "0x6A09FB0", VA = "0x186A0B9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x6A0BCF0", Offset = "0x6A0A2F0", VA = "0x186A0BCF0", Slot = "5")]
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
		private Dictionary<DFIACMOLAPM, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<DFIACMOLAPM, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<DFIACMOLAPM, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<DFIACMOLAPM, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly Dictionary<DFIACMOLAPM, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private OJKMAKKPOEK _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6A08D00", Offset = "0x6A07300", VA = "0x186A08D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6A084F0", Offset = "0x6A06AF0", VA = "0x186A084F0")]
		public OJKMAKKPOEK CAAGAFNGFEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6A08AC0", Offset = "0x6A070C0", VA = "0x186A08AC0")]
		[AsyncStateMachine(typeof(NGHNOLFJLDP))]
		public Task<OJKMAKKPOEK> KDMBLEJFMON(int PHNNIPLCINI, int PNGADIHBOKA, int IMHJOCILKDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6A08450", Offset = "0x6A06A50", VA = "0x186A08450")]
		public NoseFaceOption AJIELDICKAM(int CEJGMHBAEAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6A08770", Offset = "0x6A06D70", VA = "0x186A08770")]
		public SelectableFaceOption GFCOGPNGELK(FaceFeatureType KDLEIJBEDLO, DFIACMOLAPM HHLFIMLCCJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6A08BF0", Offset = "0x6A071F0", VA = "0x186A08BF0")]
		public int PIHOEIGCOOB(DFIACMOLAPM HHLFIMLCCJH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6A08540", Offset = "0x6A06B40", VA = "0x186A08540")]
		private void EPFGJKAFDIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB7680", Offset = "0x2CB5C80", VA = "0x182CB7680")]
		private void GIKMHPOMLCC<T>(IDictionary<DFIACMOLAPM, T> HGEMHLLLPMH, IReadOnlyList<T> MCCJAGABPKN) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6A08A10", Offset = "0x6A07010", VA = "0x186A08A10")]
		public DFIACMOLAPM JDMPCEDLMGF(FaceFeatureType KDLEIJBEDLO)
		{
			return default(DFIACMOLAPM);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6A088F0", Offset = "0x6A06EF0", VA = "0x186A088F0")]
		public DFIACMOLAPM HBDJECNPDDJ(FaceFeatureType KDLEIJBEDLO)
		{
			return default(DFIACMOLAPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6A08C70", Offset = "0x6A07270", VA = "0x186A08C70")]
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
