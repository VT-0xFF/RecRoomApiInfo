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
		[Cpp2IlInjected.Address(RVA = "0x84385A0", Offset = "0x84379A0", VA = "0x1884385A0", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		private int[] DTCBHPALRHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset GTGGRGPIZNX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x843DDF0", Offset = "0x843D1F0", VA = "0x18843DDF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x843D480", Offset = "0x843C880", VA = "0x18843D480")]
		private void RGTQLMDRHIR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x843D6A0", Offset = "0x843CAA0", VA = "0x18843D6A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x843D700", Offset = "0x843CB00", VA = "0x18843D700", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x843DE10", Offset = "0x843D210", VA = "0x18843DE10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class VMOTMGMSMQR : BNTWINDZYYN<Enum>, XGSBPYGZUDM, ATGXYKWIDMR, ZGCTZEKWYGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool CDDTPTEHSPB(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8435BA0", Offset = "0x8434FA0", VA = "0x188435BA0")]
		protected VMOTMGMSMQR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class BNTWINDZYYN<a> : ATGXYKWIDMR, ZGCTZEKWYGB where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class SYKSUEBHFID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public ZIKITLKPJEC ZLKRQBFCYXV;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public SYKSUEBHFID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5DFF680", Offset = "0x5DFEA80", VA = "0x185DFF680")]
			internal bool GSTERIJWTJI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4B40", Offset = "0x5DE3F40", VA = "0x185DE4B40")]
		protected BNTWINDZYYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A660", Offset = "0x6F69A60", VA = "0x186F6A660")]
		protected void ITBBHUJWFCE(UBQEGBDJKZF a, ZIKITLKPJEC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AC30", Offset = "0x6F6A030", VA = "0x186F6AC30")]
		protected void XHKHZECYLZM(YIEQTEZZRCU<a> a, ZIKITLKPJEC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class PXBYLFQDYQC : FIFMXVGZKZM, ZGCTZEKWYGB
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] VTHYLPDTLUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] OSNJYVABXKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void AMXQQKXHPXC(ZIKITLKPJEC a, LPZXIMFRPHT b, SSWQSTIQGVL c, TKYZNQIWDHC d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3880440", Offset = "0x387F840", VA = "0x183880440")]
		protected static b MWVADQTFUSU<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3880250", Offset = "0x387F650", VA = "0x183880250")]
		protected static void IITQWHVZUKZ<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected PXBYLFQDYQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class SLJJPSKASPW<a> : ATGXYKWIDMR, ZGCTZEKWYGB where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class SYKSUEBHFID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public ZIKITLKPJEC ZLKRQBFCYXV;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public SYKSUEBHFID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5DFF860", Offset = "0x5DFEC60", VA = "0x185DFF860")]
			internal bool GSTERIJWTJI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4B40", Offset = "0x5DE3F40", VA = "0x185DE4B40")]
		protected SLJJPSKASPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3000", Offset = "0x5DE2400", VA = "0x185DE3000")]
		protected void ITBBHUJWFCE(UBQEGBDJKZF a, ZIKITLKPJEC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5DE45B0", Offset = "0x5DE39B0", VA = "0x185DE45B0")]
		protected void XHKHZECYLZM(YIEQTEZZRCU<a> a, ZIKITLKPJEC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(LPZXIMFRPHT), new string[] { })]
	internal class ConfigUIService : LPZXIMFRPHT, RDQXTNNVCSB, LGPJMXYAVLB, TUMMHZEQETT, LZXVIVBNZGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private SSWQSTIQGVL ROHREVFQBGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private TKYZNQIWDHC MEFADWJVMUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates EMSDXNCVFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray ESQJXRYBVXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<ZIKITLKPJEC> PBWZUZLCKSD;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray WSWWGRSUBLS
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1409290", Offset = "0x1408690", VA = "0x181409290", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8436620", Offset = "0x8435A20", VA = "0x188436620", Slot = "6")]
		public void InitExternal(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8436940", Offset = "0x8435D40", VA = "0x188436940", Slot = "7")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8436A40", Offset = "0x8435E40", VA = "0x188436A40", Slot = "4")]
		public void YKYSKNZVOPY(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84365B0", Offset = "0x84359B0", VA = "0x1884365B0")]
		private void GHPLLDQTIWY(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84363C0", Offset = "0x84357C0", VA = "0x1884363C0")]
		private void GEZBDBOAZLZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8436020", Offset = "0x8435420", VA = "0x188436020")]
		private void AMXQQKXHPXC(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8436350", Offset = "0x8435750", VA = "0x188436350", Slot = "8")]
		private void EEVWSJPJMZT(SAMXOKXXSFT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD15010", Offset = "0xD14410", VA = "0x180D15010", Slot = "9")]
		private void BFZHWFFBFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8436F30", Offset = "0x8436330", VA = "0x188436F30")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class DHHHFQXLOHJ : VMOTMGMSMQR
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8436FB0", Offset = "0x84363B0", VA = "0x188436FB0", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8437060", Offset = "0x8436460", VA = "0x188437060", Slot = "7")]
		public override bool CDDTPTEHSPB(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8435BA0", Offset = "0x8434FA0", VA = "0x188435BA0")]
		public DHHHFQXLOHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class ATKAKDZSRTS : VMOTMGMSMQR
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8435A50", Offset = "0x8434E50", VA = "0x188435A50", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8435B00", Offset = "0x8434F00", VA = "0x188435B00", Slot = "7")]
		public override bool CDDTPTEHSPB(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8435BA0", Offset = "0x8434FA0", VA = "0x188435BA0")]
		public ATKAKDZSRTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class ERDESMZBRCB : BNTWINDZYYN<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84374A0", Offset = "0x84368A0", VA = "0x1884374A0", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84375F0", Offset = "0x84369F0", VA = "0x1884375F0")]
		public ERDESMZBRCB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class UQFTARZFRGR : PXBYLFQDYQC
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LPZXIMFRPHT DRQCYWAFFJL;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8437100", Offset = "0x8436500", VA = "0x188437100")]
			internal (int, int) VXRVGDIHFFA()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8437360", Offset = "0x8436760", VA = "0x188437360")]
			internal void VXXCDKCEOQJ((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] VTHYLPDTLUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] OSNJYVABXKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x843BDC0", Offset = "0x843B1C0", VA = "0x18843BDC0", Slot = "9")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, LPZXIMFRPHT b, SSWQSTIQGVL c, TKYZNQIWDHC d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x843C170", Offset = "0x843B570", VA = "0x18843C170")]
		public UQFTARZFRGR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class AUBDPBQSSDQ : SLJJPSKASPW<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8435BE0", Offset = "0x8434FE0", VA = "0x188435BE0", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8435C70", Offset = "0x8435070", VA = "0x188435C70")]
		public AUBDPBQSSDQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class REFOPXIRGXC : SLJJPSKASPW<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class EZOENQOHZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public ZIKITLKPJEC ZLKRQBFCYXV;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZOENQOHZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8437C50", Offset = "0x8437050", VA = "0x188437C50")]
			internal string VXRVGDIHFFA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8437D90", Offset = "0x8437190", VA = "0x188437D90")]
			internal void VXXCDKCEOQJ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x843B750", Offset = "0x843AB50", VA = "0x18843B750", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x843B8E0", Offset = "0x843ACE0", VA = "0x18843B8E0")]
		public REFOPXIRGXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class LUIEWAYKLFF : SLJJPSKASPW<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class EZOENQOHZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public ZIKITLKPJEC ZLKRQBFCYXV;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZOENQOHZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8437CC0", Offset = "0x84370C0", VA = "0x188437CC0")]
			internal string VXRVGDIHFFA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8437E00", Offset = "0x8437200", VA = "0x188437E00")]
			internal void VXXCDKCEOQJ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84383D0", Offset = "0x84377D0", VA = "0x1884383D0", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8438560", Offset = "0x8437960", VA = "0x188438560")]
		public LUIEWAYKLFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class RJVWHDOYQGB : SLJJPSKASPW<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class EZOENQOHZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public ZIKITLKPJEC ZLKRQBFCYXV;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZOENQOHZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8437BE0", Offset = "0x8436FE0", VA = "0x188437BE0")]
			internal float VXRVGDIHFFA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8437EE0", Offset = "0x84372E0", VA = "0x188437EE0")]
			internal void VXXCDKCEOQJ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8437B50", Offset = "0x8436F50", VA = "0x188437B50")]
			internal float VXHHLPUMMII()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8437BC0", Offset = "0x8436FC0", VA = "0x188437BC0")]
			internal void VXMOIWOJVTR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8437EF0", Offset = "0x84372F0", VA = "0x188437EF0")]
			internal float VYMWVEJWQYK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8437F80", Offset = "0x8437380", VA = "0x188437F80")]
			internal void VYSDSLDUAJT(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8437630", Offset = "0x8436A30", VA = "0x188437630")]
			internal float BXLRABYTWUB(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x84376A0", Offset = "0x8436AA0", VA = "0x1884376A0")]
			internal void DXNTUVJPSZQ(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x843B920", Offset = "0x843AD20", VA = "0x18843B920", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x843BD20", Offset = "0x843B120", VA = "0x18843BD20")]
		public RJVWHDOYQGB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class QDIFSEORUOM : SLJJPSKASPW<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x843B680", Offset = "0x843AA80", VA = "0x18843B680", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x843B710", Offset = "0x843AB10", VA = "0x18843B710")]
		public QDIFSEORUOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class AKGSOOSQUWT : SLJJPSKASPW<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8435980", Offset = "0x8434D80", VA = "0x188435980", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8435A10", Offset = "0x8434E10", VA = "0x188435A10")]
		public AKGSOOSQUWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class LBRQYNLVSYK : SLJJPSKASPW<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class EZOENQOHZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public ZIKITLKPJEC ZLKRQBFCYXV;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZOENQOHZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8437CB0", Offset = "0x84370B0", VA = "0x188437CB0")]
			internal float VXRVGDIHFFA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8437D80", Offset = "0x8437180", VA = "0x188437D80")]
			internal void VXXCDKCEOQJ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8437B40", Offset = "0x8436F40", VA = "0x188437B40")]
			internal float VXHHLPUMMII()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8437BD0", Offset = "0x8436FD0", VA = "0x188437BD0")]
			internal void VXMOIWOJVTR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8437F60", Offset = "0x8437360", VA = "0x188437F60")]
			internal float VYMWVEJWQYK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8437F70", Offset = "0x8437370", VA = "0x188437F70")]
			internal void VYSDSLDUAJT(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8437780", Offset = "0x8436B80", VA = "0x188437780")]
			internal float JQSLYCNYBVA(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x84378E0", Offset = "0x8436CE0", VA = "0x1884378E0")]
			internal void UMQESASWSAN(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8437F90", Offset = "0x8437390", VA = "0x188437F90", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8438390", Offset = "0x8437790", VA = "0x188438390")]
		public LBRQYNLVSYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class QBZUVMHQGAO : SLJJPSKASPW<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class EZOENQOHZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public ZIKITLKPJEC ZLKRQBFCYXV;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZOENQOHZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8437D40", Offset = "0x8437140", VA = "0x188437D40")]
			internal int VXRVGDIHFFA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8437E90", Offset = "0x8437290", VA = "0x188437E90")]
			internal void VXXCDKCEOQJ(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x843B4B0", Offset = "0x843A8B0", VA = "0x18843B4B0", Slot = "5")]
		public override void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x843B640", Offset = "0x843AA40", VA = "0x18843B640")]
		public QBZUVMHQGAO()
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
	internal static class YMDQQFXHGNZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x843C730", Offset = "0x843BB30", VA = "0x18843C730")]
		public static void INIZXXVYCGV(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8435DA0", Offset = "0x84351A0", VA = "0x188435DA0")]
		public static NativeList<NetworkProperty> WCPZIBSWYVG(NativeObjectLocalIdArray a, SSWQSTIQGVL b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8435CB0", Offset = "0x84350B0", VA = "0x188435CB0")]
		private static bool RRYZKXZYWEJ(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class YWWZKIDGUQB : ZIKITLKPJEC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty ZLKRQBFCYXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly SSWQSTIQGVL DPKLBQQZWEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray ESQJXRYBVXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool GQSAKQHYXLT;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x843CCF0", Offset = "0x843C0F0", VA = "0x18843CCF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AFDDQPQJFSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x843CF50", Offset = "0x843C350", VA = "0x18843CF50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject EFSSQPZVUWH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x843CE20", Offset = "0x843C220", VA = "0x18843CE20", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x843D340", Offset = "0x843C740", VA = "0x18843D340", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NQDKLOGUIZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x843D2A0", Offset = "0x843C6A0", VA = "0x18843D2A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x843CFD0", Offset = "0x843C3D0", VA = "0x18843CFD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x843D390", Offset = "0x843C790", VA = "0x18843D390")]
		public YWWZKIDGUQB(NativeObjectLocalIdArray a, NetworkProperty b, SSWQSTIQGVL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x843D070", Offset = "0x843C470", VA = "0x18843D070")]
		private void OBUCAQSOCNL(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x843CE70", Offset = "0x843C270", VA = "0x18843CE70", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x843D180", Offset = "0x843C580", VA = "0x18843D180", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x843CD50", Offset = "0x843C150", VA = "0x18843CD50", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class XVZNSVFSDHA : LHURQYRGYZH, ATGXYKWIDMR, ZGCTZEKWYGB
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class OFEBALTHFAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ZIKITLKPJEC ZLKRQBFCYXV;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OFEBALTHFAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8438800", Offset = "0x8437C00", VA = "0x188438800")]
			internal bool VXRVGDIHFFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8438850", Offset = "0x8437C50", VA = "0x188438850")]
			internal string VXXCDKCEOQJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x84386A0", Offset = "0x8437AA0", VA = "0x1884386A0")]
			internal void VXHHLPUMMII(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8438730", Offset = "0x8437B30", VA = "0x188438730")]
			internal string VXMOIWOJVTR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty FPQWNIOTCZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x843C6C0", Offset = "0x843BAC0", VA = "0x18843C6C0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x843C290", Offset = "0x843B690", VA = "0x18843C290", Slot = "5")]
		public void AMXQQKXHPXC(ZIKITLKPJEC a, TKYZNQIWDHC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public XVZNSVFSDHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class OYYECYKWGZQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly SSWQSTIQGVL ROHREVFQBGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly TKYZNQIWDHC DOLRYQKYAVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> OMHEGHOWDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<DMJRVFLDVIQ> ACITZVHJNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<DMJRVFLDVIQ, List<Candidate>> FSCCFFBGLYG;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8439300", Offset = "0x8438700", VA = "0x188439300")]
		public OYYECYKWGZQ(SSWQSTIQGVL a, TKYZNQIWDHC b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8438F60", Offset = "0x8438360", VA = "0x188438F60")]
		public void KQAMAZJYRSG(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8438DF0", Offset = "0x84381F0", VA = "0x188438DF0")]
		private void KBQHDOGWOVU(DMJRVFLDVIQ a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84392A0", Offset = "0x84386A0", VA = "0x1884392A0")]
		public void NRBZXHAKCAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84388D0", Offset = "0x8437CD0", VA = "0x1884388D0")]
		private void DDNAKHWVHVU(DMJRVFLDVIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8438D50", Offset = "0x8438150", VA = "0x188438D50")]
		private void EQDCBCGGEXT(DMJRVFLDVIQ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class YTDWNQWVAAH : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type UCRFZIXSQJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type HYVZAUTFHYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator BPMZBLFMONE;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty ZXEMFSPRYUI
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x843CC50", Offset = "0x843C050", VA = "0x18843CC50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1293840", Offset = "0x1292C40", VA = "0x181293840")]
			[DebuggerHidden]
			public YTDWNQWVAAH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x843C7F0", Offset = "0x843BBF0", VA = "0x18843C7F0", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x843C970", Offset = "0x843BD70", VA = "0x18843C970", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x843CCA0", Offset = "0x843C0A0", VA = "0x18843CCA0")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x843C930", Offset = "0x843BD30", VA = "0x18843C930", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x843C880", Offset = "0x843BC80", VA = "0x18843C880", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> FYTPLSJXZFZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x843C880", Offset = "0x843BC80", VA = "0x18843C880", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> CGELCFAHNUS;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8439620", Offset = "0x8438A20", VA = "0x188439620")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8439450", Offset = "0x8438850", VA = "0x188439450")]
		[IteratorStateMachine(typeof(YTDWNQWVAAH))]
		public IEnumerable<NetworkProperty> EPRORFLLYLE(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8439410", Offset = "0x8438810", VA = "0x188439410", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84394E0", Offset = "0x84388E0", VA = "0x1884394E0")]
		private long HNAFAUTTDLP(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8439560", Offset = "0x8438960", VA = "0x188439560")]
		private long HNAFAUTTDLP(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x8439B30", Offset = "0x8438F30", VA = "0x188439B30")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8439980", Offset = "0x8438D80", VA = "0x188439980")]
		public static PropertyBitmap EQMUBUJKUKQ(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8439B20", Offset = "0x8438F20", VA = "0x188439B20")]
		public bool WXKPRRAURNM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8439B10", Offset = "0x8438F10", VA = "0x188439B10")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8439810", Offset = "0x8438C10", VA = "0x188439810")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x84398C0", Offset = "0x8438CC0", VA = "0x1884398C0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8439970", Offset = "0x8438D70", VA = "0x188439970", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly SSWQSTIQGVL ROHREVFQBGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<ZGCTZEKWYGB> YHLXCWZPVIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType CGELCFAHNUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> SIKIRAXBAYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> EQPDAYXCGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool GQSAKQHYXLT;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<ZGCTZEKWYGB> IIZNSNWFQIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x843AD40", Offset = "0x843A140", VA = "0x18843AD40")]
		public PropertyDrawerCandidates(SSWQSTIQGVL configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8439B80", Offset = "0x8438F80", VA = "0x188439B80")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8439DB0", Offset = "0x84391B0", VA = "0x188439DB0")]
		public void FGDSCXKYMJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x843A050", Offset = "0x8439450", VA = "0x18843A050")]
		public NativeList<Candidate> MZENGRZILPG(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8439C60", Offset = "0x8439060", VA = "0x188439C60")]
		private bool EYXJXMXSLGG(ZGCTZEKWYGB a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x394FAC0", Offset = "0x394EEC0", VA = "0x18394FAC0")]
		private void WLCWVZDIVLR<b, a>(Action<b, a> a) where b : ZGCTZEKWYGB where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8439F50", Offset = "0x8439350", VA = "0x188439F50")]
		private void HAJPACPZRRB(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x394F750", Offset = "0x394EB50", VA = "0x18394F750")]
		private c QZTNYKJGRIK<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x843A520", Offset = "0x8439920", VA = "0x18843A520")]
		private int SRVNURPRGKB(ZGCTZEKWYGB a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x843A930", Offset = "0x8439D30", VA = "0x18843A930")]
		private void XGSPYOQDJBJ(ATGXYKWIDMR a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x843A610", Offset = "0x8439A10", VA = "0x18843A610")]
		private void UQZQANRVZFG(XGSBPYGZUDM a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x843ABB0", Offset = "0x8439FB0", VA = "0x18843ABB0")]
		private void ZWFWIUNQJVG(FIFMXVGZKZM a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8439F80", Offset = "0x8439380", VA = "0x188439F80")]
		private void IECONJNXOCH(LHURQYRGYZH a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<ZGCTZEKWYGB> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> TDCEZBJSUOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x843B460", Offset = "0x843A860", VA = "0x18843B460")]
		public PropertyShadowing(List<ZGCTZEKWYGB> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x843AE80", Offset = "0x843A280", VA = "0x18843AE80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x843AEC0", Offset = "0x843A2C0", VA = "0x18843AEC0")]
		private NativeList<Candidate> EWLLWBWOMKC(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x843B2F0", Offset = "0x843A6F0", VA = "0x18843B2F0")]
		private bool SWGLZVCBNIP(ZGCTZEKWYGB a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x843B1C0", Offset = "0x843A5C0", VA = "0x18843B1C0")]
		private void JUHBSJBOPPE(ZGCTZEKWYGB a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x843BD60", Offset = "0x843B160", VA = "0x18843BD60", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x843BD70", Offset = "0x843B170", VA = "0x18843BD70")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x843BDB0", Offset = "0x843B1B0", VA = "0x18843BDB0")]
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
