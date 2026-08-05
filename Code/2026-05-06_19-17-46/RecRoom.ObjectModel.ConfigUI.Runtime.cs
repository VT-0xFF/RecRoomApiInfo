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
		[Cpp2IlInjected.Address(RVA = "0x9A16410", Offset = "0x9A14E10", VA = "0x189A16410", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B820", Offset = "0x9A1A220", VA = "0x189A1B820", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AEB0", Offset = "0x9A198B0", VA = "0x189A1AEB0")]
		private void BAZLOGTATAR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B0D0", Offset = "0x9A19AD0", VA = "0x189A1B0D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B130", Offset = "0x9A19B30", VA = "0x189A1B130", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B840", Offset = "0x9A1A240", VA = "0x189A1B840")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A14DD0", Offset = "0x9A137D0", VA = "0x189A14DD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public KDEBKHUDUUH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x67CFF30", Offset = "0x67CE930", VA = "0x1867CFF30")]
			internal bool UNHXPICWZQS()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4F19540", Offset = "0x4F17F40", VA = "0x184F19540")]
		protected BWHQMDJBALX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4F19350", Offset = "0x4F17D50", VA = "0x184F19350")]
		protected void IBDWVANTAZC(CZMVZGNNVDN a, JYLQYVULPSG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4F18D70", Offset = "0x4F17770", VA = "0x184F18D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B8B330", Offset = "0x3B89D30", VA = "0x183B8B330")]
		protected static b LGCODAJVEEI<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B8B510", Offset = "0x3B89F10", VA = "0x183B8B510")]
		protected static void QUPPRKJGADP<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public KDEBKHUDUUH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67CFE40", Offset = "0x67CE840", VA = "0x1867CFE40")]
			internal bool UNHXPICWZQS()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4F19540", Offset = "0x4F17F40", VA = "0x184F19540")]
		protected MBRTWOOLSZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7019CF0", Offset = "0x70186F0", VA = "0x187019CF0")]
		protected void IBDWVANTAZC(CZMVZGNNVDN a, JYLQYVULPSG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70187D0", Offset = "0x70171D0", VA = "0x1870187D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x170F520", Offset = "0x170DF20", VA = "0x18170F520", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A14200", Offset = "0x9A12C00", VA = "0x189A14200", Slot = "6")]
		public void InitExternal(GEZRGCKOUXX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A14A70", Offset = "0x9A13470", VA = "0x189A14A70", Slot = "7")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A14600", Offset = "0x9A13000", VA = "0x189A14600", Slot = "4")]
		public void VVAEFTXYQKS(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A14590", Offset = "0x9A12F90", VA = "0x189A14590")]
		private void QMOBQZJXJOM(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A13CE0", Offset = "0x9A126E0", VA = "0x189A13CE0")]
		private void ITAXFPNMYWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A13ED0", Offset = "0x9A128D0", VA = "0x189A13ED0")]
		private void IYYSGEDDJXC(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A14520", Offset = "0x9A12F20", VA = "0x189A14520", Slot = "8")]
		private void LJERCYKGCZL(GEZRGCKOUXX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1018B40", Offset = "0x1017540", VA = "0x181018B40", Slot = "9")]
		private void XGDIBOIJOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A14C00", Offset = "0x9A13600", VA = "0x189A14C00")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class IWXGLUWBWDZ : PIDPTYHQDXH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A15330", Offset = "0x9A13D30", VA = "0x189A15330", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A15290", Offset = "0x9A13C90", VA = "0x189A15290", Slot = "7")]
		public override bool DPQAEQJCORN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A14DD0", Offset = "0x9A137D0", VA = "0x189A14DD0")]
		public IWXGLUWBWDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class DIAVVKRTVPK : PIDPTYHQDXH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A14D20", Offset = "0x9A13720", VA = "0x189A14D20", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9A14C80", Offset = "0x9A13680", VA = "0x189A14C80", Slot = "7")]
		public override bool DPQAEQJCORN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A14DD0", Offset = "0x9A137D0", VA = "0x189A14DD0")]
		public DIAVVKRTVPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class RFPTZWDYLAN : BWHQMDJBALX<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A18B80", Offset = "0x9A17580", VA = "0x189A18B80", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9A18CD0", Offset = "0x9A176D0", VA = "0x189A18CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ECWTQFSOHXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9A14E10", Offset = "0x9A13810", VA = "0x189A14E10")]
			internal (int, int) BSFEQEBHXIC()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9A15080", Offset = "0x9A13A80", VA = "0x189A15080")]
			internal void BSKLNKVFGTL((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] THTOQPYTASR
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A165E0", Offset = "0x9A14FE0", VA = "0x189A165E0", Slot = "9")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, LZGLFWTOFEZ b, UQBBTQHOWWJ c, FTGGXJYXXPC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A16990", Offset = "0x9A15390", VA = "0x189A16990")]
		public NJEWPHTEIHL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class MGXKKAMFFGG : MBRTWOOLSZS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A16510", Offset = "0x9A14F10", VA = "0x189A16510", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A165A0", Offset = "0x9A14FA0", VA = "0x189A165A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9A19C40", Offset = "0x9A18640", VA = "0x189A19C40")]
			internal string BSFEQEBHXIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9A19E80", Offset = "0x9A18880", VA = "0x189A19E80")]
			internal void BSKLNKVFGTL(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A137A0", Offset = "0x9A121A0", VA = "0x189A137A0", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A13930", Offset = "0x9A12330", VA = "0x189A13930")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9A19CA0", Offset = "0x9A186A0", VA = "0x189A19CA0")]
			internal string BSFEQEBHXIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9A19DF0", Offset = "0x9A187F0", VA = "0x189A19DF0")]
			internal void BSKLNKVFGTL(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9A197A0", Offset = "0x9A181A0", VA = "0x189A197A0", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A19930", Offset = "0x9A18330", VA = "0x189A19930")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9A19D70", Offset = "0x9A18770", VA = "0x189A19D70")]
			internal float BSFEQEBHXIC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9A19EF0", Offset = "0x9A188F0", VA = "0x189A19EF0")]
			internal void BSKLNKVFGTL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9A19BA0", Offset = "0x9A185A0", VA = "0x189A19BA0")]
			internal float BRUQVQNNELK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9A19C30", Offset = "0x9A18630", VA = "0x189A19C30")]
			internal void BRZXSXHKNWT(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9A19F60", Offset = "0x9A18960", VA = "0x189A19F60")]
			internal float BTAGFFCXJBM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9A19FE0", Offset = "0x9A189E0", VA = "0x189A19FE0")]
			internal void BTFNCLWUSMV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A3B0", Offset = "0x9A18DB0", VA = "0x189A1A3B0")]
			internal float WJEUAEVQICN(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A420", Offset = "0x9A18E20", VA = "0x189A1A420")]
			internal void YVQVCWUSPVU(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A500", Offset = "0x9A18F00", VA = "0x189A1A500", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A900", Offset = "0x9A19300", VA = "0x189A1A900")]
		public WUHBYOWTNSV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class ZFISFQJLOZO : MBRTWOOLSZS<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9A1ADE0", Offset = "0x9A197E0", VA = "0x189A1ADE0", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9A1AE70", Offset = "0x9A19870", VA = "0x189A1AE70")]
		public ZFISFQJLOZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class TGOKYOGVGTZ : MBRTWOOLSZS<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A196D0", Offset = "0x9A180D0", VA = "0x189A196D0", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9A19760", Offset = "0x9A18160", VA = "0x189A19760")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9A19D20", Offset = "0x9A18720", VA = "0x189A19D20")]
			internal float BSFEQEBHXIC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9A19DE0", Offset = "0x9A187E0", VA = "0x189A19DE0")]
			internal void BSKLNKVFGTL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9A19C10", Offset = "0x9A18610", VA = "0x189A19C10")]
			internal float BRUQVQNNELK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9A19C20", Offset = "0x9A18620", VA = "0x189A19C20")]
			internal void BRZXSXHKNWT(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9A19F50", Offset = "0x9A18950", VA = "0x189A19F50")]
			internal float BTAGFFCXJBM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9A19FD0", Offset = "0x9A189D0", VA = "0x189A19FD0")]
			internal void BTFNCLWUSMV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9A19FF0", Offset = "0x9A189F0", VA = "0x189A19FF0")]
			internal float JOCDYDXKYEG(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A150", Offset = "0x9A18B50", VA = "0x189A1A150")]
			internal void VIUMWDRNMWZ(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A13360", Offset = "0x9A11D60", VA = "0x189A13360", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A13760", Offset = "0x9A12160", VA = "0x189A13760")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9A19D30", Offset = "0x9A18730", VA = "0x189A19D30")]
			internal int BSFEQEBHXIC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9A19F00", Offset = "0x9A18900", VA = "0x189A19F00")]
			internal void BSKLNKVFGTL(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9A194A0", Offset = "0x9A17EA0", VA = "0x189A194A0", Slot = "5")]
		public override void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9A19630", Offset = "0x9A18030", VA = "0x189A19630")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A151D0", Offset = "0x9A13BD0", VA = "0x189A151D0")]
		public static void SNXXQVNSNOB(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9A13970", Offset = "0x9A12370", VA = "0x189A13970")]
		public static NativeList<NetworkProperty> ENZAOSLACPC(NativeObjectLocalIdArray a, UQBBTQHOWWJ b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9A13BF0", Offset = "0x9A125F0", VA = "0x189A13BF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A18E60", Offset = "0x9A17860", VA = "0x189A18E60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BYWDFIHJUYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9A18D10", Offset = "0x9A17710", VA = "0x189A18D10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject DFUAAMETYUD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9A19090", Offset = "0x9A17A90", VA = "0x189A19090", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9A19040", Offset = "0x9A17A40", VA = "0x189A19040", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GNKDKMVLYVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9A190E0", Offset = "0x9A17AE0", VA = "0x189A190E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9A18FA0", Offset = "0x9A179A0", VA = "0x189A18FA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9A193B0", Offset = "0x9A17DB0", VA = "0x189A193B0")]
		public RWHSZSKDGHT(NativeObjectLocalIdArray a, NetworkProperty b, UQBBTQHOWWJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9A192A0", Offset = "0x9A17CA0", VA = "0x189A192A0")]
		private void TZBBGTKJYPP(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9A18EC0", Offset = "0x9A178C0", VA = "0x189A18EC0", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9A19180", Offset = "0x9A17B80", VA = "0x189A19180", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9A18D90", Offset = "0x9A17790", VA = "0x189A18D90", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9A19AD0", Offset = "0x9A184D0", VA = "0x189A19AD0")]
			internal bool BSFEQEBHXIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9A19B20", Offset = "0x9A18520", VA = "0x189A19B20")]
			internal string BSKLNKVFGTL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9A19970", Offset = "0x9A18370", VA = "0x189A19970")]
			internal void BRUQVQNNELK(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9A19A00", Offset = "0x9A18400", VA = "0x189A19A00")]
			internal string BRZXSXHKNWT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty WIAAFFAKCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9A1A940", Offset = "0x9A19340", VA = "0x189A1A940", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9A1A9B0", Offset = "0x9A193B0", VA = "0x189A1A9B0", Slot = "5")]
		public void IYYSGEDDJXC(JYLQYVULPSG a, FTGGXJYXXPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A15E00", Offset = "0x9A14800", VA = "0x189A15E00")]
		public JJXGNWEZVUW(UQBBTQHOWWJ a, FTGGXJYXXPC b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9A153E0", Offset = "0x9A13DE0", VA = "0x189A153E0")]
		public void AUUFOOYHYZU(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9A15BF0", Offset = "0x9A145F0", VA = "0x189A15BF0")]
		private void VULOOKRSNNA(JPJHXSEIUXO a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9A15B90", Offset = "0x9A14590", VA = "0x189A15B90")]
		public void ROMXCJTTVDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9A15720", Offset = "0x9A14120", VA = "0x189A15720")]
		private void BPBJIJMVMHU(JPJHXSEIUXO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9A15D60", Offset = "0x9A14760", VA = "0x189A15D60")]
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
				[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A162F0", Offset = "0x9A14CF0", VA = "0x189A162F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15A6EB0", Offset = "0x15A58B0", VA = "0x1815A6EB0")]
			[DebuggerHidden]
			public LHFEHNEVKPB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9A16340", Offset = "0x9A14D40", VA = "0x189A16340", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9A16010", Offset = "0x9A14A10", VA = "0x189A16010", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9A15F10", Offset = "0x9A14910", VA = "0x189A15F10")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9A163D0", Offset = "0x9A14DD0", VA = "0x189A163D0", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9A15F60", Offset = "0x9A14960", VA = "0x189A15F60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> AWDSYHWAORN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9A15F60", Offset = "0x9A14960", VA = "0x189A15F60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A16CE0", Offset = "0x9A156E0", VA = "0x189A16CE0")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9A16AC0", Offset = "0x9A154C0", VA = "0x189A16AC0")]
		[IteratorStateMachine(typeof(LHFEHNEVKPB))]
		public IEnumerable<NetworkProperty> CSPLNAZPYAK(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9A16B50", Offset = "0x9A15550", VA = "0x189A16B50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9A16B90", Offset = "0x9A15590", VA = "0x189A16B90")]
		private long URBZUTBLCAJ(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9A16C10", Offset = "0x9A15610", VA = "0x189A16C10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A171F0", Offset = "0x9A15BF0", VA = "0x189A171F0")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9A17060", Offset = "0x9A15A60", VA = "0x189A17060")]
		public static PropertyBitmap WOODLPXKDJW(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9A17050", Offset = "0x9A15A50", VA = "0x189A17050")]
		public bool VNWYXTWJHOK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9A17040", Offset = "0x9A15A40", VA = "0x189A17040")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9A16ED0", Offset = "0x9A158D0", VA = "0x189A16ED0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9A16F80", Offset = "0x9A15980", VA = "0x189A16F80")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9A17030", Offset = "0x9A15A30", VA = "0x189A17030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9A18410", Offset = "0x9A16E10", VA = "0x189A18410")]
		public PropertyDrawerCandidates(UQBBTQHOWWJ configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9A17310", Offset = "0x9A15D10", VA = "0x189A17310")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9A173F0", Offset = "0x9A15DF0", VA = "0x189A173F0")]
		public void HHFYQPEHLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9A17D70", Offset = "0x9A16770", VA = "0x189A17D70")]
		public NativeList<Candidate> RCKHRARKLDW(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9A17590", Offset = "0x9A15F90", VA = "0x189A17590")]
		private bool IXZYSPAXYHI(IXQMLOKWQAV a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0E90", Offset = "0x3DCF890", VA = "0x183DD0E90")]
		private void IYEKLBFOCTV<b, a>(Action<b, a> a) where b : IXQMLOKWQAV where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9A18240", Offset = "0x9A16C40", VA = "0x189A18240")]
		private void RTTMQGLNOZV(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0B20", Offset = "0x3DCF520", VA = "0x183DD0B20")]
		private c DENXDLMNQLQ<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9A17A00", Offset = "0x9A16400", VA = "0x189A17A00")]
		private int LKEKCBJJSBD(IXQMLOKWQAV a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9A17AF0", Offset = "0x9A164F0", VA = "0x189A17AF0")]
		private void NIQLZWGFAVN(SMZSAFSYTKN a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9A176E0", Offset = "0x9A160E0", VA = "0x189A176E0")]
		private void JLLVNSBXQBK(MAHDKAORIZY a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A18270", Offset = "0x9A16C70", VA = "0x189A18270")]
		private void UXJYSIIZQNK(EBEJOVRZPRQ a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A17240", Offset = "0x9A15C40", VA = "0x189A17240")]
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
			[Cpp2IlInjected.Address(RVA = "0xF27430", Offset = "0xF25E30", VA = "0x180F27430")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A18B30", Offset = "0x9A17530", VA = "0x189A18B30")]
		public PropertyShadowing(List<IXQMLOKWQAV> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9A18550", Offset = "0x9A16F50", VA = "0x189A18550", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9A186C0", Offset = "0x9A170C0", VA = "0x189A186C0")]
		private NativeList<Candidate> JIPUEJTRWWS(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9A189C0", Offset = "0x9A173C0", VA = "0x189A189C0")]
		private bool UBGDCAWECMD(IXQMLOKWQAV a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9A18590", Offset = "0x9A16F90", VA = "0x189A18590")]
		private void HQKMCWWNNGW(IXQMLOKWQAV a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A19670", Offset = "0x9A18070", VA = "0x189A19670", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9A19680", Offset = "0x9A18080", VA = "0x189A19680")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9A196C0", Offset = "0x9A180C0", VA = "0x189A196C0")]
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
