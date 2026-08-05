using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh;
using RecRoom.FastMesh.Core;
using RecRoom.FastMesh.Rendering;
using RecRoom.FastText.Core;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.FastText
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AUQKSEVRCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Texture2D UOGGYAXZKDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GlyphUVConfig DSDOHQLHSAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public GlyphCoordinate[] YFCRQOWZOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public GlyphCoordinate PXVBKRWVIQU;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static AUQKSEVRCFC EWILUTYWHAV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static AUQKSEVRCFC FGFWIGFRRNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x99B1460", Offset = "0x99B0460", VA = "0x1899B1460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public AUQKSEVRCFC()
		{
		}
	}
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
		[Cpp2IlInjected.Address(RVA = "0x99B2120", Offset = "0x99B1120", VA = "0x1899B2120")]
		public GlyphUVConfig(int texturePixelWidth, int texturePixelHeight, int glyphCountHorizontal, int glyphCountVertical, float glyphPixelKerning = 0f, [Optional] GlyphPixelInset glyphPixelInset)
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
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct GlyphCoordinate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly char Glyph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly int IndexHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly int IndexVertical;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly GlyphCoordinate DefaultCoordinate;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99B1720", Offset = "0x99B0720", VA = "0x1899B1720")]
		public GlyphCoordinate(char glyph, int indexHorizontal, int indexVertical)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99B1730", Offset = "0x99B0730", VA = "0x1899B1730")]
		public GlyphCoordinate(GlyphCoordinateWritable glyphCoordinate)
		{
		}
	}
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

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99B16B0", Offset = "0x99B06B0", VA = "0x1899B16B0")]
		public static implicit operator GlyphCoordinate(GlyphCoordinateWritable c)
		{
			return default(GlyphCoordinate);
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
		[Space]
		[FormerlySerializedAs("glyphColCount")]
		[FormerlySerializedAs("glyphCols")]
		[SerializeField]
		[Min(1f)]
		private int glyphCountHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[FormerlySerializedAs("glyphRowCount")]
		[FormerlySerializedAs("glyphRows")]
		[SerializeField]
		[Min(1f)]
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
		[Space]
		[SerializeField]
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
		private AUQKSEVRCFC configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D UOGGYAXZKDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader RPWXVRPCNFR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x99B17F0", Offset = "0x99B07F0", VA = "0x1899B17F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material KTLZXWVTWSR
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99B1F20", Offset = "0x99B0F20", VA = "0x1899B1F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> YFCRQOWZOCP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char WTSPSWZOWVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x99B1F10", Offset = "0x99B0F10", VA = "0x1899B1F10")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AUQKSEVRCFC ADJRFBFTIFW
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x99B1AA0", Offset = "0x99B0AA0", VA = "0x1899B1AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GlyphCoordinate OZWZMJEBFVM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x99B1880", Offset = "0x99B0880", VA = "0x1899B1880")]
			get
			{
				return default(GlyphCoordinate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99B1750", Offset = "0x99B0750", VA = "0x1899B1750")]
		internal void FHSJHXMMCVR(IEnumerable<GlyphCoordinateWritable> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99B1A10", Offset = "0x99B0A10", VA = "0x1899B1A10")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99B17D0", Offset = "0x99B07D0", VA = "0x1899B17D0")]
		[CompilerGenerated]
		private bool HEUCHERSWNJ(GlyphCoordinateWritable a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(TextSegmentMeshBufferSource))]
	public class SimpleTextSegmentSource : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TextSegmentMeshBufferSource QOSTSBSDKGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TextSegmentManager QTDNERVEKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[FormerlySerializedAs("SpanText")]
		public string SegmentText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[FormerlySerializedAs("SpanFontSize")]
		public float SegmentFontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[FormerlySerializedAs("SpanColor")]
		public Color32 SegmentColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[FormerlySerializedAs("SpanAnchor")]
		public float2 SegmentAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TDZCYUUKAEQ GZZLHQYPUYD;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99B3200", Offset = "0x99B2200", VA = "0x1899B3200")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99B31B0", Offset = "0x99B21B0", VA = "0x1899B31B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99B2FD0", Offset = "0x99B1FD0", VA = "0x1899B2FD0")]
		private void CKQDDGBYBTY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99B3330", Offset = "0x99B2330", VA = "0x1899B3330")]
		public SimpleTextSegmentSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	public sealed class TextSegmentMeshBufferSource : MeshBufferSource
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool CTSIKABIXZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material SMXIEBRUGYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TextSegmentManager QTDNERVEKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material QHYAVCNKWQS;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private AUQKSEVRCFC LCFFQPDYBAI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x99B5350", Offset = "0x99B4350", VA = "0x1899B5350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public TextSegmentManager AEGAUTNAKPG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x99B5B40", Offset = "0x99B4B40", VA = "0x1899B5B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material WYSJMYSNAET
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x99B5BA0", Offset = "0x99B4BA0", VA = "0x1899B5BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99B5A60", Offset = "0x99B4A60", VA = "0x1899B5A60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99B5850", Offset = "0x99B4850", VA = "0x1899B5850", Slot = "8")]
		protected override void PHLBMKXXNLA(GABTMZZSPDD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99B5A70", Offset = "0x99B4A70", VA = "0x1899B5A70", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99B5700", Offset = "0x99B4700", VA = "0x1899B5700")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99B53E0", Offset = "0x99B43E0", VA = "0x1899B53E0")]
		private void KNBCFCGCGGW(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD119E0", Offset = "0xD109E0", VA = "0x180D119E0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly ref struct TextSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal readonly TextSegmentManager Manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly int _segmentIdx;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99B69C0", Offset = "0x99B59C0", VA = "0x1899B69C0")]
		internal TextSegmentData FDSCQVPHIGG()
		{
			return default(TextSegmentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B67E80", Offset = "0x2B66E80", VA = "0x182B67E80")]
		internal TextSegment(TextSegmentManager manager, int segmentIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class TJCJBHUONOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99B3680", Offset = "0x99B2680", VA = "0x1899B3680")]
		public static bool CCSQVNZLOVB(this TextSegment a, TextSegmentDirtyStates b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99B36D0", Offset = "0x99B26D0", VA = "0x1899B36D0")]
		internal static bool CCSQVNZLOVB(this TextSegmentData a, TextSegmentDirtyStates b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99B36F0", Offset = "0x99B26F0", VA = "0x1899B36F0")]
		public static float WJCKNJKWNEY(this TextSegment a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD45FE0", Offset = "0xD44FE0", VA = "0x180D45FE0")]
		internal static float WJCKNJKWNEY(this TextSegmentData a)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class UKSBNANFSDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99B6BE0", Offset = "0x99B5BE0", VA = "0x1899B6BE0")]
		public static void FDUVZTVZHKN(this TextSegment a, ReadOnlySpan<char> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99B6C30", Offset = "0x99B5C30", VA = "0x1899B6C30")]
		internal static void FDUVZTVZHKN(this TextSegmentData a, ReadOnlySpan<char> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99B6E40", Offset = "0x99B5E40", VA = "0x1899B6E40")]
		public static void IGTCORFDYOD(this TextSegment a, float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99B6E30", Offset = "0x99B5E30", VA = "0x1899B6E30")]
		internal static void IGTCORFDYOD(this TextSegmentData a, float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99B6EF0", Offset = "0x99B5EF0", VA = "0x1899B6EF0")]
		public static void KAPSDBEQHEK(this TextSegment a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99B6EB0", Offset = "0x99B5EB0", VA = "0x1899B6EB0")]
		internal static void KAPSDBEQHEK(this TextSegmentData a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99B7000", Offset = "0x99B6000", VA = "0x1899B7000")]
		internal static void WWGPIFRCXLE(this TextSegmentData a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99B6F60", Offset = "0x99B5F60", VA = "0x1899B6F60")]
		public static void QHJSSAAJNZT(this TextSegment a, Color32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99B6FA0", Offset = "0x99B5FA0", VA = "0x1899B6FA0")]
		internal static void QHJSSAAJNZT(this TextSegmentData a, Color32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99B6FC0", Offset = "0x99B5FC0", VA = "0x1899B6FC0")]
		public static void VSHXJFKKYQL(this TextSegment a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99B6FB0", Offset = "0x99B5FB0", VA = "0x1899B6FB0")]
		internal static void VSHXJFKKYQL(this TextSegmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x99B6B70", Offset = "0x99B5B70", VA = "0x1899B6B70")]
		internal static void EBLTVMETFXM(this TextSegmentData a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99B6E90", Offset = "0x99B5E90", VA = "0x1899B6E90")]
		internal static void IQQKZWJXXRI(this TextSegmentData a, int b, TextSegmentDirtyStates c = TextSegmentDirtyStates.DirtyAllNoAlloc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class TDZCYUUKAEQ : IEquatable<TDZCYUUKAEQ>
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const ushort ECBYPMNAOYB = 0;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const int GXXAOIQAGDC = 65534;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly TDZCYUUKAEQ VQIDGENNDJK;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ushort DETNLJGKNFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xDBD1A0", Offset = "0xDBC1A0", VA = "0x180DBD1A0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xDBD1B0", Offset = "0xDBC1B0", VA = "0x180DBD1B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TextSegmentManager CRUNLPTVVQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool GJGEGYFMMBK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x99AF1A0", Offset = "0x99AE1A0", VA = "0x1899AF1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99AF4B0", Offset = "0x99AE4B0", VA = "0x1899AF4B0")]
		public TDZCYUUKAEQ(int a, TextSegmentManager b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x99B3530", Offset = "0x99B2530", VA = "0x1899B3530")]
		public bool VEFAHXWBEDU([Out] TextSegment a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99B34E0", Offset = "0x99B24E0", VA = "0x1899B34E0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99AF3B0", Offset = "0x99AE3B0", VA = "0x1899AF3B0")]
		internal void PEIOIQZYFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99AF270", Offset = "0x99AE270", VA = "0x1899AF270", Slot = "4")]
		public bool Equals(TDZCYUUKAEQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99B33B0", Offset = "0x99B23B0", VA = "0x1899B33B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99B3470", Offset = "0x99B2470", VA = "0x1899B3470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class TextSegmentManager : IDisposable, ANVYTGYFCQL
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string ORKRVHFEXTG = "FastText";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static ProfilerMarker NYUAZBDONEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string SLAOVMJMRPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly TextSegmentManagerConfig SHVWYHTNORO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal int HDFYEXNRZPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal TextSegmentData[] VKIYIOOVTPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal TDZCYUUKAEQ[] BFVMDAZGDYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private AUQKSEVRCFC DFPSCISZUZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly IWIZRRHVMKC RHLLIRHIQME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal readonly TextSegmentMeshWriter GCKHGXLCPQJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string GAXOXHPQSZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x99B45E0", Offset = "0x99B35E0", VA = "0x1899B45E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AUQKSEVRCFC ITHCGCZIAYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x99B4DC0", Offset = "0x99B3DC0", VA = "0x1899B4DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float BGPWHZOGZRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x99B4940", Offset = "0x99B3940", VA = "0x1899B4940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float FOZYFDXWZFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x99B45C0", Offset = "0x99B35C0", VA = "0x1899B45C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public ANVYTGYFCQL.GetMeshBufferDelegate HANLZAPTXIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BE0", Offset = "0xCF6BE0", VA = "0x180CF7BE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B80", Offset = "0xCF6B80", VA = "0x180CF7B80", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99B4EA0", Offset = "0x99B3EA0", VA = "0x1899B4EA0")]
		public TextSegmentManager(TextSegmentManagerConfig config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99B52D0", Offset = "0x99B42D0", VA = "0x1899B52D0")]
		public TextSegmentManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99B4470", Offset = "0x99B3470", VA = "0x1899B4470")]
		public void KWSQHQMQIDG(GlyphMapAsset a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99B44B0", Offset = "0x99B34B0", VA = "0x1899B44B0")]
		public void KWSQHQMQIDG(AUQKSEVRCFC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99B4BC0", Offset = "0x99B3BC0", VA = "0x1899B4BC0", Slot = "6")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99B4DE0", Offset = "0x99B3DE0", VA = "0x1899B4DE0")]
		public void ZPLXMDVGPHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99B4140", Offset = "0x99B3140", VA = "0x1899B4140")]
		public bool FEXDSNRGTCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99B4960", Offset = "0x99B3960", VA = "0x1899B4960")]
		public TDZCYUUKAEQ RYIOIBFUDRF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99B3DA0", Offset = "0x99B2DA0", VA = "0x1899B3DA0")]
		public void BJDNBMSYBHF(TDZCYUUKAEQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99B43C0", Offset = "0x99B33C0", VA = "0x1899B43C0")]
		internal bool JCQBPRNFYGP(TDZCYUUKAEQ a, [Out] TextSegment b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99B3C40", Offset = "0x99B2C40", VA = "0x1899B3C40")]
		private void BEEWWFZQVIZ(TextSegmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99B4190", Offset = "0x99B3190", VA = "0x1899B4190")]
		private void HDPUNWKRUQR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99B4350", Offset = "0x99B3350", VA = "0x1899B4350")]
		private bool HLBQWDZKZSA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99AD320", Offset = "0x99AC320", VA = "0x1899AD320")]
		private static int OUPIYBOMTPV(TDZCYUUKAEQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x25ECB30", Offset = "0x25EBB30", VA = "0x1825ECB30")]
		private static ushort KLWHPDHKAAJ(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99B4670", Offset = "0x99B3670", VA = "0x1899B4670")]
		private Bounds NQBEJXLONIL()
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x99B4090", Offset = "0x99B3090", VA = "0x1899B4090", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct TextSegmentManagerConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly TextSegmentManagerConfig DefaultConfig;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const float MAX_FONT_SIZE = 65535f;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const int MAX_SEGMENT_LIMIT = 65534;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private const int MAX_VERTEX_LIMIT = 65535;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Color DefaultFontColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float DefaultFontHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int InitialSegmentCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int InitialSegmentGlyphCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int TotalVertexLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int TotalSegmentsLimit;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x99B3A40", Offset = "0x99B2A40", VA = "0x1899B3A40")]
		internal TextSegmentManagerConfig BBRCRBMIAYQ()
		{
			return default(TextSegmentManagerConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99ACD40", Offset = "0x99ABD40", VA = "0x1899ACD40")]
		[CompilerGenerated]
		internal static void MYTGVHAEIMX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x99B3B50", Offset = "0x99B2B50", VA = "0x1899B3B50")]
		[CompilerGenerated]
		internal static void MHZDXQWTNGD(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99ACC90", Offset = "0x99ABC90", VA = "0x1899ACC90")]
		[CompilerGenerated]
		internal static void NZELPXDLSXN(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99B3B70", Offset = "0x99B2B70", VA = "0x1899B3B70")]
		[CompilerGenerated]
		internal static void XBFEGICBXIJ(float a, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class HBLEJSHHPQF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99B2150", Offset = "0x99B1150", VA = "0x1899B2150")]
		public static float RSAWFACNXRK(this TextSegment a)
		{
			return default(float);
		}
	}
}
namespace RecRoom.FastText.Layout
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Obfuscation(Exclude = true)]
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
		public readonly TDZCYUUKAEQ textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x99B39D0", Offset = "0x99B29D0", VA = "0x1899B39D0")]
		public TextSegmentLayout(LayoutRect layoutRect, TDZCYUUKAEQ textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99B37A0", Offset = "0x99B27A0", VA = "0x1899B37A0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99B3810", Offset = "0x99B2810", VA = "0x1899B3810")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x99B3740", Offset = "0x99B2740", VA = "0x1899B3740")]
		public void Cleanup()
		{
		}
	}
}
namespace RecRoom.FastText.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal sealed class IWIZRRHVMKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GlyphUVConfig LNIXZUBOURN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float HDNVZGWPPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float STBXKPPWDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float QWAFUZJJSUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private float ZXTRGHMREUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private float XLVMYBOIFLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public float GHENRPEFSAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float DURWFGKLHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float GRCOPCYYEOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float YRKVIAMKSEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float FOZYFDXWZFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public float JNSAJKGXNVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float BGPWHZOGZRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly QuadUVs[] KUPXGXIJTZT;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const int ARBHVJWOQNT = 128;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private GlyphQuadUVs[] ABXAKADKZLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int RUOJUFONZXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GlyphCoordinate[] OXUVULMFUEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int YKWHDHMCSPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public QuadUVs WSCRNMKPFVW;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99B2DB0", Offset = "0x99B1DB0", VA = "0x1899B2DB0")]
		public void KWSQHQMQIDG(AUQKSEVRCFC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x99B2D30", Offset = "0x99B1D30", VA = "0x1899B2D30")]
		public void KWSQHQMQIDG(GlyphUVConfig a, IEnumerable<GlyphCoordinate> b, GlyphCoordinate c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99B2BF0", Offset = "0x99B1BF0", VA = "0x1899B2BF0")]
		internal void IGNPVHXAICH(GlyphUVConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99B2370", Offset = "0x99B1370", VA = "0x1899B2370")]
		private void ARZMEMQWFKL(IEnumerable<GlyphCoordinate> a, GlyphCoordinate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99B28A0", Offset = "0x99B18A0", VA = "0x1899B28A0")]
		public void GDBHNMDFIPJ([In] char glyph, [Out] float2[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99AF860", Offset = "0x99AE860", VA = "0x1899AF860")]
		private QuadUVs GOWAHNBJTMQ(GlyphCoordinate a)
		{
			return default(QuadUVs);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x99B2E40", Offset = "0x99B1E40", VA = "0x1899B2E40")]
		public IWIZRRHVMKC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class HMOTDSLWMUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99B2240", Offset = "0x99B1240", VA = "0x1899B2240")]
		public static void DREEPCHUDBV([In] float glyphUVWidth, [In] float glyphUVHeight, [In] int glyphIndexHorizontal, [In] int glyphIndexVertical, [In] float glyphUVPixelWidth, [In] float glyphUVPixelHeight, [In] float glyphPixelInsetLeft, [In] float glyphPixelInsetRight, [In] float glyphPixelInsetTop, [In] float glyphPixelInsetBottom, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x99B2310", Offset = "0x99B1310", VA = "0x1899B2310")]
		public static void DREEPCHUDBV([In] float glyphUVWidth, [In] float glyphUVHeight, [In] int glyphIndexHorizontal, [In] int glyphIndexVertical, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x99B21E0", Offset = "0x99B11E0", VA = "0x1899B21E0")]
		public static void DHLMCXGIEWE([In] float glyphUVPixelWidth, [In] float glyphUVPixelHeight, [In] float pixelInsetLeft, [In] float pixelInsetRight, [In] float pixelInsetTop, [In] float pixelInsetBottom, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct GlyphQuadUVs
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public const uint BYTE_SIZE = 34u;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly char Glyph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly QuadUVs QuadUVs;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x99B2090", Offset = "0x99B1090", VA = "0x1899B2090")]
		public GlyphQuadUVs(char glyph, QuadUVs quadUVs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct QuadUVs
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public const uint BYTE_SIZE = 32u;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly float2[] UVs;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x99B2EE0", Offset = "0x99B1EE0", VA = "0x1899B2EE0")]
		public QuadUVs(float uMin, float uMax, float vMin, float vMax)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal struct TextSegmentData
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal const int GLYPH_ALLOCATION_FACTOR = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal TextSegmentDirtyStates dirtyFlag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		internal char[] textGlyphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal int textLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		internal float2 textAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal float fontHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		internal Color32 textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal bool isItalic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		internal int cachedMeshVertexCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal int cachedMeshIndexCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal int cachedMeshIndexLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		internal int cachedMeshIndexLengthLastWrite;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x99B3730", Offset = "0x99B2730", VA = "0x1899B3730")]
		public static int EOAINRAPABC(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Flags]
	public enum TextSegmentDirtyStates : byte
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
		Any = 0xFF
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class FWODWCTEJQE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99B1670", Offset = "0x99B0670", VA = "0x1899B1670")]
		internal static float RSAWFACNXRK(this TextSegmentData a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99B15F0", Offset = "0x99B05F0", VA = "0x1899B15F0")]
		internal static void QBBILLHPWOQ(this TextSegmentData a, float b, float c, [Out] float2 d, [Out] float2 e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal sealed class TextSegmentMeshWriter : ANVYTGYFCQL
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private const int RKAJBPZVQIS = 65535;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private const int HXOVJTXXJRK = 16383;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const string ORKRVHFEXTG = "TextSegmentMeshWriter";

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static ProfilerMarker NPROTBAIGVI;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static ProfilerMarker VELHNPAMKSO;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static ProfilerMarker XAYNNZXVOUT;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static ProfilerMarker QWKTQDTFQQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal readonly MeshBuffer PXOOIORCWVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly float3[] KEHKKRQPYAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float2[] PYOIDHYDZCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int LVGSPKALTRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int ZCZOFGPJLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int ZRHVQQKBTDQ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string GAXOXHPQSZL
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public ANVYTGYFCQL.GetMeshBufferDelegate HANLZAPTXIN
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99B68B0", Offset = "0x99B58B0", VA = "0x1899B68B0")]
		public TextSegmentMeshWriter(MeshBuffer.BoundsGetterDelegate boundsGetter, int initialGlyphCapacity, int vertexCountLimit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99B6720", Offset = "0x99B5720", VA = "0x1899B6720", Slot = "5")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99B6700", Offset = "0x99B5700", VA = "0x1899B6700")]
		public void LLLDPGYJGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99B5F40", Offset = "0x99B4F40", VA = "0x1899B5F40")]
		public void HMTGDXVLASM(Span<TextSegmentData> a, IWIZRRHVMKC b, [In] TextSegmentManagerConfig config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99B02C0", Offset = "0x99AF2C0", VA = "0x1899B02C0")]
		private void LRZDOSYROBH([In] TextSegmentDirtyStates dirtyFlag, [In] TextSegmentData textSegmentData, int a, [In] float glyphAspectRatio, [In] float glyphKerningFactor, IWIZRRHVMKC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99B5DF0", Offset = "0x99B4DF0", VA = "0x1899B5DF0")]
		private void ENBQXCDMTOI([In] TextSegmentDirtyStates dirtyFlag, TextSegmentData a, [In] int segmentIndexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99B5C00", Offset = "0x99B4C00", VA = "0x1899B5C00")]
		public static void DMKGWXJFFKW(ReadOnlySpan<TextSegmentData> a, int b, [Out] int c, [Out] int d, [Out] int e)
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
