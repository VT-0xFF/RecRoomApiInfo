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
	public class ABQXTDWSOUX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Texture2D DOERGIKYKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GlyphUVConfig HPJNQNIKGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public GlyphCoordinate[] UOJKWEBRTOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public GlyphCoordinate HMGWSFXGXGZ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static ABQXTDWSOUX NUQSBMNGSRK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ABQXTDWSOUX DOTBAWBOHVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x99BD960", Offset = "0x99BC360", VA = "0x1899BD960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ABQXTDWSOUX()
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
		[Cpp2IlInjected.Address(RVA = "0x99BF210", Offset = "0x99BDC10", VA = "0x1899BF210")]
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
		[Cpp2IlInjected.Address(RVA = "0x99BE810", Offset = "0x99BD210", VA = "0x1899BE810")]
		public GlyphCoordinate(char glyph, int indexHorizontal, int indexVertical)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99BE820", Offset = "0x99BD220", VA = "0x1899BE820")]
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
		[Cpp2IlInjected.Address(RVA = "0x99BE7A0", Offset = "0x99BD1A0", VA = "0x1899BE7A0")]
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
		private ABQXTDWSOUX configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D DOERGIKYKDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader YXQOXBKTPCU
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x99BEA70", Offset = "0x99BD470", VA = "0x1899BEA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material ZVUYUBEGDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99BF010", Offset = "0x99BDA10", VA = "0x1899BF010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> UOJKWEBRTOM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char UJLBJHAUUFF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x99BF000", Offset = "0x99BDA00", VA = "0x1899BF000")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ABQXTDWSOUX KEJXTFVYBUX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x99BEB90", Offset = "0x99BD590", VA = "0x1899BEB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GlyphCoordinate HRRWJMBVQBX
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x99BE840", Offset = "0x99BD240", VA = "0x1899BE840")]
			get
			{
				return default(GlyphCoordinate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99BE9D0", Offset = "0x99BD3D0", VA = "0x1899BE9D0")]
		internal void FFVDSJDOQXA(IEnumerable<GlyphCoordinateWritable> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99BEB00", Offset = "0x99BD500", VA = "0x1899BEB00")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99BEA50", Offset = "0x99BD450", VA = "0x1899BEA50")]
		[CompilerGenerated]
		private bool POIEEFNOAKK(GlyphCoordinateWritable a)
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
		private TextSegmentMeshBufferSource ZDPSQTYGYPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TextSegmentManager XEZGDTEJOMA;

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
		private RCCSHOJZMQF YRLTQMDWJMA;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99BF7E0", Offset = "0x99BE1E0", VA = "0x1899BF7E0")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99BF790", Offset = "0x99BE190", VA = "0x1899BF790")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99BF910", Offset = "0x99BE310", VA = "0x1899BF910")]
		private void WJUYPBTVBWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99BFAF0", Offset = "0x99BE4F0", VA = "0x1899BFAF0")]
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
		private bool JVZQHLSKCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material DJIDPDBTHSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TextSegmentManager XEZGDTEJOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material JDHFHXQDBID;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private ABQXTDWSOUX KVMCXEKKUGD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x99C19B0", Offset = "0x99C03B0", VA = "0x1899C19B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public TextSegmentManager VNTPHBOKJPH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x99C1F90", Offset = "0x99C0990", VA = "0x1899C1F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material GMWZMFARECQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x99C1FF0", Offset = "0x99C09F0", VA = "0x1899C1FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99C1EB0", Offset = "0x99C08B0", VA = "0x1899C1EB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99C1790", Offset = "0x99C0190", VA = "0x1899C1790", Slot = "8")]
		protected override void BUPYOOSSEZL(CCXDQBYQPIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99C1EC0", Offset = "0x99C08C0", VA = "0x1899C1EC0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99C1A40", Offset = "0x99C0440", VA = "0x1899C1A40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99C1B90", Offset = "0x99C0590", VA = "0x1899C1B90")]
		private void RCLCXWKDXCN(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD2C730", Offset = "0xD2B130", VA = "0x180D2C730")]
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
		[Cpp2IlInjected.Address(RVA = "0x99C2E10", Offset = "0x99C1810", VA = "0x1899C2E10")]
		internal TextSegmentData VAELSZHSRXJ()
		{
			return default(TextSegmentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C320", Offset = "0x2B9AD20", VA = "0x182B9C320")]
		internal TextSegment(TextSegmentManager manager, int segmentIdx)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class BDNEQAGYZXB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99BE680", Offset = "0x99BD080", VA = "0x1899BE680")]
		public static bool YMVWUWLHGMI(this TextSegment a, TextSegmentDirtyStates b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99BE660", Offset = "0x99BD060", VA = "0x1899BE660")]
		internal static bool YMVWUWLHGMI(this TextSegmentData a, TextSegmentDirtyStates b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99BE6D0", Offset = "0x99BD0D0", VA = "0x1899BE6D0")]
		public static float ZLVGDACASRP(this TextSegment a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD77880", Offset = "0xD76280", VA = "0x180D77880")]
		internal static float ZLVGDACASRP(this TextSegmentData a)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ZMWJONQWPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99C3220", Offset = "0x99C1C20", VA = "0x1899C3220")]
		public static void YAVTLBOFTYU(this TextSegment a, ReadOnlySpan<char> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99C3270", Offset = "0x99C1C70", VA = "0x1899C3270")]
		internal static void YAVTLBOFTYU(this TextSegmentData a, ReadOnlySpan<char> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99C3470", Offset = "0x99C1E70", VA = "0x1899C3470")]
		public static void ZMULPRYDZFY(this TextSegment a, float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99C34C0", Offset = "0x99C1EC0", VA = "0x1899C34C0")]
		internal static void ZMULPRYDZFY(this TextSegmentData a, float2 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99C3080", Offset = "0x99C1A80", VA = "0x1899C3080")]
		public static void AZUEEMVWIXB(this TextSegment a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99C30F0", Offset = "0x99C1AF0", VA = "0x1899C30F0")]
		internal static void AZUEEMVWIXB(this TextSegmentData a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99C3150", Offset = "0x99C1B50", VA = "0x1899C3150")]
		internal static void NTSXWWJGOVN(this TextSegmentData a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99C34D0", Offset = "0x99C1ED0", VA = "0x1899C34D0")]
		public static void ZXHLQYKLNRY(this TextSegment a, Color32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99C3510", Offset = "0x99C1F10", VA = "0x1899C3510")]
		internal static void ZXHLQYKLNRY(this TextSegmentData a, Color32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99C3160", Offset = "0x99C1B60", VA = "0x1899C3160")]
		public static void NXHRFEKXVFM(this TextSegment a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99C31A0", Offset = "0x99C1BA0", VA = "0x1899C31A0")]
		internal static void NXHRFEKXVFM(this TextSegmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x99C31B0", Offset = "0x99C1BB0", VA = "0x1899C31B0")]
		internal static void ULWXVBGXPFB(this TextSegmentData a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99C3130", Offset = "0x99C1B30", VA = "0x1899C3130")]
		internal static void MSLDSIKPHTJ(this TextSegmentData a, int b, TextSegmentDirtyStates c = TextSegmentDirtyStates.DirtyAllNoAlloc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class RCCSHOJZMQF : IEquatable<RCCSHOJZMQF>
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const ushort JRROKGZGWHO = 0;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const int RINMCUACNRD = 65534;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly RCCSHOJZMQF TRXSDSIFVDZ;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ushort KBNSRJPOPPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xDD78D0", Offset = "0xDD62D0", VA = "0x180DD78D0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xDD78E0", Offset = "0xDD62E0", VA = "0x180DD78E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TextSegmentManager DKWTSYBPUTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x99B5250", Offset = "0x99B3C50", VA = "0x1899B5250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99B5360", Offset = "0x99B3D60", VA = "0x1899B5360")]
		public RCCSHOJZMQF(int a, TextSegmentManager b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x99BF640", Offset = "0x99BE040", VA = "0x1899BF640")]
		public bool UAOZZIEJMVN([Out] TextSegment a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99BF5F0", Offset = "0x99BDFF0", VA = "0x1899BF5F0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99B5260", Offset = "0x99B3C60", VA = "0x1899B5260")]
		internal void PPAOWVBBJCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99B5110", Offset = "0x99B3B10", VA = "0x1899B5110", Slot = "4")]
		public bool Equals(RCCSHOJZMQF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99BF4C0", Offset = "0x99BDEC0", VA = "0x1899BF4C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99BF580", Offset = "0x99BDF80", VA = "0x1899BF580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class TextSegmentManager : IDisposable, HOVKSWBPVOW
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string NPWORGEGDYN = "FastText";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static ProfilerMarker DISFHOACIIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string LVRMURGCZHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly TextSegmentManagerConfig XQRSGSBTDXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal int TCKTIMQRDFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal TextSegmentData[] LJTERKJIYQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal RCCSHOJZMQF[] FNSGNHEFRRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private ABQXTDWSOUX RJMKWMREYZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly AYPTRMSZZSR QRKZLFZWSUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal readonly TextSegmentMeshWriter VJNAUGMITXC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string TRYGGLEORZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x99C0E10", Offset = "0x99BF810", VA = "0x1899C0E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ABQXTDWSOUX OGRRMSQKAPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x99C11F0", Offset = "0x99BFBF0", VA = "0x1899C11F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float YFIAKHZBWVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x99C0830", Offset = "0x99BF230", VA = "0x1899C0830")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float KNSPWKJZPWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x99C0700", Offset = "0x99BF100", VA = "0x1899C0700")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public HOVKSWBPVOW.GetMeshBufferDelegate ECGWWKWSSPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD11910", Offset = "0xD10310", VA = "0x180D11910", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99C12E0", Offset = "0x99BFCE0", VA = "0x1899C12E0")]
		public TextSegmentManager(TextSegmentManagerConfig config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99C1710", Offset = "0x99C0110", VA = "0x1899C1710")]
		public TextSegmentManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99C0FB0", Offset = "0x99BF9B0", VA = "0x1899C0FB0")]
		public void RKCBVVMJUOD(GlyphMapAsset a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99C0EA0", Offset = "0x99BF8A0", VA = "0x1899C0EA0")]
		public void RKCBVVMJUOD(ABQXTDWSOUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99C0FF0", Offset = "0x99BF9F0", VA = "0x1899C0FF0", Slot = "6")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99C0720", Offset = "0x99BF120", VA = "0x1899C0720")]
		public void HIEQSMCHHWS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99C03A0", Offset = "0x99BEDA0", VA = "0x1899C03A0")]
		public bool CZYMEHHWRKT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99C04A0", Offset = "0x99BEEA0", VA = "0x1899C04A0")]
		public RCCSHOJZMQF EEAESNEBUYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99C0B20", Offset = "0x99BF520", VA = "0x1899C0B20")]
		public void KVVRLNSFFDK(RCCSHOJZMQF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99C0780", Offset = "0x99BF180", VA = "0x1899C0780")]
		internal bool JDFQTAIFFEK(RCCSHOJZMQF a, [Out] TextSegment b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99C0080", Offset = "0x99BEA80", VA = "0x1899C0080")]
		private void ASTRIGSBDRK(TextSegmentData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99C01E0", Offset = "0x99BEBE0", VA = "0x1899C01E0")]
		private void BQJFUFPSFJU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99C1210", Offset = "0x99BFC10", VA = "0x1899C1210")]
		private bool WSAZWEWWALB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99BB380", Offset = "0x99B9D80", VA = "0x1899BB380")]
		private static int UFJBXELKWHI(RCCSHOJZMQF a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x26199D0", Offset = "0x26183D0", VA = "0x1826199D0")]
		private static ushort PDYIASVZWNS(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99C0850", Offset = "0x99BF250", VA = "0x1899C0850")]
		private Bounds KUJZCMEMBMS()
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x99C03F0", Offset = "0x99BEDF0", VA = "0x1899C03F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x99BFEA0", Offset = "0x99BE8A0", VA = "0x1899BFEA0")]
		internal TextSegmentManagerConfig SJIYDVOYJDV()
		{
			return default(TextSegmentManagerConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99BA960", Offset = "0x99B9360", VA = "0x1899BA960")]
		[CompilerGenerated]
		internal static void XMRQAFEALZC(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x99BFFB0", Offset = "0x99BE9B0", VA = "0x1899BFFB0")]
		[CompilerGenerated]
		internal static void WDQEQLSJJQQ(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99BA970", Offset = "0x99B9370", VA = "0x1899BA970")]
		[CompilerGenerated]
		internal static void NGOLBFBAMXU(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99BFE80", Offset = "0x99BE880", VA = "0x1899BFE80")]
		[CompilerGenerated]
		internal static void GQFCGZWZMRO(float a, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EPAKSLPPNYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99BE710", Offset = "0x99BD110", VA = "0x1899BE710")]
		public static float RNBSAETVIBH(this TextSegment a)
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
		public readonly RCCSHOJZMQF textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x99BFE10", Offset = "0x99BE810", VA = "0x1899BFE10")]
		public TextSegmentLayout(LayoutRect layoutRect, RCCSHOJZMQF textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99BFBE0", Offset = "0x99BE5E0", VA = "0x1899BFBE0")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99BFC50", Offset = "0x99BE650", VA = "0x1899BFC50")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x99BFB80", Offset = "0x99BE580", VA = "0x1899BFB80")]
		public void Cleanup()
		{
		}
	}
}
namespace RecRoom.FastText.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal sealed class AYPTRMSZZSR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GlyphUVConfig MWTUFIAPBAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float TJNKPXKFFPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float DDWAQGMAVYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float UXFENGWLVXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private float BSVRUVOCIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private float DRJKJXSZMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public float QVRDBVYVAYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float SEVFHXKNRDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float EOGIRDUFDOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float XTXUMLISUOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float KNSPWKJZPWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public float VWAYDQCCFKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float YFIAKHZBWVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly QuadUVs[] DTYYEBRKMQQ;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const int QBOGBJXAVPS = 128;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private GlyphQuadUVs[] AOCBEURNBSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int BPEFHWIKCGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GlyphCoordinate[] ILTQMGDWWYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int IKGJERIGPYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public QuadUVs CLOGZBDWEGN;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99BE3F0", Offset = "0x99BCDF0", VA = "0x1899BE3F0")]
		public void RKCBVVMJUOD(ABQXTDWSOUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x99BE370", Offset = "0x99BCD70", VA = "0x1899BE370")]
		public void RKCBVVMJUOD(GlyphUVConfig a, IEnumerable<GlyphCoordinate> b, GlyphCoordinate c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99BE480", Offset = "0x99BCE80", VA = "0x1899BE480")]
		internal void XLVAFCVWQTW(GlyphUVConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99BDE40", Offset = "0x99BC840", VA = "0x1899BDE40")]
		private void RIOWDOOIDQO(IEnumerable<GlyphCoordinate> a, GlyphCoordinate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99BDAF0", Offset = "0x99BC4F0", VA = "0x1899BDAF0")]
		public void JDLVNEOZSJY([In] char glyph, [Out] float2[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99BBD60", Offset = "0x99BA760", VA = "0x1899BBD60")]
		private QuadUVs PDSWGUSFLMR(GlyphCoordinate a)
		{
			return default(QuadUVs);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x99BE5C0", Offset = "0x99BCFC0", VA = "0x1899BE5C0")]
		public AYPTRMSZZSR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class QQUIUIEZKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99BF300", Offset = "0x99BDD00", VA = "0x1899BF300")]
		public static void VFEBJYSSOFC([In] float glyphUVWidth, [In] float glyphUVHeight, [In] int glyphIndexHorizontal, [In] int glyphIndexVertical, [In] float glyphUVPixelWidth, [In] float glyphUVPixelHeight, [In] float glyphPixelInsetLeft, [In] float glyphPixelInsetRight, [In] float glyphPixelInsetTop, [In] float glyphPixelInsetBottom, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x99BF2A0", Offset = "0x99BDCA0", VA = "0x1899BF2A0")]
		public static void VFEBJYSSOFC([In] float glyphUVWidth, [In] float glyphUVHeight, [In] int glyphIndexHorizontal, [In] int glyphIndexVertical, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x99BF240", Offset = "0x99BDC40", VA = "0x1899BF240")]
		public static void NASOCGBMECH([In] float glyphUVPixelWidth, [In] float glyphUVPixelHeight, [In] float pixelInsetLeft, [In] float pixelInsetRight, [In] float pixelInsetTop, [In] float pixelInsetBottom, [Out] float a, [Out] float b, [Out] float c, [Out] float d)
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
		[Cpp2IlInjected.Address(RVA = "0x99BF180", Offset = "0x99BDB80", VA = "0x1899BF180")]
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
		[Cpp2IlInjected.Address(RVA = "0x99BF3D0", Offset = "0x99BDDD0", VA = "0x1899BF3D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99BFB70", Offset = "0x99BE570", VA = "0x1899BFB70")]
		public static int DRILIXXGVSR(int a)
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
	public static class XOTMWZOZKYH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99C3040", Offset = "0x99C1A40", VA = "0x1899C3040")]
		internal static float RNBSAETVIBH(this TextSegmentData a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99C2FC0", Offset = "0x99C19C0", VA = "0x1899C2FC0")]
		internal static void AXBVPUZGKWZ(this TextSegmentData a, float b, float c, [Out] float2 d, [Out] float2 e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal sealed class TextSegmentMeshWriter : HOVKSWBPVOW
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private const int JTKUSLLYUJP = 65535;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private const int RTFJSOOTYYZ = 16383;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const string NPWORGEGDYN = "TextSegmentMeshWriter";

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static ProfilerMarker AJQVHDCTUBB;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static ProfilerMarker SWUEHPNLIZL;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static ProfilerMarker LUDPZCWAFCA;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static ProfilerMarker SFQUEMBQKOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal readonly MeshBuffer EQGGRZNSHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly float3[] TCKXPRAYHZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float2[] JFKAGZWGETQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int HAMLPAEXWEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int VSGXLRVHUGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int FYVBIPIGZMH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string TRYGGLEORZU
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public HOVKSWBPVOW.GetMeshBufferDelegate ECGWWKWSSPK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99C2D00", Offset = "0x99C1700", VA = "0x1899C2D00")]
		public TextSegmentMeshWriter(MeshBuffer.BoundsGetterDelegate boundsGetter, int initialGlyphCapacity, int vertexCountLimit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99C2A00", Offset = "0x99C1400", VA = "0x1899C2A00", Slot = "5")]
		public bool TryGetMeshBuffer([Out] MeshBuffer meshBuffer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99C2A70", Offset = "0x99C1470", VA = "0x1899C2A70")]
		public void UAEXCYFUYBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99C2050", Offset = "0x99C0A50", VA = "0x1899C2050")]
		public void DDSSUJKSUDT(Span<TextSegmentData> a, AYPTRMSZZSR b, [In] TextSegmentManagerConfig config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99BC8F0", Offset = "0x99BB2F0", VA = "0x1899BC8F0")]
		private void UZILRYAXJIW([In] TextSegmentDirtyStates dirtyFlag, [In] TextSegmentData textSegmentData, int a, [In] float glyphAspectRatio, [In] float glyphKerningFactor, AYPTRMSZZSR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99C2A90", Offset = "0x99C1490", VA = "0x1899C2A90")]
		private void ZJTEGRQUFDL([In] TextSegmentDirtyStates dirtyFlag, TextSegmentData a, [In] int segmentIndexBufferIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99C2810", Offset = "0x99C1210", VA = "0x1899C2810")]
		public static void SFCCPMJIAQJ(ReadOnlySpan<TextSegmentData> a, int b, [Out] int c, [Out] int d, [Out] int e)
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
