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
		private Stream RBOGKGSJFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private TPWOPLLCOBF YBAQHLTWESY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private long SPVVKHTYILX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CloseBaseStream
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xF85FC0", Offset = "0xF849C0", VA = "0x180F85FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xF85920", Offset = "0xF84320", VA = "0x180F85920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8892300", Offset = "0x8890D00", VA = "0x188892300", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8892330", Offset = "0x8890D30", VA = "0x188892330", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88922D0", Offset = "0x8890CD0", VA = "0x1888922D0")]
		public BufferedReadStream(Stream baseStream)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88920E0", Offset = "0x8890AE0", VA = "0x1888920E0")]
		public BufferedReadStream(Stream baseStream, int initialSize, int maxBufferSize, bool minimalRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8891BD0", Offset = "0x88905D0", VA = "0x188891BD0", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		public void ZARNYZRHRXD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private void SYAKVOAUALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		public void SKUUKWEJEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8891C20", Offset = "0x8890620", VA = "0x188891C20")]
		public void RGTYYYYPYEC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8891CB0", Offset = "0x88906B0", VA = "0x188891CB0", Slot = "37")]
		public override int ReadByte()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8891DD0", Offset = "0x88907D0", VA = "0x188891DD0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8891E80", Offset = "0x8890880", VA = "0x188891E80", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8892060", Offset = "0x8890A60", VA = "0x188892060", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88920A0", Offset = "0x8890AA0", VA = "0x1888920A0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal abstract class THCLYCDTIHX
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
		private ulong XDQIFIFLKGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int YRSLZKFDKXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int AZGNAHTYROC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private byte AITHQAYEVOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PacketFlags CRTVTLWXTAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private long APYHYUDGXTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int DCYMLEVPMGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int HDNTSBPVBEB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ZOPODJWHSIP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8895000", Offset = "0x8893A00", VA = "0x188895000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8894A40", Offset = "0x8893440", VA = "0x188894A40")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long YMMGEDDKAFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int ORLIDGXUSPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD1B020", Offset = "0xD19A20", VA = "0x180D1B020")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ATDXERETROX
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8894BF0", Offset = "0x88935F0", VA = "0x188894BF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8894FD0", Offset = "0x88939D0", VA = "0x188894FD0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		internal int IZEUVKZPCHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD60890", Offset = "0xD5F290", VA = "0x180D60890")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1708EF0", Offset = "0x17078F0", VA = "0x181708EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool YBBHEDPVTVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8894A80", Offset = "0x8893480", VA = "0x188894A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8894A70", Offset = "0x8893470", VA = "0x188894A70")]
		protected bool FWQQFIPPCXP(PacketFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8894D40", Offset = "0x8893740", VA = "0x188894D40")]
		protected void VWUHQOMIPND(PacketFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8895020", Offset = "0x8893A20", VA = "0x188895020")]
		protected THCLYCDTIHX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract int RVSPGYTHDZQ();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
		public virtual void Done()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8894AB0", Offset = "0x88934B0", VA = "0x188894AB0")]
		public ulong LEIEORIXMQJ(int a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8894C00", Offset = "0x8893600", VA = "0x188894C00")]
		public void VCCYYYMWQZM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8895010", Offset = "0x8893A10", VA = "0x188895010")]
		protected void ZTTAOUAOGTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8894D60", Offset = "0x8893760", VA = "0x188894D60")]
		public int YHIVLMQLZBD(byte[] a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal interface HHQAZLHFXDD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ORWQMBSKEKL();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		THCLYCDTIHX SIMIWZICJLY();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		long ZXCLCBCSZKK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class NewStreamEventArgs : EventArgs
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private HHQAZLHFXDD PacketProvider
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IgnoreStream
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8893D70", Offset = "0x8892770", VA = "0x188893D70")]
		public NewStreamEventArgs(HHQAZLHFXDD packetProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class NGIWEYFJZQE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class VJKHFSYAWBR
		{
			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public int HRTQZLEWETH
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public PageFlags EYUTOEXCTCQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0")]
				[CompilerGenerated]
				get
				{
					return default(PageFlags);
				}
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public long NYHPSMRYIBE
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public int OTVUGVGZSCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public long UOOMIHJVRFY
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public int[] NNVBXJAZWUV
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public bool WZZFDNDWQAR
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xD3D030", Offset = "0xD3BA30", VA = "0x180D3D030")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xD3D040", Offset = "0xD3BA40", VA = "0x180D3D040")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public bool ZOPODJWHSIP
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x1B9BC60", Offset = "0x1B9A660", VA = "0x181B9BC60")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x10511F0", Offset = "0x104FBF0", VA = "0x1810511F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public VJKHFSYAWBR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private ZCYWIFGYVLD YZYJMWCQMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private BufferedReadStream EILIUIHYXUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Dictionary<int, PacketReader> VYZGFXXPLXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<int> OKDOFHFHUGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private long YMSLIRFZRZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int XTQJHCZOHWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private byte[] ZWSTXSVZJMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private long FQBDVNNIYXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private long HMDMBDJTCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[CompilerGenerated]
		private EventHandler<NewStreamEventArgs> ZPJWHBDXNSV;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int[] SEDERPSVSYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8893A70", Offset = "0x8892470", VA = "0x188893A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool YTHHMASVWJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x88927B0", Offset = "0x88911B0", VA = "0x1888927B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8893B90", Offset = "0x8892590", VA = "0x188893B90")]
		public NGIWEYFJZQE(Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8893040", Offset = "0x8891A40", VA = "0x188893040", Slot = "6")]
		public bool RKCBVVMJUOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88926A0", Offset = "0x88910A0", VA = "0x1888926A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88930C0", Offset = "0x8891AC0", VA = "0x1888930C0")]
		public HHQAZLHFXDD RUVWCUPCQOH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8893420", Offset = "0x8891E20", VA = "0x188893420")]
		private VJKHFSYAWBR WEYEOHVEPOL(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8893180", Offset = "0x8891B80", VA = "0x188893180")]
		private VJKHFSYAWBR TJCEDIXCEEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88927E0", Offset = "0x88911E0", VA = "0x1888927E0")]
		private bool OJUAVXYJDTJ(VJKHFSYAWBR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8892B30", Offset = "0x8891530", VA = "0x188892B30")]
		private int QSDXHKSLPQM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8893360", Offset = "0x8891D60", VA = "0x188893360")]
		internal void VVGFIKCALJX(PacketReader a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8893AD0", Offset = "0x88924D0", VA = "0x188893AD0")]
		internal int ZKPVLVTOLYD(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8893960", Offset = "0x8892360", VA = "0x188893960")]
		internal void WITGSJSJBRI(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8892D30", Offset = "0x8891730", VA = "0x188892D30")]
		internal void QSDXHKSLPQM(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class ZCYWIFGYVLD
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static uint[] GJCOZUEEDQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private uint YZYJMWCQMKM;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88976A0", Offset = "0x88960A0", VA = "0x1888976A0")]
		static ZCYWIFGYVLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x197C450", Offset = "0x197AE50", VA = "0x18197C450")]
		public ZCYWIFGYVLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x197C440", Offset = "0x197AE40", VA = "0x18197C440")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x88975F0", Offset = "0x8895FF0", VA = "0x1888975F0")]
		public void Update(int nextVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2753450", Offset = "0x2751E50", VA = "0x182753450")]
		public bool XRLEWILRWDT(uint a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class HBHRAUFSSZT : THCLYCDTIHX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long ATNAWAPAWLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int DCYMLEVPMGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int UQBLXQQCIVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private HBHRAUFSSZT UKDEXWTYWZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HBHRAUFSSZT HFVOBYIQQJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private HBHRAUFSSZT WMPFATUQOPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private NGIWEYFJZQE VUCKBRSYFIG;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal HBHRAUFSSZT AZIENLMDEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		internal HBHRAUFSSZT YRLUVNILUME
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		internal bool EAGDFKZIDKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8892380", Offset = "0x8890D80", VA = "0x188892380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x88924F0", Offset = "0x8890EF0", VA = "0x1888924F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal bool ACIZARIOLBA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x88924E0", Offset = "0x8890EE0", VA = "0x1888924E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8892350", Offset = "0x8890D50", VA = "0x188892350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88925C0", Offset = "0x8890FC0", VA = "0x1888925C0")]
		internal HBHRAUFSSZT(NGIWEYFJZQE a, long b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88923E0", Offset = "0x8890DE0", VA = "0x1888923E0")]
		internal void IXPZFCOAEAL(THCLYCDTIHX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8892590", Offset = "0x8890F90", VA = "0x188892590")]
		internal void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8892520", Offset = "0x8890F20", VA = "0x188892520", Slot = "4")]
		protected override int RVSPGYTHDZQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8892390", Offset = "0x8890D90", VA = "0x188892390", Slot = "5")]
		public override void Done()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DebuggerTypeProxy(typeof(SONTDEAQEXH))]
	internal class PacketReader : HHQAZLHFXDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class SONTDEAQEXH
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private NGIWEYFJZQE QYVTCLXHXOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int EJTURLZTKRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool ZOHLIPGOZBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private HBHRAUFSSZT PBLFOSHXIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private HBHRAUFSSZT QRIOXCUPKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HBHRAUFSSZT VNQZNJFUUYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private object PFGUILTIRMZ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		internal bool CKNIRUWXIUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xEAE2D0", Offset = "0xEACCD0", VA = "0x180EAE2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int HRTQZLEWETH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public long BBRSPAHSIMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool YTHHMASVWJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x88942F0", Offset = "0x8892CF0", VA = "0x1888942F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88949A0", Offset = "0x88933A0", VA = "0x1888949A0")]
		internal PacketReader(NGIWEYFJZQE container, int streamSerial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8894190", Offset = "0x8892B90", VA = "0x188894190", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8894540", Offset = "0x8892F40", VA = "0x188894540")]
		internal void QDIEDQJSUCU(HBHRAUFSSZT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8894840", Offset = "0x8893240", VA = "0x188894840")]
		internal void THBIINIIPYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8894760", Offset = "0x8893160", VA = "0x188894760", Slot = "5")]
		public THCLYCDTIHX SIMIWZICJLY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8894370", Offset = "0x8892D70", VA = "0x188894370")]
		private HBHRAUFSSZT OVUQROFTQWG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x88947A0", Offset = "0x88931A0", VA = "0x1888947A0")]
		internal void SLWWOGIOKBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8894950", Offset = "0x8893350", VA = "0x188894950")]
		internal THCLYCDTIHX ZDPVJSJPDWX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8894330", Offset = "0x8892D30", VA = "0x188894330", Slot = "4")]
		public int ORWQMBSKEKL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8894970", Offset = "0x8893370", VA = "0x188894970", Slot = "6")]
		public long ZXCLCBCSZKK()
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
	public class ZCGIALNGBFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Stream EILIUIHYXUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly LVVRNPEZPXH TDRESKXKRKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private byte[] BGJQJYBJMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private HHQAZLHFXDD HDKCVWQDXNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool ENVDTRQFZRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private NGIWEYFJZQE VUCKBRSYFIG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool YTHHMASVWJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8897250", Offset = "0x8895C50", VA = "0x188897250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private OpusTags GNXPNZZUTLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool IRXVNMFYKHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xF65C20", Offset = "0xF64620", VA = "0x180F65C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private string FSQBMTEQSCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private long YMMGEDDKAFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xFFBF90", Offset = "0xFFA990", VA = "0x180FFBF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private long XHPWJDSHDSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1016AA0", Offset = "0x10154A0", VA = "0x181016AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private long LQIVDXBNBHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xFFB590", Offset = "0xFF9F90", VA = "0x180FFB590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private long LRYKQLKEDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1016E40", Offset = "0x1015840", VA = "0x181016E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8897540", Offset = "0x8895F40", VA = "0x188897540")]
		public ZCGIALNGBFD(LVVRNPEZPXH a, Stream b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8897500", Offset = "0x8895F00", VA = "0x188897500")]
		public byte[] VWATDWEOKKW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8896BE0", Offset = "0x88955E0", VA = "0x188896BE0")]
		private bool Initialize()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8897280", Offset = "0x8895C80", VA = "0x188897280")]
		private void PRLMHMQKOJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8896BC0", Offset = "0x88955C0", VA = "0x188896BC0")]
		public void Close()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class OpusTags
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private string WCTKMFWPRWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDictionary<string, string> QCRQSLBIWIH;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x88940F0", Offset = "0x8892AF0", VA = "0x1888940F0")]
		public OpusTags()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8893E30", Offset = "0x8892830", VA = "0x188893E30")]
		internal static OpusTags RLLNHOKYMJO(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class TPWOPLLCOBF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		internal class JOVFCZZJEGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			internal Stream ZXBYZQEQXGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			internal object UBSHPZDOVTT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal long GBEXFALKWWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			internal int MJQODOOPRDD;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8892620", Offset = "0x8891020", VA = "0x188892620")]
			public JOVFCZZJEGU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class OBJDQKQMADE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public byte[] SVMFSVQCHIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public long JVLZOKZRUYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public int YTMSCNEQASK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int NHOLIKIEQFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public long HKXOEJCJNRY;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public OBJDQKQMADE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<Stream, JOVFCZZJEGU> BJRORRRLFTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private JOVFCZZJEGU PDSWNCRUQLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int WKWNBTTYISJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private byte[] VZKTTPGNGSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long EBJINZPOJZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int NLUKTVTVTVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int VDIPYWYNSFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool AQXUBWCJNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private long SGUHPVIWJYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private List<OBJDQKQMADE> BLJNFXMTJWU;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool WOTUMOPTAEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xD3D040", Offset = "0xD3BA40", VA = "0x180D3D040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int DLHONZHCTHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8895050", Offset = "0x8893A50", VA = "0x188895050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public long JVLZOKZRUYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x88953E0", Offset = "0x8893DE0", VA = "0x1888953E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int ORLIDGXUSPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15203D0", Offset = "0x151EDD0", VA = "0x1815203D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		internal long KTMSKORZRLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8895960", Offset = "0x8894360", VA = "0x188895960")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8896780", Offset = "0x8895180", VA = "0x188896780")]
		internal TPWOPLLCOBF(Stream a, int b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8895490", Offset = "0x8893E90", VA = "0x188895490", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8896500", Offset = "0x8894F00", VA = "0x188896500")]
		public int YHIVLMQLZBD(long a, byte[] b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8895890", Offset = "0x8894290", VA = "0x188895890")]
		internal int HZUHYQXJVSD(long a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8895B20", Offset = "0x8894520", VA = "0x188895B20")]
		private int MRGWPCWIMTE(long a, int b, bool c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8895A00", Offset = "0x8894400", VA = "0x188895A00")]
		private void MFVSMREJCOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8895E90", Offset = "0x8894890", VA = "0x188895E90")]
		private void PUIEZAFKMTN(long a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8895F60", Offset = "0x8894960", VA = "0x188895F60")]
		private void PVKGWPZYAUN(OBJDQKQMADE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8896360", Offset = "0x8894D60", VA = "0x188896360")]
		private void XUJFLOKAQJQ(long a, int b, [Out] int c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8896110", Offset = "0x8894B10", VA = "0x188896110")]
		private void XKLLULGPQDK(int a, bool b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x88955E0", Offset = "0x8893FE0", VA = "0x1888955E0")]
		private int ERAULJYXEYG(long a, int b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8895250", Offset = "0x8893C50", VA = "0x188895250")]
		private int BVLCSWASFOL(int a, long b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x88953F0", Offset = "0x8893DF0", VA = "0x1888953F0")]
		private void DKWBURNATNT(int a, int b, long c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8896080", Offset = "0x8894A80", VA = "0x188896080")]
		public void RGTYYYYPYEC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8895FF0", Offset = "0x88949F0", VA = "0x188895FF0")]
		private void QWWTQHNTFJU()
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
