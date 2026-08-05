using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.SynchronizedFields;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface RXTOIPCBOAE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool ORXTDLHBVBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool LJSZONNNHOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		LZEYQUPSRUQ YXQJYMCHFFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int ETLDSKTZHHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool QKDQVVNUOWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool DZQJRWQYKKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action XCTFEMVTIFN;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AGAODGTUDHU();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void DASRPJBFRIU(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void SQGTUMIQLDI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface LPRXYCAMSMJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string UWPCMRAPJZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool ZKLCKPNHVFS
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface QCHARKLRYZM<a> : LPRXYCAMSMJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a QXPMUFOLRJI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IJBSPQCWZFV(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class WJYJSIRESOD<a> : QCHARKLRYZM<a>, LPRXYCAMSMJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly KDHZRFNEEGM<a> UMRMHHNWFZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly KDHZRFNEEGM<a> RTGFNCQHSUZ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string UWPCMRAPJZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xFDE650", Offset = "0xFDD450", VA = "0x180FDE650", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PJUDBAWPFIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6800490", Offset = "0x67FF290", VA = "0x186800490", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a VVJBSITEIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6802DB0", Offset = "0x6801BB0", VA = "0x186802DB0", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x68019D0", Offset = "0x68007D0", VA = "0x1868019D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a QXPMUFOLRJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x68028E0", Offset = "0x68016E0", VA = "0x1868028E0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6802C60", Offset = "0x6801A60", VA = "0x186802C60", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a XDXPKJAQNFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x68028E0", Offset = "0x68016E0", VA = "0x1868028E0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67FF710", Offset = "0x67FE510", VA = "0x1867FF710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ZKLCKPNHVFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x67FB540", Offset = "0x67FA340", VA = "0x1867FB540", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67FC200", Offset = "0x67FB000", VA = "0x1867FC200", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x68028C0", Offset = "0x68016C0", VA = "0x1868028C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6802480", Offset = "0x6801280", VA = "0x186802480", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6802F70", Offset = "0x6801D70", VA = "0x186802F70")]
		public WJYJSIRESOD([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6802020", Offset = "0x6800E20", VA = "0x186802020")]
		private void PPNPBXMPBAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67FF080", Offset = "0x67FDE80", VA = "0x1867FF080", Slot = "5")]
		public void IJBSPQCWZFV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67FF030", Offset = "0x67FDE30", VA = "0x1867FF030")]
		public void IJBSPQCWZFV(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB560", Offset = "0x67FA360", VA = "0x1867FB560", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class WKDQPPLCBZM<a, b> : QCHARKLRYZM<(a, b)>, LPRXYCAMSMJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly KDXUIZUWGON<a, b> UMRMHHNWFZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly KDXUIZUWGON<a, b> RTGFNCQHSUZ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string UWPCMRAPJZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xFDE650", Offset = "0xFDD450", VA = "0x180FDE650", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PJUDBAWPFIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6807350", Offset = "0x6806150", VA = "0x186807350", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool UBBZGSLNDGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x68069B0", Offset = "0x68057B0", VA = "0x1868069B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool UBHGDZFKMSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6806E50", Offset = "0x6805C50", VA = "0x186806E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) VVJBSITEIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x680A830", Offset = "0x6809630", VA = "0x18680A830", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6807DB0", Offset = "0x6806BB0", VA = "0x186807DB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) QXPMUFOLRJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x680A310", Offset = "0x6809110", VA = "0x18680A310", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x680A0C0", Offset = "0x6808EC0", VA = "0x18680A0C0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) XDXPKJAQNFO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6809AB0", Offset = "0x68088B0", VA = "0x186809AB0")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6807040", Offset = "0x6805E40", VA = "0x186807040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a KQFNBSAIKCS
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6804D90", Offset = "0x6803B90", VA = "0x186804D90")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6808B60", Offset = "0x6807960", VA = "0x186808B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a OAVTXLHCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6805000", Offset = "0x6803E00", VA = "0x186805000")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a UPLBIYTHVWX
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6805000", Offset = "0x6803E00", VA = "0x186805000")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6805B60", Offset = "0x6804960", VA = "0x186805B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b KQAGELGLARJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6804DC0", Offset = "0x6803BC0", VA = "0x186804DC0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6809040", Offset = "0x6807E40", VA = "0x186809040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b OAFZFQZKFIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6804F10", Offset = "0x6803D10", VA = "0x186804F10")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b UPQIGFNFFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6804F10", Offset = "0x6803D10", VA = "0x186804F10")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6805790", Offset = "0x6804590", VA = "0x186805790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool ZKLCKPNHVFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x67FB540", Offset = "0x67FA340", VA = "0x1867FB540", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x67FC200", Offset = "0x67FB000", VA = "0x1867FC200", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68099A0", Offset = "0x68087A0", VA = "0x1868099A0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x680B070", Offset = "0x6809E70", VA = "0x18680B070")]
		public WKDQPPLCBZM([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6808950", Offset = "0x6807750", VA = "0x186808950")]
		private void PPNPBXMPBAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6806590", Offset = "0x6805390", VA = "0x186806590")]
		public void KDWMIZUIVBK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68060F0", Offset = "0x6804EF0", VA = "0x1868060F0")]
		public void IJBSPQCWZFV(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6805450", Offset = "0x6804250", VA = "0x186805450", Slot = "5")]
		private void CAQLEQATOIY((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB560", Offset = "0x67FA360", VA = "0x1867FB560", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class WKIXMWEZLKV<a, b, c> : QCHARKLRYZM<(a, b, c)>, LPRXYCAMSMJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly KDSNLTAYXDE<a, b, c> UMRMHHNWFZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly KDSNLTAYXDE<a, b, c> RTGFNCQHSUZ;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string UWPCMRAPJZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xFDE650", Offset = "0xFDD450", VA = "0x180FDE650", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool PJUDBAWPFIU
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x680DF70", Offset = "0x680CD70", VA = "0x18680DF70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool UBBZGSLNDGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x680D6A0", Offset = "0x680C4A0", VA = "0x18680D6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool UBHGDZFKMSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x680DA20", Offset = "0x680C820", VA = "0x18680DA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool UBMNBFZHWDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x680D880", Offset = "0x680C680", VA = "0x18680D880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) VVJBSITEIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6810280", Offset = "0x680F080", VA = "0x186810280", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x680E580", Offset = "0x680D380", VA = "0x18680E580", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) QXPMUFOLRJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x680FAB0", Offset = "0x680E8B0", VA = "0x18680FAB0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x680FA60", Offset = "0x680E860", VA = "0x18680FA60", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a KQFNBSAIKCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x680BE10", Offset = "0x680AC10", VA = "0x18680BE10")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x680EF00", Offset = "0x680DD00", VA = "0x18680EF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a OAVTXLHCHQR
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x680C270", Offset = "0x680B070", VA = "0x18680C270")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a UPLBIYTHVWX
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x680C270", Offset = "0x680B070", VA = "0x18680C270")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x680CBE0", Offset = "0x680B9E0", VA = "0x18680CBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b KQAGELGLARJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x680BEF0", Offset = "0x680ACF0", VA = "0x18680BEF0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x680F000", Offset = "0x680DE00", VA = "0x18680F000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b OAFZFQZKFIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x680C190", Offset = "0x680AF90", VA = "0x18680C190")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b UPQIGFNFFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x680C190", Offset = "0x680AF90", VA = "0x18680C190")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x680C890", Offset = "0x680B690", VA = "0x18680C890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c KPUZHEMNRGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x680C080", Offset = "0x680AE80", VA = "0x18680C080")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x680F4D0", Offset = "0x680E2D0", VA = "0x18680F4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c OALGCXTHOTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x680C160", Offset = "0x680AF60", VA = "0x18680C160")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c UPVPDMHCOTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x680C160", Offset = "0x680AF60", VA = "0x18680C160")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x680C6C0", Offset = "0x680B4C0", VA = "0x18680C6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ZKLCKPNHVFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x67FB540", Offset = "0x67FA340", VA = "0x1867FB540", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x680F600", Offset = "0x680E400", VA = "0x18680F600", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6810B80", Offset = "0x680F980", VA = "0x186810B80")]
		public WKIXMWEZLKV([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x680E9A0", Offset = "0x680D7A0", VA = "0x18680E9A0")]
		private void PPNPBXMPBAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x680D260", Offset = "0x680C060", VA = "0x18680D260")]
		public void KDWMIZUIVBK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x680C560", Offset = "0x680B360", VA = "0x18680C560")]
		public void GAUTMUXIMOP(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x680D100", Offset = "0x680BF00", VA = "0x18680D100")]
		public void KCFZLFZELYG(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x680CC70", Offset = "0x680BA70", VA = "0x18680CC70")]
		public void IJBSPQCWZFV(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x680DAF0", Offset = "0x680C8F0", VA = "0x18680DAF0", Slot = "5")]
		private void MFVWFEABZKV((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB560", Offset = "0x67FA360", VA = "0x1867FB560", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class WIYBGAVRXJK<a, b, c, d> : QCHARKLRYZM<(a, b, c, d)>, LPRXYCAMSMJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly KEIIDNIQZLF<a, b, c, d> UMRMHHNWFZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly KEIIDNIQZLF<a, b, c, d> RTGFNCQHSUZ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string UWPCMRAPJZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xFDE650", Offset = "0xFDD450", VA = "0x180FDE650", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) QXPMUFOLRJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x67FC600", Offset = "0x67FB400", VA = "0x1867FC600", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x67FC5B0", Offset = "0x67FB3B0", VA = "0x1867FC5B0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b OAFZFQZKFIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x67FBA20", Offset = "0x67FA820", VA = "0x1867FBA20")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c OALGCXTHOTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x67FB890", Offset = "0x67FA690", VA = "0x1867FB890")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d NZVLLDLPMLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x67FBB00", Offset = "0x67FA900", VA = "0x1867FBB00")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool ZKLCKPNHVFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x67FB540", Offset = "0x67FA340", VA = "0x1867FB540", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x67FC200", Offset = "0x67FB000", VA = "0x1867FC200", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x67FD140", Offset = "0x67FBF40", VA = "0x1867FD140")]
		public WIYBGAVRXJK([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x67FBEA0", Offset = "0x67FACA0", VA = "0x1867FBEA0")]
		private void PPNPBXMPBAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67FBB30", Offset = "0x67FA930", VA = "0x1867FBB30")]
		public void KDWMIZUIVBK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67FB5A0", Offset = "0x67FA3A0", VA = "0x1867FB5A0")]
		public void IJBSPQCWZFV(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67FB1B0", Offset = "0x67F9FB0", VA = "0x1867FB1B0", Slot = "5")]
		private void ARTZHTEKDLT((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67FB560", Offset = "0x67FA360", VA = "0x1867FB560", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class QRHIUJEVAUO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85CF590", Offset = "0x85CE390", VA = "0x1885CF590")]
		public static string TYRMHQJRBSB(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150")]
		public static NetworkSetterPermissionMode DNWJYASFWPE(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class KDHZRFNEEGM<a> : RYOWJNIZIYZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x53A7420", Offset = "0x53A6220", VA = "0x1853A7420")]
		public KDHZRFNEEGM([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x53A8B80", Offset = "0x53A7980", VA = "0x1853A8B80")]
		public KDHZRFNEEGM(XQQWUKBJKDN a, LZEYQUPSRUQ b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] WFBPCMLGOPV g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x53A7BC0", Offset = "0x53A69C0", VA = "0x1853A7BC0")]
		public KDHZRFNEEGM(XQQWUKBJKDN a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] WFBPCMLGOPV f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x53A78B0", Offset = "0x53A66B0", VA = "0x1853A78B0")]
		public KDHZRFNEEGM(XQQWUKBJKDN a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] WFBPCMLGOPV g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class KDXUIZUWGON<a, b> : RXZBRTBHGQY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x53AB960", Offset = "0x53AA760", VA = "0x1853AB960")]
		public KDXUIZUWGON([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x53ACE70", Offset = "0x53ABC70", VA = "0x1853ACE70")]
		public KDXUIZUWGON(XQQWUKBJKDN a, LZEYQUPSRUQ b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] WFBPCMLGOPV h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x53AE8F0", Offset = "0x53AD6F0", VA = "0x1853AE8F0")]
		public KDXUIZUWGON(XQQWUKBJKDN a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] WFBPCMLGOPV g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x53AD060", Offset = "0x53ABE60", VA = "0x1853AD060")]
		public KDXUIZUWGON(XQQWUKBJKDN a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] WFBPCMLGOPV h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class KDSNLTAYXDE<a, b, c> : RYEIOZVEQCH<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x53A9420", Offset = "0x53A8220", VA = "0x1853A9420")]
		public KDSNLTAYXDE([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x53AA180", Offset = "0x53A8F80", VA = "0x1853AA180")]
		public KDSNLTAYXDE(XQQWUKBJKDN a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] WFBPCMLGOPV h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KEIIDNIQZLF<a, b, c, d> : RZERBHQRLHA<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x53B0B50", Offset = "0x53AF950", VA = "0x1853B0B50")]
		public KEIIDNIQZLF([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x53AFD80", Offset = "0x53AEB80", VA = "0x1853AFD80")]
		public KEIIDNIQZLF(XQQWUKBJKDN a, LZEYQUPSRUQ b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] WFBPCMLGOPV j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x53AFC30", Offset = "0x53AEA30", VA = "0x1853AFC30")]
		public KEIIDNIQZLF(XQQWUKBJKDN a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] WFBPCMLGOPV i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KEDBGGOTPZW<a, b, c, d, e> : RZJXYOKOUSJ<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x53AFB20", Offset = "0x53AE920", VA = "0x1853AFB20")]
		public KEDBGGOTPZW(XQQWUKBJKDN a, LZEYQUPSRUQ b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] WFBPCMLGOPV k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x53AF7F0", Offset = "0x53AE5F0", VA = "0x1853AF7F0")]
		public KEDBGGOTPZW(XQQWUKBJKDN a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] WFBPCMLGOPV j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class WNTZCISMWSP<a> : RYOWJNIZIYZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x68173D0", Offset = "0x68161D0", VA = "0x1868173D0")]
		public WNTZCISMWSP(LZEYQUPSRUQ a, string b, a c, [Optional] Action d, [Optional] WFBPCMLGOPV e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class WNZFZPMKGDY<a, b> : RXZBRTBHGQY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6817790", Offset = "0x6816590", VA = "0x186817790")]
		public WNZFZPMKGDY(LZEYQUPSRUQ a, string b, a c, b d, [Optional] Action e, [Optional] WFBPCMLGOPV f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface NTMPANNNACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KDHZRFNEEGM<a> DFXKJYJCLNH<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class XXSJGORPJBE : NTMPANNNACJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly WFBPCMLGOPV TMVTTAOFKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly XQQWUKBJKDN LKKZURHCYCC;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAA5770", Offset = "0xAA4570", VA = "0x180AA5770")]
		public XXSJGORPJBE(WFBPCMLGOPV a, XQQWUKBJKDN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3EE62F0", Offset = "0x3EE50F0", VA = "0x183EE62F0", Slot = "4")]
		public KDHZRFNEEGM<a> DFXKJYJCLNH<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface FWMXFMUJXBK : XQQWUKBJKDN
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId IJGXCDMRXYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface XQQWUKBJKDN
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool RYOBENBYJUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool NDYWGDVYHDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string MRJAWLBROKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool OZZPUQTSJTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(MKDAPDYTKQJ handler);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(MKDAPDYTKQJ handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class KEYVIBRKLRX
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85CDC60", Offset = "0x85CCA60", VA = "0x1885CDC60")]
		public static bool IQGZSJYXNTI(this XQQWUKBJKDN a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface WFBPCMLGOPV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		LZEYQUPSRUQ GABUPFWQSQP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool FGJAKZFGGCD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object TOIENSZIJNR(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object ATBWNUVEMZD(LZEYQUPSRUQ a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void YGUOQNNOOOP(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void XTPWJRZQHDH(LZEYQUPSRUQ a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void XABFWPYCQXM<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LNJHRJRNVFK([CanBeNull] LZEYQUPSRUQ photonPlayer, string a, PFISPVVPEOP b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void UYQHIEZNMYR([CanBeNull] LZEYQUPSRUQ photonPlayer, string a, PFISPVVPEOP b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b KNIWLJRENGP<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object EJJHUNIVFZM<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void IJGBJBIOMJZ();

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void AZQYRDINQXX();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void VTEGGOUPPJK(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LZEYQUPSRUQ player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public XQQWUKBJKDN context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NetworkSetterPermissionMode permissionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool enforceInitialValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Action callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public WFBPCMLGOPV networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85CF620", Offset = "0x85CE420", VA = "0x1885CF620")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85CF6A0", Offset = "0x85CE4A0", VA = "0x1885CF6A0")]
		public SyncData(XQQWUKBJKDN context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] WFBPCMLGOPV networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85CF5D0", Offset = "0x85CE3D0", VA = "0x1885CF5D0")]
		public static SyncData From(XQQWUKBJKDN context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] WFBPCMLGOPV networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class FTKFIUVYHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x38E08D0", Offset = "0x38DF6D0", VA = "0x1838E08D0")]
		public static KDHZRFNEEGM<a> PFISPVVPEOP<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x38DFEC0", Offset = "0x38DECC0", VA = "0x1838DFEC0")]
		public static KDXUIZUWGON<b, c> PFISPVVPEOP<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x38DFF60", Offset = "0x38DED60", VA = "0x1838DFF60")]
		public static KDSNLTAYXDE<d, e, f> PFISPVVPEOP<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x38E0380", Offset = "0x38DF180", VA = "0x1838E0380")]
		public static KEIIDNIQZLF<g, h, i, j> PFISPVVPEOP<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x38DEF10", Offset = "0x38DDD10", VA = "0x1838DEF10")]
		public static WJYJSIRESOD<k> NKKXMHUGWYM<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x38DEDC0", Offset = "0x38DDBC0", VA = "0x1838DEDC0")]
		public static WKDQPPLCBZM<l, m> NKKXMHUGWYM<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x38DEE60", Offset = "0x38DDC60", VA = "0x1838DEE60")]
		public static WKIXMWEZLKV<n, o, p> NKKXMHUGWYM<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x38DF8D0", Offset = "0x38DE6D0", VA = "0x1838DF8D0")]
		public static WIYBGAVRXJK<q, r, s, t> NKKXMHUGWYM<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class PFISPVVPEOP : MKDAPDYTKQJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[Flags]
		private enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			Disposed = 1,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			LastSetLocally = 2,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			Synchronizing = 4,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			ModifiedOffline = 8,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Default = 4
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static Stack<WFBPCMLGOPV> KNZIVGHNXEV;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool ZWNAHIXBBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly LZEYQUPSRUQ UBWYZRSDAFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly XQQWUKBJKDN LKKZURHCYCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string KUJVGNBDNRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode SZCPSQSWWBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action ZUETPAWZPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected WFBPCMLGOPV KHNAXJBICDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags UFKYBNOCRIC;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static WFBPCMLGOPV FPPPXLVUPET
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x85CDCD0", Offset = "0x85CCAD0", VA = "0x1885CDCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool KKDMMYEZVLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x85CDE10", Offset = "0x85CCC10", VA = "0x1885CDE10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x85CF2B0", Offset = "0x85CE0B0", VA = "0x1885CF2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool RENLQSSYMIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x85CDE00", Offset = "0x85CCC00", VA = "0x1885CDE00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x85CF080", Offset = "0x85CDE80", VA = "0x1885CF080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool ORMWXDGMUCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x85CDCB0", Offset = "0x85CCAB0", VA = "0x1885CDCB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x85CF1E0", Offset = "0x85CDFE0", VA = "0x1885CF1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool ZKLCKPNHVFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x85CDD40", Offset = "0x85CCB40", VA = "0x1885CDD40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x85CEFC0", Offset = "0x85CDDC0", VA = "0x1885CEFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object ZENXFYCEGAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC10", Offset = "0xA9DA10", VA = "0x180A9EC10", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool RTXVOZSIQRD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x85CF260", Offset = "0x85CE060", VA = "0x1885CF260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int LBAFDLJUSXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xF2E2E0", Offset = "0xF2D0E0", VA = "0x180F2E2E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1AD65E0", Offset = "0x1AD53E0", VA = "0x181AD65E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string UWPCMRAPJZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x85CEE10", Offset = "0x85CDC10", VA = "0x1885CEE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85CDF90", Offset = "0x85CCD90", VA = "0x1885CDF90")]
		public static void EFRQAVKOLQC(WFBPCMLGOPV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool QGBTRMNCGDO();

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85CF370", Offset = "0x85CE170", VA = "0x1885CF370")]
		protected PFISPVVPEOP(LZEYQUPSRUQ a, XQQWUKBJKDN b, string c, NetworkSetterPermissionMode d, Action e, WFBPCMLGOPV f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85CE1E0", Offset = "0x85CCFE0", VA = "0x1885CE1E0", Slot = "1")]
		~PFISPVVPEOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85CDE20", Offset = "0x85CCC20", VA = "0x1885CDE20", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85CEAD0", Offset = "0x85CD8D0", VA = "0x1885CEAD0")]
		private void RDVMJZCVQYC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85CE8C0", Offset = "0x85CD6C0", VA = "0x1885CE8C0")]
		private object OVVSZVBYNUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x85CE650", Offset = "0x85CD450", VA = "0x1885CE650")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x85CEDD0", Offset = "0x85CDBD0", VA = "0x1885CEDD0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x85CE400", Offset = "0x85CD200", VA = "0x1885CE400")]
		protected void HNGPDNQTFQL(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85CE840", Offset = "0x85CD640", VA = "0x1885CE840")]
		internal void OEDGKWNQJWT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85CF180", Offset = "0x85CDF80", VA = "0x1885CF180")]
		private void XGYYQWHHEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85CF200", Offset = "0x85CE000", VA = "0x1885CF200")]
		private void YCCWEBVATKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x85CE170", Offset = "0x85CCF70", VA = "0x1885CE170", Slot = "4")]
		private void FIAONFJGNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85CEA30", Offset = "0x85CD830", VA = "0x1885CEA30", Slot = "5")]
		private void PLACWVNWLQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x85CE030", Offset = "0x85CCE30", VA = "0x1885CE030")]
		public bool EOKAOWLHUNH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85CE240", Offset = "0x85CD040", VA = "0x1885CE240")]
		public bool GRWFYUXLVAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x85CEC80", Offset = "0x85CDA80", VA = "0x1885CEC80")]
		private bool SPXBMDLNKKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85CDD50", Offset = "0x85CCB50", VA = "0x1885CDD50")]
		internal void DKQFBPHMHMX(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85CEB70", Offset = "0x85CD970", VA = "0x1885CEB70")]
		private void SFBDZKZALOB(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x85CDCC0", Offset = "0x85CCAC0", VA = "0x1885CDCC0")]
		private bool BCNKNZSWZHJ(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85CE820", Offset = "0x85CD620", VA = "0x1885CE820")]
		private void MYJTHHRLUUH(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85CEA40", Offset = "0x85CD840", VA = "0x1885CEA40")]
		public static string QYRJZMZFESN(LZEYQUPSRUQ a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85CF0A0", Offset = "0x85CDEA0", VA = "0x1885CF0A0")]
		public static string WPMXELKOSKR(XQQWUKBJKDN a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85CEE60", Offset = "0x85CDC60", VA = "0x1885CEE60")]
		public static bool UCFYKNMRTYL(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class GLXVWGAMDQF : WFBPCMLGOPV, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> LMMTWTTCWYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> RRNLOMUIPZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> HALGTFOFGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> DGODGZOAESI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool KTWIZWBHUSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> NCTGWNAYKPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<LZEYQUPSRUQ, Dictionary<string, object>> VWGLKPGWDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> ZEEDWHGUNPH;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> ZZJQMNMMRNX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int DGQVLYITJYW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract LZEYQUPSRUQ GABUPFWQSQP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool FGJAKZFGGCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool FJBOQXVDGOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool ONCGHIYWMTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xB009E0", Offset = "0xAFF7E0", VA = "0x180B009E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x38F4860", Offset = "0x38F3660", VA = "0x1838F4860", Slot = "12")]
		public void XABFWPYCQXM<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x85CD800", Offset = "0x85CC600", VA = "0x1885CD800", Slot = "11")]
		public void XTPWJRZQHDH(LZEYQUPSRUQ a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x85CB9B0", Offset = "0x85CA7B0", VA = "0x1885CB9B0", Slot = "9")]
		public object ATBWNUVEMZD(LZEYQUPSRUQ a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x85CD950", Offset = "0x85CC750", VA = "0x1885CD950", Slot = "10")]
		public void YGUOQNNOOOP(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x85CD160", Offset = "0x85CBF60", VA = "0x1885CD160", Slot = "8")]
		public object TOIENSZIJNR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x85CC970", Offset = "0x85CB770", VA = "0x1885CC970", Slot = "13")]
		public void LNJHRJRNVFK(LZEYQUPSRUQ a, string b, PFISPVVPEOP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x85CD2D0", Offset = "0x85CC0D0", VA = "0x1885CD2D0", Slot = "14")]
		public void UYQHIEZNMYR(LZEYQUPSRUQ a, string b, PFISPVVPEOP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85CBBE0", Offset = "0x85CA9E0", VA = "0x1885CBBE0")]
		private void CCJLDPUUUWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x85CBB90", Offset = "0x85CA990", VA = "0x1885CBB90")]
		private void BRCOQJSAYJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85CC480", Offset = "0x85CB280", VA = "0x1885CC480")]
		private void KMQYQMIXDBE(LZEYQUPSRUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x85CC140", Offset = "0x85CAF40", VA = "0x1885CC140")]
		protected void JEYDUQZADZK(LZEYQUPSRUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x85CCD10", Offset = "0x85CBB10", VA = "0x1885CCD10")]
		protected void NXLXIURYOSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85CCD00", Offset = "0x85CBB00", VA = "0x1885CCD00")]
		protected void NKJALENERWU(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x85CCE90", Offset = "0x85CBC90", VA = "0x1885CCE90")]
		protected void REMCUBUBXRO(LZEYQUPSRUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85CBFB0", Offset = "0x85CADB0", VA = "0x1885CBFB0")]
		protected void HRJTXSKXEIC(LZEYQUPSRUQ a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85CC4E0", Offset = "0x85CB2E0", VA = "0x1885CC4E0")]
		private void LHUTCQCJHCZ(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85CB450", Offset = "0x85CA250", VA = "0x1885CB450")]
		private static void AEOQIXBMGYF(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85CC260", Offset = "0x85CB060", VA = "0x1885CC260")]
		private static void JHNRJVFCOWM(Dictionary<string, object> a, string b, PFISPVVPEOP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85CCF00", Offset = "0x85CBD00", VA = "0x1885CCF00")]
		private static void SJFXOLBQHJB(Dictionary<string, object> a, string b, PFISPVVPEOP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x85CC040", Offset = "0x85CAE40", VA = "0x1885CC040", Slot = "17")]
		public void IJGBJBIOMJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void GZWWQVISZDQ(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85CBAB0", Offset = "0x85CA8B0", VA = "0x1885CBAB0", Slot = "18")]
		public void AZQYRDINQXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void NZPRJIGHHUU(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x85CBD90", Offset = "0x85CAB90", VA = "0x1885CBD90")]
		private void EFBVNXVOBAL(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x85CCA80", Offset = "0x85CB880", VA = "0x1885CCA80")]
		private void NJXVQLEKKRQ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x85CD0D0", Offset = "0x85CBED0", VA = "0x1885CD0D0")]
		public void TJOPXZADDHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85CD200", Offset = "0x85CC000", VA = "0x1885CD200")]
		public void TYKCMYLUUHL(LZEYQUPSRUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85CB650", Offset = "0x85CA450", VA = "0x1885CB650")]
		public void AKQZZKRZKIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> ZRNFBVLKNHU(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x85CD580", Offset = "0x85CC380", VA = "0x1885CD580", Slot = "19")]
		public void VTEGGOUPPJK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85CCE00", Offset = "0x85CBC00", VA = "0x1885CCE00")]
		protected string QYRJZMZFESN(LZEYQUPSRUQ a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object EJJHUNIVFZM<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c KNIWLJRENGP<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x85CBC30", Offset = "0x85CAA30", VA = "0x1885CBC30", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "33")]
		protected virtual void MLPDGFMOTDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x85CDA70", Offset = "0x85CC870", VA = "0x1885CDA70")]
		protected GLXVWGAMDQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class RYOWJNIZIYZ<a> : PFISPVVPEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a QEZNWWPCDXG;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a TEZKGBPBEDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1080A60", Offset = "0x107F860", VA = "0x181080A60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1080A50", Offset = "0x107F850", VA = "0x181080A50", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object ZENXFYCEGAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5D67FA0", Offset = "0x5D66DA0", VA = "0x185D67FA0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5D7DF50", Offset = "0x5D7CD50", VA = "0x185D7DF50", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F5C0", Offset = "0x5D7E3C0", VA = "0x185D7F5C0", Slot = "9")]
		protected override bool QGBTRMNCGDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D86BA0", Offset = "0x5D859A0", VA = "0x185D86BA0")]
		protected RYOWJNIZIYZ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5D84B10", Offset = "0x5D83910", VA = "0x185D84B10")]
		protected RYOWJNIZIYZ(LZEYQUPSRUQ a, XQQWUKBJKDN b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, WFBPCMLGOPV h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5D7EEC0", Offset = "0x5D7DCC0", VA = "0x185D7EEC0")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5D83CE0", Offset = "0x5D82AE0", VA = "0x185D83CE0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5D82C00", Offset = "0x5D81A00", VA = "0x185D82C00")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class RXZBRTBHGQY<a, b> : PFISPVVPEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a QEZNWWPCDXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b QFPIOQWUGFH;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a TEZKGBPBEDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1129960", Offset = "0x1128760", VA = "0x181129960", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1317970", Offset = "0x1316770", VA = "0x181317970", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b TFERDIIYNOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x320FB80", Offset = "0x320E980", VA = "0x18320FB80", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5D69D30", Offset = "0x5D68B30", VA = "0x185D69D30", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b KNSUNVLWICW
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1761210", Offset = "0x1760010", VA = "0x181761210")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object ZENXFYCEGAS
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x5D67FA0", Offset = "0x5D66DA0", VA = "0x185D67FA0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5D66480", Offset = "0x5D65280", VA = "0x185D66480", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D69480", Offset = "0x5D68280", VA = "0x185D69480", Slot = "9")]
		protected override bool QGBTRMNCGDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5D6F810", Offset = "0x5D6E610", VA = "0x185D6F810")]
		protected RXZBRTBHGQY([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5D711A0", Offset = "0x5D6FFA0", VA = "0x185D711A0")]
		protected RXZBRTBHGQY(LZEYQUPSRUQ a, XQQWUKBJKDN b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, WFBPCMLGOPV i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D67E70", Offset = "0x5D66C70", VA = "0x185D67E70")]
		public a JQZLKYCNRXG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E170", Offset = "0x5D6CF70", VA = "0x185D6E170")]
		public void UNKNIMXDLNG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1761210", Offset = "0x1760010", VA = "0x181761210")]
		public b JRPGCSKFUFH()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5D6EC70", Offset = "0x5D6DA70", VA = "0x185D6EC70")]
		public void UOAIAHEVNVH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5D6CC80", Offset = "0x5D6BA80", VA = "0x185D6CC80")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class RYEIOZVEQCH<a, b, c> : PFISPVVPEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a QEZNWWPCDXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b QFPIOQWUGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c QFKBRKCWWTY;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a TEZKGBPBEDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAAFDA0", Offset = "0xAAEBA0", VA = "0x180AAFDA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAAFD60", Offset = "0xAAEB60", VA = "0x180AAFD60", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b TFERDIIYNOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xF29BF0", Offset = "0xF289F0", VA = "0x180F29BF0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AAC0", Offset = "0x2A498C0", VA = "0x182A4AAC0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c TFJYAPCVWZT
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA0F10", VA = "0x180AA2110", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAA28D0", Offset = "0xAA16D0", VA = "0x180AA28D0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a KNNNQORYYRN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x5D67E70", Offset = "0x5D66C70", VA = "0x185D67E70")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b KNSUNVLWICW
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x1761210", Offset = "0x1760010", VA = "0x181761210")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c KNYBLCFTROF
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5CC7C70", Offset = "0x5CC6A70", VA = "0x185CC7C70")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object ZENXFYCEGAS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5D67FA0", Offset = "0x5D66DA0", VA = "0x185D67FA0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5D738D0", Offset = "0x5D726D0", VA = "0x185D738D0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5D74FD0", Offset = "0x5D73DD0", VA = "0x185D74FD0", Slot = "9")]
		protected override bool QGBTRMNCGDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5D7CD10", Offset = "0x5D7BB10", VA = "0x185D7CD10")]
		protected RYEIOZVEQCH([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B240", Offset = "0x5D7A040", VA = "0x185D7B240")]
		protected RYEIOZVEQCH(LZEYQUPSRUQ a, XQQWUKBJKDN b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, WFBPCMLGOPV j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D67E70", Offset = "0x5D66C70", VA = "0x185D67E70")]
		public a JQZLKYCNRXG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5D78F00", Offset = "0x5D77D00", VA = "0x185D78F00")]
		public void UNKNIMXDLNG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1761210", Offset = "0x1760010", VA = "0x181761210")]
		public b JRPGCSKFUFH()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A150", Offset = "0x5D78F50", VA = "0x185D7A150")]
		public void UOAIAHEVNVH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7C70", Offset = "0x5CC6A70", VA = "0x185CC7C70")]
		public c JRJZFLQIKTY()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78150", VA = "0x185D79350")]
		public void UNVBDAKYEJY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5D76B80", Offset = "0x5D75980", VA = "0x185D76B80")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class RZERBHQRLHA<a, b, c, d> : PFISPVVPEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a QEZNWWPCDXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b QFPIOQWUGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c QFKBRKCWWTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d QFZWJEKOZBZ;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a TEZKGBPBEDB
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xFD4900", Offset = "0xFD3700", VA = "0x180FD4900", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5DC7AC0", Offset = "0x5DC68C0", VA = "0x185DC7AC0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b TFERDIIYNOK
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2122C70", Offset = "0x2121A70", VA = "0x182122C70", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x211E120", Offset = "0x211CF20", VA = "0x18211E120", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c TFJYAPCVWZT
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x5DCEB50", Offset = "0x5DCD950", VA = "0x185DCEB50", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x5DC9320", Offset = "0x5DC8120", VA = "0x185DC9320", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d TDZBTTTOIYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1D4B0E0", Offset = "0x1D49EE0", VA = "0x181D4B0E0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x16B3390", Offset = "0x16B2190", VA = "0x1816B3390", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b KNSUNVLWICW
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x5D67E90", Offset = "0x5D66C90", VA = "0x185D67E90")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c KNYBLCFTROF
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x5D73F30", Offset = "0x5D72D30", VA = "0x185D73F30")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d KMNFEGWMDMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x2155520", Offset = "0x2154320", VA = "0x182155520")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object ZENXFYCEGAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x5D67FA0", Offset = "0x5D66DA0", VA = "0x185D67FA0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5DC6440", Offset = "0x5DC5240", VA = "0x185DC6440", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8FF0", Offset = "0x5DC7DF0", VA = "0x185DC8FF0", Slot = "9")]
		protected override bool QGBTRMNCGDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF450", Offset = "0x5DCE250", VA = "0x185DCF450")]
		protected RZERBHQRLHA([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF8A0", Offset = "0x5DCE6A0", VA = "0x185DCF8A0")]
		protected RZERBHQRLHA(LZEYQUPSRUQ a, XQQWUKBJKDN b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, WFBPCMLGOPV k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5D67E70", Offset = "0x5D66C70", VA = "0x185D67E70")]
		public a JQZLKYCNRXG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD1D0", Offset = "0x5DCBFD0", VA = "0x185DCD1D0")]
		public void UNKNIMXDLNG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5D67E90", Offset = "0x5D66C90", VA = "0x185D67E90")]
		public b JRPGCSKFUFH()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE740", Offset = "0x5DCD540", VA = "0x185DCE740")]
		public void UOAIAHEVNVH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5D73F30", Offset = "0x5D72D30", VA = "0x185D73F30")]
		public c JRJZFLQIKTY()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDD80", Offset = "0x5DCCB80", VA = "0x185DCDD80")]
		public void UNVBDAKYEJY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2155520", Offset = "0x2154320", VA = "0x182155520")]
		public d JRZTXFYANBZ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5DCCB20", Offset = "0x5DCB920", VA = "0x185DCCB20")]
		public void UMUSQSPLJFF(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9540", Offset = "0x5DC8340", VA = "0x185DC9540")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class RZJXYOKOUSJ<a, b, c, d, e> : PFISPVVPEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a QEZNWWPCDXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b QFPIOQWUGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c QFKBRKCWWTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d QFZWJEKOZBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e QFUPLXQRPQQ;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a TEZKGBPBEDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAAFDA0", Offset = "0xAAEBA0", VA = "0x180AAFDA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAAFD60", Offset = "0xAAEB60", VA = "0x180AAFD60", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b TFERDIIYNOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xE536D0", Offset = "0xE524D0", VA = "0x180E536D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x14F9D10", Offset = "0x14F8B10", VA = "0x1814F9D10", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c TFJYAPCVWZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xE71E30", Offset = "0xE70C30", VA = "0x180E71E30", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xE71A40", Offset = "0xE70840", VA = "0x180E71A40", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d TDZBTTTOIYI
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8D50", Offset = "0xAB7B50", VA = "0x180AB8D50", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAC8350", Offset = "0xAC7150", VA = "0x180AC8350", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e TEEIRANLSJR
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAB89A0", Offset = "0xAB77A0", VA = "0x180AB89A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x5DC9530", Offset = "0x5DC8330", VA = "0x185DC9530", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object ZENXFYCEGAS
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x5D67FA0", Offset = "0x5D66DA0", VA = "0x185D67FA0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x5DD1CA0", Offset = "0x5DD0AA0", VA = "0x185DD1CA0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3360", Offset = "0x5DD2160", VA = "0x185DD3360", Slot = "9")]
		protected override bool QGBTRMNCGDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA340", Offset = "0x5DD9140", VA = "0x185DDA340")]
		protected RZJXYOKOUSJ(LZEYQUPSRUQ a, XQQWUKBJKDN b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, WFBPCMLGOPV l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5D67E70", Offset = "0x5D66C70", VA = "0x185D67E70")]
		public a JQZLKYCNRXG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7310", Offset = "0x5DD6110", VA = "0x185DD7310")]
		public void UNKNIMXDLNG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1761210", Offset = "0x1760010", VA = "0x181761210")]
		public b JRPGCSKFUFH()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5DD8520", Offset = "0x5DD7320", VA = "0x185DD8520")]
		public void UOAIAHEVNVH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5CC7C70", Offset = "0x5CC6A70", VA = "0x185CC7C70")]
		public c JRJZFLQIKTY()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7A50", Offset = "0x5DD6850", VA = "0x185DD7A50")]
		public void UNVBDAKYEJY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2155520", Offset = "0x2154320", VA = "0x182155520")]
		public d JRZTXFYANBZ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7150", Offset = "0x5DD5F50", VA = "0x185DD7150")]
		public void UMUSQSPLJFF(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2700", Offset = "0x5DD1500", VA = "0x185DD2700")]
		public e JRUMZZEDDQQ()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6470", Offset = "0x5DD5270", VA = "0x185DD6470")]
		public void UMPLTLVNZTW(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4A50", Offset = "0x5DD3850", VA = "0x185DD4A50")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, e newValue5)
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
