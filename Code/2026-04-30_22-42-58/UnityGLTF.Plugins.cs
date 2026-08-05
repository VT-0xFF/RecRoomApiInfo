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
		[Cpp2IlInjected.Address(RVA = "0xCF4180", Offset = "0xCF3580", VA = "0x180CF4180")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[NonRatifiedPlugin(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool BYWDFIHJUYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MOVJBQXITYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xB614EE0", Offset = "0xB6142E0", VA = "0x18B614EE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB614EB0", Offset = "0xB6142B0", VA = "0x18B614EB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB614E50", Offset = "0xB614250", VA = "0x18B614E50", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x19A5060", Offset = "0x19A4460", VA = "0x1819A5060")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[NonRatifiedPlugin(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool MOVJBQXITYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB615090", Offset = "0xB614490", VA = "0x18B615090", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xB615060", Offset = "0xB614460", VA = "0x18B615060", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB614F10", Offset = "0xB614310", VA = "0x18B614F10", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x19A5060", Offset = "0x19A4460", VA = "0x1819A5060")]
		public AudioImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SREUUXWCROE : JVDZVLIBKQI
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class CXPSIJGWRLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AudioSource YAXETWZGEBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public AudioDataId DGHYQXGXXIB;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCFB220", Offset = "0xCFA620", VA = "0x180CFB220")]
			public CXPSIJGWRLH(AudioSource a, AudioDataId b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private XNPFEZFVAYZ TJINWTTHVQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private KHR_audio_emitter ASOWEJIYGXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private List<CXPSIJGWRLH> LUKNPFFHGSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Dictionary<int, AudioClip> GFDHSWECQWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Dictionary<int, string> TQGLOLXQHBT;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB619580", Offset = "0xB618980", VA = "0x18B619580")]
		public SREUUXWCROE(XNPFEZFVAYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB618150", Offset = "0xB617550", VA = "0x18B618150")]
		private void GWPIGJVZUKX(GZYGZQSIZFV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB618150", Offset = "0xB617550", VA = "0x18B618150", Slot = "6")]
		public override void ARHMLESVZVE(GZYGZQSIZFV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB618930", Offset = "0xB617D30", VA = "0x18B618930")]
		private void OBUMYLIYTQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB618460", Offset = "0xB617860", VA = "0x18B618460")]
		private string ITPNBKMAJNW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB619480", Offset = "0xB618880", VA = "0x18B619480")]
		private AudioType ZRGITINUIJR(string a)
		{
			return default(AudioType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xB618BA0", Offset = "0xB617FA0", VA = "0x18B618BA0")]
		private void UHCBOQZQXNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB6191D0", Offset = "0xB6185D0", VA = "0x18B6191D0")]
		private void YWICWQRNAXP(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB618580", Offset = "0xB617980", VA = "0x18B618580")]
		private void KJGEJGMLVIR(KHR_AudioEmitter a, GameObject b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xB619190", Offset = "0xB618590", VA = "0x18B619190", Slot = "11")]
		public override void UVGSFZXUPMC(TJCMXEZHJBP a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB6182D0", Offset = "0xB6176D0", VA = "0x18B6182D0", Slot = "8")]
		public override void IGXYKHBALJM(SIDFNDXEBQO a, int b, GameObject c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ExperimentalPlugin(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB6151E0", Offset = "0xB6145E0", VA = "0x18B6151E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB6151B0", Offset = "0xB6145B0", VA = "0x18B6151B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool MOVJBQXITYX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB6150C0", Offset = "0xB6144C0", VA = "0x18B6150C0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x19A5060", Offset = "0x19A4460", VA = "0x1819A5060")]
		public BakeParticleSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class QTMRKWZTKZN : HMEEPODDUBT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<Component> DAKJOHCRDSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<UnityEngine.Object> QSQYPMIVIUZ;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB617AE0", Offset = "0xB616EE0", VA = "0x18B617AE0", Slot = "7")]
		public override void LSOYBVJZGZF(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB617E20", Offset = "0xB617220", VA = "0x18B617E20", Slot = "5")]
		public override void MFIEYBWZCZI(GLTFSceneExporter a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB617A20", Offset = "0xB616E20", VA = "0x18B617A20")]
		private static void JMFGVNNOMED(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB618090", Offset = "0xB617490", VA = "0x18B618090")]
		public QTMRKWZTKZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[ExperimentalPlugin(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB616030", Offset = "0xB615430", VA = "0x18B616030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB616000", Offset = "0xB615400", VA = "0x18B616000", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool MOVJBQXITYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB615FB0", Offset = "0xB6153B0", VA = "0x18B615FB0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x19A5060", Offset = "0x19A4460", VA = "0x1819A5060")]
		public CanvasExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CZAJTWNLDRN : HMEEPODDUBT
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader PSODNIXVCRF;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB615210", Offset = "0xB614610", VA = "0x18B615210", Slot = "8")]
		public override void VIKYSQFVIMO(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public CZAJTWNLDRN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu(null)]
	internal class CanvasExportCaptureMeshHelper : MonoBehaviour, IMeshModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Mesh ADZETTUZVRJ;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
		public void ModifyMesh(Mesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB615EE0", Offset = "0xB6152E0", VA = "0x18B615EE0", Slot = "5")]
		public void ModifyMesh(VertexHelper verts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB615AC0", Offset = "0xB614EC0", VA = "0x18B615AC0")]
		public bool GetMeshAndMaterial([Out] Mesh mesh, [Out] Material material, Shader shader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xB6158C0", Offset = "0xB614CC0", VA = "0x18B6158C0")]
		public void CaptureTo(Transform root, GameObject shadow, Shader shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xCF4180", Offset = "0xCF3580", VA = "0x180CF4180")]
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
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF4180", Offset = "0xCF3580", VA = "0x180CF4180")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExperimentalPlugin(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB6179F0", Offset = "0xB616DF0", VA = "0x18B6179F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB6179C0", Offset = "0xB616DC0", VA = "0x18B6179C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB617970", Offset = "0xB616D70", VA = "0x18B617970", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x19A5060", Offset = "0x19A4460", VA = "0x1819A5060")]
		public MaterialVariantsPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class XVDMVMRNXZF : HMEEPODDUBT
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class VXVANLUKZAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Transform CANSHDFJKQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> FWWLGACJDNB;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xB61B5F0", Offset = "0xB61A9F0", VA = "0x18B61B5F0")]
			internal bool ZYIKZCXMIBC(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class VYAHKSOIIMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int JRBPTKNCKVF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Material RJSAJOAJUXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public VXVANLUKZAY IYWFXXOWUJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> FWGQOFURBFA;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VYAHKSOIIMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xB61B660", Offset = "0xB61AA60", VA = "0x18B61B660")]
			internal bool ZYDEBWDOYPT(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xB61B750", Offset = "0xB61AB50", VA = "0x18B61B750", Slot = "5")]
		public override void MFIEYBWZCZI(GLTFSceneExporter a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public XVDMVMRNXZF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : LOPDDMPFOVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xB616FA0", Offset = "0xB6163A0", VA = "0x18B616FA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xB616F30", Offset = "0xB616330", VA = "0x18B616F30", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : LOPDDMPFOVQ
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
			[Cpp2IlInjected.Address(RVA = "0xB6178F0", Offset = "0xB616CF0", VA = "0x18B6178F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GLTFSceneExporter URSCPPQZUOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xB616E90", Offset = "0xB616290", VA = "0x18B616E90")]
		public KHR_materials_variants(GLTFSceneExporter exporter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB616D30", Offset = "0xB616130", VA = "0x18B616D30", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xB6169E0", Offset = "0xB615DE0", VA = "0x18B6169E0", Slot = "5")]
		public LOPDDMPFOVQ Clone(GZYGZQSIZFV root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB616B60", Offset = "0xB615F60", VA = "0x18B616B60")]
		[CompilerGenerated]
		private JObject QONODGVKNVU(MappingVariant a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class Context : HMEEPODDUBT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> GFCFQYZTAIO;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB616060", Offset = "0xB615460", VA = "0x18B616060", Slot = "7")]
			public override void LSOYBVJZGZF(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xB6167A0", Offset = "0xB615BA0", VA = "0x18B6167A0", Slot = "5")]
			public override void MFIEYBWZCZI(GLTFSceneExporter a, GZYGZQSIZFV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB616960", Offset = "0xB615D60", VA = "0x18B616960")]
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
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xB61B0C0", Offset = "0xB61A4C0", VA = "0x18B61B0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB6196A0", Offset = "0xB618AA0", VA = "0x18B6196A0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB6198E0", Offset = "0xB618CE0", VA = "0x18B6198E0")]
		private static (Vector2[], ushort[], Vector2[]) RRXFXRFIBRE(SpriteRenderer a, Sprite b)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x19A5060", Offset = "0x19A4460", VA = "0x1819A5060")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xB619850", Offset = "0xB618C50", VA = "0x18B619850")]
		[CompilerGenerated]
		internal static Vector2 QVORNWUKZQM(float a, float b, <>c__DisplayClass4_0 c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB619750", Offset = "0xB618B50", VA = "0x18B619750")]
		[CompilerGenerated]
		internal static void EPHKQDWGFKZ(ushort a, ushort b, ushort c, ushort d, <>c__DisplayClass4_0 e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TextMeshGameObjectExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xB61B170", Offset = "0xB61A570", VA = "0x18B61B170", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB61B140", Offset = "0xB61A540", VA = "0x18B61B140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xB61B0F0", Offset = "0xB61A4F0", VA = "0x18B61B0F0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x19A5060", Offset = "0x19A4460", VA = "0x1819A5060")]
		public TextMeshGameObjectExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MXFQEZJCRQR : HMEEPODDUBT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<Texture, RenderTexture> MKFTLDQZIUS;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB617230", Offset = "0xB616630", VA = "0x18B617230", Slot = "5")]
		public override void MFIEYBWZCZI(GLTFSceneExporter a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB617190", Offset = "0xB616590", VA = "0x18B617190", Slot = "7")]
		public override void LSOYBVJZGZF(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB6173A0", Offset = "0xB6167A0", VA = "0x18B6173A0", Slot = "9")]
		public override bool VAJRWJGVQKO(GLTFSceneExporter a, GZYGZQSIZFV b, Material c, RLXWJRYFKUW d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public MXFQEZJCRQR()
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
