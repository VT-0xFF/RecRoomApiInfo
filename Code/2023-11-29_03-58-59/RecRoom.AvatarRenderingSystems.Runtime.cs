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
		private LGAEGBALGBB? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HLIMNJNLOEL CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5D259E0", Offset = "0x5D24DE0", VA = "0x185D259E0")]
			get
			{
				return default(HLIMNJNLOEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LGAEGBALGBB MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5D25A30", Offset = "0x5D24E30", VA = "0x185D25A30")]
			get
			{
				return default(LGAEGBALGBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7782C0", Offset = "0x7776C0", VA = "0x1807782C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x770C90", Offset = "0x770090", VA = "0x180770C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D25670", Offset = "0x5D24A70", VA = "0x185D25670")]
		public Material[] EGJKBEAMBDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D25750", Offset = "0x5D24B50", VA = "0x185D25750")]
		public static void KDBIICOHFCL(AvatarItemMaterial HGOBCKNOEKN, Material OLONCOMGJHB, int IBGPHNEKJPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D25910", Offset = "0x5D24D10", VA = "0x185D25910")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HJHDLDKGGLJ : NGAALPFCECF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private OMCKPMBHDPC HCAFMADAEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KCNCLKHIDOF AHHAANHPOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IRecRoomQualityConfigProvider MNJIJNGDFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool IIGADNOOENM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D263E0", Offset = "0x5D257E0", VA = "0x185D263E0")]
	[JMGGEKJCAGA(PLCOHLLKCIG.GameOnly)]
	private static void AMOLMJAIHKI(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5101610", Offset = "0x5100A10", VA = "0x185101610")]
	[Preserve]
	public HJHDLDKGGLJ([MJHHGJKKIMK(null)] KCNCLKHIDOF FEDOIONOOCG, [MJHHGJKKIMK(null)] OMCKPMBHDPC NIMNBFCIOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D26C30", Offset = "0x5D26030", VA = "0x185D26C30")]
	private void PFCFDINOIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D26BD0", Offset = "0x5D25FD0", VA = "0x185D26BD0", Slot = "6")]
	public void FHLABECMNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D264E0", Offset = "0x5D258E0", VA = "0x185D264E0", Slot = "4")]
	public OBCMOPCNEDJ<Texture2D> DHPCIFBONEK(CGCHKNIICFJ OBOJHHMGPGG, [Optional] EAFKCECIGKO NNBNMFFCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D26A20", Offset = "0x5D25E20", VA = "0x185D26A20")]
	private uint EKOKIJKGIMO(CGCHKNIICFJ OBOJHHMGPGG, EAFKCECIGKO NNBNMFFCBEB)
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
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x5D26CA0", Offset = "0x5D260A0", VA = "0x185D26CA0")]
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
		private Dictionary<EHPJADFBGFH, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Dictionary<EHPJADFBGFH, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<EHPJADFBGFH, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Dictionary<EHPJADFBGFH, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Dictionary<EHPJADFBGFH, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5D263B0", Offset = "0x5D257B0", VA = "0x185D263B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D260F0", Offset = "0x5D254F0", VA = "0x185D260F0")]
		public LCOHJFODCBF ONNFMCJCFFK(int GCCACLILBEP, int FKFLCLNOFEM, int PNDOKAEJJHM, int IMFKFAOHHGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D25C10", Offset = "0x5D25010", VA = "0x185D25C10")]
		public SelectableFaceOption JBALBMFPPAE(FaceFeatureType KDOIHHJFIDC, EHPJADFBGFH HEIEKMFHLMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D25D90", Offset = "0x5D25190", VA = "0x185D25D90")]
		public int MJCOFPLFICC(EHPJADFBGFH HEIEKMFHLMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D25EC0", Offset = "0x5D252C0", VA = "0x185D25EC0")]
		private void OGMGFFNEPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x25047A0", Offset = "0x2503BA0", VA = "0x1825047A0")]
		private void LNFEHGLJKKD<T>(IDictionary<EHPJADFBGFH, T> MJJMEPPKPMG, IReadOnlyList<T> FGJNHNFHOLE) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D25E10", Offset = "0x5D25210", VA = "0x185D25E10")]
		public EHPJADFBGFH MKLJEHLJAHC(FaceFeatureType KDOIHHJFIDC)
		{
			return default(EHPJADFBGFH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D25AF0", Offset = "0x5D24EF0", VA = "0x185D25AF0")]
		public EHPJADFBGFH AIBBPOOPIPE(FaceFeatureType KDOIHHJFIDC)
		{
			return default(EHPJADFBGFH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D26320", Offset = "0x5D25720", VA = "0x185D26320")]
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
