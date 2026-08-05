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
		private Stream KJXEEHYBHTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private AQKFHQENCCL BNELVFISODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private long RCRONSUJAAV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CloseBaseStream
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1029800", Offset = "0x1028800", VA = "0x181029800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x10296E0", Offset = "0x10286E0", VA = "0x1810296E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x75D0670", Offset = "0x75CF670", VA = "0x1875D0670", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x75D06A0", Offset = "0x75CF6A0", VA = "0x1875D06A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75D0640", Offset = "0x75CF640", VA = "0x1875D0640")]
		public BufferedReadStream(Stream baseStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x75D0450", Offset = "0x75CF450", VA = "0x1875D0450")]
		public BufferedReadStream(Stream baseStream, int initialSize, int maxBufferSize, bool minimalRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75CFFD0", Offset = "0x75CEFD0", VA = "0x1875CFFD0", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public void SAPNAYFZMNT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private void YYDIIFKSNIY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		public void KKOSBYIZXEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75CFF40", Offset = "0x75CEF40", VA = "0x1875CFF40")]
		public void DDQJXHMPNIO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75D0020", Offset = "0x75CF020", VA = "0x1875D0020", Slot = "37")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75D0140", Offset = "0x75CF140", VA = "0x1875D0140", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75D01F0", Offset = "0x75CF1F0", VA = "0x1875D01F0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75D03D0", Offset = "0x75CF3D0", VA = "0x1875D03D0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75D0410", Offset = "0x75CF410", VA = "0x1875D0410", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal abstract class JGCXHEMDTMR
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
		private ulong NFHCDSDGQDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int PJOTSACWGGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int OMCNMRJULUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private byte IIKOIMJUKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PacketFlags SHTTGQUNZFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private long NDQVPCTSKRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int VUHKDOPOVUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int HZNQIWATRIR;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool PUONTMEXYDR
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x75D06D0", Offset = "0x75CF6D0", VA = "0x1875D06D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x75D06E0", Offset = "0x75CF6E0", VA = "0x1875D06E0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long SQCGYCJKHYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAD8F60", Offset = "0xAD7F60", VA = "0x180AD8F60")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xACFF50", Offset = "0xACEF50", VA = "0x180ACFF50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xACFF80", Offset = "0xACEF80", VA = "0x180ACFF80")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool TQCLCKOTDNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x75D06C0", Offset = "0x75CF6C0", VA = "0x1875D06C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x75D0AD0", Offset = "0x75CFAD0", VA = "0x1875D0AD0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal int PHJFSTAZUQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB1C870", Offset = "0xB1B870", VA = "0x180B1C870")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1782470", Offset = "0x1781470", VA = "0x181782470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool WGVRCCBTZSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x75D0B00", Offset = "0x75CFB00", VA = "0x1875D0B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75D0B50", Offset = "0x75CFB50", VA = "0x1875D0B50")]
		protected bool WYLURYFHSOB(PacketFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75D0B30", Offset = "0x75CFB30", VA = "0x1875D0B30")]
		protected void QIKUHOUQKAR(PacketFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75D0CA0", Offset = "0x75CFCA0", VA = "0x1875D0CA0")]
		protected JGCXHEMDTMR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract int HABWEWFUOLA();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
		public virtual void Done()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75D0710", Offset = "0x75CF710", VA = "0x1875D0710")]
		public ulong CCBNCOGYOGF(int a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x75D0B60", Offset = "0x75CFB60", VA = "0x1875D0B60")]
		public void YMMWNVYJPHE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x75D0AC0", Offset = "0x75CFAC0", VA = "0x1875D0AC0")]
		protected void KMDDZPWTFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75D0850", Offset = "0x75CF850", VA = "0x1875D0850")]
		public int HCZJXBJJVIF(byte[] a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal interface KLTBIEUQRVX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NJOQPLRRLJZ();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JGCXHEMDTMR JGJFWLINNHA();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		long IYRGGYDHCGO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class NewStreamEventArgs : EventArgs
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private KLTBIEUQRVX PacketProvider
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IgnoreStream
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xBF9560", Offset = "0xBF8560", VA = "0x180BF9560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x75D0F00", Offset = "0x75CFF00", VA = "0x1875D0F00")]
		public NewStreamEventArgs(KLTBIEUQRVX packetProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class RCEVTEQEBNC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class UNIYZPCGQQL
		{
			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public int DBZDWXYEZXT
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xADCB20", Offset = "0xADBB20", VA = "0x180ADCB20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public PageFlags XHVIWWDFOLK
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xC5B060", Offset = "0xC5A060", VA = "0x180C5B060")]
				[CompilerGenerated]
				get
				{
					return default(PageFlags);
				}
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xC5B070", Offset = "0xC5A070", VA = "0x180C5B070")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public long KTOENMWSRMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xEC0760", Offset = "0xEBF760", VA = "0x180EC0760")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public int YUTPGJJKSKR
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0xB29000", Offset = "0xB28000", VA = "0x180B29000")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public long YIFYDXZYNMS
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0xAD8F60", Offset = "0xAD7F60", VA = "0x180AD8F60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public int[] HFYJURKFITP
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xAD0DC0", Offset = "0xACFDC0", VA = "0x180AD0DC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public bool VHRHEMLVJFL
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xAFB5D0", Offset = "0xAFA5D0", VA = "0x180AFB5D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAFB5E0", Offset = "0xAFA5E0", VA = "0x180AFB5E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public bool PUONTMEXYDR
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x1BE3C70", Offset = "0x1BE2C70", VA = "0x181BE3C70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x1BE3F30", Offset = "0x1BE2F30", VA = "0x181BE3F30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public UNIYZPCGQQL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private KIDGRANAJCF TMKBLTKFHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BufferedReadStream AGPVOISUSJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Dictionary<int, PacketReader> ROJWXJKBPDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<int> LYLVMIZMNSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private long FRQCYMDTXWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int KRXKTNHHZWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private byte[] AJARBHUWNNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long QOOHFKFSISR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private long PLFOAGCEXME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[CompilerGenerated]
		private EventHandler<NewStreamEventArgs> KSPKTQFMKNT;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int[] XTFTQUSLTTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x75D1F20", Offset = "0x75D0F20", VA = "0x1875D1F20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool UWUSNJQZZXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x75D2A50", Offset = "0x75D1A50", VA = "0x1875D2A50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x75D30C0", Offset = "0x75D20C0", VA = "0x1875D30C0")]
		public RCEVTEQEBNC(Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x75D29D0", Offset = "0x75D19D0", VA = "0x1875D29D0", Slot = "6")]
		public bool RTFNZEQTDKX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75D1BD0", Offset = "0x75D0BD0", VA = "0x1875D1BD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x75D1DA0", Offset = "0x75D0DA0", VA = "0x1875D1DA0")]
		public KLTBIEUQRVX FOBREEIEJFV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x75D1F80", Offset = "0x75D0F80", VA = "0x1875D1F80")]
		private UNIYZPCGQQL NICCHALSLKL(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x75D2EE0", Offset = "0x75D1EE0", VA = "0x1875D2EE0")]
		private UNIYZPCGQQL YJPFVZZTEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75D2A80", Offset = "0x75D1A80", VA = "0x1875D2A80")]
		private bool UGGGAVYOOHF(UNIYZPCGQQL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x75D27D0", Offset = "0x75D17D0", VA = "0x1875D27D0")]
		private int OLZTUQTGYCE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75D1CE0", Offset = "0x75D0CE0", VA = "0x1875D1CE0")]
		internal void ECBICAQLWMN(PacketReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x75D1E60", Offset = "0x75D0E60", VA = "0x1875D1E60")]
		internal int IICMBIFFDAD(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x75D2DD0", Offset = "0x75D1DD0", VA = "0x1875D2DD0")]
		internal void WSDGVTQNBXE(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x75D24C0", Offset = "0x75D14C0", VA = "0x1875D24C0")]
		internal void OLZTUQTGYCE(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class KIDGRANAJCF
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static uint[] FIIBDQELHAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private uint TMKBLTKFHDG;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x75D0D80", Offset = "0x75CFD80", VA = "0x1875D0D80")]
		static KIDGRANAJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F3E0", Offset = "0x1A0E3E0", VA = "0x181A0F3E0")]
		public KIDGRANAJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E810", Offset = "0x1A0D810", VA = "0x181A0E810")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75D0CD0", Offset = "0x75CFCD0", VA = "0x1875D0CD0")]
		public void Update(int nextVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x297FF10", Offset = "0x297EF10", VA = "0x18297FF10")]
		public bool HMVQINURHWZ(uint a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class BXTEKUJCHEZ : JGCXHEMDTMR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long CQKYTVUFEUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int VUHKDOPOVUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int UIEULCXLALY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private BXTEKUJCHEZ HBIEULUGMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private BXTEKUJCHEZ ARBCDXFMCOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private BXTEKUJCHEZ FODLNCWJXFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private RCEVTEQEBNC OCDWXQDEEBI;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal BXTEKUJCHEZ JIZHLMOKLUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xACEE90", Offset = "0xACDE90", VA = "0x180ACEE90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xACEBC0", Offset = "0xACDBC0", VA = "0x180ACEBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		internal BXTEKUJCHEZ HADKALBWKVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xACEE70", Offset = "0xACDE70", VA = "0x180ACEE70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xACEEA0", Offset = "0xACDEA0", VA = "0x180ACEEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		internal bool BMZMWXAYREQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x75CFC70", Offset = "0x75CEC70", VA = "0x1875CFC70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x75CFEA0", Offset = "0x75CEEA0", VA = "0x1875CFEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal bool QMIRJQLMIXY
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x75CFED0", Offset = "0x75CEED0", VA = "0x1875CFED0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x75CFE40", Offset = "0x75CEE40", VA = "0x1875CFE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x75CFEE0", Offset = "0x75CEEE0", VA = "0x1875CFEE0")]
		internal BXTEKUJCHEZ(RCEVTEQEBNC a, long b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x75CFD40", Offset = "0x75CED40", VA = "0x1875CFD40")]
		internal void KYACXLDVBDZ(JGCXHEMDTMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75CFE70", Offset = "0x75CEE70", VA = "0x1875CFE70")]
		internal void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x75CFCD0", Offset = "0x75CECD0", VA = "0x1875CFCD0", Slot = "4")]
		protected override int HABWEWFUOLA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC80", Offset = "0x75CEC80", VA = "0x1875CFC80", Slot = "5")]
		public override void Done()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DebuggerTypeProxy(typeof(OJMFZMDDAEF))]
	internal class PacketReader : KLTBIEUQRVX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class OJMFZMDDAEF
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private RCEVTEQEBNC OUOQENIWRDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int VXLFHHAHVBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool LUSXMILZFDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private BXTEKUJCHEZ LIHNHAPNXRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private BXTEKUJCHEZ OZXBSDHICAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private BXTEKUJCHEZ OUOUJHQVXNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private object AOSQFZVEZYJ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		internal bool CUXNXXXRXIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC28220", Offset = "0xC27220", VA = "0x180C28220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int DBZDWXYEZXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public long VYSMSNEJJNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1098420", Offset = "0x1097420", VA = "0x181098420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool UWUSNJQZZXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x75D15D0", Offset = "0x75D05D0", VA = "0x1875D15D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B30", Offset = "0x75D0B30", VA = "0x1875D1B30")]
		internal PacketReader(RCEVTEQEBNC container, int streamSerial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x75D1320", Offset = "0x75D0320", VA = "0x1875D1320", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x75D1910", Offset = "0x75D0910", VA = "0x1875D1910")]
		internal void ZTLUZTAJCRW(BXTEKUJCHEZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75D1800", Offset = "0x75D0800", VA = "0x1875D1800")]
		internal void ZLILSFHUHJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x75D1550", Offset = "0x75D0550", VA = "0x1875D1550", Slot = "5")]
		public JGCXHEMDTMR JGJFWLINNHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75D1630", Offset = "0x75D0630", VA = "0x1875D1630")]
		private BXTEKUJCHEZ ZKGZMHCABVM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x75D1480", Offset = "0x75D0480", VA = "0x1875D1480")]
		internal void FCWJZUIRDZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x75D1610", Offset = "0x75D0610", VA = "0x1875D1610")]
		internal JGCXHEMDTMR ZDSBLCYCHID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x75D1590", Offset = "0x75D0590", VA = "0x1875D1590", Slot = "4")]
		public int NJOQPLRRLJZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x75D1520", Offset = "0x75D0520", VA = "0x1875D1520", Slot = "6")]
		public long IYRGGYDHCGO()
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
	public class SPBDKRANBXP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Stream AGPVOISUSJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly VLNYJIHFWVH QIASEVPAMFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private byte[] CVABEOQHLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private KLTBIEUQRVX DMRJUWPEVET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool UVUHIVBHLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private RCEVTEQEBNC OCDWXQDEEBI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool UWUSNJQZZXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x75D3C00", Offset = "0x75D2C00", VA = "0x1875D3C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private OpusTags SJDYAVGVCXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xACFF40", Offset = "0xACEF40", VA = "0x180ACFF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool JEQBIVKGJQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1005590", Offset = "0x1004590", VA = "0x181005590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private string NMKNKYZAGSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAD6760", Offset = "0xAD5760", VA = "0x180AD6760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private long SQCGYCJKHYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1098440", Offset = "0x1097440", VA = "0x181098440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private long VRXNTACHOKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x10B85E0", Offset = "0x10B75E0", VA = "0x1810B85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private long UTKTNNZRLZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x10983C0", Offset = "0x10973C0", VA = "0x1810983C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private long XWXJBVVTSIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x10B8200", Offset = "0x10B7200", VA = "0x1810B8200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75D3C30", Offset = "0x75D2C30", VA = "0x1875D3C30")]
		public SPBDKRANBXP(VLNYJIHFWVH a, Stream b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x75D32C0", Offset = "0x75D22C0", VA = "0x1875D32C0")]
		public byte[] EMKKJBJGMFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x75D3580", Offset = "0x75D2580", VA = "0x1875D3580")]
		private bool Initialize()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75D3300", Offset = "0x75D2300", VA = "0x1875D3300")]
		private void GSYQXNQTGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x75D32A0", Offset = "0x75D22A0", VA = "0x1875D32A0")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class OpusTags
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string IBEVORMMOLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDictionary<string, string> JXIDIEYIUSD;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x75D1280", Offset = "0x75D0280", VA = "0x1875D1280")]
		public OpusTags()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x75D0FC0", Offset = "0x75CFFC0", VA = "0x1875D0FC0")]
		internal static OpusTags TPOQZCZPFYE(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class AQKFHQENCCL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		internal class ZSLLEHCYLAU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			internal Stream FWHGXTHPYLW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			internal object OVOAZOQMLZX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal long IWWKZDRIREG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			internal int BGVNOIGJALP;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x75D3CE0", Offset = "0x75D2CE0", VA = "0x1875D3CE0")]
			public ZSLLEHCYLAU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class PMVIVNWNOKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public byte[] HBCLKCMHZPV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public long KDZCBFAHHJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public int YTBFAQLEKEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int DYJSWRFXUPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public long WEIVRKOYQAG;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public PMVIVNWNOKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<Stream, ZSLLEHCYLAU> ETMHNHGVVEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private ZSLLEHCYLAU KIKHFWPEVIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int EOHGCEURLZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private byte[] EHNGONPJQQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long QFJTMRSGZJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int NWVQZYUVSQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int RMXHNXVKCVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool BWDNHLPOHTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private long OEAKYOAZZYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private List<PMVIVNWNOKG> JGLLGISLFKE;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool IFHUSUDIHBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAFB5E0", Offset = "0xAFA5E0", VA = "0x180AFB5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int EWXPONDUQCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x75CF5A0", Offset = "0x75CE5A0", VA = "0x1875CF5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public long KDZCBFAHHJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x75CF2A0", Offset = "0x75CE2A0", VA = "0x1875CF2A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15A17E0", Offset = "0x15A07E0", VA = "0x1815A17E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		internal long ORRTUFNWMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x75CEF50", Offset = "0x75CDF50", VA = "0x1875CEF50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x75CF830", Offset = "0x75CE830", VA = "0x1875CF830")]
		internal AQKFHQENCCL(Stream a, int b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x75CE620", Offset = "0x75CD620", VA = "0x1875CE620", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x75CE8D0", Offset = "0x75CD8D0", VA = "0x1875CE8D0")]
		public int HCZJXBJJVIF(long a, byte[] b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x75CEAC0", Offset = "0x75CDAC0", VA = "0x1875CEAC0")]
		internal int IEQZPHFXYYD(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x75CE100", Offset = "0x75CD100", VA = "0x1875CE100")]
		private int BPIUMNYKTHI(long a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x75CE500", Offset = "0x75CD500", VA = "0x1875CE500")]
		private void DLQOLPSWQLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75CE770", Offset = "0x75CD770", VA = "0x1875CE770")]
		private void FJZFILJHUIL(long a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75CE840", Offset = "0x75CD840", VA = "0x1875CE840")]
		private void FOYBVBXLJAR(PMVIVNWNOKG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x75CED20", Offset = "0x75CDD20", VA = "0x1875CED20")]
		private void OVSOKYHNJOK(long a, int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x75CF2B0", Offset = "0x75CE2B0", VA = "0x1875CF2B0")]
		private void TJSHLKRJHGY(int a, bool b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x75CEFF0", Offset = "0x75CDFF0", VA = "0x1875CEFF0")]
		private int QXNYUTARUMG(long a, int b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x75CEB90", Offset = "0x75CDB90", VA = "0x1875CEB90")]
		private int NRCXFYMWJUH(int a, long b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75CF500", Offset = "0x75CE500", VA = "0x1875CF500")]
		private void TQYQJFNGTRT(int a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x75CE470", Offset = "0x75CD470", VA = "0x1875CE470")]
		public void DDQJXHMPNIO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x75CEEC0", Offset = "0x75CDEC0", VA = "0x1875CEEC0")]
		private void PVHXVKIESTM()
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
