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
		[Cpp2IlInjected.Address(RVA = "0x9943D70", Offset = "0x9943170", VA = "0x189943D70", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		private int[] YTBMQLWISIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset TSFXVIKPUMV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9949190", Offset = "0x9948590", VA = "0x189949190", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9948820", Offset = "0x9947C20", VA = "0x189948820")]
		private void BAZLOGTATAR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9948A40", Offset = "0x9947E40", VA = "0x189948A40", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9948AA0", Offset = "0x9947EA0", VA = "0x189948AA0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99491B0", Offset = "0x99485B0", VA = "0x1899491B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class PIDPTYHQDXH : BWHQMDJBALX<Enum>, MAHDKAORIZY, SMZSAFSYTKN, IXQMLOKWQAV
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool DPQAEQJCORN(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9942880", Offset = "0x9941C80", VA = "0x189942880")]
		protected PIDPTYHQDXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class BWHQMDJBALX<a> : SMZSAFSYTKN, IXQMLOKWQAV where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class KDEBKHUDUUH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public JYLQYVULPSG RREMYBJOILF;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public KDEBKHUDUUH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6743C40", Offset = "0x6743040", VA = "0x186743C40")]
			internal bool UNHXPICWZQS()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E9A360", Offset = "0x4E99760", VA = "0x184E9A360")]
		protected BWHQMDJBALX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E9A170", Offset = "0x4E99570", VA = "0x184E9A170")]
		protected void IBDWVANTAZC(CZMVZGNNVDN a, JYLQYVULPSG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E99B90", Offset = "0x4E98F90", VA = "0x184E99B90")]
		protected void AAGGEULRYQC(BQLMPHORWRC<a> a, JYLQYVULPSG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class JTKXUUBNAES : EBEJOVRZPRQ, IXQMLOKWQAV
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] THTOQPYTASR
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] PEFIBSUZUTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void IYYSGEDDJXC(JYLQYVULPSG a, LZGLFWTOFEZ b, UQBBTQHOWWJ c, FTGGXJYXXPC d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B7FED0", Offset = "0x3B7F2D0", VA = "0x183B7FED0")]
		protected static b LGCODAJVEEI<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B800B0", Offset = "0x3B7F4B0", VA = "0x183B800B0")]
		protected static void QUPPRKJGADP<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected JTKXUUBNAES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class MBRTWOOLSZS<a> : SMZSAFSYTKN, IXQMLOKWQAV where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class KDEBKHUDUUH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public JYLQYVULPSG RREMYBJOILF;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public KDEBKHUDUUH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6743B50", Offset = "0x6742F50", VA = "0x186743B50")]
			internal bool UNHXPICWZQS()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E9A360", Offset = "0x4E99760", VA = "0x184E9A360")]
		protected MBRTWOOLSZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F88D70", Offset = "0x6F88170", VA = "0x186F88D70")]
		protected void IBDWVANTAZC(CZMVZGNNVDN a, JYLQYVULPSG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F87850", Offset = "0x6F86C50", VA = "0x186F87850")]
		protected void AAGGEULRYQC(BQLMPHORWRC<a> a, JYLQYVULPSG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(LZGLFWTOFEZ), new string[] { })]
	internal class ConfigUIService : LZGLFWTOFEZ, HDMQKUVENYZ, CKGGJPDKIOP, DYGRHSQNQBH, TQABOQMECSF
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private UQBBTQHOWWJ WFUDWODGTCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private FTGGXJYXXPC SUMTTFNKVBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates TVRSDDUCMRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray SETOONJSUFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<JYLQYVULPSG> CDCXBRVVKJN;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray GDKAYGPCBNG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x171F7B0", Offset = "0x171EBB0", VA = "0x18171F7B0", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9941CC0", Offset = "0x99410C0", VA = "0x189941CC0", Slot = "6")]
		public void InitExternal(GEZRGCKOUXX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9942530", Offset = "0x9941930", VA = "0x189942530", Slot = "7")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99420C0", Offset = "0x99414C0", VA = "0x1899420C0", Slot = "4")]
		public void VVAEFTXYQKS(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9942050", Offset = "0x9941450", VA = "0x189942050")]
		private void QMOBQZJXJOM(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9941780", Offset = "0x9940B80", VA = "0x189941780")]
		private void ITAXFPNMYWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9941980", Offset = "0x9940D80", VA = "0x189941980")]
		private void IYYSGEDDJXC(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9941FE0", Offset = "0x99413E0", VA = "0x189941FE0", Slot = "8")]
		private void LJERCYKGCZL(GEZRGCKOUXX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x102E920", Offset = "0x102DD20", VA = "0x18102E920", Slot = "9")]
		private void XGDIBOIJOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99426B0", Offset = "0x9941AB0", VA = "0x1899426B0")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class IWXGLUWBWDZ : PIDPTYHQDXH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9942C80", Offset = "0x9942080", VA = "0x189942C80", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9942BE0", Offset = "0x9941FE0", VA = "0x189942BE0", Slot = "7")]
		public override bool DPQAEQJCORN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9942880", Offset = "0x9941C80", VA = "0x189942880")]
		public IWXGLUWBWDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class DIAVVKRTVPK : PIDPTYHQDXH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99427D0", Offset = "0x9941BD0", VA = "0x1899427D0", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9942730", Offset = "0x9941B30", VA = "0x189942730", Slot = "7")]
		public override bool DPQAEQJCORN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9942880", Offset = "0x9941C80", VA = "0x189942880")]
		public DIAVVKRTVPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class RFPTZWDYLAN : BWHQMDJBALX<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99464D0", Offset = "0x99458D0", VA = "0x1899464D0", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9946620", Offset = "0x9945A20", VA = "0x189946620")]
		public RFPTZWDYLAN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class NJEWPHTEIHL : JTKXUUBNAES
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ECWTQFSOHXI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LZGLFWTOFEZ FPZAMPWUQCV;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public ECWTQFSOHXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x99428C0", Offset = "0x9941CC0", VA = "0x1899428C0")]
			internal (int, int) BSFEQEBHXIC()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9942A40", Offset = "0x9941E40", VA = "0x189942A40")]
			internal void BSKLNKVFGTL((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] THTOQPYTASR
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] PEFIBSUZUTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9943F40", Offset = "0x9943340", VA = "0x189943F40", Slot = "9")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, LZGLFWTOFEZ b, UQBBTQHOWWJ c, FTGGXJYXXPC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99442F0", Offset = "0x99436F0", VA = "0x1899442F0")]
		public NJEWPHTEIHL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class MGXKKAMFFGG : MBRTWOOLSZS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9943E70", Offset = "0x9943270", VA = "0x189943E70", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9943F00", Offset = "0x9943300", VA = "0x189943F00")]
		public MGXKKAMFFGG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class BWOBMYSVENW : MBRTWOOLSZS<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class VXVANLUKZAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public JYLQYVULPSG RREMYBJOILF;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x99475A0", Offset = "0x99469A0", VA = "0x1899475A0")]
			internal string BSFEQEBHXIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x99477E0", Offset = "0x9946BE0", VA = "0x1899477E0")]
			internal void BSKLNKVFGTL(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9941240", Offset = "0x9940640", VA = "0x189941240", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99413D0", Offset = "0x99407D0", VA = "0x1899413D0")]
		public BWOBMYSVENW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class VOQZVWQCTVN : MBRTWOOLSZS<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class VXVANLUKZAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public JYLQYVULPSG RREMYBJOILF;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9947600", Offset = "0x9946A00", VA = "0x189947600")]
			internal string BSFEQEBHXIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9947750", Offset = "0x9946B50", VA = "0x189947750")]
			internal void BSKLNKVFGTL(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99470F0", Offset = "0x99464F0", VA = "0x1899470F0", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9947280", Offset = "0x9946680", VA = "0x189947280")]
		public VOQZVWQCTVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class WUHBYOWTNSV : MBRTWOOLSZS<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class VXVANLUKZAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public JYLQYVULPSG RREMYBJOILF;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x99476D0", Offset = "0x9946AD0", VA = "0x1899476D0")]
			internal float BSFEQEBHXIC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9947850", Offset = "0x9946C50", VA = "0x189947850")]
			internal void BSKLNKVFGTL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9947500", Offset = "0x9946900", VA = "0x189947500")]
			internal float BRUQVQNNELK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9947590", Offset = "0x9946990", VA = "0x189947590")]
			internal void BRZXSXHKNWT(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x99478C0", Offset = "0x9946CC0", VA = "0x1899478C0")]
			internal float BTAGFFCXJBM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9947940", Offset = "0x9946D40", VA = "0x189947940")]
			internal void BTFNCLWUSMV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9947D10", Offset = "0x9947110", VA = "0x189947D10")]
			internal float WJEUAEVQICN(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9947D80", Offset = "0x9947180", VA = "0x189947D80")]
			internal void YVQVCWUSPVU(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9947E60", Offset = "0x9947260", VA = "0x189947E60", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9948260", Offset = "0x9947660", VA = "0x189948260")]
		public WUHBYOWTNSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class ZFISFQJLOZO : MBRTWOOLSZS<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9948750", Offset = "0x9947B50", VA = "0x189948750", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99487E0", Offset = "0x9947BE0", VA = "0x1899487E0")]
		public ZFISFQJLOZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class TGOKYOGVGTZ : MBRTWOOLSZS<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9947020", Offset = "0x9946420", VA = "0x189947020", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99470B0", Offset = "0x99464B0", VA = "0x1899470B0")]
		public TGOKYOGVGTZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class BWHMWJMGBMG : MBRTWOOLSZS<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class VXVANLUKZAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public JYLQYVULPSG RREMYBJOILF;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9947680", Offset = "0x9946A80", VA = "0x189947680")]
			internal float BSFEQEBHXIC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9947740", Offset = "0x9946B40", VA = "0x189947740")]
			internal void BSKLNKVFGTL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9947570", Offset = "0x9946970", VA = "0x189947570")]
			internal float BRUQVQNNELK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9947580", Offset = "0x9946980", VA = "0x189947580")]
			internal void BRZXSXHKNWT(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x99478B0", Offset = "0x9946CB0", VA = "0x1899478B0")]
			internal float BTAGFFCXJBM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9947930", Offset = "0x9946D30", VA = "0x189947930")]
			internal void BTFNCLWUSMV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9947950", Offset = "0x9946D50", VA = "0x189947950")]
			internal float JOCDYDXKYEG(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9947AB0", Offset = "0x9946EB0", VA = "0x189947AB0")]
			internal void VIUMWDRNMWZ(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9940E00", Offset = "0x9940200", VA = "0x189940E00", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9941200", Offset = "0x9940600", VA = "0x189941200")]
		public BWHMWJMGBMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class SULVXGTSUDQ : MBRTWOOLSZS<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class VXVANLUKZAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JYLQYVULPSG RREMYBJOILF;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9947690", Offset = "0x9946A90", VA = "0x189947690")]
			internal int BSFEQEBHXIC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9947860", Offset = "0x9946C60", VA = "0x189947860")]
			internal void BSKLNKVFGTL(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9946DF0", Offset = "0x99461F0", VA = "0x189946DF0", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9946F80", Offset = "0x9946380", VA = "0x189946F80")]
		public SULVXGTSUDQ()
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
	internal static class GWMSVKZQRGT
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9942B20", Offset = "0x9941F20", VA = "0x189942B20")]
		public static void SNXXQVNSNOB(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9941410", Offset = "0x9940810", VA = "0x189941410")]
		public static NativeList<NetworkProperty> ENZAOSLACPC(NativeObjectLocalIdArray a, UQBBTQHOWWJ b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9941690", Offset = "0x9940A90", VA = "0x189941690")]
		private static bool YGAIDWCTUEB(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RWHSZSKDGHT : JYLQYVULPSG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty RREMYBJOILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly UQBBTQHOWWJ GSPJLTIBNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray SETOONJSUFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool ZIWJLCMIQDX;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x99467B0", Offset = "0x9945BB0", VA = "0x1899467B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BYWDFIHJUYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9946660", Offset = "0x9945A60", VA = "0x189946660", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject DFUAAMETYUD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x99469E0", Offset = "0x9945DE0", VA = "0x1899469E0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9946990", Offset = "0x9945D90", VA = "0x189946990", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GNKDKMVLYVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9946A30", Offset = "0x9945E30", VA = "0x189946A30", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x99468F0", Offset = "0x9945CF0", VA = "0x1899468F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9946D00", Offset = "0x9946100", VA = "0x189946D00")]
		public RWHSZSKDGHT(NativeObjectLocalIdArray a, NetworkProperty b, UQBBTQHOWWJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9946BF0", Offset = "0x9945FF0", VA = "0x189946BF0")]
		private void TZBBGTKJYPP(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9946810", Offset = "0x9945C10", VA = "0x189946810", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9946AD0", Offset = "0x9945ED0", VA = "0x189946AD0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99466E0", Offset = "0x9945AE0", VA = "0x1899466E0", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class YYCHKBLDEBY : CLDTZQWZVUF, SMZSAFSYTKN, IXQMLOKWQAV
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class VUGRTXXDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JYLQYVULPSG RREMYBJOILF;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9947430", Offset = "0x9946830", VA = "0x189947430")]
			internal bool BSFEQEBHXIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9947480", Offset = "0x9946880", VA = "0x189947480")]
			internal string BSKLNKVFGTL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x99472C0", Offset = "0x99466C0", VA = "0x1899472C0")]
			internal void BRUQVQNNELK(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9947350", Offset = "0x9946750", VA = "0x189947350")]
			internal string BRZXSXHKNWT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty WIAAFFAKCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x99482A0", Offset = "0x99476A0", VA = "0x1899482A0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9948310", Offset = "0x9947710", VA = "0x189948310", Slot = "5")]
		public void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public YYCHKBLDEBY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class JJXGNWEZVUW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly UQBBTQHOWWJ WFUDWODGTCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly FTGGXJYXXPC SITLTAOQVKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> BNTRDAAJNVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<JPJHXSEIUXO> MHRJSCOWWBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<JPJHXSEIUXO, List<Candidate>> ODJXDBLXBFM;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9943760", Offset = "0x9942B60", VA = "0x189943760")]
		public JJXGNWEZVUW(UQBBTQHOWWJ a, FTGGXJYXXPC b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9942D30", Offset = "0x9942130", VA = "0x189942D30")]
		public void AUUFOOYHYZU(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9943550", Offset = "0x9942950", VA = "0x189943550")]
		private void VULOOKRSNNA(JPJHXSEIUXO a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99434F0", Offset = "0x99428F0", VA = "0x1899434F0")]
		public void ROMXCJTTVDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9943070", Offset = "0x9942470", VA = "0x189943070")]
		private void BPBJIJMVMHU(JPJHXSEIUXO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99436C0", Offset = "0x9942AC0", VA = "0x1899436C0")]
		private void XTKWBMCLZXP(JPJHXSEIUXO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class LHFEHNEVKPB : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type EQJHIWKHCLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type WAIIGBHOHOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator MXGZQBRVDOG;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty YVFKWABTOCM
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xDE68B0", Offset = "0xDE5CB0", VA = "0x180DE68B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x9943C50", Offset = "0x9943050", VA = "0x189943C50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15B8830", Offset = "0x15B7C30", VA = "0x1815B8830")]
			[DebuggerHidden]
			public LHFEHNEVKPB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9943CA0", Offset = "0x99430A0", VA = "0x189943CA0", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9943970", Offset = "0x9942D70", VA = "0x189943970", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9943870", Offset = "0x9942C70", VA = "0x189943870")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9943D30", Offset = "0x9943130", VA = "0x189943D30", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x99438C0", Offset = "0x9942CC0", VA = "0x1899438C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> AWDSYHWAORN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x99438C0", Offset = "0x9942CC0", VA = "0x1899438C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> IQNFCKXGRJQ;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9944620", Offset = "0x9943A20", VA = "0x189944620")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9944410", Offset = "0x9943810", VA = "0x189944410")]
		[IteratorStateMachine(typeof(LHFEHNEVKPB))]
		public IEnumerable<NetworkProperty> CSPLNAZPYAK(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99444A0", Offset = "0x99438A0", VA = "0x1899444A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99444E0", Offset = "0x99438E0", VA = "0x1899444E0")]
		private long URBZUTBLCAJ(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9944560", Offset = "0x9943960", VA = "0x189944560")]
		private long URBZUTBLCAJ(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x9944B30", Offset = "0x9943F30", VA = "0x189944B30")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x99449A0", Offset = "0x9943DA0", VA = "0x1899449A0")]
		public static PropertyBitmap WOODLPXKDJW(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9944990", Offset = "0x9943D90", VA = "0x189944990")]
		public bool VNWYXTWJHOK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9944980", Offset = "0x9943D80", VA = "0x189944980")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9944810", Offset = "0x9943C10", VA = "0x189944810")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x99448C0", Offset = "0x9943CC0", VA = "0x1899448C0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9944970", Offset = "0x9943D70", VA = "0x189944970", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly UQBBTQHOWWJ WFUDWODGTCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<IXQMLOKWQAV> VDQGOBPPXEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType IQNFCKXGRJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> NSARPMWTTJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> IYYRFTSQYCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool ZIWJLCMIQDX;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<IXQMLOKWQAV> ELRAUWJNUTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9945D60", Offset = "0x9945160", VA = "0x189945D60")]
		public PropertyDrawerCandidates(UQBBTQHOWWJ configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9944C50", Offset = "0x9944050", VA = "0x189944C50")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9944D30", Offset = "0x9944130", VA = "0x189944D30")]
		public void HHFYQPEHLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x99456D0", Offset = "0x9944AD0", VA = "0x1899456D0")]
		public NativeList<Candidate> RCKHRARKLDW(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9944ED0", Offset = "0x99442D0", VA = "0x189944ED0")]
		private bool IXZYSPAXYHI(IXQMLOKWQAV a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9EC0", Offset = "0x3DC92C0", VA = "0x183DC9EC0")]
		private void IYEKLBFOCTV<b, a>(Action<b, a> a) where b : IXQMLOKWQAV where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9945BA0", Offset = "0x9944FA0", VA = "0x189945BA0")]
		private void RTTMQGLNOZV(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9B50", Offset = "0x3DC8F50", VA = "0x183DC9B50")]
		private c DENXDLMNQLQ<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9945350", Offset = "0x9944750", VA = "0x189945350")]
		private int LKEKCBJJSBD(IXQMLOKWQAV a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9945440", Offset = "0x9944840", VA = "0x189945440")]
		private void NIQLZWGFAVN(SMZSAFSYTKN a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9945020", Offset = "0x9944420", VA = "0x189945020")]
		private void JLLVNSBXQBK(MAHDKAORIZY a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9945BD0", Offset = "0x9944FD0", VA = "0x189945BD0")]
		private void UXJYSIIZQNK(EBEJOVRZPRQ a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9944B80", Offset = "0x9943F80", VA = "0x189944B80")]
		private void DLBFUYPCGNZ(CLDTZQWZVUF a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<IXQMLOKWQAV> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> KICSKCWJRNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xF3E410", Offset = "0xF3D810", VA = "0x180F3E410")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9946480", Offset = "0x9945880", VA = "0x189946480")]
		public PropertyShadowing(List<IXQMLOKWQAV> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9945EA0", Offset = "0x99452A0", VA = "0x189945EA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9946010", Offset = "0x9945410", VA = "0x189946010")]
		private NativeList<Candidate> JIPUEJTRWWS(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9946310", Offset = "0x9945710", VA = "0x189946310")]
		private bool UBGDCAWECMD(IXQMLOKWQAV a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9945EE0", Offset = "0x99452E0", VA = "0x189945EE0")]
		private void HQKMCWWNNGW(IXQMLOKWQAV a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9946FC0", Offset = "0x99463C0", VA = "0x189946FC0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9946FD0", Offset = "0x99463D0", VA = "0x189946FD0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9947010", Offset = "0x9946410", VA = "0x189947010")]
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
