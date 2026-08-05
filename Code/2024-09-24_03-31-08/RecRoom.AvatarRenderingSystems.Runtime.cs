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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6A1F6B0", Offset = "0x6A1E0B0", VA = "0x186A1F6B0", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A2F570", Offset = "0x6A2DF70", VA = "0x186A2F570", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6A2ECB0", Offset = "0x6A2D6B0", VA = "0x186A2ECB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A2EBD0", Offset = "0x6A2D5D0", VA = "0x186A2EBD0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A2EC70", Offset = "0x6A2D670", VA = "0x186A2EC70")]
		public RecNetCDNAssetReference(RecNetCDNKey COMNIKKFEEB)
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
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8892C0", Offset = "0x887CC0", VA = "0x1808892C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A2ECF0", Offset = "0x6A2D6F0", VA = "0x186A2ECF0")]
		public static RecNetCDNKey KOPKHDLJHOP(string FFEKFJCNKFH, string LJAMAJDKFBF = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6234230", Offset = "0x6232C30", VA = "0x186234230")]
		public void GCDFLIOIMMC(string DCLHNEKEPIG, string IHNIDNBHBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A2EDF0", Offset = "0x6A2D7F0", VA = "0x186A2EDF0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DEKINLCKNLM]
public class HIHLCFHNGHD : EPLIMMLNOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> PGBBIFGLPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> EFINMJDNCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> IJAACGPCMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> JEOHEFIJLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> ICJNFNDNHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> FBBFHGIEJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> CDCJCIKJOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator PKCIAMEAOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected CPJHDJFONNI MJMJACPJMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte KPANKKIAIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> FLFMJMMBLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> AFKHGDBANOG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A660", Offset = "0x6A19060", VA = "0x186A1A660", Slot = "4")]
	public void GOCPGLDBIPD(Mesh LDNHICGPCIN, Matrix4x4 PGKCIOEMCIG, byte[] FNJEDFOJMMF, bool FBBPHGJADOL = false, PCNNDLGLKGM.MLOLFLCAEKK CCPAFCPFGDJ = (PCNNDLGLKGM.MLOLFLCAEKK)0, int DMDHAFGNAJI = -1, bool KLNMFEDDGJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A620", Offset = "0x6A19020", VA = "0x186A1A620", Slot = "5")]
	public void ELOPGGHIDEP(Allocator MPFEIGMBFCP, CPJHDJFONNI HPBMCJPOHKA, byte IFKMCFMPEON, [Optional] IList<int> MFOPCLCHPBM, [Optional] IList<int> EHIIBACCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A870", Offset = "0x6A19270", VA = "0x186A1A870")]
	private static void JICAKCKCCMN(Mesh LDNHICGPCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A1AAC0", Offset = "0x6A194C0", VA = "0x186A1AAC0")]
	public HIHLCFHNGHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DEKINLCKNLM]
public struct DMHCLKEGFJB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public LMKIJCELCLE KNAEDMKHOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int OHMCPIDNGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public JAINFKGLLHI LGNHLNKNKNE;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A17A40", Offset = "0x6A16440", VA = "0x186A17A40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[DEKINLCKNLM]
public struct JAINFKGLLHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HELHMACHBMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 KHLNAEECHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 MLNCIIKLLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 HLAFCKKNDEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct IOJCAHOBPAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float OJEAMNHPFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float CAONJNJNLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float AHIEGPCCFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float IAAMDEFEFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte OANDCEHDDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte EMKAOKFCOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte EFGLLGJHCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte GNDKLOFPPMD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct CLGJBBOIDAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half OJEAMNHPFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half CAONJNJNLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half AHIEGPCCFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half IAAMDEFEFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte OANDCEHDDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte EMKAOKFCOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte EFGLLGJHCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte GNDKLOFPPMD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct NPDCOMLBAMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 BJCIGJMGMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 HIHACEGCNEG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct KGNALPNBHHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 BJCIGJMGMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 HIHACEGCNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 FKPILGFCHBC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct MDFEIICJCFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 BJCIGJMGMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 HIHACEGCNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 FKPILGFCHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 IFCJACHHENH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DMAJLKMAHFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 BJCIGJMGMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 HIHACEGCNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 FKPILGFCHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 IFCJACHHENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 JPHNBCGOOPF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct CDDGEKIANPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float OJEAMNHPFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float CAONJNJNLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float AHIEGPCCFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float IAAMDEFEFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int OANDCEHDDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int EMKAOKFCOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int EFGLLGJHCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int GNDKLOFPPMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct IELLAANMLNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color BJCIGJMGMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 HIHACEGCNEG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct GJBNDEFDNPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color BJCIGJMGMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 HIHACEGCNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 FKPILGFCHBC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct JNIFBMDFBIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color BJCIGJMGMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 HIHACEGCNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 FKPILGFCHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 IFCJACHHENH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct OAADMKCLMGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color BJCIGJMGMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 HIHACEGCNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 FKPILGFCHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 IFCJACHHENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 JPHNBCGOOPF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool OHFODBPBEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<HELHMACHBMF> JBEOBLAIPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<NPDCOMLBAMI> PJLCJBMLHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<KGNALPNBHHB> ENHLGKIOPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<MDFEIICJCFK> GDLHMJJFNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<DMAJLKMAHFF> HPHJEGEIECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<CLGJBBOIDAK> NNHENHHEMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<IOJCAHOBPAB> IMOLKDKKACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<IELLAANMLNE> HBNIAILJPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<GJBNDEFDNPH> MGJGNFJOEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<JNIFBMDFBIO> IEJFBFNHKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<OAADMKCLMGA> CBMAKDNBDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<CDDGEKIANPC> ACFGNJAJMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> MNCNJNLDFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> PHIKLFHIIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> OIIPMDKANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> NJENFPBINOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> PJOBJLGBGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> BPBECKEKPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> FEDHCKMAPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> MPPBPLGOPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> LFOFLLOHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool IKKBOAPAJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool JMPBLJFNPGB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CEBCLOAKDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BE50", Offset = "0x6A1A850", VA = "0x186A1BE50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C4E0", Offset = "0x6A1AEE0", VA = "0x186A1C4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BDGNILFDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C4C0", Offset = "0x6A1AEC0", VA = "0x186A1C4C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BE40", Offset = "0x6A1A840", VA = "0x186A1BE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BKBKGCGLPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C4D0", Offset = "0x6A1AED0", VA = "0x186A1C4D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C970", Offset = "0x6A1B370", VA = "0x186A1C970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KAAGLFGBKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C980", Offset = "0x6A1B380", VA = "0x186A1C980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D1F0", Offset = "0x6A1BBF0", VA = "0x186A1D1F0")]
	public JAINFKGLLHI(int BDPIJAGKBEL, int OABDDCANPEA, int OLNLFCDGOPA, int FKNOKBNDHJP, Allocator MPFEIGMBFCP, int MADDIIAPGBO, OCJHHKFBJDH DHKAJEKLDIN, bool IKKBOAPAJGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C9F0", Offset = "0x6A1B3F0", VA = "0x186A1C9F0")]
	public void IODOHGJBEBF(int ENMILGHAHOM, Vector3 NLEGDNPENLM, Vector3 JCHGHJIDPLJ, Vector4 NNEFLDDEJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1CA80", Offset = "0x6A1B480", VA = "0x186A1CA80")]
	public void JFJJGHKEIGA(int ENMILGHAHOM, BoneWeight PIOGMOBBHMF, NativeSlice<byte> FNJEDFOJMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A1CEB0", Offset = "0x6A1B8B0", VA = "0x186A1CEB0")]
	public Color JOAHPLBFIIN(int ENMILGHAHOM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A1BE60", Offset = "0x6A1A860", VA = "0x186A1BE60")]
	public void BKBJFIPGOGI(int ENMILGHAHOM, Color JGMIDFFABNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C4F0", Offset = "0x6A1AEF0", VA = "0x186A1C4F0")]
	public void GABEAHKBEEM(byte GEOCBCMJGLG, int ENMILGHAHOM, Vector2 MPBOPFFDAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D1E0", Offset = "0x6A1BBE0", VA = "0x186A1D1E0")]
	public void LKINPLFAGAL(int ENMILGHAHOM, int CDHCGODDABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A1AEA0", Offset = "0x6A198A0", VA = "0x186A1AEA0")]
	public bool AAAELLMPBMN(int GEOCBCMJGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C8A0", Offset = "0x6A1B2A0", VA = "0x186A1C8A0")]
	public void HEDJJIBENLA(int OMJBBKNLDGL, int EDCGGCHLNEI, int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A1C260", Offset = "0x6A1AC60", VA = "0x186A1C260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A1AF00", Offset = "0x6A19900", VA = "0x186A1AF00")]
	public Mesh AAGMBJEHJIP([Optional] string DNKKNNFJONL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NativeContainer]
[DEKINLCKNLM]
[DefaultMember("Item")]
public struct LMKIJCELCLE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray MMJPIJBPOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> OMMJFGMAIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> DPKHDMNCAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> MPPBPLGOPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> JIJBFNMPFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> IDPMJBKOILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> COPHFOJEDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> PAHACGOBMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> JKGJDJPAMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> KEPKNICLFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> MJMFIGPBPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> KLNMFEDDGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> DMDHAFGNAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool IKKBOAPAJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> DBOAONNCMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool JMPBLJFNPGB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GIKIBIEEIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E1A0", Offset = "0x6A1CBA0", VA = "0x186A1E1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MHIJBDJOJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DEE0", Offset = "0x6A1C8E0", VA = "0x186A1DEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LHLHMIHHGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E1B0", Offset = "0x6A1CBB0", VA = "0x186A1E1B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JBNCALADOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DF00", Offset = "0x6A1C900", VA = "0x186A1DF00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DF20", Offset = "0x6A1C920", VA = "0x186A1DF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int CEBCLOAKDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DED0", Offset = "0x6A1C8D0", VA = "0x186A1DED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E0A0", Offset = "0x6A1CAA0", VA = "0x186A1E0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CIEMGIMKPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DEC0", Offset = "0x6A1C8C0", VA = "0x186A1DEC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DF10", Offset = "0x6A1C910", VA = "0x186A1DF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public CPJHDJFONNI GKPGBPKIGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E280", Offset = "0x6A1CC80", VA = "0x186A1E280")]
		get
		{
			return default(CPJHDJFONNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DEF0", Offset = "0x6A1C8F0", VA = "0x186A1DEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte ICDIOHJBAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E190", Offset = "0x6A1CB90", VA = "0x186A1E190")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E180", Offset = "0x6A1CB80", VA = "0x186A1E180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OLDEKFPFBBO BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E290", Offset = "0x6A1CC90", VA = "0x186A1E290")]
		get
		{
			return default(OLDEKFPFBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E4E0", Offset = "0x6A1CEE0", VA = "0x186A1E4E0")]
	public LMKIJCELCLE(IList<Mesh> CKFEPJHINEL, IList<Matrix4x4> NDOFAEAKFMH, IList<bool> KLNMFEDDGJI, byte IFKMCFMPEON, IList<byte[]> ILPFJFPKHGP, IList<int> KDIFCNJDENH, IList<bool> BFFPJLBGDKN, IList<int> DMDHAFGNAJI, IList<int> MFOPCLCHPBM, IList<int> LMEMHCMBOJN, Allocator MPFEIGMBFCP, CPJHDJFONNI HPBMCJPOHKA, bool IKKBOAPAJGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E0B0", Offset = "0x6A1CAB0", VA = "0x186A1E0B0")]
	public JAINFKGLLHI GEGHIACLDPA(Allocator MPFEIGMBFCP, OCJHHKFBJDH DHKAJEKLDIN)
	{
		return default(JAINFKGLLHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DF30", Offset = "0x6A1C930", VA = "0x186A1DF30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DEKINLCKNLM]
public class FDLIEAFAEEE : HIHLCFHNGHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool MHDGEFBNOHO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker IJCCBDKDDME;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A19520", Offset = "0x6A17F20", VA = "0x186A19520")]
	public LMKIJCELCLE KGEJLOPJAIC()
	{
		return default(LMKIJCELCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A19820", Offset = "0x6A18220", VA = "0x186A19820")]
	public FDLIEAFAEEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OLDEKFPFBBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData FKCDKAEHBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> MPPBPLGOPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> DHLLIINDLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int DOEKDDJMFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 GKPNJMEJDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int BPOIDABBDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> FNJEDFOJMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool HEBPOBEOIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int PJIHHKDHNID;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OBOOFNFPMMC : GEBCNIOAIHJ
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class DJBJMDNPHHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly BDAPCPEBHHJ LFLMBGCBOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		protected bool BFANOKKFBFL;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool CGDGBLPBPOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool PDLBILCKFII
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual PCNNDLGLKGM.MLOLFLCAEKK BPOIDABBDJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "6")]
			get
			{
				return default(PCNNDLGLKGM.MLOLFLCAEKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool DOJOMBANMNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB6AD30", Offset = "0xB69730", VA = "0x180B6AD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool EIIMCMGDAFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x18025A0", Offset = "0x1800FA0", VA = "0x1818025A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool DAOABCGACMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6A17A30", Offset = "0x6A16430", VA = "0x186A17A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool ACJJAFKNEMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6A17A10", Offset = "0x6A16410", VA = "0x186A17A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		protected DJBJMDNPHHE(BDAPCPEBHHJ GBLDMPDBLAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract KGIOENCPIOK MCCDEALEENK(int[] OMMDAGLCJDD, List<NLFKKAGDIKB> HHLOFGIBNHA, List<NLFKKAGDIKB> FKJOKMJNNJB);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CMPDPGHEHLK POACCGKCDIN(uint PDJBKOAOLLN, AvatarSkinnedMeshBoneOrderRemapsData DNAFOCBMOHD);
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class GBBHBAKGAEB : DJBJMDNPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class COKJGFJIDIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public NNLLBGLJADF<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public GBBHBAKGAEB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public COKJGFJIDIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6A173E0", Offset = "0x6A15DE0", VA = "0x186A173E0")]
			internal void PDJIKGEAOLK(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly AvatarSkinAssetItem.BCAJAAJCJOA GODEHIKNGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly AssetReference LBCJCIHHBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly PCNNDLGLKGM.MLOLFLCAEKK PKBPPDEDIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly ANINBIHMFJP? AONBJIDPEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly Material[] DHMJJEAOAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private SkinnedMeshRenderer[] JPLOKLDHOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private AvatarSkinAssetItem INIMLCOFMNH;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override PCNNDLGLKGM.MLOLFLCAEKK BPOIDABBDJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884030", VA = "0x180885630", Slot = "6")]
			get
			{
				return default(PCNNDLGLKGM.MLOLFLCAEKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A1C0", Offset = "0x6A18BC0", VA = "0x186A1A1C0")]
		public GBBHBAKGAEB(AvatarSkinAssetItem.BCAJAAJCJOA KEIEOCBKGJK, AssetReference BKNBPMNPGHE, Material MNOKGJDEKKA, BDAPCPEBHHJ EGKBNBCGHOD, PCNNDLGLKGM.MLOLFLCAEKK JOMGKFCDPME = (PCNNDLGLKGM.MLOLFLCAEKK)0, [Optional] ANINBIHMFJP? JOANBENHFDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A2D0", Offset = "0x6A18CD0", VA = "0x186A1A2D0")]
		public GBBHBAKGAEB(AvatarSkinAssetItem.BCAJAAJCJOA KEIEOCBKGJK, AssetReference BKNBPMNPGHE, Material MNOKGJDEKKA, PCNNDLGLKGM.MLOLFLCAEKK JOMGKFCDPME = (PCNNDLGLKGM.MLOLFLCAEKK)0, [Optional] ANINBIHMFJP? JOANBENHFDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A19CA0", Offset = "0x6A186A0", VA = "0x186A19CA0", Slot = "7")]
		public override KGIOENCPIOK MCCDEALEENK(int[] OMMDAGLCJDD, List<NLFKKAGDIKB> HHLOFGIBNHA, List<NLFKKAGDIKB> FKJOKMJNNJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A19E70", Offset = "0x6A18870", VA = "0x186A19E70", Slot = "8")]
		public override CMPDPGHEHLK POACCGKCDIN(uint PDJBKOAOLLN, AvatarSkinnedMeshBoneOrderRemapsData DNAFOCBMOHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A150", Offset = "0x6A18B50", VA = "0x186A1A150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class NGFLGIPGAKF : DJBJMDNPHHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly LEMJPPFPKJJ GFEMHFPIECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private NNLLBGLJADF<IMLBDEIEBKN> KHEIKOANOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public IMLBDEIEBKN IKEDPACIJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private NNLLBGLJADF<Material[]> PMNEJFKPCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Material[] ABBBIDKKMFD;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool CGDGBLPBPOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool PDLBILCKFII
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6A1F8C0", Offset = "0x6A1E2C0", VA = "0x186A1F8C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A20490", Offset = "0x6A1EE90", VA = "0x186A20490")]
		public NGFLGIPGAKF(BDAPCPEBHHJ GBLDMPDBLAA, LEMJPPFPKJJ MOKFJMJCPNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A1FE90", Offset = "0x6A1E890", VA = "0x186A1FE90", Slot = "7")]
		public override KGIOENCPIOK MCCDEALEENK(int[] OMMDAGLCJDD, List<NLFKKAGDIKB> HHLOFGIBNHA, List<NLFKKAGDIKB> FKJOKMJNNJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A20310", Offset = "0x6A1ED10", VA = "0x186A20310", Slot = "8")]
		public override CMPDPGHEHLK POACCGKCDIN(uint PDJBKOAOLLN, AvatarSkinnedMeshBoneOrderRemapsData DNAFOCBMOHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A1F920", Offset = "0x6A1E320", VA = "0x186A1F920")]
		public CMPDPGHEHLK FLEHDJDGPGL(GameObject LGHOHMCPDNA, uint PDJBKOAOLLN, bool FKGJBLDIFOE, bool FEALIMJMLLA, AvatarSkinnedMeshBoneOrderRemapsData DNAFOCBMOHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A1FB30", Offset = "0x6A1E530", VA = "0x186A1FB30")]
		public static bool JJEODAAJCLF(Renderer[] NGNEIPPIIED, string EAAMDIIGJCA, [Out] Renderer HIDIFHELDGJ, [Out] Renderer FMOGGKABMLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A20440", Offset = "0x6A1EE40", VA = "0x186A20440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A1F800", Offset = "0x6A1E200", VA = "0x186A1F800")]
		private (NNLLBGLJADF<IMLBDEIEBKN>, NNLLBGLJADF<Material[]>) CKPDNDIBKHB()
		{
			return default((NNLLBGLJADF<IMLBDEIEBKN>, NNLLBGLJADF<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x44B9E00", Offset = "0x44B8800", VA = "0x1844B9E00")]
		[CompilerGenerated]
		private void EEIOOLOLHOB(IMLBDEIEBKN NLAECIHBKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8890B0", Offset = "0x887AB0", VA = "0x1808890B0")]
		[CompilerGenerated]
		private void BGLLKEJJCDL(Material[] NLAECIHBKHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IMDHGNFFNFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public ENPMHBJBAFJ avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public OBOOFNFPMMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CJIKIHCHPEJ buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public IMDHGNFFNFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6A1AE30", Offset = "0x6A19830", VA = "0x186A1AE30")]
		internal bool FCEEGEGNJFE(LEMJPPFPKJJ item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A1AD80", Offset = "0x6A19780", VA = "0x186A1AD80")]
		internal void EPLGHLNKLNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6A1AE80", Offset = "0x6A19880", VA = "0x186A1AE80")]
		internal void NHPPIMFOLJM(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6A1ADA0", Offset = "0x6A197A0", VA = "0x186A1ADA0")]
		internal void FAGKJGFKOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A1ACF0", Offset = "0x6A196F0", VA = "0x186A1ACF0")]
		internal void AFHLIAACDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		internal KGIOENCPIOK OCONEDJHNMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MDKOLJLKJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public IMDHGNFFNFM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MDKOLJLKJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6A1F740", Offset = "0x6A1E140", VA = "0x186A1F740")]
		internal FILJJKMBHEA ENJNOAEHDHD(int lod)
		{
			return default(FILJJKMBHEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ONBHOOPNOFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<CJIKIHCHPEJ> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ONBHOOPNOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A2C870", Offset = "0x6A2B270", VA = "0x186A2C870")]
		internal void GINGBOLBEEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KPJLAJELGCG : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public OBOOFNFPMMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public List<DJBJMDNPHHE> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public List<CJIKIHCHPEJ> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Func<int, FILJJKMBHEA> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public EMCPPDMEJDO materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public KPJLAJELGCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DC70", Offset = "0x6A1C670", VA = "0x186A1DC70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DE70", Offset = "0x6A1C870", VA = "0x186A1DE70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CIAINEJDHJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public OBOOFNFPMMC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CIAINEJDHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A17390", Offset = "0x6A15D90", VA = "0x186A17390")]
		internal KGIOENCPIOK NEPNCGMLEND(DJBJMDNPHHE p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KFDNGLEKNNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public PDFBMGCFHMO cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KFDNGLEKNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8E1570", Offset = "0x8DFF70", VA = "0x1808E1570")]
		internal void PIBABDMEBNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xC7B100", Offset = "0xC79B00", VA = "0x180C7B100")]
		internal void ADILCOGBNBM(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class AGGNDHDKOIJ
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
		public OBOOFNFPMMC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AGGNDHDKOIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class CPHECPJJNNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JAINFKGLLHI defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public LMKIJCELCLE defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AGGNDHDKOIJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CPHECPJJNNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6A177D0", Offset = "0x6A161D0", VA = "0x186A177D0")]
		internal void CFCGMNOKPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xC7C190", Offset = "0xC7AB90", VA = "0x180C7C190")]
		internal void DDIEBLKAAJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HFLHMHMJCPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public BNMJPDFGFGI legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public DJKJJEOHGCI legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AGGNDHDKOIJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HFLHMHMJCPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A3E0", Offset = "0x6A18DE0", VA = "0x186A1A3E0")]
		internal void HIPECAOKAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC7B2F0", Offset = "0xC79CF0", VA = "0x180C7B2F0")]
		internal void DIIINIELKNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FHMCDLIFKCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public KeyValuePair<string, LEMJPPFPKJJ> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PDFBMGCFHMO cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public LEMJPPFPKJJ avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public OBOOFNFPMMC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FHMCDLIFKCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A19830", Offset = "0x6A18230", VA = "0x186A19830")]
		internal KGIOENCPIOK HOFIKKHADOD(ELLCNICPFLK item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A19C60", Offset = "0x6A18660", VA = "0x186A19C60")]
		internal void JBFMDMKHIKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KLPCKLEOELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public NNLLBGLJADF<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KLPCKLEOELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DC20", Offset = "0x6A1C620", VA = "0x186A1DC20")]
		internal void LFBMICJKOJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AOFIPPIGONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public BDAPCPEBHHJ overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AOFIPPIGONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A17310", Offset = "0x6A15D10", VA = "0x186A17310")]
		internal bool BBHGFLDNHGD(KeyValuePair<string, LEMJPPFPKJJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration BFOEENDEHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform EDHMBJBDPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference LBCJCIHHBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject PGHCPCMDFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject BADFKBCFFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer OLKMDODKCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData DPACLDGKJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] DHCBEGCGAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] DDLGOHMILJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material KJICAOAOIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material KNAMAJIEGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material CCNIDFHANBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader ABLLHCEFKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader GEFPCEMGMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator OMNOGMANLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] BHGJLKEGMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private PCNNDLGLKGM.MLOLFLCAEKK LJMAMDKAGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager DFMPEIMPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> KPFGLNMACEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.IINFBBPEOOL ONLDAIDHGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.MPHHFMNFDEN GKLKJGIGHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool FIKDGJBNNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool JIHDDGKCEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color BHNCPEOFKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color PBLMEOMOHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color HAFLACPEJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? IGADNLFHDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? OMFEHEPMEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? GJPAGCNAELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? NKDEOKLBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D BFFLADLCHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D NOFECOLLLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private LEMJPPFPKJJ AMOJNADOKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture LBKBOOAAJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color IBGNANEHLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, EMCPPDMEJDO> JPEMLGFOIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, EMCPPDMEJDO> AHJELJNKAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<CDLEFDLLEOM>> ONGOIPLLHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<CDLEFDLLEOM>> CDIJPAJILGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<NLFKKAGDIKB> CKPHBGNEGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<NLFKKAGDIKB> LIKFNBHCDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<NLFKKAGDIKB> LFMIDGHAIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<NLFKKAGDIKB> CPNDMDDEDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<CDLEFDLLEOM, Material> DNICJGFMFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<CDLEFDLLEOM, Material> EODPMAGEEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] HGKICHEKLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] KANOFHOCCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] MCCPAABNKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] FOHEBGNDDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, NNLLBGLJADF<Texture2D>> INKAMOKJOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, NNLLBGLJADF<Texture2D>> APKHOLEADCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData DLJFNOCLBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AdditionalHatData AAGPPGCIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private HairData HKCBKOIALGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private HairData KOHAMMJALIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private EAKAJADPDPK EFEHCHLLCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool? ANBDKGKCFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation ACLGMLPFBAD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material CCJOMJNDOIO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Material MGGKLONANMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, LEMJPPFPKJJ> DNFPFGBFFKC;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int JNIACJAIJNK;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int GDDMFEPOHCA;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int DHILPEBLMHG;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int JCBNDEFHBNO;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int PHPDMJKBOEK;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int NAPPOEELOPB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int DFKJCHNLIFB;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int NBIJLBFAHNI;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int GPENDLJNMOH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int HDFNFCDMMKD;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int DBGPOBHKFHN;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int IPGGNIFBMGF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int PMLMCKJPPLA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int NMFEPCEBJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly BPJHNJKJMPB BKMAAECDJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly BPJHNJKJMPB AILCACKMJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool PBCOOGHBAIF;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static Lazy<OKLMGPLPKNE> GEIHIJIEJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Lazy<GEDCGACMIJE> MOJDFDJEKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Lazy<ODKMAMHGHEN> ALCLAFKADNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private LNMBGKHEPPE JJGOHEEMHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private List<Action> JKCINDPNDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private LHPFACMFPID NDIIHHAOMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private SkinnedMeshRenderer[] PFIHPPPDGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int DGCEPGHMGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool PHODEIFKOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int EBLKIHLNODD;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static bool KAJJGBLBBME;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool NKPCOGKNEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xBD5E60", Offset = "0xBD4860", VA = "0x180BD5E60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5470", Offset = "0xBD3E70", VA = "0x180BD5470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material LLJGIBHIEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6A294E0", Offset = "0x6A27EE0", VA = "0x186A294E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material FNCBCMJNACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A23670", Offset = "0x6A22070", VA = "0x186A23670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool CIHNNKHHDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KPAFIKBMJHO IHEHMBKGJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x913B40", Offset = "0x912540", VA = "0x180913B40", Slot = "21")]
		get
		{
			return default(KPAFIKBMJHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static OKLMGPLPKNE KGEAHMJPFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A2B8B0", Offset = "0x6A2A2B0", VA = "0x186A2B8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private GEDCGACMIJE OLNGDBOJLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A26D60", Offset = "0x6A25760", VA = "0x186A26D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private ODKMAMHGHEN IFMHEIGGDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A270B0", Offset = "0x6A25AB0", VA = "0x186A270B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private LNMBGKHEPPE IMJONDCGJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A204F0", Offset = "0x6A1EEF0", VA = "0x186A204F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BPJHNJKJMPB OHKDCOHDHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xBD6350", Offset = "0xBD4D50", VA = "0x180BD6350", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BPJHNJKJMPB CLPCPIPKCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1578820", Offset = "0x1577220", VA = "0x181578820", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] KFGKLHFIAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BAE0", Offset = "0x1A0A4E0", VA = "0x181A0BAE0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] NIDKIKIDJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x883C90", Offset = "0x882690", VA = "0x180883C90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool FKDHHBPOBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A28780", Offset = "0x6A27180", VA = "0x186A28780", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation EGMMFNPKBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A2AAC0", Offset = "0x6A294C0", VA = "0x186A2AAC0", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public PCNNDLGLKGM.MLOLFLCAEKK DJGEOCLBDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x883CC0", Offset = "0x8826C0", VA = "0x180883CC0", Slot = "18")]
		get
		{
			return default(PCNNDLGLKGM.MLOLFLCAEKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int BHPCIGBKMDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1A211D0", Offset = "0x1A1FBD0", VA = "0x181A211D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A29E70", Offset = "0x6A28870", VA = "0x186A29E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool HIMNAEMGJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A2AED0", Offset = "0x6A298D0", VA = "0x186A2AED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool KKPIECJFONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A29670", Offset = "0x6A28070", VA = "0x186A29670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C0C0", Offset = "0x6A2AAC0", VA = "0x186A2C0C0")]
	public OBOOFNFPMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6A278F0", Offset = "0x6A262F0", VA = "0x186A278F0", Slot = "28")]
	public void HINDDHMAHAN(BNGLNOLJEED FJIPHNECFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A2AB20", Offset = "0x6A29520", VA = "0x186A2AB20", Slot = "29")]
	public void MLJEJKJPEFG(GBNJAHHGEHF KIOJEGNGOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A29E70", Offset = "0x6A28870", VA = "0x186A29E70", Slot = "4")]
	public void KBEGMGOLLMM(int PDJBKOAOLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A110", Offset = "0x6A28B10", VA = "0x186A2A110", Slot = "9")]
	public void KOOJLEHNHHG(HBHACIKKGNN NMPABGKDCCF, Texture2D CGILPHBKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B460", Offset = "0x6A29E60", VA = "0x186A2B460", Slot = "10")]
	public void NOGOAKNBJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A23440", Offset = "0x6A21E40", VA = "0x186A23440", Slot = "11")]
	public bool CEMGLGIFKFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A27CA0", Offset = "0x6A266A0", VA = "0x186A27CA0", Slot = "8")]
	public void HMMOHDKMJGC(LODNPOMNEKK MMLHOLGEPMI, Color? BJCIGJMGMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A21EC0", Offset = "0x6A208C0", VA = "0x186A21EC0")]
	private void BCICDEJDLPF(Action CCBKBFNBDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A280A0", Offset = "0x6A26AA0", VA = "0x186A280A0", Slot = "5")]
	public void HNDENMIDBNO(LEMJPPFPKJJ MHGLPJEDJFC, Texture BCBJICAMDGF, Color GKHPJEEDLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xBD5470", Offset = "0xBD3E70", VA = "0x180BD5470", Slot = "6")]
	public void PPEKKEFBKCC(bool NIFNCIFNKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x198A030", Offset = "0x1988A30", VA = "0x18198A030", Slot = "7")]
	public void PBJAKPNIJJN(LHPFACMFPID LFOFLLOHBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A20590", Offset = "0x6A1EF90", VA = "0x186A20590", Slot = "14")]
	public CJIKIHCHPEJ ADIJJJPBLKD(ENPMHBJBAFJ AFAHFKFLOAG, bool KOGOOCOHNLH, int[] BBLHPMJOCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A276F0", Offset = "0x6A260F0", VA = "0x186A276F0", Slot = "15")]
	public void HBMCPINPHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A21F40", Offset = "0x6A20940", VA = "0x186A21F40", Slot = "26")]
	public void BEGPEBOBFKO([Optional] EAKAJADPDPK IJLNGMDCOBO, [Optional] bool? EMJAGPBCGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A23270", Offset = "0x6A21C70", VA = "0x186A23270")]
	private bool BNLGDIJJBDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A22A20", Offset = "0x6A21420", VA = "0x186A22A20", Slot = "19")]
	public bool BFDIHFDIDEE(PCNNDLGLKGM.MLOLFLCAEKK CDDAJGBELJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A28110", Offset = "0x6A26B10", VA = "0x186A28110")]
	private bool HNEFPCLFANB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A28AB0", Offset = "0x6A274B0", VA = "0x186A28AB0")]
	private CJIKIHCHPEJ IJLHLDIIBHG(bool KOGOOCOHNLH, List<DJBJMDNPHHE> NKDPGAHFHKO, int[] BBLHPMJOCBF, Func<int, FILJJKMBHEA> AMNPEAFEDAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A29C30", Offset = "0x6A28630", VA = "0x186A29C30")]
	[IteratorStateMachine(typeof(KPJLAJELGCG))]
	private IEnumerator<DKMFPOPNNKA> JNKIBPGPIBL(bool KOGOOCOHNLH, List<DJBJMDNPHHE> NKDPGAHFHKO, int[] BBLHPMJOCBF, Func<int, FILJJKMBHEA> AMNPEAFEDAE, EMCPPDMEJDO GJMFAHCDGNL, Material JFFIJKNPIIN, List<CJIKIHCHPEJ> ALGOALBAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A254A0", Offset = "0x6A23EA0", VA = "0x186A254A0")]
	private CJIKIHCHPEJ DLIJGJAOGIE(List<DJBJMDNPHHE> NKDPGAHFHKO, int[] BBLHPMJOCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A23920", Offset = "0x6A22320", VA = "0x186A23920")]
	private CHBCKIOGPHP DKGIPEKLLIO(List<DJBJMDNPHHE> NKDPGAHFHKO, int PDJBKOAOLLN, bool KOGOOCOHNLH, FILJJKMBHEA KPHOHHILDDP, bool PLFFGNPNOBM, EMCPPDMEJDO GJMFAHCDGNL, Material JFFIJKNPIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A27BB0", Offset = "0x6A265B0", VA = "0x186A27BB0", Slot = "22")]
	public void HKFNBOOILMF(AvatarFaceShape IJKOAPJOJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A235B0", Offset = "0x6A21FB0", VA = "0x186A235B0", Slot = "23")]
	public void CGDENOHMCEP(AvatarBodyShape FMKMNMDNLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A288F0", Offset = "0x6A272F0", VA = "0x186A288F0", Slot = "25")]
	public void HOHAEMDAGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A100", Offset = "0x6A28B00", VA = "0x186A2A100", Slot = "24")]
	public void KGMHPDOELNF(bool NGCPNAFGPJB, bool ICLDBPJJDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6A26DB0", Offset = "0x6A257B0", VA = "0x186A26DB0")]
	private void GFIMAPEGAPD(SkinnedMeshRenderer EJBFFMNGMCA, int PDJBKOAOLLN, Mesh LDNHICGPCIN, List<Material> LFNGGDAGDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A25F50", Offset = "0x6A24950", VA = "0x186A25F50")]
	private static Material FALNHLAFNON(Dictionary<CDLEFDLLEOM, Material> IDGDNKCHMLD, Material ELLCDHCBPLJ, PFKHBANGMLD BFPDBBJEDPO, EFDDAIMKBLP KCIOLEKPLNL, BDAPCPEBHHJ EGKBNBCGHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A21B90", Offset = "0x6A20590", VA = "0x186A21B90")]
	private static PFKHBANGMLD ALBNAEJFMJB(DJBJMDNPHHE CKEFGOACEMG, int BDIFKLFGDJA)
	{
		return default(PFKHBANGMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A265A0", Offset = "0x6A24FA0", VA = "0x186A265A0")]
	private void FJFGLABKMIF(int PJGDMFFOLPE, Material PPFNGNPGEKG, DJBJMDNPHHE CKEFGOACEMG, [Out] Texture2D LMCDDGPHLIK, [Out] Vector4 FDIDAFFNBBK, [Out] Texture2D MKNMICAEPHO, [Out] Texture2D FEBNNMIMMBK, [Out] Texture2D DLFKHOFODJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A470", Offset = "0x6A28E70", VA = "0x186A2A470")]
	private void KPAFKDGOMCH(int PJGDMFFOLPE, Material PPFNGNPGEKG, DJBJMDNPHHE CKEFGOACEMG, [Out] Color NIMMDIFAMIB, [Out] Color JJAMAOPFEBB, [Out] Color LKIOELHKOJI, [Out] Color JEGHKIIPOEL, [Out] Color PELJMNIHIDG, [Out] Color KEFBIPGAJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B4E0", Offset = "0x6A29EE0", VA = "0x186A2B4E0")]
	private bool OAFACFFMHCK(Material PPFNGNPGEKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A2ABA0", Offset = "0x6A295A0", VA = "0x186A2ABA0")]
	private static Material MPFLJPHEKAE(int PJGDMFFOLPE, NGFLGIPGAKF CKEFGOACEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B920", Offset = "0x6A2A320", VA = "0x186A2B920")]
	private static EFDDAIMKBLP ONMELAOJMJF(DJBJMDNPHHE CKEFGOACEMG, int BDIFKLFGDJA)
	{
		return default(EFDDAIMKBLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A2ABF0", Offset = "0x6A295F0", VA = "0x186A2ABF0")]
	private static void NECEAMKEJLB(Dictionary<string, List<CDLEFDLLEOM>> ECGBCMKEIMC, DJBJMDNPHHE IBHIPOEKALN, Material ELLCDHCBPLJ, PFKHBANGMLD MMLHOLGEPMI, EFDDAIMKBLP NMPABGKDCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A23040", Offset = "0x6A21A40", VA = "0x186A23040")]
	private static SkinnedMeshRenderer BKBPPEIBEDN(Transform ELCFCFEDEPO, Transform EEMNKNMCMAL, SkinnedMeshRenderer[] NGNEIPPIIED, int PDJBKOAOLLN, FILJJKMBHEA KPHOHHILDDP, bool KOGOOCOHNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A26EF0", Offset = "0x6A258F0", VA = "0x186A26EF0")]
	private void GGBNOGFNOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A25CC0", Offset = "0x6A246C0", VA = "0x186A25CC0")]
	private void ECBPHHINIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A260B0", Offset = "0x6A24AB0", VA = "0x186A260B0")]
	private static void FFIAPNODHGE(Dictionary<CDLEFDLLEOM, Material> IDGDNKCHMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A27430", Offset = "0x6A25E30", VA = "0x186A27430")]
	private static void GPIBAMBHMDO(Dictionary<Renderer, EMCPPDMEJDO> DHKEIPKHGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A26A80", Offset = "0x6A25480", VA = "0x186A26A80")]
	private void FMDHGJKLDJC(SkinnedMeshRenderer[] NGNEIPPIIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A29DD0", Offset = "0x6A287D0", VA = "0x186A29DD0")]
	private void KAOHOIJFMIE(SkinnedMeshRenderer BDPEMPJMAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A25CD0", Offset = "0x6A246D0", VA = "0x186A25CD0")]
	private void EKKBIHPEOIB(List<NLFKKAGDIKB> HHPJLEHACKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BA20", Offset = "0x6A2A420", VA = "0x186A2BA20")]
	private void PIPPGIPNNBL(Dictionary<string, NNLLBGLJADF<Texture2D>> ECGBCMKEIMC, bool CGFMLEPGDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B410", Offset = "0x6A29E10", VA = "0x186A2B410")]
	private void NMNDLHCGHDE(Dictionary<string, List<CDLEFDLLEOM>> ECGBCMKEIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6A27590", Offset = "0x6A25F90", VA = "0x186A27590")]
	private void HBKJHIHDCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A26BD0", Offset = "0x6A255D0", VA = "0x186A26BD0")]
	private void GBGBHIGKFEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A281D0", Offset = "0x6A26BD0", VA = "0x186A281D0")]
	private void HNPBBBHGFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A269B0", Offset = "0x6A253B0", VA = "0x186A269B0")]
	private void FLCCPKNDEPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A233B0", Offset = "0x6A21DB0", VA = "0x186A233B0")]
	private void BOEDPEGLJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A29FB0", Offset = "0x6A289B0", VA = "0x186A29FB0")]
	private void KGHPGMIKHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BC30", Offset = "0x6A2A630", VA = "0x186A2BC30")]
	private void PNHCKOAABIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A950", Offset = "0x6A29350", VA = "0x186A2A950")]
	private void LAMDGAKNHHB(bool BKKGMHHLLOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A9F0", Offset = "0x6A293F0", VA = "0x186A2A9F0")]
	private void MABDPPOKHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A25EB0", Offset = "0x6A248B0", VA = "0x186A25EB0")]
	private void EMLKMOAAIMP(bool BKKGMHHLLOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A2AF50", Offset = "0x6A29950", VA = "0x186A2AF50")]
	private void NIGHOMFPGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A257F0", Offset = "0x6A241F0", VA = "0x186A257F0")]
	private void EAPIAJHOOPO(Material JFFIJKNPIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B740", Offset = "0x6A2A140", VA = "0x186A2B740")]
	private void OBAEJKNJHGG(Material JFFIJKNPIIN, Color MLINMEJDFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A21CC0", Offset = "0x6A206C0", VA = "0x186A21CC0")]
	private void ALGAKNJLOHK(Material JFFIJKNPIIN, Color LKGFBEKACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A272C0", Offset = "0x6A25CC0", VA = "0x186A272C0")]
	private void GJKDLCFHMLI(Material JFFIJKNPIIN, Color NIMMDIFAMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B290", Offset = "0x6A29C90", VA = "0x186A2B290")]
	private void NJDLPLLDKKN(Material JFFIJKNPIIN, Texture2D CGILPHBKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A2A320", Offset = "0x6A28D20", VA = "0x186A2A320")]
	private void KOPIBMFJOCJ(Material JFFIJKNPIIN, Texture GMDNPGKNCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A27100", Offset = "0x6A25B00", VA = "0x186A27100")]
	private void GICBIHHJKAD(Action<EMCPPDMEJDO> NILKKAJILBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A23760", Offset = "0x6A22160", VA = "0x186A23760")]
	private void DGMIBIGNJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A26240", Offset = "0x6A24C40", VA = "0x186A26240")]
	private void FHHALHJOJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A22A40", Offset = "0x6A21440", VA = "0x186A22A40")]
	private CJIKIHCHPEJ BHHCNDIOKDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A29080", Offset = "0x6A27A80", VA = "0x186A29080")]
	private void IMBPOMBKLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A29810", Offset = "0x6A28210", VA = "0x186A29810")]
	public void JCGHKNKAEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A28A20", Offset = "0x6A27420", VA = "0x186A28A20")]
	[CompilerGenerated]
	private void IBHOBPBDFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A26210", Offset = "0x6A24C10", VA = "0x186A26210")]
	[CompilerGenerated]
	private void FHBHKCCJCJO(EMCPPDMEJDO DOHNLDCGLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A29E90", Offset = "0x6A28890", VA = "0x186A29E90")]
	[CompilerGenerated]
	private void KCOEOIKCNPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A23900", Offset = "0x6A22300", VA = "0x186A23900")]
	[CompilerGenerated]
	private void DKGCEMAHJIC(EMCPPDMEJDO DOHNLDCGLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A29F20", Offset = "0x6A28920", VA = "0x186A29F20")]
	[CompilerGenerated]
	private void KFHGGJHCDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A238E0", Offset = "0x6A222E0", VA = "0x186A238E0")]
	[CompilerGenerated]
	private void DJMEMEJEKJP(EMCPPDMEJDO DOHNLDCGLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A25760", Offset = "0x6A24160", VA = "0x186A25760")]
	[CompilerGenerated]
	private void DPICLIIAKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A26BA0", Offset = "0x6A255A0", VA = "0x186A26BA0")]
	[CompilerGenerated]
	private void GBFOEHJMEHJ(EMCPPDMEJDO DOHNLDCGLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BBA0", Offset = "0x6A2A5A0", VA = "0x186A2BBA0")]
	[CompilerGenerated]
	private void PJHDCBHGMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A23010", Offset = "0x6A21A10", VA = "0x186A23010")]
	[CompilerGenerated]
	private void BIGLCFFCMKN(EMCPPDMEJDO DOHNLDCGLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A29D40", Offset = "0x6A28740", VA = "0x186A29D40")]
	[CompilerGenerated]
	private void KANBPJGDKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A229F0", Offset = "0x6A213F0", VA = "0x186A229F0")]
	[CompilerGenerated]
	private void BEHIOAIPEEL(EMCPPDMEJDO DOHNLDCGLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A21E30", Offset = "0x6A20830", VA = "0x186A21E30")]
	[CompilerGenerated]
	private void AMEBLAIIMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A289F0", Offset = "0x6A273F0", VA = "0x186A289F0")]
	[CompilerGenerated]
	private void IAFPCBOPJFG(EMCPPDMEJDO DOHNLDCGLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BD00", Offset = "0x6A2A700", VA = "0x186A2BD00")]
	[CompilerGenerated]
	private void PPJKILKBBNF(KeyValuePair<string, NNLLBGLJADF<Texture2D>> EHHCOJBHDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A29450", Offset = "0x6A27E50", VA = "0x186A29450")]
	[CompilerGenerated]
	private void INCEAKDPFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A2AAF0", Offset = "0x6A294F0", VA = "0x186A2AAF0")]
	[CompilerGenerated]
	private void MFKHCEOFAFP(EMCPPDMEJDO DOHNLDCGLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A29BA0", Offset = "0x6A285A0", VA = "0x186A29BA0")]
	[CompilerGenerated]
	private void JFGPMGLKMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A27C70", Offset = "0x6A26670", VA = "0x186A27C70")]
	[CompilerGenerated]
	private void HLIELOGMNFL(EMCPPDMEJDO DOHNLDCGLHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PDJDJECFKJA : PIOIOFPJAKI
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int NOLPIEEANCB;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int LGPABKOIEKP;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int JGJHIGPEOPI;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int EPOBMLFLONB;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int CENIPJHPOJB;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int LIDNDKALNOD;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int JNIICCEDGCL;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int EDFMHGOAIGI;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int AOANDLCDEHJ;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int PMCFPMJCKKA;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int HCDLLOBCHPJ;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int AHPFHMKKOOC;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int LJAKILKOLFI;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int KJCNABEPFHF;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int KEABCFIFJBL;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int JGLDAAGOKHG;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int FJGLAOBGEJB;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int OFELJIBKKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform MMEKCDKCADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform CCBPJMJOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform FCMIONBFBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform IIACKOBHBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Transform COHEACBFDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Transform MEAINJIPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Transform JJFLNLLIFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private GOGHNMGGMND IKBLAONMFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private MaterialPropertyBlock MDLAFILFAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private SkinnedMeshRenderer[] AIBFNDGIKMM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock LBDMFHMFCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6A2CB40", Offset = "0x6A2B540", VA = "0x186A2CB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6A2E6F0", Offset = "0x6A2D0F0", VA = "0x186A2E6F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CBC0", Offset = "0x6A2B5C0", VA = "0x186A2CBC0", Slot = "7")]
	public void HINDDHMAHAN(GOGHNMGGMND BLIKBCJANJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C9A0", Offset = "0x6A2B3A0", VA = "0x186A2C9A0", Slot = "8")]
	public void DJIEPJBILPF(ONAHENLDIGE HPPFKGKBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E1F0", Offset = "0x6A2CBF0", VA = "0x186A2E1F0", Slot = "5")]
	public void OCMDJDAGLGB(OFGOGHGHFLP EMEPEFNOABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E190", Offset = "0x6A2CB90", VA = "0x186A2E190")]
	private Vector2 MMLCAKEHPIN(Vector2 HAPKPDNLFNC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CFD0", Offset = "0x6A2B9D0", VA = "0x186A2CFD0", Slot = "6")]
	public void MICHLPHJMNA(PIOIGEACCKI HPPFKGKBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CC90", Offset = "0x6A2B690", VA = "0x186A2CC90")]
	private void LLECBKKAFNM(PIOIGEACCKI HJNBONDCJOC, OIEHFNCIHFC PEMCBBEAKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CA60", Offset = "0x6A2B460", VA = "0x186A2CA60")]
	private void GFDMBLEFINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EB70", Offset = "0x6A2D570", VA = "0x186A2EB70")]
	public PDJDJECFKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C9D0", Offset = "0x6A2B3D0", VA = "0x186A2C9D0")]
	[CompilerGenerated]
	internal static (float, float) EIFPHGACGKD(float PDOBKPNOFII)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E150", Offset = "0x6A2CB50", VA = "0x186A2E150")]
	[CompilerGenerated]
	internal static Vector4 MLKPCCOPJJP(Vector2 EJEBFMEPKGF, Vector2 FCFDEHNOPJK)
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
		private FAOJCMNAOGM? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AOFHBLCBKAK CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6A2FC80", Offset = "0x6A2E680", VA = "0x186A2FC80")]
			get
			{
				return default(AOFHBLCBKAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public FAOJCMNAOGM MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6A2FCB0", Offset = "0x6A2E6B0", VA = "0x186A2FCB0")]
			get
			{
				return default(FAOJCMNAOGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x88B2B0", Offset = "0x889CB0", VA = "0x18088B2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x88B2F0", Offset = "0x889CF0", VA = "0x18088B2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A2FAE0", Offset = "0x6A2E4E0", VA = "0x186A2FAE0")]
		public Material[] MBLCIAKLKDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A2F740", Offset = "0x6A2E140", VA = "0x186A2F740")]
		public static void AMCEBNJPFMH(AvatarItemMaterial OOOIFOHAAGH, Material PPFNGNPGEKG, int PJGDMFFOLPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A2F930", Offset = "0x6A2E330", VA = "0x186A2F930")]
		private static bool DECCCEMGPFD(AvatarItemMaterial OOOIFOHAAGH, int PJGDMFFOLPE, [Out] Material HOOEJBOFPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A2FBC0", Offset = "0x6A2E5C0", VA = "0x186A2FBC0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DEKINLCKNLM]
public struct BDBMKHEAEFC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public DJKJJEOHGCI KNAEDMKHOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	public int OHMCPIDNGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public BNMJPDFGFGI LGNHLNKNKNE;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A302E0", Offset = "0x6A2ECE0", VA = "0x186A302E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[DEKINLCKNLM]
public struct BNMJPDFGFGI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Vector3> NOHDOPIDDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<Vector3> PPFPMPHOIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<Vector4> NNLIGJLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public NativeArray<Vector2> ODOCABHGPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public NativeArray<Vector2> IFCJACHHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<Vector2> JPHNBCGOOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public NativeArray<Vector2> JEOODCDIBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public NativeArray<Color> BOPGACMAPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<int> MNCNJNLDFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public NativeArray<int> PHIKLFHIIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private NativeArray<int> OIIPMDKANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private NativeArray<int> NJENFPBINOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public NativeArray<int> PJOBJLGBGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public NativeArray<int> BPBECKEKPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<int> FEDHCKMAPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<BoneWeight> ALDMMNIOMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private NativeArray<int> LFOFLLOHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool JMPBLJFNPGB;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int CEBCLOAKDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6A315D0", Offset = "0x6A2FFD0", VA = "0x186A315D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A31880", Offset = "0x6A30280", VA = "0x186A31880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int BDGNILFDMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A317B0", Offset = "0x6A301B0", VA = "0x186A317B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A315C0", Offset = "0x6A2FFC0", VA = "0x186A315C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BKBKGCGLPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6A31870", Offset = "0x6A30270", VA = "0x186A31870")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6A319B0", Offset = "0x6A303B0", VA = "0x186A319B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A31C90", Offset = "0x6A30690", VA = "0x186A31C90")]
	public BNMJPDFGFGI(int BDPIJAGKBEL, int OABDDCANPEA, int OLNLFCDGOPA, int FKNOKBNDHJP, Allocator MPFEIGMBFCP, int MADDIIAPGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6A319C0", Offset = "0x6A303C0", VA = "0x186A319C0")]
	public void IODOHGJBEBF(int ENMILGHAHOM, Vector3 NLEGDNPENLM, Vector3 JCHGHJIDPLJ, Vector4 NNEFLDDEJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A31A30", Offset = "0x6A30430", VA = "0x186A31A30")]
	public void JFJJGHKEIGA(int ENMILGHAHOM, BoneWeight PIOGMOBBHMF, NativeSlice<byte> FNJEDFOJMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A31BD0", Offset = "0x6A305D0", VA = "0x186A31BD0")]
	public Color JOAHPLBFIIN(int ENMILGHAHOM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A315E0", Offset = "0x6A2FFE0", VA = "0x186A315E0")]
	public void BKBJFIPGOGI(int ENMILGHAHOM, Color JGMIDFFABNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A31890", Offset = "0x6A30290", VA = "0x186A31890")]
	public void GABEAHKBEEM(byte GEOCBCMJGLG, int ENMILGHAHOM, Vector2 MPBOPFFDAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A31BF0", Offset = "0x6A305F0", VA = "0x186A31BF0")]
	public void LKINPLFAGAL(int ENMILGHAHOM, int CDHCGODDABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A31240", Offset = "0x6A2FC40", VA = "0x186A31240")]
	public bool AAAELLMPBMN(int GEOCBCMJGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A318E0", Offset = "0x6A302E0", VA = "0x186A318E0")]
	public void HEDJJIBENLA(int OMJBBKNLDGL, int EDCGGCHLNEI, int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A317C0", Offset = "0x6A301C0", VA = "0x186A317C0")]
	public int[] EPEOMNPAHHD(int OMJBBKNLDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6A31C00", Offset = "0x6A30600", VA = "0x186A31C00")]
	private NativeSlice<int> LKJNMJOABJI(int OMJBBKNLDGL)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6A31600", Offset = "0x6A30000", VA = "0x186A31600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6A31270", Offset = "0x6A2FC70", VA = "0x186A31270")]
	public Mesh AAGMBJEHJIP([Optional] string DNKKNNFJONL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
[DEKINLCKNLM]
[NativeContainer]
public struct DJKJJEOHGCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Vector3> NOHDOPIDDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<Vector3> PPFPMPHOIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<Vector4> NNLIGJLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<Vector2> ODOCABHGPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<Vector2> IFCJACHHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<Vector2> JPHNBCGOOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<Vector2> JEOODCDIBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<Color> BOPGACMAPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<int> MDHOPKHDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public NativeArray<int> AIMHKAPIBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public NativeArray<int> FPBNBCMOEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public NativeArray<int> NDILANAPCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public NativeArray<bool> KLNMFEDDGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public NativeArray<int> DMDHAFGNAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public NativeArray<int> DPKHDMNCAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public NativeArray<BoneWeight> MPPBPLGOPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<Matrix4x4> JIJBFNMPFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private NativeArray<int> IDPMJBKOILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private NativeArray<byte> COPHFOJEDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private NativeArray<int> PAHACGOBMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private NativeArray<int> JKGJDJPAMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public NativeArray<sbyte> KEPKNICLFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeArray<byte> MJMFIGPBPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> DBOAONNCMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool JMPBLJFNPGB;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int GIKIBIEEIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x213C400", Offset = "0x213AE00", VA = "0x18213C400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MHIJBDJOJON
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x124B9E0", Offset = "0x124A3E0", VA = "0x18124B9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int LHLHMIHHGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6A32850", Offset = "0x6A31250", VA = "0x186A32850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int JBNCALADOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A324C0", Offset = "0x6A30EC0", VA = "0x186A324C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A324E0", Offset = "0x6A30EE0", VA = "0x186A324E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int CEBCLOAKDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A324A0", Offset = "0x6A30EA0", VA = "0x186A324A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A32750", Offset = "0x6A31150", VA = "0x186A32750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int CIEMGIMKPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A32490", Offset = "0x6A30E90", VA = "0x186A32490")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A324D0", Offset = "0x6A30ED0", VA = "0x186A324D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CPJHDJFONNI GKPGBPKIGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6A32880", Offset = "0x6A31280", VA = "0x186A32880")]
		get
		{
			return default(CPJHDJFONNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6A324B0", Offset = "0x6A30EB0", VA = "0x186A324B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte ICDIOHJBAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A32840", Offset = "0x6A31240", VA = "0x186A32840")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6A32830", Offset = "0x6A31230", VA = "0x186A32830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public OMHEFDODKOI BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6A32890", Offset = "0x6A31290", VA = "0x186A32890")]
		get
		{
			return default(OMHEFDODKOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6A32DB0", Offset = "0x6A317B0", VA = "0x186A32DB0")]
	public DJKJJEOHGCI(IList<Mesh> CKFEPJHINEL, IList<Matrix4x4> NDOFAEAKFMH, IList<bool> KLNMFEDDGJI, byte IFKMCFMPEON, IList<byte[]> ILPFJFPKHGP, IList<int> KDIFCNJDENH, IList<bool> BFFPJLBGDKN, IList<int> DMDHAFGNAJI, IList<int> MFOPCLCHPBM, IList<int> LMEMHCMBOJN, Allocator MPFEIGMBFCP, CPJHDJFONNI HPBMCJPOHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6A32760", Offset = "0x6A31160", VA = "0x186A32760")]
	public BNMJPDFGFGI GEGHIACLDPA(Allocator MPFEIGMBFCP)
	{
		return default(BNMJPDFGFGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6A324F0", Offset = "0x6A30EF0", VA = "0x186A324F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DEKINLCKNLM]
public class ILJALALCNOE : HIHLCFHNGHD
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6A38680", Offset = "0x6A37080", VA = "0x186A38680")]
	public DJKJJEOHGCI KGEJLOPJAIC()
	{
		return default(DJKJJEOHGCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6A19820", Offset = "0x6A18220", VA = "0x186A19820")]
	public ILJALALCNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct OMHEFDODKOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Vector3> NOHDOPIDDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<Vector3> PPFPMPHOIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<Vector4> NNLIGJLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<Vector2> ODOCABHGPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<Vector2> IFCJACHHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeSlice<Vector2> JPHNBCGOOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public NativeSlice<Vector2> JEOODCDIBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public NativeSlice<Color> BOPGACMAPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public NativeSlice<int> EEFBBDFOLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public NativeSlice<int> NDILANAPCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public NativeSlice<BoneWeight> MPPBPLGOPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public NativeSlice<byte> DHLLIINDLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public int DOEKDDJMFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Matrix4x4 GKPNJMEJDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public int BPOIDABBDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeSlice<byte> FNJEDFOJMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public bool HEBPOBEOIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public int PJIHHKDHNID;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct CDLEFDLLEOM : IEquatable<CDLEFDLLEOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	internal readonly Material LEJGECJHNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	internal readonly PFKHBANGMLD JBKFJJMOHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	internal readonly EFDDAIMKBLP MEKBCGJGCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	internal readonly BDAPCPEBHHJ BNIBKPFOKKP;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xC73590", Offset = "0xC71F90", VA = "0x180C73590")]
	public CDLEFDLLEOM(Material PPFNGNPGEKG, PFKHBANGMLD BFPDBBJEDPO, EFDDAIMKBLP KCIOLEKPLNL, BDAPCPEBHHJ EGKBNBCGHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6A32270", Offset = "0x6A30C70", VA = "0x186A32270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xC73170", Offset = "0xC71B70", VA = "0x180C73170", Slot = "4")]
	public bool Equals(CDLEFDLLEOM CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6A320F0", Offset = "0x6A30AF0", VA = "0x186A320F0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6A321D0", Offset = "0x6A30BD0", VA = "0x186A321D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EMCPPDMEJDO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private MaterialPropertyBlock IHNDPIOLMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Color? EJKGCJMNCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Color? JNOFHCCNDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Color? OGKLLGPFNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Color? CHCLEKFDFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Color LDMPNDKDHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Color AKFAEFJKHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Color EHDGBGNKMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Texture2D LFMDEJPOKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Texture2D KBOBNLCBLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private Dictionary<CDLEFDLLEOM, int> POALGEAPANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private PFKHBANGMLD[] ALEJACHABIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private EFDDAIMKBLP[] OALPIDCKIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector4[] CKAHNIPNPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector4[] GBNMLBKNJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Vector4[] GLCDNLCCPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public Vector4[] LPLFJKIJHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Vector4[] HGFFGKOHFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector4[] OJPMACJPPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<Texture2D> OCEMOBJHDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private Vector4[] MPDJOHEAKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private List<Texture2D> DEPKPAJCHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private float[] CJGODNBHOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private Vector4[] FGLFHLEKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private float[] ACBAPIHKPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float[] NPAAPNMIMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private List<Texture2D> KKPLONDNPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private float[] CIEPOJPLOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private List<Texture2D> HKBNPDBOOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private Vector4[] FDCJMABBJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private float[] PDLJPHCGPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private Vector4[] JMAGPIAEJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public float[] EDBNDACFIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public Texture2DArray IMHINECNKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public Texture2DArray CDOMLFPIAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public Texture2DArray IBGDMFCICMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public Texture2DArray CJNKIKAKGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private bool KDIPLOHDFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private int DFKNFOFJDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Vector2? FLLDIBPCHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private TextureFormat GNGJFFDGIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private Vector2? BJFBMIOFPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private TextureFormat LIAIAEIFIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private Vector2? EHGBOHCGHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private TextureFormat EHIHFIPEEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Vector2? PBFJMANEDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private TextureFormat ANLFNIIMAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private bool PJFKAIJIJGP;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int MHEEDFHCELI;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int EPKJPGMDBGD;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int LMNIELBMLPD;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int KGIDECIDEFG;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int PJPGDFMBDMI;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int ECCNFEJBJPJ;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int AEFNFKPIGMP;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int LHPBAOHPBDM;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int JCGAHKFIKMP;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int BAKALJMKJFJ;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int HMOIJJMNKLM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int JDDCBLIHOPI;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int LKDBIPDGCMO;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static int APIGFLGCOMP;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static int CFEFFBGGNMH;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static int NNKJHLOGFPG;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static int FPDINOKEKBN;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static int IAIIMHCOCNJ;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static int BMDEPBLNEHN;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static int ODOOJNCFIFD;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6A37110", Offset = "0x6A35B10", VA = "0x186A37110")]
	private EMCPPDMEJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6A37600", Offset = "0x6A36000", VA = "0x186A37600")]
	public EMCPPDMEJDO(Color MHLNLPPDBHC, Color LBKCGPDHNKD, Color CEBCOHBBEFI, Color? HNHFBAPDHLL, Color? IPDFMHNDMHF, Color? ANNOGIFDKOG, Texture2D ADAFBOBKNIO, Texture2D FPMCBKDOPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A36880", Offset = "0x6A35280", VA = "0x186A36880")]
	internal int GJNEIAHHHEP(Material OGGLCEFEKHE, PFKHBANGMLD BFPDBBJEDPO, EFDDAIMKBLP KCIOLEKPLNL, BDAPCPEBHHJ EGKBNBCGHOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A367F0", Offset = "0x6A351F0", VA = "0x186A367F0")]
	private int GJNEIAHHHEP(CDLEFDLLEOM COMNIKKFEEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6A35C20", Offset = "0x6A34620", VA = "0x186A35C20")]
	internal int EKDCCIGCKGI(Material OGGLCEFEKHE, Color NIMMDIFAMIB, Color JJAMAOPFEBB, Color LKIOELHKOJI, Color JEGHKIIPOEL, Color PELJMNIHIDG, Texture2D HFKOOANONKH, Vector4 LMGFJDEFEMK, Texture2D HAMHANGKHMK, Vector4 HCIEEOEBNBP, float KONFGGMIPBC, float OJCDDIADGJC, Texture2D BCNIIFCAHAO, Vector4 GKJOPHOIDCC, float HMDOJMJEAGK, Texture2D NBMEFEMHKMA, Color KEFBIPGAJFF, Vector4 POCNOHGOHCL, PFKHBANGMLD BFPDBBJEDPO, EFDDAIMKBLP KCIOLEKPLNL, BDAPCPEBHHJ EGKBNBCGHOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6A34DC0", Offset = "0x6A337C0", VA = "0x186A34DC0")]
	private void DFDMCCFAGEH(List<Texture2D> OCEMOBJHDPB, [Out] Texture2DArray LHMHIHEGOIC, [Out] Texture2DArray JOOAFHCJDMO, [Out] Texture2DArray PAGLNBEPOCF, [Out] Texture2DArray GOFFBPLNAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6A36A70", Offset = "0x6A35470", VA = "0x186A36A70")]
	public void LLAMIKABOCA(Shader GLFHLGJCLAF, Renderer DGLLFNJJPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A34F80", Offset = "0x6A33980", VA = "0x186A34F80")]
	private void DPCPGHFNKKJ(Shader GLFHLGJCLAF, Renderer DGLLFNJJPBO, int HDHACOCHLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6A36BC0", Offset = "0x6A355C0", VA = "0x186A36BC0")]
	private Color NNADLGFAAFA(Color JABKILMIMPK, PFKHBANGMLD MMLHOLGEPMI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A34BC0", Offset = "0x6A335C0", VA = "0x186A34BC0")]
	private Color BEDCIKPEFOD(Color LMKMPPMMFMH, PFKHBANGMLD MMLHOLGEPMI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6A36970", Offset = "0x6A35370", VA = "0x186A36970")]
	private bool GMKGANHJJIE(Texture2D EGMEPGGEOOO, EFDDAIMKBLP NMPABGKDCCF, [Out] Texture2D DMMEHEMOKGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6A34D10", Offset = "0x6A33710", VA = "0x186A34D10")]
	private void CBHMDEDNNDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6A35BE0", Offset = "0x6A345E0", VA = "0x186A35BE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class PEFPCANPPLB
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class DNGKKFILOEM : IEnumerator<DKMFPOPNNKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private DKMFPOPNNKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private DKMFPOPNNKA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public DNGKKFILOEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xC782A0", Offset = "0xC76CA0", VA = "0x180C782A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6A34610", Offset = "0x6A33010", VA = "0x186A34610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void JIAOHONACDN(string DNICIAANFHD, int PDJBKOAOLLN, long MMFCNHAIKOK, long IDLPGEKEMAO, long MANFOFBFFAA, long NAJBLBKABHC, long OFFPKKMAMGP, long NIFNDIJMNCJ, long JPBPMJHBOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6A39D50", Offset = "0x6A38750", VA = "0x186A39D50")]
	public static CHBCKIOGPHP PPLCKJJCKOC(JobHandle BDMNLOAMGHJ, bool GCIPFFPKMMM, bool CIHNNKHHDHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6A39CE0", Offset = "0x6A386E0", VA = "0x186A39CE0")]
	[IteratorStateMachine(typeof(DNGKKFILOEM))]
	private static IEnumerator<DKMFPOPNNKA> LFIMEIFAAHM(JobHandle DKMIJDPJCBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LEONJOCOGBF : ODKMAMHGHEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private OJPFIJFBAHG LAEMBNLBKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private FDMOADBLFJJ GBEOJOLEPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private IRecRoomQualityConfigProvider JEMNEKHACOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private bool JMPBLJFNPGB;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6A394D0", Offset = "0x6A37ED0", VA = "0x186A394D0")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	internal static void AABKCNFOEAJ(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D507C0", Offset = "0x5D4F1C0", VA = "0x185D507C0")]
	[UnityEngine.Scripting.Preserve]
	public LEONJOCOGBF([LKKACOOMNBP(null)] FDMOADBLFJJ MDFAMKPOGBA, [LKKACOOMNBP(null)] OJPFIJFBAHG PPCIOPFPMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6A39700", Offset = "0x6A38100", VA = "0x186A39700")]
	private void JAAAHGDHJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6A39C60", Offset = "0x6A38660", VA = "0x186A39C60", Slot = "4")]
	public void NOGOAKNBJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6A39790", Offset = "0x6A38190", VA = "0x186A39790", Slot = "5")]
	public NNLLBGLJADF<Texture2D> LEEGDIECPKO(ELLCNICPFLK EEPCILOCPCA, [Optional] LHPFACMFPID LFOFLLOHBIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6A395D0", Offset = "0x6A37FD0", VA = "0x186A395D0")]
	private uint AENPMEPMKPC(ELLCNICPFLK EEPCILOCPCA, LHPFACMFPID LFOFLLOHBIA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface EPLIMMLNOEK
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOCPGLDBIPD(Mesh LDNHICGPCIN, Matrix4x4 PGKCIOEMCIG, byte[] FNJEDFOJMMF, bool FBBPHGJADOL = false, PCNNDLGLKGM.MLOLFLCAEKK CCPAFCPFGDJ = (PCNNDLGLKGM.MLOLFLCAEKK)0, int DMDHAFGNAJI = -1, bool KLNMFEDDGJI = false);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELOPGGHIDEP(Allocator MPFEIGMBFCP, CPJHDJFONNI HPBMCJPOHKA, byte IFKMCFMPEON, [Optional] IList<int> MFOPCLCHPBM, [Optional] IList<int> EHIIBACCBLG);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct IMLBDEIEBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly GameObject LGHOHMCPDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private readonly AvatarItemMaterial BEGIKPKMAOI;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
	public IMLBDEIEBKN(GameObject LGHOHMCPDNA, AvatarItemMaterial BEGIKPKMAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6A38770", Offset = "0x6A37170", VA = "0x186A38770")]
	public void JJCNNFDKIPG(Material PPFNGNPGEKG, int PJGDMFFOLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KOHINEEODJJ : GJODJEIKLLK<Task<(GameObject, AvatarItemMaterial)>, IMLBDEIEBKN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BCCEIJKGKFL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A2FD70", Offset = "0x6A2E770", VA = "0x186A2FD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6A30270", Offset = "0x6A2EC70", VA = "0x186A30270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private NNLLBGLJADF<GameObject> DGJGLJJKAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private NNLLBGLJADF<AvatarItemMaterial> PNDJNPFFFOJ;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6A39440", Offset = "0x6A37E40", VA = "0x186A39440")]
	private KOHINEEODJJ(Task<(GameObject, AvatarItemMaterial)> DJIALEEMCOO, NNLLBGLJADF<GameObject> EMCHAOCGELL, NNLLBGLJADF<AvatarItemMaterial> MEKBGNKGOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6A38F10", Offset = "0x6A37910", VA = "0x186A38F10")]
	public static KOHINEEODJJ EMJKOLAJLFI(AssetReference GIHPCKGMGJN, [Optional] AssetReference IPLLANDLAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6A38DF0", Offset = "0x6A377F0", VA = "0x186A38DF0", Slot = "11")]
	protected override IMLBDEIEBKN AMKKOAOBGEI(Task<(GameObject, AvatarItemMaterial)> BNHGAHJPDNO)
	{
		return default(IMLBDEIEBKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6A38E90", Offset = "0x6A37890", VA = "0x186A38E90", Slot = "12")]
	protected override void EHACANLJJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6A39310", Offset = "0x6A37D10", VA = "0x186A39310")]
	[AsyncStateMachine(typeof(BCCEIJKGKFL))]
	private static Task<(GameObject, AvatarItemMaterial)> LKEKCMNLFMH(Task<GameObject> EHFNNNADPNB, Task<AvatarItemMaterial> ICKJGAAEKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HLCBDLLLLJF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private class EIGNJEFGHID : GJODJEIKLLK<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private NNLLBGLJADF<MaterialMapAsset> DKMIJDPJCBM;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6A34AE0", Offset = "0x6A334E0", VA = "0x186A34AE0")]
		public EIGNJEFGHID(NNLLBGLJADF<MaterialMapAsset> DKMIJDPJCBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6A34660", Offset = "0x6A33060", VA = "0x186A34660", Slot = "11")]
		protected override Material[] AMKKOAOBGEI(Task<MaterialMapAsset> DJIALEEMCOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6A34A80", Offset = "0x6A33480", VA = "0x186A34A80", Slot = "12")]
		protected override void EHACANLJJKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private class HBGBILKDIDF : GJODJEIKLLK<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private List<NNLLBGLJADF<Material>> MBFKMAJIOBB;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6A38170", Offset = "0x6A36B70", VA = "0x186A38170")]
		public HBGBILKDIDF(Task<Material[]> DJIALEEMCOO, List<NNLLBGLJADF<Material>> MBFKMAJIOBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6A37FE0", Offset = "0x6A369E0", VA = "0x186A37FE0", Slot = "11")]
		protected override Material[] AMKKOAOBGEI(Task<Material[]> BNHGAHJPDNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6A38030", Offset = "0x6A36A30", VA = "0x186A38030", Slot = "12")]
		protected override void EHACANLJJKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6A381E0", Offset = "0x6A36BE0", VA = "0x186A381E0")]
	public static NNLLBGLJADF<Material[]> MAENMIGHKLE(AssetReference[] DJHLIHKEFKN)
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
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x6A39EA0", Offset = "0x6A388A0", VA = "0x186A39EA0")]
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
		private struct JCIKNGFPNMJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public AsyncTaskMethodBuilder<DLDNONNNGBI> <>t__builder;

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
			private TaskAwaiter<DLDNONNNGBI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6A389A0", Offset = "0x6A373A0", VA = "0x186A389A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x6A38D80", Offset = "0x6A37780", VA = "0x186A38D80", Slot = "5")]
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
		private Dictionary<ANINBIHMFJP, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private Dictionary<ANINBIHMFJP, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private Dictionary<ANINBIHMFJP, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private Dictionary<ANINBIHMFJP, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private readonly Dictionary<ANINBIHMFJP, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private DLDNONNNGBI _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private DLDNONNNGBI _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6A37FB0", Offset = "0x6A369B0", VA = "0x186A37FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6A37E90", Offset = "0x6A36890", VA = "0x186A37E90")]
		public DLDNONNNGBI NGNLMMKNODK(KPAFIKBMJHO CEJNFGHJJOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6A377F0", Offset = "0x6A361F0", VA = "0x186A377F0")]
		[AsyncStateMachine(typeof(JCIKNGFPNMJ))]
		public Task<DLDNONNNGBI> BPJHLEFIMBJ(int? IHPKOHFEMFB, int EAHLDFAOJHM, int EPCDGOJDKFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6A37920", Offset = "0x6A36320", VA = "0x186A37920")]
		public NoseFaceOption FPBAIJEILEK(int IDFGDECHMAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6A37D10", Offset = "0x6A36710", VA = "0x186A37D10")]
		public SelectableFaceOption MPLBOOFAAKG(FaceFeatureType LDCDGHGIBGH, ANINBIHMFJP LHPAILEOBNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6A37770", Offset = "0x6A36170", VA = "0x186A37770")]
		public int BELBFKOMAOA(ANINBIHMFJP LHPAILEOBNG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6A37AE0", Offset = "0x6A364E0", VA = "0x186A37AE0")]
		private void JIDMPCIKMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2D5E090", Offset = "0x2D5CA90", VA = "0x182D5E090")]
		private void PKANGBMKJHA<T>(IDictionary<ANINBIHMFJP, T> BHMPBJAIPDE, IReadOnlyList<T> IGKLLPMJHAO) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6A376C0", Offset = "0x6A360C0", VA = "0x186A376C0")]
		public ANINBIHMFJP BCPAKFDNPIO(FaceFeatureType LDCDGHGIBGH)
		{
			return default(ANINBIHMFJP);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6A379C0", Offset = "0x6A363C0", VA = "0x186A379C0")]
		public ANINBIHMFJP FPDHJEJCAPK(FaceFeatureType LDCDGHGIBGH)
		{
			return default(ANINBIHMFJP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6A37F20", Offset = "0x6A36920", VA = "0x186A37F20")]
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
