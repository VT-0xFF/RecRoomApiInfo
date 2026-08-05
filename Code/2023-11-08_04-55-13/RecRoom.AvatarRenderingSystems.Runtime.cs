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
		private CKKJHPJHOFD? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LOMEGCIFLKN CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5D01260", Offset = "0x5D00060", VA = "0x185D01260")]
			get
			{
				return default(LOMEGCIFLKN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CKKJHPJHOFD MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5D012B0", Offset = "0x5D000B0", VA = "0x185D012B0")]
			get
			{
				return default(CKKJHPJHOFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x773BF0", Offset = "0x7729F0", VA = "0x180773BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x774640", Offset = "0x773440", VA = "0x180774640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D00EF0", Offset = "0x5CFFCF0", VA = "0x185D00EF0")]
		public Material[] FIKMMIDKFIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D00FD0", Offset = "0x5CFFDD0", VA = "0x185D00FD0")]
		public static void HKEFKEMKHNE(AvatarItemMaterial BDIEGGBGEEN, Material EACDLEEFOLG, int JBCBLFDELNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D01190", Offset = "0x5CFFF90", VA = "0x185D01190")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LBMBHNBHKGC : EEKGGBJDOPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private EMMNFOHBPKH GLMJPDOBNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JFPCIKCMMLH CGMIHPNDHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IRecRoomQualityConfigProvider OICOMLKIIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool HDKILIBHCML;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D01C60", Offset = "0x5D00A60", VA = "0x185D01C60")]
	[IBKPEPPEMNJ(MIBJABCBNEH.GameOnly)]
	private static void AGANDBGBFCP(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x50E28E0", Offset = "0x50E16E0", VA = "0x1850E28E0")]
	[Preserve]
	public LBMBHNBHKGC([HOHGLGKGFHE(null)] JFPCIKCMMLH NIPKPDDDOPA, [HOHGLGKGFHE(null)] EMMNFOHBPKH OKMMKKECBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D02300", Offset = "0x5D01100", VA = "0x185D02300")]
	private void LJMEJFFGPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D022A0", Offset = "0x5D010A0", VA = "0x185D022A0", Slot = "6")]
	public void DKGKAADMNAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D01D60", Offset = "0x5D00B60", VA = "0x185D01D60", Slot = "4")]
	public ENDMHFEHIBD<Texture2D> DBIPGAHIKII(DOBJGDENJNK PFDNHKGELAH, [Optional] IOADAEOGMCH CNCKHACNADC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D02370", Offset = "0x5D01170", VA = "0x185D02370")]
	private uint OECPAFJNNMO(DOBJGDENJNK PFDNHKGELAH, IOADAEOGMCH CNCKHACNADC)
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
		[EHGCIBCPLHN(CDIJBINDLCN.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x5D02520", Offset = "0x5D01320", VA = "0x185D02520")]
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
		private Dictionary<AEFJCPOEANN, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Dictionary<AEFJCPOEANN, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<AEFJCPOEANN, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Dictionary<AEFJCPOEANN, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Dictionary<AEFJCPOEANN, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5D01C30", Offset = "0x5D00A30", VA = "0x185D01C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D016D0", Offset = "0x5D004D0", VA = "0x185D016D0")]
		public KNGLKBABOIA JALMOHIHPDL(int AFPIPIFBBEP, int DNANGJHOIAP, int FOKADDPDKKL, int FDEIBHKOLJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D01900", Offset = "0x5D00700", VA = "0x185D01900")]
		public SelectableFaceOption JGCFAINCNJL(FaceFeatureType NGPGBDPAPJO, AEFJCPOEANN JFKDLJLLKLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D01370", Offset = "0x5D00170", VA = "0x185D01370")]
		public int BKOMEODOOFI(AEFJCPOEANN JFKDLJLLKLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D013F0", Offset = "0x5D001F0", VA = "0x185D013F0")]
		private void EFFGOEJOBMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x24EA4F0", Offset = "0x24E92F0", VA = "0x1824EA4F0")]
		private void BLJOHJGAKJA<T>(IDictionary<AEFJCPOEANN, T> OOCFAHFELIB, IReadOnlyList<T> EIADMHPHDAE) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D01620", Offset = "0x5D00420", VA = "0x185D01620")]
		public AEFJCPOEANN HKLBGGMNHLL(FaceFeatureType NGPGBDPAPJO)
		{
			return default(AEFJCPOEANN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D01A80", Offset = "0x5D00880", VA = "0x185D01A80")]
		public AEFJCPOEANN OJEBCDCIMOP(FaceFeatureType NGPGBDPAPJO)
		{
			return default(AEFJCPOEANN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D01BA0", Offset = "0x5D009A0", VA = "0x185D01BA0")]
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
