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

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	internal class TempAssignClip : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int audioSourceIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string audioPath;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[NonRatifiedPlugin(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool XHGDOZFMMRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool ZLOZDPREKZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string LBSUVJPHCHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9F03230", Offset = "0x9F02630", VA = "0x189F03230", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string VHMDXTRWDPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9F03200", Offset = "0x9F02600", VA = "0x189F03200", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9F031A0", Offset = "0x9F025A0", VA = "0x189F031A0", Slot = "14")]
		public override TSDLIDBNQGF CreateInstance(TWBIGRUSBWT context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[NonRatifiedPlugin(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool ZLOZDPREKZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string LBSUVJPHCHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9F033E0", Offset = "0x9F027E0", VA = "0x189F033E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string VHMDXTRWDPS
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9F033B0", Offset = "0x9F027B0", VA = "0x189F033B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9F03260", Offset = "0x9F02660", VA = "0x189F03260", Slot = "13")]
		public override KBBMSTCEVRO CreateInstance(TAKPQBZXKAV context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public AudioImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class YETOGPZKMHS : KBBMSTCEVRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class AWFHCXQIPXL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AudioSource CSJPEOJJMMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public AudioDataId RLZBTURLDVT;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAAC040", Offset = "0xAAB440", VA = "0x180AAC040")]
			public AWFHCXQIPXL(AudioSource a, AudioDataId b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private TAKPQBZXKAV WLMWVRDOXMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private KHR_audio_emitter KLKNKJQCZWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private List<AWFHCXQIPXL> DILYBUGHAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Dictionary<int, AudioClip> FLITIWTZRYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Dictionary<int, string> XEUCOBFMHIZ;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0A3B0", Offset = "0x9F097B0", VA = "0x189F0A3B0")]
		public YETOGPZKMHS(TAKPQBZXKAV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0A110", Offset = "0x9F09510", VA = "0x189F0A110")]
		private void WYIECEGJULR(WWOZGFPEXAT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0A110", Offset = "0x9F09510", VA = "0x189F0A110", Slot = "6")]
		public override void OZGKSKTMQYO(WWOZGFPEXAT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F09870", Offset = "0x9F08C70", VA = "0x189F09870")]
		private void JQZAOSPLDPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F0A290", Offset = "0x9F09690", VA = "0x189F0A290")]
		private string RDWJJIQYQBO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F08F90", Offset = "0x9F08390", VA = "0x189F08F90")]
		private AudioType ATBINKFNELR(string a)
		{
			return default(AudioType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F09AE0", Offset = "0x9F08EE0", VA = "0x189F09AE0")]
		private void NDWYQDHXYST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F09220", Offset = "0x9F08620", VA = "0x189F09220")]
		private void GFIAYJZXDTX(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F094C0", Offset = "0x9F088C0", VA = "0x189F094C0")]
		private void GNDFUIQUIAR(KHR_AudioEmitter a, GameObject b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F0A0D0", Offset = "0x9F094D0", VA = "0x189F0A0D0", Slot = "11")]
		public override void OGCIWVDDGRQ(DKOKDRZOXIV a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F09090", Offset = "0x9F08490", VA = "0x189F09090", Slot = "8")]
		public override void BFYGDOGOROW(TDRUPTSJFYC a, int b, GameObject c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ExperimentalPlugin(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string LBSUVJPHCHV
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9F03530", Offset = "0x9F02930", VA = "0x189F03530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string VHMDXTRWDPS
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9F03500", Offset = "0x9F02900", VA = "0x189F03500", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool ZLOZDPREKZF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F03410", Offset = "0x9F02810", VA = "0x189F03410", Slot = "14")]
		public override TSDLIDBNQGF CreateInstance(TWBIGRUSBWT context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public BakeParticleSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class KBPDDDZONIX : TSDLIDBNQGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<Component> NPZYVESIOYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<UnityEngine.Object> ERDBIRCBNVH;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F04A50", Offset = "0x9F03E50", VA = "0x189F04A50", Slot = "7")]
		public override void RQHEBGGMOWP(GLTFSceneExporter a, WWOZGFPEXAT b, Transform c, TDRUPTSJFYC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F047E0", Offset = "0x9F03BE0", VA = "0x189F047E0", Slot = "5")]
		public override void HGUVRTFGZRY(GLTFSceneExporter a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9F04D90", Offset = "0x9F04190", VA = "0x189F04D90")]
		private static void RTNEAKFZFEL(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F04E50", Offset = "0x9F04250", VA = "0x189F04E50")]
		public KBPDDDZONIX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[ExperimentalPlugin(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string LBSUVJPHCHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9F03CD0", Offset = "0x9F030D0", VA = "0x189F03CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string VHMDXTRWDPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9F03CA0", Offset = "0x9F030A0", VA = "0x189F03CA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool ZLOZDPREKZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9F03C50", Offset = "0x9F03050", VA = "0x189F03C50", Slot = "14")]
		public override TSDLIDBNQGF CreateInstance(TWBIGRUSBWT context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public CanvasExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class LJXSWTJQWDZ : TSDLIDBNQGF
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader DVHSTXINPCD;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9F056D0", Offset = "0x9F04AD0", VA = "0x189F056D0", Slot = "8")]
		public override void IWRXMOINWBI(GLTFSceneExporter a, WWOZGFPEXAT b, Transform c, TDRUPTSJFYC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public LJXSWTJQWDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu(null)]
	internal class CanvasExportCaptureMeshHelper : MonoBehaviour, IMeshModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Mesh GLWEFNHPWCH;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
		public void ModifyMesh(Mesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9F03B80", Offset = "0x9F02F80", VA = "0x189F03B80", Slot = "5")]
		public void ModifyMesh(VertexHelper verts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9F03760", Offset = "0x9F02B60", VA = "0x189F03760")]
		public bool GetMeshAndMaterial([Out] Mesh mesh, [Out] Material material, Shader shader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F03560", Offset = "0x9F02960", VA = "0x189F03560")]
		public void CaptureTo(Transform root, GameObject shadow, Shader shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public Variant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Material invisibleMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public List<Variant> variants;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExperimentalPlugin(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string LBSUVJPHCHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9F05E80", Offset = "0x9F05280", VA = "0x189F05E80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string VHMDXTRWDPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9F05E50", Offset = "0x9F05250", VA = "0x189F05E50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9F05E00", Offset = "0x9F05200", VA = "0x189F05E00", Slot = "14")]
		public override TSDLIDBNQGF CreateInstance(TWBIGRUSBWT context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public MaterialVariantsPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class QMDUMSGBJKX : TSDLIDBNQGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FXDJFRICATK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Transform ZISESPVPFJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> LUWWYAGUWCP;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public FXDJFRICATK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9F04680", Offset = "0x9F03A80", VA = "0x189F04680")]
			internal bool HHFYJMDQLQM(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FXIQCYBZKET
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int ACUWQZKFYNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Material QCJVRLCECUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public FXDJFRICATK VHOTALYTHEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> LVXFKICHRHI;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public FXIQCYBZKET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9F046F0", Offset = "0x9F03AF0", VA = "0x189F046F0")]
			internal bool HIQUQHMXZRX(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9F05EB0", Offset = "0x9F052B0", VA = "0x189F05EB0", Slot = "5")]
		public override void HGUVRTFGZRY(GLTFSceneExporter a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public QMDUMSGBJKX()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : DWUVLGQZHBQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9F054E0", Offset = "0x9F048E0", VA = "0x189F054E0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9F05470", Offset = "0x9F04870", VA = "0x189F05470", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : DWUVLGQZHBQ
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
			[Cpp2IlInjected.Address(RVA = "0x9F05D80", Offset = "0x9F05180", VA = "0x189F05D80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GLTFSceneExporter ANXCHBBNEXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F053D0", Offset = "0x9F047D0", VA = "0x189F053D0")]
		public KHR_materials_variants(GLTFSceneExporter exporter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F05270", Offset = "0x9F04670", VA = "0x189F05270", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9F04F10", Offset = "0x9F04310", VA = "0x189F04F10", Slot = "5")]
		public DWUVLGQZHBQ Clone(WWOZGFPEXAT root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F05090", Offset = "0x9F04490", VA = "0x189F05090")]
		[CompilerGenerated]
		private JObject FEWKRMUECRE(MappingVariant a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class Context : TSDLIDBNQGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> HISEPDOXXYG;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9F03EC0", Offset = "0x9F032C0", VA = "0x189F03EC0", Slot = "7")]
			public override void RQHEBGGMOWP(GLTFSceneExporter a, WWOZGFPEXAT b, Transform c, TDRUPTSJFYC d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9F03D00", Offset = "0x9F03100", VA = "0x189F03D00", Slot = "5")]
			public override void HGUVRTFGZRY(GLTFSceneExporter a, WWOZGFPEXAT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9F04600", Offset = "0x9F03A00", VA = "0x189F04600")]
			public Context()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct <>c__DisplayClass4_0
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
		public override string LBSUVJPHCHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9F08A60", Offset = "0x9F07E60", VA = "0x189F08A60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9F07040", Offset = "0x9F06440", VA = "0x189F07040", Slot = "14")]
		public override TSDLIDBNQGF CreateInstance(TWBIGRUSBWT context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F070F0", Offset = "0x9F064F0", VA = "0x189F070F0")]
		private static (Vector2[], ushort[], Vector2[]) JRPBTPZRUHA(SpriteRenderer a, Sprite b)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9F089D0", Offset = "0x9F07DD0", VA = "0x189F089D0")]
		[CompilerGenerated]
		internal static Vector2 XKHRECZAKEM(float a, float b, <>c__DisplayClass4_0 c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9F088D0", Offset = "0x9F07CD0", VA = "0x189F088D0")]
		[CompilerGenerated]
		internal static void WHRFIAXOQKZ(ushort a, ushort b, ushort c, ushort d, <>c__DisplayClass4_0 e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TextMeshGameObjectExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string LBSUVJPHCHV
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9F08B10", Offset = "0x9F07F10", VA = "0x189F08B10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string VHMDXTRWDPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9F08AE0", Offset = "0x9F07EE0", VA = "0x189F08AE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F08A90", Offset = "0x9F07E90", VA = "0x189F08A90", Slot = "14")]
		public override TSDLIDBNQGF CreateInstance(TWBIGRUSBWT context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public TextMeshGameObjectExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class YXKWQDYNEPD : TSDLIDBNQGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<Texture, RenderTexture> PKOODTGGLXE;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9F0A4D0", Offset = "0x9F098D0", VA = "0x189F0A4D0", Slot = "5")]
		public override void HGUVRTFGZRY(GLTFSceneExporter a, WWOZGFPEXAT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F0A640", Offset = "0x9F09A40", VA = "0x189F0A640", Slot = "7")]
		public override void RQHEBGGMOWP(GLTFSceneExporter a, WWOZGFPEXAT b, Transform c, TDRUPTSJFYC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F0A6E0", Offset = "0x9F09AE0", VA = "0x189F0A6E0", Slot = "9")]
		public override bool YMVHWAWIOAG(GLTFSceneExporter a, WWOZGFPEXAT b, Material c, SATUANLWUCW d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public YXKWQDYNEPD()
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
