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
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BLFADFOELKL(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9DAEC90", Offset = "0x9DAD690", VA = "0x189DAEC90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9DAEC60", Offset = "0x9DAD660", VA = "0x189DAEC60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEC00", Offset = "0x9DAD600", VA = "0x189DAEC00", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[BLFADFOELKL(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9DAEE60", Offset = "0x9DAD860", VA = "0x189DAEE60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9DAEE30", Offset = "0x9DAD830", VA = "0x189DAEE30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAECC0", Offset = "0x9DAD6C0", VA = "0x189DAECC0", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public AudioImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HLCOELNJCNK : CIAGMPPOCJL
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class LIIFBEIFCLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AudioSource KBMMHDOGEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AudioDataId MBOBEDAKEMO;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
		public LIIFBEIFCLI(AudioSource KBMMHDOGEHK, AudioDataId OABBAPFEEAF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IGCMHMGLAFB ALGKMHPMAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KHR_audio_emitter NKPJGIGHEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private List<LIIFBEIFCLI> IACJGFKJNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<int, AudioClip> IKFNGAOBLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Dictionary<int, string> FMFOJHDCOBH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9DB36B0", Offset = "0x9DB20B0", VA = "0x189DB36B0")]
	public HLCOELNJCNK(IGCMHMGLAFB HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9DB2640", Offset = "0x9DB1040", VA = "0x189DB2640")]
	private void IAGBOIAFICN(EFAGEPFJOIC PJFDNMGHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9DB2640", Offset = "0x9DB1040", VA = "0x189DB2640", Slot = "6")]
	public override void CLLJJMJMEOK(EFAGEPFJOIC MLPDGDMMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9DB27C0", Offset = "0x9DB11C0", VA = "0x189DB27C0")]
	private void EACINPNCDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9DB3010", Offset = "0x9DB1A10", VA = "0x189DB3010")]
	private string HDHNPGABKOM(string EKLKIKNENMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9DB3130", Offset = "0x9DB1B30", VA = "0x189DB3130")]
	private AudioType IAGFCLNNJEH(string EKLKIKNENMK)
	{
		return default(AudioType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9DB2A30", Offset = "0x9DB1430", VA = "0x189DB2A30")]
	private void FLDHMEIAOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9DB3230", Offset = "0x9DB1C30", VA = "0x189DB3230")]
	private void KAPCGKLDNAK(GameObject OPPPNBNEPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9DB2280", Offset = "0x9DB0C80", VA = "0x189DB2280")]
	private void ACFNIPABPBC(KHR_AudioEmitter HNMOJPKOHIP, GameObject JNBPODMNOLD, bool BKFMDEBGJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9DB34E0", Offset = "0x9DB1EE0", VA = "0x189DB34E0", Slot = "11")]
	public override void LJNEAGOLBKP(DEMHKDOKLMC FPJGDNNEOIB, int HKMFODDFBIF, GameObject OPPPNBNEPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9DB3520", Offset = "0x9DB1F20", VA = "0x189DB3520", Slot = "8")]
	public override void MFHCGMINBHG(BEPOCDMOBMH AAPGFEFGBOK, int PBKEGCHOAEH, GameObject HKLEFEBJHLN)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[GNBDMJMBJHD(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9DAFE10", Offset = "0x9DAE810", VA = "0x189DAFE10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9DAFDE0", Offset = "0x9DAE7E0", VA = "0x189DAFDE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFCD0", Offset = "0x9DAE6D0", VA = "0x189DAFCD0", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public BakeParticleSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MNECEJOCBFE : PDBJIPMJIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> NLNMFEAKFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<UnityEngine.Object> BPHNMKOHDCB;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9DB4110", Offset = "0x9DB2B10", VA = "0x189DB4110", Slot = "7")]
	public override void FKKFHAJNHOK(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9DB4410", Offset = "0x9DB2E10", VA = "0x189DB4410", Slot = "5")]
	public override void ODKAGIAEEAB(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9DB4370", Offset = "0x9DB2D70", VA = "0x189DB4370")]
	private static void MANPENHPKPJ(UnityEngine.Object EJBIGGIEBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9DB4710", Offset = "0x9DB3110", VA = "0x189DB4710")]
	public MNECEJOCBFE()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[GNBDMJMBJHD(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9DB2250", Offset = "0x9DB0C50", VA = "0x189DB2250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9DB2220", Offset = "0x9DB0C20", VA = "0x189DB2220", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DB21D0", Offset = "0x9DB0BD0", VA = "0x189DB21D0", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public CanvasExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BACONDNMHLK : PDBJIPMJIIJ
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static Shader GJIEMLKGCHL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9DAEE90", Offset = "0x9DAD890", VA = "0x189DAEE90", Slot = "8")]
	public override void MEPLLBKDIJM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC PJFDNMGHMBL, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public BACONDNMHLK()
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
		private Mesh HFCMFMCGELA;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		public void ModifyMesh(Mesh HFCMFMCGELA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB20F0", Offset = "0x9DB0AF0", VA = "0x189DB20F0", Slot = "5")]
		public void ModifyMesh(VertexHelper LOJLNAOLIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1CC0", Offset = "0x9DB06C0", VA = "0x189DB1CC0")]
		public bool GetMeshAndMaterial([Out] Mesh HFCMFMCGELA, [Out] Material POCHLMCAOAO, Shader GJIEMLKGCHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1AC0", Offset = "0x9DB04C0", VA = "0x189DB1AC0")]
		public void CaptureTo(Transform PJFDNMGHMBL, GameObject JEMECPKCKEC, Shader GJIEMLKGCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
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
				[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[GNBDMJMBJHD(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9DB48E0", Offset = "0x9DB32E0", VA = "0x189DB48E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9DB48B0", Offset = "0x9DB32B0", VA = "0x189DB48B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4860", Offset = "0x9DB3260", VA = "0x189DB4860", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public MaterialVariantsPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CBJIDIEFMJA : PDBJIPMJIIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class AJHGDPOAMCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Transform node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AJHGDPOAMCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEB90", Offset = "0x9DAD590", VA = "0x189DAEB90")]
		internal bool AFLBCGJGMKE(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KJHKEIABFAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int subMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Material exportMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AJHGDPOAMCC CS$<>8__locals1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KJHKEIABFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4020", Offset = "0x9DB2A20", VA = "0x189DB4020")]
		internal bool DGHGJIIPDIF(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x9DAFE40", Offset = "0x9DAE840", VA = "0x189DAFE40", Slot = "5")]
	public override void ODKAGIAEEAB(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC NOLLCKNLCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public CBJIDIEFMJA()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : HBJGIDHKGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3D90", Offset = "0x9DB2790", VA = "0x189DB3D90", Slot = "4")]
		public JProperty AGNKEKDJGCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3FB0", Offset = "0x9DB29B0", VA = "0x189DB3FB0", Slot = "5")]
		public HBJGIDHKGIG GICKIFLNCPB(EFAGEPFJOIC PJFDNMGHMBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : HBJGIDHKGIG
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
			[Cpp2IlInjected.Address(RVA = "0x9DB47E0", Offset = "0x9DB31E0", VA = "0x189DB47E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GENLMNMPIND exporter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3CF0", Offset = "0x9DB26F0", VA = "0x189DB3CF0")]
		public KHR_materials_variants(GENLMNMPIND HIMDLPAHKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB37F0", Offset = "0x9DB21F0", VA = "0x189DB37F0", Slot = "4")]
		public JProperty AGNKEKDJGCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3B60", Offset = "0x9DB2560", VA = "0x189DB3B60", Slot = "5")]
		public HBJGIDHKGIG GICKIFLNCPB(EFAGEPFJOIC PJFDNMGHMBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3970", Offset = "0x9DB2370", VA = "0x189DB3970")]
		[CompilerGenerated]
		private JObject CFDHKCEDEMF(MappingVariant IECENJOJFJH)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class CEPGHJOBHFF : PDBJIPMJIIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> KDHOHKCOBMH;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9DB1180", Offset = "0x9DAFB80", VA = "0x189DB1180", Slot = "7")]
			public override void FKKFHAJNHOK(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9DB1890", Offset = "0x9DB0290", VA = "0x189DB1890", Slot = "5")]
			public override void ODKAGIAEEAB(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9DB1A30", Offset = "0x9DB0430", VA = "0x189DB1A30")]
			public CEPGHJOBHFF()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct NIHCLKOLNKL
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
			[Cpp2IlInjected.Address(RVA = "0x9DB6090", Offset = "0x9DB4A90", VA = "0x189DB6090", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4910", Offset = "0x9DB3310", VA = "0x189DB4910", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4AD0", Offset = "0x9DB34D0", VA = "0x189DB4AD0")]
		private static (Vector2[], ushort[], Vector2[]) KFIPBLLCFMJ(SpriteRenderer BDBIAPPPJPF, Sprite HCNHPHAIEHK)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5F90", Offset = "0x9DB4990", VA = "0x189DB5F90")]
		[CompilerGenerated]
		internal static Vector2 NEHDAKPGABD(float EHHNMEHJEED, float GLJKLAAEFCH, NIHCLKOLNKL P_2)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9DB49D0", Offset = "0x9DB33D0", VA = "0x189DB49D0")]
		[CompilerGenerated]
		internal static void GICBCADKPAE(ushort MLLJGIHINDJ, ushort ABNAHAKPDNC, ushort HFDMMDBJNBG, ushort NOFNICNJALD, NIHCLKOLNKL P_4)
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
			[Cpp2IlInjected.Address(RVA = "0x9DB6140", Offset = "0x9DB4B40", VA = "0x189DB6140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9DB6110", Offset = "0x9DB4B10", VA = "0x189DB6110", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DB60C0", Offset = "0x9DB4AC0", VA = "0x189DB60C0", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public TextMeshGameObjectExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BBLNIOMBHKB : PDBJIPMJIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<Texture, RenderTexture> BNNFEMAHDKK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9DAFB60", Offset = "0x9DAE560", VA = "0x189DAFB60", Slot = "5")]
	public override void ODKAGIAEEAB(GENLMNMPIND GIGDEGEMDAC, EFAGEPFJOIC MILJAGBBJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9DAF550", Offset = "0x9DADF50", VA = "0x189DAF550", Slot = "7")]
	public override void FKKFHAJNHOK(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9DAF5F0", Offset = "0x9DADFF0", VA = "0x189DAF5F0", Slot = "9")]
	public override bool NDBAACIGCGM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Material POCHLMCAOAO, LCMNEMHMEMN JNPJLGBGEJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public BBLNIOMBHKB()
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
