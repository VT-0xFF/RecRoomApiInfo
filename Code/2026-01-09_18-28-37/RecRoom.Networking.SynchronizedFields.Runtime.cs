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
	public interface FHPBDQMNWKJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool JAPCUMXLMGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool GTKVSLPXHSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		JDMCEZTJJPL FOWTVDRXUUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int BTJEUGOBNEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool HVNVKZLPIUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool LDAFXFPSMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action FPKUDVBFTXW;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void PGWEQRYYCIB();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void TRSMYANGOYB(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KXIFZLSLXSP();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface LXWIKXVPPPE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string YIPZDRXKCOF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool WBGQDDVEGQL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface NJVOSILGJSJ<a> : LXWIKXVPPPE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a QNSMUNLODCT
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QOBOMJWVFRM(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class PJUEKOATGDQ<a> : NJVOSILGJSJ<a>, LXWIKXVPPPE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly WQHXCYICOSP<a> NIETDAVOFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly WQHXCYICOSP<a> IERPRIHAMSW;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string YIPZDRXKCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCCF6A0", Offset = "0xCCEAA0", VA = "0x180CCF6A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JOCNDDDUXOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5A5C2A0", Offset = "0x5A5B6A0", VA = "0x185A5C2A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a RZTIKFTFPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5A5C950", Offset = "0x5A5BD50", VA = "0x185A5C950", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5A5A2A0", Offset = "0x5A596A0", VA = "0x185A5A2A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a QNSMUNLODCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5A5C110", Offset = "0x5A5B510", VA = "0x185A5C110", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5A5AE60", Offset = "0x5A5A260", VA = "0x185A5AE60", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a MHEWXLBFLTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5A5C110", Offset = "0x5A5B510", VA = "0x185A5C110")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5A5CE30", Offset = "0x5A5C230", VA = "0x185A5CE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool WBGQDDVEGQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5A48070", Offset = "0x5A47470", VA = "0x185A48070", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5A4DC90", Offset = "0x5A4D090", VA = "0x185A4DC90", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NNHLGBZZREX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5A5CB10", Offset = "0x5A5BF10", VA = "0x185A5CB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5A5BDB0", Offset = "0x5A5B1B0", VA = "0x185A5BDB0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5A5DF80", Offset = "0x5A5D380", VA = "0x185A5DF80")]
		public PJUEKOATGDQ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5A59D80", Offset = "0x5A59180", VA = "0x185A59D80")]
		private void HASFEXRNIYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5A5B870", Offset = "0x5A5AC70", VA = "0x185A5B870", Slot = "5")]
		public void QOBOMJWVFRM(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5A5B470", Offset = "0x5A5A870", VA = "0x185A5B470")]
		public void QOBOMJWVFRM(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5A47670", Offset = "0x5A46A70", VA = "0x185A47670", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class PJOXNHGVWSH<a, b> : NJVOSILGJSJ<(a, b)>, LXWIKXVPPPE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly WQNEAFBZYDY<a, b> NIETDAVOFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly WQNEAFBZYDY<a, b> IERPRIHAMSW;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string YIPZDRXKCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCCF6A0", Offset = "0xCCEAA0", VA = "0x180CCF6A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JOCNDDDUXOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5A4E2E0", Offset = "0x5A4D6E0", VA = "0x185A4E2E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool SADLSHJKIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5A4E840", Offset = "0x5A4DC40", VA = "0x185A4E840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool SATGKBRCKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5A4EA70", Offset = "0x5A4DE70", VA = "0x185A4EA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) RZTIKFTFPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5A4E790", Offset = "0x5A4DB90", VA = "0x185A4E790", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5A4D270", Offset = "0x5A4C670", VA = "0x185A4D270", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) QNSMUNLODCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5A4EF70", Offset = "0x5A4E370", VA = "0x185A4EF70", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5A4DAB0", Offset = "0x5A4CEB0", VA = "0x185A4DAB0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) MHEWXLBFLTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5A4E120", Offset = "0x5A4D520", VA = "0x185A4E120")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5A4F270", Offset = "0x5A4E670", VA = "0x185A4F270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a VQEGMJYKKFN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5A4D480", Offset = "0x5A4C880", VA = "0x185A4D480")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5A4D9F0", Offset = "0x5A4CDF0", VA = "0x185A4D9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a UXSQDHDENBI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5A4C830", Offset = "0x5A4BC30", VA = "0x185A4C830")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5A4F1E0", Offset = "0x5A4E5E0", VA = "0x185A4F1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a KMHIBUBUNTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5A4C830", Offset = "0x5A4BC30", VA = "0x185A4C830")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5A4C310", Offset = "0x5A4B710", VA = "0x185A4C310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b VQJNJQSHTQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5A4D410", Offset = "0x5A4C810", VA = "0x185A4D410")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5A4D6A0", Offset = "0x5A4CAA0", VA = "0x185A4D6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b UXNJGAJHDPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5A4C7F0", Offset = "0x5A4BBF0", VA = "0x185A4C7F0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b KMCBENHXEID
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5A4C7F0", Offset = "0x5A4BBF0", VA = "0x185A4C7F0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5A4C730", Offset = "0x5A4BB30", VA = "0x185A4C730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool WBGQDDVEGQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5A48070", Offset = "0x5A47470", VA = "0x185A48070", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5A4DC90", Offset = "0x5A4D090", VA = "0x185A4DC90", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5A4DDA0", Offset = "0x5A4D1A0", VA = "0x185A4DDA0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5A4F2D0", Offset = "0x5A4E6D0", VA = "0x185A4F2D0")]
		public PJOXNHGVWSH([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5A4C860", Offset = "0x5A4BC60", VA = "0x185A4C860")]
		private void HASFEXRNIYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5A4CB00", Offset = "0x5A4BF00", VA = "0x185A4CB00")]
		public void MCCALAQAAGD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5A4DBC0", Offset = "0x5A4CFC0", VA = "0x185A4DBC0")]
		public void QOBOMJWVFRM(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5A4EE20", Offset = "0x5A4E220", VA = "0x185A4EE20", Slot = "5")]
		private void XIQQYMPBKZH((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5A47670", Offset = "0x5A46A70", VA = "0x185A47670", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class PJJQQAMYNGY<a, b, c> : NJVOSILGJSJ<(a, b, c)>, LXWIKXVPPPE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly WQSKXLVXHPH<a, b, c> NIETDAVOFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly WQSKXLVXHPH<a, b, c> IERPRIHAMSW;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string YIPZDRXKCOF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xCCF6A0", Offset = "0xCCEAA0", VA = "0x180CCF6A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool JOCNDDDUXOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5A4A430", Offset = "0x5A49830", VA = "0x185A4A430", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool SADLSHJKIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5A4ABF0", Offset = "0x5A49FF0", VA = "0x185A4ABF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool SATGKBRCKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5A4AEB0", Offset = "0x5A4A2B0", VA = "0x185A4AEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool SANZMUXFBDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5A4B290", Offset = "0x5A4A690", VA = "0x185A4B290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) RZTIKFTFPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5A4A710", Offset = "0x5A49B10", VA = "0x185A4A710", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5A48630", Offset = "0x5A47A30", VA = "0x185A48630", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) QNSMUNLODCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5A4B760", Offset = "0x5A4AB60", VA = "0x185A4B760", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5A49AB0", Offset = "0x5A48EB0", VA = "0x185A49AB0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a VQEGMJYKKFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5A48F80", Offset = "0x5A48380", VA = "0x185A48F80")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5A49510", Offset = "0x5A48910", VA = "0x185A49510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a UXSQDHDENBI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5A47870", Offset = "0x5A46C70", VA = "0x185A47870")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a KMHIBUBUNTM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5A47870", Offset = "0x5A46C70", VA = "0x185A47870")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5A46E90", Offset = "0x5A46290", VA = "0x185A46E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b VQJNJQSHTQW
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5A48EA0", Offset = "0x5A482A0", VA = "0x185A48EA0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5A49490", Offset = "0x5A48890", VA = "0x185A49490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b UXNJGAJHDPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5A476B0", Offset = "0x5A46AB0", VA = "0x185A476B0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b KMCBENHXEID
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5A476B0", Offset = "0x5A46AB0", VA = "0x185A476B0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5A46FB0", Offset = "0x5A463B0", VA = "0x185A46FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c VQOUGXMFDCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5A48DC0", Offset = "0x5A481C0", VA = "0x185A48DC0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5A48FB0", Offset = "0x5A483B0", VA = "0x185A48FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c UXICITPJUEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5A47840", Offset = "0x5A46C40", VA = "0x185A47840")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c KLWUHGNZUWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5A47840", Offset = "0x5A46C40", VA = "0x185A47840")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5A47200", Offset = "0x5A46600", VA = "0x185A47200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool WBGQDDVEGQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5A48070", Offset = "0x5A47470", VA = "0x185A48070", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5A49F40", Offset = "0x5A49340", VA = "0x185A49F40", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5A4B840", Offset = "0x5A4AC40", VA = "0x185A4B840")]
		public PJJQQAMYNGY([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5A47A30", Offset = "0x5A46E30", VA = "0x185A47A30")]
		private void HASFEXRNIYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5A48360", Offset = "0x5A47760", VA = "0x185A48360")]
		public void MCCALAQAAGD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5A47DB0", Offset = "0x5A471B0", VA = "0x185A47DB0")]
		public void HIBIKWZTNJG(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5A47510", Offset = "0x5A46910", VA = "0x185A47510")]
		public void DTQCFQBJDON(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5A49DA0", Offset = "0x5A491A0", VA = "0x185A49DA0")]
		public void QOBOMJWVFRM(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5A49FE0", Offset = "0x5A493E0", VA = "0x185A49FE0", Slot = "5")]
		private void TAFMUYXFKSW((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5A47670", Offset = "0x5A46A70", VA = "0x185A47670", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class PKUMWVWGBIJ<a, b, c, d> : NJVOSILGJSJ<(a, b, c, d)>, LXWIKXVPPPE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly WQXRUSPURAQ<a, b, c, d> NIETDAVOFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly WQXRUSPURAQ<a, b, c, d> IERPRIHAMSW;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string YIPZDRXKCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCCF6A0", Offset = "0xCCEAA0", VA = "0x180CCF6A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) QNSMUNLODCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5A60CF0", Offset = "0x5A600F0", VA = "0x185A60CF0", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5A60260", Offset = "0x5A5F660", VA = "0x185A60260", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b UXNJGAJHDPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5A5F8D0", Offset = "0x5A5ECD0", VA = "0x185A5F8D0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c UXICITPJUEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5A5FA60", Offset = "0x5A5EE60", VA = "0x185A5FA60")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d UYSYPOYRIGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5A5FB40", Offset = "0x5A5EF40", VA = "0x185A5FB40")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool WBGQDDVEGQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5A48070", Offset = "0x5A47470", VA = "0x185A48070", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5A4DC90", Offset = "0x5A4D090", VA = "0x185A4DC90", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5A611C0", Offset = "0x5A605C0", VA = "0x185A611C0")]
		public PKUMWVWGBIJ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5A5FB70", Offset = "0x5A5EF70", VA = "0x185A5FB70")]
		private void HASFEXRNIYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5A5FED0", Offset = "0x5A5F2D0", VA = "0x185A5FED0")]
		public void MCCALAQAAGD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5A60900", Offset = "0x5A5FD00", VA = "0x185A60900")]
		public void QOBOMJWVFRM(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5A60950", Offset = "0x5A5FD50", VA = "0x185A60950", Slot = "5")]
		private void UDAZHNCXJAI((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5A47670", Offset = "0x5A46A70", VA = "0x185A47670", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ZAQVMSFBHZF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x834DAF0", Offset = "0x834CEF0", VA = "0x18834DAF0")]
		public static string IDAWASXMGRY(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910")]
		public static NetworkSetterPermissionMode FQQZQXEAMUP(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class WQHXCYICOSP<a> : VCNISEPJLAO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x65C69B0", Offset = "0x65C5DB0", VA = "0x1865C69B0")]
		public WQHXCYICOSP([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x65C8A60", Offset = "0x65C7E60", VA = "0x1865C8A60")]
		public WQHXCYICOSP(JLPEVSHEISE a, JDMCEZTJJPL b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] DXJQDMRERKK g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x65C8270", Offset = "0x65C7670", VA = "0x1865C8270")]
		public WQHXCYICOSP(JLPEVSHEISE a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] DXJQDMRERKK f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x65C7E60", Offset = "0x65C7260", VA = "0x1865C7E60")]
		public WQHXCYICOSP(JLPEVSHEISE a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] DXJQDMRERKK g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class WQNEAFBZYDY<a, b> : VCIBUXVMBPF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x65CA5C0", Offset = "0x65C99C0", VA = "0x1865CA5C0")]
		public WQNEAFBZYDY([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x65CC8A0", Offset = "0x65CBCA0", VA = "0x1865CC8A0")]
		public WQNEAFBZYDY(JLPEVSHEISE a, JDMCEZTJJPL b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] DXJQDMRERKK h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x65CCF30", Offset = "0x65CC330", VA = "0x1865CCF30")]
		public WQNEAFBZYDY(JLPEVSHEISE a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] DXJQDMRERKK g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65CC5D0", Offset = "0x65CB9D0", VA = "0x1865CC5D0")]
		public WQNEAFBZYDY(JLPEVSHEISE a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] DXJQDMRERKK h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class WQSKXLVXHPH<a, b, c> : VCCUXRBOSDW<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x65CE0F0", Offset = "0x65CD4F0", VA = "0x1865CE0F0")]
		public WQSKXLVXHPH([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x65CE310", Offset = "0x65CD710", VA = "0x1865CE310")]
		public WQSKXLVXHPH(JLPEVSHEISE a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] DXJQDMRERKK h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class WQXRUSPURAQ<a, b, c, d> : VBXOAKHRISN<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x65DAC30", Offset = "0x65DA030", VA = "0x1865DAC30")]
		public WQXRUSPURAQ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x65D93B0", Offset = "0x65D87B0", VA = "0x1865D93B0")]
		public WQXRUSPURAQ(JLPEVSHEISE a, JDMCEZTJJPL b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] DXJQDMRERKK j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x65DA290", Offset = "0x65D9690", VA = "0x1865DA290")]
		public WQXRUSPURAQ(JLPEVSHEISE a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] DXJQDMRERKK i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class WRCYRZJSALZ<a, b, c, d, e> : VBSHDDNTZHE<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65DCB20", Offset = "0x65DBF20", VA = "0x1865DCB20")]
		public WRCYRZJSALZ(JLPEVSHEISE a, JDMCEZTJJPL b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] DXJQDMRERKK k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x65DC900", Offset = "0x65DBD00", VA = "0x1865DC900")]
		public WRCYRZJSALZ(JLPEVSHEISE a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] DXJQDMRERKK j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class RVVFXWQDTUM<a> : VCNISEPJLAO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5B84DA0", Offset = "0x5B841A0", VA = "0x185B84DA0")]
		public RVVFXWQDTUM(JDMCEZTJJPL a, string b, a c, [Optional] Action d, [Optional] DXJQDMRERKK e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class RWLAPQXVWCN<a, b> : VCIBUXVMBPF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5B84FF0", Offset = "0x5B843F0", VA = "0x185B84FF0")]
		public RWLAPQXVWCN(JDMCEZTJJPL a, string b, a c, b d, [Optional] Action e, [Optional] DXJQDMRERKK f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface PEMDCAKYBWE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WQHXCYICOSP<a> ALRLSQNFGNG<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AKDLUFBSDNX : PEMDCAKYBWE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly DXJQDMRERKK RRFMEBWSXAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly JLPEVSHEISE OELTKTIMQDP;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAAC040", Offset = "0xAAB440", VA = "0x180AAC040")]
		public AKDLUFBSDNX(DXJQDMRERKK a, JLPEVSHEISE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x306DA20", Offset = "0x306CE20", VA = "0x18306DA20", Slot = "4")]
		public WQHXCYICOSP<a> ALRLSQNFGNG<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface SVYXSZWBKMJ : JLPEVSHEISE
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId HOFSDIQRZVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface JLPEVSHEISE
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool ZUQIJTAIUFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool ZFSCXWLJPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string JKULKZCOHSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool FYTXCSZHHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(GLODVPKBZKC handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(GLODVPKBZKC handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class EKYXQFVDWKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8349790", Offset = "0x8348B90", VA = "0x188349790")]
		public static bool HDAXFITSPCR(this JLPEVSHEISE a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface DXJQDMRERKK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		JDMCEZTJJPL ATXPJDRAYLG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool NNHLGBZZREX
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool TNUEXNIXSIS
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object QXKQIDAMVPA(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object CMLOYMODTKU(JDMCEZTJJPL a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HKIAUBSLNOG(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void WBWJCPDSTJC(JDMCEZTJJPL a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OIZIGCEBTMR<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WUYAVRKZQNV([CanBeNull] JDMCEZTJJPL photonPlayer, string a, TOFCCKEDOJO b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void SZEDQPOYJLU([CanBeNull] JDMCEZTJJPL photonPlayer, string a, TOFCCKEDOJO b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b NJAMWJTCSHY<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object UIOMBCAALZF<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void DIQOFRALEWW();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void AAJAZQAUHQE();

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void UBPRQFWRGFV(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public JDMCEZTJJPL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JLPEVSHEISE context;

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
		public DXJQDMRERKK networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8349830", Offset = "0x8348C30", VA = "0x188349830")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83498B0", Offset = "0x8348CB0", VA = "0x1883498B0")]
		public SyncData(JLPEVSHEISE context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] DXJQDMRERKK networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83497E0", Offset = "0x8348BE0", VA = "0x1883497E0")]
		public static SyncData From(JLPEVSHEISE context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] DXJQDMRERKK networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class HAKUAMKUKNV
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x36CEC10", Offset = "0x36CE010", VA = "0x1836CEC10")]
		public static WQHXCYICOSP<a> TOFCCKEDOJO<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x36CE200", Offset = "0x36CD600", VA = "0x1836CE200")]
		public static WQNEAFBZYDY<b, c> TOFCCKEDOJO<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x36CE2A0", Offset = "0x36CD6A0", VA = "0x1836CE2A0")]
		public static WQSKXLVXHPH<d, e, f> TOFCCKEDOJO<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x36CE6C0", Offset = "0x36CDAC0", VA = "0x1836CE6C0")]
		public static WQXRUSPURAQ<g, h, i, j> TOFCCKEDOJO<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x36CD250", Offset = "0x36CC650", VA = "0x1836CD250")]
		public static PJUEKOATGDQ<k> DHARCPOFDPP<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x36CD100", Offset = "0x36CC500", VA = "0x1836CD100")]
		public static PJOXNHGVWSH<l, m> DHARCPOFDPP<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x36CD1A0", Offset = "0x36CC5A0", VA = "0x1836CD1A0")]
		public static PJJQQAMYNGY<n, o, p> DHARCPOFDPP<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x36CDC10", Offset = "0x36CD010", VA = "0x1836CDC10")]
		public static PKUMWVWGBIJ<q, r, s, t> DHARCPOFDPP<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class TOFCCKEDOJO : GLODVPKBZKC, IDisposable
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
		private static Stack<DXJQDMRERKK> RRKJCSSZHDI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool APGPXXQVGVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly JDMCEZTJJPL EUIONDTHRZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly JLPEVSHEISE OELTKTIMQDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string OGKRXNXYGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode HVCQPRTJLQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action MSFCZUVJLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected DXJQDMRERKK NLTLKDSUGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags OUHOTGSOHNP;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static DXJQDMRERKK ONWAYHUEVVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8349E60", Offset = "0x8349260", VA = "0x188349E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool OAWLCMKFMEW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x834A940", Offset = "0x8349D40", VA = "0x18834A940")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x834AC80", Offset = "0x834A080", VA = "0x18834AC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool OTGKSTCKAER
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x834AD80", Offset = "0x834A180", VA = "0x18834AD80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x834B040", Offset = "0x834A440", VA = "0x18834B040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool FHNSWFUUXXC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x834A6E0", Offset = "0x8349AE0", VA = "0x18834A6E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x834A6C0", Offset = "0x8349AC0", VA = "0x18834A6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool WBGQDDVEGQL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8349ED0", Offset = "0x83492D0", VA = "0x188349ED0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x834A950", Offset = "0x8349D50", VA = "0x18834A950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object VSJXXYIUWYN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8C0", Offset = "0xAADCC0", VA = "0x180AAE8C0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool DTZSSMSMFVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x834A5D0", Offset = "0x83499D0", VA = "0x18834A5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int FZZOWEJNVPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xBEB260", Offset = "0xBEA660", VA = "0x180BEB260")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x17CA0A0", Offset = "0x17C94A0", VA = "0x1817CA0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string YIPZDRXKCOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool NNHLGBZZREX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x834AD90", Offset = "0x834A190", VA = "0x18834AD90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x834AFA0", Offset = "0x834A3A0", VA = "0x18834AFA0")]
		public static void ZCYLAUPZFST(DXJQDMRERKK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool SIVIGIIKJWZ();

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x834B0F0", Offset = "0x834A4F0", VA = "0x18834B0F0")]
		protected TOFCCKEDOJO(JDMCEZTJJPL a, JLPEVSHEISE b, string c, NetworkSetterPermissionMode d, Action e, DXJQDMRERKK f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8349E00", Offset = "0x8349200", VA = "0x188349E00", Slot = "1")]
		~TOFCCKEDOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8349AC0", Offset = "0x8348EC0", VA = "0x188349AC0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x834A620", Offset = "0x8349A20", VA = "0x18834A620")]
		private void NYLXEZKERDR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x834AAB0", Offset = "0x8349EB0", VA = "0x18834AAB0")]
		private object TYQWWHOBOUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x834A030", Offset = "0x8349430", VA = "0x18834A030")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x834AA70", Offset = "0x8349E70", VA = "0x18834AA70")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x834A6F0", Offset = "0x8349AF0", VA = "0x18834A6F0")]
		protected void QMCIMVWAFIO(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8349A40", Offset = "0x8348E40", VA = "0x188349A40")]
		internal void DEPGDBEAWSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x834AC20", Offset = "0x834A020", VA = "0x18834AC20")]
		private void VICCBNPUJCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x834AA10", Offset = "0x8349E10", VA = "0x18834AA10")]
		private void SRWOSSRLGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8349C40", Offset = "0x8349040", VA = "0x188349C40", Slot = "4")]
		private void FLICBXXXCSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8349C30", Offset = "0x8349030", VA = "0x188349C30", Slot = "5")]
		private void ENTPSTWYRWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8349EF0", Offset = "0x83492F0", VA = "0x188349EF0")]
		public bool ITSOCLJRAHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x834ADE0", Offset = "0x834A1E0", VA = "0x18834ADE0")]
		public bool YYGVHYNZMAM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8349CB0", Offset = "0x83490B0", VA = "0x188349CB0")]
		private bool FMNMRCBIYDJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x834A220", Offset = "0x8349620", VA = "0x18834A220")]
		internal void LMCQXHDTULS(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x834A430", Offset = "0x8349830", VA = "0x18834A430")]
		private void NAGUCFYNHGM(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8349EE0", Offset = "0x83492E0", VA = "0x188349EE0")]
		private bool IKUIIAIEYVO(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x834A200", Offset = "0x8349600", VA = "0x18834A200")]
		private void KJMHBCGCWUM(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x834A540", Offset = "0x8349940", VA = "0x18834A540")]
		public static string NDZSKDHQXFA(JDMCEZTJJPL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x834ACA0", Offset = "0x834A0A0", VA = "0x18834ACA0")]
		public static string WUJMFJXQODQ(JLPEVSHEISE a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x834A2D0", Offset = "0x83496D0", VA = "0x18834A2D0")]
		public static bool MHFXFMZHCWU(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class WUGYISBDPIK : DXJQDMRERKK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> NMZPXSBNKYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> HSNHUZFSHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> TTRELZELYER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> LNBHJMZSTOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool TEMRMIPWZPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> TNDRYKFFIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<JDMCEZTJJPL, Dictionary<string, object>> TTOKZNLMVZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> IZCLGWGBSLK;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> SLTAGMAWBLW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int UTQHWCMKYFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract JDMCEZTJJPL ATXPJDRAYLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool NNHLGBZZREX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool TNUEXNIXSIS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool IJAXYAKANOV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool KZSKNTWAFUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xAF9ED0", Offset = "0xAF92D0", VA = "0x180AF9ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3C00", Offset = "0x3BE3000", VA = "0x183BE3C00", Slot = "12")]
		public void OIZIGCEBTMR<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x834CE90", Offset = "0x834C290", VA = "0x18834CE90", Slot = "11")]
		public void WBWJCPDSTJC(JDMCEZTJJPL a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x834B3F0", Offset = "0x834A7F0", VA = "0x18834B3F0", Slot = "9")]
		public object CMLOYMODTKU(JDMCEZTJJPL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x834BB80", Offset = "0x834AF80", VA = "0x18834BB80", Slot = "10")]
		public void HKIAUBSLNOG(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x834C3A0", Offset = "0x834B7A0", VA = "0x18834C3A0", Slot = "8")]
		public object QXKQIDAMVPA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x834CFE0", Offset = "0x834C3E0", VA = "0x18834CFE0", Slot = "13")]
		public void WUYAVRKZQNV(JDMCEZTJJPL a, string b, TOFCCKEDOJO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x834C490", Offset = "0x834B890", VA = "0x18834C490", Slot = "14")]
		public void SZEDQPOYJLU(JDMCEZTJJPL a, string b, TOFCCKEDOJO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x834C440", Offset = "0x834B840", VA = "0x18834C440")]
		private void SRYMKDMQYTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x834BD10", Offset = "0x834B110", VA = "0x18834BD10")]
		private void KDGXWZMGIJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x834C730", Offset = "0x834BB30", VA = "0x18834C730")]
		private void TPQUTMEBLDN(JDMCEZTJJPL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x834BF80", Offset = "0x834B380", VA = "0x18834BF80")]
		protected void KVHQHLRSJFF(JDMCEZTJJPL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x834B6B0", Offset = "0x834AAB0", VA = "0x18834B6B0")]
		protected void DKSOBDHGQBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x834C270", Offset = "0x834B670", VA = "0x18834C270")]
		protected void MTANHHIAYHT(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x834BCA0", Offset = "0x834B0A0", VA = "0x18834BCA0")]
		protected void INMTVLEVZZR(JDMCEZTJJPL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x834D0F0", Offset = "0x834C4F0", VA = "0x18834D0F0")]
		protected void YPBYPLDUGNB(JDMCEZTJJPL a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x834CA10", Offset = "0x834BE10", VA = "0x18834CA10")]
		private void VHZIGOHXOSC(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x834D700", Offset = "0x834CB00", VA = "0x18834D700")]
		private static void ZFMOXRGJUBU(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x834BD60", Offset = "0x834B160", VA = "0x18834BD60")]
		private static void KJOTDNARJZT(Dictionary<string, object> a, string b, TOFCCKEDOJO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x834C0A0", Offset = "0x834B4A0", VA = "0x18834C0A0")]
		private static void LTYMFWJSEHW(Dictionary<string, object> a, string b, TOFCCKEDOJO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x834B5B0", Offset = "0x834A9B0", VA = "0x18834B5B0", Slot = "17")]
		public void DIQOFRALEWW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void IVDLKRIOJEL(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x834B310", Offset = "0x834A710", VA = "0x18834B310", Slot = "18")]
		public void AAJAZQAUHQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void RLZDMMFEEBH(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x834D4E0", Offset = "0x834C8E0", VA = "0x18834D4E0")]
		private void ZCPJMYNWWJS(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x834B900", Offset = "0x834AD00", VA = "0x18834B900")]
		private void GBHTFCTIQKZ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x834C310", Offset = "0x834B710", VA = "0x18834C310")]
		public void PLSWVRGLIKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x834B4E0", Offset = "0x834A8E0", VA = "0x18834B4E0")]
		public void CXLIZYQRFIG(JDMCEZTJJPL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x834D180", Offset = "0x834C580", VA = "0x18834D180")]
		public void ZBVQRITYBVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> ENXWZOPUFEP(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x834C790", Offset = "0x834BB90", VA = "0x18834C790", Slot = "19")]
		public void UBPRQFWRGFV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x834C280", Offset = "0x834B680", VA = "0x18834C280")]
		protected string NDZSKDHQXFA(JDMCEZTJJPL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object UIOMBCAALZF<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c NJAMWJTCSHY<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x834B7A0", Offset = "0x834ABA0", VA = "0x18834B7A0", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "33")]
		protected virtual void RNTFFKRIRHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x834D900", Offset = "0x834CD00", VA = "0x18834D900")]
		protected WUGYISBDPIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class VCNISEPJLAO<a> : TOFCCKEDOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a YMHPXDMOARV;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a LIGFVUOEJIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD57120", Offset = "0xD56520", VA = "0x180D57120", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD57110", Offset = "0xD56510", VA = "0x180D57110", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object VSJXXYIUWYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x62004D0", Offset = "0x61FF8D0", VA = "0x1862004D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6230A60", Offset = "0x622FE60", VA = "0x186230A60", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62325D0", Offset = "0x62319D0", VA = "0x1862325D0", Slot = "9")]
		protected override bool SIVIGIIKJWZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6237D20", Offset = "0x6237120", VA = "0x186237D20")]
		protected VCNISEPJLAO([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6236A50", Offset = "0x6235E50", VA = "0x186236A50")]
		protected VCNISEPJLAO(JDMCEZTJJPL a, JLPEVSHEISE b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, DXJQDMRERKK h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x620B540", Offset = "0x620A940", VA = "0x18620B540")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x62366A0", Offset = "0x6235AA0", VA = "0x1862366A0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6235820", Offset = "0x6234C20", VA = "0x186235820")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class VCIBUXVMBPF<a, b> : TOFCCKEDOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a YMHPXDMOARV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b YMMWUKGLKDE;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a LIGFVUOEJIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xE31290", Offset = "0xE30690", VA = "0x180E31290", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xFF3230", Offset = "0xFF2630", VA = "0x180FF3230", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b LIWANOVWLQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2FB1AD0", Offset = "0x2FB0ED0", VA = "0x182FB1AD0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6223FD0", Offset = "0x62233D0", VA = "0x186223FD0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b FCNMWAZOPHT
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1450690", Offset = "0x144FA90", VA = "0x181450690")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object VSJXXYIUWYN
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x62004D0", Offset = "0x61FF8D0", VA = "0x1862004D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6225390", Offset = "0x6224790", VA = "0x186225390", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6228730", Offset = "0x6227B30", VA = "0x186228730", Slot = "9")]
		protected override bool SIVIGIIKJWZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x622E900", Offset = "0x622DD00", VA = "0x18622E900")]
		protected VCIBUXVMBPF([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x622F920", Offset = "0x622ED20", VA = "0x18622F920")]
		protected VCIBUXVMBPF(JDMCEZTJJPL a, JLPEVSHEISE b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, DXJQDMRERKK i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6201D40", Offset = "0x6201140", VA = "0x186201D40")]
		public a HUBTBYGJISB()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6226A10", Offset = "0x6225E10", VA = "0x186226A10")]
		public void KSCVGJNFZAN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1450690", Offset = "0x144FA90", VA = "0x181450690")]
		public b HTLYKDYRGKA()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6226080", Offset = "0x6225480", VA = "0x186226080")]
		public void KRNAOPFNWSM(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x622A240", Offset = "0x6229640", VA = "0x18622A240")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class VCCUXRBOSDW<a, b, c> : TOFCCKEDOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a YMHPXDMOARV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b YMMWUKGLKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c YMSDRRAITON;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a LIGFVUOEJIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAB4EF0", Offset = "0xAB42F0", VA = "0x180AB4EF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAB48C0", Offset = "0xAB3CC0", VA = "0x180AB48C0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b LIWANOVWLQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xBFA890", Offset = "0xBF9C90", VA = "0x180BFA890", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x27F2D90", Offset = "0x27F2190", VA = "0x1827F2D90", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c LIQTQIBZCFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7C60", Offset = "0xAA7060", VA = "0x180AA7C60", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAA7C70", Offset = "0xAA7070", VA = "0x180AA7C70", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a FBXSEGRWMZS
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6201D40", Offset = "0x6201140", VA = "0x186201D40")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b FCNMWAZOPHT
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x1450690", Offset = "0x144FA90", VA = "0x181450690")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c FCIFYUFRFWK
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5A91120", Offset = "0x5A90520", VA = "0x185A91120")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object VSJXXYIUWYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x62004D0", Offset = "0x61FF8D0", VA = "0x1862004D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6219C00", Offset = "0x6219000", VA = "0x186219C00", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x621BB00", Offset = "0x621AF00", VA = "0x18621BB00", Slot = "9")]
		protected override bool SIVIGIIKJWZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x621E520", Offset = "0x621D920", VA = "0x18621E520")]
		protected VCCUXRBOSDW([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x621E290", Offset = "0x621D690", VA = "0x18621E290")]
		protected VCCUXRBOSDW(JDMCEZTJJPL a, JLPEVSHEISE b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, DXJQDMRERKK j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6201D40", Offset = "0x6201140", VA = "0x186201D40")]
		public a HUBTBYGJISB()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x621AB90", Offset = "0x6219F90", VA = "0x18621AB90")]
		public void KSCVGJNFZAN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1450690", Offset = "0x144FA90", VA = "0x181450690")]
		public b HTLYKDYRGKA()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x621A4F0", Offset = "0x62198F0", VA = "0x18621A4F0")]
		public void KRNAOPFNWSM(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5A91120", Offset = "0x5A90520", VA = "0x185A91120")]
		public c HTRFHKSOPVJ()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x621A770", Offset = "0x6219B70", VA = "0x18621A770")]
		public void KRSHLVZLGDV(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x621D1C0", Offset = "0x621C5C0", VA = "0x18621D1C0")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class VBXOAKHRISN<a, b, c, d> : TOFCCKEDOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a YMHPXDMOARV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b YMMWUKGLKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c YMSDRRAITON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d YLHHKVRBFNC;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a LIGFVUOEJIY
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xCA98F0", Offset = "0xCA8CF0", VA = "0x180CA98F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x62005E0", Offset = "0x61FF9E0", VA = "0x1862005E0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b LIWANOVWLQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1231960", Offset = "0x1230D60", VA = "0x181231960", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x122F440", Offset = "0x122E840", VA = "0x18122F440", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c LIQTQIBZCFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x1244F20", Offset = "0x1244320", VA = "0x181244F20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x620A040", Offset = "0x6209440", VA = "0x18620A040", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d LHQLEAGMHAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1A4BD50", Offset = "0x1A4B150", VA = "0x181A4BD50", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x13A91E0", Offset = "0x13A85E0", VA = "0x1813A91E0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b FCNMWAZOPHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6201C60", Offset = "0x6201060", VA = "0x186201C60")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c FCIFYUFRFWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6209BC0", Offset = "0x6208FC0", VA = "0x186209BC0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d FBHXMMKEKRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1378F60", Offset = "0x1378360", VA = "0x181378F60")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object VSJXXYIUWYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x62004D0", Offset = "0x61FF8D0", VA = "0x1862004D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x620B360", Offset = "0x620A760", VA = "0x18620B360", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x620F450", Offset = "0x620E850", VA = "0x18620F450", Slot = "9")]
		protected override bool SIVIGIIKJWZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6214230", Offset = "0x6213630", VA = "0x186214230")]
		protected VBXOAKHRISN([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6213160", Offset = "0x6212560", VA = "0x186213160")]
		protected VBXOAKHRISN(JDMCEZTJJPL a, JLPEVSHEISE b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, DXJQDMRERKK k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6201D40", Offset = "0x6201140", VA = "0x186201D40")]
		public a HUBTBYGJISB()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x620C880", Offset = "0x620BC80", VA = "0x18620C880")]
		public void KSCVGJNFZAN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6201C60", Offset = "0x6201060", VA = "0x186201C60")]
		public b HTLYKDYRGKA()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x620B980", Offset = "0x620AD80", VA = "0x18620B980")]
		public void KRNAOPFNWSM(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6209BC0", Offset = "0x6208FC0", VA = "0x186209BC0")]
		public c HTRFHKSOPVJ()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x620C1D0", Offset = "0x620B5D0", VA = "0x18620C1D0")]
		public void KRSHLVZLGDV(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1378F60", Offset = "0x1378360", VA = "0x181378F60")]
		public d HTBKPQKWNNI()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x620DAB0", Offset = "0x620CEB0", VA = "0x18620DAB0")]
		public void KSSPYDUYBIO(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6212110", Offset = "0x6211510", VA = "0x186212110")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class VBSHDDNTZHE<a, b, c, d, e> : TOFCCKEDOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a YMHPXDMOARV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b YMMWUKGLKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c YMSDRRAITON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d YLHHKVRBFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e YLMOICKYOYL;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a LIGFVUOEJIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAB4EF0", Offset = "0xAB42F0", VA = "0x180AB4EF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAB48C0", Offset = "0xAB3CC0", VA = "0x180AB48C0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b LIWANOVWLQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB384C0", Offset = "0xB378C0", VA = "0x180B384C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x11BB980", Offset = "0x11BAD80", VA = "0x1811BB980", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c LIQTQIBZCFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB49560", Offset = "0xB48960", VA = "0x180B49560", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xB4AB30", Offset = "0xB49F30", VA = "0x180B4AB30", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d LHQLEAGMHAX
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xABE040", Offset = "0xABD440", VA = "0x180ABE040", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xACDC70", Offset = "0xACD070", VA = "0x180ACDC70", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e LHLEGTMOXPO
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xABDCA0", Offset = "0xABD0A0", VA = "0x180ABDCA0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x62005D0", Offset = "0x61FF9D0", VA = "0x1862005D0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object VSJXXYIUWYN
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x62004D0", Offset = "0x61FF8D0", VA = "0x1862004D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x6201820", Offset = "0x6200C20", VA = "0x186201820", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6204B80", Offset = "0x6203F80", VA = "0x186204B80", Slot = "9")]
		protected override bool SIVIGIIKJWZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6208B40", Offset = "0x6207F40", VA = "0x186208B40")]
		protected VBSHDDNTZHE(JDMCEZTJJPL a, JLPEVSHEISE b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, DXJQDMRERKK l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6201D40", Offset = "0x6201140", VA = "0x186201D40")]
		public a HUBTBYGJISB()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6202CC0", Offset = "0x62020C0", VA = "0x186202CC0")]
		public void KSCVGJNFZAN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1450690", Offset = "0x144FA90", VA = "0x181450690")]
		public b HTLYKDYRGKA()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x62020C0", Offset = "0x62014C0", VA = "0x1862020C0")]
		public void KRNAOPFNWSM(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5A91120", Offset = "0x5A90520", VA = "0x185A91120")]
		public c HTRFHKSOPVJ()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6202820", Offset = "0x6201C20", VA = "0x186202820")]
		public void KRSHLVZLGDV(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1378F60", Offset = "0x1378360", VA = "0x181378F60")]
		public d HTBKPQKWNNI()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6203600", Offset = "0x6202A00", VA = "0x186203600")]
		public void KSSPYDUYBIO(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6201BA0", Offset = "0x6200FA0", VA = "0x186201BA0")]
		public e HTGRMXETWYR()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6203D20", Offset = "0x6203120", VA = "0x186203D20")]
		public void KSXWVKOVKTX(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6207480", Offset = "0x6206880", VA = "0x186207480")]
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
