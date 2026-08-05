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
		private Stream RRYSGRSTIZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private CNYKBYEYNRT AQYKLMELYHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private long XUVNBFLRXFZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CloseBaseStream
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCEB8E0", Offset = "0xCEA8E0", VA = "0x180CEB8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCEB480", Offset = "0xCEA480", VA = "0x180CEB480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x73BF4E0", Offset = "0x73BE4E0", VA = "0x1873BF4E0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x73BF510", Offset = "0x73BE510", VA = "0x1873BF510", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73BF4B0", Offset = "0x73BE4B0", VA = "0x1873BF4B0")]
		public BufferedReadStream(Stream baseStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x73BF2C0", Offset = "0x73BE2C0", VA = "0x1873BF2C0")]
		public BufferedReadStream(Stream baseStream, int initialSize, int maxBufferSize, bool minimalRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x73BEE40", Offset = "0x73BDE40", VA = "0x1873BEE40", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public void KPUFZCKKBST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private void NMFKZCWEAJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public void SIUCTZDXNCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73BEDB0", Offset = "0x73BDDB0", VA = "0x1873BEDB0")]
		public void DTHGKYTSGZW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x73BEE90", Offset = "0x73BDE90", VA = "0x1873BEE90", Slot = "37")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x73BEFB0", Offset = "0x73BDFB0", VA = "0x1873BEFB0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x73BF060", Offset = "0x73BE060", VA = "0x1873BF060", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x73BF240", Offset = "0x73BE240", VA = "0x1873BF240", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x73BF280", Offset = "0x73BE280", VA = "0x1873BF280", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal abstract class WDHUXNGAJXB
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
		private ulong RZUXZJYLXOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int TRPCXSOXKRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int JRDIALKHTEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private byte DHWCPBOAOXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PacketFlags ZNUBQKXUXPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private long PSZDHTKRQRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int OLAJWHHFDIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int JOKJVBVVNFR;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool YDJCIILOSBP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x73C46D0", Offset = "0x73C36D0", VA = "0x1873C46D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x73C4980", Offset = "0x73C3980", VA = "0x1873C4980")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long CTWHUELDJFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAD32F0", Offset = "0xAD22F0", VA = "0x180AD32F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int KNJNUUEZHUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAD6FE0", Offset = "0xAD5FE0", VA = "0x180AD6FE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAD7820", Offset = "0xAD6820", VA = "0x180AD7820")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AVUNHBDZBFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x73C43D0", Offset = "0x73C33D0", VA = "0x1873C43D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x73C46A0", Offset = "0x73C36A0", VA = "0x1873C46A0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal int KGBBUTWSXBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB1B470", Offset = "0xB1A470", VA = "0x180B1B470")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1468170", Offset = "0x1467170", VA = "0x181468170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool TGNERZYUDDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x73C4950", Offset = "0x73C3950", VA = "0x1873C4950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x73C4540", Offset = "0x73C3540", VA = "0x1873C4540")]
		protected bool LMPMQAWWOOH(PacketFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x73C43E0", Offset = "0x73C33E0", VA = "0x1873C43E0")]
		protected void HJTPTUBESTJ(PacketFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x73C49B0", Offset = "0x73C39B0", VA = "0x1873C49B0")]
		protected WDHUXNGAJXB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract int PKKINHMSEVW();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
		public virtual void Done()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x73C4550", Offset = "0x73C3550", VA = "0x1873C4550")]
		public ulong LRRGGIJOPJN(int a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x73C4400", Offset = "0x73C3400", VA = "0x1873C4400")]
		public void KJGBQTNXJVO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x73C4690", Offset = "0x73C3690", VA = "0x1873C4690")]
		protected void MXAMFJKRBXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x73C46E0", Offset = "0x73C36E0", VA = "0x1873C46E0")]
		public int RPBXVQSXYXN(byte[] a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal interface QRZNDUPOYJV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EMHBSWSLXBL();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WDHUXNGAJXB DEXGHKCRURC();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		long TVHEOGPUSQQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class NewStreamEventArgs : EventArgs
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private QRZNDUPOYJV PacketProvider
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IgnoreStream
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xC35BD0", Offset = "0xC34BD0", VA = "0x180C35BD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x73C1FB0", Offset = "0x73C0FB0", VA = "0x1873C1FB0")]
		public NewStreamEventArgs(QRZNDUPOYJV packetProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class PLJKFIOCTOG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class ADLGANLQAON
		{
			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public int UGMXUFBUJFV
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xAD4F50", Offset = "0xAD3F50", VA = "0x180AD4F50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public PageFlags QMZZNXBUBHE
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xB7CE40", Offset = "0xB7BE40", VA = "0x180B7CE40")]
				[CompilerGenerated]
				get
				{
					return default(PageFlags);
				}
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xB7CC80", Offset = "0xB7BC80", VA = "0x180B7CC80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public long JMNNESDBIFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xB7CD80", Offset = "0xB7BD80", VA = "0x180B7CD80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public int CYCJMHXUEIL
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0xB23EE0", Offset = "0xB22EE0", VA = "0x180B23EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public long XWOCROUFWBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0xAD32F0", Offset = "0xAD22F0", VA = "0x180AD32F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public int[] TJJJKEJGRYP
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACF5C0", VA = "0x180AD05C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public bool VTZYQHYKKFB
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xAF8B30", Offset = "0xAF7B30", VA = "0x180AF8B30")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAF8B40", Offset = "0xAF7B40", VA = "0x180AF8B40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public bool YDJCIILOSBP
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x18C2170", Offset = "0x18C1170", VA = "0x1818C2170")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xDDBDE0", Offset = "0xDDADE0", VA = "0x180DDBDE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ADLGANLQAON()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private GNOPSHSMPLR INRNYVEQPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BufferedReadStream YAKCFZHPOIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Dictionary<int, PacketReader> IFLEAECZCOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<int> GSXDNRZPAWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private long FZKKKZKMQNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int VULTFZQQCES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private byte[] OZLOAVGMSYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long VBUZEMLYUVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private long TMGECIMDBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[CompilerGenerated]
		private EventHandler<NewStreamEventArgs> FPVRZFIHVFZ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int[] KSUYYGIYKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x73C30B0", Offset = "0x73C20B0", VA = "0x1873C30B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool VNKHYFNDALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x73C2BB0", Offset = "0x73C1BB0", VA = "0x1873C2BB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x73C38C0", Offset = "0x73C28C0", VA = "0x1873C38C0")]
		public PLJKFIOCTOG(Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x73C24E0", Offset = "0x73C14E0", VA = "0x1873C24E0", Slot = "6")]
		public bool GRLRHMOCTOZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x73C23D0", Offset = "0x73C13D0", VA = "0x1873C23D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x73C3110", Offset = "0x73C2110", VA = "0x1873C3110")]
		public QRZNDUPOYJV VROFSBLVYNP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x73C2560", Offset = "0x73C1560", VA = "0x1873C2560")]
		private ADLGANLQAON GYHVYBWZSQV(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x73C36E0", Offset = "0x73C26E0", VA = "0x1873C36E0")]
		private ADLGANLQAON XVUWXHDSJHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x73C2D60", Offset = "0x73C1D60", VA = "0x1873C2D60")]
		private bool PXCQLTHUGWF(ADLGANLQAON a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x73C31D0", Offset = "0x73C21D0", VA = "0x1873C31D0")]
		private int XKZAAZGGPNI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x73C2CA0", Offset = "0x73C1CA0", VA = "0x1873C2CA0")]
		internal void PNYSMHQOYRJ(PacketReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x73C2BE0", Offset = "0x73C1BE0", VA = "0x1873C2BE0")]
		internal int KSZJXMJVJSV(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x73C2AA0", Offset = "0x73C1AA0", VA = "0x1873C2AA0")]
		internal void HOVOBAKFYME(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x73C33D0", Offset = "0x73C23D0", VA = "0x1873C33D0")]
		internal void XKZAAZGGPNI(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class GNOPSHSMPLR
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static uint[] GMMJPWWWFXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private uint INRNYVEQPAC;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x73C1400", Offset = "0x73C0400", VA = "0x1873C1400")]
		static GNOPSHSMPLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x16E2050", Offset = "0x16E1050", VA = "0x1816E2050")]
		public GNOPSHSMPLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x16E2040", Offset = "0x16E1040", VA = "0x1816E2040")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x73C1360", Offset = "0x73C0360", VA = "0x1873C1360")]
		public void Update(int nextVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2487D90", Offset = "0x2486D90", VA = "0x182487D90")]
		public bool KWBXWRPEBWT(uint a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class FXCBGADJHLR : WDHUXNGAJXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long EEEOFSJBTDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int OLAJWHHFDIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int RFUDGBTQBYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private FXCBGADJHLR AMMGOSATNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private FXCBGADJHLR VDYEXCIXRCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private FXCBGADJHLR IKUDOZSKGVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PLJKFIOCTOG NCWMOJDXJQE;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal FXCBGADJHLR CQNORJGDYTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xACDCE0", Offset = "0xACCCE0", VA = "0x180ACDCE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xACDF50", Offset = "0xACCF50", VA = "0x180ACDF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		internal FXCBGADJHLR VQVVSGLWUSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xACDCF0", Offset = "0xACCCF0", VA = "0x180ACDCF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xACDF80", Offset = "0xACCF80", VA = "0x180ACDF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		internal bool TYGLWRPEHVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x73C1210", Offset = "0x73C0210", VA = "0x1873C1210")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x73C1220", Offset = "0x73C0220", VA = "0x1873C1220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal bool HXOXVDYMOGU
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x73C12F0", Offset = "0x73C02F0", VA = "0x1873C12F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x73C11E0", Offset = "0x73C01E0", VA = "0x1873C11E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x73C1300", Offset = "0x73C0300", VA = "0x1873C1300")]
		internal FXCBGADJHLR(PLJKFIOCTOG a, long b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x73C1080", Offset = "0x73C0080", VA = "0x1873C1080")]
		internal void DIYFJOGUGZP(WDHUXNGAJXB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x73C12C0", Offset = "0x73C02C0", VA = "0x1873C12C0")]
		internal void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x73C1250", Offset = "0x73C0250", VA = "0x1873C1250", Slot = "4")]
		protected override int PKKINHMSEVW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x73C1190", Offset = "0x73C0190", VA = "0x1873C1190", Slot = "5")]
		public override void Done()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DebuggerTypeProxy(typeof(DISUWDAIJQT))]
	internal class PacketReader : QRZNDUPOYJV, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class DISUWDAIJQT
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private PLJKFIOCTOG APKLCJODPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int WUTZCMBLQPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool YJWYSOKIMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private FXCBGADJHLR OVZYSPINAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private FXCBGADJHLR DBIZAOPMRFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private FXCBGADJHLR XOPOROLEKDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private object MTJPUHTTYUX;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		internal bool ALHQBMZMFEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC3DC90", Offset = "0xC3CC90", VA = "0x180C3DC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int UGMXUFBUJFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public long IXKYTLCPMAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD77AB0", Offset = "0xD76AB0", VA = "0x180D77AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool VNKHYFNDALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x73C3E30", Offset = "0x73C2E30", VA = "0x1873C3E30", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x73C4330", Offset = "0x73C3330", VA = "0x1873C4330")]
		internal PacketReader(PLJKFIOCTOG container, int streamSerial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x73C3B80", Offset = "0x73C2B80", VA = "0x1873C3B80", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x73C4110", Offset = "0x73C3110", VA = "0x1873C4110")]
		internal void ZZBWKDBBGLM(FXCBGADJHLR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x73C3D20", Offset = "0x73C2D20", VA = "0x1873C3D20")]
		internal void JGYCFBPORIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x73C3B40", Offset = "0x73C2B40", VA = "0x1873C3B40", Slot = "5")]
		public WDHUXNGAJXB DEXGHKCRURC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x73C3F40", Offset = "0x73C2F40", VA = "0x1873C3F40")]
		private FXCBGADJHLR YJOBIDLEYAU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x73C3EA0", Offset = "0x73C2EA0", VA = "0x1873C3EA0")]
		internal void XRKJWZKTSCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x73C3B20", Offset = "0x73C2B20", VA = "0x1873C3B20")]
		internal WDHUXNGAJXB BNUAIAHZJAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x73C3CE0", Offset = "0x73C2CE0", VA = "0x1873C3CE0", Slot = "4")]
		public int EMHBSWSLXBL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x73C3E70", Offset = "0x73C2E70", VA = "0x1873C3E70", Slot = "6")]
		public long TVHEOGPUSQQ()
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
	public class NSQJCZJRBZN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Stream YAKCFZHPOIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly VOBAGLCULQH EANTWLQALZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private byte[] VNBHRBZKUVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private QRZNDUPOYJV MOQAUZVHLKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool EPKLUBYKQWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PLJKFIOCTOG NCWMOJDXJQE;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool VNKHYFNDALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x73C1E90", Offset = "0x73C0E90", VA = "0x1873C1E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private OpusTags XBVYIYICWSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F10", Offset = "0xAD1F10", VA = "0x180AD2F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool AORQVJCJEVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCE5950", Offset = "0xCE4950", VA = "0x180CE5950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private string EXHFISDTFXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD22E0", VA = "0x180AD32E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private long CTWHUELDJFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD77810", Offset = "0xD76810", VA = "0x180D77810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private long PEVNTXCFJCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xD8FC00", Offset = "0xD8EC00", VA = "0x180D8FC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private long ROMYRKGKLML
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD76F50", Offset = "0xD75F50", VA = "0x180D76F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private long ZKXDIGSQSDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD90130", Offset = "0xD8F130", VA = "0x180D90130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x73C1F00", Offset = "0x73C0F00", VA = "0x1873C1F00")]
		public NSQJCZJRBZN(VOBAGLCULQH a, Stream b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x73C1EC0", Offset = "0x73C0EC0", VA = "0x1873C1EC0")]
		public byte[] TBGKWWMQGGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x73C1810", Offset = "0x73C0810", VA = "0x1873C1810")]
		private bool Initialize()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x73C1590", Offset = "0x73C0590", VA = "0x1873C1590")]
		private void IPCTBVCKKKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x73C1570", Offset = "0x73C0570", VA = "0x1873C1570")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class OpusTags
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string YQUIZATJBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDictionary<string, string> CVCCHOSEPHT;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x73C2330", Offset = "0x73C1330", VA = "0x1873C2330")]
		public OpusTags()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x73C2070", Offset = "0x73C1070", VA = "0x1873C2070")]
		internal static OpusTags PBYZADGDJYG(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class CNYKBYEYNRT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		internal class PWHTZSIESVU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			internal Stream LJEYUVVYGPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			internal object ICPFCPWGTVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal long SEWWGLLTWUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			internal int SMUAWVQOGGT;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x73C3AA0", Offset = "0x73C2AA0", VA = "0x1873C3AA0")]
			public PWHTZSIESVU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class OTRUVGGPRXK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public byte[] ZTFHEQUXQOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public long XQMHFMBBLXT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public int IPCXLVWHJHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int KLCEFXCEGVA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public long JKOSSADFOEA;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public OTRUVGGPRXK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<Stream, PWHTZSIESVU> IIYQFITAPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private PWHTZSIESVU KRGTHWRAIYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int XBGYSLGDCOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private byte[] OMBJDAIUITS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long OMXCVNWADWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int GNTJJJEASQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int ACVJTGTOEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool MVJWLPACVFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private long CIDNYUOBKUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private List<OTRUVGGPRXK> FPMLDBOFTCW;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool RXNLIBDHXPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAF8B40", Offset = "0xAF7B40", VA = "0x180AF8B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int FGVXRFAZLBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x73C0170", Offset = "0x73BF170", VA = "0x1873C0170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public long XQMHFMBBLXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x73BF530", Offset = "0x73BE530", VA = "0x1873BF530")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int KNJNUUEZHUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1272520", Offset = "0x1271520", VA = "0x181272520")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		internal long BCVJUWUJUZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x73C0A10", Offset = "0x73BFA10", VA = "0x1873C0A10")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x73C0C50", Offset = "0x73BFC50", VA = "0x1873C0C50")]
		internal CNYKBYEYNRT(Stream a, int b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x73BF5D0", Offset = "0x73BE5D0", VA = "0x1873BF5D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x73C0750", Offset = "0x73BF750", VA = "0x1873C0750")]
		public int RPBXVQSXYXN(long a, byte[] b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x73BF8B0", Offset = "0x73BE8B0", VA = "0x1873BF8B0")]
		internal int FAOGFZJFLMN(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x73BFE00", Offset = "0x73BEE00", VA = "0x1873BFE00")]
		private int LPLSQPBMUOE(long a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x73C0AB0", Offset = "0x73BFAB0", VA = "0x1873C0AB0")]
		private void ZFZYGOJDFTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x73C0940", Offset = "0x73BF940", VA = "0x1873C0940")]
		private void TTBEKPQYSFL(long a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x73BFD70", Offset = "0x73BED70", VA = "0x1873BFD70")]
		private void JRXKGTUKLEX(OTRUVGGPRXK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x73BF980", Offset = "0x73BE980", VA = "0x1873BF980")]
		private void GTTDWLCEMFO(long a, int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x73BFB20", Offset = "0x73BEB20", VA = "0x1873BFB20")]
		private void GZWWRVWORCK(int a, bool b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x73C0410", Offset = "0x73BF410", VA = "0x1873C0410")]
		private int OHNSCKPMZTW(long a, int b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x73BF720", Offset = "0x73BE720", VA = "0x1873BF720")]
		private int EIGYUQYOLEF(int a, long b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x73C0370", Offset = "0x73BF370", VA = "0x1873C0370")]
		private void NFXWGXWIMGH(int a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x73BF540", Offset = "0x73BE540", VA = "0x1873BF540")]
		public void DTHGKYTSGZW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x73C06C0", Offset = "0x73BF6C0", VA = "0x1873C06C0")]
		private void QQRMVLDICLS()
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
