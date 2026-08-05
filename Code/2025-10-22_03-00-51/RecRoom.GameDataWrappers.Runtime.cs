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
internal class ZFXGPLLYWZU
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
	[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
	public ZFXGPLLYWZU()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class JSWXARPTLME : AXYKVNWAJVK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private PLMLAZBVVSK.PhysicsMode AQIILWKFUJE;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString BYHVXXDTQRC;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString HKXTFPSZIHN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override PLMLAZBVVSK.PhysicsMode FZCAZKVVCAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0", Slot = "13")]
			get
			{
				return default(PLMLAZBVVSK.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85464A0", Offset = "0x8544AA0", VA = "0x1885464A0")]
		public bool DTEUAZMKDTO(UMNTAHYOPJM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8546540", Offset = "0x8544B40", VA = "0x188546540")]
		private static bool YORVYNHLYCP(UMNTAHYOPJM a, [Out] PLMLAZBVVSK.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public JSWXARPTLME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ZLMJRBOMZMP : PAFABALJKZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected UMNTAHYOPJM QHPHTAHQMYA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual UMNTAHYOPJM EPIXYLBKGFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CEYSJZWWJXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8547950", Offset = "0x8545F50", VA = "0x188547950", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool QATCOPOYNSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8547890", Offset = "0x8545E90", VA = "0x188547890", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MKGHAPKAUYK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x85478F0", Offset = "0x8545EF0", VA = "0x1885478F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DWMJADRBFEU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x85478C0", Offset = "0x8545EC0", VA = "0x1885478C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ZKBKWLZIUKR
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8547920", Offset = "0x8545F20", VA = "0x188547920", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ZLMJRBOMZMP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class OBAEZBSNUCU : RJTVTVPRSXE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper QHPHTAHQMYA;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8546F20", Offset = "0x8545520", VA = "0x188546F20")]
		public OBAEZBSNUCU(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8546AF0", Offset = "0x85450F0", VA = "0x188546AF0", Slot = "4")]
		public bool JWGJDNARNGL(PLMLAZBVVSK a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8546DC0", Offset = "0x85453C0", VA = "0x188546DC0", Slot = "5")]
		public bool OLEPBUXVECS(PLMLAZBVVSK a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8546C10", Offset = "0x8545210", VA = "0x188546C10", Slot = "6")]
		public bool LZUDFFEYLQT(XXSWOYRBGLQ a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8546A80", Offset = "0x8545080", VA = "0x188546A80")]
		private IReadOnlyList<UMNTAHYOPJM> IFCCOBPQVGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8546950", Offset = "0x8544F50", VA = "0x188546950")]
		private bool DNXWBROWYIO(int a, [Out][NotNullWhen(true)] UMNTAHYOPJM containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SZEULNFVCDT : AXYKVNWAJVK, OWKLXWVKWVX, PLMLAZBVVSK, PAFABALJKZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<ATUPEVQQISJ> BXUBSCISWWG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override UMNTAHYOPJM EPIXYLBKGFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8547110", Offset = "0x8545710", VA = "0x188547110", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override PLMLAZBVVSK.PhysicsMode FZCAZKVVCAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x85470E0", Offset = "0x85456E0", VA = "0x1885470E0", Slot = "13")]
			get
			{
				return default(PLMLAZBVVSK.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int LLMWVAOHWEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8546F70", Offset = "0x8545570", VA = "0x188546F70", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8546FB0", Offset = "0x85455B0", VA = "0x188546FB0", Slot = "15")]
		public void FRPMHDXNIBX(VOVIQUBDVFU a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public SZEULNFVCDT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AXYKVNWAJVK : ZLMJRBOMZMP, PLMLAZBVVSK, PAFABALJKZR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract PLMLAZBVVSK.PhysicsMode FZCAZKVVCAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CFTBBNEWNLD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8546160", Offset = "0x8544760", VA = "0x188546160", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FWNZPGXZRAS
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8546130", Offset = "0x8544730", VA = "0x188546130", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool EUZSNEHZEVK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8546100", Offset = "0x8544700", VA = "0x188546100", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected AXYKVNWAJVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class WMQQHKEETUS : VOVIQUBDVFU, RRTCZGNBILW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private ATUPEVQQISJ QHPHTAHQMYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<UGBHLQQAKEJ> XAEQNNESLSH;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ATUPEVQQISJ EPIXYLBKGFW
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8547830", Offset = "0x8545E30", VA = "0x188547830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GYZWXGGGHRL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x85471D0", Offset = "0x85457D0", VA = "0x1885471D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType LUEUYUIEGJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xB5D700", Offset = "0xB5BD00", VA = "0x180B5D700", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public RRTCZGNBILW PXUCFIEWHTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x85471F0", Offset = "0x85457F0", VA = "0x1885471F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 DSBMUQQWNYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x85472E0", Offset = "0x85458E0", VA = "0x1885472E0", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion VBLUIXJXMKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8547170", Offset = "0x8545770", VA = "0x188547170", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 ZZGGBTRPGMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8547650", Offset = "0x8545C50", VA = "0x188547650", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial PRMMTXGXHIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3237E60", Offset = "0x3236460", VA = "0x183237E60", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor HHPEXJZUJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x133A660", Offset = "0x1338C60", VA = "0x18133A660", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float AZLZTQGKHOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8547230", Offset = "0x8545830", VA = "0x188547230", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 JKCYYQVJBGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x85477C0", Offset = "0x8545DC0", VA = "0x1885477C0", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float GMIALSEFPAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85473B0", Offset = "0x85459B0", VA = "0x1885473B0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags IYREEORWVFL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x686B410", Offset = "0x6869A10", VA = "0x18686B410", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int FTJRLOHGVNR
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8547280", Offset = "0x8545880", VA = "0x188547280", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool RWVOODLDRJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8547250", Offset = "0x8545850", VA = "0x188547250", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool FXRBVFKMFOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8547620", Offset = "0x8545C20", VA = "0x188547620", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float CWOZQLHMEND
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x85473D0", Offset = "0x85459D0", VA = "0x1885473D0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool LVBHKBNKMKE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85472C0", Offset = "0x85458C0", VA = "0x1885472C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int VGOEAVABCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8547350", Offset = "0x8545950", VA = "0x188547350", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8547430", Offset = "0x8545A30", VA = "0x188547430", Slot = "22")]
		public void PXZYFRPRLSS(VZYYOMUWBPY a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public WMQQHKEETUS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class JFUPDFCGFBA : VZYYOMUWBPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (UGBHLQQAKEJ curr, UGBHLQQAKEJ next, ShapeConfigFlags flags) QHPHTAHQMYA;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (UGBHLQQAKEJ curr, UGBHLQQAKEJ next, ShapeConfigFlags flags) EPIXYLBKGFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5B73BA0", Offset = "0x5B721A0", VA = "0x185B73BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 RAMBHLEETFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8546430", Offset = "0x8544A30", VA = "0x188546430", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 RTMVMDHZWKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8546400", Offset = "0x8544A00", VA = "0x188546400", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85461A0", Offset = "0x85447A0", VA = "0x1885461A0", Slot = "6")]
		public quaternion MQHSIQNSUKN(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public JFUPDFCGFBA()
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
