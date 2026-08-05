using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh.Core;
using RecRoom.FastMesh.Rendering;
using RecRoom.FastText;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LFJCIKGDCJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D MGPEGBODKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig CEPIBKODLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MOHKFDBLNMJ[] DCIDNMLJLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public MOHKFDBLNMJ AEJGCMNBJDP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static LFJCIKGDCJH IAOGFPCDBBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LFJCIKGDCJH BBKKDKAMLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84EAF50", Offset = "0x84E9950", VA = "0x1884EAF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LFJCIKGDCJH()
	{
	}
}
namespace RecRoom.FastText
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct GlyphUVConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int TexturePixelWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int TexturePixelHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int GlyphCountHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int GlyphCountVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public GlyphPixelInset GlyphPixelInset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public float GlyphPixelKerning;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly GlyphUVConfig DefaultUVConfig;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84E9FB0", Offset = "0x84E89B0", VA = "0x1884E9FB0")]
		public GlyphUVConfig(int ALNABHDCJPG, int LJJDKKJHKBF, int DCNLCIBDANG, int EMGCALCJNJL, float EKCLPMJJDDG = 0f, [Optional] GlyphPixelInset LOOLBCPAIDA)
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct GlyphPixelInset
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const int BYTE_SIZE = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Min(0f)]
		public float Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Min(0f)]
		public float Right;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public floatMinMax X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Min(0f)]
		public float Bottom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Min(0f)]
		public float Top;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public floatMinMax Y;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct MOHKFDBLNMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char MDJCEKEDGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int IMPCCHFNMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int HHPLMGAMHBD;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly MOHKFDBLNMJ MDPBBFJGGGC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84EB150", Offset = "0x84E9B50", VA = "0x1884EB150")]
	public MOHKFDBLNMJ(char GEJFGBAPDDJ, int IBDKGJCNMEA, int NBIHBCLLPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84EB130", Offset = "0x84E9B30", VA = "0x1884EB130")]
	public MOHKFDBLNMJ(GlyphCoordinateWritable ILODLOOEGNE)
	{
	}
}
namespace RecRoom.FastText
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct GlyphCoordinateWritable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public char Glyph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int Col;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int Row;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84E95C0", Offset = "0x84E7FC0", VA = "0x1884E95C0")]
		public static MOHKFDBLNMJ HDPJNBPLGPE(GlyphCoordinateWritable DMCCCPMAFCP)
		{
			return default(MOHKFDBLNMJ);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CreateAssetMenu(menuName = "RecRoom/Config/New GlyphMapAsset", fileName = "GlyphMap", order = 0)]
	public class GlyphMapAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public const string FallbackMaterialShaderPath = "UI/Unlit/Text";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private Texture2D glyphTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private Shader shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Material _glyphMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[FormerlySerializedAs("glyphColCount")]
		[Space]
		[FormerlySerializedAs("glyphCols")]
		[Min(1f)]
		[SerializeField]
		private int glyphCountHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[FormerlySerializedAs("glyphRows")]
		[FormerlySerializedAs("glyphRowCount")]
		[Min(1f)]
		[SerializeField]
		private int glyphCountVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Space]
		[SerializeField]
		private GlyphPixelInset glyphPixelInset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private float glyphPixelKerning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Space]
		private char fallbackGlyph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[HideInInspector]
		private List<GlyphCoordinateWritable> glyphCoordinates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool isConfigDirty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private LFJCIKGDCJH configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84E9EB0", Offset = "0x84E88B0", VA = "0x1884E9EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84E9D30", Offset = "0x84E8730", VA = "0x1884E9D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84E9D20", Offset = "0x84E8720", VA = "0x1884E9D20")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LFJCIKGDCJH ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84E9710", Offset = "0x84E8110", VA = "0x1884E9710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private MOHKFDBLNMJ FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x84E9B90", Offset = "0x84E8590", VA = "0x1884E9B90")]
			get
			{
				return default(MOHKFDBLNMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84E9600", Offset = "0x84E8000", VA = "0x1884E9600")]
		internal void EBDAONKCKPB(IEnumerable<GlyphCoordinateWritable> PAEALKHECEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84E9680", Offset = "0x84E8080", VA = "0x1884E9680")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84E95E0", Offset = "0x84E7FE0", VA = "0x1884E95E0")]
		[CompilerGenerated]
		private bool AAFLHKAPPEM(GlyphCoordinateWritable DMCCCPMAFCP)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(TextSegmentMeshBufferSource))]
	public class SimpleTextSegmentSource : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TextSegmentMeshBufferSource DOADBIHKDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private FOKNLELMPFM NHPDHAGDAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[FormerlySerializedAs("SpanText")]
		public string SegmentText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[FormerlySerializedAs("SpanFontSize")]
		public float SegmentFontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[FormerlySerializedAs("SpanColor")]
		public Color32 SegmentColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[FormerlySerializedAs("SpanAnchor")]
		public float2 SegmentAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private JOOIOJDCINJ EFPAJJJHMFO;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84EC4E0", Offset = "0x84EAEE0", VA = "0x1884EC4E0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84EC490", Offset = "0x84EAE90", VA = "0x1884EC490")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84EC5D0", Offset = "0x84EAFD0", VA = "0x1884EC5D0")]
		private void PDMIKBIGKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84EC7B0", Offset = "0x84EB1B0", VA = "0x1884EC7B0")]
		public SimpleTextSegmentSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	public sealed class TextSegmentMeshBufferSource : MeshBufferSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool NKMILFGBOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material FONEFFHGDDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private FOKNLELMPFM NHPDHAGDAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material CLMILNNNOHE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private LFJCIKGDCJH IIDNACGLFGK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x84ED180", Offset = "0x84EBB80", VA = "0x1884ED180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FOKNLELMPFM BEAKMHBALEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x84ED2B0", Offset = "0x84EBCB0", VA = "0x1884ED2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material IPIKNPAKHON
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84ED2E0", Offset = "0x84EBCE0", VA = "0x1884ED2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84ED210", Offset = "0x84EBC10", VA = "0x1884ED210")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84ECB30", Offset = "0x84EB530", VA = "0x1884ECB30", Slot = "8")]
		protected override void CHIILNHAENG(KFMKKALMJIJ JIECEBCFPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84ED220", Offset = "0x84EBC20", VA = "0x1884ED220", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MEILAFLEOMG GIJPEHBAJAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84ED030", Offset = "0x84EBA30", VA = "0x1884ED030")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84ECD10", Offset = "0x84EB710", VA = "0x1884ECD10")]
		private void NGMBAAGABHA(bool KEJIJALNLAM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAC9DF0", Offset = "0xAC87F0", VA = "0x180AC9DF0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct JFIONBLOKBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly FOKNLELMPFM MCEMGCMOFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int DOKAMKIICEP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84E9FE0", Offset = "0x84E89E0", VA = "0x1884E9FE0")]
	internal MCPGGFAINDN OIMHMCDLMFM()
	{
		return default(MCPGGFAINDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B43B80", Offset = "0x2B42580", VA = "0x182B43B80")]
	internal JFIONBLOKBJ(FOKNLELMPFM KFMMGFEJHFC, int JDJBOIILFGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GJIIIHEFNKA
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84E9510", Offset = "0x84E7F10", VA = "0x1884E9510")]
	public static bool BNENEBAJLAF(this JFIONBLOKBJ ILFKKOOOMDI, GGBBJBJJEON MFIKPIOBDKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84E9560", Offset = "0x84E7F60", VA = "0x1884E9560")]
	internal static bool BNENEBAJLAF(this MCPGGFAINDN INDFLCBKDAB, GGBBJBJJEON MFIKPIOBDKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84E9580", Offset = "0x84E7F80", VA = "0x1884E9580")]
	public static float MBDOLHKMKEN(this JFIONBLOKBJ ILFKKOOOMDI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xB059A0", Offset = "0xB043A0", VA = "0x180B059A0")]
	internal static float MBDOLHKMKEN(this MCPGGFAINDN INDFLCBKDAB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PMBLFILGHEN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84EC1C0", Offset = "0x84EABC0", VA = "0x1884EC1C0")]
	public static void GGFJPAKINJG(this JFIONBLOKBJ ILFKKOOOMDI, ReadOnlySpan<char> NJIICAPCDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84EBFC0", Offset = "0x84EA9C0", VA = "0x1884EBFC0")]
	internal static void GGFJPAKINJG(this MCPGGFAINDN INDFLCBKDAB, ReadOnlySpan<char> NJIICAPCDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84EC280", Offset = "0x84EAC80", VA = "0x1884EC280")]
	public static void IIAMNAMDBPE(this JFIONBLOKBJ IIJFGOMJIEF, float2 JAEBKJINIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84EC2D0", Offset = "0x84EACD0", VA = "0x1884EC2D0")]
	internal static void IIAMNAMDBPE(this MCPGGFAINDN INDFLCBKDAB, float2 JAEBKJINIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84EC350", Offset = "0x84EAD50", VA = "0x1884EC350")]
	public static void PIHKMDCBHPH(this JFIONBLOKBJ IIJFGOMJIEF, float AABNGCCAIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84EC3C0", Offset = "0x84EADC0", VA = "0x1884EC3C0")]
	internal static void PIHKMDCBHPH(this MCPGGFAINDN INDFLCBKDAB, float AABNGCCAIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84EBFB0", Offset = "0x84EA9B0", VA = "0x1884EBFB0")]
	internal static void DPEKMFFCIAA(this MCPGGFAINDN INDFLCBKDAB, bool POEMFDKMAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84EBF60", Offset = "0x84EA960", VA = "0x1884EBF60")]
	public static void BAEOBNAPOHN(this JFIONBLOKBJ IIJFGOMJIEF, Color32 EOGEFFOIIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84EBFA0", Offset = "0x84EA9A0", VA = "0x1884EBFA0")]
	internal static void BAEOBNAPOHN(this MCPGGFAINDN INDFLCBKDAB, Color32 EOGEFFOIIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84EC300", Offset = "0x84EAD00", VA = "0x1884EC300")]
	public static void MOOHOHHENLH(this JFIONBLOKBJ IIJFGOMJIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84EC340", Offset = "0x84EAD40", VA = "0x1884EC340")]
	internal static void MOOHOHHENLH(this MCPGGFAINDN INDFLCBKDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84EC210", Offset = "0x84EAC10", VA = "0x1884EC210")]
	internal static void HLEFPAIMFKF(this MCPGGFAINDN INDFLCBKDAB, int KBPKPIJJPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84EC2E0", Offset = "0x84EACE0", VA = "0x1884EC2E0")]
	internal static void JAMEOJBKHHA(this MCPGGFAINDN INDFLCBKDAB, int NBIBAHMILIF, GGBBJBJJEON AIBBPPGLIJK = GGBBJBJJEON.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class JOOIOJDCINJ : IEquatable<JOOIOJDCINJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort MKOMMKHKLLG = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int DGLMFCKLCHC = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly JOOIOJDCINJ JJKDEHKDBNC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort ANKPAAJCICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xDEF0B0", Offset = "0xDEDAB0", VA = "0x180DEF0B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xDEF0C0", Offset = "0xDEDAC0", VA = "0x180DEF0C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FOKNLELMPFM MCEMGCMOFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OEBGFPNJFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84E0E10", Offset = "0x84DF810", VA = "0x1884E0E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84E0EB0", Offset = "0x84DF8B0", VA = "0x1884E0EB0")]
	public JOOIOJDCINJ(int PMNBILOCDGO, FOKNLELMPFM KFMMGFEJHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84EA1A0", Offset = "0x84E8BA0", VA = "0x1884EA1A0")]
	public bool NKAKCNHLKDF([Out] JFIONBLOKBJ ILFKKOOOMDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84EA150", Offset = "0x84E8B50", VA = "0x1884EA150")]
	public void KKMANOPBDMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84E0D90", Offset = "0x84DF790", VA = "0x1884E0D90")]
	internal void HHCLEGPGGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84E0C00", Offset = "0x84DF600", VA = "0x1884E0C00", Slot = "4")]
	public bool Equals(JOOIOJDCINJ GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84EA020", Offset = "0x84E8A20", VA = "0x1884EA020", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84EA0E0", Offset = "0x84E8AE0", VA = "0x1884EA0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class FOKNLELMPFM : IDisposable, CCHPBIFENPO
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string EJKJFOENMGD = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker GJHAGFIHPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string KGHHGPDHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly CDOBNKKMHDN CBOIHOPEAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int ACDGKMPCLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal MCPGGFAINDN[] ILMDNKLPCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal JOOIOJDCINJ[] EKCJMCGPLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private LFJCIKGDCJH JJIDFGJLKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KFMNKNCJAIA MNIIMBHFLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly NIGLHGBHECK EFGHCNIKIOH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string IELIBBNCJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84E8030", Offset = "0x84E6A30", VA = "0x1884E8030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LFJCIKGDCJH BBPODODEIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84E8760", Offset = "0x84E7160", VA = "0x1884E8760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float NDOLKPHMDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84E8780", Offset = "0x84E7180", VA = "0x1884E8780")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float HKDPJGAJOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84E8740", Offset = "0x84E7140", VA = "0x1884E8740")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CCHPBIFENPO.FHOHKJAGHHK FIHBJFMPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAB4820", Offset = "0xAB3220", VA = "0x180AB4820", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84E90D0", Offset = "0x84E7AD0", VA = "0x1884E90D0")]
	public FOKNLELMPFM(CDOBNKKMHDN OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84E9050", Offset = "0x84E7A50", VA = "0x1884E9050")]
	public FOKNLELMPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84E87A0", Offset = "0x84E71A0", VA = "0x1884E87A0")]
	public void LHEJPJMHOBO(GlyphMapAsset LMIMPHKGCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84E87E0", Offset = "0x84E71E0", VA = "0x1884E87E0")]
	public void LHEJPJMHOBO(LFJCIKGDCJH IALHFPFINMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84E8DB0", Offset = "0x84E77B0", VA = "0x1884E8DB0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] MEILAFLEOMG GIJPEHBAJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84E7CC0", Offset = "0x84E66C0", VA = "0x1884E7CC0")]
	public void AMDNOOPCBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x84E8D60", Offset = "0x84E7760", VA = "0x1884E8D60")]
	public bool OLPBHHDLPPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84E84D0", Offset = "0x84E6ED0", VA = "0x1884E84D0")]
	public JOOIOJDCINJ IBCLDFFPOOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84E8170", Offset = "0x84E6B70", VA = "0x1884E8170")]
	public void FEKALINNMEG(JOOIOJDCINJ KJMKDICAKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84E88F0", Offset = "0x84E72F0", VA = "0x1884E88F0")]
	internal bool MCMPFHJJALL(JOOIOJDCINJ KJMKDICAKPB, [Out] JFIONBLOKBJ ILFKKOOOMDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84E89A0", Offset = "0x84E73A0", VA = "0x1884E89A0")]
	private void NDBDMPJOCHH(MCPGGFAINDN INDFLCBKDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84E8B80", Offset = "0x84E7580", VA = "0x1884E8B80")]
	private void NNBFNCLNKAJ(int HPJIOOFLMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84E8B20", Offset = "0x84E7520", VA = "0x1884E8B20")]
	private bool NHBLBJDGKFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84E4810", Offset = "0x84E3210", VA = "0x1884E4810")]
	private static int EAAFGPELEHI(JOOIOJDCINJ KJMKDICAKPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2598AC0", Offset = "0x25974C0", VA = "0x182598AC0")]
	private static ushort IFKKPJKGMNE(int KABGMIEBEFC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84E7D20", Offset = "0x84E6720", VA = "0x1884E7D20")]
	private Bounds BKLLKNHIGLB()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x84E80C0", Offset = "0x84E6AC0", VA = "0x1884E80C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CDOBNKKMHDN
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly CDOBNKKMHDN JKGKDMCJJDO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float KBFOANMNJKJ = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int CCLJEFBJJJF = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int MCCMPKLFLBH = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color ANLHJMBCJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float ONFJGFKKANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int NBLHMDMCKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int PEFHDGCJJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int DJEIPHPDJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int ABPHOLLFMCN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84E7910", Offset = "0x84E6310", VA = "0x1884E7910")]
	internal CDOBNKKMHDN BPLNPLHPMKA()
	{
		return default(CDOBNKKMHDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84E0AD0", Offset = "0x84DF4D0", VA = "0x1884E0AD0")]
	[CompilerGenerated]
	internal static void LBAMANJMLHF(int KMAFNKGMDCF, int KJMOBDOKFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84E7A40", Offset = "0x84E6440", VA = "0x1884E7A40")]
	[CompilerGenerated]
	internal static void MFKKGGPPDMF(float KMAFNKGMDCF, float KJMOBDOKFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84E0AC0", Offset = "0x84DF4C0", VA = "0x1884E0AC0")]
	[CompilerGenerated]
	internal static void AAAJGEFGJAE(int KMAFNKGMDCF, int JGIELNGMIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84E7A20", Offset = "0x84E6420", VA = "0x1884E7A20")]
	[CompilerGenerated]
	internal static void EEKEHKMNNDD(float KMAFNKGMDCF, float JGIELNGMIAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PNHMJIKNPNC
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84EC400", Offset = "0x84EAE00", VA = "0x1884EC400")]
	public static float GGLKPDDDOAI(this JFIONBLOKBJ CMAEAFBBLDM)
	{
		return default(float);
	}
}
namespace RecRoom.FastText.Layout
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TextSegmentLayout
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly LayoutRect layoutRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int layoutVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private float layoutAlignment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly JOOIOJDCINJ textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x84ECAC0", Offset = "0x84EB4C0", VA = "0x1884ECAC0")]
		public TextSegmentLayout(LayoutRect layoutRect, JOOIOJDCINJ textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84EC890", Offset = "0x84EB290", VA = "0x1884EC890")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84EC900", Offset = "0x84EB300", VA = "0x1884EC900")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84EC830", Offset = "0x84EB230", VA = "0x1884EC830")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class KFMNKNCJAIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig NEOOOIFAPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float ONBCKECCDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float COLLACILEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float MMDOKMJGLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float ECHLOEAGLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float IKELKFPEIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float OHEJHPIDIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float BLNPGBCEDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float OEGJLFPFDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float HOIBDCIEOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float HKDPJGAJOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float LGFDDFCHDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float NDOLKPHMDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly KAMFMOIPFDK[] BJIHOGNDALC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int FLEHLGFAGHD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private DJGINPPMGDI[] OMLFNFFNOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int GFAIEMBCKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private MOHKFDBLNMJ[] AMGIADBEJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int BCCCAIGOMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public KAMFMOIPFDK OJNMAIONBLK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84EADA0", Offset = "0x84E97A0", VA = "0x1884EADA0")]
	public void LHEJPJMHOBO(LFJCIKGDCJH ACPOCJOPGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84EAE30", Offset = "0x84E9830", VA = "0x1884EAE30")]
	public void LHEJPJMHOBO(GlyphUVConfig IFEHNLPLAJL, IEnumerable<MOHKFDBLNMJ> LMIMPHKGCPF, MOHKFDBLNMJ PMLHMCDPEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84EAC60", Offset = "0x84E9660", VA = "0x1884EAC60")]
	internal void EFGINEHMLKP(GlyphUVConfig IFEHNLPLAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x84EA3F0", Offset = "0x84E8DF0", VA = "0x1884EA3F0")]
	private void CFBAIOPJJIP(IEnumerable<MOHKFDBLNMJ> LMIMPHKGCPF, MOHKFDBLNMJ PMLHMCDPEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84EA930", Offset = "0x84E9330", VA = "0x1884EA930")]
	public void CGDDIALBHLJ([In] char GEJFGBAPDDJ, [Out] float2[] IENLMKEPJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84E5D40", Offset = "0x84E4740", VA = "0x1884E5D40")]
	private KAMFMOIPFDK JMGCGCKEJCI(MOHKFDBLNMJ ILODLOOEGNE)
	{
		return default(KAMFMOIPFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84EAEB0", Offset = "0x84E98B0", VA = "0x1884EAEB0")]
	public KFMNKNCJAIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EEEBMNBDCJN
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84E7B30", Offset = "0x84E6530", VA = "0x1884E7B30")]
	public static void CNNOJNJLJGB([In] float LOFGIIINLIM, [In] float FNJFMICEFDF, [In] int KJHIGIBMJEA, [In] int HGDLEFEEOKH, [In] float ECHLOEAGLNP, [In] float IKELKFPEIPG, [In] float NDIDINOGPOO, [In] float JDPGCNILDLB, [In] float HDJHFPPAEAL, [In] float MAIJCDLIAFJ, [Out] float HGKNKBAKFDJ, [Out] float LJODOGONKFJ, [Out] float HILEHGMOPDN, [Out] float BKNMAKIJOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84E7C00", Offset = "0x84E6600", VA = "0x1884E7C00")]
	public static void CNNOJNJLJGB([In] float LOFGIIINLIM, [In] float FNJFMICEFDF, [In] int KJHIGIBMJEA, [In] int HGDLEFEEOKH, [Out] float HGKNKBAKFDJ, [Out] float LJODOGONKFJ, [Out] float HILEHGMOPDN, [Out] float BKNMAKIJOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84E7C60", Offset = "0x84E6660", VA = "0x1884E7C60")]
	public static void NNKBOOPLJMK([In] float ECHLOEAGLNP, [In] float IKELKFPEIPG, [In] float BHDFLOFGCMO, [In] float GEICLOFBMHM, [In] float EJAFGCFDCOM, [In] float IOEIOACOOPJ, [Out] float GBKJOBGLKFF, [Out] float EDLELCDEFCK, [Out] float EMIEGPKPJBK, [Out] float NGKPKPANAKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct DJGINPPMGDI
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint INOPHPPIKNE = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char MDJCEKEDGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly KAMFMOIPFDK CDLAPLMLIHF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84E7B10", Offset = "0x84E6510", VA = "0x1884E7B10")]
	public DJGINPPMGDI(char GEJFGBAPDDJ, KAMFMOIPFDK IENLMKEPJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KAMFMOIPFDK
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint INOPHPPIKNE = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] LBGFAIHDOLL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84EA300", Offset = "0x84E8D00", VA = "0x1884EA300")]
	public KAMFMOIPFDK(float HGKNKBAKFDJ, float LJODOGONKFJ, float HILEHGMOPDN, float BKNMAKIJOAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct MCPGGFAINDN
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int NMNNLEFEJNB = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal GGBBJBJJEON AIBBPPGLIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] FJEKEJLOIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int MNIICPEBLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 JAEBKJINIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float JONNFDNEHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 MAPGOEHEONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool POEMFDKMAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int NAIKIBAALBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int ELOKKAGEOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int IIKFMIHLIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int BEOAMJEFFLM;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x84EB0D0", Offset = "0x84E9AD0", VA = "0x1884EB0D0")]
	public static int PJOMKMFBDKF(int DDAJLLHFJBK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum GGBBJBJJEON : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Clean = 0,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DirtyPos = 1,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DirtyColor = 2,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DirtyUVs = 4,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DirtyPosColors = 3,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DirtyPosColorUVs = 7,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DirtyTextCapacity = 8,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DirtyMoreGlyphs = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DirtyLessGlyphs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DirtyGlyphCount = 0x30,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DirtyAllNoAlloc = 0x37,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DirtyAllWithAlloc = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	UtilDirtyLayout = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Any = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AEOJOJIOEJN
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84E7850", Offset = "0x84E6250", VA = "0x1884E7850")]
	internal static float GGLKPDDDOAI(this MCPGGFAINDN INDFLCBKDAB, float HCCFHFLGOKO, float IMFBJIEIDEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84E7890", Offset = "0x84E6290", VA = "0x1884E7890")]
	internal static void GGOIGIBCICC(this MCPGGFAINDN INDFLCBKDAB, float HCCFHFLGOKO, float IMFBJIEIDEC, [Out] float2 EPMJNJEPCMJ, [Out] float2 JOEBEKPOHKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class NIGLHGBHECK : CCHPBIFENPO
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int LFGNDNDJIIE = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int AOFJJMAPHMG = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string EJKJFOENMGD = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker DDMPLGMFCEA;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker HNIIDDJLNDO;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker CNBKPNBEFNA;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker KOFDNAIADHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly MEILAFLEOMG GIJPEHBAJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] OIMGGBMMLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] JIEFIAJMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int MHOCIMFLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int AINHPJLGJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int FAHKDNNEFOI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string IELIBBNCJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CCHPBIFENPO.FHOHKJAGHHK FIHBJFMPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x84EBE50", Offset = "0x84EA850", VA = "0x1884EBE50")]
	public NIGLHGBHECK(MEILAFLEOMG.GIMCOPMMHIF DGOHEGJNKHE, int JFFAJHCLKKK, int DBIGCIPEIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x84EBCC0", Offset = "0x84EA6C0", VA = "0x1884EBCC0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] MEILAFLEOMG GIJPEHBAJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84EB160", Offset = "0x84E9B60", VA = "0x1884EB160")]
	public void AJKILGIIELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84EB180", Offset = "0x84E9B80", VA = "0x1884EB180")]
	public void BBOMHLHKAOI(Span<MCPGGFAINDN> FJIBLGKEHMB, KFMNKNCJAIA FHGBHAEEEGF, [In] CDOBNKKMHDN OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84E65D0", Offset = "0x84E4FD0", VA = "0x1884E65D0")]
	private void FHNBGJIENHK([In] GGBBJBJJEON AIBBPPGLIJK, [In] MCPGGFAINDN GAOHCOAGGMG, int EMPECEBECFC, [In] float HCCFHFLGOKO, [In] float IMFBJIEIDEC, KFMNKNCJAIA FHGBHAEEEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x84EBB70", Offset = "0x84EA570", VA = "0x1884EBB70")]
	private void KPLOKDDKGON([In] GGBBJBJJEON AIBBPPGLIJK, MCPGGFAINDN GAOHCOAGGMG, [In] int OAONJOOCFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84EB960", Offset = "0x84EA360", VA = "0x1884EB960")]
	public static void KHDDKBCCMDL(ReadOnlySpan<MCPGGFAINDN> FJIBLGKEHMB, int DLKDEDPILKC, [Out] int GCKHHAPKJCB, [Out] int NKACLJBJJCA, [Out] int DIJAIGOOLKD)
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
