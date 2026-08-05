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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7932C10", Offset = "0x7932010", VA = "0x187932C10", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
			[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x793FF00", Offset = "0x793F300", VA = "0x18793FF00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x793FE90", Offset = "0x793F290", VA = "0x18793FE90", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x793FEC0", Offset = "0x793F2C0", VA = "0x18793FEC0")]
		public RecNetCDNAssetReference(RecNetCDNKey IICGAABOENK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum BMGALKANECG : byte
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
			[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9F7FA0", Offset = "0x9F73A0", VA = "0x1809F7FA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9F7D20", Offset = "0x9F7120", VA = "0x1809F7D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BMGALKANECG PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD7C4C0", Offset = "0xD7B8C0", VA = "0x180D7C4C0")]
			[CompilerGenerated]
			get
			{
				return default(BMGALKANECG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x128A150", Offset = "0x1289550", VA = "0x18128A150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7940010", Offset = "0x793F410", VA = "0x187940010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x793FF90", Offset = "0x793F390", VA = "0x18793FF90")]
		public static RecNetCDNKey MKNCAIFGHDO(string AKOEHIMDEEN, BMGALKANECG AJKCIEMDNDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x793FF40", Offset = "0x793F340", VA = "0x18793FF40")]
		public void KMAKIIICLOO(string DNCGNDKOFGI, string MKLCJOILBMP, bool MKAELJHANFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[IJOMDGJLMLC]
public class FPHKBKCKEFI : IJJAPEHKKEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> IGBKKNIJAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> KBJEOPJDANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> ALBCLPOCBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> PJOGHEEICGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> GHFIKDCPGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> LALCFAJHDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> KDLKDMIHLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator KPCLKCGLEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected MMLHJADAHDP FAIFADBNIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte JLPICINNPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> KFNIPCKLFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> BIAKONOGKOP;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x792DBE0", Offset = "0x792CFE0", VA = "0x18792DBE0", Slot = "4")]
	public void GGEOCDKAPLP(Mesh IGPCANDHEAE, Matrix4x4 HOCAIHBBIII, byte[] FOPDBNEDBDL, bool INDMKONCMOB = false, MOJPHFECLPK.JODCMICJPOD LJALGHFGBJD = (MOJPHFECLPK.JODCMICJPOD)0L, int GJHJCCOEDJM = -1, bool HBLMKDAAMGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x792DBA0", Offset = "0x792CFA0", VA = "0x18792DBA0", Slot = "5")]
	public void EPMHHOMHJHE(Allocator LMMGDELCIGC, MMLHJADAHDP FDLKGJPBCLI, byte JFLLIEFLOAN, [Optional] IList<int> FDFEKECPEML, [Optional] IList<int> BHJIBDMJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x792D940", Offset = "0x792CD40", VA = "0x18792D940")]
	private static void CCKKPMGEJIG(Mesh IGPCANDHEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x792DE60", Offset = "0x792D260", VA = "0x18792DE60")]
	public FPHKBKCKEFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[IJOMDGJLMLC]
public struct COAIOAAOMLG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public HILGFIIMJKM BEJAACOABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int KKCBFLPOOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public LIKIIGOPDGC OHILHMBMFDH;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x792BC10", Offset = "0x792B010", VA = "0x18792BC10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[IJOMDGJLMLC]
public struct LIKIIGOPDGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct JGPCOFFMMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 CCGHLOJKMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 KBGACFDBMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 KIEOKDMFIGP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct CIKPEOJBANB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float ACHDJPDIJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float AGEFINEFNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float GLEIKBFBHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float KFLFPKFDAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte JEPCBFJAGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte BIAAIGCDNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte CJDNNPBEECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte ACLCHKMDLOO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct LGGBJDDPBAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half ACHDJPDIJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half AGEFINEFNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half GLEIKBFBHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half KFLFPKFDAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte JEPCBFJAGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte BIAAIGCDNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte CJDNNPBEECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte ACLCHKMDLOO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct CMDMNHFJDFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 JLFKDHGAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 BAHNLBEDACE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct HPPGHLCOCPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 JLFKDHGAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 BAHNLBEDACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 GLFDGEBKPBF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LGBDOEGJINE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 JLFKDHGAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 BAHNLBEDACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 GLFDGEBKPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 JCBMLEDLIAG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct JPDDMPKBIIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 JLFKDHGAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 BAHNLBEDACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 GLFDGEBKPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 JCBMLEDLIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 ECNBACPPPHP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PJNANEFEJHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float ACHDJPDIJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float AGEFINEFNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float GLEIKBFBHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float KFLFPKFDAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int JEPCBFJAGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int BIAAIGCDNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int CJDNNPBEECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int ACLCHKMDLOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct PIIOLEDPOFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color JLFKDHGAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 BAHNLBEDACE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LHDEMCGNFND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color JLFKDHGAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 BAHNLBEDACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 GLFDGEBKPBF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct EPDKDDALGEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color JLFKDHGAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 BAHNLBEDACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 GLFDGEBKPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 JCBMLEDLIAG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct JJGGLPMDKAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color JLFKDHGAEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 BAHNLBEDACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 GLFDGEBKPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 JCBMLEDLIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 ECNBACPPPHP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool AAABKKPICPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<JGPCOFFMMGM> AOOBHAGCPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<CMDMNHFJDFN> MFIFOALHMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<HPPGHLCOCPM> NKMHGMBHJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<LGBDOEGJINE> DONCLDCEGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<JPDDMPKBIIK> BNKCNMABIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<LGGBJDDPBAE> MKILNGFIKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<CIKPEOJBANB> PEAOIMKAOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<PIIOLEDPOFK> DGKACFBPCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<LHDEMCGNFND> AMOPECEEOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<EPDKDDALGEN> IPDKPLIPCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<JJGGLPMDKAO> AEMEGAJPBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<PJNANEFEJHN> ENNLABBHHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> PAIIAPCMBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> IBPAIGDEBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> INMBHAFJFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> FEIPIPBPNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> JBELGJMMEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> ABBHOMOKCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> DBGLMFMOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> CCDILOBBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> OPJDOLNIGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool JHOAOFBABMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool IPHKKJNBPKG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DNFJPKILBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x79304B0", Offset = "0x792F8B0", VA = "0x1879304B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7930930", Offset = "0x792FD30", VA = "0x187930930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FGONIPEEEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x79304A0", Offset = "0x792F8A0", VA = "0x1879304A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x79319A0", Offset = "0x7930DA0", VA = "0x1879319A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DBLGOKMADAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x792FE80", Offset = "0x792F280", VA = "0x18792FE80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7930940", Offset = "0x792FD40", VA = "0x187930940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BEIEHNPPCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x79304C0", Offset = "0x792F8C0", VA = "0x1879304C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x79321E0", Offset = "0x79315E0", VA = "0x1879321E0")]
	public LIKIIGOPDGC(int LMLEAMKIKHE, int DPCHKOFINNA, int LJPDJOJABNA, int HILAGJKHOEB, Allocator LMMGDELCIGC, int INHPLKCNKNM, DMKNFKMNBLJ JIOCGCIDEBA, bool JHOAOFBABMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7930950", Offset = "0x792FD50", VA = "0x187930950")]
	public void MMCKFHCJJCA(int COPLIEINKOF, Vector3 LLEKGMDPLMK, Vector3 LDMILEIDPGI, Vector4 DEEHPBDAIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7931DB0", Offset = "0x79311B0", VA = "0x187931DB0")]
	public void POLGEODCNAK(int COPLIEINKOF, BoneWeight JIHIAPAPLBL, NativeSlice<byte> FOPDBNEDBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7930600", Offset = "0x792FA00", VA = "0x187930600")]
	public Color IIPCMGIIAOP(int COPLIEINKOF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x79319B0", Offset = "0x7930DB0", VA = "0x1879319B0")]
	public void PGMBEALILMD(int COPLIEINKOF, Color NEIELBLPLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x792FE90", Offset = "0x792F290", VA = "0x18792FE90")]
	public void DMEKPPJIHOA(byte KONJFHKABGH, int COPLIEINKOF, Vector2 OMHKKBGGNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x79309E0", Offset = "0x792FDE0", VA = "0x1879309E0")]
	public void NKFABIBGDON(int COPLIEINKOF, int MHFNAPNEJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7931940", Offset = "0x7930D40", VA = "0x187931940")]
	public bool OHGKJJFBHMI(int KONJFHKABGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7930530", Offset = "0x792F930", VA = "0x187930530")]
	public void IEFPDHBJKBL(int JKCFIEGDEPM, int IALPEJIGIPD, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7930240", Offset = "0x792F640", VA = "0x187930240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x79309F0", Offset = "0x792FDF0", VA = "0x1879309F0")]
	public Mesh NOOINEIDNCN([Optional] string OCHFDEHDFLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[IJOMDGJLMLC]
[NativeContainer]
public struct HILGFIIMJKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray DDDDLFCBIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> GOPNOGLGOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> JHPJOIGODPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> CCDILOBBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> PBHCIPLDAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> PJFIJINDMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> LGPGGFJMCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> GEDGEHGHGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> EHBGNMNDBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> LCNGIMFEEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> GFPJLAGJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> HBLMKDAAMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> GJHJCCOEDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool JHOAOFBABMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> PPGDEOGMPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool IPHKKJNBPKG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KLMOMHCPIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x792E290", Offset = "0x792D690", VA = "0x18792E290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DFKBKGBIJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x792E0C0", Offset = "0x792D4C0", VA = "0x18792E0C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HBACKHBILEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x792E610", Offset = "0x792DA10", VA = "0x18792E610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LAINMMEIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x792E390", Offset = "0x792D790", VA = "0x18792E390")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x792E280", Offset = "0x792D680", VA = "0x18792E280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DNFJPKILBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x792E270", Offset = "0x792D670", VA = "0x18792E270")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x792E2A0", Offset = "0x792D6A0", VA = "0x18792E2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int PDGEFKKAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x792E0E0", Offset = "0x792D4E0", VA = "0x18792E0E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x792E3A0", Offset = "0x792D7A0", VA = "0x18792E3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MMLHJADAHDP FKKGCCJCKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x792E0D0", Offset = "0x792D4D0", VA = "0x18792E0D0")]
		get
		{
			return default(MMLHJADAHDP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x792E0B0", Offset = "0x792D4B0", VA = "0x18792E0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte GNECOBFPNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x792E600", Offset = "0x792DA00", VA = "0x18792E600")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x792E380", Offset = "0x792D780", VA = "0x18792E380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DDGLANNEICH LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x792E3B0", Offset = "0x792D7B0", VA = "0x18792E3B0")]
		get
		{
			return default(DDGLANNEICH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x792E6E0", Offset = "0x792DAE0", VA = "0x18792E6E0")]
	public HILGFIIMJKM(IList<Mesh> GDPIDINCOGJ, IList<Matrix4x4> BPKKINFDFAC, IList<bool> HBLMKDAAMGN, byte JFLLIEFLOAN, IList<byte[]> PKGJFPJAOHE, IList<long> EALCLADCLDA, IList<bool> DNHNIAMOMMK, IList<int> GJHJCCOEDJM, IList<int> FDFEKECPEML, IList<int> JPCMALDEIJF, Allocator LMMGDELCIGC, MMLHJADAHDP FDLKGJPBCLI, bool JHOAOFBABMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x792E2B0", Offset = "0x792D6B0", VA = "0x18792E2B0")]
	public LIKIIGOPDGC JOBAKKENCDI(Allocator LMMGDELCIGC, DMKNFKMNBLJ JIOCGCIDEBA)
	{
		return default(LIKIIGOPDGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x792E0F0", Offset = "0x792D4F0", VA = "0x18792E0F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[IJOMDGJLMLC]
public class HLJNHINDBMI : FPHKBKCKEFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool KMCPOINMIPE;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker AABPOMGNGEA;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x792F8F0", Offset = "0x792ECF0", VA = "0x18792F8F0")]
	public HILGFIIMJKM FKNMKLFPPLJ()
	{
		return default(HILGFIIMJKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x792FBB0", Offset = "0x792EFB0", VA = "0x18792FBB0")]
	public HLJNHINDBMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DDGLANNEICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData EJOBMJFDEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> CCDILOBBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> PPFNLNBKDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int GEOGABLDMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 KMDNHBFFBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long BBHJOFLIMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> FOPDBNEDBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool HGFPKPOCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int EPJJMBLOJGL;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MOPMMHIMELM : CKKICPFEDGL
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FPBDEOLNKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public LAAPKAPFAKB avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public MOPMMHIMELM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ALPDPKEGNFF buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action<KeyValuePair<string, PKCCCOBBKFK<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public FPBDEOLNKHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x792D810", Offset = "0x792CC10", VA = "0x18792D810")]
		internal bool HEMLACIJPKC(NDKAGBMMFHK item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x792D7C0", Offset = "0x792CBC0", VA = "0x18792D7C0")]
		internal void DCEHHNEDLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x792D860", Offset = "0x792CC60", VA = "0x18792D860")]
		internal void IJGEBGNGNIA(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x792D7C0", Offset = "0x792CBC0", VA = "0x18792D7C0")]
		internal void DMBNIGJOCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x792D860", Offset = "0x792CC60", VA = "0x18792D860")]
		internal void ODLCNBJINFE(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x792D7E0", Offset = "0x792CBE0", VA = "0x18792D7E0")]
		internal void GMCCKLOEIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x792D790", Offset = "0x792CB90", VA = "0x18792D790")]
		internal void DBKBIAGHOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x792D880", Offset = "0x792CC80", VA = "0x18792D880")]
		internal void OCDHOJMCGOI(Dictionary<string, PKCCCOBBKFK<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x792D6D0", Offset = "0x792CAD0", VA = "0x18792D6D0")]
		internal void BOMMNJCJOEN(KeyValuePair<string, PKCCCOBBKFK<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		internal DKABIBJEBOC NFCMDNDOFAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OCBKDLLLECK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public FPBDEOLNKHB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OCBKDLLLECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x793FCA0", Offset = "0x793F0A0", VA = "0x18793FCA0")]
		internal ELCBLFJGOOO DLHDAIFHLHF(int lod)
		{
			return default(ELCBLFJGOOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class OKENOKOCBME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public NDJGFNKMCGL<Dictionary<string, PKCCCOBBKFK<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OKENOKOCBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		internal NDJGFNKMCGL<Dictionary<string, PKCCCOBBKFK<Texture2D>>> LGDEHIIAOFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PLGDFKCJEAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<ALPDPKEGNFF> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PLGDFKCJEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x793FD60", Offset = "0x793F160", VA = "0x18793FD60")]
		internal void GEBOFENPKBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CGMHMKBMIDG : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public MOPMMHIMELM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public List<EDNGGAEGJMP> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<ALPDPKEGNFF> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public Func<int, ELCBLFJGOOO> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public NHDPAPIPOBA materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public CGMHMKBMIDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x792B940", Offset = "0x792AD40", VA = "0x18792B940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x792BBC0", Offset = "0x792AFC0", VA = "0x18792BBC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EHGCJJGFDDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public OLGGPKFFNDE cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public EHGCJJGFDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA57650", Offset = "0xA56A50", VA = "0x180A57650")]
		internal void NKMCELNDDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xC9E410", Offset = "0xC9D810", VA = "0x180C9E410")]
		internal void PKAPDAFKCBH(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HPECALCCDLE
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
		public MOPMMHIMELM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public HPECALCCDLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AOCKNIDOJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public LIKIIGOPDGC defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public HILGFIIMJKM defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public HPECALCCDLE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AOCKNIDOJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7929DA0", Offset = "0x79291A0", VA = "0x187929DA0")]
		internal void DCONOJDPCIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x11F75A0", Offset = "0x11F69A0", VA = "0x1811F75A0")]
		internal void HHHHHLDPMPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ILIKAPIIKGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JDGMFIBEFHH legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public EKGNDFLNLFD legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public HPECALCCDLE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ILIKAPIIKGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x792FBC0", Offset = "0x792EFC0", VA = "0x18792FBC0")]
		internal void HAGPNIMDLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x11E7B10", Offset = "0x11E6F10", VA = "0x1811E7B10")]
		internal void NFHAFBECGIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JDIANAMGLCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public MJGMDPCOPJP overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JDIANAMGLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x792FE00", Offset = "0x792F200", VA = "0x18792FE00")]
		internal bool ECCOBAENDAA(KeyValuePair<string, NDKAGBMMFHK> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly KFBDEOPEKLE MIIAHFINEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly KFBDEOPEKLE FJOMLIFBPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<BCKKHHFAGPP, float> MIIBJGKPMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<FGBECOOKEOM, float> DBCJLEACLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<JCIMPJGFJKG, float> AGMIOMDAGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, PNBEAKMENNH> JMIBEGIDFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, PNBEAKMENNH> OKCCKABJEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, PNBEAKMENNH> MGJBALMIJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, PNBEAKMENNH> CAEIHJNDMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private BFMHJLAEPMI EEDMEEIIJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private BFMHJLAEPMI MCLPAJAGLCE;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float GFAAKOGNIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? HHCKHFOCNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? HJAAFKAEDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? OFAPEIMKDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? MAKEKKBDOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration BKKIJINGKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform EJJJJBLFPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem APLFIMALDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference DFGEFFDBPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject OMMHAKPEIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject JPOPFPNDPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer EHAJHFEACLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData MOOJCLOLDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] PLIOIBAOAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] IIIIFODDDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material PKALMCELAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material PKFPOBPNFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material CIJBHGHKLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Shader MJDEMPOAGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader DJMGIKGCOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Animator EGIOLJKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Renderer[] NJDDPOFFDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private MOJPHFECLPK.JODCMICJPOD JBKMLINAMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AvatarBodyPartShapesManager FHIHNFHKHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private IReadOnlyDictionary<string, Transform> GBPPIMEEAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private AvatarFaceShapeData.BMGPHLCKOHO FJCPNHFJFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarBodyShapeData.KDFLAIKEMGD FMILADPDIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private EKLJAOFDFFM CACEJKKGLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool HDJAGBPHPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool COGGKKOCDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Color NNAGPCFEGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color HANCPGNJCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color IEAMJNFFINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color? EIPCJLHHDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? NGBBLNCGAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? PKKONFENLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? PLLKIGDGIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Texture2D FFOBNCKJFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D DIFMHHKDKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[CanBeNull]
	private NDKAGBMMFHK LCLBGOCAJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Texture EIGFNMDIBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Color NDHPLKENLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Dictionary<Renderer, NHDPAPIPOBA> HCFKMKKLBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Dictionary<Renderer, NHDPAPIPOBA> EPIJPJDNEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, List<DJOGFPFHELD>> DMADJLBMHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<DJOGFPFHELD>> HMCCLHEPJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly List<BFNBKBNLNFO> KPDPLBMJFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<BFNBKBNLNFO> HMFAADOLODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<BFNBKBNLNFO> MBFICOEBHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<BFNBKBNLNFO> AFBBBIGAEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Dictionary<DJOGFPFHELD, Material> ADBHLCMBINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<DJOGFPFHELD, Material> IDDHLDKFHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private SkinnedMeshRenderer[] HFCDOMIMLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] IGMFJFMHPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] AKHCGKDBECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] PIOPFCCALKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<string, PKCCCOBBKFK<Texture2D>> JIABDFMFIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, PKCCCOBBKFK<Texture2D>> KIIPGGBPJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AdditionalHatData GHGFKNJFIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData PDFODCJNPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private HairData OELGPEMOMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData POCJLCBCKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private AOFLICKOANP ELJAFACPOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool? PDBJNDPBOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private PositionAndRotation CDOFFIELJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform OPGNEGEJGME;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Material EHBBHEGHPBO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material EBGGPCLIHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Dictionary<string, NDKAGBMMFHK> PFJEPGNPDFO;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int BIOECLMPKCM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int EGKBMPKAKME;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int NDIJHJLHECJ;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int OACCCPOMMNE;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int HDAAKNKBCGH;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int MEGNMMHJLBA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int LIBOKAAMLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool EIJLOHCEIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> NOJDKNJGNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private KIDHHIPBIAG NDIACLLNGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private SkinnedMeshRenderer[] FEGNKCFEFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int FBMBJLDPBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool MDBJFOOAODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int PBLGJEEDGEB;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public KFBDEOPEKLE NPLOCJLICMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public KFBDEOPEKLE EHBAMAPCHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private PCFGMNCOCPN MIBMBMCHHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x79349A0", Offset = "0x7933DA0", VA = "0x1879349A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool BDPFPJLFBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x793DF40", Offset = "0x793D340", VA = "0x18793DF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool PKEMNBOMBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x793B260", Offset = "0x793A660", VA = "0x18793B260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool JAJILFLHMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x793BB20", Offset = "0x793AF20", VA = "0x18793BB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool AFJJABGBNOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x793C140", Offset = "0x793B540", VA = "0x18793C140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration ABMDHBOOHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7D0", Offset = "0x9CCBD0", VA = "0x1809CD7D0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool OGNOCINJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x13009E0", Offset = "0x12FFDE0", VA = "0x1813009E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x252BC10", Offset = "0x252B010", VA = "0x18252BC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material EEFNKJGIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x793C220", Offset = "0x793B620", VA = "0x18793C220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material DHHFGLPMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7939F30", Offset = "0x7939330", VA = "0x187939F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool MEFGCBCAIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public LOHMIPEBFLA KHLHALFBNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1150A10", Offset = "0x114FE10", VA = "0x181150A10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(LOHMIPEBFLA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x114EEC0", Offset = "0x114E2C0", VA = "0x18114EEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material OLBHAMIIFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC9AEA0", Offset = "0xC9A2A0", VA = "0x180C9AEA0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] EJKJGLNJFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1B9EB70", Offset = "0x1B9DF70", VA = "0x181B9EB70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] MPGLLLBCFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA67400", Offset = "0xA66800", VA = "0x180A67400", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DNIGEGIPKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x793EE20", Offset = "0x793E220", VA = "0x18793EE20", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public MOJPHFECLPK.JODCMICJPOD GMHLCIEPNOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F230", Offset = "0xA5E630", VA = "0x180A5F230", Slot = "20")]
		get
		{
			return default(MOJPHFECLPK.JODCMICJPOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int MGMPJAKCHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x114EEF0", Offset = "0x114E2F0", VA = "0x18114EEF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7934760", Offset = "0x7933B60", VA = "0x187934760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool EDCHIDNADPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x793B650", Offset = "0x793AA50", VA = "0x18793B650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool OKAJHKNHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x793E6D0", Offset = "0x793DAD0", VA = "0x18793E6D0", Slot = "15")]
	public ALPDPKEGNFF OHEADOBHNJF(LAAPKAPFAKB LOJPCJHBPKC, bool NEIHBJENBCF, int[] IPMDIHKDHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x793EC00", Offset = "0x793E000", VA = "0x18793EC00", Slot = "14")]
	public ALPDPKEGNFF PAPBPKOAKPH(LAAPKAPFAKB LOJPCJHBPKC, bool NEIHBJENBCF, int[] IPMDIHKDHPF, Func<Dictionary<string, NDKAGBMMFHK>, (ALPDPKEGNFF, NDJGFNKMCGL<Dictionary<string, PKCCCOBBKFK<Texture2D>>>)> JOFOELFDMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79356F0", Offset = "0x7934AF0", VA = "0x1879356F0")]
	public ALPDPKEGNFF EEHEJBALOCO(LAAPKAPFAKB LOJPCJHBPKC, bool NEIHBJENBCF, int[] IPMDIHKDHPF, bool MBMBPFBLLKB, BFMHJLAEPMI PAHHPPAODBI, [Optional] Func<Dictionary<string, NDKAGBMMFHK>, (ALPDPKEGNFF, NDJGFNKMCGL<Dictionary<string, PKCCCOBBKFK<Texture2D>>>)> JOFOELFDMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x793B490", Offset = "0x793A890", VA = "0x18793B490")]
	private bool KFMCELHMBMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7933EB0", Offset = "0x79332B0", VA = "0x187933EB0")]
	private ALPDPKEGNFF DCEDONEIJFI(bool NEIHBJENBCF, List<EDNGGAEGJMP> EPACINOLFFI, int[] IPMDIHKDHPF, Func<int, ELCBLFJGOOO> ADOANDKEOPG, bool MBMBPFBLLKB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x793EF90", Offset = "0x793E390", VA = "0x18793EF90")]
	[IteratorStateMachine(typeof(CGMHMKBMIDG))]
	private IEnumerator<LCENDOCODMB> POIJLKBOPGN(bool NEIHBJENBCF, List<EDNGGAEGJMP> EPACINOLFFI, int[] IPMDIHKDHPF, Func<int, ELCBLFJGOOO> ADOANDKEOPG, NHDPAPIPOBA ENIIFPAMLBF, Material OIINLIAGOKI, List<ALPDPKEGNFF> KFNIAGEEEJP, bool NGIPPJJCIJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x793A450", Offset = "0x7939850", VA = "0x18793A450")]
	private void JAAMMNALCFN(List<EDNGGAEGJMP> EPACINOLFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7938000", Offset = "0x7937400", VA = "0x187938000")]
	private ALPDPKEGNFF FDMFNKDDJPF(List<EDNGGAEGJMP> EPACINOLFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x793CC20", Offset = "0x793C020", VA = "0x18793CC20")]
	private DGHHBAELICH NEEEKKGONMA(List<EDNGGAEGJMP> EPACINOLFFI, int BKCGKLBAHGO, bool NEIHBJENBCF, ELCBLFJGOOO ECBKLLFECHB, bool EOGPMKIDCBA, NHDPAPIPOBA ENIIFPAMLBF, Material OIINLIAGOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x793B180", Offset = "0x793A580", VA = "0x18793B180", Slot = "27")]
	public void JKKPAKCEAOC(BCKKHHFAGPP CBKABMIGHBO, float OOEMJLHLIHJ, bool CLINKEIPFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7933400", Offset = "0x7932800", VA = "0x187933400", Slot = "29")]
	public void BDPBLOJJNPF(FGBECOOKEOM EJGKLLLLALH, float OOEMJLHLIHJ, bool AAKNAEMMJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7932F30", Offset = "0x7932330", VA = "0x187932F30", Slot = "30")]
	public void ANIHNCNHNEE(JCIMPJGFJKG OLCFOJACJIG, float OOEMJLHLIHJ, bool JBGDJHMBBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7933D10", Offset = "0x7933110", VA = "0x187933D10", Slot = "28")]
	public void COPMAJGOOLH(bool KODNDHHNFLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x793C780", Offset = "0x793BB80", VA = "0x18793C780", Slot = "31")]
	public void NAOEKBONOCO(bool KODNDHHNFLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x793EC30", Offset = "0x793E030", VA = "0x18793EC30", Slot = "32")]
	public void PBPIJAFHDLJ(bool KODNDHHNFLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x793C530", Offset = "0x793B930", VA = "0x18793C530")]
	private void MLOPKAAHNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x793C000", Offset = "0x793B400", VA = "0x18793C000")]
	private void LMLKBNAPAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7933380", Offset = "0x7932780", VA = "0x187933380")]
	private void BABEAGODAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x793C080", Offset = "0x793B480", VA = "0x18793C080", Slot = "25")]
	public void LNBIJGIAFMM(AvatarFaceShape KDHMLIJJJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x793B560", Offset = "0x793A960", VA = "0x18793B560", Slot = "26")]
	public void KJDHJJOMDDG(AvatarBodyShape CBKGAIGIBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x22ACB60", Offset = "0x22ABF60", VA = "0x1822ACB60", Slot = "33")]
	public void HPGJGGHKHED(EKLJAOFDFFM EFBDDCCBBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7935130", Offset = "0x7934530", VA = "0x187935130", Slot = "35")]
	public void EBCKLLKPOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7933D70", Offset = "0x7933170", VA = "0x187933D70", Slot = "38")]
	public void CPFJBDILAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7933C70", Offset = "0x7933070", VA = "0x187933C70", Slot = "34")]
	public void CGJKCGCGPGD(bool AINPCMODBCI, bool FJOIMKOJKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x793B340", Offset = "0x793A740", VA = "0x18793B340")]
	private void KFIJCOJMAHM(SkinnedMeshRenderer GLMPHIBBLCM, int BKCGKLBAHGO, Mesh IGPCANDHEAE, List<Material> IGEAFMJNNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7933220", Offset = "0x7932620", VA = "0x187933220")]
	private static Material APOJMLFDINM(Dictionary<DJOGFPFHELD, Material> POEFDNJEDGN, Material DFPBBLNGBAB, CACMIOCCJGJ DMAAMPLEDGG, OHPFNPNDHLJ BDIBLODBLEH, MJGMDPCOPJP DFKGNLKKCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x79383B0", Offset = "0x79377B0", VA = "0x1879383B0")]
	private static CACMIOCCJGJ FHGHBNBMENF(EDNGGAEGJMP BMOBKLECNPF, int EBBDANBAIHJ)
	{
		return default(CACMIOCCJGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7937870", Offset = "0x7936C70", VA = "0x187937870")]
	private void EJBCEKMPANI(int LDDICKCHFNB, Material FFHFAEDNMPG, EDNGGAEGJMP BMOBKLECNPF, [Out] Texture2D ICGCGFEHPKA, [Out] Vector4 COGBFCPKIJK, [Out] Texture2D LPNEBKAAODJ, [Out] Texture2D ILAOBDJLDGB, [Out] Texture2D GMHIEBGMEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x793AA70", Offset = "0x7939E70", VA = "0x18793AA70")]
	private void JBLKGAFNBGA(int LDDICKCHFNB, Material FFHFAEDNMPG, EDNGGAEGJMP BMOBKLECNPF, [Out] Color MMFEOPPFIJC, [Out] Color DKHCMLFNJEN, [Out] Color FPFPBCCJFCL, [Out] Color LGHIHINJDEE, [Out] Color NMAMGFOFBFB, [Out] Color CAOIJFCOMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x793B8C0", Offset = "0x793ACC0", VA = "0x18793B8C0")]
	private bool LHNOCBEJHCB(Material FFHFAEDNMPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x793ECC0", Offset = "0x793E0C0", VA = "0x18793ECC0")]
	private static Material PFDGKPAHOMO(int LDDICKCHFNB, EFMCDPJBIJP BMOBKLECNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x793F0B0", Offset = "0x793E4B0", VA = "0x18793F0B0")]
	private static OHPFNPNDHLJ PPGBMHHAILF(EDNGGAEGJMP BMOBKLECNPF, int EBBDANBAIHJ)
	{
		return default(OHPFNPNDHLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x793C960", Offset = "0x793BD60", VA = "0x18793C960")]
	private static void NEBDDCAFGGA(Dictionary<string, List<DJOGFPFHELD>> PPJCHOKILKM, EDNGGAEGJMP FMJAAABPEAI, Material DFPBBLNGBAB, CACMIOCCJGJ PBAGJLPCJPH, OHPFNPNDHLJ GEKBJBBGKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x79334E0", Offset = "0x79328E0", VA = "0x1879334E0")]
	private static SkinnedMeshRenderer BEMJOLIPNCC(Transform LEBPKMKLHLN, Transform NJBNHOIMLNH, SkinnedMeshRenderer[] FPKMAPBAAOK, int BKCGKLBAHGO, ELCBLFJGOOO ECBKLLFECHB, bool NEIHBJENBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x793F300", Offset = "0x793E700", VA = "0x18793F300")]
	public MOPMMHIMELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7937C80", Offset = "0x7937080", VA = "0x187937C80")]
	public void ENMMELFAOHH([In] ICCCEGHKHFM BAOPJCOCGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x79373D0", Offset = "0x79367D0", VA = "0x1879373D0")]
	public void FLMBCCCBLNM([In] FOIKDEKIGMP LBLAKCFMMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7934760", Offset = "0x7933B60", VA = "0x187934760", Slot = "5")]
	public void DICEGGMCPAL(int BKCGKLBAHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7933000", Offset = "0x7932400", VA = "0x187933000", Slot = "10")]
	public void APDBANLCNLD(EEKMALMABLI GEKBJBBGKGK, Texture2D PNHEFBGDDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0")]
	public static bool GMKKBGLGONJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x793C7E0", Offset = "0x793BBE0", VA = "0x18793C7E0", Slot = "11")]
	public bool NBNPEBMNPOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x793A020", Offset = "0x7939420", VA = "0x18793A020", Slot = "9")]
	public void IHPFFBBGFFL(NMMLLNKGFJC PBAGJLPCJPH, Color? JLFKDHGAEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7939B90", Offset = "0x7938F90", VA = "0x187939B90")]
	private void HFOMEEJDEMA(Action OAEHEMGDFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x793EDB0", Offset = "0x793E1B0", VA = "0x18793EDB0", Slot = "6")]
	public void PKAEJEFNKMA(NDKAGBMMFHK LDAFGBOABPN, Texture LDBGJEIKFFL, Color ILOPDPAAFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x252BC10", Offset = "0x252B010", VA = "0x18252BC10", Slot = "7")]
	public void ILJEBHJNKFL(bool NGIPPJJCIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x12A7150", Offset = "0x12A6550", VA = "0x1812A7150", Slot = "8")]
	public void JADIFMJHOGP(KIDHHIPBIAG OPJDOLNIGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x793E200", Offset = "0x793D600", VA = "0x18793E200", Slot = "16")]
	public void NPALAMLGMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7939A10", Offset = "0x7938E10", VA = "0x187939A10", Slot = "36")]
	public void GDFBOHMEFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x79384B0", Offset = "0x79378B0", VA = "0x1879384B0", Slot = "37")]
	public void FKIPFHKDNIM([Optional] AOFLICKOANP FNMHKMFPHLM, [Optional] bool? PKIBBIPCIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x793DE00", Offset = "0x793D200", VA = "0x18793DE00")]
	private bool NGMGKAKGCEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7939350", Offset = "0x7938750", VA = "0x187939350", Slot = "21")]
	public bool FMHAIIANNNO(MOJPHFECLPK.JODCMICJPOD KIKOIPIKOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x793C5B0", Offset = "0x793B9B0", VA = "0x18793C5B0")]
	private void NABFLPPNLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7933AF0", Offset = "0x7932EF0", VA = "0x187933AF0")]
	private void BLDKFLCLOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7934FD0", Offset = "0x79343D0", VA = "0x187934FD0")]
	private static void EABPJADIMIK(Dictionary<DJOGFPFHELD, Material> POEFDNJEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7939490", Offset = "0x7938890", VA = "0x187939490")]
	private static void GAHIEKKGPLG(Dictionary<Renderer, NHDPAPIPOBA> BOCEEDBNFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7934620", Offset = "0x7933A20", VA = "0x187934620")]
	private void DGGBDLMOEJF(SkinnedMeshRenderer[] FPKMAPBAAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x793ED10", Offset = "0x793E110", VA = "0x18793ED10")]
	private void PHGJAEALBGE(SkinnedMeshRenderer INOCKJOPLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x793E020", Offset = "0x793D420", VA = "0x18793E020")]
	private void NOEIOOLDGPG(List<BFNBKBNLNFO> FDKDBADPHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x793AF30", Offset = "0x793A330", VA = "0x18793AF30")]
	private void JIJNMBKDGIG(Dictionary<string, PKCCCOBBKFK<Texture2D>> PPJCHOKILKM, bool EMBFKPKPOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7939300", Offset = "0x7938700", VA = "0x187939300")]
	private void FMDOMAPBBCH(Dictionary<string, List<DJOGFPFHELD>> PPJCHOKILKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7935510", Offset = "0x7934910", VA = "0x187935510")]
	private void EBIBLKELFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7933940", Offset = "0x7932D40", VA = "0x187933940")]
	private void BIABGHOCPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7934A10", Offset = "0x7933E10", VA = "0x187934A10")]
	private void DNNEJEPNNNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x793DD30", Offset = "0x793D130", VA = "0x18793DD30")]
	private void NGJMBBAFDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7933710", Offset = "0x7932B10", VA = "0x187933710")]
	private void BFHJLIPFPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7934780", Offset = "0x7933B80", VA = "0x187934780")]
	private void DLJIOJMCCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x79348D0", Offset = "0x7933CD0", VA = "0x1879348D0")]
	private void DMCCMLNGHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7932CA0", Offset = "0x79320A0", VA = "0x187932CA0")]
	private void ADKKMEGECGH(bool FEBPLELKLJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x793B0B0", Offset = "0x793A4B0", VA = "0x18793B0B0")]
	private void JKJNNJDHLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7939AA0", Offset = "0x7938EA0", VA = "0x187939AA0")]
	private void GMAJLGHJBLO(bool FEBPLELKLJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7939C10", Offset = "0x7939010", VA = "0x187939C10")]
	private void HGPKGAAGDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x793E700", Offset = "0x793DB00", VA = "0x18793E700")]
	private void OOIBPEPPCKP(Material OIINLIAGOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7932D80", Offset = "0x7932180", VA = "0x187932D80")]
	private void AGHDMNLCKMI(Material OIINLIAGOKI, Color LHKLEEDFBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x793E480", Offset = "0x793D880", VA = "0x18793E480")]
	private void OFMMNFNGNPA(Material OIINLIAGOKI, Color LHKLEEDFBJI, Color NGMKLFLFKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x79337A0", Offset = "0x7932BA0", VA = "0x1879337A0")]
	private void BHLINJMLOLD(Material OIINLIAGOKI, Color MMFEOPPFIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x793B6D0", Offset = "0x793AAD0", VA = "0x18793B6D0")]
	private void LAPHGJAPJPI(Material OIINLIAGOKI, Texture2D PNHEFBGDDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x793C3C0", Offset = "0x793B7C0", VA = "0x18793C3C0")]
	private void MKKJPOBILFM(Material OIINLIAGOKI, Texture CDAPPCNELAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7938250", Offset = "0x7937650", VA = "0x187938250")]
	private void FFFJKACIBGC(Action<NHDPAPIPOBA> BPHILPEOFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x79344A0", Offset = "0x79338A0", VA = "0x1879344A0")]
	private void DCIIJHOJJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x79395F0", Offset = "0x79389F0", VA = "0x1879395F0")]
	private void GAHONDCAIDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x793BC00", Offset = "0x793B000", VA = "0x18793BC00")]
	private void LJCBKJLMCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x79374E0", Offset = "0x79368E0", VA = "0x1879374E0")]
	public void EIPLCKLAEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x79373D0", Offset = "0x79367D0", VA = "0x1879373D0", Slot = "4")]
	private void EHBPKAMNKMO([In] FOIKDEKIGMP LBLAKCFMMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7933C30", Offset = "0x7933030", VA = "0x187933C30")]
	[CompilerGenerated]
	private DKABIBJEBOC CFOCAPMOFII(EDNGGAEGJMP OHELNHAJILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7937450", Offset = "0x7936850", VA = "0x187937450")]
	[CompilerGenerated]
	private void EINIBKODEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x793BFD0", Offset = "0x793B3D0", VA = "0x18793BFD0")]
	[CompilerGenerated]
	private void LLFMGJLGKLK(NHDPAPIPOBA PKMNDHNNFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7933BA0", Offset = "0x7932FA0", VA = "0x187933BA0")]
	[CompilerGenerated]
	private void CFBKKDOGJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7933AD0", Offset = "0x7932ED0", VA = "0x187933AD0")]
	[CompilerGenerated]
	private void BKLCKEINKFB(NHDPAPIPOBA PKMNDHNNFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7935660", Offset = "0x7934A60", VA = "0x187935660")]
	[CompilerGenerated]
	private void ECJAPDOEJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7934740", Offset = "0x7933B40", VA = "0x187934740")]
	[CompilerGenerated]
	private void DHOJEJCPBBG(NHDPAPIPOBA PKMNDHNNFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7939400", Offset = "0x7938800", VA = "0x187939400")]
	[CompilerGenerated]
	private void FPCJJDJKPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7937FD0", Offset = "0x79373D0", VA = "0x187937FD0")]
	[CompilerGenerated]
	private void FCBPMBIGIAF(NHDPAPIPOBA PKMNDHNNFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7933C80", Offset = "0x7933080", VA = "0x187933C80")]
	[CompilerGenerated]
	private void CJLINAJBCDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x793EC90", Offset = "0x793E090", VA = "0x18793EC90")]
	[CompilerGenerated]
	private void PCLPGEKAFAO(NHDPAPIPOBA PKMNDHNNFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7939370", Offset = "0x7938770", VA = "0x187939370")]
	[CompilerGenerated]
	private void FOFHHOACNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7932F00", Offset = "0x7932300", VA = "0x187932F00")]
	[CompilerGenerated]
	private void AJGCGNHFIAB(NHDPAPIPOBA PKMNDHNNFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7933B00", Offset = "0x7932F00", VA = "0x187933B00")]
	[CompilerGenerated]
	private void CACJGLJAKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7939A70", Offset = "0x7938E70", VA = "0x187939A70")]
	[CompilerGenerated]
	private void GGFKOGNEGFE(NHDPAPIPOBA PKMNDHNNFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x793E400", Offset = "0x793D800", VA = "0x18793E400")]
	[CompilerGenerated]
	private void OFCMHJAHJOA(KeyValuePair<string, PKCCCOBBKFK<Texture2D>> KFBKMJEPDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7939B80", Offset = "0x7938F80", VA = "0x187939B80")]
	[CompilerGenerated]
	private void HFDOADGEBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x793A420", Offset = "0x7939820", VA = "0x18793A420")]
	[CompilerGenerated]
	private void IJPOCPBCACG(NHDPAPIPOBA PKMNDHNNFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7933B90", Offset = "0x7932F90", VA = "0x187933B90")]
	[CompilerGenerated]
	private void CEJFAMOIINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x793B620", Offset = "0x793AA20", VA = "0x18793B620")]
	[CompilerGenerated]
	private void KMGFKNCCLNM(NHDPAPIPOBA PKMNDHNNFCP)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, CDMFGMGOJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Vector3? PBKKJONHHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool MLEFJEHLIKB;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7929FE0", Offset = "0x79293E0", VA = "0x187929FE0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x792A610", Offset = "0x7929A10", VA = "0x18792A610", Slot = "4")]
		public void UpdateController(float KMHBKELIILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xBF27A0", Offset = "0xBF1BA0", VA = "0x180BF27A0", Slot = "6")]
		public void SetEnabled(bool OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x792A0C0", Offset = "0x79294C0", VA = "0x18792A0C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x792AAD0", Offset = "0x7929ED0", VA = "0x18792AAD0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, CDMFGMGOJIF
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private const float FMCMAHFNJHM = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Vector3 PLDOBIAFGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 FEMGENHECLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private bool MLEFJEHLIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float KKJOHLOEJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private float CNGLDPPCMOD;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x792AE50", Offset = "0x792A250", VA = "0x18792AE50", Slot = "4")]
		public void UpdateController(float KMHBKELIILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xEDD960", Offset = "0xEDCD60", VA = "0x180EDD960", Slot = "6")]
		public void SetEnabled(bool OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x792AB70", Offset = "0x7929F70", VA = "0x18792AB70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x792B910", Offset = "0x792AD10", VA = "0x18792B910")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LFDJDONCOGP : GNHNBKMHFPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int KHMJGKGHIFO;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int IMPMNHJDAFP;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int HGEBCPCOPJO;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int NDKDKJPFFOH;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int DCLPCJIFGKH;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int CFODJECINEF;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int OHEHOBFLIID;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int PCBKBCAEMNI;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int FGIFLCCOKAN;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int GINHJPBHCBF;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int BKMHIJOLNPC;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int ANBPKMOAAHH;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int FBNJECALGAD;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int DFJINJFMJAD;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int DNBDGGEFNNB;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int GAGPKKMHOCE;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int GGDMCJOPNHL;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int OPKNKPIEKMP;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int APBLDCGKJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform HDMGCDIBIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform HIABIJBDEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform CBHDIMIOABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform MANKMDFGBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform CDDJHGHCGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform BEIKGGCHJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform LGAMAMOLCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private PNONPLLEHFK AFJPKKBELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Material PAOGLPPHOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private SkinnedMeshRenderer[] KMCFMHAOAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly List<Material> GNEEKAFHIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private IPJAKLGDELD AIHFFPPAABG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KFBDEOPEKLE OELDJAHNCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private IPJAKLGDELD DOPJOEJFKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x794C740", Offset = "0x794BB40", VA = "0x18794C740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PJBCMDOMBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x794B4A0", Offset = "0x794A8A0", VA = "0x18794B4A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x794CC00", Offset = "0x794C000", VA = "0x18794CC00")]
	public void ENMMELFAOHH([In] PNONPLLEHFK LMLFHIHEBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x794B620", Offset = "0x794AA20", VA = "0x18794B620")]
	public void LHEJIOCHCJJ([In] GLAINGLAKFD IJLCCNHPLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x794D070", Offset = "0x794C470", VA = "0x18794D070", Slot = "6")]
	public void IINLEAAMPGP(KBGOENLLBFA IPHELLNHANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x794D550", Offset = "0x794C950", VA = "0x18794D550")]
	private Vector2 KFCLLDCLGDJ(Vector2 FFEONHMGALK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x794B6C0", Offset = "0x794AAC0", VA = "0x18794B6C0")]
	public void CPNNMEHMHNG([In] IKMDDOEMNLG IJLCCNHPLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x794C830", Offset = "0x794BC30", VA = "0x18794C830")]
	private void EFDNPJGIHMC(OGLMLNLEBHG JCCDHJBDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x794CCD0", Offset = "0x794C0D0", VA = "0x18794CCD0")]
	private void EOIBFECIJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x794C7C0", Offset = "0x794BBC0", VA = "0x18794C7C0")]
	private void GOMBAODCIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x794C7C0", Offset = "0x794BBC0", VA = "0x18794C7C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x794D950", Offset = "0x794CD50", VA = "0x18794D950")]
	public LFDJDONCOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x794B620", Offset = "0x794AA20", VA = "0x18794B620", Slot = "5")]
	private void CKGAKBANBLN([In] GLAINGLAKFD IJLCCNHPLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x794B490", Offset = "0x794A890", VA = "0x18794B490", Slot = "7")]
	private void ADDIHBNGNID([In] IKMDDOEMNLG IJLCCNHPLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x794D060", Offset = "0x794C460", VA = "0x18794D060")]
	[CompilerGenerated]
	internal static float IFLHFOMLHFM(float OOEMJLHLIHJ, float OEKMAIKEGFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x794C650", Offset = "0x794BA50", VA = "0x18794C650")]
	[CompilerGenerated]
	internal static void DBPCIKOLHDN(Vector2 BILKLDHMHOA, Vector2 GMPPGABKKFO, Vector2 LLBNOFGPNDN, Vector2 JLCBKIPFKML, Vector2 CBHAMKJGEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x794B400", Offset = "0x794A800", VA = "0x18794B400")]
	[CompilerGenerated]
	internal static (float, float) ACEONEPBMEE(float BHEPDFLNELB)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x794D5B0", Offset = "0x794C9B0", VA = "0x18794D5B0")]
	[CompilerGenerated]
	internal static Vector4 MPNKEGFOKLN(Vector2 KBPOHLLNAIG, Vector2 KPABPLHPKDL)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, CDMFGMGOJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private float KKJOHLOEJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool MLEFJEHLIKB;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7940AD0", Offset = "0x793FED0", VA = "0x187940AD0", Slot = "4")]
		public void UpdateController(float KMHBKELIILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1603BA0", Offset = "0x1602FA0", VA = "0x181603BA0", Slot = "6")]
		public void SetEnabled(bool OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7941340", Offset = "0x7940740", VA = "0x187941340")]
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
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x79413E0", Offset = "0x79407E0", VA = "0x1879413E0")]
		public void HGEPFBBIJLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7941370", Offset = "0x7940770", VA = "0x187941370")]
		public int GGMACKPDIOH(int GBKINKICKNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LAKJPCFBEPA : NFNBPKODEIF
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x794AAE0", Offset = "0x7949EE0", VA = "0x18794AAE0", Slot = "22")]
	public override float HOGMHNBOCON()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x794AB30", Offset = "0x7949F30", VA = "0x18794AB30")]
	public LAKJPCFBEPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NFNBPKODEIF : OHNJHAOHDGP
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int KIEICILDDIB;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int EEPPPKPPFJK;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int EOKLMMJPGDN;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int EDHEFNFELDF;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int CABAPHFNMAL;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int PKMLGADEOAH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int BJHKOLCDNFO;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int[] OHIHKLIJCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private FLJPPGGDPCK AFJPKKBELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private GIPKBMEGECK KDBFHEIHNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private int ANBBLABMEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private float IIKNBDNIKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected Animator EGIOLJKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected bool NLODIEKFAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration LCKDJCOFDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int AEEAMAFIDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int PFHLGIPDGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int CCJEPHLPIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool HOBPPMBDEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NFFIGFBDIBD OCCCHJEFHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int AHDKIFAFKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float GEMFOJNCEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings MIOOJMCNCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private LOHMIPEBFLA HOLJNKIIALI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform GGCCEFHNBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 FIKBMFIOHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1617B80", Offset = "0x1616F80", VA = "0x181617B80")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1617B70", Offset = "0x1616F70", VA = "0x181617B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion FHPCKGGKDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xCDFEF0", Offset = "0xCDF2F0", VA = "0x180CDFEF0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xEE8B30", Offset = "0xEE7F30", VA = "0x180EE8B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CDFPABNNKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x794EFA0", Offset = "0x794E3A0", VA = "0x18794EFA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x794F630", Offset = "0x794EA30", VA = "0x18794F630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Vector3 JPMJNLLDMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x794F670", Offset = "0x794EA70", VA = "0x18794F670", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x794F370", Offset = "0x794E770", VA = "0x18794F370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Quaternion GDLJDGGDAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x794F1B0", Offset = "0x794E5B0", VA = "0x18794F1B0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x794F660", Offset = "0x794EA60", VA = "0x18794F660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KGMJJNNLLGP PIDKAPGGLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB4F1A0", Offset = "0xB4E5A0", VA = "0x180B4F1A0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(KGMJJNNLLGP);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xB4EA80", Offset = "0xB4DE80", VA = "0x180B4EA80", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KGMJJNNLLGP MKEPDIFPEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x24038E0", Offset = "0x2402CE0", VA = "0x1824038E0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(KGMJJNNLLGP);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2403130", Offset = "0x2402530", VA = "0x182403130", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float GCBLMEFACNI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x14170E0", Offset = "0x14164E0", VA = "0x1814170E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xED0FC0", Offset = "0xED03C0", VA = "0x180ED0FC0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OFHNNENMIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x794F010", Offset = "0x794E410", VA = "0x18794F010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HJAEENDKMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x794F360", Offset = "0x794E760", VA = "0x18794F360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LEMADPDPBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x794F3E0", Offset = "0x794E7E0", VA = "0x18794F3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool FIDJKGDDNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x794EF90", Offset = "0x794E390", VA = "0x18794EF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x794F1C0", Offset = "0x794E5C0", VA = "0x18794F1C0", Slot = "21")]
	public void ENMMELFAOHH(FLJPPGGDPCK LMLFHIHEBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x794EF40", Offset = "0x794E340", VA = "0x18794EF40")]
	public void AHEPLALHDLM(GIPKBMEGECK AHDMONMOBJF, AvatarHandDisplaySettings MMJOHIFPIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x794EEB0", Offset = "0x794E2B0", VA = "0x18794EEB0", Slot = "12")]
	public void ADOBMHOMKPA(bool DEFBJFIEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x794F6A0", Offset = "0x794EAA0", VA = "0x18794F6A0", Slot = "11")]
	public void OMIKDBPIGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x14170E0", Offset = "0x14164E0", VA = "0x1814170E0", Slot = "22")]
	public virtual float HOGMHNBOCON()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x794F020", Offset = "0x794E420", VA = "0x18794F020")]
	private int DBENKJCEGCD(KGMJJNNLLGP FKNMKMGBGGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x794F470", Offset = "0x794E870", VA = "0x18794F470")]
	private void LAOIMKBEDHM(int LIGAOHJHECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x794F3F0", Offset = "0x794E7F0", VA = "0x18794F3F0", Slot = "13")]
	public bool HOMGPDADFGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x794F690", Offset = "0x794EA90", VA = "0x18794F690", Slot = "14")]
	public bool OFLHFMOKPPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x794F420", Offset = "0x794E820", VA = "0x18794F420")]
	private KGMJJNNLLGP JPIOBLLOOPM()
	{
		return default(KGMJJNNLLGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C890", Offset = "0x1D0BC90", VA = "0x181D0C890", Slot = "15")]
	public void LDJELOLENMA(bool DEFBJFIEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x794EFD0", Offset = "0x794E3D0", VA = "0x18794EFD0", Slot = "10")]
	public void CDPKDAMOICB(int LIGAOHJHECO, float GJFJBMGOCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x794FA10", Offset = "0x794EE10", VA = "0x18794FA10", Slot = "8")]
	public void PNBEAMFCPEI(NFFIGFBDIBD FGCBFMGNEPC, bool KOIDOLHMLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x794F410", Offset = "0x794E810", VA = "0x18794F410", Slot = "9")]
	public void IBIDMCDIPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x794F390", Offset = "0x794E790", VA = "0x18794F390", Slot = "16")]
	public void HJNGHMPLGBK(Transform GEFLCBDBKHP, Vector3 LNDLINIPIHN, Quaternion JGGIJBBEIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x794FD00", Offset = "0x794F100", VA = "0x18794FD00")]
	public NFNBPKODEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EFMCDPJBIJP : EDNGGAEGJMP
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DCJKEODDNEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public EFMCDPJBIJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public List<BFNBKBNLNFO> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<BFNBKBNLNFO> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PKCCCOBBKFK<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public PKCCCOBBKFK<FLIIOCPIKNF> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DCJKEODDNEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7943A50", Offset = "0x7942E50", VA = "0x187943A50")]
		internal DKABIBJEBOC DMFIOBEOCDB(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public NDKAGBMMFHK EPBDDEIBIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public FLIIOCPIKNF ONBOBKFKLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private PKCCCOBBKFK<FLIIOCPIKNF> BBALDCMPEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private PKCCCOBBKFK<Material[]> CJGKDDDACLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Material[] DDLGGCBIMNI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool ODIAIKPPNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FA0", Offset = "0x9F73A0", VA = "0x1809F7FA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D20", Offset = "0x9F7120", VA = "0x1809F7D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MOJPHFECLPK.JODCMICJPOD HHNKKBFGLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
		[CompilerGenerated]
		get
		{
			return default(MOJPHFECLPK.JODCMICJPOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9D9490", Offset = "0x9D8890", VA = "0x1809D9490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x79454D0", Offset = "0x79448D0", VA = "0x1879454D0")]
	public EFMCDPJBIJP(MJGMDPCOPJP GKMENOPLCMG, NDKAGBMMFHK KAOONLABEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7944FC0", Offset = "0x79443C0", VA = "0x187944FC0", Slot = "6")]
	public override DKABIBJEBOC PNJDLGBPDCA(List<BFNBKBNLNFO> PFMMCFLAGAI, List<BFNBKBNLNFO> OHDDJBMLHLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7944510", Offset = "0x7943910", VA = "0x187944510")]
	public DKABIBJEBOC CALBOINICPF(List<BFNBKBNLNFO> PFMMCFLAGAI, List<BFNBKBNLNFO> OHDDJBMLHLM, PKCCCOBBKFK<Material[]> CJGKDDDACLL, [Optional] PKCCCOBBKFK<FLIIOCPIKNF> MLCJEJEGGLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7944180", Offset = "0x7943580", VA = "0x187944180")]
	public (PKCCCOBBKFK<Material[]>, PKCCCOBBKFK<FLIIOCPIKNF>) BKPEMOLGNOI(List<BFNBKBNLNFO> PFMMCFLAGAI, List<BFNBKBNLNFO> OHDDJBMLHLM)
	{
		return default((PKCCCOBBKFK<Material[]>, PKCCCOBBKFK<FLIIOCPIKNF>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7944820", Offset = "0x7943C20", VA = "0x187944820", Slot = "7")]
	public override EFDMKOADJOE DDMBFKNOHID(uint BKCGKLBAHGO, AvatarSkinnedMeshBoneOrderRemapsData LBMBMFENBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7944CC0", Offset = "0x79440C0", VA = "0x187944CC0")]
	public EFDMKOADJOE DPOGGGJBOBM(GameObject MABMIHHHDOA, uint BKCGKLBAHGO, bool CPHBMPPDIAI, bool DJHEFJCGCDH, AvatarSkinnedMeshBoneOrderRemapsData LBMBMFENBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7944950", Offset = "0x7943D50", VA = "0x187944950")]
	public static bool DMBOOHNPDBM(Renderer[] FPKMAPBAAOK, string BDCOFNOBICF, [Out] Renderer JLDCHEAJBAN, [Out] Renderer ELILKBIGGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7945480", Offset = "0x7944880", VA = "0x187945480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7944ED0", Offset = "0x79442D0", VA = "0x187944ED0")]
	private (PKCCCOBBKFK<FLIIOCPIKNF>, PKCCCOBBKFK<Material[]>) KHLOMDCAEPK()
	{
		return default((PKCCCOBBKFK<FLIIOCPIKNF>, PKCCCOBBKFK<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7944FA0", Offset = "0x79443A0", VA = "0x187944FA0")]
	[CompilerGenerated]
	private void OPKKNKKEEPH(FLIIOCPIKNF APLCGCDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9CD820", Offset = "0x9CCC20", VA = "0x1809CD820")]
	[CompilerGenerated]
	private void KJPOAILGBJB(Material[] APLCGCDLEGH)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, CDMFGMGOJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Vector3 PLDOBIAFGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 MIDCLEDJAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 PGONOHEMLHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Matrix4x4 KOGEGMOKEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private bool MLEFJEHLIKB;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7941970", Offset = "0x7940D70", VA = "0x187941970", Slot = "4")]
		public void UpdateController(float KMHBKELIILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7941960", Offset = "0x7940D60", VA = "0x187941960", Slot = "6")]
		public void SetEnabled(bool OOEMJLHLIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7941500", Offset = "0x7940900", VA = "0x187941500")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7942030", Offset = "0x7941430", VA = "0x187942030")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[IJOMDGJLMLC]
public struct GNMJNEOOCHF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[ReadOnly]
	public EKGNDFLNLFD BEJAACOABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public int KKCBFLPOOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public JDGMFIBEFHH OHILHMBMFDH;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7947830", Offset = "0x7946C30", VA = "0x187947830", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[IJOMDGJLMLC]
public struct JDGMFIBEFHH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector3> GOPKMGOJHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> OJBFBCFKCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector4> JDKPOCGANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> ODBEDFLMPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> JCBMLEDLIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> ECNBACPPPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> BOJDMMAMMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Color> MKGOODAJNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<int> PAIIAPCMBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> IBPAIGDEBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<int> INMBHAFJFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> FEIPIPBPNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> JBELGJMMEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> ABBHOMOKCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> DBGLMFMOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<BoneWeight> EJEEJMEEEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NativeArray<int> OPJDOLNIGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private bool IPHKKJNBPKG;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int DNFJPKILBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x79493E0", Offset = "0x79487E0", VA = "0x1879493E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7949570", Offset = "0x7948970", VA = "0x187949570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int FGONIPEEEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x79493D0", Offset = "0x79487D0", VA = "0x1879493D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7949A40", Offset = "0x7948E40", VA = "0x187949A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int DBLGOKMADAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x79491C0", Offset = "0x79485C0", VA = "0x1879491C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7949580", Offset = "0x7948980", VA = "0x187949580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7949C10", Offset = "0x7949010", VA = "0x187949C10")]
	public JDGMFIBEFHH(int LMLEAMKIKHE, int DPCHKOFINNA, int LJPDJOJABNA, int HILAGJKHOEB, Allocator LMMGDELCIGC, int INHPLKCNKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7949590", Offset = "0x7948990", VA = "0x187949590")]
	public void MMCKFHCJJCA(int COPLIEINKOF, Vector3 LLEKGMDPLMK, Vector3 LDMILEIDPGI, Vector4 DEEHPBDAIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7949A70", Offset = "0x7948E70", VA = "0x187949A70")]
	public void POLGEODCNAK(int COPLIEINKOF, BoneWeight JIHIAPAPLBL, NativeSlice<byte> FOPDBNEDBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7949550", Offset = "0x7948950", VA = "0x187949550")]
	public Color IIPCMGIIAOP(int COPLIEINKOF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7949A50", Offset = "0x7948E50", VA = "0x187949A50")]
	public void PGMBEALILMD(int COPLIEINKOF, Color NEIELBLPLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x79491D0", Offset = "0x79485D0", VA = "0x1879491D0")]
	public void DMEKPPJIHOA(byte KONJFHKABGH, int COPLIEINKOF, Vector2 OMHKKBGGNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7949600", Offset = "0x7948A00", VA = "0x187949600")]
	public void NKFABIBGDON(int COPLIEINKOF, int MHFNAPNEJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7949A10", Offset = "0x7948E10", VA = "0x187949A10")]
	public bool OHGKJJFBHMI(int KONJFHKABGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7949480", Offset = "0x7948880", VA = "0x187949480")]
	public void IEFPDHBJKBL(int JKCFIEGDEPM, int IALPEJIGIPD, int CFKBLDHNBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7949610", Offset = "0x7948A10", VA = "0x187949610")]
	public int[] NMGLANBBGFL(int JKCFIEGDEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x79493F0", Offset = "0x79487F0", VA = "0x1879493F0")]
	private NativeSlice<int> FNDGNEHBIOA(int JKCFIEGDEPM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7949220", Offset = "0x7948620", VA = "0x187949220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x79496C0", Offset = "0x7948AC0", VA = "0x1879496C0")]
	public Mesh NOOINEIDNCN([Optional] string OCHFDEHDFLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[IJOMDGJLMLC]
[DefaultMember("Item")]
[NativeContainer]
public struct EKGNDFLNLFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector3> GOPKMGOJHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> OJBFBCFKCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector4> JDKPOCGANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> ODBEDFLMPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> JCBMLEDLIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> ECNBACPPPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> BOJDMMAMMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Color> MKGOODAJNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> CNFACDKFKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> INCCHLADNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> KPPHPLAPKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> MKEACNOFGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<bool> HBLMKDAAMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<int> GJHJCCOEDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> JHPJOIGODPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<BoneWeight> CCDILOBBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<Matrix4x4> PBHCIPLDAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<long> PJFIJINDMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<byte> LGPGGFJMCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<int> GEDGEHGHGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> EHBGNMNDBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<sbyte> LCNGIMFEEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<byte> GFPJLAGJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private NativeArray<int> PPGDEOGMPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private bool IPHKKJNBPKG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int KLMOMHCPIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xD736B0", Offset = "0xD72AB0", VA = "0x180D736B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int DFKBKGBIJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xBF51B0", Offset = "0xBF45B0", VA = "0x180BF51B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int HBACKHBILEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7945E50", Offset = "0x7945250", VA = "0x187945E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int LAINMMEIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x79458F0", Offset = "0x7944CF0", VA = "0x1879458F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x79457F0", Offset = "0x7944BF0", VA = "0x1879457F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int DNFJPKILBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x79457E0", Offset = "0x7944BE0", VA = "0x1879457E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7945800", Offset = "0x7944C00", VA = "0x187945800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int PDGEFKKAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7945560", Offset = "0x7944960", VA = "0x187945560")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7945900", Offset = "0x7944D00", VA = "0x187945900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public MMLHJADAHDP FKKGCCJCKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7945550", Offset = "0x7944950", VA = "0x187945550")]
		get
		{
			return default(MMLHJADAHDP);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7945540", Offset = "0x7944940", VA = "0x187945540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public byte GNECOBFPNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7945E40", Offset = "0x7945240", VA = "0x187945E40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x79458E0", Offset = "0x7944CE0", VA = "0x1879458E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public EEBEPCBOEPJ LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7945910", Offset = "0x7944D10", VA = "0x187945910")]
		get
		{
			return default(EEBEPCBOEPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7945E80", Offset = "0x7945280", VA = "0x187945E80")]
	public EKGNDFLNLFD(IList<Mesh> GDPIDINCOGJ, IList<Matrix4x4> BPKKINFDFAC, IList<bool> HBLMKDAAMGN, byte JFLLIEFLOAN, IList<byte[]> PKGJFPJAOHE, IList<long> EALCLADCLDA, IList<bool> DNHNIAMOMMK, IList<int> GJHJCCOEDJM, IList<int> FDFEKECPEML, IList<int> JPCMALDEIJF, Allocator LMMGDELCIGC, MMLHJADAHDP FDLKGJPBCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7945810", Offset = "0x7944C10", VA = "0x187945810")]
	public JDGMFIBEFHH JOBAKKENCDI(Allocator LMMGDELCIGC)
	{
		return default(JDGMFIBEFHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7945570", Offset = "0x7944970", VA = "0x187945570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[IJOMDGJLMLC]
public class ONCAGEFCCGG : FPHKBKCKEFI
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7952960", Offset = "0x7951D60", VA = "0x187952960")]
	public EKGNDFLNLFD FKNMKLFPPLJ()
	{
		return default(EKGNDFLNLFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x792FBB0", Offset = "0x792EFB0", VA = "0x18792FBB0")]
	public ONCAGEFCCGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EEBEPCBOEPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector3> GOPKMGOJHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> OJBFBCFKCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector4> JDKPOCGANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> ODBEDFLMPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> JCBMLEDLIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> ECNBACPPPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> BOJDMMAMMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Color> MKGOODAJNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<int> KPHHCJEFNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> MKEACNOFGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<BoneWeight> CCDILOBBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<byte> PPFNLNBKDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public int GEOGABLDMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public Matrix4x4 KMDNHBFFBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public long BBHJOFLIMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<byte> FOPDBNEDBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public bool HGFPKPOCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public int EPJJMBLOJGL;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct DJOGFPFHELD : IEquatable<DJOGFPFHELD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly Material KGJJNNOKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly CACMIOCCJGJ OLGHOLDPHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly OHPFNPNDHLJ MAMFCMFLPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly MJGMDPCOPJP MGIEBOLKHHO;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x79440D0", Offset = "0x79434D0", VA = "0x1879440D0")]
	public DJOGFPFHELD(Material FFHFAEDNMPG, CACMIOCCJGJ DMAAMPLEDGG, OHPFNPNDHLJ BDIBLODBLEH, MJGMDPCOPJP DFKGNLKKCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7943EA0", Offset = "0x79432A0", VA = "0x187943EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7943C90", Offset = "0x7943090", VA = "0x187943C90", Slot = "4")]
	public bool Equals(DJOGFPFHELD DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7943D10", Offset = "0x7943110", VA = "0x187943D10", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7943E00", Offset = "0x7943200", VA = "0x187943E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, JKBKGMHAJBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		[Header("Configuration")]
		private LOHMIPEBFLA avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private CKKICPFEDGL AJHJLCJJKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private GNHNBKMHFPD HIHJEFNEKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private OHNJHAOHDGP JJJKKIKLIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private OHNJHAOHDGP KAACODCEGLG;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public CKKICPFEDGL JFCOOEMAEGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7943050", Offset = "0x7942450", VA = "0x187943050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public GNHNBKMHFPD CHEAINDHKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x79430A0", Offset = "0x79424A0", VA = "0x1879430A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public OHNJHAOHDGP JGINNIICJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x79430F0", Offset = "0x79424F0", VA = "0x1879430F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public OHNJHAOHDGP IHCEIPDDAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7943140", Offset = "0x7942540", VA = "0x187943140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Transform MPGLMLAPHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7943190", Offset = "0x7942590", VA = "0x187943190", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public LOHMIPEBFLA PDBNGGNFIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9D9640", Offset = "0x9D8A40", VA = "0x1809D9640", Slot = "12")]
			get
			{
				return default(LOHMIPEBFLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7942670", Offset = "0x7941A70", VA = "0x187942670")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7942EB0", Offset = "0x79422B0", VA = "0x187942EB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7942A10", Offset = "0x7941E10", VA = "0x187942A10", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7942EB0", Offset = "0x79422B0", VA = "0x187942EB0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x79426E0", Offset = "0x7941AE0", VA = "0x1879426E0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7942F60", Offset = "0x7942360", VA = "0x187942F60")]
		public void UpdatePostIKAnimControllers(float KMHBKELIILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7942A70", Offset = "0x7941E70", VA = "0x187942A70")]
		private void MGGFNALKLBN(GameObject KLANNNFBLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7942B00", Offset = "0x7941F00", VA = "0x187942B00")]
		private CKKICPFEDGL NMLILMBBOAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x79422D0", Offset = "0x79416D0", VA = "0x1879422D0")]
		private GNHNBKMHFPD ANJJNNHEGHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7942040", Offset = "0x7941440", VA = "0x187942040")]
		private OHNJHAOHDGP ALAOENBEJAN(DFGGMLJPKKG IGIJOOMGCOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7943040", Offset = "0x7942440", VA = "0x187943040")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class NHDPAPIPOBA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private MaterialPropertyBlock PGKMGNMBNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? JAFAGFCIBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color? BBCDLFBHBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? BLHNJPAFIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? FGGDFJJHBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color KEOEONCECEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color EMEEGAGIJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color NBBJALCMCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Texture2D ACKHLIEFJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Texture2D DLOANABCOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private Dictionary<DJOGFPFHELD, int> FBPFHNCEAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private CACMIOCCJGJ[] GHFJCMHHMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private OHPFNPNDHLJ[] IHFINAKNPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] JEAFMLIJKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] IHBFMBEEMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] DFKGPLDMHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] LEAKNFDNNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] DKHJOPHANIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] ENBMPAFCBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private List<Texture2D> KCKDCKPEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] MGFBALIPLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private List<Texture2D> FINHJJBOLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private float[] JJOLCPJBGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] JNEOOAGIIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] DFAILBMLPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public float[] CGILFKFMGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private List<Texture2D> DBFKIDJGNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] HMBJECGIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private List<Texture2D> CCFHAEMMGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector4[] NGJOCAILELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] IMIGLBLPAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector4[] FPPPKOPEIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public float[] CKBLMHBAIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray CPJMFNGLHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public Texture2DArray MPDBBKGHPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Texture2DArray IKIGJGEGDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray CPHPPPGLEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private bool JKFFHHCAEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private int BOELKAGBLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private Vector2? HAPDHBGEANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private TextureFormat BJIBMNIBMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private Vector2? EKCNFJJCLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private TextureFormat KABGMLGDNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private Vector2? EAGGAJGHHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private TextureFormat BLANAKNINJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private Vector2? ALHKJMFFEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private TextureFormat GBIOAAAGLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private bool FJEDLGBMFFE;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int JMEBCGMDEMB;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int HBCFCKKCEEH;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int HBPOLMGFNGO;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int LFGJPODMFNF;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int BINPECHGCKD;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int DLBPKEEGDNE;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int EJCKNHFMDEI;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int ADIKIPJLOMP;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int IIHOBCCBFLE;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int NDONDDDFIPK;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int MNKGADJHKHO;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int IJMJEPHNEOB;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int MLGPKJALGPN;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int AGHBDEJPJEO;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int BIAMKAAIKBM;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int FOFCMCFAHPP;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int BANPHIIDHEK;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int OECDAJNMHAI;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int CILLOPGHDMB;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int DPOJGGFHPIF;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x79523B0", Offset = "0x79517B0", VA = "0x1879523B0")]
	private NHDPAPIPOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x79528A0", Offset = "0x7951CA0", VA = "0x1879528A0")]
	public NHDPAPIPOBA(Color KDJOEKHGMNE, Color NALECDPAKHG, Color PDLGDFPPDGM, Color? BPNPIIENIKA, Color? BDBGCLLALBM, Color? CFHCLNAMHED, Texture2D HKLDHLAHOIL, Texture2D MHAAADILEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7950E70", Offset = "0x7950270", VA = "0x187950E70")]
	internal int JGGPJDKAKHO(Material EHIJCMLCEML, CACMIOCCJGJ DMAAMPLEDGG, OHPFNPNDHLJ BDIBLODBLEH, MJGMDPCOPJP DFKGNLKKCJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7950DE0", Offset = "0x79501E0", VA = "0x187950DE0")]
	private int JGGPJDKAKHO(DJOGFPFHELD IICGAABOENK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x79500C0", Offset = "0x794F4C0", VA = "0x1879500C0")]
	internal int ICNIMEGMLHC(Material EHIJCMLCEML, Color MMFEOPPFIJC, Color DKHCMLFNJEN, Color FPFPBCCJFCL, Color LGHIHINJDEE, Color NMAMGFOFBFB, Texture2D PJLJCIAEFGC, Vector4 ADHCHIBLLHJ, Texture2D BFBMPPNMBLF, Vector4 PKOIKAHINAK, float PNMPMNMKMCP, float HHPMDCKPABF, Texture2D LPPJEOGLGDA, Vector4 GFAJEPCEADN, float BOCPBLLCIIK, Texture2D LDLIPGGCDKF, Color CAOIJFCOMKI, Vector4 PHFLEBNDJHJ, CACMIOCCJGJ DMAAMPLEDGG, OHPFNPNDHLJ BDIBLODBLEH, MJGMDPCOPJP DFKGNLKKCJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7950F60", Offset = "0x7950360", VA = "0x187950F60")]
	private void JKJLJPOEKDE(List<Texture2D> KCKDCKPEELN, [Out] Texture2DArray ILHNDLGECKL, [Out] Texture2DArray CINMKNGFCMM, [Out] Texture2DArray EIHHBNCCDLC, [Out] Texture2DArray LNMJIAEHABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x79511D0", Offset = "0x79505D0", VA = "0x1879511D0")]
	public void OFKAHCJDPDM(Shader EHCDALJKCGG, Renderer JBNKAEBEMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7951320", Offset = "0x7950720", VA = "0x187951320")]
	private void OJMIIFOCELA(Shader EHCDALJKCGG, Renderer JBNKAEBEMAK, int FKJNLCMBGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x794FD20", Offset = "0x794F120", VA = "0x18794FD20")]
	private Color CBHLCELKJBD(Color MBGJOKEJAPA, CACMIOCCJGJ PBAGJLPCJPH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7950C90", Offset = "0x7950090", VA = "0x187950C90")]
	private Color IPBHGKHKBKA(Color JNGDEKAAOMM, CACMIOCCJGJ PBAGJLPCJPH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x794FF60", Offset = "0x794F360", VA = "0x18794FF60")]
	private bool FIMKAOFOPKH(Texture2D JPLHGDEIAMC, OHPFNPNDHLJ GEKBJBBGKGK, [Out] Texture2D LNIJGAJNFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7951120", Offset = "0x7950520", VA = "0x187951120")]
	private void NHPJAEAOKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x794FF20", Offset = "0x794F320", VA = "0x18794FF20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class EDNGGAEGJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public readonly MJGMDPCOPJP HOFMJDPMKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	protected bool LIKFAAAPKFA;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool KAMPPGNILPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xC461D0", Offset = "0xC455D0", VA = "0x180C461D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xC461E0", Offset = "0xC455E0", VA = "0x180C461E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool OELBCCIMALL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xC46900", Offset = "0xC45D00", VA = "0x180C46900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xC468F0", Offset = "0xC45CF0", VA = "0x180C468F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public virtual MOJPHFECLPK.JODCMICJPOD BBHJOFLIMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MOJPHFECLPK.JODCMICJPOD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC35DD0", Offset = "0xC351D0", VA = "0x180C35DD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool DNKIEJLGKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1253B10", Offset = "0x1252F10", VA = "0x181253B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool BDIAJDICNFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7944140", Offset = "0x7943540", VA = "0x187944140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool OADHPANHICP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7944110", Offset = "0x7943510", VA = "0x187944110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool JMGHGMIGAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7944120", Offset = "0x7943520", VA = "0x187944120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7944150", Offset = "0x7943550", VA = "0x187944150")]
	protected EDNGGAEGJMP(MJGMDPCOPJP GKMENOPLCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract DKABIBJEBOC PNJDLGBPDCA(List<BFNBKBNLNFO> PFMMCFLAGAI, List<BFNBKBNLNFO> OHDDJBMLHLM);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract EFDMKOADJOE DDMBFKNOHID(uint BKCGKLBAHGO, AvatarSkinnedMeshBoneOrderRemapsData LBMBMFENBLK);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KNHPBLIDJMP : BOGGNALBEDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private AvatarSkinAssetItem APLFIMALDBA;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x794A9E0", Offset = "0x7949DE0", VA = "0x18794A9E0")]
	public KNHPBLIDJMP(AvatarSkinAssetItem GDBMCGJFFAD, AvatarSkinAssetItem.AMNFGBEAJLI KJOKBHGGNJC, MJGMDPCOPJP DFKGNLKKCJM, [Optional] CEIANKIDECD? PAGDHJNGOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x794A770", Offset = "0x7949B70", VA = "0x18794A770", Slot = "6")]
	public override DKABIBJEBOC PNJDLGBPDCA(List<BFNBKBNLNFO> PFMMCFLAGAI, List<BFNBKBNLNFO> OHDDJBMLHLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PECALOELNPI
{
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static readonly int[] AIEFGGIKOLH;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static readonly int[] CDPMDALCBMA;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static int[] CCHDEJNJDED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x79538B0", Offset = "0x7952CB0", VA = "0x1879538B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7953820", Offset = "0x7952C20", VA = "0x187953820")]
	public static int[] CKIHKPMFPLM(bool EPAILCOAFID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7953910", Offset = "0x7952D10", VA = "0x187953910")]
	public static int IOPPJMDPFNI(BAJKLLBGNIN EFLJLCONNGP, bool EPAILCOAFID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7953900", Offset = "0x7952D00", VA = "0x187953900")]
	private static int GPLDEEIKBMD(BAJKLLBGNIN EFLJLCONNGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x79539A0", Offset = "0x7952DA0", VA = "0x1879539A0")]
	private static int MANMCPLCJKK(BAJKLLBGNIN EFLJLCONNGP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BNJAMDGKGPC
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DABOCLMLBMG : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private LCENDOCODMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public DABOCLMLBMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x11E7B80", Offset = "0x11E6F80", VA = "0x1811E7B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7943A00", Offset = "0x7942E00", VA = "0x187943A00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	public static void DOOMLLMFIFH(string FBLIJIPJKFJ, int BKCGKLBAHGO, long NCFELJOBANB, long JFOCPKKDJHO, long GGHJMOGIOLM, long JHPOFNDCDFC, long DBLCMNHNIIN, long AEDOEBCKDDE, long GMOJPJHEHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7943220", Offset = "0x7942620", VA = "0x187943220")]
	public static DGHHBAELICH FGJABJHOOIH(JobHandle HAEDDJDDHPP, bool ALKNMLBBDPP, bool MEFGCBCAIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x79431B0", Offset = "0x79425B0", VA = "0x1879431B0")]
	[IteratorStateMachine(typeof(DABOCLMLBMG))]
	private static IEnumerator<LCENDOCODMB> CEBLDNJBPOD(JobHandle PAOMPCHHBKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MCEJCCGBJCN
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum GEGKIFEFCLL
	{
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int JOMGGEJMECD;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int GECEEOANJAL;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int BPMGKHHHNFE;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int GLEAKDGECNI;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int IEKBAAHHMMC;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int CLOIPBDFOFG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int AOONGOPDNLG;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int JBMMGBIENBK;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x794DB50", Offset = "0x794CF50", VA = "0x18794DB50")]
	public static bool GKECHCMFELG(Material FFHFAEDNMPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x794DA90", Offset = "0x794CE90", VA = "0x18794DA90")]
	public static bool AMKFLCFCKGO(Material FFHFAEDNMPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BOGGNALBEDP : EDNGGAEGJMP
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class AIDCFBBPIOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public PKCCCOBBKFK<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public BOGGNALBEDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AIDCFBBPIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x79406F0", Offset = "0x793FAF0", VA = "0x1879406F0")]
		internal void EDGJNNBLJMM(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x79405B0", Offset = "0x793F9B0", VA = "0x1879405B0")]
		internal void DMFIOBEOCDB(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	protected AvatarSkinAssetItem PADLDDMJNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	protected Material[] LNKOCDPFCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private readonly AvatarSkinAssetItem.AMNFGBEAJLI OPGGBPPMIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly AssetReference DFGEFFDBPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private readonly CEIANKIDECD? EFGGEEOPOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private SkinnedMeshRenderer[] LKNFINOMIHJ;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public override MOJPHFECLPK.JODCMICJPOD BBHJOFLIMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MOJPHFECLPK.JODCMICJPOD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9C9470", Offset = "0x9C8870", VA = "0x1809C9470", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x79437B0", Offset = "0x7942BB0", VA = "0x1879437B0")]
	public BOGGNALBEDP(AvatarSkinAssetItem.AMNFGBEAJLI KJOKBHGGNJC, AssetReference GAFIHHIEKOF, Material NHOKJBJIMIF, MJGMDPCOPJP DFKGNLKKCJM, MOJPHFECLPK.JODCMICJPOD OFONDBHHPEO = (MOJPHFECLPK.JODCMICJPOD)0L, [Optional] CEIANKIDECD? PAGDHJNGOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x79438E0", Offset = "0x7942CE0", VA = "0x1879438E0")]
	public BOGGNALBEDP(AvatarSkinAssetItem.AMNFGBEAJLI KJOKBHGGNJC, AssetReference GAFIHHIEKOF, Material NHOKJBJIMIF, MOJPHFECLPK.JODCMICJPOD OFONDBHHPEO = (MOJPHFECLPK.JODCMICJPOD)0L, [Optional] CEIANKIDECD? PAGDHJNGOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7943570", Offset = "0x7942970", VA = "0x187943570", Slot = "6")]
	public override DKABIBJEBOC PNJDLGBPDCA(List<BFNBKBNLNFO> PFMMCFLAGAI, List<BFNBKBNLNFO> OHDDJBMLHLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7943310", Offset = "0x7942710", VA = "0x187943310", Slot = "7")]
	public override EFDMKOADJOE DDMBFKNOHID(uint BKCGKLBAHGO, AvatarSkinnedMeshBoneOrderRemapsData LBMBMFENBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7943740", Offset = "0x7942B40", VA = "0x187943740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7943520", Offset = "0x7942920", VA = "0x187943520")]
	protected void HHOOEGHGADC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NEKPGAPMAOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<int> BINCCENGEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<MIIKAFBECIH> HHLDIGCHODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private HashSet<Transform> LGIHNADJOIH;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x794E930", Offset = "0x794DD30", VA = "0x18794E930")]
	public static NEKPGAPMAOO IOONGAPKIOJ(Transform DEEHPBDAIHI, Dictionary<Transform, OutfitType?> OFBJCNCGOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x794EAC0", Offset = "0x794DEC0", VA = "0x18794EAC0")]
	private void JGJMCLACKJG(Transform DEEHPBDAIHI, MJGMDPCOPJP DFKGNLKKCJM, Dictionary<Transform, OutfitType?> OFBJCNCGOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x794E410", Offset = "0x794D810", VA = "0x18794E410")]
	private void CFBEBCHGPAP(Transform AIINFJBAELC, MJGMDPCOPJP DFKGNLKKCJM, bool OBDANANLCLO, OutfitType? MCHONEGAHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x794E540", Offset = "0x794D940", VA = "0x18794E540")]
	public OPFNJOPMGKO FKNALPJPHPE(HashSet<string> HCKLKCPKFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x794ED80", Offset = "0x794E180", VA = "0x18794ED80")]
	public NEKPGAPMAOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class OPFNJOPMGKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private List<MIIKAFBECIH> HHLDIGCHODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private List<Matrix4x4> EJMKNFDJIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private Transform[] GGEPPJKIODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private Matrix4x4[] AIOLNPJMNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private Dictionary<PHMICIFPFNK, int> IKEKLOKEAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<LEKLBPBABPM> IGFAOHJKFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private bool HJMDJADDPKC;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7953570", Offset = "0x7952970", VA = "0x187953570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Transform[] LIEFNMEKEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7953400", Offset = "0x7952800", VA = "0x187953400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Matrix4x4[] MNMFOOEPLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7952B40", Offset = "0x7951F40", VA = "0x187952B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7952F00", Offset = "0x7952300", VA = "0x187952F00")]
	public void CFBEBCHGPAP(Transform AIINFJBAELC, MJGMDPCOPJP DFKGNLKKCJM, OutfitType? MCHONEGAHNA, bool LHFGEDGKPNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7952BB0", Offset = "0x7951FB0", VA = "0x187952BB0")]
	private void CFBEBCHGPAP(Transform AIINFJBAELC, MJGMDPCOPJP DFKGNLKKCJM, OutfitType? MCHONEGAHNA, bool LHFGEDGKPNM, Matrix4x4 ABNALJHANGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7953100", Offset = "0x7952500", VA = "0x187953100")]
	public int FKPKLOENOPL(PHMICIFPFNK IICGAABOENK, bool HECFPEPHMJB, [Optional] OutfitType? MCHONEGAHNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x79535B0", Offset = "0x79529B0", VA = "0x1879535B0")]
	public int PFGJBCEGPFD(MJGMDPCOPJP DFKGNLKKCJM, [Optional] OutfitType? MCHONEGAHNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7952A50", Offset = "0x7951E50", VA = "0x187952A50")]
	public void BJBLOGHMBLF(PHMICIFPFNK IICGAABOENK, Matrix4x4 PHCNNICGNAK, bool HECFPEPHMJB = false, [Optional] OutfitType? MCHONEGAHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x79532B0", Offset = "0x79526B0", VA = "0x1879532B0")]
	public Matrix4x4 KGHFBKHFAKK(PHMICIFPFNK IICGAABOENK, bool HECFPEPHMJB, [Optional] OutfitType? MCHONEGAHNA)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x128F2B0", Offset = "0x128E6B0", VA = "0x18128F2B0")]
	public void IOEJPALKPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x79536B0", Offset = "0x7952AB0", VA = "0x1879536B0")]
	public OPFNJOPMGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct PHMICIFPFNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly string INLKEBPMMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly MJGMDPCOPJP MGIEBOLKHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly OutfitType? JEDKMJPEJNI;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7953D50", Offset = "0x7953150", VA = "0x187953D50")]
	public PHMICIFPFNK(string MBKADIIBEKE, MJGMDPCOPJP DFKGNLKKCJM, [Optional] OutfitType? MCHONEGAHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7953CA0", Offset = "0x79530A0", VA = "0x187953CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7953BE0", Offset = "0x7952FE0", VA = "0x187953BE0")]
	public bool ONNJEEKCAPG(PHMICIFPFNK DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7953AC0", Offset = "0x7952EC0", VA = "0x187953AC0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7953B70", Offset = "0x7952F70", VA = "0x187953B70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct LEKLBPBABPM : IEquatable<LEKLBPBABPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly MJGMDPCOPJP MGIEBOLKHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly OutfitType? GHKHDDIGANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly int HBCLMGOFJJP;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x794B3F0", Offset = "0x794A7F0", VA = "0x18794B3F0")]
	public LEKLBPBABPM(MJGMDPCOPJP DFKGNLKKCJM, int IELKBDBGOKO, [Optional] OutfitType? OJJDGFKNLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x794B320", Offset = "0x794A720", VA = "0x18794B320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0D90", Offset = "0x6BB0190", VA = "0x186BB0D90")]
	public bool APONHHHLCGK(MJGMDPCOPJP DFKGNLKKCJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x794B2A0", Offset = "0x794A6A0", VA = "0x18794B2A0")]
	public bool MJAPHNHNKDC(OutfitType? OJJDGFKNLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x794B110", Offset = "0x794A510", VA = "0x18794B110", Slot = "4")]
	public bool Equals(LEKLBPBABPM DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x794B160", Offset = "0x794A560", VA = "0x18794B160", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x794B250", Offset = "0x794A650", VA = "0x18794B250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct MIIKAFBECIH : IEquatable<MIIKAFBECIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly Transform JAMPKJBPKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly bool JOAFIOGDMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly MJGMDPCOPJP NAJFBMPLKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? JEDKMJPEJNI;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x794E1C0", Offset = "0x794D5C0", VA = "0x18794E1C0")]
	public MIIKAFBECIH(Transform AIINFJBAELC, bool OBDANANLCLO, MJGMDPCOPJP ANLHOBDBLHH, [Optional] OutfitType? DFEHHMGBMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x794DFA0", Offset = "0x794D3A0", VA = "0x18794DFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x794DE20", Offset = "0x794D220", VA = "0x18794DE20", Slot = "4")]
	public bool Equals(MIIKAFBECIH DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x794DD40", Offset = "0x794D140", VA = "0x18794DD40", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x794DF20", Offset = "0x794D320", VA = "0x18794DF20", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x79477C0", Offset = "0x7946BC0", VA = "0x1879477C0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface IJJAPEHKKEA
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGEOCDKAPLP(Mesh IGPCANDHEAE, Matrix4x4 HOCAIHBBIII, byte[] FOPDBNEDBDL, bool INDMKONCMOB = false, MOJPHFECLPK.JODCMICJPOD LJALGHFGBJD = (MOJPHFECLPK.JODCMICJPOD)0L, int GJHJCCOEDJM = -1, bool HBLMKDAAMGN = false);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPMHHOMHJHE(Allocator LMMGDELCIGC, MMLHJADAHDP FDLKGJPBCLI, byte JFLLIEFLOAN, [Optional] IList<int> FDFEKECPEML, [Optional] IList<int> BHJIBDMJHMC);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct FLIIOCPIKNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly GameObject MABMIHHHDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly AvatarItemMaterial PCNCDCBNEPJ;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
	public FLIIOCPIKNF(GameObject MABMIHHHDOA, AvatarItemMaterial PCNCDCBNEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7947730", Offset = "0x7946B30", VA = "0x187947730")]
	public void IOPJIHEPOIK(Material FFHFAEDNMPG, int LDDICKCHFNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KFDMBOBKLJG : LGJCKJIHGIM<Task<(GameObject, AvatarItemMaterial)>, FLIIOCPIKNF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct IDACKKIACEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7948C50", Offset = "0x7948050", VA = "0x187948C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7949150", Offset = "0x7948550", VA = "0x187949150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private PKCCCOBBKFK<GameObject> FLJEJAKEEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private PKCCCOBBKFK<AvatarItemMaterial> IKBOKFPFBJB;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x794A6E0", Offset = "0x7949AE0", VA = "0x18794A6E0")]
	private KFDMBOBKLJG(Task<(GameObject, AvatarItemMaterial)> OOCBIOLELBN, PKCCCOBBKFK<GameObject> IALDGAFHDOH, PKCCCOBBKFK<AvatarItemMaterial> HBCHFNLCADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x794A1A0", Offset = "0x79495A0", VA = "0x18794A1A0")]
	public static KFDMBOBKLJG BPKMLDCMEGB(AssetReference NCFEBEOCPIK, [Optional] AssetReference HELNLOHJHJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x794A640", Offset = "0x7949A40", VA = "0x18794A640", Slot = "11")]
	protected override FLIIOCPIKNF KBMOOBJAMDG(Task<(GameObject, AvatarItemMaterial)> IPLNFKCIDBN)
	{
		return default(FLIIOCPIKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x794A5C0", Offset = "0x79499C0", VA = "0x18794A5C0", Slot = "12")]
	protected override void DIIFFIKCKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x794A070", Offset = "0x7949470", VA = "0x18794A070")]
	[AsyncStateMachine(typeof(IDACKKIACEL))]
	private static Task<(GameObject, AvatarItemMaterial)> BNHALMCNOHF(Task<GameObject> MACKONDGAHP, Task<AvatarItemMaterial> FJIHGMEGNCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HFKKDFACMAH
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class LBOAPIHNMIE : LGJCKJIHGIM<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private PKCCCOBBKFK<MaterialMapAsset> PAOMPCHHBKF;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x794B030", Offset = "0x794A430", VA = "0x18794B030")]
		public LBOAPIHNMIE(PKCCCOBBKFK<MaterialMapAsset> PAOMPCHHBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x794ABF0", Offset = "0x7949FF0", VA = "0x18794ABF0", Slot = "11")]
		protected override Material[] KBMOOBJAMDG(Task<MaterialMapAsset> OOCBIOLELBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x794AB90", Offset = "0x7949F90", VA = "0x18794AB90", Slot = "12")]
		protected override void DIIFFIKCKMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MPLIBFFBFGG : LGJCKJIHGIM<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private List<PKCCCOBBKFK<Material>> OGLMLGNLLKL;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x794E3A0", Offset = "0x794D7A0", VA = "0x18794E3A0")]
		public MPLIBFFBFGG(Task<Material[]> OOCBIOLELBN, List<PKCCCOBBKFK<Material>> OGLMLGNLLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x794E350", Offset = "0x794D750", VA = "0x18794E350", Slot = "11")]
		protected override Material[] KBMOOBJAMDG(Task<Material[]> IPLNFKCIDBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x794E210", Offset = "0x794D610", VA = "0x18794E210", Slot = "12")]
		protected override void DIIFFIKCKMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x79487B0", Offset = "0x7947BB0", VA = "0x1879487B0")]
	public static PKCCCOBBKFK<Material[]> AKBHFFGDKOF(AssetReference[] MAJDJCMOEOM)
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
		public enum JCLOKAIDILL
		{
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum JJFNBGEKKCG
		{
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum MEJKPGCMLPA : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct ALLLKIJLAMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public readonly Material KGJJNNOKCEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public readonly JCLOKAIDILL OLGHOLDPHLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public readonly JJFNBGEKKCG MAMFCMFLPFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public readonly MJGMDPCOPJP MGIEBOLKHHO;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x79440D0", Offset = "0x79434D0", VA = "0x1879440D0")]
			public ALLLKIJLAMC(Material FFHFAEDNMPG, JCLOKAIDILL DMAAMPLEDGG, JJFNBGEKKCG BDIBLODBLEH, MJGMDPCOPJP DFKGNLKKCJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7966190", Offset = "0x7965590", VA = "0x187966190", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x7943C90", Offset = "0x7943090", VA = "0x187943C90")]
			public bool ONNJEEKCAPG(ALLLKIJLAMC DMMBOHMLHLF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x7966000", Offset = "0x7965400", VA = "0x187966000", Slot = "0")]
			public override bool Equals(object KLANNNFBLNB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x79660F0", Offset = "0x79654F0", VA = "0x1879660F0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct MPBCGDGMCMG : IComparable<MPBCGDGMCMG>, IEquatable<MPBCGDGMCMG>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public int HFGGECDDPBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public PlayerAvatarDisplayBase CPMOFLNCDEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public IList<HJAIALMMLAJ> HJFMOGOPFCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public AvatarItemBodyType MMIKBGDPJNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public BFMHJLAEPMI NKJCAELGFNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public bool ILENNPDPHGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public int[] IPMDIHKDHPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public float NFKAMDDPDBK;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x796B030", Offset = "0x796A430", VA = "0x18796B030", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x796AED0", Offset = "0x796A2D0", VA = "0x18796AED0", Slot = "4")]
			public int CompareTo(MPBCGDGMCMG DMMBOHMLHLF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x796AEF0", Offset = "0x796A2F0", VA = "0x18796AEF0", Slot = "5")]
			public bool Equals(MPBCGDGMCMG DMMBOHMLHLF)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class EGGNHFJEPEF
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class BMFKNOOFMAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Mesh IONJHIKMOLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly Material[] KLBFOAGBPHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public readonly Transform[] IDLAPFOPHEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public readonly Matrix4x4[] NJAKBINIOLG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				public readonly Transform LGENFOMMELG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				public readonly bool OMOIPBHGBHC;

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
				protected BMFKNOOFMAD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x79666E0", Offset = "0x7965AE0", VA = "0x1879666E0")]
				public BMFKNOOFMAD(Mesh IGPCANDHEAE, Material[] CAOKOIJJCBB, bool IDGIDCEOHKG, Transform[] AAPOEDBDHOK, Transform DEBMCNDPDJF, Matrix4x4[] IHDNPMMFKNP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x7966B90", Offset = "0x7965F90", VA = "0x187966B90")]
				private BMFKNOOFMAD(SkinnedMeshRenderer INOCKJOPLCC, Material[] IBEDBNMDDID)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x7966C50", Offset = "0x7966050", VA = "0x187966C50")]
				private BMFKNOOFMAD(MeshRenderer EIBKALLDDHL, Transform DEBMCNDPDJF, Material[] IBEDBNMDDID)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0x79663C0", Offset = "0x79657C0", VA = "0x1879663C0")]
				public static BMFKNOOFMAD NAFOHLPFIAO(Renderer JBNKAEBEMAK, Material[] IBEDBNMDDID)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly MJGMDPCOPJP MGIEBOLKHHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public readonly Transform JNPGFKNNJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public readonly bool NDOHDDKAKKK;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual bool KAMPPGNILPD
			{
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual bool OELBCCIMALL
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public virtual MOJPHFECLPK.JODCMICJPOD BBHJOFLIMIP
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "6")]
				get
				{
					return default(MOJPHFECLPK.JODCMICJPOD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public bool HGFPKPOCAJB
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x7967810", Offset = "0x7966C10", VA = "0x187967810")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7967820", Offset = "0x7966C20", VA = "0x187967820")]
			protected EGGNHFJEPEF(MJGMDPCOPJP DFKGNLKKCJM, Transform GPBCCEBICBI, bool JFJHKIBBIPB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract DKABIBJEBOC PNJDLGBPDCA(List<BFNBKBNLNFO> PFMMCFLAGAI, List<BFNBKBNLNFO> OHDDJBMLHLM);

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract BMFKNOOFMAD DDMBFKNOHID(int BKCGKLBAHGO, PlayerHandBones KKEOKLNFFNN);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class LIPHIBDNIKJ : EGGNHFJEPEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected readonly BodyPartLODs LKNFINOMIHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			protected readonly Material[] LNKOCDPFCFP;

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x796ADC0", Offset = "0x796A1C0", VA = "0x18796ADC0")]
			public LIPHIBDNIKJ(MJGMDPCOPJP DFKGNLKKCJM, BodyPartLODs HOJOGIOOAEK, Material NHOKJBJIMIF, [Optional] Transform GPBCCEBICBI, bool JFJHKIBBIPB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x796ACC0", Offset = "0x796A0C0", VA = "0x18796ACC0", Slot = "7")]
			public override DKABIBJEBOC PNJDLGBPDCA(List<BFNBKBNLNFO> PFMMCFLAGAI, List<BFNBKBNLNFO> OHDDJBMLHLM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x796AB00", Offset = "0x7969F00", VA = "0x18796AB00", Slot = "8")]
			public override BMFKNOOFMAD DDMBFKNOHID(int BKCGKLBAHGO, PlayerHandBones KKEOKLNFFNN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x796AD50", Offset = "0x796A150", VA = "0x18796AD50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class IHBHCGNGHLJ : EGGNHFJEPEF
		{
			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public override bool KAMPPGNILPD
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public override bool OELBCCIMALL
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x79699F0", Offset = "0x7968DF0", VA = "0x1879699F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public EAHNLELNCAK MKHACCANOCH
			{
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7969B40", Offset = "0x7968F40", VA = "0x187969B40")]
			public IHBHCGNGHLJ(MJGMDPCOPJP DFKGNLKKCJM, Transform GPBCCEBICBI, EAHNLELNCAK INDBGNLJGMK, bool JFJHKIBBIPB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7969A40", Offset = "0x7968E40", VA = "0x187969A40", Slot = "7")]
			public override DKABIBJEBOC PNJDLGBPDCA(List<BFNBKBNLNFO> PFMMCFLAGAI, List<BFNBKBNLNFO> OHDDJBMLHLM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "8")]
			public override BMFKNOOFMAD DDMBFKNOHID(int BKCGKLBAHGO, PlayerHandBones KKEOKLNFFNN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7969AD0", Offset = "0x7968ED0", VA = "0x187969AD0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class HIDAJIACOFN
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum JAGEKDOAOHC
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
			public static readonly int HGIFGFNABLB;

			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public static readonly int JEHGOLJKLNA;

			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public static readonly int JMALMFFKBPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly DFGGMLJPKKG IGIJOOMGCOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly NCBMKNMEOGG FJNGOEDPLJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Animator LJDONNMIBEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected readonly Transform NKKMMLENAKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly Vector3 CFAAHNDAONA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Transform EBOHIEEKMPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected readonly Vector3 IKGMELCHFPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected bool PJAALBHIGKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected OHNJHAOHDGP FOCHBIJFDKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected bool ALADCFAMNCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected float JCBAJMFMOBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected HMMMFBEOJDO<KGMJJNNLLGP> CEDEKNDPGGB;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public OHNJHAOHDGP NPGMCLCNKPL
			{
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x9CD810", Offset = "0x9CCC10", VA = "0x1809CD810")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x9CD7F0", Offset = "0x9CCBF0", VA = "0x1809CD7F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public bool ILNBBNGPJOK
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0xBBB7C0", Offset = "0xBBABC0", VA = "0x180BBB7C0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x7968380", Offset = "0x7967780", VA = "0x187968380")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public bool FGEBELDMPKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x9CE3A0", Offset = "0x9CD7A0", VA = "0x1809CE3A0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x7968AB0", Offset = "0x7967EB0", VA = "0x187968AB0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public float NCHEFAKCAHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xC47150", Offset = "0xC46550", VA = "0x180C47150")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x7968970", Offset = "0x7967D70", VA = "0x187968970")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public KGMJJNNLLGP MINPJNMGPFE
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0x7968720", Offset = "0x7967B20", VA = "0x187968720")]
				get
				{
					return default(KGMJJNNLLGP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x7968860", Offset = "0x7967C60", VA = "0x187968860")]
			public bool ODNILKAMKEJ(KGMJJNNLLGP FLJBAOHEIGO, object PAHPIGHLKFG, JAGEKDOAOHC CBJBMBLMJFG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7968760", Offset = "0x7967B60", VA = "0x187968760")]
			public bool NCKEIHGGCBE(object PAHPIGHLKFG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7969220", Offset = "0x7968620", VA = "0x187969220")]
			protected HIDAJIACOFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x7968C30", Offset = "0x7968030", VA = "0x187968C30")]
			public HIDAJIACOFN(DFGGMLJPKKG IGIJOOMGCOP, OHNJHAOHDGP EEHDKGPICLG, Animator LJDONNMIBEG, Transform NKKMMLENAKF, Transform EBOHIEEKMPB, Vector3 CFAAHNDAONA, Vector3 IKGMELCHFPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x7968280", Offset = "0x7967680", VA = "0x187968280")]
			private void EAEGOKGOOOE(ushort LPGIIFGLNJB, ushort HIPAAGGGBJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x7968630", Offset = "0x7967A30", VA = "0x187968630")]
			protected void KPDGFNKOOLD(ushort LPGIIFGLNJB, ushort HIPAAGGGBJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7967F90", Offset = "0x7967390", VA = "0x187967F90")]
			protected void BNIHDCDOIDB(ushort LPGIIFGLNJB, ushort HIPAAGGGBJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x7968500", Offset = "0x7967900", VA = "0x187968500")]
			protected void KCJIAOFIHMF(ushort LPGIIFGLNJB, ushort HIPAAGGGBJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7968170", Offset = "0x7967570", VA = "0x187968170")]
			protected void DBPDLIEBDKP(ushort LPGIIFGLNJB, ushort HIPAAGGGBJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7968450", Offset = "0x7967850", VA = "0x187968450")]
			protected void IEMHKBILBDM(ushort LPGIIFGLNJB, ushort HIPAAGGGBJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x79684B0", Offset = "0x79678B0", VA = "0x1879684B0")]
			protected void KAEMPBGKDBF(ushort LPGIIFGLNJB, ushort HIPAAGGGBJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7968330", Offset = "0x7967730", VA = "0x187968330")]
			protected void GEALIDKJABO(ushort LPGIIFGLNJB, ushort HIPAAGGGBJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7968050", Offset = "0x7967450", VA = "0x187968050")]
			protected void BPLBJHDCNAF(ushort LPGIIFGLNJB, ushort HIPAAGGGBJB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class AAEBABBECEM : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public const int MAGPHFCNPOF = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected MaterialPropertyBlock PGKMGNMBNPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color? JAFAGFCIBMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color? BLHNJPAFIGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Color? FGGDFJJHBOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Color KEOEONCECEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Color EMEEGAGIJPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Color NBBJALCMCFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Texture2D ACKHLIEFJMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Texture2D DLOANABCOCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Dictionary<ALLLKIJLAMC, int> FBPFHNCEAKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected JCLOKAIDILL[] GHFJCMHHMJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] JEAFMLIJKOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] IHBFMBEEMCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Vector4[] DFKGPLDMHNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Vector4[] LEAKNFDNNLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Vector4[] DKHJOPHANIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Vector4[] ENBMPAFCBHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected List<Texture2D> KCKDCKPEELN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected Vector4[] MGFBALIPLFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected List<Texture2D> FINHJJBOLBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected float[] JJOLCPJBGKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector4[] JNEOOAGIIBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected float[] DFAILBMLPEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public float[] CGILFKFMGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected List<Texture2D> DBFKIDJGNDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected float[] HMBJECGIPIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected List<Texture2D> CCFHAEMMGHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected Vector4[] NGJOCAILELP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected float[] IMIGLBLPAEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Vector4[] FPPPKOPEIOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public float[] CKBLMHBAIEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Texture2DArray CPJMFNGLHFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Texture2DArray MPDBBKGHPFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Texture2DArray IKIGJGEGDLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Texture2DArray CPHPPPGLEFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected bool JKFFHHCAEHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected int BOELKAGBLLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? HAPDHBGEANG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat BJIBMNIBMGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? EKCNFJJCLMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat KABGMLGDNKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector2? EAGGAJGHHAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected TextureFormat BLANAKNINJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected Vector2? ALHKJMFFEJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected TextureFormat GBIOAAAGLOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool FJEDLGBMFFE;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int JMEBCGMDEMB;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int HBCFCKKCEEH;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int HBPOLMGFNGO;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int LFGJPODMFNF;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int BINPECHGCKD;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int DLBPKEEGDNE;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int EJCKNHFMDEI;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int ADIKIPJLOMP;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int IIHOBCCBFLE;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int NDONDDDFIPK;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int MNKGADJHKHO;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int IJMJEPHNEOB;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int MLGPKJALGPN;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int AGHBDEJPJEO;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int BIAMKAAIKBM;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int FOFCMCFAHPP;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int BANPHIIDHEK;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int OECDAJNMHAI;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int CILLOPGHDMB;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int DPOJGGFHPIF;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7965010", Offset = "0x7964410", VA = "0x187965010")]
			protected AAEBABBECEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x79654D0", Offset = "0x79648D0", VA = "0x1879654D0")]
			public AAEBABBECEM(Color KDJOEKHGMNE, Color NALECDPAKHG, Color PDLGDFPPDGM, Color? BPNPIIENIKA, Color? BDBGCLLALBM, Color? CFHCLNAMHED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7963BA0", Offset = "0x7962FA0", VA = "0x187963BA0")]
			public int JGGPJDKAKHO(Material EHIJCMLCEML, JCLOKAIDILL DMAAMPLEDGG, JJFNBGEKKCG BDIBLODBLEH, MJGMDPCOPJP DFKGNLKKCJM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7963B10", Offset = "0x7962F10", VA = "0x187963B10")]
			public int JGGPJDKAKHO(ALLLKIJLAMC IICGAABOENK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7962E10", Offset = "0x7962210", VA = "0x187962E10")]
			public int ICNIMEGMLHC(Material EHIJCMLCEML, Color MMFEOPPFIJC, Color DKHCMLFNJEN, Color FPFPBCCJFCL, Color LGHIHINJDEE, Color NMAMGFOFBFB, Texture2D PJLJCIAEFGC, Vector4 ADHCHIBLLHJ, Texture2D BFBMPPNMBLF, Vector4 PKOIKAHINAK, float PNMPMNMKMCP, float HHPMDCKPABF, Texture2D LPPJEOGLGDA, Vector4 GFAJEPCEADN, float BOCPBLLCIIK, Texture2D LDLIPGGCDKF, float ENNIGFFBGBL, Color CAOIJFCOMKI, Vector4 PHFLEBNDJHJ, JCLOKAIDILL DMAAMPLEDGG, JJFNBGEKKCG BDIBLODBLEH, MJGMDPCOPJP DFKGNLKKCJM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7963C90", Offset = "0x7963090", VA = "0x187963C90")]
			protected void JKJLJPOEKDE([Out] Texture2DArray ILHNDLGECKL, [Out] Texture2DArray CINMKNGFCMM, [Out] Texture2DArray EIHHBNCCDLC, [Out] Texture2DArray LNMJIAEHABM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7963EE0", Offset = "0x79632E0", VA = "0x187963EE0")]
			public void OFKAHCJDPDM(PlayerAvatarDisplayBase IPJCKAFDFKP, Renderer JBNKAEBEMAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7964150", Offset = "0x7963550", VA = "0x187964150")]
			protected void OJMIIFOCELA(PlayerAvatarDisplayBase IPJCKAFDFKP, Renderer JBNKAEBEMAK, int FKJNLCMBGPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7962A90", Offset = "0x7961E90", VA = "0x187962A90")]
			private Color CBHLCELKJBD(Color MBGJOKEJAPA, JCLOKAIDILL PBAGJLPCJPH)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7962CC0", Offset = "0x79620C0", VA = "0x187962CC0")]
			private Color HGLDPHNDOKC(Color GHDADMJJGDB, JCLOKAIDILL PBAGJLPCJPH)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7963E50", Offset = "0x7963250", VA = "0x187963E50")]
			protected void NHPJAEAOKLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7962C80", Offset = "0x7962080", VA = "0x187962C80", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7971C90", Offset = "0x7971090", VA = "0x187971C90")]
			public void GPFFMMHNGCD(MJGMDPCOPJP DFKGNLKKCJM, [Out] Transform DGFFJNKGDJD, [Out] Transform[] AAPOEDBDHOK)
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
		private sealed class FONGOGLALIL : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033D")]
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
			[DebuggerHidden]
			public FONGOGLALIL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7967A90", Offset = "0x7966E90", VA = "0x187967A90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x7967D10", Offset = "0x7967110", VA = "0x187967D10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x7967C60", Offset = "0x7967060", VA = "0x187967C60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x7967C60", Offset = "0x7967060", VA = "0x187967C60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class PPHBCCMGOMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public PPHBCCMGOMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x796B580", Offset = "0x796A980", VA = "0x18796B580")]
			internal bool EDGPPIKNILL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class IPOJBMJPEGI : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private LCENDOCODMB <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000349")]
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
			[DebuggerHidden]
			public IPOJBMJPEGI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x7969EA0", Offset = "0x79692A0", VA = "0x187969EA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x796A280", Offset = "0x7969680", VA = "0x18796A280", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct CFLOEHHIAIL : IAsyncStateMachine
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
			public BJFLFCHJINB avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7966F80", Offset = "0x7966380", VA = "0x187966F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x79677B0", Offset = "0x7966BB0", VA = "0x1879677B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class LGODJJBIGBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public LGODJJBIGBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x796AA20", Offset = "0x7969E20", VA = "0x18796AA20")]
			internal bool ECCOBAENDAA(HJAIALMMLAJ selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class JAPMHOLMHDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Func<NDJGFNKMCGL<Dictionary<string, PKCCCOBBKFK<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public JAPMHOLMHDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x796A380", Offset = "0x7969780", VA = "0x18796A380")]
			internal (ALPDPKEGNFF, NDJGFNKMCGL<Dictionary<string, PKCCCOBBKFK<Texture2D>>>) OAKPEDLCOKA(Dictionary<string, NDKAGBMMFHK> avatarItems)
			{
				return default((ALPDPKEGNFF, NDJGFNKMCGL<Dictionary<string, PKCCCOBBKFK<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x796A2D0", Offset = "0x79696D0", VA = "0x18796A2D0")]
			internal NDJGFNKMCGL<Dictionary<string, PKCCCOBBKFK<Texture2D>>> BFOCALPEANH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x796A340", Offset = "0x7969740", VA = "0x18796A340")]
			internal void NIBBHHCDHEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class LICIFAHGMAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public LICIFAHGMAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x796AA50", Offset = "0x7969E50", VA = "0x18796AA50")]
			internal bool IGCKHBINKMF(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct GGDHAEGBBIK : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x7967D60", Offset = "0x7967160", VA = "0x187967D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7967F30", Offset = "0x7967330", VA = "0x187967F30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int EGKBMPKAKME;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int NDIJHJLHECJ;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int OACCCPOMMNE;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int HDAAKNKBCGH;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int MEGNMMHJLBA;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int LIBOKAAMLFG;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] LONHMFLANDH;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] KDNLPELENFL;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] BOHPOPDNFLD;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int[] MEHFHNLMCFC;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int[] LACHHHAFLDO;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int[] CPIBKOKLBFI;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static List<PlayerAvatarDisplayBase> NDJKFIEEBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected AELCGAALLCD DCOMLHHOLCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected bool AINPCMODBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected bool FJOIMKOJKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int[] OKMNKEPNPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected Dictionary<ALLLKIJLAMC, Material> AODGCEJHLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected Dictionary<ALLLKIJLAMC, Material> GBJJHGHADNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected Material EHBBHEGHPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected CKKICPFEDGL ELNDGIGCCLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private OHNJHAOHDGP JJJKKIKLIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private OHNJHAOHDGP KAACODCEGLG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected Material EBGGPCLIHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected FitMeshHemisphere KIIDOOPMEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected bool JIBEFPHKACD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected AOFLICKOANP BACHKPBLJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected bool GDECBPFHAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected AnchorParamsRestrictions IOPKEJAOLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool MLMEOHNLGFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Transform FJHOMDCENMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected bool JACMMPMGKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool GCKOCKDGJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected Vector3 CCHLIHKGDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected Quaternion KJOKJNFODAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Vector2 LBKLPHLFMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected FitMeshHemisphere NLHCMGDIPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[HAKPMKJKBJL(ANEAJGIOFML.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected Collider[] EJEFMFLGBFM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Collider[] CMHGOJGNKNK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected HIDAJIACOFN[] FMCJOFHDDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public Dictionary<Renderer, AAEBABBECEM> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Dictionary<Renderer, AAEBABBECEM> BHJLIBDDFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected NEKPGAPMAOO NJIPCLBFMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected ALPDPKEGNFF DPPKGCIDOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public BAJKLLBGNIN DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected int PBLGJEEDGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected (bool isLodForced, int forcedLOD) LFIBNBCBMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected HMMMFBEOJDO<NCBMKNMEOGG> CEDEKNDPGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected bool KGHDNJDHNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected Dictionary<HJAIALMMLAJ, List<ALLLKIJLAMC>> GKHAOGHADHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected Dictionary<HJAIALMMLAJ, List<ALLLKIJLAMC>> BOCCHNHCOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected readonly Dictionary<string, PKCCCOBBKFK<Texture2D>> GHAKFKIKCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected readonly Dictionary<string, PKCCCOBBKFK<Texture2D>> EHLPCIDMODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected bool BFGEKKCOOMJ;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static int DKNOFGEALLD;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected static List<MPBCGDGMCMG> JAOJFLBEJJF;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected static List<MPBCGDGMCMG> LNNAMACGIIJ;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected static DGHHBAELICH BGBMOGHNPJB;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected static bool KBNOKKHPFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color? MNJPFGJFAEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected bool GNKBLPKPEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected Color HJCLECIMECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Color NFCGIFLLNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected Color ILDMLIOHBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected AvatarHairPattern FBGHOFNEJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected EAHNLELNCAK PIKPNGDCPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Color CBBJEMDNHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color HFEPKAFALDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected AvatarHairPattern EEDHPAJNMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected EAHNLELNCAK JEOAKNIFGHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected EAHNLELNCAK KNKPNMKPADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color GFJPFNBPLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private AdditionalFeetData KLJPCGPBGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected HJAIALMMLAJ? ABDIJCIPALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Texture AEHCFMCOCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color DEMBIINPNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected readonly IList<HJAIALMMLAJ> ICPJOIDIHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected readonly IList<HJAIALMMLAJ> AODBEANLPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private AvatarItemBodyType OAOKCMLCFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		[SerializeField]
		protected EKLJAOFDFFM _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected MEJKPGCMLPA OJKCHPDNIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected int[] ABELAEHMDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected bool OLMCOPJKMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected int[] NMEGONPFMJF;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly MOJPHFECLPK.JODCMICJPOD IENNCGDILME;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly MOJPHFECLPK.JODCMICJPOD LEEMOLKHBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected bool IBGILDGDPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected KIDHHIPBIAG NDIACLLNGID;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string ACJIBBKGDHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool OGNOCINJNDA
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xBD1050", Offset = "0xBD0450", VA = "0x180BD1050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xBD05C0", Offset = "0xBCF9C0", VA = "0x180BD05C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool CDMKLAFKIMM
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool DMPCNJNAELB
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7961420", Offset = "0x7960820", VA = "0x187961420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool FCHEOEMNENF
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool HNGCIDAGEII
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool OMNCLMMKCEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public CKKICPFEDGL MEGJHNHKOMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA6F130", Offset = "0xA6E530", VA = "0x180A6F130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x7961BF0", Offset = "0x7960FF0", VA = "0x187961BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public OHNJHAOHDGP JGINNIICJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA790E0", Offset = "0xA784E0", VA = "0x180A790E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7961FF0", Offset = "0x79613F0", VA = "0x187961FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public OHNJHAOHDGP IHCEIPDDAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA8A1C0", Offset = "0xA895C0", VA = "0x180A8A1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x79622C0", Offset = "0x79616C0", VA = "0x1879622C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Material EEFNKJGIEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x795AA80", Offset = "0x7959E80", VA = "0x18795AA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected Material DHHFGLPMMNL
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7958A90", Offset = "0x7957E90", VA = "0x187958A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool MKPKLKBHLIK
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2136C40", Offset = "0x2136040", VA = "0x182136C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public PlayerFacialAnimatorBase LGMJMDIPFOP
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA8A3D0", Offset = "0xA897D0", VA = "0x180A8A3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public HIDAJIACOFN[] LGOGDCFMNMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7960FE0", Offset = "0x79603E0", VA = "0x187960FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public HIDAJIACOFN AJCJPBIHAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7961620", Offset = "0x7960A20", VA = "0x187961620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public HIDAJIACOFN LNLHPIOLCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7961650", Offset = "0x7960A50", VA = "0x187961650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Mesh NMJGOCENAHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA8ABE0", Offset = "0xA89FE0", VA = "0x180A8ABE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected NEKPGAPMAOO PMPIIHGHCAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x79550A0", Offset = "0x79544A0", VA = "0x1879550A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected ALPDPKEGNFF HANJEOHNFMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF70", Offset = "0xA8A370", VA = "0x180A8AF70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x795A4A0", Offset = "0x79598A0", VA = "0x18795A4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool MEFGCBCAIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool LCPAKGGEHOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7961610", Offset = "0x7960A10", VA = "0x187961610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int MGMPJAKCHNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x11505F0", Offset = "0x114F9F0", VA = "0x1811505F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7962200", Offset = "0x7961600", VA = "0x187962200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int POGNMMIDIPI
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x7961F40", Offset = "0x7961340", VA = "0x187961F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected virtual bool LEKJJBJKPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected virtual int[] IEKKDEBHCCN
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x795A9F0", Offset = "0x7959DF0", VA = "0x18795A9F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected bool EDCHIDNADPP
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x795A870", Offset = "0x7959C70", VA = "0x18795A870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected static bool OKAJHKNHPDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool DALNJLBAFKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x114EE30", Offset = "0x114E230", VA = "0x18114EE30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x79624E0", Offset = "0x79618E0", VA = "0x1879624E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public IEnumerable<SkinnedMeshRenderer> LGJIHPHJGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7960EC0", Offset = "0x79602C0", VA = "0x187960EC0")]
			[IteratorStateMachine(typeof(FONGOGLALIL))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool PJBCMDOMBND
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x114EDF0", Offset = "0x114E1F0", VA = "0x18114EDF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x11500F0", Offset = "0x114F4F0", VA = "0x1811500F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public LOHMIPEBFLA KHLHALFBNEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7960F40", Offset = "0x7960340", VA = "0x187960F40")]
			get
			{
				return default(LOHMIPEBFLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public static bool KFFFDCJMKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7961390", Offset = "0x7960790", VA = "0x187961390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected static DGHHBAELICH MKLAKJPCKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x795B820", Offset = "0x795AC20", VA = "0x18795B820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7959160", Offset = "0x7958560", VA = "0x187959160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Color BLHNJPAFIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7956A10", Offset = "0x7955E10", VA = "0x187956A10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Color FGGDFJJHBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x7959C10", Offset = "0x7959010", VA = "0x187959C10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Texture2D ONKABDEJEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x7958CB0", Offset = "0x79580B0", VA = "0x187958CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color KEOEONCECEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x795BA50", Offset = "0x795AE50", VA = "0x18795BA50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color EMEEGAGIJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7955BA0", Offset = "0x7954FA0", VA = "0x187955BA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public EAHNLELNCAK LJLDDKLGAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7960FA0", Offset = "0x79603A0", VA = "0x187960FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Texture2D LDNKAEGEAOM
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7953EC0", Offset = "0x79532C0", VA = "0x187953EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public float JAKFFGGAFFG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7960FC0", Offset = "0x79603C0", VA = "0x187960FC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float KGCGEFPINAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7961400", Offset = "0x7960800", VA = "0x187961400")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool DOJOKPMKEKF
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x12B4950", Offset = "0x12B3D50", VA = "0x1812B4950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x79619C0", Offset = "0x7960DC0", VA = "0x1879619C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NPLOCJLICMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x7960C20", Offset = "0x7960020", VA = "0x187960C20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7961720", Offset = "0x7960B20", VA = "0x187961720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action IHABOAJDBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7960B80", Offset = "0x795FF80", VA = "0x187960B80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7961680", Offset = "0x7960A80", VA = "0x187961680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action PILBGGAFFOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7960CC0", Offset = "0x79600C0", VA = "0x187960CC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x79617C0", Offset = "0x7960BC0", VA = "0x1879617C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CCOGDJBONJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7960D60", Offset = "0x7960160", VA = "0x187960D60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7961860", Offset = "0x7960C60", VA = "0x187961860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<DFGGMLJPKKG, KGMJJNNLLGP> HBMCACBFAFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x7960E00", Offset = "0x7960200", VA = "0x187960E00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x7961900", Offset = "0x7960D00", VA = "0x187961900")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x795D9A0", Offset = "0x795CDA0", VA = "0x18795D9A0")]
		public bool SetDeformation(bool AINPCMODBCI, bool FJOIMKOJKLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7954350", Offset = "0x7953750", VA = "0x187954350")]
		protected static Material APOJMLFDINM(Dictionary<ALLLKIJLAMC, Material> POEFDNJEDGN, Material DFPBBLNGBAB, JCLOKAIDILL DMAAMPLEDGG, JJFNBGEKKCG BDIBLODBLEH, MJGMDPCOPJP DFKGNLKKCJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x795A750", Offset = "0x7959B50", VA = "0x18795A750")]
		protected void KNBBPNCNEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7959C60", Offset = "0x7959060", VA = "0x187959C60")]
		protected bool KHDCFOBGCNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7955D10", Offset = "0x7955110", VA = "0x187955D10")]
		protected void DICIHGINIJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7955040", Offset = "0x7954440", VA = "0x187955040", Slot = "10")]
		protected virtual void BIABGHOCPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x795B170", Offset = "0x795A570", VA = "0x18795B170")]
		public int MeshesAtLODCount(int ELKCGMNMOLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x795B530", Offset = "0x795A930", VA = "0x18795B530")]
		protected static void NEBDDCAFGGA(Dictionary<HJAIALMMLAJ, List<ALLLKIJLAMC>> PPJCHOKILKM, EGGNHFJEPEF FMJAAABPEAI, Material DFPBBLNGBAB, JCLOKAIDILL PBAGJLPCJPH, JJFNBGEKKCG GEKBJBBGKGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7954D70", Offset = "0x7954170", VA = "0x187954D70")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7959540", Offset = "0x7958940", VA = "0x187959540")]
		protected void JCILONGHJEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x795C7B0", Offset = "0x795BBB0", VA = "0x18795C7B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "11")]
		protected virtual void GNPEGCMHFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7958680", Offset = "0x7957A80", VA = "0x187958680")]
		protected static void HFMCCNCFMIJ(List<Material> GNLPAGHAHDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7956220", Offset = "0x7955620", VA = "0x187956220")]
		protected static void EABPJADIMIK(Dictionary<ALLLKIJLAMC, Material> POEFDNJEDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7958020", Offset = "0x7957420", VA = "0x187958020")]
		protected static void GAHIEKKGPLG(Dictionary<Renderer, AAEBABBECEM> BOCEEDBNFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7955BF0", Offset = "0x7954FF0", VA = "0x187955BF0")]
		protected void DGGBDLMOEJF(SkinnedMeshRenderer[] FPKMAPBAAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x795CA60", Offset = "0x795BE60", VA = "0x18795CA60")]
		protected void PHGJAEALBGE(SkinnedMeshRenderer INOCKJOPLCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x795CB00", Offset = "0x795BF00", VA = "0x18795CB00")]
		protected void PHGJAEALBGE(MeshRenderer EIBKALLDDHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x795BBA0", Offset = "0x795AFA0", VA = "0x18795BBA0")]
		protected void NOEIOOLDGPG(List<BFNBKBNLNFO> FDKDBADPHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7959870", Offset = "0x7958C70", VA = "0x187959870")]
		protected void JIJNMBKDGIG(Dictionary<string, PKCCCOBBKFK<Texture2D>> PPJCHOKILKM, bool EMBFKPKPOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7956610", Offset = "0x7955A10", VA = "0x187956610")]
		protected void EKAIKPMLEAD(Dictionary<HJAIALMMLAJ, List<ALLLKIJLAMC>> PPJCHOKILKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x79584E0", Offset = "0x79578E0", VA = "0x1879584E0")]
		public float GetHandOpenClosedAxis(DFGGMLJPKKG IGIJOOMGCOP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x795E260", Offset = "0x795D660", VA = "0x18795E260")]
		public void SetHandOpenClosedAxis(DFGGMLJPKKG IGIJOOMGCOP, float DNCMOOADKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7958520", Offset = "0x7957920", VA = "0x187958520")]
		public KGMJJNNLLGP GetHandVisualState(DFGGMLJPKKG IGIJOOMGCOP)
		{
			return default(KGMJJNNLLGP);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x79544B0", Offset = "0x79538B0", VA = "0x1879544B0")]
		public bool AddHandVisualStateToken(DFGGMLJPKKG IGIJOOMGCOP, KGMJJNNLLGP JOHAPACLFGD, object PAHPIGHLKFG, HIDAJIACOFN.JAGEKDOAOHC CBJBMBLMJFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x795FA70", Offset = "0x795EE70", VA = "0x18795FA70")]
		public void SetWatchHand(DFGGMLJPKKG IGIJOOMGCOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x795FB30", Offset = "0x795EF30", VA = "0x18795FB30")]
		public void SetWatchHands(bool JAGNFLFEIGE, bool AHNEFJACMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x795D040", Offset = "0x795C440", VA = "0x18795D040")]
		public bool RemoveHandVisualStateToken(DFGGMLJPKKG IGIJOOMGCOP, object PAHPIGHLKFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x79585A0", Offset = "0x79579A0", VA = "0x1879585A0")]
		public bool GetThumbsUpActive(DFGGMLJPKKG IGIJOOMGCOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x795F510", Offset = "0x795E910", VA = "0x18795F510")]
		public void SetThumbsUpActive(DFGGMLJPKKG IGIJOOMGCOP, bool DJCKIHMFOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7958560", Offset = "0x7957960", VA = "0x187958560")]
		public bool GetHandshakeActive(DFGGMLJPKKG IGIJOOMGCOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x795E2B0", Offset = "0x795D6B0", VA = "0x18795E2B0")]
		public void SetHandshakeActive(DFGGMLJPKKG IGIJOOMGCOP, bool DEKHGEJCIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7957FD0", Offset = "0x79573D0", VA = "0x187957FD0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x79558C0", Offset = "0x7954CC0", VA = "0x1879558C0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7959AE0", Offset = "0x7958EE0", VA = "0x187959AE0")]
		private static void KBPHMOADCJI(Scene GCOBHCDOBIL, LoadSceneMode FDNGPAPMHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x795A540", Offset = "0x7959940", VA = "0x18795A540")]
		protected static void KMKFHKNFJPH(PlayerAvatarDisplayBase FECIJMPEKKA, List<MPBCGDGMCMG> JICNHCHPDHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x795CD60", Offset = "0x795C160", VA = "0x18795CD60")]
		public void Rebuild(bool ILIECILCIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7954240", Offset = "0x7953640", VA = "0x187954240")]
		protected void ANNONOHIMGM(bool ILIECILCIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x79540F0", Offset = "0x79534F0", VA = "0x1879540F0", Slot = "12")]
		protected virtual DKABIBJEBOC ANNONOHIMGM(IList<HJAIALMMLAJ> NKBAEOANHML, AvatarItemBodyType IMDCLKMCEHI, bool NEIHBJENBCF, int[] IDOPEJJBFEM, bool ILIECILCIIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7959E80", Offset = "0x7959280", VA = "0x187959E80")]
		protected static DKABIBJEBOC KIMLHBOMECL(MPBCGDGMCMG MLOJPGBCDFP, List<MPBCGDGMCMG> JICNHCHPDHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7958B80", Offset = "0x7957F80", VA = "0x187958B80")]
		[IteratorStateMachine(typeof(IPOJBMJPEGI))]
		protected static IEnumerator<LCENDOCODMB> ICGJNIKGKKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x795A930", Offset = "0x7959D30", VA = "0x18795A930")]
		protected static MPBCGDGMCMG LGJFBOOFNFL(List<MPBCGDGMCMG> JICNHCHPDHD)
		{
			return default(MPBCGDGMCMG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x795DAB0", Offset = "0x795CEB0", VA = "0x18795DAB0")]
		[AsyncStateMachine(typeof(CFLOEHHIAIL))]
		public Task SetFaceCustomizationSettings(BJFLFCHJINB NMNEBNPOIJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7959330", Offset = "0x7958730", VA = "0x187959330")]
		public void InitializeFaceFeatures(AvatarConfiguration DOGJIOIGOCA, LOHMIPEBFLA EEBDILJINIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x795F260", Offset = "0x795E660", VA = "0x18795F260")]
		public void SetTeamColors(Color? CFHCLNAMHED, bool EBECJCMHOLM, Color OOOMIDNBDED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1219F40", Offset = "0x1219340", VA = "0x181219F40")]
		private static void HIFKFGCOLHM(Material FFHFAEDNMPG, Color OOEMJLHLIHJ, params int[] HFMFJKONEAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1219540", Offset = "0x1218940", VA = "0x181219540")]
		private static void BCLIFILAMDD(Material FFHFAEDNMPG, Texture OOEMJLHLIHJ, params int[] HFMFJKONEAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x795C530", Offset = "0x795B930", VA = "0x18795C530")]
		protected void OOIBPEPPCKP(Material OIINLIAGOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7953DA0", Offset = "0x79531A0", VA = "0x187953DA0")]
		protected void AGHDMNLCKMI(Material OIINLIAGOKI, Color LHKLEEDFBJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x795C250", Offset = "0x795B650", VA = "0x18795C250")]
		protected void OFMMNFNGNPA(Material OIINLIAGOKI, Color LHKLEEDFBJI, Color NGMKLFLFKLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x795B310", Offset = "0x795A710", VA = "0x18795B310")]
		protected void NBJPNDJAGJL(Material OIINLIAGOKI, Texture2D PNHEFBGDDBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x795AD30", Offset = "0x795A130", VA = "0x18795AD30")]
		protected void MKKJPOBILFM(Material OIINLIAGOKI, Texture CDAPPCNELAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x79568B0", Offset = "0x7955CB0", VA = "0x1879568B0")]
		protected void FFFJKACIBGC(Action<AAEBABBECEM> BPHILPEOFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x79587C0", Offset = "0x7957BC0", VA = "0x1879587C0")]
		protected void HGPKGAAGDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x79559E0", Offset = "0x7954DE0", VA = "0x1879559E0")]
		protected void DCIIJHOJJGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7958180", Offset = "0x7957580", VA = "0x187958180")]
		protected void GAHONDCAIDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7954800", Offset = "0x7953C00", VA = "0x187954800")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x795D400", Offset = "0x795C800", VA = "0x18795D400")]
		public void SetBeardPrimaryColor([Optional] Color? PKOCLDFKEKD, bool LPGGGIHMPEO = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x795D630", Offset = "0x795CA30", VA = "0x18795D630")]
		public void SetBeardSecondaryColor([Optional] Color? PKOCLDFKEKD, bool LPGGGIHMPEO = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x795D2C0", Offset = "0x795C6C0", VA = "0x18795D2C0")]
		public void SetBeardPattern([Optional] AvatarHairPattern FNHPEBLFLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7958FF0", Offset = "0x79583F0", VA = "0x187958FF0")]
		private void ILAAGCMKMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x795C110", Offset = "0x795B510", VA = "0x18795C110")]
		private bool OAONNHEAEJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x795DE20", Offset = "0x795D220", VA = "0x18795DE20")]
		public void SetHairPrimaryColor([Optional] Color? KICEJIPNOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x795E040", Offset = "0x795D440", VA = "0x18795E040")]
		public void SetHairSecondaryColor([Optional] Color? KICEJIPNOCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x795DCF0", Offset = "0x795D0F0", VA = "0x18795DCF0")]
		public void SetHairPattern([Optional] AvatarHairPattern FNHPEBLFLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x795CEE0", Offset = "0x795C2E0", VA = "0x18795CEE0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7954290", Offset = "0x7953690", VA = "0x187954290")]
		private bool AONCAEOIDCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x795F0A0", Offset = "0x795E4A0", VA = "0x18795F0A0")]
		public void SetSkinColor(Color KDJOEKHGMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x795F560", Offset = "0x795E960", VA = "0x18795F560")]
		public void SetUgcItemVisualOverrides(HJAIALMMLAJ LDAFGBOABPN, LOHMIPEBFLA EEBDILJINIH, Texture LOLJNMGJOKL, Color LIOAGJMBPNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7955990", Offset = "0x7954D90", VA = "0x187955990")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x795DBB0", Offset = "0x795CFB0", VA = "0x18795DBB0")]
		public bool SetFaceShape(AvatarFaceShape KDHMLIJJJEP, bool HJCHKMOBDNG = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x79599F0", Offset = "0x7958DF0", VA = "0x1879599F0")]
		private void JKKPAKCEAOC(BCKKHHFAGPP CBKABMIGHBO, float OOEMJLHLIHJ, bool CLINKEIPFAO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x79550C0", Offset = "0x79544C0", VA = "0x1879550C0")]
		private void BKMHPFANCOP(PONEFPLHJGC PDFBCGJOCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7954F00", Offset = "0x7954300", VA = "0x187954F00")]
		private void BDPBLOJJNPF(FGBECOOKEOM EJGKLLLLALH, float OOEMJLHLIHJ, bool AAKNAEMMJHB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7953FC0", Offset = "0x79533C0", VA = "0x187953FC0")]
		private void ANIHNCNHNEE(JCIMPJGFJKG OLCFOJACJIG, float OOEMJLHLIHJ, bool JBGDJHMBBMA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7956C00", Offset = "0x7956000", VA = "0x187956C00")]
		private void FJGJEFAFABN(LHGBMALHBIJ KMKKOBMLMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x795A650", Offset = "0x7959A50", VA = "0x18795A650")]
		private void KMOICJJAIMI(HMHDCFIMNEB JMDIEJFLGEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x795D860", Offset = "0x795CC60", VA = "0x18795D860")]
		public bool SetBodyShape(AvatarBodyShape CBKGAIGIBOG, bool HJCHKMOBDNG = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x795EF30", Offset = "0x795E330", VA = "0x18795EF30")]
		public bool SetNoseType(EKLJAOFDFFM EFBDDCCBBIN, bool HJCHKMOBDNG = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x795FC90", Offset = "0x795F090", VA = "0x18795FC90")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x795EF10", Offset = "0x795E310", VA = "0x18795EF10")]
		public bool SetHideEars(bool BDEOKLEFJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x795EF00", Offset = "0x795E300", VA = "0x18795EF00")]
		public bool SetHelmetHair(AELCGAALLCD CBCNMJBIBHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x795E300", Offset = "0x795D700", VA = "0x18795E300")]
		public void SetHatAnchorParameters(AOFLICKOANP CHIGKBMFEJH, bool DAOFGIPADCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x795FC00", Offset = "0x795F000", VA = "0x18795FC00")]
		public void SetupDisplayLODs(MEJKPGCMLPA LMBFCAAICAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7958DA0", Offset = "0x79581A0", VA = "0x187958DA0")]
		protected int[] IGOLNKMODNA(MEJKPGCMLPA LMBFCAAICAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x795F020", Offset = "0x795E420", VA = "0x18795F020")]
		public void SetOutfitSelections(IList<HJAIALMMLAJ> NKBAEOANHML, AvatarItemBodyType IMDCLKMCEHI, bool ILIECILCIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x795F060", Offset = "0x795E460", VA = "0x18795F060")]
		public void SetOutfitSelections(IList<HJAIALMMLAJ> NKBAEOANHML, AvatarItemBodyType IMDCLKMCEHI, bool NEIHBJENBCF, bool ILIECILCIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x795EFD0", Offset = "0x795E3D0", VA = "0x18795EFD0")]
		public DKABIBJEBOC SetOutfitSelections(IList<HJAIALMMLAJ> NKBAEOANHML, AvatarItemBodyType IMDCLKMCEHI, MEJKPGCMLPA LMBFCAAICAA, bool NEIHBJENBCF, bool HJCHKMOBDNG = false, bool ILIECILCIIJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7956660", Offset = "0x7955A60", VA = "0x187956660", Slot = "13")]
		protected virtual DKABIBJEBOC FCDGLENJOLC(IList<HJAIALMMLAJ> NKBAEOANHML, AvatarItemBodyType IMDCLKMCEHI, bool NEIHBJENBCF, MEJKPGCMLPA LMBFCAAICAA, bool HJCHKMOBDNG, bool ILIECILCIIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x795BAA0", Offset = "0x795AEA0", VA = "0x18795BAA0")]
		protected int[] NOCNEDGNFHP(MEJKPGCMLPA LMBFCAAICAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "14")]
		protected virtual ALPDPKEGNFF HBOBNFOPPFC(AvatarItemBodyType IGEPGIJPCPL, Dictionary<string, NDKAGBMMFHK> CFGPLCLIABL, Dictionary<string, PKCCCOBBKFK<Texture2D>> CKGIFKEIMHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x795BD80", Offset = "0x795B180", VA = "0x18795BD80", Slot = "15")]
		protected virtual DKABIBJEBOC NPDEMMBKJFD(IList<HJAIALMMLAJ> NKBAEOANHML, AvatarItemBodyType IMDCLKMCEHI, bool NEIHBJENBCF, int[] IPMDIHKDHPF, BFMHJLAEPMI KJPFLGFJANF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7955DA0", Offset = "0x79551A0", VA = "0x187955DA0", Slot = "16")]
		protected virtual NDKAGBMMFHK DILGEDONNFF(EAHNLELNCAK INDBGNLJGMK, AvatarItemBodyType IGEPGIJPCPL, MJGMDPCOPJP DFKGNLKKCJM, NDKAGBMMFHK OJPHOCKLCPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "17")]
		protected virtual NDKAGBMMFHK PAGFIHGEIPN(AvatarItemBodyType IGEPGIJPCPL, MJGMDPCOPJP DFKGNLKKCJM, EACKHGFMFHP DMMOIDHGCMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7958BE0", Offset = "0x7957FE0", VA = "0x187958BE0")]
		protected void IENKMDIFOPM(LAAPKAPFAKB ANNOGINCFIM, MOJPHFECLPK.JODCMICJPOD ODFEOLFCHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7957F50", Offset = "0x7957350", VA = "0x187957F50")]
		protected void FOJDGLABIOG(LAAPKAPFAKB ANNOGINCFIM, MOJPHFECLPK.JODCMICJPOD ODFEOLFCHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", VA = "0x180A4EED0", Slot = "18")]
		protected virtual LAAPKAPFAKB IDBBOKOHJFE(LAAPKAPFAKB ANNOGINCFIM, HelmetHairStyle KHPJIGNAGMC, bool LNIPNDLCEOH, AvatarItemBodyType IMDCLKMCEHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7956DE0", Offset = "0x79561E0", VA = "0x187956DE0")]
		protected LAAPKAPFAKB FKCDBCIIFAA(IList<HJAIALMMLAJ> NKBAEOANHML, AvatarItemBodyType IHMAKDMNENF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x79557A0", Offset = "0x7954BA0", VA = "0x1879557A0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7957E50", Offset = "0x7957250", VA = "0x187957E50")]
		protected void FMIKEJBNKDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x795AE40", Offset = "0x795A240", VA = "0x18795AE40")]
		protected void MNMJHGMPDON(Transform LANJILJFPMM, IEnumerable<SkinnedMeshRenderer> LKNNEPNDGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x795C050", Offset = "0x795B450", VA = "0x18795C050")]
		protected MOJPHFECLPK.JODCMICJPOD OANHPJNAAOI(MOJPHFECLPK.JODCMICJPOD KIKOIPIKOEN, MJGMDPCOPJP GKMENOPLCMG)
		{
			return default(MOJPHFECLPK.JODCMICJPOD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7953D90", Offset = "0x7953190", VA = "0x187953D90")]
		protected void ADILFAEMBNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1197670", Offset = "0x1196A70", VA = "0x181197670")]
		protected void MDOMNLDLJEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x795B940", Offset = "0x795AD40", VA = "0x18795B940")]
		protected void NJJFHNGIHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7956D10", Offset = "0x7956110", VA = "0x187956D10")]
		[AsyncStateMachine(typeof(GGDHAEGBBIK))]
		protected Task FKAJABFPMIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7956A60", Offset = "0x7955E60", VA = "0x187956A60")]
		protected static JCLOKAIDILL FHGHBNBMENF(EGGNHFJEPEF BMOBKLECNPF, int EBBDANBAIHJ)
		{
			return default(JCLOKAIDILL);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x795CC10", Offset = "0x795C010", VA = "0x18795CC10")]
		protected static JJFNBGEKKCG PPGBMHHAILF(EGGNHFJEPEF BMOBKLECNPF, int EBBDANBAIHJ)
		{
			return default(JJFNBGEKKCG);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7959A90", Offset = "0x7958E90", VA = "0x187959A90")]
		protected Transform JNBJKANEEBO(MJGMDPCOPJP DFKGNLKKCJM, OutfitType MCHONEGAHNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7956410", Offset = "0x7955810", VA = "0x187956410")]
		protected void EJBCEKMPANI(int LDDICKCHFNB, Material FFHFAEDNMPG, EGGNHFJEPEF BMOBKLECNPF, [Out] Texture2D ICGCGFEHPKA, [Out] Vector4 COGBFCPKIJK, [Out] Texture2D LPNEBKAAODJ, [Out] Texture2D ILAOBDJLDGB, [Out] Texture2D GMHIEBGMEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x79593F0", Offset = "0x79587F0", VA = "0x1879593F0")]
		protected void JBLKGAFNBGA(int LDDICKCHFNB, Material FFHFAEDNMPG, EGGNHFJEPEF BMOBKLECNPF, [Out] Color MMFEOPPFIJC, [Out] Color DKHCMLFNJEN, [Out] Color FPFPBCCJFCL, [Out] Color LGHIHINJDEE, [Out] Color NMAMGFOFBFB, [Out] Color CAOIJFCOMKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x795ACC0", Offset = "0x795A0C0", VA = "0x18795ACC0")]
		protected void MEDEKAFGGGM(Vector3 KHAINEMBOCD, Quaternion CNCCLHDGKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x795E8B0", Offset = "0x795DCB0", VA = "0x18795E8B0")]
		public void SetHatAnchorParameters(AOFLICKOANP CHIGKBMFEJH, AnchorParamsRestrictions LAECHJCNPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x79552C0", Offset = "0x79546C0", VA = "0x1879552C0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere KIIDOOPMEDK, Transform FJHOMDCENMN, AOFLICKOANP CHIGKBMFEJH, AnchorParamsRestrictions IOPKEJAOLLI, [Out] Vector3 PJFBLLCJOED, [Out] Quaternion EFHNCGDBHHB, [Out] AOFLICKOANP CJMHOOHOFOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x795D150", Offset = "0x795C550", VA = "0x18795D150")]
		public void ResetHatAnchor(Vector2 GEDIHEALPDG, Vector3 FBFBJHOBCFC, Vector3 IKMMHNMDBKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA65D60", Offset = "0xA65160", VA = "0x180A65D60")]
		public LOLKEBDAHDP GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7954630", Offset = "0x7953A30", VA = "0x187954630")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7954770", Offset = "0x7953B70", VA = "0x187954770")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x79545A0", Offset = "0x79539A0", VA = "0x1879545A0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x795FC30", Offset = "0x795F030", VA = "0x18795FC30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x795B870", Offset = "0x795AC70", VA = "0x18795B870")]
		protected void NJCAHEPNBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x795F9F0", Offset = "0x795EDF0", VA = "0x18795F9F0")]
		public void SetWaitForUgcTextureLoads(bool NGIPPJJCIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x795F900", Offset = "0x795ED00", VA = "0x18795F900")]
		public void SetUgcTextureParameters(KIDHHIPBIAG OPJDOLNIGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7960570", Offset = "0x795F970", VA = "0x187960570")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7958F60", Offset = "0x7958360", VA = "0x187958F60")]
		[CompilerGenerated]
		private void IHKMFKBDALE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7957E20", Offset = "0x7957220", VA = "0x187957E20")]
		[CompilerGenerated]
		private void FLLFCIMKFBA(AAEBABBECEM PKMNDHNNFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7958A00", Offset = "0x7957E00", VA = "0x187958A00")]
		[CompilerGenerated]
		private void HNGANGMEAPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x79585E0", Offset = "0x79579E0", VA = "0x1879585E0")]
		[CompilerGenerated]
		private void HFLKEGIIJDM(AAEBABBECEM PKMNDHNNFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7956380", Offset = "0x7955780", VA = "0x187956380")]
		[CompilerGenerated]
		private void ECKELJLNMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7954FA0", Offset = "0x79543A0", VA = "0x187954FA0")]
		[CompilerGenerated]
		private void BHKJDLMDFHI(AAEBABBECEM PKMNDHNNFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x795C1C0", Offset = "0x795B5C0", VA = "0x18795C1C0")]
		[CompilerGenerated]
		private void OCKKCEEIEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7957F00", Offset = "0x7957300", VA = "0x187957F00")]
		[CompilerGenerated]
		private void FNLENFBOHLC(AAEBABBECEM PKMNDHNNFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7954060", Offset = "0x7953460", VA = "0x187954060")]
		[CompilerGenerated]
		private void ANJOJJICKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7958C60", Offset = "0x7958060", VA = "0x187958C60")]
		[CompilerGenerated]
		private void IGDFAHEGLKL(AAEBABBECEM PKMNDHNNFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x795C480", Offset = "0x795B880", VA = "0x18795C480")]
		[CompilerGenerated]
		private void OINLBEJIAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x795C510", Offset = "0x795B910", VA = "0x18795C510")]
		[CompilerGenerated]
		private void OKJFBDKFNOP(AAEBABBECEM PKMNDHNNFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x795B230", Offset = "0x795A630", VA = "0x18795B230")]
		[CompilerGenerated]
		internal static bool NAIBALJCCAC(Transform IIHNGEDCDCI, IEnumerable<SkinnedMeshRenderer> IGBKKNIJAKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x795A8F0", Offset = "0x7959CF0", VA = "0x18795A8F0")]
		[CompilerGenerated]
		private void LCHLHEMBIEL(AAEBABBECEM PKMNDHNNFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x795CBD0", Offset = "0x795BFD0", VA = "0x18795CBD0")]
		[CompilerGenerated]
		private void PMKEBFKGEPP(AAEBABBECEM PKMNDHNNFCP)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, AHODEOBLEAO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct IOLLGIANAKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public BJFLFCHJINB avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x7969BB0", Offset = "0x7968FB0", VA = "0x187969BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x7969E40", Offset = "0x7969240", VA = "0x187969E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct CFJBAOCEEKB : IAsyncStateMachine
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
			public LOHMIPEBFLA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x7966D40", Offset = "0x7966140", VA = "0x187966D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x7966F20", Offset = "0x7966320", VA = "0x187966F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct OMGJHNHBKMC : IAsyncStateMachine
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
			public LOHMIPEBFLA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x796B380", Offset = "0x796A780", VA = "0x18796B380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x796B520", Offset = "0x796A920", VA = "0x18796B520", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct EIBHHJIFDOJ : IAsyncStateMachine
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
			public BJFLFCHJINB avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x7967880", Offset = "0x7966C80", VA = "0x187967880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x7967A30", Offset = "0x7966E30", VA = "0x187967A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct LFDNKHMHNGB : IAsyncStateMachine
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
			public LOHMIPEBFLA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			private TaskAwaiter<IKECNDGIGBG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x796A580", Offset = "0x7969980", VA = "0x18796A580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x796A9C0", Offset = "0x7969DC0", VA = "0x18796A9C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct AKIEMFMPGJN : IAsyncStateMachine
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
			public LOHMIPEBFLA avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x7965AC0", Offset = "0x7964EC0", VA = "0x187965AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x7965FA0", Offset = "0x79653A0", VA = "0x187965FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected const float FGMEJGGJEJH = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected const int BFJPBMFOPKB = 5;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static readonly Dictionary<EADIBIPOLJC.GMDHOMLFFCC, int> LMGFFBHBHNG;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> OBMEGACBBDM;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static readonly int KHMJGKGHIFO;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly int CNCBDINNJGL;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static readonly int CFODJECINEF;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int MIFJBIEKBOH;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static readonly int ANBPKMOAAHH;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static readonly int NHCMHDBNKBN;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static readonly int GGDMCJOPNHL;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static readonly int OPKNKPIEKMP;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 DHFPLKGCMKN;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 EIDEBPPHAOK;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 EFGNAACENAK;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 MCOHIEOBJHA;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 EJGMKKECKCJ;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 AAEOBONNPDN;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 HPMJOFOKDBC;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 JMDNOADKBDC;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static Vector2 CJDABCBDHOA;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static Vector2 DJKCJFJGAAK;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 MNEIAAMLHNG;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 KCCCGKEPNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
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
		private LOHMIPEBFLA GELJPPMOGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private FaceStyleSet ADGFKHGJBCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected const int OBFEABKACOD = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int PLKIJHILFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int ACNDLOLGDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int CDBMMMLIMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int MPBPHKGDOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Vector2 AHFBGCIHNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float FALEMPPJEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected float LCIALMCJPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float IPEBMKBBFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Vector2 JFFIOFBBGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float OAFHNKAIALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected float JICNGEELJBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float ODLECMPKBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 NILIJIGDIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float GHLEDBAOAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float BHLKNGABAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float AFGKLPOLCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected Vector2 EFNAEBKBMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float FBHMPAABAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected float HLCNHNAIOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float LHFCBKKFELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected List<SelectableFaceOption> MJDFGGKCLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected List<SelectableFaceOption> LHMLGGHNMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected List<SelectableFaceOption> BGFILHFDBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected List<SelectableFaceOption> LODOJGEHHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Coroutine MNEHBANCOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int? CACLFEPHHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int EFIJEMKICIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int GFIODDBOBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected int PLMGCCEHLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected int HJCCFPLKILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected int DBIBNEPOHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected int DMBMJCBPFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Sprite BDHHNIKEDJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Sprite PEAJACJKAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Sprite ODHCMLOCLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Sprite HFBDICIGMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected bool HAHOHDJNGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected string NHEMIEONFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected string DMPKKEFDNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected string HIMMGPNOLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected string CJPCAHINDDH;

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
		protected AvatarConfiguration DOGJIOIGOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected IKECNDGIGBG DKOEICCFGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private readonly List<Material> GNEEKAFHIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected IPJAKLGDELD FEDCMEICJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected Dictionary<string, int> LPNKJGCHLKL;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FaceStyleSet ELJILDKOMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x79719D0", Offset = "0x7970DD0", VA = "0x1879719D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool HFNAFNGMPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xAB2D70", Offset = "0xAB2170", VA = "0x180AB2D70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x25982D0", Offset = "0x25976D0", VA = "0x1825982D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected virtual bool CEELICHDOEB
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected virtual bool MGGBJOCMMEC
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected int INOLJOFKPMK
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x796E000", Offset = "0x796D400", VA = "0x18796E000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Renderer CGNEHOLIKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool JAENIAOIMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0A20", Offset = "0xAAFE20", VA = "0x180AB0A20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x7971C80", Offset = "0x7971080", VA = "0x187971C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Renderer[] DGGKMKIABEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool AGIOCDCOMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7971A20", Offset = "0x7970E20", VA = "0x187971A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7971BE0", Offset = "0x7970FE0", VA = "0x187971BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int EAEOPBGNELE
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x796E330", Offset = "0x796D730", VA = "0x18796E330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected int AOCLELGNLMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x796BD30", Offset = "0x796B130", VA = "0x18796BD30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public float ECCNJMJHHIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7971A00", Offset = "0x7970E00", VA = "0x187971A00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x7971BC0", Offset = "0x7970FC0", VA = "0x187971BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public GNHNBKMHFPD CHEAINDHKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xA7C5A0", Offset = "0xA7B9A0", VA = "0x180A7C5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA98E90", Offset = "0xA98290", VA = "0x180A98E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public IKECNDGIGBG ODNNIKAJGNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xA8A3E0", Offset = "0xA897E0", VA = "0x180A8A3E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x7971B40", Offset = "0x7970F40", VA = "0x187971B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public NoseFaceOption HHLNDABCKDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA7CDB0", Offset = "0xA7C1B0", VA = "0x180A7CDB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xB08FE0", Offset = "0xB083E0", VA = "0x180B08FE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected IPJAKLGDELD DOPJOEJFKCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x796CC40", Offset = "0x796C040", VA = "0x18796CC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action BNGALLBIFPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x7971920", Offset = "0x7970D20", VA = "0x187971920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7971A90", Offset = "0x7970E90", VA = "0x187971A90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x796E390", Offset = "0x796D790", VA = "0x18796E390")]
		public void LocalPlayEmote(EADIBIPOLJC.GMDHOMLFFCC NOBIIPDIFAA, float LONBBBKBKDD = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x796DD40", Offset = "0x796D140", VA = "0x18796DD40")]
		public bool IsEmotePlaying(EADIBIPOLJC.GMDHOMLFFCC NOBIIPDIFAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x796F820", Offset = "0x796EC20", VA = "0x18796F820")]
		public void SetIdleHappy(bool BCHGABNHOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x796E2B0", Offset = "0x796D6B0", VA = "0x18796E2B0")]
		protected void KOFANDIPAHF(bool NCMNEIAFKNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x796EED0", Offset = "0x796E2D0", VA = "0x18796EED0")]
		protected void PIHJBIHKMDB(bool HPKNJJAKOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x796BD90", Offset = "0x796B190", VA = "0x18796BD90")]
		protected void BDIONLIHACF(MJGMDPCOPJP DFKGNLKKCJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x796BE00", Offset = "0x796B200", VA = "0x18796BE00")]
		protected void BHMFPJPPIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x796F030", Offset = "0x796E430", VA = "0x18796F030")]
		public void PlayExpression(int EBCPKJMLPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x796DE60", Offset = "0x796D260", VA = "0x18796DE60")]
		protected void JCDFCLHDIOB(bool INAIGHKAPHG, bool KODFNGDNFCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x796CF70", Offset = "0x796C370", VA = "0x18796CF70")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType JAPIFDOMPDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x796D810", Offset = "0x796CC10", VA = "0x18796D810")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration DOGJIOIGOCA, LOHMIPEBFLA EEBDILJINIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x796F600", Offset = "0x796EA00", VA = "0x18796F600")]
		[AsyncStateMachine(typeof(IOLLGIANAKD))]
		public Task SetFaceSettings(BJFLFCHJINB NMNEBNPOIJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x796F6F0", Offset = "0x796EAF0", VA = "0x18796F6F0")]
		[AsyncStateMachine(typeof(CFJBAOCEEKB))]
		public Task SetFaceSettings(int PELGMDLEIGC, int GDGOJHPOKJJ, int OEEODHOOOML, int HOJLCEDCHMC, LOHMIPEBFLA EEBDILJINIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x796F8A0", Offset = "0x796ECA0", VA = "0x18796F8A0")]
		[AsyncStateMachine(typeof(OMGJHNHBKMC))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType JAPIFDOMPDD, int GEKFNFEIFKI, LOHMIPEBFLA EEBDILJINIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x796EB40", Offset = "0x796DF40", VA = "0x18796EB40")]
		protected void OOKJGNGEPCH(FaceFeatureType JAPIFDOMPDD, CEIANKIDECD FMKKMDNPMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x796C300", Offset = "0x796B700", VA = "0x18796C300")]
		protected void DCBJMHBFHMH(FaceFeatureType JAPIFDOMPDD, int GEKFNFEIFKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x796CD90", Offset = "0x796C190", VA = "0x18796CD90")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x796CB50", Offset = "0x796BF50", VA = "0x18796CB50")]
		[AsyncStateMachine(typeof(EIBHHJIFDOJ))]
		protected Task DINLGOLECPN(BJFLFCHJINB NMNEBNPOIJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x796BA30", Offset = "0x796AE30", VA = "0x18796BA30")]
		protected void BCKIEGMIFJF(BJFLFCHJINB NMNEBNPOIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x796E820", Offset = "0x796DC20", VA = "0x18796E820")]
		protected static void NKELHGDKNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x796B660", Offset = "0x796AA60", VA = "0x18796B660")]
		private void AALFIFMLADL(bool LCDPJEBNEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x796BF70", Offset = "0x796B370", VA = "0x18796BF70")]
		protected void CKCLLMLHBBE(FaceFeatureType JAPIFDOMPDD, Vector2 JAELDEOGPAD, LOHMIPEBFLA EEBDILJINIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x796F050", Offset = "0x796E450", VA = "0x18796F050")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType JAPIFDOMPDD, Vector2 PCIOKPLNMJO, LOHMIPEBFLA EEBDILJINIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x796E9C0", Offset = "0x796DDC0", VA = "0x18796E9C0")]
		protected void NOADKBJIAKL(FaceFeatureType JAPIFDOMPDD, float IDAOOBNOFGA, LOHMIPEBFLA EEBDILJINIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x796E130", Offset = "0x796D530", VA = "0x18796E130")]
		protected void KKKEPFADNCK(FaceFeatureType JAPIFDOMPDD, float PNEDBEMJDJJ, LOHMIPEBFLA EEBDILJINIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x796CCC0", Offset = "0x796C0C0", VA = "0x18796CCC0")]
		protected void EFGBKNKDPJI(FaceFeatureType JAPIFDOMPDD, float OEKMAIKEGFB, LOHMIPEBFLA EEBDILJINIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x796F3E0", Offset = "0x796E7E0", VA = "0x18796F3E0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType JAPIFDOMPDD, float LPDCNHLGHCB, LOHMIPEBFLA EEBDILJINIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x796DF20", Offset = "0x796D320", VA = "0x18796DF20")]
		[AsyncStateMachine(typeof(LFDNKHMHNGB))]
		protected Task KECDAHJHJLB(LOHMIPEBFLA EEBDILJINIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x796DB30", Offset = "0x796CF30", VA = "0x18796DB30")]
		public void InitializeFaceFeatureStyleSet(LOHMIPEBFLA EEBDILJINIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x796E490", Offset = "0x796D890", VA = "0x18796E490")]
		protected bool NALFENFGGOC(string FEADKKBPHOM, [Out] int COPLIEINKOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x796B8F0", Offset = "0x796ACF0", VA = "0x18796B8F0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x15AB410", Offset = "0x15AA810", VA = "0x1815AB410", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x796ECC0", Offset = "0x796E0C0", VA = "0x18796ECC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x79709D0", Offset = "0x796FDD0", VA = "0x1879709D0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x796BE70", Offset = "0x796B270", VA = "0x18796BE70")]
		[AsyncStateMachine(typeof(AKIEMFMPGJN))]
		public Task BuildFaceStyleAsyncIfChanged(LOHMIPEBFLA EEBDILJINIH, bool HJCHKMOBDNG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x79702F0", Offset = "0x796F6F0", VA = "0x1879702F0")]
		public void UpdateFaceDisplays(bool NBCELAFGKEH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x796CFB0", Offset = "0x796C3B0", VA = "0x18796CFB0")]
		protected bool HKMCGKNEPGP(bool NBCELAFGKEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7970010", Offset = "0x796F410", VA = "0x187970010")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x796F9B0", Offset = "0x796EDB0", VA = "0x18796F9B0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7970500", Offset = "0x796F900", VA = "0x187970500")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x79706F0", Offset = "0x796FAF0", VA = "0x1879706F0")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x796CA60", Offset = "0x796BE60", VA = "0x18796CA60")]
		protected void DFHMOGOGPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x796E570", Offset = "0x796D970", VA = "0x18796E570")]
		private void NAOEKBONOCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x79716C0", Offset = "0x7970AC0", VA = "0x1879716C0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9F69F0", Offset = "0x9F5DF0", VA = "0x1809F69F0", Slot = "4")]
		private bool LDCBNFHEIEE()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LICIHKOBOOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public string LIPJOHOCCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public int NKGPMMKCOJL;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct NJJHACMGNDP : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x796B180", Offset = "0x796A580", VA = "0x18796B180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct ACNHGCGODNA : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x7965560", Offset = "0x7964960", VA = "0x187965560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7965A60", Offset = "0x7964E60", VA = "0x187965A60", Slot = "5")]
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
		public LOHMIPEBFLA avatarBodyType;

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
		public AELCGAALLCD useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public AOFLICKOANP hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public LOLKEBDAHDP HatAnchorRestrictions;

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
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private JKBKGMHAJBG MDNOLAHHAPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		[SerializeField]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private AnimatorOverrideController PPIEHFABILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> DBCBCJDNBAF;

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
		public readonly LICIHKOBOOM[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public readonly (string, KGMJJNNLLGP)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		protected bool IPHKKJNBPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		protected Guid PLIOOHGKIOB;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		protected static Guid FNHJJBCDJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private CKKICPFEDGL AJHJLCJJKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private GNHNBKMHFPD HIHJEFNEKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private OHNJHAOHDGP JJJKKIKLIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private OHNJHAOHDGP KAACODCEGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private AdditionalHatData LIKBKDELNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private readonly Dictionary<GameObject, EAHNLELNCAK> JOEPGCGDJEB;

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public static Func<EACKHGFMFHP> HECCNNBHGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7976CD0", Offset = "0x79760D0", VA = "0x187976CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7977310", Offset = "0x7976710", VA = "0x187977310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool AONCAEOIDCG
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7976E30", Offset = "0x7976230", VA = "0x187976E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool OAONNHEAEJP
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7976D20", Offset = "0x7976120", VA = "0x187976D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public PlayerAvatarDisplayBase IPJCKAFDFKP
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xA790E0", Offset = "0xA784E0", VA = "0x180A790E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		protected static Guid DFBMIJCIGBH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7973D50", Offset = "0x7973150", VA = "0x187973D50")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public (GameObject, MJGMDPCOPJP)[] OHELICKGGFN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x7976F40", Offset = "0x7976340", VA = "0x187976F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x79749E0", Offset = "0x7973DE0", VA = "0x1879749E0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x79722D0", Offset = "0x79716D0", VA = "0x1879722D0")]
		private IEnumerable<GameObject> BAFCENOGMPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7974ED0", Offset = "0x79742D0", VA = "0x187974ED0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7972760", Offset = "0x7971B60", VA = "0x187972760")]
		private void BFKMNMPGNIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x11FE000", Offset = "0x11FD400", VA = "0x1811FE000")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7973E40", Offset = "0x7973240", VA = "0x187973E40")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7974EE0", Offset = "0x79742E0", VA = "0x187974EE0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7974CD0", Offset = "0x79740D0", VA = "0x187974CD0")]
		public void ShowPose(AnimationClip MFAHBOICLFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7974EA0", Offset = "0x79742A0", VA = "0x187974EA0")]
		public void ShowPose(string CLGOPECALBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7974B30", Offset = "0x7973F30", VA = "0x187974B30")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x79749F0", Offset = "0x7973DF0", VA = "0x1879749F0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x79759B0", Offset = "0x7974DB0", VA = "0x1879759B0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7975800", Offset = "0x7974C00", VA = "0x187975800")]
		public void UpdateFaceAndBodyShapes(bool HJCHKMOBDNG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7975DB0", Offset = "0x79751B0", VA = "0x187975DB0")]
		public void UpdateNoseShape(EKLJAOFDFFM EFBDDCCBBIN, bool HJCHKMOBDNG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7975D80", Offset = "0x7975180", VA = "0x187975D80")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7972840", Offset = "0x7971C40", VA = "0x187972840", Slot = "4")]
		protected virtual void BOOPOHCFAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x79735B0", Offset = "0x79729B0", VA = "0x1879735B0", Slot = "5")]
		protected virtual void GDACGMCJBPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7971F00", Offset = "0x7971300", VA = "0x187971F00")]
		public void ApplyHatData(AdditionalHatData DLDAPNFMGOG, bool KHALHNDCFBA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7971D40", Offset = "0x7971140", VA = "0x187971D40")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7972260", Offset = "0x7971660", VA = "0x187972260")]
		public void ApplyHatUVOverride(Vector2 EDNOICIECBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7972180", Offset = "0x7971580", VA = "0x187972180")]
		public void ApplyHatPositionAdjustment(Vector3 GFMKDDJOPLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x79721F0", Offset = "0x79715F0", VA = "0x1879721F0")]
		public void ApplyHatRotationAdjustment(Vector3 HCIBMENGKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7972B50", Offset = "0x7971F50", VA = "0x187972B50")]
		public HJAIALMMLAJ BuildAvatarItemSelection(GameObject EBEKPKOFICL, LOHMIPEBFLA IGEPGIJPCPL, MJGMDPCOPJP MFKCMECFFAH)
		{
			return default(HJAIALMMLAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7972BF0", Offset = "0x7971FF0", VA = "0x187972BF0")]
		public void BuildAvatar(bool HJCHKMOBDNG = false, bool KHALHNDCFBA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7975240", Offset = "0x7974640", VA = "0x187975240")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7971E80", Offset = "0x7971280", VA = "0x187971E80")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7975BD0", Offset = "0x7974FD0", VA = "0x187975BD0")]
		public void UpdateHatAnchor(bool KHALHNDCFBA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7975900", Offset = "0x7974D00", VA = "0x187975900")]
		[AsyncStateMachine(typeof(NJJHACMGNDP))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7973210", Offset = "0x7972610", VA = "0x187973210")]
		[AsyncStateMachine(typeof(ACNHGCGODNA))]
		private Task DFJIFCCMBPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x79732E0", Offset = "0x79726E0", VA = "0x1879732E0")]
		private void GBHGJBANDFI(FaceFeatureType IBMEGOHDDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7974950", Offset = "0x7973D50", VA = "0x187974950")]
		private void PMDNEELGEHG(FaceFeatureType IBMEGOHDDJB, [Out] float IHLKBBGENAM, [Out] float CCNFAMDHJJH, [Out] float KPABPLHPKDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x79756C0", Offset = "0x7974AC0", VA = "0x1879756C0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7975A60", Offset = "0x7974E60", VA = "0x187975A60")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7973820", Offset = "0x7972C20", VA = "0x187973820")]
		private void GEDMFBFGBEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		private void DLOAENEODEK(EAHNLELNCAK INDBGNLJGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		private void NODFGECAMPD(EAHNLELNCAK INDBGNLJGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x79745F0", Offset = "0x79739F0", VA = "0x1879745F0")]
		private void NIAAEAJFHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7975E40", Offset = "0x7975240", VA = "0x187975E40")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7974540", Offset = "0x7973940", VA = "0x187974540")]
		[CompilerGenerated]
		private HJAIALMMLAJ KKHMGCNEPND((GameObject, MJGMDPCOPJP) AINELBBEFLN)
		{
			return default(HJAIALMMLAJ);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[SerializeField]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct HJAIALMMLAJ
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IEAFDGALJBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public IEAFDGALJBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7969970", Offset = "0x7968D70", VA = "0x187969970")]
		internal bool LLNHGFBLFOI(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private EAHNLELNCAK PLNEJLOMKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private MJGMDPCOPJP DPFIJOOHOIM;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public EAHNLELNCAK MKHACCANOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public MJGMDPCOPJP MGIEBOLKHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E10", Offset = "0xCE6210", VA = "0x180CE6E10")]
		get
		{
			return default(MJGMDPCOPJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string BCNFMIOEPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7969420", Offset = "0x7968820", VA = "0x187969420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool LOAHNCGGKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x79692B0", Offset = "0x79686B0", VA = "0x1879692B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool JJBPDMEBJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7969300", Offset = "0x7968700", VA = "0x187969300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x1729F40", Offset = "0x1729340", VA = "0x181729F40")]
	public HJAIALMMLAJ(EAHNLELNCAK INDBGNLJGMK, MJGMDPCOPJP DFKGNLKKCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7969350", Offset = "0x7968750", VA = "0x187969350")]
	public bool EMEHFLLFDJI(OutfitType OKFGAPFKLHH, MJGMDPCOPJP KMCGCBHIOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7969510", Offset = "0x7968910", VA = "0x187969510")]
	public bool KBAEOGLBOBN(OutfitType OKFGAPFKLHH, MJGMDPCOPJP KMCGCBHIOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7969780", Offset = "0x7968B80", VA = "0x187969780")]
	public bool OCACGJAEHAO(HJAIALMMLAJ GHHIMAAKGNP)
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
