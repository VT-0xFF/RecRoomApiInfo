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
		[Cpp2IlInjected.Address(RVA = "0x8372010", Offset = "0x8370C10", VA = "0x188372010", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		private int[] RXQWJMLBFSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset DXAPYCEYZZY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8377000", Offset = "0x8375C00", VA = "0x188377000", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8376670", Offset = "0x8375270", VA = "0x188376670")]
		private void JGBTHBSKOEG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8376890", Offset = "0x8375490", VA = "0x188376890", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83768F0", Offset = "0x83754F0", VA = "0x1883768F0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8377020", Offset = "0x8375C20", VA = "0x188377020")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class YJLLFJGYELM : VOIMPATSXCE<Enum>, PXGORJIUYTN, FHGNKDPAWBM, KCOIKAIRWKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool AJOULMIFJZW(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8372740", Offset = "0x8371340", VA = "0x188372740")]
		protected YJLLFJGYELM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class VOIMPATSXCE<a> : FHGNKDPAWBM, KCOIKAIRWKK where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class MIPFINYMDPQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public NFVIWDDFSLX XUAFXXFXALQ;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MIPFINYMDPQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5703570", Offset = "0x5702170", VA = "0x185703570")]
			internal bool LMIQBZBRUWN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4044DF0", Offset = "0x40439F0", VA = "0x184044DF0")]
		protected VOIMPATSXCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x615AB40", Offset = "0x6159740", VA = "0x18615AB40")]
		protected void MAYJNKPWJAP(KVNKJPGTPIS a, NFVIWDDFSLX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x615B110", Offset = "0x6159D10", VA = "0x18615B110")]
		protected void VNLLERPHJVL(SAUPIFBOXJD<a> a, NFVIWDDFSLX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class DGYEYPULMDD : LBTLALYKJXB, KCOIKAIRWKK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] LVHTFUPSIEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] ATXWYFXCGVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void EEXSAUWLFAZ(NFVIWDDFSLX a, FGVUKUHRZYS b, FSKIAIMTZDG c, YYKGLJJFPVJ d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x353C8D0", Offset = "0x353B4D0", VA = "0x18353C8D0")]
		protected static b GVIMTPEHAFL<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x353C6E0", Offset = "0x353B2E0", VA = "0x18353C6E0")]
		protected static void AYBQINPHNPK<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected DGYEYPULMDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class DRKJWPIDIUN<a> : FHGNKDPAWBM, KCOIKAIRWKK where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class MIPFINYMDPQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public NFVIWDDFSLX XUAFXXFXALQ;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MIPFINYMDPQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5703430", Offset = "0x5702030", VA = "0x185703430")]
			internal bool LMIQBZBRUWN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4044DF0", Offset = "0x40439F0", VA = "0x184044DF0")]
		protected DRKJWPIDIUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4042AE0", Offset = "0x40416E0", VA = "0x184042AE0")]
		protected void MAYJNKPWJAP(KVNKJPGTPIS a, NFVIWDDFSLX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4043C50", Offset = "0x4042850", VA = "0x184043C50")]
		protected void VNLLERPHJVL(SAUPIFBOXJD<a> a, NFVIWDDFSLX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(FGVUKUHRZYS), new string[] { })]
	internal class ConfigUIService : FGVUKUHRZYS, KVDAJIKJIJC, HJESUUHTFVQ, IQIQMYLKLGS, GWUWQZCMFZU
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private FSKIAIMTZDG HVESHRNRAZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private YYKGLJJFPVJ BWXGUNEBLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates ZPXHIERATMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray PJNVNEQTTHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<NFVIWDDFSLX> DQWJDWRKKHW;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray LOESHGRXYJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1412870", Offset = "0x1411470", VA = "0x181412870", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x836F5C0", Offset = "0x836E1C0", VA = "0x18836F5C0", Slot = "6")]
		public void InitExternal(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x836F8E0", Offset = "0x836E4E0", VA = "0x18836F8E0", Slot = "7")]
		public void PUBZWIFCMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x836FBE0", Offset = "0x836E7E0", VA = "0x18836FBE0", Slot = "4")]
		public void ZRZOOIALXAP(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x836F1B0", Offset = "0x836DDB0", VA = "0x18836F1B0")]
		private void BIRIGQIEHQN(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x836F9E0", Offset = "0x836E5E0", VA = "0x18836F9E0")]
		private void QYIHAXLILOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x836F290", Offset = "0x836DE90", VA = "0x18836F290")]
		private void EEXSAUWLFAZ(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x836F220", Offset = "0x836DE20", VA = "0x18836F220", Slot = "8")]
		private void ECGVZCYOEDK(FRTNUJPZGKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD19560", Offset = "0xD18160", VA = "0x180D19560", Slot = "9")]
		private void RXSKOFHNRCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83700E0", Offset = "0x836ECE0", VA = "0x1883700E0")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class ZLUCPLGRJRQ : YJLLFJGYELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8376500", Offset = "0x8375100", VA = "0x188376500", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8376460", Offset = "0x8375060", VA = "0x188376460", Slot = "7")]
		public override bool AJOULMIFJZW(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8372740", Offset = "0x8371340", VA = "0x188372740")]
		public ZLUCPLGRJRQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class OUFVQYGHBUT : YJLLFJGYELM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8372690", Offset = "0x8371290", VA = "0x188372690", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83725F0", Offset = "0x83711F0", VA = "0x1883725F0", Slot = "7")]
		public override bool AJOULMIFJZW(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8372740", Offset = "0x8371340", VA = "0x188372740")]
		public OUFVQYGHBUT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class PCOBAWOOVHA : VOIMPATSXCE<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8372780", Offset = "0x8371380", VA = "0x188372780", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83728D0", Offset = "0x83714D0", VA = "0x1883728D0")]
		public PCOBAWOOVHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class MGRILQQHLNM : DGYEYPULMDD
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public FGVUKUHRZYS UPBCAQKTRXM;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x83761E0", Offset = "0x8374DE0", VA = "0x1883761E0")]
			internal (int, int) RRMOIQRSSSX()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8376090", Offset = "0x8374C90", VA = "0x188376090")]
			internal void RRHHLJXVJHO((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] LVHTFUPSIEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] ATXWYFXCGVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8372110", Offset = "0x8370D10", VA = "0x188372110", Slot = "9")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, FGVUKUHRZYS b, FSKIAIMTZDG c, YYKGLJJFPVJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83724C0", Offset = "0x83710C0", VA = "0x1883724C0")]
		public MGRILQQHLNM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class BJRIGVBOMRJ : DRKJWPIDIUN<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x836ED70", Offset = "0x836D970", VA = "0x18836ED70", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x836EE00", Offset = "0x836DA00", VA = "0x18836EE00")]
		public BJRIGVBOMRJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class RELPQFMQPMT : DRKJWPIDIUN<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class HWLFBXLBEBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public NFVIWDDFSLX XUAFXXFXALQ;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HWLFBXLBEBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8371E20", Offset = "0x8370A20", VA = "0x188371E20")]
			internal string RRMOIQRSSSX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8371C70", Offset = "0x8370870", VA = "0x188371C70")]
			internal void RRHHLJXVJHO(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83749F0", Offset = "0x83735F0", VA = "0x1883749F0", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8374B80", Offset = "0x8373780", VA = "0x188374B80")]
		public RELPQFMQPMT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class DWYEIRPSCOE : DRKJWPIDIUN<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HWLFBXLBEBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public NFVIWDDFSLX XUAFXXFXALQ;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HWLFBXLBEBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8371D30", Offset = "0x8370930", VA = "0x188371D30")]
			internal string RRMOIQRSSSX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8371BE0", Offset = "0x83707E0", VA = "0x188371BE0")]
			internal void RRHHLJXVJHO(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8370610", Offset = "0x836F210", VA = "0x188370610", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83707A0", Offset = "0x836F3A0", VA = "0x1883707A0")]
		public DWYEIRPSCOE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class GWDMVHGKDYQ : DRKJWPIDIUN<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class HWLFBXLBEBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NFVIWDDFSLX XUAFXXFXALQ;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HWLFBXLBEBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8371DB0", Offset = "0x83709B0", VA = "0x188371DB0")]
			internal float RRMOIQRSSSX()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8371BC0", Offset = "0x83707C0", VA = "0x188371BC0")]
			internal void RRHHLJXVJHO(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8371EF0", Offset = "0x8370AF0", VA = "0x188371EF0")]
			internal float RRXCDEFNLPP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8371EE0", Offset = "0x8370AE0", VA = "0x188371EE0")]
			internal void RRRVFXLQCEG(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8371F90", Offset = "0x8370B90", VA = "0x188371F90")]
			internal float RSHPXRTIEMH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8371F80", Offset = "0x8370B80", VA = "0x188371F80")]
			internal void RSCJAKZKVAY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8371B50", Offset = "0x8370750", VA = "0x188371B50")]
			internal float RKNYINHXHXW(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8371A70", Offset = "0x8370670", VA = "0x188371A70")]
			internal void IXPVTKFKKBV(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83711A0", Offset = "0x836FDA0", VA = "0x1883711A0", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83715A0", Offset = "0x83701A0", VA = "0x1883715A0")]
		public GWDMVHGKDYQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class BGNUBRCMZJV : DRKJWPIDIUN<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x836ECA0", Offset = "0x836D8A0", VA = "0x18836ECA0", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x836ED30", Offset = "0x836D930", VA = "0x18836ED30")]
		public BGNUBRCMZJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class HSZZAGIQZMY : DRKJWPIDIUN<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83715E0", Offset = "0x83701E0", VA = "0x1883715E0", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8371670", Offset = "0x8370270", VA = "0x188371670")]
		public HSZZAGIQZMY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class SRUNHAILLEL : DRKJWPIDIUN<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HWLFBXLBEBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public NFVIWDDFSLX XUAFXXFXALQ;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HWLFBXLBEBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8371EC0", Offset = "0x8370AC0", VA = "0x188371EC0")]
			internal float RRMOIQRSSSX()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8371BD0", Offset = "0x83707D0", VA = "0x188371BD0")]
			internal void RRHHLJXVJHO(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8371F60", Offset = "0x8370B60", VA = "0x188371F60")]
			internal float RRXCDEFNLPP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8371ED0", Offset = "0x8370AD0", VA = "0x188371ED0")]
			internal void RRRVFXLQCEG(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8372000", Offset = "0x8370C00", VA = "0x188372000")]
			internal float RSHPXRTIEMH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8371F70", Offset = "0x8370B70", VA = "0x188371F70")]
			internal void RSCJAKZKVAY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83716B0", Offset = "0x83702B0", VA = "0x1883716B0")]
			internal float BNDARPFLSWJ(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8371810", Offset = "0x8370410", VA = "0x188371810")]
			internal void EIIWJBZUKIG(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83750C0", Offset = "0x8373CC0", VA = "0x1883750C0", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83754C0", Offset = "0x83740C0", VA = "0x1883754C0")]
		public SRUNHAILLEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class BFUPHOAWKAP : DRKJWPIDIUN<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HWLFBXLBEBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public NFVIWDDFSLX XUAFXXFXALQ;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HWLFBXLBEBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8371E80", Offset = "0x8370A80", VA = "0x188371E80")]
			internal int RRMOIQRSSSX()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8371CE0", Offset = "0x83708E0", VA = "0x188371CE0")]
			internal void RRHHLJXVJHO(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x836EAD0", Offset = "0x836D6D0", VA = "0x18836EAD0", Slot = "5")]
		public override void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x836EC60", Offset = "0x836D860", VA = "0x18836EC60")]
		public BFUPHOAWKAP()
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
	internal static class ZVLOPYZRVAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83765B0", Offset = "0x83751B0", VA = "0x1883765B0")]
		public static void MYWCEZTHJZS(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x836EF30", Offset = "0x836DB30", VA = "0x18836EF30")]
		public static NativeList<NetworkProperty> YERRDXVACGD(NativeObjectLocalIdArray a, FSKIAIMTZDG b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x836EE40", Offset = "0x836DA40", VA = "0x18836EE40")]
		private static bool SIJEJZVBSBQ(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class EAWUSFXSNLW : NFVIWDDFSLX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty XUAFXXFXALQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly FSKIAIMTZDG SSSCLEJSVJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray PJNVNEQTTHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool AHBYTLQTEJW;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string XPPEXRAPNHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8370E20", Offset = "0x836FA20", VA = "0x188370E20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ZFOCEHIGODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8370B40", Offset = "0x836F740", VA = "0x188370B40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject XKZCWEECYPC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8370D80", Offset = "0x836F980", VA = "0x188370D80", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8370DD0", Offset = "0x836F9D0", VA = "0x188370DD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action UKUEKOGHFUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8370BC0", Offset = "0x836F7C0", VA = "0x188370BC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x83708B0", Offset = "0x836F4B0", VA = "0x1883708B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8370E80", Offset = "0x836FA80", VA = "0x188370E80")]
		public EAWUSFXSNLW(NativeObjectLocalIdArray a, NetworkProperty b, FSKIAIMTZDG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8370A30", Offset = "0x836F630", VA = "0x188370A30")]
		private void JBQXLBJGQKS(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8370950", Offset = "0x836F550", VA = "0x188370950", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8370C60", Offset = "0x836F860", VA = "0x188370C60", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83707E0", Offset = "0x836F3E0", VA = "0x1883707E0", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class DRCSNWYISIJ : NZKZSHQKEGK, FHGNKDPAWBM, KCOIKAIRWKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class FWKMQDTJZYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public NFVIWDDFSLX XUAFXXFXALQ;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FWKMQDTJZYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8370FF0", Offset = "0x836FBF0", VA = "0x188370FF0")]
			internal bool RRMOIQRSSSX()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8370F70", Offset = "0x836FB70", VA = "0x188370F70")]
			internal string RRHHLJXVJHO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8371110", Offset = "0x836FD10", VA = "0x188371110")]
			internal void RRXCDEFNLPP(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8371040", Offset = "0x836FC40", VA = "0x188371040")]
			internal string RRRVFXLQCEG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty BYKNUORMGUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x83705A0", Offset = "0x836F1A0", VA = "0x1883705A0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8370160", Offset = "0x836ED60", VA = "0x188370160", Slot = "5")]
		public void EEXSAUWLFAZ(NFVIWDDFSLX a, YYKGLJJFPVJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public DRCSNWYISIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class ULEGCGZMBSB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly FSKIAIMTZDG HVESHRNRAZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly YYKGLJJFPVJ ANJLVKZMIYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> IGRXSDFNTVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<GITFXUBMOXD> IKHOBDQCXWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<GITFXUBMOXD, List<Candidate>> VOHZYIUUMYJ;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8375F80", Offset = "0x8374B80", VA = "0x188375F80")]
		public ULEGCGZMBSB(FSKIAIMTZDG a, YYKGLJJFPVJ b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8375AD0", Offset = "0x83746D0", VA = "0x188375AD0")]
		public void PFGNBIRTMKD(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8375E10", Offset = "0x8374A10", VA = "0x188375E10")]
		private void ZCFDKTQYOGN(GITFXUBMOXD a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8375560", Offset = "0x8374160", VA = "0x188375560")]
		public void EEOOCGUHRZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8375660", Offset = "0x8374260", VA = "0x188375660")]
		private void NZJTOUHGVCR(GITFXUBMOXD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83755C0", Offset = "0x83741C0", VA = "0x1883755C0")]
		private void JIOHHWOERGA(GITFXUBMOXD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class SJFDENVOERC : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type TYTIIADQMLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type JCAIYSTVFHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator KYBQTQIMGAL;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty ARTJZDFRQET
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xB0BC00", Offset = "0xB0A800", VA = "0x180B0BC00", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x8374BC0", Offset = "0x83737C0", VA = "0x188374BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x12AE9F0", Offset = "0x12AD5F0", VA = "0x1812AE9F0")]
			[DebuggerHidden]
			public SJFDENVOERC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8375030", Offset = "0x8373C30", VA = "0x188375030", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8374C60", Offset = "0x8373860", VA = "0x188374C60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8374C10", Offset = "0x8373810", VA = "0x188374C10")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8374FF0", Offset = "0x8373BF0", VA = "0x188374FF0", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8374F40", Offset = "0x8373B40", VA = "0x188374F40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> PNCGMVHRHWI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8374F40", Offset = "0x8373B40", VA = "0x188374F40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> RCVXPUFXBSP;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8372B30", Offset = "0x8371730", VA = "0x188372B30")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8372950", Offset = "0x8371550", VA = "0x188372950")]
		[IteratorStateMachine(typeof(SJFDENVOERC))]
		public IEnumerable<NetworkProperty> KKCDVFDMQEJ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8372910", Offset = "0x8371510", VA = "0x188372910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83729E0", Offset = "0x83715E0", VA = "0x1883729E0")]
		private long MZELEIDUZBK(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8372A60", Offset = "0x8371660", VA = "0x188372A60")]
		private long MZELEIDUZBK(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x8373040", Offset = "0x8371C40", VA = "0x188373040")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8372E80", Offset = "0x8371A80", VA = "0x188372E80")]
		public static PropertyBitmap BJDWJOCUXHF(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8373020", Offset = "0x8371C20", VA = "0x188373020")]
		public bool OECEDCPAPBD(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8373030", Offset = "0x8371C30", VA = "0x188373030")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8372D20", Offset = "0x8371920", VA = "0x188372D20")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8372DD0", Offset = "0x83719D0", VA = "0x188372DD0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8373010", Offset = "0x8371C10", VA = "0x188373010", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly FSKIAIMTZDG HVESHRNRAZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<KCOIKAIRWKK> AYCJUYAZTZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType RCVXPUFXBSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> XNLDKSRPKTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> IZTXEKAIPRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool AHBYTLQTEJW;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<KCOIKAIRWKK> ZIVPIMTMJBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8374280", Offset = "0x8372E80", VA = "0x188374280")]
		public PropertyDrawerCandidates(FSKIAIMTZDG configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83731E0", Offset = "0x8371DE0", VA = "0x1883731E0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8373A60", Offset = "0x8372660", VA = "0x188373A60")]
		public void PIVHAQSNIZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8373CF0", Offset = "0x83728F0", VA = "0x188373CF0")]
		public NativeList<Candidate> XFFSLFCYGQX(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8373090", Offset = "0x8371C90", VA = "0x188373090")]
		private bool CEFRNEETGUN(KCOIKAIRWKK a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3920840", Offset = "0x391F440", VA = "0x183920840")]
		private void EIDXPCXAOLS<b, a>(Action<b, a> a) where b : KCOIKAIRWKK where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x83741C0", Offset = "0x8372DC0", VA = "0x1883741C0")]
		private void XVUELQMAYGG(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x39204D0", Offset = "0x391F0D0", VA = "0x1839204D0")]
		private c CQXGYSQBFNR<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8373C00", Offset = "0x8372800", VA = "0x188373C00")]
		private int WWQMHGUFDGG(KCOIKAIRWKK a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83734A0", Offset = "0x83720A0", VA = "0x1883734A0")]
		private void JKISTSBHJJY(FHGNKDPAWBM a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8373730", Offset = "0x8372330", VA = "0x188373730")]
		private void LITPZXAWSDV(PXGORJIUYTN a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x83732C0", Offset = "0x8371EC0", VA = "0x1883732C0")]
		private void EMUVWSTZEAD(LBTLALYKJXB a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83733D0", Offset = "0x8371FD0", VA = "0x1883733D0")]
		private void GLZQDDDQGXI(NZKZSHQKEGK a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<KCOIKAIRWKK> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> GRZLQICVYJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xC3E6B0", Offset = "0xC3D2B0", VA = "0x180C3E6B0")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x83749A0", Offset = "0x83735A0", VA = "0x1883749A0")]
		public PropertyShadowing(List<KCOIKAIRWKK> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x83743C0", Offset = "0x8372FC0", VA = "0x1883743C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83746A0", Offset = "0x83732A0", VA = "0x1883746A0")]
		private NativeList<Candidate> UENGLMSIJIN(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8374530", Offset = "0x8373130", VA = "0x188374530")]
		private bool OHZJABWIFIG(KCOIKAIRWKK a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8374400", Offset = "0x8373000", VA = "0x188374400")]
		private void KSRXHWMUYFL(KCOIKAIRWKK a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8375500", Offset = "0x8374100", VA = "0x188375500", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8375510", Offset = "0x8374110", VA = "0x188375510")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8375550", Offset = "0x8374150", VA = "0x188375550")]
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
