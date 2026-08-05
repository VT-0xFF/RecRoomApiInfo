using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TMRYTQGXOHE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
	public TMRYTQGXOHE()
	{
	}
}
namespace RecRoom.ObjectModel.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class IZLWDFREORC
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static FileDescriptor VGHOHGGMPTL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FileDescriptor JTCJRJMYVLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9B882C0", Offset = "0x9B86CC0", VA = "0x189B882C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9B88310", Offset = "0x9B86D10", VA = "0x189B88310")]
		static IZLWDFREORC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class YICQGXILDQB : IMessage<YICQGXILDQB>, IMessage, IEquatable<YICQGXILDQB>, IDeepCloneable<YICQGXILDQB>, IBufferMessage
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class TITDVGJTICR
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public enum Version
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				[OriginalName("V0_PreObjectModel")]
				V0PreObjectModel = 0,
				[Cpp2IlInjected.Token(Token = "0x400000D")]
				[OriginalName("V1_ObjectModelHierarchy")]
				V1ObjectModelHierarchy = 1,
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				[OriginalName("V2_ObjectModelHierarchy")]
				V2ObjectModelHierarchy = 2,
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				[OriginalName("V3_Entities_050")]
				V3Entities050 = 3,
				[Cpp2IlInjected.Token(Token = "0x4000010")]
				[OriginalName("V4_Entities_050_Compressed")]
				V4Entities050Compressed = 4,
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				[OriginalName("V5_BumpObjectModelVersion_May_2024")]
				V5BumpObjectModelVersionMay2024 = 5,
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				[OriginalName("V6_Entities100")]
				V6Entities100 = 6,
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[OriginalName("OldestCompatibleVersion", PreferredAlias = false)]
				OldestCompatibleVersion = 3,
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[OriginalName("LatestVersion", PreferredAlias = false)]
				LatestVersion = 6
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly MessageParser<YICQGXILDQB> YCUZRICJQWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private UnknownFieldSet KYDVFLKNOQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TITDVGJTICR.Version CJDGBIPSJDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ByteString TOMCSXDERYJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<YICQGXILDQB> NPRFJTSKYLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9B8B850", Offset = "0x9B8A250", VA = "0x189B8B850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor JTCJRJMYVLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9B8B580", Offset = "0x9B89F80", VA = "0x189B8B580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private MessageDescriptor TGMKLUEWAXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9B8B700", Offset = "0x9B8A100", VA = "0x189B8B700", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TITDVGJTICR.Version UYZONXALEIA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0")]
			get
			{
				return default(TITDVGJTICR.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6B0", Offset = "0xD0B0B0", VA = "0x180D0C6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString IBPQMDVZAXS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9B8B7E0", Offset = "0x9B8A1E0", VA = "0x189B8B7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B9A0", Offset = "0x9B8A3A0", VA = "0x189B8B9A0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YICQGXILDQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B8BA40", Offset = "0x9B8A440", VA = "0x189B8BA40")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YICQGXILDQB(YICQGXILDQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B150", Offset = "0x9B89B50", VA = "0x189B8B150", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YICQGXILDQB Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B2A0", Offset = "0x9B89CA0", VA = "0x189B8B2A0", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B390", Offset = "0x9B89D90", VA = "0x189B8B390", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(YICQGXILDQB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B450", Offset = "0x9B89E50", VA = "0x189B8B450", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B6B0", Offset = "0x9B8A0B0", VA = "0x189B8B6B0", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87FA140", Offset = "0x87F8B40", VA = "0x1887FA140", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B4F0", Offset = "0x9B89EF0", VA = "0x189B8B4F0", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void LQXOJSUKGRJ(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B090", Offset = "0x9B89A90", VA = "0x189B8B090", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B630", Offset = "0x9B8A030", VA = "0x189B8B630", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(YICQGXILDQB other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87F9CA0", Offset = "0x87F86A0", VA = "0x1887F9CA0", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9B8B1E0", Offset = "0x9B89BE0", VA = "0x189B8B1E0", Slot = "11")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void DUORMPWQZGJ(ParseContext a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class LRHFRWRGFAU
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static FileDescriptor VGHOHGGMPTL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static FileDescriptor JTCJRJMYVLD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9B88860", Offset = "0x9B87260", VA = "0x189B88860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B888B0", Offset = "0x9B872B0", VA = "0x189B888B0")]
		static LRHFRWRGFAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class VBKROBXGRUF : IMessage<VBKROBXGRUF>, IMessage, IEquatable<VBKROBXGRUF>, IDeepCloneable<VBKROBXGRUF>, IBufferMessage
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class TITDVGJTICR
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public enum Version
			{
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				[OriginalName("V0_PreObjectModel")]
				V0PreObjectModel = 0,
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				[OriginalName("V1_ObjectModelHierarchy")]
				V1ObjectModelHierarchy = 1,
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				[OriginalName("V2_ObjectModelHierarchy")]
				V2ObjectModelHierarchy = 2,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				[OriginalName("OldestCompatibleVersion", PreferredAlias = false)]
				OldestCompatibleVersion = 2,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				[OriginalName("LatestVersion", PreferredAlias = false)]
				LatestVersion = 2
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class HWTMYEWPQNC : IMessage<HWTMYEWPQNC>, IMessage, IEquatable<HWTMYEWPQNC>, IDeepCloneable<HWTMYEWPQNC>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private static readonly MessageParser<HWTMYEWPQNC> YCUZRICJQWK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private UnknownFieldSet KYDVFLKNOQU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				private ulong NCGWOPGAIWF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				private uint CJDGBIPSJDT;

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<HWTMYEWPQNC> NPRFJTSKYLV
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x9B88110", Offset = "0x9B86B10", VA = "0x189B88110")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor JTCJRJMYVLD
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x9B87F40", Offset = "0x9B86940", VA = "0x189B87F40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor TGMKLUEWAXL
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x9B88060", Offset = "0x9B86A60", VA = "0x189B88060", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ulong VVWFXYFKTII
				{
					[Cpp2IlInjected.Token(Token = "0x6000039")]
					[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
					get
					{
						return default(ulong);
					}
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0xE26CF0", Offset = "0xE256F0", VA = "0x180E26CF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public uint UYZONXALEIA
				{
					[Cpp2IlInjected.Token(Token = "0x600003B")]
					[Cpp2IlInjected.Address(RVA = "0xD1B530", Offset = "0xD19F30", VA = "0x180D1B530")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0xD5E6E0", Offset = "0xD5D0E0", VA = "0x180D5E6E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public HWTMYEWPQNC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x9B88260", Offset = "0x9B86C60", VA = "0x189B88260")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public HWTMYEWPQNC(HWTMYEWPQNC a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x9B87C40", Offset = "0x9B86640", VA = "0x189B87C40", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public HWTMYEWPQNC Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x9B87D80", Offset = "0x9B86780", VA = "0x189B87D80", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x87FCE20", Offset = "0x87FB820", VA = "0x1887FCE20", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(HWTMYEWPQNC other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9B87E20", Offset = "0x9B86820", VA = "0x189B87E20", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x9B88010", Offset = "0x9B86A10", VA = "0x189B88010", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x87FA140", Offset = "0x87F8B40", VA = "0x1887FA140", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x9B87EC0", Offset = "0x9B868C0", VA = "0x189B87EC0", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void LQXOJSUKGRJ(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x9B87B80", Offset = "0x9B86580", VA = "0x189B87B80", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x9B87FC0", Offset = "0x9B869C0", VA = "0x189B87FC0", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(HWTMYEWPQNC other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x87F9CA0", Offset = "0x87F86A0", VA = "0x1887F9CA0", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x9B87CD0", Offset = "0x9B866D0", VA = "0x189B87CD0", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void DUORMPWQZGJ(ParseContext a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class NJVCGLMHQHV : IMessage<NJVCGLMHQHV>, IMessage, IEquatable<NJVCGLMHQHV>, IDeepCloneable<NJVCGLMHQHV>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				private static readonly MessageParser<NJVCGLMHQHV> YCUZRICJQWK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				private UnknownFieldSet KYDVFLKNOQU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				private int HSFOEIJKBCD;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				private static readonly FieldCodec<int> PNBBHXOCOHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private readonly RepeatedField<int> BMCHSLFUIVE;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				private static readonly FieldCodec<GFCKRECEEYQ> FWLIOGEGJXN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				private readonly RepeatedField<GFCKRECEEYQ> AQITPBMRYKX;

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<NJVCGLMHQHV> NPRFJTSKYLV
				{
					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x9B89CA0", Offset = "0x9B886A0", VA = "0x189B89CA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor JTCJRJMYVLD
				{
					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x9B89A70", Offset = "0x9B88470", VA = "0x189B89A70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor TGMKLUEWAXL
				{
					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x9B89BF0", Offset = "0x9B885F0", VA = "0x189B89BF0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int TVWLBLTNVIK
				{
					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0xD0C6B0", Offset = "0xD0B0B0", VA = "0x180D0C6B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> FOMLUJGCBJY
				{
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<GFCKRECEEYQ> MPZZYXFATVQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x9B89F90", Offset = "0x9B88990", VA = "0x189B89F90")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NJVCGLMHQHV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x9B89EC0", Offset = "0x9B888C0", VA = "0x189B89EC0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NJVCGLMHQHV(NJVCGLMHQHV a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x9B89450", Offset = "0x9B87E50", VA = "0x189B89450", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NJVCGLMHQHV Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x9B897A0", Offset = "0x9B881A0", VA = "0x189B897A0", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x9B896E0", Offset = "0x9B880E0", VA = "0x189B896E0", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(NJVCGLMHQHV other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x9B898B0", Offset = "0x9B882B0", VA = "0x189B898B0", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x9B89BA0", Offset = "0x9B885A0", VA = "0x189B89BA0", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x87FA140", Offset = "0x87F8B40", VA = "0x1887FA140", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x9B89970", Offset = "0x9B88370", VA = "0x189B89970", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void LQXOJSUKGRJ(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x9B89330", Offset = "0x9B87D30", VA = "0x189B89330", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x9B89AF0", Offset = "0x9B884F0", VA = "0x189B89AF0", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(NJVCGLMHQHV other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x87F9CA0", Offset = "0x87F86A0", VA = "0x1887F9CA0", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x9B89540", Offset = "0x9B87F40", VA = "0x189B89540", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void DUORMPWQZGJ(ParseContext a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class GFCKRECEEYQ : IMessage<GFCKRECEEYQ>, IMessage, IEquatable<GFCKRECEEYQ>, IDeepCloneable<GFCKRECEEYQ>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				private static readonly MessageParser<GFCKRECEEYQ> YCUZRICJQWK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				private UnknownFieldSet KYDVFLKNOQU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				private int HSFOEIJKBCD;

				[Cpp2IlInjected.Token(Token = "0x4000034")]
				private static readonly FieldCodec<ByteString> JWYBKWQYGIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				private readonly RepeatedField<ByteString> ICMIWAPWLQR;

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GFCKRECEEYQ> NPRFJTSKYLV
				{
					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x9B878E0", Offset = "0x9B862E0", VA = "0x189B878E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor JTCJRJMYVLD
				{
					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x9B876D0", Offset = "0x9B860D0", VA = "0x189B876D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor TGMKLUEWAXL
				{
					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9B87830", Offset = "0x9B86230", VA = "0x189B87830", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int TVWLBLTNVIK
				{
					[Cpp2IlInjected.Token(Token = "0x6000069")]
					[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0xD0C6B0", Offset = "0xD0B0B0", VA = "0x180D0C6B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<ByteString> BIXAGKYJCIQ
				{
					[Cpp2IlInjected.Token(Token = "0x600006B")]
					[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x9B87A60", Offset = "0x9B86460", VA = "0x189B87A60")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GFCKRECEEYQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x9B87AE0", Offset = "0x9B864E0", VA = "0x189B87AE0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GFCKRECEEYQ(GFCKRECEEYQ a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x9B87200", Offset = "0x9B85C00", VA = "0x189B87200", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GFCKRECEEYQ Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x9B873F0", Offset = "0x9B85DF0", VA = "0x189B873F0", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x9B874D0", Offset = "0x9B85ED0", VA = "0x189B874D0", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(GFCKRECEEYQ other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x9B87570", Offset = "0x9B85F70", VA = "0x189B87570", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x9B877E0", Offset = "0x9B861E0", VA = "0x189B877E0", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x87FA140", Offset = "0x87F8B40", VA = "0x1887FA140", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x9B87600", Offset = "0x9B86000", VA = "0x189B87600", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void LQXOJSUKGRJ(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x9B87120", Offset = "0x9B85B20", VA = "0x189B87120", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x9B87750", Offset = "0x9B86150", VA = "0x189B87750", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(GFCKRECEEYQ other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x87F9CA0", Offset = "0x87F86A0", VA = "0x1887F9CA0", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x9B872C0", Offset = "0x9B85CC0", VA = "0x189B872C0", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void DUORMPWQZGJ(ParseContext a)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly MessageParser<VBKROBXGRUF> YCUZRICJQWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private UnknownFieldSet KYDVFLKNOQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TITDVGJTICR.Version CJDGBIPSJDT;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly FieldCodec<TITDVGJTICR.HWTMYEWPQNC> WCTOKAEIOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RepeatedField<TITDVGJTICR.HWTMYEWPQNC> RGDYASOEAEN;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly FieldCodec<TITDVGJTICR.NJVCGLMHQHV> BQNNNDXFLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly RepeatedField<TITDVGJTICR.NJVCGLMHQHV> TAPHFIAKEEV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VBKROBXGRUF> NPRFJTSKYLV
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9B8AC70", Offset = "0x9B89670", VA = "0x189B8AC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor JTCJRJMYVLD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9B8AA80", Offset = "0x9B89480", VA = "0x189B8AA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private MessageDescriptor TGMKLUEWAXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9B8AC30", Offset = "0x9B89630", VA = "0x189B8AC30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TITDVGJTICR.Version UYZONXALEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0")]
			get
			{
				return default(TITDVGJTICR.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6B0", Offset = "0xD0B0B0", VA = "0x180D0C6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TITDVGJTICR.HWTMYEWPQNC> MVGFLKPNGVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TITDVGJTICR.NJVCGLMHQHV> EOJBKRRABRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B8AF00", Offset = "0x9B89900", VA = "0x189B8AF00")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VBKROBXGRUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B8AFC0", Offset = "0x9B899C0", VA = "0x189B8AFC0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VBKROBXGRUF(VBKROBXGRUF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A530", Offset = "0x9B88F30", VA = "0x189B8A530", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VBKROBXGRUF Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A870", Offset = "0x9B89270", VA = "0x189B8A870", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A7B0", Offset = "0x9B891B0", VA = "0x189B8A7B0", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VBKROBXGRUF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B898B0", Offset = "0x9B882B0", VA = "0x189B898B0", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8ABE0", Offset = "0x9B895E0", VA = "0x189B8ABE0", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87FA140", Offset = "0x87F8B40", VA = "0x1887FA140", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A980", Offset = "0x9B89380", VA = "0x189B8A980", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void LQXOJSUKGRJ(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A410", Offset = "0x9B88E10", VA = "0x189B8A410", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8AB30", Offset = "0x9B89530", VA = "0x189B8AB30", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VBKROBXGRUF other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87F9CA0", Offset = "0x87F86A0", VA = "0x1887F9CA0", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A620", Offset = "0x9B89020", VA = "0x189B8A620", Slot = "11")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void DUORMPWQZGJ(ParseContext a)
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
