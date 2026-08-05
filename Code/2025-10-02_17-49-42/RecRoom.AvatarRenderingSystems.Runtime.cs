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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x831CDF0", Offset = "0x831B7F0", VA = "0x18831CDF0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x831DA70", Offset = "0x831C470", VA = "0x18831DA70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x831DA00", Offset = "0x831C400", VA = "0x18831DA00", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x831DA30", Offset = "0x831C430", VA = "0x18831DA30")]
		public RecNetCDNAssetReference(RecNetCDNKey HPFHOBCPNEF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum EJFNADFHNIC : byte
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
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xADB270", Offset = "0xAD9C70", VA = "0x180ADB270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xADAFF0", Offset = "0xAD99F0", VA = "0x180ADAFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EJFNADFHNIC PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF79550", Offset = "0xF77F50", VA = "0x180F79550")]
			[CompilerGenerated]
			get
			{
				return default(EJFNADFHNIC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1626120", Offset = "0x1624B20", VA = "0x181626120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x831DB80", Offset = "0x831C580", VA = "0x18831DB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x831DB00", Offset = "0x831C500", VA = "0x18831DB00")]
		public static RecNetCDNKey IHPBEILMGKK(string PFOHJGFPEHL, EJFNADFHNIC PKOLNHJMCBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x831DAB0", Offset = "0x831C4B0", VA = "0x18831DAB0")]
		public void DCGIGHBCMGJ(string DOKHCGNGBKP, string LMLHBIBFOGI, bool HABMPHFLKBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LDDMKMABCFO]
public class MNDHAMFKPIO : GHBJCGHKNIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> PDECOBINNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<IReadOnlyList<byte>> NNGFOCIIODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> NPEOFHIIGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> JJKMNENMAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> OAFCBLEIHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> HBABDPJGCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> FOFKIPOKMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator OPAJLHNKAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected EKPJNMADPCB GHKDPMGILAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte IIFDBOMCIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> GGEOAPDLJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> DGILOPGBFFK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x831D120", Offset = "0x831BB20", VA = "0x18831D120", Slot = "4")]
	public void ODAIGGCAFEJ(Mesh KGGOMLADPBD, Matrix4x4 ONMPCJHMCMI, IReadOnlyList<byte> ELONOALJKKD, bool JFKNILJIMBE = false, HLHFIFHEPCK.LFIDLNGOLDF PNJAPAHPGBC = (HLHFIFHEPCK.LFIDLNGOLDF)0L, int JCILFKFDKDO = -1, bool MFBKBIBKKBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x831D0E0", Offset = "0x831BAE0", VA = "0x18831D0E0", Slot = "5")]
	public void ENNKFJHCNMI(Allocator EIOOMONCLID, EKPJNMADPCB PHEKDHCLLIA, byte HJHOJDKFBIE, [Optional] IList<int> OBLFKHKFEFA, [Optional] IList<int> PPNDDAAAJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x831CE80", Offset = "0x831B880", VA = "0x18831CE80")]
	private static void EBBPELIEOJM(Mesh KGGOMLADPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x831D440", Offset = "0x831BE40", VA = "0x18831D440")]
	public MNDHAMFKPIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[LDDMKMABCFO]
public struct CIDBLLCCBHF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public JJBINIEPPHH HONCCLOHNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int DFHKGKGFNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public KIKKGIDGELC BMPNHNJGJCH;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x83163C0", Offset = "0x8314DC0", VA = "0x1883163C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[LDDMKMABCFO]
[NativeContainer]
public struct KIKKGIDGELC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct AFMOPCDDFDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 HCODDIBDOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 BJGHDDIMDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 ILIMBEEKFNL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct DIIIEEJKACG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float MJOMGLCOAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float JFIBCLHJKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float KIKNPKGINKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float NACKFHEOEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte HNKNBHLGDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte GLFAFCCNHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte AINEILJKPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte AKPIIAGMDKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct FMLJNIPADDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half MJOMGLCOAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half JFIBCLHJKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half KIKNPKGINKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half NACKFHEOEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte HNKNBHLGDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte GLFAFCCNHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte AINEILJKPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte AKPIIAGMDKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct PHKKCOEIJGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 EOGEFFOIIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 DLOHNANENLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 EIJENPLANKP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct JIJAHNOKIOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half4 EOGEFFOIIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 DLOHNANENLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 CNBLONMGGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half4 EIJENPLANKP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DJNHKNAAJMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 EOGEFFOIIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 DLOHNANENLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half2 CNBLONMGGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 PGFIIPCFHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half4 EIJENPLANKP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct AIHLAHNPGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half4 EOGEFFOIIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 DLOHNANENLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public half2 CNBLONMGGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public half2 PGFIIPCFHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public half2 FONAINCBCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public half4 EIJENPLANKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OEIBNMBCCLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float MJOMGLCOAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float JFIBCLHJKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float KIKNPKGINKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float NACKFHEOEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int HNKNBHLGDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int GLFAFCCNHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int AINEILJKPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int AKPIIAGMDKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct CINOEPJJAHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color EOGEFFOIIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 DLOHNANENLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4 EIJENPLANKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct IHIADFCCIMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Color EOGEFFOIIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 DLOHNANENLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector2 CNBLONMGGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4 EIJENPLANKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct DGFCMDDKHJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Color EOGEFFOIIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 DLOHNANENLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 CNBLONMGGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Vector2 PGFIIPCFHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector4 EIJENPLANKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct LOADBEEBPGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Color EOGEFFOIIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector2 DLOHNANENLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector2 CNBLONMGGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Vector2 PGFIIPCFHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Vector2 FONAINCBCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Vector4 EIJENPLANKP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool BCGDFDGMHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<AFMOPCDDFDP> FKBJJPIKBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<PHKKCOEIJGC> LKHALGLLPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<JIJAHNOKIOG> AAOBGLGOOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<DJNHKNAAJMJ> CLPHCLBJNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<AIHLAHNPGAB> EAMKAGOAIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<FMLJNIPADDE> OOHMEGIGEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<DIIIEEJKACG> KGDPIPJEHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<CINOEPJJAHN> DDIHNDHNBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<IHIADFCCIMP> HIELLFCIGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<DGFCMDDKHJI> NAMGEONOHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<LOADBEEBPGD> DJBPJBFOJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<OEIBNMBCCLB> KPJHOJCKJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> GBLKPFDPOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> HOJIGFMFFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> BLLNLKLFEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> MPMCCCAALDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> OBDBPLIFLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> OMGOIKPNHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> EFBBCPNGDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> EECFNOMGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> PDCLAJMPOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool DBMMKJIFCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool MDJGPDAKFFD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GKKHECINGBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x831B1D0", Offset = "0x8319BD0", VA = "0x18831B1D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8319B90", Offset = "0x8318590", VA = "0x188319B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BKIKGDLDPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x831B630", Offset = "0x831A030", VA = "0x18831B630")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x831BF80", Offset = "0x831A980", VA = "0x18831BF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DMFPAEFFFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x831BF70", Offset = "0x831A970", VA = "0x18831BF70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8319B80", Offset = "0x8318580", VA = "0x188319B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int IABDHNEFINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x831AEF0", Offset = "0x83198F0", VA = "0x18831AEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x831C3C0", Offset = "0x831ADC0", VA = "0x18831C3C0")]
	public KIKKGIDGELC(int EHCMPHBOHMC, int COCDKCIIDED, int MFCCCNMHBNM, int HPAPCCFJNDA, Allocator EIOOMONCLID, int AJJGJOLGNNF, KENOBBOBGKO NOMKPGOEHIC, bool DBMMKJIFCGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x831BDF0", Offset = "0x831A7F0", VA = "0x18831BDF0")]
	public void MAMNEIKOFFD(int KABGMIEBEFC, Vector3 FEBGNHCBECK, Vector3 AFDFHFKFCKE, Vector4 GGMLEPFJHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x831BF90", Offset = "0x831A990", VA = "0x18831BF90")]
	public void PGBIBBLPLLF(int KABGMIEBEFC, BoneWeight DLDHAEIEMAE, NativeSlice<byte> ELONOALJKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x831B1E0", Offset = "0x8319BE0", VA = "0x18831B1E0")]
	public Color GPLOMMFCMIG(int KABGMIEBEFC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x831AAC0", Offset = "0x83194C0", VA = "0x18831AAC0")]
	public void DIMLBIDOHMD(int KABGMIEBEFC, Color DMCCCPMAFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x831BE80", Offset = "0x831A880", VA = "0x18831BE80")]
	public void MHLPKINIDBH(int KABGMIEBEFC, Vector3 FNPMGHGMCGE, Vector3 BIPJHCOBIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x831BA50", Offset = "0x831A450", VA = "0x18831BA50")]
	public void LBEKGAJFNNC(int KABGMIEBEFC, half4 GJKOLNHMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x831BBA0", Offset = "0x831A5A0", VA = "0x18831BBA0")]
	public void LJIMEBGHJCB(int KABGMIEBEFC, Vector3 GJKOLNHMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x831B640", Offset = "0x831A040", VA = "0x18831B640")]
	public void INCDLKLNCDB(byte LAGPHBENBMG, int KABGMIEBEFC, Vector2 GJKOLNHMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x831B1C0", Offset = "0x8319BC0", VA = "0x18831B1C0")]
	public void FLLJEJICAFM(int KABGMIEBEFC, int JLGGDBMNAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x831B500", Offset = "0x8319F00", VA = "0x18831B500")]
	public bool HEKALOFHECJ(int LAGPHBENBMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x831B560", Offset = "0x8319F60", VA = "0x18831B560")]
	public void HEOBEKJHMEH(int IPMHCEACDJA, int JBCPGNDLJHB, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x831AF60", Offset = "0x8319960", VA = "0x18831AF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8319BA0", Offset = "0x83185A0", VA = "0x188319BA0")]
	public Mesh CGBJLGFAJJM([Optional] string ABJJBLBNHAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[LDDMKMABCFO]
[NativeContainer]
public struct JJBINIEPPHH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Mesh.MeshDataArray HAMMECJHCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> CFFDEHHIMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<int> ELNLKEOKKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<BoneWeight> EECFNOMGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<Matrix4x4> MAONPADOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<long> AFDGIMFPEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<byte> DJNIHEOPILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<int> FHNJEIAJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<int> EOELDEHJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeArray<sbyte> MIHBEINGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<byte> ACNJFOLIOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<bool> MFBKBIBKKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<int> JCILFKFDKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool DBMMKJIFCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<int> BNJPBJILKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool MDJGPDAKFFD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OACFJOLPMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8318760", Offset = "0x8317160", VA = "0x188318760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int EMHECKNBIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8318730", Offset = "0x8317130", VA = "0x188318730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BEPIODHFIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8318170", Offset = "0x8316B70", VA = "0x188318170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int JEKFFOMLIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8318750", Offset = "0x8317150", VA = "0x188318750")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8318770", Offset = "0x8317170", VA = "0x188318770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GKKHECINGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8318710", Offset = "0x8317110", VA = "0x188318710")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8318150", Offset = "0x8316B50", VA = "0x188318150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int NEGEBCIBDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83184A0", Offset = "0x8316EA0", VA = "0x1883184A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8318740", Offset = "0x8317140", VA = "0x188318740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public EKPJNMADPCB PLIGKHPBMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8318720", Offset = "0x8317120", VA = "0x188318720")]
		get
		{
			return default(EKPJNMADPCB);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8318160", Offset = "0x8316B60", VA = "0x188318160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte GMKJEOMBJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8318310", Offset = "0x8316D10", VA = "0x188318310")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83184B0", Offset = "0x8316EB0", VA = "0x1883184B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MANGOPGJAMI PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83184C0", Offset = "0x8316EC0", VA = "0x1883184C0")]
		get
		{
			return default(MANGOPGJAMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8318780", Offset = "0x8317180", VA = "0x188318780")]
	public JJBINIEPPHH(IList<Mesh> LLJGIONICIL, IList<Matrix4x4> NCOMDPKDFCB, IList<bool> MFBKBIBKKBL, byte HJHOJDKFBIE, IList<IReadOnlyList<byte>> IPNJKLIACME, IList<long> BFDEJCHBKEH, IList<bool> CJPNLELHDGM, IList<int> JCILFKFDKDO, IList<int> OBLFKHKFEFA, IList<int> JLFNLPNBIEB, Allocator EIOOMONCLID, EKPJNMADPCB PHEKDHCLLIA, bool DBMMKJIFCGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8318240", Offset = "0x8316C40", VA = "0x188318240")]
	public KIKKGIDGELC CPPDOMEFIBA(Allocator EIOOMONCLID, KENOBBOBGKO NOMKPGOEHIC)
	{
		return default(KIKKGIDGELC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8318320", Offset = "0x8316D20", VA = "0x188318320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[LDDMKMABCFO]
public class HFLKBJMBGFH : MNDHAMFKPIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool BBFIJGHOMCJ;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly ProfilerMarker ADLIGDOCEAJ;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8317E80", Offset = "0x8316880", VA = "0x188317E80")]
	public JJBINIEPPHH PBPNNMEKIHF()
	{
		return default(JJBINIEPPHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8318140", Offset = "0x8316B40", VA = "0x188318140")]
	public HFLKBJMBGFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MANGOPGJAMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Mesh.MeshData FKEJOKAAPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NativeSlice<BoneWeight> EECFNOMGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public NativeSlice<byte> HHGIBLLCMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int NGOFMAICIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Matrix4x4 EFGNJAODGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public long COBDGJAAHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeSlice<byte> ELONOALJKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public bool GODGFICPAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public int LJMHOJELONP;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[DisallowMultipleComponent]
	public class AvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum AGFCKGMJOAM : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct PCGKGDJDDBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public bool CBNDFDHCFNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public long BNICMFHPCJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int DFJPAPCPHCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public float JIGCMOAOJAM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[CompilerGenerated]
		private Action BuildCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public PCGKGDJDDBF[] lodInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public ACOJACDAJIP DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected AGFCKGMJOAM _currentLODSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		protected int[] _currentLODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int requestedLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		protected int _manualLod;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float bboxDiameterInMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		protected ICNBFDLCIDH _displaySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		protected PKHGEDPOIHB _currentPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected (bool isLodForced, int forcedLOD) _forceLod;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public virtual int ENEGAIEFADB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xACB3F0", Offset = "0xAC9DF0", VA = "0x180ACB3F0", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x1794EA0", Offset = "0x17938A0", VA = "0x181794EA0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool HPMPAMGPGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8315FC0", Offset = "0x83149C0", VA = "0x188315FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public virtual bool FAPEKLEEJLK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool OEGAHCMICEI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8315F80", Offset = "0x8314980", VA = "0x188315F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ICNBFDLCIDH IMNCOKLCNMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8316070", Offset = "0x8314A70", VA = "0x188316070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected PKHGEDPOIHB LOPLMBAMEFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8315950", Offset = "0x8314350", VA = "0x188315950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int GFMJCFFKBNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x83163A0", Offset = "0x8314DA0", VA = "0x1883163A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public BOIFAILEJMF EEPLNFFDGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8315F30", Offset = "0x8314930", VA = "0x188315F30")]
			get
			{
				return default(BOIFAILEJMF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public virtual event Action PBLFDJADPAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8315E90", Offset = "0x8314890", VA = "0x188315E90", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8315FD0", Offset = "0x83149D0", VA = "0x188315FD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8315B70", Offset = "0x8314570", VA = "0x188315B70", Slot = "8")]
		public virtual (bool, bool, bool) WhichLodsAreResident()
		{
			return default((bool, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8315830", Offset = "0x8314230", VA = "0x188315830", Slot = "9")]
		public virtual (int, long, int) GetDisplayedLodInfo()
		{
			return default((int, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1007980", Offset = "0x1006380", VA = "0x181007980")]
		protected void LPPJCMBOCFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8315690", Offset = "0x8314090", VA = "0x188315690")]
		protected void AOAMGAGENHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x100EA60", Offset = "0x100D460", VA = "0x18100EA60")]
		protected void DDEKFNFLOGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8315780", Offset = "0x8314180", VA = "0x188315780", Slot = "11")]
		public virtual Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8315A50", Offset = "0x8314450", VA = "0x188315A50")]
		protected void MAENPEMNEGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8315890", Offset = "0x8314290", VA = "0x188315890", Slot = "12")]
		protected virtual void IMILJHLEPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8315AC0", Offset = "0x83144C0", VA = "0x188315AC0")]
		public int MeshesAtLODCount(int JNLBPBFBLNH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8315D90", Offset = "0x8314790", VA = "0x188315D90")]
		public AvatarDisplayBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AGIJPMGLDJD : ICNBFDLCIDH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PPLGNPCJAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AGIJPMGLDJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public PKHGEDPOIHB buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Action<KeyValuePair<string, AACADPLMCLK<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PPLGNPCJAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x831D850", Offset = "0x831C250", VA = "0x18831D850")]
		internal bool GGEAMHEEELL(MOJNGFFGLIG item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x831D810", Offset = "0x831C210", VA = "0x18831D810")]
		internal void EJFMLFICAEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x831D830", Offset = "0x831C230", VA = "0x18831D830")]
		internal void FKMICBDGHEJ(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x831D810", Offset = "0x831C210", VA = "0x18831D810")]
		internal void HICPEGEBMNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x831D830", Offset = "0x831C230", VA = "0x18831D830")]
		internal void HNEOBHCKFHG(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x831D8E0", Offset = "0x831C2E0", VA = "0x18831D8E0")]
		internal void IAJGNAKBAMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x831D9D0", Offset = "0x831C3D0", VA = "0x18831D9D0")]
		internal void NHNHMOCLNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x831D750", Offset = "0x831C150", VA = "0x18831D750")]
		internal void DOBIKMMLNAA(Dictionary<string, AACADPLMCLK<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x831D910", Offset = "0x831C310", VA = "0x18831D910")]
		internal void JMJDBPKHABN(KeyValuePair<string, AACADPLMCLK<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		internal CNBBKAECPOB PAOGACHCJNN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class PHELPPNDOLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public PPLGNPCJAHD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PHELPPNDOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x831D690", Offset = "0x831C090", VA = "0x18831D690")]
		internal BOBIFDGCLIG IJKEAGPOPMD(int lod)
		{
			return default(BOBIFDGCLIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LOAMABIPGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public FKFADEBPFBK<Dictionary<string, AACADPLMCLK<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LOAMABIPGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		internal FKFADEBPFBK<Dictionary<string, AACADPLMCLK<Texture2D>>> INKCOGFOJAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HDHJFMOBKFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<PKHGEDPOIHB> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HDHJFMOBKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8317D50", Offset = "0x8316750", VA = "0x188317D50")]
		internal void PFPPDIEJOJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KENMPCAINCC : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AGIJPMGLDJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public List<APINAHJGOBF> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public List<PKHGEDPOIHB> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Func<int, BOBIFDGCLIG> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public HNEMICNHGFC materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public KENMPCAINCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8319890", Offset = "0x8318290", VA = "0x188319890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8319B30", Offset = "0x8318530", VA = "0x188319B30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NHAEMPPBMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public List<HPBHBMMEHME> _nextPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public List<HPBHBMMEHME> _nextMaterialHandles;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NHAEMPPBMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8332EA0", Offset = "0x83318A0", VA = "0x188332EA0")]
		internal CNBBKAECPOB OEPIEFOFGAE(APINAHJGOBF p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CFJHELBEKFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public GFJMCEJGNHF cancelable;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CFJHELBEKFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xC188B0", Offset = "0xC172B0", VA = "0x180C188B0")]
		internal void KFPAJLJFOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xE99BD0", Offset = "0xE985D0", VA = "0x180E99BD0")]
		internal void JLOPMIMINNP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OMOIENFJHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public GFJMCEJGNHF cancelable;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OMOIENFJHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xC188B0", Offset = "0xC172B0", VA = "0x180C188B0")]
		internal void KFPAJLJFOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xE99BD0", Offset = "0xE985D0", VA = "0x180E99BD0")]
		internal void JLOPMIMINNP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class CINPKFDFKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AGIJPMGLDJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public List<(int mat, int part)> avatarItemMaterialPartIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public List<Bounds> avatarPartMeshBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CINPKFDFKJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class KKCLMCKDBBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public KIKKGIDGELC defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public JJBINIEPPHH defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public CINPKFDFKJL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KKCLMCKDBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x83317C0", Offset = "0x83301C0", VA = "0x1883317C0")]
		internal void DJFOLDOLEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x14A22D0", Offset = "0x14A0CD0", VA = "0x1814A22D0")]
		internal void CDEHJCMKOGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ECGMMKDFGJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public CKPMNKCIFOL legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public FIPHKOCGMNL legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public CINPKFDFKJL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ECGMMKDFGJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8328370", Offset = "0x8326D70", VA = "0x188328370")]
		internal void DLDPFEEJFBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x14A2580", Offset = "0x14A0F80", VA = "0x1814A2580")]
		internal void BPLFMNFNGBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KDJELEKNEFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AGIJPMGLDJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KDJELEKNEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8331780", Offset = "0x8330180", VA = "0x188331780")]
		internal void HDGFLLEGCAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HHLJNCKPHBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public EHMKAKBCPJB overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HHLJNCKPHBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x832BA70", Offset = "0x832A470", VA = "0x18832BA70")]
		internal bool CCHIDHICKFE(KeyValuePair<string, MOJNGFFGLIG> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly EBDGCEEEFPM EOOMFHDAFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly EBDGCEEEFPM NCJHKKKIFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<AJEJOKPMFDJ, float> EPHCJEHKFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<KPABGEBMFHP, float> CNCEBPKFCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<KFBADBLPJDD, float> KJBCPMAKHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private IReadOnlyDictionary<string, KBGJKKGMBIG> PEEGBBBPOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<string, KBGJKKGMBIG> LCEMCKNCMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Dictionary<string, KBGJKKGMBIG> DIHJAIBOENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Dictionary<string, KBGJKKGMBIG> AFDPNAFCJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private CBOHKGOBEFH GAOOAHEFEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private CBOHKGOBEFH DAFIEKDDKDJ;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static float GELPOIPMCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool? OOGLGKAKPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool? EPOKJCANHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private bool? PJHKMHKNMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool? JBFHPDJPFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private AvatarConfiguration EFHHIALFJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Transform DHLIDLMBDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AvatarSkinAssetItem DOKOADBNHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private AssetReference INOGKEAHCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private AssetReference EBMADMEFMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AssetReference NMKJFAFMDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private AssetReference AADODHKAJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private GameObject LALKKCFLJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private GameObject DLBNJBGOODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private GameObject AIEHACBAOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private SkinnedMeshRenderer DAHLIDCJPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private AvatarSkinnedMeshBoneOrderRemapsData CMKIPEHDCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Transform[] KOCONCIJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Matrix4x4[] DIFNEPIJAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Material GNFPMBNKOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material DNMFLHOLKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Material LFLNBDOGFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Material BJMBJANDGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Material JMLLNJPAOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Shader CILELJDOPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Shader GBPCIFEFNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Animator LLKALGJKEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Renderer[] MGHNMAJDJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private HLHFIFHEPCK.LFIDLNGOLDF KKKNIMPKFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AvatarBodyPartShapesManager JGBDGHPLJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IReadOnlyDictionary<string, Transform> IHKALHBAPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AvatarFaceShapeData.JNEPACCKGPD EBPNKABMEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private AvatarBodyShapeData.FEJDKIDOGBI NIFEKCCKCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private EJOAHECBEFE AHGBGPDJPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool EJIBPDGBJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x145")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool FFCPOICCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Color ELECHEAAAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Color BEDAMMEEKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Color DCFGEJFLCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Color? HNLILOGKDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Color? MMECCFPKDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Color? GKINPMFOIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private Color? HPGPDJABHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Texture2D BAAEIMBFLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Texture2D PFCJIDDMOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[CanBeNull]
	private MOJNGFFGLIG MFMDJIFPEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Texture DNFDFGCKKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Color HLONJNOIEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Dictionary<Renderer, HNEMICNHGFC> NFEMCEAIOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<Renderer, HNEMICNHGFC> PNHHNMHAEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Dictionary<string, List<FCOONAJGFPJ>> BBLABAIAGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private Dictionary<string, List<FCOONAJGFPJ>> KAMIDGFHMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly List<HPBHBMMEHME> IDCMDCGLAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly List<HPBHBMMEHME> GGDFLKMJAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly List<HPBHBMMEHME> FCELBJDIEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly List<HPBHBMMEHME> EKJCPNAJGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Dictionary<FCOONAJGFPJ, Material> NHAPGMKNPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Dictionary<FCOONAJGFPJ, Material> CANODDKLCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private SkinnedMeshRenderer[] NHELKMHNGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private SkinnedMeshRenderer[] LKFNEHKBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private SkinnedMeshRenderer[] FLKNEKBAAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private SkinnedMeshRenderer[] HFLBLPPHDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Dictionary<string, AACADPLMCLK<Texture2D>> OKFBGJFOBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Dictionary<string, AACADPLMCLK<Texture2D>> AODDCIGJDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private AdditionalHatData AJFPFHLBOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private AdditionalHatData DKHGNPODNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private HairData EHBHHOLFMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private HairData BDBEIMOEOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private AFKHHJFHFCH MGFHCEMHKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private bool? FIIKKBAJGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private PositionAndRotation IBKBDPNPIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform MIMMDCAEKMI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Material OCINJGLDIEK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Material HHHLEKDPMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private Dictionary<string, MOJNGFFGLIG> GKPLBPIFDPE;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly int KKMBDPHKGBK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly int GGFLLHJEGGF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly int IJGHAAAMHKK;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly int BEAHLKLDNDM;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly int LJADKPCMMNH;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly int AHCNFFEOMFA;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly int FNMMGLFNDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool HGLFCJOECDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private List<Action> BOAPJCJMHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private JLDDJMHEPLP GGCJPIMJKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private SkinnedMeshRenderer[] NMDNBJGLGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int MFFJIIBAGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private bool MHAJBIBCAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int IGOJGALJHMF;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public EBDGCEEEFPM GOLOMGNLHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public EBDGCEEEFPM APPNNILLMDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private JLFIJNDEFBP OPGACPAKDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8312700", Offset = "0x8311100", VA = "0x188312700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool OGGPDMMHLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8308720", Offset = "0x8307120", VA = "0x188308720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool LMNDCILJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83117E0", Offset = "0x83101E0", VA = "0x1883117E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool FGNICCLBBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83116D0", Offset = "0x83100D0", VA = "0x1883116D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool JKGPAIGCGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x830CDA0", Offset = "0x830B7A0", VA = "0x18830CDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AvatarConfiguration MNDNMMNNALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool ELICGGNPNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x830DE80", Offset = "0x830C880", VA = "0x18830DE80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x830CB40", Offset = "0x830B540", VA = "0x18830CB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Material MHNEFLHCBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x830B390", Offset = "0x8309D90", VA = "0x18830B390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Material HBHCOJMLFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x830CB50", Offset = "0x830B550", VA = "0x18830CB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool PIHKFNOJAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public BOIFAILEJMF HNLJAOBBNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8315510", Offset = "0x8313F10", VA = "0x188315510", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(BOIFAILEJMF);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x830F6F0", Offset = "0x830E0F0", VA = "0x18830F6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Material OGAPOLEHLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB3BA70", Offset = "0xB3A470", VA = "0x180B3BA70", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public SkinnedMeshRenderer[] ACODMFEDMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xBC1CF0", Offset = "0xBC06F0", VA = "0x180BC1CF0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Renderer[] DHCEIFCFIGM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB11EE0", Offset = "0xB108E0", VA = "0x180B11EE0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HBIABBHJNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8315520", Offset = "0x8313F20", VA = "0x188315520", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public HLHFIFHEPCK.LFIDLNGOLDF EFPCNLHGNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC269B0", Offset = "0xC253B0", VA = "0x180C269B0", Slot = "21")]
		get
		{
			return default(HLHFIFHEPCK.LFIDLNGOLDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int ENEGAIEFADB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x830AC80", Offset = "0x8309680", VA = "0x18830AC80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8310220", Offset = "0x830EC20", VA = "0x188310220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool PKLAJPIPGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x830B530", Offset = "0x8309F30", VA = "0x18830B530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private static bool GKIFPNJOCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x83088B0", Offset = "0x83072B0", VA = "0x1883088B0", Slot = "16")]
	public PKHGEDPOIHB BuildPotatoAvatar(EHBONEDLEEG KOEOMBPDEBK, bool ILCFNBPOEIB, int[] AEGHGIKPNPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8308880", Offset = "0x8307280", VA = "0x188308880", Slot = "15")]
	public PKHGEDPOIHB BuildAvatarMeshes(EHBONEDLEEG KOEOMBPDEBK, bool ILCFNBPOEIB, int[] AEGHGIKPNPM, Func<Dictionary<string, MOJNGFFGLIG>, (PKHGEDPOIHB, FKFADEBPFBK<Dictionary<string, AACADPLMCLK<Texture2D>>>)> FOOKPGALLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8308BC0", Offset = "0x83075C0", VA = "0x188308BC0")]
	public PKHGEDPOIHB CIBCNOMELCE(EHBONEDLEEG KOEOMBPDEBK, bool ILCFNBPOEIB, int[] AEGHGIKPNPM, bool CEOCCKFODHF, CBOHKGOBEFH MKDDIAFCOIA, [Optional] Func<Dictionary<string, MOJNGFFGLIG>, (PKHGEDPOIHB, FKFADEBPFBK<Dictionary<string, AACADPLMCLK<Texture2D>>>)> FOOKPGALLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x830B5B0", Offset = "0x8309FB0", VA = "0x18830B5B0")]
	private bool FIHLHPPMLFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x830D470", Offset = "0x830BE70", VA = "0x18830D470")]
	private PKHGEDPOIHB JHAKGLPDEFJ(bool ILCFNBPOEIB, List<APINAHJGOBF> KBAAPPGBGLO, int[] AEGHGIKPNPM, Func<int, BOBIFDGCLIG> EIGGFJAIPMH, bool CEOCCKFODHF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8307AD0", Offset = "0x83064D0", VA = "0x188307AD0")]
	[IteratorStateMachine(typeof(KENMPCAINCC))]
	private IEnumerator<JFFMJDIOLAN> AIHFLACEDMA(bool ILCFNBPOEIB, List<APINAHJGOBF> KBAAPPGBGLO, int[] AEGHGIKPNPM, Func<int, BOBIFDGCLIG> EIGGFJAIPMH, HNEMICNHGFC FCCLOGLCHNC, Material DJPAPGPCBDH, List<PKHGEDPOIHB> KJCGINCDHLG, bool DIFBPHDJJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8310D10", Offset = "0x830F710", VA = "0x188310D10")]
	public static void NDKOFHCBNKH(List<APINAHJGOBF> KBAAPPGBGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8307BF0", Offset = "0x83065F0", VA = "0x188307BF0")]
	public static PKHGEDPOIHB AKDCJLPKEHB(List<APINAHJGOBF> KBAAPPGBGLO, List<HPBHBMMEHME> IDCMDCGLAJC, List<HPBHBMMEHME> FCELBJDIEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8307EB0", Offset = "0x83068B0", VA = "0x188307EB0")]
	public PKHGEDPOIHB AKDCJLPKEHB(List<APINAHJGOBF> KBAAPPGBGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x830DF80", Offset = "0x830C980", VA = "0x18830DF80")]
	private LCOHCCBKPLJ LAIBGCFAJLG(List<APINAHJGOBF> KBAAPPGBGLO, int ODNGOEPLNNM, bool ILCFNBPOEIB, BOBIFDGCLIG LBOHPGJILDA, bool LJJNDPOIMDK, HNEMICNHGFC FCCLOGLCHNC, Material DJPAPGPCBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x83127A0", Offset = "0x83111A0", VA = "0x1883127A0", Slot = "28")]
	public void SetBodyProperty(AJEJOKPMFDJ KEGEFGDLPMG, float KMAFNKGMDCF, bool FALKKBAOPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8312D50", Offset = "0x8311750", VA = "0x188312D50", Slot = "30")]
	public void SetFaceProperty(KPABGEBMFHP BEDDMIIBLAD, float KMAFNKGMDCF, bool FEHNDKLGLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8312EF0", Offset = "0x83118F0", VA = "0x188312EF0", Slot = "31")]
	public void SetNoseProperty(KFBADBLPJDD LOKOOJAOCIA, float KMAFNKGMDCF, bool LBPHAFGGGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8308100", Offset = "0x8306B00", VA = "0x188308100", Slot = "29")]
	public void ApplyBodyProperties(bool ACMMFCACMKN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8308160", Offset = "0x8306B60", VA = "0x188308160", Slot = "32")]
	public void ApplyFaceProperties(bool ACMMFCACMKN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8308220", Offset = "0x8306C20", VA = "0x188308220", Slot = "33")]
	public void ApplyNoseProperties(bool ACMMFCACMKN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x830C430", Offset = "0x830AE30", VA = "0x18830C430")]
	private void HHHBEIELBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8308B40", Offset = "0x8307540", VA = "0x188308B40")]
	private void CGCNFCGKEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8308800", Offset = "0x8307200", VA = "0x188308800")]
	private void BMEKGJNFILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8312E30", Offset = "0x8311830", VA = "0x188312E30", Slot = "26")]
	public void SetFaceShape(AvatarFaceShape ACPFNMCKDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8312880", Offset = "0x8311280", VA = "0x188312880", Slot = "27")]
	public void SetBodyShape(AvatarBodyShape LFOIALMAMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8312FE0", Offset = "0x83119E0", VA = "0x188312FE0", Slot = "34")]
	public void SetNoseType(EJOAHECBEFE PMEKGOFHJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x83135D0", Offset = "0x8311FD0", VA = "0x1883135D0", Slot = "36")]
	public void UpdateFaceAndBodyShapes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8314800", Offset = "0x8313200", VA = "0x188314800", Slot = "42")]
	public void UpdateNoseShape()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8312D40", Offset = "0x8311740", VA = "0x188312D40", Slot = "35")]
	public void SetDeformation(bool HALHMGCGANJ, bool JPJJENGEKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x830B970", Offset = "0x830A370", VA = "0x18830B970")]
	private void GIGODDNKHPF(SkinnedMeshRenderer BAFFEHPDJDC, int ODNGOEPLNNM, Mesh KGGOMLADPBD, List<Material> CKIINIHDKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x830CC40", Offset = "0x830B640", VA = "0x18830CC40")]
	public static Material IFMIHHOOGBL(Dictionary<FCOONAJGFPJ, Material> PFNGHAJKEOB, Material EDODCBPBNFL, KNJLBNMOIIP OFNIKDNNMDM, KMKLIECDFMI PPDKOPMNDPA, EHMKAKBCPJB GDCGOHLFNLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8310120", Offset = "0x830EB20", VA = "0x188310120")]
	public static KNJLBNMOIIP MKDNMOEAIEK(APINAHJGOBF EKILGADNPDE, int KBLLLLMLGLD)
	{
		return default(KNJLBNMOIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x830C5D0", Offset = "0x830AFD0", VA = "0x18830C5D0")]
	private void HKGBGMACECG(int EMJCACMKDGG, Material PJPBFBIEGMK, APINAHJGOBF EKILGADNPDE, [Out] Texture2D LJCBJDPGNOG, [Out] Vector4 EPNLKLGLFLC, [Out] Texture2D GNMCNPOAFHD, [Out] Texture2D MDMCNOKPCGB, [Out] Texture2D IBBDDDPJHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x83075E0", Offset = "0x8305FE0", VA = "0x1883075E0")]
	private void AFJDEMEDADI(int EMJCACMKDGG, Material PJPBFBIEGMK, APINAHJGOBF EKILGADNPDE, [Out] Color HHBPGHCDJAA, [Out] Color MCIKBOBAKNJ, [Out] Color OCJBDEBIGDC, [Out] Color EHPMHONAGDG, [Out] Color BCDFNBEMEEH, [Out] Color IJPMBIPOAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x83088E0", Offset = "0x83072E0", VA = "0x1883088E0")]
	private bool CCHCCJAPDFD(Material PJPBFBIEGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x830BBC0", Offset = "0x830A5C0", VA = "0x18830BBC0")]
	private static Material GMMAPOPDDAD(int EMJCACMKDGG, HPBCMJEABFP EKILGADNPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x830B680", Offset = "0x830A080", VA = "0x18830B680")]
	public static KMKLIECDFMI FNAFFGGHPFO(APINAHJGOBF EKILGADNPDE, int KBLLLLMLGLD)
	{
		return default(KMKLIECDFMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8310240", Offset = "0x830EC40", VA = "0x188310240")]
	private static void MMLHBLDLAML(Dictionary<string, List<FCOONAJGFPJ>> HJAOHCJPEIK, APINAHJGOBF NCPMENBJPNL, Material EDODCBPBNFL, KNJLBNMOIIP EKICIBMPDIG, KMKLIECDFMI CANAAJFPLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8311D80", Offset = "0x8310780", VA = "0x188311D80")]
	public static SkinnedMeshRenderer PFCFCIMNEOI(Transform NEDMGEIDNLM, Transform IKELFCCIJGE, SkinnedMeshRenderer[] LAHKKEOEOAI, int ODNGOEPLNNM, BOBIFDGCLIG LBOHPGJILDA, bool ILCFNBPOEIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8314B50", Offset = "0x8313550", VA = "0x188314B50")]
	public AGIJPMGLDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x830D060", Offset = "0x830BA60", VA = "0x18830D060")]
	public void Initialize([In] JGEMDOMHFFG HJDEICKIDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x830F670", Offset = "0x830E070", VA = "0x18830F670")]
	public void Setup([In] GHDGLCJFLIP NKFALPOKBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8310220", Offset = "0x830EC20", VA = "0x188310220", Slot = "6")]
	public void SetManualLOD(int ODNGOEPLNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8312FF0", Offset = "0x83119F0", VA = "0x188312FF0", Slot = "11")]
	public void SetTexture(EBGJOHEHHCE CANAAJFPLON, Texture2D JBOOEIGKOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
	public static bool HPNDIKKJENL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8308280", Offset = "0x8306C80", VA = "0x188308280", Slot = "12")]
	public bool AreMeshesBuilt()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8312940", Offset = "0x8311340", VA = "0x188312940", Slot = "10")]
	public void SetColor(KPPHMPNEPHC EKICIBMPDIG, Color? EOGEFFOIIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x830AF60", Offset = "0x8309960", VA = "0x18830AF60")]
	private void EHFOMHFNKFJ(Action LGKEKGMOEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8313210", Offset = "0x8311C10", VA = "0x188313210", Slot = "7")]
	public void SetUgcItemVisualOverrides(MOJNGFFGLIG FLMDINIBFPL, Texture CLJFNGGDKOH, Color KPAACMKLCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x830CB40", Offset = "0x830B540", VA = "0x18830CB40", Slot = "8")]
	public void SetWaitForUgcTextureLoads(bool DIFBPHDJJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xB3AB60", Offset = "0xB39560", VA = "0x180B3AB60", Slot = "9")]
	public void SetUgcTextureParameters(JLDDJMHEPLP PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8313280", Offset = "0x8311C80", VA = "0x188313280", Slot = "17")]
	public void Teardown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x83081C0", Offset = "0x8306BC0", VA = "0x1883081C0", Slot = "37")]
	public void ApplyHatAdjustments()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x83139B0", Offset = "0x83123B0", VA = "0x1883139B0", Slot = "38")]
	public void UpdateHatPivot([Optional] AFKHHJFHFCH AJCEKGACABD, [Optional] bool? HHLDPIMOPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x830ACB0", Offset = "0x83096B0", VA = "0x18830ACB0")]
	private bool DOMOMIGPGFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8312780", Offset = "0x8311180", VA = "0x188312780", Slot = "22")]
	public bool SetBaseSkinCullingMask(HLHFIFHEPCK.LFIDLNGOLDF HDNBENONCKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8313470", Offset = "0x8311E70", VA = "0x188313470", Slot = "40")]
	public void UpdateEmissiveEffect(float CAGAFLPJDAC, Color EOGEFFOIIOP, bool MEDCIFFHKLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x830DAF0", Offset = "0x830C4F0", VA = "0x18830DAF0")]
	public void KEFFEBEGBKI(float CAGAFLPJDAC, Color EOGEFFOIIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x830BAD0", Offset = "0x830A4D0", VA = "0x18830BAD0")]
	private static bool GKOKKIMNDPL(Material DJPAPGPCBDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8314950", Offset = "0x8313350", VA = "0x188314950", Slot = "41")]
	public void UpdateTextureEffect(AFFAAMCHLIA BIHACCKPAOO, FDNICDIHCGG FLKBHNICNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x830F650", Offset = "0x830E050", VA = "0x18830F650")]
	private static bool LKLEKCDAEEE(FCOONAJGFPJ HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8311350", Offset = "0x830FD50", VA = "0x188311350")]
	public void NFOEALFHCPK(AFFAAMCHLIA MKEIPFMKCMA, FDNICDIHCGG LHEECCHHDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x830CA10", Offset = "0x830B410", VA = "0x18830CA10", Slot = "39")]
	public void HideAvatarMeshes(bool HALBENDLPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x830F320", Offset = "0x830DD20", VA = "0x18830F320")]
	private void LFIAPNAPBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x830DEA0", Offset = "0x830C8A0", VA = "0x18830DEA0")]
	private void KOHLKFPDMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x32D69E0", Offset = "0x32D53E0", VA = "0x1832D69E0")]
	public static void IEABMELMIEO<T>(Dictionary<T, Material> PFNGHAJKEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x830F780", Offset = "0x830E180", VA = "0x18830F780")]
	private static void MCLBBJCCPBO(Dictionary<Renderer, HNEMICNHGFC> MBIBIKLMPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x830AA20", Offset = "0x8309420", VA = "0x18830AA20")]
	public static void CPNAFIKJJHL(SkinnedMeshRenderer[] LAHKKEOEOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8311B10", Offset = "0x8310510", VA = "0x188311B10")]
	public static void OLJHFLDFHMP(SkinnedMeshRenderer DDEOMDPNNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x830BC80", Offset = "0x830A680", VA = "0x18830BC80")]
	public static void HEHFHDOAHLJ(List<HPBHBMMEHME> HCLKNHFPLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8310690", Offset = "0x830F090", VA = "0x188310690")]
	private void NAIBJBPOAIN(Dictionary<string, AACADPLMCLK<Texture2D>> HJAOHCJPEIK, bool GEHFOLBAIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x830D010", Offset = "0x830BA10", VA = "0x18830D010")]
	private void IMOCGBBFALC(Dictionary<string, List<FCOONAJGFPJ>> HJAOHCJPEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8311570", Offset = "0x830FF70", VA = "0x188311570")]
	private void NLMPEPJGGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x830CE80", Offset = "0x830B880", VA = "0x18830CE80")]
	private void IMILJHLEPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x830BE50", Offset = "0x830A850", VA = "0x18830BE50")]
	private void HFNLAICCBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x830F250", Offset = "0x830DC50", VA = "0x18830F250")]
	private void LCKGJFCMNHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8307530", Offset = "0x8305F30", VA = "0x188307530")]
	private void AAFPHJBMAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8308540", Offset = "0x8306F40", VA = "0x188308540")]
	private void BFEKEFGAJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x830ABB0", Offset = "0x83095B0", VA = "0x18830ABB0")]
	private void DIOLDDDDFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8308430", Offset = "0x8306E30", VA = "0x188308430")]
	private void BCLOIMBJCDP(bool GCCPEBFFFEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8312630", Offset = "0x8311030", VA = "0x188312630")]
	private void PJKFEPAOHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8310C30", Offset = "0x830F630", VA = "0x188310C30")]
	private void NBIFJOPKJNN(bool GCCPEBFFFEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x830F8D0", Offset = "0x830E2D0", VA = "0x18830F8D0")]
	private void MGJEOFNPFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x830FC20", Offset = "0x830E620", VA = "0x18830FC20")]
	private void MJFGBFHNNOP(Material DJPAPGPCBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x830B760", Offset = "0x830A160", VA = "0x18830B760")]
	private void GBGNGOKBAGK(Material DJPAPGPCBDH, Color EJCHMIHNPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x83118C0", Offset = "0x83102C0", VA = "0x1883118C0")]
	private void OKCIBIANGOF(Material DJPAPGPCBDH, Color EJCHMIHNPKJ, Color GJEBBPLEFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8311BB0", Offset = "0x83105B0", VA = "0x188311BB0")]
	private void OPKOGHDBNLN(Material DJPAPGPCBDH, Color HHBPGHCDJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8312440", Offset = "0x8310E40", VA = "0x188312440")]
	private void PIBPHLGOEDF(Material DJPAPGPCBDH, Texture2D JBOOEIGKOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x830ADF0", Offset = "0x83097F0", VA = "0x18830ADF0")]
	private void EAAKAKNBNKN(Material DJPAPGPCBDH, Texture EBAHBEEIEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x830F4F0", Offset = "0x830DEF0", VA = "0x18830F4F0")]
	private void LIBGNIGEMNH(Action<HNEMICNHGFC> FOBJABDHGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8310510", Offset = "0x830EF10", VA = "0x188310510")]
	private void MPGJKAJPNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8310810", Offset = "0x830F210", VA = "0x188310810")]
	private void NBBFMMLEELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8311FB0", Offset = "0x83109B0", VA = "0x188311FB0")]
	private void PGKAMHDIKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x830AFE0", Offset = "0x83099E0", VA = "0x18830AFE0")]
	public void EMNDLCOGJKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8312770", Offset = "0x8311170", VA = "0x188312770", Slot = "4")]
	private void PMOABHMJMKH([In] JGEMDOMHFFG HJDEICKIDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x830F670", Offset = "0x830E070", VA = "0x18830F670", Slot = "5")]
	private void LOJGOLKCGKB([In] GHDGLCJFLIP NKFALPOKBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x830AB70", Offset = "0x8309570", VA = "0x18830AB70")]
	[CompilerGenerated]
	private CNBBKAECPOB DAAADKJNCEM(APINAHJGOBF BNAMGIMJGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8312380", Offset = "0x8310D80", VA = "0x188312380")]
	[CompilerGenerated]
	private void PGOAPGHMEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8312410", Offset = "0x8310E10", VA = "0x188312410")]
	[CompilerGenerated]
	private void PHOFJPPOLAF(HNEMICNHGFC GGJEMPPBOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x830C540", Offset = "0x830AF40", VA = "0x18830C540")]
	[CompilerGenerated]
	private void HJFFBCPAADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x830AC90", Offset = "0x8309690", VA = "0x18830AC90")]
	[CompilerGenerated]
	private void DOIJLCMAGJA(HNEMICNHGFC GGJEMPPBOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x830B8E0", Offset = "0x830A2E0", VA = "0x18830B8E0")]
	[CompilerGenerated]
	private void GGEFHKKFFHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x83075C0", Offset = "0x8305FC0", VA = "0x1883075C0")]
	[CompilerGenerated]
	private void AENPKHDPNJP(HNEMICNHGFC GGJEMPPBOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x830DEF0", Offset = "0x830C8F0", VA = "0x18830DEF0")]
	[CompilerGenerated]
	private void LACOPOFPGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x83117B0", Offset = "0x83101B0", VA = "0x1883117B0")]
	[CompilerGenerated]
	private void OGNLEMIFECP(HNEMICNHGFC GGJEMPPBOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x830DA60", Offset = "0x830C460", VA = "0x18830DA60")]
	[CompilerGenerated]
	private void JODLEKHNDIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8308510", Offset = "0x8306F10", VA = "0x188308510")]
	[CompilerGenerated]
	private void BDIAOMFBGAJ(HNEMICNHGFC GGJEMPPBOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x830C4B0", Offset = "0x830AEB0", VA = "0x18830C4B0")]
	[CompilerGenerated]
	private void HIGIGKMNANB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x830BC50", Offset = "0x830A650", VA = "0x18830BC50")]
	[CompilerGenerated]
	private void GNJNBDKMFGJ(HNEMICNHGFC GGJEMPPBOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8308690", Offset = "0x8307090", VA = "0x188308690")]
	[CompilerGenerated]
	private void BJGEELICGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x830FBF0", Offset = "0x830E5F0", VA = "0x18830FBF0")]
	[CompilerGenerated]
	private void MGMCCODALFA(HNEMICNHGFC GGJEMPPBOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x830F700", Offset = "0x830E100", VA = "0x18830F700")]
	[CompilerGenerated]
	private void MCBLCCDKKBO(KeyValuePair<string, AACADPLMCLK<Texture2D>> IFHPIFMHEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x830DE90", Offset = "0x830C890", VA = "0x18830DE90")]
	[CompilerGenerated]
	private void KJDHOPBDHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8311D50", Offset = "0x8310750", VA = "0x188311D50")]
	[CompilerGenerated]
	private void PANKOCNOBKH(HNEMICNHGFC GGJEMPPBOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x830BAC0", Offset = "0x830A4C0", VA = "0x18830BAC0")]
	[CompilerGenerated]
	private void GJIODJGGENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8308400", Offset = "0x8306E00", VA = "0x188308400")]
	[CompilerGenerated]
	private void BAKKDBKPPMM(HNEMICNHGFC GGJEMPPBOGN)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarElbowBendHelperController : MonoBehaviour, HPCJFNFELMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Vector3? BJLACNHMLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private bool BHCELNIGEAJ;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x83217D0", Offset = "0x83201D0", VA = "0x1883217D0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8321E00", Offset = "0x8320800", VA = "0x188321E00", Slot = "4")]
		public void UpdateController(float LHPALOIPBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xDD3F80", Offset = "0xDD2980", VA = "0x180DD3F80", Slot = "6")]
		public void SetEnabled(bool KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x83218B0", Offset = "0x83202B0", VA = "0x1883218B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8322220", Offset = "0x8320C20", VA = "0x188322220")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarElbowBendTargetController : MonoBehaviour, HPCJFNFELMP
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private const float FODGKDLGFNH = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Vector3 GLCFFGOLKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Vector3 ADDOGLMKKKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private bool BHCELNIGEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private float BBKPOMPONEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private float FEAJHHLEGOL;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x83225A0", Offset = "0x8320FA0", VA = "0x1883225A0", Slot = "4")]
		public void UpdateController(float LHPALOIPBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1050500", Offset = "0x104EF00", VA = "0x181050500", Slot = "6")]
		public void SetEnabled(bool KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x83222C0", Offset = "0x8320CC0", VA = "0x1883222C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8323060", Offset = "0x8321A60", VA = "0x188323060")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class APLMPEOAAHJ : NOCNHILIHGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static readonly int GIIKPDNGNCL;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static readonly int NEMNEHCDNNG;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static readonly int JEOKOLCJKKH;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static readonly int GKOIDFNKEPH;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly int CHBGAMGCGOB;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly int CBKJIJMCNKH;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly int MLHGONFCIJB;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly int NINCAGDOCKM;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly int BCGDJINHOKN;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly int IFCEONLKHEI;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly int DJNHNKNHCBE;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly int OKMAGJKFKMJ;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly int CILECLHLCEG;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly int EOGNAKBMLFB;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static readonly int BKFNAPGFMKK;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static readonly int AGCNALPBLEL;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static readonly int JLIGJKJKLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private Transform OJNJDGFEPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private Transform NFKHIMHGEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private Transform LKHEEDJBCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private Transform HNIJMJAHLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private Transform EFJGJKDJJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private Transform ANFCOGJJPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private IMLJIOJOHKL LOPPEBOEGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private Material OFPLAOFHPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private SkinnedMeshRenderer[] MBBEGKKLJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly List<Material> JACOJKLEEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NKBMEBEPJID GIGKJAIFJHK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EBDGCEEEFPM HNIAMMNAMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private NKBMEBEPJID KLCABPMOOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8320880", Offset = "0x831F280", VA = "0x188320880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool FHLCJJBHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8320680", Offset = "0x831F080", VA = "0x188320680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x83207D0", Offset = "0x831F1D0", VA = "0x1883207D0")]
	public void GFALNPPLGKO([In] IMLJIOJOHKL MPECFJMFHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8320D00", Offset = "0x831F700", VA = "0x188320D00")]
	public void LIOLDLHGPDJ([In] FOMDALKDNBC NKAOIPCLIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8320E10", Offset = "0x831F810", VA = "0x188320E10", Slot = "6")]
	public void NDHPMPBIAEI(BJBOKDHNHHN EIILEJHCMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8320DB0", Offset = "0x831F7B0", VA = "0x188320DB0")]
	private Vector2 MJKPKHDKNOL(Vector2 LBHEENAGKNI)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x831F710", Offset = "0x831E110", VA = "0x18831F710")]
	public void CIPOGAMELLO([In] EJBCBDCKDOK NKAOIPCLIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x831F340", Offset = "0x831DD40", VA = "0x18831F340")]
	private void ABJHNONNDCN(ENDPMHNKEKC KPJMGIFJLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x8320900", Offset = "0x831F300", VA = "0x188320900")]
	private void IPKFGMKBEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x8320610", Offset = "0x831F010", VA = "0x188320610")]
	private void LILGBDCIJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8320610", Offset = "0x831F010", VA = "0x188320610", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8321690", Offset = "0x8320090", VA = "0x188321690")]
	public APLMPEOAAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x8320D00", Offset = "0x831F700", VA = "0x188320D00", Slot = "5")]
	private void KDLJOCIONJP([In] FOMDALKDNBC NKAOIPCLIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8320DA0", Offset = "0x831F7A0", VA = "0x188320DA0", Slot = "7")]
	private void LGIGFJPEIFN([In] EJBCBDCKDOK NKAOIPCLIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8320600", Offset = "0x831F000", VA = "0x188320600")]
	[CompilerGenerated]
	internal static float COIIMDOOOAA(float KMAFNKGMDCF, float DEDMEALJJPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8320C10", Offset = "0x831F610", VA = "0x188320C10")]
	[CompilerGenerated]
	internal static void JCEKKOOFLBM(Vector2 BLJMDNLILHJ, Vector2 CMGJLHFMHOA, Vector2 BCAJFCGHDKI, Vector2 EPMJNJEPCMJ, Vector2 JOEBEKPOHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8321340", Offset = "0x831FD40", VA = "0x188321340")]
	[CompilerGenerated]
	internal static Vector4 ONOGDFKJKDE(Vector2 KFJFDPLEJOD, Vector2 NIAMAMNMMFM)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarForearmRollController : MonoBehaviour, HPCJFNFELMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private float BBKPOMPONEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private bool BHCELNIGEAJ;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8323090", Offset = "0x8321A90", VA = "0x188323090", Slot = "4")]
		public void UpdateController(float LHPALOIPBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x18D8440", Offset = "0x18D6E40", VA = "0x1818D8440", Slot = "6")]
		public void SetEnabled(bool KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8323900", Offset = "0x8322300", VA = "0x188323900")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x83239A0", Offset = "0x83223A0", VA = "0x1883239A0")]
		public void LHEJPJMHOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8323930", Offset = "0x8322330", VA = "0x188323930")]
		public int DJEGJDAKFBG(int KDKPJJBFLOC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OPLBHNJBLLG : DNEFDPFOOPH
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x83333B0", Offset = "0x8331DB0", VA = "0x1883333B0", Slot = "24")]
	public override float FMGGFHFJDNC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8333400", Offset = "0x8331E00", VA = "0x188333400")]
	public OPLBHNJBLLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class DNEFDPFOOPH : KHMNFMMABMJ
{
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static int GMFAFFDEGHI;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static int DMGPEKPBEPK;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static int ICMGNIAKJAM;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static int DLDOFMCNAFB;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static int HFGHBEHGBAL;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static int JJFFJPACACE;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private static int JLJGHBCBOOK;

	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static int[] EFHMKGIHCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private AIKJMOJDBBG LOPPEBOEGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private IOCHIHGNBHC LBNNFADOOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int DMBOICPDACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private float LNCJCPDBBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	protected Animator LLKALGJKEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	protected AvatarConfiguration CBAMIGLJGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	protected int MFACCABEKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private int CIPIPFGKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private int NMMHFMNABDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private bool AHFEIOIHIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private KLBMAHPKMOD FGNADPOEBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private int OIIGDNACDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private float FPABAHAEEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private AvatarHandDisplaySettings PDIKKCDPJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private BOIFAILEJMF HLPJILJDGIO;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Transform LJBIBCFNJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Vector3 LPJCJANGBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x19EEBD0", Offset = "0x19ED5D0", VA = "0x1819EEBD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x19EEBF0", Offset = "0x19ED5F0", VA = "0x1819EEBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Quaternion OLFKDKLCDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xECFB90", Offset = "0xECE590", VA = "0x180ECFB90")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x10D0D90", Offset = "0x10CF790", VA = "0x1810D0D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PAAAIMKAFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8328030", Offset = "0x8326A30", VA = "0x188328030")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8327C90", Offset = "0x8326690", VA = "0x188327C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool PPKOKPHNMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xB2F830", Offset = "0xB2E230", VA = "0x180B2F830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Vector3 FIDKCMFBALG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xADAE70", Offset = "0xAD9870", VA = "0x180ADAE70", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xAD9D60", Offset = "0xAD8760", VA = "0x180AD9D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Quaternion MKBKJDEBJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x12CD660", Offset = "0x12CC060", VA = "0x1812CD660", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1770220", Offset = "0x176EC20", VA = "0x181770220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DBPOEHMBPJL IFJGJHCMCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB68B60", Offset = "0xB67560", VA = "0x180B68B60", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(DBPOEHMBPJL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xB68A10", Offset = "0xB67410", VA = "0x180B68A10", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DBPOEHMBPJL FLMDJCIBJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xB68B50", Offset = "0xB67550", VA = "0x180B68B50", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(DBPOEHMBPJL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xB68230", Offset = "0xB66C30", VA = "0x180B68230", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public float JDLGGDPBOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xC35990", Offset = "0xC34390", VA = "0x180C35990", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x10E84B0", Offset = "0x10E6EB0", VA = "0x1810E84B0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool EIKJPCBLKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8328020", Offset = "0x8326A20", VA = "0x188328020", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8327A50", Offset = "0x8326450", VA = "0x188327A50", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool HLDEHBGEBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x83276D0", Offset = "0x83260D0", VA = "0x1883276D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool HOOAIFHMCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8328010", Offset = "0x8326A10", VA = "0x188328010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool BAJKIJNNJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8328060", Offset = "0x8326A60", VA = "0x188328060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HIMLIMBNKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8328070", Offset = "0x8326A70", VA = "0x188328070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8327AF0", Offset = "0x83264F0", VA = "0x188327AF0", Slot = "23")]
	public void GFALNPPLGKO(AIKJMOJDBBG MPECFJMFHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8327FC0", Offset = "0x83269C0", VA = "0x188327FC0")]
	public void KFHFMKJJEBK(IOCHIHGNBHC IJIPKLDDBOI, AvatarHandDisplaySettings ANGOOFAAJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8327CC0", Offset = "0x83266C0", VA = "0x188327CC0", Slot = "14")]
	public void HKDKLEABILK(bool FCCCGLOCDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x83276E0", Offset = "0x83260E0", VA = "0x1883276E0", Slot = "13")]
	public void BKCNMPFFBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xC35990", Offset = "0xC34390", VA = "0x180C35990", Slot = "24")]
	public virtual float FMGGFHFJDNC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8327540", Offset = "0x8325F40", VA = "0x188327540")]
	private int AHNKPPAGNMA(DBPOEHMBPJL DFHCGPLHBLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8327DD0", Offset = "0x83267D0", VA = "0x188327DD0")]
	private void JMALDBENNNF(int PBGLKDBEABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8327DB0", Offset = "0x83267B0", VA = "0x188327DB0", Slot = "15")]
	public bool JLNIKCDCBID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8327DA0", Offset = "0x83267A0", VA = "0x188327DA0", Slot = "16")]
	public bool IKJPMELDNNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8327D50", Offset = "0x8326750", VA = "0x188327D50")]
	private DBPOEHMBPJL IINMOIMEBFE()
	{
		return default(DBPOEHMBPJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1F85BB0", Offset = "0x1F845B0", VA = "0x181F85BB0", Slot = "17")]
	public void GPBOECELFHE(bool FCCCGLOCDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8327A60", Offset = "0x8326460", VA = "0x188327A60", Slot = "12")]
	public void DONCDIGLDKH(int PBGLKDBEABL, float FNFLPPCMCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8327F90", Offset = "0x8326990", VA = "0x188327F90", Slot = "10")]
	public void KEENJGGGINH(KLBMAHPKMOD IMNBLKDCAKA, bool JNNEMJKMKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8327FB0", Offset = "0x83269B0", VA = "0x188327FB0", Slot = "11")]
	public void KEFEHDFCFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8327AA0", Offset = "0x83264A0", VA = "0x188327AA0", Slot = "18")]
	public void GBGBNPFDLFN(Transform AEMEEJKFKNN, Vector3 EFCINLKKPIC, Quaternion BAPJENGMKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8328350", Offset = "0x8326D50", VA = "0x188328350")]
	public DNEFDPFOOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class HPBCMJEABFP : APINAHJGOBF
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FOFEOPAIPAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public HPBCMJEABFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public List<HPBHBMMEHME> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public List<HPBHBMMEHME> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AACADPLMCLK<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AACADPLMCLK<GFJOMPDGOLA> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FOFEOPAIPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x832B2D0", Offset = "0x8329CD0", VA = "0x18832B2D0")]
		internal CNBBKAECPOB EIFGPIIPEFM(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public MOJNGFFGLIG PPGJGNANOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public GFJOMPDGOLA LKDLOOCBPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private AACADPLMCLK<GFJOMPDGOLA> KFLFBIMAPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private AACADPLMCLK<Material[]> HENLBHALEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public Material[] DAJPBHHBKFJ;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool AFKJCNBJKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xB041D0", Offset = "0xB02BD0", VA = "0x180B041D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xB04860", Offset = "0xB03260", VA = "0x180B04860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public HLHFIFHEPCK.LFIDLNGOLDF DCGCPKOHJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return default(HLHFIFHEPCK.LFIDLNGOLDF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xFEB710", Offset = "0xFEA110", VA = "0x180FEB710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x83302D0", Offset = "0x832ECD0", VA = "0x1883302D0")]
	public HPBCMJEABFP(LMLHDPNCKKH LJNAHBMJLHD, MOJNGFFGLIG CMDJIHOCGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x832F220", Offset = "0x832DC20", VA = "0x18832F220", Slot = "6")]
	public override CNBBKAECPOB CIKNKNBLMAF(List<HPBHBMMEHME> OOMLMKHHJDO, List<HPBHBMMEHME> IFNIBLPFKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x832EF20", Offset = "0x832D920", VA = "0x18832EF20")]
	public CNBBKAECPOB BANMJNCHBOI(List<HPBHBMMEHME> OOMLMKHHJDO, List<HPBHBMMEHME> IFNIBLPFKHK, AACADPLMCLK<Material[]> HENLBHALEOL, [Optional] AACADPLMCLK<GFJOMPDGOLA> DDJDPGIEHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x832F8D0", Offset = "0x832E2D0", VA = "0x18832F8D0")]
	public (AACADPLMCLK<Material[]>, AACADPLMCLK<GFJOMPDGOLA>) HFMJNNOFFNF(List<HPBHBMMEHME> OOMLMKHHJDO, List<HPBHBMMEHME> IFNIBLPFKHK)
	{
		return default((AACADPLMCLK<Material[]>, AACADPLMCLK<GFJOMPDGOLA>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x832F6D0", Offset = "0x832E0D0", VA = "0x18832F6D0", Slot = "7")]
	public override FFGDOHJPCCP ENKKFJHDHBG(uint ODNGOEPLNNM, AvatarSkinnedMeshBoneOrderRemapsData MFHAMCLBKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x832FC40", Offset = "0x832E640", VA = "0x18832FC40")]
	public FFGDOHJPCCP KONLINFANKK(GameObject FLIHICBMLPK, uint ODNGOEPLNNM, bool EFGFLGOOIKF, bool KLKJGNIGHNE, AvatarSkinnedMeshBoneOrderRemapsData MFHAMCLBKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x832FE50", Offset = "0x832E850", VA = "0x18832FE50")]
	public static bool LMMBIKEGPLL(Renderer[] LAHKKEOEOAI, string NAOFFDOMMCK, [Out] Renderer OPPOIKFEHFO, [Out] Renderer KNABKJFDBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8330280", Offset = "0x832EC80", VA = "0x188330280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x83301C0", Offset = "0x832EBC0", VA = "0x1883301C0")]
	private (AACADPLMCLK<GFJOMPDGOLA>, AACADPLMCLK<Material[]>) MIEINEHFCPP()
	{
		return default((AACADPLMCLK<GFJOMPDGOLA>, AACADPLMCLK<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x832EF00", Offset = "0x832D900", VA = "0x18832EF00")]
	[CompilerGenerated]
	private void AALHBFHGMJF(GFJOMPDGOLA GGIKEMCHAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0xAB4820", Offset = "0xAB3220", VA = "0x180AB4820")]
	[CompilerGenerated]
	private void MCGCAKBMHNK(Material[] GGIKEMCHAAA)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class AvatarKneeBendTargetController : MonoBehaviour, HPCJFNFELMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Vector3 GLCFFGOLKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Vector3 GGKICFPDADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Vector3 GBAJMHKCBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private Matrix4x4 INDNBJHEIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private bool BHCELNIGEAJ;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8323F30", Offset = "0x8322930", VA = "0x188323F30", Slot = "4")]
		public void UpdateController(float LHPALOIPBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8323F20", Offset = "0x8322920", VA = "0x188323F20", Slot = "6")]
		public void SetEnabled(bool KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8323AC0", Offset = "0x83224C0", VA = "0x188323AC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x83245F0", Offset = "0x8322FF0", VA = "0x1883245F0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[LDDMKMABCFO]
public struct IHCJBLOEGJG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	[ReadOnly]
	public FIPHKOCGMNL HONCCLOHNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	[ReadOnly]
	public int DFHKGKGFNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public CKPMNKCIFOL BMPNHNJGJCH;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8330800", Offset = "0x832F200", VA = "0x188330800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[NativeContainer]
[LDDMKMABCFO]
public struct CKPMNKCIFOL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<Vector3> KHNGGHMDDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeArray<Vector3> DOPNICCPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeArray<Vector4> KEIDKJECCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeArray<Vector2> OAIMFEAFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeArray<Vector2> PGFIIPCFHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeArray<Vector2> FONAINCBCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeArray<Vector2> MGCEFHBFOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeArray<Color> PMGDAAKKEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<int> GBLKPFDPOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeArray<int> HOJIGFMFFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private NativeArray<int> BLLNLKLFEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private NativeArray<int> MPMCCCAALDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeArray<int> OBDBPLIFLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeArray<int> OMGOIKPNHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeArray<int> EFBBCPNGDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeArray<BoneWeight> PLDENFMOGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private NativeArray<int> PDCLAJMPOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private bool MDJGPDAKFFD;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int GKKHECINGBD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8326BE0", Offset = "0x83255E0", VA = "0x188326BE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x83266A0", Offset = "0x83250A0", VA = "0x1883266A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int BKIKGDLDPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8326D10", Offset = "0x8325710", VA = "0x188326D10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8326E80", Offset = "0x8325880", VA = "0x188326E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int DMFPAEFFFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8326E70", Offset = "0x8325870", VA = "0x188326E70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8326690", Offset = "0x8325090", VA = "0x188326690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x83270E0", Offset = "0x8325AE0", VA = "0x1883270E0")]
	public CKPMNKCIFOL(int EHCMPHBOHMC, int COCDKCIIDED, int MFCCCNMHBNM, int HPAPCCFJNDA, Allocator EIOOMONCLID, int AJJGJOLGNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8326E00", Offset = "0x8325800", VA = "0x188326E00")]
	public void MAMNEIKOFFD(int KABGMIEBEFC, Vector3 FEBGNHCBECK, Vector3 AFDFHFKFCKE, Vector4 GGMLEPFJHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8326E90", Offset = "0x8325890", VA = "0x188326E90")]
	public void PGBIBBLPLLF(int KABGMIEBEFC, BoneWeight DLDHAEIEMAE, NativeSlice<byte> ELONOALJKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8326BF0", Offset = "0x83255F0", VA = "0x188326BF0")]
	public Color GPLOMMFCMIG(int KABGMIEBEFC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8326A00", Offset = "0x8325400", VA = "0x188326A00")]
	public void DIMLBIDOHMD(int KABGMIEBEFC, Color DMCCCPMAFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8326D20", Offset = "0x8325720", VA = "0x188326D20")]
	public void INCDLKLNCDB(byte LAGPHBENBMG, int KABGMIEBEFC, Vector2 GJKOLNHMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8326BD0", Offset = "0x83255D0", VA = "0x188326BD0")]
	public void FLLJEJICAFM(int KABGMIEBEFC, int JLGGDBMNAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8326C10", Offset = "0x8325610", VA = "0x188326C10")]
	public bool HEKALOFHECJ(int LAGPHBENBMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8326C40", Offset = "0x8325640", VA = "0x188326C40")]
	public void HEOBEKJHMEH(int IPMHCEACDJA, int JBCPGNDLJHB, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8327030", Offset = "0x8325A30", VA = "0x188327030")]
	public int[] PJKNKACJLPI(int IPMHCEACDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8326D70", Offset = "0x8325770", VA = "0x188326D70")]
	private NativeSlice<int> JKENAJIDKGA(int IPMHCEACDJA)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8326A20", Offset = "0x8325420", VA = "0x188326A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x83266B0", Offset = "0x83250B0", VA = "0x1883266B0")]
	public Mesh CGBJLGFAJJM([Optional] string ABJJBLBNHAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DefaultMember("Item")]
[LDDMKMABCFO]
[NativeContainer]
public struct FIPHKOCGMNL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public NativeArray<Vector3> KHNGGHMDDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeArray<Vector3> DOPNICCPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeArray<Vector4> KEIDKJECCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public NativeArray<Vector2> OAIMFEAFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public NativeArray<Vector2> PGFIIPCFHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public NativeArray<Vector2> FONAINCBCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public NativeArray<Vector2> MGCEFHBFOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public NativeArray<Color> PMGDAAKKEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public NativeArray<int> IHDDFPGEMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<int> LBABKBLOFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public NativeArray<int> JDNCBNBDEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public NativeArray<int> IKAKCAIBJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeArray<bool> MFBKBIBKKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public NativeArray<int> JCILFKFDKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public NativeArray<int> ELNLKEOKKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public NativeArray<BoneWeight> EECFNOMGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private NativeArray<Matrix4x4> MAONPADOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private NativeArray<long> AFDGIMFPEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private NativeArray<byte> DJNIHEOPILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private NativeArray<int> FHNJEIAJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private NativeArray<int> EOELDEHJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public NativeArray<sbyte> MIHBEINGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public NativeArray<byte> ACNJFOLIOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private NativeArray<int> BNJPBJILKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private bool MDJGPDAKFFD;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int OACFJOLPMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xF91E00", Offset = "0xF90800", VA = "0x180F91E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int EMHECKNBIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xDD6D30", Offset = "0xDD5730", VA = "0x180DD6D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int BEPIODHFIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8329220", Offset = "0x8327C20", VA = "0x188329220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int JEKFFOMLIKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8329B20", Offset = "0x8328520", VA = "0x188329B20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8329B30", Offset = "0x8328530", VA = "0x188329B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int GKKHECINGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8329AF0", Offset = "0x83284F0", VA = "0x188329AF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8329200", Offset = "0x8327C00", VA = "0x188329200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int NEGEBCIBDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x83295A0", Offset = "0x8327FA0", VA = "0x1883295A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8329B10", Offset = "0x8328510", VA = "0x188329B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public EKPJNMADPCB PLIGKHPBMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8329B00", Offset = "0x8328500", VA = "0x188329B00")]
		get
		{
			return default(EKPJNMADPCB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8329210", Offset = "0x8327C10", VA = "0x188329210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public byte GMKJEOMBJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8329320", Offset = "0x8327D20", VA = "0x188329320")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x83295B0", Offset = "0x8327FB0", VA = "0x1883295B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public FEDGEFJALDF PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x83295C0", Offset = "0x8327FC0", VA = "0x1883295C0")]
		get
		{
			return default(FEDGEFJALDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8329B40", Offset = "0x8328540", VA = "0x188329B40")]
	public FIPHKOCGMNL(IList<Mesh> LLJGIONICIL, IList<Matrix4x4> NCOMDPKDFCB, IList<bool> MFBKBIBKKBL, byte HJHOJDKFBIE, IList<IReadOnlyList<byte>> IPNJKLIACME, IList<long> BFDEJCHBKEH, IList<bool> CJPNLELHDGM, IList<int> JCILFKFDKDO, IList<int> OBLFKHKFEFA, IList<int> JLFNLPNBIEB, Allocator EIOOMONCLID, EKPJNMADPCB PHEKDHCLLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x8329250", Offset = "0x8327C50", VA = "0x188329250")]
	public CKPMNKCIFOL CPPDOMEFIBA(Allocator EIOOMONCLID)
	{
		return default(CKPMNKCIFOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8329330", Offset = "0x8327D30", VA = "0x188329330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[LDDMKMABCFO]
public class GCFAFDAHNJL : MNDHAMFKPIO
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x832B580", Offset = "0x8329F80", VA = "0x18832B580")]
	public FIPHKOCGMNL PBPNNMEKIHF()
	{
		return default(FIPHKOCGMNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8318140", Offset = "0x8316B40", VA = "0x188318140")]
	public GCFAFDAHNJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct FEDGEFJALDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public NativeSlice<Vector3> KHNGGHMDDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public NativeSlice<Vector3> DOPNICCPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public NativeSlice<Vector4> KEIDKJECCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public NativeSlice<Vector2> OAIMFEAFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public NativeSlice<Vector2> PGFIIPCFHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public NativeSlice<Vector2> FONAINCBCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public NativeSlice<Vector2> MGCEFHBFOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public NativeSlice<Color> PMGDAAKKEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	public NativeSlice<int> PCGEDHHGAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public NativeSlice<int> IKAKCAIBJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	public NativeSlice<BoneWeight> EECFNOMGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public NativeSlice<byte> HHGIBLLCMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public int NGOFMAICIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public Matrix4x4 EFGNJAODGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public long COBDGJAAHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public NativeSlice<byte> ELONOALJKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public bool GODGFICPAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public int LJMHOJELONP;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct FCOONAJGFPJ : IEquatable<FCOONAJGFPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	internal readonly Material OCAHEHKLJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	internal readonly KNJLBNMOIIP PAEBAHFGCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	internal readonly KMKLIECDFMI OOIKDDDLAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	internal readonly EHMKAKBCPJB ILBGGFKMPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	internal readonly bool OGFFENGDLML;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x83290C0", Offset = "0x8327AC0", VA = "0x1883290C0")]
	public FCOONAJGFPJ(Material PJPBFBIEGMK, KNJLBNMOIIP OFNIKDNNMDM, KMKLIECDFMI PPDKOPMNDPA, EHMKAKBCPJB GDCGOHLFNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x8328E20", Offset = "0x8327820", VA = "0x188328E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8328B80", Offset = "0x8327580", VA = "0x188328B80", Slot = "4")]
	public bool Equals(FCOONAJGFPJ GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x8328C10", Offset = "0x8327610", VA = "0x188328C10", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8328D10", Offset = "0x8327710", VA = "0x188328D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, EEMBOJLPGKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[Header("Configuration")]
		[SerializeField]
		private BOIFAILEJMF avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private AssetReference torsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		private AssetReference legsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		private AssetReference torsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[SerializeField]
		private Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private ICNBFDLCIDH IALPMJAPHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private NOCNHILIHGH CPIOOIKMBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private KHMNFMMABMJ EBAHABHLKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private KHMNFMMABMJ HMMALMLIICC;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public ICNBFDLCIDH NAOGKIBLGME
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x83255D0", Offset = "0x8323FD0", VA = "0x1883255D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public NOCNHILIHGH GEIBKNDDNKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8325620", Offset = "0x8324020", VA = "0x188325620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public KHMNFMMABMJ LENENJOODFE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x8325670", Offset = "0x8324070", VA = "0x188325670", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public KHMNFMMABMJ NGILENECMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x83256C0", Offset = "0x83240C0", VA = "0x1883256C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public Transform ONLJGJEPKHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8325710", Offset = "0x8324110", VA = "0x188325710", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public BOIFAILEJMF DGBHIEOFEJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xABC390", Offset = "0xABAD90", VA = "0x180ABC390", Slot = "12")]
			get
			{
				return default(BOIFAILEJMF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8324690", Offset = "0x8323090", VA = "0x188324690")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8325430", Offset = "0x8323E30", VA = "0x188325430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x83250B0", Offset = "0x8323AB0", VA = "0x1883250B0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8325430", Offset = "0x8323E30", VA = "0x188325430", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8324D80", Offset = "0x8323780", VA = "0x188324D80", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x83254E0", Offset = "0x8323EE0", VA = "0x1883254E0")]
		public void UpdatePostIKAnimControllers(float LHPALOIPBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8324600", Offset = "0x8323000", VA = "0x188324600")]
		private void ANGOIHAHMLE(GameObject PMNHIPACJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x83246D0", Offset = "0x83230D0", VA = "0x1883246D0")]
		private ICNBFDLCIDH BDEGIKCFPDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x83250F0", Offset = "0x8323AF0", VA = "0x1883250F0")]
		private NOCNHILIHGH OFGOLDPBNMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8324AF0", Offset = "0x83234F0", VA = "0x188324AF0")]
		private KHMNFMMABMJ CEPOFLHCDIF(KGBHGNCHKEB FKKCCFGPMMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x83255C0", Offset = "0x8323FC0", VA = "0x1883255C0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class HNEMICNHGFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private MaterialPropertyBlock DPNHGBJIFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public Color? DBGIEEMHBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public Color? LHGPAFBIPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public Color? LBDFFCJNBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public Color? ACFIPENJJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public Color IIIIFFKFKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public Color HMOFFNCGNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public Color FIJJCCCKIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public float NOAIHPAPFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public Texture2D APLDMIFCMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public Texture2D MDFDEABCIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private Dictionary<FCOONAJGFPJ, int> PMKFPPMHFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private KNJLBNMOIIP[] BMKKMNKDGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private KMKLIECDFMI[] HBDHDEOKGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public Vector4[] GEDMIBDPDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public Vector4[] EIBKMBDIOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public Vector4[] GEEOAACBACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public Vector4[] DODEPCKGILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public Vector4[] KIKOFNHNKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public Vector4[] KHPHMJNAPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private List<Texture2D> NGAGDHJJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private Vector4[] DDLDNACPJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private List<Texture2D> ONEBMCNMHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private float[] DCKICINEPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private Vector4[] GBJCNGIBHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private float[] BAKCGMBPKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public float[] OCEJNMNEOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private List<Texture2D> IPBGKFJLGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private float[] CPPFLIFHJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private List<Texture2D> IHIEOHGGEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private Vector4[] ENDKEHFHFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private float[] GBGAMFGDNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private Vector4[] NPNMHGCFFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public float[] JFFDJBDKCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public Texture2DArray KMMDMJCPLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public Texture2DArray CAPFPHLGGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public Texture2DArray DHKMMEAHDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public Texture2DArray OHLHAIHLKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private bool DFECDFIBCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private int MHAAPCAKIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private Vector2? CEJBJENOOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private TextureFormat FJNGBBNGEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private Vector2? EKLECOAOIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private TextureFormat FJMGFLBACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private Vector2? KBGBDABOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private TextureFormat EACCPLJICFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private Vector2? LGNNAEFEMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private TextureFormat FEEAPLNMDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private bool ICPNMNBNLKA;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private static int JBFDHBBOGLM;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private static int HEONIKKBAFE;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private static int OELIBNPMAPG;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private static int BGIAHDMJKNK;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private static int IBGGJJDKNDJ;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private static int PBLMBCJCNMN;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private static int CJOPGMHLOJP;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private static int FBJINFKEHHC;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private static int IHIPFAIDAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private static int AMFDCFADOHD;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private static int KCIJMDOALNL;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private static int MGEEEHFLCPF;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private static int CIMMLLGBGAJ;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private static int PEBIPPEADPL;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private static int NFIJPBMPPAC;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private static int OHMNFPHPMNL;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private static int BLODBJLEIAH;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private static int FPHHBPNHGGH;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private static int NENEONPOFPA;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private static int IJKGDNGLFII;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x832E940", Offset = "0x832D340", VA = "0x18832E940")]
	private HNEMICNHGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x832EE40", Offset = "0x832D840", VA = "0x18832EE40")]
	public HNEMICNHGFC(Color FLIINIJOCEE, Color ODIJGFLOBLI, Color FIKJODNHBJM, Color? HICDMECNKKN, Color? FJPKIKDGLNN, Color? JHAOGDKGJLC, Texture2D JLIBIACJPBF, Texture2D KNJOJMANEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x832E4E0", Offset = "0x832CEE0", VA = "0x18832E4E0")]
	internal int OPMPLABOFBH(Material BMLEAIFKNGD, KNJLBNMOIIP OFNIKDNNMDM, KMKLIECDFMI PPDKOPMNDPA, EHMKAKBCPJB GDCGOHLFNLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x832E450", Offset = "0x832CE50", VA = "0x18832E450")]
	private int OPMPLABOFBH(FCOONAJGFPJ HPFHOBCPNEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x832D880", Offset = "0x832C280", VA = "0x18832D880")]
	internal int NOCMLDEOCCA(Material BMLEAIFKNGD, Color HHBPGHCDJAA, Color MCIKBOBAKNJ, Color OCJBDEBIGDC, Color EHPMHONAGDG, Color BCDFNBEMEEH, Texture2D ECBAFLAHCBH, Vector4 EFCNKOPILIO, Texture2D DOOIIOAKNNI, Vector4 KIOFMKIKLPH, float DANKMBLLBMK, float MKEFJBFKLHL, Texture2D PGFPJMDDCHH, Vector4 NMMAJKOGNPM, float KGDNKBPHIKK, Texture2D DHELOCHIJGO, Color IJPMBIPOAGA, Vector4 MMCGDMLAJJP, KNJLBNMOIIP OFNIKDNNMDM, KMKLIECDFMI PPDKOPMNDPA, EHMKAKBCPJB GDCGOHLFNLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x832C670", Offset = "0x832B070", VA = "0x18832C670")]
	private void FEFJJOKLHAN(List<Texture2D> NGAGDHJJIJO, [Out] Texture2DArray KOLEPLNBNGN, [Out] Texture2DArray DGEKGOFCIOJ, [Out] Texture2DArray BHFBGMOJAOC, [Out] Texture2DArray EEBOMJIPIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x832D730", Offset = "0x832C130", VA = "0x18832D730")]
	public void MBGCPLOCMNP(Shader KEGLONAOMID, Renderer ALKNEOONPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x832CA40", Offset = "0x832B440", VA = "0x18832CA40")]
	private void LOEKLDKLJGJ(Shader KEGLONAOMID, Renderer ALKNEOONPNG, int KCNIOAJIAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x832C2E0", Offset = "0x832ACE0", VA = "0x18832C2E0")]
	private Color AKDFFOFEAFC(Color GBGDNKDLBNA, KNJLBNMOIIP EKICIBMPDIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x832C4E0", Offset = "0x832AEE0", VA = "0x18832C4E0")]
	private Color DIHAKOFHGCE(Color NPANOOBIPPN, KNJLBNMOIIP EKICIBMPDIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x832C830", Offset = "0x832B230", VA = "0x18832C830")]
	private bool GKEGKFMEPNG(Texture2D APCKLEIFJGP, KMKLIECDFMI CANAAJFPLON, [Out] Texture2D CDCIGNKIHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x832C990", Offset = "0x832B390", VA = "0x18832C990")]
	private void HBNIKJHDAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x832C630", Offset = "0x832B030", VA = "0x18832C630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class APINAHJGOBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly LMLHDPNCKKH ILBGGFKMPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	protected bool BKDMLFPAMHN;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool IOFDOOLLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool CNJHDMBAGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA70", Offset = "0xB8A470", VA = "0x180B8BA70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA50", Offset = "0xB8A450", VA = "0x180B8BA50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public virtual HLHFIFHEPCK.LFIDLNGOLDF COBDGJAAHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HLHFIFHEPCK.LFIDLNGOLDF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool BFFOGDNGGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool NDHFKFHGINL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x831F1A0", Offset = "0x831DBA0", VA = "0x18831F1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool BDACGDFCALH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x831F120", Offset = "0x831DB20", VA = "0x18831F120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool PGJLAIIENCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x831F220", Offset = "0x831DC20", VA = "0x18831F220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x831F310", Offset = "0x831DD10", VA = "0x18831F310")]
	protected APINAHJGOBF(LMLHDPNCKKH LJNAHBMJLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract CNBBKAECPOB CIKNKNBLMAF(List<HPBHBMMEHME> OOMLMKHHJDO, List<HPBHBMMEHME> IFNIBLPFKHK);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract FFGDOHJPCCP ENKKFJHDHBG(uint ODNGOEPLNNM, AvatarSkinnedMeshBoneOrderRemapsData MFHAMCLBKLG);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GNNHALLHEFG : HLNABMJKIKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private AvatarSkinAssetItem DOKOADBNHDB;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x832B970", Offset = "0x832A370", VA = "0x18832B970")]
	public GNNHALLHEFG(AvatarSkinAssetItem BCDDCOIIGOE, AvatarSkinAssetItem.DJOECECCENC FLAFGBFIKNL, LMLHDPNCKKH GDCGOHLFNLP, [Optional] IBNJPOEEICJ? AHPHBJPHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x832B700", Offset = "0x832A100", VA = "0x18832B700", Slot = "6")]
	public override CNBBKAECPOB CIKNKNBLMAF(List<HPBHBMMEHME> OOMLMKHHJDO, List<HPBHBMMEHME> IFNIBLPFKHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LOOGLBBBMKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private static readonly int[] AOBPHPNLGKB;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private static readonly int[] IJDJFNJCDBE;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public static int[] OOHBLAODANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8331F60", Offset = "0x8330960", VA = "0x188331F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8331E10", Offset = "0x8330810", VA = "0x188331E10")]
	public static int[] FEHFDLPLIDP(bool AGNPKOJIIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8331ED0", Offset = "0x83308D0", VA = "0x188331ED0")]
	public static int MNJONEFEMKP(ACOJACDAJIP PCIPFNNANAA, bool AGNPKOJIIDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8331EA0", Offset = "0x83308A0", VA = "0x188331EA0")]
	private static int ILLDJDLNGAE(ACOJACDAJIP PCIPFNNANAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8331EB0", Offset = "0x83308B0", VA = "0x188331EB0")]
	private static int JHBJNDGKNGD(ACOJACDAJIP PCIPFNNANAA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NINDBLFBMKK
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class NJGMOJNFFON : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public NJGMOJNFFON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x157DAA0", Offset = "0x157C4A0", VA = "0x18157DAA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8333360", Offset = "0x8331D60", VA = "0x188333360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	public static void CDELNBPDNDI(string NMAIBBDGPCD, int ODNGOEPLNNM, long OCILDBANODD, long IDEDDOCBFJJ, long MACCALEDEEK, long GHIONGPGBMB, long IMFDNCMPHDI, long FBDCMPHAPBH, long OMLFELCALLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x83331A0", Offset = "0x8331BA0", VA = "0x1883331A0")]
	public static LCOHCCBKPLJ AMMNOLFINAK(JobHandle LGKOOBIENNL, bool BNGIGMMIGBL, bool PIHKFNOJAJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x83332F0", Offset = "0x8331CF0", VA = "0x1883332F0")]
	[IteratorStateMachine(typeof(NJGMOJNFFON))]
	private static IEnumerator<JFFMJDIOLAN> PFJGGCBFOMA(JobHandle NOJLBGFGHBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AEFECHEPLBP
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum OFKDGPFIPLK
	{
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly int MDKHLDCJBFL;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly int GFHIPIAMJPL;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly int FBFHNBBFFJD;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly int HILPOGGPJGH;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly int BFDJPDHOMIE;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly int NIKHOFLDBEF;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly int PGDCMLPGILJ;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly int OGCBCMFHELO;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly int CIDENFBDOJO;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly int HIODPMBFBFC;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly int MGDLIJIBLFM;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly int MACHAIECDDC;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x831E260", Offset = "0x831CC60", VA = "0x18831E260")]
	public static bool CAJGDFIDDIJ(Material PJPBFBIEGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x831E2D0", Offset = "0x831CCD0", VA = "0x18831E2D0")]
	public static bool NPAECMKBCHM(Material PJPBFBIEGMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class HLNABMJKIKM : APINAHJGOBF
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class EFEBPGGFHLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AACADPLMCLK<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public HLNABMJKIKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EFEBPGGFHLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8328730", Offset = "0x8327130", VA = "0x188328730")]
		internal void HAOFPDGOHOH(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x83285F0", Offset = "0x8326FF0", VA = "0x1883285F0")]
		internal void EIFGPIIPEFM(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	protected AvatarSkinAssetItem GKFLJDFIEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	protected Material[] GNEHFOCOAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private readonly AvatarSkinAssetItem.DJOECECCENC EJKMCJEKMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private readonly AssetReference INOGKEAHCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private readonly IBNJPOEEICJ? JDGIHLFFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private SkinnedMeshRenderer[] HNGANMBIBJI;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public override HLHFIFHEPCK.LFIDLNGOLDF COBDGJAAHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HLHFIFHEPCK.LFIDLNGOLDF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C90", Offset = "0xAB4690", VA = "0x180AB5C90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x832C1B0", Offset = "0x832ABB0", VA = "0x18832C1B0")]
	public HLNABMJKIKM(AvatarSkinAssetItem.DJOECECCENC FLAFGBFIKNL, AssetReference NGJGPEPHCAD, Material OMLGHMGLNPK, LMLHDPNCKKH GDCGOHLFNLP, HLHFIFHEPCK.LFIDLNGOLDF IPMMKMEGMKK = (HLHFIFHEPCK.LFIDLNGOLDF)0L, [Optional] IBNJPOEEICJ? AHPHBJPHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x832C050", Offset = "0x832AA50", VA = "0x18832C050")]
	public HLNABMJKIKM(AvatarSkinAssetItem.DJOECECCENC FLAFGBFIKNL, AssetReference NGJGPEPHCAD, Material OMLGHMGLNPK, HLHFIFHEPCK.LFIDLNGOLDF IPMMKMEGMKK = (HLHFIFHEPCK.LFIDLNGOLDF)0L, [Optional] IBNJPOEEICJ? AHPHBJPHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x832BFB0", Offset = "0x832A9B0", VA = "0x18832BFB0")]
	public HLNABMJKIKM(AvatarSkinAssetItem.DJOECECCENC FLAFGBFIKNL, AssetReference NGJGPEPHCAD, Material[] GOHAKKGFFNP, LMLHDPNCKKH GDCGOHLFNLP, HLHFIFHEPCK.LFIDLNGOLDF IPMMKMEGMKK = (HLHFIFHEPCK.LFIDLNGOLDF)0L, [Optional] IBNJPOEEICJ? AHPHBJPHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x832BB10", Offset = "0x832A510", VA = "0x18832BB10", Slot = "6")]
	public override CNBBKAECPOB CIKNKNBLMAF(List<HPBHBMMEHME> OOMLMKHHJDO, List<HPBHBMMEHME> IFNIBLPFKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x832BD30", Offset = "0x832A730", VA = "0x18832BD30", Slot = "7")]
	public override FFGDOHJPCCP ENKKFJHDHBG(uint ODNGOEPLNNM, AvatarSkinnedMeshBoneOrderRemapsData MFHAMCLBKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x832BF40", Offset = "0x832A940", VA = "0x18832BF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x832BCE0", Offset = "0x832A6E0", VA = "0x18832BCE0")]
	protected void EACLADOFKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class AJBBNLBONGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private List<int> CNIHIINGFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private List<HPKNCNLGCGN> NHKKFIJGKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private HashSet<Transform> LNEEPLCAGDL;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x831EB40", Offset = "0x831D540", VA = "0x18831EB40")]
	public static AJBBNLBONGM NHAPJOIANKA(Transform GGMLEPFJHKP, Dictionary<Transform, OutfitType?> JAMKHHIMDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x831ECD0", Offset = "0x831D6D0", VA = "0x18831ECD0")]
	private void NKCHDKNOACD(Transform GGMLEPFJHKP, EHMKAKBCPJB GDCGOHLFNLP, Dictionary<Transform, OutfitType?> JAMKHHIMDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x831E9B0", Offset = "0x831D3B0", VA = "0x18831E9B0")]
	private void DFBGHPJLHNG(Transform GOOKJAPFHOF, EHMKAKBCPJB GDCGOHLFNLP, bool FIENKKECOBI, OutfitType? KCPLHLPCIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x831E5C0", Offset = "0x831CFC0", VA = "0x18831E5C0")]
	public NAOKHHDAFJL BNEFKEAKJKF(HashSet<string> FPOBHEMKDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x831EFF0", Offset = "0x831D9F0", VA = "0x18831EFF0")]
	public AJBBNLBONGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class NAOKHHDAFJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private List<HPKNCNLGCGN> NHKKFIJGKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private List<Matrix4x4> PFLEFCMLOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private Transform[] HBMCKMLNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private Matrix4x4[] OBECDCJIGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private Dictionary<NICPOBPOMAL, int> ONDLMJNDGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private List<CEIGHLIINOH> HEDACIMEMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private bool OHKPKJKNAOL;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8332A90", Offset = "0x8331490", VA = "0x188332A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Transform[] HLKNBNFAKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8332BC0", Offset = "0x83315C0", VA = "0x188332BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Matrix4x4[] DODANKEDNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8332770", Offset = "0x8331170", VA = "0x188332770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8332570", Offset = "0x8330F70", VA = "0x188332570")]
	public void DFBGHPJLHNG(Transform GOOKJAPFHOF, EHMKAKBCPJB GDCGOHLFNLP, OutfitType? KCPLHLPCIAE, bool ANCGLFBFPEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8332200", Offset = "0x8330C00", VA = "0x188332200")]
	private void DFBGHPJLHNG(Transform GOOKJAPFHOF, EHMKAKBCPJB GDCGOHLFNLP, OutfitType? KCPLHLPCIAE, bool ANCGLFBFPEF, Matrix4x4 NGJFCDIFFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x83328E0", Offset = "0x83312E0", VA = "0x1883328E0")]
	public int JDPJIBCMPJN(NICPOBPOMAL HPFHOBCPNEF, bool GJFOGNFJJGN, [Optional] OutfitType? KCPLHLPCIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x83327E0", Offset = "0x83311E0", VA = "0x1883327E0")]
	public int IPJKFFJPEDP(EHMKAKBCPJB GDCGOHLFNLP, [Optional] OutfitType? KCPLHLPCIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8332AD0", Offset = "0x83314D0", VA = "0x188332AD0")]
	public void LMIJOHFBOAM(NICPOBPOMAL HPFHOBCPNEF, Matrix4x4 ICLJAPLENEA, bool GJFOGNFJJGN = false, [Optional] OutfitType? KCPLHLPCIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x83320B0", Offset = "0x8330AB0", VA = "0x1883320B0")]
	public Matrix4x4 ADPKLFAPCNH(NICPOBPOMAL HPFHOBCPNEF, bool GJFOGNFJJGN, [Optional] OutfitType? KCPLHLPCIAE)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x12B56A0", Offset = "0x12B40A0", VA = "0x1812B56A0")]
	public void JGBEKAJHNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8332D30", Offset = "0x8331730", VA = "0x188332D30")]
	public NAOKHHDAFJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct NICPOBPOMAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public readonly string PCNCENGMKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public readonly EHMKAKBCPJB ILBGGFKMPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public readonly OutfitType? KKDDEHLJFCE;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8333160", Offset = "0x8331B60", VA = "0x188333160")]
	public NICPOBPOMAL(string JFCAGHAKKFM, EHMKAKBCPJB GDCGOHLFNLP, [Optional] OutfitType? KCPLHLPCIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x83330B0", Offset = "0x8331AB0", VA = "0x1883330B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8332EE0", Offset = "0x83318E0", VA = "0x188332EE0")]
	public bool CFJEMHPIHGP(NICPOBPOMAL GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8332FA0", Offset = "0x83319A0", VA = "0x188332FA0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8333040", Offset = "0x8331A40", VA = "0x188333040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct CEIGHLIINOH : IEquatable<CEIGHLIINOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public readonly EHMKAKBCPJB ILBGGFKMPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public readonly OutfitType? DFKIGPAPINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public readonly int KNIGBECBMEN;

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8326680", Offset = "0x8325080", VA = "0x188326680")]
	public CEIGHLIINOH(EHMKAKBCPJB GDCGOHLFNLP, int KOHOJNNHMEF, [Optional] OutfitType? EOKGPIIPLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x83265B0", Offset = "0x8324FB0", VA = "0x1883265B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x74D5F50", Offset = "0x74D4950", VA = "0x1874D5F50")]
	public bool GFGGBNMDOJD(EHMKAKBCPJB GDCGOHLFNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8326530", Offset = "0x8324F30", VA = "0x188326530")]
	public bool JGAGBKHKGAB(OutfitType? EOKGPIIPLAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x83263A0", Offset = "0x8324DA0", VA = "0x1883263A0", Slot = "4")]
	public bool Equals(CEIGHLIINOH GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x83263F0", Offset = "0x8324DF0", VA = "0x1883263F0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x83264E0", Offset = "0x8324EE0", VA = "0x1883264E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HPKNCNLGCGN : IEquatable<HPKNCNLGCGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public readonly Transform LDLDAFFONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public readonly bool AKGMPBNMCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public readonly EHMKAKBCPJB PIDOOFAPJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public readonly OutfitType? KKDDEHLJFCE;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x83307B0", Offset = "0x832F1B0", VA = "0x1883307B0")]
	public HPKNCNLGCGN(Transform GOOKJAPFHOF, bool FIENKKECOBI, EHMKAKBCPJB BKGDNOKAEMA, [Optional] OutfitType? GHPCIGEGELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x83305A0", Offset = "0x832EFA0", VA = "0x1883305A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8330420", Offset = "0x832EE20", VA = "0x188330420", Slot = "4")]
	public bool Equals(HPKNCNLGCGN GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8330340", Offset = "0x832ED40", VA = "0x188330340", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8330520", Offset = "0x832EF20", VA = "0x188330520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x832B510", Offset = "0x8329F10", VA = "0x18832B510")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface GHBJCGHKNIC
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODAIGGCAFEJ(Mesh KGGOMLADPBD, Matrix4x4 ONMPCJHMCMI, IReadOnlyList<byte> ELONOALJKKD, bool JFKNILJIMBE = false, HLHFIFHEPCK.LFIDLNGOLDF PNJAPAHPGBC = (HLHFIFHEPCK.LFIDLNGOLDF)0L, int JCILFKFDKDO = -1, bool MFBKBIBKKBL = false);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENNKFJHCNMI(Allocator EIOOMONCLID, EKPJNMADPCB PHEKDHCLLIA, byte HJHOJDKFBIE, [Optional] IList<int> OBLFKHKFEFA, [Optional] IList<int> PPNDDAAAJCN);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct GFJOMPDGOLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public readonly GameObject FLIHICBMLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private readonly AvatarItemMaterial LIJDAEDGCFD;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
	public GFJOMPDGOLA(GameObject FLIHICBMLPK, AvatarItemMaterial LIJDAEDGCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x832B670", Offset = "0x832A070", VA = "0x18832B670")]
	public void LLDKAHEMOFB(Material PJPBFBIEGMK, int EMJCACMKDGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class BHKHEOFAFIN : GIIKODNJIFI<Task<(GameObject, AvatarItemMaterial)>, GFJOMPDGOLA>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct BNPFNGAEGNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8325E30", Offset = "0x8324830", VA = "0x188325E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8326330", Offset = "0x8324D30", VA = "0x188326330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private AACADPLMCLK<GameObject> GDEELBKHDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private AACADPLMCLK<AvatarItemMaterial> KCCPIFANEGM;

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8325DA0", Offset = "0x83247A0", VA = "0x188325DA0")]
	private BHKHEOFAFIN(Task<(GameObject, AvatarItemMaterial)> FLAIIHBKGBI, AACADPLMCLK<GameObject> PMACCDIDBIO, AACADPLMCLK<AvatarItemMaterial> NKCDCLILPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8325860", Offset = "0x8324260", VA = "0x188325860")]
	public static BHKHEOFAFIN MLAHKGEEKLJ(AssetReference MBBGEAIJFPL, [Optional] AssetReference FPEALKBOJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8325C80", Offset = "0x8324680", VA = "0x188325C80", Slot = "11")]
	protected override GFJOMPDGOLA NBPJMAMEEPL(Task<(GameObject, AvatarItemMaterial)> FHIOMBJHFCB)
	{
		return default(GFJOMPDGOLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8325D20", Offset = "0x8324720", VA = "0x188325D20", Slot = "12")]
	protected override void OJPNDDKCELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8325730", Offset = "0x8324130", VA = "0x188325730")]
	[AsyncStateMachine(typeof(BNPFNGAEGNI))]
	private static Task<(GameObject, AvatarItemMaterial)> HEGLAIKHPAH(Task<GameObject> GKNALNCKGEP, Task<AvatarItemMaterial> KCHAMPKFNKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class NEKHBEKBEPG
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class DLILEOCKPHE : GIIKODNJIFI<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private AACADPLMCLK<MaterialMapAsset> NOJLBGFGHBD;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x83370C0", Offset = "0x8335AC0", VA = "0x1883370C0")]
		public DLILEOCKPHE(AACADPLMCLK<MaterialMapAsset> NOJLBGFGHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8336BF0", Offset = "0x83355F0", VA = "0x188336BF0", Slot = "11")]
		protected override Material[] NBPJMAMEEPL(Task<MaterialMapAsset> FLAIIHBKGBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8337060", Offset = "0x8335A60", VA = "0x188337060", Slot = "12")]
		protected override void OJPNDDKCELO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class IADOJMDDCHK : GIIKODNJIFI<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private List<AACADPLMCLK<Material>> AEBBDAOLLLI;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8337DD0", Offset = "0x83367D0", VA = "0x188337DD0")]
		public IADOJMDDCHK(Task<Material[]> FLAIIHBKGBI, List<AACADPLMCLK<Material>> AEBBDAOLLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8337C40", Offset = "0x8336640", VA = "0x188337C40", Slot = "11")]
		protected override Material[] NBPJMAMEEPL(Task<Material[]> FHIOMBJHFCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8337C90", Offset = "0x8336690", VA = "0x188337C90", Slot = "12")]
		protected override void OJPNDDKCELO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x833A750", Offset = "0x8339150", VA = "0x18833A750")]
	public static AACADPLMCLK<Material[]> BNJMGCOJMGJ(AssetReference[] ANOGMAHAPHP)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : AvatarDisplayBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public enum LGAIDLAMHGF
		{
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public enum CBOILKINAMA
		{
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct AHNNGLCLOAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public readonly Material OCAHEHKLJJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public readonly LGAIDLAMHGF PAEBAHFGCEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public readonly CBOILKINAMA OOIKDDDLAEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public readonly EHMKAKBCPJB ILBGGFKMPDG;

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x8333B10", Offset = "0x8332510", VA = "0x188333B10")]
			public AHNNGLCLOAH(Material PJPBFBIEGMK, LGAIDLAMHGF OFNIKDNNMDM, CBOILKINAMA PPDKOPMNDPA, EHMKAKBCPJB GDCGOHLFNLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x83338F0", Offset = "0x83322F0", VA = "0x1883338F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x83336F0", Offset = "0x83320F0", VA = "0x1883336F0")]
			public bool CFJEMHPIHGP(AHNNGLCLOAH GOCNHGEHNFD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x8333770", Offset = "0x8332170", VA = "0x188333770", Slot = "0")]
			public override bool Equals(object PMNHIPACJLN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x8333850", Offset = "0x8332250", VA = "0x188333850", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class MFDBBIKIJMH : IComparable<MFDBBIKIJMH>, IEquatable<MFDBBIKIJMH>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public int EMOICFMCODG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public PlayerAvatarDisplayBase NGBNCIGPFCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public IList<DFPKOJIPBPI> LIJMKMNHDDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public AvatarItemBodyType PJNLBINJNAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public CBOHKGOBEFH FGOBMDOOKKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public bool DBNKFICEDLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public bool AOALOIBPEIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public int[] AEGHGIKPNPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public float BAJJHIOFCHK;

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x833A590", Offset = "0x8338F90", VA = "0x18833A590", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x833A440", Offset = "0x8338E40", VA = "0x18833A440", Slot = "4")]
			public int CompareTo(MFDBBIKIJMH GOCNHGEHNFD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x833A470", Offset = "0x8338E70", VA = "0x18833A470", Slot = "5")]
			public bool Equals(MFDBBIKIJMH GOCNHGEHNFD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public MFDBBIKIJMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected abstract class MIMNCCNKADG
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			public class JPPMPJBLKOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000386")]
				public readonly Mesh DAMOEDIBCAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000387")]
				public readonly Material[] BIIGEAMAGGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000388")]
				public readonly Transform[] DCOIPLOONEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000389")]
				public readonly Matrix4x4[] PNCIGDCCGBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400038A")]
				public readonly Transform AJPMHKLCGGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400038B")]
				public readonly bool DGFIBDHOFGL;

				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
				protected JPPMPJBLKOL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x83387C0", Offset = "0x83371C0", VA = "0x1883387C0")]
				public JPPMPJBLKOL(Mesh KGGOMLADPBD, Material[] PKBOBPADDHG, bool HGEHMIFPKNA, Transform[] IDHPHJINHBB, Transform JMGFBEJCCBI, Matrix4x4[] LILCKJNIDEP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x8338700", Offset = "0x8337100", VA = "0x188338700")]
				private JPPMPJBLKOL(SkinnedMeshRenderer DDEOMDPNNBG, Material[] PCAFIIJABAB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x8338610", Offset = "0x8337010", VA = "0x188338610")]
				private JPPMPJBLKOL(MeshRenderer NIGPOKJDIFD, Transform JMGFBEJCCBI, Material[] PCAFIIJABAB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x83382F0", Offset = "0x8336CF0", VA = "0x1883382F0")]
				public static JPPMPJBLKOL JANMHGIFFFE(Renderer ALKNEOONPNG, Material[] PCAFIIJABAB)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public readonly EHMKAKBCPJB ILBGGFKMPDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public readonly Transform PDKBEOJFBKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public readonly bool PALFFBKLEKA;

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool IOFDOOLLOGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual bool CNJHDMBAGCP
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual HLHFIFHEPCK.LFIDLNGOLDF COBDGJAAHFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "6")]
				get
				{
					return default(HLHFIFHEPCK.LFIDLNGOLDF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public bool GODGFICPAMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0x833A6E0", Offset = "0x83390E0", VA = "0x18833A6E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x833A6F0", Offset = "0x83390F0", VA = "0x18833A6F0")]
			protected MIMNCCNKADG(EHMKAKBCPJB GDCGOHLFNLP, Transform OEPCBFGOCCF, bool CNJDJPAECBG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract CNBBKAECPOB CIKNKNBLMAF(List<HPBHBMMEHME> OOMLMKHHJDO, List<HPBHBMMEHME> IFNIBLPFKHK);

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract JPPMPJBLKOL ENKKFJHDHBG(int ODNGOEPLNNM, PlayerHandBones HECDOHFPNMF);
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		protected class FEDLPBAFLGB : MIMNCCNKADG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected readonly BodyPartLODs HNGANMBIBJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected readonly Material[] GNEHFOCOAKF;

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8337460", Offset = "0x8335E60", VA = "0x188337460")]
			public FEDLPBAFLGB(EHMKAKBCPJB GDCGOHLFNLP, BodyPartLODs DKLADNJANBA, Material OMLGHMGLNPK, [Optional] Transform OEPCBFGOCCF, bool CNJDJPAECBG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x83371A0", Offset = "0x8335BA0", VA = "0x1883371A0", Slot = "7")]
			public override CNBBKAECPOB CIKNKNBLMAF(List<HPBHBMMEHME> OOMLMKHHJDO, List<HPBHBMMEHME> IFNIBLPFKHK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8337230", Offset = "0x8335C30", VA = "0x188337230", Slot = "8")]
			public override JPPMPJBLKOL ENKKFJHDHBG(int ODNGOEPLNNM, PlayerHandBones HECDOHFPNMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x83373F0", Offset = "0x8335DF0", VA = "0x1883373F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		protected class KHADCGOCJEN : MIMNCCNKADG
		{
			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public override bool IOFDOOLLOGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public override bool CNJHDMBAGCP
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x8338D00", Offset = "0x8337700", VA = "0x188338D00", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public IPHOENMGNFP AKOAJOFMJIM
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x8338DC0", Offset = "0x83377C0", VA = "0x188338DC0")]
			public KHADCGOCJEN(EHMKAKBCPJB GDCGOHLFNLP, Transform OEPCBFGOCCF, IPHOENMGNFP EAOHNMPFEDH, bool CNJDJPAECBG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x8338C70", Offset = "0x8337670", VA = "0x188338C70", Slot = "7")]
			public override CNBBKAECPOB CIKNKNBLMAF(List<HPBHBMMEHME> OOMLMKHHJDO, List<HPBHBMMEHME> IFNIBLPFKHK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "8")]
			public override JPPMPJBLKOL ENKKFJHDHBG(int ODNGOEPLNNM, PlayerHandBones HECDOHFPNMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x8338D50", Offset = "0x8337750", VA = "0x188338D50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class KHMPCLBDNGB
		{
			[Cpp2IlInjected.Token(Token = "0x2000062")]
			public enum JILICDGDAKP
			{
				[Cpp2IlInjected.Token(Token = "0x400039F")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x40003A0")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x40003A1")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x40003A2")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x40003A3")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x40003A4")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x40003A5")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public static readonly int MAFHOFMMNDH;

			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public static readonly int NFOLPBOFNCC;

			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public static readonly int DBOJOEIMKHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected readonly KGBHGNCHKEB FKKCCFGPMMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected readonly GGGFJJCDJPN JNIAJCFIOJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected readonly Animator GJHCDDOAODF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected readonly Transform FJCGEGNMOCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Vector3 DNOCGOFKEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected readonly Transform HOHMCLNDCDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Vector3 GKAHODFIHON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected bool JAOLACEHFHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected KHMNFMMABMJ AIMPDAGGCHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected bool DCLDGHHLDGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected float HAIGPMCDBNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected PBMHLLBNIIC<DBPOEHMBPJL> LKFAHAKOAFN;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public KHMNFMMABMJ NMCBGEHGKIH
			{
				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool FJHPJCALNGP
			{
				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0xD8A650", Offset = "0xD89050", VA = "0x180D8A650")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x8339530", Offset = "0x8337F30", VA = "0x188339530")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public bool JMPBCFNICLJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000331")]
				[Cpp2IlInjected.Address(RVA = "0x83396F0", Offset = "0x83380F0", VA = "0x1883396F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public float DDHKPEIGJEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000332")]
				[Cpp2IlInjected.Address(RVA = "0xE33CF0", Offset = "0xE326F0", VA = "0x180E33CF0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000333")]
				[Cpp2IlInjected.Address(RVA = "0x83393A0", Offset = "0x8337DA0", VA = "0x1883393A0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public DBPOEHMBPJL NHCHDPONGAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000334")]
				[Cpp2IlInjected.Address(RVA = "0x8338FA0", Offset = "0x83379A0", VA = "0x188338FA0")]
				get
				{
					return default(DBPOEHMBPJL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x8339910", Offset = "0x8338310", VA = "0x188339910")]
			public bool PKILKIDCDIJ(DBPOEHMBPJL ADENAMOLMEP, object MFKHKDDANII, JILICDGDAKP GMCNPLKBPIA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x8339810", Offset = "0x8338210", VA = "0x188339810")]
			public bool LOGPAEGNFND(object MFKHKDDANII)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x8339AD0", Offset = "0x83384D0", VA = "0x188339AD0")]
			protected KHMPCLBDNGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x8339B60", Offset = "0x8338560", VA = "0x188339B60")]
			public KHMPCLBDNGB(KGBHGNCHKEB FKKCCFGPMMJ, KHMNFMMABMJ OJCPACNCMBB, Animator GJHCDDOAODF, Transform FJCGEGNMOCD, Transform HOHMCLNDCDD, Vector3 DNOCGOFKEPE, Vector3 GKAHODFIHON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x8338EF0", Offset = "0x83378F0", VA = "0x188338EF0")]
			private void AEFMIFPHINO(ushort GLEKMCHEICP, ushort GDBEEGOINCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8339600", Offset = "0x8338000", VA = "0x188339600")]
			protected void IMDIJOEMLPD(ushort GLEKMCHEICP, ushort GDBEEGOINCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x8338E30", Offset = "0x8337830", VA = "0x188338E30")]
			protected void ABEPMKHFNNH(ushort GLEKMCHEICP, ushort GDBEEGOINCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8338FE0", Offset = "0x83379E0", VA = "0x188338FE0")]
			protected void BOKAAPMHBNG(ushort GLEKMCHEICP, ushort GDBEEGOINCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x8339110", Offset = "0x8337B10", VA = "0x188339110")]
			protected void CBNIJHAJEKL(ushort GLEKMCHEICP, ushort GDBEEGOINCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x8339340", Offset = "0x8337D40", VA = "0x188339340")]
			protected void FKKAJBHMLGK(ushort GLEKMCHEICP, ushort GDBEEGOINCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x83397C0", Offset = "0x83381C0", VA = "0x1883397C0")]
			protected void LFEDJIEBMKO(ushort GLEKMCHEICP, ushort GDBEEGOINCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x83394E0", Offset = "0x8337EE0", VA = "0x1883394E0")]
			protected void IFCOKPJJDGN(ushort GLEKMCHEICP, ushort GDBEEGOINCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x8339220", Offset = "0x8337C20", VA = "0x188339220")]
			protected void DHBKOGFGAHC(ushort GLEKMCHEICP, ushort GDBEEGOINCI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public class BAEKLBOPEFI : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public const int ONLCKHEGJKN = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected MaterialPropertyBlock DPNHGBJIFJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public Color? DBGIEEMHBGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public Color? LBDFFCJNBPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Color? ACFIPENJJNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Color IIIIFFKFKOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Color HMOFFNCGNCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Color FIJJCCCKIHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public Texture2D APLDMIFCMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			public Texture2D MDFDEABCIPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Dictionary<AHNNGLCLOAH, int> PMKFPPMHFPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected LGAIDLAMHGF[] BMKKMNKDGJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public Vector4[] GEDMIBDPDNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public Vector4[] EIBKMBDIOGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public Vector4[] GEEOAACBACK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public Vector4[] DODEPCKGILB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public Vector4[] KIKOFNHNKIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Vector4[] KHPHMJNAPCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected List<Texture2D> NGAGDHJJIJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected Vector4[] DDLDNACPJLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected List<Texture2D> ONEBMCNMHFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected float[] DCKICINEPIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected Vector4[] GBJCNGIBHLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected float[] BAKCGMBPKHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public float[] OCEJNMNEOMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected List<Texture2D> IPBGKFJLGJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected float[] CPPFLIFHJDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected List<Texture2D> IHIEOHGGEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected Vector4[] ENDKEHFHFAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected float[] GBGAMFGDNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected Vector4[] NPNMHGCFFCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public float[] JFFDJBDKCBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public Texture2DArray KMMDMJCPLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public Texture2DArray CAPFPHLGGLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public Texture2DArray DHKMMEAHDBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public Texture2DArray OHLHAIHLKPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected bool DFECDFIBCLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected int MHAAPCAKIBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected Vector2? CEJBJENOOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			protected TextureFormat FJNGBBNGEMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			protected Vector2? EKLECOAOIKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			protected TextureFormat FJMGFLBACBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			protected Vector2? KBGBDABOKJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			protected TextureFormat EACCPLJICFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			protected Vector2? LGNNAEFEMEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			protected TextureFormat FEEAPLNMDPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			protected bool ICPNMNBNLKA;

			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			protected static int JBFDHBBOGLM;

			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			protected static int HEONIKKBAFE;

			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			protected static int OELIBNPMAPG;

			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			protected static int BGIAHDMJKNK;

			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			protected static int IBGGJJDKNDJ;

			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			protected static int PBLMBCJCNMN;

			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			protected static int CJOPGMHLOJP;

			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			protected static int FBJINFKEHHC;

			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			protected static int IHIPFAIDAAJ;

			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			protected static int AMFDCFADOHD;

			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			protected static int KCIJMDOALNL;

			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			protected static int MGEEEHFLCPF;

			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			protected static int CIMMLLGBGAJ;

			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			protected static int PEBIPPEADPL;

			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			protected static int NFIJPBMPPAC;

			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			protected static int OHMNFPHPMNL;

			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			protected static int BLODBJLEIAH;

			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			protected static int FPHHBPNHGGH;

			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			protected static int NENEONPOFPA;

			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			protected static int IJKGDNGLFII;

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x83360C0", Offset = "0x8334AC0", VA = "0x1883360C0")]
			protected BAEKLBOPEFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x8336580", Offset = "0x8334F80", VA = "0x188336580")]
			public BAEKLBOPEFI(Color FLIINIJOCEE, Color ODIJGFLOBLI, Color FIKJODNHBJM, Color? HICDMECNKKN, Color? FJPKIKDGLNN, Color? JHAOGDKGJLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x8335C40", Offset = "0x8334640", VA = "0x188335C40")]
			public int OPMPLABOFBH(Material BMLEAIFKNGD, LGAIDLAMHGF OFNIKDNNMDM, CBOILKINAMA PPDKOPMNDPA, EHMKAKBCPJB GDCGOHLFNLP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x8335BB0", Offset = "0x83345B0", VA = "0x188335BB0")]
			public int OPMPLABOFBH(AHNNGLCLOAH HPFHOBCPNEF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x8334EB0", Offset = "0x83338B0", VA = "0x188334EB0")]
			public int NOCMLDEOCCA(Material BMLEAIFKNGD, Color HHBPGHCDJAA, Color MCIKBOBAKNJ, Color OCJBDEBIGDC, Color EHPMHONAGDG, Color BCDFNBEMEEH, Texture2D ECBAFLAHCBH, Vector4 EFCNKOPILIO, Texture2D DOOIIOAKNNI, Vector4 KIOFMKIKLPH, float DANKMBLLBMK, float MKEFJBFKLHL, Texture2D PGFPJMDDCHH, Vector4 NMMAJKOGNPM, float KGDNKBPHIKK, Texture2D DHELOCHIJGO, float JLIGLCMHACB, Color IJPMBIPOAGA, Vector4 MMCGDMLAJJP, LGAIDLAMHGF OFNIKDNNMDM, CBOILKINAMA PPDKOPMNDPA, EHMKAKBCPJB GDCGOHLFNLP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x8333ED0", Offset = "0x83328D0", VA = "0x188333ED0")]
			protected void FEFJJOKLHAN([Out] Texture2DArray KOLEPLNBNGN, [Out] Texture2DArray DGEKGOFCIOJ, [Out] Texture2DArray BHFBGMOJAOC, [Out] Texture2DArray EEBOMJIPIBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x8334C40", Offset = "0x8333640", VA = "0x188334C40")]
			public void MBGCPLOCMNP(PlayerAvatarDisplayBase NMKCEKNAPGI, Renderer ALKNEOONPNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x8334120", Offset = "0x8332B20", VA = "0x188334120")]
			protected void LOEKLDKLJGJ(PlayerAvatarDisplayBase NMKCEKNAPGI, Renderer ALKNEOONPNG, int KCNIOAJIAGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x8333B50", Offset = "0x8332550", VA = "0x188333B50")]
			private Color AKDFFOFEAFC(Color GBGDNKDLBNA, LGAIDLAMHGF EKICIBMPDIG)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x8333D80", Offset = "0x8332780", VA = "0x188333D80")]
			private Color EGPMFANPIFK(Color HEOAKCLDNDP, LGAIDLAMHGF EKICIBMPDIG)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8334090", Offset = "0x8332A90", VA = "0x188334090")]
			protected void HBNIKJHDAEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8333D40", Offset = "0x8332740", VA = "0x188333D40", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x83503E0", Offset = "0x834EDE0", VA = "0x1883503E0")]
			public void CCKGHEJMPGC(EHMKAKBCPJB GDCGOHLFNLP, [Out] Transform FAIGKPPBFHA, [Out] Transform[] IDHPHJINHBB)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class CLFBBOFFLEN : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
			[DebuggerHidden]
			public CLFBBOFFLEN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8336610", Offset = "0x8335010", VA = "0x188336610", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x8336890", Offset = "0x8335290", VA = "0x188336890", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x83367E0", Offset = "0x83351E0", VA = "0x1883367E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x83367E0", Offset = "0x83351E0", VA = "0x1883367E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class DIMOKLIKHPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public DIMOKLIKHPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8336B20", Offset = "0x8335520", VA = "0x188336B20")]
			internal bool MIMNNIBBAEJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class IADMOBPOAFL : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			private JFFMJDIOLAN <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000368")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public IADMOBPOAFL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x83378A0", Offset = "0x83362A0", VA = "0x1883378A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x8337BF0", Offset = "0x83365F0", VA = "0x188337BF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct IFHDPJJFKCH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public DECEKEGDNPK avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x8337E40", Offset = "0x8336840", VA = "0x188337E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x83381E0", Offset = "0x8336BE0", VA = "0x1883381E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class JAMAILMBHLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public JAMAILMBHLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x157CAA0", Offset = "0x157B4A0", VA = "0x18157CAA0")]
			internal bool CCHIDHICKFE(DFPKOJIPBPI selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class NNNOLEFGPBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Func<FKFADEBPFBK<Dictionary<string, AACADPLMCLK<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public NNNOLEFGPBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x833ABF0", Offset = "0x83395F0", VA = "0x18833ABF0")]
			internal (PKHGEDPOIHB, FKFADEBPFBK<Dictionary<string, AACADPLMCLK<Texture2D>>>) AAPAPFFOCOJ(Dictionary<string, MOJNGFFGLIG> avatarItems)
			{
				return default((PKHGEDPOIHB, FKFADEBPFBK<Dictionary<string, AACADPLMCLK<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x833B0A0", Offset = "0x8339AA0", VA = "0x18833B0A0")]
			internal FKFADEBPFBK<Dictionary<string, AACADPLMCLK<Texture2D>>> IPGDFNMJNJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x833ADF0", Offset = "0x83397F0", VA = "0x18833ADF0")]
			internal void FJBIOGLBDPF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class JHMLOMELFNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public JHMLOMELFNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x8338240", Offset = "0x8336C40", VA = "0x188338240")]
			internal bool GAOBGBMKNKG(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct GOIPGKPIFEF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x8337560", Offset = "0x8335F60", VA = "0x188337560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x8337840", Offset = "0x8336240", VA = "0x188337840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected static readonly int GGFLLHJEGGF;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected static readonly int IJGHAAAMHKK;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected static readonly int BEAHLKLDNDM;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected static readonly int LJADKPCMMNH;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected static readonly int AHCNFFEOMFA;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected static readonly int FNMMGLFNDAK;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected static readonly int[] PJKNLOMAFAP;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected static readonly int[] CPGCKMDMJJB;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected static readonly int[] KBKOICFLIGJ;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected static readonly int[] KGOMEIDKIDP;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected static readonly int[] DIOHAHKGDIN;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected static readonly int[] NOPGOGBAMED;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected static List<PlayerAvatarDisplayBase> LLLNNIAFDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected FKFKFDENFBG IGFNAOFPCBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected bool HALHMGCGANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected bool JPJJENGEKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected static readonly int[] LHPNFICDNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Dictionary<AHNNGLCLOAH, Material> EAMIMJADEGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected Dictionary<AHNNGLCLOAH, Material> NGDPAMAIOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		public Transform remoteMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Material OCINJGLDIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private KHMNFMMABMJ EBAHABHLKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private KHMNFMMABMJ HMMALMLIICC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected Material HHHLEKDPMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected FitMeshHemisphere HJDKEPGDGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected bool BLDKDKLPNMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected AFKHHJFHFCH PADCCFJIPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected bool JLCEKGAEGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected AnchorParamsRestrictions BMBNMGDDOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected bool IDDGFNDGKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Transform ELMKCLIGPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected bool AEMDBJHBIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected bool EOOAMILONII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Vector3 OELCDDDKPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected Quaternion JBPLACLAMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected Vector2 BEOBNJKBPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected FitMeshHemisphere OBGAKGAANJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		[IHBEENDFBCJ(EAHEBLGAGFP.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected Collider[] COEIHCHCEHD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Collider[] JICMHLLMHGG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected KHMPCLBDNGB[] KMHOKINONOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public Dictionary<Renderer, BAEKLBOPEFI> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected Dictionary<Renderer, BAEKLBOPEFI> LHEABICKAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected AJBBNLBONGM EJMPLDCGLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected PBMHLLBNIIC<GGGFJJCDJPN> LKFAHAKOAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected bool PMHAJFLFJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected Dictionary<DFPKOJIPBPI, List<AHNNGLCLOAH>> DIGGLIHKJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected Dictionary<DFPKOJIPBPI, List<AHNNGLCLOAH>> MANINGFBECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected readonly Dictionary<string, AACADPLMCLK<Texture2D>> GIDAHGGJFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected readonly Dictionary<string, AACADPLMCLK<Texture2D>> KMFFOIAOLGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected bool CNINPIJFPJI;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected static int MADNNKLGEMJ;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected static List<MFDBBIKIJMH> GNHOPEMFKIL;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		protected static List<MFDBBIKIJMH> IPAKJPGLBMM;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		protected static LCOHCCBKPLJ CIANFHFCPAA;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected static Func<List<MFDBBIKIJMH>, MFDBBIKIJMH> DFOBMALBMBM;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		protected static bool OMAGNILNGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		protected Color? HKPPMDHGECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		protected bool KAPGMKAOCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		protected Color MPOEMACDADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected Color CHFILPBAOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected Color NMFCLPMHBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected AvatarHairPattern LEJPEMOFNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		protected IPHOENMGNFP IOJDHDOIBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		protected Color MLMKPKEIINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		protected Color PFOJMEFAKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		protected AvatarHairPattern NONCLJNHNPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		protected IPHOENMGNFP DIFEKOKAEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		protected IPHOENMGNFP FJNNODCEEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		protected Color OKIAHKMAAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private AdditionalFeetData BDJLGOEDDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		protected DFPKOJIPBPI? ILCDBBGHBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		protected Texture BOHBELNDCJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		protected Color DPNOKDDOAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		protected readonly IList<DFPKOJIPBPI> GHOLPGGOJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		protected readonly IList<DFPKOJIPBPI> NGCFFKBDAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private AvatarItemBodyType PJDLPKPANFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		[SerializeField]
		protected EJOAHECBEFE _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F5")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		protected bool IAPGBAIFBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		protected int[] JIMNJGGCOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		protected bool KHKBEAILLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x401")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		protected bool ABAECGEBEND;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private static readonly HLHFIFHEPCK.LFIDLNGOLDF GCMBBAJHHED;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static readonly HLHFIFHEPCK.LFIDLNGOLDF FBBLGOBBGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x402")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		protected bool OGIJLPPGIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		protected JLDDJMHEPLP GGCJPIMJKGB;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public string NDFNHKKMFJG
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xAB7AB0", Offset = "0xAB64B0", VA = "0x180AB7AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool ELICGGNPNIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xE2A010", Offset = "0xE28A10", VA = "0x180E2A010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xE276B0", Offset = "0xE260B0", VA = "0x180E276B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual bool FELLDGPOHLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool HKJJFIMNAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8348DE0", Offset = "0x83477E0", VA = "0x188348DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual bool PPPNIJMCLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool DBMMFDBABDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual bool AOEDFCCMOPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public KHMNFMMABMJ LENENJOODFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xC28670", Offset = "0xC27070", VA = "0x180C28670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x8349540", Offset = "0x8347F40", VA = "0x188349540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public KHMNFMMABMJ NGILENECMNE
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xC3B980", Offset = "0xC3A380", VA = "0x180C3B980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x83497F0", Offset = "0x83481F0", VA = "0x1883497F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Material MHNEFLHCBAC
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x833EF10", Offset = "0x833D910", VA = "0x18833EF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected Material HBHCOJMLFCN
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x8340440", Offset = "0x833EE40", VA = "0x188340440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool CKLBHEIGMNH
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xB87980", Offset = "0xB86380", VA = "0x180B87980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public PlayerFacialAnimatorBase FCNNKGBLICB
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xC417B0", Offset = "0xC401B0", VA = "0x180C417B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public KHMPCLBDNGB[] JMGGFHECHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x8348960", Offset = "0x8347360", VA = "0x188348960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public KHMPCLBDNGB LJDBMONAHLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x8348FD0", Offset = "0x83479D0", VA = "0x188348FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public KHMPCLBDNGB ADHACCFHIFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x8349000", Offset = "0x8347A00", VA = "0x188349000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Mesh KILICBKGLPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xC42210", Offset = "0xC40C10", VA = "0x180C42210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected AJBBNLBONGM NEDAFCCODNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x833CBD0", Offset = "0x833B5D0", VA = "0x18833CBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected bool PIHKFNOJAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override int ENEGAIEFADB
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xACB3F0", Offset = "0xAC9DF0", VA = "0x180ACB3F0", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8349750", Offset = "0x8348150", VA = "0x188349750", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected virtual bool EAGIIOCIEPN
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		protected virtual int[] FBCPAKOLMGA
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x833D7D0", Offset = "0x833C1D0", VA = "0x18833D7D0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected bool PKLAJPIPGLO
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x833F150", Offset = "0x833DB50", VA = "0x18833F150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected static bool GKIFPNJOCEF
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool JACGEJGPDFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8349030", Offset = "0x8347A30", VA = "0x188349030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x8349A00", Offset = "0x8348400", VA = "0x188349A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public IEnumerable<SkinnedMeshRenderer> AIJAKCKJLCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8348840", Offset = "0x8347240", VA = "0x188348840")]
			[IteratorStateMachine(typeof(CLFBBOFFLEN))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool FHLCJJBHDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8348FC0", Offset = "0x83479C0", VA = "0x188348FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x8343440", Offset = "0x8341E40", VA = "0x188343440")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public new static bool OEGAHCMICEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8348D10", Offset = "0x8347710", VA = "0x188348D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected static LCOHCCBKPLJ GEPAKLJCCDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x8341960", Offset = "0x8340360", VA = "0x188341960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x83430F0", Offset = "0x8341AF0", VA = "0x1883430F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Color LBDFFCJNBPC
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x833F5E0", Offset = "0x833DFE0", VA = "0x18833F5E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Color ACFIPENJJNK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x833F1D0", Offset = "0x833DBD0", VA = "0x18833F1D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Texture2D IPKOPNAMIEM
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x833CAE0", Offset = "0x833B4E0", VA = "0x18833CAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Color IIIIFFKFKOI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x8348910", Offset = "0x8347310", VA = "0x188348910")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Color HMOFFNCGNCB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x8341B50", Offset = "0x8340550", VA = "0x188341B50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public IPHOENMGNFP AEGMDGBGFCM
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x83488D0", Offset = "0x83472D0", VA = "0x1883488D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected Texture2D KOHGGMJPGOK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x8341390", Offset = "0x833FD90", VA = "0x188341390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public float CLNCDGONMKN
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x83488F0", Offset = "0x83472F0", VA = "0x1883488F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public float LFAMKJPENBA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x8348DC0", Offset = "0x83477C0", VA = "0x188348DC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public bool ILDJMLGDFIK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x83488C0", Offset = "0x83472C0", VA = "0x1883488C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8349310", Offset = "0x8347D10", VA = "0x188349310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action DIIKHKMPMPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8348570", Offset = "0x8346F70", VA = "0x188348570")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8349040", Offset = "0x8347A40", VA = "0x188349040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action DPPKJKAMJID
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8348620", Offset = "0x8347020", VA = "0x188348620")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x83490F0", Offset = "0x8347AF0", VA = "0x1883490F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action FFEOCMEFFBC
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x83486D0", Offset = "0x83470D0", VA = "0x1883486D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x83491A0", Offset = "0x8347BA0", VA = "0x1883491A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<KGBHGNCHKEB, DBPOEHMBPJL> LDJBMONKIGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8348780", Offset = "0x8347180", VA = "0x188348780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8349250", Offset = "0x8347C50", VA = "0x188349250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8344A80", Offset = "0x8343480", VA = "0x188344A80")]
		public bool SetDeformation(bool HALHMGCGANJ, bool JPJJENGEKNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8340530", Offset = "0x833EF30", VA = "0x188340530")]
		protected static Material IFMIHHOOGBL(Dictionary<AHNNGLCLOAH, Material> PFNGHAJKEOB, Material EDODCBPBNFL, LGAIDLAMHGF OFNIKDNNMDM, CBOILKINAMA PPDKOPMNDPA, EHMKAKBCPJB GDCGOHLFNLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x833B540", Offset = "0x8339F40", VA = "0x18833B540")]
		protected void AIJPBPABMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8341BA0", Offset = "0x83405A0", VA = "0x188341BA0")]
		protected bool MEJMNCMIKPC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8340A30", Offset = "0x833F430", VA = "0x188340A30")]
		protected void JBJMGJNFKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8342720", Offset = "0x8341120", VA = "0x188342720")]
		protected static void MMLHBLDLAML(Dictionary<DFPKOJIPBPI, List<AHNNGLCLOAH>> HJAOHCJPEIK, MIMNCCNKADG NCPMENBJPNL, Material EDODCBPBNFL, LGAIDLAMHGF EKICIBMPDIG, CBOILKINAMA CANAAJFPLON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x833BFF0", Offset = "0x833A9F0", VA = "0x18833BFF0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x833C290", Offset = "0x833AC90", VA = "0x18833C290")]
		protected void BLENMKDCAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x83437B0", Offset = "0x83421B0", VA = "0x1883437B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "19")]
		protected virtual void JIJGAOODKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8341250", Offset = "0x833FC50", VA = "0x188341250")]
		protected static void KFAJAMIBLGL(List<Material> KCFGNFMEEII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x83402E0", Offset = "0x833ECE0", VA = "0x1883402E0")]
		protected static void IEABMELMIEO(Dictionary<AHNNGLCLOAH, Material> PFNGHAJKEOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x83419B0", Offset = "0x83403B0", VA = "0x1883419B0")]
		protected static void MCLBBJCCPBO(Dictionary<Renderer, BAEKLBOPEFI> MBIBIKLMPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x833CEC0", Offset = "0x833B8C0", VA = "0x18833CEC0")]
		protected void CPNAFIKJJHL(SkinnedMeshRenderer[] LAHKKEOEOAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8343640", Offset = "0x8342040", VA = "0x188343640")]
		protected void OLJHFLDFHMP(SkinnedMeshRenderer DDEOMDPNNBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x83436E0", Offset = "0x83420E0", VA = "0x1883436E0")]
		protected void OLJHFLDFHMP(MeshRenderer NIGPOKJDIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x833FE80", Offset = "0x833E880", VA = "0x18833FE80")]
		protected void HEHFHDOAHLJ(List<HPBHBMMEHME> HCLKNHFPLBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8342C10", Offset = "0x8341610", VA = "0x188342C10")]
		protected void NAIBJBPOAIN(Dictionary<string, AACADPLMCLK<Texture2D>> HJAOHCJPEIK, bool GEHFOLBAIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x83410A0", Offset = "0x833FAA0", VA = "0x1883410A0")]
		protected void JLOCAEEMOGC(Dictionary<DFPKOJIPBPI, List<AHNNGLCLOAH>> HJAOHCJPEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x833F840", Offset = "0x833E240", VA = "0x18833F840")]
		public float GetHandOpenClosedAxis(KGBHGNCHKEB FKKCCFGPMMJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8345310", Offset = "0x8343D10", VA = "0x188345310")]
		public void SetHandOpenClosedAxis(KGBHGNCHKEB FKKCCFGPMMJ, float FHCMMHNOCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x833F880", Offset = "0x833E280", VA = "0x18833F880")]
		public DBPOEHMBPJL GetHandVisualState(KGBHGNCHKEB FKKCCFGPMMJ)
		{
			return default(DBPOEHMBPJL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x833B660", Offset = "0x833A060", VA = "0x18833B660")]
		public bool AddHandVisualStateToken(KGBHGNCHKEB FKKCCFGPMMJ, DBPOEHMBPJL ACJCLGKBBGK, object MFKHKDDANII, KHMPCLBDNGB.JILICDGDAKP GMCNPLKBPIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8346E40", Offset = "0x8345840", VA = "0x188346E40")]
		public void SetWatchHand(KGBHGNCHKEB FKKCCFGPMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8346F00", Offset = "0x8345900", VA = "0x188346F00")]
		public void SetWatchHands(bool NONGDEDAGLF, bool IGHBIBKKCHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8344060", Offset = "0x8342A60", VA = "0x188344060")]
		public bool RemoveHandVisualStateToken(KGBHGNCHKEB FKKCCFGPMMJ, object MFKHKDDANII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x833F930", Offset = "0x833E330", VA = "0x18833F930")]
		public bool GetThumbsUpActive(KGBHGNCHKEB FKKCCFGPMMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x83467A0", Offset = "0x83451A0", VA = "0x1883467A0")]
		public void SetThumbsUpActive(KGBHGNCHKEB FKKCCFGPMMJ, bool EPJCGFABCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x833F8F0", Offset = "0x833E2F0", VA = "0x18833F8F0")]
		public bool GetHandshakeActive(KGBHGNCHKEB FKKCCFGPMMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8345480", Offset = "0x8343E80", VA = "0x188345480")]
		public void SetHandshakeActive(KGBHGNCHKEB FKKCCFGPMMJ, bool AKNLHCNHCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x833F370", Offset = "0x833DD70", VA = "0x18833F370")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8346D30", Offset = "0x8345730", VA = "0x188346D30")]
		public void SetUseClassicBeanHandScale(bool KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x833D5E0", Offset = "0x833BFE0", VA = "0x18833D5E0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x833F630", Offset = "0x833E030", VA = "0x18833F630")]
		private static void GEDIMBJKFPE(Scene LDEJAMJEHAA, LoadSceneMode GDIJNLEACAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x833F3C0", Offset = "0x833DDC0", VA = "0x18833F3C0")]
		protected static void GAPGAJNIFBE(PlayerAvatarDisplayBase JBJOMLHGOKB, List<MFDBBIKIJMH> BEHOJPOBBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8343D90", Offset = "0x8342790", VA = "0x188343D90")]
		public CNBBKAECPOB Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x833EAB0", Offset = "0x833D4B0", VA = "0x18833EAB0")]
		protected CNBBKAECPOB DLPAEOCNGMG(bool KFFKGJGJNHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x833E980", Offset = "0x833D380", VA = "0x18833E980", Slot = "20")]
		protected virtual CNBBKAECPOB DLPAEOCNGMG(IList<DFPKOJIPBPI> AEFHKHCKGDL, AvatarItemBodyType LCBPFFJMFOM, bool ILCFNBPOEIB, bool GDOLEFIHFGC, int[] ICIEJKEJMMO, bool KFFKGJGJNHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x833C470", Offset = "0x833AE70", VA = "0x18833C470")]
		protected static CNBBKAECPOB BOOFAADJLIG(MFDBBIKIJMH BFCHAMOGNJN, List<MFDBBIKIJMH> BEHOJPOBBDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8341860", Offset = "0x8340260", VA = "0x188341860")]
		[IteratorStateMachine(typeof(IADMOBPOAFL))]
		protected static IEnumerator<JFFMJDIOLAN> LPNNIAGOLHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x833B4B0", Offset = "0x8339EB0", VA = "0x18833B4B0")]
		protected static MFDBBIKIJMH AIIIDDPHGGO(List<MFDBBIKIJMH> BEHOJPOBBDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8344B90", Offset = "0x8343590", VA = "0x188344B90")]
		[AsyncStateMachine(typeof(IFHDPJJFKCH))]
		public Task SetFaceCustomizationSettings(DECEKEGDNPK AIFAODPNIHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8347060", Offset = "0x8345A60", VA = "0x188347060")]
		public bool UpdateFaceAndBodyCustomizationSettings(DECEKEGDNPK AIFAODPNIHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8340950", Offset = "0x833F350", VA = "0x188340950")]
		public void InitializeFaceFeatures(AvatarConfiguration JMNPDPKGBHB, BOIFAILEJMF FJBHHBODDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8346500", Offset = "0x8344F00", VA = "0x188346500")]
		public void SetTeamColors(Color? JHAOGDKGJLC, bool MBNFIOBNOOM, Color NEFOPDPCGAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x15B4850", Offset = "0x15B3250", VA = "0x1815B4850")]
		private static void NFDKFPBICHF(Material PJPBFBIEGMK, Color KMAFNKGMDCF, params int[] OOMIBCNNHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x15B50A0", Offset = "0x15B3AA0", VA = "0x1815B50A0")]
		private static void PAMDCFMEPCG(Material PJPBFBIEGMK, Texture KMAFNKGMDCF, params int[] OOMIBCNNHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8342270", Offset = "0x8340C70", VA = "0x188342270")]
		protected void MJFGBFHNNOP(Material DJPAPGPCBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x833F4C0", Offset = "0x833DEC0", VA = "0x18833F4C0")]
		protected void GBGNGOKBAGK(Material DJPAPGPCBDH, Color EJCHMIHNPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8343450", Offset = "0x8341E50", VA = "0x188343450")]
		protected void OKCIBIANGOF(Material DJPAPGPCBDH, Color EJCHMIHNPKJ, Color GJEBBPLEFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8343B70", Offset = "0x8342570", VA = "0x188343B70")]
		protected void PMBELIOLLFN(Material DJPAPGPCBDH, Texture2D JBOOEIGKOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x833EB10", Offset = "0x833D510", VA = "0x18833EB10")]
		protected void EAAKAKNBNKN(Material DJPAPGPCBDH, Texture EBAHBEEIEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8341540", Offset = "0x833FF40", VA = "0x188341540")]
		protected void LIBGNIGEMNH(Action<BAEKLBOPEFI> FOBJABDHGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8342030", Offset = "0x8340A30", VA = "0x188342030")]
		protected void MGJEOFNPFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8342A50", Offset = "0x8341450", VA = "0x188342A50")]
		protected void MPGJKAJPNMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8342D90", Offset = "0x8341790", VA = "0x188342D90")]
		protected void NBBFMMLEELB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x833BA70", Offset = "0x833A470", VA = "0x18833BA70")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8344510", Offset = "0x8342F10", VA = "0x188344510")]
		public void SetBeardPrimaryColor([Optional] Color? PJJAOMFAMGO, bool KOBIFNMCMMF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x8344730", Offset = "0x8343130", VA = "0x188344730")]
		public void SetBeardSecondaryColor([Optional] Color? PJJAOMFAMGO, bool KOBIFNMCMMF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x83443E0", Offset = "0x8342DE0", VA = "0x1883443E0")]
		public void SetBeardPattern([Optional] AvatarHairPattern PPINEDCLKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8340AC0", Offset = "0x833F4C0", VA = "0x188340AC0")]
		private void JDELJACMNPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x83432C0", Offset = "0x8341CC0", VA = "0x1883432C0")]
		private bool NLEKMBNKBCP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8344EF0", Offset = "0x83438F0", VA = "0x188344EF0")]
		public void SetHairPrimaryColor([Optional] Color? JOBCGCABNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8345100", Offset = "0x8343B00", VA = "0x188345100")]
		public void SetHairSecondaryColor([Optional] Color? JOBCGCABNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8344DC0", Offset = "0x83437C0", VA = "0x188344DC0")]
		public void SetHairPattern([Optional] AvatarHairPattern PPINEDCLKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8343F00", Offset = "0x8342900", VA = "0x188343F00")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x83417A0", Offset = "0x83401A0", VA = "0x1883417A0")]
		private bool LLNMEEPMMHG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8346350", Offset = "0x8344D50", VA = "0x188346350")]
		public void SetSkinColor(Color FLIINIJOCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x83468B0", Offset = "0x83452B0", VA = "0x1883468B0")]
		public void SetUgcItemVisualOverrides(DFPKOJIPBPI FLMDINIBFPL, BOIFAILEJMF FJBHHBODDIK, Texture GFBGOGOCHMG, Color HIHDBCKCCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x833D6B0", Offset = "0x833C0B0", VA = "0x18833D6B0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8344C90", Offset = "0x8343690", VA = "0x188344C90")]
		public bool SetFaceShape(AvatarFaceShape ACPFNMCKDKM, bool BDJNEFCCEFH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8343AD0", Offset = "0x83424D0", VA = "0x188343AD0")]
		private void PJAGLBIKDHM(AJEJOKPMFDJ KEGEFGDLPMG, float KMAFNKGMDCF, bool FALKKBAOPMA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x833B110", Offset = "0x8339B10", VA = "0x18833B110")]
		private void ACKJHCNBGDN(KECHODCMKML NDEGCBFHPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8340C20", Offset = "0x833F620", VA = "0x188340C20")]
		private void JDPADJCPKOP(KPABGEBMFHP BEDDMIIBLAD, float KMAFNKGMDCF, bool FEHNDKLGLAN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x833B410", Offset = "0x8339E10", VA = "0x18833B410")]
		private void AHIGGKEDMGA(KFBADBLPJDD LOKOOJAOCIA, float KMAFNKGMDCF, bool LBPHAFGGGAP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8340840", Offset = "0x833F240", VA = "0x188340840")]
		private void IJACLLOHMPC(NEDIDPDJGFK FMPILMOBEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8340680", Offset = "0x833F080", VA = "0x188340680")]
		private void IGGJGLLHOLI(AAGDDBFBFJH FNCCOLLOOHD, float AFPJEDMPGHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8344950", Offset = "0x8343350", VA = "0x188344950")]
		public bool SetBodyShape(AvatarBodyShape LFOIALMAMID, bool BDJNEFCCEFH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x83461C0", Offset = "0x8344BC0", VA = "0x1883461C0")]
		public bool SetNoseType(EJOAHECBEFE PMEKGOFHJPP, bool BDJNEFCCEFH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x83478D0", Offset = "0x83462D0", VA = "0x1883478D0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x83461A0", Offset = "0x8344BA0", VA = "0x1883461A0")]
		public bool SetHideEars(bool ILJBHAHDCLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8346180", Offset = "0x8344B80", VA = "0x188346180")]
		public bool SetHelmetHair(FKFKFDENFBG MGOPOHAJOPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8345BE0", Offset = "0x83445E0", VA = "0x188345BE0")]
		public void SetHatAnchorParameters(AFKHHJFHFCH JHMBLCGLMGG, bool FFEOFCPLPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8346330", Offset = "0x8344D30", VA = "0x188346330")]
		public bool SetShowModestyAndValidationGuidelines(bool MBJFKHCFNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8346FD0", Offset = "0x83459D0", VA = "0x188346FD0")]
		public void SetupDisplayLODs(AGFCKGMJOAM HPIGAOEFGEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x833ECC0", Offset = "0x833D6C0", VA = "0x18833ECC0")]
		protected int[] EKMIFPPGAMG(AGFCKGMJOAM HPIGAOEFGEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x83462B0", Offset = "0x8344CB0", VA = "0x1883462B0")]
		public void SetOutfitSelections(IList<DFPKOJIPBPI> AEFHKHCKGDL, AvatarItemBodyType LCBPFFJMFOM, bool GDOLEFIHFGC, bool KFFKGJGJNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8346260", Offset = "0x8344C60", VA = "0x188346260")]
		public void SetOutfitSelections(IList<DFPKOJIPBPI> AEFHKHCKGDL, AvatarItemBodyType LCBPFFJMFOM, bool ILCFNBPOEIB, bool GDOLEFIHFGC, bool KFFKGJGJNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x83462F0", Offset = "0x8344CF0", VA = "0x1883462F0")]
		public CNBBKAECPOB SetOutfitSelections(IList<DFPKOJIPBPI> AEFHKHCKGDL, AvatarItemBodyType LCBPFFJMFOM, AGFCKGMJOAM HPIGAOEFGEM, bool ILCFNBPOEIB, bool GDOLEFIHFGC, bool BDJNEFCCEFH = false, bool KFFKGJGJNHF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8341DC0", Offset = "0x83407C0", VA = "0x188341DC0", Slot = "21")]
		protected virtual CNBBKAECPOB MELHEIOLPFF(IList<DFPKOJIPBPI> AEFHKHCKGDL, AvatarItemBodyType LCBPFFJMFOM, bool ILCFNBPOEIB, bool GDOLEFIHFGC, AGFCKGMJOAM HPIGAOEFGEM, bool BDJNEFCCEFH, bool KFFKGJGJNHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x83416A0", Offset = "0x83400A0", VA = "0x1883416A0")]
		protected int[] LIFEANDNFOH(AGFCKGMJOAM HPIGAOEFGEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "22")]
		protected virtual PKHGEDPOIHB CIPNIAKODED(AvatarItemBodyType BIKJIJKPPJA, Dictionary<string, MOJNGFFGLIG> CHIAPIEJGDE, Dictionary<string, AACADPLMCLK<Texture2D>> AEJIBMELGFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x833CBF0", Offset = "0x833B5F0", VA = "0x18833CBF0", Slot = "23")]
		protected virtual CNBBKAECPOB CNFFAGBCAMH(IList<DFPKOJIPBPI> AEFHKHCKGDL, AvatarItemBodyType LCBPFFJMFOM, bool ILCFNBPOEIB, bool GDOLEFIHFGC, int[] AEGHGIKPNPM, CBOHKGOBEFH JLJINENNJNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x833F970", Offset = "0x833E370", VA = "0x18833F970", Slot = "24")]
		protected virtual MOJNGFFGLIG HBNPFFDFDLB(IPHOENMGNFP EAOHNMPFEDH, AvatarItemBodyType BIKJIJKPPJA, EHMKAKBCPJB GDCGOHLFNLP, MOJNGFFGLIG DMKGAACFIAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "25")]
		protected virtual MOJNGFFGLIG AMNGOBDCLKG(AvatarItemBodyType BIKJIJKPPJA, EHMKAKBCPJB GDCGOHLFNLP, BMBPHCMGKOJ FDFGEPPACCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x833C180", Offset = "0x833AB80", VA = "0x18833C180")]
		protected void BALPCILOMHP(EHBONEDLEEG NNGPPOMILDA, HLHFIFHEPCK.LFIDLNGOLDF PHMDJIBCKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8343A50", Offset = "0x8342450", VA = "0x188343A50")]
		protected void PHJPAICMGPG(EHBONEDLEEG NNGPPOMILDA, HLHFIFHEPCK.LFIDLNGOLDF PHMDJIBCKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xB117A0", Offset = "0xB101A0", VA = "0x180B117A0", Slot = "26")]
		protected virtual EHBONEDLEEG FCHDLANNHIK(EHBONEDLEEG NNGPPOMILDA, HelmetHairStyle KKMDNCBALCB, bool PLMGJLAFGIH, AvatarItemBodyType LCBPFFJMFOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x833D860", Offset = "0x833C260", VA = "0x18833D860")]
		protected EHBONEDLEEG DCCMBKGGJOI(IList<DFPKOJIPBPI> AEFHKHCKGDL, AvatarItemBodyType GEHNLIDGOFC, bool GDOLEFIHFGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x833D4C0", Offset = "0x833BEC0", VA = "0x18833D4C0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x833EE70", Offset = "0x833D870", VA = "0x18833EE70")]
		protected void ENDLKCGGHOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8340D80", Offset = "0x833F780", VA = "0x188340D80")]
		protected void JKHEKBBEPJI(Transform GMBPOHAALBD, IEnumerable<SkinnedMeshRenderer> CONGHLLHMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8340CC0", Offset = "0x833F6C0", VA = "0x188340CC0")]
		protected HLHFIFHEPCK.LFIDLNGOLDF JHIGJCBKMIK(HLHFIFHEPCK.LFIDLNGOLDF HDNBENONCKM, EHMKAKBCPJB LJNAHBMJLHD)
		{
			return default(HLHFIFHEPCK.LFIDLNGOLDF);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x833D700", Offset = "0x833C100", VA = "0x18833D700", Slot = "11")]
		[AsyncStateMachine(typeof(GOIPGKPIFEF))]
		public override Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x83424F0", Offset = "0x8340EF0", VA = "0x1883424F0")]
		protected static LGAIDLAMHGF MKDNMOEAIEK(MIMNCCNKADG EKILGADNPDE, int KBLLLLMLGLD)
		{
			return default(LGAIDLAMHGF);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x833F220", Offset = "0x833DC20", VA = "0x18833F220")]
		protected static CBOILKINAMA FNAFFGGHPFO(MIMNCCNKADG EKILGADNPDE, int KBLLLLMLGLD)
		{
			return default(CBOILKINAMA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x833F7A0", Offset = "0x833E1A0", VA = "0x18833F7A0")]
		protected Transform GJFBCIHCDLK(EHMKAKBCPJB GDCGOHLFNLP, OutfitType KCPLHLPCIAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x83400E0", Offset = "0x833EAE0", VA = "0x1883400E0")]
		protected void HKGBGMACECG(int EMJCACMKDGG, Material PJPBFBIEGMK, MIMNCCNKADG EKILGADNPDE, [Out] Texture2D LJCBJDPGNOG, [Out] Vector4 EPNLKLGLFLC, [Out] Texture2D GNMCNPOAFHD, [Out] Texture2D MDMCNOKPCGB, [Out] Texture2D IBBDDDPJHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x833B2C0", Offset = "0x8339CC0", VA = "0x18833B2C0")]
		protected void AFJDEMEDADI(int EMJCACMKDGG, Material PJPBFBIEGMK, MIMNCCNKADG EKILGADNPDE, [Out] Color HHBPGHCDJAA, [Out] Color MCIKBOBAKNJ, [Out] Color OCJBDEBIGDC, [Out] Color EHPMHONAGDG, [Out] Color BCDFNBEMEEH, [Out] Color IJPMBIPOAGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x83429E0", Offset = "0x83413E0", VA = "0x1883429E0")]
		protected void MNPMFIDBKLC(Vector3 NGNFCFGNCAH, Quaternion OHBEIHCPLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8345590", Offset = "0x8343F90", VA = "0x188345590")]
		public void SetHatAnchorParameters(AFKHHJFHFCH JHMBLCGLMGG, AnchorParamsRestrictions NCDBOIGLBIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x833CFE0", Offset = "0x833B9E0", VA = "0x18833CFE0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere HJDKEPGDGOE, Transform ELMKCLIGPEN, AFKHHJFHFCH JHMBLCGLMGG, AnchorParamsRestrictions BMBNMGDDOMM, [Out] Vector3 AIOBIOOBAEK, [Out] Quaternion ECCDGFAJEON, [Out] AFKHHJFHFCH HMECOKGPLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8344270", Offset = "0x8342C70", VA = "0x188344270")]
		public void ResetHatAnchor(Vector2 PDEKLCKPFCE, Vector3 IICJEOAGFHF, Vector3 LGJLLGFMONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xC41150", Offset = "0xC3FB50", VA = "0x180C41150")]
		public FGDGCNLFBBF GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x833B8A0", Offset = "0x833A2A0", VA = "0x18833B8A0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x833B9E0", Offset = "0x833A3E0", VA = "0x18833B9E0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x833B810", Offset = "0x833A210", VA = "0x18833B810")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8347000", Offset = "0x8345A00", VA = "0x188347000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8343370", Offset = "0x8341D70", VA = "0x188343370")]
		protected void OHDFMJEFAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8346DC0", Offset = "0x83457C0", VA = "0x188346DC0")]
		public void SetWaitForUgcTextureLoads(bool DIFBPHDJJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8346C40", Offset = "0x8345640", VA = "0x188346C40")]
		public void SetUgcTextureParameters(JLDDJMHEPLP PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8348030", Offset = "0x8346A30", VA = "0x188348030")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8340050", Offset = "0x833EA50", VA = "0x188340050")]
		[CompilerGenerated]
		private void HFEDGKPLFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x83410F0", Offset = "0x833FAF0", VA = "0x1883410F0")]
		[CompilerGenerated]
		private void KBIIILBFNKI(BAEKLBOPEFI GGJEMPPBOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x833E8F0", Offset = "0x833D2F0", VA = "0x18833E8F0")]
		[CompilerGenerated]
		private void DCDEOFGMCDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x833EC20", Offset = "0x833D620", VA = "0x18833EC20")]
		[CompilerGenerated]
		private void EENOGOGCOHJ(BAEKLBOPEFI GGJEMPPBOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x83407B0", Offset = "0x833F1B0", VA = "0x1883407B0")]
		[CompilerGenerated]
		private void IGKHIHBHNCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x83418C0", Offset = "0x83402C0", VA = "0x1883418C0")]
		[CompilerGenerated]
		private void MAALGBGCMJD(BAEKLBOPEFI GGJEMPPBOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x833C200", Offset = "0x833AC00", VA = "0x18833C200")]
		[CompilerGenerated]
		private void BFDIOEDJIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x833CA90", Offset = "0x833B490", VA = "0x18833CA90")]
		[CompilerGenerated]
		private void CANEIMELIEN(BAEKLBOPEFI GGJEMPPBOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8342690", Offset = "0x8341090", VA = "0x188342690")]
		[CompilerGenerated]
		private void MMGILKMMLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8341200", Offset = "0x833FC00", VA = "0x188341200")]
		[CompilerGenerated]
		private void KEDLGBHPLBM(BAEKLBOPEFI GGJEMPPBOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x83414B0", Offset = "0x833FEB0", VA = "0x1883414B0")]
		[CompilerGenerated]
		private void LDGFBCEBLFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8341490", Offset = "0x833FE90", VA = "0x188341490")]
		[CompilerGenerated]
		private void KLPFKLDMLON(BAEKLBOPEFI GGJEMPPBOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8341120", Offset = "0x833FB20", VA = "0x188341120")]
		[CompilerGenerated]
		internal static bool KDLEEFAMOOC(Transform OECMBJOIFDJ, IEnumerable<SkinnedMeshRenderer> PDECOBINNMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x833F7F0", Offset = "0x833E1F0", VA = "0x18833F7F0")]
		[DebuggerHidden]
		[CompilerGenerated]
		private Task GMHPEMPPAMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x833F800", Offset = "0x833E200", VA = "0x18833F800")]
		[CompilerGenerated]
		private void GNKEGKMIGKJ(BAEKLBOPEFI GGJEMPPBOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x833F760", Offset = "0x833E160", VA = "0x18833F760")]
		[CompilerGenerated]
		private void GGKODGJCADC(BAEKLBOPEFI GGJEMPPBOGN)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, GBAIPNMDKIG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct LBDHKFNJFOH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public DECEKEGDNPK avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x833A150", Offset = "0x8338B50", VA = "0x18833A150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x833A3E0", Offset = "0x8338DE0", VA = "0x18833A3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct DCJCOPPHDBA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			public BOIFAILEJMF avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x83368E0", Offset = "0x83352E0", VA = "0x1883368E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x8336AC0", Offset = "0x83354C0", VA = "0x188336AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct DNNHLFDHFLC : IAsyncStateMachine
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
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public BOIFAILEJMF avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x8351B20", Offset = "0x8350520", VA = "0x188351B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x8351CC0", Offset = "0x83506C0", VA = "0x188351CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct MMKAAMHFHGD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public DECEKEGDNPK avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x8352020", Offset = "0x8350A20", VA = "0x188352020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x83521D0", Offset = "0x8350BD0", VA = "0x1883521D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct CJHLLEEFANG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public BOIFAILEJMF avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			private TaskAwaiter<FAIGKHFAAMB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x8350F30", Offset = "0x834F930", VA = "0x188350F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x8351370", Offset = "0x834FD70", VA = "0x188351370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct PNGHJPJCDEJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public BOIFAILEJMF avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x8352230", Offset = "0x8350C30", VA = "0x188352230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x8352570", Offset = "0x8350F70", VA = "0x188352570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected const float CNKGNHBGEIN = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected const int BBICEFKIELD = 5;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly int GIIKPDNGNCL;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private static readonly int NEMNEHCDNNG;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private static readonly int GKOIDFNKEPH;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected static readonly Dictionary<DHNMEJJFOPB.GPPBLLODNFA, int> MBIDHAPPOCF;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> ECHJLNIMFLN;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected static readonly int JGLEJIEGIMF;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected static readonly int OCBALINMIBG;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected static readonly int CKEDDALDJDM;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected static readonly int NEDJIOEHMBC;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected static readonly int AGCNALPBLEL;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected static Vector2 DHOLAHJGPKP;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected static Vector2 KIGIECKOENK;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected static Vector2 ANEJKHGBGBH;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected static Vector2 LALKCFHBHMJ;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected static Vector2 MCKMOECCANP;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected static Vector2 BANGEJHIJBG;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected static Vector2 GGAMKANCNJI;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected static Vector2 FGNKBBBPLIM;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected static Vector2 OIANLHCHOFA;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected static Vector2 LCLOKMBEDEJ;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected static Vector2 JHBOINNAAEH;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected static Vector2 LJEEIIABHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private BOIFAILEJMF FJIIHCBCDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private FaceStyleSet BPIIDOLHFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected const int HIADJJLKIMA = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected int CHBBEIGLCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected int OBIMHAAIDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected int CPLLDMFCBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected int NNGPAPLCDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected Vector2 BOEBGBPIAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected float JBBMEHHGLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected float HOELCPNHHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected float ELLHPHABLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected Vector2 BCPMLENNLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected float OEHNCGDGGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected float DKCGNEDAHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected float BEPJDCKOPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		protected Vector2 GFJLJKEEFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		protected float JBMFKBEELCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		protected float HEEGGNONCOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected float GGEAPKAEKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected Vector2 DCOJKGPAICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		protected float CEFFIGEECEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		protected float PGGEEFAPGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected float AONPCHOLFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected List<SelectableFaceOption> PHNDJNGPOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected List<SelectableFaceOption> EDCEBFLFDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		protected List<SelectableFaceOption> AKBEAGEFNAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		protected List<SelectableFaceOption> DODNEAKCJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		protected Coroutine JOGINOPGCIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		protected int? OPBJIDDKOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		protected int APJINKCECIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected int KEPGPPCBJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		protected int BDMMGEKBBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		protected int HBJMGKAMMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		protected Sprite GLMLPPLBPDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		protected Sprite IPFKHNOALDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		protected Sprite NGIPICBGFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		protected Sprite OIDACJHEMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		protected bool BMCOGPALKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		protected string AMFFLFAAPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		protected string JNMFIIEJGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		protected string HAFDPMEFAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		protected string FBMDBMFCNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		protected AvatarConfiguration JMNPDPKGBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		protected FAIGKHFAAMB KLICBCMJFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private readonly List<Material> JACOJKLEEGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		protected NKBMEBEPJID PILDBLLFAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		protected Dictionary<string, int> GCDELFDGDFA;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public FaceStyleSet JLILABPKNBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x8350130", Offset = "0x834EB30", VA = "0x188350130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool GKHDDIPMIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xB61910", Offset = "0xB60310", VA = "0x180B61910", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x27909A0", Offset = "0x278F3A0", VA = "0x1827909A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected virtual bool PNGCOLJBJII
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected virtual bool GDHAHAHEJOD
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int IBHMFAICKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x834A230", Offset = "0x8348C30", VA = "0x18834A230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer KCOOFCMOLHN
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool BHDOHIOPOKF
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x13FA240", Offset = "0x13F8C40", VA = "0x1813FA240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x2791C20", Offset = "0x2790620", VA = "0x182791C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Renderer[] AIPAHGDLAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public bool PAKOANIODDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x8350180", Offset = "0x834EB80", VA = "0x188350180")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x8350340", Offset = "0x834ED40", VA = "0x188350340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		protected int KPLJMGJHPED
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x834D320", Offset = "0x834BD20", VA = "0x18834D320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected int MEHBLOAMKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x834A960", Offset = "0x8349360", VA = "0x18834A960")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public float IBGGNHGKOFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x8350160", Offset = "0x834EB60", VA = "0x188350160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x8350320", Offset = "0x834ED20", VA = "0x188350320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NOCNHILIHGH GEIBKNDDNKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xC42020", Offset = "0xC40A20", VA = "0x180C42020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xC91E30", Offset = "0xC90830", VA = "0x180C91E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public FAIGKHFAAMB KJNMNIODNEG
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xB879C0", Offset = "0xB863C0", VA = "0x180B879C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x83502A0", Offset = "0x834ECA0", VA = "0x1883502A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public NoseFaceOption FKOJHHKPHMM
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xC41150", Offset = "0xC3FB50", VA = "0x180C41150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xC31C00", Offset = "0xC30600", VA = "0x180C31C00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		protected NKBMEBEPJID KLCABPMOOPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x834B3E0", Offset = "0x8349DE0", VA = "0x18834B3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action EIOMKHPCCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8350080", Offset = "0x834EA80", VA = "0x188350080")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x83501F0", Offset = "0x834EBF0", VA = "0x1883501F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x834CA50", Offset = "0x834B450", VA = "0x18834CA50")]
		public void LocalPlayEmote(DHNMEJJFOPB.GPPBLLODNFA OFDIJFMEJLP, float PNMJKMGGLOD = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x834C3B0", Offset = "0x834ADB0", VA = "0x18834C3B0")]
		public bool IsEmotePlaying(DHNMEJJFOPB.GPPBLLODNFA OFDIJFMEJLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x834DFA0", Offset = "0x834C9A0", VA = "0x18834DFA0")]
		public void SetIdleHappy(bool NFHBIOAJOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x834B360", Offset = "0x8349D60", VA = "0x18834B360")]
		protected void HDIKMJBGGOP(bool EHBGINECADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x834CEE0", Offset = "0x834B8E0", VA = "0x18834CEE0")]
		protected void MMJINDBIEJM(bool FKPEIPIKMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x834BD20", Offset = "0x834A720", VA = "0x18834BD20")]
		protected void IMFKBMPOLLD(EHMKAKBCPJB GDCGOHLFNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x834D2B0", Offset = "0x834BCB0", VA = "0x18834D2B0")]
		protected void NCJFDKMOMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x834D670", Offset = "0x834C070", VA = "0x18834D670")]
		public void PlayExpression(int NEGDFJCIMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x834C5B0", Offset = "0x834AFB0", VA = "0x18834C5B0")]
		protected void KPMHDJIHMON(bool DCDOJKILEEI, bool PODECIJHOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x834B320", Offset = "0x8349D20", VA = "0x18834B320")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType KBFIENDMOAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x834BE80", Offset = "0x834A880", VA = "0x18834BE80")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration JMNPDPKGBHB, BOIFAILEJMF FJBHHBODDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x834DC40", Offset = "0x834C640", VA = "0x18834DC40")]
		[AsyncStateMachine(typeof(LBDHKFNJFOH))]
		public Task SetFaceSettings(DECEKEGDNPK AIFAODPNIHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x834DD30", Offset = "0x834C730", VA = "0x18834DD30")]
		[AsyncStateMachine(typeof(DCJCOPPHDBA))]
		public Task SetFaceSettings(int BMABEIAJKGF, int ODAAMKOJGOB, int FCBJOLKEGLN, int NMPOBNMHAAJ, BOIFAILEJMF FJBHHBODDIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x834E020", Offset = "0x834CA20", VA = "0x18834E020")]
		[AsyncStateMachine(typeof(DNNHLFDHFLC))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType KBFIENDMOAP, int CMAPMNHBFMD, BOIFAILEJMF FJBHHBODDIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x834AAC0", Offset = "0x83494C0", VA = "0x18834AAC0")]
		protected void EHHMIEGIKIM(FaceFeatureType KBFIENDMOAP, IBNJPOEEICJ PAMILKIJNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x834B5E0", Offset = "0x8349FE0", VA = "0x18834B5E0")]
		protected void ILEFGIAFEHK(FaceFeatureType KBFIENDMOAP, int CMAPMNHBFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x834B140", Offset = "0x8349B40", VA = "0x18834B140")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x834B050", Offset = "0x8349A50", VA = "0x18834B050")]
		[AsyncStateMachine(typeof(MMKAAMHFHGD))]
		protected Task GLKGBDOJHLN(DECEKEGDNPK AIFAODPNIHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x834A360", Offset = "0x8348D60", VA = "0x18834A360")]
		protected void ANJBOCCJOJN(DECEKEGDNPK AIFAODPNIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x834D040", Offset = "0x834BA40", VA = "0x18834D040")]
		protected static void MMLOACMMLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x834ADC0", Offset = "0x83497C0", VA = "0x18834ADC0")]
		private void FKGKNFJJNIM(bool LNBBJFPKJNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x834CB50", Offset = "0x834B550", VA = "0x18834CB50")]
		protected void MCOAGOHECPG(FaceFeatureType KBFIENDMOAP, Vector2 GBPDMHAFFAI, BOIFAILEJMF FJBHHBODDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x834D690", Offset = "0x834C090", VA = "0x18834D690")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType KBFIENDMOAP, Vector2 AMLPLELHGOK, BOIFAILEJMF FJBHHBODDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x834B460", Offset = "0x8349E60", VA = "0x18834B460")]
		protected void ILADLDIJCJA(FaceFeatureType KBFIENDMOAP, float HBOHCMBAGOG, BOIFAILEJMF FJBHHBODDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x834AC40", Offset = "0x8349640", VA = "0x18834AC40")]
		protected void EKNICHIDHLB(FaceFeatureType KBFIENDMOAP, float AMHDLJKDJBK, BOIFAILEJMF FJBHHBODDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x834D1E0", Offset = "0x834BBE0", VA = "0x18834D1E0")]
		protected void NCAIHLNEHMJ(FaceFeatureType KBFIENDMOAP, float DEDMEALJJPH, BOIFAILEJMF FJBHHBODDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x834DA20", Offset = "0x834C420", VA = "0x18834DA20")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType KBFIENDMOAP, float PGBMHAOKGHM, BOIFAILEJMF FJBHHBODDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x834C4D0", Offset = "0x834AED0", VA = "0x18834C4D0")]
		[AsyncStateMachine(typeof(CJHLLEEFANG))]
		protected Task JIBIHBPAAGK(BOIFAILEJMF FJBHHBODDIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x834C1A0", Offset = "0x834ABA0", VA = "0x18834C1A0")]
		public void InitializeFaceFeatureStyleSet(BOIFAILEJMF FJBHHBODDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x834D380", Offset = "0x834BD80", VA = "0x18834D380")]
		protected bool OLMIMGBLADF(string HKIIDPABGFE, [Out] int KABGMIEBEFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x834A820", Offset = "0x8349220", VA = "0x18834A820")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x834E130", Offset = "0x834CB30", VA = "0x18834E130", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x834D460", Offset = "0x834BE60", VA = "0x18834D460")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x834F130", Offset = "0x834DB30", VA = "0x18834F130")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x834A9C0", Offset = "0x83493C0", VA = "0x18834A9C0")]
		[AsyncStateMachine(typeof(PNGHJPJCDEJ))]
		public Task BuildFaceStyleAsyncIfChanged(BOIFAILEJMF FJBHHBODDIK, bool BDJNEFCCEFH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x834EA40", Offset = "0x834D440", VA = "0x18834EA40")]
		public void UpdateFaceDisplays(bool IPJPEFIPMBG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8349AE0", Offset = "0x83484E0", VA = "0x188349AE0")]
		protected bool AAEOCAHOPDH(bool IPJPEFIPMBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x834E7A0", Offset = "0x834D1A0", VA = "0x18834E7A0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x834DE60", Offset = "0x834C860", VA = "0x18834DE60")]
		public void SetFaceSpriteIndices(string JCDCBGGHJOJ, string DLHFGKDHGKE, string OMEAODLNACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x834E140", Offset = "0x834CB40", VA = "0x18834E140")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x834EC60", Offset = "0x834D660", VA = "0x18834EC60")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x834EE50", Offset = "0x834D850", VA = "0x18834EE50")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x834BD90", Offset = "0x834A790", VA = "0x18834BD90")]
		protected void IMILEPIPFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x834C670", Offset = "0x834B070", VA = "0x18834C670")]
		private void LGCFNDCFKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x834C8A0", Offset = "0x834B2A0", VA = "0x18834C8A0")]
		private void LJADFOKJJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x834FE20", Offset = "0x834E820", VA = "0x18834FE20")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xADAB70", Offset = "0xAD9570", VA = "0x180ADAB70", Slot = "4")]
		private bool NNIBCAIEOLK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct GAEIONLAHKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public string DDPJMHMICBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public int BKICOPKGOOC;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private struct LJBBLCCGNJJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x8351E20", Offset = "0x8350820", VA = "0x188351E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private struct ACPDBLMNPNM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x8350850", Offset = "0x834F250", VA = "0x188350850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x8350D30", Offset = "0x834F730", VA = "0x188350D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public BOIFAILEJMF avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public FKFKFDENFBG useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AFKHHJFHFCH hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public FGDGCNLFBBF HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public GameObject torsoModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public GameObject legsModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public GameObject validationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public bool showModestyAndValidationGuidelines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private EEMBOJLPGKK CJKEFIALDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private AnimatorOverrideController OFAJPLNIAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> MMHGDKGILJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public readonly GAEIONLAHKJ[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public readonly (string, DBPOEHMBPJL)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x249")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24A")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		protected bool MDJGPDAKFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		protected Guid HMPCKMDLNBD;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		protected static Guid ACDLKMOCANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private ICNBFDLCIDH IALPMJAPHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private NOCNHILIHGH CPIOOIKMBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private KHMNFMMABMJ EBAHABHLKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private KHMNFMMABMJ HMMALMLIICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private AdditionalHatData PNHLJLDNNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private readonly Dictionary<GameObject, IPHOENMGNFP> EHOANIBEEJF;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public static Func<BMBPHCMGKOJ> HKKAPCFKJCD
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x83574C0", Offset = "0x8355EC0", VA = "0x1883574C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x8357B00", Offset = "0x8356500", VA = "0x188357B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public bool LLNMEEPMMHG
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x8357620", Offset = "0x8356020", VA = "0x188357620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool NLEKMBNKBCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x8357510", Offset = "0x8355F10", VA = "0x188357510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public PlayerAvatarDisplayBase NMKCEKNAPGI
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xC26D40", Offset = "0xC25740", VA = "0x180C26D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		protected static Guid HONJLDIOAKE
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x8354BA0", Offset = "0x83535A0", VA = "0x188354BA0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public (GameObject, EHMKAKBCPJB)[] DCBLKBKBNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x8357730", Offset = "0x8356130", VA = "0x188357730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x83551B0", Offset = "0x8353BB0", VA = "0x1883551B0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x8354D40", Offset = "0x8353740", VA = "0x188354D40")]
		private IEnumerable<GameObject> OMLOELNLCLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x83556D0", Offset = "0x83540D0", VA = "0x1883556D0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x83525D0", Offset = "0x8350FD0", VA = "0x1883525D0")]
		private void APOFKOCIMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x159A5B0", Offset = "0x1598FB0", VA = "0x18159A5B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8353B40", Offset = "0x8352540", VA = "0x188353B40")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x83556E0", Offset = "0x83540E0", VA = "0x1883556E0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x83554F0", Offset = "0x8353EF0", VA = "0x1883554F0")]
		public void ShowPose(AnimationClip PIPEBBLMJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x83556A0", Offset = "0x83540A0", VA = "0x1883556A0")]
		public void ShowPose(string HGIMINPOINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8355320", Offset = "0x8353D20", VA = "0x188355320")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x83551C0", Offset = "0x8353BC0", VA = "0x1883551C0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8356190", Offset = "0x8354B90", VA = "0x188356190")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8355FF0", Offset = "0x83549F0", VA = "0x188355FF0")]
		public void UpdateFaceAndBodyShapes(bool BDJNEFCCEFH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x83565B0", Offset = "0x8354FB0", VA = "0x1883565B0")]
		public void UpdateNoseShape(EJOAHECBEFE PMEKGOFHJPP, bool BDJNEFCCEFH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8356570", Offset = "0x8354F70", VA = "0x188356570")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x8353820", Offset = "0x8352220", VA = "0x188353820", Slot = "4")]
		protected virtual void IHPKNOHDPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x8354840", Offset = "0x8353240", VA = "0x188354840", Slot = "5")]
		protected virtual void MJIFIHPGAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x8352950", Offset = "0x8351350", VA = "0x188352950")]
		public void ApplyHatData(AdditionalHatData DNLHGEAPHCJ, bool FEKMLHGJPNL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8352790", Offset = "0x8351190", VA = "0x188352790")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x8352CB0", Offset = "0x83516B0", VA = "0x188352CB0")]
		public void ApplyHatUVOverride(Vector2 ACJLHBDCNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8352BD0", Offset = "0x83515D0", VA = "0x188352BD0")]
		public void ApplyHatPositionAdjustment(Vector3 IIMHMEPOMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x8352C40", Offset = "0x8351640", VA = "0x188352C40")]
		public void ApplyHatRotationAdjustment(Vector3 JLGCDHFHJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x8352DB0", Offset = "0x83517B0", VA = "0x188352DB0")]
		public DFPKOJIPBPI BuildAvatarItemSelection(GameObject GMLADKDADNH, BOIFAILEJMF BIKJIJKPPJA, EHMKAKBCPJB IHAGKOOJJKE)
		{
			return default(DFPKOJIPBPI);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x8352E50", Offset = "0x8351850", VA = "0x188352E50")]
		public void BuildAvatar(bool BDJNEFCCEFH = false, bool FEKMLHGJPNL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x8355A30", Offset = "0x8354430", VA = "0x188355A30")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x83528D0", Offset = "0x83512D0", VA = "0x1883528D0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x83563C0", Offset = "0x8354DC0", VA = "0x1883563C0")]
		public void UpdateHatAnchor(bool FEKMLHGJPNL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x83560E0", Offset = "0x8354AE0", VA = "0x1883560E0")]
		[AsyncStateMachine(typeof(LJBBLCCGNJJ))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x8354240", Offset = "0x8352C40", VA = "0x188354240")]
		[AsyncStateMachine(typeof(ACPDBLMNPNM))]
		private Task JJGBLLKOGCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8354AB0", Offset = "0x83534B0", VA = "0x188354AB0")]
		private void NDOEPNJLCIP(FaceFeatureType OKHJLKIMLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8352D20", Offset = "0x8351720", VA = "0x188352D20")]
		private void BKCDAMNCOJL(FaceFeatureType OKHJLKIMLFB, [Out] float OKIHGHPHOPO, [Out] float MPBIJPKCAND, [Out] float NIAMAMNMMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x8355EB0", Offset = "0x83548B0", VA = "0x188355EB0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x8356220", Offset = "0x8354C20", VA = "0x188356220")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x8354310", Offset = "0x8352D10", VA = "0x188354310")]
		private void KIFJODJGAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private void MINKOOOMJDN(IPHOENMGNFP EAOHNMPFEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private void CCIJFEEEGMA(IPHOENMGNFP EAOHNMPFEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x83534A0", Offset = "0x8351EA0", VA = "0x1883534A0")]
		private void GDACOJDDOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x8356640", Offset = "0x8355040", VA = "0x188356640")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x8354C90", Offset = "0x8353690", VA = "0x188354C90")]
		[CompilerGenerated]
		private DFPKOJIPBPI OBLAAIFBIFH((GameObject, EHMKAKBCPJB) CCJLLLDEAFO)
		{
			return default(DFPKOJIPBPI);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct DFPKOJIPBPI
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class KLLAKFAKLEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KLLAKFAKLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8351DA0", Offset = "0x83507A0", VA = "0x188351DA0")]
		internal bool KKJEKCJJGPA(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private IPHOENMGNFP KPDOLJJIILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private EHMKAKBCPJB CNGNNPABEDJ;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public IPHOENMGNFP AKOAJOFMJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EHMKAKBCPJB ILBGGFKMPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xECC7E0", Offset = "0xECB1E0", VA = "0x180ECC7E0")]
		get
		{
			return default(EHMKAKBCPJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public string ENMICGMLGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x83519C0", Offset = "0x83503C0", VA = "0x1883519C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool CKLKGMAJIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8351970", Offset = "0x8350370", VA = "0x188351970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool AILNHHOBNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x83513D0", Offset = "0x834FDD0", VA = "0x1883513D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1B11FE0", Offset = "0x1B109E0", VA = "0x181B11FE0")]
	public DFPKOJIPBPI(IPHOENMGNFP EAOHNMPFEDH, EHMKAKBCPJB GDCGOHLFNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x8351420", Offset = "0x834FE20", VA = "0x188351420")]
	public bool DMDAKJBMCMM(OutfitType MJBEFJEGBGJ, EHMKAKBCPJB PNLEKLFCAKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x83514F0", Offset = "0x834FEF0", VA = "0x1883514F0")]
	public bool JBAOEKODFIP(OutfitType MJBEFJEGBGJ, EHMKAKBCPJB PNLEKLFCAKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x8351780", Offset = "0x8350180", VA = "0x188351780")]
	public bool LDIBMPLBHKA(DFPKOJIPBPI LJDPIEGIBPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class CCPJPJFMJBG
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class HLLOKLJCJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HLLOKLJCJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x8351D20", Offset = "0x8350720", VA = "0x188351D20")]
		internal bool KKJEKCJJGPA(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private IPHOENMGNFP KPDOLJJIILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private DNOBJDOAFEC CNGNNPABEDJ;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IPHOENMGNFP AKOAJOFMJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public DNOBJDOAFEC ILBGGFKMPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		get
		{
			return default(DNOBJDOAFEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Color? JCMKCPCHLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B10", Offset = "0xAB6510", VA = "0x180AB7B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B90", Offset = "0xAB6590", VA = "0x180AB7B90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3? OHBEIHCPLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xF84360", Offset = "0xF82D60", VA = "0x180F84360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xF83BD0", Offset = "0xF825D0", VA = "0x180F83BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x8350EC0", Offset = "0x834F8C0", VA = "0x188350EC0")]
	public CCPJPJFMJBG(IPHOENMGNFP EAOHNMPFEDH, DNOBJDOAFEC GDCGOHLFNLP, Color? EOGEFFOIIOP, Vector3? AMHDLJKDJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8350D90", Offset = "0x834F790", VA = "0x188350D90")]
	public bool LDIBMPLBHKA(CCPJPJFMJBG LJDPIEGIBPB)
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
