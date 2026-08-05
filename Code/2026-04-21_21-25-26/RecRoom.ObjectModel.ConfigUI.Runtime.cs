using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9B75030", Offset = "0x9B73A30", VA = "0x189B75030", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] SSKDGXUXNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset DGANWLFFZHC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B78E90", Offset = "0x9B77890", VA = "0x189B78E90", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B78EB0", Offset = "0x9B778B0", VA = "0x189B78EB0")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B78720", Offset = "0x9B77120", VA = "0x189B78720", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B78780", Offset = "0x9B77180", VA = "0x189B78780", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B790D0", Offset = "0x9B77AD0", VA = "0x189B790D0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class QFIBWAZCZIU : VNWQVNWMKLE<Enum>, YBMOHIVCIWV, SEMWBKXPSCA, TPQLDRBRGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool INGXCVFWEJY(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B77A90", Offset = "0x9B76490", VA = "0x189B77A90")]
		protected QFIBWAZCZIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class VNWQVNWMKLE<a> : SEMWBKXPSCA, TPQLDRBRGAM where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class BAWJCOIJFZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public EFSRNAMUUKX TGJGFLSHRHC;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BAWJCOIJFZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4EF9400", Offset = "0x4EF7E00", VA = "0x184EF9400")]
			internal bool DACAPZTKDOH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A06F40", Offset = "0x7A05940", VA = "0x187A06F40")]
		protected VNWQVNWMKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1D00", Offset = "0x7FF0700", VA = "0x187FF1D00")]
		protected void OOGCFGCNHMN(LXTIMKXBYZO a, EFSRNAMUUKX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1AF0", Offset = "0x7FF04F0", VA = "0x187FF1AF0")]
		protected void DLNBVSIAATR(QDUDIDLXOOH<a> a, EFSRNAMUUKX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class WLEPJOKSCPR : NEFKBHGBRDD, TPQLDRBRGAM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] HBIUSKSOFHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] ORPRLWXOEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void NMFIASHFGKT(EFSRNAMUUKX a, RLGFHYWFQMI b, JALXIPKYOPE c, KXNTIHEZPWZ d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4151430", Offset = "0x414FE30", VA = "0x184151430")]
		protected static b FRICHGVQBZR<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4151610", Offset = "0x4150010", VA = "0x184151610")]
		protected static void ZJMRWBFQXQO<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected WLEPJOKSCPR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class SQXVZWZSUCL<a> : SEMWBKXPSCA, TPQLDRBRGAM where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class BAWJCOIJFZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public EFSRNAMUUKX TGJGFLSHRHC;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BAWJCOIJFZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4EF9630", Offset = "0x4EF8030", VA = "0x184EF9630")]
			internal bool DACAPZTKDOH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7A06F40", Offset = "0x7A05940", VA = "0x187A06F40")]
		protected SQXVZWZSUCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7A05F40", Offset = "0x7A04940", VA = "0x187A05F40")]
		protected void OOGCFGCNHMN(LXTIMKXBYZO a, EFSRNAMUUKX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7A04D10", Offset = "0x7A03710", VA = "0x187A04D10")]
		protected void DLNBVSIAATR(QDUDIDLXOOH<a> a, EFSRNAMUUKX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(RLGFHYWFQMI), new string[] { })]
	internal class ConfigUIService : RLGFHYWFQMI, PVENKBCWRBE, JQVAGBYEMGQ, JIKZVPRDGWM, ORELWRZKHYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private JALXIPKYOPE ZYDDIBTKENX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private KXNTIHEZPWZ EICYLRNWZKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates IEKOUZZNILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray SZSZHYVGGYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<EFSRNAMUUKX> AQPBBFJJSXE;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray DITMLTUQTZX
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1753E80", Offset = "0x1752880", VA = "0x181753E80", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B71120", Offset = "0x9B6FB20", VA = "0x189B71120", Slot = "6")]
		public void InitExternal(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B71440", Offset = "0x9B6FE40", VA = "0x189B71440", Slot = "7")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B71B60", Offset = "0x9B70560", VA = "0x189B71B60", Slot = "4")]
		public void UVQBYUIKFQV(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B718F0", Offset = "0x9B702F0", VA = "0x189B718F0")]
		private void OSEAKYBPNOL(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B71960", Offset = "0x9B70360", VA = "0x189B71960")]
		private void QGDBZDLJRFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B715B0", Offset = "0x9B6FFB0", VA = "0x189B715B0")]
		private void NMFIASHFGKT(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B71540", Offset = "0x9B6FF40", VA = "0x189B71540", Slot = "8")]
		private void MBYFDPTTQYS(IKBIXEGYPOI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x104F170", Offset = "0x104DB70", VA = "0x18104F170", Slot = "9")]
		private void NXHIFSUZYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B72060", Offset = "0x9B70A60", VA = "0x189B72060")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class UWCLNLKGDBG : QFIBWAZCZIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B77DA0", Offset = "0x9B767A0", VA = "0x189B77DA0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B77D00", Offset = "0x9B76700", VA = "0x189B77D00", Slot = "7")]
		public override bool INGXCVFWEJY(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B77A90", Offset = "0x9B76490", VA = "0x189B77A90")]
		public UWCLNLKGDBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class XRDWIRIZYKJ : QFIBWAZCZIU
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B77EF0", Offset = "0x9B768F0", VA = "0x189B77EF0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B77E50", Offset = "0x9B76850", VA = "0x189B77E50", Slot = "7")]
		public override bool INGXCVFWEJY(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B77A90", Offset = "0x9B76490", VA = "0x189B77A90")]
		public XRDWIRIZYKJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class BOLNJFPBGTC : VNWQVNWMKLE<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B70C20", Offset = "0x9B6F620", VA = "0x189B70C20", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9B70D70", Offset = "0x9B6F770", VA = "0x189B70D70")]
		public BOLNJFPBGTC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class YYUKCJEXTUY : WLEPJOKSCPR
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public RLGFHYWFQMI FOXFDSIIDAM;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9B75730", Offset = "0x9B74130", VA = "0x189B75730")]
			internal (int, int) WMKFZMPHDCF()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9B755E0", Offset = "0x9B73FE0", VA = "0x189B755E0")]
			internal void WMEZCFVJTQW((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] HBIUSKSOFHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] ORPRLWXOEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B78240", Offset = "0x9B76C40", VA = "0x189B78240", Slot = "9")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, RLGFHYWFQMI b, JALXIPKYOPE c, KXNTIHEZPWZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B785F0", Offset = "0x9B76FF0", VA = "0x189B785F0")]
		public YYUKCJEXTUY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class YLYZKMUXXMF : SQXVZWZSUCL<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B77FA0", Offset = "0x9B769A0", VA = "0x189B77FA0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B78030", Offset = "0x9B76A30", VA = "0x189B78030")]
		public YLYZKMUXXMF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class FYOGXOKSYTL : SQXVZWZSUCL<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public EFSRNAMUUKX TGJGFLSHRHC;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9B736F0", Offset = "0x9B720F0", VA = "0x189B736F0")]
			internal string WMKFZMPHDCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9B73540", Offset = "0x9B71F40", VA = "0x189B73540")]
			internal void WMEZCFVJTQW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B72C50", Offset = "0x9B71650", VA = "0x189B72C50", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9B72DE0", Offset = "0x9B717E0", VA = "0x189B72DE0")]
		public FYOGXOKSYTL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class UEMIJBINLOG : SQXVZWZSUCL<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public EFSRNAMUUKX TGJGFLSHRHC;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9B737D0", Offset = "0x9B721D0", VA = "0x189B737D0")]
			internal string WMKFZMPHDCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9B735C0", Offset = "0x9B71FC0", VA = "0x189B735C0")]
			internal void WMEZCFVJTQW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9B77B30", Offset = "0x9B76530", VA = "0x189B77B30", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B77CC0", Offset = "0x9B766C0", VA = "0x189B77CC0")]
		public UEMIJBINLOG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class DFVOCLYHCVI : SQXVZWZSUCL<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EFSRNAMUUKX TGJGFLSHRHC;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9B73750", Offset = "0x9B72150", VA = "0x189B73750")]
			internal float WMKFZMPHDCF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9B736A0", Offset = "0x9B720A0", VA = "0x189B736A0")]
			internal void WMEZCFVJTQW(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B734C0", Offset = "0x9B71EC0", VA = "0x189B734C0")]
			internal float WLZSEZBMKFN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9B734A0", Offset = "0x9B71EA0", VA = "0x189B734A0")]
			internal void WLULHSHPAUE(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9B73420", Offset = "0x9B71E20", VA = "0x189B73420")]
			internal float WLPEKLNRRIV()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9B73400", Offset = "0x9B71E00", VA = "0x189B73400")]
			internal void WLJXNETUHXM(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9B73390", Offset = "0x9B71D90", VA = "0x189B73390")]
			internal float WARLNCMJAFI(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9B732B0", Offset = "0x9B71CB0", VA = "0x189B732B0")]
			internal void SLZSNNRYKOV(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B720E0", Offset = "0x9B70AE0", VA = "0x189B720E0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B724E0", Offset = "0x9B70EE0", VA = "0x189B724E0")]
		public DFVOCLYHCVI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class GMCEFXMESTT : SQXVZWZSUCL<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B72E20", Offset = "0x9B71820", VA = "0x189B72E20", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9B72EB0", Offset = "0x9B718B0", VA = "0x189B72EB0")]
		public GMCEFXMESTT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class APEHSTSUCDY : SQXVZWZSUCL<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B70B50", Offset = "0x9B6F550", VA = "0x189B70B50", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B70BE0", Offset = "0x9B6F5E0", VA = "0x189B70BE0")]
		public APEHSTSUCDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class FTDWQMDPMAR : SQXVZWZSUCL<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public EFSRNAMUUKX TGJGFLSHRHC;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9B737C0", Offset = "0x9B721C0", VA = "0x189B737C0")]
			internal float WMKFZMPHDCF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9B735B0", Offset = "0x9B71FB0", VA = "0x189B735B0")]
			internal void WMEZCFVJTQW(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9B73530", Offset = "0x9B71F30", VA = "0x189B73530")]
			internal float WLZSEZBMKFN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9B734B0", Offset = "0x9B71EB0", VA = "0x189B734B0")]
			internal void WLULHSHPAUE(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9B73490", Offset = "0x9B71E90", VA = "0x189B73490")]
			internal float WLPEKLNRRIV()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9B73410", Offset = "0x9B71E10", VA = "0x189B73410")]
			internal void WLJXNETUHXM(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9B72EF0", Offset = "0x9B718F0", VA = "0x189B72EF0")]
			internal float MGTRMDGEWMX(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9B73050", Offset = "0x9B71A50", VA = "0x189B73050")]
			internal void PNBXEIOSJPW(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B725E0", Offset = "0x9B70FE0", VA = "0x189B725E0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B729E0", Offset = "0x9B713E0", VA = "0x189B729E0")]
		public FTDWQMDPMAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class YSNHRFZNYDP : SQXVZWZSUCL<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class GRHZZGJLVFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public EFSRNAMUUKX TGJGFLSHRHC;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9B736B0", Offset = "0x9B720B0", VA = "0x189B736B0")]
			internal int WMKFZMPHDCF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9B73650", Offset = "0x9B72050", VA = "0x189B73650")]
			internal void WMEZCFVJTQW(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B78070", Offset = "0x9B76A70", VA = "0x189B78070", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9B78200", Offset = "0x9B76C00", VA = "0x189B78200")]
		public YSNHRFZNYDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal struct Candidate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int drawerIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NetworkProperty property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int priority;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class EPZYUEBYMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B72520", Offset = "0x9B70F20", VA = "0x189B72520")]
		public static void VUYEFWBFUGC(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9B70DB0", Offset = "0x9B6F7B0", VA = "0x189B70DB0")]
		public static NativeList<NetworkProperty> BRAZZRLSVYR(NativeObjectLocalIdArray a, JALXIPKYOPE b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9B71030", Offset = "0x9B6FA30", VA = "0x189B71030")]
		private static bool PBMSDJRBZSE(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class LCZOQLMCXCS : EFSRNAMUUKX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty TGJGFLSHRHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly JALXIPKYOPE CECZXJTQYDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray SZSZHYVGGYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9B74610", Offset = "0x9B73010", VA = "0x189B74610", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool TKCLWUCJLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9B74390", Offset = "0x9B72D90", VA = "0x189B74390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject EECHEESZWMK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9B745C0", Offset = "0x9B72FC0", VA = "0x189B745C0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9B74670", Offset = "0x9B73070", VA = "0x189B74670", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PVIQOTRYGPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9B747E0", Offset = "0x9B731E0", VA = "0x189B747E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9B74880", Offset = "0x9B73280", VA = "0x189B74880", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9B74A30", Offset = "0x9B73430", VA = "0x189B74A30")]
		public LCZOQLMCXCS(NativeObjectLocalIdArray a, NetworkProperty b, JALXIPKYOPE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B74920", Offset = "0x9B73320", VA = "0x189B74920")]
		private void YORNVBRYBCI(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9B744E0", Offset = "0x9B72EE0", VA = "0x189B744E0", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9B746C0", Offset = "0x9B730C0", VA = "0x189B746C0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9B74410", Offset = "0x9B72E10", VA = "0x189B74410", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class NXPUJCCYOYP : TPUPLHIGUTW, SEMWBKXPSCA, TPQLDRBRGAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public EFSRNAMUUKX TGJGFLSHRHC;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9B72C00", Offset = "0x9B71600", VA = "0x189B72C00")]
			internal bool WMKFZMPHDCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B72B80", Offset = "0x9B71580", VA = "0x189B72B80")]
			internal string WMEZCFVJTQW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9B72AF0", Offset = "0x9B714F0", VA = "0x189B72AF0")]
			internal void WLZSEZBMKFN(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9B72A20", Offset = "0x9B71420", VA = "0x189B72A20")]
			internal string WLULHSHPAUE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty OPNSYIBLXMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9B75130", Offset = "0x9B73B30", VA = "0x189B75130", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9B751A0", Offset = "0x9B73BA0", VA = "0x189B751A0", Slot = "5")]
		public void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public NXPUJCCYOYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class GTBYYYOUUJV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly JALXIPKYOPE ZYDDIBTKENX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly KXNTIHEZPWZ RHMMKLTBUUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> YRACNMRCEJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<JCIOFENRTQT> RRGWMGIFRUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<JCIOFENRTQT, List<Candidate>> ZRMRWPXSZKH;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9B74280", Offset = "0x9B72C80", VA = "0x189B74280")]
		public GTBYYYOUUJV(JALXIPKYOPE a, KXNTIHEZPWZ b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9B73DC0", Offset = "0x9B727C0", VA = "0x189B73DC0")]
		public void UHSLNVKQWMB(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9B74100", Offset = "0x9B72B00", VA = "0x189B74100")]
		private void ZQVFPWWZEIH(JCIOFENRTQT a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9B73850", Offset = "0x9B72250", VA = "0x189B73850")]
		public void BITMIQVVOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9B73950", Offset = "0x9B72350", VA = "0x189B73950")]
		private void QFLAZKBZHTR(JCIOFENRTQT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B738B0", Offset = "0x9B722B0", VA = "0x189B738B0")]
		private void DRTJYRVKWFQ(JCIOFENRTQT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class LYMYFXRLBHE : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type XIFUWJIDDEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type GOSFBHMBQMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator ULWCKXMDKCB;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty LUJUTENMHGN
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x9B74BD0", Offset = "0x9B735D0", VA = "0x189B74BD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15D99C0", Offset = "0x15D83C0", VA = "0x1815D99C0")]
			[DebuggerHidden]
			public LYMYFXRLBHE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9B74F10", Offset = "0x9B73910", VA = "0x189B74F10", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9B74C20", Offset = "0x9B73620", VA = "0x189B74C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9B74FE0", Offset = "0x9B739E0", VA = "0x189B74FE0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9B74FA0", Offset = "0x9B739A0", VA = "0x189B74FA0", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9B74B20", Offset = "0x9B73520", VA = "0x189B74B20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> GBLWSRPLJYW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9B74B20", Offset = "0x9B73520", VA = "0x189B74B20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> LEIGGTYIKDP;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B75BD0", Offset = "0x9B745D0", VA = "0x189B75BD0")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9B75AB0", Offset = "0x9B744B0", VA = "0x189B75AB0")]
		[IteratorStateMachine(typeof(LYMYFXRLBHE))]
		public IEnumerable<NetworkProperty> XHOALXYKXMH(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9B759B0", Offset = "0x9B743B0", VA = "0x189B759B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9B75A30", Offset = "0x9B74430", VA = "0x189B75A30")]
		private long SZFJXCVXQYK(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B759F0", Offset = "0x9B743F0", VA = "0x189B759F0")]
		private long SZFJXCVXQYK(Type a)
		{
			return default(long);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal struct PropertyBitmap : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private NativeBitArray bitmap;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9B760E0", Offset = "0x9B74AE0", VA = "0x189B760E0")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9B75F40", Offset = "0x9B74940", VA = "0x189B75F40")]
		public static PropertyBitmap WMLSVZEVVDP(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9B760D0", Offset = "0x9B74AD0", VA = "0x189B760D0")]
		public bool WREUKVHAOCT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9B75F30", Offset = "0x9B74930", VA = "0x189B75F30")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9B75DC0", Offset = "0x9B747C0", VA = "0x189B75DC0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9B75E70", Offset = "0x9B74870", VA = "0x189B75E70")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9B75F20", Offset = "0x9B74920", VA = "0x189B75F20", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly JALXIPKYOPE ZYDDIBTKENX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<TPQLDRBRGAM> PXDELPMCGSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType LEIGGTYIKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> WDJWCIWEJXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> ALUEPKGSVJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<TPQLDRBRGAM> QHSGZUCPTNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B77320", Offset = "0x9B75D20", VA = "0x189B77320")]
		public PropertyDrawerCandidates(JALXIPKYOPE configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B76310", Offset = "0x9B74D10", VA = "0x189B76310")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9B763F0", Offset = "0x9B74DF0", VA = "0x189B763F0")]
		public void EHDLJZGRLPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9B765C0", Offset = "0x9B74FC0", VA = "0x189B765C0")]
		public NativeList<Candidate> FDTFZPIMIJD(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9B76DC0", Offset = "0x9B757C0", VA = "0x189B76DC0")]
		private bool KFYXTKUPFOP(TPQLDRBRGAM a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3E432E0", Offset = "0x3E41CE0", VA = "0x183E432E0")]
		private void KVWFIFLJNHA<b, a>(Action<b, a> a) where b : TPQLDRBRGAM where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B76590", Offset = "0x9B74F90", VA = "0x189B76590")]
		private void EMZSAUKHPDO(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3E435F0", Offset = "0x3E41FF0", VA = "0x183E435F0")]
		private c PSUAZMNVIER<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B771A0", Offset = "0x9B75BA0", VA = "0x189B771A0")]
		private int TPYFAWKJCRC(TPQLDRBRGAM a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9B76F10", Offset = "0x9B75910", VA = "0x189B76F10")]
		private void PLBZEQWOBWI(SEMWBKXPSCA a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9B76A90", Offset = "0x9B75490", VA = "0x189B76A90")]
		private void HBACHRKJIOJ(YBMOHIVCIWV a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B76130", Offset = "0x9B74B30", VA = "0x189B76130")]
		private void BQNPZNLWSBH(NEFKBHGBRDD a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B76240", Offset = "0x9B74C40", VA = "0x189B76240")]
		private void DECMFPZLNJS(TPUPLHIGUTW a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<TPQLDRBRGAM> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> QLGCNHABRQT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xF5DD60", Offset = "0xF5C760", VA = "0x180F5DD60")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B77A40", Offset = "0x9B76440", VA = "0x189B77A40")]
		public PropertyShadowing(List<TPQLDRBRGAM> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B77590", Offset = "0x9B75F90", VA = "0x189B77590", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9B77740", Offset = "0x9B76140", VA = "0x189B77740")]
		private NativeList<Candidate> OQYWZNVJOLZ(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9B775D0", Offset = "0x9B75FD0", VA = "0x189B775D0")]
		private bool EVUNQMBTXWE(TPQLDRBRGAM a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9B77460", Offset = "0x9B75E60", VA = "0x189B77460")]
		private void DPRNCLNXADB(TPQLDRBRGAM a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B77AD0", Offset = "0x9B764D0", VA = "0x189B77AD0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9B77AE0", Offset = "0x9B764E0", VA = "0x189B77AE0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B77B20", Offset = "0x9B76520", VA = "0x189B77B20")]
		public SpecificPropertyDrawer(int Priority = 1)
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
