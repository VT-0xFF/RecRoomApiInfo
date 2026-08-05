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
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[NonRatifiedPlugin(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool DBKUPEYWNFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool ZZPYAMUJLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string BSGUNNAWEFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA6C6510", Offset = "0xA6C5110", VA = "0x18A6C6510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string UXJYQDOEVFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA6C64E0", Offset = "0xA6C50E0", VA = "0x18A6C64E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6480", Offset = "0xA6C5080", VA = "0x18A6C6480", Slot = "14")]
		public override ZXOPVYVNXUU CreateInstance(DVKRDZWHQPM context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[NonRatifiedPlugin(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool ZZPYAMUJLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string BSGUNNAWEFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA6C66C0", Offset = "0xA6C52C0", VA = "0x18A6C66C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string UXJYQDOEVFD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA6C6690", Offset = "0xA6C5290", VA = "0x18A6C6690", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6540", Offset = "0xA6C5140", VA = "0x18A6C6540", Slot = "13")]
		public override JYIYGGYLPYB CreateInstance(NOIBRXOTQWI context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public AudioImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class BELRISVAKRR : JYIYGGYLPYB
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class IEYDPWHPSPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AudioSource CGYVKFIGYBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public AudioDataId EVCNDGUHITW;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
			public IEYDPWHPSPE(AudioSource a, AudioDataId b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private NOIBRXOTQWI GZPJVTHTNZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private KHR_audio_emitter YITNXBXHJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private List<IEYDPWHPSPE> YFBPLYUVRQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Dictionary<int, AudioClip> DGJGUTZYFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Dictionary<int, string> SWLIYZHBJEA;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA6C7B20", Offset = "0xA6C6720", VA = "0x18A6C7B20")]
		public BELRISVAKRR(NOIBRXOTQWI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA6C79A0", Offset = "0xA6C65A0", VA = "0x18A6C79A0")]
		private void WMZLIAYBTPW(WHQEVNUVYVG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA6C79A0", Offset = "0xA6C65A0", VA = "0x18A6C79A0", Slot = "6")]
		public override void XDAFDGKVJOT(WHQEVNUVYVG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6D90", Offset = "0xA6C5990", VA = "0x18A6C6D90")]
		private void KUKVNFTWGWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA6C68C0", Offset = "0xA6C54C0", VA = "0x18A6C68C0")]
		private string HXFBULMOIJT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6C90", Offset = "0xA6C5890", VA = "0x18A6C6C90")]
		private AudioType KSBVCTGMNCO(string a)
		{
			return default(AudioType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA6C7000", Offset = "0xA6C5C00", VA = "0x18A6C7000")]
		private void LJHIPQRJVBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA6C69E0", Offset = "0xA6C55E0", VA = "0x18A6C69E0")]
		private void KQXPLXEOXOA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA6C75F0", Offset = "0xA6C61F0", VA = "0x18A6C75F0")]
		private void MHEFPSSCYGW(KHR_AudioEmitter a, GameObject b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6880", Offset = "0xA6C5480", VA = "0x18A6C6880", Slot = "11")]
		public override void FXTEYBVVLEZ(QLUJKLJJEKU a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA6C66F0", Offset = "0xA6C52F0", VA = "0x18A6C66F0", Slot = "8")]
		public override void CNHXIJOUYGL(OINYKCZIBWN a, int b, GameObject c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ExperimentalPlugin(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string BSGUNNAWEFE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA6C7D60", Offset = "0xA6C6960", VA = "0x18A6C7D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string UXJYQDOEVFD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA6C7D30", Offset = "0xA6C6930", VA = "0x18A6C7D30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool ZZPYAMUJLNK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA6C7C40", Offset = "0xA6C6840", VA = "0x18A6C7C40", Slot = "14")]
		public override ZXOPVYVNXUU CreateInstance(DVKRDZWHQPM context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public BakeParticleSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class FBJJSYKIVPA : ZXOPVYVNXUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<Component> WQDLNDULAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<UnityEngine.Object> KUMKPAJOIVI;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA6C91F0", Offset = "0xA6C7DF0", VA = "0x18A6C91F0", Slot = "7")]
		public override void SUXLXDKKNUM(GLTFSceneExporter a, WHQEVNUVYVG b, Transform c, OINYKCZIBWN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8EC0", Offset = "0xA6C7AC0", VA = "0x18A6C8EC0", Slot = "5")]
		public override void EMLIOAGEZWV(GLTFSceneExporter a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9130", Offset = "0xA6C7D30", VA = "0x18A6C9130")]
		private static void HXMGNIJVISG(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9530", Offset = "0xA6C8130", VA = "0x18A6C9530")]
		public FBJJSYKIVPA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[ExperimentalPlugin(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string BSGUNNAWEFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA6C8500", Offset = "0xA6C7100", VA = "0x18A6C8500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string UXJYQDOEVFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA6C84D0", Offset = "0xA6C70D0", VA = "0x18A6C84D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool ZZPYAMUJLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8480", Offset = "0xA6C7080", VA = "0x18A6C8480", Slot = "14")]
		public override ZXOPVYVNXUU CreateInstance(DVKRDZWHQPM context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public CanvasExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class PQLFGPWMVQK : ZXOPVYVNXUU
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader VJDPAQNVVVK;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9F00", Offset = "0xA6C8B00", VA = "0x18A6C9F00", Slot = "8")]
		public override void GONLYJQFHBZ(GLTFSceneExporter a, WHQEVNUVYVG b, Transform c, OINYKCZIBWN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public PQLFGPWMVQK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu(null)]
	internal class CanvasExportCaptureMeshHelper : MonoBehaviour, IMeshModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Mesh SWPLFFUBETG;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public void ModifyMesh(Mesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6C83B0", Offset = "0xA6C6FB0", VA = "0x18A6C83B0", Slot = "5")]
		public void ModifyMesh(VertexHelper verts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA6C7F90", Offset = "0xA6C6B90", VA = "0x18A6C7F90")]
		public bool GetMeshAndMaterial([Out] Mesh mesh, [Out] Material material, Shader shader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA6C7D90", Offset = "0xA6C6990", VA = "0x18A6C7D90")]
		public void CaptureTo(Transform root, GameObject shadow, Shader shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
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
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExperimentalPlugin(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string BSGUNNAWEFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA6C9ED0", Offset = "0xA6C8AD0", VA = "0x18A6C9ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string UXJYQDOEVFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA6C9EA0", Offset = "0xA6C8AA0", VA = "0x18A6C9EA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9E50", Offset = "0xA6C8A50", VA = "0x18A6C9E50", Slot = "14")]
		public override ZXOPVYVNXUU CreateInstance(DVKRDZWHQPM context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public MaterialVariantsPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class SOJGOULIVLG : ZXOPVYVNXUU
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Transform HILXSABAWVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> VOKPHXAPWMM;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA6CDF10", Offset = "0xA6CCB10", VA = "0x18A6CDF10")]
			internal bool REGTQOAQNHN(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class UUXQCCVJIIU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int FKNTTZXGEAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Material IKCQZHXSUZA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public UVCWZJPGRUD JZUGHOQQQFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> VOFIKQGSNBD;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UUXQCCVJIIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA6CDE20", Offset = "0xA6CCA20", VA = "0x18A6CDE20")]
			internal bool RDQYYTSYKZM(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA6CAD20", Offset = "0xA6C9920", VA = "0x18A6CAD20", Slot = "5")]
		public override void EMLIOAGEZWV(GLTFSceneExporter a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public SOJGOULIVLG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : FNHEMEFBNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9BD0", Offset = "0xA6C87D0", VA = "0x18A6C9BD0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9B60", Offset = "0xA6C8760", VA = "0x18A6C9B60", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : FNHEMEFBNEF
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
			[Cpp2IlInjected.Address(RVA = "0xA6C9DD0", Offset = "0xA6C89D0", VA = "0x18A6C9DD0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GLTFSceneExporter QYBFMSNBTZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9AC0", Offset = "0xA6C86C0", VA = "0x18A6C9AC0")]
		public KHR_materials_variants(GLTFSceneExporter exporter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9960", Offset = "0xA6C8560", VA = "0x18A6C9960", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA6C95F0", Offset = "0xA6C81F0", VA = "0x18A6C95F0", Slot = "5")]
		public FNHEMEFBNEF Clone(WHQEVNUVYVG root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9780", Offset = "0xA6C8380", VA = "0x18A6C9780")]
		[CompilerGenerated]
		private JObject EYSESLIJRYX(MappingVariant a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class Context : ZXOPVYVNXUU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> XJURWIIZIHR;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA6C86F0", Offset = "0xA6C72F0", VA = "0x18A6C86F0", Slot = "7")]
			public override void SUXLXDKKNUM(GLTFSceneExporter a, WHQEVNUVYVG b, Transform c, OINYKCZIBWN d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA6C8530", Offset = "0xA6C7130", VA = "0x18A6C8530", Slot = "5")]
			public override void EMLIOAGEZWV(GLTFSceneExporter a, WHQEVNUVYVG b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA6C8E40", Offset = "0xA6C7A40", VA = "0x18A6C8E40")]
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
		public override string BSGUNNAWEFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA6CD8F0", Offset = "0xA6CC4F0", VA = "0x18A6CD8F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA6CBED0", Offset = "0xA6CAAD0", VA = "0x18A6CBED0", Slot = "14")]
		public override ZXOPVYVNXUU CreateInstance(DVKRDZWHQPM context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC010", Offset = "0xA6CAC10", VA = "0x18A6CC010")]
		private static (Vector2[], ushort[], Vector2[]) MSUBSHWOIDX(SpriteRenderer a, Sprite b)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA6CBF80", Offset = "0xA6CAB80", VA = "0x18A6CBF80")]
		[CompilerGenerated]
		internal static Vector2 IIOJJUCHFIJ(float a, float b, <>c__DisplayClass4_0 c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD7F0", Offset = "0xA6CC3F0", VA = "0x18A6CD7F0")]
		[CompilerGenerated]
		internal static void YODIHZPTOUK(ushort a, ushort b, ushort c, ushort d, <>c__DisplayClass4_0 e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TextMeshGameObjectExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string BSGUNNAWEFE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA6CD9A0", Offset = "0xA6CC5A0", VA = "0x18A6CD9A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string UXJYQDOEVFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA6CD970", Offset = "0xA6CC570", VA = "0x18A6CD970", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD920", Offset = "0xA6CC520", VA = "0x18A6CD920", Slot = "14")]
		public override ZXOPVYVNXUU CreateInstance(DVKRDZWHQPM context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public TextMeshGameObjectExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class QKCAIIIFZGU : ZXOPVYVNXUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<Texture, RenderTexture> EPTOWWCAYUP;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA5C0", Offset = "0xA6C91C0", VA = "0x18A6CA5C0", Slot = "5")]
		public override void EMLIOAGEZWV(GLTFSceneExporter a, WHQEVNUVYVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA6CAC80", Offset = "0xA6C9880", VA = "0x18A6CAC80", Slot = "7")]
		public override void SUXLXDKKNUM(GLTFSceneExporter a, WHQEVNUVYVG b, Transform c, OINYKCZIBWN d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA730", Offset = "0xA6C9330", VA = "0x18A6CA730", Slot = "9")]
		public override bool MOMHFITHUVP(GLTFSceneExporter a, WHQEVNUVYVG b, Material c, LVNNDEQXMVX d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public QKCAIIIFZGU()
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
