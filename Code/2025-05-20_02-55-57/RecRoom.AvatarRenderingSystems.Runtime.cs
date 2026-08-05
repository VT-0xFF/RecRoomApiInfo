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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7ACECC0", Offset = "0x7ACDEC0", VA = "0x187ACECC0", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7ADC700", Offset = "0x7ADB900", VA = "0x187ADC700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC690", Offset = "0x7ADB890", VA = "0x187ADC690", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC6C0", Offset = "0x7ADB8C0", VA = "0x187ADC6C0")]
		public RecNetCDNAssetReference(RecNetCDNKey AGBHGDFILGO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum LGLMDAKCKEM : byte
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
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1D4D0", VA = "0x180A1E2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA1E050", Offset = "0xA1D250", VA = "0x180A1E050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LGLMDAKCKEM PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xDB5500", Offset = "0xDB4700", VA = "0x180DB5500")]
			[CompilerGenerated]
			get
			{
				return default(LGLMDAKCKEM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1339D10", Offset = "0x1338F10", VA = "0x181339D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7ADC810", Offset = "0x7ADBA10", VA = "0x187ADC810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC790", Offset = "0x7ADB990", VA = "0x187ADC790")]
		public static RecNetCDNKey LKOBOCODILA(string JGIKMIPHFJD, LGLMDAKCKEM LEGNIKCLGLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC740", Offset = "0x7ADB940", VA = "0x187ADC740")]
		public void KDJJOIEGBPJ(string KPFFFNILFJH, string BDJMEJKDJOJ, bool LNHPGGLNPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CFBFBMEJALB]
public class NPKPOOJPNFH : BGAFHLDDLLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> DGFDOGAPAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> BJJBFDBBCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> BKIJLANLMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> GHOGKKGGCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> AMMBOCGMOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> BEOEPKFBILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> LODOHKLHIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator KGBEFFLJOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected FGOPFGCCILH OBDPJMGFDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte EKOHCCLCJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> JOGIFLKCEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> DNCABGIDJCB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF230", Offset = "0x7ACE430", VA = "0x187ACF230", Slot = "4")]
	public void MBHPLCKMKIG(Mesh KHKMPBIDLPA, Matrix4x4 GOJFCNDHMEN, byte[] BAHOOJKGPPI, bool KLIPPPBAEOH = false, JHAAOOMONHE.GKJIKMBGLPD LLJHGCIOCOH = (JHAAOOMONHE.GKJIKMBGLPD)0L, int CCIBOBBFIBJ = -1, bool GPJBONMNGGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7ACEF90", Offset = "0x7ACE190", VA = "0x187ACEF90", Slot = "5")]
	public void AJGMICOKLPM(Allocator FOPENOLHBOM, FGOPFGCCILH JJCMBBCIHNI, byte EMGNIKJCOOE, [Optional] IList<int> GIKDDOAKEBJ, [Optional] IList<int> OGMIFJLFKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7ACEFD0", Offset = "0x7ACE1D0", VA = "0x187ACEFD0")]
	private static void KKKIDFMEHNB(Mesh KHKMPBIDLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF4B0", Offset = "0x7ACE6B0", VA = "0x187ACF4B0")]
	public NPKPOOJPNFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CFBFBMEJALB]
public struct CAFFGGIKICA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public LPEGNGJFODF LBHMMHBGAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int LAFNOEKMIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public FKLIPJGELLE PLHKMIHPABA;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC82F0", Offset = "0x7AC74F0", VA = "0x187AC82F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[CFBFBMEJALB]
public struct FKLIPJGELLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct LGEIPNHAJHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 OADPKIOCENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 PLEIILPBIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 AHKONODNLEG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct LPIHPGPJMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float PLIPDCAMBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float ODIAFPFNLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float IOOHJLMHKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float GGBNHABKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte PGEPDFJOCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte IAPJHOAOFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte MKKLKOBMIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte EHPGBMJEKDP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct DJPLKPHAOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half PLIPDCAMBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half ODIAFPFNLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half IOOHJLMHKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half GGBNHABKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte PGEPDFJOCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte IAPJHOAOFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte MKKLKOBMIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte EHPGBMJEKDP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct NKJIHDAGJGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 EKKMKLFENBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 OMFBNLCJFCC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NLIMHHHGKLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 EKKMKLFENBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 OMFBNLCJFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 IFBCDHLAHCM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct JOLHICIMICF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 EKKMKLFENBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 OMFBNLCJFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 IFBCDHLAHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 PJPDGMKDHFE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DJEDKAINAGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 EKKMKLFENBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 OMFBNLCJFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 IFBCDHLAHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 PJPDGMKDHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 NLCJGNAMANC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct KJCJCMDIDHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float PLIPDCAMBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float ODIAFPFNLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float IOOHJLMHKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float GGBNHABKMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int PGEPDFJOCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int IAPJHOAOFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int MKKLKOBMIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int EHPGBMJEKDP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct DDKLIDKOHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color EKKMKLFENBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 OMFBNLCJFCC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FFEENJNBDIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color EKKMKLFENBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 OMFBNLCJFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 IFBCDHLAHCM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct NHDAMBLKCOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color EKKMKLFENBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 OMFBNLCJFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 IFBCDHLAHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 PJPDGMKDHFE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct MENBFHAOEHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color EKKMKLFENBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 OMFBNLCJFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 IFBCDHLAHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 PJPDGMKDHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 NLCJGNAMANC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool OJMFBOIKPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<LGEIPNHAJHE> ADEJOMDDMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<NKJIHDAGJGL> NCHGFIFEONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<NLIMHHHGKLB> GLPHMJKJIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<JOLHICIMICF> JCEGFHDHHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<DJEDKAINAGC> MHODHIAJJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<DJPLKPHAOIL> FOFDLKEHBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<LPIHPGPJMGK> KOBHMDKNJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<DDKLIDKOHGN> GMINEIJPDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<FFEENJNBDIN> FJJCCJOLPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<NHDAMBLKCOJ> LADFBIMGINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<MENBFHAOEHJ> IKAKCCCEPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<KJCJCMDIDHN> ENGODIPLAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> CJIHLBFFCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> BLLOENKDGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> IDILJOOLFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> PJHLHDFBNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> IANNCKDCIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> EKKBNKLKGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> EMKCDIAMOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> PJDLGAIFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> MGEECOGALOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool NGHCHBBELHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool DAACGONLPME;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DCDCJFJECNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC280", Offset = "0x7ACB480", VA = "0x187ACC280")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC3C0", Offset = "0x7ACB5C0", VA = "0x187ACC3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BOMOFDKMINA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7ACB080", Offset = "0x7ACA280", VA = "0x187ACB080")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBE40", Offset = "0x7ACB040", VA = "0x187ACBE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FNALNOMAGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC3E0", Offset = "0x7ACB5E0", VA = "0x187ACC3E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC3D0", Offset = "0x7ACB5D0", VA = "0x187ACC3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HFGKBMHEIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7ACB090", Offset = "0x7ACA290", VA = "0x187ACB090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC490", Offset = "0x7ACB690", VA = "0x187ACC490")]
	public FKLIPJGELLE(int DCBFKDPHPBD, int MAMNEILKOJK, int FNKIJAFCMIE, int BCGGNJEPMFI, Allocator FOPENOLHBOM, int CKBLGPBHGLN, NCHOFAPFJKL EDBFDEOOKFC, bool NGHCHBBELHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC3F0", Offset = "0x7ACB5F0", VA = "0x187ACC3F0")]
	public void PDAJHHCMPHG(int NIBICIJAIGM, Vector3 KOBHBJCHIOC, Vector3 EMNFBEIKLFD, Vector4 PNIEJJKFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7ACBE50", Offset = "0x7ACB050", VA = "0x187ACBE50")]
	public void KKGFKGMBLKP(int NIBICIJAIGM, BoneWeight IAJPKGMAAJB, NativeSlice<byte> BAHOOJKGPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7ACBB10", Offset = "0x7ACAD10", VA = "0x187ACBB10")]
	public Color JDCCPOHKNHI(int NIBICIJAIGM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB360", Offset = "0x7ACA560", VA = "0x187ACB360")]
	public void GPMLMMPGPJF(int NIBICIJAIGM, Color FLCLDMGPCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB760", Offset = "0x7ACA960", VA = "0x187ACB760")]
	public void IBAPDCHDLEB(byte JLGKAPOAIED, int NIBICIJAIGM, Vector2 PDEMJJEJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC480", Offset = "0x7ACB680", VA = "0x187ACC480")]
	public void PKLDMACAOPJ(int NIBICIJAIGM, int PCGFOPNDGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC290", Offset = "0x7ACB490", VA = "0x187ACC290")]
	public bool LNOPEDODMJP(int JLGKAPOAIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC2F0", Offset = "0x7ACB4F0", VA = "0x187ACC2F0")]
	public void LPCIPBMFJNH(int EOMFIEIIDIK, int OEBFFKLMAPN, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB100", Offset = "0x7ACA300", VA = "0x187ACB100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7ACA140", Offset = "0x7AC9340", VA = "0x187ACA140")]
	public Mesh AKHLHOBJLFF([Optional] string AOCHEAJEPFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[CFBFBMEJALB]
[NativeContainer]
public struct LPEGNGJFODF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray NNENJNFEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> GBBPPCJKKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> BMOHBNDLMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> PJDLGAIFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> BOKOHPJCLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> AEJNLFLDDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> LGJEMLHAPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> NHOGDHADBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> MFAEODIAJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> HCKLJFMGEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> POHPLEJHGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> GPJBONMNGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> CCIBOBBFIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool NGHCHBBELHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> NNFEBEMODOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool DAACGONLPME;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NLHBJPKIOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD8B0", Offset = "0x7ACCAB0", VA = "0x187ACD8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KLGHBIHAPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDA90", Offset = "0x7ACCC90", VA = "0x187ACDA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PLKAOBJAMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD8D0", Offset = "0x7ACCAD0", VA = "0x187ACD8D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CPALJLJFIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD4B0", Offset = "0x7ACC6B0", VA = "0x187ACD4B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD4A0", Offset = "0x7ACC6A0", VA = "0x187ACD4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DCDCJFJECNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDA80", Offset = "0x7ACCC80", VA = "0x187ACDA80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDAA0", Offset = "0x7ACCCA0", VA = "0x187ACDAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int LJMGCPEKGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDA70", Offset = "0x7ACCC70", VA = "0x187ACDA70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDAB0", Offset = "0x7ACCCB0", VA = "0x187ACDAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public FGOPFGCCILH NJANCDAFFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDAC0", Offset = "0x7ACCCC0", VA = "0x187ACDAC0")]
		get
		{
			return default(FGOPFGCCILH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD4D0", Offset = "0x7ACC6D0", VA = "0x187ACD4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte CHINDJOFGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD8C0", Offset = "0x7ACCAC0", VA = "0x187ACD8C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD4C0", Offset = "0x7ACC6C0", VA = "0x187ACD4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GMMFPGMLOAP JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD4E0", Offset = "0x7ACC6E0", VA = "0x187ACD4E0")]
		get
		{
			return default(GMMFPGMLOAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7ACDAD0", Offset = "0x7ACCCD0", VA = "0x187ACDAD0")]
	public LPEGNGJFODF(IList<Mesh> PMGBCOIIHFG, IList<Matrix4x4> ADNPLCNJCJL, IList<bool> GPJBONMNGGN, byte EMGNIKJCOOE, IList<byte[]> CLFIFGJOOPD, IList<long> AKKOIHNMLAO, IList<bool> ICGOJMGIEBA, IList<int> CCIBOBBFIBJ, IList<int> GIKDDOAKEBJ, IList<int> MJNCILAEFDF, Allocator FOPENOLHBOM, FGOPFGCCILH JJCMBBCIHNI, bool NGHCHBBELHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7ACD9A0", Offset = "0x7ACCBA0", VA = "0x187ACD9A0")]
	public FKLIPJGELLE KGHNGNCEPJA(Allocator FOPENOLHBOM, NCHOFAPFJKL EDBFDEOOKFC)
	{
		return default(FKLIPJGELLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7ACD730", Offset = "0x7ACC930", VA = "0x187ACD730", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CFBFBMEJALB]
public class CBCOEAMODPM : NPKPOOJPNFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool AICPIHNOOPK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker FMNDEAGKJPK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7AC9DB0", Offset = "0x7AC8FB0", VA = "0x187AC9DB0")]
	public LPEGNGJFODF AJCAJLCNOMD()
	{
		return default(LPEGNGJFODF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7ACA0B0", Offset = "0x7AC92B0", VA = "0x187ACA0B0")]
	public CBCOEAMODPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GMMFPGMLOAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData DIFNLDIDLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> PJDLGAIFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> DLLHDHDFLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int BAJACHCMPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 IOMPPBABBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long EINOOCAHEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> BAHOOJKGPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool DMMMFHBHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int LNPIKGNMFOB;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PGFGDPCGKIK : KILAHEJLJLB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IPFAONANDEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public OOCDAONIGLJ avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public PGFGDPCGKIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public GCMBNCCDKOG buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action<KeyValuePair<string, PAACHOBIIFN<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IPFAONANDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7ACCFA0", Offset = "0x7ACC1A0", VA = "0x187ACCFA0")]
		internal bool EADEKCEANNA(PMPGDBHEJJO item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD110", Offset = "0x7ACC310", VA = "0x187ACD110")]
		internal void ONFJJPNGCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7ACCF80", Offset = "0x7ACC180", VA = "0x187ACCF80")]
		internal void PEIPIOBDMHD(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD110", Offset = "0x7ACC310", VA = "0x187ACD110")]
		internal void MJHKEGELHEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7ACCF80", Offset = "0x7ACC180", VA = "0x187ACCF80")]
		internal void DJGBPEEEEFI(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD0B0", Offset = "0x7ACC2B0", VA = "0x187ACD0B0")]
		internal void FDBIGPBICFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD0E0", Offset = "0x7ACC2E0", VA = "0x187ACD0E0")]
		internal void JIJMJONJIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7ACCFF0", Offset = "0x7ACC1F0", VA = "0x187ACCFF0")]
		internal void EOCAMNMJDHD(Dictionary<string, PAACHOBIIFN<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7ACCEC0", Offset = "0x7ACC0C0", VA = "0x187ACCEC0")]
		internal void CKCKGKMKIEM(KeyValuePair<string, PAACHOBIIFN<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		internal IJPNCIBDOFL LFPPLDIIGLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ANFPNBBEIJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public IPFAONANDEI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ANFPNBBEIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AC68E0", Offset = "0x7AC5AE0", VA = "0x187AC68E0")]
		internal GFIAJMEIGOG AJEPKOJEDGM(int lod)
		{
			return default(GFIAJMEIGOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class KECMGCPFFOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CMEBMOPMCFP<Dictionary<string, PAACHOBIIFN<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KECMGCPFFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		internal CMEBMOPMCFP<Dictionary<string, PAACHOBIIFN<Texture2D>>> PJDOOEMHEGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JPCGBFKIBEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<GCMBNCCDKOG> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JPCGBFKIBEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD130", Offset = "0x7ACC330", VA = "0x187ACD130")]
		internal void ANHNMFOIDMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ALJBLBLFJFM : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public PGFGDPCGKIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<FLOGFKECHKC> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<GCMBNCCDKOG> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Func<int, GFIAJMEIGOG> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public ABHKOLGDLEL materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public ALJBLBLFJFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6610", Offset = "0x7AC5810", VA = "0x187AC6610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6890", Offset = "0x7AC5A90", VA = "0x187AC6890", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LCHGFEEAFIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public GMCBKNKNOJM cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LCHGFEEAFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xAA2900", Offset = "0xAA1B00", VA = "0x180AA2900")]
		internal void MIKHONIFNLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xCE4F10", Offset = "0xCE4110", VA = "0x180CE4F10")]
		internal void KPOLANLAIEH(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IFBHJCFICEC
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
		public PGFGDPCGKIK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IFBHJCFICEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KOINNHFBEOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FKLIPJGELLE defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public LPEGNGJFODF defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IFBHJCFICEC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KOINNHFBEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD260", Offset = "0x7ACC460", VA = "0x187ACD260")]
		internal void HMGLAKALJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x12798C0", Offset = "0x1278AC0", VA = "0x1812798C0")]
		internal void KKDHOLHBKOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NNIGHHJNEFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public OODMLKPNGAI legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public OOOELIAMCHI legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public IFBHJCFICEC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NNIGHHJNEFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7ACED50", Offset = "0x7ACDF50", VA = "0x187ACED50")]
		internal void MFLFNBJLMHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1279610", Offset = "0x1278810", VA = "0x181279610")]
		internal void KCGKAIOMDKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DKHHMMEOACE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public KPCHKNGGLCC overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DKHHMMEOACE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA0C0", Offset = "0x7AC92C0", VA = "0x187ACA0C0")]
		internal bool CCPABGJDEGO(KeyValuePair<string, PMPGDBHEJJO> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly JGNOJICCDHE NEIFHOLANJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JGNOJICCDHE BLIPEMMBIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<ONHCMAHDMCI, float> PIGOMNKEDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<LPBIBCFKFIO, float> NMPAPHENODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<MGJJLPJHDIJ, float> NPMLDNEKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, FEBMAHNDAMD> IIAMOMDHHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, FEBMAHNDAMD> HCMHIEONKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, FEBMAHNDAMD> GMJNMPHCOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, FEBMAHNDAMD> MKDHKPCPNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private GFCHKNGLAOD JKKGOGLMBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private GFCHKNGLAOD CDAEFAJNMOK;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float KMFCBHIHOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? HNKDECOFPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? GAIBNIJFDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? IFDOOKMKAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? OOFLMGHNBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration EOKGNJPLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform ADDJOMHMNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem EKFAMCKMKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference KHMEOEECMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject KOOBJEEGFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject HCKCMFNLDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer OMKEKOCGHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData CFEKCKGMLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] EHGGEGJJPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] MMKDJAJKKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material CIOFMOHBKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material BFNAHKNHOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material JMPBICPHHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material NJMKLIOIJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader GAOLBFLBIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Shader OJHGBAMIELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator JBMIOLOFNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Renderer[] HEDAJOIABLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private JHAAOOMONHE.GKJIKMBGLPD GOMCMMHDCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyPartShapesManager FDJIGNBAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IReadOnlyDictionary<string, Transform> FGJEMCPDHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarFaceShapeData.JFNENHFDCCA CCJMPFOPKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private AvatarBodyShapeData.ELAFEKJMLDJ HJGCKKDGKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private BBICHONDDFB CICMJPMDFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool KEMJDIBFAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool PHCPIACCMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color BPHOLAHMAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color HGKALJGEMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color HNNKMENFDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? KAAMIKACMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? LPLGBFOHLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? IPKJANLDAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Color? EHKGGLDINJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D FIAIJNAHMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Texture2D ELNGAOBMDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[CanBeNull]
	private PMPGDBHEJJO JMJMAMNCNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Texture OOIFDKFKFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color NCMOJEODONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Dictionary<Renderer, ABHKOLGDLEL> PNJCHNOHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<Renderer, ABHKOLGDLEL> LKIIEEAEPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<MFMPGCGPJJF>> IHKACDLHACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<string, List<MFMPGCGPJJF>> IDLCHKADAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<NCBKHDICHNJ> MHOFLGFHKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<NCBKHDICHNJ> NFFEHFDCDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<NCBKHDICHNJ> LABMHMIJKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<NCBKHDICHNJ> BLBKPGIDEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<MFMPGCGPJJF, Material> LHDIHNFHOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<MFMPGCGPJJF, Material> PODOBEJEJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] GKOPCGFFMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] ELGBPBIPHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] CAJAIOLEGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private SkinnedMeshRenderer[] HEOEBLDLHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, PAACHOBIIFN<Texture2D>> EBBHCNDJPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Dictionary<string, PAACHOBIIFN<Texture2D>> KBCKIACOMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData GJEAEDCDMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AdditionalHatData GBBNBFGCCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData AKBHNMLELMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HairData MNPILBHKLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private EDFKFIPIEMK FCHENAFAOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool? ACBLNMNIPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private PositionAndRotation BINGNHCFGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Transform FAKBDDGLOAA;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material BGEDLODPPGG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Material IEADPJPPDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<string, PMPGDBHEJJO> EMMOGONDKHC;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int KNAANEMGIMC;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int EIMELNBNCKF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int KLGKEPOFGNG;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int IPGNDPCHANK;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int GKABOLAACEH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int MMIMELILFNM;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int LENGJOFMOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool PJLMIMMOFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> EFMGKMBMNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private INLCADECIKI BPJLOOKGJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private SkinnedMeshRenderer[] HDNBAICMMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int CJGDBKGEKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool DHOEHNNLKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int COOOABCCHAE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public JGNOJICCDHE KNJPEOJLAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public JGNOJICCDHE BJBJBIOFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private HJGCGGODOAD MIFPNJKPFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA370", Offset = "0x7AD9570", VA = "0x187ADA370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool NLDLBLLMHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1690", Offset = "0x7AD0890", VA = "0x187AD1690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool FIFAENNHDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD6970", Offset = "0x7AD5B70", VA = "0x187AD6970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool PHIPGIFAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0250", Offset = "0x7ACF450", VA = "0x187AD0250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool LOMNODMLCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD2100", Offset = "0x7AD1300", VA = "0x187AD2100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration BMPCHJILGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CIPDOFBCBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9D10", Offset = "0x7AD8F10", VA = "0x187AD9D10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA440", Offset = "0x7AD9640", VA = "0x187ADA440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material FMAKHLKKPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7AD8C00", Offset = "0x7AD7E00", VA = "0x187AD8C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material FIEDOJDKGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7ACFBA0", Offset = "0x7ACEDA0", VA = "0x187ACFBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool OJHCHHMGIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public EAEHACEIFMC AOFKIEDHDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7AD14A0", Offset = "0x7AD06A0", VA = "0x187AD14A0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(EAEHACEIFMC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4C50", Offset = "0x7AD3E50", VA = "0x187AD4C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material DGPJPOKGJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCCA9E0", Offset = "0xCC9BE0", VA = "0x180CCA9E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] CKDEKAHPBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x13654B0", Offset = "0x13646B0", VA = "0x1813654B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] LFMOFCEKGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xAA8460", Offset = "0xAA7660", VA = "0x180AA8460", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OCCILOJLMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7E70", Offset = "0x7AD7070", VA = "0x187AD7E70", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public JHAAOOMONHE.GKJIKMBGLPD FIBDLJLBPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8470", Offset = "0xAA7670", VA = "0x180AA8470", Slot = "20")]
		get
		{
			return default(JHAAOOMONHE.GKJIKMBGLPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NFEJMCKEBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x11FFD10", Offset = "0x11FEF10", VA = "0x1811FFD10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7ACF790", Offset = "0x7ACE990", VA = "0x187ACF790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool HIHAHNHMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9760", Offset = "0x7AD8960", VA = "0x187AD9760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool PDKDOOJDGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2D40", Offset = "0x7AD1F40", VA = "0x187AD2D40", Slot = "15")]
	public GCMBNCCDKOG GNIGIOBJFPG(OOCDAONIGLJ ANOJDILGPKP, bool MKKGENLJJFA, int[] HKPFCOLCDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4BD0", Offset = "0x7AD3DD0", VA = "0x187AD4BD0", Slot = "14")]
	public GCMBNCCDKOG HKOAFPANJDF(OOCDAONIGLJ ANOJDILGPKP, bool MKKGENLJJFA, int[] HKPFCOLCDHL, Func<Dictionary<string, PMPGDBHEJJO>, (GCMBNCCDKOG, CMEBMOPMCFP<Dictionary<string, PAACHOBIIFN<Texture2D>>>)> ENPAKEJNFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2F50", Offset = "0x7AD2150", VA = "0x187AD2F50")]
	public GCMBNCCDKOG HKJEKGECDBM(OOCDAONIGLJ ANOJDILGPKP, bool MKKGENLJJFA, int[] HKPFCOLCDHL, bool PGABJPLIDKP, GFCHKNGLAOD JPJGODENIBE, [Optional] Func<Dictionary<string, PMPGDBHEJJO>, (GCMBNCCDKOG, CMEBMOPMCFP<Dictionary<string, PAACHOBIIFN<Texture2D>>>)> ENPAKEJNFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5F50", Offset = "0x7AD5150", VA = "0x187AD5F50")]
	private bool JAGODBCEKMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AD21E0", Offset = "0x7AD13E0", VA = "0x187AD21E0")]
	private GCMBNCCDKOG GANMBMNLBEJ(bool MKKGENLJJFA, List<FLOGFKECHKC> GFDOMBEAPIE, int[] HKPFCOLCDHL, Func<int, GFIAJMEIGOG> FCDJOJPEMMJ, bool PGABJPLIDKP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AD27C0", Offset = "0x7AD19C0", VA = "0x187AD27C0")]
	[IteratorStateMachine(typeof(ALJBLBLFJFM))]
	private IEnumerator<EAALCCOKLJL> GCJCBHKBAOO(bool MKKGENLJJFA, List<FLOGFKECHKC> GFDOMBEAPIE, int[] HKPFCOLCDHL, Func<int, GFIAJMEIGOG> FCDJOJPEMMJ, ABHKOLGDLEL GCNKBAKNKDA, Material JMKFNDKNLIC, List<GCMBNCCDKOG> IPIMBJCIOGO, bool KGKBFDCCNCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9D40", Offset = "0x7AD8F40", VA = "0x187AD9D40")]
	private void OEMMCKHLHBC(List<FLOGFKECHKC> GFDOMBEAPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0330", Offset = "0x7ACF530", VA = "0x187AD0330")]
	private GCMBNCCDKOG CFBAHCLFIED(List<FLOGFKECHKC> GFDOMBEAPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6C10", Offset = "0x7AD5E10", VA = "0x187AD6C10")]
	private PEFNPNHCEAP KNMEMMGFJPM(List<FLOGFKECHKC> GFDOMBEAPIE, int ANANLCFKCEG, bool MKKGENLJJFA, GFIAJMEIGOG LFADMJJFICC, bool EICCOGFIMIE, ABHKOLGDLEL GCNKBAKNKDA, Material JMKFNDKNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7AD15A0", Offset = "0x7AD07A0", VA = "0x187AD15A0", Slot = "27")]
	public void EDCAPENFCGI(ONHCMAHDMCI HCHJEDBHCCL, float MLCDCHNOCFI, bool HDJECOPNGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6020", Offset = "0x7AD5220", VA = "0x187AD6020", Slot = "29")]
	public void JCGPLDNNGLM(LPBIBCFKFIO HGHKNANFPLC, float MLCDCHNOCFI, bool KKKHACBMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7ADB6B0", Offset = "0x7ADA8B0", VA = "0x187ADB6B0", Slot = "30")]
	public void PGFBGHOIBHP(MGJJLPJHDIJ CAIBEMJLLEB, float MLCDCHNOCFI, bool FBFICBOKLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1540", Offset = "0x7AD0740", VA = "0x187AD1540", Slot = "28")]
	public void EBKIEHKKHEH(bool OIPOGEDCFLG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7ADA3E0", Offset = "0x7AD95E0", VA = "0x187ADA3E0", Slot = "31")]
	public void OLHBKBLGACG(bool OIPOGEDCFLG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7AD8DA0", Offset = "0x7AD7FA0", VA = "0x187AD8DA0", Slot = "32")]
	public void MBMHCMPPBPD(bool OIPOGEDCFLG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7ADBA20", Offset = "0x7ADAC20", VA = "0x187ADBA20")]
	private void PLIINEIBKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7AD8690", Offset = "0x7AD7890", VA = "0x187AD8690")]
	private void LHFKMJJOKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9C60", Offset = "0x7AD8E60", VA = "0x187AD9C60")]
	private void NMBMHDJJKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2E90", Offset = "0x7AD2090", VA = "0x187AD2E90", Slot = "25")]
	public void HKCOPHJNLHG(AvatarFaceShape JGFEANPMJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9520", Offset = "0x7AD8720", VA = "0x187AD9520", Slot = "26")]
	public void MMODBKCPOEG(AvatarBodyShape LANMJKKBJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE4C0", Offset = "0xAAD6C0", VA = "0x180AAE4C0", Slot = "33")]
	public void JHEDIGIGILD(BBICHONDDFB OOAIFJBLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0DE0", Offset = "0x7ACFFE0", VA = "0x187AD0DE0", Slot = "35")]
	public void DCOANMBJHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD19B0", Offset = "0x7AD0BB0", VA = "0x187AD19B0", Slot = "38")]
	public void FCGBEMNIEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFB90", Offset = "0x7ACED90", VA = "0x187ACFB90", Slot = "34")]
	public void AGNMCCDDICP(bool AIPNIOHNACK, bool MHAGBACIBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFA40", Offset = "0x7ACEC40", VA = "0x187ACFA40")]
	private void AGFFLOJBPAA(SkinnedMeshRenderer NGIIHFCDLIK, int ANANLCFKCEG, Mesh KHKMPBIDLPA, List<Material> AMPODIDADNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFDB0", Offset = "0x7ACEFB0", VA = "0x187ACFDB0")]
	private static Material BCMEIGHBNOP(Dictionary<MFMPGCGPJJF, Material> CECHFCMPIOG, Material FMCJDGHFODJ, AJMCIGPEEJK OLINJDDNCOO, GDHLKBLKMHG FBEFFFKKANF, KPCHKNGGLCC IKCLPEICFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0060", Offset = "0x7ACF260", VA = "0x187AD0060")]
	private static AJMCIGPEEJK BLEBDLJPHCD(FLOGFKECHKC EHKLPHPBADH, int FHPOHJMOJFO)
	{
		return default(AJMCIGPEEJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1B00", Offset = "0x7AD0D00", VA = "0x187AD1B00")]
	private void FGHLDBDHJMH(int LKJMKPMCGAN, Material OHHEKLKCMJA, FLOGFKECHKC EHKLPHPBADH, [Out] Texture2D FELKHENEICC, [Out] Vector4 PCLAOEBKAKB, [Out] Texture2D OFFIJIDCAOK, [Out] Texture2D KPDHDGJOJLK, [Out] Texture2D OLCIINLMAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7AD8740", Offset = "0x7AD7940", VA = "0x187AD8740")]
	private void LKGMOMLLBGD(int LKJMKPMCGAN, Material OHHEKLKCMJA, FLOGFKECHKC EHKLPHPBADH, [Out] Color KGCAJMAKBGH, [Out] Color POBKIOMOBMH, [Out] Color NNNEJFKHENP, [Out] Color CNDJGDIHNNG, [Out] Color GLECNHGBAGO, [Out] Color DOKEAOFICLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF7B0", Offset = "0x7ACE9B0", VA = "0x187ACF7B0")]
	private bool ABILLAAMLPH(Material OHHEKLKCMJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0580", Offset = "0x7ACF780", VA = "0x187AD0580")]
	private static Material CGNNJIHPBDG(int LKJMKPMCGAN, DLPEPFPEBIO EHKLPHPBADH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7AD18D0", Offset = "0x7AD0AD0", VA = "0x187AD18D0")]
	private static GDHLKBLKMHG EPNJFMGOBMK(FLOGFKECHKC EHKLPHPBADH, int FHPOHJMOJFO)
	{
		return default(GDHLKBLKMHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6270", Offset = "0x7AD5470", VA = "0x187AD6270")]
	private static void JJEGFFOMNCO(Dictionary<string, List<MFMPGCGPJJF>> JPGJDFDDJJG, FLOGFKECHKC BNGNPDJEBAE, Material FMCJDGHFODJ, AJMCIGPEEJK OLEMJHJGMFO, GDHLKBLKMHG CNMOECIJMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7AD65C0", Offset = "0x7AD57C0", VA = "0x187AD65C0")]
	private static SkinnedMeshRenderer KFHHOGPPFGG(Transform FOEMNNBAHCL, Transform INGILMLKLGK, SkinnedMeshRenderer[] CDEFDFNJKAI, int ANANLCFKCEG, GFIAJMEIGOG LFADMJJFICC, bool MKKGENLJJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7ADBCE0", Offset = "0x7ADAEE0", VA = "0x187ADBCE0")]
	public PGFGDPCGKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5300", Offset = "0x7AD4500", VA = "0x187AD5300")]
	public void ILLMBOBOELN([In] COGPNFOCIKO OFMHIGCOLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFF10", Offset = "0x7ACF110", VA = "0x187ACFF10")]
	public void BDOPOEJBFHA([In] GCLHNAIOIIA NBKGLOLFPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF790", Offset = "0x7ACE990", VA = "0x187ACF790", Slot = "5")]
	public void KCMBKCHDOKL(int ANANLCFKCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7AD07A0", Offset = "0x7ACF9A0", VA = "0x187AD07A0", Slot = "10")]
	public void CMDDFEIEOAB(AFFMCAMHIHB CNMOECIJMMD, Texture2D BEFHHDCIDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
	public static bool MBCAPJFCOKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6100", Offset = "0x7AD5300", VA = "0x187AD6100", Slot = "11")]
	public bool JCPJKFKKFCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5670", Offset = "0x7AD4870", VA = "0x187AD5670", Slot = "9")]
	public void INAKPNOAHGH(HOFHEGKKJJF OLEMJHJGMFO, Color? EKKMKLFENBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFC90", Offset = "0x7ACEE90", VA = "0x187ACFC90")]
	private void ALEEJPOPFEN(Action DFECBELNIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4E40", Offset = "0x7AD4040", VA = "0x187AD4E40", Slot = "6")]
	public void IBPIMGMABCF(PMPGDBHEJJO IMPCPINIMCF, Texture BNCPHJFACKF, Color AEDNIMIDBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7ADA440", Offset = "0x7AD9640", VA = "0x187ADA440", Slot = "7")]
	public void PMDFJPEENLD(bool KGKBFDCCNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1C3FAC0", Offset = "0x1C3ECC0", VA = "0x181C3FAC0", Slot = "8")]
	public void PNKFGMHILPK(INLCADECIKI MGEECOGALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7AD98B0", Offset = "0x7AD8AB0", VA = "0x187AD98B0", Slot = "16")]
	public void NHHAABJGCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7AD14B0", Offset = "0x7AD06B0", VA = "0x187AD14B0", Slot = "36")]
	public void DLPBOKCBGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7ADA870", Offset = "0x7AD9A70", VA = "0x187ADA870", Slot = "37")]
	public void PELBFOCHNHI([Optional] EDFKFIPIEMK NEGNAILDEPM, [Optional] bool? ILADGOANCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0B10", Offset = "0x7ACFD10", VA = "0x187AD0B10")]
	private bool CNAIJJBHNPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7AD85A0", Offset = "0x7AD77A0", VA = "0x187AD85A0", Slot = "21")]
	public bool LGJMJJEKLBH(JHAAOOMONHE.GKJIKMBGLPD NMLHLIMGHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7AD05D0", Offset = "0x7ACF7D0", VA = "0x187AD05D0")]
	private void CGOKAKACJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0790", Offset = "0x7ACF990", VA = "0x187AD0790")]
	private void CIECNEBAHPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7ADB8C0", Offset = "0x7ADAAC0", VA = "0x187ADB8C0")]
	private static void PHHOIAJLOFD(Dictionary<MFMPGCGPJJF, Material> CECHFCMPIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1770", Offset = "0x7AD0970", VA = "0x187AD1770")]
	private static void EOHGOCAHNAK(Dictionary<Renderer, ABHKOLGDLEL> HCBFNNAEFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7ADB7A0", Offset = "0x7ADA9A0", VA = "0x187ADB7A0")]
	private void PGHHOANOLLD(SkinnedMeshRenderer[] CDEFDFNJKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFD10", Offset = "0x7ACEF10", VA = "0x187ACFD10")]
	private void BAFMEPNDAJI(SkinnedMeshRenderer GMHNGMFBFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4C60", Offset = "0x7AD3E60", VA = "0x187AD4C60")]
	private void IBNCGNDJIOE(List<NCBKHDICHNJ> KFMEKLDKNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7AD67F0", Offset = "0x7AD59F0", VA = "0x187AD67F0")]
	private void KIFEFENDADM(Dictionary<string, PAACHOBIIFN<Texture2D>> JPGJDFDDJJG, bool LBIDBPOLBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4C00", Offset = "0x7AD3E00", VA = "0x187AD4C00")]
	private void HNNPEFLNHMH(Dictionary<string, List<MFMPGCGPJJF>> JPGJDFDDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9610", Offset = "0x7AD8810", VA = "0x187AD9610")]
	private void NCENGCDDCGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0C50", Offset = "0x7ACFE50", VA = "0x187AD0C50")]
	private void DADCMKAINOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7AD7FE0", Offset = "0x7AD71E0", VA = "0x187AD7FE0")]
	private void LFNJBMFICBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7AD85C0", Offset = "0x7AD77C0", VA = "0x187AD85C0")]
	private void LHENHJHCEPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5270", Offset = "0x7AD4470", VA = "0x187AD5270")]
	private void IGBFMFNKDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7AD09C0", Offset = "0x7ACFBC0", VA = "0x187AD09C0")]
	private void CMMHNINCNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFF90", Offset = "0x7ACF190", VA = "0x187ACFF90")]
	private void BKJFJDIHMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0170", Offset = "0x7ACF370", VA = "0x187AD0170")]
	private void CBIJENKFAIK(bool HNKFKHLFGID = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7AD97E0", Offset = "0x7AD89E0", VA = "0x187AD97E0")]
	private void NGHNNNBEGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7ADBAA0", Offset = "0x7ADACA0", VA = "0x187ADBAA0")]
	private void POFPEMHNEBP(bool HNKFKHLFGID = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4EB0", Offset = "0x7AD40B0", VA = "0x187AD4EB0")]
	private void ICCNAOEOPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5A70", Offset = "0x7AD4C70", VA = "0x187AD5A70")]
	private void IOHCLOOEDFD(Material JMKFNDKNLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9AF0", Offset = "0x7AD8CF0", VA = "0x187AD9AF0")]
	private void NKOJMKHBEOA(Material JMKFNDKNLIC, Color PLHNAIINEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AD92E0", Offset = "0x7AD84E0", VA = "0x187AD92E0")]
	private void MJALEIANAJP(Material JMKFNDKNLIC, Color PLHNAIINEDP, Color KEJGIENBHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6A50", Offset = "0x7AD5C50", VA = "0x187AD6A50")]
	private void KLHOCBFNINK(Material JMKFNDKNLIC, Color KGCAJMAKBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1F10", Offset = "0x7AD1110", VA = "0x187AD1F10")]
	private void FHEEFONHDNO(Material JMKFNDKNLIC, Texture2D BEFHHDCIDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1340", Offset = "0x7AD0540", VA = "0x187AD1340")]
	private void DIIAIGHNAKC(Material JMKFNDKNLIC, Texture MBODEKMKKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7AD7D10", Offset = "0x7AD6F10", VA = "0x187AD7D10")]
	private void KOLOAPGKEPL(Action<ABHKOLGDLEL> EBHHBJPKDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7AD11C0", Offset = "0x7AD03C0", VA = "0x187AD11C0")]
	private void DHIGIMGKEPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7ADA450", Offset = "0x7AD9650", VA = "0x187ADA450")]
	private void PCOLKELGMFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2970", Offset = "0x7AD1B70", VA = "0x187AD2970")]
	private void GEDMILDDCGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7AD8E00", Offset = "0x7AD8000", VA = "0x187AD8E00")]
	public void MCJILICOJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFF10", Offset = "0x7ACF110", VA = "0x187ACFF10", Slot = "4")]
	private void HNHABBMJDJH([In] GCLHNAIOIIA NBKGLOLFPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9AB0", Offset = "0x7AD8CB0", VA = "0x187AD9AB0")]
	[CompilerGenerated]
	private IJPNCIBDOFL NHIEOADLBGN(FLOGFKECHKC OJJILHCFMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7AD28E0", Offset = "0x7AD1AE0", VA = "0x187AD28E0")]
	[CompilerGenerated]
	private void GCOJGNELFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7AD8710", Offset = "0x7AD7910", VA = "0x187AD8710")]
	[CompilerGenerated]
	private void LJFKDPBPPPI(ABHKOLGDLEL FCIDOIIAAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF700", Offset = "0x7ACE900", VA = "0x187ACF700")]
	[CompilerGenerated]
	private void AAODCBHFEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5250", Offset = "0x7AD4450", VA = "0x187AD5250")]
	[CompilerGenerated]
	private void IDKOHJHIJCH(ABHKOLGDLEL FCIDOIIAAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2E00", Offset = "0x7AD2000", VA = "0x187AD2E00")]
	[CompilerGenerated]
	private void HAOANLCPDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9D20", Offset = "0x7AD8F20", VA = "0x187AD9D20")]
	[CompilerGenerated]
	private void OCIIAPJMHEG(ABHKOLGDLEL FCIDOIIAAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7AD91C0", Offset = "0x7AD83C0", VA = "0x187AD91C0")]
	[CompilerGenerated]
	private void MEEFHLHFIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7AD95E0", Offset = "0x7AD87E0", VA = "0x187AD95E0")]
	[CompilerGenerated]
	private void MPGKDKAMAKD(ABHKOLGDLEL FCIDOIIAAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9250", Offset = "0x7AD8450", VA = "0x187AD9250")]
	[CompilerGenerated]
	private void MIHODNIJENH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFA10", Offset = "0x7ACEC10", VA = "0x187ACFA10")]
	[CompilerGenerated]
	private void ADBHGJHLJAN(ABHKOLGDLEL FCIDOIIAAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2D70", Offset = "0x7AD1F70", VA = "0x187AD2D70")]
	[CompilerGenerated]
	private void GOAEPLJOOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6BE0", Offset = "0x7AD5DE0", VA = "0x187AD6BE0")]
	[CompilerGenerated]
	private void KMMLKPIGABG(ABHKOLGDLEL FCIDOIIAAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6530", Offset = "0x7AD5730", VA = "0x187AD6530")]
	[CompilerGenerated]
	private void JPCIDBDLJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9CE0", Offset = "0x7AD8EE0", VA = "0x187AD9CE0")]
	[CompilerGenerated]
	private void OAEBAGIBAAO(ABHKOLGDLEL FCIDOIIAAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7AD51D0", Offset = "0x7AD43D0", VA = "0x187AD51D0")]
	[CompilerGenerated]
	private void ICFADBANFAE(KeyValuePair<string, PAACHOBIIFN<Texture2D>> EFEGEHDMNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1680", Offset = "0x7AD0880", VA = "0x187AD1680")]
	[CompilerGenerated]
	private void EGPLLFBPLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9190", Offset = "0x7AD8390", VA = "0x187AD9190")]
	[CompilerGenerated]
	private void MDHEOJEAICD(ABHKOLGDLEL FCIDOIIAAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7ADBB80", Offset = "0x7ADAD80", VA = "0x187ADBB80")]
	[CompilerGenerated]
	private void PPLALEHOKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1510", Offset = "0x7AD0710", VA = "0x187AD1510")]
	[CompilerGenerated]
	private void DMLGBPILGGD(ABHKOLGDLEL FCIDOIIAAIA)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, FNEGHPKEGOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3? IGFGBMAHKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private bool NMJNEGBAAOO;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7AC69A0", Offset = "0x7AC5BA0", VA = "0x187AC69A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6FC0", Offset = "0x7AC61C0", VA = "0x187AC6FC0", Slot = "4")]
		public void UpdateController(float PNLPAJFPFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC55B20", Offset = "0xC54D20", VA = "0x180C55B20", Slot = "6")]
		public void SetEnabled(bool MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6A80", Offset = "0x7AC5C80", VA = "0x187AC6A80")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7480", Offset = "0x7AC6680", VA = "0x187AC7480")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, FNEGHPKEGOG
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private const float ELPNIELKLLB = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 EMHHAGLGLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Vector3 JDHPFEKIPFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private bool NMJNEGBAAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float IIIHCMIPDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private float DBNPEANACDL;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7800", Offset = "0x7AC6A00", VA = "0x187AC7800", Slot = "4")]
		public void UpdateController(float PNLPAJFPFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xE92CC0", Offset = "0xE91EC0", VA = "0x180E92CC0", Slot = "6")]
		public void SetEnabled(bool MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7520", Offset = "0x7AC6720", VA = "0x187AC7520")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7AC82C0", Offset = "0x7AC74C0", VA = "0x187AC82C0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MDNLJPIOKLL : HGCMEOFLAIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int AAGHEAIINMJ;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int LPCEGLDBOEL;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int MAJKEAFPLJI;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int DGHEANCPFCB;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int FLNJDMIEFCC;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int MCFLIBAJJAH;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int LCJHPJEINGO;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int FJHAOPPCCGK;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int DODODNONDBC;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int HCCEEJBBNDE;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int GKEHGHPMGJL;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int DCKGNLJGNBL;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int JAEFAMPDHHF;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int KMEJJJNAFBA;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int OJPLCBLJCKM;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int FHIONJLNACN;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int KCCMPOOHLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Transform FABGMLLCKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform HHKMMMJIDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform ECDFIGMNHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform OPLBAPENLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform KJCGBEIEPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform EBECLCNHJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private LJLIHOKEFLN JPIGGEFFKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Material OHLBAPLMGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private SkinnedMeshRenderer[] JAMDBOFHAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly List<Material> DENEPKCMOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private JOCCOIINFCA POHFPAGKKIH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JGNOJICCDHE LDELPAMPGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private JOCCOIINFCA ALCAMLBCHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7AE98D0", Offset = "0x7AE8AD0", VA = "0x187AE98D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7F70", Offset = "0x7AE7170", VA = "0x187AE7F70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7AE93E0", Offset = "0x7AE85E0", VA = "0x187AE93E0")]
	public void ILLMBOBOELN([In] LJLIHOKEFLN CICFEJKDEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7AE9820", Offset = "0x7AE8A20", VA = "0x187AE9820")]
	public void PNEPDDHIMNO([In] HFLHEHIBPAI EAPLBEJALFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7AE99B0", Offset = "0x7AE8BB0", VA = "0x187AE99B0", Slot = "6")]
	public void NOJFJODDBLD(JGBGKLMHDNG DCJLLFPGBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7AE9950", Offset = "0x7AE8B50", VA = "0x187AE9950")]
	private Vector2 NAKJLDPEKDK(Vector2 COKCAHCHAAA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7AE8130", Offset = "0x7AE7330", VA = "0x187AE8130")]
	public void FIGLOJJMEAH([In] BMGIPJNFMGH EAPLBEJALFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7AE9020", Offset = "0x7AE8220", VA = "0x187AE9020")]
	private void HMBBOMOIAFD(AOAMJBGIKCE OBCLKBLDKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7AE9490", Offset = "0x7AE8690", VA = "0x187AE9490")]
	private void KAMLNGGOION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE80C0", Offset = "0x7AE72C0", VA = "0x187AE80C0")]
	private void MLCFIJNJNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE80C0", Offset = "0x7AE72C0", VA = "0x187AE80C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA240", Offset = "0x7AE9440", VA = "0x187AEA240")]
	public MDNLJPIOKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE9820", Offset = "0x7AE8A20", VA = "0x187AE9820", Slot = "5")]
	private void KPDDGCPNOBB([In] HFLHEHIBPAI EAPLBEJALFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7F20", Offset = "0x7AE7120", VA = "0x187AE7F20", Slot = "7")]
	private void AFLHMIOFDPM([In] BMGIPJNFMGH EAPLBEJALFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7AE98C0", Offset = "0x7AE8AC0", VA = "0x187AE98C0")]
	[CompilerGenerated]
	internal static float MAFPJJLNAJP(float MLCDCHNOCFI, float DBANJKINOGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7AE9E80", Offset = "0x7AE9080", VA = "0x187AE9E80")]
	[CompilerGenerated]
	internal static void OKPHHGOIJHP(Vector2 BLPJCJEDNFF, Vector2 IMPLFJMBMGK, Vector2 JAFKPMJIGFL, Vector2 BCBBNNPFNAH, Vector2 IMCPMFMKKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7F30", Offset = "0x7AE7130", VA = "0x187AE7F30")]
	[CompilerGenerated]
	internal static Vector4 DEBEIHGDIIP(Vector2 BJHAAAPCKLC, Vector2 MMIJFAFPOOH)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, FNEGHPKEGOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private float IIIHCMIPDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private bool NMJNEGBAAOO;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0FC0", Offset = "0x7AE01C0", VA = "0x187AE0FC0", Slot = "4")]
		public void UpdateController(float PNLPAJFPFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x16A8470", Offset = "0x16A7670", VA = "0x1816A8470", Slot = "6")]
		public void SetEnabled(bool MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7AE1820", Offset = "0x7AE0A20", VA = "0x187AE1820")]
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
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7AE18C0", Offset = "0x7AE0AC0", VA = "0x187AE18C0")]
		public void MNFKMEBPDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7AE1850", Offset = "0x7AE0A50", VA = "0x187AE1850")]
		public int EGLJNPGHHFG(int DCCCEFOFIOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class INKDMEIAPOM : BIFJNABDECN
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE74D0", Offset = "0x7AE66D0", VA = "0x187AE74D0", Slot = "22")]
	public override float BBMBLHFHGHF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7520", Offset = "0x7AE6720", VA = "0x187AE7520")]
	public INKDMEIAPOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BIFJNABDECN : APPJCEDIMMA
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int DEKKHBICJLO;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int GPDCBGJLKDK;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int LKEEPIAAJNO;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int KCBGEOKIIME;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int MHEJDNCDKMA;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int MNMEAMOJJOC;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int KIKNKGHBPCK;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int[] EFOGEKBDEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private FJADBKLADKJ JPIGGEFFKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private FCDAGPBMHIJ CMCOGADMPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private int KABMGHOPHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private float JHAJFGDFOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected Animator JBMIOLOFNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected AvatarConfiguration BLOEBHEOKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected int MIGPBDHAHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private int AODLOMHKNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int NPDDEKIALBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private bool NHLBKMGAMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private DCOKIPCFDIJ MFOLNFBGPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int NJBANLEBEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private float IBMACNDDFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private AvatarHandDisplaySettings FCHPFBNMACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private EAEHACEIFMC IOMNMGANAAG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CMGPMHPAFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 CNIKCAAJFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x16B5640", Offset = "0x16B4840", VA = "0x1816B5640")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x16B5630", Offset = "0x16B4830", VA = "0x1816B5630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion LHFLDANBPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xD34DA0", Offset = "0xD33FA0", VA = "0x180D34DA0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xF45E50", Offset = "0xF45050", VA = "0x180F45E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool EPIFJNLCLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7AE35F0", Offset = "0x7AE27F0", VA = "0x187AE35F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7AE3680", Offset = "0x7AE2880", VA = "0x187AE3680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KHCGJOPLOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xD34EB0", Offset = "0xD340B0", VA = "0x180D34EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 KKKPPBPODKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA1DBA0", Offset = "0xA1CDA0", VA = "0x180A1DBA0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA1DBC0", Offset = "0xA1CDC0", VA = "0x180A1DBC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion AMLPEBDPKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x10CFA20", Offset = "0x10CEC20", VA = "0x1810CFA20", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x14723B0", Offset = "0x14715B0", VA = "0x1814723B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public JDHBOJLMCKA IBCCJMHCINN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xAC65D0", Offset = "0xAC57D0", VA = "0x180AC65D0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(JDHBOJLMCKA);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xAC63D0", Offset = "0xAC55D0", VA = "0x180AC63D0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public JDHBOJLMCKA FEAIOCAKGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2561970", Offset = "0x2560B70", VA = "0x182561970", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(JDHBOJLMCKA);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x25606A0", Offset = "0x255F8A0", VA = "0x1825606A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float AJGJPCCBJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xAAF150", Offset = "0xAAE350", VA = "0x180AAF150", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xF52470", Offset = "0xF51670", VA = "0x180F52470", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LFMCDEMHCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7AE37A0", Offset = "0x7AE29A0", VA = "0x187AE37A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AIPLAIPEFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE3EA0", Offset = "0x7AE30A0", VA = "0x187AE3EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GCGPEKPNNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE3E90", Offset = "0x7AE3090", VA = "0x187AE3E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KANCJKJLAAM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE36D0", Offset = "0x7AE28D0", VA = "0x187AE36D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3CF0", Offset = "0x7AE2EF0", VA = "0x187AE3CF0", Slot = "21")]
	public void ILLMBOBOELN(FJADBKLADKJ CICFEJKDEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7AE36E0", Offset = "0x7AE28E0", VA = "0x187AE36E0")]
	public void EKCICMEIPEE(FCDAGPBMHIJ NABBANDAIMD, AvatarHandDisplaySettings PDKFGEDPJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3EB0", Offset = "0x7AE30B0", VA = "0x187AE3EB0", Slot = "12")]
	public void NFGIMKCBDGI(bool BMBINDLKLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7AE37B0", Offset = "0x7AE29B0", VA = "0x187AE37B0", Slot = "11")]
	public void FLFPODIPEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xAAF150", Offset = "0xAAE350", VA = "0x180AAF150", Slot = "22")]
	public virtual float BBMBLHFHGHF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3B70", Offset = "0x7AE2D70", VA = "0x187AE3B70")]
	private int IJENLNNFMEM(JDHBOJLMCKA MMLIHGNBOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3F40", Offset = "0x7AE3140", VA = "0x187AE3F40")]
	private void PAEKLOKFFMJ(int MKGLECIDKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3770", Offset = "0x7AE2970", VA = "0x187AE3770", Slot = "13")]
	public bool FEINPLMJHLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3790", Offset = "0x7AE2990", VA = "0x187AE3790", Slot = "14")]
	public bool FEKBKEOKDMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3620", Offset = "0x7AE2820", VA = "0x187AE3620")]
	private JDHBOJLMCKA BAJCLNMEHKG()
	{
		return default(JDHBOJLMCKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1C059A0", Offset = "0x1C04BA0", VA = "0x181C059A0", Slot = "15")]
	public void FKMDDFKFACI(bool BMBINDLKLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3730", Offset = "0x7AE2930", VA = "0x187AE3730", Slot = "10")]
	public void EKMLNPIGNBK(int MKGLECIDKMH, float JHIFCHHLDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7AE36B0", Offset = "0x7AE28B0", VA = "0x187AE36B0", Slot = "8")]
	public void ECDIAHJEAJB(DCOKIPCFDIJ HPAPEOOKLIH, bool GHGDMNBCOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3670", Offset = "0x7AE2870", VA = "0x187AE3670", Slot = "9")]
	public void BLOLNOBLPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7AE3B20", Offset = "0x7AE2D20", VA = "0x187AE3B20", Slot = "16")]
	public void GKBJOABFGBG(Transform NJHDJGHEICO, Vector3 BKOODGIFLHB, Quaternion EALBDGEIKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7AE4390", Offset = "0x7AE3590", VA = "0x187AE4390")]
	public BIFJNABDECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DLPEPFPEBIO : FLOGFKECHKC
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BMDJMJFCKGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public DLPEPFPEBIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public List<NCBKHDICHNJ> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public List<NCBKHDICHNJ> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PAACHOBIIFN<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public PAACHOBIIFN<JOIGDBKKOCF> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BMDJMJFCKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7AE43B0", Offset = "0x7AE35B0", VA = "0x187AE43B0")]
		internal IJPNCIBDOFL KDMDHJEAKNC(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public PMPGDBHEJJO EMPAIFGAJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public JOIGDBKKOCF FMABLJLCELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private PAACHOBIIFN<JOIGDBKKOCF> AJINJKKCDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private PAACHOBIIFN<Material[]> EJEGFNEECFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Material[] MDMBPBCBCGN;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DJPMNMJEAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1D4D0", VA = "0x180A1E2D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA1E050", Offset = "0xA1D250", VA = "0x180A1E050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JHAAOOMONHE.GKJIKMBGLPD NFHDKGEBCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return default(JHAAOOMONHE.GKJIKMBGLPD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8C0", Offset = "0x9FCAC0", VA = "0x1809FD8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6340", Offset = "0x7AE5540", VA = "0x187AE6340")]
	public DLPEPFPEBIO(KPCHKNGGLCC NFODGIBNOOP, PMPGDBHEJJO AMMEFNMBHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5AC0", Offset = "0x7AE4CC0", VA = "0x187AE5AC0", Slot = "6")]
	public override IJPNCIBDOFL PLDIGGJPKFP(List<NCBKHDICHNJ> PBHHDAJBEAO, List<NCBKHDICHNJ> KLMGPLLBBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5240", Offset = "0x7AE4440", VA = "0x187AE5240")]
	public IJPNCIBDOFL FBNBCNPDPLB(List<NCBKHDICHNJ> PBHHDAJBEAO, List<NCBKHDICHNJ> KLMGPLLBBKN, PAACHOBIIFN<Material[]> EJEGFNEECFB, [Optional] PAACHOBIIFN<JOIGDBKKOCF> IHECKNFJAIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5F60", Offset = "0x7AE5160", VA = "0x187AE5F60")]
	public (PAACHOBIIFN<Material[]>, PAACHOBIIFN<JOIGDBKKOCF>) PPOFEIPHNJA(List<NCBKHDICHNJ> PBHHDAJBEAO, List<NCBKHDICHNJ> KLMGPLLBBKN)
	{
		return default((PAACHOBIIFN<Material[]>, PAACHOBIIFN<JOIGDBKKOCF>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5990", Offset = "0x7AE4B90", VA = "0x187AE5990", Slot = "7")]
	public override NJENFEHNOGL OLFIPHGKNMP(uint ANANLCFKCEG, AvatarSkinnedMeshBoneOrderRemapsData AGEKJKBCPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5030", Offset = "0x7AE4230", VA = "0x187AE5030")]
	public NJENFEHNOGL AONKFNLCFEM(GameObject KHFMJMHIEKD, uint ANANLCFKCEG, bool FOKMLIDBDLP, bool PEJAHIJIDDE, AvatarSkinnedMeshBoneOrderRemapsData AGEKJKBCPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5560", Offset = "0x7AE4760", VA = "0x187AE5560")]
	public static bool LHKGPLMGFBE(Renderer[] CDEFDFNJKAI, string LHLKHGBADJF, [Out] Renderer CIHBJOOFGOE, [Out] Renderer AGPNMKEMDCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7AE62F0", Offset = "0x7AE54F0", VA = "0x187AE62F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7AE58C0", Offset = "0x7AE4AC0", VA = "0x187AE58C0")]
	private (PAACHOBIIFN<JOIGDBKKOCF>, PAACHOBIIFN<Material[]>) NMHDMIOEGIN()
	{
		return default((PAACHOBIIFN<JOIGDBKKOCF>, PAACHOBIIFN<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5540", Offset = "0x7AE4740", VA = "0x187AE5540")]
	[CompilerGenerated]
	private void IOHCBPOIOPF(JOIGDBKKOCF IGGKBIDIAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
	[CompilerGenerated]
	private void BPGHDGMNFIP(Material[] IGGKBIDIAJL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, FNEGHPKEGOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Vector3 EMHHAGLGLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private Vector3 LPJIBBJDLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private Vector3 ANILLBIBGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Matrix4x4 BHLMFPPGMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private bool NMJNEGBAAOO;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE1E50", Offset = "0x7AE1050", VA = "0x187AE1E50", Slot = "4")]
		public void UpdateController(float PNLPAJFPFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE1E40", Offset = "0x7AE1040", VA = "0x187AE1E40", Slot = "6")]
		public void SetEnabled(bool MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE19E0", Offset = "0x7AE0BE0", VA = "0x187AE19E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2510", Offset = "0x7AE1710", VA = "0x187AE2510")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CFBFBMEJALB]
public struct AKBKDIODEAF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[ReadOnly]
	public OOOELIAMCHI LBHMMHBGAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[ReadOnly]
	public int LAFNOEKMIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public OODMLKPNGAI PLHKMIHPABA;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE0040", Offset = "0x7ADF240", VA = "0x187AE0040", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[CFBFBMEJALB]
public struct OODMLKPNGAI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector3> KGEEFFHEBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector3> MJGJOBDPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector4> LGKDIAIONON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector2> NHILDLNBJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector2> PJPDGMKDHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> NLCJGNAMANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> JDEDKPOAHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Color> DLJBBPPIDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> CJIHLBFFCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> BLLOENKDGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NativeArray<int> IDILJOOLFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> PJHLHDFBNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> IANNCKDCIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> EKKBNKLKGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<int> EMKCDIAMOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<BoneWeight> LOEBKNFMKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private NativeArray<int> MGEECOGALOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private bool DAACGONLPME;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int DCDCJFJECNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7AECE50", Offset = "0x7AEC050", VA = "0x187AECE50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7AECF60", Offset = "0x7AEC160", VA = "0x187AECF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BOMOFDKMINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7AEC910", Offset = "0x7AEBB10", VA = "0x187AEC910")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7AECCA0", Offset = "0x7AEBEA0", VA = "0x187AECCA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int FNALNOMAGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7AECF80", Offset = "0x7AEC180", VA = "0x187AECF80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7AECF70", Offset = "0x7AEC170", VA = "0x187AECF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7AED010", Offset = "0x7AEC210", VA = "0x187AED010")]
	public OODMLKPNGAI(int DCBFKDPHPBD, int MAMNEILKOJK, int FNKIJAFCMIE, int BCGGNJEPMFI, Allocator FOPENOLHBOM, int CKBLGPBHGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7AECF90", Offset = "0x7AEC190", VA = "0x187AECF90")]
	public void PDAJHHCMPHG(int NIBICIJAIGM, Vector3 KOBHBJCHIOC, Vector3 EMNFBEIKLFD, Vector4 PNIEJJKFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7AECCB0", Offset = "0x7AEBEB0", VA = "0x187AECCB0")]
	public void KKGFKGMBLKP(int NIBICIJAIGM, BoneWeight IAJPKGMAAJB, NativeSlice<byte> BAHOOJKGPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7AECC80", Offset = "0x7AEBE80", VA = "0x187AECC80")]
	public Color JDCCPOHKNHI(int NIBICIJAIGM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7AECAD0", Offset = "0x7AEBCD0", VA = "0x187AECAD0")]
	public void GPMLMMPGPJF(int NIBICIJAIGM, Color FLCLDMGPCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7AECBA0", Offset = "0x7AEBDA0", VA = "0x187AECBA0")]
	public void IBAPDCHDLEB(byte JLGKAPOAIED, int NIBICIJAIGM, Vector2 PDEMJJEJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7AED000", Offset = "0x7AEC200", VA = "0x187AED000")]
	public void PKLDMACAOPJ(int NIBICIJAIGM, int PCGFOPNDGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7AECE60", Offset = "0x7AEC060", VA = "0x187AECE60")]
	public bool LNOPEDODMJP(int JLGKAPOAIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7AECE90", Offset = "0x7AEC090", VA = "0x187AECE90")]
	public void LPCIPBMFJNH(int EOMFIEIIDIK, int OEBFFKLMAPN, int LMMGFKFHEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7AECAF0", Offset = "0x7AEBCF0", VA = "0x187AECAF0")]
	public int[] HLPKFOHMFOG(int EOMFIEIIDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7AECBF0", Offset = "0x7AEBDF0", VA = "0x187AECBF0")]
	private NativeSlice<int> IPMFCJEEDLO(int EOMFIEIIDIK)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC920", Offset = "0x7AEBB20", VA = "0x187AEC920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC5C0", Offset = "0x7AEB7C0", VA = "0x187AEC5C0")]
	public Mesh AKHLHOBJLFF([Optional] string AOCHEAJEPFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[CFBFBMEJALB]
[DefaultMember("Item")]
[NativeContainer]
public struct OOOELIAMCHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<Vector3> KGEEFFHEBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector3> MJGJOBDPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector4> LGKDIAIONON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector2> NHILDLNBJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector2> PJPDGMKDHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector2> NLCJGNAMANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> JDEDKPOAHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Color> DLJBBPPIDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<int> GHOGMIBLEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> AHGDMJPOGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> KBLEGDGHGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> GIJOEGBHLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<bool> GPJBONMNGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> CCIBOBBFIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> BMOHBNDLMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<BoneWeight> PJDLGAIFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private NativeArray<Matrix4x4> BOKOHPJCLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NativeArray<long> AEJNLFLDDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private NativeArray<byte> LGJEMLHAPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<int> NHOGDHADBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<int> MFAEODIAJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeArray<sbyte> HCKLJFMGEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<byte> POHPLEJHGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> NNFEBEMODOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private bool DAACGONLPME;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int NLHBJPKIOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xDAF870", Offset = "0xDAEA70", VA = "0x180DAF870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KLGHBIHAPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xC585F0", Offset = "0xC577F0", VA = "0x180C585F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int PLKAOBJAMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDC60", Offset = "0x7AECE60", VA = "0x187AEDC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int CPALJLJFIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7AED480", Offset = "0x7AEC680", VA = "0x187AED480")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7AED470", Offset = "0x7AEC670", VA = "0x187AED470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int DCDCJFJECNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDD70", Offset = "0x7AECF70", VA = "0x187AEDD70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDD80", Offset = "0x7AECF80", VA = "0x187AEDD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int LJMGCPEKGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDD60", Offset = "0x7AECF60", VA = "0x187AEDD60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDD90", Offset = "0x7AECF90", VA = "0x187AEDD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FGOPFGCCILH NJANCDAFFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDDA0", Offset = "0x7AECFA0", VA = "0x187AEDDA0")]
		get
		{
			return default(FGOPFGCCILH);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7AED4A0", Offset = "0x7AEC6A0", VA = "0x187AED4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public byte CHINDJOFGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDC50", Offset = "0x7AECE50", VA = "0x187AEDC50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7AED490", Offset = "0x7AEC690", VA = "0x187AED490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public OGKNJKFIJKI JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7AED4B0", Offset = "0x7AEC6B0", VA = "0x187AED4B0")]
		get
		{
			return default(OGKNJKFIJKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDDB0", Offset = "0x7AECFB0", VA = "0x187AEDDB0")]
	public OOOELIAMCHI(IList<Mesh> PMGBCOIIHFG, IList<Matrix4x4> ADNPLCNJCJL, IList<bool> GPJBONMNGGN, byte EMGNIKJCOOE, IList<byte[]> CLFIFGJOOPD, IList<long> AKKOIHNMLAO, IList<bool> ICGOJMGIEBA, IList<int> CCIBOBBFIBJ, IList<int> GIKDDOAKEBJ, IList<int> MJNCILAEFDF, Allocator FOPENOLHBOM, FGOPFGCCILH JJCMBBCIHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7AEDC90", Offset = "0x7AECE90", VA = "0x187AEDC90")]
	public OODMLKPNGAI KGHNGNCEPJA(Allocator FOPENOLHBOM)
	{
		return default(OODMLKPNGAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7AED9E0", Offset = "0x7AECBE0", VA = "0x187AED9E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CFBFBMEJALB]
public class FJDPKOLKFIM : NPKPOOJPNFH
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6BA0", Offset = "0x7AE5DA0", VA = "0x187AE6BA0")]
	public OOOELIAMCHI AJCAJLCNOMD()
	{
		return default(OOOELIAMCHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7ACA0B0", Offset = "0x7AC92B0", VA = "0x187ACA0B0")]
	public FJDPKOLKFIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct OGKNJKFIJKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeSlice<Vector3> KGEEFFHEBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<Vector3> MJGJOBDPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<Vector4> LGKDIAIONON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector2> NHILDLNBJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector2> PJPDGMKDHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector2> NLCJGNAMANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> JDEDKPOAHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Color> DLJBBPPIDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<int> DLDDPPEJCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<int> GIJOEGBHLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<BoneWeight> PJDLGAIFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<byte> DLLHDHDFLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public int BAJACHCMPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public Matrix4x4 IOMPPBABBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public long EINOOCAHEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<byte> BAHOOJKGPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public bool DMMMFHBHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public int LNPIKGNMFOB;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct MFMPGCGPJJF : IEquatable<MFMPGCGPJJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	internal readonly Material HKJLLEFIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	internal readonly AJMCIGPEEJK HNFDIFOMDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	internal readonly GDHLKBLKMHG CKGNHBBDEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly KPCHKNGGLCC AOJFILOCGCA;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA7A0", Offset = "0x7AE99A0", VA = "0x187AEA7A0")]
	public MFMPGCGPJJF(Material OHHEKLKCMJA, AJMCIGPEEJK OLINJDDNCOO, GDHLKBLKMHG FBEFFFKKANF, KPCHKNGGLCC IKCLPEICFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA580", Offset = "0x7AE9780", VA = "0x187AEA580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA380", Offset = "0x7AE9580", VA = "0x187AEA380", Slot = "4")]
	public bool Equals(MFMPGCGPJJF FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA400", Offset = "0x7AE9600", VA = "0x187AEA400", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA4E0", Offset = "0x7AE96E0", VA = "0x187AEA4E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, CMJKOOMEHEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[Header("Configuration")]
		[SerializeField]
		private EAEHACEIFMC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private KILAHEJLJLB AHCOBOBIMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private HGCMEOFLAIK DAFDDEPIIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private APPJCEDIMMA FJFIABHAFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private APPJCEDIMMA LFMFMDEOONL;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public KILAHEJLJLB PNPGPLADLHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7AE3490", Offset = "0x7AE2690", VA = "0x187AE3490", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public HGCMEOFLAIK MCBOKIAFKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7AE34E0", Offset = "0x7AE26E0", VA = "0x187AE34E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public APPJCEDIMMA CKDMLHBFNBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7AE3530", Offset = "0x7AE2730", VA = "0x187AE3530", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public APPJCEDIMMA OICHBIPODPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7AE3580", Offset = "0x7AE2780", VA = "0x187AE3580", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Transform FKCAICIFDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7AE35D0", Offset = "0x7AE27D0", VA = "0x187AE35D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public EAEHACEIFMC APFNIIPECKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9FD530", Offset = "0x9FC730", VA = "0x1809FD530", Slot = "12")]
			get
			{
				return default(EAEHACEIFMC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2860", Offset = "0x7AE1A60", VA = "0x187AE2860")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE32F0", Offset = "0x7AE24F0", VA = "0x187AE32F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7AE3200", Offset = "0x7AE2400", VA = "0x187AE3200", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7AE32F0", Offset = "0x7AE24F0", VA = "0x187AE32F0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2B60", Offset = "0x7AE1D60", VA = "0x187AE2B60", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7AE33A0", Offset = "0x7AE25A0", VA = "0x187AE33A0")]
		public void UpdatePostIKAnimControllers(float PNLPAJFPFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE3260", Offset = "0x7AE2460", VA = "0x187AE3260")]
		private void LCFOHILENMM(GameObject DBCLNEGBNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2E90", Offset = "0x7AE2090", VA = "0x187AE2E90")]
		private KILAHEJLJLB DMALBCBFPCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2520", Offset = "0x7AE1720", VA = "0x187AE2520")]
		private HGCMEOFLAIK AFDHKHJAFGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE28D0", Offset = "0x7AE1AD0", VA = "0x187AE28D0")]
		private APPJCEDIMMA BHOCMBBJGKP(KNKPNKCKMEN ELGGHNMIKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE3480", Offset = "0x7AE2680", VA = "0x187AE3480")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class ABHKOLGDLEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private MaterialPropertyBlock JHICODJBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Color? GAOOFMOMPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Color? NDMPEPOPGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public Color? OFGOAJBAICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? EFGJPMPNGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color AHJFFFEOHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color CNJFDDLOCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color GMCNMLMPFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Texture2D HIDAHLCEKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Texture2D FJGOLAPHNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private Dictionary<MFMPGCGPJJF, int> DEANHPLFMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private AJMCIGPEEJK[] ONLFGIIEFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private GDHLKBLKMHG[] KECIOGOFHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public Vector4[] FDLMAFAJLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Vector4[] HNDJBOFFAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public Vector4[] HFKBNDGMPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] OLINOKGPKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] GEHCJCFPNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] AMCGHLLBAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private List<Texture2D> FDOOKCBONHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Vector4[] NKEDDPOMFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private List<Texture2D> ACKKDHBDOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private float[] DFCPGEKJBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] JKMHIBDNKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private float[] KBAKKNJFCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public float[] IHPBBPBJMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private List<Texture2D> LAOHHGGLECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] NMAMINLLGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private List<Texture2D> NBHCOENGLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector4[] DCOFHGBENKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] AAHCNJCHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private Vector4[] KBEOIEMDIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public float[] LBGALFDIKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public Texture2DArray HDDFHLGLNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Texture2DArray OEEADBHJODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public Texture2DArray BMNDJMIMBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray KIPPMHHEIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool HAPHGIPDBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private int FJJFNGKBGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private Vector2? LOIMHEPKKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private TextureFormat OBIEBOLNNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private Vector2? PGFAGLPAAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private TextureFormat JCOEKGLJMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private Vector2? MFGJCALHLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private TextureFormat JBOBGFDNHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector2? IMGDGJNGPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private TextureFormat NBKIBMJFOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private bool DJOMNIEOFJP;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int BIPHFIPDABB;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int DALLFICJOPI;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int GHCIHICLDJP;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int PMIBJKCLGDP;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int GIFPBOBNKFC;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int PLKKHGEAOLJ;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int FJNPDNIJHJP;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int INOPPMBENFI;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int FMKIDHCAMIN;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int ILKGHFAIBGI;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int DMFOCEGFEFL;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int PLOMMPFBMID;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int PGHPIINDGHH;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int GJFBGBJNPHO;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int CIAHPEPOGLA;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int GFJMICKBOCC;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int CBJAIFCHNND;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int GDIGHMCNAIK;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int PMMJBPEPOPD;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int LMPJBKIAAKB;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7ADF460", Offset = "0x7ADE660", VA = "0x187ADF460")]
	private ABHKOLGDLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7ADF3A0", Offset = "0x7ADE5A0", VA = "0x187ADF3A0")]
	public ABHKOLGDLEL(Color PPBFBMBLICC, Color EKFGDBKJFAC, Color IPDHOPKFLFC, Color? HIKBCDHAODJ, Color? MMJMGCNNAPA, Color? GCLBMEOLPMD, Texture2D NDIOCKFGGBC, Texture2D POHMEFMGLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7ADCE80", Offset = "0x7ADC080", VA = "0x187ADCE80")]
	internal int EOGMGFFBECJ(Material MJIMAHFNOKD, AJMCIGPEEJK OLINJDDNCOO, GDHLKBLKMHG FBEFFFKKANF, KPCHKNGGLCC IKCLPEICFDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7ADCF70", Offset = "0x7ADC170", VA = "0x187ADCF70")]
	private int EOGMGFFBECJ(MFMPGCGPJJF AGBHGDFILGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7ADD470", Offset = "0x7ADC670", VA = "0x187ADD470")]
	internal int LGOPGDNDKPI(Material MJIMAHFNOKD, Color KGCAJMAKBGH, Color POBKIOMOBMH, Color NNNEJFKHENP, Color CNDJGDIHNNG, Color GLECNHGBAGO, Texture2D DOCIJGEPJCG, Vector4 JLOHELKBOOF, Texture2D PDLHNHKBDEC, Vector4 MJKNMBHIGLO, float IMIOBHACEDI, float MFCHOKMDMIL, Texture2D CNPBAFFOFJB, Vector4 DIEMJFPIONB, float FBCIKOLPABK, Texture2D EDOBFONNHNH, Color DOKEAOFICLM, Vector4 HGMFHMBECCG, AJMCIGPEEJK OLINJDDNCOO, GDHLKBLKMHG FBEFFFKKANF, KPCHKNGGLCC IKCLPEICFDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7ADD2B0", Offset = "0x7ADC4B0", VA = "0x187ADD2B0")]
	private void KDDFDNDJOCF(List<Texture2D> FDOOKCBONHB, [Out] Texture2DArray CDOOMDOHCDJ, [Out] Texture2DArray MODKDEELAPC, [Out] Texture2DArray LICEAAGEKGE, [Out] Texture2DArray DBKEABLHCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7ADD000", Offset = "0x7ADC200", VA = "0x187ADD000")]
	public void EPFAOPPAFPF(Shader NNEPNELICHC, Renderer JFBIEOOKIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7ADE190", Offset = "0x7ADD390", VA = "0x187ADE190")]
	private void MPFALFPOPEP(Shader NNEPNELICHC, Renderer JFBIEOOKIGH, int FPFJIFHIDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7ADEE50", Offset = "0x7ADE050", VA = "0x187ADEE50")]
	private Color PHKDOINFIID(Color DKFEEPAJOMM, AJMCIGPEEJK OLEMJHJGMFO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7ADE040", Offset = "0x7ADD240", VA = "0x187ADE040")]
	private Color MFELIKCEJOB(Color LOPLFJFHEOO, AJMCIGPEEJK OLEMJHJGMFO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7ADD150", Offset = "0x7ADC350", VA = "0x187ADD150")]
	private bool HMABEGGGJMJ(Texture2D CFDOIGJBOOP, GDHLKBLKMHG CNMOECIJMMD, [Out] Texture2D PBKBCIMIHPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7ADCD90", Offset = "0x7ADBF90", VA = "0x187ADCD90")]
	private void BLIMOMNDLJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7ADCE40", Offset = "0x7ADC040", VA = "0x187ADCE40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class FLOGFKECHKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public readonly KPCHKNGGLCC AJEFJODIEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	protected bool KDPKCKODNEH;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool OMEHKEBODCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5D0", Offset = "0xC8B7D0", VA = "0x180C8C5D0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool BKLAGICLJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xC8D1F0", Offset = "0xC8C3F0", VA = "0x180C8D1F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xC8D200", Offset = "0xC8C400", VA = "0x180C8D200")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public virtual JHAAOOMONHE.GKJIKMBGLPD EINOOCAHEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JHAAOOMONHE.GKJIKMBGLPD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool KCKNLGOPKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xF6BC00", Offset = "0xF6AE00", VA = "0x180F6BC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool MFPOCGLLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7200", Offset = "0x7AE6400", VA = "0x187AE7200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool OONKBPHMNDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7230", Offset = "0x7AE6430", VA = "0x187AE7230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool BOOCKDNJCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7210", Offset = "0x7AE6410", VA = "0x187AE7210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7240", Offset = "0x7AE6440", VA = "0x187AE7240")]
	protected FLOGFKECHKC(KPCHKNGGLCC NFODGIBNOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract IJPNCIBDOFL PLDIGGJPKFP(List<NCBKHDICHNJ> PBHHDAJBEAO, List<NCBKHDICHNJ> KLMGPLLBBKN);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract NJENFEHNOGL OLFIPHGKNMP(uint ANANLCFKCEG, AvatarSkinnedMeshBoneOrderRemapsData AGEKJKBCPAI);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EAGOGKJEJHF : PDOFEJPFGMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private AvatarSkinAssetItem EKFAMCKMKBK;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6610", Offset = "0x7AE5810", VA = "0x187AE6610")]
	public EAGOGKJEJHF(AvatarSkinAssetItem LAMEADODOHG, AvatarSkinAssetItem.FKFPPCLEPED MODHIKIGOKC, KPCHKNGGLCC IKCLPEICFDN, [Optional] FOJCDPOPCPL? AMLAMDHDEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7AE63B0", Offset = "0x7AE55B0", VA = "0x187AE63B0", Slot = "6")]
	public override IJPNCIBDOFL PLDIGGJPKFP(List<NCBKHDICHNJ> PBHHDAJBEAO, List<NCBKHDICHNJ> KLMGPLLBBKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CJOGIAEOGPM
{
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly int[] OEPPHLBLJDD;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static readonly int[] BPLPHGKOOOC;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static int[] BCNAEEGEDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7AE4B90", Offset = "0x7AE3D90", VA = "0x187AE4B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7AE4B00", Offset = "0x7AE3D00", VA = "0x187AE4B00")]
	public static int[] BAHMILCIDDP(bool MDHAHIJDOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE4C00", Offset = "0x7AE3E00", VA = "0x187AE4C00")]
	public static int MAAMIIGHAFP(MIPMLGOBAHP LKNFNMAJNOO, bool MDHAHIJDOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7AE4B80", Offset = "0x7AE3D80", VA = "0x187AE4B80")]
	private static int DKDGAOMACHA(MIPMLGOBAHP LKNFNMAJNOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7AE4BE0", Offset = "0x7AE3DE0", VA = "0x187AE4BE0")]
	private static int JMHGEOEJONI(MIPMLGOBAHP LKNFNMAJNOO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KAGKLIPOOIE
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class OEHKAJHCEBJ : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private EAALCCOKLJL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public OEHKAJHCEBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x127A040", Offset = "0x1279240", VA = "0x18127A040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA7E0", Offset = "0x7AE99E0", VA = "0x187AEA7E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	public static void KFLBONOPCLG(string MKHHKDJKLDN, int ANANLCFKCEG, long NAGAKEIGKEO, long GKBBAOGDGCB, long KLHBAOECCMC, long JOJCOJPMPCN, long NGAOCCMKBBC, long PDKMKALDFLN, long MHJFLFNCPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7610", Offset = "0x7AE6810", VA = "0x187AE7610")]
	public static PEFNPNHCEAP MAEHDFBIIEC(JobHandle ELJKLIDICJF, bool FDLNHHKLPJB, bool OJHCHHMGIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7700", Offset = "0x7AE6900", VA = "0x187AE7700")]
	[IteratorStateMachine(typeof(OEHKAJHCEBJ))]
	private static IEnumerator<EAALCCOKLJL> PIDNACKPFEC(JobHandle NLNGJFNOHGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DJIAONIKNID
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum AEBJKLGFGKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly int NDIPJJPOEDE;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly int OOLOCANOHGK;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly int PPBBJELAPFA;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int DHLHNGMPKNL;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int PKGCGNLJNHL;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int JCCPBJONDPL;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int GIDACMPOAFI;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int JDDHDLOOCEI;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7AE4D90", Offset = "0x7AE3F90", VA = "0x187AE4D90")]
	public static bool DKMMBANCCNJ(Material OHHEKLKCMJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7AE4E00", Offset = "0x7AE4000", VA = "0x187AE4E00")]
	public static bool HICGGJOKKME(Material OHHEKLKCMJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PDOFEJPFGMD : FLOGFKECHKC
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class CECJOOGBCNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public PAACHOBIIFN<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public PDOFEJPFGMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CECJOOGBCNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7AE45F0", Offset = "0x7AE37F0", VA = "0x187AE45F0")]
		internal void ECLFBCMOMJM(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7AE49C0", Offset = "0x7AE3BC0", VA = "0x187AE49C0")]
		internal void KDMDHJEAKNC(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	protected AvatarSkinAssetItem KJBAOHLGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	protected Material[] GBNINPIOOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private readonly AvatarSkinAssetItem.FKFPPCLEPED IPBHNCIEKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private readonly AssetReference KHMEOEECMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private readonly FOJCDPOPCPL? EMBGIECECEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private SkinnedMeshRenderer[] MDIFCNCFJIP;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public override JHAAOOMONHE.GKJIKMBGLPD EINOOCAHEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JHAAOOMONHE.GKJIKMBGLPD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F2520", Offset = "0x9F1720", VA = "0x1809F2520", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFAF0", Offset = "0x7AEECF0", VA = "0x187AEFAF0")]
	public PDOFEJPFGMD(AvatarSkinAssetItem.FKFPPCLEPED MODHIKIGOKC, AssetReference AOKDNGPBFNJ, Material NMGMBFEIFMJ, KPCHKNGGLCC IKCLPEICFDN, JHAAOOMONHE.GKJIKMBGLPD AMLLFNOONJO = (JHAAOOMONHE.GKJIKMBGLPD)0L, [Optional] FOJCDPOPCPL? AMLAMDHDEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFC20", Offset = "0x7AEEE20", VA = "0x187AEFC20")]
	public PDOFEJPFGMD(AvatarSkinAssetItem.FKFPPCLEPED MODHIKIGOKC, AssetReference AOKDNGPBFNJ, Material NMGMBFEIFMJ, JHAAOOMONHE.GKJIKMBGLPD AMLLFNOONJO = (JHAAOOMONHE.GKJIKMBGLPD)0L, [Optional] FOJCDPOPCPL? AMLAMDHDEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF8B0", Offset = "0x7AEEAB0", VA = "0x187AEF8B0", Slot = "6")]
	public override IJPNCIBDOFL PLDIGGJPKFP(List<NCBKHDICHNJ> PBHHDAJBEAO, List<NCBKHDICHNJ> KLMGPLLBBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF6A0", Offset = "0x7AEE8A0", VA = "0x187AEF6A0", Slot = "7")]
	public override NJENFEHNOGL OLFIPHGKNMP(uint ANANLCFKCEG, AvatarSkinnedMeshBoneOrderRemapsData AGEKJKBCPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFA80", Offset = "0x7AEEC80", VA = "0x187AEFA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF650", Offset = "0x7AEE850", VA = "0x187AEF650")]
	protected void NEKKAEAHHNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class OKCBDCNOHBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private List<int> NMJHDOFKFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private List<LDEBGBNLCEH> IHAABJPEIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private HashSet<Transform> LLAACDHKMIP;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7AEAD90", Offset = "0x7AE9F90", VA = "0x187AEAD90")]
	public static OKCBDCNOHBB JGICJDNHDFE(Transform PNIEJJKFCEK, Dictionary<Transform, OutfitType?> FOICGAFFIAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7AEB440", Offset = "0x7AEA640", VA = "0x187AEB440")]
	private void NHCCJODDELL(Transform PNIEJJKFCEK, KPCHKNGGLCC IKCLPEICFDN, Dictionary<Transform, OutfitType?> FOICGAFFIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7AEAF20", Offset = "0x7AEA120", VA = "0x187AEAF20")]
	private void JKDINJLAFMK(Transform DLAHHMHPADL, KPCHKNGGLCC IKCLPEICFDN, bool AKFFEOKMMDA, OutfitType? IKKJICDKAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7AEB050", Offset = "0x7AEA250", VA = "0x187AEB050")]
	public OKCKLKFHOLF LLJNPAFECOP(HashSet<string> FMCMHOAEOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7AEB700", Offset = "0x7AEA900", VA = "0x187AEB700")]
	public OKCBDCNOHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class OKCKLKFHOLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<LDEBGBNLCEH> IHAABJPEIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<Matrix4x4> JICEFKMGGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private Transform[] LHOAHKDMAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private Matrix4x4[] DJOLPCDGMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private Dictionary<PLGOPKCNFPO, int> NBLIOPEJOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private List<MBKGLAKKOOC> LDKKBIJMCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private bool AFEHNKGBNOA;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7AEC090", Offset = "0x7AEB290", VA = "0x187AEC090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform[] IHHGPIBKFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7AEC280", Offset = "0x7AEB480", VA = "0x187AEC280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Matrix4x4[] AOANFKKDPKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7AEC3E0", Offset = "0x7AEB5E0", VA = "0x187AEC3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBA60", Offset = "0x7AEAC60", VA = "0x187AEBA60")]
	public void JKDINJLAFMK(Transform DLAHHMHPADL, KPCHKNGGLCC IKCLPEICFDN, OutfitType? IKKJICDKAJF, bool OLODJHAMIAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBC50", Offset = "0x7AEAE50", VA = "0x187AEBC50")]
	private void JKDINJLAFMK(Transform DLAHHMHPADL, KPCHKNGGLCC IKCLPEICFDN, OutfitType? IKKJICDKAJF, bool OLODJHAMIAD, Matrix4x4 MADKJBGIIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC0D0", Offset = "0x7AEB2D0", VA = "0x187AEC0D0")]
	public int MMPDJNNBGPO(PLGOPKCNFPO AGBHGDFILGO, bool OEFMAFKMHID, [Optional] OutfitType? IKKJICDKAJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBF90", Offset = "0x7AEB190", VA = "0x187AEBF90")]
	public int KJDLAKOMDAN(KPCHKNGGLCC IKCLPEICFDN, [Optional] OutfitType? IKKJICDKAJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7AEB830", Offset = "0x7AEAA30", VA = "0x187AEB830")]
	public void HFJECHFIJAN(PLGOPKCNFPO AGBHGDFILGO, Matrix4x4 FIFMGFADECE, bool OEFMAFKMHID = false, [Optional] OutfitType? IKKJICDKAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7AEB920", Offset = "0x7AEAB20", VA = "0x187AEB920")]
	public Matrix4x4 IKLGOKGGIAD(PLGOPKCNFPO AGBHGDFILGO, bool OEFMAFKMHID, [Optional] OutfitType? IKKJICDKAJF)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x133D6C0", Offset = "0x133C8C0", VA = "0x18133D6C0")]
	public void LMCLHBGKEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC450", Offset = "0x7AEB650", VA = "0x187AEC450")]
	public OKCKLKFHOLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct PLGOPKCNFPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public readonly string KEEJNAKPOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public readonly KPCHKNGGLCC AOJFILOCGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public readonly OutfitType? PLMGNMPFCLH;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFFC0", Offset = "0x7AEF1C0", VA = "0x187AEFFC0")]
	public PLGOPKCNFPO(string BNEGAFBFOGI, KPCHKNGGLCC IKCLPEICFDN, [Optional] OutfitType? IKKJICDKAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFF10", Offset = "0x7AEF110", VA = "0x187AEFF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFD40", Offset = "0x7AEEF40", VA = "0x187AEFD40")]
	public bool EKHAGIJCEHN(PLGOPKCNFPO FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFE00", Offset = "0x7AEF000", VA = "0x187AEFE00", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFEA0", Offset = "0x7AEF0A0", VA = "0x187AEFEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct MBKGLAKKOOC : IEquatable<MBKGLAKKOOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly KPCHKNGGLCC AOJFILOCGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly OutfitType? OCANONIPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly int ALEFKLNKPOO;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7F10", Offset = "0x7AE7110", VA = "0x187AE7F10")]
	public MBKGLAKKOOC(KPCHKNGGLCC IKCLPEICFDN, int PBNKDPJIGIA, [Optional] OutfitType? LILAOFECFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7E40", Offset = "0x7AE7040", VA = "0x187AE7E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DF70", Offset = "0x6D3D170", VA = "0x186D3DF70")]
	public bool KOAKFJHBFMI(KPCHKNGGLCC IKCLPEICFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7DC0", Offset = "0x7AE6FC0", VA = "0x187AE7DC0")]
	public bool MCEINAKCMDC(OutfitType? LILAOFECFNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7D20", Offset = "0x7AE6F20", VA = "0x187AE7D20", Slot = "4")]
	public bool Equals(MBKGLAKKOOC FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7C30", Offset = "0x7AE6E30", VA = "0x187AE7C30", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7D70", Offset = "0x7AE6F70", VA = "0x187AE7D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LDEBGBNLCEH : IEquatable<LDEBGBNLCEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly Transform JNFNGBEKCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly bool PIJGIIGGPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly KPCHKNGGLCC IFPMHFOABPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly OutfitType? PLMGNMPFCLH;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7BE0", Offset = "0x7AE6DE0", VA = "0x187AE7BE0")]
	public LDEBGBNLCEH(Transform DLAHHMHPADL, bool AKFFEOKMMDA, KPCHKNGGLCC FFONHGEMJAI, [Optional] OutfitType? NNJDGLLHKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7AE79D0", Offset = "0x7AE6BD0", VA = "0x187AE79D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7850", Offset = "0x7AE6A50", VA = "0x187AE7850", Slot = "4")]
	public bool Equals(LDEBGBNLCEH FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7770", Offset = "0x7AE6970", VA = "0x187AE7770", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7950", Offset = "0x7AE6B50", VA = "0x187AE7950", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7270", Offset = "0x7AE6470", VA = "0x187AE7270")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface BGAFHLDDLLB
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBHPLCKMKIG(Mesh KHKMPBIDLPA, Matrix4x4 GOJFCNDHMEN, byte[] BAHOOJKGPPI, bool KLIPPPBAEOH = false, JHAAOOMONHE.GKJIKMBGLPD LLJHGCIOCOH = (JHAAOOMONHE.GKJIKMBGLPD)0L, int CCIBOBBFIBJ = -1, bool GPJBONMNGGN = false);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJGMICOKLPM(Allocator FOPENOLHBOM, FGOPFGCCILH JJCMBBCIHNI, byte EMGNIKJCOOE, [Optional] IList<int> GIKDDOAKEBJ, [Optional] IList<int> OGMIFJLFKHM);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct JOIGDBKKOCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public readonly GameObject KHFMJMHIEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly AvatarItemMaterial DPDLHJEEMCH;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
	public JOIGDBKKOCF(GameObject KHFMJMHIEKD, AvatarItemMaterial DPDLHJEEMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7580", Offset = "0x7AE6780", VA = "0x187AE7580")]
	public void ODEBBHHGBLO(Material OHHEKLKCMJA, int LKJMKPMCGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class ADEOEEKFDHJ : KDNGCMNJOMB<Task<(GameObject, AvatarItemMaterial)>, JOIGDBKKOCF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct FJPLOGDMFHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE6C90", Offset = "0x7AE5E90", VA = "0x187AE6C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7190", Offset = "0x7AE6390", VA = "0x187AE7190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private PAACHOBIIFN<GameObject> DCAIDPAHAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private PAACHOBIIFN<AvatarItemMaterial> FNIKIOBPPJD;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7ADFFB0", Offset = "0x7ADF1B0", VA = "0x187ADFFB0")]
	private ADEOEEKFDHJ(Task<(GameObject, AvatarItemMaterial)> LDLKICLCOAG, PAACHOBIIFN<GameObject> AEDPFDDLPMO, PAACHOBIIFN<AvatarItemMaterial> HBCCBNGEOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7ADF9F0", Offset = "0x7ADEBF0", VA = "0x187ADF9F0")]
	public static ADEOEEKFDHJ EAIFKKLDBGP(AssetReference CAGMBLGHNJN, [Optional] AssetReference JCBCDBLJEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7ADF950", Offset = "0x7ADEB50", VA = "0x187ADF950", Slot = "11")]
	protected override JOIGDBKKOCF DIPNANLPGNN(Task<(GameObject, AvatarItemMaterial)> OBBHLIEHBKJ)
	{
		return default(JOIGDBKKOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7ADFE00", Offset = "0x7ADF000", VA = "0x187ADFE00", Slot = "12")]
	protected override void OEOOAOLMMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7ADFE80", Offset = "0x7ADF080", VA = "0x187ADFE80")]
	[AsyncStateMachine(typeof(FJPLOGDMFHO))]
	private static Task<(GameObject, AvatarItemMaterial)> OGFKCFNFJJD(Task<GameObject> LHBOKOKJHIC, Task<AvatarItemMaterial> BKBJFNAJMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EPEJDCGINNG
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class OJFEEHHNOKO : KDNGCMNJOMB<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private PAACHOBIIFN<MaterialMapAsset> NLNGJFNOHGL;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7AEACB0", Offset = "0x7AE9EB0", VA = "0x187AEACB0")]
		public OJFEEHHNOKO(PAACHOBIIFN<MaterialMapAsset> NLNGJFNOHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA830", Offset = "0x7AE9A30", VA = "0x187AEA830", Slot = "11")]
		protected override Material[] DIPNANLPGNN(Task<MaterialMapAsset> LDLKICLCOAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7AEAC50", Offset = "0x7AE9E50", VA = "0x187AEAC50", Slot = "12")]
		protected override void OEOOAOLMMGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class GFECBDBMEAP : KDNGCMNJOMB<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private List<PAACHOBIIFN<Material>> DCLFGGJMPBJ;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7460", Offset = "0x7AE6660", VA = "0x187AE7460")]
		public GFECBDBMEAP(Task<Material[]> LDLKICLCOAG, List<PAACHOBIIFN<Material>> DCLFGGJMPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE72D0", Offset = "0x7AE64D0", VA = "0x187AE72D0", Slot = "11")]
		protected override Material[] DIPNANLPGNN(Task<Material[]> OBBHLIEHBKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7320", Offset = "0x7AE6520", VA = "0x187AE7320", Slot = "12")]
		protected override void OEOOAOLMMGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6710", Offset = "0x7AE5910", VA = "0x187AE6710")]
	public static PAACHOBIIFN<Material[]> ODAFEAAOBED(AssetReference[] EDAOIIAEAGF)
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
		public enum NPJPLEDNJMO
		{
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum CGKNLLLIDFD
		{
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum FMAOLDADBBH : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct PMBDLNPMALH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public readonly Material HKJLLEFIMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public readonly NPJPLEDNJMO HNFDIFOMDEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public readonly CGKNLLLIDFD CKGNHBBDEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public readonly KPCHKNGGLCC AOJFILOCGCA;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7AEA7A0", Offset = "0x7AE99A0", VA = "0x187AEA7A0")]
			public PMBDLNPMALH(Material OHHEKLKCMJA, NPJPLEDNJMO OLINJDDNCOO, CGKNLLLIDFD FBEFFFKKANF, KPCHKNGGLCC IKCLPEICFDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x7B04810", Offset = "0x7B03A10", VA = "0x187B04810", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x7AEA380", Offset = "0x7AE9580", VA = "0x187AEA380")]
			public bool EKHAGIJCEHN(PMBDLNPMALH FNJGMJGALLH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x7B04690", Offset = "0x7B03890", VA = "0x187B04690", Slot = "0")]
			public override bool Equals(object DBCLNEGBNLN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x7B04770", Offset = "0x7B03970", VA = "0x187B04770", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected class HKJGEHAAOFH : IComparable<HKJGEHAAOFH>, IEquatable<HKJGEHAAOFH>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public int BONBOPDJIOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public PlayerAvatarDisplayBase JOOGKGIFDEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public IList<AODJELJAHEP> CBELOAMJOPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public AvatarItemBodyType ECLALABJBLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public GFCHKNGLAOD HFIBMHINDFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public bool KAKOFGDDDFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public bool MPOBICABLIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public int[] HKPFCOLCDHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public float AFKEOEFICMO;

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x7B01870", Offset = "0x7B00A70", VA = "0x187B01870", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x7B01720", Offset = "0x7B00920", VA = "0x187B01720", Slot = "4")]
			public int CompareTo(HKJGEHAAOFH FNJGMJGALLH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x7B01750", Offset = "0x7B00950", VA = "0x187B01750", Slot = "5")]
			public bool Equals(HKJGEHAAOFH FNJGMJGALLH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public HKJGEHAAOFH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class KKKHKFMJLAN
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class BBCIFAGNGDO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Mesh FKCONFFGCHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly Material[] ANGEFLFBBKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public readonly Transform[] LEGMADFFKAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public readonly Matrix4x4[] BFJINKOJBOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				public readonly Transform LIBOAMCAFIA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				public readonly bool IOCHNONMNNA;

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
				protected BBCIFAGNGDO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x7AFFEC0", Offset = "0x7AFF0C0", VA = "0x187AFFEC0")]
				public BBCIFAGNGDO(Mesh KHKMPBIDLPA, Material[] BKFPNJPJHFM, bool POOGPGNANMN, Transform[] ELKOPKMBPKH, Transform PHAMBIFCEDM, Matrix4x4[] CKCNMAHKFMO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x7B00370", Offset = "0x7AFF570", VA = "0x187B00370")]
				private BBCIFAGNGDO(SkinnedMeshRenderer GMHNGMFBFCL, Material[] FBACJLBNNKF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x7AFFDD0", Offset = "0x7AFEFD0", VA = "0x187AFFDD0")]
				private BBCIFAGNGDO(MeshRenderer MNMHOOGCAGL, Transform PHAMBIFCEDM, Material[] FBACJLBNNKF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0x7AFFAA0", Offset = "0x7AFECA0", VA = "0x187AFFAA0")]
				public static BBCIFAGNGDO FIPNGDGICDC(Renderer JFBIEOOKIGH, Material[] FBACJLBNNKF)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly KPCHKNGGLCC AOJFILOCGCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public readonly Transform GOFHBFOICBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public readonly bool DCNJHKCFCME;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual bool OMEHKEBODCE
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual bool BKLAGICLJGG
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual JHAAOOMONHE.GKJIKMBGLPD EINOOCAHEIB
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "6")]
				get
				{
					return default(JHAAOOMONHE.GKJIKMBGLPD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public bool DMMMFHBHOKA
			{
				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x7B02E70", Offset = "0x7B02070", VA = "0x187B02E70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7B02E80", Offset = "0x7B02080", VA = "0x187B02E80")]
			protected KKKHKFMJLAN(KPCHKNGGLCC IKCLPEICFDN, Transform ANALCKNKMHH, bool GJMGIBPPLAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract IJPNCIBDOFL PLDIGGJPKFP(List<NCBKHDICHNJ> PBHHDAJBEAO, List<NCBKHDICHNJ> KLMGPLLBBKN);

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract BBCIFAGNGDO OLFIPHGKNMP(int ANANLCFKCEG, PlayerHandBones BIEHEPCLDDA);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class AFBPOEJILPH : KKKHKFMJLAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly BodyPartLODs MDIFCNCFJIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Material[] GBNINPIOOGC;

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7AFF300", Offset = "0x7AFE500", VA = "0x187AFF300")]
			public AFBPOEJILPH(KPCHKNGGLCC IKCLPEICFDN, BodyPartLODs FHNCEPADEAH, Material NMGMBFEIFMJ, [Optional] Transform ANALCKNKMHH, bool GJMGIBPPLAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7AFF200", Offset = "0x7AFE400", VA = "0x187AFF200", Slot = "7")]
			public override IJPNCIBDOFL PLDIGGJPKFP(List<NCBKHDICHNJ> PBHHDAJBEAO, List<NCBKHDICHNJ> KLMGPLLBBKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x7AFF040", Offset = "0x7AFE240", VA = "0x187AFF040", Slot = "8")]
			public override BBCIFAGNGDO OLFIPHGKNMP(int ANANLCFKCEG, PlayerHandBones BIEHEPCLDDA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x7AFF290", Offset = "0x7AFE490", VA = "0x187AFF290", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class GJEOEBNGKNI : KKKHKFMJLAN
		{
			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public override bool OMEHKEBODCE
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public override bool BKLAGICLJGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x7B00B90", Offset = "0x7AFFD90", VA = "0x187B00B90", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public IDJDHKAFLFD HKEADDOFEJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7B00CE0", Offset = "0x7AFFEE0", VA = "0x187B00CE0")]
			public GJEOEBNGKNI(KPCHKNGGLCC IKCLPEICFDN, Transform ANALCKNKMHH, IDJDHKAFLFD KCMFKDFNBLH, bool GJMGIBPPLAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7B00BE0", Offset = "0x7AFFDE0", VA = "0x187B00BE0", Slot = "7")]
			public override IJPNCIBDOFL PLDIGGJPKFP(List<NCBKHDICHNJ> PBHHDAJBEAO, List<NCBKHDICHNJ> KLMGPLLBBKN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "8")]
			public override BBCIFAGNGDO OLFIPHGKNMP(int ANANLCFKCEG, PlayerHandBones BIEHEPCLDDA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7B00C70", Offset = "0x7AFFE70", VA = "0x187B00C70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class NMHLOBBCEGI
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum KAAGOCPCFPH
			{
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x400037B")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x400037C")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400037F")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public static readonly int FMFJCAHPMGF;

			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public static readonly int HFOAIFPJNAG;

			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public static readonly int KMNLPPPMKGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly KNKPNKCKMEN ELGGHNMIKBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly EMLFMIJEOGB HCBFMNJPOJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Animator IBENMAADEEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Transform OEGGICFEIFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly Vector3 AJFJLFDFLCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Transform KALEMCFCPIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected readonly Vector3 KCFLIKAGMKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected bool EDEMKDPPKGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected APPJCEDIMMA CEIIFIELCBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected bool MFMJHAPLNDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected float KNCAJBLMAGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected HHBOOOHHBCL<JDHBOJLMCKA> FJNBLLHFIGB;

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public APPJCEDIMMA ONGCAJOCMOB
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool DFBGOGPONLA
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0xC129A0", Offset = "0xC11BA0", VA = "0x180C129A0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x7B03580", Offset = "0x7B02780", VA = "0x187B03580")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool ABBBJNFDPIA
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0x9F6D80", Offset = "0x9F5F80", VA = "0x1809F6D80")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x7B032E0", Offset = "0x7B024E0", VA = "0x187B032E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public float JOJMNNNMHGL
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0xC8D230", Offset = "0xC8C430", VA = "0x180C8D230")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0x7B03710", Offset = "0x7B02910", VA = "0x187B03710")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public JDHBOJLMCKA GNPJFBLJNNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0x7B03A80", Offset = "0x7B02C80", VA = "0x187B03A80")]
				get
				{
					return default(JDHBOJLMCKA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7B03970", Offset = "0x7B02B70", VA = "0x187B03970")]
			public bool LPCNNBINHDA(JDHBOJLMCKA BPMKPBKLFHP, object PPOILDCNBFL, KAAGOCPCFPH NNIDLNKAMEF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x7B031E0", Offset = "0x7B023E0", VA = "0x187B031E0")]
			public bool DNEOFIBKAPB(object PPOILDCNBFL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x7B04400", Offset = "0x7B03600", VA = "0x187B04400")]
			protected NMHLOBBCEGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x7B03E10", Offset = "0x7B03010", VA = "0x187B03E10")]
			public NMHLOBBCEGI(KNKPNKCKMEN ELGGHNMIKBA, APPJCEDIMMA OKBCEGDCEIK, Animator IBENMAADEEO, Transform OEGGICFEIFG, Transform KALEMCFCPIK, Vector3 AJFJLFDFLCB, Vector3 KCFLIKAGMKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7B033B0", Offset = "0x7B025B0", VA = "0x187B033B0")]
			private void HFMFHNEHMDD(ushort MMJHGNOMKJO, ushort OFOOGHALCDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x7B03C80", Offset = "0x7B02E80", VA = "0x187B03C80")]
			protected void OEILOMOJDPO(ushort MMJHGNOMKJO, ushort OFOOGHALCDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7B03650", Offset = "0x7B02850", VA = "0x187B03650")]
			protected void KJBCGDHHCLE(ushort MMJHGNOMKJO, ushort OFOOGHALCDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7B03460", Offset = "0x7B02660", VA = "0x187B03460")]
			protected void IGFGPMABCBC(ushort MMJHGNOMKJO, ushort OFOOGHALCDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x7B03B70", Offset = "0x7B02D70", VA = "0x187B03B70")]
			protected void NIJPPENDHGE(ushort MMJHGNOMKJO, ushort OFOOGHALCDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7B03AC0", Offset = "0x7B02CC0", VA = "0x187B03AC0")]
			protected void NCMBAJIAKBO(ushort MMJHGNOMKJO, ushort OFOOGHALCDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7B03190", Offset = "0x7B02390", VA = "0x187B03190")]
			protected void AKGAMFKMOMI(ushort MMJHGNOMKJO, ushort OFOOGHALCDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7B03B20", Offset = "0x7B02D20", VA = "0x187B03B20")]
			protected void NFCDPFPGOBH(ushort MMJHGNOMKJO, ushort OFOOGHALCDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7B03850", Offset = "0x7B02A50", VA = "0x187B03850")]
			protected void LEMEPBBGCNE(ushort MMJHGNOMKJO, ushort OFOOGHALCDC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class PPNPBEIDPEF : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public const int EHOEILDFKNB = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected MaterialPropertyBlock JHICODJBHKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color? GAOOFMOMPKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color? OFGOAJBAICA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Color? EFGJPMPNGJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Color AHJFFFEOHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Color CNJFDDLOCFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Color GMCNMLMPFKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2D HIDAHLCEKFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2D FJGOLAPHNJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Dictionary<PMBDLNPMALH, int> DEANHPLFMOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected NPJPLEDNJMO[] ONLFGIIEFJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] FDLMAFAJLPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] HNDJBOFFAAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Vector4[] HFKBNDGMPHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector4[] OLINOKGPKDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Vector4[] GEHCJCFPNGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector4[] AMCGHLLBAFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> FDOOKCBONHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] NKEDDPOMFNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected List<Texture2D> ACKKDHBDOEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float[] DFCPGEKJBAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector4[] JKMHIBDNKNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected float[] KBAKKNJFCJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public float[] IHPBBPBJMDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected List<Texture2D> LAOHHGGLECF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected float[] NMAMINLLGGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected List<Texture2D> NBHCOENGLNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected Vector4[] DCOFHGBENKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] AAHCNJCHEAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] KBEOIEMDIBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public float[] LBGALFDIKJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Texture2DArray HDDFHLGLNPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Texture2DArray OEEADBHJODC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Texture2DArray BMNDJMIMBOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Texture2DArray KIPPMHHEIMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected bool HAPHGIPDBGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected int FJJFNGKBGGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? LOIMHEPKKPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat OBIEBOLNNNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? PGFAGLPAAMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat JCOEKGLJMME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector2? MFGJCALHLED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected TextureFormat JBOBGFDNHDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected Vector2? IMGDGJNGPPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected TextureFormat NBKIBMJFOMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool DJOMNIEOFJP;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int BIPHFIPDABB;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int DALLFICJOPI;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int GHCIHICLDJP;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int PMIBJKCLGDP;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int GIFPBOBNKFC;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int PLKKHGEAOLJ;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int FJNPDNIJHJP;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int INOPPMBENFI;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int FMKIDHCAMIN;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int ILKGHFAIBGI;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int DMFOCEGFEFL;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int PLOMMPFBMID;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int PGHPIINDGHH;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int GJFBGBJNPHO;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int CIAHPEPOGLA;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int GFJMICKBOCC;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int CBJAIFCHNND;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int GDIGHMCNAIK;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int PMMJBPEPOPD;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int LMPJBKIAAKB;

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7B06FA0", Offset = "0x7B061A0", VA = "0x187B06FA0")]
			protected PPNPBEIDPEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7B06F10", Offset = "0x7B06110", VA = "0x187B06F10")]
			public PPNPBEIDPEF(Color PPBFBMBLICC, Color EKFGDBKJFAC, Color IPDHOPKFLFC, Color? HIKBCDHAODJ, Color? MMJMGCNNAPA, Color? GCLBMEOLPMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7B04B00", Offset = "0x7B03D00", VA = "0x187B04B00")]
			public int EOGMGFFBECJ(Material MJIMAHFNOKD, NPJPLEDNJMO OLINJDDNCOO, CGKNLLLIDFD FBEFFFKKANF, KPCHKNGGLCC IKCLPEICFDN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7B04BF0", Offset = "0x7B03DF0", VA = "0x187B04BF0")]
			public int EOGMGFFBECJ(PMBDLNPMALH AGBHGDFILGO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7B051F0", Offset = "0x7B043F0", VA = "0x187B051F0")]
			public int LGOPGDNDKPI(Material MJIMAHFNOKD, Color KGCAJMAKBGH, Color POBKIOMOBMH, Color NNNEJFKHENP, Color CNDJGDIHNNG, Color GLECNHGBAGO, Texture2D DOCIJGEPJCG, Vector4 JLOHELKBOOF, Texture2D PDLHNHKBDEC, Vector4 MJKNMBHIGLO, float IMIOBHACEDI, float MFCHOKMDMIL, Texture2D CNPBAFFOFJB, Vector4 DIEMJFPIONB, float FBCIKOLPABK, Texture2D EDOBFONNHNH, float IDGNKIHDBOM, Color DOKEAOFICLM, Vector4 HGMFHMBECCG, NPJPLEDNJMO OLINJDDNCOO, CGKNLLLIDFD FBEFFFKKANF, KPCHKNGGLCC IKCLPEICFDN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7B05030", Offset = "0x7B04230", VA = "0x187B05030")]
			protected void KDDFDNDJOCF([Out] Texture2DArray CDOOMDOHCDJ, [Out] Texture2DArray MODKDEELAPC, [Out] Texture2DArray LICEAAGEKGE, [Out] Texture2DArray DBKEABLHCNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7B04C80", Offset = "0x7B03E80", VA = "0x187B04C80")]
			public void EPFAOPPAFPF(PlayerAvatarDisplayBase EBGMLONGJKO, Renderer JFBIEOOKIGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7B05EE0", Offset = "0x7B050E0", VA = "0x187B05EE0")]
			protected void MPFALFPOPEP(PlayerAvatarDisplayBase EBGMLONGJKO, Renderer JFBIEOOKIGH, int FPFJIFHIDKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7B069D0", Offset = "0x7B05BD0", VA = "0x187B069D0")]
			private Color PHKDOINFIID(Color DKFEEPAJOMM, NPJPLEDNJMO OLEMJHJGMFO)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7B04EE0", Offset = "0x7B040E0", VA = "0x187B04EE0")]
			private Color FJAJBBFLCIO(Color PNGJJNGJHJL, NPJPLEDNJMO OLEMJHJGMFO)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7B04A30", Offset = "0x7B03C30", VA = "0x187B04A30")]
			protected void BLIMOMNDLJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7B04AC0", Offset = "0x7B03CC0", VA = "0x187B04AC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7B0DB10", Offset = "0x7B0CD10", VA = "0x187B0DB10")]
			public void JFPKKJICNNJ(KPCHKNGGLCC IKCLPEICFDN, [Out] Transform FHPKLENNKKO, [Out] Transform[] ELKOPKMBPKH)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class HKBDIBPKKEL : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000341")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
			[DebuggerHidden]
			public HKBDIBPKKEL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x7B01240", Offset = "0x7B00440", VA = "0x187B01240", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x7B014C0", Offset = "0x7B006C0", VA = "0x187B014C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x7B01410", Offset = "0x7B00610", VA = "0x187B01410", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7B01410", Offset = "0x7B00610", VA = "0x187B01410", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class FILJNNKCJAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public FILJNNKCJAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x7B00AB0", Offset = "0x7AFFCB0", VA = "0x187B00AB0")]
			internal bool ODBALPPIMOM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class EPAMMJNCBBN : IEnumerator<EAALCCOKLJL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private EAALCCOKLJL <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			private EAALCCOKLJL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034B")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
			[DebuggerHidden]
			public EPAMMJNCBBN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7B006A0", Offset = "0x7AFF8A0", VA = "0x187B006A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7B009E0", Offset = "0x7AFFBE0", VA = "0x187B009E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct IMLJFPFOEFJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public HEAMFGBJNNJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7B02840", Offset = "0x7B01A40", VA = "0x187B02840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x7B02BE0", Offset = "0x7B01DE0", VA = "0x187B02BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class EGCPMFCNAEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public EGCPMFCNAEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x7B00670", Offset = "0x7AFF870", VA = "0x187B00670")]
			internal bool CCPABGJDEGO(AODJELJAHEP selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class MGNJFNAGBGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Func<CMEBMOPMCFP<Dictionary<string, PAACHOBIIFN<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public MGNJFNAGBGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7B02F50", Offset = "0x7B02150", VA = "0x187B02F50")]
			internal (GCMBNCCDKOG, CMEBMOPMCFP<Dictionary<string, PAACHOBIIFN<Texture2D>>>) EKCFMNCHFNN(Dictionary<string, PMPGDBHEJJO> avatarItems)
			{
				return default((GCMBNCCDKOG, CMEBMOPMCFP<Dictionary<string, PAACHOBIIFN<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x7B02EE0", Offset = "0x7B020E0", VA = "0x187B02EE0")]
			internal CMEBMOPMCFP<Dictionary<string, PAACHOBIIFN<Texture2D>>> BFIPJFBPHPM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7B03150", Offset = "0x7B02350", VA = "0x187B03150")]
			internal void LBNKCBJCFFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class ACKKMJKOMKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ACKKMJKOMKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7AFEF90", Offset = "0x7AFE190", VA = "0x187AFEF90")]
			internal bool NHAGLMHMFGA(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct KKGBEHFODKK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7B02C40", Offset = "0x7B01E40", VA = "0x187B02C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x7B02E10", Offset = "0x7B02010", VA = "0x187B02E10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected static readonly int EIMELNBNCKF;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected static readonly int KLGKEPOFGNG;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected static readonly int IPGNDPCHANK;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int GKABOLAACEH;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int MMIMELILFNM;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int LENGJOFMOHH;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int[] PEAAIPMKOGJ;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int[] FCAPDCKFBDF;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int[] BNGCGJFNBBN;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] APFMCBNMMHE;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] BAAEBDHLKME;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] ENNMDAPLAMJ;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static List<PlayerAvatarDisplayBase> KLILJBNDGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected BIDLKADDAJF INNEFAPGMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected bool AIPNIOHNACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected bool MHAGBACIBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected static readonly int[] ACNJPCOCGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected Dictionary<PMBDLNPMALH, Material> LPODMDCBKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected Dictionary<PMBDLNPMALH, Material> POILLLOEPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected Material BGEDLODPPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected KILAHEJLJLB AGDLPLFKGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private APPJCEDIMMA FJFIABHAFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private APPJCEDIMMA LFMFMDEOONL;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected Material IEADPJPPDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected FitMeshHemisphere MOFCFIOJMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected bool DFABBAFNALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected EDFKFIPIEMK OANNFBKIILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected bool CBCEJIHDHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected AnchorParamsRestrictions HDPCBLBANBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected bool FDFGEHDKIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected Transform LPBKJABLPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected bool CKFMDKGGLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool FDMGJHKFOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Vector3 BNDFIJMONAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected Quaternion FCPAFNNGILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected Vector2 HLLMKMPMFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected FitMeshHemisphere ALBJIBGCMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected Collider[] BILNGGIIMKI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Collider[] FPAJPLMEOPN;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected NMHLOBBCEGI[] GBKJLOAENJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public Dictionary<Renderer, PPNPBEIDPEF> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected Dictionary<Renderer, PPNPBEIDPEF> HFLCNJKJAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected OKCBDCNOHBB JGPDMNGBAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected GCMBNCCDKOG OFOGKIIBAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public MIPMLGOBAHP DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected int COOOABCCHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected (bool isLodForced, int forcedLOD) NMADBBFOECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected HHBOOOHHBCL<EMLFMIJEOGB> FJNBLLHFIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected bool GHMPMHJCBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected Dictionary<AODJELJAHEP, List<PMBDLNPMALH>> IDPOLGLOPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Dictionary<AODJELJAHEP, List<PMBDLNPMALH>> DPCFLLMEANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected readonly Dictionary<string, PAACHOBIIFN<Texture2D>> EJJCJMLJEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected readonly Dictionary<string, PAACHOBIIFN<Texture2D>> FPPABGBOALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected bool ABEMHLPMMFM;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected static int PALMGAHKPDK;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected static List<HKJGEHAAOFH> LKFGIPMCCBE;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected static List<HKJGEHAAOFH> GJNLKOLIDIA;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static PEFNPNHCEAP LBGAEFKKKMG;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected static Func<List<HKJGEHAAOFH>, HKJGEHAAOFH> NLJOBBEHKBJ;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected static bool LPLCMKICCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected Color? GEFGJLNDGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected bool MGPKHDICMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color GAPDBAOADHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected Color LAPIMGCDPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Color IGDKPGIHELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected AvatarHairPattern GEABBEFAEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected IDJDHKAFLFD ILNGHFENJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected Color DHGGLNIGCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Color IBKMIEEEPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected AvatarHairPattern CPNPANNCGDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected IDJDHKAFLFD CDOGDEHGBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected IDJDHKAFLFD IBDNKBODCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected Color GNBFIINFCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private AdditionalFeetData OKEACOBIICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected AODJELJAHEP? HPGDIJCIHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected Texture IBJDEGIGIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected Color OCGGBGANLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected readonly IList<AODJELJAHEP> FODFDPCAFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected readonly IList<AODJELJAHEP> IBDKLJEKANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private AvatarItemBodyType JBLEBOOHIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[SerializeField]
		protected BBICHONDDFB _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected FMAOLDADBBH KCMIOOBAPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected int[] CIDEPDDFJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected bool NAKELLPNMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected int[] GKOCECKJDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected bool LBOMIJEMJCD;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly JHAAOOMONHE.GKJIKMBGLPD EDPENFKKLDJ;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly JHAAOOMONHE.GKJIKMBGLPD INKPEFOHCGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected bool INMBDHKNPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected INLCADECIKI BPJLOOKGJMD;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string PDADFFAGIBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool CIPDOFBCBJP
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xC09F90", Offset = "0xC09190", VA = "0x180C09F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xC09740", Offset = "0xC08940", VA = "0x180C09740")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool MHLKBLPJGBN
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool IJNDDKKPJII
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD9B0", Offset = "0x7AFCBB0", VA = "0x187AFD9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool DKDDLOGJKEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool OEEKINKFAIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool FEGFAIOIAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public KILAHEJLJLB FCGCFBHJNNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xABB770", Offset = "0xABA970", VA = "0x180ABB770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x7AFE160", Offset = "0x7AFD360", VA = "0x187AFE160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public APPJCEDIMMA CKDMLHBFNBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xABC0A0", Offset = "0xABB2A0", VA = "0x180ABC0A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7AFE560", Offset = "0x7AFD760", VA = "0x187AFE560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public APPJCEDIMMA OICHBIPODPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xAC8220", Offset = "0xAC7420", VA = "0x180AC8220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7AFE830", Offset = "0x7AFDA30", VA = "0x187AFE830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected Material FMAKHLKKPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6BF0", Offset = "0x7AF5DF0", VA = "0x187AF6BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected Material FIEDOJDKGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7AF0290", Offset = "0x7AEF490", VA = "0x187AF0290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool LFELLCDAFDM
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x21D6260", Offset = "0x21D5460", VA = "0x1821D6260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public PlayerFacialAnimatorBase LPGMEBFLEEE
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xAC8430", Offset = "0xAC7630", VA = "0x180AC8430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public NMHLOBBCEGI[] PABGECGGGMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD540", Offset = "0x7AFC740", VA = "0x187AFD540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public NMHLOBBCEGI CNCENILBGMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDBA0", Offset = "0x7AFCDA0", VA = "0x187AFDBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public NMHLOBBCEGI JLIPHFLLKNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDBD0", Offset = "0x7AFCDD0", VA = "0x187AFDBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Mesh IABLDGIMCIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xAC8BE0", Offset = "0xAC7DE0", VA = "0x180AC8BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected OKCBDCNOHBB ADEOAHDHAAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7AF8CA0", Offset = "0x7AF7EA0", VA = "0x187AF8CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected GCMBNCCDKOG NINDLLGLBJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xAC8F70", Offset = "0xAC8170", VA = "0x180AC8F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x7AF05C0", Offset = "0x7AEF7C0", VA = "0x187AF05C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected bool OJHCHHMGIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool OAFCCJCCHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDB90", Offset = "0x7AFCD90", VA = "0x187AFDB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int NFEJMCKEBFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1200F40", Offset = "0x1200140", VA = "0x181200F40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7AFE770", Offset = "0x7AFD970", VA = "0x187AFE770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int OIEFAJIDMDK
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x7AFE4B0", Offset = "0x7AFD6B0", VA = "0x187AFE4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected virtual bool BLJMGOCDMKD
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected virtual int[] PCGLOPELGJL
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7AF5300", Offset = "0x7AF4500", VA = "0x187AF5300", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected bool HIHAHNHMOFA
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7AF74C0", Offset = "0x7AF66C0", VA = "0x187AF74C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected static bool PDKDOOJDGOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool JBDOKEDDLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1201E10", Offset = "0x1201010", VA = "0x181201E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7AFEA40", Offset = "0x7AFDC40", VA = "0x187AFEA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public IEnumerable<SkinnedMeshRenderer> PCLOGJEMENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD410", Offset = "0x7AFC610", VA = "0x187AFD410")]
			[IteratorStateMachine(typeof(HKBDIBPKKEL))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool DBBHGEKFDEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1201920", Offset = "0x1200B20", VA = "0x181201920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x11FFD20", Offset = "0x11FEF20", VA = "0x1811FFD20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public EAEHACEIFMC AOFKIEDHDCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD490", Offset = "0x7AFC690", VA = "0x187AFD490")]
			get
			{
				return default(EAEHACEIFMC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public static bool JPFBMKAPGBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD8E0", Offset = "0x7AFCAE0", VA = "0x187AFD8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected static PEFNPNHCEAP BGDBOCBLGLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6440", Offset = "0x7AF5640", VA = "0x187AF6440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7AF7BA0", Offset = "0x7AF6DA0", VA = "0x187AF7BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color OFGOAJBAICA
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x7AF50D0", Offset = "0x7AF42D0", VA = "0x187AF50D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Color EFGJPMPNGJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x7AF7540", Offset = "0x7AF6740", VA = "0x187AF7540")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Texture2D CILCAPJCHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x7AF0790", Offset = "0x7AEF990", VA = "0x187AF0790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color AHJFFFEOHCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7AF5950", Offset = "0x7AF4B50", VA = "0x187AF5950")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Color CNJFDDLOCFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7AF7AD0", Offset = "0x7AF6CD0", VA = "0x187AF7AD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public IDJDHKAFLFD LNDOAKLMLHI
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD500", Offset = "0x7AFC700", VA = "0x187AFD500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Texture2D HLGPOEBNCEP
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x7AF55D0", Offset = "0x7AF47D0", VA = "0x187AF55D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float FCKPOEEHKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD520", Offset = "0x7AFC720", VA = "0x187AFD520")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float AJDDGGEOPEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD990", Offset = "0x7AFCB90", VA = "0x187AFD990")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool GPPPPKODDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD4F0", Offset = "0x7AFC6F0", VA = "0x187AFD4F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDF40", Offset = "0x7AFD140", VA = "0x187AFDF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KNJPEOJLAII
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD170", Offset = "0x7AFC370", VA = "0x187AFD170")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDCA0", Offset = "0x7AFCEA0", VA = "0x187AFDCA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action CDEBDMJLALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD0D0", Offset = "0x7AFC2D0", VA = "0x187AFD0D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDC00", Offset = "0x7AFCE00", VA = "0x187AFDC00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action COEOIKLDFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD210", Offset = "0x7AFC410", VA = "0x187AFD210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDD40", Offset = "0x7AFCF40", VA = "0x187AFDD40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action AJLFFAPCFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD2B0", Offset = "0x7AFC4B0", VA = "0x187AFD2B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDDE0", Offset = "0x7AFCFE0", VA = "0x187AFDDE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<KNKPNKCKMEN, JDHBOJLMCKA> CJFOAHBAOOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD350", Offset = "0x7AFC550", VA = "0x187AFD350")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDE80", Offset = "0x7AFD080", VA = "0x187AFDE80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9A50", Offset = "0x7AF8C50", VA = "0x187AF9A50")]
		public bool SetDeformation(bool AIPNIOHNACK, bool MHAGBACIBMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1540", Offset = "0x7AF0740", VA = "0x187AF1540")]
		protected static Material BCMEIGHBNOP(Dictionary<PMBDLNPMALH, Material> CECHFCMPIOG, Material FMCJDGHFODJ, NPJPLEDNJMO OLINJDDNCOO, CGKNLLLIDFD FBEFFFKKANF, KPCHKNGGLCC IKCLPEICFDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6980", Offset = "0x7AF5B80", VA = "0x187AF6980")]
		protected void LBDBPLBBAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4C60", Offset = "0x7AF3E60", VA = "0x187AF4C60")]
		protected bool GEFPFBMIDAL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1710", Offset = "0x7AF0910", VA = "0x187AF1710")]
		protected void BJEBPBHHEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2210", Offset = "0x7AF1410", VA = "0x187AF2210", Slot = "10")]
		protected virtual void DADCMKAINOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7400", Offset = "0x7AF6600", VA = "0x187AF7400")]
		public int MeshesAtLODCount(int IELOGJMELKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6160", Offset = "0x7AF5360", VA = "0x187AF6160")]
		protected static void JJEGFFOMNCO(Dictionary<AODJELJAHEP, List<PMBDLNPMALH>> JPGJDFDDJJG, KKKHKFMJLAN BNGNPDJEBAE, Material FMCJDGHFODJ, NPJPLEDNJMO OLEMJHJGMFO, CGKNLLLIDFD CNMOECIJMMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1140", Offset = "0x7AF0340", VA = "0x187AF1140")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF24F0", Offset = "0x7AF16F0", VA = "0x187AF24F0")]
		protected void DFICONAABMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7EF0", Offset = "0x7AF70F0", VA = "0x187AF7EF0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "11")]
		protected virtual void LLOHPNJAOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7790", Offset = "0x7AF6990", VA = "0x187AF7790")]
		protected static void OEANECBGANH(List<Material> CFFJKDIBCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8CC0", Offset = "0x7AF7EC0", VA = "0x187AF8CC0")]
		protected static void PHHOIAJLOFD(Dictionary<PMBDLNPMALH, Material> CECHFCMPIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4550", Offset = "0x7AF3750", VA = "0x187AF4550")]
		protected static void EOHGOCAHNAK(Dictionary<Renderer, PPNPBEIDPEF> HCBFNNAEFLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8B80", Offset = "0x7AF7D80", VA = "0x187AF8B80")]
		protected void PGHHOANOLLD(SkinnedMeshRenderer[] CDEFDFNJKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7AF12C0", Offset = "0x7AF04C0", VA = "0x187AF12C0")]
		protected void BAFMEPNDAJI(SkinnedMeshRenderer GMHNGMFBFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1360", Offset = "0x7AF0560", VA = "0x187AF1360")]
		protected void BAFMEPNDAJI(MeshRenderer MNMHOOGCAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5120", Offset = "0x7AF4320", VA = "0x187AF5120")]
		protected void IBNCGNDJIOE(List<NCBKHDICHNJ> KFMEKLDKNOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6540", Offset = "0x7AF5740", VA = "0x187AF6540")]
		protected void KIFEFENDADM(Dictionary<string, PAACHOBIIFN<Texture2D>> JPGJDFDDJJG, bool LBIDBPOLBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7AF46B0", Offset = "0x7AF38B0", VA = "0x187AF46B0")]
		protected void EOMHFKHLNEJ(Dictionary<AODJELJAHEP, List<PMBDLNPMALH>> JPGJDFDDJJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4F10", Offset = "0x7AF4110", VA = "0x187AF4F10")]
		public float GetHandOpenClosedAxis(KNKPNKCKMEN ELGGHNMIKBA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7AFA2F0", Offset = "0x7AF94F0", VA = "0x187AFA2F0")]
		public void SetHandOpenClosedAxis(KNKPNKCKMEN ELGGHNMIKBA, float ICDKGDPIIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4F50", Offset = "0x7AF4150", VA = "0x187AF4F50")]
		public JDHBOJLMCKA GetHandVisualState(KNKPNKCKMEN ELGGHNMIKBA)
		{
			return default(JDHBOJLMCKA);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0880", Offset = "0x7AEFA80", VA = "0x187AF0880")]
		public bool AddHandVisualStateToken(KNKPNKCKMEN ELGGHNMIKBA, JDHBOJLMCKA EPOOKABDPOC, object PPOILDCNBFL, NMHLOBBCEGI.KAAGOCPCFPH NNIDLNKAMEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBAF0", Offset = "0x7AFACF0", VA = "0x187AFBAF0")]
		public void SetWatchHand(KNKPNKCKMEN ELGGHNMIKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBBB0", Offset = "0x7AFADB0", VA = "0x187AFBBB0")]
		public void SetWatchHands(bool BEPKMAFOGGC, bool GCCFBBPFPIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9110", Offset = "0x7AF8310", VA = "0x187AF9110")]
		public bool RemoveHandVisualStateToken(KNKPNKCKMEN ELGGHNMIKBA, object PPOILDCNBFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4FD0", Offset = "0x7AF41D0", VA = "0x187AF4FD0")]
		public bool GetThumbsUpActive(KNKPNKCKMEN ELGGHNMIKBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB590", Offset = "0x7AFA790", VA = "0x187AFB590")]
		public void SetThumbsUpActive(KNKPNKCKMEN ELGGHNMIKBA, bool LNGDMPHIMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4F90", Offset = "0x7AF4190", VA = "0x187AF4F90")]
		public bool GetHandshakeActive(KNKPNKCKMEN ELGGHNMIKBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7AFA340", Offset = "0x7AF9540", VA = "0x187AFA340")]
		public void SetHandshakeActive(KNKPNKCKMEN ELGGHNMIKBA, bool GDNMJDHEAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4B80", Offset = "0x7AF3D80", VA = "0x187AF4B80")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7AF20F0", Offset = "0x7AF12F0", VA = "0x187AF20F0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7AF72D0", Offset = "0x7AF64D0", VA = "0x187AF72D0")]
		private static void MKMDDMPIACF(Scene IIPJDMFDDBF, LoadSceneMode BGIKBFMPDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0090", Offset = "0x7AEF290", VA = "0x187AF0090")]
		protected static void ADMHJOCOENA(PlayerAvatarDisplayBase FOLIHPDENOP, List<HKJGEHAAOFH> FDJBCCEAHNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8E20", Offset = "0x7AF8020", VA = "0x187AF8E20")]
		public IJPNCIBDOFL Rebuild(bool FAHGOBHIEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7E90", Offset = "0x7AF7090", VA = "0x187AF7E90")]
		protected IJPNCIBDOFL OPHJNBMEOBL(bool FAHGOBHIEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7D60", Offset = "0x7AF6F60", VA = "0x187AF7D60", Slot = "12")]
		protected virtual IJPNCIBDOFL OPHJNBMEOBL(IList<AODJELJAHEP> OPIPGJCJJFA, AvatarItemBodyType HBLGPPNPKAP, bool MKKGENLJJFA, bool HHOLLHLLLJP, int[] FKKMLDHHANK, bool FAHGOBHIEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5A80", Offset = "0x7AF4C80", VA = "0x187AF5A80")]
		protected static IJPNCIBDOFL JABIHLODIDK(HKJGEHAAOFH KCBBEOHGILH, List<HKJGEHAAOFH> FDJBCCEAHNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1430", Offset = "0x7AF0630", VA = "0x187AF1430")]
		[IteratorStateMachine(typeof(EPAMMJNCBBN))]
		protected static IEnumerator<EAALCCOKLJL> BAMFBIPNMGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0000", Offset = "0x7AEF200", VA = "0x187AF0000")]
		protected static HKJGEHAAOFH AAKCGOBCBNJ(List<HKJGEHAAOFH> FDJBCCEAHNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9B60", Offset = "0x7AF8D60", VA = "0x187AF9B60")]
		[AsyncStateMachine(typeof(IMLJFPFOEFJ))]
		public Task SetFaceCustomizationSettings(HEAMFGBJNNJ LNAHHHMDCMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBD10", Offset = "0x7AFAF10", VA = "0x187AFBD10")]
		public bool UpdateFaceAndBodyCustomizationSettings(HEAMFGBJNNJ LNAHHHMDCMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7AF59A0", Offset = "0x7AF4BA0", VA = "0x187AF59A0")]
		public void InitializeFaceFeatures(AvatarConfiguration LPIFIOMBHJE, EAEHACEIFMC IMIGMMADGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB2E0", Offset = "0x7AFA4E0", VA = "0x187AFB2E0")]
		public void SetTeamColors(Color? GCLBMEOLPMD, bool JCAPMBFMOII, Color HEHIEEACCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x12AC7B0", Offset = "0x12AB9B0", VA = "0x1812AC7B0")]
		private static void BHPELCJDICK(Material OHHEKLKCMJA, Color MLCDCHNOCFI, params int[] PKACAFJPHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x12AC9C0", Offset = "0x12ABBC0", VA = "0x1812AC9C0")]
		private static void DBJMFFJGAHD(Material OHHEKLKCMJA, Texture MLCDCHNOCFI, params int[] PKACAFJPHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7AF56D0", Offset = "0x7AF48D0", VA = "0x187AF56D0")]
		protected void IOHCLOOEDFD(Material JMKFNDKNLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7590", Offset = "0x7AF6790", VA = "0x187AF7590")]
		protected void NKOJMKHBEOA(Material JMKFNDKNLIC, Color PLHNAIINEDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7AF70B0", Offset = "0x7AF62B0", VA = "0x187AF70B0")]
		protected void MJALEIANAJP(Material JMKFNDKNLIC, Color PLHNAIINEDP, Color KEJGIENBHLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4340", Offset = "0x7AF3540", VA = "0x187AF4340")]
		protected void ENJMJOAMAPE(Material JMKFNDKNLIC, Texture2D BEFHHDCIDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF29E0", Offset = "0x7AF1BE0", VA = "0x187AF29E0")]
		protected void DIIAIGHNAKC(Material JMKFNDKNLIC, Texture MBODEKMKKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6820", Offset = "0x7AF5A20", VA = "0x187AF6820")]
		protected void KOLOAPGKEPL(Action<PPNPBEIDPEF> EBHHBJPKDIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5390", Offset = "0x7AF4590", VA = "0x187AF5390")]
		protected void ICCNAOEOPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2820", Offset = "0x7AF1A20", VA = "0x187AF2820")]
		protected void DHIGIMGKEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8780", Offset = "0x7AF7980", VA = "0x187AF8780")]
		protected void PCOLKELGMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0BD0", Offset = "0x7AEFDD0", VA = "0x187AF0BD0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7AF94D0", Offset = "0x7AF86D0", VA = "0x187AF94D0")]
		public void SetBeardPrimaryColor([Optional] Color? CNLIJBJIOFB, bool BFFFFGELDNE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7AF96F0", Offset = "0x7AF88F0", VA = "0x187AF96F0")]
		public void SetBeardSecondaryColor([Optional] Color? CNLIJBJIOFB, bool BFFFFGELDNE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9390", Offset = "0x7AF8590", VA = "0x187AF9390")]
		public void SetBeardPattern([Optional] AvatarHairPattern PJMBCGJNAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6E30", Offset = "0x7AF6030", VA = "0x187AF6E30")]
		private void LOOCCPBPHPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1490", Offset = "0x7AF0690", VA = "0x187AF1490")]
		private bool BCFPLHLEJKG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9ED0", Offset = "0x7AF90D0", VA = "0x187AF9ED0")]
		public void SetHairPrimaryColor([Optional] Color? AOFEBAENHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7AFA0E0", Offset = "0x7AF92E0", VA = "0x187AFA0E0")]
		public void SetHairSecondaryColor([Optional] Color? AOFEBAENHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9DA0", Offset = "0x7AF8FA0", VA = "0x187AF9DA0")]
		public void SetHairPattern([Optional] AvatarHairPattern PJMBCGJNAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8FB0", Offset = "0x7AF81B0", VA = "0x187AF8FB0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7AF86C0", Offset = "0x7AF78C0", VA = "0x187AF86C0")]
		private bool PCCIAAIGJFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB120", Offset = "0x7AFA320", VA = "0x187AFB120")]
		public void SetSkinColor(Color PPBFBMBLICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB5E0", Offset = "0x7AFA7E0", VA = "0x187AFB5E0")]
		public void SetUgcItemVisualOverrides(AODJELJAHEP IMPCPINIMCF, EAEHACEIFMC IMIGMMADGOL, Texture AFPOEOFPDNF, Color JLHFCJIGKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7AF21C0", Offset = "0x7AF13C0", VA = "0x187AF21C0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9C60", Offset = "0x7AF8E60", VA = "0x187AF9C60")]
		public bool SetFaceShape(AvatarFaceShape JGFEANPMJLJ, bool KMGMJINOHKD = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7AF3E90", Offset = "0x7AF3090", VA = "0x187AF3E90")]
		private void EDCAPENFCGI(ONHCMAHDMCI HCHJEDBHCCL, float MLCDCHNOCFI, bool HDJECOPNGBB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7AF78D0", Offset = "0x7AF6AD0", VA = "0x187AF78D0")]
		private void OKMIKIEAIBH(DNKNGKICPLF LLEPJKKELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6040", Offset = "0x7AF5240", VA = "0x187AF6040")]
		private void JCGPLDNNGLM(LPBIBCFKFIO HGHKNANFPLC, float MLCDCHNOCFI, bool KKKHACBMFCE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8AE0", Offset = "0x7AF7CE0", VA = "0x187AF8AE0")]
		private void PGFBGHOIBHP(MGJJLPJHDIJ CAIBEMJLLEB, float MLCDCHNOCFI, bool FBFICBOKLID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7AF66C0", Offset = "0x7AF58C0", VA = "0x187AF66C0")]
		private void KNBNKMJIGMA(EFPLFOFHFDF AGHCAKKHCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0660", Offset = "0x7AEF860", VA = "0x187AF0660")]
		private void ANIGKKAMGCI(KELJNCEBLGL GPIOBHILFME, float GIDLFOJKMPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9910", Offset = "0x7AF8B10", VA = "0x187AF9910")]
		public bool SetBodyShape(AvatarBodyShape LANMJKKBJBO, bool KMGMJINOHKD = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7AFAFB0", Offset = "0x7AFA1B0", VA = "0x187AFAFB0")]
		public bool SetNoseType(BBICHONDDFB OOAIFJBLOGJ, bool KMGMJINOHKD = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC3F0", Offset = "0x7AFB5F0", VA = "0x187AFC3F0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7AFAF90", Offset = "0x7AFA190", VA = "0x187AFAF90")]
		public bool SetHideEars(bool GELDMIOLOME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7AFAF80", Offset = "0x7AFA180", VA = "0x187AFAF80")]
		public bool SetHelmetHair(BIDLKADDAJF OCJDFKBBMGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7AFA390", Offset = "0x7AF9590", VA = "0x187AFA390")]
		public void SetHatAnchorParameters(EDFKFIPIEMK OCLIKMKEHEO, bool NECPENAMLFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBC80", Offset = "0x7AFAE80", VA = "0x187AFBC80")]
		public void SetupDisplayLODs(FMAOLDADBBH JNKBJADLAKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0380", Offset = "0x7AEF580", VA = "0x187AF0380")]
		protected int[] AJDPDILPHBH(FMAOLDADBBH JNKBJADLAKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB090", Offset = "0x7AFA290", VA = "0x187AFB090")]
		public void SetOutfitSelections(IList<AODJELJAHEP> OPIPGJCJJFA, AvatarItemBodyType HBLGPPNPKAP, bool HHOLLHLLLJP, bool FAHGOBHIEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB0D0", Offset = "0x7AFA2D0", VA = "0x187AFB0D0")]
		public void SetOutfitSelections(IList<AODJELJAHEP> OPIPGJCJJFA, AvatarItemBodyType HBLGPPNPKAP, bool MKKGENLJJFA, bool HHOLLHLLLJP, bool FAHGOBHIEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB050", Offset = "0x7AFA250", VA = "0x187AFB050")]
		public IJPNCIBDOFL SetOutfitSelections(IList<AODJELJAHEP> OPIPGJCJJFA, AvatarItemBodyType HBLGPPNPKAP, FMAOLDADBBH JNKBJADLAKF, bool MKKGENLJJFA, bool HHOLLHLLLJP, bool KMGMJINOHKD = false, bool FAHGOBHIEDI = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2270", Offset = "0x7AF1470", VA = "0x187AF2270", Slot = "13")]
		protected virtual IJPNCIBDOFL DBFPMOIEOOM(IList<AODJELJAHEP> OPIPGJCJJFA, AvatarItemBodyType HBLGPPNPKAP, bool MKKGENLJJFA, bool HHOLLHLLLJP, FMAOLDADBBH JNKBJADLAKF, bool KMGMJINOHKD, bool FAHGOBHIEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0190", Offset = "0x7AEF390", VA = "0x187AF0190")]
		protected int[] AHNAFAKKCJL(FMAOLDADBBH JNKBJADLAKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "14")]
		protected virtual GCMBNCCDKOG NMPCGAIOHAJ(AvatarItemBodyType EHKELMIJMDD, Dictionary<string, PMPGDBHEJJO> BPNPKIDIMLG, Dictionary<string, PAACHOBIIFN<Texture2D>> PPPHALOKCOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2B30", Offset = "0x7AF1D30", VA = "0x187AF2B30", Slot = "15")]
		protected virtual IJPNCIBDOFL DMOHGJHMENA(IList<AODJELJAHEP> OPIPGJCJJFA, AvatarItemBodyType HBLGPPNPKAP, bool MKKGENLJJFA, bool HHOLLHLLLJP, int[] HKPFCOLCDHL, GFCHKNGLAOD JFGNBOEIDAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8240", Offset = "0x7AF7440", VA = "0x187AF8240", Slot = "16")]
		protected virtual PMPGDBHEJJO PBMKBHPDFMB(IDJDHKAFLFD KCMFKDFNBLH, AvatarItemBodyType EHKELMIJMDD, KPCHKNGGLCC IKCLPEICFDN, PMPGDBHEJJO FDCGDJNLHCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "17")]
		protected virtual PMPGDBHEJJO NEJKFEFDJEG(AvatarItemBodyType EHKELMIJMDD, KPCHKNGGLCC IKCLPEICFDN, OELJPHMJLDA GBEOAHCNHMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7AF60E0", Offset = "0x7AF52E0", VA = "0x187AF60E0")]
		protected void JGAFBNLJFIF(OOCDAONIGLJ BPJCMGHLAPC, JHAAOOMONHE.GKJIKMBGLPD AEOFBOKKJMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7B20", Offset = "0x7AF6D20", VA = "0x187AF7B20")]
		protected void OMHMOHFKNBB(OOCDAONIGLJ BPJCMGHLAPC, JHAAOOMONHE.GKJIKMBGLPD AEOFBOKKJMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6950", Offset = "0xAA5B50", VA = "0x180AA6950", Slot = "18")]
		protected virtual OOCDAONIGLJ ANGABLBIGGP(OOCDAONIGLJ BPJCMGHLAPC, HelmetHairStyle CCMDHFBMMCL, bool NFEPOPIADHE, AvatarItemBodyType HBLGPPNPKAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2EA0", Offset = "0x7AF20A0", VA = "0x187AF2EA0")]
		protected OOCDAONIGLJ EBEIAPKGHJC(IList<AODJELJAHEP> OPIPGJCJJFA, AvatarItemBodyType ENOCGNAPDFM, bool HHOLLHLLLJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1FD0", Offset = "0x7AF11D0", VA = "0x187AF1FD0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6490", Offset = "0x7AF5690", VA = "0x187AF6490")]
		protected void KHJEELPLFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4010", Offset = "0x7AF3210", VA = "0x187AF4010")]
		protected void EMPLIBPIIFM(Transform HOJOHJCNJMM, IEnumerable<SkinnedMeshRenderer> NMKHFAEGEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5F80", Offset = "0x7AF5180", VA = "0x187AF5F80")]
		protected JHAAOOMONHE.GKJIKMBGLPD JCFPOCHFJHH(JHAAOOMONHE.GKJIKMBGLPD NMLHLIMGHMC, KPCHKNGGLCC NFODGIBNOOP)
		{
			return default(JHAAOOMONHE.GKJIKMBGLPD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7AF76B0", Offset = "0x7AF68B0", VA = "0x187AF76B0")]
		protected void NLHJPFLFKDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1227EC0", Offset = "0x12270C0", VA = "0x181227EC0")]
		protected void DLFCBEPILED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6FA0", Offset = "0x7AF61A0", VA = "0x187AF6FA0")]
		protected void MAGBBBEFAFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7AF76C0", Offset = "0x7AF68C0", VA = "0x187AF76C0")]
		[AsyncStateMachine(typeof(KKGBEHFODKK))]
		protected Task NMIOJKBDAAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7AF17A0", Offset = "0x7AF09A0", VA = "0x187AF17A0")]
		protected static NPJPLEDNJMO BLEBDLJPHCD(KKKHKFMJLAN EHKLPHPBADH, int FHPOHJMOJFO)
		{
			return default(NPJPLEDNJMO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4700", Offset = "0x7AF3900", VA = "0x187AF4700")]
		protected static CGKNLLLIDFD EPNJFMGOBMK(KKKHKFMJLAN EHKLPHPBADH, int FHPOHJMOJFO)
		{
			return default(CGKNLLLIDFD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4AA0", Offset = "0x7AF3CA0", VA = "0x187AF4AA0")]
		protected Transform FLEDLDJGPDN(KPCHKNGGLCC IKCLPEICFDN, OutfitType IKKJICDKAJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4850", Offset = "0x7AF3A50", VA = "0x187AF4850")]
		protected void FGHLDBDHJMH(int LKJMKPMCGAN, Material OHHEKLKCMJA, KKKHKFMJLAN EHKLPHPBADH, [Out] Texture2D FELKHENEICC, [Out] Vector4 PCLAOEBKAKB, [Out] Texture2D OFFIJIDCAOK, [Out] Texture2D KPDHDGJOJLK, [Out] Texture2D OLCIINLMAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6AA0", Offset = "0x7AF5CA0", VA = "0x187AF6AA0")]
		protected void LKGMOMLLBGD(int LKJMKPMCGAN, Material OHHEKLKCMJA, KKKHKFMJLAN EHKLPHPBADH, [Out] Color KGCAJMAKBGH, [Out] Color POBKIOMOBMH, [Out] Color NNNEJFKHENP, [Out] Color CNDJGDIHNNG, [Out] Color GLECNHGBAGO, [Out] Color DOKEAOFICLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7AF16A0", Offset = "0x7AF08A0", VA = "0x187AF16A0")]
		protected void BIEJCDAFFEM(Vector3 PHGICKGLDGM, Quaternion JPIDPNKLHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7AFA930", Offset = "0x7AF9B30", VA = "0x187AFA930")]
		public void SetHatAnchorParameters(EDFKFIPIEMK OCLIKMKEHEO, AnchorParamsRestrictions GMAIDALAHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1AF0", Offset = "0x7AF0CF0", VA = "0x187AF1AF0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere MOFCFIOJMKB, Transform LPBKJABLPJH, EDFKFIPIEMK OCLIKMKEHEO, AnchorParamsRestrictions HDPCBLBANBN, [Out] Vector3 KGEICFIBDCA, [Out] Quaternion JLBNIDPEHNC, [Out] EDFKFIPIEMK FNDDPJELGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9220", Offset = "0x7AF8420", VA = "0x187AF9220")]
		public void ResetHatAnchor(Vector2 OHEKHNJFAEF, Vector3 GPJCKDOKELO, Vector3 HNPGHEDFFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xAA5F90", Offset = "0xAA5190", VA = "0x180AA5F90")]
		public NEHJNKKHCKL GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0A00", Offset = "0x7AEFC00", VA = "0x187AF0A00")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0B40", Offset = "0x7AEFD40", VA = "0x187AF0B40")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0970", Offset = "0x7AEFB70", VA = "0x187AF0970")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBCB0", Offset = "0x7AFAEB0", VA = "0x187AFBCB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1960", Offset = "0x7AF0B60", VA = "0x187AF1960")]
		protected void CBLAGAAGAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBA70", Offset = "0x7AFAC70", VA = "0x187AFBA70")]
		public void SetWaitForUgcTextureLoads(bool KGKBFDCCNCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB980", Offset = "0x7AFAB80", VA = "0x187AFB980")]
		public void SetUgcTextureParameters(INLCADECIKI MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCAD0", Offset = "0x7AFBCD0", VA = "0x187AFCAD0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4BD0", Offset = "0x7AF3DD0", VA = "0x187AF4BD0")]
		[CompilerGenerated]
		private void GECIKKCPDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7AF50A0", Offset = "0x7AF42A0", VA = "0x187AF50A0")]
		[CompilerGenerated]
		private void HDOPNHIEMJH(PPNPBEIDPEF FCIDOIIAAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4AF0", Offset = "0x7AF3CF0", VA = "0x187AF4AF0")]
		[CompilerGenerated]
		private void FPJOBNOFAHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2E00", Offset = "0x7AF2000", VA = "0x187AF2E00")]
		[CompilerGenerated]
		private void DPDENOMKEKE(PPNPBEIDPEF FCIDOIIAAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0530", Offset = "0x7AEF730", VA = "0x187AF0530")]
		[CompilerGenerated]
		private void AJFDFIBLJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7AF81A0", Offset = "0x7AF73A0", VA = "0x187AF81A0")]
		[CompilerGenerated]
		private void PAPAHKBACHF(PPNPBEIDPEF FCIDOIIAAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4E80", Offset = "0x7AF4080", VA = "0x187AF4E80")]
		[CompilerGenerated]
		private void GPENBFJIFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4A50", Offset = "0x7AF3C50", VA = "0x187AF4A50")]
		[CompilerGenerated]
		private void FLDOLDFCNJG(PPNPBEIDPEF FCIDOIIAAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5010", Offset = "0x7AF4210", VA = "0x187AF5010")]
		[CompilerGenerated]
		private void HACJBPKCGMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7AF67D0", Offset = "0x7AF59D0", VA = "0x187AF67D0")]
		[CompilerGenerated]
		private void KNNJHKGOJKB(PPNPBEIDPEF FCIDOIIAAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1A60", Offset = "0x7AF0C60", VA = "0x187AF1A60")]
		[CompilerGenerated]
		private void CNFCOCDIOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1940", Offset = "0x7AF0B40", VA = "0x187AF1940")]
		[CompilerGenerated]
		private void BOHFNIPKPBM(PPNPBEIDPEF FCIDOIIAAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7AF3F30", Offset = "0x7AF3130", VA = "0x187AF3F30")]
		[CompilerGenerated]
		internal static bool EIIOEHIGHHB(Transform NPNLNDCKBMP, IEnumerable<SkinnedMeshRenderer> DGFDOGAPAPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2AF0", Offset = "0x7AF1CF0", VA = "0x187AF2AF0")]
		[CompilerGenerated]
		private void DKDGEKEDHOC(PPNPBEIDPEF FCIDOIIAAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1A20", Offset = "0x7AF0C20", VA = "0x187AF1A20")]
		[CompilerGenerated]
		private void CGBDFAIINEK(PPNPBEIDPEF FCIDOIIAAIA)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, PFFMGCANADG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct HJBNPFAGBLP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public HEAMFGBJNNJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x7B00F50", Offset = "0x7B00150", VA = "0x187B00F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7B011E0", Offset = "0x7B003E0", VA = "0x187B011E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct DCEPMIGJIAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public EAEHACEIFMC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x7B00430", Offset = "0x7AFF630", VA = "0x187B00430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B00610", Offset = "0x7AFF810", VA = "0x187B00610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct HDNEHGGLKLG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public EAEHACEIFMC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x7B00D50", Offset = "0x7AFFF50", VA = "0x187B00D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x7B00EF0", Offset = "0x7B000F0", VA = "0x187B00EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct HKCIAFFMJJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public HEAMFGBJNNJ avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x7B01510", Offset = "0x7B00710", VA = "0x187B01510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x7B016C0", Offset = "0x7B008C0", VA = "0x187B016C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct IFAAJIMDOKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public EAEHACEIFMC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			private TaskAwaiter<KHFGLAMFJOD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x7B01F20", Offset = "0x7B01120", VA = "0x187B01F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7B02360", Offset = "0x7B01560", VA = "0x187B02360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct IGLEJAFJLEO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public EAEHACEIFMC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7B023C0", Offset = "0x7B015C0", VA = "0x187B023C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7B027E0", Offset = "0x7B019E0", VA = "0x187B027E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected const float LONEBDNKCPO = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected const int GEHNMELMOPL = 5;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly int AAGHEAIINMJ;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly int LPCEGLDBOEL;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private static readonly int DGHEANCPFCB;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly Dictionary<PEFMMHAKAJD.PLIPHJNOPNE, int> BCJKJHGGEGC;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> LFPOBFEMFCF;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int BKBMGLNNAON;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static readonly int ICNAHGCDPMK;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static readonly int AAPEEIDGCMP;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static readonly int FACBDLHELAF;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static readonly int FHIONJLNACN;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 PEPMOGKMMJD;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 CEMODOBACCJ;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 DKOKALJGANF;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 PMIKCEJBADK;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 AAPILNBOMFP;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 NDPLKMONGCN;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 LIDHEOKOEPH;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 PPCELDJKOME;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 GKIDMAAFKBH;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 EDPLKDIANCF;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 PPOBKANLDEI;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 CPKJBKLENPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		[SerializeField]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private EAEHACEIFMC HPGDHLFADFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private FaceStyleSet FHALBDOGDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected const int BCGMCBNPCKL = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int IDDIIPOMNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int PPFKEINPHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int GNJOHKJBFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int EIJIJFKJFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Vector2 LCHGIJPKKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float FGAENHCNOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected float JEPNEEEMDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float JKJEMLCPGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Vector2 LKBCKGGPKIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float KCKPKIPNLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected float OOFMKCHHJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float HNAGPGGCKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 DECNBMGIJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float HHJIINMDKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float OCHBGKHJMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float OOAGDFKINGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 NADELLJOMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float JDDNJOPGAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float HIEOHOHNPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float LDKANMDMOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected List<SelectableFaceOption> GDLMPEJFANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected List<SelectableFaceOption> HKFPDHMFJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected List<SelectableFaceOption> DPIDFOBHEDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected List<SelectableFaceOption> ICOEJGDOIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Coroutine LHHHKHKNEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int? CCPOPKEMFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int LJCGGHGINIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int KOMNBANPNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected int NNDEBFMKBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected int GNCGMLHOGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected int HFNONHFGBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int NCJOJHGHONK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Sprite IHCJPNDPFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Sprite MFBDPFEHGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Sprite HFCPICCEMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Sprite CMCJLNBOFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected bool HOBPLKGADBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected string CCNBHDIPHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected string IHAFLPOBOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected string ALAKEENLHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected string NIOKKINEBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected AvatarConfiguration LPIFIOMBHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected KHFGLAMFJOD JOGKPIAGBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private readonly List<Material> DENEPKCMOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected JOCCOIINFCA DHEKBGKEOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected Dictionary<string, int> EBPNPPBLJFF;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public FaceStyleSet BCBMBNMACPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7B0D860", Offset = "0x7B0CA60", VA = "0x187B0D860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool HMKFKLBGGOM
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2810", Offset = "0xAD1A10", VA = "0x180AD2810", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x1241D80", Offset = "0x1240F80", VA = "0x181241D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected virtual bool AGILEFMJCCB
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected virtual bool CBKMFDOIEDF
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected int HCCOKHPAMMO
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7B08310", Offset = "0x7B07510", VA = "0x187B08310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Renderer BKCANEOMKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public bool LKFPMCHKLJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xADC2F0", Offset = "0xADB4F0", VA = "0x180ADC2F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5AE0", Offset = "0x1DC4CE0", VA = "0x181DC5AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer[] NOIOKJKDNKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool PEFOCDCCGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7B0D8B0", Offset = "0x7B0CAB0", VA = "0x187B0D8B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x7B0DA70", Offset = "0x7B0CC70", VA = "0x187B0DA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected int GOFIGJDKEFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7B095D0", Offset = "0x7B087D0", VA = "0x187B095D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		protected int KLDBEJEPAOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x7B09EC0", Offset = "0x7B090C0", VA = "0x187B09EC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public float DECJIIAKAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x7B0D890", Offset = "0x7B0CA90", VA = "0x187B0D890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x7B0DA50", Offset = "0x7B0CC50", VA = "0x187B0DA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public HGCMEOFLAIK MCBOKIAFKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xAB3730", Offset = "0xAB2930", VA = "0x180AB3730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xAF79F0", Offset = "0xAF6BF0", VA = "0x180AF79F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public KHFGLAMFJOD NALIFOHIJJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xAC8440", Offset = "0xAC7640", VA = "0x180AC8440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x7B0D9D0", Offset = "0x7B0CBD0", VA = "0x187B0D9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public NoseFaceOption NFMLIMHPLFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xAB8720", Offset = "0xAB7920", VA = "0x180AB8720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xB38F30", Offset = "0xB38130", VA = "0x180B38F30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		protected JOCCOIINFCA ALCAMLBCHGE
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x7B0A4B0", Offset = "0x7B096B0", VA = "0x187B0A4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action LBNGDJFEGHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x7B0D7B0", Offset = "0x7B0C9B0", VA = "0x187B0D7B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7B0D920", Offset = "0x7B0CB20", VA = "0x187B0D920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0A3B0", Offset = "0x7B095B0", VA = "0x187B0A3B0")]
		public void LocalPlayEmote(PEFMMHAKAJD.PLIPHJNOPNE FJBGDINLJBF, float KJIECKPLNFI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7B09B40", Offset = "0x7B08D40", VA = "0x187B09B40")]
		public bool IsEmotePlaying(PEFMMHAKAJD.PLIPHJNOPNE FJBGDINLJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B7A0", Offset = "0x7B0A9A0", VA = "0x187B0B7A0")]
		public void SetIdleHappy(bool OKPCDPFEMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7B07550", Offset = "0x7B06750", VA = "0x187B07550")]
		protected void AMGJIJLJKHF(bool BECPFLBNDLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7B0A530", Offset = "0x7B09730", VA = "0x187B0A530")]
		protected void OFGMGAPCEOK(bool NBGHBHFNCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7B08440", Offset = "0x7B07640", VA = "0x187B08440")]
		protected void FPHIGEHOKLO(KPCHKNGGLCC IKCLPEICFDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7B082A0", Offset = "0x7B074A0", VA = "0x187B082A0")]
		protected void CJEKPOKMPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7B0AE70", Offset = "0x7B0A070", VA = "0x187B0AE70")]
		public void PlayExpression(int OHMOKBAGDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7B09F20", Offset = "0x7B09120", VA = "0x187B09F20")]
		protected void JMNGCGBFBID(bool CIHOKBKMNJL, bool HPEDLABAHHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7B09590", Offset = "0x7B08790", VA = "0x187B09590")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType AAPBCKMENNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7B09630", Offset = "0x7B08830", VA = "0x187B09630")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration LPIFIOMBHJE, EAEHACEIFMC IMIGMMADGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B440", Offset = "0x7B0A640", VA = "0x187B0B440")]
		[AsyncStateMachine(typeof(HJBNPFAGBLP))]
		public Task SetFaceSettings(HEAMFGBJNNJ LNAHHHMDCMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B530", Offset = "0x7B0A730", VA = "0x187B0B530")]
		[AsyncStateMachine(typeof(DCEPMIGJIAE))]
		public Task SetFaceSettings(int GFJABNHBKEJ, int FOHMDCIMANI, int IHOLFLAHHNB, int MDNCGJPBFGH, EAEHACEIFMC IMIGMMADGOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B820", Offset = "0x7B0AA20", VA = "0x187B0B820")]
		[AsyncStateMachine(typeof(HDNEHGGLKLG))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType AAPBCKMENNH, int JGGMDLGPMII, EAEHACEIFMC IMIGMMADGOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7B08910", Offset = "0x7B07B10", VA = "0x187B08910")]
		protected void GHBDKBOGPDA(FaceFeatureType AAPBCKMENNH, FOJCDPOPCPL ILFKCEAJKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7B07890", Offset = "0x7B06A90", VA = "0x187B07890")]
		protected void BGMGPIDNEPI(FaceFeatureType AAPBCKMENNH, int JGGMDLGPMII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7B093C0", Offset = "0x7B085C0", VA = "0x187B093C0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7B07460", Offset = "0x7B06660", VA = "0x187B07460")]
		[AsyncStateMachine(typeof(HKCIAFFMJJA))]
		protected Task AGEKHPEDJDB(HEAMFGBJNNJ LNAHHHMDCMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0A0B0", Offset = "0x7B092B0", VA = "0x187B0A0B0")]
		protected void JPGDIFBFGBL(HEAMFGBJNNJ LNAHHHMDCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7B09230", Offset = "0x7B08430", VA = "0x187B09230")]
		protected static void GNEKMPFBDAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7B09C60", Offset = "0x7B08E60", VA = "0x187B09C60")]
		private void JIJAIFLKEBI(bool PLJMINBLLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7B084B0", Offset = "0x7B076B0", VA = "0x187B084B0")]
		protected void GDLGFFLCHDK(FaceFeatureType AAPBCKMENNH, Vector2 DEIEOHGDJPF, EAEHACEIFMC IMIGMMADGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7B0AE90", Offset = "0x7B0A090", VA = "0x187B0AE90")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType AAPBCKMENNH, Vector2 ELCDNFMOAJP, EAEHACEIFMC IMIGMMADGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7B075D0", Offset = "0x7B067D0", VA = "0x187B075D0")]
		protected void AMINENIAMCM(FaceFeatureType AAPBCKMENNH, float NJBNCPCJNPP, EAEHACEIFMC IMIGMMADGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ACF0", Offset = "0x7B09EF0", VA = "0x187B0ACF0")]
		protected void PGLOGBJBMCI(FaceFeatureType AAPBCKMENNH, float PANMBKPFLFA, EAEHACEIFMC IMIGMMADGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7B08840", Offset = "0x7B07A40", VA = "0x187B08840")]
		protected void GGLMMNAEOAD(FaceFeatureType AAPBCKMENNH, float DBANJKINOGK, EAEHACEIFMC IMIGMMADGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B220", Offset = "0x7B0A420", VA = "0x187B0B220")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType AAPBCKMENNH, float FGBIEDAPKND, EAEHACEIFMC IMIGMMADGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7B07FD0", Offset = "0x7B071D0", VA = "0x187B07FD0")]
		[AsyncStateMachine(typeof(IFAAJIMDOKM))]
		protected Task BIOFNHMFGHN(EAEHACEIFMC IMIGMMADGOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7B09930", Offset = "0x7B08B30", VA = "0x187B09930")]
		public void InitializeFaceFeatureStyleSet(EAEHACEIFMC IMIGMMADGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7B09FD0", Offset = "0x7B091D0", VA = "0x187B09FD0")]
		protected bool JNMNLDFBNNL(string CJMBNDLLJLD, [Out] int NIBICIJAIGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7B07750", Offset = "0x7B06950", VA = "0x187B07750")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x164BCD0", Offset = "0x164AED0", VA = "0x18164BCD0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7B0A940", Offset = "0x7B09B40", VA = "0x187B0A940")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C950", Offset = "0x7B0BB50", VA = "0x187B0C950")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7B081A0", Offset = "0x7B073A0", VA = "0x187B081A0")]
		[AsyncStateMachine(typeof(IGLEJAFJLEO))]
		public Task BuildFaceStyleAsyncIfChanged(EAEHACEIFMC IMIGMMADGOL, bool KMGMJINOHKD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C260", Offset = "0x7B0B460", VA = "0x187B0C260")]
		public void UpdateFaceDisplays(bool LBADOADKKFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7B08A90", Offset = "0x7B07C90", VA = "0x187B08A90")]
		protected bool GHHIMDODCNK(bool LBADOADKKFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7B0BF80", Offset = "0x7B0B180", VA = "0x187B0BF80")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B660", Offset = "0x7B0A860", VA = "0x187B0B660")]
		public void SetFaceSpriteIndices(string LPHPAIMBBMG, string NMOHHDGFBME, string IABMAFPEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B930", Offset = "0x7B0AB30", VA = "0x187B0B930")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C480", Offset = "0x7B0B680", VA = "0x187B0C480")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C670", Offset = "0x7B0B870", VA = "0x187B0C670")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7B080B0", Offset = "0x7B072B0", VA = "0x187B080B0")]
		protected void BJBKDEPOMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0A690", Offset = "0x7B09890", VA = "0x187B0A690")]
		private void OLHBKBLGACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0AB50", Offset = "0x7B09D50", VA = "0x187B0AB50")]
		private void PENOIHCNIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0D560", Offset = "0x7B0C760", VA = "0x187B0D560")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA1CDE0", Offset = "0xA1BFE0", VA = "0x180A1CDE0", Slot = "4")]
		private bool IPNNAEAJLGL()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct AGEKOGFMAAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public string BGMICIBNDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public int CCDGCEMKGPH;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct OOOEGEGKCCB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B04490", Offset = "0x7B03690", VA = "0x187B04490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct IBGCGDMKIDM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B019C0", Offset = "0x7B00BC0", VA = "0x187B019C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x7B01EC0", Offset = "0x7B010C0", VA = "0x187B01EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public EAEHACEIFMC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public BIDLKADDAJF useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public EDFKFIPIEMK hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public NEHJNKKHCKL HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private CMJKOOMEHEJ JJEEKIEHFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private AnimatorOverrideController PIOGDHEHEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> IJIPGBBHGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public readonly AGEKOGFMAAH[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public readonly (string, JDHBOJLMCKA)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		protected bool DAACGONLPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		protected Guid EFCPAIHDOJP;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		protected static Guid BBHDAKDHPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private KILAHEJLJLB AHCOBOBIMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private HGCMEOFLAIK DAFDDEPIIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private APPJCEDIMMA FJFIABHAFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private APPJCEDIMMA LFMFMDEOONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private AdditionalHatData JIIBFJEBDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private readonly Dictionary<GameObject, IDJDHKAFLFD> FGBKKPOMNNK;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public static Func<OELJPHMJLDA> HEMGODCECGK
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7B12A90", Offset = "0x7B11C90", VA = "0x187B12A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7B130D0", Offset = "0x7B122D0", VA = "0x187B130D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool PCCIAAIGJFF
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7B12BF0", Offset = "0x7B11DF0", VA = "0x187B12BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool BCFPLHLEJKG
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7B12AE0", Offset = "0x7B11CE0", VA = "0x187B12AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public PlayerAvatarDisplayBase EBGMLONGJKO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xABC0A0", Offset = "0xABB2A0", VA = "0x180ABC0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		protected static Guid KNEAIOHFCEO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7B10370", Offset = "0x7B0F570", VA = "0x187B10370")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public (GameObject, KPCHKNGGLCC)[] CCMEENJONPC
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x7B12D00", Offset = "0x7B11F00", VA = "0x187B12D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B10810", Offset = "0x7B0FA10", VA = "0x187B10810")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F720", Offset = "0x7B0E920", VA = "0x187B0F720")]
		private IEnumerable<GameObject> ILKOAFHFFFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B10D00", Offset = "0x7B0FF00", VA = "0x187B10D00")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B10290", Offset = "0x7B0F490", VA = "0x187B10290")]
		private void KJACBIEADOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1290CE0", Offset = "0x128FEE0", VA = "0x181290CE0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0FB90", Offset = "0x7B0ED90", VA = "0x187B0FB90")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B10D10", Offset = "0x7B0FF10", VA = "0x187B10D10")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B10B00", Offset = "0x7B0FD00", VA = "0x187B10B00")]
		public void ShowPose(AnimationClip IHLJEKHPGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B10CD0", Offset = "0x7B0FED0", VA = "0x187B10CD0")]
		public void ShowPose(string DKCBJEPIILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B10960", Offset = "0x7B0FB60", VA = "0x187B10960")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B10820", Offset = "0x7B0FA20", VA = "0x187B10820")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B117E0", Offset = "0x7B109E0", VA = "0x187B117E0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B11630", Offset = "0x7B10830", VA = "0x187B11630")]
		public void UpdateFaceAndBodyShapes(bool KMGMJINOHKD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B11BE0", Offset = "0x7B10DE0", VA = "0x187B11BE0")]
		public void UpdateNoseShape(BBICHONDDFB OOAIFJBLOGJ, bool KMGMJINOHKD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B11BB0", Offset = "0x7B10DB0", VA = "0x187B11BB0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B0DBC0", Offset = "0x7B0CDC0", VA = "0x187B0DBC0", Slot = "4")]
		protected virtual void AIOCDOLAGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B10460", Offset = "0x7B0F660", VA = "0x187B10460", Slot = "5")]
		protected virtual void LKPNEGBPBOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E090", Offset = "0x7B0D290", VA = "0x187B0E090")]
		public void ApplyHatData(AdditionalHatData FPMMNIHABNO, bool BNFPCENAGJG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0DED0", Offset = "0x7B0D0D0", VA = "0x187B0DED0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E3F0", Offset = "0x7B0D5F0", VA = "0x187B0E3F0")]
		public void ApplyHatUVOverride(Vector2 PEKGLFEPJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E310", Offset = "0x7B0D510", VA = "0x187B0E310")]
		public void ApplyHatPositionAdjustment(Vector3 EDOFLAHENNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E380", Offset = "0x7B0D580", VA = "0x187B0E380")]
		public void ApplyHatRotationAdjustment(Vector3 FHDNILCADFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E720", Offset = "0x7B0D920", VA = "0x187B0E720")]
		public AODJELJAHEP BuildAvatarItemSelection(GameObject CAGJKICDFJI, EAEHACEIFMC EHKELMIJMDD, KPCHKNGGLCC IJONBOEPBFA)
		{
			return default(AODJELJAHEP);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E7C0", Offset = "0x7B0D9C0", VA = "0x187B0E7C0")]
		public void BuildAvatar(bool KMGMJINOHKD = false, bool BNFPCENAGJG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B11070", Offset = "0x7B10270", VA = "0x187B11070")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E010", Offset = "0x7B0D210", VA = "0x187B0E010")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B11A00", Offset = "0x7B10C00", VA = "0x187B11A00")]
		public void UpdateHatAnchor(bool BNFPCENAGJG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B11730", Offset = "0x7B10930", VA = "0x187B11730")]
		[AsyncStateMachine(typeof(OOOEGEGKCCB))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EDD0", Offset = "0x7B0DFD0", VA = "0x187B0EDD0")]
		[AsyncStateMachine(typeof(IBGCGDMKIDM))]
		private Task CCFLPFAHBEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E460", Offset = "0x7B0D660", VA = "0x187B0E460")]
		private void BJNDOIPMLPM(FaceFeatureType CNIMCDMPCAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7B10780", Offset = "0x7B0F980", VA = "0x187B10780")]
		private void PANFHAGLPKM(FaceFeatureType CNIMCDMPCAO, [Out] float HBKOIGMBGDE, [Out] float FFDCBEKKGFG, [Out] float MMIJFAFPOOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7B114F0", Offset = "0x7B106F0", VA = "0x187B114F0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B11890", Offset = "0x7B10A90", VA = "0x187B11890")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EEA0", Offset = "0x7B0E0A0", VA = "0x187B0EEA0")]
		private void DHMNPGCBIBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private void CHPNHMOIFCH(IDJDHKAFLFD KCMFKDFNBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		private void CJBHPGLJILI(IDJDHKAFLFD KCMFKDFNBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F3C0", Offset = "0x7B0E5C0", VA = "0x187B0F3C0")]
		private void GPMBCOFPPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B11C60", Offset = "0x7B10E60", VA = "0x187B11C60")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B106D0", Offset = "0x7B0F8D0", VA = "0x187B106D0")]
		[CompilerGenerated]
		private AODJELJAHEP OBIGAFDMNEG((GameObject, KPCHKNGGLCC) EEJMHEOPCDJ)
		{
			return default(AODJELJAHEP);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct AODJELJAHEP
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class FBONDLFPDLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public FBONDLFPDLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B00A30", Offset = "0x7AFFC30", VA = "0x187B00A30")]
		internal bool NEIMAHEADJJ(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private IDJDHKAFLFD HCLGGPCHHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private KPCHKNGGLCC DHDAEHJJGPO;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IDJDHKAFLFD HKEADDOFEJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public KPCHKNGGLCC AOJFILOCGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xD42180", Offset = "0xD41380", VA = "0x180D42180")]
		get
		{
			return default(KPCHKNGGLCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string GGKCIIOKDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF8A0", Offset = "0x7AFEAA0", VA = "0x187AFF8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool BFALHDPCBBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF850", Offset = "0x7AFEA50", VA = "0x187AFF850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LKOMJNBNNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF990", Offset = "0x7AFEB90", VA = "0x187AFF990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x17BD360", Offset = "0x17BC560", VA = "0x1817BD360")]
	public AODJELJAHEP(IDJDHKAFLFD KCMFKDFNBLH, KPCHKNGGLCC IKCLPEICFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7AFF9E0", Offset = "0x7AFEBE0", VA = "0x187AFF9E0")]
	public bool PMKGBKLBIPM(OutfitType PDNDFIHKEOL, KPCHKNGGLCC NJBOKNFMCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7AFF400", Offset = "0x7AFE600", VA = "0x187AFF400")]
	public bool BKLPGMMJDJA(OutfitType PDNDFIHKEOL, KPCHKNGGLCC NJBOKNFMCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7AFF660", Offset = "0x7AFE860", VA = "0x187AFF660")]
	public bool GFBLILIKGME(AODJELJAHEP GFLDNDFBJFB)
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
