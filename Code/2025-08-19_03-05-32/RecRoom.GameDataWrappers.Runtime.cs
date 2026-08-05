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
internal class MUPXUODILAN
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
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public MUPXUODILAN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class TYZHMZWPLWP : RZUZLOPTWMR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private GDWVOPVZDUV.PhysicsMode UCCMTIWDYPZ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString VASQJPTTQNX;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString FMGQFUTUJBG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override GDWVOPVZDUV.PhysicsMode ACOBPYUHCCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20", Slot = "13")]
			get
			{
				return default(GDWVOPVZDUV.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85CDB50", Offset = "0x85CC950", VA = "0x1885CDB50")]
		public bool TANPJQAOVCR(LZGZZRSUFGL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85CD820", Offset = "0x85CC620", VA = "0x1885CD820")]
		private static bool HDDLGWMOWXM(LZGZZRSUFGL a, [Out] GDWVOPVZDUV.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TYZHMZWPLWP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class OPNZUQBRKSK : OJMGCXVPMEW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected LZGZZRSUFGL UZOZEZLFZLF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual LZGZZRSUFGL YTUDXKSFVRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool WQQEGKELCGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x85CD6C0", Offset = "0x85CC4C0", VA = "0x1885CD6C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool RITOMLHLJPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x85CD720", Offset = "0x85CC520", VA = "0x1885CD720", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BRGZQDAQJKV
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x85CD6F0", Offset = "0x85CC4F0", VA = "0x1885CD6F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ZBHZLVCLVIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x85CD750", Offset = "0x85CC550", VA = "0x1885CD750", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool LZMFKTGNGQG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x85CD690", Offset = "0x85CC490", VA = "0x1885CD690", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public OPNZUQBRKSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EPRRBZRHKRX : BKNGFKZHTVF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper UZOZEZLFZLF;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85CD640", Offset = "0x85CC440", VA = "0x1885CD640")]
		public EPRRBZRHKRX(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85CD370", Offset = "0x85CC170", VA = "0x1885CD370", Slot = "4")]
		public bool LTCYZOJHWSY(GDWVOPVZDUV a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85CD210", Offset = "0x85CC010", VA = "0x1885CD210", Slot = "5")]
		public bool LHRKSFYGVNJ(GDWVOPVZDUV a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85CD490", Offset = "0x85CC290", VA = "0x1885CD490", Slot = "6")]
		public bool XRJPQHTRMVA(KWXACINWXHP a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85CD1A0", Offset = "0x85CBFA0", VA = "0x1885CD1A0")]
		private IReadOnlyList<LZGZZRSUFGL> IPMHEJLYYGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85CD060", Offset = "0x85CBE60", VA = "0x1885CD060")]
		private bool DHTCKRWEHDJ(int a, [Out][NotNullWhen(true)] LZGZZRSUFGL containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class EKJHVWEXQZC : RZUZLOPTWMR, CBYVFBQKVAA, GDWVOPVZDUV, OJMGCXVPMEW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<LZSMYNFCCLC> YZOPLABMVIV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override LZGZZRSUFGL YTUDXKSFVRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x85CCE70", Offset = "0x85CBC70", VA = "0x1885CCE70", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override GDWVOPVZDUV.PhysicsMode ACOBPYUHCCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x85CCFF0", Offset = "0x85CBDF0", VA = "0x1885CCFF0", Slot = "13")]
			get
			{
				return default(GDWVOPVZDUV.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int LBPFKEGAQKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x85CD020", Offset = "0x85CBE20", VA = "0x1885CD020", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85CCED0", Offset = "0x85CBCD0", VA = "0x1885CCED0", Slot = "15")]
		public void FCRIOQNIOFI(EIBHAFKQDLL a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public EKJHVWEXQZC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class RZUZLOPTWMR : OPNZUQBRKSK, GDWVOPVZDUV, OJMGCXVPMEW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract GDWVOPVZDUV.PhysicsMode ACOBPYUHCCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CNXOFWGVGXY
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x85CD7E0", Offset = "0x85CC5E0", VA = "0x1885CD7E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FYENXZMDXFP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x85CD7B0", Offset = "0x85CC5B0", VA = "0x1885CD7B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool SSNUIOCMGXL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x85CD780", Offset = "0x85CC580", VA = "0x1885CD780", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected RZUZLOPTWMR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AJPUEOKVBKR : EIBHAFKQDLL, QPDBBGASNAV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private LZSMYNFCCLC UZOZEZLFZLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<BTSODNVDPXU> QMXWFOFLPZG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LZSMYNFCCLC YTUDXKSFVRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x85CC450", Offset = "0x85CB250", VA = "0x1885CC450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CLSRYMVGUBI
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x85CC7F0", Offset = "0x85CB5F0", VA = "0x1885CC7F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType SBZIHDDMMGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2936F90", Offset = "0x2935D90", VA = "0x182936F90", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public QPDBBGASNAV JKCSUSDTABE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x85CC4E0", Offset = "0x85CB2E0", VA = "0x1885CC4E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 VQBBPYBXSGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x85CC610", Offset = "0x85CB410", VA = "0x1885CC610", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion JZOPJQMDSFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x85CC5B0", Offset = "0x85CB3B0", VA = "0x1885CC5B0", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 GLTCDKGXFXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x85CC680", Offset = "0x85CB480", VA = "0x1885CC680", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial KDKSVXRWXGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x321C3F0", Offset = "0x321B1F0", VA = "0x18321C3F0", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor QNWAOOGPRMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x131B330", Offset = "0x131A130", VA = "0x18131B330", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float CGEBPJJUTLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x85CCAD0", Offset = "0x85CB8D0", VA = "0x1885CCAD0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 ISFZHFQQDHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x85CCA00", Offset = "0x85CB800", VA = "0x1885CCA00", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float YCJEZHFHCJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85CCAF0", Offset = "0x85CB8F0", VA = "0x1885CCAF0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags IFSMXXDVHYY
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E82ED0", Offset = "0x5E81CD0", VA = "0x185E82ED0", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BNOEBGSTAXC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x85CC570", Offset = "0x85CB370", VA = "0x1885CC570", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool UVZZVPJBLWA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x85CC4B0", Offset = "0x85CB2B0", VA = "0x1885CC4B0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool KSEWULZLSFV
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x85CC520", Offset = "0x85CB320", VA = "0x1885CC520", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float UICZSISISIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x85CCA70", Offset = "0x85CB870", VA = "0x1885CCA70", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool JOARVOKDODV
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85CC550", Offset = "0x85CB350", VA = "0x1885CC550", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int HAQNVDKPIDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x85CCB10", Offset = "0x85CB910", VA = "0x1885CCB10", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85CC810", Offset = "0x85CB610", VA = "0x1885CC810", Slot = "22")]
		public void OJDUALWFJZH(YQDFESMNSQR a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AJPUEOKVBKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CUHNCFDCEQZ : YQDFESMNSQR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (BTSODNVDPXU curr, BTSODNVDPXU next, ShapeConfigFlags flags) UZOZEZLFZLF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (BTSODNVDPXU curr, BTSODNVDPXU next, ShapeConfigFlags flags) YTUDXKSFVRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5C2B730", Offset = "0x5C2A530", VA = "0x185C2B730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 CXGUXRWHWJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x85CCDD0", Offset = "0x85CBBD0", VA = "0x1885CCDD0", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 NPJLVZIDVVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x85CCE40", Offset = "0x85CBC40", VA = "0x1885CCE40", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85CCB70", Offset = "0x85CB970", VA = "0x1885CCB70", Slot = "6")]
		public quaternion CELDCDKPAES(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CUHNCFDCEQZ()
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
