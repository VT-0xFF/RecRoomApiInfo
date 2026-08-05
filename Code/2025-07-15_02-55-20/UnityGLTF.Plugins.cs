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
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[LLINJMKJHDE(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9BB0830", Offset = "0x9BAF430", VA = "0x189BB0830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9BB0800", Offset = "0x9BAF400", VA = "0x189BB0800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BB07A0", Offset = "0x9BAF3A0", VA = "0x189BB07A0", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[LLINJMKJHDE(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9BB0A00", Offset = "0x9BAF600", VA = "0x189BB0A00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9BB09D0", Offset = "0x9BAF5D0", VA = "0x189BB09D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0860", Offset = "0x9BAF460", VA = "0x189BB0860", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public AudioImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IEHGPMDOHPG : ICGIFJEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class JDFHDFEIGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AudioSource DEKBNILGDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AudioDataId AJJPHAAGGJI;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA67BC0", Offset = "0xA667C0", VA = "0x180A67BC0")]
		public JDFHDFEIGCB(AudioSource DEKBNILGDMD, AudioDataId APBELAKHOKL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CCACMMEEOIH OMLHMMMGABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KHR_audio_emitter JPICIKOPLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private List<JDFHDFEIGCB> JGFJLOOGGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<int, AudioClip> ECKDDMPMHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Dictionary<int, string> CEFKNIGODMG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9BB52B0", Offset = "0x9BB3EB0", VA = "0x189BB52B0")]
	public IEHGPMDOHPG(CCACMMEEOIH PBHLPKLGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9BB4470", Offset = "0x9BB3070", VA = "0x189BB4470")]
	private void BAOPEEFJFOK(EEBBIHGHGOL OLIIIAEGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9BB4470", Offset = "0x9BB3070", VA = "0x189BB4470", Slot = "6")]
	public override void GNBOPHLPJEC(EEBBIHGHGOL LPFALNIFEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9BB46F0", Offset = "0x9BB32F0", VA = "0x189BB46F0")]
	private void DKLEDIKOEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9BB4D60", Offset = "0x9BB3960", VA = "0x189BB4D60")]
	private string NOBMCOFGBBA(string BABJKPNEIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9BB45F0", Offset = "0x9BB31F0", VA = "0x189BB45F0")]
	private AudioType DEJALCMKNKL(string BABJKPNEIND)
	{
		return default(AudioType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9BB3E90", Offset = "0x9BB2A90", VA = "0x189BB3E90")]
	private void ADKAAGFDACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9BB5010", Offset = "0x9BB3C10", VA = "0x189BB5010")]
	private void PMJFCPIEKNG(GameObject PFOGMIDIHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9BB49A0", Offset = "0x9BB35A0", VA = "0x189BB49A0")]
	private void KOFGILKJBJJ(KHR_AudioEmitter NANPFIFNOKJ, GameObject PMMNPPLNFHD, bool HHONCEKMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9BB4960", Offset = "0x9BB3560", VA = "0x189BB4960", Slot = "11")]
	public override void GNEGNJAKEPF(DPPJKKPNPHL CMBCIMNOCEH, int NIHHGEAIOGB, GameObject PFOGMIDIHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9BB4E80", Offset = "0x9BB3A80", VA = "0x189BB4E80", Slot = "8")]
	public override void OBMANOPCBCO(GCJECACEHBN PBBEMEGKFPO, int DGOOJPINDFJ, GameObject BJPENCKFDJG)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[MPDMAAHGFJO(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9BB0B70", Offset = "0x9BAF770", VA = "0x189BB0B70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9BB0B40", Offset = "0x9BAF740", VA = "0x189BB0B40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0A30", Offset = "0x9BAF630", VA = "0x189BB0A30", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public BakeParticleSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OEABLAADIKP : HAINKNBMHAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> MGDPCHKGEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<UnityEngine.Object> BJJJIFNDEMC;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9BB61E0", Offset = "0x9BB4DE0", VA = "0x189BB61E0", Slot = "7")]
	public override void OFGEELJJIDB(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9BB5EE0", Offset = "0x9BB4AE0", VA = "0x189BB5EE0", Slot = "5")]
	public override void LEFJOHKPFPH(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9BB5E40", Offset = "0x9BB4A40", VA = "0x189BB5E40")]
	private static void BHEAAFGCOOD(UnityEngine.Object FKPCPEEFHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9BB6490", Offset = "0x9BB5090", VA = "0x189BB6490")]
	public OEABLAADIKP()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[MPDMAAHGFJO(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9BB1CD0", Offset = "0x9BB08D0", VA = "0x189BB1CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9BB1CA0", Offset = "0x9BB08A0", VA = "0x189BB1CA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1C50", Offset = "0x9BB0850", VA = "0x189BB1C50", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public CanvasExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DMBEGIHICPH : HAINKNBMHAH
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static Shader NKBOHNKGJLG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9BB3050", Offset = "0x9BB1C50", VA = "0x189BB3050", Slot = "8")]
	public override void MLOPPEFHAKP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL OLIIIAEGOLD, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public DMBEGIHICPH()
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
		private Mesh MOGMOMKEFJC;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
		public void ModifyMesh(Mesh MOGMOMKEFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1B70", Offset = "0x9BB0770", VA = "0x189BB1B70", Slot = "5")]
		public void ModifyMesh(VertexHelper PHJMJLCPIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1740", Offset = "0x9BB0340", VA = "0x189BB1740")]
		public bool GetMeshAndMaterial([Out] Mesh MOGMOMKEFJC, [Out] Material CIBNABIMGCK, Shader NKBOHNKGJLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1540", Offset = "0x9BB0140", VA = "0x189BB1540")]
		public void CaptureTo(Transform OLIIIAEGOLD, GameObject PNHJJLPACLP, Shader NKBOHNKGJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
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
				[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[MPDMAAHGFJO(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9BB5E10", Offset = "0x9BB4A10", VA = "0x189BB5E10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9BB5DE0", Offset = "0x9BB49E0", VA = "0x189BB5DE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5D90", Offset = "0x9BB4990", VA = "0x189BB5D90", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public MaterialVariantsPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DBNCPBNMJEE : HAINKNBMHAH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class AAOPBLBIJEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Transform node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AAOPBLBIJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0730", Offset = "0x9BAF330", VA = "0x189BB0730")]
		internal bool DGDJMDLBHKA(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class IPAMFDKBLJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int subMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Material exportMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AAOPBLBIJEF CS$<>8__locals1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IPAMFDKBLJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9BB53F0", Offset = "0x9BB3FF0", VA = "0x189BB53F0")]
		internal bool JOHBPCJCMDB(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x9BB1D00", Offset = "0x9BB0900", VA = "0x189BB1D00", Slot = "5")]
	public override void LEFJOHKPFPH(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL NOENPNBGFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public DBNCPBNMJEE()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : AIMPEIJNMBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5AF0", Offset = "0x9BB46F0", VA = "0x189BB5AF0", Slot = "4")]
		public JProperty PBHGMJKEMBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5A80", Offset = "0x9BB4680", VA = "0x189BB5A80", Slot = "5")]
		public AIMPEIJNMBC JEKMEOOFFAJ(EEBBIHGHGOL OLIIIAEGOLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : AIMPEIJNMBC
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
			[Cpp2IlInjected.Address(RVA = "0x9BB5D10", Offset = "0x9BB4910", VA = "0x189BB5D10", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private DDIHIDBGEBH exporter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9BB59E0", Offset = "0x9BB45E0", VA = "0x189BB59E0")]
		public KHR_materials_variants(DDIHIDBGEBH OOJHOOBDAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5860", Offset = "0x9BB4460", VA = "0x189BB5860", Slot = "4")]
		public JProperty PBHGMJKEMBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9BB54E0", Offset = "0x9BB40E0", VA = "0x189BB54E0", Slot = "5")]
		public AIMPEIJNMBC JEKMEOOFFAJ(EEBBIHGHGOL OLIIIAEGOLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5670", Offset = "0x9BB4270", VA = "0x189BB5670")]
		[CompilerGenerated]
		private JObject NPBPDDICDAF(MappingVariant LGCEHLADNJC)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class CBNBNFBHHLP : HAINKNBMHAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> HGGBEEGOOOM;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9BB0D40", Offset = "0x9BAF940", VA = "0x189BB0D40", Slot = "7")]
			public override void OFGEELJJIDB(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9BB0BA0", Offset = "0x9BAF7A0", VA = "0x189BB0BA0", Slot = "5")]
			public override void LEFJOHKPFPH(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9BB14B0", Offset = "0x9BB00B0", VA = "0x189BB14B0")]
			public CBNBNFBHHLP()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct ODILBCBGEFH
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
			[Cpp2IlInjected.Address(RVA = "0x9BB7CE0", Offset = "0x9BB68E0", VA = "0x189BB7CE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7A20", Offset = "0x9BB6620", VA = "0x189BB7A20", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9BB6560", Offset = "0x9BB5160", VA = "0x189BB6560")]
		private static (Vector2[], ushort[], Vector2[]) EHPNJHOECHI(SpriteRenderer NMGNJGPOFCI, Sprite MDILAKMPEME)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7AE0", Offset = "0x9BB66E0", VA = "0x189BB7AE0")]
		[CompilerGenerated]
		internal static Vector2 ICFMLCNHDMB(float MHGMAJNONPC, float PNDECLAFCHF, ODILBCBGEFH P_2)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7BE0", Offset = "0x9BB67E0", VA = "0x189BB7BE0")]
		[CompilerGenerated]
		internal static void MOGPDCEJPHD(ushort JPILOOHOBDJ, ushort MAKDDCFIOBO, ushort FBNAMAEDFNA, ushort MIBBFFFNMGG, ODILBCBGEFH P_4)
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
			[Cpp2IlInjected.Address(RVA = "0x9BB7D90", Offset = "0x9BB6990", VA = "0x189BB7D90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9BB7D60", Offset = "0x9BB6960", VA = "0x189BB7D60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7D10", Offset = "0x9BB6910", VA = "0x189BB7D10", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public TextMeshGameObjectExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HDJINLJEMAN : HAINKNBMHAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<Texture, RenderTexture> IKIBMOIPBGO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9BB3710", Offset = "0x9BB2310", VA = "0x189BB3710", Slot = "5")]
	public override void LEFJOHKPFPH(DDIHIDBGEBH HPNKJCMLGMJ, EEBBIHGHGOL NGENHMBMKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9BB3DF0", Offset = "0x9BB29F0", VA = "0x189BB3DF0", Slot = "7")]
	public override void OFGEELJJIDB(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9BB3880", Offset = "0x9BB2480", VA = "0x189BB3880", Slot = "9")]
	public override bool OAAPCPEPDAP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Material CIBNABIMGCK, IBKALPNABJD FIAJENKIKEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public HDJINLJEMAN()
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
