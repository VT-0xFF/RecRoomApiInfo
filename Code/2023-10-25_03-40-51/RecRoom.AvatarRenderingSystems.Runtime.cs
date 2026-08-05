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
		private JJOIDFMIAGG? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MIIMNMCJACG CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5B97470", Offset = "0x5B96270", VA = "0x185B97470")]
			get
			{
				return default(MIIMNMCJACG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JJOIDFMIAGG MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5B974C0", Offset = "0x5B962C0", VA = "0x185B974C0")]
			get
			{
				return default(JJOIDFMIAGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x768A70", Offset = "0x767870", VA = "0x180768A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766770", VA = "0x180767970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5B97100", Offset = "0x5B95F00", VA = "0x185B97100")]
		public Material[] CLBLBBLJJGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5B971E0", Offset = "0x5B95FE0", VA = "0x185B971E0")]
		public static void HMKHBLPOLKK(AvatarItemMaterial AOICLDOPKLL, Material PMPKGHHPFNJ, int INAFOJMIEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5B973A0", Offset = "0x5B961A0", VA = "0x185B973A0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HEGBJHBBPIE : DAEDDKOAICN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NNECFNGLCCF GNMGALACDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BHKFKNAMOCM FKOIGJMEAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IRecRoomQualityConfigProvider MNBNFNMKIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool MEPKFPKBJKM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5B97ED0", Offset = "0x5B96CD0", VA = "0x185B97ED0")]
	[DJDJPHIPNFL(IEJLPKKICHC.GameOnly)]
	private static void HACFLCEFAPO(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4F81B40", Offset = "0x4F80940", VA = "0x184F81B40")]
	[Preserve]
	public HEGBJHBBPIE([FGPOJKOJBFM(null)] BHKFKNAMOCM KFFNLEPPBKL, [FGPOJKOJBFM(null)] NNECFNGLCCF EMEAGAPJFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5B97FD0", Offset = "0x5B96DD0", VA = "0x185B97FD0")]
	private void HIEFMGDPOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5B97E70", Offset = "0x5B96C70", VA = "0x185B97E70", Slot = "6")]
	public void FIFMEHGMKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5B981F0", Offset = "0x5B96FF0", VA = "0x185B981F0", Slot = "4")]
	public FBMLADGOGPH<Texture2D> PJKKIHDPDKN(MFHFGENFHMN CMFLGCPBEIL, [Optional] EMAGFDLNOKO APKDPMMLKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5B98040", Offset = "0x5B96E40", VA = "0x185B98040")]
	private uint KOJMHEGFPGL(MFHFGENFHMN CMFLGCPBEIL, EMAGFDLNOKO APKDPMMLKGB)
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
		[DBHJNHHAHKH(PBHAFHEAPLG.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x5B98730", Offset = "0x5B97530", VA = "0x185B98730")]
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
		private Dictionary<IGJNIAODAPD, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Dictionary<IGJNIAODAPD, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<IGJNIAODAPD, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Dictionary<IGJNIAODAPD, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Dictionary<IGJNIAODAPD, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5B97E40", Offset = "0x5B96C40", VA = "0x185B97E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5B97580", Offset = "0x5B96380", VA = "0x185B97580")]
		public HBJBPLHAOEF BPNHBNDHKNN(int CHGGDINBBNO, int KDCHLMHNHAI, int AIHHLPMEFPK, int LKHAOMIIBBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5B97BB0", Offset = "0x5B969B0", VA = "0x185B97BB0")]
		public SelectableFaceOption MDHCNLIHBJE(FaceFeatureType MLPKPMHCMLM, IGJNIAODAPD AFHFHDECDMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B97D30", Offset = "0x5B96B30", VA = "0x185B97D30")]
		public int OCHJKJCNOAE(IGJNIAODAPD AFHFHDECDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B978D0", Offset = "0x5B966D0", VA = "0x185B978D0")]
		private void HJJDHHOJJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2395680", Offset = "0x2394480", VA = "0x182395680")]
		private void FFJMPJDKGOO<T>(IDictionary<IGJNIAODAPD, T> EKLELFILNFP, IReadOnlyList<T> DBKKAHAGOFL) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5B97B00", Offset = "0x5B96900", VA = "0x185B97B00")]
		public IGJNIAODAPD JLOCHOHFLNA(FaceFeatureType MLPKPMHCMLM)
		{
			return default(IGJNIAODAPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5B977B0", Offset = "0x5B965B0", VA = "0x185B977B0")]
		public IGJNIAODAPD CJBCAFICFNE(FaceFeatureType MLPKPMHCMLM)
		{
			return default(IGJNIAODAPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5B97DB0", Offset = "0x5B96BB0", VA = "0x185B97DB0")]
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
