using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Concentus.Oggfile
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	internal class BufferedReadStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private Stream FNYDHRZDJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private WLPQVWWKZXA JFUMSAITXSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private long UOAEGHVMHRA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CloseBaseStream
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xF528E0", Offset = "0xF512E0", VA = "0x180F528E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xF527C0", Offset = "0xF511C0", VA = "0x180F527C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x870C4B0", Offset = "0x870AEB0", VA = "0x18870C4B0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x870C4E0", Offset = "0x870AEE0", VA = "0x18870C4E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x870C480", Offset = "0x870AE80", VA = "0x18870C480")]
		public BufferedReadStream(Stream baseStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x870C290", Offset = "0x870AC90", VA = "0x18870C290")]
		public BufferedReadStream(Stream baseStream, int initialSize, int maxBufferSize, bool minimalRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x870BD80", Offset = "0x870A780", VA = "0x18870BD80", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public void YDAJXNSGXVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private void MJRYUTVBGAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public void FDHDFUSSSIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x870C200", Offset = "0x870AC00", VA = "0x18870C200")]
		public void XDCKSYPXQPJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x870BDD0", Offset = "0x870A7D0", VA = "0x18870BDD0", Slot = "37")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x870BEF0", Offset = "0x870A8F0", VA = "0x18870BEF0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x870BFA0", Offset = "0x870A9A0", VA = "0x18870BFA0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x870C180", Offset = "0x870AB80", VA = "0x18870C180", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x870C1C0", Offset = "0x870ABC0", VA = "0x18870C1C0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal abstract class MJGHVILHKRK
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[Flags]
		protected enum PacketFlags : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			IsResync = 1,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			IsEndOfStream = 2,
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			IsShort = 4,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			HasGranuleCount = 8,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			User1 = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			User2 = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			User3 = 0x40,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			User4 = 0x80
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private ulong UDCOHUEHHTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int GOTSKNFRCUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int PDDJNHLUFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private byte ZJXAKVNQWOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PacketFlags AJHGRMITPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private long EULWHYIEZSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int LHIXDXYWGYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int XNMRSWEJJJU;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool UMWBFNAPKDU
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x870CB50", Offset = "0x870B550", VA = "0x18870CB50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x870C800", Offset = "0x870B200", VA = "0x18870C800")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long AZZPSEZZHBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2F0", Offset = "0xCD9CF0", VA = "0x180CDB2F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int FUKZCZVBGQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCDD9E0", Offset = "0xCDC3E0", VA = "0x180CDD9E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCDD820", Offset = "0xCDC220", VA = "0x180CDD820")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool SHUUKHHLXUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x870C580", Offset = "0x870AF80", VA = "0x18870C580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x870C830", Offset = "0x870B230", VA = "0x18870C830")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal int PHETTIDHAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD217E0", Offset = "0xD201E0", VA = "0x180D217E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x16CAC00", Offset = "0x16C9600", VA = "0x1816CAC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool WCPCAHKWKDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x870C860", Offset = "0x870B260", VA = "0x18870C860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x870C9D0", Offset = "0x870B3D0", VA = "0x18870C9D0")]
		protected bool MFCVNDNHJSS(PacketFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x870C9E0", Offset = "0x870B3E0", VA = "0x18870C9E0")]
		protected void MUILLMWPCOK(PacketFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x870CB60", Offset = "0x870B560", VA = "0x18870CB60")]
		protected MJGHVILHKRK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract int RDPAAWBCPXB();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
		public virtual void Done()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x870CA00", Offset = "0x870B400", VA = "0x18870CA00")]
		public ulong OGWFHJOGTKW(int a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x870C890", Offset = "0x870B290", VA = "0x18870C890")]
		public void HWZKXILBOXJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x870CB40", Offset = "0x870B540", VA = "0x18870CB40")]
		protected void TOVWLETTNCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x870C590", Offset = "0x870AF90", VA = "0x18870C590")]
		public int EDBAWLRQTGA(byte[] a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal interface ZVWTWDQBPAO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IOHLDKKWJLG();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MJGHVILHKRK EULNLWCTFMJ();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		long KVFTSIMGMWB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class NewStreamEventArgs : EventArgs
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private ZVWTWDQBPAO PacketProvider
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IgnoreStream
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xE70C80", Offset = "0xE6F680", VA = "0x180E70C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x870CB90", Offset = "0x870B590", VA = "0x18870CB90")]
		public NewStreamEventArgs(ZVWTWDQBPAO packetProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class UITSKDILQYN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class TAFZLSAPFLM
		{
			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public int LPKUUWXIWSE
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xCDFF30", Offset = "0xCDE930", VA = "0x180CDFF30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public PageFlags HJOHHTAGMNF
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xDF0AD0", Offset = "0xDEF4D0", VA = "0x180DF0AD0")]
				[CompilerGenerated]
				get
				{
					return default(PageFlags);
				}
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xDF0A00", Offset = "0xDEF400", VA = "0x180DF0A00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public long JIHMVPDXNOF
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xDF0A10", Offset = "0xDEF410", VA = "0x180DF0A10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public int RRNZUBUNRVW
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0xCE2550", Offset = "0xCE0F50", VA = "0x180CE2550")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0xD251B0", Offset = "0xD23BB0", VA = "0x180D251B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public long LBGQFCQOWJF
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0xCDB2F0", Offset = "0xCD9CF0", VA = "0x180CDB2F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public int[] DGCZQOXLSNQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CE0", Offset = "0xCD26E0", VA = "0x180CD3CE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public bool EXEIWDVNYLU
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xCFE3A0", Offset = "0xCFCDA0", VA = "0x180CFE3A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xCFE3B0", Offset = "0xCFCDB0", VA = "0x180CFE3B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public bool UMWBFNAPKDU
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x1B5FB20", Offset = "0x1B5E520", VA = "0x181B5FB20")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x102AB30", Offset = "0x1029530", VA = "0x18102AB30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public TAFZLSAPFLM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private OBUAOBLICNY AMMTOJKYHTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BufferedReadStream LTTHIQDCHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Dictionary<int, PacketReader> IUYHMXGIXZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<int> ALYAMURBXVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private long LIUALMCRPAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int RTPCVFYKSBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private byte[] QGKSCAAXQMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long MXREPRTKDYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private long RZGFNTTDGHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[CompilerGenerated]
		private EventHandler<NewStreamEventArgs> VSZVQCGTOZA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int[] NOGCRKDDJSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x870E870", Offset = "0x870D270", VA = "0x18870E870", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HYRLEACPYGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x870EF50", Offset = "0x870D950", VA = "0x18870EF50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x870EF80", Offset = "0x870D980", VA = "0x18870EF80")]
		public UITSKDILQYN(Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x870EE10", Offset = "0x870D810", VA = "0x18870EE10", Slot = "6")]
		public bool VQZGAVQPNPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x870DC60", Offset = "0x870C660", VA = "0x18870DC60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x870DD70", Offset = "0x870C770", VA = "0x18870DD70")]
		public ZVWTWDQBPAO EOJXMRFJHLO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x870E8D0", Offset = "0x870D2D0", VA = "0x18870E8D0")]
		private TAFZLSAPFLM OBAVRHEOMDE(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x870DE30", Offset = "0x870C830", VA = "0x18870DE30")]
		private TAFZLSAPFLM KDPDOBNSSEY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x870E010", Offset = "0x870CA10", VA = "0x18870E010")]
		private bool LIRUPNRRVOM(TAFZLSAPFLM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x870E670", Offset = "0x870D070", VA = "0x18870E670")]
		private int MFQZTWWCWHD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x870DBA0", Offset = "0x870C5A0", VA = "0x18870DBA0")]
		internal void CYXMIFXDRCK(PacketReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x870EE90", Offset = "0x870D890", VA = "0x18870EE90")]
		internal int WMDIWLJNDHQ(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x870DA90", Offset = "0x870C490", VA = "0x18870DA90")]
		internal void CPFYJKXRQIH(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x870E360", Offset = "0x870CD60", VA = "0x18870E360")]
		internal void MFQZTWWCWHD(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class OBUAOBLICNY
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static uint[] HFCQRVOJNJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private uint AMMTOJKYHTD;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x870CD00", Offset = "0x870B700", VA = "0x18870CD00")]
		static OBUAOBLICNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1940990", Offset = "0x193F390", VA = "0x181940990")]
		public OBUAOBLICNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1940980", Offset = "0x193F380", VA = "0x181940980")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x870CC50", Offset = "0x870B650", VA = "0x18870CC50")]
		public void Update(int nextVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x271B310", Offset = "0x2719D10", VA = "0x18271B310")]
		public bool AXXRPEPDQYI(uint a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class WUCXAZQSCDW : MJGHVILHKRK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long HBWGVJDCZYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int LHIXDXYWGYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int XMXXUDHVPEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private WUCXAZQSCDW ZARQOUZTFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private WUCXAZQSCDW MVDOIKDXFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private WUCXAZQSCDW FPLGULSCTMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private UITSKDILQYN PINLFKNSCLJ;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal WUCXAZQSCDW EEMQUSMSXGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		internal WUCXAZQSCDW RMSVDYSXECV
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		internal bool PIPTFOSRRSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x87118D0", Offset = "0x87102D0", VA = "0x1887118D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8711790", Offset = "0x8710190", VA = "0x188711790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal bool PIXUCVJBIVR
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8711700", Offset = "0x8710100", VA = "0x188711700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8711760", Offset = "0x8710160", VA = "0x188711760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8711980", Offset = "0x8710380", VA = "0x188711980")]
		internal WUCXAZQSCDW(UITSKDILQYN a, long b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x87117C0", Offset = "0x87101C0", VA = "0x1887117C0")]
		internal void NJEDGYUAUZG(MJGHVILHKRK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8711950", Offset = "0x8710350", VA = "0x188711950")]
		internal void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x87118E0", Offset = "0x87102E0", VA = "0x1887118E0", Slot = "4")]
		protected override int RDPAAWBCPXB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8711710", Offset = "0x8710110", VA = "0x188711710", Slot = "5")]
		public override void Done()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DebuggerTypeProxy(typeof(ADECVZNWXBQ))]
	internal class PacketReader : ZVWTWDQBPAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class ADECVZNWXBQ
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private UITSKDILQYN BDALUXZPCVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int XTUZVHTTQOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool KONFMQAQXJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private WUCXAZQSCDW KKUNZARJXSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private WUCXAZQSCDW KVJBXDUUAYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private WUCXAZQSCDW PPQXZDKQGXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private object ISCTQEXDTDI;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		internal bool HYFELJWKZOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE6DD30", Offset = "0xE6C730", VA = "0x180E6DD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int LPKUUWXIWSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public long ZOCZBLWAUQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xFA4B70", Offset = "0xFA3570", VA = "0x180FA4B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool HYRLEACPYGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x870D9B0", Offset = "0x870C3B0", VA = "0x18870D9B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x870D9F0", Offset = "0x870C3F0", VA = "0x18870D9F0")]
		internal PacketReader(UITSKDILQYN container, int streamSerial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x870D2F0", Offset = "0x870BCF0", VA = "0x18870D2F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x870D5C0", Offset = "0x870BFC0", VA = "0x18870D5C0")]
		internal void UMZYUASZGCH(WUCXAZQSCDW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x870D1E0", Offset = "0x870BBE0", VA = "0x18870D1E0")]
		internal void CEYCDYUHMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x870D450", Offset = "0x870BE50", VA = "0x18870D450", Slot = "5")]
		public MJGHVILHKRK EULNLWCTFMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x870D7E0", Offset = "0x870C1E0", VA = "0x18870D7E0")]
		private WUCXAZQSCDW ZBSDHGSDFYT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x870D520", Offset = "0x870BF20", VA = "0x18870D520")]
		internal void QMUSYCEHWNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x870D500", Offset = "0x870BF00", VA = "0x18870D500")]
		internal MJGHVILHKRK PSKIHSBFDNS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x870D490", Offset = "0x870BE90", VA = "0x18870D490", Slot = "4")]
		public int IOHLDKKWJLG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x870D4D0", Offset = "0x870BED0", VA = "0x18870D4D0", Slot = "6")]
		public long KVFTSIMGMWB()
		{
			return default(long);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Flags]
	internal enum PageFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		ContinuesPacket = 1,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		BeginningOfStream = 2,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		EndOfStream = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UTOGBBGDRFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Stream LTTHIQDCHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly DBIFGDONOSY BMVCYSTMIJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private byte[] BPOVMPJZWRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private ZVWTWDQBPAO WJSENTSZHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool MTBWCDSLQJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private UITSKDILQYN PINLFKNSCLJ;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool HYRLEACPYGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x870FAB0", Offset = "0x870E4B0", VA = "0x18870FAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private OpusTags ISFCKCOOSCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xCDB280", Offset = "0xCD9C80", VA = "0x180CDB280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool BTGRMGRIBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xF29FD0", Offset = "0xF289D0", VA = "0x180F29FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private string ARJCARKCYAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCD76A0", Offset = "0xCD60A0", VA = "0x180CD76A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private long AZZPSEZZHBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xFA4B50", Offset = "0xFA3550", VA = "0x180FA4B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private long DWUJNPKIMHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xFDE770", Offset = "0xFDD170", VA = "0x180FDE770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private long AXFUQRMEULO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xFA51D0", Offset = "0xFA3BD0", VA = "0x180FA51D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private long BPDSNFMPKNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xFDE780", Offset = "0xFDD180", VA = "0x180FDE780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x870FAE0", Offset = "0x870E4E0", VA = "0x18870FAE0")]
		public UTOGBBGDRFM(DBIFGDONOSY a, Stream b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x870FA70", Offset = "0x870E470", VA = "0x18870FA70")]
		public byte[] OWLLRGRAKYZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x870F400", Offset = "0x870DE00", VA = "0x18870F400")]
		private bool Initialize()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x870F180", Offset = "0x870DB80", VA = "0x18870F180")]
		private void EGFEGNNLNEW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x870F160", Offset = "0x870DB60", VA = "0x18870F160")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class OpusTags
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string HUMJGWVVPGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDictionary<string, string> GRBSWMWFCEQ;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x870D140", Offset = "0x870BB40", VA = "0x18870D140")]
		public OpusTags()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x870CE80", Offset = "0x870B880", VA = "0x18870CE80")]
		internal static OpusTags EWRUBXSVUVV(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class WLPQVWWKZXA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		internal class HBCKOFYASXB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			internal Stream RGTJYRDPCJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			internal object VLGOWWHMOEQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal long TUXSRGCGMDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			internal int MSXQTYRZKRG;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x870C500", Offset = "0x870AF00", VA = "0x18870C500")]
			public HBCKOFYASXB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class IHYGHJMSGKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public byte[] OHPLGLWJJAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public long KPJGHVOHRYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public int QUSLSCNGWNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int KVJEGHIJOWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public long HIHJIGCYMKP;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public IHYGHJMSGKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<Stream, HBCKOFYASXB> HKSMGVQPNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private HBCKOFYASXB CSOQGDKPZKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int JTDTNCKQEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private byte[] JQQLQPAMKVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long RRCCNTEOEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int OXKRXZJCIVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int VWFJMQSMSOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool EPDKSKKENDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private long JVNANFTILMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private List<IHYGHJMSGKJ> TLNXFPCHZGD;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool RANWOTHTEUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xCFE3B0", Offset = "0xCFCDB0", VA = "0x180CFE3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int NHCXGOHQCTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x87102E0", Offset = "0x870ECE0", VA = "0x1887102E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public long KPJGHVOHRYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8710570", Offset = "0x870EF70", VA = "0x188710570")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int FUKZCZVBGQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x14E47D0", Offset = "0x14E31D0", VA = "0x1814E47D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		internal long EPWKZBGSRRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8710240", Offset = "0x870EC40", VA = "0x188710240")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x87112C0", Offset = "0x870FCC0", VA = "0x1887112C0")]
		internal WLPQVWWKZXA(Stream a, int b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x870FB90", Offset = "0x870E590", VA = "0x18870FB90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x870FCE0", Offset = "0x870E6E0", VA = "0x18870FCE0")]
		public int EDBAWLRQTGA(long a, byte[] b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8710CC0", Offset = "0x870F6C0", VA = "0x188710CC0")]
		internal int TLNBTBVWCVY(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x870FED0", Offset = "0x870E8D0", VA = "0x18870FED0")]
		private int EMEZXJCDUQB(long a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8710710", Offset = "0x870F110", VA = "0x188710710")]
		private void RJWLZICCHQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8710E20", Offset = "0x870F820", VA = "0x188710E20")]
		private void XASVMEPCAXC(long a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x87104E0", Offset = "0x870EEE0", VA = "0x1887104E0")]
		private void ONJTMNKVDMW(IHYGHJMSGKJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8710A80", Offset = "0x870F480", VA = "0x188710A80")]
		private void SGNWSWEAVET(long a, int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8710830", Offset = "0x870F230", VA = "0x188710830")]
		private void SGAGHTQHDJP(int a, bool b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8710F80", Offset = "0x870F980", VA = "0x188710F80")]
		private int XRODULRKUHN(long a, int b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8710580", Offset = "0x870EF80", VA = "0x188710580")]
		private int PYYTMQNKBZU(int a, long b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8710C20", Offset = "0x870F620", VA = "0x188710C20")]
		private void TJFHMCOOCEI(int a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8710EF0", Offset = "0x870F8F0", VA = "0x188710EF0")]
		public void XDCKSYPXQPJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8710D90", Offset = "0x870F790", VA = "0x188710D90")]
		private void ULWEQLIWUXP()
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
