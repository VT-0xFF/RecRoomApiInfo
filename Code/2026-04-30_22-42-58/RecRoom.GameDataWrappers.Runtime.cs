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
internal class CWHGVYTHLWE
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
	[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
	public CWHGVYTHLWE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class QDHBNSBFAPQ : MKMJZWDGFYO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BLNRZMQMDQY.PhysicsMode KXHRURLJXKQ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString MYOOVYUIZYW;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString GXWWVNOGICN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override BLNRZMQMDQY.PhysicsMode FBRQINPCIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "13")]
			get
			{
				return default(BLNRZMQMDQY.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97DE660", Offset = "0x97DDA60", VA = "0x1897DE660")]
		public bool QFOQNMWMHQS(TEAIRTFLUOM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97DE330", Offset = "0x97DD730", VA = "0x1897DE330")]
		private static bool GRANYTOVBUR(TEAIRTFLUOM a, [Out] BLNRZMQMDQY.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public QDHBNSBFAPQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class DPYOHVECNHT : FPOHMPDVPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected TEAIRTFLUOM ZTAAYLQAUCS;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual TEAIRTFLUOM YVVJIHKGLFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool GVSCCCJQRWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x97DD5B0", Offset = "0x97DC9B0", VA = "0x1897DD5B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KAJMOQTYKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x97DD610", Offset = "0x97DCA10", VA = "0x1897DD610", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool XJNDAISQSVO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x97DD5E0", Offset = "0x97DC9E0", VA = "0x1897DD5E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EUGFLIPSJQC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x97DD640", Offset = "0x97DCA40", VA = "0x1897DD640", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool LJYZQYBSELB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x97DD580", Offset = "0x97DC980", VA = "0x1897DD580", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public DPYOHVECNHT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class YDVZNXUGPOO : VZDDGAXATII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper ZTAAYLQAUCS;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x97DEDD0", Offset = "0x97DE1D0", VA = "0x1897DEDD0")]
		public YDVZNXUGPOO(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x97DE7F0", Offset = "0x97DDBF0", VA = "0x1897DE7F0", Slot = "4")]
		public bool ASYLOZLGUCV(BLNRZMQMDQY a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x97DEA50", Offset = "0x97DDE50", VA = "0x1897DEA50", Slot = "5")]
		public bool KMWNFQRCICU(BLNRZMQMDQY a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x97DEC20", Offset = "0x97DE020", VA = "0x1897DEC20", Slot = "6")]
		public bool YIXOTFIGKZP(UQABVOOVISY a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x97DEBB0", Offset = "0x97DDFB0", VA = "0x1897DEBB0")]
		private IReadOnlyList<TEAIRTFLUOM> NVJGVNMITPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x97DE910", Offset = "0x97DDD10", VA = "0x1897DE910")]
		private bool HLRYQNKXLDC(int a, [Out][NotNullWhen(true)] TEAIRTFLUOM containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class EJGOCXHGNSD : MKMJZWDGFYO, EDJBSTIEJSH, BLNRZMQMDQY, FPOHMPDVPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<KGZTHHXYXVN> FGKHAEFKKJO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override TEAIRTFLUOM YVVJIHKGLFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x97DD670", Offset = "0x97DCA70", VA = "0x1897DD670", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override BLNRZMQMDQY.PhysicsMode FBRQINPCIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x97DD710", Offset = "0x97DCB10", VA = "0x1897DD710", Slot = "13")]
			get
			{
				return default(BLNRZMQMDQY.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int LLKCUAZVPNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x97DD6D0", Offset = "0x97DCAD0", VA = "0x1897DD6D0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97DD740", Offset = "0x97DCB40", VA = "0x1897DD740", Slot = "15")]
		public void XHBKURGNSLB(RJSLWMZQHCA a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public EJGOCXHGNSD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MKMJZWDGFYO : DPYOHVECNHT, BLNRZMQMDQY, FPOHMPDVPEN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract BLNRZMQMDQY.PhysicsMode FBRQINPCIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool WGEJRZNNIAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x97DE290", Offset = "0x97DD690", VA = "0x1897DE290", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool UKPOXLJSXXK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x97DE300", Offset = "0x97DD700", VA = "0x1897DE300", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool RQUQBZEKEYK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x97DE2D0", Offset = "0x97DD6D0", VA = "0x1897DE2D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected MKMJZWDGFYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class MDXXGXHTMLS : RJSLWMZQHCA, ATWISMKGAKW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private KGZTHHXYXVN ZTAAYLQAUCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<TLGVBOZBNDR> JBLWNOKZXRD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public KGZTHHXYXVN YVVJIHKGLFY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x97DDC40", Offset = "0x97DD040", VA = "0x1897DDC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool BOEPUTJOSYD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x97DE270", Offset = "0x97DD670", VA = "0x1897DE270", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType VANTYOLEKRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x283E4B0", Offset = "0x283D8B0", VA = "0x18283E4B0", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ATWISMKGAKW ZSDAJKWGVLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x97DE020", Offset = "0x97DD420", VA = "0x1897DE020", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 VBAMHTFZVCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x97DDB70", Offset = "0x97DCF70", VA = "0x1897DDB70", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion LXYOOPRPYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x97DDBE0", Offset = "0x97DCFE0", VA = "0x1897DDBE0", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 XOJMVANENPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x97DDE30", Offset = "0x97DD230", VA = "0x1897DDE30", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial EEQKTWQVTXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x32B3E30", Offset = "0x32B3230", VA = "0x1832B3E30", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor RABJBRSMCAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x12E0850", Offset = "0x12DFC50", VA = "0x1812E0850", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float SWOMGZAWUIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x97DDD30", Offset = "0x97DD130", VA = "0x1897DDD30", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 HIMXRYKCYXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x97DDD80", Offset = "0x97DD180", VA = "0x1897DDD80", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float SVTCWWCPMFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x97DE060", Offset = "0x97DD460", VA = "0x1897DE060", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags KWIJCBATVVV
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6783350", Offset = "0x6782750", VA = "0x186783350", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int JSQMMIFXMIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x97DDDF0", Offset = "0x97DD1F0", VA = "0x1897DDDF0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool RMOPRSHSSSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x97DDD50", Offset = "0x97DD150", VA = "0x1897DDD50", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool XADDXUNOFXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x97DDCA0", Offset = "0x97DD0A0", VA = "0x1897DDCA0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float TCDPYAURKTB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x97DDFC0", Offset = "0x97DD3C0", VA = "0x1897DDFC0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool QCGJODAAPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x97DDFA0", Offset = "0x97DD3A0", VA = "0x1897DDFA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int UOMJHXYWPXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x97DDCD0", Offset = "0x97DD0D0", VA = "0x1897DDCD0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97DE080", Offset = "0x97DD480", VA = "0x1897DE080", Slot = "22")]
		public void ZMYPJBJEUXO(YHYGZNJEYXG a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public MDXXGXHTMLS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EYFGOLVBKTW : YHYGZNJEYXG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (TLGVBOZBNDR curr, TLGVBOZBNDR next, ShapeConfigFlags flags) ZTAAYLQAUCS;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (TLGVBOZBNDR curr, TLGVBOZBNDR next, ShapeConfigFlags flags) YVVJIHKGLFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x730B4E0", Offset = "0x730A8E0", VA = "0x18730B4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 OXYBJKKQMBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x97DDB00", Offset = "0x97DCF00", VA = "0x1897DDB00", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 UASRRBTTTFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x97DD870", Offset = "0x97DCC70", VA = "0x1897DD870", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x97DD8A0", Offset = "0x97DCCA0", VA = "0x1897DD8A0", Slot = "6")]
		public quaternion NUKTLFIJQXN(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public EYFGOLVBKTW()
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
