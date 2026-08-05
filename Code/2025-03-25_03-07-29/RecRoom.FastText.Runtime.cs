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
public class EECPOLBOOCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D DHLGJKKKBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig GFDLHHIKPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public BKECNCFAEFH[] BGAFCIPJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public BKECNCFAEFH ANODABMKPNE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static EECPOLBOOCK GJBJPAKKLKL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EECPOLBOOCK MMGIGKEFDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x780BE40", Offset = "0x780B240", VA = "0x18780BE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public EECPOLBOOCK()
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
		[Cpp2IlInjected.Address(RVA = "0x780D590", Offset = "0x780C990", VA = "0x18780D590")]
		public GlyphUVConfig(int IFGBNPEBOMF, int DGMDDDIAFDG, int NODBPLFPIOL, int LGMKMPEDJBK, float OFLKAKJOPEJ = 0f, [Optional] GlyphPixelInset DMMHAJAPJBC)
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
public readonly struct BKECNCFAEFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char FNGDIEEHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int DNCBPAIJDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int OAPMPBIBGBL;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly BKECNCFAEFH EPEIKNCNOGK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x780AE20", Offset = "0x780A220", VA = "0x18780AE20")]
	public BKECNCFAEFH(char NNCHNIEDOKN, int FBIOKIEGPNI, int FABJNLKGFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x780AE00", Offset = "0x780A200", VA = "0x18780AE00")]
	public BKECNCFAEFH(GlyphCoordinateWritable FNGEOGHAMCD)
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
		[Cpp2IlInjected.Address(RVA = "0x780CBB0", Offset = "0x780BFB0", VA = "0x18780CBB0")]
		public static BKECNCFAEFH MDKCMNAEKLA(GlyphCoordinateWritable AMLIHKJCCAK)
		{
			return default(BKECNCFAEFH);
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
		private EECPOLBOOCK configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x780D490", Offset = "0x780C890", VA = "0x18780D490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x780D310", Offset = "0x780C710", VA = "0x18780D310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992790", VA = "0x180993390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x780D300", Offset = "0x780C700", VA = "0x18780D300")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public EECPOLBOOCK ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x780CD00", Offset = "0x780C100", VA = "0x18780CD00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BKECNCFAEFH FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x780D170", Offset = "0x780C570", VA = "0x18780D170")]
			get
			{
				return default(BKECNCFAEFH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x780CBF0", Offset = "0x780BFF0", VA = "0x18780CBF0")]
		internal void KJJPNEHJAID(IEnumerable<GlyphCoordinateWritable> NBDJEABIFEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x780CC70", Offset = "0x780C070", VA = "0x18780CC70")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x780CBD0", Offset = "0x780BFD0", VA = "0x18780CBD0")]
		[CompilerGenerated]
		private bool IFKDCJNGMED(GlyphCoordinateWritable AMLIHKJCCAK)
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
		private TextSegmentMeshBufferSource DOKBHFLLFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private LFLIAJMKKCF GKPHBGOKHLJ;

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
		private PHEPGIGIBNK MIFIGDBAJAI;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x780FD30", Offset = "0x780F130", VA = "0x18780FD30")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x780FCE0", Offset = "0x780F0E0", VA = "0x18780FCE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x780FB00", Offset = "0x780EF00", VA = "0x18780FB00")]
		private void GIAJDHGLACL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x780FE20", Offset = "0x780F220", VA = "0x18780FE20")]
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
		private bool KBOEPOCCKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material MOFDONIOAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private LFLIAJMKKCF GKPHBGOKHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material BCIGGKNBBAD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private EECPOLBOOCK BJHJICNEJHG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7810390", Offset = "0x780F790", VA = "0x187810390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LFLIAJMKKCF FHLNGFGKPOK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7810930", Offset = "0x780FD30", VA = "0x187810930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material FCEEPBHEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7810960", Offset = "0x780FD60", VA = "0x187810960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7810890", Offset = "0x780FC90", VA = "0x187810890")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78101A0", Offset = "0x780F5A0", VA = "0x1878101A0", Slot = "8")]
		protected override void KNBPNKHKMMP(AGFGCDANDBI EGGMDMFIMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78108A0", Offset = "0x780FCA0", VA = "0x1878108A0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] FFNMHJHNNJN NGCNOOEEGHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7810740", Offset = "0x780FB40", VA = "0x187810740")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7810420", Offset = "0x780F820", VA = "0x187810420")]
		private void MEMDGOFHFLN(bool HEGINIGEJIB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2C0", Offset = "0x9AD6C0", VA = "0x1809AE2C0")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct NNDKENNKIJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly LFLIAJMKKCF PCMAAHCHACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int DFOEAKAIDAO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x780F7E0", Offset = "0x780EBE0", VA = "0x18780F7E0")]
	internal AJAGPHOMBCA CHEKGCNHIIE()
	{
		return default(AJAGPHOMBCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26392F0", Offset = "0x26386F0", VA = "0x1826392F0")]
	internal NNDKENNKIJM(LFLIAJMKKCF ECPDNOJCJEA, int NHBHCMLNPJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GLBPJDONGDD
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x780CB20", Offset = "0x780BF20", VA = "0x18780CB20")]
	public static bool CAIDKAMNHNN(this NNDKENNKIJM CEMBNABNOIL, PIKIFEFFAGF EGAOGIJPDJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x780CB00", Offset = "0x780BF00", VA = "0x18780CB00")]
	internal static bool CAIDKAMNHNN(this AJAGPHOMBCA MDGPOPLHHAB, PIKIFEFFAGF EGAOGIJPDJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x780CB70", Offset = "0x780BF70", VA = "0x18780CB70")]
	public static float MICHFOFJPJP(this NNDKENNKIJM CEMBNABNOIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC80DD0", Offset = "0xC801D0", VA = "0x180C80DD0")]
	internal static float MICHFOFJPJP(this AJAGPHOMBCA MDGPOPLHHAB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IAMGNNEHPJN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x780D620", Offset = "0x780CA20", VA = "0x18780D620")]
	public static void EMCDDMEBIFN(this NNDKENNKIJM CEMBNABNOIL, ReadOnlySpan<char> IAGCMGDDMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x780D670", Offset = "0x780CA70", VA = "0x18780D670")]
	internal static void EMCDDMEBIFN(this AJAGPHOMBCA MDGPOPLHHAB, ReadOnlySpan<char> IAGCMGDDMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x780D9F0", Offset = "0x780CDF0", VA = "0x18780D9F0")]
	public static void NMLENPAPKHA(this NNDKENNKIJM HIAMJPOFDGG, float2 HIPBDJDGPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x780D9E0", Offset = "0x780CDE0", VA = "0x18780D9E0")]
	internal static void NMLENPAPKHA(this AJAGPHOMBCA MDGPOPLHHAB, float2 HIPBDJDGPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x780D870", Offset = "0x780CC70", VA = "0x18780D870")]
	public static void EMOKMHPHNDG(this NNDKENNKIJM HIAMJPOFDGG, float AHLAJHFBHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x780D8E0", Offset = "0x780CCE0", VA = "0x18780D8E0")]
	internal static void EMOKMHPHNDG(this AJAGPHOMBCA MDGPOPLHHAB, float AHLAJHFBHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x780D5C0", Offset = "0x780C9C0", VA = "0x18780D5C0")]
	internal static void EHALIFOHFHG(this AJAGPHOMBCA MDGPOPLHHAB, bool NPAFJBBBPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x780D990", Offset = "0x780CD90", VA = "0x18780D990")]
	public static void HJILODOODPL(this NNDKENNKIJM HIAMJPOFDGG, Color32 CKANMCILFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x780D9D0", Offset = "0x780CDD0", VA = "0x18780D9D0")]
	internal static void HJILODOODPL(this AJAGPHOMBCA MDGPOPLHHAB, Color32 CKANMCILFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x780D5D0", Offset = "0x780C9D0", VA = "0x18780D5D0")]
	public static void EKKPJGNEBDC(this NNDKENNKIJM HIAMJPOFDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x780D610", Offset = "0x780CA10", VA = "0x18780D610")]
	internal static void EKKPJGNEBDC(this AJAGPHOMBCA MDGPOPLHHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x780D920", Offset = "0x780CD20", VA = "0x18780D920")]
	internal static void HDFGDPDIADD(this AJAGPHOMBCA MDGPOPLHHAB, int CPDKIAENLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x780DA40", Offset = "0x780CE40", VA = "0x18780DA40")]
	internal static void OLOBEDDJLEJ(this AJAGPHOMBCA MDGPOPLHHAB, int NOIENCHKCFF, PIKIFEFFAGF BFMGFIDJNJO = PIKIFEFFAGF.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class PHEPGIGIBNK : IEquatable<PHEPGIGIBNK>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort FKCLIGNINMK = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int LDGOHINGIKF = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly PHEPGIGIBNK HCBBFIJCJBM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort PKFHPFFFDIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB8F780", Offset = "0xB8EB80", VA = "0x180B8F780")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB8F790", Offset = "0xB8EB90", VA = "0x180B8F790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LFLIAJMKKCF PCMAAHCHACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MLDGJAOBMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7808B40", Offset = "0x7807F40", VA = "0x187808B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7808C80", Offset = "0x7808080", VA = "0x187808C80")]
	public PHEPGIGIBNK(int BDAOABDOAKO, LFLIAJMKKCF ECPDNOJCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x780F820", Offset = "0x780EC20", VA = "0x18780F820")]
	public bool ENOIPALANBH([Out] NNDKENNKIJM CEMBNABNOIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x780FA20", Offset = "0x780EE20", VA = "0x18780FA20")]
	public void ICCKCAPBKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7808B50", Offset = "0x7807F50", VA = "0x187808B50")]
	internal void LBHDLHNOPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7808A20", Offset = "0x7807E20", VA = "0x187808A20", Slot = "4")]
	public bool Equals(PHEPGIGIBNK JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x780F8F0", Offset = "0x780ECF0", VA = "0x18780F8F0", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x780F9B0", Offset = "0x780EDB0", VA = "0x18780F9B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class LFLIAJMKKCF : IDisposable, PLCIAIJPKJC
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string MIBBFEHANBC = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker NMNAAMCLBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string GAACKKHLLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly INDMFOKMPLN FJJKAGFFJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int HDFHGGOFELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal AJAGPHOMBCA[] KANMHCHBCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal PHEPGIGIBNK[] FMJJBAAKLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EECPOLBOOCK CECPGMNKPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly EGLEMBJIOBL CHCMHOPPNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly DOOLOAOHJEE PBBEKHDKEGH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string MPGDCPPMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x780E9F0", Offset = "0x780DDF0", VA = "0x18780E9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public EECPOLBOOCK MCGHEMFNHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x780DEE0", Offset = "0x780D2E0", VA = "0x18780DEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float DOPMOKHMOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x780E4D0", Offset = "0x780D8D0", VA = "0x18780E4D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float NLODINOIAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x780E9D0", Offset = "0x780DDD0", VA = "0x18780E9D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PLCIAIJPKJC.JHKAELGLEOL HDDFALOEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x993540", Offset = "0x992940", VA = "0x180993540", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9932B0", Offset = "0x9926B0", VA = "0x1809932B0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x780F310", Offset = "0x780E710", VA = "0x18780F310")]
	public LFLIAJMKKCF(INDMFOKMPLN EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x780F290", Offset = "0x780E690", VA = "0x18780F290")]
	public LFLIAJMKKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x780E010", Offset = "0x780D410", VA = "0x18780E010")]
	public void AEJOPFDILPE(GlyphMapAsset KAIHDMFJEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x780DF00", Offset = "0x780D300", VA = "0x18780DF00")]
	public void AEJOPFDILPE(EECPOLBOOCK NIIKKCABFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x780EFC0", Offset = "0x780E3C0", VA = "0x18780EFC0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] FFNMHJHNNJN NGCNOOEEGHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x780E050", Offset = "0x780D450", VA = "0x18780E050")]
	public void AHBLMNKJOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x780EC60", Offset = "0x780E060", VA = "0x18780EC60")]
	public bool KNDNHEJIBFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x780ECB0", Offset = "0x780E0B0", VA = "0x18780ECB0")]
	public PHEPGIGIBNK OMPHCHLJEJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x780E4F0", Offset = "0x780D8F0", VA = "0x18780E4F0")]
	public void FMJKHCNKIGD(PHEPGIGIBNK DPONILEDPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x780EF10", Offset = "0x780E310", VA = "0x18780EF10")]
	internal bool OPEBHOKCLGD(PHEPGIGIBNK DPONILEDPBE, [Out] NNDKENNKIJM CEMBNABNOIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x780E850", Offset = "0x780DC50", VA = "0x18780E850")]
	private void GAOAGIFFJOA(AJAGPHOMBCA MDGPOPLHHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x780EA80", Offset = "0x780DE80", VA = "0x18780EA80")]
	private void KKKFEAFIMEO(int ILAEPCDGECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x780E0B0", Offset = "0x780D4B0", VA = "0x18780E0B0")]
	private bool CMPHPALLAJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7803870", Offset = "0x7802C70", VA = "0x187803870")]
	private static int ALCGPKMNDDP(PHEPGIGIBNK DPONILEDPBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F97580", Offset = "0x1F96980", VA = "0x181F97580")]
	private static ushort CFBHNIGCNEN(int KDCAMOIGIMA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x780E1C0", Offset = "0x780D5C0", VA = "0x18780E1C0")]
	private Bounds FFNJLFDLENN()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x780E110", Offset = "0x780D510", VA = "0x18780E110", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct INDMFOKMPLN
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly INDMFOKMPLN LCBEPLHIMEO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float HMFNCIJALBK = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int DBEJDPDJKJA = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int ALJBNCPAICK = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color CMCKEHACPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float OGIIEFIHFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int JABPMOEGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int KBNCJLPJPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int PLOINIPCMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int MPFHJOKBECJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x780DA60", Offset = "0x780CE60", VA = "0x18780DA60")]
	internal INDMFOKMPLN EKALJMIBBIE()
	{
		return default(INDMFOKMPLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x78027E0", Offset = "0x7801BE0", VA = "0x1878027E0")]
	[CompilerGenerated]
	internal static void GMKEFGHALFK(int FIIKLGCIAGG, int MBADHELIPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x780DB90", Offset = "0x780CF90", VA = "0x18780DB90")]
	[CompilerGenerated]
	internal static void OPONHMFBJNJ(float FIIKLGCIAGG, float MBADHELIPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x78027F0", Offset = "0x7801BF0", VA = "0x1878027F0")]
	[CompilerGenerated]
	internal static void DNBHHEIPGIM(int FIIKLGCIAGG, int CLKPAJGLJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x780DB70", Offset = "0x780CF70", VA = "0x18780DB70")]
	[CompilerGenerated]
	internal static void ODFNONFEFDL(float FIIKLGCIAGG, float CLKPAJGLJDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NIHKJPIIADP
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x780F750", Offset = "0x780EB50", VA = "0x18780F750")]
	public static float NAGDBPIBNHA(this NNDKENNKIJM JDPGEKGLPMB)
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
		public readonly PHEPGIGIBNK textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7810130", Offset = "0x780F530", VA = "0x187810130")]
		public TextSegmentLayout(LayoutRect layoutRect, PHEPGIGIBNK textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x780FF00", Offset = "0x780F300", VA = "0x18780FF00")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x780FF70", Offset = "0x780F370", VA = "0x18780FF70")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x780FEA0", Offset = "0x780F2A0", VA = "0x18780FEA0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class EGLEMBJIOBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig NAMMILOHHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float AJFHOHGGOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float HKBBBKJCGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float BGALPHNAJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float FJPPLGBIMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float AEHBJPHJHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float KBHOJEMEEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float JFCDBAPFLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float GCKPPLHKHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float PMNBPGMGDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float NLODINOIAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float CAMAAJAPKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float DOPMOKHMOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly KOGIEACFPDJ[] BCHIJDGOEOI;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int KGFPIHMLGNN = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private DDDOIEBANPA[] OFCCAFINMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int IBLJOABDFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private BKECNCFAEFH[] OJELILIEIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int ECJKCAEHNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public KOGIEACFPDJ JEPMJNHNLPI;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x780BFB0", Offset = "0x780B3B0", VA = "0x18780BFB0")]
	public void AEJOPFDILPE(EECPOLBOOCK IOABPGNJMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x780C040", Offset = "0x780B440", VA = "0x18780C040")]
	public void AEJOPFDILPE(GlyphUVConfig KMBLKGJCIGO, IEnumerable<BKECNCFAEFH> KAIHDMFJEEH, BKECNCFAEFH DLJBGDFKODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x780C0C0", Offset = "0x780B4C0", VA = "0x18780C0C0")]
	internal void AGDGNKLCNAK(GlyphUVConfig KMBLKGJCIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x780C530", Offset = "0x780B930", VA = "0x18780C530")]
	private void OHHLHPEADIN(IEnumerable<BKECNCFAEFH> KAIHDMFJEEH, BKECNCFAEFH DLJBGDFKODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x780C200", Offset = "0x780B600", VA = "0x18780C200")]
	public void LINFFPAMJJH([In] char NNCHNIEDOKN, [Out] float2[] IENNICHJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x780A9C0", Offset = "0x7809DC0", VA = "0x18780A9C0")]
	private KOGIEACFPDJ OOAJDADOHFB(BKECNCFAEFH FNGEOGHAMCD)
	{
		return default(KOGIEACFPDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x780CA60", Offset = "0x780BE60", VA = "0x18780CA60")]
	public EGLEMBJIOBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KPAPEOJHKJE
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x780DDB0", Offset = "0x780D1B0", VA = "0x18780DDB0")]
	public static void EBLDICPNCPJ([In] float LLLPNBDCNHP, [In] float PJIBFNIJLCP, [In] int DAGDGMBFBMK, [In] int HMFGDHMEGGG, [In] float FJPPLGBIMPI, [In] float AEHBJPHJHCH, [In] float JDHEIPACELK, [In] float JEHHJKFBAOD, [In] float ANBKJICCEMF, [In] float GLJALABNEJD, [Out] float DDGBBEBJEAF, [Out] float MIODGBGNFAO, [Out] float BPKJNGAHEIE, [Out] float CMGMJMCPMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x780DE80", Offset = "0x780D280", VA = "0x18780DE80")]
	public static void EBLDICPNCPJ([In] float LLLPNBDCNHP, [In] float PJIBFNIJLCP, [In] int DAGDGMBFBMK, [In] int HMFGDHMEGGG, [Out] float DDGBBEBJEAF, [Out] float MIODGBGNFAO, [Out] float BPKJNGAHEIE, [Out] float CMGMJMCPMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x780DD50", Offset = "0x780D150", VA = "0x18780DD50")]
	public static void ADMAGMBCKNA([In] float FJPPLGBIMPI, [In] float AEHBJPHJHCH, [In] float ILMBKJOFKCG, [In] float HFMGGEOLGPH, [In] float FPBHGDDCOAE, [In] float FKHNDAMIIAK, [Out] float PLKJCMCBMDN, [Out] float DHKLPMJADMP, [Out] float MGENLCJEJHP, [Out] float MBEHADGJNMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct DDDOIEBANPA
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint GAFOPLNLCAH = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char FNGDIEEHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly KOGIEACFPDJ MLBLCPLPGJK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x780AE30", Offset = "0x780A230", VA = "0x18780AE30")]
	public DDDOIEBANPA(char NNCHNIEDOKN, KOGIEACFPDJ IENNICHJHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KOGIEACFPDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint GAFOPLNLCAH = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] MHMFGCBJGKL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x780DC60", Offset = "0x780D060", VA = "0x18780DC60")]
	public KOGIEACFPDJ(float DDGBBEBJEAF, float MIODGBGNFAO, float BPKJNGAHEIE, float CMGMJMCPMCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct AJAGPHOMBCA
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int FAADJMOKLGJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal PIKIFEFFAGF BFMGFIDJNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] LDGAIDBIEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int CCIEAODMNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 HIPBDJDGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float BHPPLIHFEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 LEIMBHKPEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool NPAFJBBBPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int HHNDPAEECMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int OMDBBPAPLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int BOPAIJOIKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int EHDNEIMOHLN;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x780ADA0", Offset = "0x780A1A0", VA = "0x18780ADA0")]
	public static int JPCBEBGGALJ(int LNIDLCOKOPF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum PIKIFEFFAGF : byte
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
public static class DDLMFDPJPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x780AED0", Offset = "0x780A2D0", VA = "0x18780AED0")]
	internal static float NAGDBPIBNHA(this AJAGPHOMBCA MDGPOPLHHAB, float FANPKFPBLJG, float MAPGJAJHFJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x780AE50", Offset = "0x780A250", VA = "0x18780AE50")]
	internal static void EDLHENGBGMM(this AJAGPHOMBCA MDGPOPLHHAB, float FANPKFPBLJG, float MAPGJAJHFJF, [Out] float2 IPECBHNLFPB, [Out] float2 HJCBHKAGEBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class DOOLOAOHJEE : PLCIAIJPKJC
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int NFMKAIALJJI = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int LCHNJGJCLLA = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string MIBBFEHANBC = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker DLAOMGJICIL;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker JNDPGFKABAA;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker HNKNKNBGHBB;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker BDMKHAMMAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly FFNMHJHNNJN NGCNOOEEGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] HMMEHDNEINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] IHAGDEIKEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int ACAELGKHADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int NLDMFLNKBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int FNGHEJIAOOP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string MPGDCPPMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PLCIAIJPKJC.JHKAELGLEOL HDDFALOEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x780BD30", Offset = "0x780B130", VA = "0x18780BD30")]
	public DOOLOAOHJEE(FFNMHJHNNJN.KOIFLCDCEKF PMKPIDEJKKJ, int NHGGEOCEKJB, int HNFIGFGJGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x780BBB0", Offset = "0x780AFB0", VA = "0x18780BBB0", Slot = "5")]
	public bool TryGetMeshBuffer([Out] FFNMHJHNNJN NGCNOOEEGHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x780BB90", Offset = "0x780AF90", VA = "0x18780BB90")]
	public void NGPIPEKCLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x780B060", Offset = "0x780A460", VA = "0x18780B060")]
	public void MLJCBICEDHE(Span<AJAGPHOMBCA> DCIDNCOAAGK, EGLEMBJIOBL JKIGBMEKNEI, [In] INDMFOKMPLN EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7808CF0", Offset = "0x78080F0", VA = "0x187808CF0")]
	private void BOIGKGHAFML([In] PIKIFEFFAGF BFMGFIDJNJO, [In] AJAGPHOMBCA GLCLFKFLDHF, int EGCJEMNODLJ, [In] float FANPKFPBLJG, [In] float MAPGJAJHFJF, EGLEMBJIOBL JKIGBMEKNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x780AF10", Offset = "0x780A310", VA = "0x18780AF10")]
	private void MIOGFLAPCOM([In] PIKIFEFFAGF BFMGFIDJNJO, AJAGPHOMBCA GLCLFKFLDHF, [In] int EFJEAKMBDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x780B960", Offset = "0x780AD60", VA = "0x18780B960")]
	public static void NBPDLOIELOH(ReadOnlySpan<AJAGPHOMBCA> DCIDNCOAAGK, int NMEAHCCJAJE, [Out] int DBFJHGEIGBD, [Out] int JEEPPPHPMCA, [Out] int NNMDCKIPBCG)
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
