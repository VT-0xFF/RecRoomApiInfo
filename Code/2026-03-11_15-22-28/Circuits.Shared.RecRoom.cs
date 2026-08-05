using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Circuits.Shared.RecRoom.Api;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2918FF0", Offset = "0x2917FF0", VA = "0x182918FF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class ARMKYUXXZYH : IEquatable<ARMKYUXXZYH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly string TXKKVYGLDVU;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		private ARMKYUXXZYH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29186A0", Offset = "0x29176A0", VA = "0x1829186A0")]
		public static ARMKYUXXZYH New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2918740", Offset = "0x2917740", VA = "0x182918740")]
		public static void RNWSGUUBNYS(Stream a, ARMKYUXXZYH? self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2918790", Offset = "0x2917790", VA = "0x182918790")]
		public static ARMKYUXXZYH YNFZNMPNYHA(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2918820", Offset = "0x2917820", VA = "0x182918820")]
		public static int ZRSPLMJTNOG(ARMKYUXXZYH? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x29185A0", Offset = "0x29175A0", VA = "0x1829185A0")]
		public static bool JNIBMGTXNLH(ARMKYUXXZYH? a, ARMKYUXXZYH? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x29185A0", Offset = "0x29175A0", VA = "0x1829185A0", Slot = "4")]
		public bool Equals(ARMKYUXXZYH? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x29185F0", Offset = "0x29175F0", VA = "0x1829185F0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2918670", Offset = "0x2917670", VA = "0x182918670", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CKRCEGUWXQO : HBXVWXIGUXD, IEquatable<CKRCEGUWXQO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public long XSVAJJCNYNV
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string FJJXEMRQDRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string PPGVAEATQSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2918A90", Offset = "0x2917A90", VA = "0x182918A90")]
		public CKRCEGUWXQO(long a, string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2918870", Offset = "0x2917870", VA = "0x182918870", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2918850", Offset = "0x2917850", VA = "0x182918850", Slot = "7")]
		public bool Equals(CKRCEGUWXQO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2918910", Offset = "0x2917910", VA = "0x182918910", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2918930", Offset = "0x2917930", VA = "0x182918930")]
		public static void RNWSGUUBNYS(CKRCEGUWXQO? self, Stream a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2918990", Offset = "0x2917990", VA = "0x182918990")]
		public static CKRCEGUWXQO YNFZNMPNYHA(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2918A50", Offset = "0x2917A50", VA = "0x182918A50")]
		public static int ZRSPLMJTNOG(CKRCEGUWXQO? a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class SQZPFTBXRCR
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2919A60", Offset = "0x2918A60", VA = "0x182919A60")]
		public static XJGAAGQYWTE XRHSQBYDVHR(this CKRCEGUWXQO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x29199C0", Offset = "0x29189C0", VA = "0x1829199C0")]
		public static CKRCEGUWXQO WLZQZCXXIAC(this XJGAAGQYWTE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class QHCVCSRLJNP : OVDWRGAOKDG, IEquatable<QHCVCSRLJNP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string YKFTTYZGRGN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public QHCVCSRLJNP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x29194F0", Offset = "0x29184F0", VA = "0x1829194F0")]
		public static bool JNIBMGTXNLH(QHCVCSRLJNP a, QHCVCSRLJNP b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x29194B0", Offset = "0x29184B0", VA = "0x1829194B0", Slot = "5")]
		public bool Equals(QHCVCSRLJNP? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2919400", Offset = "0x2918400", VA = "0x182919400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2918670", Offset = "0x2917670", VA = "0x182918670", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2919520", Offset = "0x2918520", VA = "0x182919520")]
		public static void RNWSGUUBNYS(QHCVCSRLJNP? self, Stream a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2919570", Offset = "0x2918570", VA = "0x182919570")]
		public static QHCVCSRLJNP YNFZNMPNYHA(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2919600", Offset = "0x2918600", VA = "0x182919600")]
		public static int ZRSPLMJTNOG(QHCVCSRLJNP? a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class XCYKGQMIKSR : XVNRGWBKEIW, IEquatable<XCYKGQMIKSR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public CircuitsDestinationTargetType ZROAUARRVHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(CircuitsDestinationTargetType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool YCOIPFZNUUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x10BD270", Offset = "0x10BC270", VA = "0x1810BD270", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RoomDoorData.FZNFAKTBVRO.RoomDoorInviteMode MAFFOHEJBNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(RoomDoorData.FZNFAKTBVRO.RoomDoorInviteMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string LJHQAHAOKJB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string XGENAKKRLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string DRGHPIOGZRI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string PPGVAEATQSJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x2919FC0", Offset = "0x2918FC0", VA = "0x182919FC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool YFYXGCQSVOU
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x291A020", Offset = "0x2919020", VA = "0x18291A020", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x291A750", Offset = "0x2919750", VA = "0x18291A750")]
		public XCYKGQMIKSR(string? a, string? b, string? c, RoomDoorData.FZNFAKTBVRO.RoomDoorInviteMode d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x291A2B0", Offset = "0x29192B0", VA = "0x18291A2B0")]
		private static CircuitsDestinationTargetType IVFEUBPPKVR(string a, string b, string c)
		{
			return default(CircuitsDestinationTargetType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x291A0D0", Offset = "0x29190D0", VA = "0x18291A0D0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x291A040", Offset = "0x2919040", VA = "0x18291A040", Slot = "12")]
		public bool Equals(XCYKGQMIKSR? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x291A1D0", Offset = "0x29191D0", VA = "0x18291A1D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x291A3A0", Offset = "0x29193A0", VA = "0x18291A3A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x291A320", Offset = "0x2919320", VA = "0x18291A320")]
		[Obsolete("You shouldn't even be able to call serialize on a `null` destination.")]
		public static void RNWSGUUBNYS(XCYKGQMIKSR? self, Stream a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x291A560", Offset = "0x2919560", VA = "0x18291A560")]
		public static XCYKGQMIKSR YNFZNMPNYHA(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x291A700", Offset = "0x2919700", VA = "0x18291A700")]
		public static int ZRSPLMJTNOG(XCYKGQMIKSR? a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class QSHFBEWVVEZ : RRZDPNREULO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string LJHQAHAOKJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string WHFURZVMXOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public List<string> GVWKFYIURND
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int TCFMQGPCDME
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAD05D0", Offset = "0xACF5D0", VA = "0x180AD05D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int UBIPPZXSEHN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xB98E90", Offset = "0xB97E90", VA = "0x180B98E90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int DQRBZGKCVOO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAD6FE0", Offset = "0xAD5FE0", VA = "0x180AD6FE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int NURZJGZKKOP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB1B470", Offset = "0xB1A470", VA = "0x180B1B470", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public UNIBTHIMABE MSJZGYWBSUM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int KIJSRAMPRHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAE9560", Offset = "0xAE8560", VA = "0x180AE9560", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2919660", Offset = "0x2918660", VA = "0x182919660")]
		public QSHFBEWVVEZ(string a, string b, List<string> c, int d, int e, int f, int g, UNIBTHIMABE h, int i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class HNUQRIOBXVC : JTAZPAWUZRZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly Guid TXKKVYGLDVU;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string LYINETZRBNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string ZPMFPMJXRGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int SBHNXTPNFTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAFB170", Offset = "0xAFA170", VA = "0x180AFB170", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool NJDQYAWOKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCAEA10", Offset = "0xCADA10", VA = "0x180CAEA10", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool EZMEVBAIBTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD77530", Offset = "0xD76530", VA = "0x180D77530", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool VCKKXYCKEUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD774E0", Offset = "0xD764E0", VA = "0x180D774E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float DLGLQENRCDT
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB1DBE0", Offset = "0xB1CBE0", VA = "0x180B1DBE0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ObjectiveMarkerDestroyingHandler JEAIZELZQFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2918C20", Offset = "0x2917C20", VA = "0x182918C20", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2918DC0", Offset = "0x2917DC0", VA = "0x182918DC0", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2918F60", Offset = "0x2917F60", VA = "0x182918F60")]
		public HNUQRIOBXVC(string a, Guid b, int c, string d, bool e, bool f, bool g, float h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2918B10", Offset = "0x2917B10", VA = "0x182918B10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2918BB0", Offset = "0x2917BB0", VA = "0x182918BB0")]
		public bool GAKCEAXGPGS(HNUQRIOBXVC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2918C00", Offset = "0x2917C00", VA = "0x182918C00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2918E60", Offset = "0x2917E60", VA = "0x182918E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2918AF0", Offset = "0x2917AF0", VA = "0x182918AF0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2918EC0", Offset = "0x2917EC0", VA = "0x182918EC0")]
		public COVSSKPVAQE UBGNRDBAKQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2918CC0", Offset = "0x2917CC0", VA = "0x182918CC0")]
		public static HNUQRIOBXVC LAMDQBNQDPW(COVSSKPVAQE a, Guid b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class WEGRYIKXQVP : UNIBTHIMABE, IEquatable<WEGRYIKXQVP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int UWBLCVGPTVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string TGIVWCKQBZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string OJOKJNKLZIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string YVEJHIVUUCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ELSOJULCQFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int UIKHXZUQRRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAFB170", Offset = "0xAFA170", VA = "0x180AFB170", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2919EE0", Offset = "0x2918EE0", VA = "0x182919EE0")]
		public WEGRYIKXQVP(int a, string? b, string? c, string? d, string? e, int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2919B00", Offset = "0x2918B00", VA = "0x182919B00", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2919AE0", Offset = "0x2918AE0", VA = "0x182919AE0", Slot = "10")]
		public bool Equals(WEGRYIKXQVP? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2919BB0", Offset = "0x2918BB0", VA = "0x182919BB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2919CB0", Offset = "0x2918CB0", VA = "0x182919CB0")]
		public static void RNWSGUUBNYS(WEGRYIKXQVP a, Stream b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2919D30", Offset = "0x2918D30", VA = "0x182919D30")]
		public static WEGRYIKXQVP YNFZNMPNYHA(Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2919E90", Offset = "0x2918E90", VA = "0x182919E90")]
		public static int ZRSPLMJTNOG(WEGRYIKXQVP a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class QVTNSBFBOQY : LIMIDQITZIR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Guid MLRHXBCEJQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> JOHSDEEOPAW;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Guid TXKKVYGLDVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x29198A0", Offset = "0x29188A0", VA = "0x1829198A0", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> FSGRNFHLEHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2919900", Offset = "0x2918900", VA = "0x182919900")]
		public QVTNSBFBOQY(Guid a, string b, List<string> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
		public void JOQLFUCXDGO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x29198B0", Offset = "0x29188B0", VA = "0x1829198B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2919710", Offset = "0x2918710", VA = "0x182919710")]
		public JNFCEQZXACY EZHGQPFESIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2919790", Offset = "0x2918790", VA = "0x182919790")]
		public static QVTNSBFBOQY QBKWSQOULRS(JNFCEQZXACY a, string b, Guid c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class QDVUTSHAYDT : WAVHLXLYFEQ, IEquatable<QDVUTSHAYDT>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int HAMGKMEAXJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int EKKSLZHWCOY
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB7CE40", Offset = "0xB7BE40", VA = "0x180B7CE40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x29193C0", Offset = "0x29183C0", VA = "0x1829193C0")]
		public QDVUTSHAYDT(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x29190E0", Offset = "0x29180E0", VA = "0x1829190E0")]
		public static QDVUTSHAYDT Default()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x29192C0", Offset = "0x29182C0", VA = "0x1829192C0")]
		public static QDVUTSHAYDT KZZUIVBAPMM(ConstantStorefrontItemData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2919070", Offset = "0x2918070", VA = "0x182919070")]
		public ConstantStorefrontItemData CJIAPTSYSVP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2919340", Offset = "0x2918340", VA = "0x182919340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2919130", Offset = "0x2918130", VA = "0x182919130", Slot = "6")]
		public bool Equals(QDVUTSHAYDT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2919160", Offset = "0x2918160", VA = "0x182919160", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2919250", Offset = "0x2918250", VA = "0x182919250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
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
