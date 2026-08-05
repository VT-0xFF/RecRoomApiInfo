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
		private Stream IWWXAQASEQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private FQCLEFJHLON LJLMXVHZJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private long XTNYUKZVVLJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CloseBaseStream
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCC8520", Offset = "0xCC6D20", VA = "0x180CC8520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCC81C0", Offset = "0xCC69C0", VA = "0x180CC81C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7239F20", Offset = "0x7238720", VA = "0x187239F20", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7239F50", Offset = "0x7238750", VA = "0x187239F50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7239EF0", Offset = "0x72386F0", VA = "0x187239EF0")]
		public BufferedReadStream(Stream baseStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7239D00", Offset = "0x7238500", VA = "0x187239D00")]
		public BufferedReadStream(Stream baseStream, int initialSize, int maxBufferSize, bool minimalRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7239880", Offset = "0x7238080", VA = "0x187239880", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public void BHTWEZFPFSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private void PQWYBGTRFXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public void GGDETTNYMQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72397F0", Offset = "0x7237FF0", VA = "0x1872397F0")]
		public void CLUEEAVYWNS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72398D0", Offset = "0x72380D0", VA = "0x1872398D0", Slot = "37")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72399F0", Offset = "0x72381F0", VA = "0x1872399F0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7239AA0", Offset = "0x72382A0", VA = "0x187239AA0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7239C80", Offset = "0x7238480", VA = "0x187239C80", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7239CC0", Offset = "0x72384C0", VA = "0x187239CC0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal abstract class OBIMZGTUPZJ
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
		private ulong DGWDLAZQQEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int UVALYIIYPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int WSCLGDSBQFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private byte YJZPULDDXOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PacketFlags ATYNXYNGAZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private long BMHODIEVJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int UNUPUDJWWHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int WOMVPOVPWNJ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NKAKPYFNJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x723BE10", Offset = "0x723A610", VA = "0x18723BE10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x723BDC0", Offset = "0x723A5C0", VA = "0x18723BDC0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long ZYCGTYORZLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB2A0", VA = "0x180AACAA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int KGSUFPGCCQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A80", Offset = "0xAB7280", VA = "0x180AB8A80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A70", Offset = "0xAB7270", VA = "0x180AB8A70")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GLNPHCFYNWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x723BE00", Offset = "0x723A600", VA = "0x18723BE00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x723BC30", Offset = "0x723A430", VA = "0x18723BC30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal int CEPKXMTFNBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFB170", VA = "0x180AFC970")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x143C990", Offset = "0x143B190", VA = "0x18143C990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool PGDJQRLLUUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x723BC00", Offset = "0x723A400", VA = "0x18723BC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x723BDF0", Offset = "0x723A5F0", VA = "0x18723BDF0")]
		protected bool MAKUNLFCTNZ(PacketFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x723BC60", Offset = "0x723A460", VA = "0x18723BC60")]
		protected void GBYJFCGQMFR(PacketFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x723C1E0", Offset = "0x723A9E0", VA = "0x18723C1E0")]
		protected OBIMZGTUPZJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract int XAGEZDZPEHG();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public virtual void Done()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x723BC80", Offset = "0x723A480", VA = "0x18723BC80")]
		public ulong JNHEDPPYLVB(int a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x723BE30", Offset = "0x723A630", VA = "0x18723BE30")]
		public void XUXJELDWKLC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x723BE20", Offset = "0x723A620", VA = "0x18723BE20")]
		protected void XHVSLIKLACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x723BF70", Offset = "0x723A770", VA = "0x18723BF70")]
		public int YLXFDFFRGEH(byte[] a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal interface WUXEWLOVPPB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CFBNIZPIHOV();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OBIMZGTUPZJ RXWGYFSWKVW();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		long TYJDFSNZAZS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class NewStreamEventArgs : EventArgs
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private WUXEWLOVPPB PacketProvider
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IgnoreStream
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xC19AA0", Offset = "0xC182A0", VA = "0x180C19AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x723BB40", Offset = "0x723A340", VA = "0x18723BB40")]
		public NewStreamEventArgs(WUXEWLOVPPB packetProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class WDIFPPTTXZM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class YEYROSQZXYB
		{
			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public int XHOCEIWZDEL
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public PageFlags XFZCZODLNKC
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300")]
				[CompilerGenerated]
				get
				{
					return default(PageFlags);
				}
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xB5F310", Offset = "0xB5DB10", VA = "0x180B5F310")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public long OMFAIQMQRYM
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xB5F2F0", Offset = "0xB5DAF0", VA = "0x180B5F2F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public int WOWSBBPZFSX
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0xB02F10", Offset = "0xB01710", VA = "0x180B02F10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public long HATULCDTTBS
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB2A0", VA = "0x180AACAA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public int[] KOHBWNNLOKT
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xAB1230", Offset = "0xAAFA30", VA = "0x180AB1230")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public bool VIWEVPFGAXR
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xADAAF0", Offset = "0xAD92F0", VA = "0x180ADAAF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xADAB00", Offset = "0xAD9300", VA = "0x180ADAB00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public bool NKAKPYFNJLL
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x1893680", Offset = "0x1891E80", VA = "0x181893680")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x1893940", Offset = "0x1892140", VA = "0x181893940")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YEYROSQZXYB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private WXDDURDOAPB SJQDTUTVVWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BufferedReadStream UFONQPJSWPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Dictionary<int, PacketReader> ZRETUTQLKYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<int> BHCWOAFDCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private long MAPISNAAQXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int PFPRNCZPJTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private byte[] RFTBVSTIOZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long VSYOHZQIZRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private long KFSAYWMFZSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[CompilerGenerated]
		private EventHandler<NewStreamEventArgs> PXITEYRLUUT;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int[] VMRIEARZBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x723DA70", Offset = "0x723C270", VA = "0x18723DA70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FVZJYZMZNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x723DB90", Offset = "0x723C390", VA = "0x18723DB90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x723ED40", Offset = "0x723D540", VA = "0x18723ED40")]
		public WDIFPPTTXZM(Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x723E960", Offset = "0x723D160", VA = "0x18723E960", Slot = "6")]
		public bool RUCBQSMBUXH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x723D960", Offset = "0x723C160", VA = "0x18723D960", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x723EC80", Offset = "0x723D480", VA = "0x18723EC80")]
		public WUXEWLOVPPB WZEDMYCCKOB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x723DF10", Offset = "0x723C710", VA = "0x18723DF10")]
		private YEYROSQZXYB OHKLICPNLKZ(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x723E9E0", Offset = "0x723D1E0", VA = "0x18723E9E0")]
		private YEYROSQZXYB SQSKDSWAZWD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x723DBC0", Offset = "0x723C3C0", VA = "0x18723DBC0")]
		private bool ODTNJSBRCOZ(YEYROSQZXYB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x723E450", Offset = "0x723CC50", VA = "0x18723E450")]
		private int PUQFYWMJOWO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x723DAD0", Offset = "0x723C2D0", VA = "0x18723DAD0")]
		internal void JOPXHXLBGGT(PacketReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x723EBC0", Offset = "0x723D3C0", VA = "0x18723EBC0")]
		internal int VZZAYONLPKR(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x723D850", Offset = "0x723C050", VA = "0x18723D850")]
		internal void DIETHZUOUWM(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x723E650", Offset = "0x723CE50", VA = "0x18723E650")]
		internal void PUQFYWMJOWO(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class WXDDURDOAPB
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static uint[] FXEKBGTICWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private uint SJQDTUTVVWC;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x723EFC0", Offset = "0x723D7C0", VA = "0x18723EFC0")]
		static WXDDURDOAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x16B7A60", Offset = "0x16B6260", VA = "0x1816B7A60")]
		public WXDDURDOAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x16B7A50", Offset = "0x16B6250", VA = "0x1816B7A50")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x723EF20", Offset = "0x723D720", VA = "0x18723EF20")]
		public void Update(int nextVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2445170", Offset = "0x2443970", VA = "0x182445170")]
		public bool CJHQAOJQAJF(uint a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class AIJHAIOULBB : OBIMZGTUPZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long FJMAGJSQJHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int UNUPUDJWWHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int PBIBSFPYBTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private AIJHAIOULBB JSWSCRZMQNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private AIJHAIOULBB PNPTFROHVXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private AIJHAIOULBB WHJOLINRSVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private WDIFPPTTXZM QYCOXUOUMBS;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal AIJHAIOULBB AZNBPSIKRMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAB3470", Offset = "0xAB1C70", VA = "0x180AB3470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAB3290", Offset = "0xAB1A90", VA = "0x180AB3290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		internal AIJHAIOULBB WONPWASPJSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAB3280", Offset = "0xAB1A80", VA = "0x180AB3280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB32A0", Offset = "0xAB1AA0", VA = "0x180AB32A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		internal bool QECCTOBRCHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7239700", Offset = "0x7237F00", VA = "0x187239700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x72396D0", Offset = "0x7237ED0", VA = "0x1872396D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal bool MPOFIMRDAFC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7239780", Offset = "0x7237F80", VA = "0x187239780")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7239570", Offset = "0x7237D70", VA = "0x187239570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7239790", Offset = "0x7237F90", VA = "0x187239790")]
		internal AIJHAIOULBB(WDIFPPTTXZM a, long b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x72395A0", Offset = "0x7237DA0", VA = "0x1872395A0")]
		internal void NJZPDMKKSAV(OBIMZGTUPZJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x72396A0", Offset = "0x7237EA0", VA = "0x1872396A0")]
		internal void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7239710", Offset = "0x7237F10", VA = "0x187239710", Slot = "4")]
		protected override int XAGEZDZPEHG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7239520", Offset = "0x7237D20", VA = "0x187239520", Slot = "5")]
		public override void Done()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DebuggerTypeProxy(typeof(WASFBMHYQOP))]
	internal class PacketReader : WUXEWLOVPPB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class WASFBMHYQOP
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private WDIFPPTTXZM UOBYSLTCTNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int LJPOCYAXBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool OGGNIUVFGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private AIJHAIOULBB UWTRAERLKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private AIJHAIOULBB QRKEQNXDMUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private AIJHAIOULBB HDVGBHGBFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private object BWUWDKFFEQD;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		internal bool CPKYYACNNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC2B730", Offset = "0xC29F30", VA = "0x180C2B730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int XHOCEIWZDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public long VIWALUJLQUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD40E30", Offset = "0xD3F630", VA = "0x180D40E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool FVZJYZMZNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x723CA60", Offset = "0x723B260", VA = "0x18723CA60", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x723CD80", Offset = "0x723B580", VA = "0x18723CD80")]
		internal PacketReader(WDIFPPTTXZM container, int streamSerial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x723C5B0", Offset = "0x723ADB0", VA = "0x18723C5B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x723C840", Offset = "0x723B040", VA = "0x18723C840")]
		internal void MMZMXTTHJKG(AIJHAIOULBB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x723C710", Offset = "0x723AF10", VA = "0x18723C710")]
		internal void GSWXGZBGBTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x723CAA0", Offset = "0x723B2A0", VA = "0x18723CAA0", Slot = "5")]
		public OBIMZGTUPZJ RXWGYFSWKVW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x723CBB0", Offset = "0x723B3B0", VA = "0x18723CBB0")]
		private AIJHAIOULBB ZARVRGWIVZK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x723CB10", Offset = "0x723B310", VA = "0x18723CB10")]
		internal void XOXDGHQZDVQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x723C820", Offset = "0x723B020", VA = "0x18723C820")]
		internal OBIMZGTUPZJ JPUZMEGVKZL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x723C570", Offset = "0x723AD70", VA = "0x18723C570", Slot = "4")]
		public int CFBNIZPIHOV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x723CAE0", Offset = "0x723B2E0", VA = "0x18723CAE0", Slot = "6")]
		public long TYJDFSNZAZS()
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
	public class TVUUGFZKETB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Stream UFONQPJSWPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly TFFKXUFXVGH KFILCCIPCQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private byte[] OQXZCQVILRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private WUXEWLOVPPB BYVDVMWGBPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool KEDWMBRPJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private WDIFPPTTXZM QYCOXUOUMBS;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool FVZJYZMZNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x723D4F0", Offset = "0x723BCF0", VA = "0x18723D4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private OpusTags CEUSHNLKFQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAACAD0", Offset = "0xAAB2D0", VA = "0x180AACAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool YMVDBTONNFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCC4030", Offset = "0xCC2830", VA = "0x180CC4030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private string WCIMIOZDOSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB2E0", VA = "0x180AACAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private long ZYCGTYORZLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD41150", Offset = "0xD3F950", VA = "0x180D41150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private long SVSDDBSSGRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xD71740", Offset = "0xD6FF40", VA = "0x180D71740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private long ALYBVNZBHEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD40A60", Offset = "0xD3F260", VA = "0x180D40A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private long FVBHCNHZLNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD71B80", Offset = "0xD70380", VA = "0x180D71B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x723D7A0", Offset = "0x723BFA0", VA = "0x18723D7A0")]
		public TVUUGFZKETB(TFFKXUFXVGH a, Stream b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x723CE40", Offset = "0x723B640", VA = "0x18723CE40")]
		public byte[] FRQWOBGQITS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x723CE80", Offset = "0x723B680", VA = "0x18723CE80")]
		private bool Initialize()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x723D520", Offset = "0x723BD20", VA = "0x18723D520")]
		private void ZYJVKWVYYFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x723CE20", Offset = "0x723B620", VA = "0x18723CE20")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class OpusTags
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string CIDKKJIULBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDictionary<string, string> NBZWLIPHEFP;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x723C4D0", Offset = "0x723ACD0", VA = "0x18723C4D0")]
		public OpusTags()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x723C210", Offset = "0x723AA10", VA = "0x18723C210")]
		internal static OpusTags OBIWDXSWSLQ(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class FQCLEFJHLON : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		internal class FGJWYOQPEZA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			internal Stream ZIRLVQYXIOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			internal object QWGLITOJQQL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal long TELGRDZZGQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			internal int VQEYHHUQFLZ;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7239F70", Offset = "0x7238770", VA = "0x187239F70")]
			public FGJWYOQPEZA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class DZQHETDFEIY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public byte[] HXZMNHCFLEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public long BSWEBNIQGSF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public int AXHFTEUJRLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int RUKIVMWUDFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public long NAAHRORQPQY;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public DZQHETDFEIY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<Stream, FGJWYOQPEZA> FGNMKSRCLGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private FGJWYOQPEZA QKVZLKJXLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int ULAXXZVAYZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private byte[] AFCNXRPGEGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long JDHSFEYRTLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int LHCGVLYZHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int YSIVFSTJELX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool DCQVRWOOVQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private long VPICHVQDHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private List<DZQHETDFEIY> PUAKKHKBQWG;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool QVLLZYDCNSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xADAB00", Offset = "0xAD9300", VA = "0x180ADAB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int QJHEEOCRCQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x723A090", Offset = "0x7238890", VA = "0x18723A090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public long BSWEBNIQGSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x723A080", Offset = "0x7238880", VA = "0x18723A080")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int KGSUFPGCCQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x125D5D0", Offset = "0x125BDD0", VA = "0x18125D5D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		internal long HURSWHQLZAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x723B4D0", Offset = "0x7239CD0", VA = "0x18723B4D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x723B710", Offset = "0x7239F10", VA = "0x18723B710")]
		internal FQCLEFJHLON(Stream a, int b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x723A290", Offset = "0x7238A90", VA = "0x18723A290", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x723B2E0", Offset = "0x7239AE0", VA = "0x18723B2E0")]
		public int YLXFDFFRGEH(long a, byte[] b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x723AD90", Offset = "0x7239590", VA = "0x18723AD90")]
		internal int RZDWHWTZJBH(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x723AA20", Offset = "0x7239220", VA = "0x18723AA20")]
		private int RVMMMEHNSYM(long a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x723B570", Offset = "0x7239D70", VA = "0x18723B570")]
		private void ZQBHXAHZBZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x723A7C0", Offset = "0x7238FC0", VA = "0x18723A7C0")]
		private void NEANYRLPSTD(long a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x723A3E0", Offset = "0x7238BE0", VA = "0x18723A3E0")]
		private void JAIPPQEEFZB(DZQHETDFEIY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x723AEF0", Offset = "0x72396F0", VA = "0x18723AEF0")]
		private void TIDUDOUVMKQ(long a, int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x723B090", Offset = "0x7239890", VA = "0x18723B090")]
		private void YERORUWNQFU(int a, bool b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x723A510", Offset = "0x7238D10", VA = "0x18723A510")]
		private int MXUZKTZZZTK(long a, int b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x723A890", Offset = "0x7239090", VA = "0x18723A890")]
		private int NEMOQWTAKWB(int a, long b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x723A470", Offset = "0x7238C70", VA = "0x18723A470")]
		private void LKCUGPLQGFV(int a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7239FF0", Offset = "0x72387F0", VA = "0x187239FF0")]
		public void CLUEEAVYWNS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x723AE60", Offset = "0x7239660", VA = "0x18723AE60")]
		private void TBSLMENOQBK()
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
