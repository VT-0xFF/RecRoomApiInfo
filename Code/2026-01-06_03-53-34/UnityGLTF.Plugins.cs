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
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[NonRatifiedPlugin(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool MVQOJPYSRSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool FUFYAALZRYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA030190", Offset = "0xA02EB90", VA = "0x18A030190", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA030160", Offset = "0xA02EB60", VA = "0x18A030160", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA030100", Offset = "0xA02EB00", VA = "0x18A030100", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x16D2550", Offset = "0x16D0F50", VA = "0x1816D2550")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[NonRatifiedPlugin(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool FUFYAALZRYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA030340", Offset = "0xA02ED40", VA = "0x18A030340", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA030310", Offset = "0xA02ED10", VA = "0x18A030310", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0301C0", Offset = "0xA02EBC0", VA = "0x18A0301C0", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x16D2550", Offset = "0x16D0F50", VA = "0x1816D2550")]
		public AudioImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class XHBKYLASLIN : ZBWCSHABZTR
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class FZAAETPAKTG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AudioSource XUGQZLSCACW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public AudioDataId YQZDYOVZCQK;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABCB10", VA = "0x180ABE110")]
			public FZAAETPAKTG(AudioSource a, AudioDataId b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GKBIBFXCLMW KKZVEULAXOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private KHR_audio_emitter WHTAQKEQOUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private List<FZAAETPAKTG> ARMTAGFOHEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Dictionary<int, AudioClip> AGODQOONZTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Dictionary<int, string> JHSUJUCNOTE;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA037330", Offset = "0xA035D30", VA = "0x18A037330")]
		public XHBKYLASLIN(GKBIBFXCLMW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0360A0", Offset = "0xA034AA0", VA = "0x18A0360A0")]
		private void TSWTGRMJZIW(WTVTOFLEGQC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0360A0", Offset = "0xA034AA0", VA = "0x18A0360A0", Slot = "6")]
		public override void AKVRFNLAZUV(WTVTOFLEGQC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA036260", Offset = "0xA034C60", VA = "0x18A036260")]
		private void BOIPEACIBIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA037110", Offset = "0xA035B10", VA = "0x18A037110")]
		private string ZDATPZMDRPR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA037230", Offset = "0xA035C30", VA = "0x18A037230")]
		private AudioType ZVOACJKJZYA(string a)
		{
			return default(AudioType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA036880", Offset = "0xA035280", VA = "0x18A036880")]
		private void CMDCMSWCUMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA036E70", Offset = "0xA035870", VA = "0x18A036E70")]
		private void SHXQCWOZTHE(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA0364D0", Offset = "0xA034ED0", VA = "0x18A0364D0")]
		private void CFGIFFHFHYQ(KHR_AudioEmitter a, GameObject b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA036220", Offset = "0xA034C20", VA = "0x18A036220", Slot = "11")]
		public override void AOUXMVJCKGT(FHGUWOJFITY a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA035F10", Offset = "0xA034910", VA = "0x18A035F10", Slot = "8")]
		public override void AEIZNWAUJBT(BERLEXGGYBZ a, int b, GameObject c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[ExperimentalPlugin(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA030490", Offset = "0xA02EE90", VA = "0x18A030490", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA030460", Offset = "0xA02EE60", VA = "0x18A030460", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool FUFYAALZRYS
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA030370", Offset = "0xA02ED70", VA = "0x18A030370", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x16D2550", Offset = "0x16D0F50", VA = "0x1816D2550")]
		public BakeParticleSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AFKVUWFIXXO : NVPVEURSWXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<Component> LPPZGRJTQNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<UnityEngine.Object> VXDPVVOAQOU;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA02FA60", Offset = "0xA02E460", VA = "0x18A02FA60", Slot = "7")]
		public override void DYLDTRGEEZU(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA02FDD0", Offset = "0xA02E7D0", VA = "0x18A02FDD0", Slot = "5")]
		public override void XPSISWXJQFV(GLTFSceneExporter a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA02FD10", Offset = "0xA02E710", VA = "0x18A02FD10")]
		private static void KTYTIKVPMYY(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA030040", Offset = "0xA02EA40", VA = "0x18A030040")]
		public AFKVUWFIXXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[ExperimentalPlugin(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA030C30", Offset = "0xA02F630", VA = "0x18A030C30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA030C00", Offset = "0xA02F600", VA = "0x18A030C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool FUFYAALZRYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA030BB0", Offset = "0xA02F5B0", VA = "0x18A030BB0", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x16D2550", Offset = "0x16D0F50", VA = "0x1816D2550")]
		public CanvasExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SSVBIQGGPDK : NVPVEURSWXA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static Shader NCYNUMEVQYG;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA032780", Offset = "0xA031180", VA = "0x18A032780", Slot = "8")]
		public override void XGUTBCAIYDT(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public SSVBIQGGPDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu(null)]
	internal class CanvasExportCaptureMeshHelper : MonoBehaviour, IMeshModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Mesh RNUVXSOSTUS;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "4")]
		public void ModifyMesh(Mesh mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA030AE0", Offset = "0xA02F4E0", VA = "0x18A030AE0", Slot = "5")]
		public void ModifyMesh(VertexHelper verts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA0306C0", Offset = "0xA02F0C0", VA = "0x18A0306C0")]
		public bool GetMeshAndMaterial([Out] Mesh mesh, [Out] Material material, Shader shader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA0304C0", Offset = "0xA02EEC0", VA = "0x18A0304C0")]
		public void CaptureTo(Transform root, GameObject shadow, Shader shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
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
				[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExperimentalPlugin(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA031E90", Offset = "0xA030890", VA = "0x18A031E90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA031E60", Offset = "0xA030860", VA = "0x18A031E60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA031E10", Offset = "0xA030810", VA = "0x18A031E10", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x16D2550", Offset = "0x16D0F50", VA = "0x1816D2550")]
		public MaterialVariantsPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class STFKJXRAJJA : NVPVEURSWXA
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Transform CBWCVBMBGYT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> VQRNVFLBTHM;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA032710", Offset = "0xA031110", VA = "0x18A032710")]
			internal bool UXSPAPHXCYB(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class QFGTGBWYVMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int DTIRZZUKNHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Material CMSSIOXZYAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public QFMADIQWEXT MNSDRRJEMWM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Func<MaterialVariants.Variant.MaterialSet, bool> VRHIMZSTVPN;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public QFGTGBWYVMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA032620", Offset = "0xA031020", VA = "0x18A032620")]
			internal bool UXXVXWBUMJK(MaterialVariants.Variant.MaterialSet a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA032E30", Offset = "0xA031830", VA = "0x18A032E30", Slot = "5")]
		public override void XPSISWXJQFV(GLTFSceneExporter a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public STFKJXRAJJA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : RCVNBXYDJZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA031BA0", Offset = "0xA0305A0", VA = "0x18A031BA0", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA031B30", Offset = "0xA030530", VA = "0x18A031B30", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : RCVNBXYDJZR
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
			[Cpp2IlInjected.Address(RVA = "0xA031D90", Offset = "0xA030790", VA = "0x18A031D90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GLTFSceneExporter XNEXFZJLSAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA031A90", Offset = "0xA030490", VA = "0x18A031A90")]
		public KHR_materials_variants(GLTFSceneExporter exporter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA031930", Offset = "0xA030330", VA = "0x18A031930", Slot = "4")]
		public JProperty Serialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA0315E0", Offset = "0xA02FFE0", VA = "0x18A0315E0", Slot = "5")]
		public RCVNBXYDJZR Clone(WTVTOFLEGQC root)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA031760", Offset = "0xA030160", VA = "0x18A031760")]
		[CompilerGenerated]
		private JObject KHCBTEYHEUV(MappingVariant a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class Context : NVPVEURSWXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> PIABDNHNAKZ;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA030C60", Offset = "0xA02F660", VA = "0x18A030C60", Slot = "7")]
			public override void DYLDTRGEEZU(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA0313A0", Offset = "0xA02FDA0", VA = "0x18A0313A0", Slot = "5")]
			public override void XPSISWXJQFV(GLTFSceneExporter a, WTVTOFLEGQC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA031560", Offset = "0xA02FF60", VA = "0x18A031560")]
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
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA0359E0", Offset = "0xA0343E0", VA = "0x18A0359E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA033FC0", Offset = "0xA0329C0", VA = "0x18A033FC0", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA034200", Offset = "0xA032C00", VA = "0x18A034200")]
		private static (Vector2[], ushort[], Vector2[]) TEFSQSRIZZB(SpriteRenderer a, Sprite b)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x16D2550", Offset = "0x16D0F50", VA = "0x1816D2550")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA034070", Offset = "0xA032A70", VA = "0x18A034070")]
		[CompilerGenerated]
		internal static Vector2 LXJDQEGZSFF(float a, float b, <>c__DisplayClass4_0 c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA034100", Offset = "0xA032B00", VA = "0x18A034100")]
		[CompilerGenerated]
		internal static void NWEFFOFSALC(ushort a, ushort b, ushort c, ushort d, <>c__DisplayClass4_0 e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TextMeshGameObjectExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA035A90", Offset = "0xA034490", VA = "0x18A035A90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA035A60", Offset = "0xA034460", VA = "0x18A035A60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA035A10", Offset = "0xA034410", VA = "0x18A035A10", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x16D2550", Offset = "0x16D0F50", VA = "0x1816D2550")]
		public TextMeshGameObjectExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OTQCOKEWKJU : NVPVEURSWXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Dictionary<Texture, RenderTexture> YJJPMWLCLQZ;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA0324B0", Offset = "0xA030EB0", VA = "0x18A0324B0", Slot = "5")]
		public override void XPSISWXJQFV(GLTFSceneExporter a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA031EC0", Offset = "0xA0308C0", VA = "0x18A031EC0", Slot = "7")]
		public override void DYLDTRGEEZU(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA031F60", Offset = "0xA030960", VA = "0x18A031F60", Slot = "9")]
		public override bool SYBEISKFSHN(GLTFSceneExporter a, WTVTOFLEGQC b, Material c, OFRYBPDMWCH d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public OTQCOKEWKJU()
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
