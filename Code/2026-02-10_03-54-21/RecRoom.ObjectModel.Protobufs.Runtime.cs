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
internal class TGYWBCNCWWO
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
	[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
	public TGYWBCNCWWO()
	{
	}
}
namespace RecRoom.ObjectModel.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class KQRLNTHLNTS
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static FileDescriptor FGYLQVBUDGF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FileDescriptor QUDQGRVHXON
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8612490", Offset = "0x8611690", VA = "0x188612490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86124E0", Offset = "0x86116E0", VA = "0x1886124E0")]
		static KQRLNTHLNTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TBCFNDVWWGJ : IMessage<TBCFNDVWWGJ>, IMessage, IEquatable<TBCFNDVWWGJ>, IDeepCloneable<TBCFNDVWWGJ>, IBufferMessage
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class XTSKGUBYJNP
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
		private static readonly MessageParser<TBCFNDVWWGJ> RQDMAMIJBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private UnknownFieldSet QUAHXIDIDZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private XTSKGUBYJNP.Version TLYDNVUTMNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ByteString IZCXIVWOIOJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TBCFNDVWWGJ> QFKCUZYEFHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8612F40", Offset = "0x8612140", VA = "0x188612F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor QUDQGRVHXON
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8612A30", Offset = "0x8611C30", VA = "0x188612A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private MessageDescriptor TNPNCMEGXMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8613080", Offset = "0x8612280", VA = "0x188613080", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XTSKGUBYJNP.Version YYVQTFDYWHC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0")]
			get
			{
				return default(XTSKGUBYJNP.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xABB640", Offset = "0xABA840", VA = "0x180ABB640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString YZKHAUKEWAA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8613010", Offset = "0x8612210", VA = "0x188613010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8613340", Offset = "0x8612540", VA = "0x188613340")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TBCFNDVWWGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86133E0", Offset = "0x86125E0", VA = "0x1886133E0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TBCFNDVWWGJ(TBCFNDVWWGJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8612BA0", Offset = "0x8611DA0", VA = "0x188612BA0", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TBCFNDVWWGJ Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8612C30", Offset = "0x8611E30", VA = "0x188612C30", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8612D20", Offset = "0x8611F20", VA = "0x188612D20", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TBCFNDVWWGJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8612DE0", Offset = "0x8611FE0", VA = "0x188612DE0", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8613160", Offset = "0x8612360", VA = "0x188613160", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72CD270", Offset = "0x72CC470", VA = "0x1872CD270", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86131B0", Offset = "0x86123B0", VA = "0x1886131B0", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void XPITAUCUWTN(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8612AE0", Offset = "0x8611CE0", VA = "0x188612AE0", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8612F90", Offset = "0x8612190", VA = "0x188612F90", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TBCFNDVWWGJ other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72CCDD0", Offset = "0x72CBFD0", VA = "0x1872CCDD0", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8612E80", Offset = "0x8612080", VA = "0x188612E80", Slot = "11")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void IBEHZISEEBX(ParseContext a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class UCBQUOSTOPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static FileDescriptor FGYLQVBUDGF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static FileDescriptor QUDQGRVHXON
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8613800", Offset = "0x8612A00", VA = "0x188613800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8613850", Offset = "0x8612A50", VA = "0x188613850")]
		static UCBQUOSTOPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KIANZPRZSAJ : IMessage<KIANZPRZSAJ>, IMessage, IEquatable<KIANZPRZSAJ>, IDeepCloneable<KIANZPRZSAJ>, IBufferMessage
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class XTSKGUBYJNP
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
			public sealed class FOTVZJFZVNG : IMessage<FOTVZJFZVNG>, IMessage, IEquatable<FOTVZJFZVNG>, IDeepCloneable<FOTVZJFZVNG>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private static readonly MessageParser<FOTVZJFZVNG> RQDMAMIJBKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private UnknownFieldSet QUAHXIDIDZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				private ulong NXKNEPZRIOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				private uint TLYDNVUTMNT;

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FOTVZJFZVNG> QFKCUZYEFHB
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8610770", Offset = "0x860F970", VA = "0x188610770")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor QUDQGRVHXON
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x86103B0", Offset = "0x860F5B0", VA = "0x1886103B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor TNPNCMEGXMF
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x8610810", Offset = "0x860FA10", VA = "0x188610810", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ulong DPDKTQZNUBK
				{
					[Cpp2IlInjected.Token(Token = "0x6000039")]
					[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
					get
					{
						return default(ulong);
					}
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0xB82B40", Offset = "0xB81D40", VA = "0x180B82B40")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public uint YYVQTFDYWHC
				{
					[Cpp2IlInjected.Token(Token = "0x600003B")]
					[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0xB0EDE0", Offset = "0xB0DFE0", VA = "0x180B0EDE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public FOTVZJFZVNG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x8610A90", Offset = "0x860FC90", VA = "0x188610A90")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public FOTVZJFZVNG(FOTVZJFZVNG a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x86104F0", Offset = "0x860F6F0", VA = "0x1886104F0", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public FOTVZJFZVNG Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x8610580", Offset = "0x860F780", VA = "0x188610580", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x72CFF50", Offset = "0x72CF150", VA = "0x1872CFF50", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(FOTVZJFZVNG other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8610620", Offset = "0x860F820", VA = "0x188610620", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x86108C0", Offset = "0x860FAC0", VA = "0x1886108C0", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x72CD270", Offset = "0x72CC470", VA = "0x1872CD270", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x8610910", Offset = "0x860FB10", VA = "0x188610910", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void XPITAUCUWTN(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x8610430", Offset = "0x860F630", VA = "0x188610430", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x86107C0", Offset = "0x860F9C0", VA = "0x1886107C0", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(FOTVZJFZVNG other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x72CCDD0", Offset = "0x72CBFD0", VA = "0x1872CCDD0", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x86106C0", Offset = "0x860F8C0", VA = "0x1886106C0", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void IBEHZISEEBX(ParseContext a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class IOBXOVCNJFN : IMessage<IOBXOVCNJFN>, IMessage, IEquatable<IOBXOVCNJFN>, IDeepCloneable<IOBXOVCNJFN>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				private static readonly MessageParser<IOBXOVCNJFN> RQDMAMIJBKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				private UnknownFieldSet QUAHXIDIDZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				private int PAASDOVVACX;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				private static readonly FieldCodec<int> VRCUXYVLHRW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private readonly RepeatedField<int> XWVMRJVZVLU;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				private static readonly FieldCodec<ACSPSPXBZUE> HTXPEFVATPN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				private readonly RepeatedField<ACSPSPXBZUE> BZGEQEYSQVJ;

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<IOBXOVCNJFN> QFKCUZYEFHB
				{
					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x86111B0", Offset = "0x86103B0", VA = "0x1886111B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor QUDQGRVHXON
				{
					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x8610AF0", Offset = "0x860FCF0", VA = "0x188610AF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor TNPNCMEGXMF
				{
					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x86112B0", Offset = "0x86104B0", VA = "0x1886112B0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int FTNBHZVTHHU
				{
					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0xABB640", Offset = "0xABA840", VA = "0x180ABB640")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> TSIMFVZJXWO
				{
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<ACSPSPXBZUE> ZLFZEKVCJRI
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x8611750", Offset = "0x8610950", VA = "0x188611750")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public IOBXOVCNJFN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x8611680", Offset = "0x8610880", VA = "0x188611680")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public IOBXOVCNJFN(IOBXOVCNJFN a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x8610C90", Offset = "0x860FE90", VA = "0x188610C90", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public IOBXOVCNJFN Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x8610E40", Offset = "0x8610040", VA = "0x188610E40", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x8610D80", Offset = "0x860FF80", VA = "0x188610D80", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(IOBXOVCNJFN other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x8610F50", Offset = "0x8610150", VA = "0x188610F50", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x8611360", Offset = "0x8610560", VA = "0x188611360", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x72CD270", Offset = "0x72CC470", VA = "0x1872CD270", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x86113B0", Offset = "0x86105B0", VA = "0x1886113B0", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void XPITAUCUWTN(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x8610B70", Offset = "0x860FD70", VA = "0x188610B70", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x8611200", Offset = "0x8610400", VA = "0x188611200", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(IOBXOVCNJFN other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x72CCDD0", Offset = "0x72CBFD0", VA = "0x1872CCDD0", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x8611010", Offset = "0x8610210", VA = "0x188611010", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void IBEHZISEEBX(ParseContext a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ACSPSPXBZUE : IMessage<ACSPSPXBZUE>, IMessage, IEquatable<ACSPSPXBZUE>, IDeepCloneable<ACSPSPXBZUE>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				private static readonly MessageParser<ACSPSPXBZUE> RQDMAMIJBKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				private UnknownFieldSet QUAHXIDIDZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				private int PAASDOVVACX;

				[Cpp2IlInjected.Token(Token = "0x4000034")]
				private static readonly FieldCodec<ByteString> OXAHLQMRCYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				private readonly RepeatedField<ByteString> UMGYGMYMAYF;

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ACSPSPXBZUE> QFKCUZYEFHB
				{
					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x860FEB0", Offset = "0x860F0B0", VA = "0x18860FEB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor QUDQGRVHXON
				{
					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x860F950", Offset = "0x860EB50", VA = "0x18860F950")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor TNPNCMEGXMF
				{
					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x860FF90", Offset = "0x860F190", VA = "0x18860FF90", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int FTNBHZVTHHU
				{
					[Cpp2IlInjected.Token(Token = "0x6000069")]
					[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0xABB640", Offset = "0xABA840", VA = "0x180ABB640")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<ByteString> YQBLYFLRZOA
				{
					[Cpp2IlInjected.Token(Token = "0x600006B")]
					[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x8610290", Offset = "0x860F490", VA = "0x188610290")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ACSPSPXBZUE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x8610310", Offset = "0x860F510", VA = "0x188610310")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ACSPSPXBZUE(ACSPSPXBZUE a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x860FAB0", Offset = "0x860ECB0", VA = "0x18860FAB0", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ACSPSPXBZUE Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x860FC10", Offset = "0x860EE10", VA = "0x18860FC10", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x860FB70", Offset = "0x860ED70", VA = "0x18860FB70", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(ACSPSPXBZUE other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x860FCF0", Offset = "0x860EEF0", VA = "0x18860FCF0", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x8610040", Offset = "0x860F240", VA = "0x188610040", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x72CD270", Offset = "0x72CC470", VA = "0x1872CD270", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x8610090", Offset = "0x860F290", VA = "0x188610090", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void XPITAUCUWTN(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x860F9D0", Offset = "0x860EBD0", VA = "0x18860F9D0", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x860FF00", Offset = "0x860F100", VA = "0x18860FF00", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(ACSPSPXBZUE other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x72CCDD0", Offset = "0x72CBFD0", VA = "0x1872CCDD0", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x860FD80", Offset = "0x860EF80", VA = "0x18860FD80", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void IBEHZISEEBX(ParseContext a)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly MessageParser<KIANZPRZSAJ> RQDMAMIJBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private UnknownFieldSet QUAHXIDIDZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private XTSKGUBYJNP.Version TLYDNVUTMNT;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly FieldCodec<XTSKGUBYJNP.FOTVZJFZVNG> FLIQRMMVBSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RepeatedField<XTSKGUBYJNP.FOTVZJFZVNG> LDZIVPACTBX;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly FieldCodec<XTSKGUBYJNP.IOBXOVCNJFN> RNHGOUCOQRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly RepeatedField<XTSKGUBYJNP.IOBXOVCNJFN> DDCJBRFMMLH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KIANZPRZSAJ> QFKCUZYEFHB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8611E30", Offset = "0x8611030", VA = "0x188611E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor QUDQGRVHXON
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8611810", Offset = "0x8610A10", VA = "0x188611810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private MessageDescriptor TNPNCMEGXMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8611F30", Offset = "0x8611130", VA = "0x188611F30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XTSKGUBYJNP.Version YYVQTFDYWHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0")]
			get
			{
				return default(XTSKGUBYJNP.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xABB640", Offset = "0xABA840", VA = "0x180ABB640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<XTSKGUBYJNP.FOTVZJFZVNG> MXOXPXLHDJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<XTSKGUBYJNP.IOBXOVCNJFN> MSXROLSNLVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86123D0", Offset = "0x86115D0", VA = "0x1886123D0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIANZPRZSAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8612300", Offset = "0x8611500", VA = "0x188612300")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIANZPRZSAJ(KIANZPRZSAJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86119E0", Offset = "0x8610BE0", VA = "0x1886119E0", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIANZPRZSAJ Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8611AD0", Offset = "0x8610CD0", VA = "0x188611AD0", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8611BE0", Offset = "0x8610DE0", VA = "0x188611BE0", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KIANZPRZSAJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8610F50", Offset = "0x8610150", VA = "0x188610F50", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8611F70", Offset = "0x8611170", VA = "0x188611F70", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72CD270", Offset = "0x72CC470", VA = "0x1872CD270", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8611FC0", Offset = "0x86111C0", VA = "0x188611FC0", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void XPITAUCUWTN(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86118C0", Offset = "0x8610AC0", VA = "0x1886118C0", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8611E80", Offset = "0x8611080", VA = "0x188611E80", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KIANZPRZSAJ other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x72CCDD0", Offset = "0x72CBFD0", VA = "0x1872CCDD0", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8611CA0", Offset = "0x8610EA0", VA = "0x188611CA0", Slot = "11")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void IBEHZISEEBX(ParseContext a)
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
