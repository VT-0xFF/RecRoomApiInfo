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
internal class SVGOSYYBXCW
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
	[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
	public SVGOSYYBXCW()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class WTGYAEVZTZK : BZNRQSWSZOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private CYZULSGWQRY.PhysicsMode GEYYHBXJBJY;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString UDOHZCOZIRK;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString YNOKROWZMWP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override CYZULSGWQRY.PhysicsMode MTVBSZEJEWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0", Slot = "13")]
			get
			{
				return default(CYZULSGWQRY.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x989BBC0", Offset = "0x989A7C0", VA = "0x18989BBC0")]
		public bool LWOZYEBUCXC(YMQXVRQNJLQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x989BC60", Offset = "0x989A860", VA = "0x18989BC60")]
		private static bool YFVNVRWKPLJ(YMQXVRQNJLQ a, [Out] CYZULSGWQRY.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public WTGYAEVZTZK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SPSJIXPGBCL : JOVEUEDNTZV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected YMQXVRQNJLQ GEHCEZHJWAY;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual YMQXVRQNJLQ HBLTVDNEEXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool MOJDNGOELYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x989BB60", Offset = "0x989A760", VA = "0x18989BB60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KARNVRMCFBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x989BB90", Offset = "0x989A790", VA = "0x18989BB90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CBGLFNBPORI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x989BB00", Offset = "0x989A700", VA = "0x18989BB00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HPALIOMEFSI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x989BB30", Offset = "0x989A730", VA = "0x18989BB30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool PPUYNNNVJSN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x989BAD0", Offset = "0x989A6D0", VA = "0x18989BAD0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public SPSJIXPGBCL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class KNZBSPXEPQM : CTAQTRIFRJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper GEHCEZHJWAY;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x989B360", Offset = "0x9899F60", VA = "0x18989B360")]
		public KNZBSPXEPQM(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x989AD90", Offset = "0x9899990", VA = "0x18989AD90", Slot = "4")]
		public bool HJLEXYXGGRJ(CYZULSGWQRY a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x989B200", Offset = "0x9899E00", VA = "0x18989B200", Slot = "5")]
		public bool SIMYFCYLNCW(CYZULSGWQRY a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x989AFE0", Offset = "0x9899BE0", VA = "0x18989AFE0", Slot = "6")]
		public bool JJBSVDYSVLV(AEIULYWIKIO a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x989B190", Offset = "0x9899D90", VA = "0x18989B190")]
		private IReadOnlyList<YMQXVRQNJLQ> NOMKPMCSCZM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x989AEB0", Offset = "0x9899AB0", VA = "0x18989AEB0")]
		private bool IBLIGNMLGIG(int a, [Out][NotNullWhen(true)] YMQXVRQNJLQ containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class YTCYLIPQGTD : BZNRQSWSZOI, DULCQNADRTP, CYZULSGWQRY, JOVEUEDNTZV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<MDKZANPVLEJ> UCUMMZYVNIG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override YMQXVRQNJLQ HBLTVDNEEXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x989C210", Offset = "0x989AE10", VA = "0x18989C210", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override CYZULSGWQRY.PhysicsMode MTVBSZEJEWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x989C080", Offset = "0x989AC80", VA = "0x18989C080", Slot = "13")]
			get
			{
				return default(CYZULSGWQRY.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int CGYOIQMFZMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x989C1D0", Offset = "0x989ADD0", VA = "0x18989C1D0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x989C0B0", Offset = "0x989ACB0", VA = "0x18989C0B0", Slot = "15")]
		public void FXGSPCSBVEN(DCVUFXSAJRM a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public YTCYLIPQGTD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class BZNRQSWSZOI : SPSJIXPGBCL, CYZULSGWQRY, JOVEUEDNTZV
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract CYZULSGWQRY.PhysicsMode MTVBSZEJEWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool DHLZHQUUWOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x989A9F0", Offset = "0x98995F0", VA = "0x18989A9F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool CJIWUJXWQKS
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x989AA30", Offset = "0x9899630", VA = "0x18989AA30", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ZAHUXJLEESI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x989AA60", Offset = "0x9899660", VA = "0x18989AA60", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected BZNRQSWSZOI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class OGCCYOZBLLM : DCVUFXSAJRM, YWVYKLRCINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MDKZANPVLEJ GEHCEZHJWAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<MTSOOUKDLCJ> BVCTQQHTJFR;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public MDKZANPVLEJ HBLTVDNEEXS
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x989BA20", Offset = "0x989A620", VA = "0x18989BA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OIDRLIWCRUN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x989B510", Offset = "0x989A110", VA = "0x18989B510", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType GJVLUAKAYMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2838540", Offset = "0x2837140", VA = "0x182838540", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public YWVYKLRCINC RKVFIIVBRWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x989B5D0", Offset = "0x989A1D0", VA = "0x18989B5D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 LWKWIDIZVNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x989B3D0", Offset = "0x9899FD0", VA = "0x18989B3D0", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion KGAYDLOYNUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x989B440", Offset = "0x989A040", VA = "0x18989B440", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 JBTKORXHGDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x989B640", Offset = "0x989A240", VA = "0x18989B640", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial KSFJLDIUTJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x32B4420", Offset = "0x32B3020", VA = "0x1832B4420", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor LPXTJPZIKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1321FE0", Offset = "0x1320BE0", VA = "0x181321FE0", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float SVFPOYRRLZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x989BA80", Offset = "0x989A680", VA = "0x18989BA80", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 UKUIDNUTOUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x989B4A0", Offset = "0x989A0A0", VA = "0x18989B4A0", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float SDPVMFANIXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x989B3B0", Offset = "0x9899FB0", VA = "0x18989B3B0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags VGGDXNOJJIN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4FB2D30", Offset = "0x4FB1930", VA = "0x184FB2D30", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int YSCZYCLUVZR
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x989B530", Offset = "0x989A130", VA = "0x18989B530", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool VLURESVZGVV
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x989B610", Offset = "0x989A210", VA = "0x18989B610", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool SBAJEMJWSNO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x989BAA0", Offset = "0x989A6A0", VA = "0x18989BAA0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float UVQLYSMCQLP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x989B7B0", Offset = "0x989A3B0", VA = "0x18989B7B0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IPQBAZDNXSI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x989B810", Offset = "0x989A410", VA = "0x18989B810", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int TASCUYNVLSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x989B570", Offset = "0x989A170", VA = "0x18989B570", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x989B830", Offset = "0x989A430", VA = "0x18989B830", Slot = "22")]
		public void RMLWOYRTXEG(WMGCXZRRUPM a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public OGCCYOZBLLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class IMSQAPMZQRU : WMGCXZRRUPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (MTSOOUKDLCJ curr, MTSOOUKDLCJ next, ShapeConfigFlags flags) GEHCEZHJWAY;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (MTSOOUKDLCJ curr, MTSOOUKDLCJ next, ShapeConfigFlags flags) HBLTVDNEEXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x726C4F0", Offset = "0x726B0F0", VA = "0x18726C4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 JOGSRQJMWZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x989AAC0", Offset = "0x98996C0", VA = "0x18989AAC0", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 KUNLLKTXIHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x989AA90", Offset = "0x9899690", VA = "0x18989AA90", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x989AB30", Offset = "0x9899730", VA = "0x18989AB30", Slot = "6")]
		public quaternion KMWKJYSUNTH(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public IMSQAPMZQRU()
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
