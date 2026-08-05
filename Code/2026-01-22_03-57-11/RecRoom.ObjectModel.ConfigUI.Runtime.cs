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
		[Cpp2IlInjected.Address(RVA = "0x84A19A0", Offset = "0x84A01A0", VA = "0x1884A19A0", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		private int[] GGRLHWHSZPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset ERVRXHKVDYW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84A6090", Offset = "0x84A4890", VA = "0x1884A6090", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84A5700", Offset = "0x84A3F00", VA = "0x1884A5700")]
		private void LJCGTCDSEAS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84A5920", Offset = "0x84A4120", VA = "0x1884A5920", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84A5980", Offset = "0x84A4180", VA = "0x1884A5980", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84A60B0", Offset = "0x84A48B0", VA = "0x1884A60B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class FYATJGXXLUS : WDCLJTZJZWI<Enum>, SYGPUJBWLSP, XCAJKFOSIJQ, MTCOIMQUIYK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool WBHJCEAJHKY(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84A0A60", Offset = "0x849F260", VA = "0x1884A0A60")]
		protected FYATJGXXLUS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class WDCLJTZJZWI<a> : XCAJKFOSIJQ, MTCOIMQUIYK where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class CYJUGVKDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public FKTUPDJHZUV VVJCRQNILAW;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public CYJUGVKDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3F065B0", Offset = "0x3F04DB0", VA = "0x183F065B0")]
			internal bool DQHBBHVABOV()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4785170", Offset = "0x4783970", VA = "0x184785170")]
		protected WDCLJTZJZWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66AD850", Offset = "0x66AC050", VA = "0x1866AD850")]
		protected void NDBBNYKGEFF(NLLIORNTCIK a, FKTUPDJHZUV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66AD270", Offset = "0x66ABA70", VA = "0x1866AD270")]
		protected void FIQUZOJJKCJ(GXJIYSPAGDH<a> a, FKTUPDJHZUV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class CPVFEJWPNYR : IZLFKOQWCFF, MTCOIMQUIYK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] NZBSXODOBKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] BJAHOXZDTYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void URHQMCSACOF(FKTUPDJHZUV a, XWQHOAHMQAC b, NCMVUEGBKNC c, MRXZDPARFBF d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x349CA60", Offset = "0x349B260", VA = "0x18349CA60")]
		protected static b SJBMCQRAUBH<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x349CC40", Offset = "0x349B440", VA = "0x18349CC40")]
		protected static void ZDPIUTNPVSQ<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected CPVFEJWPNYR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class EXCEEYWNKFX<a> : XCAJKFOSIJQ, MTCOIMQUIYK where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class CYJUGVKDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public FKTUPDJHZUV VVJCRQNILAW;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public CYJUGVKDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3F06650", Offset = "0x3F04E50", VA = "0x183F06650")]
			internal bool DQHBBHVABOV()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4785170", Offset = "0x4783970", VA = "0x184785170")]
		protected EXCEEYWNKFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4784BA0", Offset = "0x47833A0", VA = "0x184784BA0")]
		protected void NDBBNYKGEFF(NLLIORNTCIK a, FKTUPDJHZUV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4783060", Offset = "0x4781860", VA = "0x184783060")]
		protected void FIQUZOJJKCJ(GXJIYSPAGDH<a> a, FKTUPDJHZUV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(XWQHOAHMQAC), new string[] { })]
	internal class ConfigUIService : XWQHOAHMQAC, DPQPSOGQUSE, LYHFQGWTPJE, WVKCUFPJZYK, KKGEYMKPCBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private NCMVUEGBKNC GVDVLWBKITZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private MRXZDPARFBF IOPYOIRVNMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates UJMZBDRIGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray DUDHLSIPDTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<FKTUPDJHZUV> QWUDECPZCEA;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray SXJGSLCBVZB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x14794E0", Offset = "0x1477CE0", VA = "0x1814794E0", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x849E590", Offset = "0x849CD90", VA = "0x18849E590", Slot = "6")]
		public void InitExternal(MZUBMRWQSAC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x849E490", Offset = "0x849CC90", VA = "0x18849E490", Slot = "7")]
		public void GGOPOLDMLPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x849EBE0", Offset = "0x849D3E0", VA = "0x18849EBE0", Slot = "4")]
		public void YCEJTSQWUQH(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x849E1B0", Offset = "0x849C9B0", VA = "0x18849E1B0")]
		private void CPCDDNCXCFL(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x849E290", Offset = "0x849CA90", VA = "0x18849E290")]
		private void FVKBHRLKCVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x849E8B0", Offset = "0x849D0B0", VA = "0x18849E8B0")]
		private void URHQMCSACOF(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x849E220", Offset = "0x849CA20", VA = "0x18849E220", Slot = "8")]
		private void DFEIFKWLVLC(MZUBMRWQSAC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDA6BD0", Offset = "0xDA53D0", VA = "0x180DA6BD0", Slot = "9")]
		private void WDBEGWLPSKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x849F0D0", Offset = "0x849D8D0", VA = "0x18849F0D0")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class ZZAEJBZWYQS : FYATJGXXLUS
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84A55B0", Offset = "0x84A3DB0", VA = "0x1884A55B0", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84A5660", Offset = "0x84A3E60", VA = "0x1884A5660", Slot = "7")]
		public override bool WBHJCEAJHKY(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84A0A60", Offset = "0x849F260", VA = "0x1884A0A60")]
		public ZZAEJBZWYQS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class IOPSWCLNRCT : FYATJGXXLUS
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84A1170", Offset = "0x849F970", VA = "0x1884A1170", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84A1220", Offset = "0x849FA20", VA = "0x1884A1220", Slot = "7")]
		public override bool WBHJCEAJHKY(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84A0A60", Offset = "0x849F260", VA = "0x1884A0A60")]
		public IOPSWCLNRCT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class WJBOUUPIWCS : WDCLJTZJZWI<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84A4890", Offset = "0x84A3090", VA = "0x1884A4890", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84A49E0", Offset = "0x84A31E0", VA = "0x1884A49E0")]
		public WJBOUUPIWCS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class MKLJGBSRQEW : CPVFEJWPNYR
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OZNGAHXEFXB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public XWQHOAHMQAC KURCHCYIGIS;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OZNGAHXEFXB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84A24F0", Offset = "0x84A0CF0", VA = "0x1884A24F0")]
			internal (int, int) VQYRMWOGJGH()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x84A23B0", Offset = "0x84A0BB0", VA = "0x1884A23B0")]
			internal void VQTKPPUIZUY((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] NZBSXODOBKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] BJAHOXZDTYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84A1AA0", Offset = "0x84A02A0", VA = "0x1884A1AA0", Slot = "9")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, XWQHOAHMQAC b, NCMVUEGBKNC c, MRXZDPARFBF d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84A1E50", Offset = "0x84A0650", VA = "0x1884A1E50")]
		public MKLJGBSRQEW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class LMGHAWSLKJV : EXCEEYWNKFX<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84A1700", Offset = "0x849FF00", VA = "0x1884A1700", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84A1790", Offset = "0x849FF90", VA = "0x1884A1790")]
		public LMGHAWSLKJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class LTUTPENMWAL : EXCEEYWNKFX<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class YMFUAEWSMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public FKTUPDJHZUV VVJCRQNILAW;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YMFUAEWSMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84A5320", Offset = "0x84A3B20", VA = "0x1884A5320")]
			internal string VQYRMWOGJGH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84A5120", Offset = "0x84A3920", VA = "0x1884A5120")]
			internal void VQTKPPUIZUY(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84A17D0", Offset = "0x849FFD0", VA = "0x1884A17D0", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84A1960", Offset = "0x84A0160", VA = "0x1884A1960")]
		public LTUTPENMWAL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class GAMEELAYIEM : EXCEEYWNKFX<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class YMFUAEWSMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public FKTUPDJHZUV VVJCRQNILAW;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YMFUAEWSMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x84A52A0", Offset = "0x84A3AA0", VA = "0x1884A52A0")]
			internal string VQYRMWOGJGH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x84A5190", Offset = "0x84A3990", VA = "0x1884A5190")]
			internal void VQTKPPUIZUY(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84A0AA0", Offset = "0x849F2A0", VA = "0x1884A0AA0", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84A0C30", Offset = "0x849F430", VA = "0x1884A0C30")]
		public GAMEELAYIEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class MYRYJIJBDUU : EXCEEYWNKFX<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class YMFUAEWSMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public FKTUPDJHZUV VVJCRQNILAW;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YMFUAEWSMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x84A5380", Offset = "0x84A3B80", VA = "0x1884A5380")]
			internal float VQYRMWOGJGH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x84A5280", Offset = "0x84A3A80", VA = "0x1884A5280")]
			internal void VQTKPPUIZUY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84A5460", Offset = "0x84A3C60", VA = "0x1884A5460")]
			internal float VRJFHKCBCCZ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84A5440", Offset = "0x84A3C40", VA = "0x1884A5440")]
			internal void VRDYKDIDSRQ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x84A50A0", Offset = "0x84A38A0", VA = "0x1884A50A0")]
			internal float VQDPXVMQXMX()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x84A5080", Offset = "0x84A3880", VA = "0x1884A5080")]
			internal void VPYJAOSTOBO(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x84A5010", Offset = "0x84A3810", VA = "0x1884A5010")]
			internal float NZQSLHRJVQY(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x84A54D0", Offset = "0x84A3CD0", VA = "0x1884A54D0")]
			internal void ZJZVXFIWZTB(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84A1F70", Offset = "0x84A0770", VA = "0x1884A1F70", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84A2370", Offset = "0x84A0B70", VA = "0x1884A2370")]
		public MYRYJIJBDUU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class DBGRHERSWKT : EXCEEYWNKFX<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x849F150", Offset = "0x849D950", VA = "0x18849F150", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x849F1E0", Offset = "0x849D9E0", VA = "0x18849F1E0")]
		public DBGRHERSWKT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class ELXCFVDNWEI : EXCEEYWNKFX<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84A04E0", Offset = "0x849ECE0", VA = "0x1884A04E0", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84A0570", Offset = "0x849ED70", VA = "0x1884A0570")]
		public ELXCFVDNWEI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class IVPPATUEUBR : EXCEEYWNKFX<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class YMFUAEWSMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public FKTUPDJHZUV VVJCRQNILAW;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YMFUAEWSMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x84A5290", Offset = "0x84A3A90", VA = "0x1884A5290")]
			internal float VQYRMWOGJGH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x84A5270", Offset = "0x84A3A70", VA = "0x1884A5270")]
			internal void VQTKPPUIZUY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x84A5450", Offset = "0x84A3C50", VA = "0x1884A5450")]
			internal float VRJFHKCBCCZ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x84A5430", Offset = "0x84A3C30", VA = "0x1884A5430")]
			internal void VRDYKDIDSRQ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x84A5110", Offset = "0x84A3910", VA = "0x1884A5110")]
			internal float VQDPXVMQXMX()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x84A5090", Offset = "0x84A3890", VA = "0x1884A5090")]
			internal void VPYJAOSTOBO(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x84A4C50", Offset = "0x84A3450", VA = "0x1884A4C50")]
			internal float CFJZEOOMQCN(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x84A4DB0", Offset = "0x84A35B0", VA = "0x1884A4DB0")]
			internal void CGUCUVHOTDI(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84A12C0", Offset = "0x849FAC0", VA = "0x1884A12C0", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84A16C0", Offset = "0x849FEC0", VA = "0x1884A16C0")]
		public IVPPATUEUBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class BZKKATCHKSP : EXCEEYWNKFX<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class YMFUAEWSMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public FKTUPDJHZUV VVJCRQNILAW;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YMFUAEWSMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x84A53F0", Offset = "0x84A3BF0", VA = "0x1884A53F0")]
			internal int VQYRMWOGJGH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x84A5220", Offset = "0x84A3A20", VA = "0x1884A5220")]
			internal void VQTKPPUIZUY(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x849DC70", Offset = "0x849C470", VA = "0x18849DC70", Slot = "5")]
		public override void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x849DE00", Offset = "0x849C600", VA = "0x18849DE00")]
		public BZKKATCHKSP()
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
	internal static class AFEDGRZSBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x849DBB0", Offset = "0x849C3B0", VA = "0x18849DBB0")]
		public static void PMUKKMXLQAE(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x849DE40", Offset = "0x849C640", VA = "0x18849DE40")]
		public static NativeList<NetworkProperty> DYWOHEZISHN(NativeObjectLocalIdArray a, NCMVUEGBKNC b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x849E0C0", Offset = "0x849C8C0", VA = "0x18849E0C0")]
		private static bool TVDYKKMKOHA(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DEPDMRSPGIU : FKTUPDJHZUV, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty VVJCRQNILAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly NCMVUEGBKNC CKABIPJYVBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray DUDHLSIPDTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool RZOBVXQYVPC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x849F590", Offset = "0x849DD90", VA = "0x18849F590", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PJAPEOLNEQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x849F3E0", Offset = "0x849DBE0", VA = "0x18849F3E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject KTSNYXQGISY
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x849F540", Offset = "0x849DD40", VA = "0x18849F540", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x849F220", Offset = "0x849DA20", VA = "0x18849F220", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action VIROSZPZYYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x849F5F0", Offset = "0x849DDF0", VA = "0x18849F5F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x849F270", Offset = "0x849DA70", VA = "0x18849F270", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x849F8C0", Offset = "0x849E0C0", VA = "0x18849F8C0")]
		public DEPDMRSPGIU(NativeObjectLocalIdArray a, NetworkProperty b, NCMVUEGBKNC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x849F7B0", Offset = "0x849DFB0", VA = "0x18849F7B0")]
		private void VURHGBKESNI(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x849F460", Offset = "0x849DC60", VA = "0x18849F460", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x849F690", Offset = "0x849DE90", VA = "0x18849F690", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x849F310", Offset = "0x849DB10", VA = "0x18849F310", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class FBGGGCQMUQN : SRSDDIQSNJE, XCAJKFOSIJQ, MTCOIMQUIYK
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class WSROETRUXZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FKTUPDJHZUV VVJCRQNILAW;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WSROETRUXZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x84A4AA0", Offset = "0x84A32A0", VA = "0x1884A4AA0")]
			internal bool VQYRMWOGJGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x84A4A20", Offset = "0x84A3220", VA = "0x1884A4A20")]
			internal string VQTKPPUIZUY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x84A4BC0", Offset = "0x84A33C0", VA = "0x1884A4BC0")]
			internal void VRJFHKCBCCZ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x84A4AF0", Offset = "0x84A32F0", VA = "0x1884A4AF0")]
			internal string VRDYKDIDSRQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty LAWCCXCQZRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x84A09F0", Offset = "0x849F1F0", VA = "0x1884A09F0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84A05B0", Offset = "0x849EDB0", VA = "0x1884A05B0", Slot = "5")]
		public void URHQMCSACOF(FKTUPDJHZUV a, MRXZDPARFBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public FBGGGCQMUQN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class DFIPBITZSFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly NCMVUEGBKNC GVDVLWBKITZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly MRXZDPARFBF UHQNOKLHXWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> EZSDIHBEQWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<DCTWKXHPMOZ> KXUQDQNAWWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<DCTWKXHPMOZ, List<Candidate>> PSCETNQKVXL;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84A03D0", Offset = "0x849EBD0", VA = "0x1884A03D0")]
		public DFIPBITZSFD(NCMVUEGBKNC a, MRXZDPARFBF b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84A0090", Offset = "0x849E890", VA = "0x1884A0090")]
		public void SZOSIHTNBAP(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x849F9B0", Offset = "0x849E1B0", VA = "0x18849F9B0")]
		private void GOQBQRMEPQB(DCTWKXHPMOZ a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84A0030", Offset = "0x849E830", VA = "0x1884A0030")]
		public void SULLKTZBCBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x849FBC0", Offset = "0x849E3C0", VA = "0x18849FBC0")]
		private void REAALSBDFBX(DCTWKXHPMOZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x849FB20", Offset = "0x849E320", VA = "0x18849FB20")]
		private void NGAUFBBNLCU(DCTWKXHPMOZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class HHSNWBVPEZG : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type FDULPSXRSFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type TMAVFVCSDGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator YLHXGKHQDKH;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty ZOHMRWPNNQL
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x84A1040", Offset = "0x849F840", VA = "0x1884A1040", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1326640", Offset = "0x1324E40", VA = "0x181326640")]
			[DebuggerHidden]
			public HHSNWBVPEZG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x84A1090", Offset = "0x849F890", VA = "0x1884A1090", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x84A0D60", Offset = "0x849F560", VA = "0x1884A0D60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84A1120", Offset = "0x849F920", VA = "0x1884A1120")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x84A0D20", Offset = "0x849F520", VA = "0x1884A0D20", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x84A0C70", Offset = "0x849F470", VA = "0x1884A0C70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> ASCAADVTTPS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x84A0C70", Offset = "0x849F470", VA = "0x1884A0C70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> KFPPLXAQCUT;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84A2980", Offset = "0x84A1180", VA = "0x1884A2980")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84A2870", Offset = "0x84A1070", VA = "0x1884A2870")]
		[IteratorStateMachine(typeof(HHSNWBVPEZG))]
		public IEnumerable<NetworkProperty> TGGNUDWLJHD(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84A2830", Offset = "0x84A1030", VA = "0x1884A2830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84A27B0", Offset = "0x84A0FB0", VA = "0x1884A27B0")]
		private long ASUMCSEKNMQ(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84A2770", Offset = "0x84A0F70", VA = "0x1884A2770")]
		private long ASUMCSEKNMQ(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x84A2E90", Offset = "0x84A1690", VA = "0x1884A2E90")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84A2CE0", Offset = "0x84A14E0", VA = "0x1884A2CE0")]
		public static PropertyBitmap GNFJJFVVTGD(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84A2E80", Offset = "0x84A1680", VA = "0x1884A2E80")]
		public bool WBXIBNLXMIN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84A2E70", Offset = "0x84A1670", VA = "0x1884A2E70")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84A2B70", Offset = "0x84A1370", VA = "0x1884A2B70")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x84A2C20", Offset = "0x84A1420", VA = "0x1884A2C20")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x84A2CD0", Offset = "0x84A14D0", VA = "0x1884A2CD0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly NCMVUEGBKNC GVDVLWBKITZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<MTCOIMQUIYK> XPGUSJHQSJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType KFPPLXAQCUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> NISCAGICQHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> DAUHUJVQOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool RZOBVXQYVPC;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<MTCOIMQUIYK> UAEJMJWPYVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84A40C0", Offset = "0x84A28C0", VA = "0x1884A40C0")]
		public PropertyDrawerCandidates(NCMVUEGBKNC configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x84A3210", Offset = "0x84A1A10", VA = "0x1884A3210")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84A32F0", Offset = "0x84A1AF0", VA = "0x1884A32F0")]
		public void KEIUZNIBSLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84A3B70", Offset = "0x84A2370", VA = "0x1884A3B70")]
		public NativeList<Candidate> RBXPYGPWYGP(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x84A39F0", Offset = "0x84A21F0", VA = "0x1884A39F0")]
		private bool NOMSQDCGVKZ(MTCOIMQUIYK a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x39441A0", Offset = "0x39429A0", VA = "0x1839441A0")]
		private void WHOVNWEFXBG<b, a>(Action<b, a> a) where b : MTCOIMQUIYK where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x84A3B40", Offset = "0x84A2340", VA = "0x1884A3B40")]
		private void POKOHHMOCAW(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3943E30", Offset = "0x3942630", VA = "0x183943E30")]
		private c IKFAPUFSBFV<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x84A3830", Offset = "0x84A2030", VA = "0x1884A3830")]
		private int LCNPAYBTTLA(MTCOIMQUIYK a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84A35A0", Offset = "0x84A1DA0", VA = "0x1884A35A0")]
		private void KYSLPSQYFZE(XCAJKFOSIJQ a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84A2EE0", Offset = "0x84A16E0", VA = "0x1884A2EE0")]
		private void BYMXVGSTYIP(SYGPUJBWLSP a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x84A3490", Offset = "0x84A1C90", VA = "0x1884A3490")]
		private void KQVKVLZJIWT(IZLFKOQWCFF a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x84A3920", Offset = "0x84A2120", VA = "0x1884A3920")]
		private void NKVRIGPKEVI(SRSDDIQSNJE a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<MTCOIMQUIYK> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> VJQZLBXDCBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCA48C0", Offset = "0xCA30C0", VA = "0x180CA48C0")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84A47E0", Offset = "0x84A2FE0", VA = "0x1884A47E0")]
		public PropertyShadowing(List<MTCOIMQUIYK> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84A4330", Offset = "0x84A2B30", VA = "0x1884A4330", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84A44E0", Offset = "0x84A2CE0", VA = "0x1884A44E0")]
		private NativeList<Candidate> QXWNAZNEEEN(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84A4370", Offset = "0x84A2B70", VA = "0x1884A4370")]
		private bool ETQERIUYMGK(MTCOIMQUIYK a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84A4200", Offset = "0x84A2A00", VA = "0x1884A4200")]
		private void CJBJKKNLCXD(MTCOIMQUIYK a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x84A4830", Offset = "0x84A3030", VA = "0x1884A4830", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x84A4840", Offset = "0x84A3040", VA = "0x1884A4840")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x84A4880", Offset = "0x84A3080", VA = "0x1884A4880")]
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
