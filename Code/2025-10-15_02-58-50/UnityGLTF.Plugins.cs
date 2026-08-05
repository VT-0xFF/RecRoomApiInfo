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
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[NonRatifiedPlugin(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool TSOQDPQOFOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool TEMXDZCNVCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string GTTSAVBEEKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA18CB60", Offset = "0xA18B960", VA = "0x18A18CB60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string RHKDOAEXMSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA18CB30", Offset = "0xA18B930", VA = "0x18A18CB30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA18CAD0", Offset = "0xA18B8D0", VA = "0x18A18CAD0", Slot = "14")]
		public override SSTIZANBDPY CreateInstance(JYOVARWRYWQ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x19DB410", Offset = "0x19DA210", VA = "0x1819DB410")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[NonRatifiedPlugin(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool TEMXDZCNVCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string GTTSAVBEEKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA18CD10", Offset = "0xA18BB10", VA = "0x18A18CD10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string RHKDOAEXMSH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA18CCE0", Offset = "0xA18BAE0", VA = "0x18A18CCE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA18CB90", Offset = "0xA18B990", VA = "0x18A18CB90", Slot = "13")]
		public override YGKRTGXDNDV CreateInstance(HRESPQDGAEG context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x19DB410", Offset = "0x19DA210", VA = "0x1819DB410")]
		public AudioImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RQKKJIBGQMF : YGKRTGXDNDV
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class TATZBHOWMPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AudioSource WHNGECRFSDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public AudioDataId UDYFYKXAAJE;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAA5770", Offset = "0xAA4570", VA = "0x180AA5770")]
			public TATZBHOWMPK(AudioSource a, AudioDataId b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private HRESPQDGAEG YMLMGJRFRLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private KHR_audio_emitter GIYYKXOTGSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private List<TATZBHOWMPK> DDXJKPQWLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Dictionary<int, AudioClip> JGBPBBGDMYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Dictionary<int, string> YPOPEGONCWS;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA190B80", Offset = "0xA18F980", VA = "0x18A190B80")]
		public RQKKJIBGQMF(HRESPQDGAEG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA18F9C0", Offset = "0xA18E7C0", VA = "0x18A18F9C0")]
		private void TOTTDNPHKWK(JEGPMPFQLBY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA18F9C0", Offset = "0xA18E7C0", VA = "0x18A18F9C0", Slot = "6")]
		public override void CICGZYETSRT(JEGPMPFQLBY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA18F750", Offset = "0xA18E550", VA = "0x18A18F750")]
		private void BGZYHHYIQMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA190520", Offset = "0xA18F320", VA = "0x18A190520")]
		private string TDPPWHVKRJB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA18FB80", Offset = "0xA18E980", VA = "0x18A18FB80")]
		private AudioType HKTEUWZJASM(string a)
		{
			return default(AudioType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA18FC80", Offset = "0xA18EA80", VA = "0x18A18FC80")]
		private void PTBRAJHCEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA190270", Offset = "0xA18F070", VA = "0x18A190270")]
		private void PWIWPQYQUOO(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA1907D0", Offset = "0xA18F5D0", VA = "0x18A1907D0")]
		private void XJDSMFYUVDG(KHR_AudioEmitter a, GameObject b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA18FB40", Offset = "0xA18E940", VA = "0x18A18FB40", Slot = "11")]
		public override void DBJKPGZDVOT(SWPQGJPBGRA a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA190640", Offset = "0xA18F440", VA = "0x18A190640", Slot = "8")]
		public override void TTLCXJWDOCR(ITZFJUYYDSP a, int b, GameObject c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ExperimentalPlugin(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string GTTSAVBEEKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA18CE60", Offset = "0xA18BC60", VA = "0x18A18CE60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string RHKDOAEXMSH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA18CE30", Offset = "0xA18BC30", VA = "0x18A18CE30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool TEMXDZCNVCC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA18CD40", Offset = "0xA18BB40", VA = "0x18A18CD40", Slot = "14")]
		public override SSTIZANBDPY CreateInstance(JYOVARWRYWQ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x19DB410", Offset = "0x19DA210", VA = "0x1819DB410")]
		public BakeParticleSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class EXFSSNEFUPW : SSTIZANBDPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<Component> DXMQFXAQVQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<UnityEngine.Object> UHYBFQEIHNO;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA18E720", Offset = "0xA18D520", VA = "0x18A18E720", Slot = "7")]
		public override void FWJFWIPZXIO(GLTFSceneExporter a, JEGPMPFQLBY b, Transform c, ITZFJUYYDSP d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA18EB20", Offset = "0xA18D920", VA = "0x18A18EB20", Slot = "5")]
		public override void UYGOMCOCIOX(GLTFSceneExporter a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA18EA60", Offset = "0xA18D860", VA = "0x18A18EA60")]
		private static void PTAAQJULUME(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA18ED90", Offset = "0xA18DB90", VA = "0x18A18ED90")]
		public EXFSSNEFUPW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[ExperimentalPlugin(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string GTTSAVBEEKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA18DD60", Offset = "0xA18CB60", VA = "0x18A18DD60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string RHKDOAEXMSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA18DD30", Offset = "0xA18CB30", VA = "0x18A18DD30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool TEMXDZCNVCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA18DCE0", Offset = "0xA18CAE0", VA = "0x18A18DCE0", Slot = "14")]
		public override SSTIZANBDPY CreateInstance(JYOVARWRYWQ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x19DB410", Offset = "0x19DA210", VA = "0x1819DB410")]
		public CanvasExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class XLJYBEZJIHK : SSTIZANBDPY
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader CXSUCVZVLSS;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA193F00", Offset = "0xA192D00", VA = "0x18A193F00", Slot = "8")]
		public override void AARWPKKYPAZ(GLTFSceneExporter a, JEGPMPFQLBY b, Transform c, ITZFJUYYDSP d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public XLJYBEZJIHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu(null)]
	internal class CanvasExportCaptureMeshHelper : MonoBehaviour, IMeshModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Mesh YAQHUCUSNHI;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
		public void ModifyMesh(Mesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA18DC10", Offset = "0xA18CA10", VA = "0x18A18DC10", Slot = "5")]
		public void ModifyMesh(VertexHelper verts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA18D7F0", Offset = "0xA18C5F0", VA = "0x18A18D7F0")]
		public bool GetMeshAndMaterial([Out] Mesh mesh, [Out] Material material, Shader shader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA18D5F0", Offset = "0xA18C3F0", VA = "0x18A18D5F0")]
		public void CaptureTo(Transform root, GameObject shadow, Shader shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
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
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExperimentalPlugin(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string GTTSAVBEEKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA18F720", Offset = "0xA18E520", VA = "0x18A18F720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string RHKDOAEXMSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA18F6F0", Offset = "0xA18E4F0", VA = "0x18A18F6F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA18F6A0", Offset = "0xA18E4A0", VA = "0x18A18F6A0", Slot = "14")]
		public override SSTIZANBDPY CreateInstance(JYOVARWRYWQ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x19DB410", Offset = "0x19DA210", VA = "0x1819DB410")]
		public MaterialVariantsPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class WDHWOWKZNOK : SSTIZANBDPY
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class WRYJXOISUHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Transform SMJSDUHDMSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> JOTTFLBNJVM;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WRYJXOISUHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA193E90", Offset = "0xA192C90", VA = "0x18A193E90")]
			internal bool KCPULMRHHMB(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class WRTDAHOVKWG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int ALACYMTORBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Material ILEGPCGASAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public WRYJXOISUHP JOWOLGJKVOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> JNTKTDGAOQT;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WRTDAHOVKWG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA193DA0", Offset = "0xA192BA0", VA = "0x18A193DA0")]
			internal bool KBEYERHZTKQ(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA192BF0", Offset = "0xA1919F0", VA = "0x18A192BF0", Slot = "5")]
		public override void UYGOMCOCIOX(GLTFSceneExporter a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public WDHWOWKZNOK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : AHNEHECEPNV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA18F420", Offset = "0xA18E220", VA = "0x18A18F420", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA18F3B0", Offset = "0xA18E1B0", VA = "0x18A18F3B0", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : AHNEHECEPNV
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
			[Cpp2IlInjected.Address(RVA = "0xA18F620", Offset = "0xA18E420", VA = "0x18A18F620", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GLTFSceneExporter KAOYUHEQKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA18F310", Offset = "0xA18E110", VA = "0x18A18F310")]
		public KHR_materials_variants(GLTFSceneExporter exporter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA18F1B0", Offset = "0xA18DFB0", VA = "0x18A18F1B0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA18EE50", Offset = "0xA18DC50", VA = "0x18A18EE50", Slot = "5")]
		public AHNEHECEPNV Clone(JEGPMPFQLBY root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA18EFE0", Offset = "0xA18DDE0", VA = "0x18A18EFE0")]
		[CompilerGenerated]
		private JObject MPFMNSVYLAF(MappingVariant a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class Context : SSTIZANBDPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> WFQFIMMUQQJ;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA18DD90", Offset = "0xA18CB90", VA = "0x18A18DD90", Slot = "7")]
			public override void FWJFWIPZXIO(GLTFSceneExporter a, JEGPMPFQLBY b, Transform c, ITZFJUYYDSP d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA18E4E0", Offset = "0xA18D2E0", VA = "0x18A18E4E0", Slot = "5")]
			public override void UYGOMCOCIOX(GLTFSceneExporter a, JEGPMPFQLBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA18E6A0", Offset = "0xA18D4A0", VA = "0x18A18E6A0")]
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
		public override string GTTSAVBEEKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA1926C0", Offset = "0xA1914C0", VA = "0x18A1926C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA190CA0", Offset = "0xA18FAA0", VA = "0x18A190CA0", Slot = "14")]
		public override SSTIZANBDPY CreateInstance(JYOVARWRYWQ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA190DE0", Offset = "0xA18FBE0", VA = "0x18A190DE0")]
		private static (Vector2[], ushort[], Vector2[]) PRXRMEENTHR(SpriteRenderer a, Sprite b)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x19DB410", Offset = "0x19DA210", VA = "0x1819DB410")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA190D50", Offset = "0xA18FB50", VA = "0x18A190D50")]
		[CompilerGenerated]
		internal static Vector2 JBFJXRRHJST(float a, float b, <>c__DisplayClass4_0 c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA1925C0", Offset = "0xA1913C0", VA = "0x18A1925C0")]
		[CompilerGenerated]
		internal static void TJZYCATBURK(ushort a, ushort b, ushort c, ushort d, <>c__DisplayClass4_0 e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TextMeshGameObjectExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string GTTSAVBEEKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA192770", Offset = "0xA191570", VA = "0x18A192770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string RHKDOAEXMSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA192740", Offset = "0xA191540", VA = "0x18A192740", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA1926F0", Offset = "0xA1914F0", VA = "0x18A1926F0", Slot = "14")]
		public override SSTIZANBDPY CreateInstance(JYOVARWRYWQ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x19DB410", Offset = "0x19DA210", VA = "0x1819DB410")]
		public TextMeshGameObjectExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class CCDATSTBXVM : SSTIZANBDPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<Texture, RenderTexture> RQNXLJQUNGJ;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA18D480", Offset = "0xA18C280", VA = "0x18A18D480", Slot = "5")]
		public override void UYGOMCOCIOX(GLTFSceneExporter a, JEGPMPFQLBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA18CE90", Offset = "0xA18BC90", VA = "0x18A18CE90", Slot = "7")]
		public override void FWJFWIPZXIO(GLTFSceneExporter a, JEGPMPFQLBY b, Transform c, ITZFJUYYDSP d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA18CF30", Offset = "0xA18BD30", VA = "0x18A18CF30", Slot = "9")]
		public override bool QGYPTEPNFNZ(GLTFSceneExporter a, JEGPMPFQLBY b, Material c, LFPGYMTHYUP d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public CCDATSTBXVM()
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
