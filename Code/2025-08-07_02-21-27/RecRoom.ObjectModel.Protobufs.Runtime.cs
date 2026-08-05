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
internal class DZISONAGUEP
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
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	public DZISONAGUEP()
	{
	}
}
namespace RecRoom.ObjectModel.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class SFLFOPUDKYR
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static FileDescriptor OOLBTJOBXLO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FileDescriptor DMTOEEARNEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8C0BE10", Offset = "0x8C0AA10", VA = "0x188C0BE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BE60", Offset = "0x8C0AA60", VA = "0x188C0BE60")]
		static SFLFOPUDKYR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PAIASMSNXTK : IMessage<PAIASMSNXTK>, IMessage, IEquatable<PAIASMSNXTK>, IDeepCloneable<PAIASMSNXTK>, IBufferMessage
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class MMDAOZKJIDU
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
		private static readonly MessageParser<PAIASMSNXTK> AUCGJPZHYBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private UnknownFieldSet OFZHSVRPHMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private MMDAOZKJIDU.Version AKGWAJZWHRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ByteString RFONOVPADNG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PAIASMSNXTK> HIJBDCXWAPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8C0B9F0", Offset = "0x8C0A5F0", VA = "0x188C0B9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor DMTOEEARNEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8C0B6F0", Offset = "0x8C0A2F0", VA = "0x188C0B6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private MessageDescriptor GRWVNVFLSQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8C0BB20", Offset = "0x8C0A720", VA = "0x188C0BB20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MMDAOZKJIDU.Version MDWPLBPDAJV
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			get
			{
				return default(MMDAOZKJIDU.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString QVOBJOPJJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8C0B840", Offset = "0x8C0A440", VA = "0x188C0B840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BD70", Offset = "0x8C0A970", VA = "0x188C0BD70")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAIASMSNXTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BD10", Offset = "0x8C0A910", VA = "0x188C0BD10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAIASMSNXTK(PAIASMSNXTK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B4B0", Offset = "0x8C0A0B0", VA = "0x188C0B4B0", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PAIASMSNXTK Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B540", Offset = "0x8C0A140", VA = "0x188C0B540", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B630", Offset = "0x8C0A230", VA = "0x188C0B630", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PAIASMSNXTK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B7A0", Offset = "0x8C0A3A0", VA = "0x188C0B7A0", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BA40", Offset = "0x8C0A640", VA = "0x188C0BA40", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78504E0", Offset = "0x784F0E0", VA = "0x1878504E0", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BA90", Offset = "0x8C0A690", VA = "0x188C0BA90", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void UHPFACYTSUC(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B3F0", Offset = "0x8C09FF0", VA = "0x188C0B3F0", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B970", Offset = "0x8C0A570", VA = "0x188C0B970", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PAIASMSNXTK other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7850040", Offset = "0x784EC40", VA = "0x187850040", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B8B0", Offset = "0x8C0A4B0", VA = "0x188C0B8B0", Slot = "11")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void ISLGCIGNGHO(ParseContext a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class GXCTHWRKDAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static FileDescriptor OOLBTJOBXLO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static FileDescriptor DMTOEEARNEM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8C09200", Offset = "0x8C07E00", VA = "0x188C09200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8C09250", Offset = "0x8C07E50", VA = "0x188C09250")]
		static GXCTHWRKDAN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ADFQSYVUQNS : IMessage<ADFQSYVUQNS>, IMessage, IEquatable<ADFQSYVUQNS>, IDeepCloneable<ADFQSYVUQNS>, IBufferMessage
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class MMDAOZKJIDU
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
			public sealed class SPGNDMIVSNH : IMessage<SPGNDMIVSNH>, IMessage, IEquatable<SPGNDMIVSNH>, IDeepCloneable<SPGNDMIVSNH>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private static readonly MessageParser<SPGNDMIVSNH> AUCGJPZHYBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private UnknownFieldSet OFZHSVRPHMV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				private ulong KAJZCPDVLJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				private uint AKGWAJZWHRS;

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<SPGNDMIVSNH> HIJBDCXWAPE
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8C0C7D0", Offset = "0x8C0B3D0", VA = "0x188C0C7D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor DMTOEEARNEM
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x8C0C5B0", Offset = "0x8C0B1B0", VA = "0x188C0C5B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor GRWVNVFLSQS
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x8C0C8F0", Offset = "0x8C0B4F0", VA = "0x188C0C8F0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ulong MFKVHVKLVIF
				{
					[Cpp2IlInjected.Token(Token = "0x6000039")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
					get
					{
						return default(ulong);
					}
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0xE6CC90", Offset = "0xE6B890", VA = "0x180E6CC90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public uint MDWPLBPDAJV
				{
					[Cpp2IlInjected.Token(Token = "0x600003B")]
					[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SPGNDMIVSNH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x8C0CAB0", Offset = "0x8C0B6B0", VA = "0x188C0CAB0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SPGNDMIVSNH(SPGNDMIVSNH a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x8C0C480", Offset = "0x8C0B080", VA = "0x188C0C480", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SPGNDMIVSNH Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x8C0C510", Offset = "0x8C0B110", VA = "0x188C0C510", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7853210", Offset = "0x7851E10", VA = "0x187853210", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(SPGNDMIVSNH other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8C0C630", Offset = "0x8C0B230", VA = "0x188C0C630", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x8C0C820", Offset = "0x8C0B420", VA = "0x188C0C820", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x78504E0", Offset = "0x784F0E0", VA = "0x1878504E0", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x8C0C870", Offset = "0x8C0B470", VA = "0x188C0C870", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void UHPFACYTSUC(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x8C0C3C0", Offset = "0x8C0AFC0", VA = "0x188C0C3C0", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x8C0C780", Offset = "0x8C0B380", VA = "0x188C0C780", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(SPGNDMIVSNH other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x7850040", Offset = "0x784EC40", VA = "0x187850040", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x8C0C6D0", Offset = "0x8C0B2D0", VA = "0x188C0C6D0", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void ISLGCIGNGHO(ParseContext a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class NYADXNOTNKM : IMessage<NYADXNOTNKM>, IMessage, IEquatable<NYADXNOTNKM>, IDeepCloneable<NYADXNOTNKM>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				private static readonly MessageParser<NYADXNOTNKM> AUCGJPZHYBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				private UnknownFieldSet OFZHSVRPHMV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				private int MCXKLREYEEC;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				private static readonly FieldCodec<int> WGWCOKQGMUP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private readonly RepeatedField<int> JCCZDWAPNRJ;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				private static readonly FieldCodec<NVGAAMBLERP> WJHQDZGOPDM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				private readonly RepeatedField<NVGAAMBLERP> IAROORICGSI;

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<NYADXNOTNKM> HIJBDCXWAPE
				{
					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x8C0AE10", Offset = "0x8C09A10", VA = "0x188C0AE10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor DMTOEEARNEM
				{
					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x8C0AB40", Offset = "0x8C09740", VA = "0x188C0AB40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor GRWVNVFLSQS
				{
					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x8C0AFC0", Offset = "0x8C09BC0", VA = "0x188C0AFC0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int TFKHVZRHBKR
				{
					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> NENDFUAXGGD
				{
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<NVGAAMBLERP> SAMDHLCGHKD
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x8C0B260", Offset = "0x8C09E60", VA = "0x188C0B260")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NYADXNOTNKM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x8C0B320", Offset = "0x8C09F20", VA = "0x188C0B320")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NYADXNOTNKM(NYADXNOTNKM a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A880", Offset = "0x8C09480", VA = "0x188C0A880", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NYADXNOTNKM Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A970", Offset = "0x8C09570", VA = "0x188C0A970", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x8C0AA80", Offset = "0x8C09680", VA = "0x188C0AA80", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(NYADXNOTNKM other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x8C08920", Offset = "0x8C07520", VA = "0x188C08920", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x8C0AE60", Offset = "0x8C09A60", VA = "0x188C0AE60", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x78504E0", Offset = "0x784F0E0", VA = "0x1878504E0", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x8C0AEB0", Offset = "0x8C09AB0", VA = "0x188C0AEB0", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void UHPFACYTSUC(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A760", Offset = "0x8C09360", VA = "0x188C0A760", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x8C0AD60", Offset = "0x8C09960", VA = "0x188C0AD60", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(NYADXNOTNKM other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x7850040", Offset = "0x784EC40", VA = "0x187850040", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x8C0ABC0", Offset = "0x8C097C0", VA = "0x188C0ABC0", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void ISLGCIGNGHO(ParseContext a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class NVGAAMBLERP : IMessage<NVGAAMBLERP>, IMessage, IEquatable<NVGAAMBLERP>, IDeepCloneable<NVGAAMBLERP>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				private static readonly MessageParser<NVGAAMBLERP> AUCGJPZHYBH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				private UnknownFieldSet OFZHSVRPHMV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				private int MCXKLREYEEC;

				[Cpp2IlInjected.Token(Token = "0x4000034")]
				private static readonly FieldCodec<ByteString> CZZGMOYUOPG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				private readonly RepeatedField<ByteString> DRYLRLOZYJA;

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<NVGAAMBLERP> HIJBDCXWAPE
				{
					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x8C0A2E0", Offset = "0x8C08EE0", VA = "0x188C0A2E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor DMTOEEARNEM
				{
					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x8C0A010", Offset = "0x8C08C10", VA = "0x188C0A010")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor GRWVNVFLSQS
				{
					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x8C0A450", Offset = "0x8C09050", VA = "0x188C0A450", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int TFKHVZRHBKR
				{
					[Cpp2IlInjected.Token(Token = "0x6000069")]
					[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<ByteString> MWTHSNJHTTX
				{
					[Cpp2IlInjected.Token(Token = "0x600006B")]
					[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A640", Offset = "0x8C09240", VA = "0x188C0A640")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NVGAAMBLERP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A6C0", Offset = "0x8C092C0", VA = "0x188C0A6C0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NVGAAMBLERP(NVGAAMBLERP a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x8C09DD0", Offset = "0x8C089D0", VA = "0x188C09DD0", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NVGAAMBLERP Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x8C09F30", Offset = "0x8C08B30", VA = "0x188C09F30", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x8C09E90", Offset = "0x8C08A90", VA = "0x188C09E90", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(NVGAAMBLERP other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A090", Offset = "0x8C08C90", VA = "0x188C0A090", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A330", Offset = "0x8C08F30", VA = "0x188C0A330", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x78504E0", Offset = "0x784F0E0", VA = "0x1878504E0", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A380", Offset = "0x8C08F80", VA = "0x188C0A380", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void UHPFACYTSUC(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x8C09CE0", Offset = "0x8C088E0", VA = "0x188C09CE0", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A250", Offset = "0x8C08E50", VA = "0x188C0A250", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(NVGAAMBLERP other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x7850040", Offset = "0x784EC40", VA = "0x187850040", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x8C0A120", Offset = "0x8C08D20", VA = "0x188C0A120", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void ISLGCIGNGHO(ParseContext a)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly MessageParser<ADFQSYVUQNS> AUCGJPZHYBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private UnknownFieldSet OFZHSVRPHMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MMDAOZKJIDU.Version AKGWAJZWHRS;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly FieldCodec<MMDAOZKJIDU.SPGNDMIVSNH> DFNWAHSNTCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RepeatedField<MMDAOZKJIDU.SPGNDMIVSNH> SQBGHPHHNGG;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly FieldCodec<MMDAOZKJIDU.NYADXNOTNKM> XGRYSSSAIXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly RepeatedField<MMDAOZKJIDU.NYADXNOTNKM> ESCLHAHLXVA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ADFQSYVUQNS> HIJBDCXWAPE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8C08C20", Offset = "0x8C07820", VA = "0x188C08C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor DMTOEEARNEM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8C08870", Offset = "0x8C07470", VA = "0x188C08870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private MessageDescriptor GRWVNVFLSQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8C08DD0", Offset = "0x8C079D0", VA = "0x188C08DD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MMDAOZKJIDU.Version MDWPLBPDAJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			get
			{
				return default(MMDAOZKJIDU.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MMDAOZKJIDU.SPGNDMIVSNH> DYSXOFYTGQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MMDAOZKJIDU.NYADXNOTNKM> ANTIUTHZUAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8C09140", Offset = "0x8C07D40", VA = "0x188C09140")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ADFQSYVUQNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C09070", Offset = "0x8C07C70", VA = "0x188C09070")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ADFQSYVUQNS(ADFQSYVUQNS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8C085B0", Offset = "0x8C071B0", VA = "0x188C085B0", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ADFQSYVUQNS Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8C086A0", Offset = "0x8C072A0", VA = "0x188C086A0", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8C087B0", Offset = "0x8C073B0", VA = "0x188C087B0", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ADFQSYVUQNS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8C08920", Offset = "0x8C07520", VA = "0x188C08920", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8C08C70", Offset = "0x8C07870", VA = "0x188C08C70", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78504E0", Offset = "0x784F0E0", VA = "0x1878504E0", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8C08CC0", Offset = "0x8C078C0", VA = "0x188C08CC0", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void UHPFACYTSUC(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C08490", Offset = "0x8C07090", VA = "0x188C08490", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8C08B70", Offset = "0x8C07770", VA = "0x188C08B70", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ADFQSYVUQNS other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7850040", Offset = "0x784EC40", VA = "0x187850040", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8C089E0", Offset = "0x8C075E0", VA = "0x188C089E0", Slot = "11")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void ISLGCIGNGHO(ParseContext a)
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
