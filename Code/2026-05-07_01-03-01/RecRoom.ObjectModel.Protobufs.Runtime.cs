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
	[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A286B0", Offset = "0x9A270B0", VA = "0x189A286B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9A28700", Offset = "0x9A27100", VA = "0x189A28700")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2BCC0", Offset = "0x9A2A6C0", VA = "0x189A2BCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2B9F0", Offset = "0x9A2A3F0", VA = "0x189A2B9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2BB70", Offset = "0x9A2A570", VA = "0x189A2BB70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0")]
			get
			{
				return default(TITDVGJTICR.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCD36B0", Offset = "0xCD20B0", VA = "0x180CD36B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9A2BC50", Offset = "0x9A2A650", VA = "0x189A2BC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A2BE20", Offset = "0x9A2A820", VA = "0x189A2BE20")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YICQGXILDQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A2BEC0", Offset = "0x9A2A8C0", VA = "0x189A2BEC0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YICQGXILDQB(YICQGXILDQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B5C0", Offset = "0x9A29FC0", VA = "0x189A2B5C0", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public YICQGXILDQB Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B710", Offset = "0x9A2A110", VA = "0x189A2B710", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B800", Offset = "0x9A2A200", VA = "0x189A2B800", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(YICQGXILDQB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B8C0", Offset = "0x9A2A2C0", VA = "0x189A2B8C0", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9A2BB20", Offset = "0x9A2A520", VA = "0x189A2BB20", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x867DEE0", Offset = "0x867C8E0", VA = "0x18867DEE0", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B960", Offset = "0x9A2A360", VA = "0x189A2B960", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void LQXOJSUKGRJ(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B500", Offset = "0x9A29F00", VA = "0x189A2B500", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A2BAA0", Offset = "0x9A2A4A0", VA = "0x189A2BAA0", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(YICQGXILDQB other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x867DA40", Offset = "0x867C440", VA = "0x18867DA40", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B650", Offset = "0x9A2A050", VA = "0x189A2B650", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A28C60", Offset = "0x9A27660", VA = "0x189A28C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A28CB0", Offset = "0x9A276B0", VA = "0x189A28CB0")]
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
					[Cpp2IlInjected.Address(RVA = "0x9A284F0", Offset = "0x9A26EF0", VA = "0x189A284F0")]
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
					[Cpp2IlInjected.Address(RVA = "0x9A28320", Offset = "0x9A26D20", VA = "0x189A28320")]
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
					[Cpp2IlInjected.Address(RVA = "0x9A28440", Offset = "0x9A26E40", VA = "0x189A28440", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
					get
					{
						return default(ulong);
					}
					[Cpp2IlInjected.Token(Token = "0x600003A")]
					[Cpp2IlInjected.Address(RVA = "0xDF0A10", Offset = "0xDEF410", VA = "0x180DF0A10")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE2550", Offset = "0xCE0F50", VA = "0x180CE2550")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x600003C")]
					[Cpp2IlInjected.Address(RVA = "0xD251B0", Offset = "0xD23BB0", VA = "0x180D251B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public HWTMYEWPQNC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x9A28650", Offset = "0x9A27050", VA = "0x189A28650")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public HWTMYEWPQNC(HWTMYEWPQNC a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x9A28020", Offset = "0x9A26A20", VA = "0x189A28020", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public HWTMYEWPQNC Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x9A28160", Offset = "0x9A26B60", VA = "0x189A28160", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x8680C10", Offset = "0x867F610", VA = "0x188680C10", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(HWTMYEWPQNC other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9A28200", Offset = "0x9A26C00", VA = "0x189A28200", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x9A283F0", Offset = "0x9A26DF0", VA = "0x189A283F0", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x867DEE0", Offset = "0x867C8E0", VA = "0x18867DEE0", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x9A282A0", Offset = "0x9A26CA0", VA = "0x189A282A0", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void LQXOJSUKGRJ(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x9A27F60", Offset = "0x9A26960", VA = "0x189A27F60", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x9A283A0", Offset = "0x9A26DA0", VA = "0x189A283A0", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(HWTMYEWPQNC other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x867DA40", Offset = "0x867C440", VA = "0x18867DA40", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x9A280B0", Offset = "0x9A26AB0", VA = "0x189A280B0", Slot = "11")]
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
					[Cpp2IlInjected.Address(RVA = "0x9A2A0C0", Offset = "0x9A28AC0", VA = "0x189A2A0C0")]
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
					[Cpp2IlInjected.Address(RVA = "0x9A29E90", Offset = "0x9A28890", VA = "0x189A29E90")]
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
					[Cpp2IlInjected.Address(RVA = "0x9A2A010", Offset = "0x9A28A10", VA = "0x189A2A010", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0xCD36B0", Offset = "0xCD20B0", VA = "0x180CD36B0")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x9A2A3D0", Offset = "0x9A28DD0", VA = "0x189A2A3D0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NJVCGLMHQHV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x9A2A300", Offset = "0x9A28D00", VA = "0x189A2A300")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NJVCGLMHQHV(NJVCGLMHQHV a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x9A29860", Offset = "0x9A28260", VA = "0x189A29860", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public NJVCGLMHQHV Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x9A29BB0", Offset = "0x9A285B0", VA = "0x189A29BB0", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x9A29AF0", Offset = "0x9A284F0", VA = "0x189A29AF0", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(NJVCGLMHQHV other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x9A29CC0", Offset = "0x9A286C0", VA = "0x189A29CC0", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x9A29FC0", Offset = "0x9A289C0", VA = "0x189A29FC0", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x867DEE0", Offset = "0x867C8E0", VA = "0x18867DEE0", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x9A29D80", Offset = "0x9A28780", VA = "0x189A29D80", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void LQXOJSUKGRJ(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x9A29740", Offset = "0x9A28140", VA = "0x189A29740", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x9A29F10", Offset = "0x9A28910", VA = "0x189A29F10", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(NJVCGLMHQHV other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x867DA40", Offset = "0x867C440", VA = "0x18867DA40", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x9A29950", Offset = "0x9A28350", VA = "0x189A29950", Slot = "11")]
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
					[Cpp2IlInjected.Address(RVA = "0x9A27CB0", Offset = "0x9A266B0", VA = "0x189A27CB0")]
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
					[Cpp2IlInjected.Address(RVA = "0x9A27AA0", Offset = "0x9A264A0", VA = "0x189A27AA0")]
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
					[Cpp2IlInjected.Address(RVA = "0x9A27C00", Offset = "0x9A26600", VA = "0x189A27C00", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600006A")]
					[Cpp2IlInjected.Address(RVA = "0xCD36B0", Offset = "0xCD20B0", VA = "0x180CD36B0")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x9A27E40", Offset = "0x9A26840", VA = "0x189A27E40")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GFCKRECEEYQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x9A27EC0", Offset = "0x9A268C0", VA = "0x189A27EC0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GFCKRECEEYQ(GFCKRECEEYQ a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x9A275D0", Offset = "0x9A25FD0", VA = "0x189A275D0", Slot = "10")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GFCKRECEEYQ Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x9A277C0", Offset = "0x9A261C0", VA = "0x189A277C0", Slot = "0")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x9A278A0", Offset = "0x9A262A0", VA = "0x189A278A0", Slot = "9")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Equals(GFCKRECEEYQ other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x9A27940", Offset = "0x9A26340", VA = "0x189A27940", Slot = "2")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x9A27BB0", Offset = "0x9A265B0", VA = "0x189A27BB0", Slot = "3")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x867DEE0", Offset = "0x867C8E0", VA = "0x18867DEE0", Slot = "6")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x9A279D0", Offset = "0x9A263D0", VA = "0x189A279D0", Slot = "12")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				private void LQXOJSUKGRJ(WriteContext a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x9A274E0", Offset = "0x9A25EE0", VA = "0x189A274E0", Slot = "7")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x9A27B20", Offset = "0x9A26520", VA = "0x189A27B20", Slot = "4")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(GFCKRECEEYQ other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x867DA40", Offset = "0x867C440", VA = "0x18867DA40", Slot = "5")]
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x9A27690", Offset = "0x9A26090", VA = "0x189A27690", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2B0C0", Offset = "0x9A29AC0", VA = "0x189A2B0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2AED0", Offset = "0x9A298D0", VA = "0x189A2AED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A2B080", Offset = "0x9A29A80", VA = "0x189A2B080", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0")]
			get
			{
				return default(TITDVGJTICR.Version);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xCD36B0", Offset = "0xCD20B0", VA = "0x180CD36B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B370", Offset = "0x9A29D70", VA = "0x189A2B370")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VBKROBXGRUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B430", Offset = "0x9A29E30", VA = "0x189A2B430")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VBKROBXGRUF(VBKROBXGRUF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A2A970", Offset = "0x9A29370", VA = "0x189A2A970", Slot = "10")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VBKROBXGRUF Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A2ACB0", Offset = "0x9A296B0", VA = "0x189A2ACB0", Slot = "0")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A2ABF0", Offset = "0x9A295F0", VA = "0x189A2ABF0", Slot = "9")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VBKROBXGRUF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A29CC0", Offset = "0x9A286C0", VA = "0x189A29CC0", Slot = "2")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B030", Offset = "0x9A29A30", VA = "0x189A2B030", Slot = "3")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x867DEE0", Offset = "0x867C8E0", VA = "0x18867DEE0", Slot = "6")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A2ADC0", Offset = "0x9A297C0", VA = "0x189A2ADC0", Slot = "12")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		private void LQXOJSUKGRJ(WriteContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2A850", Offset = "0x9A29250", VA = "0x189A2A850", Slot = "7")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9A2AF80", Offset = "0x9A29980", VA = "0x189A2AF80", Slot = "4")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VBKROBXGRUF other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x867DA40", Offset = "0x867C440", VA = "0x18867DA40", Slot = "5")]
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A2AA60", Offset = "0x9A29460", VA = "0x189A2AA60", Slot = "11")]
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
