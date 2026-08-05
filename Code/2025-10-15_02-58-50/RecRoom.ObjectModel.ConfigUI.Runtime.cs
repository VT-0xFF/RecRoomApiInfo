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
		[Cpp2IlInjected.Address(RVA = "0x8631F40", Offset = "0x8630D40", VA = "0x188631F40", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		private int[] DAADMOFRSKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset RDSSOODTNJI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8637160", Offset = "0x8635F60", VA = "0x188637160", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8637180", Offset = "0x8635F80", VA = "0x188637180")]
		private void ZZHVSKGGGUO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8636A10", Offset = "0x8635810", VA = "0x188636A10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8636A70", Offset = "0x8635870", VA = "0x188636A70", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86373A0", Offset = "0x86361A0", VA = "0x1886373A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class VZKTLDRATOK : DLHXORADQVC<Enum>, NONPEOQGKUD, YJKFRNLGEZM, UIVSGSXHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool UMGAVWIMAJK(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8635530", Offset = "0x8634330", VA = "0x188635530")]
		protected VZKTLDRATOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class DLHXORADQVC<a> : YJKFRNLGEZM, UIVSGSXHJLM where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JSZUEIUUAJQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public IAZMQWJFDLL YGKGEJDOLLU;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public JSZUEIUUAJQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x52BFF10", Offset = "0x52BED10", VA = "0x1852BFF10")]
			internal bool VLBZOYTNFXH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4161980", Offset = "0x4160780", VA = "0x184161980")]
		protected DLHXORADQVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x432D240", Offset = "0x432C040", VA = "0x18432D240")]
		protected void AJBNCACLALV(MFLMIIOVXIK a, IAZMQWJFDLL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x432D820", Offset = "0x432C620", VA = "0x18432D820")]
		protected void DSFCUVJYQJH(FXIOEOUQDHP<a> a, IAZMQWJFDLL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class YQQZBOLSCQZ : RPSFXABCWYL, UIVSGSXHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] FFWEXZHZYJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] ZSELRNLDDYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void IHFRBVFXRGV(IAZMQWJFDLL a, SZATOJQWBZI b, ARDHDMAJEBG c, ROZUICBEBCP d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3EF40A0", Offset = "0x3EF2EA0", VA = "0x183EF40A0")]
		protected static b LPMXDLBNOQN<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3EB0", Offset = "0x3EF2CB0", VA = "0x183EF3EB0")]
		protected static void BDPBDSNMJAA<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected YQQZBOLSCQZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class ZKIUFFKKUAV<a> : YJKFRNLGEZM, UIVSGSXHJLM where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class JSZUEIUUAJQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IAZMQWJFDLL YGKGEJDOLLU;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public JSZUEIUUAJQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x52BFE20", Offset = "0x52BEC20", VA = "0x1852BFE20")]
			internal bool VLBZOYTNFXH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4161980", Offset = "0x4160780", VA = "0x184161980")]
		protected ZKIUFFKKUAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x415FA60", Offset = "0x415E860", VA = "0x18415FA60")]
		protected void AJBNCACLALV(MFLMIIOVXIK a, IAZMQWJFDLL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4160BF0", Offset = "0x415F9F0", VA = "0x184160BF0")]
		protected void DSFCUVJYQJH(FXIOEOUQDHP<a> a, IAZMQWJFDLL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(SZATOJQWBZI), new string[] { })]
	internal class ConfigUIService : SZATOJQWBZI, XBOLCYDYDAA, BQLXQKHZRWO, OQVTAWVSILE, CKMVDEYKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private ARDHDMAJEBG TJROLRYFILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private ROZUICBEBCP AHWRNSSHBGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates SCHJVUUQKMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray JUFBGGBKBMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<IAZMQWJFDLL> ZMZBSSEXTYI;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray JJPYSBKWORR
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1753600", Offset = "0x1752400", VA = "0x181753600", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x862FD10", Offset = "0x862EB10", VA = "0x18862FD10", Slot = "6")]
		public void InitExternal(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86306A0", Offset = "0x862F4A0", VA = "0x1886306A0", Slot = "7")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8630230", Offset = "0x862F030", VA = "0x188630230", Slot = "4")]
		public void OAOKWMLVSUD(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x862F960", Offset = "0x862E760", VA = "0x18862F960")]
		private void ALMDKABJAYJ(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8630030", Offset = "0x862EE30", VA = "0x188630030")]
		private void NDGLNLKSWSC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x862F9D0", Offset = "0x862E7D0", VA = "0x18862F9D0")]
		private void IHFRBVFXRGV(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86307A0", Offset = "0x862F5A0", VA = "0x1886307A0", Slot = "8")]
		private void VROTAZPKECM(YKMTYEBAAOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x108FBC0", Offset = "0x108E9C0", VA = "0x18108FBC0", Slot = "9")]
		private void WEWODNDDDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86308A0", Offset = "0x862F6A0", VA = "0x1886308A0")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class UYKFQUQVUXA : VZKTLDRATOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86353E0", Offset = "0x86341E0", VA = "0x1886353E0", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8635490", Offset = "0x8634290", VA = "0x188635490", Slot = "7")]
		public override bool UMGAVWIMAJK(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8635530", Offset = "0x8634330", VA = "0x188635530")]
		public UYKFQUQVUXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class WYAOQDNHAKD : VZKTLDRATOK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8636130", Offset = "0x8634F30", VA = "0x188636130", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86361E0", Offset = "0x8634FE0", VA = "0x1886361E0", Slot = "7")]
		public override bool UMGAVWIMAJK(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8635530", Offset = "0x8634330", VA = "0x188635530")]
		public WYAOQDNHAKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class BQOFTIVBRFE : DLHXORADQVC<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x862F460", Offset = "0x862E260", VA = "0x18862F460", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x862F5B0", Offset = "0x862E3B0", VA = "0x18862F5B0")]
		public BQOFTIVBRFE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class UBIMMBIMCTE : YQQZBOLSCQZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class VFMVPEYKGXJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public SZATOJQWBZI SPHNQIBORYS;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public VFMVPEYKGXJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8635650", Offset = "0x8634450", VA = "0x188635650")]
			internal (int, int) RZTUWNJEECX()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8635570", Offset = "0x8634370", VA = "0x188635570")]
			internal void RZONZGPGURO((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] FFWEXZHZYJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] ZSELRNLDDYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8634F00", Offset = "0x8633D00", VA = "0x188634F00", Slot = "9")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, SZATOJQWBZI b, ARDHDMAJEBG c, ROZUICBEBCP d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86352B0", Offset = "0x86340B0", VA = "0x1886352B0")]
		public UBIMMBIMCTE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class JCTSQIWNTFV : ZKIUFFKKUAV<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86311D0", Offset = "0x862FFD0", VA = "0x1886311D0", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8631260", Offset = "0x8630060", VA = "0x188631260")]
		public JCTSQIWNTFV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class DZVEEUNSDVR : ZKIUFFKKUAV<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class WRYJXOISUHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public IAZMQWJFDLL YGKGEJDOLLU;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WRYJXOISUHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8635C30", Offset = "0x8634A30", VA = "0x188635C30")]
			internal string RZTUWNJEECX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8635A80", Offset = "0x8634880", VA = "0x188635A80")]
			internal void RZONZGPGURO(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8630920", Offset = "0x862F720", VA = "0x188630920", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8630AB0", Offset = "0x862F8B0", VA = "0x188630AB0")]
		public DZVEEUNSDVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class IKVQMHXLLSI : ZKIUFFKKUAV<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class WRYJXOISUHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public IAZMQWJFDLL YGKGEJDOLLU;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WRYJXOISUHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8635C90", Offset = "0x8634A90", VA = "0x188635C90")]
			internal string RZTUWNJEECX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8635AF0", Offset = "0x86348F0", VA = "0x188635AF0")]
			internal void RZONZGPGURO(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8631000", Offset = "0x862FE00", VA = "0x188631000", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8631190", Offset = "0x862FF90", VA = "0x188631190")]
		public IKVQMHXLLSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class GUNBNSEVAWA : ZKIUFFKKUAV<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class WRYJXOISUHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IAZMQWJFDLL YGKGEJDOLLU;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WRYJXOISUHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8635D20", Offset = "0x8634B20", VA = "0x188635D20")]
			internal float RZTUWNJEECX()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8635BE0", Offset = "0x86349E0", VA = "0x188635BE0")]
			internal void RZONZGPGURO(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8635DB0", Offset = "0x8634BB0", VA = "0x188635DB0")]
			internal float SAEIRAWYWZP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8635D90", Offset = "0x8634B90", VA = "0x188635D90")]
			internal void RZZBTUDBNOG(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8635E60", Offset = "0x8634C60", VA = "0x188635E60")]
			internal float SAOWLOKTPWH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8635E40", Offset = "0x8634C40", VA = "0x188635E40")]
			internal void SAJPOHQWGKY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x86357D0", Offset = "0x86345D0", VA = "0x1886357D0")]
			internal float AHTCUCWIEKE(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x86359A0", Offset = "0x86347A0", VA = "0x1886359A0")]
			internal void LWUITOBWVED(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8630AF0", Offset = "0x862F8F0", VA = "0x188630AF0", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8630EF0", Offset = "0x862FCF0", VA = "0x188630EF0")]
		public GUNBNSEVAWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class GVJPPMHIESH : ZKIUFFKKUAV<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8630F30", Offset = "0x862FD30", VA = "0x188630F30", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8630FC0", Offset = "0x862FDC0", VA = "0x188630FC0")]
		public GVJPPMHIESH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class KDXBNIRGRWM : ZKIUFFKKUAV<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8631E70", Offset = "0x8630C70", VA = "0x188631E70", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8631F00", Offset = "0x8630D00", VA = "0x188631F00")]
		public KDXBNIRGRWM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class JZUSYNNDTXV : ZKIUFFKKUAV<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class WRYJXOISUHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public IAZMQWJFDLL YGKGEJDOLLU;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WRYJXOISUHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8635D10", Offset = "0x8634B10", VA = "0x188635D10")]
			internal float RZTUWNJEECX()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8635B80", Offset = "0x8634980", VA = "0x188635B80")]
			internal void RZONZGPGURO(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8635E20", Offset = "0x8634C20", VA = "0x188635E20")]
			internal float SAEIRAWYWZP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8635DA0", Offset = "0x8634BA0", VA = "0x188635DA0")]
			internal void RZZBTUDBNOG(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8635E50", Offset = "0x8634C50", VA = "0x188635E50")]
			internal float SAOWLOKTPWH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8635E30", Offset = "0x8634C30", VA = "0x188635E30")]
			internal void SAJPOHQWGKY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8635840", Offset = "0x8634640", VA = "0x188635840")]
			internal float ECZOGVYRGEV(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8635ED0", Offset = "0x8634CD0", VA = "0x188635ED0")]
			internal void SIPYBLFMUUO(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8631A30", Offset = "0x8630830", VA = "0x188631A30", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8631E30", Offset = "0x8630C30", VA = "0x188631E30")]
		public JZUSYNNDTXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class ZFZISJMLMPB : ZKIUFFKKUAV<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class WRYJXOISUHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public IAZMQWJFDLL YGKGEJDOLLU;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WRYJXOISUHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8635BF0", Offset = "0x86349F0", VA = "0x188635BF0")]
			internal int RZTUWNJEECX()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8635B90", Offset = "0x8634990", VA = "0x188635B90")]
			internal void RZONZGPGURO(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8636840", Offset = "0x8635640", VA = "0x188636840", Slot = "5")]
		public override void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86369D0", Offset = "0x86357D0", VA = "0x1886369D0")]
		public ZFZISJMLMPB()
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
	internal static class XYSQZWYZSLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8636780", Offset = "0x8635580", VA = "0x188636780")]
		public static void TEPDABRFBNC(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x862F6E0", Offset = "0x862E4E0", VA = "0x18862F6E0")]
		public static NativeList<NetworkProperty> JZPBXXNGGCD(NativeObjectLocalIdArray a, ARDHDMAJEBG b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x862F5F0", Offset = "0x862E3F0", VA = "0x18862F5F0")]
		private static bool ETPGYGKSRSK(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class JMFCCTPGJOQ : IAZMQWJFDLL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty YGKGEJDOLLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ARDHDMAJEBG CYUOCKVYJLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray JUFBGGBKBMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool RKZVTHIHIQI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x86318E0", Offset = "0x86306E0", VA = "0x1886318E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool TSOQDPQOFOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8631630", Offset = "0x8630430", VA = "0x188631630", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject QREWLGKVCEI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8631410", Offset = "0x8630210", VA = "0x188631410", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8631540", Offset = "0x8630340", VA = "0x188631540", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AEYEOLPEVSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x86312A0", Offset = "0x86300A0", VA = "0x1886312A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8631590", Offset = "0x8630390", VA = "0x188631590", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8631940", Offset = "0x8630740", VA = "0x188631940")]
		public JMFCCTPGJOQ(NativeObjectLocalIdArray a, NetworkProperty b, ARDHDMAJEBG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x86317D0", Offset = "0x86305D0", VA = "0x1886317D0")]
		private void WUNOIIBUJYK(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8631460", Offset = "0x8630260", VA = "0x188631460", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86316B0", Offset = "0x86304B0", VA = "0x1886316B0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8631340", Offset = "0x8630140", VA = "0x188631340", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class AHTZWELKWIR : JPBXOPXZSGS, YJKFRNLGEZM, UIVSGSXHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class OMGLYBCUARB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public IAZMQWJFDLL YGKGEJDOLLU;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OMGLYBCUARB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8632C00", Offset = "0x8631A00", VA = "0x188632C00")]
			internal bool RZTUWNJEECX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8632B80", Offset = "0x8631980", VA = "0x188632B80")]
			internal string RZONZGPGURO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8632D30", Offset = "0x8631B30", VA = "0x188632D30")]
			internal void SAEIRAWYWZP(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8632C50", Offset = "0x8631A50", VA = "0x188632C50")]
			internal string RZZBTUDBNOG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty NRMYWAZRGMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x862EFB0", Offset = "0x862DDB0", VA = "0x18862EFB0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x862F020", Offset = "0x862DE20", VA = "0x18862F020", Slot = "5")]
		public void IHFRBVFXRGV(IAZMQWJFDLL a, ROZUICBEBCP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public AHTZWELKWIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class NPSOBQDMCZP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly ARDHDMAJEBG TJROLRYFILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly ROZUICBEBCP KVVKLOSHXUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> JZDBIVETXWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<JGBDOSOEESF> WQDKKWKYYSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<JGBDOSOEESF, List<Candidate>> IWJPDBXDCMJ;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8632A70", Offset = "0x8631870", VA = "0x188632A70")]
		public NPSOBQDMCZP(ARDHDMAJEBG a, ROZUICBEBCP b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8632730", Offset = "0x8631530", VA = "0x188632730")]
		public void UKNOADGYQXB(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8632040", Offset = "0x8630E40", VA = "0x188632040")]
		private void HMSNNSIHGQJ(JGBDOSOEESF a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86321B0", Offset = "0x8630FB0", VA = "0x1886321B0")]
		public void NPQKPIAHXCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x86322B0", Offset = "0x86310B0", VA = "0x1886322B0")]
		private void TIRAQCWXDQN(JGBDOSOEESF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8632210", Offset = "0x8631010", VA = "0x188632210")]
		private void RPTVYKLPUDC(JGBDOSOEESF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class XJNEJVDEATG : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type BZOQAXHJQMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type PYAKCNXNCLS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator RSQQLXOAUXF;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty IWNYWLVIVJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xC1BCE0", Offset = "0xC1AAE0", VA = "0x180C1BCE0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x86366E0", Offset = "0x86354E0", VA = "0x1886366E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15ECBD0", Offset = "0x15EB9D0", VA = "0x1815ECBD0")]
			[DebuggerHidden]
			public XJNEJVDEATG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8636280", Offset = "0x8635080", VA = "0x188636280", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8636400", Offset = "0x8635200", VA = "0x188636400", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8636730", Offset = "0x8635530", VA = "0x188636730")]
			private void XVTZRJOPNYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x86363C0", Offset = "0x86351C0", VA = "0x1886363C0", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8636310", Offset = "0x8635110", VA = "0x188636310", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> JKXEZBOCMYQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8636310", Offset = "0x8635110", VA = "0x188636310", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> PAQIPDPOXOP;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8632FE0", Offset = "0x8631DE0", VA = "0x188632FE0")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8632EC0", Offset = "0x8631CC0", VA = "0x188632EC0")]
		[IteratorStateMachine(typeof(XJNEJVDEATG))]
		public IEnumerable<NetworkProperty> RVANMIBNSKV(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8632E80", Offset = "0x8631C80", VA = "0x188632E80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8632E00", Offset = "0x8631C00", VA = "0x188632E00")]
		private long CICOCQCPAQI(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8632DC0", Offset = "0x8631BC0", VA = "0x188632DC0")]
		private long CICOCQCPAQI(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x86334F0", Offset = "0x86322F0", VA = "0x1886334F0")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8633350", Offset = "0x8632150", VA = "0x188633350")]
		public static PropertyBitmap OJOIHOVIAEX(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8633340", Offset = "0x8632140", VA = "0x188633340")]
		public bool GPLQZYAWMIB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x86334E0", Offset = "0x86322E0", VA = "0x1886334E0")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86331D0", Offset = "0x8631FD0", VA = "0x1886331D0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8633280", Offset = "0x8632080", VA = "0x188633280")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8633330", Offset = "0x8632130", VA = "0x188633330", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly ARDHDMAJEBG TJROLRYFILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<UIVSGSXHJLM> VVKEZTCDIWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType PAQIPDPOXOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> JOACCEQZDAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> HEMPSVGMARV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool RKZVTHIHIQI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<UIVSGSXHJLM> BKINGILFACL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8634730", Offset = "0x8633530", VA = "0x188634730")]
		public PropertyDrawerCandidates(ARDHDMAJEBG configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8633650", Offset = "0x8632450", VA = "0x188633650")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8633D20", Offset = "0x8632B20", VA = "0x188633D20")]
		public void OCFNTAOCBLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86341D0", Offset = "0x8632FD0", VA = "0x1886341D0")]
		public NativeList<Candidate> WMGAPYAEPCX(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8634080", Offset = "0x8632E80", VA = "0x188634080")]
		private bool VZMBBDPOVAJ(UIVSGSXHJLM a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF82F0", Offset = "0x3BF70F0", VA = "0x183BF82F0")]
		private void OPINCXWFKIA<b, a>(Action<b, a> a) where b : UIVSGSXHJLM where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86339C0", Offset = "0x86327C0", VA = "0x1886339C0")]
		private void FFJMIAQTORA(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8600", Offset = "0x3BF7400", VA = "0x183BF8600")]
		private c ZEMMOYUVAZV<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8633F90", Offset = "0x8632D90", VA = "0x188633F90")]
		private int TVUQLUNZZEK(UIVSGSXHJLM a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8633730", Offset = "0x8632530", VA = "0x188633730")]
		private void EITDTDZWVSO(YJKFRNLGEZM a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86339F0", Offset = "0x86327F0", VA = "0x1886339F0")]
		private void HKWKDUTWYQT(NONPEOQGKUD a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8633540", Offset = "0x8632340", VA = "0x188633540")]
		private void AXQZXUDBZGL(RPSFXABCWYL a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8633EC0", Offset = "0x8632CC0", VA = "0x188633EC0")]
		private void TCSPEBXTUFE(JPBXOPXZSGS a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<UIVSGSXHJLM> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> GMADYVZJVAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xBB6880", Offset = "0xBB5680", VA = "0x180BB6880")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8634E50", Offset = "0x8633C50", VA = "0x188634E50")]
		public PropertyShadowing(List<UIVSGSXHJLM> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8634870", Offset = "0x8633670", VA = "0x188634870", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x86348B0", Offset = "0x86336B0", VA = "0x1886348B0")]
		private NativeList<Candidate> EXUXZRZWJXP(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8634BB0", Offset = "0x86339B0", VA = "0x188634BB0")]
		private bool VDEPXYMVVCS(UIVSGSXHJLM a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8634D20", Offset = "0x8633B20", VA = "0x188634D20")]
		private void ZWQGPYSKSKJ(UIVSGSXHJLM a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8634EA0", Offset = "0x8633CA0", VA = "0x188634EA0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8634EB0", Offset = "0x8633CB0", VA = "0x188634EB0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8634EF0", Offset = "0x8633CF0", VA = "0x188634EF0")]
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
