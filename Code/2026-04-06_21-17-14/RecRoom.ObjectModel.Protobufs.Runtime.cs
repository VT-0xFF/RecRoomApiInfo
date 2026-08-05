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
internal class UFSCIDMSTJW
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
	[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
	public UFSCIDMSTJW()
	{
	}
}
namespace RecRoom.ObjectModel.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class HKSKXITYFTY
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static FileDescriptor BSBBCBRTOKP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FileDescriptor JOYPZMWRRGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9BA0580", Offset = "0x9B9F580", VA = "0x189BA0580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BA05D0", Offset = "0x9B9F5D0", VA = "0x189BA05D0")]
		static HKSKXITYFTY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IRYAZLWJNZZ : IMessage<IRYAZLWJNZZ>, IMessage, IEquatable<IRYAZLWJNZZ>, IDeepCloneable<IRYAZLWJNZZ>, IBufferMessage
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class SVFNYUIHGCD
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
		private static readonly MessageParser<IRYAZLWJNZZ> PDGAWFICMGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private UnknownFieldSet LFDHADXHXYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private SVFNYUIHGCD.Version MJIOQALHIVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ByteString DVNANSHBTVB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IRYAZLWJNZZ> VYAQUCBGFCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1150", Offset = "0x9BA0150", VA = "0x189BA1150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor JOYPZMWRRGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1020", Offset = "0x9BA0020", VA = "0x189BA1020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private MessageDescriptor LDJDZGBYBAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9BA1260", Offset = "0x9BA0260", VA = "0x189BA1260", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SVFNYUIHGCD.Version WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			get
			{
				return default(SVFNYUIHGCD.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD031D0", Offset = "0xD021D0", VA = "0x180D031D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString NCQSLFIKERI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9BA11A0", Offset = "0x9BA01A0", VA = "0x189BA11A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9BA1450", Offset = "0x9BA0450", VA = "0x189BA1450")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IRYAZLWJNZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BA14F0", Offset = "0x9BA04F0", VA = "0x189BA14F0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IRYAZLWJNZZ(IRYAZLWJNZZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0BF0", Offset = "0x9B9FBF0", VA = "0x189BA0BF0", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IRYAZLWJNZZ Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0E90", Offset = "0x9B9FE90", VA = "0x189BA0E90", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0DD0", Offset = "0x9B9FDD0", VA = "0x189BA0DD0", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IRYAZLWJNZZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0F80", Offset = "0x9B9FF80", VA = "0x189BA0F80", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9BA1210", Offset = "0x9BA0210", VA = "0x189BA1210", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87F8D50", Offset = "0x87F7D50", VA = "0x1887F8D50", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0C80", Offset = "0x9B9FC80", VA = "0x189BA0C80", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void DZLTTUZBOWJ(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0B30", Offset = "0x9B9FB30", VA = "0x189BA0B30", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9BA10D0", Offset = "0x9BA00D0", VA = "0x189BA10D0", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IRYAZLWJNZZ other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87F88B0", Offset = "0x87F78B0", VA = "0x1887F88B0", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0D10", Offset = "0x9B9FD10", VA = "0x189BA0D10", Slot = "11")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void ESSHNMQCQRR(ParseContext a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PYSWYDICDYW
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static FileDescriptor BSBBCBRTOKP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static FileDescriptor JOYPZMWRRGL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9BA2930", Offset = "0x9BA1930", VA = "0x189BA2930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9BA2980", Offset = "0x9BA1980", VA = "0x189BA2980")]
		static PYSWYDICDYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ENHQPATCNXN : IMessage<ENHQPATCNXN>, IMessage, IEquatable<ENHQPATCNXN>, IDeepCloneable<ENHQPATCNXN>, IBufferMessage
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class SVFNYUIHGCD
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
			public sealed class NSWFCAKUTVE : IMessage<NSWFCAKUTVE>, IMessage, IEquatable<NSWFCAKUTVE>, IDeepCloneable<NSWFCAKUTVE>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				private static readonly MessageParser<NSWFCAKUTVE> PDGAWFICMGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private UnknownFieldSet LFDHADXHXYW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				private ulong FADIWRSCUXB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				private uint MJIOQALHIVN;

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<NSWFCAKUTVE> VYAQUCBGFCR
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x9BA2670", Offset = "0x9BA1670", VA = "0x189BA2670")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor JOYPZMWRRGL
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x9BA25A0", Offset = "0x9BA15A0", VA = "0x189BA25A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor LDJDZGBYBAH
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x9BA2710", Offset = "0x9BA1710", VA = "0x189BA2710", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ulong XWBSGGSKFGS
				{
					[Cpp2IlInjected.Token(Token = "0x6000039")]
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
					get
					{
						return default(ulong);
					}
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0xE01B00", Offset = "0xE00B00", VA = "0x180E01B00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public uint WZQEDLFLMPU
				{
					[Cpp2IlInjected.Token(Token = "0x600003B")]
					[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0xD4BEA0", Offset = "0xD4AEA0", VA = "0x180D4BEA0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NSWFCAKUTVE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x9BA28D0", Offset = "0x9BA18D0", VA = "0x189BA28D0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NSWFCAKUTVE(NSWFCAKUTVE a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x9BA22A0", Offset = "0x9BA12A0", VA = "0x189BA22A0", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NSWFCAKUTVE Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x9BA2460", Offset = "0x9BA1460", VA = "0x189BA2460", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x87FBA80", Offset = "0x87FAA80", VA = "0x1887FBA80", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(NSWFCAKUTVE other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9BA2500", Offset = "0x9BA1500", VA = "0x189BA2500", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x9BA26C0", Offset = "0x9BA16C0", VA = "0x189BA26C0", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x87F8D50", Offset = "0x87F7D50", VA = "0x1887F8D50", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x9BA2330", Offset = "0x9BA1330", VA = "0x189BA2330", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void DZLTTUZBOWJ(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x9BA21E0", Offset = "0x9BA11E0", VA = "0x189BA21E0", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x9BA2620", Offset = "0x9BA1620", VA = "0x189BA2620", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(NSWFCAKUTVE other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x87F88B0", Offset = "0x87F78B0", VA = "0x1887F88B0", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x9BA23B0", Offset = "0x9BA13B0", VA = "0x189BA23B0", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void ESSHNMQCQRR(ParseContext a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class JTRZZMNALNT : IMessage<JTRZZMNALNT>, IMessage, IEquatable<JTRZZMNALNT>, IDeepCloneable<JTRZZMNALNT>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				private static readonly MessageParser<JTRZZMNALNT> PDGAWFICMGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				private UnknownFieldSet LFDHADXHXYW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				private int DUPDWCOVRJT;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				private static readonly FieldCodec<int> OYANPKTSAFI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private readonly RepeatedField<int> UTUSXDRTSXC;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				private static readonly FieldCodec<QVMNSDBXCRM> HIXXAORQOSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				private readonly RepeatedField<QVMNSDBXCRM> MBDKIHDQLNX;

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<JTRZZMNALNT> VYAQUCBGFCR
				{
					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x9BA1D10", Offset = "0x9BA0D10", VA = "0x189BA1D10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor JOYPZMWRRGL
				{
					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x9BA1BE0", Offset = "0x9BA0BE0", VA = "0x189BA1BE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor LDJDZGBYBAH
				{
					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x9BA1DB0", Offset = "0x9BA0DB0", VA = "0x189BA1DB0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int XKCVEXFKTRG
				{
					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0xD031D0", Offset = "0xD021D0", VA = "0x180D031D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> UAUQHGMVXBK
				{
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<QVMNSDBXCRM> GUJCEMQIGWE
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x9BA2120", Offset = "0x9BA1120", VA = "0x189BA2120")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public JTRZZMNALNT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x9BA2050", Offset = "0x9BA1050", VA = "0x189BA2050")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public JTRZZMNALNT(JTRZZMNALNT a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x9BA1670", Offset = "0x9BA0670", VA = "0x189BA1670", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public JTRZZMNALNT Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x9BA1AD0", Offset = "0x9BA0AD0", VA = "0x189BA1AD0", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x9BA1A10", Offset = "0x9BA0A10", VA = "0x189BA1A10", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(JTRZZMNALNT other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x9B9FE90", Offset = "0x9B9EE90", VA = "0x189B9FE90", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x9BA1D60", Offset = "0x9BA0D60", VA = "0x189BA1D60", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x87F8D50", Offset = "0x87F7D50", VA = "0x1887F8D50", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x9BA1760", Offset = "0x9BA0760", VA = "0x189BA1760", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void DZLTTUZBOWJ(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x9BA1550", Offset = "0x9BA0550", VA = "0x189BA1550", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x9BA1C60", Offset = "0x9BA0C60", VA = "0x189BA1C60", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(JTRZZMNALNT other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x87F88B0", Offset = "0x87F78B0", VA = "0x1887F88B0", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x9BA1870", Offset = "0x9BA0870", VA = "0x189BA1870", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void ESSHNMQCQRR(ParseContext a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class QVMNSDBXCRM : IMessage<QVMNSDBXCRM>, IMessage, IEquatable<QVMNSDBXCRM>, IDeepCloneable<QVMNSDBXCRM>, IBufferMessage
			{
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				private static readonly MessageParser<QVMNSDBXCRM> PDGAWFICMGQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				private UnknownFieldSet LFDHADXHXYW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				private int DUPDWCOVRJT;

				[Cpp2IlInjected.Token(Token = "0x4000034")]
				private static readonly FieldCodec<ByteString> JHPGBLBMSWT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				private readonly RepeatedField<ByteString> NLNUWMDVHYL;

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<QVMNSDBXCRM> VYAQUCBGFCR
				{
					[Cpp2IlInjected.Token(Token = "0x6000063")]
					[Cpp2IlInjected.Address(RVA = "0x9BA3AE0", Offset = "0x9BA2AE0", VA = "0x189BA3AE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageDescriptor JOYPZMWRRGL
				{
					[Cpp2IlInjected.Token(Token = "0x6000064")]
					[Cpp2IlInjected.Address(RVA = "0x9BA39D0", Offset = "0x9BA29D0", VA = "0x189BA39D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private MessageDescriptor LDJDZGBYBAH
				{
					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9BA3B80", Offset = "0x9BA2B80", VA = "0x189BA3B80", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int XKCVEXFKTRG
				{
					[Cpp2IlInjected.Token(Token = "0x6000069")]
					[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0xD031D0", Offset = "0xD021D0", VA = "0x180D031D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<ByteString> ISYCGRVKIZA
				{
					[Cpp2IlInjected.Token(Token = "0x600006B")]
					[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x9BA3D70", Offset = "0x9BA2D70", VA = "0x189BA3D70")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public QVMNSDBXCRM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x9BA3DF0", Offset = "0x9BA2DF0", VA = "0x189BA3DF0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public QVMNSDBXCRM(QVMNSDBXCRM a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x9BA3500", Offset = "0x9BA2500", VA = "0x189BA3500", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public QVMNSDBXCRM Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x9BA37C0", Offset = "0x9BA27C0", VA = "0x189BA37C0", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x9BA38A0", Offset = "0x9BA28A0", VA = "0x189BA38A0", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(QVMNSDBXCRM other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x9BA3940", Offset = "0x9BA2940", VA = "0x189BA3940", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x9BA3B30", Offset = "0x9BA2B30", VA = "0x189BA3B30", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x87F8D50", Offset = "0x87F7D50", VA = "0x1887F8D50", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x9BA35C0", Offset = "0x9BA25C0", VA = "0x189BA35C0", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void DZLTTUZBOWJ(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x9BA3410", Offset = "0x9BA2410", VA = "0x189BA3410", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x9BA3A50", Offset = "0x9BA2A50", VA = "0x189BA3A50", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(QVMNSDBXCRM other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x87F88B0", Offset = "0x87F78B0", VA = "0x1887F88B0", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x9BA3690", Offset = "0x9BA2690", VA = "0x189BA3690", Slot = "11")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void ESSHNMQCQRR(ParseContext a)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly MessageParser<ENHQPATCNXN> PDGAWFICMGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private UnknownFieldSet LFDHADXHXYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private SVFNYUIHGCD.Version MJIOQALHIVN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly FieldCodec<SVFNYUIHGCD.NSWFCAKUTVE> FGRFAEZDDUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RepeatedField<SVFNYUIHGCD.NSWFCAKUTVE> AXZWKMWNNBB;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly FieldCodec<SVFNYUIHGCD.JTRZZMNALNT> UXLDXHHQBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly RepeatedField<SVFNYUIHGCD.JTRZZMNALNT> CAMRNJIHRQP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ENHQPATCNXN> VYAQUCBGFCR
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9BA00B0", Offset = "0x9B9F0B0", VA = "0x189BA00B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor JOYPZMWRRGL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9B9FF50", Offset = "0x9B9EF50", VA = "0x189B9FF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private MessageDescriptor LDJDZGBYBAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9BA0150", Offset = "0x9B9F150", VA = "0x189BA0150", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SVFNYUIHGCD.Version WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			get
			{
				return default(SVFNYUIHGCD.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD031D0", Offset = "0xD021D0", VA = "0x180D031D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SVFNYUIHGCD.NSWFCAKUTVE> GLQPIFWQRPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SVFNYUIHGCD.JTRZZMNALNT> HMCCDPHSWHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9BA04C0", Offset = "0x9B9F4C0", VA = "0x189BA04C0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENHQPATCNXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9BA03F0", Offset = "0x9B9F3F0", VA = "0x189BA03F0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENHQPATCNXN(ENHQPATCNXN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B9F930", Offset = "0x9B9E930", VA = "0x189B9F930", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENHQPATCNXN Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B9FD80", Offset = "0x9B9ED80", VA = "0x189B9FD80", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B9FCC0", Offset = "0x9B9ECC0", VA = "0x189B9FCC0", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ENHQPATCNXN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B9FE90", Offset = "0x9B9EE90", VA = "0x189B9FE90", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0100", Offset = "0x9B9F100", VA = "0x189BA0100", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87F8D50", Offset = "0x87F7D50", VA = "0x1887F8D50", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B9FA20", Offset = "0x9B9EA20", VA = "0x189B9FA20", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void DZLTTUZBOWJ(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B9F810", Offset = "0x9B9E810", VA = "0x189B9F810", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9BA0000", Offset = "0x9B9F000", VA = "0x189BA0000", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ENHQPATCNXN other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87F88B0", Offset = "0x87F78B0", VA = "0x1887F88B0", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9B9FB30", Offset = "0x9B9EB30", VA = "0x189B9FB30", Slot = "11")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void ESSHNMQCQRR(ParseContext a)
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
