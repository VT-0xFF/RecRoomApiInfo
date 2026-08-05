using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ANCGMDIPPEP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static FileDescriptor IJFLPFGIPEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FileDescriptor IOFJMBMLJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x62370A0", Offset = "0x62362A0", VA = "0x1862370A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62370F0", Offset = "0x62362F0", VA = "0x1862370F0")]
	static ANCGMDIPPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class DDCPMGKNPHO : IMessage<DDCPMGKNPHO>, IMessage, IEquatable<DDCPMGKNPHO>, IDeepCloneable<DDCPMGKNPHO>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DebuggerNonUserCode]
	public static class CLLCPNGMLHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum NDBKMPKBJNB
		{
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			[OriginalName("V0_PreObjectModel")]
			V0PreObjectModel = 0,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			[OriginalName("V1_ObjectModelHierarchy")]
			V1ObjectModelHierarchy = 1,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			[OriginalName("V2_ObjectModelHierarchy")]
			V2ObjectModelHierarchy = 2,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			[OriginalName("V3_Entities_050")]
			V3Entities050 = 3,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			[OriginalName("V4_Entities_050_Compressed")]
			V4Entities050Compressed = 4,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			[OriginalName("OldestCompatibleVersion", PreferredAlias = false)]
			OldestCompatibleVersion = 2,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			[OriginalName("LatestVersion", PreferredAlias = false)]
			LatestVersion = 4
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly MessageParser<DDCPMGKNPHO> FFBMCONBGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CLLCPNGMLHE.NDBKMPKBJNB LCFALHJIKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ByteString NOHKFLGENHM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[DebuggerNonUserCode]
	public static MessageParser<DDCPMGKNPHO> GHGFFPGGAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62387F0", Offset = "0x62379F0", VA = "0x1862387F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[DebuggerNonUserCode]
	public static MessageDescriptor IOFJMBMLJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62388C0", Offset = "0x6237AC0", VA = "0x1862388C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[DebuggerNonUserCode]
	private MessageDescriptor DKPHOEEPCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6238D90", Offset = "0x6237F90", VA = "0x186238D90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[DebuggerNonUserCode]
	public CLLCPNGMLHE.NDBKMPKBJNB DFFLBILJIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180")]
		get
		{
			return default(CLLCPNGMLHE.NDBKMPKBJNB);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF590", Offset = "0x7BE790", VA = "0x1807BF590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[DebuggerNonUserCode]
	public ByteString NFLIBGAKCBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6238A40", Offset = "0x6237C40", VA = "0x186238A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6238CA0", Offset = "0x6237EA0", VA = "0x186238CA0")]
	[DebuggerNonUserCode]
	public DDCPMGKNPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6238D40", Offset = "0x6237F40", VA = "0x186238D40")]
	[DebuggerNonUserCode]
	public DDCPMGKNPHO(DDCPMGKNPHO NFMPGFPPFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6238600", Offset = "0x6237800", VA = "0x186238600", Slot = "10")]
	[DebuggerNonUserCode]
	public DDCPMGKNPHO Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6238680", Offset = "0x6237880", VA = "0x186238680", Slot = "0")]
	[DebuggerNonUserCode]
	public override bool Equals(object NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6238760", Offset = "0x6237960", VA = "0x186238760", Slot = "9")]
	[DebuggerNonUserCode]
	public bool Equals(DDCPMGKNPHO NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6238840", Offset = "0x6237A40", VA = "0x186238840", Slot = "2")]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6238AB0", Offset = "0x6237CB0", VA = "0x186238AB0", Slot = "3")]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6238B00", Offset = "0x6237D00", VA = "0x186238B00", Slot = "6")]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream DHLDOFLJLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6238550", Offset = "0x6237750", VA = "0x186238550", Slot = "7")]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6238970", Offset = "0x6237B70", VA = "0x186238970", Slot = "4")]
	[DebuggerNonUserCode]
	public void MergeFrom(DDCPMGKNPHO NFMPGFPPFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62389D0", Offset = "0x6237BD0", VA = "0x1862389D0", Slot = "5")]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream NKIKIMMJFMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GOPPJCOIJFA
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static FileDescriptor IJFLPFGIPEI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static FileDescriptor IOFJMBMLJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6238E70", Offset = "0x6238070", VA = "0x186238E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6238EC0", Offset = "0x62380C0", VA = "0x186238EC0")]
	static GOPPJCOIJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class DCLGADHHAMB : IMessage<DCLGADHHAMB>, IMessage, IEquatable<DCLGADHHAMB>, IDeepCloneable<DCLGADHHAMB>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DebuggerNonUserCode]
	public static class EAFDHPFHMIG
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum PJEGCFEBPNF
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			[OriginalName("V0_PreObjectModel")]
			V0PreObjectModel = 0,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			[OriginalName("V1_ObjectModelHierarchy")]
			V1ObjectModelHierarchy = 1,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			[OriginalName("V2_ObjectModelHierarchy")]
			V2ObjectModelHierarchy = 2,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[OriginalName("OldestCompatibleVersion", PreferredAlias = false)]
			OldestCompatibleVersion = 2,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[OriginalName("LatestVersion", PreferredAlias = false)]
			LatestVersion = 2
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class AEPGIIHNMDD : IMessage<AEPGIIHNMDD>, IMessage, IEquatable<AEPGIIHNMDD>, IDeepCloneable<AEPGIIHNMDD>
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private static readonly MessageParser<AEPGIIHNMDD> FFBMCONBGNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private ulong NACMJJEDPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private uint LCFALHJIKBF;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			[DebuggerNonUserCode]
			public static MessageParser<AEPGIIHNMDD> GHGFFPGGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x6236C00", Offset = "0x6235E00", VA = "0x186236C00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			[DebuggerNonUserCode]
			public static MessageDescriptor IOFJMBMLJOH
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x6236CC0", Offset = "0x6235EC0", VA = "0x186236CC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			[DebuggerNonUserCode]
			private MessageDescriptor DKPHOEEPCDB
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x6236FF0", Offset = "0x62361F0", VA = "0x186236FF0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			[DebuggerNonUserCode]
			public ulong MJDFEADBLAG
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
				get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x13307D0", Offset = "0x132F9D0", VA = "0x1813307D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			[DebuggerNonUserCode]
			public uint DFFLBILJIAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x7C0510", Offset = "0x7BF710", VA = "0x1807C0510")]
				get
				{
					return default(uint);
				}
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x7C0520", Offset = "0x7BF720", VA = "0x1807C0520")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			[DebuggerNonUserCode]
			public AEPGIIHNMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6236FB0", Offset = "0x62361B0", VA = "0x186236FB0")]
			[DebuggerNonUserCode]
			public AEPGIIHNMDD(AEPGIIHNMDD NFMPGFPPFKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6236AD0", Offset = "0x6235CD0", VA = "0x186236AD0", Slot = "10")]
			[DebuggerNonUserCode]
			public AEPGIIHNMDD Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6236B40", Offset = "0x6235D40", VA = "0x186236B40", Slot = "0")]
			[DebuggerNonUserCode]
			public override bool Equals(object NFMPGFPPFKH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6236BD0", Offset = "0x6235DD0", VA = "0x186236BD0", Slot = "9")]
			[DebuggerNonUserCode]
			public bool Equals(AEPGIIHNMDD NFMPGFPPFKH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6236C50", Offset = "0x6235E50", VA = "0x186236C50", Slot = "2")]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6236DD0", Offset = "0x6235FD0", VA = "0x186236DD0", Slot = "3")]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6236E20", Offset = "0x6236020", VA = "0x186236E20", Slot = "6")]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream DHLDOFLJLMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6236A30", Offset = "0x6235C30", VA = "0x186236A30", Slot = "7")]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6236D40", Offset = "0x6235F40", VA = "0x186236D40", Slot = "4")]
			[DebuggerNonUserCode]
			public void MergeFrom(AEPGIIHNMDD NFMPGFPPFKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6236D70", Offset = "0x6235F70", VA = "0x186236D70", Slot = "5")]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream NKIKIMMJFMI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public sealed class KEKDGGGNKBG : IMessage<KEKDGGGNKBG>, IMessage, IEquatable<KEKDGGGNKBG>, IDeepCloneable<KEKDGGGNKBG>
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static readonly MessageParser<KEKDGGGNKBG> FFBMCONBGNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private int CCHFILDCDMH;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly FieldCodec<int> GMHDPEBIKBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly RepeatedField<int> DLDCOMIBAMI;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static readonly FieldCodec<PKLOGECCHLJ> COPIMKNKONH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly RepeatedField<PKLOGECCHLJ> BKFCNJJJEGH;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			[DebuggerNonUserCode]
			public static MessageParser<KEKDGGGNKBG> GHGFFPGGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x623A300", Offset = "0x6239500", VA = "0x18623A300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			[DebuggerNonUserCode]
			public static MessageDescriptor IOFJMBMLJOH
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x623A350", Offset = "0x6239550", VA = "0x18623A350")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			[DebuggerNonUserCode]
			private MessageDescriptor DKPHOEEPCDB
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x623AA80", Offset = "0x6239C80", VA = "0x18623AA80", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			[DebuggerNonUserCode]
			public int HFFOOIGAONC
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x7BF590", Offset = "0x7BE790", VA = "0x1807BF590")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x623A9B0", Offset = "0x6239BB0", VA = "0x18623A9B0")]
			[DebuggerNonUserCode]
			public KEKDGGGNKBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x623A900", Offset = "0x6239B00", VA = "0x18623A900")]
			[DebuggerNonUserCode]
			public KEKDGGGNKBG(KEKDGGGNKBG NFMPGFPPFKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x623A070", Offset = "0x6239270", VA = "0x18623A070", Slot = "10")]
			[DebuggerNonUserCode]
			public KEKDGGGNKBG Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x623A200", Offset = "0x6239400", VA = "0x18623A200", Slot = "0")]
			[DebuggerNonUserCode]
			public override bool Equals(object NFMPGFPPFKH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x623A150", Offset = "0x6239350", VA = "0x18623A150", Slot = "9")]
			[DebuggerNonUserCode]
			public bool Equals(KEKDGGGNKBG NFMPGFPPFKH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6237CA0", Offset = "0x6236EA0", VA = "0x186237CA0", Slot = "2")]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x623A5B0", Offset = "0x62397B0", VA = "0x18623A5B0", Slot = "3")]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x623A600", Offset = "0x6239800", VA = "0x18623A600", Slot = "6")]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream DHLDOFLJLMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6239F60", Offset = "0x6239160", VA = "0x186239F60", Slot = "7")]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x623A520", Offset = "0x6239720", VA = "0x18623A520", Slot = "4")]
			[DebuggerNonUserCode]
			public void MergeFrom(KEKDGGGNKBG NFMPGFPPFKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x623A3D0", Offset = "0x62395D0", VA = "0x18623A3D0", Slot = "5")]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream NKIKIMMJFMI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public sealed class PKLOGECCHLJ : IMessage<PKLOGECCHLJ>, IMessage, IEquatable<PKLOGECCHLJ>, IDeepCloneable<PKLOGECCHLJ>
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static readonly MessageParser<PKLOGECCHLJ> FFBMCONBGNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private int CCHFILDCDMH;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static readonly FieldCodec<ByteString> FKINPALGHHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly RepeatedField<ByteString> HNHBDDNAMFI;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			[DebuggerNonUserCode]
			public static MessageParser<PKLOGECCHLJ> GHGFFPGGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x623AE00", Offset = "0x623A000", VA = "0x18623AE00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			[DebuggerNonUserCode]
			public static MessageDescriptor IOFJMBMLJOH
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x623AEC0", Offset = "0x623A0C0", VA = "0x18623AEC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			[DebuggerNonUserCode]
			private MessageDescriptor DKPHOEEPCDB
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x623B400", Offset = "0x623A600", VA = "0x18623B400", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			[DebuggerNonUserCode]
			public int HFFOOIGAONC
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x7BF590", Offset = "0x7BE790", VA = "0x1807BF590")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x623B2F0", Offset = "0x623A4F0", VA = "0x18623B2F0")]
			[DebuggerNonUserCode]
			public PKLOGECCHLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x623B380", Offset = "0x623A580", VA = "0x18623B380")]
			[DebuggerNonUserCode]
			public PKLOGECCHLJ(PKLOGECCHLJ NFMPGFPPFKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x623AC00", Offset = "0x6239E00", VA = "0x18623AC00", Slot = "10")]
			[DebuggerNonUserCode]
			public PKLOGECCHLJ Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x623ACB0", Offset = "0x6239EB0", VA = "0x18623ACB0", Slot = "0")]
			[DebuggerNonUserCode]
			public override bool Equals(object NFMPGFPPFKH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x623AD80", Offset = "0x6239F80", VA = "0x18623AD80", Slot = "9")]
			[DebuggerNonUserCode]
			public bool Equals(PKLOGECCHLJ NFMPGFPPFKH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x623AE50", Offset = "0x623A050", VA = "0x18623AE50", Slot = "2")]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x623B090", Offset = "0x623A290", VA = "0x18623B090", Slot = "3")]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x623B0E0", Offset = "0x623A2E0", VA = "0x18623B0E0", Slot = "6")]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream DHLDOFLJLMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x623AB30", Offset = "0x6239D30", VA = "0x18623AB30", Slot = "7")]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x623B020", Offset = "0x623A220", VA = "0x18623B020", Slot = "4")]
			[DebuggerNonUserCode]
			public void MergeFrom(PKLOGECCHLJ NFMPGFPPFKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x623AF40", Offset = "0x623A140", VA = "0x18623AF40", Slot = "5")]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream NKIKIMMJFMI)
			{
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly MessageParser<DCLGADHHAMB> FFBMCONBGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private EAFDHPFHMIG.PJEGCFEBPNF LCFALHJIKBF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly FieldCodec<EAFDHPFHMIG.AEPGIIHNMDD> EAJFHLHEHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly RepeatedField<EAFDHPFHMIG.AEPGIIHNMDD> EOMOBMBJINA;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly FieldCodec<EAFDHPFHMIG.KEKDGGGNKBG> OJDDPHBDCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly RepeatedField<EAFDHPFHMIG.KEKDGGGNKBG> IIAILFGGAHG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	[DebuggerNonUserCode]
	public static MessageParser<DCLGADHHAMB> GHGFFPGGAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6237C50", Offset = "0x6236E50", VA = "0x186237C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	[DebuggerNonUserCode]
	public static MessageDescriptor IOFJMBMLJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6237D40", Offset = "0x6236F40", VA = "0x186237D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[DebuggerNonUserCode]
	private MessageDescriptor DKPHOEEPCDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6238510", Offset = "0x6237710", VA = "0x186238510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[DebuggerNonUserCode]
	public EAFDHPFHMIG.PJEGCFEBPNF DFFLBILJIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180")]
		get
		{
			return default(EAFDHPFHMIG.PJEGCFEBPNF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BF590", Offset = "0x7BE790", VA = "0x1807BF590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6238390", Offset = "0x6237590", VA = "0x186238390")]
	[DebuggerNonUserCode]
	public DCLGADHHAMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6238460", Offset = "0x6237660", VA = "0x186238460")]
	[DebuggerNonUserCode]
	public DCLGADHHAMB(DCLGADHHAMB NFMPGFPPFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x62379C0", Offset = "0x6236BC0", VA = "0x1862379C0", Slot = "10")]
	[DebuggerNonUserCode]
	public DCLGADHHAMB Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6237B50", Offset = "0x6236D50", VA = "0x186237B50", Slot = "0")]
	[DebuggerNonUserCode]
	public override bool Equals(object NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6237AA0", Offset = "0x6236CA0", VA = "0x186237AA0", Slot = "9")]
	[DebuggerNonUserCode]
	public bool Equals(DCLGADHHAMB NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6237CA0", Offset = "0x6236EA0", VA = "0x186237CA0", Slot = "2")]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6237FC0", Offset = "0x62371C0", VA = "0x186237FC0", Slot = "3")]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6238010", Offset = "0x6237210", VA = "0x186238010", Slot = "6")]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream DHLDOFLJLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62378B0", Offset = "0x6236AB0", VA = "0x1862378B0", Slot = "7")]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6237DF0", Offset = "0x6236FF0", VA = "0x186237DF0", Slot = "4")]
	[DebuggerNonUserCode]
	public void MergeFrom(DCLGADHHAMB NFMPGFPPFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6237E80", Offset = "0x6237080", VA = "0x186237E80", Slot = "5")]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream NKIKIMMJFMI)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CNDGMOJHGPO
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public CNDGMOJHGPO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
