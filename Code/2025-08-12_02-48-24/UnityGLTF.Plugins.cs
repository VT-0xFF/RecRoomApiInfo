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
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DOJCEAMCAEN(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9F5EE50", Offset = "0x9F5D450", VA = "0x189F5EE50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9F5EE20", Offset = "0x9F5D420", VA = "0x189F5EE20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9F5EDC0", Offset = "0x9F5D3C0", VA = "0x189F5EDC0", Slot = "14")]
		public override NEIOLEIJNLF MMOANNGKKCJ(PANCEFCDEBH HHPFOCCGJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DOJCEAMCAEN(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9F5F020", Offset = "0x9F5D620", VA = "0x189F5F020", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9F5EFF0", Offset = "0x9F5D5F0", VA = "0x189F5EFF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5EE80", Offset = "0x9F5D480", VA = "0x189F5EE80", Slot = "13")]
		public override MOPMEJHJBHO MMOANNGKKCJ(OLOHGHMILBG HHPFOCCGJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public AudioImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HLDCLDCIFNJ : MOPMEJHJBHO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class LIKKPLHEOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AudioSource FDHHMJDPGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AudioDataId ADEFPBMCGDH;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA94D60", Offset = "0xA93360", VA = "0x180A94D60")]
		public LIKKPLHEOKE(AudioSource FDHHMJDPGCH, AudioDataId IDKDBOIGKHL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OLOHGHMILBG HMCGFFOOIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KHR_audio_emitter HEIOFEGAEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private List<LIKKPLHEOKE> DGMHNHJAPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<int, AudioClip> CDHNPJDBPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Dictionary<int, string> GLEKEIFNLAA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9F614E0", Offset = "0x9F5FAE0", VA = "0x189F614E0")]
	public HLDCLDCIFNJ(OLOHGHMILBG HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9F61360", Offset = "0x9F5F960", VA = "0x189F61360")]
	private void PIJFHFAKBLH(ODFBKBJAHBE PPOKNBNEDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9F61360", Offset = "0x9F5F960", VA = "0x189F61360", Slot = "6")]
	public override void OEGHCCCHBND(ODFBKBJAHBE KGILCINJKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9F60A80", Offset = "0x9F5F080", VA = "0x189F60A80")]
	private void JJKAAJHNKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9F60960", Offset = "0x9F5EF60", VA = "0x189F60960")]
	private string IIGDAAPGIMO(string JHKHLJEKOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9F60280", Offset = "0x9F5E880", VA = "0x189F60280")]
	private AudioType EAMELCKEJMI(string JHKHLJEKOLA)
	{
		return default(AudioType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9F60380", Offset = "0x9F5E980", VA = "0x189F60380")]
	private void IENBMGPAIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9F610B0", Offset = "0x9F5F6B0", VA = "0x189F610B0")]
	private void LLHAFNGCMNO(GameObject JAKGGEGIGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9F60CF0", Offset = "0x9F5F2F0", VA = "0x189F60CF0")]
	private void LLFAKICAEMA(KHR_AudioEmitter ACNBPHMEBIL, GameObject HPDKLCCOKBC, bool FBDCMDIKHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9F60240", Offset = "0x9F5E840", VA = "0x189F60240", Slot = "11")]
	public override void DFIBKLPHDMH(MJLGMELAKAH PDFMOBOALJB, int KCJJLNAHDKI, GameObject JAKGGEGIGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9F600B0", Offset = "0x9F5E6B0", VA = "0x189F600B0", Slot = "8")]
	public override void AKEJLEHKBBJ(FAAAIFMJNGC CFHHNIJODJI, int EDGKMKKEHNJ, GameObject HDOLMHOHGKA)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[MNIOINKLJGD(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9F5F190", Offset = "0x9F5D790", VA = "0x189F5F190", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9F5F160", Offset = "0x9F5D760", VA = "0x189F5F160", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5F050", Offset = "0x9F5D650", VA = "0x189F5F050", Slot = "14")]
		public override NEIOLEIJNLF MMOANNGKKCJ(PANCEFCDEBH HHPFOCCGJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public BakeParticleSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KLCBKIJFGFC : NEIOLEIJNLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> NDCGBACHLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<UnityEngine.Object> NPEALMKHIDA;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9F62150", Offset = "0x9F60750", VA = "0x189F62150", Slot = "7")]
	public override void JHJKMAPGLLF(CMOPDBEMMCD DMOFDIAEEHN, ODFBKBJAHBE KGILCINJKPF, Transform JAHKFPBBGHB, FAAAIFMJNGC CFHHNIJODJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9F61E50", Offset = "0x9F60450", VA = "0x189F61E50", Slot = "5")]
	public override void DPLBDNNOHBJ(CMOPDBEMMCD DMOFDIAEEHN, ODFBKBJAHBE KGILCINJKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9F623B0", Offset = "0x9F609B0", VA = "0x189F623B0")]
	private static void KMINHOBELBC(UnityEngine.Object OOHPPJENJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9F62450", Offset = "0x9F60A50", VA = "0x189F62450")]
	public KLCBKIJFGFC()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[MNIOINKLJGD(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9F5F950", Offset = "0x9F5DF50", VA = "0x189F5F950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9F5F920", Offset = "0x9F5DF20", VA = "0x189F5F920", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9F5F8D0", Offset = "0x9F5DED0", VA = "0x189F5F8D0", Slot = "14")]
		public override NEIOLEIJNLF MMOANNGKKCJ(PANCEFCDEBH HHPFOCCGJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public CanvasExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FFOLDNLEHDG : NEIOLEIJNLF
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static Shader IHMPIMNLCPH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9F5F9F0", Offset = "0x9F5DFF0", VA = "0x189F5F9F0", Slot = "8")]
	public override void NAAEFAEHDHL(CMOPDBEMMCD DMOFDIAEEHN, ODFBKBJAHBE PPOKNBNEDHM, Transform JAHKFPBBGHB, FAAAIFMJNGC CFHHNIJODJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public FFOLDNLEHDG()
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
		private Mesh LJNJDNJBNIE;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void ModifyMesh(Mesh LJNJDNJBNIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9F5F7F0", Offset = "0x9F5DDF0", VA = "0x189F5F7F0", Slot = "5")]
		public void ModifyMesh(VertexHelper MNNAHDCEFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5F3C0", Offset = "0x9F5D9C0", VA = "0x189F5F3C0")]
		public bool GetMeshAndMaterial([Out] Mesh LJNJDNJBNIE, [Out] Material JKDFAJLFBEL, Shader IHMPIMNLCPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5F1C0", Offset = "0x9F5D7C0", VA = "0x189F5F1C0")]
		public void CaptureTo(Transform PPOKNBNEDHM, GameObject OIGNGLKOEDG, Shader IHMPIMNLCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[MNIOINKLJGD(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9F62DA0", Offset = "0x9F613A0", VA = "0x189F62DA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9F62D70", Offset = "0x9F61370", VA = "0x189F62D70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9F62D20", Offset = "0x9F61320", VA = "0x189F62D20", Slot = "14")]
		public override NEIOLEIJNLF MMOANNGKKCJ(PANCEFCDEBH HHPFOCCGJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public MaterialVariantsPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PEJEDAAONCN : NEIOLEIJNLF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class DGMAHJNDHFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Transform node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public DGMAHJNDHFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5F980", Offset = "0x9F5DF80", VA = "0x189F5F980")]
		internal bool DFBIAHPDHMJ(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class APKPDCGGIBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int subMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Material exportMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DGMAHJNDHFB CS$<>8__locals1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public APKPDCGGIBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9F5ECD0", Offset = "0x9F5D2D0", VA = "0x189F5ECD0")]
		internal bool PDGABFNLIBI(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x9F63720", Offset = "0x9F61D20", VA = "0x189F63720", Slot = "5")]
	public override void DPLBDNNOHBJ(CMOPDBEMMCD DMOFDIAEEHN, ODFBKBJAHBE HCMJOCBMEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public PEJEDAAONCN()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : CMBLNFIAIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9F61BC0", Offset = "0x9F601C0", VA = "0x189F61BC0", Slot = "4")]
		public JProperty CAELEDFILEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9F61DE0", Offset = "0x9F603E0", VA = "0x189F61DE0", Slot = "5")]
		public CMBLNFIAIJM JJDCBGIHCCL(ODFBKBJAHBE PPOKNBNEDHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : CMBLNFIAIJM
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
			[Cpp2IlInjected.Address(RVA = "0x9F62CA0", Offset = "0x9F612A0", VA = "0x189F62CA0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CMOPDBEMMCD exporter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F61B20", Offset = "0x9F60120", VA = "0x189F61B20")]
		public KHR_materials_variants(CMOPDBEMMCD DMOFDIAEEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F61620", Offset = "0x9F5FC20", VA = "0x189F61620", Slot = "4")]
		public JProperty CAELEDFILEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9F61990", Offset = "0x9F5FF90", VA = "0x189F61990", Slot = "5")]
		public CMBLNFIAIJM JJDCBGIHCCL(ODFBKBJAHBE PPOKNBNEDHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F617A0", Offset = "0x9F5FDA0", VA = "0x189F617A0")]
		[CompilerGenerated]
		private JObject JGNKIKIONIC(MappingVariant POMPNNDHCKO)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class NDCIBBNAKPD : NEIOLEIJNLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> BHEMEENDCOD;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9F62F70", Offset = "0x9F61570", VA = "0x189F62F70", Slot = "7")]
			public override void JHJKMAPGLLF(CMOPDBEMMCD DMOFDIAEEHN, ODFBKBJAHBE KGILCINJKPF, Transform JAHKFPBBGHB, FAAAIFMJNGC CFHHNIJODJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9F62DD0", Offset = "0x9F613D0", VA = "0x189F62DD0", Slot = "5")]
			public override void DPLBDNNOHBJ(CMOPDBEMMCD DMOFDIAEEHN, ODFBKBJAHBE KGILCINJKPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9F63690", Offset = "0x9F61C90", VA = "0x189F63690")]
			public NDCIBBNAKPD()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct AFKKGAMAGCO
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
			[Cpp2IlInjected.Address(RVA = "0x9F661F0", Offset = "0x9F647F0", VA = "0x189F661F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9F66030", Offset = "0x9F64630", VA = "0x189F66030", Slot = "14")]
		public override NEIOLEIJNLF MMOANNGKKCJ(PANCEFCDEBH HHPFOCCGJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F64A70", Offset = "0x9F63070", VA = "0x189F64A70")]
		private static (Vector2[], ushort[], Vector2[]) EKLKMLHFMOJ(SpriteRenderer PHHDHBAFNEH, Sprite LEKCEIIOPND)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9F65F30", Offset = "0x9F64530", VA = "0x189F65F30")]
		[CompilerGenerated]
		internal static Vector2 IIPOBHBIKCK(float NCKIOHJLABC, float JOBNJBAGCAN, AFKKGAMAGCO P_2)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9F660F0", Offset = "0x9F646F0", VA = "0x189F660F0")]
		[CompilerGenerated]
		internal static void NIGEJIFNDEI(ushort IAFDMJDNHDH, ushort DFKKOPOBCBA, ushort JNNOBIJIOOK, ushort BBJNPAEMBIM, AFKKGAMAGCO P_4)
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
			[Cpp2IlInjected.Address(RVA = "0x9F662A0", Offset = "0x9F648A0", VA = "0x189F662A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9F66270", Offset = "0x9F64870", VA = "0x189F66270", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F66220", Offset = "0x9F64820", VA = "0x189F66220", Slot = "14")]
		public override NEIOLEIJNLF MMOANNGKKCJ(PANCEFCDEBH HHPFOCCGJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public TextMeshGameObjectExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KNJBGEICICO : NEIOLEIJNLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<Texture, RenderTexture> LMJLACBIAPK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9F62520", Offset = "0x9F60B20", VA = "0x189F62520", Slot = "5")]
	public override void DPLBDNNOHBJ(CMOPDBEMMCD CGLIDCMIAEF, ODFBKBJAHBE FEMMKOBPFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9F62C00", Offset = "0x9F61200", VA = "0x189F62C00", Slot = "7")]
	public override void JHJKMAPGLLF(CMOPDBEMMCD DMOFDIAEEHN, ODFBKBJAHBE KGILCINJKPF, Transform JAHKFPBBGHB, FAAAIFMJNGC CFHHNIJODJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9F62690", Offset = "0x9F60C90", VA = "0x189F62690", Slot = "9")]
	public override bool HBNILGMNELO(CMOPDBEMMCD DMOFDIAEEHN, ODFBKBJAHBE KGILCINJKPF, Material JKDFAJLFBEL, OGGAHFGGFMK LPJLHBKPHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public KNJBGEICICO()
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
