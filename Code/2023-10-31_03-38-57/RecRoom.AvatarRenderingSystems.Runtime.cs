using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.AssetIds;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private OOEEDDDFDMO? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public PONACHLFLJJ CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5B95910", Offset = "0x5B94D10", VA = "0x185B95910")]
			get
			{
				return default(PONACHLFLJJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OOEEDDDFDMO MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5B95960", Offset = "0x5B94D60", VA = "0x185B95960")]
			get
			{
				return default(OOEEDDDFDMO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x761D10", Offset = "0x761110", VA = "0x180761D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x75F220", Offset = "0x75E620", VA = "0x18075F220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5B955A0", Offset = "0x5B949A0", VA = "0x185B955A0")]
		public Material[] AGAJMLCPHPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5B95680", Offset = "0x5B94A80", VA = "0x185B95680")]
		public static void FBJEFKFEMLK(AvatarItemMaterial CJANIHCONEK, Material JGKNCBCEPPI, int IMFJMHOMBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5B95840", Offset = "0x5B94C40", VA = "0x185B95840")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MKOGAGAELFE : JCGKFAFFHEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JMMJEGMJEBG ILDJEIPCGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KJFCFMFKPOG BGGLPHCAMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IRecRoomQualityConfigProvider JLCHAKLFHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool KLPDEGOGACF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5B96A00", Offset = "0x5B95E00", VA = "0x185B96A00")]
	[JMHDKPKEECF(OPIGPDFNEON.GameOnly)]
	private static void GEANPNKJHMH(HLDKHDLHDPB KBPJCNHNBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FFE0", Offset = "0x4F7F3E0", VA = "0x184F7FFE0")]
	[Preserve]
	public MKOGAGAELFE([LOJAGCNCPBJ(null)] KJFCFMFKPOG LGCLJMFDPPO, [LOJAGCNCPBJ(null)] JMMJEGMJEBG EALEPKIELNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5B96B00", Offset = "0x5B95F00", VA = "0x185B96B00")]
	private void KNCLMDDAKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5B96B70", Offset = "0x5B95F70", VA = "0x185B96B70", Slot = "6")]
	public void LJLNDPPPLHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5B96310", Offset = "0x5B95710", VA = "0x185B96310", Slot = "4")]
	public EJOGLAHGLBK<Texture2D> EEBPKLDJMKO(MLIFKHMHACN CLJCHGMLLOF, [Optional] AHBFLDGMEIA ILKHBODBFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5B96850", Offset = "0x5B95C50", VA = "0x185B96850")]
	private uint FHKBKIDNLIA(MLIFKHMHACN CLJCHGMLLOF, AHBFLDGMEIA ILKHBODBFFI)
	{
		return default(uint);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[BCMNMDCFIOE(DGGKPPHNIIC.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5B96BD0", Offset = "0x5B95FD0", VA = "0x185B96BD0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Dictionary<NHKHEJJGMPN, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Dictionary<NHKHEJJGMPN, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<NHKHEJJGMPN, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Dictionary<NHKHEJJGMPN, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Dictionary<NHKHEJJGMPN, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5B962E0", Offset = "0x5B956E0", VA = "0x185B962E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5B95C50", Offset = "0x5B95050", VA = "0x185B95C50")]
		public DMHKLCPNFMM JOALHKNOLHL(int IFCIHGIGNPE, int DCKLHLJKBBH, int PCJHFFAMIBM, int JLFEKEFFDPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5B960D0", Offset = "0x5B954D0", VA = "0x185B960D0")]
		public SelectableFaceOption NDFFILOCCEF(FaceFeatureType OICEJICCAHH, NHKHEJJGMPN JNONOJGIJFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B95F30", Offset = "0x5B95330", VA = "0x185B95F30")]
		public int LPLJPIEEFBK(NHKHEJJGMPN JNONOJGIJFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B95A20", Offset = "0x5B94E20", VA = "0x185B95A20")]
		private void GOACHFEBEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x23745B0", Offset = "0x23739B0", VA = "0x1823745B0")]
		private void CBKOOMACAPI<T>(IDictionary<NHKHEJJGMPN, T> FBGCPGFLOPN, IReadOnlyList<T> MFMFMCPPDFF) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5B95E80", Offset = "0x5B95280", VA = "0x185B95E80")]
		public NHKHEJJGMPN JOFHHJNLOMJ(FaceFeatureType OICEJICCAHH)
		{
			return default(NHKHEJJGMPN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5B95FB0", Offset = "0x5B953B0", VA = "0x185B95FB0")]
		public NHKHEJJGMPN MBFKONBPMOM(FaceFeatureType OICEJICCAHH)
		{
			return default(NHKHEJJGMPN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5B96250", Offset = "0x5B95650", VA = "0x185B96250")]
		public FaceStyleSet()
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
