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
internal class UFSCIDMSTJW
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
	[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
	public UFSCIDMSTJW()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class XTUUXSFKLEC : QDYCPGWKCZI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private RPREGJMJXHC.PhysicsMode PIPKWQYRROI;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString XWNFMGKGBRE;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString DQCNIOICEUB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override RPREGJMJXHC.PhysicsMode KEAJXJQCNHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "13")]
			get
			{
				return default(RPREGJMJXHC.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x99F9600", Offset = "0x99F8600", VA = "0x1899F9600")]
		public bool DJYUQCOOODQ(RWNYJETRKPC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99F96A0", Offset = "0x99F86A0", VA = "0x1899F96A0")]
		private static bool HNUGYYCFYAF(RWNYJETRKPC a, [Out] RPREGJMJXHC.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public XTUUXSFKLEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JSGAYVUVYWB : DZGYZTSJJCR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected RWNYJETRKPC KMBDDVIDAVU;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual RWNYJETRKPC YTUTJGBWUDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool QKJYISQUGFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x99F9300", Offset = "0x99F8300", VA = "0x1899F9300", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool WTNLUYEYMXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x99F9270", Offset = "0x99F8270", VA = "0x1899F9270", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ONEPRHUMATC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x99F92A0", Offset = "0x99F82A0", VA = "0x1899F92A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PAYXEQRGCDY
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99F9330", Offset = "0x99F8330", VA = "0x1899F9330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool VBMQWSBKWDR
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x99F92D0", Offset = "0x99F82D0", VA = "0x1899F92D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public JSGAYVUVYWB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ZDFDKFAOSKC : TQHVUJAUGMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper KMBDDVIDAVU;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99FA090", Offset = "0x99F9090", VA = "0x1899FA090")]
		public ZDFDKFAOSKC(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99F9DC0", Offset = "0x99F8DC0", VA = "0x1899F9DC0", Slot = "4")]
		public bool NAZVIRUAVXH(RPREGJMJXHC a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99F9B30", Offset = "0x99F8B30", VA = "0x1899F9B30", Slot = "5")]
		public bool HDJJKPSXYQY(RPREGJMJXHC a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99F9EE0", Offset = "0x99F8EE0", VA = "0x1899F9EE0", Slot = "6")]
		public bool WGWIRJPBQOF(YWUKULOOTNO a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99F9AC0", Offset = "0x99F8AC0", VA = "0x1899F9AC0")]
		private IReadOnlyList<RWNYJETRKPC> DYISCOIVNGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99F9C90", Offset = "0x99F8C90", VA = "0x1899F9C90")]
		private bool LRARQRVRBTC(int a, [Out][NotNullWhen(true)] RWNYJETRKPC containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class WLAYMRUOTXR : QDYCPGWKCZI, JPCYJBDYUQH, RPREGJMJXHC, DZGYZTSJJCR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<CQJPULRVYVZ> CMHBQIAORKQ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override RWNYJETRKPC YTUTJGBWUDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x99F9400", Offset = "0x99F8400", VA = "0x1899F9400", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override RPREGJMJXHC.PhysicsMode KEAJXJQCNHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x99F95D0", Offset = "0x99F85D0", VA = "0x1899F95D0", Slot = "13")]
			get
			{
				return default(RPREGJMJXHC.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int HVGWADOCGLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x99F9460", Offset = "0x99F8460", VA = "0x1899F9460", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99F94A0", Offset = "0x99F84A0", VA = "0x1899F94A0", Slot = "15")]
		public void LDVCSXHWLXV(JVMBPIXUSIQ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public WLAYMRUOTXR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class QDYCPGWKCZI : JSGAYVUVYWB, RPREGJMJXHC, DZGYZTSJJCR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract RPREGJMJXHC.PhysicsMode KEAJXJQCNHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool ARSENADBUNV
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x99F93C0", Offset = "0x99F83C0", VA = "0x1899F93C0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool XUMPPNRBFHC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x99F9360", Offset = "0x99F8360", VA = "0x1899F9360", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ETTCTXIVTPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x99F9390", Offset = "0x99F8390", VA = "0x1899F9390", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected QDYCPGWKCZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class JDWTTSIPYOM : JVMBPIXUSIQ, HQBSCOZZWDU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private CQJPULRVYVZ KMBDDVIDAVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<UDWGCJFTWNB> LZYMLSEKWWF;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CQJPULRVYVZ YTUTJGBWUDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x99F8D40", Offset = "0x99F7D40", VA = "0x1899F8D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool SISPRMNZPZV
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x99F9130", Offset = "0x99F8130", VA = "0x1899F9130", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType WIFVAIUROOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x28396E0", Offset = "0x28386E0", VA = "0x1828396E0", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HQBSCOZZWDU QPNSNQWCADZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x99F9230", Offset = "0x99F8230", VA = "0x1899F9230", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 PJXFWPNRWXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x99F90A0", Offset = "0x99F80A0", VA = "0x1899F90A0", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion CDENTUISUSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x99F9150", Offset = "0x99F8150", VA = "0x1899F9150", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 ZNEFDMSKVKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99F8B50", Offset = "0x99F7B50", VA = "0x1899F8B50", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial PPDPXHUEIBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x32BA160", Offset = "0x32B9160", VA = "0x1832BA160", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor OCTDXXQMYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x131E6D0", Offset = "0x131D6D0", VA = "0x18131E6D0", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float KNIIVJGNRKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x99F9110", Offset = "0x99F8110", VA = "0x1899F9110", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 CFWJYKBGYPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x99F9000", Offset = "0x99F8000", VA = "0x1899F9000", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PDMFIEEJINQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x99F8CC0", Offset = "0x99F7CC0", VA = "0x1899F8CC0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags PBJVUTHFVIP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x662A210", Offset = "0x6629210", VA = "0x18662A210", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int KLEVGSLEVHP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x99F8FC0", Offset = "0x99F7FC0", VA = "0x1899F8FC0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool ZHNHBOZFQCB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x99F9070", Offset = "0x99F8070", VA = "0x1899F9070", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool UQMTKDVBHPY
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x99F8F90", Offset = "0x99F7F90", VA = "0x1899F8F90", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float XSBXJVZFVNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x99F8CE0", Offset = "0x99F7CE0", VA = "0x1899F8CE0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool FDXHBUTMSGC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x99F9210", Offset = "0x99F8210", VA = "0x1899F9210", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int SOBXRLODDED
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x99F91B0", Offset = "0x99F81B0", VA = "0x1899F91B0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99F8DA0", Offset = "0x99F7DA0", VA = "0x1899F8DA0", Slot = "22")]
		public void IRHVHNYUXBW(GOGPWELYDXC a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public JDWTTSIPYOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FGGHUGFQXYA : GOGPWELYDXC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (UDWGCJFTWNB curr, UDWGCJFTWNB next, ShapeConfigFlags flags) KMBDDVIDAVU;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (UDWGCJFTWNB curr, UDWGCJFTWNB next, ShapeConfigFlags flags) YTUTJGBWUDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x73B4640", Offset = "0x73B3640", VA = "0x1873B4640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 ELYIHVHAUZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x99F8850", Offset = "0x99F7850", VA = "0x1899F8850", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 XXLBRFDHPSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x99F88C0", Offset = "0x99F78C0", VA = "0x1899F88C0", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99F88F0", Offset = "0x99F78F0", VA = "0x1899F88F0", Slot = "6")]
		public quaternion YLXUAZEHAUT(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public FGGHUGFQXYA()
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
