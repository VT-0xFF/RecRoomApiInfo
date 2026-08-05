using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using RecRoom.DataLayer;
using RecRoom.Protobuf;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class OPFYJNMMZGZ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
	public OPFYJNMMZGZ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ALYZHZEYSHB : WZQNIDDCTBT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private EJMCRQHWAQR.PhysicsMode HIXBGPTGCPZ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString HBSRPWNGEAR;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString EOGVWGOWVOU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override EJMCRQHWAQR.PhysicsMode TCLDGFHWWWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1C0", Offset = "0xA9BDC0", VA = "0x180A9D1C0", Slot = "13")]
			get
			{
				return default(EJMCRQHWAQR.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x820BCA0", Offset = "0x820A8A0", VA = "0x18820BCA0")]
		public bool IRQDXPYCUIJ(JEXJFGQTHAX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x820BD40", Offset = "0x820A940", VA = "0x18820BD40")]
		private static bool RQUTVEDKZYG(JEXJFGQTHAX a, [Out] EJMCRQHWAQR.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ALYZHZEYSHB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class UOWAXIMKILA : PVCJGWPKPHU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected JEXJFGQTHAX HIVBQTYRTXF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual JEXJFGQTHAX TBBLLJEYAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool BIVROKXYGBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x820D3E0", Offset = "0x820BFE0", VA = "0x18820D3E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool HSYWVSDEUUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x820D470", Offset = "0x820C070", VA = "0x18820D470", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool YARSHODDQSR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x820D410", Offset = "0x820C010", VA = "0x18820D410", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool OOQVEOTNGSB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x820D3B0", Offset = "0x820BFB0", VA = "0x18820D3B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool XUAXVVHPFFY
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x820D440", Offset = "0x820C040", VA = "0x18820D440", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public UOWAXIMKILA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BWBHYOYCFAN : XVJCMVWNXQH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper HIVBQTYRTXF;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x820C750", Offset = "0x820B350", VA = "0x18820C750")]
		public BWBHYOYCFAN(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x820C170", Offset = "0x820AD70", VA = "0x18820C170", Slot = "4")]
		public bool HWOQEVBOQYM(EJMCRQHWAQR a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x820C290", Offset = "0x820AE90", VA = "0x18820C290", Slot = "5")]
		public bool IICEMUPXXFJ(EJMCRQHWAQR a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x820C5A0", Offset = "0x820B1A0", VA = "0x18820C5A0", Slot = "6")]
		public bool ULWVAEHRLUO(RZEZLSFPPWR a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x820C530", Offset = "0x820B130", VA = "0x18820C530")]
		private IReadOnlyList<JEXJFGQTHAX> SFJQFLJSRRH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x820C3F0", Offset = "0x820AFF0", VA = "0x18820C3F0")]
		private bool OVIJVGQRPUX(int a, [Out][NotNullWhen(true)] JEXJFGQTHAX containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class TVPGCGJQCHG : WZQNIDDCTBT, HFMVYTSFXLS, EJMCRQHWAQR, PVCJGWPKPHU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<XEKBSBZPVSI> XHLPIKPQNAV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override JEXJFGQTHAX TBBLLJEYAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x820D350", Offset = "0x820BF50", VA = "0x18820D350", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override EJMCRQHWAQR.PhysicsMode TCLDGFHWWWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x820D1C0", Offset = "0x820BDC0", VA = "0x18820D1C0", Slot = "13")]
			get
			{
				return default(EJMCRQHWAQR.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int GXQLIXOTEAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x820D310", Offset = "0x820BF10", VA = "0x18820D310", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x820D1F0", Offset = "0x820BDF0", VA = "0x18820D1F0", Slot = "15")]
		public void LXZPRDIZFDY(MFOMITMLGUN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public TVPGCGJQCHG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class WZQNIDDCTBT : UOWAXIMKILA, EJMCRQHWAQR, PVCJGWPKPHU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract EJMCRQHWAQR.PhysicsMode TCLDGFHWWWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NCBOTMJKZHE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x820D4A0", Offset = "0x820C0A0", VA = "0x18820D4A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FWHBKTMGBAB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x820D4E0", Offset = "0x820C0E0", VA = "0x18820D4E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool UTSQMEJKKYR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x820D510", Offset = "0x820C110", VA = "0x18820D510", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected WZQNIDDCTBT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class LWUOJMINAXT : MFOMITMLGUN, GPUEKTZZKCV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private XEKBSBZPVSI HIVBQTYRTXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<ZBJXSUDBVLU> UTZIURBUMWI;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public XEKBSBZPVSI TBBLLJEYAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x820D140", Offset = "0x820BD40", VA = "0x18820D140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DXFSDYJVNAW
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x820CE40", Offset = "0x820BA40", VA = "0x18820CE40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType FDZXDJWFESM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x24C9EB0", Offset = "0x24C8AB0", VA = "0x1824C9EB0", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GPUEKTZZKCV JFGBMXNSHJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x820CED0", Offset = "0x820BAD0", VA = "0x18820CED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 PWGDLGZEIQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x820CE60", Offset = "0x820BA60", VA = "0x18820CE60", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion AWDLCCGDDQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x820CF70", Offset = "0x820BB70", VA = "0x18820CF70", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 JWUOPNQQOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x820CFD0", Offset = "0x820BBD0", VA = "0x18820CFD0", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial ZZRIAUJAGUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2FEE7E0", Offset = "0x2FED3E0", VA = "0x182FEE7E0", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor FJMIRNGGFGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x102EEE0", Offset = "0x102DAE0", VA = "0x18102EEE0", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float EOMSKGXLXMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x820CAA0", Offset = "0x820B6A0", VA = "0x18820CAA0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 AMZTYAZKKYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x820CAC0", Offset = "0x820B6C0", VA = "0x18820CAC0", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float UEVCGXHGPZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x820D1A0", Offset = "0x820BDA0", VA = "0x18820D1A0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags TWKJDAMGDEI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x59185A0", Offset = "0x59171A0", VA = "0x1859185A0", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int TCKSLMMZLVK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x820CF30", Offset = "0x820BB30", VA = "0x18820CF30", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool CVNSFFXAYYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x820CE10", Offset = "0x820BA10", VA = "0x18820CE10", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool NBQPOQNXRWP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x820CD80", Offset = "0x820B980", VA = "0x18820CD80", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float WNZWFQJXXVS
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x820CB30", Offset = "0x820B730", VA = "0x18820CB30", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool ROCPEOPPHDR
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x820CF10", Offset = "0x820BB10", VA = "0x18820CF10", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int ETONUJFPQWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x820CDB0", Offset = "0x820B9B0", VA = "0x18820CDB0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x820CB90", Offset = "0x820B790", VA = "0x18820CB90", Slot = "22")]
		public void EXLDXZOUZWN(MRJZJNVGZUF a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public LWUOJMINAXT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class KBDKESBJQCN : MRJZJNVGZUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (ZBJXSUDBVLU curr, ZBJXSUDBVLU next, ShapeConfigFlags flags) HIVBQTYRTXF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (ZBJXSUDBVLU curr, ZBJXSUDBVLU next, ShapeConfigFlags flags) TBBLLJEYAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x588EED0", Offset = "0x588DAD0", VA = "0x18588EED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 JTXETNBCQZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x820C7D0", Offset = "0x820B3D0", VA = "0x18820C7D0", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 CEUGJPMHKXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x820C7A0", Offset = "0x820B3A0", VA = "0x18820C7A0", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x820C840", Offset = "0x820B440", VA = "0x18820C840", Slot = "6")]
		public quaternion PZMGPAXYBOC(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public KBDKESBJQCN()
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
