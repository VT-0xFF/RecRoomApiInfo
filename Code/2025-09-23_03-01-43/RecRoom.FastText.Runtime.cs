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
public class GKGMHHMMGNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Texture2D GFJMFADEONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GlyphUVConfig IJKBGPPANPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public FKLELBJDGGF[] MBFHBCNBJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public FKLELBJDGGF GHKIIJJFKEF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static GKGMHHMMGNI IKDFLCKJPLE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GKGMHHMMGNI KGCHLHLOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84F4360", Offset = "0x84F2960", VA = "0x1884F4360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public GKGMHHMMGNI()
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
		[Cpp2IlInjected.Address(RVA = "0x84F4ED0", Offset = "0x84F34D0", VA = "0x1884F4ED0")]
		public GlyphUVConfig(int AKIPNGJENPF, int EEGPPBNKHFO, int GNPDADOKHLB, int MNLNKOKPLBD, float CAEOJOOHJGO = 0f, [Optional] GlyphPixelInset NBFMFKJGLAP)
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
public readonly struct FKLELBJDGGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly char KFFNLHOEHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly int LIPDELOMLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int NNIJCFNMJCP;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly FKLELBJDGGF DMFOELLKGOK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84F42A0", Offset = "0x84F28A0", VA = "0x1884F42A0")]
	public FKLELBJDGGF(char IPCFDDCFHAM, int CNAAKOAIKGN, int LDKBIOLGENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84F4280", Offset = "0x84F2880", VA = "0x1884F4280")]
	public FKLELBJDGGF(GlyphCoordinateWritable JCKGKKFLCDK)
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
		[Cpp2IlInjected.Address(RVA = "0x84F44E0", Offset = "0x84F2AE0", VA = "0x1884F44E0")]
		public static FKLELBJDGGF HNGLNPFKABH(GlyphCoordinateWritable KGDLOJHDMHI)
		{
			return default(FKLELBJDGGF);
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
		private GKGMHHMMGNI configData;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal Texture2D GlyphTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Shader Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84F4DD0", Offset = "0x84F33D0", VA = "0x1884F4DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material GlyphMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84F4C50", Offset = "0x84F3250", VA = "0x1884F4C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal IEnumerable<GlyphCoordinateWritable> GlyphCoordinates
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public char FallbackGlyph
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84F4C40", Offset = "0x84F3240", VA = "0x1884F4C40")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GKGMHHMMGNI ConfigData
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84F4630", Offset = "0x84F2C30", VA = "0x1884F4630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FKLELBJDGGF FallbackCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x84F4AB0", Offset = "0x84F30B0", VA = "0x1884F4AB0")]
			get
			{
				return default(FKLELBJDGGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84F4500", Offset = "0x84F2B00", VA = "0x1884F4500")]
		internal void CCJDDKGBNIJ(IEnumerable<GlyphCoordinateWritable> DAEIHMDFOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84F45A0", Offset = "0x84F2BA0", VA = "0x1884F45A0")]
		public GlyphMapAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84F4580", Offset = "0x84F2B80", VA = "0x1884F4580")]
		[CompilerGenerated]
		private bool ILJLAKAMBAA(GlyphCoordinateWritable KGDLOJHDMHI)
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
		private TextSegmentMeshBufferSource BBAKKHBDJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private BDNCNPMFIDD ACCAENLKNHP;

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
		private JCLBGGODNFK AOBEJHACFLD;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84F6750", Offset = "0x84F4D50", VA = "0x1884F6750")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84F6700", Offset = "0x84F4D00", VA = "0x1884F6700")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84F6520", Offset = "0x84F4B20", VA = "0x1884F6520")]
		private void FEKBJKOCKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84F6840", Offset = "0x84F4E40", VA = "0x1884F6840")]
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
		private bool PNNAGPNBENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int SubMeshPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Fast Text Config")]
		public Material TextMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Material MJLGDMIGENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BDNCNPMFIDD ACCAENLKNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Material DHPODLFNCOG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private GKGMHHMMGNI DEMKDMIILDE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x84F6EE0", Offset = "0x84F54E0", VA = "0x1884F6EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BDNCNPMFIDD OACHELJFMCH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x84F7350", Offset = "0x84F5950", VA = "0x1884F7350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Material JDHOLCHDDNG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84F7380", Offset = "0x84F5980", VA = "0x1884F7380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84F72B0", Offset = "0x84F58B0", VA = "0x1884F72B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84F6F70", Offset = "0x84F5570", VA = "0x1884F6F70", Slot = "8")]
		protected override void DPOMLOPGMNE(OEDDLEGCPCL MILFPGANEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84F72C0", Offset = "0x84F58C0", VA = "0x1884F72C0", Slot = "9")]
		public override bool TryGetMeshBuffer([Out] JINNNIHNFJI JCFBNGADOOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84F7160", Offset = "0x84F5760", VA = "0x1884F7160")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84F6BC0", Offset = "0x84F51C0", VA = "0x1884F6BC0")]
		private void APOCGBAFCNE(bool AKKFOJDOENB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAC3A10", Offset = "0xAC2010", VA = "0x180AC3A10")]
		public TextSegmentMeshBufferSource()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly ref struct LPHNCKPPFNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal readonly BDNCNPMFIDD PMAADJHGMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int MLHJLKOJOEA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84F5650", Offset = "0x84F3C50", VA = "0x1884F5650")]
	internal FADANLDMLFA KICLLNPACEC()
	{
		return default(FADANLDMLFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B41580", Offset = "0x2B3FB80", VA = "0x182B41580")]
	internal LPHNCKPPFNG(BDNCNPMFIDD IHEHADIIJNO, int MPMHLHJONKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FPFMHFFCEAA
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84F4310", Offset = "0x84F2910", VA = "0x1884F4310")]
	public static bool GPGPEOAFOLP(this LPHNCKPPFNG OKONKGPFIFL, LDEFNCPHCND BDEFEECLFKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84F42F0", Offset = "0x84F28F0", VA = "0x1884F42F0")]
	internal static bool GPGPEOAFOLP(this FADANLDMLFA IIADKLNLOPA, LDEFNCPHCND BDEFEECLFKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84F42B0", Offset = "0x84F28B0", VA = "0x1884F42B0")]
	public static float BFAGCMFHOOC(this LPHNCKPPFNG OKONKGPFIFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xB02540", Offset = "0xB00B40", VA = "0x180B02540")]
	internal static float BFAGCMFHOOC(this FADANLDMLFA IIADKLNLOPA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EJAOKGBNMJA
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84F3D80", Offset = "0x84F2380", VA = "0x1884F3D80")]
	public static void AAJENHCKKHM(this LPHNCKPPFNG OKONKGPFIFL, ReadOnlySpan<char> FIDFOHPHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84F3DD0", Offset = "0x84F23D0", VA = "0x1884F3DD0")]
	internal static void AAJENHCKKHM(this FADANLDMLFA IIADKLNLOPA, ReadOnlySpan<char> FIDFOHPHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84F3FE0", Offset = "0x84F25E0", VA = "0x1884F3FE0")]
	public static void BBBOHEKJCHF(this LPHNCKPPFNG IBAOKFDADPN, float2 LLLOPOCOHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84F3FD0", Offset = "0x84F25D0", VA = "0x1884F3FD0")]
	internal static void BBBOHEKJCHF(this FADANLDMLFA IIADKLNLOPA, float2 LLLOPOCOHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84F4170", Offset = "0x84F2770", VA = "0x1884F4170")]
	public static void PCPDHDALNOM(this LPHNCKPPFNG IBAOKFDADPN, float COBEKFBOOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84F41E0", Offset = "0x84F27E0", VA = "0x1884F41E0")]
	internal static void PCPDHDALNOM(this FADANLDMLFA IIADKLNLOPA, float COBEKFBOOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84F4080", Offset = "0x84F2680", VA = "0x1884F4080")]
	internal static void GMMDGOCNEGP(this FADANLDMLFA IIADKLNLOPA, bool HJMPMEAFKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84F4030", Offset = "0x84F2630", VA = "0x1884F4030")]
	public static void FIJOGNHJBOJ(this LPHNCKPPFNG IBAOKFDADPN, Color32 FPHNLEHIJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84F4070", Offset = "0x84F2670", VA = "0x1884F4070")]
	internal static void FIJOGNHJBOJ(this FADANLDMLFA IIADKLNLOPA, Color32 FPHNLEHIJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84F4120", Offset = "0x84F2720", VA = "0x1884F4120")]
	public static void OOPDHAJKKED(this LPHNCKPPFNG IBAOKFDADPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84F4160", Offset = "0x84F2760", VA = "0x1884F4160")]
	internal static void OOPDHAJKKED(this FADANLDMLFA IIADKLNLOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84F4090", Offset = "0x84F2690", VA = "0x1884F4090")]
	internal static void INGCEBACGNB(this FADANLDMLFA IIADKLNLOPA, int IDPMFLFLACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84F4100", Offset = "0x84F2700", VA = "0x1884F4100")]
	internal static void OJLNHDNBFOI(this FADANLDMLFA IIADKLNLOPA, int OLMHJGBHGJB, LDEFNCPHCND MEBENFDNGHL = LDEFNCPHCND.DirtyAllNoAlloc)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class JCLBGGODNFK : IEquatable<JCLBGGODNFK>
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const ushort FIMHCLBMKDH = 0;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const int KPHOMPLJIEK = 65534;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly JCLBGGODNFK OPCNKJBOGBC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ushort GAMOMNHLIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xDEB010", Offset = "0xDE9610", VA = "0x180DEB010")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xDEB020", Offset = "0xDE9620", VA = "0x180DEB020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BDNCNPMFIDD PMAADJHGMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GLJIKBGGLIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84E91A0", Offset = "0x84E77A0", VA = "0x1884E91A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84E9320", Offset = "0x84E7920", VA = "0x1884E9320")]
	public JCLBGGODNFK(int KCDFMGCPBJM, BDNCNPMFIDD IHEHADIIJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84F5430", Offset = "0x84F3A30", VA = "0x1884F5430")]
	public bool PPABCACIKFB([Out] LPHNCKPPFNG OKONKGPFIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84F52B0", Offset = "0x84F38B0", VA = "0x1884F52B0")]
	public void AMPHLDINMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84E9050", Offset = "0x84E7650", VA = "0x1884E9050")]
	internal void BGKFNMOBBHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84E9140", Offset = "0x84E7740", VA = "0x1884E9140", Slot = "4")]
	public bool Equals(JCLBGGODNFK AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84F5300", Offset = "0x84F3900", VA = "0x1884F5300", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84F53C0", Offset = "0x84F39C0", VA = "0x1884F53C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class BDNCNPMFIDD : IDisposable, AEIPIMBAAED
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const string IOEBIEKHPEP = "FastText";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static ProfilerMarker IOMMAONOHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private string JLFIMMGPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly IJMHIFEADFN MPGPNKPCHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal int AMLPJPBNADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal FADANLDMLFA[] NMKKBOGPMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal JCLBGGODNFK[] IEDEGOPBECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private GKGMHHMMGNI LACAJIKBEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CHJGPAFPJMN NKKLFODEPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly NJEANOGFACD JJCGPHDCELH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string NDIENANOGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84F1E90", Offset = "0x84F0490", VA = "0x1884F1E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public GKGMHHMMGNI NBJOKIHOBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84F2390", Offset = "0x84F0990", VA = "0x1884F2390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float KBFNIJACKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84F2710", Offset = "0x84F0D10", VA = "0x1884F2710")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float HNILEJHEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84F1E70", Offset = "0x84F0470", VA = "0x1884F1E70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AEIPIMBAAED.FADBHMDODFJ PFOBHFDAJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAA5520", Offset = "0xAA3B20", VA = "0x180AA5520", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84F2C70", Offset = "0x84F1270", VA = "0x1884F2C70")]
	public BDNCNPMFIDD(IJMHIFEADFN GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84F30B0", Offset = "0x84F16B0", VA = "0x1884F30B0")]
	public BDNCNPMFIDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84F1F20", Offset = "0x84F0520", VA = "0x1884F1F20")]
	public void HAKAIDJFGEI(GlyphMapAsset BADHKHKBFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84F1F60", Offset = "0x84F0560", VA = "0x1884F1F60")]
	public void HAKAIDJFGEI(GKGMHHMMGNI KBENEOFIFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84F29D0", Offset = "0x84F0FD0", VA = "0x1884F29D0", Slot = "6")]
	public bool TryGetMeshBuffer([Out] JINNNIHNFJI JCFBNGADOOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84F2970", Offset = "0x84F0F70", VA = "0x1884F2970")]
	public void PABKGKPOFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x84F23B0", Offset = "0x84F09B0", VA = "0x1884F23B0")]
	public bool IOPHFHHGNPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84F2070", Offset = "0x84F0670", VA = "0x1884F2070")]
	public JCLBGGODNFK HOCFGLGBFJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84F18E0", Offset = "0x84EFEE0", VA = "0x1884F18E0")]
	public void ADOCIGIEAPM(JCLBGGODNFK KHFODFFLFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84F22E0", Offset = "0x84F08E0", VA = "0x1884F22E0")]
	internal bool ICIFCIKPIMN(JCLBGGODNFK KHFODFFLFOD, [Out] LPHNCKPPFNG OKONKGPFIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84F1C40", Offset = "0x84F0240", VA = "0x1884F1C40")]
	private void DOHHNIEAENA(FADANLDMLFA IIADKLNLOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84F2790", Offset = "0x84F0D90", VA = "0x1884F2790")]
	private void OMHBKPOIHEK(int HFBCMCCHFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84F2730", Offset = "0x84F0D30", VA = "0x1884F2730")]
	private bool NDDKIFBKFPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84EF0F0", Offset = "0x84ED6F0", VA = "0x1884EF0F0")]
	private static int FNLIOHPHJGM(JCLBGGODNFK KHFODFFLFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x257EC30", Offset = "0x257D230", VA = "0x18257EC30")]
	private static ushort DJHGFFDCOOI(int PMIGBJGNLLP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84F2400", Offset = "0x84F0A00", VA = "0x1884F2400")]
	private Bounds KNDPGKOEDIE()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x84F1DC0", Offset = "0x84F03C0", VA = "0x1884F1DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IJMHIFEADFN
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IJMHIFEADFN MGHICGHFAMH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const float HBHFPIINJCK = 65535f;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int NKOMCBIKOLC = 65534;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HHEMPKIADPF = 65535;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Color DHLIMILJNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float GCGNJOLKMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int CMFDFICJDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int HEOBLIOBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public int EFPHFPKKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int AEDHMFPLMPO;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84F50B0", Offset = "0x84F36B0", VA = "0x1884F50B0")]
	internal IJMHIFEADFN JLNLKIJPNGK()
	{
		return default(IJMHIFEADFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84EBCC0", Offset = "0x84EA2C0", VA = "0x1884EBCC0")]
	[CompilerGenerated]
	internal static void HALOKILDMAO(int KOPHBHGIACG, int APJDJFMLEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84F5090", Offset = "0x84F3690", VA = "0x1884F5090")]
	[CompilerGenerated]
	internal static void JJEEAHCGBGD(float KOPHBHGIACG, float APJDJFMLEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84EBCB0", Offset = "0x84EA2B0", VA = "0x1884EBCB0")]
	[CompilerGenerated]
	internal static void IFFABGKMFBB(int KOPHBHGIACG, int FNAHBLLDBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84F51C0", Offset = "0x84F37C0", VA = "0x1884F51C0")]
	[CompilerGenerated]
	internal static void PKAKJPJIDPM(float KOPHBHGIACG, float FNAHBLLDBKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MMLFGCCOOPO
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84F5690", Offset = "0x84F3C90", VA = "0x1884F5690")]
	public static float PNBCGEHBBBI(this LPHNCKPPFNG BHIJJHKEEEH)
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
		public readonly JCLBGGODNFK textHandle;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x84F6B50", Offset = "0x84F5150", VA = "0x1884F6B50")]
		public TextSegmentLayout(LayoutRect layoutRect, JCLBGGODNFK textHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84F6920", Offset = "0x84F4F20", VA = "0x1884F6920")]
		public void SetLayoutAlignment(float textAlignment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84F6990", Offset = "0x84F4F90", VA = "0x1884F6990")]
		public bool WriteLayout()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84F68C0", Offset = "0x84F4EC0", VA = "0x1884F68C0")]
		public void Cleanup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal sealed class CHJGPAFPJMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GlyphUVConfig JGHICANAJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float PKLLIONHHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float DJGOLMFMFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float BLOOKBPJIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float IEMBCEPGDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private float NHNCALOKEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float FDHJJCOODJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float OEAEJDDMJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float NMEIBHBBOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float HBMLHCPIBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public float HNILEJHEOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float LBOIEBBEAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float KBFNIJACKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly DNMKCHFJKKD[] MGFLAEMEHOD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const int FKBMBLFELGH = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private INHAFDNNDNA[] CPDFOIHIPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int JNPDNEEHHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private FKLELBJDGGF[] MBOMHHFOIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int DBALHKMFDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public DNMKCHFJKKD AGJCBFAPLBE;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84F34E0", Offset = "0x84F1AE0", VA = "0x1884F34E0")]
	public void HAKAIDJFGEI(GKGMHHMMGNI JBEHOMBBIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84F3460", Offset = "0x84F1A60", VA = "0x1884F3460")]
	public void HAKAIDJFGEI(GlyphUVConfig FPGFJAOKAAD, IEnumerable<FKLELBJDGGF> BADHKHKBFCB, FKLELBJDGGF NFPHLDILFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84F3570", Offset = "0x84F1B70", VA = "0x1884F3570")]
	internal void JAJAEHNHPKP(GlyphUVConfig FPGFJAOKAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x84F36B0", Offset = "0x84F1CB0", VA = "0x1884F36B0")]
	private void PNJMENILADA(IEnumerable<FKLELBJDGGF> BADHKHKBFCB, FKLELBJDGGF NFPHLDILFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84F3130", Offset = "0x84F1730", VA = "0x1884F3130")]
	public void BPJLKAEFNMH([In] char IPCFDDCFHAM, [Out] float2[] NBBBLCBJIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84EFDD0", Offset = "0x84EE3D0", VA = "0x1884EFDD0")]
	private DNMKCHFJKKD IAONIMKKMBP(FKLELBJDGGF JCKGKKFLCDK)
	{
		return default(DNMKCHFJKKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84F3BF0", Offset = "0x84F21F0", VA = "0x1884F3BF0")]
	public CHJGPAFPJMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IDKBHPDLLAB
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84F4F60", Offset = "0x84F3560", VA = "0x1884F4F60")]
	public static void MMBGFKMJGGD([In] float KHMDGHMBEMJ, [In] float IHLKBMEHNEF, [In] int OKBNFLFADDE, [In] int NCHPMOJKBBJ, [In] float IEMBCEPGDOP, [In] float NHNCALOKEFK, [In] float PHNEAEAMBMI, [In] float LNFEBLHNBPF, [In] float BDCLJFLGOCL, [In] float KILNKKDONCB, [Out] float HGHGCBODKBN, [Out] float AHBJBHJJMJG, [Out] float PLELCCIEDPB, [Out] float BCLBHILMFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84F5030", Offset = "0x84F3630", VA = "0x1884F5030")]
	public static void MMBGFKMJGGD([In] float KHMDGHMBEMJ, [In] float IHLKBMEHNEF, [In] int OKBNFLFADDE, [In] int NCHPMOJKBBJ, [Out] float HGHGCBODKBN, [Out] float AHBJBHJJMJG, [Out] float PLELCCIEDPB, [Out] float BCLBHILMFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84F4F00", Offset = "0x84F3500", VA = "0x1884F4F00")]
	public static void HBHIOBDGIJH([In] float IEMBCEPGDOP, [In] float NHNCALOKEFK, [In] float GPEIHBJAPJL, [In] float NLKKLKNPBAE, [In] float KHHFLKCHJIN, [In] float NBHCBCKJMBG, [Out] float MOFODIGPJPB, [Out] float NCACMFBLHJM, [Out] float MAFGBDGIHIG, [Out] float OIGKGMPPKFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct INHAFDNNDNA
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const uint AKFMFCBOCJG = 34u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly char KFFNLHOEHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly DNMKCHFJKKD KGHHNDBHMHC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84F5290", Offset = "0x84F3890", VA = "0x1884F5290")]
	public INHAFDNNDNA(char IPCFDDCFHAM, DNMKCHFJKKD NBBBLCBJIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DNMKCHFJKKD
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public const uint AKFMFCBOCJG = 32u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float2[] KHDHFKNOHAF;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84F3C90", Offset = "0x84F2290", VA = "0x1884F3C90")]
	public DNMKCHFJKKD(float HGHGCBODKBN, float AHBJBHJJMJG, float PLELCCIEDPB, float BCLBHILMFDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal struct FADANLDMLFA
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal const int HKCEBLEIOFH = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal LDEFNCPHCND MEBENFDNGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal char[] BIHOKFIFENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal int LPCBANBELNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	internal float2 LLLOPOCOHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	internal float NFPHCMDBIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	internal Color32 BBKOBJKOODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal bool HJMPMEAFKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal int BDOBANKMFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	internal int EDBCCOFBBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	internal int CMPLEFCBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	internal int HGJJNOOEMNK;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x84F4220", Offset = "0x84F2820", VA = "0x1884F4220")]
	public static int AFPNLLKBCLP(int FINMODPIHAG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum LDEFNCPHCND : byte
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
public static class LIGBEIGENCB
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84F5610", Offset = "0x84F3C10", VA = "0x1884F5610")]
	internal static float PNBCGEHBBBI(this FADANLDMLFA IIADKLNLOPA, float GOJKAGHOODG, float OLOAPDJGCFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84F5590", Offset = "0x84F3B90", VA = "0x1884F5590")]
	internal static void HIHJIKDOKAL(this FADANLDMLFA IIADKLNLOPA, float GOJKAGHOODG, float OLOAPDJGCFF, [Out] float2 KECGAHAPFAB, [Out] float2 GAEHKCHAJDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class NJEANOGFACD : AEIPIMBAAED
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const int LHPIHOPBLEO = 65535;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const int PCPENABMHLF = 16383;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const string IOEBIEKHPEP = "TextSegmentMeshWriter";

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ProfilerMarker HAMLIKEFCBN;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static ProfilerMarker PGFCEHBHJIC;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static ProfilerMarker LPHLMLFFCCO;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static ProfilerMarker KAONAMMGDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal readonly JINNNIHNFJI JCFBNGADOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly float3[] KEKLJIKAILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private float2[] KFPLKPHIIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int BFAGNMOPPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int ENCNNEDDDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int FNJAEJCJFPG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string NDIENANOGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public AEIPIMBAAED.FADBHMDODFJ PFOBHFDAJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x84F6410", Offset = "0x84F4A10", VA = "0x1884F6410")]
	public NJEANOGFACD(JINNNIHNFJI.ECCNIFNPFBG OMPGLGNEDOA, int FDOHHMOPJCD, int KMCCLLPKGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x84F6280", Offset = "0x84F4880", VA = "0x1884F6280", Slot = "5")]
	public bool TryGetMeshBuffer([Out] JINNNIHNFJI JCFBNGADOOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84F5A80", Offset = "0x84F4080", VA = "0x1884F5A80")]
	public void LJGFJOAMEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84F5AA0", Offset = "0x84F40A0", VA = "0x1884F5AA0")]
	public void NHJEMJJOAOH(Span<FADANLDMLFA> GNIHMHKHGFA, CHJGPAFPJMN ABJHBHBKDNC, [In] IJMHIFEADFN GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84F0290", Offset = "0x84EE890", VA = "0x1884F0290")]
	private void EHDHHNDNBKB([In] LDEFNCPHCND MEBENFDNGHL, [In] FADANLDMLFA DHJOPPDHMPK, int DEMGDEDIADB, [In] float GOJKAGHOODG, [In] float OLOAPDJGCFF, CHJGPAFPJMN ABJHBHBKDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x84F5930", Offset = "0x84F3F30", VA = "0x1884F5930")]
	private void EDDDJPFKFAF([In] LDEFNCPHCND MEBENFDNGHL, FADANLDMLFA DHJOPPDHMPK, [In] int HLGLGJMLHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84F5720", Offset = "0x84F3D20", VA = "0x1884F5720")]
	public static void ADJAINCNBJB(ReadOnlySpan<FADANLDMLFA> GNIHMHKHGFA, int KGCHANKKGCL, [Out] int JLKOEKMGGKG, [Out] int LOAJOKAOHIE, [Out] int PGODFABFIPH)
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
