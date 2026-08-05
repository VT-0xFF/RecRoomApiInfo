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
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public TempAssignClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BINOHMBHGFE(null)]
	public class AudioExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E330", Offset = "0x9B4D130", VA = "0x189B4E330", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E300", Offset = "0x9B4D100", VA = "0x189B4E300", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E2A0", Offset = "0x9B4D0A0", VA = "0x189B4E2A0", Slot = "14")]
		public override OFHNLAEIMPB AAIDNCCKOCM(HILGAGFEFMF IEOOLFDDEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public AudioExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[BINOHMBHGFE(null)]
	public class AudioImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E500", Offset = "0x9B4D300", VA = "0x189B4E500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E4D0", Offset = "0x9B4D2D0", VA = "0x189B4E4D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E360", Offset = "0x9B4D160", VA = "0x189B4E360", Slot = "13")]
		public override LFPALPGIBAE AAIDNCCKOCM(ENFJKJENLLC IEOOLFDDEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public AudioImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FFGHJAEALFA : LFPALPGIBAE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class AMEABJLLBCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AudioSource ILCNJFHLEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AudioDataId FGLDELAOGLO;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA639A0", Offset = "0xA627A0", VA = "0x180A639A0")]
		public AMEABJLLBCK(AudioSource ILCNJFHLEMI, AudioDataId COAKMJBCPKE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ENFJKJENLLC GKGINDPIHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KHR_audio_emitter FOJDGMPKFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private List<AMEABJLLBCK> EKLBMEIHOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<int, AudioClip> IOAEFBFOCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Dictionary<int, string> CNHGDNADCJL;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9B50C40", Offset = "0x9B4FA40", VA = "0x189B50C40")]
	public FFGHJAEALFA(ENFJKJENLLC IEOOLFDDEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9B4F820", Offset = "0x9B4E620", VA = "0x189B4F820")]
	private void BOHLOALNDDJ(CBKMJCPMMJF EGPDFGOHLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9B4F820", Offset = "0x9B4E620", VA = "0x189B4F820", Slot = "6")]
	public override void HBHIAMHJBCG(CBKMJCPMMJF KCBCHJKCOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9B505D0", Offset = "0x9B4F3D0", VA = "0x189B505D0")]
	private void ILNMDKHBCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9B4F9A0", Offset = "0x9B4E7A0", VA = "0x189B4F9A0")]
	private string CAEGOKJLPAE(string LOFMPHHFPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9B504D0", Offset = "0x9B4F2D0", VA = "0x189B504D0")]
	private AudioType HLOEHHKJNMB(string LOFMPHHFPDG)
	{
		return default(AudioType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9B4FEF0", Offset = "0x9B4ECF0", VA = "0x189B4FEF0")]
	private void GPBMNDAMHKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9B4FAC0", Offset = "0x9B4E8C0", VA = "0x189B4FAC0")]
	private void DFMFNIGFHEK(GameObject GFLBPAOCEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9B50880", Offset = "0x9B4F680", VA = "0x189B50880")]
	private void PBPPJKAHIOA(KHR_AudioEmitter PEAFCHFNBOO, GameObject PBJHKCLLDEP, bool BKKEOKADOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9B50840", Offset = "0x9B4F640", VA = "0x189B50840", Slot = "11")]
	public override void NGDDBPCPODO(KIKJFNGFKIM DHLFBBHICBC, int AKCNICEMINJ, GameObject GFLBPAOCEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9B4FD60", Offset = "0x9B4EB60", VA = "0x189B4FD60", Slot = "8")]
	public override void EONLPLOCGGI(IAACNMOKGJE FNINGPDJHMC, int GALEFDCCLEM, GameObject OJPBNPPAOEJ)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CINHALFNLEH(null)]
	public class BakeParticleSystem : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F030", Offset = "0x9B4DE30", VA = "0x189B4F030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F000", Offset = "0x9B4DE00", VA = "0x189B4F000", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B4EEF0", Offset = "0x9B4DCF0", VA = "0x189B4EEF0", Slot = "14")]
		public override OFHNLAEIMPB AAIDNCCKOCM(HILGAGFEFMF IEOOLFDDEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public BakeParticleSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PINGIDECODI : OFHNLAEIMPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> JLPBPBNOLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<UnityEngine.Object> FNMDCHFLFNM;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x9B53C60", Offset = "0x9B52A60", VA = "0x189B53C60", Slot = "7")]
	public override void DMDHIMFCMLH(CCAEOCLCFCI HDJKNFPCLJL, CBKMJCPMMJF KCBCHJKCOAC, Transform OLPMPAIMKPI, IAACNMOKGJE FNINGPDJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9B53960", Offset = "0x9B52760", VA = "0x189B53960", Slot = "5")]
	public override void AMMNOPBNIMH(CCAEOCLCFCI HDJKNFPCLJL, CBKMJCPMMJF KCBCHJKCOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9B53EC0", Offset = "0x9B52CC0", VA = "0x189B53EC0")]
	private static void MPOAFHMNNDO(UnityEngine.Object AGFBLLPJMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9B53F60", Offset = "0x9B52D60", VA = "0x189B53F60")]
	public PINGIDECODI()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CINHALFNLEH(null)]
	public class CanvasExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F7F0", Offset = "0x9B4E5F0", VA = "0x189B4F7F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9B4F7C0", Offset = "0x9B4E5C0", VA = "0x189B4F7C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F770", Offset = "0x9B4E570", VA = "0x189B4F770", Slot = "14")]
		public override OFHNLAEIMPB AAIDNCCKOCM(HILGAGFEFMF IEOOLFDDEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public CanvasExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GOGKOFPLIME : OFHNLAEIMPB
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static Shader CBHLBLEKIGL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9B50E70", Offset = "0x9B4FC70", VA = "0x189B50E70", Slot = "8")]
	public override void DNBDICFOCML(CCAEOCLCFCI HDJKNFPCLJL, CBKMJCPMMJF EGPDFGOHLFM, Transform OLPMPAIMKPI, IAACNMOKGJE FNINGPDJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public GOGKOFPLIME()
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
		private Mesh JLPONKINLEO;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		public void ModifyMesh(Mesh JLPONKINLEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F690", Offset = "0x9B4E490", VA = "0x189B4F690", Slot = "5")]
		public void ModifyMesh(VertexHelper MNCLBNBEOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F260", Offset = "0x9B4E060", VA = "0x189B4F260")]
		public bool GetMeshAndMaterial([Out] Mesh JLPONKINLEO, [Out] Material KKBOKCGIENM, Shader CBHLBLEKIGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9B4F060", Offset = "0x9B4DE60", VA = "0x189B4F060")]
		public void CaptureTo(Transform EGPDFGOHLFM, GameObject ALIJLONOBKO, Shader CBHLBLEKIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public MaterialVariants()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CINHALFNLEH(null)]
	public class MaterialVariantsPlugin : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9B531B0", Offset = "0x9B51FB0", VA = "0x189B531B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9B53180", Offset = "0x9B51F80", VA = "0x189B53180", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B53130", Offset = "0x9B51F30", VA = "0x189B53130", Slot = "14")]
		public override OFHNLAEIMPB AAIDNCCKOCM(HILGAGFEFMF IEOOLFDDEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public MaterialVariantsPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class INNEHPGFOOF : OFHNLAEIMPB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BBEPNCOPNDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Transform node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BBEPNCOPNDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9B4E530", Offset = "0x9B4D330", VA = "0x189B4E530")]
		internal bool OJEBGFBDGLE(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FKPNPBCPFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int subMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Material exportMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BBEPNCOPNDP CS$<>8__locals1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Func<MaterialVariants.Variant.MaterialSet, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FKPNPBCPFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9B50D80", Offset = "0x9B4FB80", VA = "0x189B50D80")]
		internal bool ILJJHEEJKNJ(MaterialVariants.Variant.MaterialSet x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x9B51530", Offset = "0x9B50330", VA = "0x189B51530", Slot = "5")]
	public override void AMMNOPBNIMH(CCAEOCLCFCI HDJKNFPCLJL, CBKMJCPMMJF AGOJEDPEBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public INNEHPGFOOF()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KHR_materials_variants_root : FFFEBHOLBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string[] variantNames;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B52E90", Offset = "0x9B51C90", VA = "0x189B52E90", Slot = "4")]
		public JProperty NEJFHFKCOKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B52E20", Offset = "0x9B51C20", VA = "0x189B52E20", Slot = "5")]
		public FFFEBHOLBPB AJBMEKOGIKE(CBKMJCPMMJF EGPDFGOHLFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KHR_materials_variants_root()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KHR_materials_variants : FFFEBHOLBPB
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
			[Cpp2IlInjected.Address(RVA = "0x9B530B0", Offset = "0x9B51EB0", VA = "0x189B530B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public MappingVariant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CCAEOCLCFCI exporter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<MappingVariant> mappings;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9B52D80", Offset = "0x9B51B80", VA = "0x189B52D80")]
		public KHR_materials_variants(CCAEOCLCFCI HDJKNFPCLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B52C00", Offset = "0x9B51A00", VA = "0x189B52C00", Slot = "4")]
		public JProperty NEJFHFKCOKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9B52880", Offset = "0x9B51680", VA = "0x189B52880", Slot = "5")]
		public FFFEBHOLBPB AJBMEKOGIKE(CBKMJCPMMJF EGPDFGOHLFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9B52A10", Offset = "0x9B51810", VA = "0x189B52A10")]
		[CompilerGenerated]
		private JObject IHOFDMBMOHB(MappingVariant DHOMBGCEEAK)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class SpriteRendererExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class BPKCGGIKMPD : OFHNLAEIMPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GameObject> AEEAIPCOCBJ;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E740", Offset = "0x9B4D540", VA = "0x189B4E740", Slot = "7")]
			public override void DMDHIMFCMLH(CCAEOCLCFCI HDJKNFPCLJL, CBKMJCPMMJF KCBCHJKCOAC, Transform OLPMPAIMKPI, IAACNMOKGJE FNINGPDJHMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E5A0", Offset = "0x9B4D3A0", VA = "0x189B4E5A0", Slot = "5")]
			public override void AMMNOPBNIMH(CCAEOCLCFCI HDJKNFPCLJL, CBKMJCPMMJF KCBCHJKCOAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9B4EE60", Offset = "0x9B4DC60", VA = "0x189B4EE60")]
			public BPKCGGIKMPD()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct HGNHDBKLLPG
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
			[Cpp2IlInjected.Address(RVA = "0x9B557B0", Offset = "0x9B545B0", VA = "0x189B557B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B54030", Offset = "0x9B52E30", VA = "0x189B54030", Slot = "14")]
		public override OFHNLAEIMPB AAIDNCCKOCM(HILGAGFEFMF IEOOLFDDEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B542F0", Offset = "0x9B530F0", VA = "0x189B542F0")]
		private static (Vector2[], ushort[], Vector2[]) GPJCJLHJJMD(SpriteRenderer MIFBMDMJHAH, Sprite LEDFMOKNNEN)
		{
			return default((Vector2[], ushort[], Vector2[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public SpriteRendererExport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9B541F0", Offset = "0x9B52FF0", VA = "0x189B541F0")]
		[CompilerGenerated]
		internal static Vector2 GDMEBKAHAHE(float JPMLBGFJDDL, float EADELPLCAJF, HGNHDBKLLPG P_2)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9B540F0", Offset = "0x9B52EF0", VA = "0x189B540F0")]
		[CompilerGenerated]
		internal static void FGPBKLILAND(ushort LKPLCEODICL, ushort MANCHAKPLNN, ushort BEIDDJJHBIM, ushort EMDDNMINEBB, HGNHDBKLLPG P_4)
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
			[Cpp2IlInjected.Address(RVA = "0x9B55860", Offset = "0x9B54660", VA = "0x189B55860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9B55830", Offset = "0x9B54630", VA = "0x189B55830", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9B557E0", Offset = "0x9B545E0", VA = "0x189B557E0", Slot = "14")]
		public override OFHNLAEIMPB AAIDNCCKOCM(HILGAGFEFMF IEOOLFDDEEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public TextMeshGameObjectExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OLIPPJKPMOH : OFHNLAEIMPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<Texture, RenderTexture> HENIKMFNCFI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9B531E0", Offset = "0x9B51FE0", VA = "0x189B531E0", Slot = "5")]
	public override void AMMNOPBNIMH(CCAEOCLCFCI FCNMCCJKGMG, CBKMJCPMMJF DPGONNKCNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9B53350", Offset = "0x9B52150", VA = "0x189B53350", Slot = "7")]
	public override void DMDHIMFCMLH(CCAEOCLCFCI HDJKNFPCLJL, CBKMJCPMMJF KCBCHJKCOAC, Transform OLPMPAIMKPI, IAACNMOKGJE FNINGPDJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9B533F0", Offset = "0x9B521F0", VA = "0x189B533F0", Slot = "9")]
	public override bool ODDLEDFJNAL(CCAEOCLCFCI HDJKNFPCLJL, CBKMJCPMMJF KCBCHJKCOAC, Material KKBOKCGIENM, NDPKMIIHMLI AGJFAGMCNPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public OLIPPJKPMOH()
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
