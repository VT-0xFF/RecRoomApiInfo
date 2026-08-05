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
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[FPLFCAKGIHI(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9FF4930", Offset = "0x9FF2F30", VA = "0x189FF4930", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9FF4900", Offset = "0x9FF2F00", VA = "0x189FF4900", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9FF48A0", Offset = "0x9FF2EA0", VA = "0x189FF48A0", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[FPLFCAKGIHI(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9FF4B00", Offset = "0x9FF3100", VA = "0x189FF4B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9FF4AD0", Offset = "0x9FF30D0", VA = "0x189FF4AD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9FF4960", Offset = "0x9FF2F60", VA = "0x189FF4960", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public AudioImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GIHNLEFLPAC : CMDLLNAPBAF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class NKIMDBINKJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AudioSource PBLDFAKOFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AudioDataId DHPFMMOEADD;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA7000", Offset = "0xAA5600", VA = "0x180AA7000")]
		public NKIMDBINKJP(AudioSource PBLDFAKOFIK, AudioDataId JIGLGEJKJBJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HOLINFLNHMO FGJKBNBIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KHR_audio_emitter KBFNLKJNEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private List<NKIMDBINKJP> ELNADLHKPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<int, AudioClip> OMEEJFFDHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Dictionary<int, string> HNDHEKMOEEP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9FF72C0", Offset = "0x9FF58C0", VA = "0x189FF72C0")]
	public GIHNLEFLPAC(HOLINFLNHMO JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9FF6060", Offset = "0x9FF4660", VA = "0x189FF6060")]
	private void ELHGIPIPOBI(HHLPFANFNFB BOCNDANOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9FF6060", Offset = "0x9FF4660", VA = "0x189FF6060", Slot = "6")]
	public override void KDIOACKDNLH(HHLPFANFNFB HMJMPFHGNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9FF6B90", Offset = "0x9FF5190", VA = "0x189FF6B90")]
	private void PJGGIFIPEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9FF6A70", Offset = "0x9FF5070", VA = "0x189FF6A70")]
	private string OEDPGEPJIGP(string DBAKOFGJILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9FF71C0", Offset = "0x9FF57C0", VA = "0x189FF71C0")]
	private AudioType PMGCPNMMCBE(string DBAKOFGJILA)
	{
		return default(AudioType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9FF61E0", Offset = "0x9FF47E0", VA = "0x189FF61E0")]
	private void GKNGADCKIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9FF67C0", Offset = "0x9FF4DC0", VA = "0x189FF67C0")]
	private void KACFEDOAGDI(GameObject DKDHLDHNOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9FF6E00", Offset = "0x9FF5400", VA = "0x189FF6E00")]
	private void PLDAEKCFFHE(KHR_AudioEmitter ENOCPJLHIOG, GameObject JGOLHKHAFPN, bool LKMIAAKNKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9FF6020", Offset = "0x9FF4620", VA = "0x189FF6020", Slot = "11")]
	public override void EHJPCKPNGIM(ECGPILHJDAN BLFJNFOGIPN, int FMKCJNDALPC, GameObject DKDHLDHNOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9FF5E90", Offset = "0x9FF4490", VA = "0x189FF5E90", Slot = "8")]
	public override void BIIMPHGJCML(EPNFLCKAFCM EMOGDLPNEGA, int EGKCHCJOJAH, GameObject LAHGCGOJCBH)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[HEAEBJGIEHF(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9FF4C70", Offset = "0x9FF3270", VA = "0x189FF4C70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9FF4C40", Offset = "0x9FF3240", VA = "0x189FF4C40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9FF4B30", Offset = "0x9FF3130", VA = "0x189FF4B30", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public BakeParticleSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PDEJBCMOPJI : LEPJFGIFCMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> MEAJCPDEEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<UnityEngine.Object> DNBBDFDBCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9FF8850", Offset = "0x9FF6E50", VA = "0x189FF8850", Slot = "7")]
	public override void EDODCLDHCOF(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9FF8550", Offset = "0x9FF6B50", VA = "0x189FF8550", Slot = "5")]
	public override void BKPGHCMBJOK(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9FF8AB0", Offset = "0x9FF70B0", VA = "0x189FF8AB0")]
	private static void NEJONKPCKNN(UnityEngine.Object KGIGKNOAIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9FF8B50", Offset = "0x9FF7150", VA = "0x189FF8B50")]
	public PDEJBCMOPJI()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[HEAEBJGIEHF(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9FF5430", Offset = "0x9FF3A30", VA = "0x189FF5430", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9FF5400", Offset = "0x9FF3A00", VA = "0x189FF5400", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9FF53B0", Offset = "0x9FF39B0", VA = "0x189FF53B0", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public CanvasExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ADNANAELADH : LEPJFGIFCMO
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static Shader LAGKJJFLJJJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9FF41E0", Offset = "0x9FF27E0", VA = "0x189FF41E0", Slot = "8")]
	public override void ALPMPEPJCPP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB BOCNDANOLJJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public ADNANAELADH()
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
		private Mesh KNHPHEPPGOL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
		public void ModifyMesh(Mesh KNHPHEPPGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9FF52D0", Offset = "0x9FF38D0", VA = "0x189FF52D0", Slot = "5")]
		public void ModifyMesh(VertexHelper LMLKICDHKON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9FF4EA0", Offset = "0x9FF34A0", VA = "0x189FF4EA0")]
		public bool GetMeshAndMaterial([Out] Mesh KNHPHEPPGOL, [Out] Material PFHPGDKJCCC, Shader LAGKJJFLJJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9FF4CA0", Offset = "0x9FF32A0", VA = "0x189FF4CA0")]
		public void CaptureTo(Transform BOCNDANOLJJ, GameObject IHLNEOFACJG, Shader LAGKJJFLJJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
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
				[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
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
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[HEAEBJGIEHF(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9FF8520", Offset = "0x9FF6B20", VA = "0x189FF8520", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9FF84F0", Offset = "0x9FF6AF0", VA = "0x189FF84F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9FF84A0", Offset = "0x9FF6AA0", VA = "0x189FF84A0", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public MaterialVariantsPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PFHNPMFKMHC : LEPJFGIFCMO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class GIMCOAHHDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Transform node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GIMCOAHHDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9FF7400", Offset = "0x9FF5A00", VA = "0x189FF7400")]
		internal bool JPOJHIMGFGB(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FEONNDIHHKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int subMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Material exportMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GIMCOAHHDCO CS$<>8__locals1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public FEONNDIHHKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9FF5460", Offset = "0x9FF3A60", VA = "0x189FF5460")]
		internal bool JDFECFNFPOO(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x9FF8C20", Offset = "0x9FF7220", VA = "0x189FF8C20", Slot = "5")]
	public override void BKPGHCMBJOK(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMAECAIJJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public PFHNPMFKMHC()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : ACPIKDDNLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9FF8190", Offset = "0x9FF6790", VA = "0x189FF8190", Slot = "4")]
		public JProperty ANHNANMIGBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9FF83B0", Offset = "0x9FF69B0", VA = "0x189FF83B0", Slot = "5")]
		public ACPIKDDNLKC JGHKMFOJCLP(HHLPFANFNFB BOCNDANOLJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : ACPIKDDNLKC
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
			[Cpp2IlInjected.Address(RVA = "0x9FF8420", Offset = "0x9FF6A20", VA = "0x189FF8420", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private ILJINGLACKB exporter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9FF80F0", Offset = "0x9FF66F0", VA = "0x189FF80F0")]
		public KHR_materials_variants(ILJINGLACKB NPLAFPNKHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9FF7BF0", Offset = "0x9FF61F0", VA = "0x189FF7BF0", Slot = "4")]
		public JProperty ANHNANMIGBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9FF7F60", Offset = "0x9FF6560", VA = "0x189FF7F60", Slot = "5")]
		public ACPIKDDNLKC JGHKMFOJCLP(HHLPFANFNFB BOCNDANOLJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9FF7D70", Offset = "0x9FF6370", VA = "0x189FF7D70")]
		[CompilerGenerated]
		private JObject GJGPFLJKDFI(MappingVariant GBNAKFLHCOE)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class GBOHCHPOOOM : LEPJFGIFCMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> FINIEHGNILC;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9FF56F0", Offset = "0x9FF3CF0", VA = "0x189FF56F0", Slot = "7")]
			public override void EDODCLDHCOF(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9FF5550", Offset = "0x9FF3B50", VA = "0x189FF5550", Slot = "5")]
			public override void BKPGHCMBJOK(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9FF5E00", Offset = "0x9FF4400", VA = "0x189FF5E00")]
			public GBOHCHPOOOM()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct OFANGALJIOJ
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
			[Cpp2IlInjected.Address(RVA = "0x9FFB6E0", Offset = "0x9FF9CE0", VA = "0x189FFB6E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9FFA060", Offset = "0x9FF8660", VA = "0x189FFA060", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9FFA120", Offset = "0x9FF8720", VA = "0x189FFA120")]
		private static (Vector2[], ushort[], Vector2[]) ICALMEHBBJN(SpriteRenderer MAFJPEPPLNH, Sprite BGDPMEMGGAC)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9FFB5E0", Offset = "0x9FF9BE0", VA = "0x189FFB5E0")]
		[CompilerGenerated]
		internal static Vector2 KGEIDBICFEF(float AHKLPANLBIB, float MIMFJBMPOMF, OFANGALJIOJ P_2)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9FF9F60", Offset = "0x9FF8560", VA = "0x189FF9F60")]
		[CompilerGenerated]
		internal static void CBKOGHGODNP(ushort JGPEJMANNEB, ushort PDHHCOODKIC, ushort KGDLOJHDMHI, ushort COPABLGBACJ, OFANGALJIOJ P_4)
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
			[Cpp2IlInjected.Address(RVA = "0x9FFB790", Offset = "0x9FF9D90", VA = "0x189FFB790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9FFB760", Offset = "0x9FF9D60", VA = "0x189FFB760", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9FFB710", Offset = "0x9FF9D10", VA = "0x189FFB710", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public TextMeshGameObjectExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JFPFJFHGDEM : LEPJFGIFCMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<Texture, RenderTexture> ONMCNFCPBIL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9FF79E0", Offset = "0x9FF5FE0", VA = "0x189FF79E0", Slot = "5")]
	public override void BKPGHCMBJOK(ILJINGLACKB APAPCLFINDP, HHLPFANFNFB ILMCLCDCMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9FF7B50", Offset = "0x9FF6150", VA = "0x189FF7B50", Slot = "7")]
	public override void EDODCLDHCOF(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9FF7470", Offset = "0x9FF5A70", VA = "0x189FF7470", Slot = "9")]
	public override bool AMGHOCJJIEC(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Material PFHPGDKJCCC, LPKIABJLDGD CCPAGGJAIBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public JFPFJFHGDEM()
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
