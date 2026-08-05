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
		[Cpp2IlInjected.Address(RVA = "0x99F1BC0", Offset = "0x99F09C0", VA = "0x1899F1BC0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99F59E0", Offset = "0x99F47E0", VA = "0x1899F59E0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99F5A00", Offset = "0x99F4800", VA = "0x1899F5A00")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99F5270", Offset = "0x99F4070", VA = "0x1899F5270", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99F52D0", Offset = "0x99F40D0", VA = "0x1899F52D0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99F5C20", Offset = "0x99F4A20", VA = "0x1899F5C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F45E0", Offset = "0x99F33E0", VA = "0x1899F45E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BAWJCOIJFZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4EAE700", Offset = "0x4EAD500", VA = "0x184EAE700")]
			internal bool DACAPZTKDOH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x78C0770", Offset = "0x78BF570", VA = "0x1878C0770")]
		protected VNWQVNWMKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1EF0", Offset = "0x7EA0CF0", VA = "0x187EA1EF0")]
		protected void OOGCFGCNHMN(LXTIMKXBYZO a, EFSRNAMUUKX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1CF0", Offset = "0x7EA0AF0", VA = "0x187EA1CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4100920", Offset = "0x40FF720", VA = "0x184100920")]
		protected static b FRICHGVQBZR<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4100B00", Offset = "0x40FF900", VA = "0x184100B00")]
		protected static void ZJMRWBFQXQO<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BAWJCOIJFZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4EAE930", Offset = "0x4EAD730", VA = "0x184EAE930")]
			internal bool DACAPZTKDOH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78C0770", Offset = "0x78BF570", VA = "0x1878C0770")]
		protected SQXVZWZSUCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78BF7F0", Offset = "0x78BE5F0", VA = "0x1878BF7F0")]
		protected void OOGCFGCNHMN(LXTIMKXBYZO a, EFSRNAMUUKX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x78BE670", Offset = "0x78BD470", VA = "0x1878BE670")]
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
			[Cpp2IlInjected.Address(RVA = "0x171DC70", Offset = "0x171CA70", VA = "0x18171DC70", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99EDCF0", Offset = "0x99ECAF0", VA = "0x1899EDCF0", Slot = "6")]
		public void InitExternal(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99EE010", Offset = "0x99ECE10", VA = "0x1899EE010", Slot = "7")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99EE710", Offset = "0x99ED510", VA = "0x1899EE710", Slot = "4")]
		public void UVQBYUIKFQV(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99EE4B0", Offset = "0x99ED2B0", VA = "0x1899EE4B0")]
		private void OSEAKYBPNOL(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99EE520", Offset = "0x99ED320", VA = "0x1899EE520")]
		private void QGDBZDLJRFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99EE180", Offset = "0x99ECF80", VA = "0x1899EE180")]
		private void NMFIASHFGKT(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99EE110", Offset = "0x99ECF10", VA = "0x1899EE110", Slot = "8")]
		private void MBYFDPTTQYS(IKBIXEGYPOI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1025A60", Offset = "0x1024860", VA = "0x181025A60", Slot = "9")]
		private void NXHIFSUZYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99EEC10", Offset = "0x99EDA10", VA = "0x1899EEC10")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class UWCLNLKGDBG : QFIBWAZCZIU
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99F48F0", Offset = "0x99F36F0", VA = "0x1899F48F0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99F4850", Offset = "0x99F3650", VA = "0x1899F4850", Slot = "7")]
		public override bool INGXCVFWEJY(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99F45E0", Offset = "0x99F33E0", VA = "0x1899F45E0")]
		public UWCLNLKGDBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class XRDWIRIZYKJ : QFIBWAZCZIU
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99F4A40", Offset = "0x99F3840", VA = "0x1899F4A40", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99F49A0", Offset = "0x99F37A0", VA = "0x1899F49A0", Slot = "7")]
		public override bool INGXCVFWEJY(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99F45E0", Offset = "0x99F33E0", VA = "0x1899F45E0")]
		public XRDWIRIZYKJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class BOLNJFPBGTC : VNWQVNWMKLE<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99ED7F0", Offset = "0x99EC5F0", VA = "0x1899ED7F0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99ED940", Offset = "0x99EC740", VA = "0x1899ED940")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x99F22B0", Offset = "0x99F10B0", VA = "0x1899F22B0")]
			internal (int, int) WMKFZMPHDCF()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x99F2160", Offset = "0x99F0F60", VA = "0x1899F2160")]
			internal void WMEZCFVJTQW((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] HBIUSKSOFHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99F4D90", Offset = "0x99F3B90", VA = "0x1899F4D90", Slot = "9")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, RLGFHYWFQMI b, JALXIPKYOPE c, KXNTIHEZPWZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99F5140", Offset = "0x99F3F40", VA = "0x1899F5140")]
		public YYUKCJEXTUY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class YLYZKMUXXMF : SQXVZWZSUCL<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99F4AF0", Offset = "0x99F38F0", VA = "0x1899F4AF0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99F4B80", Offset = "0x99F3980", VA = "0x1899F4B80")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x99F02A0", Offset = "0x99EF0A0", VA = "0x1899F02A0")]
			internal string WMKFZMPHDCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x99F00F0", Offset = "0x99EEEF0", VA = "0x1899F00F0")]
			internal void WMEZCFVJTQW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99EF800", Offset = "0x99EE600", VA = "0x1899EF800", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99EF990", Offset = "0x99EE790", VA = "0x1899EF990")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x99F0380", Offset = "0x99EF180", VA = "0x1899F0380")]
			internal string WMKFZMPHDCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x99F0170", Offset = "0x99EEF70", VA = "0x1899F0170")]
			internal void WMEZCFVJTQW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99F4680", Offset = "0x99F3480", VA = "0x1899F4680", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99F4810", Offset = "0x99F3610", VA = "0x1899F4810")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x99F0300", Offset = "0x99EF100", VA = "0x1899F0300")]
			internal float WMKFZMPHDCF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x99F0250", Offset = "0x99EF050", VA = "0x1899F0250")]
			internal void WMEZCFVJTQW(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x99F0070", Offset = "0x99EEE70", VA = "0x1899F0070")]
			internal float WLZSEZBMKFN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x99F0050", Offset = "0x99EEE50", VA = "0x1899F0050")]
			internal void WLULHSHPAUE(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x99EFFD0", Offset = "0x99EEDD0", VA = "0x1899EFFD0")]
			internal float WLPEKLNRRIV()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x99EFFB0", Offset = "0x99EEDB0", VA = "0x1899EFFB0")]
			internal void WLJXNETUHXM(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x99EFF40", Offset = "0x99EED40", VA = "0x1899EFF40")]
			internal float WARLNCMJAFI(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x99EFE60", Offset = "0x99EEC60", VA = "0x1899EFE60")]
			internal void SLZSNNRYKOV(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x99EEC90", Offset = "0x99EDA90", VA = "0x1899EEC90", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99EF090", Offset = "0x99EDE90", VA = "0x1899EF090")]
		public DFVOCLYHCVI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class GMCEFXMESTT : SQXVZWZSUCL<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99EF9D0", Offset = "0x99EE7D0", VA = "0x1899EF9D0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99EFA60", Offset = "0x99EE860", VA = "0x1899EFA60")]
		public GMCEFXMESTT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class APEHSTSUCDY : SQXVZWZSUCL<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99ED720", Offset = "0x99EC520", VA = "0x1899ED720", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99ED7B0", Offset = "0x99EC5B0", VA = "0x1899ED7B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x99F0370", Offset = "0x99EF170", VA = "0x1899F0370")]
			internal float WMKFZMPHDCF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x99F0160", Offset = "0x99EEF60", VA = "0x1899F0160")]
			internal void WMEZCFVJTQW(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x99F00E0", Offset = "0x99EEEE0", VA = "0x1899F00E0")]
			internal float WLZSEZBMKFN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x99F0060", Offset = "0x99EEE60", VA = "0x1899F0060")]
			internal void WLULHSHPAUE(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x99F0040", Offset = "0x99EEE40", VA = "0x1899F0040")]
			internal float WLPEKLNRRIV()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x99EFFC0", Offset = "0x99EEDC0", VA = "0x1899EFFC0")]
			internal void WLJXNETUHXM(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x99EFAA0", Offset = "0x99EE8A0", VA = "0x1899EFAA0")]
			internal float MGTRMDGEWMX(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x99EFC00", Offset = "0x99EEA00", VA = "0x1899EFC00")]
			internal void PNBXEIOSJPW(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99EF190", Offset = "0x99EDF90", VA = "0x1899EF190", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99EF590", Offset = "0x99EE390", VA = "0x1899EF590")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GRHZZGJLVFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x99F0260", Offset = "0x99EF060", VA = "0x1899F0260")]
			internal int WMKFZMPHDCF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x99F0200", Offset = "0x99EF000", VA = "0x1899F0200")]
			internal void WMEZCFVJTQW(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x99F4BC0", Offset = "0x99F39C0", VA = "0x1899F4BC0", Slot = "5")]
		public override void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99F4D50", Offset = "0x99F3B50", VA = "0x1899F4D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x99EF0D0", Offset = "0x99EDED0", VA = "0x1899EF0D0")]
		public static void VUYEFWBFUGC(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x99ED980", Offset = "0x99EC780", VA = "0x1899ED980")]
		public static NativeList<NetworkProperty> BRAZZRLSVYR(NativeObjectLocalIdArray a, JALXIPKYOPE b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99EDC00", Offset = "0x99ECA00", VA = "0x1899EDC00")]
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
			[Cpp2IlInjected.Address(RVA = "0x99F11B0", Offset = "0x99EFFB0", VA = "0x1899F11B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool TKCLWUCJLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x99F0F30", Offset = "0x99EFD30", VA = "0x1899F0F30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject EECHEESZWMK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x99F1160", Offset = "0x99EFF60", VA = "0x1899F1160", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x99F1210", Offset = "0x99F0010", VA = "0x1899F1210", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PVIQOTRYGPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x99F1380", Offset = "0x99F0180", VA = "0x1899F1380", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x99F1420", Offset = "0x99F0220", VA = "0x1899F1420", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99F15D0", Offset = "0x99F03D0", VA = "0x1899F15D0")]
		public LCZOQLMCXCS(NativeObjectLocalIdArray a, NetworkProperty b, JALXIPKYOPE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99F14C0", Offset = "0x99F02C0", VA = "0x1899F14C0")]
		private void YORNVBRYBCI(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x99F1080", Offset = "0x99EFE80", VA = "0x1899F1080", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99F1260", Offset = "0x99F0060", VA = "0x1899F1260", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99F0FB0", Offset = "0x99EFDB0", VA = "0x1899F0FB0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x99EF7B0", Offset = "0x99EE5B0", VA = "0x1899EF7B0")]
			internal bool WMKFZMPHDCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x99EF730", Offset = "0x99EE530", VA = "0x1899EF730")]
			internal string WMEZCFVJTQW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x99EF6A0", Offset = "0x99EE4A0", VA = "0x1899EF6A0")]
			internal void WLZSEZBMKFN(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x99EF5D0", Offset = "0x99EE3D0", VA = "0x1899EF5D0")]
			internal string WLULHSHPAUE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty OPNSYIBLXMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x99F1CC0", Offset = "0x99F0AC0", VA = "0x1899F1CC0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x99F1D30", Offset = "0x99F0B30", VA = "0x1899F1D30", Slot = "5")]
		public void NMFIASHFGKT(EFSRNAMUUKX a, KXNTIHEZPWZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F0E20", Offset = "0x99EFC20", VA = "0x1899F0E20")]
		public GTBYYYOUUJV(JALXIPKYOPE a, KXNTIHEZPWZ b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99F0970", Offset = "0x99EF770", VA = "0x1899F0970")]
		public void UHSLNVKQWMB(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99F0CB0", Offset = "0x99EFAB0", VA = "0x1899F0CB0")]
		private void ZQVFPWWZEIH(JCIOFENRTQT a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99F0400", Offset = "0x99EF200", VA = "0x1899F0400")]
		public void BITMIQVVOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99F0500", Offset = "0x99EF300", VA = "0x1899F0500")]
		private void QFLAZKBZHTR(JCIOFENRTQT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99F0460", Offset = "0x99EF260", VA = "0x1899F0460")]
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
				[Cpp2IlInjected.Address(RVA = "0xDDD300", Offset = "0xDDC100", VA = "0x180DDD300", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x99F1770", Offset = "0x99F0570", VA = "0x1899F1770", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15A3320", Offset = "0x15A2120", VA = "0x1815A3320")]
			[DebuggerHidden]
			public LYMYFXRLBHE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x99F1AA0", Offset = "0x99F08A0", VA = "0x1899F1AA0", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x99F17C0", Offset = "0x99F05C0", VA = "0x1899F17C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x99F1B70", Offset = "0x99F0970", VA = "0x1899F1B70")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x99F1B30", Offset = "0x99F0930", VA = "0x1899F1B30", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x99F16C0", Offset = "0x99F04C0", VA = "0x1899F16C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> GBLWSRPLJYW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x99F16C0", Offset = "0x99F04C0", VA = "0x1899F16C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F2740", Offset = "0x99F1540", VA = "0x1899F2740")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99F2620", Offset = "0x99F1420", VA = "0x1899F2620")]
		[IteratorStateMachine(typeof(LYMYFXRLBHE))]
		public IEnumerable<NetworkProperty> XHOALXYKXMH(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99F2520", Offset = "0x99F1320", VA = "0x1899F2520", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99F25A0", Offset = "0x99F13A0", VA = "0x1899F25A0")]
		private long SZFJXCVXQYK(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99F2560", Offset = "0x99F1360", VA = "0x1899F2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F2C50", Offset = "0x99F1A50", VA = "0x1899F2C50")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x99F2AB0", Offset = "0x99F18B0", VA = "0x1899F2AB0")]
		public static PropertyBitmap WMLSVZEVVDP(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x99F2C40", Offset = "0x99F1A40", VA = "0x1899F2C40")]
		public bool WREUKVHAOCT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x99F2AA0", Offset = "0x99F18A0", VA = "0x1899F2AA0")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x99F2930", Offset = "0x99F1730", VA = "0x1899F2930")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x99F29E0", Offset = "0x99F17E0", VA = "0x1899F29E0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x99F2A90", Offset = "0x99F1890", VA = "0x1899F2A90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99F3E70", Offset = "0x99F2C70", VA = "0x1899F3E70")]
		public PropertyDrawerCandidates(JALXIPKYOPE configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99F2E80", Offset = "0x99F1C80", VA = "0x1899F2E80")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x99F2F60", Offset = "0x99F1D60", VA = "0x1899F2F60")]
		public void EHDLJZGRLPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x99F3130", Offset = "0x99F1F30", VA = "0x1899F3130")]
		public NativeList<Candidate> FDTFZPIMIJD(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x99F3920", Offset = "0x99F2720", VA = "0x1899F3920")]
		private bool KFYXTKUPFOP(TPQLDRBRGAM a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3CB0", Offset = "0x3DF2AB0", VA = "0x183DF3CB0")]
		private void KVWFIFLJNHA<b, a>(Action<b, a> a) where b : TPQLDRBRGAM where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x99F3100", Offset = "0x99F1F00", VA = "0x1899F3100")]
		private void EMZSAUKHPDO(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF3FC0", Offset = "0x3DF2DC0", VA = "0x183DF3FC0")]
		private c PSUAZMNVIER<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x99F3CF0", Offset = "0x99F2AF0", VA = "0x1899F3CF0")]
		private int TPYFAWKJCRC(TPQLDRBRGAM a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x99F3A70", Offset = "0x99F2870", VA = "0x1899F3A70")]
		private void PLBZEQWOBWI(SEMWBKXPSCA a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x99F3600", Offset = "0x99F2400", VA = "0x1899F3600")]
		private void HBACHRKJIOJ(YBMOHIVCIWV a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x99F2CA0", Offset = "0x99F1AA0", VA = "0x1899F2CA0")]
		private void BQNPZNLWSBH(NEFKBHGBRDD a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x99F2DB0", Offset = "0x99F1BB0", VA = "0x1899F2DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x99F4590", Offset = "0x99F3390", VA = "0x1899F4590")]
		public PropertyShadowing(List<TPQLDRBRGAM> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x99F40E0", Offset = "0x99F2EE0", VA = "0x1899F40E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x99F4290", Offset = "0x99F3090", VA = "0x1899F4290")]
		private NativeList<Candidate> OQYWZNVJOLZ(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x99F4120", Offset = "0x99F2F20", VA = "0x1899F4120")]
		private bool EVUNQMBTXWE(TPQLDRBRGAM a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x99F3FB0", Offset = "0x99F2DB0", VA = "0x1899F3FB0")]
		private void DPRNCLNXADB(TPQLDRBRGAM a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x99F4620", Offset = "0x99F3420", VA = "0x1899F4620", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x99F4630", Offset = "0x99F3430", VA = "0x1899F4630")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x99F4670", Offset = "0x99F3470", VA = "0x1899F4670")]
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
