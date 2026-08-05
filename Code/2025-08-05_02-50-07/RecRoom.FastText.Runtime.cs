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
public class NJHEOCEANPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D GIOGCFBDILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig DMPGGOLCGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public EGJBLHJILBH[] KJKLKBBGNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public EGJBLHJILBH BODGOHOGGFA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static NJHEOCEANPD DAOMANINCLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NJHEOCEANPD LPGLPBBIDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82A3700", Offset = "0x82A2B00", VA = "0x1882A3700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NJHEOCEANPD()
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
		[Cpp2IlInjected.Address(RVA = "0x829FF70", Offset = "0x829F370", VA = "0x18829FF70")]
		public GlyphUVConfig(int FEEGLANNDHH, int IJFAOLKJNDL, int FIFKPGMEEJA, int AHGBKFEILLF, float FIKGPHLAAEC = 0f, [Optional] GlyphPixelInset AICMEFBHFPF)
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
public readonly struct EGJBLHJILBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char FBJDHMNEEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int DAEILJLCPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int GLHDGBHHFKL;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly EGJBLHJILBH DFNEJNGGGKJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x829F2C0", Offset = "0x829E6C0", VA = "0x18829F2C0")]
	public EGJBLHJILBH(char CGDPLHKAFLO, int FCNIJLGJHPB, int NDBJHFNMEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x829F2D0", Offset = "0x829E6D0", VA = "0x18829F2D0")]
	public EGJBLHJILBH(GlyphCoordinateWritable PBNOBIEENFN)
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
		[Cpp2IlInjected.Address(RVA = "0x829F580", Offset = "0x829E980", VA = "0x18829F580")]
		public static EGJBLHJILBH GKKMDDPCKIG(GlyphCoordinateWritable CHNNNFLKBNN)
		{
			return default(EGJBLHJILBH);
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
		private NJHEOCEANPD configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x829FE70", Offset = "0x829F270", VA = "0x18829FE70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x829FCF0", Offset = "0x829F0F0", VA = "0x18829FCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x829FCE0", Offset = "0x829F0E0", VA = "0x18829FCE0")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NJHEOCEANPD ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x829F6D0", Offset = "0x829EAD0", VA = "0x18829F6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EGJBLHJILBH FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x829FB50", Offset = "0x829EF50", VA = "0x18829FB50")]
			get
			{
				return default(EGJBLHJILBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x829F5C0", Offset = "0x829E9C0", VA = "0x18829F5C0")]
		internal void OPDCFAALBEH(IEnumerable<GlyphCoordinateWritable> HGFPDDHMJLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x829F640", Offset = "0x829EA40", VA = "0x18829F640")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x829F5A0", Offset = "0x829E9A0", VA = "0x18829F5A0")]
		[CompilerGenerated]
		private bool HFNFIHMMMDI(GlyphCoordinateWritable CHNNNFLKBNN)
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
		private TextSegmentMeshBufferSource PCJIEEAPKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private MMDFPBCPPIL JDPBLGFBJAJ;

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
		private NPLDOBIAEPA MCILLKMJMMG;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82A3F70", Offset = "0x82A3370", VA = "0x1882A3F70")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82A3F20", Offset = "0x82A3320", VA = "0x1882A3F20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82A3D40", Offset = "0x82A3140", VA = "0x1882A3D40")]
		private void JOGOFCCGIHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82A4060", Offset = "0x82A3460", VA = "0x1882A4060")]
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
		private bool GFFNKPNHDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material GBOHKBAJDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private MMDFPBCPPIL JDPBLGFBJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material PNIIEOINJJG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private NJHEOCEANPD ALGHDMNJAOE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x82A43E0", Offset = "0x82A37E0", VA = "0x1882A43E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MMDFPBCPPIL NPAJHGPIJEG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x82A4B50", Offset = "0x82A3F50", VA = "0x1882A4B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material GLFABINCIIN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x82A4B80", Offset = "0x82A3F80", VA = "0x1882A4B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82A4AB0", Offset = "0x82A3EB0", VA = "0x1882A4AB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82A4470", Offset = "0x82A3870", VA = "0x1882A4470", Slot = "8")]
		protected override void EJABDMJDLKC(FANALJCJPEA JPDMLMONOAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82A4AC0", Offset = "0x82A3EC0", VA = "0x1882A4AC0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] LEIELOBJHHC PIOAHEPFEFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82A4960", Offset = "0x82A3D60", VA = "0x1882A4960")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82A4640", Offset = "0x82A3A40", VA = "0x1882A4640")]
		private void EJMHHNINEKM(bool KBIBIFOFAKG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA8B610", Offset = "0xA8AA10", VA = "0x180A8B610")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct OAMEGBFBNKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly MMDFPBCPPIL BCCGHIIMBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int IDFEKBIGDDM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82A3B70", Offset = "0x82A2F70", VA = "0x1882A3B70")]
	internal NKGAEFHMDLM GLIFNCBFEHC()
	{
		return default(NKGAEFHMDLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A3B0", Offset = "0x2A697B0", VA = "0x182A6A3B0")]
	internal OAMEGBFBNKC(MMDFPBCPPIL JPGAFCLKGNM, int GPNKIJMKLPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BPEMIHMBHHL
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x829F140", Offset = "0x829E540", VA = "0x18829F140")]
	public static bool OMHKCNEJAEP(this OAMEGBFBNKC JMJNEBNDLKF, DFMPDOAHMAA CLKFPKOPGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x829F190", Offset = "0x829E590", VA = "0x18829F190")]
	internal static bool OMHKCNEJAEP(this NKGAEFHMDLM OAHDNKPEPGE, DFMPDOAHMAA CLKFPKOPGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x829F100", Offset = "0x829E500", VA = "0x18829F100")]
	public static float NEGKDNLMHDK(this OAMEGBFBNKC JMJNEBNDLKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40")]
	internal static float NEGKDNLMHDK(this NKGAEFHMDLM OAHDNKPEPGE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IMDOJCGNBKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x829FFA0", Offset = "0x829F3A0", VA = "0x18829FFA0")]
	public static void DGGMHMNFOEF(this OAMEGBFBNKC JMJNEBNDLKF, ReadOnlySpan<char> JIBCECJIMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x829FFF0", Offset = "0x829F3F0", VA = "0x18829FFF0")]
	internal static void DGGMHMNFOEF(this NKGAEFHMDLM OAHDNKPEPGE, ReadOnlySpan<char> JIBCECJIMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x82A03E0", Offset = "0x829F7E0", VA = "0x1882A03E0")]
	public static void NIENDAPLBCE(this OAMEGBFBNKC BHDHCDGMOKI, float2 MDELHDHKDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82A0430", Offset = "0x829F830", VA = "0x1882A0430")]
	internal static void NIENDAPLBCE(this NKGAEFHMDLM OAHDNKPEPGE, float2 MDELHDHKDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x82A0330", Offset = "0x829F730", VA = "0x1882A0330")]
	public static void NAPOEIOLPAH(this OAMEGBFBNKC BHDHCDGMOKI, float AKKJCMPDNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82A03A0", Offset = "0x829F7A0", VA = "0x1882A03A0")]
	internal static void NAPOEIOLPAH(this NKGAEFHMDLM OAHDNKPEPGE, float AKKJCMPDNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82A0240", Offset = "0x829F640", VA = "0x1882A0240")]
	internal static void HKGIDKAIGLJ(this NKGAEFHMDLM OAHDNKPEPGE, bool MLEJOCHCDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82A0200", Offset = "0x829F600", VA = "0x1882A0200")]
	public static void FEBHBPCBCFF(this OAMEGBFBNKC BHDHCDGMOKI, Color32 IFBOGFLAOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82A01F0", Offset = "0x829F5F0", VA = "0x1882A01F0")]
	internal static void FEBHBPCBCFF(this NKGAEFHMDLM OAHDNKPEPGE, Color32 IFBOGFLAOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82A0260", Offset = "0x829F660", VA = "0x1882A0260")]
	public static void KMNBNAACCLB(this OAMEGBFBNKC BHDHCDGMOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82A0250", Offset = "0x829F650", VA = "0x1882A0250")]
	internal static void KMNBNAACCLB(this NKGAEFHMDLM OAHDNKPEPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x82A02A0", Offset = "0x829F6A0", VA = "0x1882A02A0")]
	internal static void MMCCADGMHGI(this NKGAEFHMDLM OAHDNKPEPGE, int FLGJKOGKNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82A0310", Offset = "0x829F710", VA = "0x1882A0310")]
	internal static void MMGFPMLKFBJ(this NKGAEFHMDLM OAHDNKPEPGE, int HKGIMACKGLG, DFMPDOAHMAA EFCKHGMLFNC = DFMPDOAHMAA.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NPLDOBIAEPA : IEquatable<NPLDOBIAEPA>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort KAJFICLPIFN = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int CMJKOLDCDAE = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly NPLDOBIAEPA OBNMJIMBHID;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort NIFMJAEHAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xD88A20", Offset = "0xD87E20", VA = "0x180D88A20")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD88A30", Offset = "0xD87E30", VA = "0x180D88A30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MMDFPBCPPIL BCCGHIIMBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JDPJAANKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8299BF0", Offset = "0x8298FF0", VA = "0x188299BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8299D80", Offset = "0x8299180", VA = "0x188299D80")]
	public NPLDOBIAEPA(int FAAADMOMPAE, MMDFPBCPPIL JPGAFCLKGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82A39C0", Offset = "0x82A2DC0", VA = "0x1882A39C0")]
	public bool HJLJENBCMFD([Out] OAMEGBFBNKC JMJNEBNDLKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82A3A90", Offset = "0x82A2E90", VA = "0x1882A3A90")]
	public void LLLHPAIEGMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8299C70", Offset = "0x8299070", VA = "0x188299C70")]
	internal void LCKBMNGLGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8299AD0", Offset = "0x8298ED0", VA = "0x188299AD0", Slot = "4")]
	public bool Equals(NPLDOBIAEPA LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82A3890", Offset = "0x82A2C90", VA = "0x1882A3890", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82A3950", Offset = "0x82A2D50", VA = "0x1882A3950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MMDFPBCPPIL : IDisposable, PEAEKLMBLEB
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string LNOEFJFGAON = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker GFDLAJHDOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string EFINADMOPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly GGEJNEAJJPL GLDKAJEHDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int NJLBPDDNAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal NKGAEFHMDLM[] BBPJIKNOFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal NPLDOBIAEPA[] GHFEPIOEBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private NJHEOCEANPD PKKLCCFLILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly NBDMDPNDLGB BFOFHLJMDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly MFAKKIIPOAJ CMOHEHABMAC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string HDNPPEBJPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82A1500", Offset = "0x82A0900", VA = "0x1882A1500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NJHEOCEANPD GHGIDAANCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82A2400", Offset = "0x82A1800", VA = "0x1882A2400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float GKCJPNKKKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82A1DE0", Offset = "0x82A11E0", VA = "0x1882A1DE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float JNEHDNBFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x82A1330", Offset = "0x82A0730", VA = "0x1882A1330")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PEAEKLMBLEB.LCFDLNMPFHL BHBNGNGEMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA70240", Offset = "0xA6F640", VA = "0x180A70240", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82A26C0", Offset = "0x82A1AC0", VA = "0x1882A26C0")]
	public MMDFPBCPPIL(GGEJNEAJJPL HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82A2B00", Offset = "0x82A1F00", VA = "0x1882A2B00")]
	public MMDFPBCPPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82A2090", Offset = "0x82A1490", VA = "0x1882A2090")]
	public void IPJPKJAMFMN(GlyphMapAsset ODIJECMHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82A1F80", Offset = "0x82A1380", VA = "0x1882A1F80")]
	public void IPJPKJAMFMN(NJHEOCEANPD ECLHDBEMNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82A2420", Offset = "0x82A1820", VA = "0x1882A2420", Slot = "6")]
	public bool TryGetMeshBuffer([Out] LEIELOBJHHC PIOAHEPFEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82A2130", Offset = "0x82A1530", VA = "0x1882A2130")]
	public void KJMNJFNGGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82A1400", Offset = "0x82A0800", VA = "0x1882A1400")]
	public bool DOONGPFBLFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82A2190", Offset = "0x82A1590", VA = "0x1882A2190")]
	public NPLDOBIAEPA LOFCFFCAAAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82A1A80", Offset = "0x82A0E80", VA = "0x1882A1A80")]
	public void GHEDMCAPBEI(NPLDOBIAEPA FCMKNPPFCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82A1350", Offset = "0x82A0750", VA = "0x1882A1350")]
	internal bool DLPABABOCEI(NPLDOBIAEPA FCMKNPPFCKC, [Out] OAMEGBFBNKC JMJNEBNDLKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82A1E00", Offset = "0x82A1200", VA = "0x1882A1E00")]
	private void HOADGMNBABB(NKGAEFHMDLM OAHDNKPEPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82A18A0", Offset = "0x82A0CA0", VA = "0x1882A18A0")]
	private void FEDKCOEPHBK(int FCLMHKDGJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82A20D0", Offset = "0x82A14D0", VA = "0x1882A20D0")]
	private bool KDJGFBMMGEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8298D90", Offset = "0x8298190", VA = "0x188298D90")]
	private static int EFGBEJINING(NPLDOBIAEPA FCMKNPPFCKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24EC6C0", Offset = "0x24EBAC0", VA = "0x1824EC6C0")]
	private static ushort ODLHEFBLLAJ(int NOEININIMIL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82A1590", Offset = "0x82A0990", VA = "0x1882A1590")]
	private Bounds EJFLMDKMMNP()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82A1450", Offset = "0x82A0850", VA = "0x1882A1450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GGEJNEAJJPL
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GGEJNEAJJPL LDECEJLPLDE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float FPBHOPCAFDJ = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int DLLAGFEHNNB = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int MGAIDEMFIIN = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color EOHNJMMHFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float GHCBOIPFPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int KIIJLEGPOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int BBHGGHBINPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int CAFDCBNEIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int GLBAOODLCNE;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x829F380", Offset = "0x829E780", VA = "0x18829F380")]
	internal GGEJNEAJJPL DGPJFEDELAI()
	{
		return default(GGEJNEAJJPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82999A0", Offset = "0x8298DA0", VA = "0x1882999A0")]
	[CompilerGenerated]
	internal static void LOLODDLJFLI(int CBMEHPPMEEA, int ABINAMGBLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x829F490", Offset = "0x829E890", VA = "0x18829F490")]
	[CompilerGenerated]
	internal static void EBCPNDCGEJI(float CBMEHPPMEEA, float ABINAMGBLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8299990", Offset = "0x8298D90", VA = "0x188299990")]
	[CompilerGenerated]
	internal static void PCBFMFMOCDH(int CBMEHPPMEEA, int NNMKKFCMLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x829F4B0", Offset = "0x829E8B0", VA = "0x18829F4B0")]
	[CompilerGenerated]
	internal static void KNLKKIHEMDI(float CBMEHPPMEEA, float NNMKKFCMLGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FNGMMHPOLBN
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x829F2F0", Offset = "0x829E6F0", VA = "0x18829F2F0")]
	public static float BAPPMBMHAKP(this OAMEGBFBNKC NNMOHEBIGDE)
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
		public readonly NPLDOBIAEPA textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x82A4370", Offset = "0x82A3770", VA = "0x1882A4370")]
		public TextSegmentLayout(LayoutRect layoutRect, NPLDOBIAEPA textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x82A4140", Offset = "0x82A3540", VA = "0x1882A4140")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x82A41B0", Offset = "0x82A35B0", VA = "0x1882A41B0")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82A40E0", Offset = "0x82A34E0", VA = "0x1882A40E0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class NBDMDPNDLGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig BDOIIFJNOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float CNOGFIGOPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float MFENCBFKFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float JGOCEAGEFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float EMMJDENFHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float IGFKHKDIOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float OLJONIKOPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float KGOPBDLDHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float DBIFPIDFOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float KDDNKONNHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float JNEHDNBFOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float PDLMPJOFELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float GKCJPNKKKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MMBIDMLJELN[] FKOPAJCOCED;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int NJMJNCPMKOO = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NJELCIEFLGC[] JEJLLHMJPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int IEDLPJHMHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private EGJBLHJILBH[] HIEALLNMLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int ICHKIJOHJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public MMBIDMLJELN ABKCHIPPOFM;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x82A2CC0", Offset = "0x82A20C0", VA = "0x1882A2CC0")]
	public void IPJPKJAMFMN(NJHEOCEANPD OJFDMEDOMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82A2D50", Offset = "0x82A2150", VA = "0x1882A2D50")]
	public void IPJPKJAMFMN(GlyphUVConfig FEGNDHFFJOG, IEnumerable<EGJBLHJILBH> ODIJECMHALL, EGJBLHJILBH EDKBJJOKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x82A2B80", Offset = "0x82A1F80", VA = "0x1882A2B80")]
	internal void DAKPHMGMHNB(GlyphUVConfig FEGNDHFFJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x82A2DD0", Offset = "0x82A21D0", VA = "0x1882A2DD0")]
	private void KCOKIBFCJJP(IEnumerable<EGJBLHJILBH> ODIJECMHALL, EGJBLHJILBH EDKBJJOKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82A3310", Offset = "0x82A2710", VA = "0x1882A3310")]
	public void KFBDPHMLHJE([In] char CGDPLHKAFLO, [Out] float2[] MEOGFPCLBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x829ED20", Offset = "0x829E120", VA = "0x18829ED20")]
	private MMBIDMLJELN DFGDDALFINI(EGJBLHJILBH PBNOBIEENFN)
	{
		return default(MMBIDMLJELN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82A3640", Offset = "0x82A2A40", VA = "0x1882A3640")]
	public NBDMDPNDLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PGPFCOBJHHA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x82A3C10", Offset = "0x82A3010", VA = "0x1882A3C10")]
	public static void KGBNIFENHCI([In] float BMANIPBNHKE, [In] float IOMOJEMDOLA, [In] int GECHLBBJLCH, [In] int FDPHFDGDKDG, [In] float EMMJDENFHOB, [In] float IGFKHKDIOCB, [In] float LIBBBPACDGI, [In] float APGPMEOAJBC, [In] float HACHIGOJJKN, [In] float CIKGLLLJKFN, [Out] float HMCDNPPODLE, [Out] float KPOMBNIDEJF, [Out] float MFNNJGFEDOH, [Out] float FLHNPIIHLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x82A3BB0", Offset = "0x82A2FB0", VA = "0x1882A3BB0")]
	public static void KGBNIFENHCI([In] float BMANIPBNHKE, [In] float IOMOJEMDOLA, [In] int GECHLBBJLCH, [In] int FDPHFDGDKDG, [Out] float HMCDNPPODLE, [Out] float KPOMBNIDEJF, [Out] float MFNNJGFEDOH, [Out] float FLHNPIIHLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82A3CE0", Offset = "0x82A30E0", VA = "0x1882A3CE0")]
	public static void LOCIEJMDBOE([In] float EMMJDENFHOB, [In] float IGFKHKDIOCB, [In] float LMNPAPDNFNH, [In] float PLGAKNHOIBN, [In] float BLPGAIHJLNN, [In] float KFPGAHDIPMF, [Out] float NFMDGIPBAOK, [Out] float PGNPHPOFEHM, [Out] float HKNLPOACLCN, [Out] float KMGIBJBFBOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct NJELCIEFLGC
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint PGCHGMLBODI = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char FBJDHMNEEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly MMBIDMLJELN FPGMHJAOOOJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x82A36E0", Offset = "0x82A2AE0", VA = "0x1882A36E0")]
	public NJELCIEFLGC(char CGDPLHKAFLO, MMBIDMLJELN MEOGFPCLBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MMBIDMLJELN
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint PGCHGMLBODI = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] ENHKABHMDBC;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82A1240", Offset = "0x82A0640", VA = "0x1882A1240")]
	public MMBIDMLJELN(float HMCDNPPODLE, float KPOMBNIDEJF, float MFNNJGFEDOH, float FLHNPIIHLPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct NKGAEFHMDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int DPACILGFOLO = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal DFMPDOAHMAA EFCKHGMLFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] LIBCDNOAABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int IKPACGLHAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 MDELHDHKDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float DPLILPPFDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 JNDPBACKOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool MLEJOCHCDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int MIEGEINAIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int FENJCMCOOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int EFJNEOEEKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int AIHLDKKFCNG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82A3880", Offset = "0x82A2C80", VA = "0x1882A3880")]
	public static int JHOFNODOLHI(int BNOOMHACNIN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum DFMPDOAHMAA : byte
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
public static class DMIAJFFNAPB
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x829F230", Offset = "0x829E630", VA = "0x18829F230")]
	internal static float BAPPMBMHAKP(this NKGAEFHMDLM OAHDNKPEPGE, float ABIGDALOEDB, float ACFGJJOOJCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x829F1B0", Offset = "0x829E5B0", VA = "0x18829F1B0")]
	internal static void AEEHLMFENJA(this NKGAEFHMDLM OAHDNKPEPGE, float ABIGDALOEDB, float ACFGJJOOJCD, [Out] float2 FELPICHHHLC, [Out] float2 IDCCLFDFCEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class MFAKKIIPOAJ : PEAEKLMBLEB
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int AIKILOMKIPF = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int OLECIJENJGB = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string LNOEFJFGAON = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker PPNHIAKMPFD;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker KCHIFEGPANL;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker NGJHEMJCOJL;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker EOICEFBFFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly LEIELOBJHHC PIOAHEPFEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] FJIAHPFKEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] DMPFCJHGHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int OIPLFGKKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int FCLJLLBFDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int MLIEKJLEDEP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string HDNPPEBJPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PEAEKLMBLEB.LCFDLNMPFHL BHBNGNGEMOM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x82A1130", Offset = "0x82A0530", VA = "0x1882A1130")]
	public MFAKKIIPOAJ(LEIELOBJHHC.CEDBNOMKPOO BCGGOAABFHC, int HNAEGOEGGCC, int DGOKMPGGGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x82A0FA0", Offset = "0x82A03A0", VA = "0x1882A0FA0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] LEIELOBJHHC PIOAHEPFEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82A0F80", Offset = "0x82A0380", VA = "0x1882A0F80")]
	public void JHPNIJCGEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x82A0440", Offset = "0x829F840", VA = "0x1882A0440")]
	public void CNJGFNIDFMP(Span<NKGAEFHMDLM> BCLNMNDGFDD, NBDMDPNDLGB CDPPOHEMHOI, [In] GGEJNEAJJPL HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x829DEB0", Offset = "0x829D2B0", VA = "0x18829DEB0")]
	private void LFHIPNFPOAN([In] DFMPDOAHMAA EFCKHGMLFNC, [In] NKGAEFHMDLM CBDHMBNDHJJ, int HBHNGGJNBEG, [In] float ABIGDALOEDB, [In] float ACFGJJOOJCD, NBDMDPNDLGB CDPPOHEMHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82A0C20", Offset = "0x82A0020", VA = "0x1882A0C20")]
	private void CPMJLBOCDJP([In] DFMPDOAHMAA EFCKHGMLFNC, NKGAEFHMDLM CBDHMBNDHJJ, [In] int CMJAICFLFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x82A0D70", Offset = "0x82A0170", VA = "0x1882A0D70")]
	public static void HENDEKOPHFP(ReadOnlySpan<NKGAEFHMDLM> BCLNMNDGFDD, int HEPBLGFBJKH, [Out] int NHBDFCJOBIF, [Out] int OOIDJLMFJDE, [Out] int NCNDBPELCFN)
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
