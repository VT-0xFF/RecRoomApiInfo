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
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x742C320", Offset = "0x742B720", VA = "0x18742C320", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x96E0E0", Offset = "0x96D4E0", VA = "0x18096E0E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x743D440", Offset = "0x743C840", VA = "0x18743D440", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x743D3D0", Offset = "0x743C7D0", VA = "0x18743D3D0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x743D400", Offset = "0x743C800", VA = "0x18743D400")]
		public RecNetCDNAssetReference(RecNetCDNKey MCNLCGLNHHO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum HLANPPAIOON : byte
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
			[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x993140", Offset = "0x992540", VA = "0x180993140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x992EC0", Offset = "0x9922C0", VA = "0x180992EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HLANPPAIOON PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCB5070", Offset = "0xCB4470", VA = "0x180CB5070")]
			[CompilerGenerated]
			get
			{
				return default(HLANPPAIOON);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x11735D0", Offset = "0x11729D0", VA = "0x1811735D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x743D550", Offset = "0x743C950", VA = "0x18743D550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x743D4D0", Offset = "0x743C8D0", VA = "0x18743D4D0")]
		public static RecNetCDNKey LPLBIEKIOPM(string PFKGAHOCAAP, HLANPPAIOON KCJAHLANMHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x743D480", Offset = "0x743C880", VA = "0x18743D480")]
		public void ECLEODIHEHN(string DKCMIENFPNI, string JPJGMEMJNGO, bool POOGMPNNFMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MENIDINFMMJ]
public class EHHBNFLMJPC : EBAHLAGOJPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> AHJOPBCELFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> BLPCOAHGALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> POPEPBEGLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> CFDKLOPAEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> HECGBBJDGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> AGDGIHFPNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> DGNAENNMNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator IBKHINBEOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected HOICEHILGLA HGDBNLOAMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte OFGPHJNNMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> LAKBBFBEDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> IIEJFHPFKFB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7429030", Offset = "0x7428430", VA = "0x187429030", Slot = "4")]
	public void GPKPHILKIFF(Mesh HLHLPCAMLJN, Matrix4x4 CJBIMFGKJDA, byte[] APMMBEKIAPE, bool GOPMMNFGOBG = false, JEMKHCHMBLO.IFCJAEMECIM NBMAKEKJLBO = (JEMKHCHMBLO.IFCJAEMECIM)0L, int EGLHKMAGHPC = -1, bool CCPPPCLPFOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74292B0", Offset = "0x74286B0", VA = "0x1874292B0", Slot = "5")]
	public void JECLJBHJACN(Allocator FALBINAEKDG, HOICEHILGLA GJHKPHJLIFD, byte KDLMKHFIMOE, [Optional] IList<int> FNCPPDHDPLG, [Optional] IList<int> KJKPEENPKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74292F0", Offset = "0x74286F0", VA = "0x1874292F0")]
	private static void LDCIIPMDJAI(Mesh HLHLPCAMLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7429550", Offset = "0x7428950", VA = "0x187429550")]
	public EHHBNFLMJPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[MENIDINFMMJ]
public struct ACJCPGNFLFN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public MNLDLJIEAEC LFGDFOKFLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int BCKFCFLNLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public PFPHHLKIEOF MDJDPOGCLOE;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7425930", Offset = "0x7424D30", VA = "0x187425930", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[MENIDINFMMJ]
[NativeContainer]
public struct PFPHHLKIEOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct AKMAGMNBPOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 FAIANMBPEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 BLIFKOEAPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 FHEKDKNIDEI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct JFGMIBBIMCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float LADHAHAJOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float GBMNNFIJOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float EDBPGOHJHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float HPDBIHCEMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte KHLIOICBKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte MEOCJIGPJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte IHLJBHPDCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte BAPHCLHMIHO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BENNEFECPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half LADHAHAJOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half GBMNNFIJOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half EDBPGOHJHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half HPDBIHCEMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte KHLIOICBKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte MEOCJIGPJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte IHLJBHPDCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte BAPHCLHMIHO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct FKFOELCIAIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 MLLLJKFOPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 BOADLEKDLLH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct GBMMAHBPMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 MLLLJKFOPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 BOADLEKDLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 EADFJEFAFPD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CNKPHACJGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 MLLLJKFOPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 BOADLEKDLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 EADFJEFAFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 LCPLLLHAOPF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct IGNODCDBIEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 MLLLJKFOPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 BOADLEKDLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 EADFJEFAFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 LCPLLLHAOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 NGNFHJJLAFC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct DKCBKNHIGME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float LADHAHAJOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float GBMNNFIJOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float EDBPGOHJHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float HPDBIHCEMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int KHLIOICBKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int MEOCJIGPJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int IHLJBHPDCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int BAPHCLHMIHO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EAIGIAPOALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color MLLLJKFOPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 BOADLEKDLLH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct BLNMGDEKINK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color MLLLJKFOPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 BOADLEKDLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 EADFJEFAFPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct FFOGMHGOEDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color MLLLJKFOPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 BOADLEKDLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 EADFJEFAFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 LCPLLLHAOPF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct BMAGMOALONC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color MLLLJKFOPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 BOADLEKDLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 EADFJEFAFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 LCPLLLHAOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 NGNFHJJLAFC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool PIAAKNDHNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<AKMAGMNBPOO> KJADEDOOCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<FKFOELCIAIJ> LCMEBFGGEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<GBMMAHBPMIB> MALLFNJJMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<CNKPHACJGKM> PGMJIPJGCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<IGNODCDBIEL> KMDBNEFNAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<BENNEFECPEM> BPIMMMEJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<JFGMIBBIMCD> NNKNDHNBBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<EAIGIAPOALA> FCKNLMCMCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<BLNMGDEKINK> LPDFABBHCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<FFOGMHGOEDN> OCDGJOCBAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<BMAGMOALONC> LNIBICHIJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<DKCBKNHIGME> KLADHLBOIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> LGBOGPFFDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> DGICAJJNJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> INBMEPAFDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> JJCOJBMHEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> NFKKGODHJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> JFHBOMGMLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> MPHOMGIPEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> GJLOMGIBDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> GAPCIOOOOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool PCHPGNFNHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool BGCFHENHHJD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KHDPOANANBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x743C550", Offset = "0x743B950", VA = "0x18743C550")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x743C190", Offset = "0x743B590", VA = "0x18743C190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LJJBDGPMFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x743C180", Offset = "0x743B580", VA = "0x18743C180")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x743BD40", Offset = "0x743B140", VA = "0x18743BD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JHLGAOPGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x743A6C0", Offset = "0x7439AC0", VA = "0x18743A6C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x743C990", Offset = "0x743BD90", VA = "0x18743C990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int ENPJKPMCLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x743C080", Offset = "0x743B480", VA = "0x18743C080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x743C9A0", Offset = "0x743BDA0", VA = "0x18743C9A0")]
	public PFPHHLKIEOF(int JMNHBPEFOID, int CPAMACJAGBF, int JMDLIPDPGPB, int POKEFPEKPCG, Allocator FALBINAEKDG, int JICJDHCOIMH, BCANCJIMFLD AMDKCBPCDDD, bool PCHPGNFNHKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x743C0F0", Offset = "0x743B4F0", VA = "0x18743C0F0")]
	public void IMDOHAAKOKC(int FFCBHHABFJN, Vector3 CKLNAHKPEEA, Vector3 AHFGMNBCHCA, Vector4 MPAMMAGABHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x743C560", Offset = "0x743B960", VA = "0x18743C560")]
	public void MLJJIFFIEBK(int FFCBHHABFJN, BoneWeight KIDLGJFCDJI, NativeSlice<byte> APMMBEKIAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x743BD50", Offset = "0x743B150", VA = "0x18743BD50")]
	public Color IFMHNLGPFEH(int FFCBHHABFJN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x743B940", Offset = "0x743AD40", VA = "0x18743B940")]
	public void FKLOKKNKOMI(int FFCBHHABFJN, Color FBGCPEAGLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x743C1A0", Offset = "0x743B5A0", VA = "0x18743C1A0")]
	public void LMKJFMIFCIH(byte PGMAINGIGPA, int FFCBHHABFJN, Vector2 ENPEMOFMIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x743A650", Offset = "0x7439A50", VA = "0x18743A650")]
	public void COIAKPCFEDI(int FFCBHHABFJN, int CJBFPNMNIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x743A660", Offset = "0x7439A60", VA = "0x18743A660")]
	public bool DEODECNDGGF(int PGMAINGIGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x743B870", Offset = "0x743AC70", VA = "0x18743B870")]
	public void EPEKJKJBEII(int GCKLCOBEDON, int FGCNBOMLCIC, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x743A6D0", Offset = "0x7439AD0", VA = "0x18743A6D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x743A930", Offset = "0x7439D30", VA = "0x18743A930")]
	public Mesh ELHPJAPGFMD([Optional] string FABFJPGHADM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[MENIDINFMMJ]
public struct MNLDLJIEAEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray EAFMAJLANKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> MLFCJMAIHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> PPOEJLEMLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> GJLOMGIBDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> BNLENHGBNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> NIFBADDLCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> BPBNGBLPNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> AMJIDEIPPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> LIOPEBIBEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> FMOKIKOLAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> BAGFIDNNGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> CCPPPCLPFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> EGLHKMAGHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool PCHPGNFNHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> JIBJDOFPHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool BGCFHENHHJD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NKDLDJBKCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7439020", Offset = "0x7438420", VA = "0x187439020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DIBMKAFLNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7438F20", Offset = "0x7438320", VA = "0x187438F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int FMCBEJKHKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7438E30", Offset = "0x7438230", VA = "0x187438E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PEEJFKBGPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7439040", Offset = "0x7438440", VA = "0x187439040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7438E10", Offset = "0x7438210", VA = "0x187438E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KHDPOANANBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7438F40", Offset = "0x7438340", VA = "0x187438F40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7438F30", Offset = "0x7438330", VA = "0x187438F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EDIIGDADJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7438A20", Offset = "0x7437E20", VA = "0x187438A20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7438F10", Offset = "0x7438310", VA = "0x187438F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public HOICEHILGLA KNFGJANPFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7438E20", Offset = "0x7438220", VA = "0x187438E20")]
		get
		{
			return default(HOICEHILGLA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7438A30", Offset = "0x7437E30", VA = "0x187438A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte ANFIFCKFNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7438F00", Offset = "0x7438300", VA = "0x187438F00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7439030", Offset = "0x7438430", VA = "0x187439030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public FJPALOFPPCD BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7438BC0", Offset = "0x7437FC0", VA = "0x187438BC0")]
		get
		{
			return default(FJPALOFPPCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7439050", Offset = "0x7438450", VA = "0x187439050")]
	public MNLDLJIEAEC(IList<Mesh> LCPDPHMNGDF, IList<Matrix4x4> NHLKMCHPIJO, IList<bool> CCPPPCLPFOM, byte KDLMKHFIMOE, IList<byte[]> CEGNGFAEAIP, IList<long> NBLKAMIBMFM, IList<bool> EAHOJKOLOEL, IList<int> EGLHKMAGHPC, IList<int> FNCPPDHDPLG, IList<int> HMDDDHFMDBP, Allocator FALBINAEKDG, HOICEHILGLA GJHKPHJLIFD, bool PCHPGNFNHKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7438F50", Offset = "0x7438350", VA = "0x187438F50")]
	public PFPHHLKIEOF MGAPFFIHMMN(Allocator FALBINAEKDG, BCANCJIMFLD AMDKCBPCDDD)
	{
		return default(PFPHHLKIEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7438A40", Offset = "0x7437E40", VA = "0x187438A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[MENIDINFMMJ]
public class NOLKNBCDEGN : EHHBNFLMJPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool GDPMEAAHIED;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker MOBNMEEECPJ;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x743A210", Offset = "0x7439610", VA = "0x18743A210")]
	public MNLDLJIEAEC FBAOEPIGPFH()
	{
		return default(MNLDLJIEAEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x743A510", Offset = "0x7439910", VA = "0x18743A510")]
	public NOLKNBCDEGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FJPALOFPPCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData JBNHOECMCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> GJLOMGIBDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> FMONEEMGAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int NLMELCMIEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 JGMIEOFJBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long ODMEBKLIPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> APMMBEKIAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool IJPAHMDIIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int NJKIJFHEIBF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MBOGIKGHAPE : NHBJOEBCOCP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DDBFEHMHIJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public IAKNPHOHNEA avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public MBOGIKGHAPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NFJKMPPPDKA buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Action<KeyValuePair<string, JCAOOGBCPCO<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DDBFEHMHIJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7428F60", Offset = "0x7428360", VA = "0x187428F60")]
		internal bool NAPCPIMIEFC(PFLMFICBCEJ item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7428EF0", Offset = "0x74282F0", VA = "0x187428EF0")]
		internal void PINHCHOELEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7428F40", Offset = "0x7428340", VA = "0x187428F40")]
		internal void JOOEGGHMMKA(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7428EF0", Offset = "0x74282F0", VA = "0x187428EF0")]
		internal void ICFBBMLJIKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7428F40", Offset = "0x7428340", VA = "0x187428F40")]
		internal void LDPKAPOHGOO(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7428E00", Offset = "0x7428200", VA = "0x187428E00")]
		internal void ABMLFHOHNLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7428F10", Offset = "0x7428310", VA = "0x187428F10")]
		internal void IMHKKOBBILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7428D40", Offset = "0x7428140", VA = "0x187428D40")]
		internal void ABBMNAIIBAP(Dictionary<string, JCAOOGBCPCO<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7428E30", Offset = "0x7428230", VA = "0x187428E30")]
		internal void FPBFDEIIGMD(KeyValuePair<string, JCAOOGBCPCO<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
		internal OCLDKMPDLBK ICFNCMPLPJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KMEANNNDALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public DDBFEHMHIJI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public KMEANNNDALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x742C260", Offset = "0x742B660", VA = "0x18742C260")]
		internal FICFPAPGNDK KPKLNBLPCAE(int lod)
		{
			return default(FICFPAPGNDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class MOMNBAPHDIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public HHPFDJMLPAL<Dictionary<string, JCAOOGBCPCO<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MOMNBAPHDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		internal HHPFDJMLPAL<Dictionary<string, JCAOOGBCPCO<Texture2D>>> LECIGGMMGCL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PCLLMMGAEIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<NFJKMPPPDKA> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public PCLLMMGAEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x743A520", Offset = "0x7439920", VA = "0x18743A520")]
		internal void NPFOIKCEFGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JOKPMKEOICH : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public MBOGIKGHAPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public List<JFNPPCOIGBP> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<NFJKMPPPDKA> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Func<int, FICFPAPGNDK> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public GAOFBAKPJIA materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public JOKPMKEOICH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x742BF90", Offset = "0x742B390", VA = "0x18742BF90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x742C210", Offset = "0x742B610", VA = "0x18742C210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CJOHHJNLFMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public BPPCKMAONFJ cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public CJOHHJNLFMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAD2FC0", Offset = "0xAD23C0", VA = "0x180AD2FC0")]
		internal void EJNJNNGKFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xBE16E0", Offset = "0xBE0AE0", VA = "0x180BE16E0")]
		internal void PEJHODIMEIG(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NIJFJFAGEPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public MBOGIKGHAPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public NIJFJFAGEPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HEJLHJMEFKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public PFPHHLKIEOF defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public MNLDLJIEAEC defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public NIJFJFAGEPB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HEJLHJMEFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x74299E0", Offset = "0x7428DE0", VA = "0x1874299E0")]
		internal void KAGFGILIDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x10BFF80", Offset = "0x10BF380", VA = "0x1810BFF80")]
		internal void EJFMEBHOBMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EHJDMHIOINA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public PJFEHCEGOEP legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public LKBGKMOODCI legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public NIJFJFAGEPB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EHJDMHIOINA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x74297A0", Offset = "0x7428BA0", VA = "0x1874297A0")]
		internal void LDACHKBEAHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x10C1600", Offset = "0x10C0A00", VA = "0x1810C1600")]
		internal void JHDMLEABGHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DEKGALOICIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public FGFOFKPBCAF overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public DEKGALOICIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7428FB0", Offset = "0x74283B0", VA = "0x187428FB0")]
		internal bool LPAJCJCFOPO(KeyValuePair<string, PFLMFICBCEJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly EBGLFEEDNOA HBPPKCBCCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EBGLFEEDNOA JIBEMMGJNGF;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<PCMIOJDPABF, float> FDIFMIGFFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private IReadOnlyDictionary<string, FOBKBIDNGNH> CBOEEMIOCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<string, FOBKBIDNGNH> ALNICOIEBLP;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static float LLGIFBDJKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool? NCFIOCBGMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool? LDNNIJNOJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private AvatarConfiguration HDCDCHEPCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Transform NGEMCGOICJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private AvatarSkinAssetItem JPPBAHBKNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private AssetReference OFMJPCLJLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private GameObject AFDMMFDKIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private GameObject LKHJNONINJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private SkinnedMeshRenderer LPFFPGJDBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarSkinnedMeshBoneOrderRemapsData KILCOGEOKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Transform[] PCECFICPJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Matrix4x4[] CMDLMNELMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Material DFMALCIPJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Material MHBOLLDMGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Material KGGHOPCFDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Shader KALAOKAHDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Shader NKPNGPPPJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Animator AIBCJAJGEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Renderer[] NFGBPBPLBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private JEMKHCHMBLO.IFCJAEMECIM DINKHFBOLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private AvatarBodyPartShapesManager KCAPAAKILII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private IReadOnlyDictionary<string, Transform> OLKDFFNEHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private AvatarFaceShapeData.HIOMJMOBCNN FBEGHJEBBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private AvatarBodyShapeData.CGGHALEEMLL MMOAPEJCKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private HDEGHEIKKJI EIDKKCLAJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool LMGAPNFEKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool PPOBBDCMIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Color LKNAIGMBALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Color MHPFINPLBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Color JOOOCCGPOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Color? KMKNFOHMBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Color? CFCGBMGJAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Color? PACEGBBJODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Color? HCMJLCIIPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Texture2D LMHNHGEIBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Texture2D CEKCHNOCECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[CanBeNull]
	private PFLMFICBCEJ MKOOCOFFPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Texture JBLIJMGOFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color AEENIGEFNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Dictionary<Renderer, GAOFBAKPJIA> OMFDHBKPNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Dictionary<Renderer, GAOFBAKPJIA> FCBGHPGOPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Dictionary<string, List<OJJHMFOHKIH>> KMFHIAMEKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Dictionary<string, List<OJJHMFOHKIH>> OKBLMKBNGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly List<OOEAEINEKGH> GCLIGBNIAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly List<OOEAEINEKGH> EGHMNPHKAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly List<OOEAEINEKGH> PHFNGAAMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<OOEAEINEKGH> GJLLFOIIEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Dictionary<OJJHMFOHKIH, Material> LIEMGJDPPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<OJJHMFOHKIH, Material> BFMCOBCLDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private SkinnedMeshRenderer[] IEDLPPFAOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private SkinnedMeshRenderer[] IAIEIJCHKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private SkinnedMeshRenderer[] DDLHMCJHCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private SkinnedMeshRenderer[] MLFKGEFFCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly Dictionary<string, JCAOOGBCPCO<Texture2D>> BCOLHNJHMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly Dictionary<string, JCAOOGBCPCO<Texture2D>> JKJAGCMOHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private FOJIEICEIIC NGHDDPCILPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private FOJIEICEIIC JEKFJJDMFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private AdditionalHatData GIHDHOIMADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private AdditionalHatData KDNBECDHEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private HairData GFMFOCGHACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private HairData DPIFAELNPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private CFIMFIIKPEO PENKNIJBNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool? ICPLHLKPHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private PositionAndRotation OANGHIHJBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Transform PFMGDPMCBLM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Material OKJHCEODLGC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Material OPKGEFMIBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Dictionary<string, PFLMFICBCEJ> ENFIEAIFMHM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int HGOEPBPPJNK;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int GPFCKEFOJMK;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int FCAOACLJEMM;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int BDLMGGLODNA;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int OCJPNOGGHML;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int HNNCLHAPEDM;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int AENGMKNDNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool PMMLGCANBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private List<Action> CCKDDPPDKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private AIJALJOGGJG JFPABFJFIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private SkinnedMeshRenderer[] NDHFAGEPCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private int NNAPGKCKDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool KNADEBIDJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int EBIGGNIJJKD;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public EBGLFEEDNOA AGIMFEPEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EBGLFEEDNOA EENNHOGFJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private PAJFLGMBLIE OFOFLKGFIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7432AF0", Offset = "0x7431EF0", VA = "0x187432AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool ONCHJKBFGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7432F80", Offset = "0x7432380", VA = "0x187432F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool AEHIMLONEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x742F7B0", Offset = "0x742EBB0", VA = "0x18742F7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AvatarConfiguration ABBINCFKGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool GHODFIGIDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1055340", Offset = "0x1054740", VA = "0x181055340")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1055170", Offset = "0x1054570", VA = "0x181055170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Material JCHFNBINGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x742E350", Offset = "0x742D750", VA = "0x18742E350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Material GECMFADHLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x742E800", Offset = "0x742DC00", VA = "0x18742E800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool AHBEMLNMCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DIINEKIAPFE EIEEEPIDOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2015730", Offset = "0x2014B30", VA = "0x182015730", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(DIINEKIAPFE);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x74344B0", Offset = "0x74338B0", VA = "0x1874344B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Material BKMHIJCELBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xACC560", Offset = "0xACB960", VA = "0x180ACC560", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public SkinnedMeshRenderer[] KEIOEHGLOFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA66520", Offset = "0xA65920", VA = "0x180A66520", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Renderer[] NPPHNALBGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xC31D40", Offset = "0xC31140", VA = "0x180C31D40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool GKCLPLAAHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x742E8F0", Offset = "0x742DCF0", VA = "0x18742E8F0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public JEMKHCHMBLO.IFCJAEMECIM KCLOBFAIFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xBDADE0", Offset = "0xBDA1E0", VA = "0x180BDADE0", Slot = "20")]
		get
		{
			return default(JEMKHCHMBLO.IFCJAEMECIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int NDHAPKOPBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x20BC780", Offset = "0x20BBB80", VA = "0x1820BC780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x742D700", Offset = "0x742CB00", VA = "0x18742D700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool CALIOGEHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x74363D0", Offset = "0x74357D0", VA = "0x1874363D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private static bool KMNNGAHOPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7433E80", Offset = "0x7433280", VA = "0x187433E80", Slot = "15")]
	public NFJKMPPPDKA LLBPPDPFELJ(IAKNPHOHNEA EMPJALJALOI, bool GLIEMLJKHAM, int[] ADAGNFIGKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7433770", Offset = "0x7432B70", VA = "0x187433770", Slot = "14")]
	public NFJKMPPPDKA KFALMDJCLLA(IAKNPHOHNEA EMPJALJALOI, bool GLIEMLJKHAM, int[] ADAGNFIGKFB, Func<Dictionary<string, PFLMFICBCEJ>, (NFJKMPPPDKA, HHPFDJMLPAL<Dictionary<string, JCAOOGBCPCO<Texture2D>>>)> DOKFDGIABHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7436510", Offset = "0x7435910", VA = "0x187436510")]
	public NFJKMPPPDKA PLIHIDOKAJB(IAKNPHOHNEA EMPJALJALOI, bool GLIEMLJKHAM, int[] ADAGNFIGKFB, bool OMNOIIFEBEB, FOJIEICEIIC BEJIPAIEEGB, [Optional] Func<Dictionary<string, PFLMFICBCEJ>, (NFJKMPPPDKA, HHPFDJMLPAL<Dictionary<string, JCAOOGBCPCO<Texture2D>>>)> DOKFDGIABHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x742FB60", Offset = "0x742EF60", VA = "0x18742FB60")]
	private bool GIJOBBDGHHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7435230", Offset = "0x7434630", VA = "0x187435230")]
	private NFJKMPPPDKA OCJFMLEJAPE(bool GLIEMLJKHAM, List<JFNPPCOIGBP> AHBDDNLCLFK, int[] ADAGNFIGKFB, Func<int, FICFPAPGNDK> KIDJLHGOGFN, bool OMNOIIFEBEB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7432C20", Offset = "0x7432020", VA = "0x187432C20")]
	[IteratorStateMachine(typeof(JOKPMKEOICH))]
	private IEnumerator<MOLDBMJPKNN> JCGMNJLBMBE(bool GLIEMLJKHAM, List<JFNPPCOIGBP> AHBDDNLCLFK, int[] ADAGNFIGKFB, Func<int, FICFPAPGNDK> KIDJLHGOGFN, GAOFBAKPJIA NEKEFHFDFLO, Material MMCBMDPFDPO, List<NFJKMPPPDKA> JJIHLCLIHHO, bool OJDHCDEPBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x742FE50", Offset = "0x742F250", VA = "0x18742FE50")]
	private void GOJLBOIABGP(List<JFNPPCOIGBP> AHBDDNLCLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x74348C0", Offset = "0x7433CC0", VA = "0x1874348C0")]
	private NFJKMPPPDKA NIHPDLGNMFJ(List<JFNPPCOIGBP> AHBDDNLCLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7430B20", Offset = "0x742FF20", VA = "0x187430B20")]
	private DCOKPPOHOJG IFJNHNHCJND(List<JFNPPCOIGBP> AHBDDNLCLFK, int AKKLJPLLNIC, bool GLIEMLJKHAM, FICFPAPGNDK AEPPPPJLFAJ, bool CGCMEAJBGJD, GAOFBAKPJIA NEKEFHFDFLO, Material MMCBMDPFDPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x742EA60", Offset = "0x742DE60", VA = "0x18742EA60", Slot = "27")]
	public void EOILNKIIMIJ(PCMIOJDPABF CEHFLGNGNNM, float PEBNJNGMMHE, bool DKCKKFNLCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x742D1E0", Offset = "0x742C5E0", VA = "0x18742D1E0", Slot = "28")]
	public void BKIDNFODHML(bool MGHEDHLLCGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7435D10", Offset = "0x7435110", VA = "0x187435D10")]
	private void OKKGDJJGNIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74335F0", Offset = "0x74329F0", VA = "0x1874335F0", Slot = "25")]
	public void KBIDMGPMCAP(AvatarFaceShape DDJACKDKDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7432B60", Offset = "0x7431F60", VA = "0x187432B60", Slot = "26")]
	public void ILFJOIEMEKA(AvatarBodyShape EBNHCAOCMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xE062C0", Offset = "0xE056C0", VA = "0x180E062C0", Slot = "29")]
	public void ADDJHDKGOMG(HDEGHEIKKJI MGIHACEIMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x742E060", Offset = "0x742D460", VA = "0x18742E060", Slot = "31")]
	public void EBAAINJNPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x742F5D0", Offset = "0x742E9D0", VA = "0x18742F5D0", Slot = "34")]
	public void FHBAEPDPBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x742C680", Offset = "0x742BA80", VA = "0x18742C680", Slot = "30")]
	public void BCOLNDAOMHO(bool FHGJDENMMFP, bool AMHNIFJFKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x742EFA0", Offset = "0x742E3A0", VA = "0x18742EFA0")]
	private void EOJCBFNAPAJ(SkinnedMeshRenderer ICCIDOLMGON, int AKKLJPLLNIC, Mesh HLHLPCAMLJN, List<Material> DKHDPNKFLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x742F100", Offset = "0x742E500", VA = "0x18742F100")]
	private static Material FAGCNGPAJIK(Dictionary<OJJHMFOHKIH, Material> BIOHKMBAOBH, Material DHHMMCCOHKH, DGELAGPJCGL LCDDGKHBODE, MOKDCLELCHM LGEFBLDNOIB, FGFOFKPBCAF CBBFCGBIHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7435810", Offset = "0x7434C10", VA = "0x187435810")]
	private static DGELAGPJCGL OFLCINDDNML(JFNPPCOIGBP GPMKEFBILDC, int LIHFPNCLECB)
	{
		return default(DGELAGPJCGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7435DF0", Offset = "0x74351F0", VA = "0x187435DF0")]
	private void OPAIBCLOELH(int HJFKPBMKNKH, Material GIEDFKFHBFF, JFNPPCOIGBP GPMKEFBILDC, [Out] Texture2D OKABEIOOKIK, [Out] Vector4 DIGGOCJJBDH, [Out] Texture2D GCKGEFAHPLJ, [Out] Texture2D OGBFAFGNCPH, [Out] Texture2D IIPLEFDPLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74339A0", Offset = "0x7432DA0", VA = "0x1874339A0")]
	private void LAOABENDNMM(int HJFKPBMKNKH, Material GIEDFKFHBFF, JFNPPCOIGBP GPMKEFBILDC, [Out] Color LILHMHLMJHJ, [Out] Color IDINJOGOKPO, [Out] Color KCBGFDFFGHK, [Out] Color LHJKPNILPMP, [Out] Color EAGKGNCBDNC, [Out] Color EOPJFHKGKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x742F290", Offset = "0x742E690", VA = "0x18742F290")]
	private bool FCNMEGPMIIM(Material GIEDFKFHBFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74342A0", Offset = "0x74336A0", VA = "0x1874342A0")]
	private static Material MHJKDMBNLOJ(int HJFKPBMKNKH, DIAJBNMBCLD GPMKEFBILDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74342F0", Offset = "0x74336F0", VA = "0x1874342F0")]
	private static MOKDCLELCHM MODJPCBMBOH(JFNPPCOIGBP GPMKEFBILDC, int LIHFPNCLECB)
	{
		return default(MOKDCLELCHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7434600", Offset = "0x7433A00", VA = "0x187434600")]
	private static void NHEHNBNCLKJ(Dictionary<string, List<OJJHMFOHKIH>> MHJIECJLKAG, JFNPPCOIGBP IDPPNALDCOI, Material DHHMMCCOHKH, DGELAGPJCGL DKOKEINPBND, MOKDCLELCHM DNLKJGJDLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7430730", Offset = "0x742FB30", VA = "0x187430730")]
	private static SkinnedMeshRenderer HIJCPEIKDCI(Transform APAIEEDJEND, Transform LNICBMOLJJD, SkinnedMeshRenderer[] JDDHAEABJGF, int AKKLJPLLNIC, FICFPAPGNDK AEPPPPJLFAJ, bool GLIEMLJKHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7438480", Offset = "0x7437880", VA = "0x187438480")]
	public MBOGIKGHAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7434F10", Offset = "0x7434310", VA = "0x187434F10")]
	public void OBBALIPJEND([In] CIDCFKJJJAE OBCCIOAEHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x742DC90", Offset = "0x742D090", VA = "0x18742DC90")]
	public void DFGPGHHJBLN([In] PEIMOGJCFOI CPAJGFIMPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x742D700", Offset = "0x742CB00", VA = "0x18742D700", Slot = "5")]
	public void GIDFJBMDDNN(int AKKLJPLLNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x742D4E0", Offset = "0x742C8E0", VA = "0x18742D4E0", Slot = "10")]
	public void BPDKBIGEAMM(NEDJDHNJCMJ DNLKJGJDLBL, Texture2D LEFNCCFPOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
	public static bool FNMIBCBNOKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x742CC70", Offset = "0x742C070", VA = "0x18742CC70", Slot = "11")]
	public bool BGMHBCPMAAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7434B10", Offset = "0x7433F10", VA = "0x187434B10", Slot = "9")]
	public void NJNHHICIILD(LGFACLPGLBE DKOKEINPBND, Color? MLLLJKFOPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7432D40", Offset = "0x7432140", VA = "0x187432D40")]
	private void JCKMECFGAKA(Action FMOAKEICGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7433060", Offset = "0x7432460", VA = "0x187433060", Slot = "6")]
	public void JHIOJHDCNKK(PFLMFICBCEJ GJDIIEHGAFJ, Texture EOCCCJAHNIK, Color NENMNLPKOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1055170", Offset = "0x1054570", VA = "0x181055170", Slot = "7")]
	public void OCHFAHAAALD(bool OJDHCDEPBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA82C50", Offset = "0xA82050", VA = "0x180A82C50", Slot = "8")]
	public void AFKOGDHMICA(AIJALJOGGJG GAPCIOOOOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7433F40", Offset = "0x7433340", VA = "0x187433F40", Slot = "16")]
	public void MDKKDOCCKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x742D310", Offset = "0x742C710", VA = "0x18742D310", Slot = "32")]
	public void BOHPKOKNBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7431CB0", Offset = "0x74310B0", VA = "0x187431CB0", Slot = "33")]
	public void IHCKHOLCAJO([Optional] CFIMFIIKPEO FJKEGLCCHFI, [Optional] bool? HNAECPAAPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74344C0", Offset = "0x74338C0", VA = "0x1874344C0")]
	private bool NEIGPEHFMAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7433E60", Offset = "0x7433260", VA = "0x187433E60", Slot = "21")]
	public bool LFFNBBHFEMB(JEMKHCHMBLO.IFCJAEMECIM GJHJAHHLEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7432DC0", Offset = "0x74321C0", VA = "0x187432DC0")]
	private void JEJHMCAADJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x74305A0", Offset = "0x742F9A0", VA = "0x1874305A0")]
	private void GPOFEBMAOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7434140", Offset = "0x7433540", VA = "0x187434140")]
	private static void MFANJHFKDKJ(Dictionary<OJJHMFOHKIH, Material> BIOHKMBAOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x742FCF0", Offset = "0x742F0F0", VA = "0x18742FCF0")]
	private static void GOFPIENBGJK(Dictionary<Renderer, GAOFBAKPJIA> JFFAJOOMDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7430480", Offset = "0x742F880", VA = "0x187430480")]
	private void GPBJFLGCBPF(SkinnedMeshRenderer[] JDDHAEABJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x742D270", Offset = "0x742C670", VA = "0x18742D270")]
	private void BLONABKDGON(SkinnedMeshRenderer AKKIOLPGAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7436200", Offset = "0x7435600", VA = "0x187436200")]
	private void PBLBGCHECFJ(List<OOEAEINEKGH> APNNPANHFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x742E680", Offset = "0x742DA80", VA = "0x18742E680")]
	private void EJJDNNNECKJ(Dictionary<string, JCAOOGBCPCO<Texture2D>> MHJIECJLKAG, bool EFOEKPMBKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x742DE80", Offset = "0x742D280", VA = "0x18742DE80")]
	private void DKOBGKGFPIO(Dictionary<string, List<OJJHMFOHKIH>> MHJIECJLKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x74334A0", Offset = "0x74328A0", VA = "0x1874334A0")]
	private void JODJJOFANJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x742DED0", Offset = "0x742D2D0", VA = "0x18742DED0")]
	private void DPGEAHJKLLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x742C6A0", Offset = "0x742BAA0", VA = "0x18742C6A0")]
	private void BGBFPFOIOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x742FC20", Offset = "0x742F020", VA = "0x18742FC20")]
	private void GMPAMMALLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x742F720", Offset = "0x742EB20", VA = "0x18742F720")]
	private void FJJHCLIPPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x742DD10", Offset = "0x742D110", VA = "0x18742DD10")]
	private void DGFDHDGBFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7435920", Offset = "0x7434D20", VA = "0x187435920")]
	private void OHIBKOFAPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x742F4F0", Offset = "0x742E8F0", VA = "0x18742F4F0")]
	private void FEKEGBPAEEM(bool LPHBBCJHHJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x742F920", Offset = "0x742ED20", VA = "0x18742F920")]
	private void GCEFEFGOJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74343D0", Offset = "0x74337D0", VA = "0x1874343D0")]
	private void NABHLOAPAGP(bool LPHBBCJHHJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x74359F0", Offset = "0x7434DF0", VA = "0x1874359F0")]
	private void OICBBBGDOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x742D7B0", Offset = "0x742CBB0", VA = "0x18742D7B0")]
	private void CNLDBNHJEOL(Material MMCBMDPFDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x742D370", Offset = "0x742C770", VA = "0x18742D370")]
	private void BOPEJKKAFKC(Material MMCBMDPFDPO, Color ABPFOOEGHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x742C440", Offset = "0x742B840", VA = "0x18742C440")]
	private void AIAIDHONFAL(Material MMCBMDPFDPO, Color ABPFOOEGHLD, Color ONMINNEAIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7430960", Offset = "0x742FD60", VA = "0x187430960")]
	private void HLMOBFEMNEH(Material MMCBMDPFDPO, Color LILHMHLMJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x74337A0", Offset = "0x7432BA0", VA = "0x1874337A0")]
	private void LAJPPHABAIN(Material MMCBMDPFDPO, Texture2D LEFNCCFPOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x742FA00", Offset = "0x742EE00", VA = "0x18742FA00")]
	private void GHLNEDKADPG(Material MMCBMDPFDPO, Texture IMLKNDLLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x742E4F0", Offset = "0x742D8F0", VA = "0x18742E4F0")]
	private void EHNCCGBICJH(Action<GAOFBAKPJIA> BCMMBNPMIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x74305B0", Offset = "0x742F9B0", VA = "0x1874305B0")]
	private void HFADEPLMKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x742EB80", Offset = "0x742DF80", VA = "0x18742EB80")]
	private void EOIOHJIJGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x742CE10", Offset = "0x742C210", VA = "0x18742CE10")]
	private void BKELAOCEDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x74330D0", Offset = "0x74324D0", VA = "0x1874330D0")]
	public void JIBLNMPEOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x742DC90", Offset = "0x742D090", VA = "0x18742DC90", Slot = "4")]
	private void PJJLGDMBENA([In] PEIMOGJCFOI CPAJGFIMPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7433460", Offset = "0x7432860", VA = "0x187433460")]
	[CompilerGenerated]
	private OCLDKMPDLBK JMEJFOHPHKP(JFNPPCOIGBP FEPAKEBFLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x742F610", Offset = "0x742EA10", VA = "0x18742F610")]
	[CompilerGenerated]
	private void FIHBMBOJHLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x742F260", Offset = "0x742E660", VA = "0x18742F260")]
	[CompilerGenerated]
	private void FAHPFEHNFKC(GAOFBAKPJIA CMJMALHNEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x742D720", Offset = "0x742CB20", VA = "0x18742D720")]
	[CompilerGenerated]
	private void CKDECPLEEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x742DE60", Offset = "0x742D260", VA = "0x18742DE60")]
	[CompilerGenerated]
	private void DKOALGPNJND(GAOFBAKPJIA CMJMALHNEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x742F890", Offset = "0x742EC90", VA = "0x18742F890")]
	[CompilerGenerated]
	private void GCAMJIJFJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x742F0E0", Offset = "0x742E4E0", VA = "0x18742F0E0")]
	[CompilerGenerated]
	private void FADBBOJICGL(GAOFBAKPJIA CMJMALHNEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x742C3B0", Offset = "0x742B7B0", VA = "0x18742C3B0")]
	[CompilerGenerated]
	private void ACIADIMCDOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x742CDE0", Offset = "0x742C1E0", VA = "0x18742CDE0")]
	[CompilerGenerated]
	private void BHKIGNGCEHC(GAOFBAKPJIA CMJMALHNEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7436450", Offset = "0x7435850", VA = "0x187436450")]
	[CompilerGenerated]
	private void PEHGEJCCDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x742E650", Offset = "0x742DA50", VA = "0x18742E650")]
	[CompilerGenerated]
	private void EHPBFFANDCJ(GAOFBAKPJIA CMJMALHNEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7433EB0", Offset = "0x74332B0", VA = "0x187433EB0")]
	[CompilerGenerated]
	private void MBFLGNGDCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7433740", Offset = "0x7432B40", VA = "0x187433740")]
	[CompilerGenerated]
	private void KEKLFJPNKJN(GAOFBAKPJIA CMJMALHNEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x74336B0", Offset = "0x7432AB0", VA = "0x1874336B0")]
	[CompilerGenerated]
	private void KEJBLNFDFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x74364E0", Offset = "0x74358E0", VA = "0x1874364E0")]
	[CompilerGenerated]
	private void PGGJICINJPH(GAOFBAKPJIA CMJMALHNEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x742F6A0", Offset = "0x742EAA0", VA = "0x18742F6A0")]
	[CompilerGenerated]
	private void FJCPCPBAOCC(KeyValuePair<string, JCAOOGBCPCO<Texture2D>> BNONCNKMPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x742C690", Offset = "0x742BA90", VA = "0x18742C690")]
	[CompilerGenerated]
	private void BFDFHABPEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x742D240", Offset = "0x742C640", VA = "0x18742D240")]
	[CompilerGenerated]
	private void BKLHNLNNCDP(GAOFBAKPJIA CMJMALHNEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x742F9F0", Offset = "0x742EDF0", VA = "0x18742F9F0")]
	[CompilerGenerated]
	private void GEHPOAIIOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7430AF0", Offset = "0x742FEF0", VA = "0x187430AF0")]
	[CompilerGenerated]
	private void HNHAAIBCNHC(GAOFBAKPJIA CMJMALHNEPH)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, FFFMFLNNING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Vector3? GFGMKFHAPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private bool PHLIFDNGGPD;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x74273F0", Offset = "0x74267F0", VA = "0x1874273F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7427A10", Offset = "0x7426E10", VA = "0x187427A10", Slot = "4")]
		public void UpdateController(float JHAIOFABKNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xB55DA0", Offset = "0xB551A0", VA = "0x180B55DA0", Slot = "6")]
		public void SetEnabled(bool PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x74274D0", Offset = "0x74268D0", VA = "0x1874274D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7427ED0", Offset = "0x74272D0", VA = "0x187427ED0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, FFFMFLNNING
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private const float DDMMMHOKBGH = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Vector3 OMGHDBOPCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Vector3 KJLPBCGEBOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private bool PHLIFDNGGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float JOFPHHHAAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private float MCEGCEIODPF;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7428250", Offset = "0x7427650", VA = "0x187428250", Slot = "4")]
		public void UpdateController(float JHAIOFABKNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xFF9C60", Offset = "0xFF9060", VA = "0x180FF9C60", Slot = "6")]
		public void SetEnabled(bool PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7427F70", Offset = "0x7427370", VA = "0x187427F70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7428D10", Offset = "0x7428110", VA = "0x187428D10")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IIBMKBKGNKI : IAENBMOFMLD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int JHCJACNDEGF;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int AODPNGBDOPG;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int FHAKONKJKEN;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int CICGKMKPDOK;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int NAOLPALJAIH;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int LKEDDJOGAPG;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int ECFMGPBALPM;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int JHEGKKEHPPB;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int NODKIGLFLOH;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int OFHKNJBCLFL;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int OOINLGCPLKE;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int CNFAPKDEAJC;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int MBCCMCDKKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int CGMCBMOANBI;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int COGMHJBFHBD;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int LBDKJNAPOMD;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int GNNBCCOMAKL;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int HCBENEAFHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private Transform MIECOKAGKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Transform DLFANNAPCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private Transform FCPHOEABILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private Transform KFMJOCPBAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private Transform NNCOGNPJDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private Transform AMFCKEFECKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Transform JENBODMAFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NBPJKDKHJND KKKMAMBKCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Material IHFJMCJLBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private SkinnedMeshRenderer[] NPIIOPDDFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly List<Material> EBLNHFCHDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private JNKFNELNFPN JIFDAILMMMD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public EBGLFEEDNOA ELBMGACDJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private JNKFNELNFPN MLDCINHCLLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x742A490", Offset = "0x7429890", VA = "0x18742A490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool GJIAKANDJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x742A8A0", Offset = "0x7429CA0", VA = "0x18742A8A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x742B9C0", Offset = "0x742ADC0", VA = "0x18742B9C0")]
	public void OBBALIPJEND([In] NBPJKDKHJND ALNOOCNEEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x742AA20", Offset = "0x7429E20", VA = "0x18742AA20")]
	public void HEKPGEBBKJO([In] FHOFHKOENLI MJFFNOMLMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7429C20", Offset = "0x7429020", VA = "0x187429C20", Slot = "6")]
	public void AEGAEJHODBK(NIJKPLPHOCE ABFGHNJBOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x742BA90", Offset = "0x742AE90", VA = "0x18742BA90")]
	private Vector2 OECBHGPHPDO(Vector2 IAOFFPNCNIH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x742AB00", Offset = "0x7429F00", VA = "0x18742AB00")]
	public void LPICJLBOFLA([In] FIBNFDNIBFJ MJFFNOMLMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x742A0E0", Offset = "0x74294E0", VA = "0x18742A0E0")]
	private void CGNEAKAAMLJ(DMFKIMMOAIF NEMKNPNLHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x742A510", Offset = "0x7429910", VA = "0x18742A510")]
	private void GANBPBIJLFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x742A420", Offset = "0x7429820", VA = "0x18742A420")]
	private void FFKFEJCCGNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x742A420", Offset = "0x7429820", VA = "0x18742A420", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x742BE90", Offset = "0x742B290", VA = "0x18742BE90")]
	public IIBMKBKGNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x742AA20", Offset = "0x7429E20", VA = "0x18742AA20", Slot = "5")]
	private void PLLMGIGMLHI([In] FHOFHKOENLI MJFFNOMLMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x742BAF0", Offset = "0x742AEF0", VA = "0x18742BAF0", Slot = "7")]
	private void OICDPIBADGM([In] FIBNFDNIBFJ MJFFNOMLMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x742BB00", Offset = "0x742AF00", VA = "0x18742BB00")]
	[CompilerGenerated]
	internal static (float, float) PFFBBPDLNNA(float MCOCNKCDPHM)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x742AAC0", Offset = "0x7429EC0", VA = "0x18742AAC0")]
	[CompilerGenerated]
	internal static Vector4 JLLCEOGAPGO(Vector2 HJBDDDIFEBJ, Vector2 JKHHCOODJNJ)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, FFFMFLNNING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private float JOFPHHHAAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool PHLIFDNGGPD;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x743DDA0", Offset = "0x743D1A0", VA = "0x18743DDA0", Slot = "4")]
		public void UpdateController(float JHAIOFABKNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x14F85B0", Offset = "0x14F79B0", VA = "0x1814F85B0", Slot = "6")]
		public void SetEnabled(bool PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x743E820", Offset = "0x743DC20", VA = "0x18743E820")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x743E8C0", Offset = "0x743DCC0", VA = "0x18743E8C0")]
		public void MEKFCHHLHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x743E850", Offset = "0x743DC50", VA = "0x18743E850")]
		public int HNCGILHCHEE(int MOJPEFOMGMK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FMKLMOOCMIN : MCCFPHJJHFH
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x74429E0", Offset = "0x7441DE0", VA = "0x1874429E0", Slot = "22")]
	public override float MJKCJBCKEDN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7442A30", Offset = "0x7441E30", VA = "0x187442A30")]
	public FMKLMOOCMIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MCCFPHJJHFH : MBDCKCDIJDA
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private static int PHBBGBEHGKP;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static int EBBNEEKACMP;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static int HKNPNMJKLKJ;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static int HHDGMIEIAMN;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static int MLOMONCJHMI;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int FPFFEDPBBGF;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int KPGBPIIEHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int[] PEACFIIJFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private OACCOHEPABJ KKKMAMBKCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private AAGHDAAJACF DMFIMGJHNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private int JEBDLEAJDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private float LJJLKCLBOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	protected Animator AIBCJAJGEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected bool HJGPOMCNCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	protected AvatarConfiguration BJONLFDFCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected int EECMNOFOIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private int IBODBGDDGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private int JMGFDJIBHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private bool MGJHNLCJIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private KHIKDCNOCPN GCOGBOBDACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private int BFBIGNKHNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private float OCBAAPLHLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private AvatarHandDisplaySettings EEGFHCBDDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private DIINEKIAPFE NPPGNMCIOLE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform EPEODOAEDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Vector3 JHEOPELKPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x14AE600", Offset = "0x14ADA00", VA = "0x1814AE600")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x14AE440", Offset = "0x14AD840", VA = "0x1814AE440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Quaternion BHAGEDDHEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xC23270", Offset = "0xC22670", VA = "0x180C23270")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xDE59A0", Offset = "0xDE4DA0", VA = "0x180DE59A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HDDBGLHBOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x744A7E0", Offset = "0x7449BE0", VA = "0x18744A7E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x744A390", Offset = "0x7449790", VA = "0x18744A390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 FEILKIOPDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x744A2D0", Offset = "0x74496D0", VA = "0x18744A2D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x744A3E0", Offset = "0x74497E0", VA = "0x18744A3E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Quaternion IIGBLDIDIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x744A400", Offset = "0x7449800", VA = "0x18744A400", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x744A380", Offset = "0x7449780", VA = "0x18744A380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public EFMOGLDOMFL ALEDEDIMDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA9E590", Offset = "0xA9D990", VA = "0x180A9E590", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(EFMOGLDOMFL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA9DA90", Offset = "0xA9CE90", VA = "0x180A9DA90", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EFMOGLDOMFL FIFOLHFLIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2287B00", Offset = "0x2286F00", VA = "0x182287B00", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(EFMOGLDOMFL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2286AB0", Offset = "0x2285EB0", VA = "0x182286AB0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public float MLFFNLDADCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x12FF870", Offset = "0x12FEC70", VA = "0x1812FF870", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xDF8590", Offset = "0xDF7990", VA = "0x180DF8590", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool ODMCBFEPPOC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x744A470", Offset = "0x7449870", VA = "0x18744A470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool HHCBFJDNHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7449EF0", Offset = "0x74492F0", VA = "0x187449EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool PDGGLHDKBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x744A410", Offset = "0x7449810", VA = "0x18744A410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DJHKLIMOIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x744AA10", Offset = "0x7449E10", VA = "0x18744AA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x744A810", Offset = "0x7449C10", VA = "0x18744A810", Slot = "21")]
	public void OBBALIPJEND(OACCOHEPABJ ALNOOCNEEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x744A420", Offset = "0x7449820", VA = "0x18744A420")]
	public void KPCCDPEONJN(AAGHDAAJACF KFDMHDEHOLF, AvatarHandDisplaySettings LHOBKNFOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x744A2F0", Offset = "0x74496F0", VA = "0x18744A2F0", Slot = "12")]
	public void DNHGABOPIKC(bool LOKMCLGPAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7449F00", Offset = "0x7449300", VA = "0x187449F00", Slot = "11")]
	public void ALGHBALMIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x12FF870", Offset = "0x12FEC70", VA = "0x1812FF870", Slot = "22")]
	public virtual float MJKCJBCKEDN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x744A480", Offset = "0x7449880", VA = "0x18744A480")]
	private int MOALAKJEIHA(EFMOGLDOMFL KMFFNFMHLPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x744A600", Offset = "0x7449A00", VA = "0x18744A600")]
	private void NBCPADMAHCL(int HDBCIMDLLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x744A3C0", Offset = "0x74497C0", VA = "0x18744A3C0", Slot = "13")]
	public bool JHAEHFFPCJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x744AA00", Offset = "0x7449E00", VA = "0x18744AA00", Slot = "14")]
	public bool OJLMCBKHAAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x744A270", Offset = "0x7449670", VA = "0x18744A270")]
	private EFMOGLDOMFL AOKMMKPBMOI()
	{
		return default(EFMOGLDOMFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1BC1DD0", Offset = "0x1BC11D0", VA = "0x181BC1DD0", Slot = "15")]
	public void HNBCECICMLA(bool LOKMCLGPAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x744AA20", Offset = "0x7449E20", VA = "0x18744AA20", Slot = "10")]
	public void PMIHLLCEJHK(int HDBCIMDLLCK, float NINNGAEMCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x744A7C0", Offset = "0x7449BC0", VA = "0x18744A7C0", Slot = "8")]
	public void NGKDGLKAALP(KHIKDCNOCPN MLIDEILJAJE, bool CJIJMMBOCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x744A2C0", Offset = "0x74496C0", VA = "0x18744A2C0", Slot = "9")]
	public void CPLBMHHIKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x744A9B0", Offset = "0x7449DB0", VA = "0x18744A9B0", Slot = "16")]
	public void OGAIJBHBABK(Transform HKNGNFLDPKM, Vector3 LPCBIJGIIBF, Quaternion NJEEKLMANDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x744ACF0", Offset = "0x744A0F0", VA = "0x18744ACF0")]
	public MCCFPHJJHFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DIAJBNMBCLD : JFNPPCOIGBP
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FNAGGBGIACK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public DIAJBNMBCLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public List<OOEAEINEKGH> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public List<OOEAEINEKGH> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public JCAOOGBCPCO<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public JCAOOGBCPCO<IOHPJAMOGEK> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public FNAGGBGIACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7442A90", Offset = "0x7441E90", VA = "0x187442A90")]
		internal OCLDKMPDLBK KFKNNOGKDMF(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public PFLMFICBCEJ DBGFIHFHGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public IOHPJAMOGEK OCFHCNCFMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private JCAOOGBCPCO<IOHPJAMOGEK> FEDKJOBIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private JCAOOGBCPCO<Material[]> FIAMNMFCBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Material[] MHNCHMEJEJF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool IGNMHGHCLFN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x993140", Offset = "0x992540", VA = "0x180993140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x992EC0", Offset = "0x9922C0", VA = "0x180992EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public JEMKHCHMBLO.IFCJAEMECIM ANBLOICENLA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
		[CompilerGenerated]
		get
		{
			return default(JEMKHCHMBLO.IFCJAEMECIM);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x96FCD0", Offset = "0x96F0D0", VA = "0x18096FCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7442970", Offset = "0x7441D70", VA = "0x187442970")]
	public DIAJBNMBCLD(FGFOFKPBCAF CNAGADBDHAP, PFLMFICBCEJ BOAIJHLCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7441680", Offset = "0x7440A80", VA = "0x187441680", Slot = "6")]
	public override OCLDKMPDLBK DFBNBKEGOMN(List<OOEAEINEKGH> AKJDHLAOJOP, List<OOEAEINEKGH> FIHAAEHJJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7441B20", Offset = "0x7440F20", VA = "0x187441B20")]
	public OCLDKMPDLBK IGANJLGMKAF(List<OOEAEINEKGH> AKJDHLAOJOP, List<OOEAEINEKGH> FIHAAEHJJFO, JCAOOGBCPCO<Material[]> FIAMNMFCBHJ, [Optional] JCAOOGBCPCO<IOHPJAMOGEK> EIKEFCIAKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7442100", Offset = "0x7441500", VA = "0x187442100")]
	public (JCAOOGBCPCO<Material[]>, JCAOOGBCPCO<IOHPJAMOGEK>) MDEMJMMDCNF(List<OOEAEINEKGH> AKJDHLAOJOP, List<OOEAEINEKGH> FIHAAEHJJFO)
	{
		return default((JCAOOGBCPCO<Material[]>, JCAOOGBCPCO<IOHPJAMOGEK>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x74427F0", Offset = "0x7441BF0", VA = "0x1874427F0", Slot = "7")]
	public override JIDPIGAIGOP PNENNOKJENN(uint AKKLJPLLNIC, AvatarSkinnedMeshBoneOrderRemapsData KCLPCDEHJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7441E20", Offset = "0x7441220", VA = "0x187441E20")]
	public JIDPIGAIGOP LDGCAKFFCJG(GameObject MLLMEIAEFBA, uint AKKLJPLLNIC, bool JHDKMNPEMKF, bool EEBNGEEGCEB, AvatarSkinnedMeshBoneOrderRemapsData KCLPCDEHJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7442490", Offset = "0x7441890", VA = "0x187442490")]
	public static bool PJKIIJINJIH(Renderer[] JDDHAEABJGF, string PDKHJBDMMHG, [Out] Renderer FAGIIMOLMNJ, [Out] Renderer ICIKBINIPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7442920", Offset = "0x7441D20", VA = "0x187442920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7442030", Offset = "0x7441430", VA = "0x187442030")]
	private (JCAOOGBCPCO<IOHPJAMOGEK>, JCAOOGBCPCO<Material[]>) MAPEFKIMFID()
	{
		return default((JCAOOGBCPCO<IOHPJAMOGEK>, JCAOOGBCPCO<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7442470", Offset = "0x7441870", VA = "0x187442470")]
	[CompilerGenerated]
	private void OGMJCMLCFFG(IOHPJAMOGEK HOCIBOCHCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x964300", Offset = "0x963700", VA = "0x180964300")]
	[CompilerGenerated]
	private void NLHLFJMGGOG(Material[] HOCIBOCHCFJ)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, FFFMFLNNING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private Vector3 OMGHDBOPCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private Vector3 ELMKJKNKKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private Vector3 OAGCKIJMKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private Matrix4x4 GBEEPJBEKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private bool PHLIFDNGGPD;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x743EE50", Offset = "0x743E250", VA = "0x18743EE50", Slot = "4")]
		public void UpdateController(float JHAIOFABKNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x743EE40", Offset = "0x743E240", VA = "0x18743EE40", Slot = "6")]
		public void SetEnabled(bool PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x743E9E0", Offset = "0x743DDE0", VA = "0x18743E9E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x743F510", Offset = "0x743E910", VA = "0x18743F510")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[MENIDINFMMJ]
public struct GGPKAIBBNCF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	[ReadOnly]
	public LKBGKMOODCI LFGDFOKFLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	[ReadOnly]
	public int BCKFCFLNLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public PJFEHCEGOEP MDJDPOGCLOE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x74458F0", Offset = "0x7444CF0", VA = "0x1874458F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[MENIDINFMMJ]
public struct PJFEHCEGOEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector3> DMEFNADHLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector3> ADEFIMFPPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector4> MJLHPEJKCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> PDLFKNMDIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector2> LCPLLLHAOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector2> NGNFHJJLAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector2> NOONMDGNLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Color> MPHEILABLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> LGBOGPFFDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> DGICAJJNJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<int> INBMEPAFDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private NativeArray<int> JJCOJBMHEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> NFKKGODHJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> JFHBOMGMLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<int> MPHOMGIPEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<BoneWeight> KNAGGBKJAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> GAPCIOOOOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private bool BGCFHENHHJD;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int KHDPOANANBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x744E110", Offset = "0x744D510", VA = "0x18744E110")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x744E0B0", Offset = "0x744D4B0", VA = "0x18744E0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int LJJBDGPMFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x744E010", Offset = "0x744D410", VA = "0x18744E010")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x744DF70", Offset = "0x744D370", VA = "0x18744DF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int JHLGAOPGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x744D8C0", Offset = "0x744CCC0", VA = "0x18744D8C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x744E2C0", Offset = "0x744D6C0", VA = "0x18744E2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x744E2D0", Offset = "0x744D6D0", VA = "0x18744E2D0")]
	public PJFEHCEGOEP(int JMNHBPEFOID, int CPAMACJAGBF, int JMDLIPDPGPB, int POKEFPEKPCG, Allocator FALBINAEKDG, int JICJDHCOIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x744DFA0", Offset = "0x744D3A0", VA = "0x18744DFA0")]
	public void IMDOHAAKOKC(int FFCBHHABFJN, Vector3 CKLNAHKPEEA, Vector3 AHFGMNBCHCA, Vector4 MPAMMAGABHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x744E120", Offset = "0x744D520", VA = "0x18744E120")]
	public void MLJJIFFIEBK(int FFCBHHABFJN, BoneWeight KIDLGJFCDJI, NativeSlice<byte> APMMBEKIAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x744DF80", Offset = "0x744D380", VA = "0x18744DF80")]
	public Color IFMHNLGPFEH(int FFCBHHABFJN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x744DEA0", Offset = "0x744D2A0", VA = "0x18744DEA0")]
	public void FKLOKKNKOMI(int FFCBHHABFJN, Color FBGCPEAGLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x744E0C0", Offset = "0x744D4C0", VA = "0x18744E0C0")]
	public void LMKJFMIFCIH(byte PGMAINGIGPA, int FFCBHHABFJN, Vector2 ENPEMOFMIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x744D880", Offset = "0x744CC80", VA = "0x18744D880")]
	public void COIAKPCFEDI(int FFCBHHABFJN, int CJBFPNMNIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x744D890", Offset = "0x744CC90", VA = "0x18744D890")]
	public bool DEODECNDGGF(int PGMAINGIGPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x744DDD0", Offset = "0x744D1D0", VA = "0x18744DDD0")]
	public void EPEKJKJBEII(int GCKLCOBEDON, int FGCNBOMLCIC, int EHCAJIFPCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x744DEC0", Offset = "0x744D2C0", VA = "0x18744DEC0")]
	public int[] GBKJNIKAOOD(int GCKLCOBEDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x744E020", Offset = "0x744D420", VA = "0x18744E020")]
	private NativeSlice<int> KHPBMNICJFO(int GCKLCOBEDON)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x744D8D0", Offset = "0x744CCD0", VA = "0x18744D8D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x744DA80", Offset = "0x744CE80", VA = "0x18744DA80")]
	public Mesh ELHPJAPGFMD([Optional] string FABFJPGHADM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[MENIDINFMMJ]
[DefaultMember("Item")]
[NativeContainer]
public struct LKBGKMOODCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<Vector3> DMEFNADHLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Vector3> ADEFIMFPPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<Vector4> MJLHPEJKCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<Vector2> PDLFKNMDIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<Vector2> LCPLLLHAOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector2> NGNFHJJLAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector2> NOONMDGNLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Color> MPHEILABLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<int> OMJMOEPHDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<int> ENOOEPPIPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<int> OJGJLKMBCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<int> DFLMFJBPCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<bool> CCPPPCLPFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> EGLHKMAGHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> PPOEJLEMLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<BoneWeight> GJLOMGIBDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private NativeArray<Matrix4x4> BNLENHGBNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private NativeArray<long> NIFBADDLCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private NativeArray<byte> BPBNGBLPNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private NativeArray<int> AMJIDEIPPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private NativeArray<int> LIOPEBIBEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<sbyte> FMOKIKOLAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<byte> BAGFIDNNGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<int> JIBJDOFPHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private bool BGCFHENHHJD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int NKDLDJBKCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x25BC6E0", Offset = "0x25BBAE0", VA = "0x1825BC6E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int DIBMKAFLNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB58810", Offset = "0xB57C10", VA = "0x180B58810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int FMCBEJKHKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7447F90", Offset = "0x7447390", VA = "0x187447F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int PEEJFKBGPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x74480E0", Offset = "0x74474E0", VA = "0x1874480E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7447F70", Offset = "0x7447370", VA = "0x187447F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KHDPOANANBB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7447FF0", Offset = "0x74473F0", VA = "0x187447FF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7447FE0", Offset = "0x74473E0", VA = "0x187447FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EDIIGDADJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x74477B0", Offset = "0x7446BB0", VA = "0x1874477B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7447FD0", Offset = "0x74473D0", VA = "0x187447FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public HOICEHILGLA KNFGJANPFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7447F80", Offset = "0x7447380", VA = "0x187447F80")]
		get
		{
			return default(HOICEHILGLA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x74477C0", Offset = "0x7446BC0", VA = "0x1874477C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public byte ANFIFCKFNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7447FC0", Offset = "0x74473C0", VA = "0x187447FC0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x74480D0", Offset = "0x74474D0", VA = "0x1874480D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CALLMKAHDKB BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7447A40", Offset = "0x7446E40", VA = "0x187447A40")]
		get
		{
			return default(CALLMKAHDKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x74480F0", Offset = "0x74474F0", VA = "0x1874480F0")]
	public LKBGKMOODCI(IList<Mesh> LCPDPHMNGDF, IList<Matrix4x4> NHLKMCHPIJO, IList<bool> CCPPPCLPFOM, byte KDLMKHFIMOE, IList<byte[]> CEGNGFAEAIP, IList<long> NBLKAMIBMFM, IList<bool> EAHOJKOLOEL, IList<int> EGLHKMAGHPC, IList<int> FNCPPDHDPLG, IList<int> HMDDDHFMDBP, Allocator FALBINAEKDG, HOICEHILGLA GJHKPHJLIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7448000", Offset = "0x7447400", VA = "0x187448000")]
	public PJFEHCEGOEP MGAPFFIHMMN(Allocator FALBINAEKDG)
	{
		return default(PJFEHCEGOEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x74477D0", Offset = "0x7446BD0", VA = "0x1874477D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[MENIDINFMMJ]
public class HIJPMMFKPDL : EHHBNFLMJPC
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7446B10", Offset = "0x7445F10", VA = "0x187446B10")]
	public LKBGKMOODCI FBAOEPIGPFH()
	{
		return default(LKBGKMOODCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x743A510", Offset = "0x7439910", VA = "0x18743A510")]
	public HIJPMMFKPDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct CALLMKAHDKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeSlice<Vector3> DMEFNADHLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeSlice<Vector3> ADEFIMFPPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeSlice<Vector4> MJLHPEJKCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeSlice<Vector2> PDLFKNMDIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeSlice<Vector2> LCPLLLHAOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<Vector2> NGNFHJJLAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<Vector2> NOONMDGNLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Color> MPHEILABLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<int> GNADLJBAKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<int> DFLMFJBPCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<BoneWeight> GJLOMGIBDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<byte> FMONEEMGAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public int NLMELCMIEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public Matrix4x4 JGMIEOFJBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public long ODMEBKLIPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<byte> APMMBEKIAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public bool IJPAHMDIIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public int NJKIJFHEIBF;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct OJJHMFOHKIH : IEquatable<OJJHMFOHKIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	internal readonly Material AAJNLIMEBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	internal readonly DGELAGPJCGL AKGMAMBHJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	internal readonly MOKDCLELCHM HPNAMLNLOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	internal readonly FGFOFKPBCAF ADKLHBIHDNA;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x744BB80", Offset = "0x744AF80", VA = "0x18744BB80")]
	public OJJHMFOHKIH(Material GIEDFKFHBFF, DGELAGPJCGL LCDDGKHBODE, MOKDCLELCHM LGEFBLDNOIB, FGFOFKPBCAF CBBFCGBIHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x744B960", Offset = "0x744AD60", VA = "0x18744B960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x744B840", Offset = "0x744AC40", VA = "0x18744B840", Slot = "4")]
	public bool Equals(OJJHMFOHKIH MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x744B760", Offset = "0x744AB60", VA = "0x18744B760", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x744B8C0", Offset = "0x744ACC0", VA = "0x18744B8C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, HLDIOKBHFCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		[Header("Configuration")]
		private DIINEKIAPFE avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private NHBJOEBCOCP LPGNIDOGAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private IAENBMOFMLD FCDJKGHHHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private MBDCKCDIJDA GBOPGCJIHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private MBDCKCDIJDA AAKHNKNNOAP;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public NHBJOEBCOCP LMOFHGMMECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x7440380", Offset = "0x743F780", VA = "0x187440380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public IAENBMOFMLD NBHAKAKGHCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x74403D0", Offset = "0x743F7D0", VA = "0x1874403D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public MBDCKCDIJDA GANCCIOCOGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x74405F0", Offset = "0x743F9F0", VA = "0x1874405F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public MBDCKCDIJDA MPBFMGGKGHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x7440640", Offset = "0x743FA40", VA = "0x187440640", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Transform ONCAPKLALNO
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7440690", Offset = "0x743FA90", VA = "0x187440690", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DIINEKIAPFE CCBKMGCAFKO
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x96FB20", Offset = "0x96EF20", VA = "0x18096FB20", Slot = "12")]
			get
			{
				return default(DIINEKIAPFE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x743F7B0", Offset = "0x743EBB0", VA = "0x18743F7B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x74401E0", Offset = "0x743F5E0", VA = "0x1874401E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x74400F0", Offset = "0x743F4F0", VA = "0x1874400F0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x74401E0", Offset = "0x743F5E0", VA = "0x1874401E0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x743FA10", Offset = "0x743EE10", VA = "0x18743FA10", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7440290", Offset = "0x743F690", VA = "0x187440290")]
		public void UpdatePostIKAnimControllers(float JHAIOFABKNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7440150", Offset = "0x743F550", VA = "0x187440150")]
		private void NMFPMCPHIAB(GameObject NBAMGPFDMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x743FD40", Offset = "0x743F140", VA = "0x18743FD40")]
		private NHBJOEBCOCP DGKJBFECMJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x743F820", Offset = "0x743EC20", VA = "0x18743F820")]
		private IAENBMOFMLD BKBCEIDAJHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x743F520", Offset = "0x743E920", VA = "0x18743F520")]
		private MBDCKCDIJDA AHLBFPAPKOL(PMBKDIGAKIN PPBJGEKMDDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7440370", Offset = "0x743F770", VA = "0x187440370")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class GAOFBAKPJIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private MaterialPropertyBlock EMEBPCKIHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public Color? CPHGMAOMDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Color? MBIEELGBHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Color? IGOCHOIDINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Color? BECGDMEGCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Color NCAJMMPKOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Color OFOAGNCLMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public Color NLHAMNPDCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Texture2D JEJHBDLMFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Texture2D IGJEJAECEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private Dictionary<OJJHMFOHKIH, int> ABPLDJNMAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private DGELAGPJCGL[] KJPHLCGNNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private MOKDCLELCHM[] HCIFCGELOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Vector4[] OBKKPDIEJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Vector4[] NLFIDCBCHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Vector4[] GIOADBLAJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Vector4[] KEPMIPDGFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public Vector4[] JKONBBKCMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Vector4[] IKIOGFGMFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private List<Texture2D> BADDEACDDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private Vector4[] KPNDOCHKBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private List<Texture2D> ICPLDCHLKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private float[] JEPKPKEBNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private Vector4[] HJNNLGOIMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private float[] EAAMJHBBAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public float[] PGKEIJEJHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> NPKNJLDIHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private float[] BFHNIGHFFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> CFKGJKIIBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private Vector4[] GBBBDDHEIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private float[] IOEOLGKIGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private Vector4[] EOKMBOFELOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] FPFLGKMLDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public Texture2DArray KKOEAPEEAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public Texture2DArray FBJDIDLAMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public Texture2DArray DIKKMCKMKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public Texture2DArray AHOBJNEEECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private bool HGDMPIEMBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private int NFEDHFCBNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private Vector2? MDHLLEDHLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private TextureFormat JBNIIHBIHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private Vector2? IFLBPCNFFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private TextureFormat CFIACFCAECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private Vector2? IILPNKNBDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private TextureFormat KOFLIAIKMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private Vector2? BLIEEECKDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private TextureFormat HNLJEFNMLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private bool JBOKBJOADDP;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int PJHOHGPGHAG;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int FJJNCJIBLIK;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int FPIPPCJCAIG;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int HKLGCKMDPFE;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int MBILKBAFKGB;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int BPDKAJCMACI;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int IFMDIMCDAOA;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int GGEEENEHIPA;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int KCBODELPHJG;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int OIEJCEFFCNL;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int JGMLGAIAOJP;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int BLKLJLEALKD;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int EFONFMAGKLG;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int DFLJGDDLGBH;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int NHNKKEHILCH;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int CDFIBGNPJCE;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int CJEEDPGFCJH;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int DCFPOMOLOFA;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int FKPKMCAMBIO;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int DJEEGAAADEG;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7445340", Offset = "0x7444740", VA = "0x187445340")]
	private GAOFBAKPJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7445830", Offset = "0x7444C30", VA = "0x187445830")]
	public GAOFBAKPJIA(Color JLGJDBKIIPE, Color LOMINNKLFIF, Color NGGIHNCPJAF, Color? JDMJAFAMPGP, Color? JJNMPIILLMJ, Color? GGNPFJNCHNB, Texture2D BFPCDCANMCH, Texture2D AGEGLDBDGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x74431C0", Offset = "0x74425C0", VA = "0x1874431C0")]
	internal int HAAJAINEDGO(Material COGLOKJGGNE, DGELAGPJCGL LCDDGKHBODE, MOKDCLELCHM LGEFBLDNOIB, FGFOFKPBCAF CBBFCGBIHBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7443130", Offset = "0x7442530", VA = "0x187443130")]
	private int HAAJAINEDGO(OJJHMFOHKIH MCNLCGLNHHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7444420", Offset = "0x7443820", VA = "0x187444420")]
	internal int PAMKHPKCMIJ(Material COGLOKJGGNE, Color LILHMHLMJHJ, Color IDINJOGOKPO, Color KCBGFDFFGHK, Color LHJKPNILPMP, Color EAGKGNCBDNC, Texture2D BOCHOPNJLDB, Vector4 OAHFKOIKHGA, Texture2D HKIFOJBNLBE, Vector4 LPJOPMMGFIH, float MDJHOGMCKCJ, float KOJNHJMCNNE, Texture2D LJIJLENDBKA, Vector4 GGNFPLBCCBP, float ACOBLGMFOKN, Texture2D JCNEHJDDBEA, Color EOPJFHKGKON, Vector4 BLOADCDACHP, DGELAGPJCGL LCDDGKHBODE, MOKDCLELCHM LGEFBLDNOIB, FGFOFKPBCAF CBBFCGBIHBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7442DE0", Offset = "0x74421E0", VA = "0x187442DE0")]
	private void DCBHEGGBAFB(List<Texture2D> BADDEACDDGC, [Out] Texture2DArray DIGCPGCBOIO, [Out] Texture2DArray NGMIHJDKHJB, [Out] Texture2DArray JOIHPAKGGKH, [Out] Texture2DArray EGDEFJGCAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x74432B0", Offset = "0x74426B0", VA = "0x1874432B0")]
	public void IKEPGMHPJMJ(Shader LPJBDMIGHLP, Renderer CJJNPFGBHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7443760", Offset = "0x7442B60", VA = "0x187443760")]
	private void NKOHEDDDLAJ(Shader LPJBDMIGHLP, Renderer CJJNPFGBHFH, int JFDBFBFBEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7443400", Offset = "0x7442800", VA = "0x187443400")]
	private Color JBDIEGDGJEG(Color HLMFDMBPHLE, DGELAGPJCGL DKOKEINPBND)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7442FE0", Offset = "0x74423E0", VA = "0x187442FE0")]
	private Color GGJIELLFBFF(Color JODMBGKAODK, DGELAGPJCGL DKOKEINPBND)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7443600", Offset = "0x7442A00", VA = "0x187443600")]
	private bool JKGFCNCDGNE(Texture2D HCNDHKBCICP, MOKDCLELCHM DNLKJGJDLBL, [Out] Texture2D JPMIFGANFIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7442D30", Offset = "0x7442130", VA = "0x187442D30")]
	private void ANOODEMMHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7442FA0", Offset = "0x74423A0", VA = "0x187442FA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class JFNPPCOIGBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public readonly FGFOFKPBCAF HMHGMKLFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	protected bool JFKCHEKLCIO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool NFLEMECECMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xB8D840", Offset = "0xB8CC40", VA = "0x180B8D840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xB8D080", Offset = "0xB8C480", VA = "0x180B8D080")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool NLFNEKMFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xB8D860", Offset = "0xB8CC60", VA = "0x180B8D860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xB8E5A0", Offset = "0xB8D9A0", VA = "0x180B8E5A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public virtual JEMKHCHMBLO.IFCJAEMECIM ODMEBKLIPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JEMKHCHMBLO.IFCJAEMECIM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xB70030", Offset = "0xB6F430", VA = "0x180B70030", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool FDBBOIADILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1164CC0", Offset = "0x11640C0", VA = "0x181164CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool CHEKCKFNNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7446F20", Offset = "0x7446320", VA = "0x187446F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool IKAONHOGLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7446F50", Offset = "0x7446350", VA = "0x187446F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool LINNBAJDBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7446F30", Offset = "0x7446330", VA = "0x187446F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7446F60", Offset = "0x7446360", VA = "0x187446F60")]
	protected JFNPPCOIGBP(FGFOFKPBCAF CNAGADBDHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract OCLDKMPDLBK DFBNBKEGOMN(List<OOEAEINEKGH> AKJDHLAOJOP, List<OOEAEINEKGH> FIHAAEHJJFO);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract JIDPIGAIGOP PNENNOKJENN(uint AKKLJPLLNIC, AvatarSkinnedMeshBoneOrderRemapsData KCLPCDEHJNC);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BIDACLPBCKK : BNDKBNFEGBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private AvatarSkinAssetItem JPPBAHBKNIK;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7440DD0", Offset = "0x74401D0", VA = "0x187440DD0")]
	public BIDACLPBCKK(AvatarSkinAssetItem DAEHDKOMAFF, AvatarSkinAssetItem.BNPPOKIJAMP BFOCKINCOPP, FGFOFKPBCAF CBBFCGBIHBA, [Optional] AFEABOIFMLA? IJENEBIDOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7440B70", Offset = "0x743FF70", VA = "0x187440B70", Slot = "6")]
	public override OCLDKMPDLBK DFBNBKEGOMN(List<OOEAEINEKGH> AKJDHLAOJOP, List<OOEAEINEKGH> FIHAAEHJJFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class INCLNEHLOGC
{
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static readonly int[] OPBKEFENJPF;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static readonly int[] GNHOGFGADFG;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static int[] JJNFMBKAEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7446C80", Offset = "0x7446080", VA = "0x187446C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7446C00", Offset = "0x7446000", VA = "0x187446C00")]
	public static int[] DPNNOEPNBNE(bool DBMGOBCBKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7446D00", Offset = "0x7446100", VA = "0x187446D00")]
	public static int KPFDDLNBBMH(BJOOMCLMBJJ GFOOPLNMAEB, bool DBMGOBCBKGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7446CF0", Offset = "0x74460F0", VA = "0x187446CF0")]
	private static int JFNIAGLGHOO(BJOOMCLMBJJ GFOOPLNMAEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7446CD0", Offset = "0x74460D0", VA = "0x187446CD0")]
	private static int HJKIMLHOEAK(BJOOMCLMBJJ GFOOPLNMAEB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MIGPIDLBNGL
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class JMNCHODIELA : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public JMNCHODIELA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x10BFC80", Offset = "0x10BF080", VA = "0x1810BFC80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7446F90", Offset = "0x7446390", VA = "0x187446F90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	public static void MOKILFHLFMJ(string NNKBGKICBEC, int AKKLJPLLNIC, long IICFBNBINNO, long MNFDCGHNCIK, long OMNIFPKIIAG, long OKLCBLHBOBJ, long GACKLFFFCLE, long JAKPNAPPFCF, long MLLLIAAJGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x744AD80", Offset = "0x744A180", VA = "0x18744AD80")]
	public static DCOKPPOHOJG LIPJAOCEFEJ(JobHandle NLEFLBDIKKD, bool HJEMLOFHCIN, bool AHBEMLNMCKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x744AD10", Offset = "0x744A110", VA = "0x18744AD10")]
	[IteratorStateMachine(typeof(JMNCHODIELA))]
	private static IEnumerator<MOLDBMJPKNN> IKLLOBJIJFP(JobHandle ODHBLOGMAPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HEECGMNAKBH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum IHNOBDEKDMH
	{
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly int PGOAILJDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly int IPILFJOOEND;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly int KCIDIDAOACA;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly int CNCCKGEMAJP;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly int CMOKPKCMKLO;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly int BGAOADLLNNA;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly int HMMJELGBJAK;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int FJMOLMPPENP;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7446930", Offset = "0x7445D30", VA = "0x187446930")]
	public static bool PJCBGDKDJDC(Material GIEDFKFHBFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7446870", Offset = "0x7445C70", VA = "0x187446870")]
	public static bool KHENOEAJIIL(Material GIEDFKFHBFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BNDKBNFEGBG : JFNPPCOIGBP
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class LHJDICMNOGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public JCAOOGBCPCO<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public BNDKBNFEGBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LHJDICMNOGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x74472A0", Offset = "0x74466A0", VA = "0x1874472A0")]
		internal void BBADHEJGIDL(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7447670", Offset = "0x7446A70", VA = "0x187447670")]
		internal void KFKNNOGKDMF(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	protected AvatarSkinAssetItem FGPIBICHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	protected Material[] MAABFFJPDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private readonly AvatarSkinAssetItem.BNPPOKIJAMP CEILFIJAEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly AssetReference OFMJPCLJLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private readonly AFEABOIFMLA? GEMLHNNINOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private SkinnedMeshRenderer[] ECAIOGPPGCH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public override JEMKHCHMBLO.IFCJAEMECIM ODMEBKLIPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JEMKHCHMBLO.IFCJAEMECIM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x96A770", Offset = "0x969B70", VA = "0x18096A770", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7441430", Offset = "0x7440830", VA = "0x187441430")]
	public BNDKBNFEGBG(AvatarSkinAssetItem.BNPPOKIJAMP BFOCKINCOPP, AssetReference GIDCCLDJINI, Material LGDDLMEIDEM, FGFOFKPBCAF CBBFCGBIHBA, JEMKHCHMBLO.IFCJAEMECIM LCFEOLPILCM = (JEMKHCHMBLO.IFCJAEMECIM)0L, [Optional] AFEABOIFMLA? IJENEBIDOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7441560", Offset = "0x7440960", VA = "0x187441560")]
	public BNDKBNFEGBG(AvatarSkinAssetItem.BNPPOKIJAMP BFOCKINCOPP, AssetReference GIDCCLDJINI, Material LGDDLMEIDEM, JEMKHCHMBLO.IFCJAEMECIM LCFEOLPILCM = (JEMKHCHMBLO.IFCJAEMECIM)0L, [Optional] AFEABOIFMLA? IJENEBIDOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7440F20", Offset = "0x7440320", VA = "0x187440F20", Slot = "6")]
	public override OCLDKMPDLBK DFBNBKEGOMN(List<OOEAEINEKGH> AKJDHLAOJOP, List<OOEAEINEKGH> FIHAAEHJJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x74410F0", Offset = "0x74404F0", VA = "0x1874410F0", Slot = "7")]
	public override JIDPIGAIGOP PNENNOKJENN(uint AKKLJPLLNIC, AvatarSkinnedMeshBoneOrderRemapsData KCLPCDEHJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x74413C0", Offset = "0x74407C0", VA = "0x1874413C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7440ED0", Offset = "0x74402D0", VA = "0x187440ED0")]
	protected void BDDFLGPHODO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class OJONGFGIIBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private List<int> OBJHHDAAFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private List<BGNLCNJECMC> ELJEACNMMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private HashSet<Transform> EMMCOPECBGE;

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x744BFB0", Offset = "0x744B3B0", VA = "0x18744BFB0")]
	public static OJONGFGIIBH BHCKCKLCAPD(Transform MPAMMAGABHA, Dictionary<Transform, OutfitType?> OHJPCMMCPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x744C270", Offset = "0x744B670", VA = "0x18744C270")]
	private void ENPOOBFIJIP(Transform MPAMMAGABHA, FGFOFKPBCAF CBBFCGBIHBA, Dictionary<Transform, OutfitType?> OHJPCMMCPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x744C140", Offset = "0x744B540", VA = "0x18744C140")]
	private void EEKCAMLFEBJ(Transform MHJHFBGHAHI, FGFOFKPBCAF CBBFCGBIHBA, bool COPJNMGBEKA, OutfitType? IPCKIOFDOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x744BBC0", Offset = "0x744AFC0", VA = "0x18744BBC0")]
	public ONODJOHEMEN APEHGNIHDKF(HashSet<string> NFDDAMHDFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x744C530", Offset = "0x744B930", VA = "0x18744C530")]
	public OJONGFGIIBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class ONODJOHEMEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private List<BGNLCNJECMC> ELJEACNMMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private List<Matrix4x4> GBAEBKEEKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private Transform[] IHBFEIJIECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private Matrix4x4[] BIMBGLAILHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private Dictionary<LHDFJLIEGMI, int> FJAHJOIMIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<ACLNDHHLHOE> GBDMPJGJHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private bool PHOKOHBBFNO;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x744C830", Offset = "0x744BC30", VA = "0x18744C830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Transform[] OPAPGAPALFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x744C660", Offset = "0x744BA60", VA = "0x18744C660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Matrix4x4[] MHKBLICEMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x744C7C0", Offset = "0x744BBC0", VA = "0x18744C7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x744C870", Offset = "0x744BC70", VA = "0x18744C870")]
	public void EEKCAMLFEBJ(Transform MHJHFBGHAHI, FGFOFKPBCAF CBBFCGBIHBA, OutfitType? IPCKIOFDOOM, bool MNDNHPFNCGL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x744CA60", Offset = "0x744BE60", VA = "0x18744CA60")]
	private void EEKCAMLFEBJ(Transform MHJHFBGHAHI, FGFOFKPBCAF CBBFCGBIHBA, OutfitType? IPCKIOFDOOM, bool MNDNHPFNCGL, Matrix4x4 EKBGGJLDJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x744CDA0", Offset = "0x744C1A0", VA = "0x18744CDA0")]
	public int FIHGLFMKCOG(LHDFJLIEGMI MCNLCGLNHHO, bool CCCCLOLJHHC, [Optional] OutfitType? IPCKIOFDOOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x744D090", Offset = "0x744C490", VA = "0x18744D090")]
	public int IOBINPJHPHO(FGFOFKPBCAF CBBFCGBIHBA, [Optional] OutfitType? IPCKIOFDOOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x744D190", Offset = "0x744C590", VA = "0x18744D190")]
	public void MPBHDJJKDAB(LHDFJLIEGMI MCNLCGLNHHO, Matrix4x4 JHHGFIELIKL, bool CCCCLOLJHHC = false, [Optional] OutfitType? IPCKIOFDOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x744CF50", Offset = "0x744C350", VA = "0x18744CF50")]
	public Matrix4x4 GOPMCHJBONO(LHDFJLIEGMI MCNLCGLNHHO, bool CCCCLOLJHHC, [Optional] OutfitType? IPCKIOFDOOM)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x119BD20", Offset = "0x119B120", VA = "0x18119BD20")]
	public void ODLHFCBEJGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x744D280", Offset = "0x744C680", VA = "0x18744D280")]
	public ONODJOHEMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct LHDFJLIEGMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public readonly string FLPHKFBFLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public readonly FGFOFKPBCAF ADKLHBIHDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public readonly OutfitType? NELNBKBFCJK;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7447260", Offset = "0x7446660", VA = "0x187447260")]
	public LHDFJLIEGMI(string FJLJJNGMMAD, FGFOFKPBCAF CBBFCGBIHBA, [Optional] OutfitType? IPCKIOFDOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x74471B0", Offset = "0x74465B0", VA = "0x1874471B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x74470F0", Offset = "0x74464F0", VA = "0x1874470F0")]
	public bool HMBOCEMAMKA(LHDFJLIEGMI MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7446FE0", Offset = "0x74463E0", VA = "0x187446FE0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7447080", Offset = "0x7446480", VA = "0x187447080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct ACLNDHHLHOE : IEquatable<ACLNDHHLHOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public readonly FGFOFKPBCAF ADKLHBIHDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public readonly OutfitType? LCLCLMHOHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public readonly int NNLNLGBIIDA;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x743DD90", Offset = "0x743D190", VA = "0x18743DD90")]
	public ACLNDHHLHOE(FGFOFKPBCAF CBBFCGBIHBA, int KCIBGKILDGB, [Optional] OutfitType? BFFKKEKOOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x743DCC0", Offset = "0x743D0C0", VA = "0x18743DCC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x673CA70", Offset = "0x673BE70", VA = "0x18673CA70")]
	public bool CGDJAHIKIMH(FGFOFKPBCAF CBBFCGBIHBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x743DC40", Offset = "0x743D040", VA = "0x18743DC40")]
	public bool LOGHICKMEIG(OutfitType? BFFKKEKOOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x743DBA0", Offset = "0x743CFA0", VA = "0x18743DBA0", Slot = "4")]
	public bool Equals(ACLNDHHLHOE MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x743DAB0", Offset = "0x743CEB0", VA = "0x18743DAB0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x743DBF0", Offset = "0x743CFF0", VA = "0x18743DBF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BGNLCNJECMC : IEquatable<BGNLCNJECMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public readonly Transform MDIMIANDOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly bool BPHAOGEMNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly FGFOFKPBCAF GBKBPJBLCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly OutfitType? NELNBKBFCJK;

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7440B20", Offset = "0x743FF20", VA = "0x187440B20")]
	public BGNLCNJECMC(Transform MHJHFBGHAHI, bool COPJNMGBEKA, FGFOFKPBCAF EINJCENBLDE, [Optional] OutfitType? MNJEGJHMFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7440910", Offset = "0x743FD10", VA = "0x187440910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x74406B0", Offset = "0x743FAB0", VA = "0x1874406B0", Slot = "4")]
	public bool Equals(BGNLCNJECMC MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x74407B0", Offset = "0x743FBB0", VA = "0x1874407B0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7440890", Offset = "0x743FC90", VA = "0x187440890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7442CD0", Offset = "0x74420D0", VA = "0x187442CD0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface EBAHLAGOJPM
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPKPHILKIFF(Mesh HLHLPCAMLJN, Matrix4x4 CJBIMFGKJDA, byte[] APMMBEKIAPE, bool GOPMMNFGOBG = false, JEMKHCHMBLO.IFCJAEMECIM NBMAKEKJLBO = (JEMKHCHMBLO.IFCJAEMECIM)0L, int EGLHKMAGHPC = -1, bool CCPPPCLPFOM = false);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JECLJBHJACN(Allocator FALBINAEKDG, HOICEHILGLA GJHKPHJLIFD, byte KDLMKHFIMOE, [Optional] IList<int> FNCPPDHDPLG, [Optional] IList<int> KJKPEENPKLB);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct IOHPJAMOGEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public readonly GameObject MLLMEIAEFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private readonly AvatarItemMaterial HJOOPBCCDKF;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
	public IOHPJAMOGEK(GameObject MLLMEIAEFBA, AvatarItemMaterial HJOOPBCCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7446E90", Offset = "0x7446290", VA = "0x187446E90")]
	public void FHLPIGKCAFI(Material GIEDFKFHBFF, int HJFKPBMKNKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class NHHKCLDKIKH : LMPEBKOJGNB<Task<(GameObject, AvatarItemMaterial)>, IOHPJAMOGEK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct LNHFBOGGJKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7449980", Offset = "0x7448D80", VA = "0x187449980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7449E80", Offset = "0x7449280", VA = "0x187449E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private JCAOOGBCPCO<GameObject> LGBPHLKGNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private JCAOOGBCPCO<AvatarItemMaterial> KPPKKECBJFG;

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x744B4D0", Offset = "0x744A8D0", VA = "0x18744B4D0")]
	private NHHKCLDKIKH(Task<(GameObject, AvatarItemMaterial)> GELALODAJCE, JCAOOGBCPCO<GameObject> LKBGBEEJLLD, JCAOOGBCPCO<AvatarItemMaterial> PPIBAAKHKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x744AE70", Offset = "0x744A270", VA = "0x18744AE70")]
	public static NHHKCLDKIKH GEEFBNOOFMP(AssetReference JDHDKPLPOHL, [Optional] AssetReference CMCBMPLPHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x744B300", Offset = "0x744A700", VA = "0x18744B300", Slot = "11")]
	protected override IOHPJAMOGEK KFLHCAMCJBL(Task<(GameObject, AvatarItemMaterial)> FHPAHMEAHON)
	{
		return default(IOHPJAMOGEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x744B280", Offset = "0x744A680", VA = "0x18744B280", Slot = "12")]
	protected override void GOMHKNFIAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x744B3A0", Offset = "0x744A7A0", VA = "0x18744B3A0")]
	[AsyncStateMachine(typeof(LNHFBOGGJKG))]
	private static Task<(GameObject, AvatarItemMaterial)> LOOFKHAAANP(Task<GameObject> EEOOAGCEALO, Task<AvatarItemMaterial> KAJPNGPFEME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PCEDLMHCGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class PJIGMHAIHIK : LMPEBKOJGNB<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private JCAOOGBCPCO<MaterialMapAsset> ODHBLOGMAPO;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x744EBB0", Offset = "0x744DFB0", VA = "0x18744EBB0")]
		public PJIGMHAIHIK(JCAOOGBCPCO<MaterialMapAsset> ODHBLOGMAPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x744E790", Offset = "0x744DB90", VA = "0x18744E790", Slot = "11")]
		protected override Material[] KFLHCAMCJBL(Task<MaterialMapAsset> GELALODAJCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x744E730", Offset = "0x744DB30", VA = "0x18744E730", Slot = "12")]
		protected override void GOMHKNFIAAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class NLGGIFHECNF : LMPEBKOJGNB<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private List<JCAOOGBCPCO<Material>> OHJJNNCOGMN;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x744B6F0", Offset = "0x744AAF0", VA = "0x18744B6F0")]
		public NLGGIFHECNF(Task<Material[]> GELALODAJCE, List<JCAOOGBCPCO<Material>> OHJJNNCOGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x744B6A0", Offset = "0x744AAA0", VA = "0x18744B6A0", Slot = "11")]
		protected override Material[] KFLHCAMCJBL(Task<Material[]> FHPAHMEAHON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x744B560", Offset = "0x744A960", VA = "0x18744B560", Slot = "12")]
		protected override void GOMHKNFIAAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x744D3F0", Offset = "0x744C7F0", VA = "0x18744D3F0")]
	public static JCAOOGBCPCO<Material[]> NHDPBJJOFPN(AssetReference[] BMFCFCKJNLO)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum LAAPEEPPAGG
		{
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum LPEOPFPFNPM
		{
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum FGPIAFCECMF : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct FABILHIAGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public readonly Material AAJNLIMEBFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public readonly LAAPEEPPAGG AKGMAMBHJPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public readonly LPEOPFPFNPM HPNAMLNLOIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public readonly FGFOFKPBCAF ADKLHBIHDNA;

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x744BB80", Offset = "0x744AF80", VA = "0x18744BB80")]
			public FABILHIAGEK(Material GIEDFKFHBFF, LAAPEEPPAGG LCDDGKHBODE, LPEOPFPFNPM LGEFBLDNOIB, FGFOFKPBCAF CBBFCGBIHBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x74607C0", Offset = "0x745FBC0", VA = "0x1874607C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x744B840", Offset = "0x744AC40", VA = "0x18744B840")]
			public bool HMBOCEMAMKA(FABILHIAGEK MNALNBMKJLK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x7460640", Offset = "0x745FA40", VA = "0x187460640", Slot = "0")]
			public override bool Equals(object NBAMGPFDMIB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x7460720", Offset = "0x745FB20", VA = "0x187460720", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct FABBEKEEFFL : IComparable<FABBEKEEFFL>, IEquatable<FABBEKEEFFL>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public int ALEKAGPOKNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public PlayerAvatarDisplayBase CMLLJBLPAFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public IList<IEOIGDKBNNB> BNIMFDJCBJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public AvatarItemBodyType FHGLBAHMBDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public FOJIEICEIIC BHJBIFMMAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public bool IAFJBCAMCOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public int[] ADAGNFIGKFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public float IEIHBJDNLAN;

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x74604F0", Offset = "0x745F8F0", VA = "0x1874604F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7460390", Offset = "0x745F790", VA = "0x187460390", Slot = "4")]
			public int CompareTo(FABBEKEEFFL MNALNBMKJLK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x74603B0", Offset = "0x745F7B0", VA = "0x1874603B0", Slot = "5")]
			public bool Equals(FABBEKEEFFL MNALNBMKJLK)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class ADDLNMLFHMK
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class KGELDHJICFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000357")]
				public readonly Mesh MOPHOAEDCKD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public readonly Material[] LIAEKGIDOMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000359")]
				public readonly Transform[] KPNPOEEOFFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400035A")]
				public readonly Matrix4x4[] HDPCBMEIODG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400035B")]
				public readonly Transform EECFJBHEHDL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400035C")]
				public readonly bool ABLIGNKOLGO;

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
				protected KGELDHJICFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x7463540", Offset = "0x7462940", VA = "0x187463540")]
				public KGELDHJICFP(Mesh HLHLPCAMLJN, Material[] HNJFBBAICDM, bool CCGKLCEBBGK, Transform[] LKGFMADIEBG, Transform IDMMKBOABNA, Matrix4x4[] GDEAIDCAINO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0x7463AE0", Offset = "0x7462EE0", VA = "0x187463AE0")]
				private KGELDHJICFP(SkinnedMeshRenderer AKKIOLPGAEI, Material[] KGONHFGLNJE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x74639F0", Offset = "0x7462DF0", VA = "0x1874639F0")]
				private KGELDHJICFP(MeshRenderer AKKJIAALAKN, Transform IDMMKBOABNA, Material[] KGONHFGLNJE)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0x7463210", Offset = "0x7462610", VA = "0x187463210")]
				public static KGELDHJICFP BEHBHCNKOLB(Renderer CJJNPFGBHFH, Material[] KGONHFGLNJE)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public readonly FGFOFKPBCAF ADKLHBIHDNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public readonly Transform KGFPCPFDPOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public readonly bool JDAJKFHGEMC;

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual bool NFLEMECECMF
			{
				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual bool NLFNEKMFNCD
			{
				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual JEMKHCHMBLO.IFCJAEMECIM ODMEBKLIPNB
			{
				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "6")]
				get
				{
					return default(JEMKHCHMBLO.IFCJAEMECIM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public bool IJPAHMDIIMG
			{
				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x745FA50", Offset = "0x745EE50", VA = "0x18745FA50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x745FA60", Offset = "0x745EE60", VA = "0x18745FA60")]
			protected ADDLNMLFHMK(FGFOFKPBCAF CBBFCGBIHBA, Transform PILAGBBHNCB, bool IIPCDIOFIAD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract OCLDKMPDLBK DFBNBKEGOMN(List<OOEAEINEKGH> AKJDHLAOJOP, List<OOEAEINEKGH> FIHAAEHJJFO);

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract KGELDHJICFP PNENNOKJENN(int AKKLJPLLNIC, PlayerHandBones HIKGEKHHCPM);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class HGDHMIHFKJI : ADDLNMLFHMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			protected readonly BodyPartLODs ECAIOGPPGCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			protected readonly Material[] MAABFFJPDAK;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7461E80", Offset = "0x7461280", VA = "0x187461E80")]
			public HGDHMIHFKJI(FGFOFKPBCAF CBBFCGBIHBA, BodyPartLODs EAKJJIFEEHD, Material LGDDLMEIDEM, [Optional] Transform PILAGBBHNCB, bool IIPCDIOFIAD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x7461BC0", Offset = "0x7460FC0", VA = "0x187461BC0", Slot = "7")]
			public override OCLDKMPDLBK DFBNBKEGOMN(List<OOEAEINEKGH> AKJDHLAOJOP, List<OOEAEINEKGH> FIHAAEHJJFO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x7461C50", Offset = "0x7461050", VA = "0x187461C50", Slot = "8")]
			public override KGELDHJICFP PNENNOKJENN(int AKKLJPLLNIC, PlayerHandBones HIKGEKHHCPM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x7461E10", Offset = "0x7461210", VA = "0x187461E10", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class GLFCIGENFFD : ADDLNMLFHMK
		{
			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public override bool NFLEMECECMF
			{
				[Cpp2IlInjected.Token(Token = "0x60002F2")]
				[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public override bool NLFNEKMFNCD
			{
				[Cpp2IlInjected.Token(Token = "0x60002F3")]
				[Cpp2IlInjected.Address(RVA = "0x7460C90", Offset = "0x7460090", VA = "0x187460C90", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public BNAPMJHDJHM KJMHPDOHPAG
			{
				[Cpp2IlInjected.Token(Token = "0x60002F4")]
				[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x7460DE0", Offset = "0x74601E0", VA = "0x187460DE0")]
			public GLFCIGENFFD(FGFOFKPBCAF CBBFCGBIHBA, Transform PILAGBBHNCB, BNAPMJHDJHM ODAOKEOLGCK, bool IIPCDIOFIAD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x7460CE0", Offset = "0x74600E0", VA = "0x187460CE0", Slot = "7")]
			public override OCLDKMPDLBK DFBNBKEGOMN(List<OOEAEINEKGH> AKJDHLAOJOP, List<OOEAEINEKGH> FIHAAEHJJFO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "8")]
			public override KGELDHJICFP PNENNOKJENN(int AKKLJPLLNIC, PlayerHandBones HIKGEKHHCPM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7460D70", Offset = "0x7460170", VA = "0x187460D70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class NBNDBDFOMAA
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum ANICLFFAOLM
			{
				[Cpp2IlInjected.Token(Token = "0x4000370")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000371")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000373")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public static readonly int OBLLKDJENEO;

			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public static readonly int PDBMJPOJELA;

			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public static readonly int BJODDFHIALL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			protected readonly PMBKDIGAKIN PPBJGEKMDDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			protected readonly AAPEMHKIMMD LNAFJELAEGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			protected readonly Animator FDOGPBCNLKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly Transform FJPJAGLCACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Vector3 OGALHKDBFLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			protected readonly Transform GFHGJBPFCPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			protected readonly Vector3 MKPIOKGDICD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			protected bool BDEPPDGGANA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			protected MBDCKCDIJDA MELBDCGLHPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected bool JKAGFAMBEKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected float ILFBEBKCJBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected ILMOGPFFNGM<EFMOGLDOMFL> NNJEKNPCOAI;

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public MBDCKCDIJDA CEBPBBKLGPJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x9642C0", Offset = "0x9636C0", VA = "0x1809642C0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x9642E0", Offset = "0x9636E0", VA = "0x1809642E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool CKKKKGNILIF
			{
				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0xAFAB30", Offset = "0xAF9F30", VA = "0x180AFAB30")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x7464B80", Offset = "0x7463F80", VA = "0x187464B80")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public bool HBOLCAJFPBN
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x96E0B0", Offset = "0x96D4B0", VA = "0x18096E0B0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x7464AB0", Offset = "0x7463EB0", VA = "0x187464AB0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public float FOJOBMLLJBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0xB8D090", Offset = "0xB8C490", VA = "0x180B8D090")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x7464070", Offset = "0x7463470", VA = "0x187464070")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public EFMOGLDOMFL DAPHLAKAOPJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0x74644D0", Offset = "0x74638D0", VA = "0x1874644D0")]
				get
				{
					return default(EFMOGLDOMFL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7464510", Offset = "0x7463910", VA = "0x187464510")]
			public bool ENHBJGDNFMA(EFMOGLDOMFL MGIFACCLIPH, object OCDOGNMJENC, ANICLFFAOLM LDKOMOHFHLM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x74649B0", Offset = "0x7463DB0", VA = "0x1874649B0")]
			public bool OKBKPEEBAJD(object OCDOGNMJENC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x7464CF0", Offset = "0x74640F0", VA = "0x187464CF0")]
			protected NBNDBDFOMAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x7464D80", Offset = "0x7464180", VA = "0x187464D80")]
			public NBNDBDFOMAA(PMBKDIGAKIN PPBJGEKMDDD, MBDCKCDIJDA HCEJOBEKGFD, Animator FDOGPBCNLKM, Transform FJPJAGLCACF, Transform GFHGJBPFCPN, Vector3 OGALHKDBFLL, Vector3 MKPIOKGDICD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x74643D0", Offset = "0x74637D0", VA = "0x1874643D0")]
			private void DCPDPHLFAFN(ushort KFDDDKALDOD, ushort GALFKIEONDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x7464740", Offset = "0x7463B40", VA = "0x187464740")]
			protected void GDIMFHHFLDK(ushort KFDDDKALDOD, ushort GALFKIEONDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x74641B0", Offset = "0x74635B0", VA = "0x1874641B0")]
			protected void AHPCOFNBNKE(ushort KFDDDKALDOD, ushort GALFKIEONDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7464830", Offset = "0x7463C30", VA = "0x187464830")]
			protected void MKNALEOPDAC(ushort KFDDDKALDOD, ushort GALFKIEONDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7464270", Offset = "0x7463670", VA = "0x187464270")]
			protected void APPHHIKGNJF(ushort KFDDDKALDOD, ushort GALFKIEONDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7464950", Offset = "0x7463D50", VA = "0x187464950")]
			protected void OIDMOICBPBE(ushort KFDDDKALDOD, ushort GALFKIEONDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7464380", Offset = "0x7463780", VA = "0x187464380")]
			protected void BJBIDMKJCII(ushort KFDDDKALDOD, ushort GALFKIEONDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7464480", Offset = "0x7463880", VA = "0x187464480")]
			protected void DHCPHGGIGOL(ushort KFDDDKALDOD, ushort GALFKIEONDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7464620", Offset = "0x7463A20", VA = "0x187464620")]
			protected void GCODJGMKNAH(ushort KFDDDKALDOD, ushort GALFKIEONDM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class ACLIDNDADAP : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public const int FDKLIIDHMIF = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected MaterialPropertyBlock EMEBPCKIHII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public Color? CPHGMAOMDDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Color? IGOCHOIDINI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public Color? BECGDMEGCHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Color NCAJMMPKOIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public Color OFOAGNCLMIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public Color NLHAMNPDCLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public Texture2D JEJHBDLMFLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public Texture2D IGJEJAECEHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected Dictionary<FABILHIAGEK, int> ABPLDJNMAFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected LAAPEEPPAGG[] KJPHLCGNNDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Vector4[] OBKKPDIEJJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Vector4[] NLFIDCBCHDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Vector4[] GIOADBLAJFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Vector4[] KEPMIPDGFHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Vector4[] JKONBBKCMOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Vector4[] IKIOGFGMFDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected List<Texture2D> BADDEACDDGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Vector4[] KPNDOCHKBGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected List<Texture2D> ICPLDCHLKOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected float[] JEPKPKEBNOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected Vector4[] HJNNLGOIMON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected float[] EAAMJHBBAID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public float[] PGKEIJEJHGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected List<Texture2D> NPKNJLDIHOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			protected float[] BFHNIGHFFLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> CFKGJKIIBOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] GBBBDDHEIOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected float[] IOEOLGKIGIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected Vector4[] EOKMBOFELOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public float[] FPFLGKMLDAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Texture2DArray KKOEAPEEAIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Texture2DArray FBJDIDLAMFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Texture2DArray DIKKMCKMKOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Texture2DArray AHOBJNEEECB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected bool HGDMPIEMBIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected int NFEDHFCBNJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected Vector2? MDHLLEDHLEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected TextureFormat JBNIIHBIHMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected Vector2? IFLBPCNFFKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected TextureFormat CFIACFCAECA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected Vector2? IILPNKNBDNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected TextureFormat KOFLIAIKMOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected Vector2? BLIEEECKDJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected TextureFormat HNLJEFNMLGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected bool JBOKBJOADDP;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected static int PJHOHGPGHAG;

			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected static int FJJNCJIBLIK;

			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected static int FPIPPCJCAIG;

			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected static int HKLGCKMDPFE;

			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected static int MBILKBAFKGB;

			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected static int BPDKAJCMACI;

			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected static int IFMDIMCDAOA;

			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected static int GGEEENEHIPA;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected static int KCBODELPHJG;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int OIEJCEFFCNL;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int JGMLGAIAOJP;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int BLKLJLEALKD;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int EFONFMAGKLG;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int DFLJGDDLGBH;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int NHNKKEHILCH;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int CDFIBGNPJCE;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int CJEEDPGFCJH;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int DCFPOMOLOFA;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int FKPKMCAMBIO;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int DJEEGAAADEG;

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x745F590", Offset = "0x745E990", VA = "0x18745F590")]
			protected ACLIDNDADAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x745F500", Offset = "0x745E900", VA = "0x18745F500")]
			public ACLIDNDADAP(Color JLGJDBKIIPE, Color LOMINNKLFIF, Color NGGIHNCPJAF, Color? JDMJAFAMPGP, Color? JJNMPIILLMJ, Color? GGNPFJNCHNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x745D400", Offset = "0x745C800", VA = "0x18745D400")]
			public int HAAJAINEDGO(Material COGLOKJGGNE, LAAPEEPPAGG LCDDGKHBODE, LPEOPFPFNPM LGEFBLDNOIB, FGFOFKPBCAF CBBFCGBIHBA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x745D4F0", Offset = "0x745C8F0", VA = "0x18745D4F0")]
			public int HAAJAINEDGO(FABILHIAGEK MCNLCGLNHHO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x745E4C0", Offset = "0x745D8C0", VA = "0x18745E4C0")]
			public int PAMKHPKCMIJ(Material COGLOKJGGNE, Color LILHMHLMJHJ, Color IDINJOGOKPO, Color KCBGFDFFGHK, Color LHJKPNILPMP, Color EAGKGNCBDNC, Texture2D BOCHOPNJLDB, Vector4 OAHFKOIKHGA, Texture2D HKIFOJBNLBE, Vector4 LPJOPMMGFIH, float MDJHOGMCKCJ, float KOJNHJMCNNE, Texture2D LJIJLENDBKA, Vector4 GGNFPLBCCBP, float ACOBLGMFOKN, Texture2D JCNEHJDDBEA, float BIHANJJMJHK, Color EOPJFHKGKON, Vector4 BLOADCDACHP, LAAPEEPPAGG LCDDGKHBODE, LPEOPFPFNPM LGEFBLDNOIB, FGFOFKPBCAF CBBFCGBIHBA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x745D200", Offset = "0x745C600", VA = "0x18745D200")]
			protected void DCBHEGGBAFB([Out] Texture2DArray DIGCPGCBOIO, [Out] Texture2DArray NGMIHJDKHJB, [Out] Texture2DArray JOIHPAKGGKH, [Out] Texture2DArray EGDEFJGCAIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x745D580", Offset = "0x745C980", VA = "0x18745D580")]
			public void IKEPGMHPJMJ(PlayerAvatarDisplayBase MJELLHIKLJE, Renderer CJJNPFGBHFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x745D9D0", Offset = "0x745CDD0", VA = "0x18745D9D0")]
			protected void NKOHEDDDLAJ(PlayerAvatarDisplayBase MJELLHIKLJE, Renderer CJJNPFGBHFH, int JFDBFBFBEOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x745D7E0", Offset = "0x745CBE0", VA = "0x18745D7E0")]
			private Color JBDIEGDGJEG(Color HLMFDMBPHLE, LAAPEEPPAGG DKOKEINPBND)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x745D0B0", Offset = "0x745C4B0", VA = "0x18745D0B0")]
			private Color BNMFDKLAAKP(Color GCFODIPMKGO, LAAPEEPPAGG DKOKEINPBND)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x745D020", Offset = "0x745C420", VA = "0x18745D020")]
			protected void ANOODEMMHBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x745D3C0", Offset = "0x745C7C0", VA = "0x18745D3C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x746BBF0", Offset = "0x746AFF0", VA = "0x18746BBF0")]
			public void EJANJCJPDOO(FGFOFKPBCAF CBBFCGBIHBA, [Out] Transform HAIKBOLEOOP, [Out] Transform[] LKGFMADIEBG)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class MFMLAEOJDDO : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600032A")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
			[DebuggerHidden]
			public MFMLAEOJDDO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7463DA0", Offset = "0x74631A0", VA = "0x187463DA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7464020", Offset = "0x7463420", VA = "0x187464020", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7463F70", Offset = "0x7463370", VA = "0x187463F70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7463F70", Offset = "0x7463370", VA = "0x187463F70", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class PEDKFHJHKMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public PEDKFHJHKMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7465CE0", Offset = "0x74650E0", VA = "0x187465CE0")]
			internal bool PODBLBBDPCL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class HOIPFAAMLIM : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private MOLDBMJPKNN <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000334")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public HOIPFAAMLIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7461F80", Offset = "0x7461380", VA = "0x187461F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7462350", Offset = "0x7461750", VA = "0x187462350", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct EOALOLEIHPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public GKDBEGOBGHP avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x745FB70", Offset = "0x745EF70", VA = "0x18745FB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7460330", Offset = "0x745F730", VA = "0x187460330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class NHFKECLFBKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public NHFKECLFBKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7465370", Offset = "0x7464770", VA = "0x187465370")]
			internal bool LPAJCJCFOPO(IEOIGDKBNNB selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class FKCNPJGIFCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Func<HHPFDJMLPAL<Dictionary<string, JCAOOGBCPCO<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public FKCNPJGIFCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7460A90", Offset = "0x745FE90", VA = "0x187460A90")]
			internal (NFJKMPPPDKA, HHPFDJMLPAL<Dictionary<string, JCAOOGBCPCO<Texture2D>>>) MMBEAHOCOEM(Dictionary<string, PFLMFICBCEJ> avatarItems)
			{
				return default((NFJKMPPPDKA, HHPFDJMLPAL<Dictionary<string, JCAOOGBCPCO<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x74609E0", Offset = "0x745FDE0", VA = "0x1874609E0")]
			internal HHPFDJMLPAL<Dictionary<string, JCAOOGBCPCO<Texture2D>>> DFGCGLHFHHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x7460A50", Offset = "0x745FE50", VA = "0x187460A50")]
			internal void GKMLHFGAEJN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class EHFFFHHCBKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public EHFFFHHCBKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x745FAC0", Offset = "0x745EEC0", VA = "0x18745FAC0")]
			internal bool INGNFPKLNAH(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct KAKDBEJKNCI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x7462FE0", Offset = "0x74623E0", VA = "0x187462FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x74631B0", Offset = "0x74625B0", VA = "0x1874631B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		protected static readonly int GPFCKEFOJMK;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		protected static readonly int FCAOACLJEMM;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		protected static readonly int BDLMGGLODNA;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		protected static readonly int OCJPNOGGHML;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected static readonly int HNNCLHAPEDM;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected static readonly int AENGMKNDNCO;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected static readonly int[] DDMEDDMLOEP;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int[] APGPDBJHIAL;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int[] LKAMCKCLBPH;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int[] HIEDMDJFLCO;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int[] LCCPIBLEKIO;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int[] PDNMLFEFAEG;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static List<PlayerAvatarDisplayBase> MKGOALBAIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected JKJEECCDFGN AOEPDAMOKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected bool FHGJDENMMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected bool AMHNIFJFKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected static readonly int[] OPJEENDKBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected Dictionary<FABILHIAGEK, Material> LCAOIGLGICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected Dictionary<FABILHIAGEK, Material> HKNBIMDPKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected Material OKJHCEODLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected NHBJOEBCOCP POLNJCMKMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private MBDCKCDIJDA GBOPGCJIHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private MBDCKCDIJDA AAKHNKNNOAP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected Material OPKGEFMIBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected FitMeshHemisphere MLIDJAPHMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected bool PCGGDBCBPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected CFIMFIIKPEO JDOBNCOLDLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		protected bool GJKACFCDJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected AnchorParamsRestrictions DBHNBCEFIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected bool AHIBNNFFCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected Transform KDIGEGOMEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected bool CGJALCHANLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A1")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected bool GCGFAIABFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected Vector3 AJCAEIOACOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected Quaternion JOLPLNDCAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected Vector2 FHKKNCBLJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected FitMeshHemisphere MNCPJLBDEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[IGKHBFEOLOG(MFMOBKOPAIF.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Collider[] EJEFACJOFIP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected Collider[] LFOEPPDIKGC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected NBNDBDFOMAA[] PPIAECIOGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public Dictionary<Renderer, ACLIDNDADAP> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected Dictionary<Renderer, ACLIDNDADAP> DFCOGJBJCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected OJONGFGIIBH HJAFBAJPFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected NFJKMPPPDKA PGMODECHAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public BJOOMCLMBJJ DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected int EBIGGNIJJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected (bool isLodForced, int forcedLOD) KHLOOBCHFCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected ILMOGPFFNGM<AAPEMHKIMMD> NNJEKNPCOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected bool AIKIALNINPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Dictionary<IEOIGDKBNNB, List<FABILHIAGEK>> CEDDFNEMGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected Dictionary<IEOIGDKBNNB, List<FABILHIAGEK>> MHDLPIOMALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected readonly Dictionary<string, JCAOOGBCPCO<Texture2D>> FNDFIFOBAHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected readonly Dictionary<string, JCAOOGBCPCO<Texture2D>> MPKLEBHFDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected bool NEEBGGCDNHA;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected static int DIBLDDPJIFA;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected static List<FABBEKEEFFL> JGFNPLLPNGG;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected static List<FABBEKEEFFL> OMCFICPILBL;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected static DCOKPPOHOJG CNJJHCCCIGJ;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected static bool EFGEJMPAKIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected Color? HIOCLKELOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected bool JNFMLGHKJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected Color MCNLLJEFGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected Color ACEJAOPFEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected Color DOOCMDNCHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected AvatarHairPattern KHLMOJBDAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected BNAPMJHDJHM NAAOOJEBBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected Color LIFGGICGACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected Color ADOHDOMFEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected AvatarHairPattern ICIOJKOMDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected BNAPMJHDJHM FMGLDJBKJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected BNAPMJHDJHM ECOKFAPDAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Color EBAILHHNHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private AdditionalFeetData CNEAFEAANGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected IEOIGDKBNNB? GBMGAGJJAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Texture EIPMFJMBDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Color BOCHNFMMABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected readonly IList<IEOIGDKBNNB> LDPGCKKKBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected readonly IList<IEOIGDKBNNB> EELINBCLHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private AvatarItemBodyType PBNJPMMBMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		[SerializeField]
		protected HDEGHEIKKJI _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C5")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected FGPIAFCECMF JLLEADJPBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected int[] BGIDJAGJOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected bool GGFMAHKPOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected int[] OMOLFPPDCBF;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private static readonly JEMKHCHMBLO.IFCJAEMECIM AONNAJAFHOG;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private static readonly JEMKHCHMBLO.IFCJAEMECIM HJGJOIFBJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected bool HAIHEEPJDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected AIJALJOGGJG JFPABFJFIJD;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string HEGJENDAGPL
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GHODFIGIDFF
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xB07F00", Offset = "0xB07300", VA = "0x180B07F00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xB54B50", Offset = "0xB53F50", VA = "0x180B54B50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual bool IPGFMNCDBOO
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool FADMFPJFIMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x745BB80", Offset = "0x745AF80", VA = "0x18745BB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool HDANPDDGBHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool DMHOLHMMKOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool EABGPPJIGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public NHBJOEBCOCP PCMLFCKLPDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x9F9DD0", Offset = "0x9F91D0", VA = "0x1809F9DD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x745C1F0", Offset = "0x745B5F0", VA = "0x18745C1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public MBDCKCDIJDA GANCCIOCOGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC90", Offset = "0x9DB090", VA = "0x1809DBC90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x745C5F0", Offset = "0x745B9F0", VA = "0x18745C5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public MBDCKCDIJDA MPBFMGGKGHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9D9C10", Offset = "0x9D9010", VA = "0x1809D9C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x745C8C0", Offset = "0x745BCC0", VA = "0x18745C8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected Material JCHFNBINGOE
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7452750", Offset = "0x7451B50", VA = "0x187452750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected Material GECMFADHLIK
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7452D20", Offset = "0x7452120", VA = "0x187452D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool ABFGJJBFMKN
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x9E22D0", Offset = "0x9E16D0", VA = "0x1809E22D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public PlayerFacialAnimatorBase HFMOEKHDBMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x9E1BE0", Offset = "0x9E0FE0", VA = "0x1809E1BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public NBNDBDFOMAA[] ONBCADCCOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x745B750", Offset = "0x745AB50", VA = "0x18745B750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public NBNDBDFOMAA PDMCJNIDDAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x745BD70", Offset = "0x745B170", VA = "0x18745BD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public NBNDBDFOMAA PLADDEEJLJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x745BDA0", Offset = "0x745B1A0", VA = "0x18745BDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Mesh DHEIDDCICNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xCD5C00", Offset = "0xCD5000", VA = "0x180CD5C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		protected OJONGFGIIBH DLBAHEGEKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7457710", Offset = "0x7456B10", VA = "0x187457710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		protected NFJKMPPPDKA NOMIDKFOLJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1055C00", Offset = "0x1055000", VA = "0x181055C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x744EEB0", Offset = "0x744E2B0", VA = "0x18744EEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected bool AHBEMLNMCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool GDABNICBNIL
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x745BD60", Offset = "0x745B160", VA = "0x18745BD60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public int NDHAPKOPBKD
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1055250", Offset = "0x1054650", VA = "0x181055250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x745C800", Offset = "0x745BC00", VA = "0x18745C800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public int PDGDPIPJFPD
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x745C540", Offset = "0x745B940", VA = "0x18745C540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected virtual bool NDNPNDALAKH
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected virtual int[] IDHDFNLBDBG
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x7456D30", Offset = "0x7456130", VA = "0x187456D30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected bool CALIOGEHKNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x74575D0", Offset = "0x74569D0", VA = "0x1874575D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected static bool KMNNGAHOPDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool JMGMBJHDIEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1054FF0", Offset = "0x10543F0", VA = "0x181054FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x745CAD0", Offset = "0x745BED0", VA = "0x18745CAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IEnumerable<SkinnedMeshRenderer> MJOPGMBIFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x745B620", Offset = "0x745AA20", VA = "0x18745B620")]
			[IteratorStateMachine(typeof(MFMLAEOJDDO))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool GJIAKANDJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1055340", Offset = "0x1054740", VA = "0x181055340")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1055170", Offset = "0x1054570", VA = "0x181055170")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public DIINEKIAPFE EIEEEPIDOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x745B6A0", Offset = "0x745AAA0", VA = "0x18745B6A0")]
			get
			{
				return default(DIINEKIAPFE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public static bool LGLIDFMOALF
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x745BAF0", Offset = "0x745AEF0", VA = "0x18745BAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		protected static DCOKPPOHOJG ELBNOMHHPHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x7454740", Offset = "0x7453B40", VA = "0x187454740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x744EF50", Offset = "0x744E350", VA = "0x18744EF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Color IGOCHOIDINI
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x74524D0", Offset = "0x74518D0", VA = "0x1874524D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected Color BECGDMEGCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x7456CE0", Offset = "0x74560E0", VA = "0x187456CE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Texture2D GHIAOGCBFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x7454FA0", Offset = "0x74543A0", VA = "0x187454FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color NCAJMMPKOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x7456300", Offset = "0x7455700", VA = "0x187456300")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Color OFOAGNCLMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7455A50", Offset = "0x7454E50", VA = "0x187455A50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public BNAPMJHDJHM CBECFMHNHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x745B710", Offset = "0x745AB10", VA = "0x18745B710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Texture2D AIODNAOLLGF
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x7455AA0", Offset = "0x7454EA0", VA = "0x187455AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public float NMKJDADELGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x745B730", Offset = "0x745AB30", VA = "0x18745B730")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public float FJDKPAMANMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x745BB60", Offset = "0x745AF60", VA = "0x18745BB60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool EICIKLBNDOF
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x745B700", Offset = "0x745AB00", VA = "0x18745B700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x745BFD0", Offset = "0x745B3D0", VA = "0x18745BFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AGIMFEPEJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x745B4C0", Offset = "0x745A8C0", VA = "0x18745B4C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x745BE70", Offset = "0x745B270", VA = "0x18745BE70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action PKGMAIPENCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x745B420", Offset = "0x745A820", VA = "0x18745B420")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x745BDD0", Offset = "0x745B1D0", VA = "0x18745BDD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PMBKDIGAKIN, EFMOGLDOMFL> OIJIPGDFGGM
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x745B560", Offset = "0x745A960", VA = "0x18745B560")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x745BF10", Offset = "0x745B310", VA = "0x18745BF10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7458350", Offset = "0x7457750", VA = "0x187458350")]
		public bool SetDeformation(bool FHGJDENMMFP, bool AMHNIFJFKDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7453270", Offset = "0x7452670", VA = "0x187453270")]
		protected static Material FAGCNGPAJIK(Dictionary<FABILHIAGEK, Material> BIOHKMBAOBH, Material DHHMMCCOHKH, LAAPEEPPAGG LCDDGKHBODE, LPEOPFPFNPM LGEFBLDNOIB, FGFOFKPBCAF CBBFCGBIHBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7450B10", Offset = "0x744FF10", VA = "0x187450B10")]
		protected void CPLBCMMBOEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x744FE10", Offset = "0x744F210", VA = "0x18744FE10")]
		protected bool BPGCMNHDEBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x74535E0", Offset = "0x74529E0", VA = "0x1874535E0")]
		protected void FNICMDOJOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7452660", Offset = "0x7451A60", VA = "0x187452660", Slot = "10")]
		protected virtual void DPGEAHJKLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x74560B0", Offset = "0x74554B0", VA = "0x1874560B0")]
		public int MeshesAtLODCount(int ABIKPIDMBAA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7456350", Offset = "0x7455750", VA = "0x187456350")]
		protected static void NHEHNBNCLKJ(Dictionary<IEOIGDKBNNB, List<FABILHIAGEK>> MHJIECJLKAG, ADDLNMLFHMK IDPPNALDCOI, Material DHHMMCCOHKH, LAAPEEPPAGG DKOKEINPBND, LPEOPFPFNPM DNLKJGJDLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x744F9D0", Offset = "0x744EDD0", VA = "0x18744F9D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x74501C0", Offset = "0x744F5C0", VA = "0x1874501C0")]
		protected void CBBDEGCLPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7456FC0", Offset = "0x74563C0", VA = "0x187456FC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "11")]
		protected virtual void IKBBLMFINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7450080", Offset = "0x744F480", VA = "0x187450080")]
		protected static void CBBAJOAHJPL(List<Material> DPGHHLLPEDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7455740", Offset = "0x7454B40", VA = "0x187455740")]
		protected static void MFANJHFKDKJ(Dictionary<FABILHIAGEK, Material> BIOHKMBAOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7453B00", Offset = "0x7452F00", VA = "0x187453B00")]
		protected static void GOFPIENBGJK(Dictionary<Renderer, ACLIDNDADAP> JFFAJOOMDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7453C60", Offset = "0x7453060", VA = "0x187453C60")]
		protected void GPBJFLGCBPF(SkinnedMeshRenderer[] JDDHAEABJGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x744FB80", Offset = "0x744EF80", VA = "0x18744FB80")]
		protected void BLONABKDGON(SkinnedMeshRenderer AKKIOLPGAEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x744FC20", Offset = "0x744F020", VA = "0x18744FC20")]
		protected void BLONABKDGON(MeshRenderer AKKJIAALAKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7457400", Offset = "0x7456800", VA = "0x187457400")]
		protected void PBLBGCHECFJ(List<OOEAEINEKGH> APNNPANHFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7452AF0", Offset = "0x7451EF0", VA = "0x187452AF0")]
		protected void EJJDNNNECKJ(Dictionary<string, JCAOOGBCPCO<Texture2D>> MHJIECJLKAG, bool EFOEKPMBKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7450030", Offset = "0x744F430", VA = "0x187450030")]
		protected void CAMNGNDMLII(Dictionary<IEOIGDKBNNB, List<FABILHIAGEK>> MHJIECJLKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7453D80", Offset = "0x7453180", VA = "0x187453D80")]
		public float GetHandOpenClosedAxis(PMBKDIGAKIN PPBJGEKMDDD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7458BE0", Offset = "0x7457FE0", VA = "0x187458BE0")]
		public void SetHandOpenClosedAxis(PMBKDIGAKIN PPBJGEKMDDD, float PMLJLKBDAEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7453DC0", Offset = "0x74531C0", VA = "0x187453DC0")]
		public EFMOGLDOMFL GetHandVisualState(PMBKDIGAKIN PPBJGEKMDDD)
		{
			return default(EFMOGLDOMFL);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x744F110", Offset = "0x744E510", VA = "0x18744F110")]
		public bool AddHandVisualStateToken(PMBKDIGAKIN PPBJGEKMDDD, EFMOGLDOMFL PPFOEBKOEHP, object OCDOGNMJENC, NBNDBDFOMAA.ANICLFFAOLM LDKOMOHFHLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x745A3B0", Offset = "0x74597B0", VA = "0x18745A3B0")]
		public void SetWatchHand(PMBKDIGAKIN PPBJGEKMDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x745A470", Offset = "0x7459870", VA = "0x18745A470")]
		public void SetWatchHands(bool FHDABAKPBOF, bool FHJJEHJEEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7457A10", Offset = "0x7456E10", VA = "0x187457A10")]
		public bool RemoveHandVisualStateToken(PMBKDIGAKIN PPBJGEKMDDD, object OCDOGNMJENC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7453E40", Offset = "0x7453240", VA = "0x187453E40")]
		public bool GetThumbsUpActive(PMBKDIGAKIN PPBJGEKMDDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7459E60", Offset = "0x7459260", VA = "0x187459E60")]
		public void SetThumbsUpActive(PMBKDIGAKIN PPBJGEKMDDD, bool DIEAMCBLEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7453E00", Offset = "0x7453200", VA = "0x187453E00")]
		public bool GetHandshakeActive(PMBKDIGAKIN PPBJGEKMDDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7458C30", Offset = "0x7458030", VA = "0x187458C30")]
		public void SetHandshakeActive(PMBKDIGAKIN PPBJGEKMDDD, bool ELJPACCCOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7453770", Offset = "0x7452B70", VA = "0x187453770")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7451230", Offset = "0x7450630", VA = "0x187451230")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x74537C0", Offset = "0x7452BC0", VA = "0x1874537C0")]
		protected static void GGBKLHMKJOB(PlayerAvatarDisplayBase OLOAPCMLJOK, List<FABBEKEEFFL> DKNNLCIDLCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7457730", Offset = "0x7456B30", VA = "0x187457730")]
		public void Rebuild(bool JMANEBHBFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x74562B0", Offset = "0x74556B0", VA = "0x1874562B0")]
		protected void NAPOOGKCHLF(bool JMANEBHBFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7456170", Offset = "0x7455570", VA = "0x187456170", Slot = "12")]
		protected virtual OCLDKMPDLBK NAPOOGKCHLF(IList<IEOIGDKBNNB> EHPNMLCPCHA, AvatarItemBodyType HMAFFNHMKLB, bool GLIEMLJKHAM, int[] MEHCCGGOKAF, bool JMANEBHBFCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7455090", Offset = "0x7454490", VA = "0x187455090")]
		protected static OCLDKMPDLBK LHBMCJDFJEC(FABBEKEEFFL BPOMHAMIIIC, List<FABBEKEEFFL> DKNNLCIDLCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x74568A0", Offset = "0x7455CA0", VA = "0x1874568A0")]
		[IteratorStateMachine(typeof(HOIPFAAMLIM))]
		protected static IEnumerator<MOLDBMJPKNN> OFBOIGBDBBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7457650", Offset = "0x7456A50", VA = "0x187457650")]
		protected static FABBEKEEFFL PHMONKBCIFG(List<FABBEKEEFFL> DKNNLCIDLCP)
		{
			return default(FABBEKEEFFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7458450", Offset = "0x7457850", VA = "0x187458450")]
		[AsyncStateMachine(typeof(EOALOLEIHPJ))]
		public Task SetFaceCustomizationSettings(GKDBEGOBGHP BFLCMMHHBLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7454790", Offset = "0x7453B90", VA = "0x187454790")]
		public void InitializeFaceFeatures(AvatarConfiguration FDDIIONJAJJ, DIINEKIAPFE NKOMJFFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7459BC0", Offset = "0x7458FC0", VA = "0x187459BC0")]
		public void SetTeamColors(Color? GGNPFJNCHNB, bool LIHCMOJEEBB, Color KFPNJMNJHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x112A080", Offset = "0x1129480", VA = "0x18112A080")]
		private static void OFHIBGPFMKH(Material GIEDFKFHBFF, Color PEBNJNGMMHE, params int[] MMABOEEHHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x11299D0", Offset = "0x1128DD0", VA = "0x1811299D0")]
		private static void MEDOJEOCBPK(Material GIEDFKFHBFF, Texture PEBNJNGMMHE, params int[] MMABOEEHHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x74505C0", Offset = "0x744F9C0", VA = "0x1874505C0")]
		protected void CNLDBNHJEOL(Material MMCBMDPFDPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x744FCF0", Offset = "0x744F0F0", VA = "0x18744FCF0")]
		protected void BOPEJKKAFKC(Material MMCBMDPFDPO, Color ABPFOOEGHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x744EC90", Offset = "0x744E090", VA = "0x18744EC90")]
		protected void AIAIDHONFAL(Material MMCBMDPFDPO, Color ABPFOOEGHLD, Color ONMINNEAIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7454370", Offset = "0x7453770", VA = "0x187454370")]
		protected void HEBGECFOHPJ(Material MMCBMDPFDPO, Texture2D LEFNCCFPOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7453950", Offset = "0x7452D50", VA = "0x187453950")]
		protected void GHLNEDKADPG(Material MMCBMDPFDPO, Texture IMLKNDLLJAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7452990", Offset = "0x7451D90", VA = "0x187452990")]
		protected void EHNCCGBICJH(Action<ACLIDNDADAP> BCMMBNPMIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7456AA0", Offset = "0x7455EA0", VA = "0x187456AA0")]
		protected void OICBBBGDOKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7454580", Offset = "0x7453980", VA = "0x187454580")]
		protected void HFADEPLMKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7452F10", Offset = "0x7452310", VA = "0x187452F10")]
		protected void EOIOHJIJGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x744F460", Offset = "0x744E860", VA = "0x18744F460")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7457DD0", Offset = "0x74571D0", VA = "0x187457DD0")]
		public void SetBeardPrimaryColor([Optional] Color? FDLFKPFJNNN, bool JJGBBHAGAHG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7457FF0", Offset = "0x74573F0", VA = "0x187457FF0")]
		public void SetBeardSecondaryColor([Optional] Color? FDLFKPFJNNN, bool JJGBBHAGAHG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7457C90", Offset = "0x7457090", VA = "0x187457C90")]
		public void SetBeardPattern([Optional] AvatarHairPattern KLOEEMOKOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7451350", Offset = "0x7450750", VA = "0x187451350")]
		private void DFAJMAFJIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7454C50", Offset = "0x7454050", VA = "0x187454C50")]
		private bool KINFACKBBKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x74587C0", Offset = "0x7457BC0", VA = "0x1874587C0")]
		public void SetHairPrimaryColor([Optional] Color? DMPJPAJBEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x74589D0", Offset = "0x7457DD0", VA = "0x1874589D0")]
		public void SetHairSecondaryColor([Optional] Color? DMPJPAJBEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7458690", Offset = "0x7457A90", VA = "0x187458690")]
		public void SetHairPattern([Optional] AvatarHairPattern KLOEEMOKOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x74578B0", Offset = "0x7456CB0", VA = "0x1874578B0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7454D00", Offset = "0x7454100", VA = "0x187454D00")]
		private bool KNGPLKILDLE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7459A00", Offset = "0x7458E00", VA = "0x187459A00")]
		public void SetSkinColor(Color JLGJDBKIIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7459EB0", Offset = "0x74592B0", VA = "0x187459EB0")]
		public void SetUgcItemVisualOverrides(IEOIGDKBNNB GJDIIEHGAFJ, DIINEKIAPFE NKOMJFFJMEP, Texture EGNFHLCDJEI, Color DCCPCKLKNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7451300", Offset = "0x7450700", VA = "0x187451300")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7458550", Offset = "0x7457950", VA = "0x187458550")]
		public bool SetFaceShape(AvatarFaceShape DDJACKDKDIC, bool HJPCEOBMLOH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7452E10", Offset = "0x7452210", VA = "0x187452E10")]
		private void EOILNKIIMIJ(PCMIOJDPABF CEHFLGNGNNM, float PEBNJNGMMHE, bool DKCKKFNLCEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7457200", Offset = "0x7456600", VA = "0x187457200")]
		private void PAEGAOCHOAH(FBGENMFPENA OLNIHJMBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7458210", Offset = "0x7457610", VA = "0x187458210")]
		public bool SetBodyShape(AvatarBodyShape EBNHCAOCMBF, bool HJPCEOBMLOH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7459890", Offset = "0x7458C90", VA = "0x187459890")]
		public bool SetNoseType(HDEGHEIKKJI MGIHACEIMCH, bool HJPCEOBMLOH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x745A5D0", Offset = "0x74599D0", VA = "0x18745A5D0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7459870", Offset = "0x7458C70", VA = "0x187459870")]
		public bool SetHideEars(bool JKMNFADJDPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7459860", Offset = "0x7458C60", VA = "0x187459860")]
		public bool SetHelmetHair(JKJEECCDFGN MBHOHPMOAEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x74592D0", Offset = "0x74586D0", VA = "0x1874592D0")]
		public void SetHatAnchorParameters(CFIMFIIKPEO PEGLDNMLNAO, bool KIFMMJOLJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x745A540", Offset = "0x7459940", VA = "0x18745A540")]
		public void SetupDisplayLODs(FGPIAFCECMF EGLPKPNNFDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x74558A0", Offset = "0x7454CA0", VA = "0x1874558A0")]
		protected int[] MKCHNKGMJFI(FGPIAFCECMF EGLPKPNNFDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7459980", Offset = "0x7458D80", VA = "0x187459980")]
		public void SetOutfitSelections(IList<IEOIGDKBNNB> EHPNMLCPCHA, AvatarItemBodyType HMAFFNHMKLB, bool JMANEBHBFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x74599C0", Offset = "0x7458DC0", VA = "0x1874599C0")]
		public void SetOutfitSelections(IList<IEOIGDKBNNB> EHPNMLCPCHA, AvatarItemBodyType HMAFFNHMKLB, bool GLIEMLJKHAM, bool JMANEBHBFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7459930", Offset = "0x7458D30", VA = "0x187459930")]
		public OCLDKMPDLBK SetOutfitSelections(IList<IEOIGDKBNNB> EHPNMLCPCHA, AvatarItemBodyType HMAFFNHMKLB, FGPIAFCECMF EGLPKPNNFDL, bool GLIEMLJKHAM, bool HJPCEOBMLOH = false, bool JMANEBHBFCM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7454870", Offset = "0x7453C70", VA = "0x187454870", Slot = "13")]
		protected virtual OCLDKMPDLBK JAHDJFHLHDB(IList<IEOIGDKBNNB> EHPNMLCPCHA, AvatarItemBodyType HMAFFNHMKLB, bool GLIEMLJKHAM, FGPIAFCECMF EGLPKPNNFDL, bool HJPCEOBMLOH, bool JMANEBHBFCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7456670", Offset = "0x7455A70", VA = "0x187456670")]
		protected int[] NKDHIKGEFAK(FGPIAFCECMF EGLPKPNNFDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "14")]
		protected virtual NFJKMPPPDKA DJDKOHGEHKC(AvatarItemBodyType ILBEBBKHOOK, Dictionary<string, PFLMFICBCEJ> EBCIFIHLICM, Dictionary<string, JCAOOGBCPCO<Texture2D>> NEHNMJDNHOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7450840", Offset = "0x744FC40", VA = "0x187450840", Slot = "15")]
		protected virtual OCLDKMPDLBK COEANANCBGG(IList<IEOIGDKBNNB> EHPNMLCPCHA, AvatarItemBodyType HMAFFNHMKLB, bool GLIEMLJKHAM, int[] ADAGNFIGKFB, FOJIEICEIIC BBHNIBNFEGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7453E80", Offset = "0x7453280", VA = "0x187453E80", Slot = "16")]
		protected virtual PFLMFICBCEJ HBJIIADLOIN(BNAPMJHDJHM ODAOKEOLGCK, AvatarItemBodyType ILBEBBKHOOK, FGFOFKPBCAF CBBFCGBIHBA, PFLMFICBCEJ KLPFDIMCDAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "17")]
		protected virtual PFLMFICBCEJ MDLDMJGJPCL(AvatarItemBodyType ILBEBBKHOOK, FGFOFKPBCAF CBBFCGBIHBA, LHBDPPOGLJN GDFLHALIOAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7450540", Offset = "0x744F940", VA = "0x187450540")]
		protected void CFPHOGNHOFM(IAKNPHOHNEA IMPKOBAFOLA, JEMKHCHMBLO.IFCJAEMECIM OBCJCJLLOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x74538D0", Offset = "0x7452CD0", VA = "0x1874538D0")]
		protected void GHEGEAMCMNI(IAKNPHOHNEA IMPKOBAFOLA, JEMKHCHMBLO.IFCJAEMECIM OBCJCJLLOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xD03D20", Offset = "0xD03120", VA = "0x180D03D20", Slot = "18")]
		protected virtual IAKNPHOHNEA NCNJCCLMHGF(IAKNPHOHNEA IMPKOBAFOLA, HelmetHairStyle CGAINLPPFDD, bool MJNBDDJCMPI, AvatarItemBodyType HMAFFNHMKLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x74514C0", Offset = "0x74508C0", VA = "0x1874514C0")]
		protected IAKNPHOHNEA DIMEHEGENAE(IList<IEOIGDKBNNB> EHPNMLCPCHA, AvatarItemBodyType DFEMOOLAFNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7451110", Offset = "0x7450510", VA = "0x187451110")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7452C70", Offset = "0x7452070", VA = "0x187452C70")]
		protected void ELAJOBANPBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7455C30", Offset = "0x7455030", VA = "0x187455C30")]
		protected void MOCEGPIOPLF(Transform AGNNCBEMHLA, IEnumerable<SkinnedMeshRenderer> HDHAIMIIDOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x74567E0", Offset = "0x7455BE0", VA = "0x1874567E0")]
		protected JEMKHCHMBLO.IFCJAEMECIM OALAMBFKPMP(JEMKHCHMBLO.IFCJAEMECIM GJHJAHHLEGA, FGFOFKPBCAF CNAGADBDHAP)
		{
			return default(JEMKHCHMBLO.IFCJAEMECIM);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x744FB70", Offset = "0x744EF70", VA = "0x18744FB70")]
		protected void BLELBADPHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1084250", Offset = "0x1083650", VA = "0x181084250")]
		protected void JHGHLNGAHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x74534B0", Offset = "0x74528B0", VA = "0x1874534B0")]
		protected void FIABNDKJLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x74536A0", Offset = "0x7452AA0", VA = "0x1874536A0")]
		[AsyncStateMachine(typeof(KAKDBEJKNCI))]
		protected Task FPEFCKJLGEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7456900", Offset = "0x7455D00", VA = "0x187456900")]
		protected static LAAPEEPPAGG OFLCINDDNML(ADDLNMLFHMK GPMKEFBILDC, int LIHFPNCLECB)
		{
			return default(LAAPEEPPAGG);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7455F60", Offset = "0x7455360", VA = "0x187455F60")]
		protected static LPEOPFPFNPM MODJPCBMBOH(ADDLNMLFHMK GPMKEFBILDC, int LIHFPNCLECB)
		{
			return default(LPEOPFPFNPM);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7453A60", Offset = "0x7452E60", VA = "0x187453A60")]
		protected Transform GNICHHJKCOJ(FGFOFKPBCAF CBBFCGBIHBA, OutfitType IPCKIOFDOOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7456DC0", Offset = "0x74561C0", VA = "0x187456DC0")]
		protected void OPAIBCLOELH(int HJFKPBMKNKH, Material GIEDFKFHBFF, ADDLNMLFHMK GPMKEFBILDC, [Out] Texture2D OKABEIOOKIK, [Out] Vector4 DIGGOCJJBDH, [Out] Texture2D GCKGEFAHPLJ, [Out] Texture2D OGBFAFGNCPH, [Out] Texture2D IIPLEFDPLGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7454DC0", Offset = "0x74541C0", VA = "0x187454DC0")]
		protected void LAOABENDNMM(int HJFKPBMKNKH, Material GIEDFKFHBFF, ADDLNMLFHMK GPMKEFBILDC, [Out] Color LILHMHLMJHJ, [Out] Color IDINJOGOKPO, [Out] Color KCBGFDFFGHK, [Out] Color LHJKPNILPMP, [Out] Color EAGKGNCBDNC, [Out] Color EOPJFHKGKON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7456770", Offset = "0x7455B70", VA = "0x187456770")]
		protected void NOBOHMEGCON(Vector3 LLLAMAJMODF, Quaternion ANFMFACGGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7458C80", Offset = "0x7458080", VA = "0x187458C80")]
		public void SetHatAnchorParameters(CFIMFIIKPEO PEGLDNMLNAO, AnchorParamsRestrictions KDAEGKMIFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7450C30", Offset = "0x7450030", VA = "0x187450C30")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere MLIDJAPHMBA, Transform KDIGEGOMEJN, CFIMFIIKPEO PEGLDNMLNAO, AnchorParamsRestrictions DBHNBCEFIAN, [Out] Vector3 ODMGDEIMGFO, [Out] Quaternion NNFHCIFKIPA, [Out] CFIMFIIKPEO JCPOBKCEDBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7457B20", Offset = "0x7456F20", VA = "0x187457B20")]
		public void ResetHatAnchor(Vector2 ACPMCDEOPDG, Vector3 FKNJHOMMHBO, Vector3 IOONKEHABOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9FC050", Offset = "0x9FB450", VA = "0x1809FC050")]
		public FNKFCOOECIK GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x744F290", Offset = "0x744E690", VA = "0x18744F290")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x744F3D0", Offset = "0x744E7D0", VA = "0x18744F3D0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x744F200", Offset = "0x744E600", VA = "0x18744F200")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x745A570", Offset = "0x7459970", VA = "0x18745A570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7454AC0", Offset = "0x7453EC0", VA = "0x187454AC0")]
		protected void JCBECOEMMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x745A330", Offset = "0x7459730", VA = "0x18745A330")]
		public void SetWaitForUgcTextureLoads(bool OJDHCDEPBKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x745A240", Offset = "0x7459640", VA = "0x18745A240")]
		public void SetUgcTextureParameters(AIJALJOGGJG GAPCIOOOOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x745AE20", Offset = "0x745A220", VA = "0x18745AE20")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x74556B0", Offset = "0x7454AB0", VA = "0x1874556B0")]
		[CompilerGenerated]
		private void MCNBMOFEJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7453670", Offset = "0x7452A70", VA = "0x187453670")]
		[CompilerGenerated]
		private void FOGKIAKKOCD(ACLIDNDADAP CMJMALHNEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7454B80", Offset = "0x7453F80", VA = "0x187454B80")]
		[CompilerGenerated]
		private void JGOPLDBOKHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7452520", Offset = "0x7451920", VA = "0x187452520")]
		[CompilerGenerated]
		private void DLHCNEBJKDE(ACLIDNDADAP CMJMALHNEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7454F10", Offset = "0x7454310", VA = "0x187454F10")]
		[CompilerGenerated]
		private void LBPNBLKILLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x74525C0", Offset = "0x74519C0", VA = "0x1874525C0")]
		[CompilerGenerated]
		private void DMAPKEKJJEG(ACLIDNDADAP CMJMALHNEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x74526C0", Offset = "0x7451AC0", VA = "0x1874526C0")]
		[CompilerGenerated]
		private void ECAMIPEDFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x74504F0", Offset = "0x744F8F0", VA = "0x1874504F0")]
		[CompilerGenerated]
		private void CFGGFHPEPEE(ACLIDNDADAP CMJMALHNEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x744FAE0", Offset = "0x744EEE0", VA = "0x18744FAE0")]
		[CompilerGenerated]
		private void BHBIHFLLIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7453AB0", Offset = "0x7452EB0", VA = "0x187453AB0")]
		[CompilerGenerated]
		private void GNOCPPIABAC(ACLIDNDADAP CMJMALHNEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7455BA0", Offset = "0x7454FA0", VA = "0x187455BA0")]
		[CompilerGenerated]
		private void MNDHAGLAGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x74535C0", Offset = "0x74529C0", VA = "0x1874535C0")]
		[CompilerGenerated]
		private void FIIFPPMJPMF(ACLIDNDADAP CMJMALHNEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x74533D0", Offset = "0x74527D0", VA = "0x1874533D0")]
		[CompilerGenerated]
		internal static bool FANCELCIHHK(Transform OOBJPKCFFCJ, IEnumerable<SkinnedMeshRenderer> AHJOPBCELFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7456630", Offset = "0x7455A30", VA = "0x187456630")]
		[CompilerGenerated]
		private void NJIPDDLMPMI(ACLIDNDADAP CMJMALHNEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7454C10", Offset = "0x7454010", VA = "0x187454C10")]
		[CompilerGenerated]
		private void KGOJOJLFKOG(ACLIDNDADAP CMJMALHNEPH)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, PCDEJAOCFEP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct HFODMJBOKJK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public GKDBEGOBGHP avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x74618D0", Offset = "0x7460CD0", VA = "0x1874618D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x7461B60", Offset = "0x7460F60", VA = "0x187461B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct OOLDMOCJMEO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public DIINEKIAPFE avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x7465620", Offset = "0x7464A20", VA = "0x187465620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x7465800", Offset = "0x7464C00", VA = "0x187465800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct OLMMAPICDGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public DIINEKIAPFE avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x74653A0", Offset = "0x74647A0", VA = "0x1874653A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x7465540", Offset = "0x7464940", VA = "0x187465540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct JKJDINLJMIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public GKDBEGOBGHP avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct IKLFCFOIBIH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public GKDBEGOBGHP avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x7462A40", Offset = "0x7461E40", VA = "0x187462A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x7462F80", Offset = "0x7462380", VA = "0x187462F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct PCKBKBNLOGO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public DIINEKIAPFE avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private TaskAwaiter<LFLFMHLHDIK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x7465860", Offset = "0x7464C60", VA = "0x187465860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x7465C80", Offset = "0x7465080", VA = "0x187465C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct GMCJLPMMLMN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public DIINEKIAPFE avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x7460E50", Offset = "0x7460250", VA = "0x187460E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x7461320", Offset = "0x7460720", VA = "0x187461320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		protected const float MBHAJCMJJKL = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		protected const int DAOJFNGBOBK = 5;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static readonly Dictionary<FEDMOEFAKIB.EJAJIJJGHBN, int> PPAGCAOOFCO;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> FNHGFIDCNNC;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static readonly int JHCJACNDEGF;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static readonly int IJHDBEPGLGO;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static readonly int LKEDDJOGAPG;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static readonly int EKGGEJNKNNF;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static readonly int CNFAPKDEAJC;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static readonly int DMOELLLDOMJ;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static readonly int GNNBCCOMAKL;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static readonly int HCBENEAFHFJ;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static Vector2 OAFNBFEFJNO;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static Vector2 DFMBHBHHKGA;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static Vector2 FEDNBFMEPLH;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static Vector2 DCOAIOGHEFF;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static Vector2 IBMOODBBNKN;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static Vector2 KPBBDMEKANK;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static Vector2 ODECJCJGJDJ;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static Vector2 BDEALEABMMN;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static Vector2 CEGHIOCDHKO;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 DGDHJDJJAJA;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 KHJHHBOAPIC;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 NLOEFNDLFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private DIINEKIAPFE JMBAIFDHHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private FaceStyleSet JCIBDOEOMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected const int APDAONPEPHA = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected int FNHGNPHPKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected int MBMKLBOKICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected int MDAEKNOOBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected int IJDIHDPFLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected Vector2 ELLJMDEBDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected float GPDIINGAMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected Vector2 OGADHDEGHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected float APKJDCEHCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected Vector2 HKJIEDMPEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected float NLOOGFLBCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected Vector2 CKGCKFBBJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected float IMGPDIKKJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected List<SelectableFaceOption> IOAEGLONEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected List<SelectableFaceOption> OIMMOFCLIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected List<SelectableFaceOption> KAOLHNGCOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected List<SelectableFaceOption> EEHOEGJDPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected Coroutine IPGOIGNIBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected int? DNHHCDEOJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected int IJBFLBMLHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected int BOFEEEPGEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected int HFPABGCPDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected int FLHHHOFNFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected int PALECFCHJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected int HKKECCINNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected Sprite GFPDLMLKNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Sprite AHGMAGGMCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected Sprite PLLPFPBKFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected Sprite MKEPDDBKIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected bool DOANKABLCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected string PIIADLNLDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected string PHJFDOHGDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected string OGHIPKGLPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected string PPBAJAMDFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected AvatarConfiguration FDDIIONJAJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected LFLFMHLHDIK GKAAOBBKPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private readonly List<Material> EBLNHFCHDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected JNKFNELNFPN BMCKIGIECDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected Dictionary<string, int> CHLMAJJDKKB;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public FaceStyleSet GJPNHNIPJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x746B950", Offset = "0x746AD50", VA = "0x18746B950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool OPONMODNLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x9E38F0", Offset = "0x9E2CF0", VA = "0x1809E38F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x9E3110", Offset = "0x9E2510", VA = "0x1809E3110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		protected virtual bool DFGGDKFBCCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		protected virtual bool DLFJPEIFJGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected int MCODEOJPKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7466A40", Offset = "0x7465E40", VA = "0x187466A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Renderer GGBGFCKHOEB
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool MDDBENIPHAN
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x131CDA0", Offset = "0x131C1A0", VA = "0x18131CDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x131D0B0", Offset = "0x131C4B0", VA = "0x18131D0B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Renderer[] MGCJGBIJCCE
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool BBPIHBCNOBM
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x746B990", Offset = "0x746AD90", VA = "0x18746B990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x746BB50", Offset = "0x746AF50", VA = "0x18746BB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int GMOBBKJKHPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7467BD0", Offset = "0x7466FD0", VA = "0x187467BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected int KFFAENJKICM
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x7468FD0", Offset = "0x74683D0", VA = "0x187468FD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public float BDNOMAJALFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x746B970", Offset = "0x746AD70", VA = "0x18746B970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x746BB30", Offset = "0x746AF30", VA = "0x18746BB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public IAENBMOFMLD NBHAKAKGHCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x9DEF90", Offset = "0x9DE390", VA = "0x1809DEF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xA8F640", Offset = "0xA8EA40", VA = "0x180A8F640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public LFLFMHLHDIK KOKEOKGNDMP
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF270", Offset = "0x9DE670", VA = "0x1809DF270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x746BAB0", Offset = "0x746AEB0", VA = "0x18746BAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public NoseFaceOption PLIPDODKOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA86060", Offset = "0xA85460", VA = "0x180A86060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x9F80D0", Offset = "0x9F74D0", VA = "0x1809F80D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected JNKFNELNFPN MLDCINHCLLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x7467660", Offset = "0x7466A60", VA = "0x187467660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BFJEJGMLIHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x746B8A0", Offset = "0x746ACA0", VA = "0x18746B8A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x746BA00", Offset = "0x746AE00", VA = "0x18746BA00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x74687E0", Offset = "0x7467BE0", VA = "0x1874687E0")]
		public void LocalPlayEmote(FEDMOEFAKIB.EJAJIJJGHBN CBEKHELGDIP, float GEOBBGODMBH = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x74680F0", Offset = "0x74674F0", VA = "0x1874680F0")]
		public bool IsEmotePlaying(FEDMOEFAKIB.EJAJIJJGHBN CBEKHELGDIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x74699F0", Offset = "0x7468DF0", VA = "0x1874699F0")]
		public void SetIdleHappy(bool LPCKBEIBKFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7467B50", Offset = "0x7466F50", VA = "0x187467B50")]
		protected void HKLHPFGLAEO(bool KLGDNDKOGKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7465DC0", Offset = "0x74651C0", VA = "0x187465DC0")]
		protected void AECFCMLDPFN(bool HNDJFNAABOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x7469030", Offset = "0x7468430", VA = "0x187469030")]
		protected void PHJAOAGJOGI(FGFOFKPBCAF CBBFCGBIHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x74689C0", Offset = "0x7467DC0", VA = "0x1874689C0")]
		protected void MIDMKOGLNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7469220", Offset = "0x7468620", VA = "0x187469220")]
		public void PlayExpression(int KFMNIFAFENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x74667A0", Offset = "0x7465BA0", VA = "0x1874667A0")]
		protected void BKIGMCIDFPE(bool LOOOMINLHDH, bool JJHOEMMCLCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7467B10", Offset = "0x7466F10", VA = "0x187467B10")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType NMALLOBNLKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7467C30", Offset = "0x7467030", VA = "0x187467C30")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration FDDIIONJAJJ, DIINEKIAPFE NKOMJFFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x74697D0", Offset = "0x7468BD0", VA = "0x1874697D0")]
		[AsyncStateMachine(typeof(HFODMJBOKJK))]
		public Task SetFaceSettings(GKDBEGOBGHP BFLCMMHHBLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x74698C0", Offset = "0x7468CC0", VA = "0x1874698C0")]
		[AsyncStateMachine(typeof(OOLDMOCJMEO))]
		public Task SetFaceSettings(int KODMNGIGPMB, int EKCEEMOLFOP, int GJKJNAMIEIE, int IPCIHGFNDLK, DIINEKIAPFE NKOMJFFJMEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x7469A70", Offset = "0x7468E70", VA = "0x187469A70")]
		[AsyncStateMachine(typeof(OLMMAPICDGF))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType NMALLOBNLKG, int NPNHLBGBGCB, DIINEKIAPFE NKOMJFFJMEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7466CA0", Offset = "0x74660A0", VA = "0x187466CA0")]
		protected void DMFNMHFBHIN(FaceFeatureType NMALLOBNLKG, AFEABOIFMLA FJPOLNGOPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7466060", Offset = "0x7465460", VA = "0x187466060")]
		protected void BKDKAEJELJC(FaceFeatureType NMALLOBNLKG, int NPNHLBGBGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7467940", Offset = "0x7466D40", VA = "0x187467940")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7466950", Offset = "0x7465D50", VA = "0x187466950")]
		[AsyncStateMachine(typeof(IKLFCFOIBIH))]
		protected Task CHDJMBIPEGC(GKDBEGOBGHP BFLCMMHHBLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7468650", Offset = "0x7467A50", VA = "0x187468650")]
		protected static void LNFFBHKHHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x74676E0", Offset = "0x7466AE0", VA = "0x1874676E0")]
		private void GOCNPAPEACI(bool ODNLPCHGOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7468200", Offset = "0x7467600", VA = "0x187468200")]
		protected void JIBIOJKPHCH(FaceFeatureType NMALLOBNLKG, Vector2 DPHJFNLKJME, DIINEKIAPFE NKOMJFFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7469240", Offset = "0x7468640", VA = "0x187469240")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType NMALLOBNLKG, Vector2 CPCKCPECPAF, DIINEKIAPFE NKOMJFFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x74690A0", Offset = "0x74684A0", VA = "0x1874690A0")]
		protected void PPCKNMAOEEG(FaceFeatureType NMALLOBNLKG, float JFONOIBEFKK, DIINEKIAPFE NKOMJFFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x74695B0", Offset = "0x74689B0", VA = "0x1874695B0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType NMALLOBNLKG, float EBLCHJBCPMF, DIINEKIAPFE NKOMJFFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7468CE0", Offset = "0x74680E0", VA = "0x187468CE0")]
		[AsyncStateMachine(typeof(PCKBKBNLOGO))]
		protected Task NJNOHMCOPBD(DIINEKIAPFE NKOMJFFJMEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7467EE0", Offset = "0x74672E0", VA = "0x187467EE0")]
		public void InitializeFaceFeatureStyleSet(DIINEKIAPFE NKOMJFFJMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7468570", Offset = "0x7467970", VA = "0x187468570")]
		protected bool KIBBLMBAFDP(string KDPFFMGAKEG, [Out] int FFCBHHABFJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7465F20", Offset = "0x7465320", VA = "0x187465F20")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x13AF810", Offset = "0x13AEC10", VA = "0x1813AF810", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7468DC0", Offset = "0x74681C0", VA = "0x187468DC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x746AA40", Offset = "0x7469E40", VA = "0x18746AA40")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7466850", Offset = "0x7465C50", VA = "0x187466850")]
		[AsyncStateMachine(typeof(GMCJLPMMLMN))]
		public Task BuildFaceStyleAsyncIfChanged(DIINEKIAPFE NKOMJFFJMEP, bool HJPCEOBMLOH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x746A370", Offset = "0x7469770", VA = "0x18746A370")]
		public void UpdateFaceDisplays(bool FNGHNBKCFGG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7466E10", Offset = "0x7466210", VA = "0x187466E10")]
		protected bool EOKICJPHLHN(bool FNGHNBKCFGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x746A090", Offset = "0x7469490", VA = "0x18746A090")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7469B80", Offset = "0x7468F80", VA = "0x187469B80")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x746A580", Offset = "0x7469980", VA = "0x18746A580")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x746A770", Offset = "0x7469B70", VA = "0x18746A770")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x74688D0", Offset = "0x7467CD0", VA = "0x1874688D0")]
		protected void MDFABKFOGJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7468A30", Offset = "0x7467E30", VA = "0x187468A30")]
		private void NIFAIAABNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x746B650", Offset = "0x746AA50", VA = "0x18746B650")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x991AF0", Offset = "0x990EF0", VA = "0x180991AF0", Slot = "4")]
		private bool EDMNCKJLANA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7466B70", Offset = "0x7465F70", VA = "0x187466B70")]
		[CompilerGenerated]
		internal static GMOHEDJKJCH DAAEDBFMDNJ(FaceFeatureType NMALLOBNLKG, JKJDINLJMIP P_1)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct HEBCPOFILDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public string NAMECGEJFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public int MHHGANKHAMB;
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
		private struct KPHHCHEMBEB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x7463BA0", Offset = "0x7462FA0", VA = "0x187463BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct GNBCLOGNNJI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7461380", Offset = "0x7460780", VA = "0x187461380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x7461870", Offset = "0x7460C70", VA = "0x187461870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public DIINEKIAPFE avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public JKJEECCDFGN useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public CFIMFIIKPEO hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public FNKFCOOECIK HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[SerializeField]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private HLDIOKBHFCE COPEHBACHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private AnimatorOverrideController EMBCIJGLNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> CINOHFCAOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public readonly HEBCPOFILDJ[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public readonly (string, EFMOGLDOMFL)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		protected bool BGCFHENHHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		protected Guid AINEMKMNMJO;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		protected static Guid PBEMFNHDHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private NHBJOEBCOCP LPGNIDOGAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private IAENBMOFMLD FCDJKGHHHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private MBDCKCDIJDA GBOPGCJIHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private MBDCKCDIJDA AAKHNKNNOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private AdditionalHatData KDINDCFBJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private readonly Dictionary<GameObject, BNAPMJHDJHM> BJOHDKPOKOO;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public static Func<LHBDPPOGLJN> HCNGKDOLBGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x7470B80", Offset = "0x746FF80", VA = "0x187470B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x74711C0", Offset = "0x74705C0", VA = "0x1874711C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public bool KNGPLKILDLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x7470CE0", Offset = "0x74700E0", VA = "0x187470CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool KINFACKBBKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x7470BD0", Offset = "0x746FFD0", VA = "0x187470BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public PlayerAvatarDisplayBase MJELLHIKLJE
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x9E2DD0", Offset = "0x9E21D0", VA = "0x1809E2DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected static Guid COLAFFDHHJG
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x746CD10", Offset = "0x746C110", VA = "0x18746CD10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public (GameObject, FGFOFKPBCAF)[] GLBIMPNIBBO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7470DF0", Offset = "0x74701F0", VA = "0x187470DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x746E900", Offset = "0x746DD00", VA = "0x18746E900")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x746E490", Offset = "0x746D890", VA = "0x18746E490")]
		private IEnumerable<GameObject> PFJCIMMEANA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x746EDF0", Offset = "0x746E1F0", VA = "0x18746EDF0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x746DC10", Offset = "0x746D010", VA = "0x18746DC10")]
		private void JIGDABLDOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x10D94C0", Offset = "0x10D88C0", VA = "0x1810D94C0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x746D510", Offset = "0x746C910", VA = "0x18746D510")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x746EE00", Offset = "0x746E200", VA = "0x18746EE00")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x746EBF0", Offset = "0x746DFF0", VA = "0x18746EBF0")]
		public void ShowPose(AnimationClip CHAHBFANCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x746EDC0", Offset = "0x746E1C0", VA = "0x18746EDC0")]
		public void ShowPose(string OCFHONOJPAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x746EA50", Offset = "0x746DE50", VA = "0x18746EA50")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x746E910", Offset = "0x746DD10", VA = "0x18746E910")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x746F8D0", Offset = "0x746ECD0", VA = "0x18746F8D0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x746F720", Offset = "0x746EB20", VA = "0x18746F720")]
		public void UpdateFaceAndBodyShapes(bool HJPCEOBMLOH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x746FCD0", Offset = "0x746F0D0", VA = "0x18746FCD0")]
		public void UpdateNoseShape(HDEGHEIKKJI MGIHACEIMCH, bool HJPCEOBMLOH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x746FCA0", Offset = "0x746F0A0", VA = "0x18746FCA0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x746D200", Offset = "0x746C600", VA = "0x18746D200", Slot = "4")]
		protected virtual void IPKACOKKFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x746DCF0", Offset = "0x746D0F0", VA = "0x18746DCF0", Slot = "5")]
		protected virtual void JNBCMFCAJAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x746C290", Offset = "0x746B690", VA = "0x18746C290")]
		public void ApplyHatData(AdditionalHatData BKABAMKBACK, bool LADBCEILGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x746C0D0", Offset = "0x746B4D0", VA = "0x18746C0D0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x746C5F0", Offset = "0x746B9F0", VA = "0x18746C5F0")]
		public void ApplyHatUVOverride(Vector2 ABGKMCNGPKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x746C510", Offset = "0x746B910", VA = "0x18746C510")]
		public void ApplyHatPositionAdjustment(Vector3 MFIOHIKBBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x746C580", Offset = "0x746B980", VA = "0x18746C580")]
		public void ApplyHatRotationAdjustment(Vector3 HPHGHPGNJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x746C660", Offset = "0x746BA60", VA = "0x18746C660")]
		public IEOIGDKBNNB BuildAvatarItemSelection(GameObject LDPLECPNAKN, DIINEKIAPFE ILBEBBKHOOK, FGFOFKPBCAF OGHDCLKOCFH)
		{
			return default(IEOIGDKBNNB);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x746C700", Offset = "0x746BB00", VA = "0x18746C700")]
		public void BuildAvatar(bool HJPCEOBMLOH = false, bool LADBCEILGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x746F160", Offset = "0x746E560", VA = "0x18746F160")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x746C210", Offset = "0x746B610", VA = "0x18746C210")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x746FAF0", Offset = "0x746EEF0", VA = "0x18746FAF0")]
		public void UpdateHatAnchor(bool LADBCEILGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x746F820", Offset = "0x746EC20", VA = "0x18746F820")]
		[AsyncStateMachine(typeof(KPHHCHEMBEB))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x746BCA0", Offset = "0x746B0A0", VA = "0x18746BCA0")]
		[AsyncStateMachine(typeof(GNBCLOGNNJI))]
		private Task ABNKBEJHKGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x746CE90", Offset = "0x746C290", VA = "0x18746CE90")]
		private void FIJDEAGPMHK(FaceFeatureType FHBFDOFHNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x746CE00", Offset = "0x746C200", VA = "0x18746CE00")]
		private void FGDNMKEIIHH(FaceFeatureType FHBFDOFHNME, [Out] float FMCBGANICJB, [Out] float JPCMPOFENAN, [Out] float JKHHCOODJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x746F5E0", Offset = "0x746E9E0", VA = "0x18746F5E0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x746F980", Offset = "0x746ED80", VA = "0x18746F980")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x746DF60", Offset = "0x746D360", VA = "0x18746DF60")]
		private void OFMMKIFGDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
		private void ABNBIGIFJGL(BNAPMJHDJHM ODAOKEOLGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
		private void IEGGBDPGFIG(BNAPMJHDJHM ODAOKEOLGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x746BD70", Offset = "0x746B170", VA = "0x18746BD70")]
		private void AIAEIMFNFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x746FD50", Offset = "0x746F150", VA = "0x18746FD50")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x746D150", Offset = "0x746C550", VA = "0x18746D150")]
		[CompilerGenerated]
		private IEOIGDKBNNB IKBMPEBOADH((GameObject, FGFOFKPBCAF) CEBODBHNODA)
		{
			return default(IEOIGDKBNNB);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		[SerializeField]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct IEOIGDKBNNB
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class OLOEKIJNCDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OLOEKIJNCDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x74655A0", Offset = "0x74649A0", VA = "0x1874655A0")]
		internal bool EILHKLFFBNF(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private BNAPMJHDJHM LOMFDKDIKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private FGFOFKPBCAF PNGBAEMEIGB;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public BNAPMJHDJHM KJMHPDOHPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public FGFOFKPBCAF ADKLHBIHDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFE0", Offset = "0xC1A3E0", VA = "0x180C1AFE0")]
		get
		{
			return default(FGFOFKPBCAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public string AGHJIAELIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7462500", Offset = "0x7461900", VA = "0x187462500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GDMACONDHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x74624B0", Offset = "0x74618B0", VA = "0x1874624B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool IMAHKOOKFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x74623A0", Offset = "0x74617A0", VA = "0x1874623A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x15EEE20", Offset = "0x15EE220", VA = "0x1815EEE20")]
	public IEOIGDKBNNB(BNAPMJHDJHM ODAOKEOLGCK, FGFOFKPBCAF CBBFCGBIHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x74623F0", Offset = "0x74617F0", VA = "0x1874623F0")]
	public bool HBACNCKGMMI(OutfitType DGPNKBIGBGP, FGFOFKPBCAF DAMHDMJIDGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x74625F0", Offset = "0x74619F0", VA = "0x1874625F0")]
	public bool MCEJJMLJAHL(OutfitType DGPNKBIGBGP, FGFOFKPBCAF DAMHDMJIDGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x7462850", Offset = "0x7461C50", VA = "0x187462850")]
	public bool ONNJJADLKGP(IEOIGDKBNNB NPFFCCAALML)
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
