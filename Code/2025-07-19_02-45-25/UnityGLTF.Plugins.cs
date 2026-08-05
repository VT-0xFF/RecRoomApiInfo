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
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[HHGMMINJFGO(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9C29A60", Offset = "0x9C28A60", VA = "0x189C29A60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9C29A30", Offset = "0x9C28A30", VA = "0x189C29A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C299D0", Offset = "0x9C289D0", VA = "0x189C299D0", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[HHGMMINJFGO(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9C29C30", Offset = "0x9C28C30", VA = "0x189C29C30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9C29C00", Offset = "0x9C28C00", VA = "0x189C29C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C29A90", Offset = "0x9C28A90", VA = "0x189C29A90", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public AudioImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PCLNOEABCLK : BJGLPJBGPPC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class KKGBGIKCIHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AudioSource IOFHCDLLALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AudioDataId BAFAKGHLBFM;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA653E0", Offset = "0xA643E0", VA = "0x180A653E0")]
		public KKGBGIKCIHN(AudioSource IOFHCDLLALA, AudioDataId OOMELHOPOCP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JNADKFAPCEK APPOPGIENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KHR_audio_emitter ACNNANAFLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private List<KKGBGIKCIHN> ENBKJNEMPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<int, AudioClip> DIPNFBNHPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Dictionary<int, string> JHOPHFIPMJO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9C2F6C0", Offset = "0x9C2E6C0", VA = "0x189C2F6C0")]
	public PCLNOEABCLK(JNADKFAPCEK IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9C2E430", Offset = "0x9C2D430", VA = "0x189C2E430")]
	private void DMPAKJMIIBO(CNIIHPEFGGP NKBKNNLLHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9C2E430", Offset = "0x9C2D430", VA = "0x189C2E430", Slot = "6")]
	public override void BLOAIGDJNDC(CNIIHPEFGGP HPAACAMAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9C2E5B0", Offset = "0x9C2D5B0", VA = "0x189C2E5B0")]
	private void GHBOCKAMEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9C2F5A0", Offset = "0x9C2E5A0", VA = "0x189C2F5A0")]
	private string OGEHNEOKFCG(string GPJHIMJKJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9C2EE00", Offset = "0x9C2DE00", VA = "0x189C2EE00")]
	private AudioType KEOHFAFPLAJ(string GPJHIMJKJOA)
	{
		return default(AudioType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9C2E820", Offset = "0x9C2D820", VA = "0x189C2E820")]
	private void IBHJLKDBEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9C2F300", Offset = "0x9C2E300", VA = "0x189C2F300")]
	private void OEMNCELLLGF(GameObject BKPEODADMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9C2EF40", Offset = "0x9C2DF40", VA = "0x189C2EF40")]
	private void LMOOHEGAPPH(KHR_AudioEmitter NEHMNKLGOKI, GameObject OEFOHFDLKOB, bool CMBOHEPODPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9C2EF00", Offset = "0x9C2DF00", VA = "0x189C2EF00", Slot = "11")]
	public override void LFHLMGMKLLE(EJGANAMIGAK KJIOEGBKNOL, int MAENJMKCDDI, GameObject BKPEODADMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9C2E2A0", Offset = "0x9C2D2A0", VA = "0x189C2E2A0", Slot = "8")]
	public override void AHMJLKAIMMI(EOEJDHNLIOH ABOLKPCCJOL, int KJEACKDADJM, GameObject OOJEEGFLMBO)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[HLIIDKLNKKH(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9C29DA0", Offset = "0x9C28DA0", VA = "0x189C29DA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9C29D70", Offset = "0x9C28D70", VA = "0x189C29D70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C29C60", Offset = "0x9C28C60", VA = "0x189C29C60", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public BakeParticleSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FKCGDODAOEF : GMHJHFOKIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> CCKGGEBONAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<UnityEngine.Object> LMJHJCEFNLE;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9C2C0D0", Offset = "0x9C2B0D0", VA = "0x189C2C0D0", Slot = "7")]
	public override void IPECIJEIOIO(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9C2C380", Offset = "0x9C2B380", VA = "0x189C2C380", Slot = "5")]
	public override void OOPHHNDAEGJ(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9C2C680", Offset = "0x9C2B680", VA = "0x189C2C680")]
	private static void PLIGGFBLDAL(UnityEngine.Object FOIEAAPDPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9C2C720", Offset = "0x9C2B720", VA = "0x189C2C720")]
	public FKCGDODAOEF()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[HLIIDKLNKKH(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9C2B920", Offset = "0x9C2A920", VA = "0x189C2B920", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9C2B8F0", Offset = "0x9C2A8F0", VA = "0x189C2B8F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B8A0", Offset = "0x9C2A8A0", VA = "0x189C2B8A0", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public CanvasExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OIFPBMPDBKN : GMHJHFOKIMI
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static Shader FIFMLGDAANB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9C2DBE0", Offset = "0x9C2CBE0", VA = "0x189C2DBE0", Slot = "8")]
	public override void GLFMIBKLNCM(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP NKBKNNLLHKF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public OIFPBMPDBKN()
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
		private Mesh BFBFJIKLAEJ;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void ModifyMesh(Mesh BFBFJIKLAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B7C0", Offset = "0x9C2A7C0", VA = "0x189C2B7C0", Slot = "5")]
		public void ModifyMesh(VertexHelper HHABOHOHJNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B390", Offset = "0x9C2A390", VA = "0x189C2B390")]
		public bool GetMeshAndMaterial([Out] Mesh BFBFJIKLAEJ, [Out] Material JNBIMACAHOC, Shader FIFMLGDAANB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B190", Offset = "0x9C2A190", VA = "0x189C2B190")]
		public void CaptureTo(Transform NKBKNNLLHKF, GameObject DBCBNCINCDL, Shader FIFMLGDAANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[HLIIDKLNKKH(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9C2DBB0", Offset = "0x9C2CBB0", VA = "0x189C2DBB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9C2DB80", Offset = "0x9C2CB80", VA = "0x189C2DB80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9C2DB30", Offset = "0x9C2CB30", VA = "0x189C2DB30", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public MaterialVariantsPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CMEJPLFODNK : GMHJHFOKIMI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CJFGCGFIJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Transform node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public CJFGCGFIJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C29DD0", Offset = "0x9C28DD0", VA = "0x189C29DD0")]
		internal bool IMOOKALMKIP(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class HNJAOKFDIIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int subMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Material exportMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CJFGCGFIJGP CS$<>8__locals1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HNJAOKFDIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C2C7F0", Offset = "0x9C2B7F0", VA = "0x189C2C7F0")]
		internal bool HIEMMBCNPLK(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x9C29E40", Offset = "0x9C28E40", VA = "0x189C29E40", Slot = "5")]
	public override void OOPHHNDAEGJ(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP GGJNHNJNFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public CMEJPLFODNK()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : FEDEIKABHJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D890", Offset = "0x9C2C890", VA = "0x189C2D890", Slot = "4")]
		public JProperty FBGBLPHHDGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D820", Offset = "0x9C2C820", VA = "0x189C2D820", Slot = "5")]
		public FEDEIKABHJG AABAGJPEDHJ(CNIIHPEFGGP NKBKNNLLHKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : FEDEIKABHJG
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
			[Cpp2IlInjected.Address(RVA = "0x9C2DAB0", Offset = "0x9C2CAB0", VA = "0x189C2DAB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private EEJGCGOJGCD exporter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D780", Offset = "0x9C2C780", VA = "0x189C2D780")]
		public KHR_materials_variants(EEJGCGOJGCD LNCGGHOFHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D600", Offset = "0x9C2C600", VA = "0x189C2D600", Slot = "4")]
		public JProperty FBGBLPHHDGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D280", Offset = "0x9C2C280", VA = "0x189C2D280", Slot = "5")]
		public FEDEIKABHJG AABAGJPEDHJ(CNIIHPEFGGP NKBKNNLLHKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D410", Offset = "0x9C2C410", VA = "0x189C2D410")]
		[CompilerGenerated]
		private JObject EDLOCHDPKCN(MappingVariant OEFDFBLCHHF)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class IPCGEFDKGIF : GMHJHFOKIMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> EENPDFPJHCC;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9C2C8E0", Offset = "0x9C2B8E0", VA = "0x189C2C8E0", Slot = "7")]
			public override void IPECIJEIOIO(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9C2D050", Offset = "0x9C2C050", VA = "0x189C2D050", Slot = "5")]
			public override void OOPHHNDAEGJ(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9C2D1F0", Offset = "0x9C2C1F0", VA = "0x189C2D1F0")]
			public IPCGEFDKGIF()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct ICKGJEJMAJI
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
			[Cpp2IlInjected.Address(RVA = "0x9C30F80", Offset = "0x9C2FF80", VA = "0x189C30F80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9C30EC0", Offset = "0x9C2FEC0", VA = "0x189C30EC0", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9C2F800", Offset = "0x9C2E800", VA = "0x189C2F800")]
		private static (Vector2[], ushort[], Vector2[]) AKMBIPDPLMD(SpriteRenderer LBNDIMGOFLA, Sprite HMILKDLMBAG)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9C30DC0", Offset = "0x9C2FDC0", VA = "0x189C30DC0")]
		[CompilerGenerated]
		internal static Vector2 IMHGEMMBNDB(float NCHBCHELMBE, float OIELDKFCJMF, ICKGJEJMAJI P_2)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9C30CC0", Offset = "0x9C2FCC0", VA = "0x189C30CC0")]
		[CompilerGenerated]
		internal static void APPPNBMGLHD(ushort JDINPJIAKOC, ushort LDPKBPICKKH, ushort JKODNDABGFB, ushort ONHOGPDMCCD, ICKGJEJMAJI P_4)
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
			[Cpp2IlInjected.Address(RVA = "0x9C31030", Offset = "0x9C30030", VA = "0x189C31030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9C31000", Offset = "0x9C30000", VA = "0x189C31000", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C30FB0", Offset = "0x9C2FFB0", VA = "0x189C30FB0", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public TextMeshGameObjectExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FHNIBLKHOEC : GMHJHFOKIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<Texture, RenderTexture> OPHACJPFMPF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9C2BF60", Offset = "0x9C2AF60", VA = "0x189C2BF60", Slot = "5")]
	public override void OOPHHNDAEGJ(EEJGCGOJGCD CIABMLDDFBB, CNIIHPEFGGP GHINBINAHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9C2BEC0", Offset = "0x9C2AEC0", VA = "0x189C2BEC0", Slot = "7")]
	public override void IPECIJEIOIO(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9C2B950", Offset = "0x9C2A950", VA = "0x189C2B950", Slot = "9")]
	public override bool GCMNDLLJCDH(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Material JNBIMACAHOC, HLAGMJEKLKG MPDMBPBHNNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public FHNIBLKHOEC()
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
