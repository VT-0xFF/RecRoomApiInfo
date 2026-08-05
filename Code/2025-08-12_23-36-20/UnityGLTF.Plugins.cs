using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using GLTF.Schema;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityGLTF.Plugins;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	internal class TempAssignClip : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int audioSourceIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string audioPath;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[JNCAHPHEIBE(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9E50310", Offset = "0x9E4F110", VA = "0x189E50310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9E502E0", Offset = "0x9E4F0E0", VA = "0x189E502E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9E50280", Offset = "0x9E4F080", VA = "0x189E50280", Slot = "14")]
		public override IOHNIAGNAKL CNHDEGPOMJC(KJEAOHGPMOC KKBNGKDBMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[JNCAHPHEIBE(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9E504E0", Offset = "0x9E4F2E0", VA = "0x189E504E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9E504B0", Offset = "0x9E4F2B0", VA = "0x189E504B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9E50340", Offset = "0x9E4F140", VA = "0x189E50340", Slot = "13")]
		public override HOEJKGJHHEK CNHDEGPOMJC(BLJFBPHGAMF KKBNGKDBMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public AudioImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DKMPIJDGCLO : HOEJKGJHHEK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class NDHLINHGKOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AudioSource FBABCNPBHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AudioDataId LJGJMJLFKGN;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
		public NDHLINHGKOI(AudioSource FBABCNPBHOI, AudioDataId EEIEBJBJJOK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BLJFBPHGAMF GPOHMLEHCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KHR_audio_emitter LIFEAIOALIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private List<NDHLINHGKOI> EHCLJJEAOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<int, AudioClip> CJKHALEDDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Dictionary<int, string> IEPKDIGANMH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9E52920", Offset = "0x9E51720", VA = "0x189E52920")]
	public DKMPIJDGCLO(BLJFBPHGAMF KKBNGKDBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9E51900", Offset = "0x9E50700", VA = "0x189E51900")]
	private void KOGDDHEAKIF(JKAIJADDELF MMENCBNBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9E51900", Offset = "0x9E50700", VA = "0x189E51900", Slot = "6")]
	public override void MDDKDCBKJBN(JKAIJADDELF FGOEPDIJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9E51E40", Offset = "0x9E50C40", VA = "0x189E51E40")]
	private void MKCLKDPOFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9E51550", Offset = "0x9E50350", VA = "0x189E51550")]
	private string DPGNNJAFBMK(string DPDAOJBIEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9E51800", Offset = "0x9E50600", VA = "0x189E51800")]
	private AudioType IBFABEKAMPF(string DPDAOJBIEFI)
	{
		return default(AudioType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9E520B0", Offset = "0x9E50EB0", VA = "0x189E520B0")]
	private void MOGGEEGEPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9E52680", Offset = "0x9E51480", VA = "0x189E52680")]
	private void OEDBPHHFEEK(GameObject DOBAJNECPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9E51A80", Offset = "0x9E50880", VA = "0x189E51A80")]
	private void MEIMKLGDFIK(KHR_AudioEmitter HOBDNCGHKIN, GameObject MNDFFFGGEND, bool FBHBPKCAJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9E51510", Offset = "0x9E50310", VA = "0x189E51510", Slot = "11")]
	public override void ACDGPHCIDOF(MIKFGIALEDD OKCGKPEIJGC, int KDKEOFJAODJ, GameObject DOBAJNECPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9E51670", Offset = "0x9E50470", VA = "0x189E51670", Slot = "8")]
	public override void EFGCBEGDIDE(NMPNDLGKGCA DFHOHFFNCIJ, int AIKEBLPMPJO, GameObject CPEHOMOBIAG)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[NDDIODBFEPP(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9E50650", Offset = "0x9E4F450", VA = "0x189E50650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9E50620", Offset = "0x9E4F420", VA = "0x189E50620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9E50510", Offset = "0x9E4F310", VA = "0x189E50510", Slot = "14")]
		public override IOHNIAGNAKL CNHDEGPOMJC(KJEAOHGPMOC KKBNGKDBMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public BakeParticleSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CDLIEOPBCOP : IOHNIAGNAKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> CMGNBLHNHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<UnityEngine.Object> DCEPAJHKIHJ;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9E50720", Offset = "0x9E4F520", VA = "0x189E50720", Slot = "7")]
	public override void IBMNLBJHGAA(LMEGNAPBGNK FBAAFJJHNND, JKAIJADDELF FGOEPDIJFCK, Transform DNNOOFELIOA, NMPNDLGKGCA DFHOHFFNCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9E50980", Offset = "0x9E4F780", VA = "0x189E50980", Slot = "5")]
	public override void KGNNMCEJCEJ(LMEGNAPBGNK FBAAFJJHNND, JKAIJADDELF FGOEPDIJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9E50680", Offset = "0x9E4F480", VA = "0x189E50680")]
	private static void HAJMMGOBAOA(UnityEngine.Object CFLDGKLFNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9E50C80", Offset = "0x9E4FA80", VA = "0x189E50C80")]
	public CDLIEOPBCOP()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NDDIODBFEPP(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9E514E0", Offset = "0x9E502E0", VA = "0x189E514E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9E514B0", Offset = "0x9E502B0", VA = "0x189E514B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9E51460", Offset = "0x9E50260", VA = "0x189E51460", Slot = "14")]
		public override IOHNIAGNAKL CNHDEGPOMJC(KJEAOHGPMOC KKBNGKDBMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public CanvasExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IAEENCBJCGL : IOHNIAGNAKL
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static Shader HLFLBIJHOIB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9E52B50", Offset = "0x9E51950", VA = "0x189E52B50", Slot = "8")]
	public override void PGHKFALNCCE(LMEGNAPBGNK FBAAFJJHNND, JKAIJADDELF MMENCBNBOBJ, Transform DNNOOFELIOA, NMPNDLGKGCA DFHOHFFNCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public IAEENCBJCGL()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu(null)]
	internal class CanvasExportCaptureMeshHelper : MonoBehaviour, IMeshModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Mesh PKBJPDPONKJ;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void ModifyMesh(Mesh PKBJPDPONKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9E51380", Offset = "0x9E50180", VA = "0x189E51380", Slot = "5")]
		public void ModifyMesh(VertexHelper HLIMDLBHPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9E50F50", Offset = "0x9E4FD50", VA = "0x189E50F50")]
		public bool GetMeshAndMaterial([Out] Mesh PKBJPDPONKJ, [Out] Material GKIFPALLDIK, Shader HLFLBIJHOIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9E50D50", Offset = "0x9E4FB50", VA = "0x189E50D50")]
		public void CaptureTo(Transform MMENCBNBOBJ, GameObject ENEBLMPFBCD, Shader HLFLBIJHOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public CanvasExportCaptureMeshHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MaterialVariants : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class Variant
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public class MaterialSet
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public Transform transform;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public Material[] sharedMaterials;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
				public MaterialSet()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public List<MaterialSet> activeSets;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public Variant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Material invisibleMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public List<Variant> variants;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[NDDIODBFEPP(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9E542A0", Offset = "0x9E530A0", VA = "0x189E542A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9E54270", Offset = "0x9E53070", VA = "0x189E54270", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9E54220", Offset = "0x9E53020", VA = "0x189E54220", Slot = "14")]
		public override IOHNIAGNAKL CNHDEGPOMJC(KJEAOHGPMOC KKBNGKDBMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public MaterialVariantsPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AOBINCMPLPF : IOHNIAGNAKL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class PIBEFLGNJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Transform node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PIBEFLGNJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9E542D0", Offset = "0x9E530D0", VA = "0x189E542D0")]
		internal bool PLEHGHFLMJJ(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FOGJJFOEOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int subMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Material exportMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PIBEFLGNJMA CS$<>8__locals1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FOGJJFOEOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9E52A60", Offset = "0x9E51860", VA = "0x189E52A60")]
		internal bool GEEMPGHCJHB(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x9E4EF60", Offset = "0x9E4DD60", VA = "0x189E4EF60", Slot = "5")]
	public override void KGNNMCEJCEJ(LMEGNAPBGNK FBAAFJJHNND, JKAIJADDELF EODMJPIPLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public AOBINCMPLPF()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : DECBOJDHDDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9E53F90", Offset = "0x9E52D90", VA = "0x189E53F90", Slot = "4")]
		public JProperty OFACCHGGJAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9E53F20", Offset = "0x9E52D20", VA = "0x189E53F20", Slot = "5")]
		public DECBOJDHDDE BKCDCCJFPOM(JKAIJADDELF MMENCBNBOBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : DECBOJDHDDE
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class MappingVariant
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int[] variantIndices;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9E541A0", Offset = "0x9E52FA0", VA = "0x189E541A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private LMEGNAPBGNK exporter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9E53E80", Offset = "0x9E52C80", VA = "0x189E53E80")]
		public KHR_materials_variants(LMEGNAPBGNK FBAAFJJHNND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9E53D00", Offset = "0x9E52B00", VA = "0x189E53D00", Slot = "4")]
		public JProperty OFACCHGGJAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9E53980", Offset = "0x9E52780", VA = "0x189E53980", Slot = "5")]
		public DECBOJDHDDE BKCDCCJFPOM(JKAIJADDELF MMENCBNBOBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9E53B10", Offset = "0x9E52910", VA = "0x189E53B10")]
		[CompilerGenerated]
		private JObject BMGIHBFPELB(MappingVariant DBBMOEGPNPP)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class AGLEKLABNCC : IOHNIAGNAKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> OGFLMOMBAGP;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9E4E630", Offset = "0x9E4D430", VA = "0x189E4E630", Slot = "7")]
			public override void IBMNLBJHGAA(LMEGNAPBGNK FBAAFJJHNND, JKAIJADDELF FGOEPDIJFCK, Transform DNNOOFELIOA, NMPNDLGKGCA DFHOHFFNCIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9E4ED30", Offset = "0x9E4DB30", VA = "0x189E4ED30", Slot = "5")]
			public override void KGNNMCEJCEJ(LMEGNAPBGNK FBAAFJJHNND, JKAIJADDELF FGOEPDIJFCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9E4EED0", Offset = "0x9E4DCD0", VA = "0x189E4EED0")]
			public AGLEKLABNCC()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct OIJCEOAEODF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Rect texRect;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Vector2 uvMin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public Vector2 uvMax;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public ushort[] newTris;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int index;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9E55AC0", Offset = "0x9E548C0", VA = "0x189E55AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9E54340", Offset = "0x9E53140", VA = "0x189E54340", Slot = "14")]
		public override IOHNIAGNAKL CNHDEGPOMJC(KJEAOHGPMOC KKBNGKDBMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9E54400", Offset = "0x9E53200", VA = "0x189E54400")]
		private static (Vector2[], ushort[], Vector2[]) DNFOIHEALPF(SpriteRenderer NNEJGKAIJNN, Sprite BCNAMAKCMNM)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9E558C0", Offset = "0x9E546C0", VA = "0x189E558C0")]
		[CompilerGenerated]
		internal static Vector2 KNPACCBHJCJ(float JPECHLPIEMM, float DPODBJGMEGM, OIJCEOAEODF P_2)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9E559C0", Offset = "0x9E547C0", VA = "0x189E559C0")]
		[CompilerGenerated]
		internal static void PPNKBLGHLGL(ushort GENJGFGGINA, ushort KMNEIBIPMKI, ushort JMOOEAFLFLP, ushort DKAEMMPPGGA, OIJCEOAEODF P_4)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TextMeshGameObjectExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9E55B70", Offset = "0x9E54970", VA = "0x189E55B70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9E55B40", Offset = "0x9E54940", VA = "0x189E55B40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9E55AF0", Offset = "0x9E548F0", VA = "0x189E55AF0", Slot = "14")]
		public override IOHNIAGNAKL CNHDEGPOMJC(KJEAOHGPMOC KKBNGKDBMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public TextMeshGameObjectExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KBLDLIBLGLH : IOHNIAGNAKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<Texture, RenderTexture> DFEPFONLEMI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9E532A0", Offset = "0x9E520A0", VA = "0x189E532A0", Slot = "5")]
	public override void KGNNMCEJCEJ(LMEGNAPBGNK OGPILIPEPKA, JKAIJADDELF LPALLJHCFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9E53200", Offset = "0x9E52000", VA = "0x189E53200", Slot = "7")]
	public override void IBMNLBJHGAA(LMEGNAPBGNK FBAAFJJHNND, JKAIJADDELF FGOEPDIJFCK, Transform DNNOOFELIOA, NMPNDLGKGCA DFHOHFFNCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9E53410", Offset = "0x9E52210", VA = "0x189E53410", Slot = "9")]
	public override bool OIDJDFAPHLH(LMEGNAPBGNK FBAAFJJHNND, JKAIJADDELF FGOEPDIJFCK, Material GKIFPALLDIK, BNLLBMEIJFE DLDHEOOLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public KBLDLIBLGLH()
	{
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
