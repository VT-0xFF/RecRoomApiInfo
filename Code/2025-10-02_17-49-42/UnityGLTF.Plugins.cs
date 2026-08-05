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
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[LEOIFONIILC(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9FEC110", Offset = "0x9FEAB10", VA = "0x189FEC110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9FEC0E0", Offset = "0x9FEAAE0", VA = "0x189FEC0E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9FEC080", Offset = "0x9FEAA80", VA = "0x189FEC080", Slot = "14")]
		public override FJKHHJKCAII GKPAIOOMAFO(KCCHBFECOED IJNPIDPIBFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[LEOIFONIILC(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9FEC2E0", Offset = "0x9FEACE0", VA = "0x189FEC2E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9FEC2B0", Offset = "0x9FEACB0", VA = "0x189FEC2B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9FEC140", Offset = "0x9FEAB40", VA = "0x189FEC140", Slot = "13")]
		public override EPODMCKGHHF GKPAIOOMAFO(EIKEJCINPBC IJNPIDPIBFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public AudioImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NANHANGJDED : EPODMCKGHHF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class PAAIKPDECIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AudioSource FNBEJKIAEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AudioDataId OMJBMFFJKAM;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
		public PAAIKPDECIE(AudioSource FNBEJKIAEFA, AudioDataId HLAHMHCEOGH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EIKEJCINPBC MLODABLCFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KHR_audio_emitter IPENGIDBAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private List<PAAIKPDECIE> EBBLCOMIEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<int, AudioClip> MMLDEFLBCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Dictionary<int, string> LJIHCIILBGL;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9FF1BC0", Offset = "0x9FF05C0", VA = "0x189FF1BC0")]
	public NANHANGJDED(EIKEJCINPBC IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9FF1570", Offset = "0x9FEFF70", VA = "0x189FF1570")]
	private void CGDKEMCEKAM(PJMAOFGKAFA FAIGKPPBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9FF1570", Offset = "0x9FEFF70", VA = "0x189FF1570", Slot = "6")]
	public override void LIELEMDPLAJ(PJMAOFGKAFA EHNGFOMGHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9FF16F0", Offset = "0x9FF00F0", VA = "0x189FF16F0")]
	private void FBOEOBGJKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9FF1A60", Offset = "0x9FF0460", VA = "0x189FF1A60")]
	private string HEHMMFCPFBJ(string DJPFGOODJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9FF1960", Offset = "0x9FF0360", VA = "0x189FF1960")]
	private AudioType GEDKIOIMILD(string DJPFGOODJDG)
	{
		return default(AudioType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9FF07A0", Offset = "0x9FEF1A0", VA = "0x189FF07A0")]
	private void AIIIPDHCBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9FF0D80", Offset = "0x9FEF780", VA = "0x189FF0D80")]
	private void BCKKPGIIABL(GameObject IPONPCAJKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9FF1020", Offset = "0x9FEFA20", VA = "0x189FF1020")]
	private void BKGPAGMEJIH(KHR_AudioEmitter LEFLOIONHDF, GameObject HHPKLJOBAIC, bool KGJECCJJHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9FF1B80", Offset = "0x9FF0580", VA = "0x189FF1B80", Slot = "11")]
	public override void LKAMMIOAMCB(LDCDIKCHLMA LDEJAMJEHAA, int CPJFOBILFKL, GameObject IPONPCAJKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9FF13E0", Offset = "0x9FEFDE0", VA = "0x189FF13E0", Slot = "8")]
	public override void CDMDKENJLEE(OGLNHONLBCN MNHKIMAOFNO, int HIJPLBHNIIL, GameObject EKAOFDOLJKC)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[IBMPMMJKBKM(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9FEC450", Offset = "0x9FEAE50", VA = "0x189FEC450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9FEC420", Offset = "0x9FEAE20", VA = "0x189FEC420", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9FEC310", Offset = "0x9FEAD10", VA = "0x189FEC310", Slot = "14")]
		public override FJKHHJKCAII GKPAIOOMAFO(KCCHBFECOED IJNPIDPIBFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public BakeParticleSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LGKJEECNFEO : FJKHHJKCAII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> MJPPMGCIKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<UnityEngine.Object> MLJKGKCKNGN;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9FEF500", Offset = "0x9FEDF00", VA = "0x189FEF500", Slot = "7")]
	public override void MHCMEHGEANG(MDCIFLJGAKO AGJGIEFNLLE, PJMAOFGKAFA EHNGFOMGHEC, Transform HALOMIKDIAH, OGLNHONLBCN MNHKIMAOFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9FEF160", Offset = "0x9FEDB60", VA = "0x189FEF160", Slot = "5")]
	public override void EICOILFDMAM(MDCIFLJGAKO AGJGIEFNLLE, PJMAOFGKAFA EHNGFOMGHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9FEF460", Offset = "0x9FEDE60", VA = "0x189FEF460")]
	private static void EMJNINPHCLL(UnityEngine.Object NALAIDLJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9FEF760", Offset = "0x9FEE160", VA = "0x189FEF760")]
	public LGKJEECNFEO()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[IBMPMMJKBKM(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9FEDF50", Offset = "0x9FEC950", VA = "0x189FEDF50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9FEDF20", Offset = "0x9FEC920", VA = "0x189FEDF20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9FEDED0", Offset = "0x9FEC8D0", VA = "0x189FEDED0", Slot = "14")]
		public override FJKHHJKCAII GKPAIOOMAFO(KCCHBFECOED IJNPIDPIBFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public CanvasExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LOMDAIAKKGJ : FJKHHJKCAII
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static Shader GLHHKGKLKIE;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9FEF830", Offset = "0x9FEE230", VA = "0x189FEF830", Slot = "8")]
	public override void EIBHIHBHPEG(MDCIFLJGAKO AGJGIEFNLLE, PJMAOFGKAFA FAIGKPPBFHA, Transform HALOMIKDIAH, OGLNHONLBCN MNHKIMAOFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public LOMDAIAKKGJ()
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
		private Mesh KGGOMLADPBD;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void ModifyMesh(Mesh KGGOMLADPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9FEDDF0", Offset = "0x9FEC7F0", VA = "0x189FEDDF0", Slot = "5")]
		public void ModifyMesh(VertexHelper JOHBJJKGLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9FED9C0", Offset = "0x9FEC3C0", VA = "0x189FED9C0")]
		public bool GetMeshAndMaterial([Out] Mesh KGGOMLADPBD, [Out] Material PJPBFBIEGMK, Shader GLHHKGKLKIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9FED7C0", Offset = "0x9FEC1C0", VA = "0x189FED7C0")]
		public void CaptureTo(Transform FAIGKPPBFHA, GameObject ELCNKDHGFEA, Shader GLHHKGKLKIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[IBMPMMJKBKM(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9FF0770", Offset = "0x9FEF170", VA = "0x189FF0770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9FF0740", Offset = "0x9FEF140", VA = "0x189FF0740", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9FF06F0", Offset = "0x9FEF0F0", VA = "0x189FF06F0", Slot = "14")]
		public override FJKHHJKCAII GKPAIOOMAFO(KCCHBFECOED IJNPIDPIBFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public MaterialVariantsPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CGGKGPLBPGN : FJKHHJKCAII
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class HIJOKLKADMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Transform node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HIJOKLKADMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9FEE8C0", Offset = "0x9FED2C0", VA = "0x189FEE8C0")]
		internal bool LBNLIEMECBN(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PNAHBEGKBNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int subMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Material exportMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HIJOKLKADMC CS$<>8__locals1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PNAHBEGKBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9FF1D00", Offset = "0x9FF0700", VA = "0x189FF1D00")]
		internal bool BLDMILDJHEG(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x9FEC480", Offset = "0x9FEAE80", VA = "0x189FEC480", Slot = "5")]
	public override void EICOILFDMAM(MDCIFLJGAKO AGJGIEFNLLE, PJMAOFGKAFA IFDEKIJIEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public CGGKGPLBPGN()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : MIHMDPBIHOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9FEEF40", Offset = "0x9FED940", VA = "0x189FEEF40", Slot = "4")]
		public JProperty GCGCKFHBJPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9FEEED0", Offset = "0x9FED8D0", VA = "0x189FEEED0", Slot = "5")]
		public MIHMDPBIHOE AFCIIKKNNFA(PJMAOFGKAFA FAIGKPPBFHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : MIHMDPBIHOE
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
			[Cpp2IlInjected.Address(RVA = "0x9FF0670", Offset = "0x9FEF070", VA = "0x189FF0670", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private MDCIFLJGAKO exporter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9FEEE30", Offset = "0x9FED830", VA = "0x189FEEE30")]
		public KHR_materials_variants(MDCIFLJGAKO AGJGIEFNLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9FEECB0", Offset = "0x9FED6B0", VA = "0x189FEECB0", Slot = "4")]
		public JProperty GCGCKFHBJPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9FEE930", Offset = "0x9FED330", VA = "0x189FEE930", Slot = "5")]
		public MIHMDPBIHOE AFCIIKKNNFA(PJMAOFGKAFA FAIGKPPBFHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9FEEAC0", Offset = "0x9FED4C0", VA = "0x189FEEAC0")]
		[CompilerGenerated]
		private JObject DDJGFHCIPEG(MappingVariant FKPKEFAKAOE)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class EADPOIDJGDH : FJKHHJKCAII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> COKCJJCHKLE;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9FEE120", Offset = "0x9FECB20", VA = "0x189FEE120", Slot = "7")]
			public override void MHCMEHGEANG(MDCIFLJGAKO AGJGIEFNLLE, PJMAOFGKAFA EHNGFOMGHEC, Transform HALOMIKDIAH, OGLNHONLBCN MNHKIMAOFNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9FEDF80", Offset = "0x9FEC980", VA = "0x189FEDF80", Slot = "5")]
			public override void EICOILFDMAM(MDCIFLJGAKO AGJGIEFNLLE, PJMAOFGKAFA EHNGFOMGHEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9FEE830", Offset = "0x9FED230", VA = "0x189FEE830")]
			public EADPOIDJGDH()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct JHLCDDNLEDI
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
			[Cpp2IlInjected.Address(RVA = "0x9FF3570", Offset = "0x9FF1F70", VA = "0x189FF3570", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9FF1EF0", Offset = "0x9FF08F0", VA = "0x189FF1EF0", Slot = "14")]
		public override FJKHHJKCAII GKPAIOOMAFO(KCCHBFECOED IJNPIDPIBFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9FF1FB0", Offset = "0x9FF09B0", VA = "0x189FF1FB0")]
		private static (Vector2[], ushort[], Vector2[]) JBILGBKDFEP(SpriteRenderer ALKNEOONPNG, Sprite DGCMKKGIIIC)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9FF3470", Offset = "0x9FF1E70", VA = "0x189FF3470")]
		[CompilerGenerated]
		internal static Vector2 KEEILKDJJOO(float DAGJAGBHOFK, float NNMIAILGNGC, JHLCDDNLEDI P_2)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9FF1DF0", Offset = "0x9FF07F0", VA = "0x189FF1DF0")]
		[CompilerGenerated]
		internal static void BLLAEKOOIKE(ushort EICJFDNFOCB, ushort MIBIEOGGIAP, ushort DMCCCPMAFCP, ushort JHDCFCMBFOH, JHLCDDNLEDI P_4)
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
			[Cpp2IlInjected.Address(RVA = "0x9FF3620", Offset = "0x9FF2020", VA = "0x189FF3620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9FF35F0", Offset = "0x9FF1FF0", VA = "0x189FF35F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9FF35A0", Offset = "0x9FF1FA0", VA = "0x189FF35A0", Slot = "14")]
		public override FJKHHJKCAII GKPAIOOMAFO(KCCHBFECOED IJNPIDPIBFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public TextMeshGameObjectExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MNGIGOCDOHJ : FJKHHJKCAII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<Texture, RenderTexture> JIOIEDIDBHF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9FF0460", Offset = "0x9FEEE60", VA = "0x189FF0460", Slot = "5")]
	public override void EICOILFDMAM(MDCIFLJGAKO HBELCFIJGKE, PJMAOFGKAFA FDMKKJHCPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9FF05D0", Offset = "0x9FEEFD0", VA = "0x189FF05D0", Slot = "7")]
	public override void MHCMEHGEANG(MDCIFLJGAKO AGJGIEFNLLE, PJMAOFGKAFA EHNGFOMGHEC, Transform HALOMIKDIAH, OGLNHONLBCN MNHKIMAOFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9FEFEF0", Offset = "0x9FEE8F0", VA = "0x189FEFEF0", Slot = "9")]
	public override bool BNJGMCAMNCM(MDCIFLJGAKO AGJGIEFNLLE, PJMAOFGKAFA EHNGFOMGHEC, Material PJPBFBIEGMK, NMLLOJDOHNK ICJJPBCOPJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public MNGIGOCDOHJ()
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
