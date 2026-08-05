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
		private LKFKHDAJLCP? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EJKPOEEPIFD CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5D24550", Offset = "0x5D22D50", VA = "0x185D24550")]
			get
			{
				return default(EJKPOEEPIFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LKFKHDAJLCP MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5D245A0", Offset = "0x5D22DA0", VA = "0x185D245A0")]
			get
			{
				return default(LKFKHDAJLCP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x779F00", Offset = "0x778700", VA = "0x180779F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x777190", Offset = "0x775990", VA = "0x180777190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D243A0", Offset = "0x5D22BA0", VA = "0x185D243A0")]
		public Material[] JHJHIKBDCFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D241E0", Offset = "0x5D229E0", VA = "0x185D241E0")]
		public static void BKFAHHNKCHB(AvatarItemMaterial FFJFDNHLMIO, Material ECIAJACKHCB, int AAEJBMPGNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D24480", Offset = "0x5D22C80", VA = "0x185D24480")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KPGBOCJFNIM : ANLJALABHNP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private AMOINCJKGLG CFGEOJDNOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IBAHBKHCKNL JKJBKIEOGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IRecRoomQualityConfigProvider FKMCELLGGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool AOECLFLEBBA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D256A0", Offset = "0x5D23EA0", VA = "0x185D256A0")]
	[IOOPNJKFHOG(FICJCHGEBPC.GameOnly)]
	private static void GOBPJCGLIAD(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5100180", Offset = "0x50FE980", VA = "0x185100180")]
	[Preserve]
	public KPGBOCJFNIM([NBBCAEDCKMG(null)] IBAHBKHCKNL LODJFHDAFII, [NBBCAEDCKMG(null)] AMOINCJKGLG NBDHFFHLLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D257A0", Offset = "0x5D23FA0", VA = "0x185D257A0")]
	private void IFFNKCBMPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D25640", Offset = "0x5D23E40", VA = "0x185D25640", Slot = "6")]
	public void GNGPHDIEJJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D24F50", Offset = "0x5D23750", VA = "0x185D24F50", Slot = "4")]
	public LLCBDIPCFGG<Texture2D> CDJIFKPHLFF(KLOJHDHDIBD AGHALFDPGJE, [Optional] OHAAHIPDKEI ICGNFMFDOBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D25490", Offset = "0x5D23C90", VA = "0x185D25490")]
	private uint GMAKHOBPLNK(KLOJHDHDIBD AGHALFDPGJE, OHAAHIPDKEI ICGNFMFDOBD)
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
		[CMCMKAFNABN(JEAHCFCDLNC.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x5D25810", Offset = "0x5D24010", VA = "0x185D25810")]
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
		private Dictionary<CEPJMPEDIKN, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Dictionary<CEPJMPEDIKN, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<CEPJMPEDIKN, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Dictionary<CEPJMPEDIKN, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Dictionary<CEPJMPEDIKN, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5D24F20", Offset = "0x5D23720", VA = "0x185D24F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D24A90", Offset = "0x5D23290", VA = "0x185D24A90")]
		public IHHFLFOBFPM JBINOAKHLAC(int HLNOPPJGLJC, int CLJGLEIHJBE, int EBECJBNHJDP, int MCCDCLMLHBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D24910", Offset = "0x5D23110", VA = "0x185D24910")]
		public SelectableFaceOption IPDBKBKEBKI(FaceFeatureType AMCKEFIOOPJ, CEPJMPEDIKN FOLEBHLGIGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D24660", Offset = "0x5D22E60", VA = "0x185D24660")]
		public int FEABEGAPEDE(CEPJMPEDIKN FOLEBHLGIGE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D246E0", Offset = "0x5D22EE0", VA = "0x185D246E0")]
		private void GMILDNNLHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x24CC9E0", Offset = "0x24CB1E0", VA = "0x1824CC9E0")]
		private void FBFMEOBLOPB<T>(IDictionary<CEPJMPEDIKN, T> JJJHLPMHAAM, IReadOnlyList<T> ADFICKOFCJC) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D24CC0", Offset = "0x5D234C0", VA = "0x185D24CC0")]
		public CEPJMPEDIKN JOOBHAICAAF(FaceFeatureType AMCKEFIOOPJ)
		{
			return default(CEPJMPEDIKN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D24D70", Offset = "0x5D23570", VA = "0x185D24D70")]
		public CEPJMPEDIKN OMPBHINEDAC(FaceFeatureType AMCKEFIOOPJ)
		{
			return default(CEPJMPEDIKN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D24E90", Offset = "0x5D23690", VA = "0x185D24E90")]
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
