using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Events;
using RecNet.Rooms;
using RecRoom.Async;
using RecRoom.Chat.Runtime.MessagePackagers;
using RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers;
using RecRoom.Chat.Runtime.Tokens;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x80E2950", Offset = "0x80E1D50", VA = "0x1880E2950")]
		public NullableAttribute(byte P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Chat_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80E7300", Offset = "0x80E6700", VA = "0x1880E7300", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x273A690", VA = "0x18273B290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : PJGOLIODJYG
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class WOYNMATPKOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage CBNGNAQFWGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> LVMRPUOMYKQ;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public WOYNMATPKOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x80E70B0", Offset = "0x80E64B0", VA = "0x1880E70B0")]
			internal SKSLBBUJUBM YDNSQEKJMFA(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x80E72D0", Offset = "0x80E66D0", VA = "0x1880E72D0")]
			internal void YDSZNLEGVQJ(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class QSAJZAFTFJW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage CBNGNAQFWGP;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public QSAJZAFTFJW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x80E46D0", Offset = "0x80E3AD0", VA = "0x1880E46D0")]
			internal void LNKWNPBFSOT(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class VLMGFEXHLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AKYHWQJFRDD.MessageContentType FNMDQUQROYD;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VLMGFEXHLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x80E6C00", Offset = "0x80E6000", VA = "0x1880E6C00")]
			internal bool QBGKOIENPGW(QCFZWJUJITO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly AKYHWQJFRDD.ILAKBABKYDT HLLJDLDVRLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int VYQKRWJINGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<QCFZWJUJITO> ZBOZXHXUYYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly RMDUBCCZSGW SQUSPHEUFGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly RDDOUOICORO SDBEKCNOKWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IZWZJCDVQPP JCKGRRCUINW;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80E16A0", Offset = "0x80E0AA0", VA = "0x1880E16A0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] RMDUBCCZSGW accountsClient, [Inject(null)] RDDOUOICORO chatClient, [Inject(null)] IZWZJCDVQPP clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80E0820", Offset = "0x80DFC20", VA = "0x1880E0820", Slot = "5")]
		public bool AVQERTZQBFW(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80E1430", Offset = "0x80E0830", VA = "0x1880E1430", Slot = "6")]
		public ChatMessage ZFKJCFPLIDA(long a, AKYHWQJFRDD.ILAKBABKYDT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80E0EE0", Offset = "0x80E02E0", VA = "0x1880E0EE0", Slot = "7")]
		public KOPZSJWAQQR<AKYHWQJFRDD.BWKKJOEVQDN> JZXKIIGAZJW(AKYHWQJFRDD.ILAKBABKYDT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80E1250", Offset = "0x80E0650", VA = "0x1880E1250", Slot = "4")]
		public void QZTBJDQLPRM(QCFZWJUJITO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80E0A10", Offset = "0x80DFE10", VA = "0x1880E0A10", Slot = "8")]
		public void EHELFHZWURX(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80E0CE0", Offset = "0x80E00E0", VA = "0x1880E0CE0")]
		private AKYHWQJFRDD.ILAKBABKYDT FNISLFQUPJZ(AKYHWQJFRDD.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80E0B00", Offset = "0x80DFF00", VA = "0x1880E0B00")]
		private void EYTWCZTNXLG(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80E1050", Offset = "0x80E0450", VA = "0x1880E1050")]
		private void LOEEATZTFRN(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80E1350", Offset = "0x80E0750", VA = "0x1880E1350")]
		private QCFZWJUJITO RGHULBQXDCM(int a, AKYHWQJFRDD.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PJGOLIODJYG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QZTBJDQLPRM(QCFZWJUJITO a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AVQERTZQBFW(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage ZFKJCFPLIDA(long a, AKYHWQJFRDD.ILAKBABKYDT b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		KOPZSJWAQQR<AKYHWQJFRDD.BWKKJOEVQDN> JZXKIIGAZJW(AKYHWQJFRDD.ILAKBABKYDT a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EHELFHZWURX(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface OACTMJKLSBB
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		JQSJODDDNWT<OACTMJKLSBB> ENCPVPYGLDT
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool SOGUSIMACGV
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<VKPNCEMLLAF> HWLYTYCUSWK
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string OEEWMRVQBKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		SKSLBBUJUBM SZRRPGCFERM();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : AKYHWQJFRDD.ILAKBABKYDT
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override AKYHWQJFRDD.MessageContentType SDHPMYQVTHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "10")]
			get
			{
				return default(AKYHWQJFRDD.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80E3730", Offset = "0x80E2B30", VA = "0x1880E3730")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x80E3690", Offset = "0x80E2A90", VA = "0x1880E3690")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : AKYHWQJFRDD.ILAKBABKYDT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long ZGZHVPOUYIE;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override AKYHWQJFRDD.MessageContentType SDHPMYQVTHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910", Slot = "10")]
			get
			{
				return default(AKYHWQJFRDD.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string QYNCNGPYXAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC29C30", Offset = "0xC29030", VA = "0x180C29C30", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long RTPIGIKJDWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x80E3930", Offset = "0x80E2D30", VA = "0x1880E3930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80E39F0", Offset = "0x80E2DF0", VA = "0x1880E39F0")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80E39B0", Offset = "0x80E2DB0", VA = "0x1880E39B0")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class WMWAZPJJPFX
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80E6C80", Offset = "0x80E6080", VA = "0x1880E6C80")]
		[JKCTBFVRGVY.Root]
		internal static void FJCZUIPAULX(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x80E6F60", Offset = "0x80E6360", VA = "0x1880E6F60")]
		[UnityEngine.Scripting.Preserve]
		public WMWAZPJJPFX([Inject(null)] PJGOLIODJYG chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] MADIMQOMXVH textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class ODEZJUZUHRS
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class VKMWSMJNIRA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public OACTMJKLSBB RGGHHMMBWLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool CTIRVARYRGG;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VKMWSMJNIRA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x80E6760", Offset = "0x80E5B60", VA = "0x1880E6760")]
			internal string BPOFZJMUPQQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] EDPSDTMUILA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x80E2C50", Offset = "0x80E2050", VA = "0x1880E2C50")]
		public static KOPZSJWAQQR<string> PRNMSQAFZJY(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x80E2D20", Offset = "0x80E2120", VA = "0x1880E2D20")]
		public static KOPZSJWAQQR<string> PRNMSQAFZJY(AKYHWQJFRDD.ILAKBABKYDT a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80E3230", Offset = "0x80E2630", VA = "0x1880E3230")]
		private static string ZTELKQKEVTQ(OACTMJKLSBB a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80E2AE0", Offset = "0x80E1EE0", VA = "0x1880E2AE0")]
		public static string DUDUTZXDEWE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80E29D0", Offset = "0x80E1DD0", VA = "0x1880E29D0")]
		public static string ACTTBYROMRB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x80E3190", Offset = "0x80E2590", VA = "0x1880E3190")]
		public static bool STDNOSPOAOU(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80E2BE0", Offset = "0x80E1FE0", VA = "0x1880E2BE0")]
		public static bool GREIQXVLAIB(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80E3200", Offset = "0x80E2600", VA = "0x1880E3200")]
		public static bool VPUSMRAPFOK(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80E3040", Offset = "0x80E2440", VA = "0x1880E3040")]
		public static string REAEYSIRTFS(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : AKYHWQJFRDD.ILAKBABKYDT, OACTMJKLSBB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JQSJODDDNWT<OACTMJKLSBB> ENCPVPYGLDT
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<VKPNCEMLLAF> HWLYTYCUSWK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool SOGUSIMACGV
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x80E5B80", Offset = "0x80E4F80", VA = "0x1880E5B80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool SNUBYQZVLOI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x80E5DB0", Offset = "0x80E51B0", VA = "0x1880E5DB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x80E65D0", Offset = "0x80E59D0", VA = "0x1880E65D0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x80E6300", Offset = "0x80E5700", VA = "0x1880E6300")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80E64C0", Offset = "0x80E58C0", VA = "0x1880E64C0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80E5CC0", Offset = "0x80E50C0", VA = "0x1880E5CC0", Slot = "17")]
		public void IYKRXZVSMGS(VKPNCEMLLAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x80E5E40", Offset = "0x80E5240", VA = "0x1880E5E40", Slot = "16")]
		public SKSLBBUJUBM SZRRPGCFERM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x80E6210", Offset = "0x80E5610", VA = "0x1880E6210")]
		private void ZFUBCAYPQGZ(VKPNCEMLLAF a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class VKPNCEMLLAF : IEquatable<VKPNCEMLLAF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JQSJODDDNWT<VKPNCEMLLAF> ENCPVPYGLDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool SOGUSIMACGV
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xBFA2C0", Offset = "0xBF96C0", VA = "0x180BFA2C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC1E0", Offset = "0xAAB5E0", VA = "0x180AAC1E0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool SNUBYQZVLOI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x80E6950", Offset = "0x80E5D50", VA = "0x1880E6950", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string GLXXOFTFPXI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long MMURXGEIPWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAAEFF0", Offset = "0xAAE3F0", VA = "0x180AAEFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ZKQTFPXOJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BD0", Offset = "0xAA2FD0", VA = "0x180AA3BD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object ZPGKTUZTXII
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AB0", Offset = "0xAA8EB0", VA = "0x180AA9AB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public SKSLBBUJUBM WQGXNLZLRAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8C0", Offset = "0xAADCC0", VA = "0x180AAE8C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x80E6B60", Offset = "0x80E5F60", VA = "0x1880E6B60")]
		protected VKPNCEMLLAF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x80E6AB0", Offset = "0x80E5EB0", VA = "0x1880E6AB0")]
		protected VKPNCEMLLAF(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x80E69E0", Offset = "0x80E5DE0", VA = "0x1880E69E0")]
		protected VKPNCEMLLAF(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x80E6990", Offset = "0x80E5D90", VA = "0x1880E6990")]
		protected void VAPOQUCXGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x80E67C0", Offset = "0x80E5BC0", VA = "0x1880E67C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x80E6920", Offset = "0x80E5D20", VA = "0x1880E6920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x80E68A0", Offset = "0x80E5CA0", VA = "0x1880E68A0", Slot = "4")]
		public bool Equals(VKPNCEMLLAF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string WGAMSQLRFWJ(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UOTZGSYGRVF<a, b> : VKPNCEMLLAF where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class LYTSFHXTFCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public VVQOLOWDTTB DRUMWOFTBOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public UOTZGSYGRVF<a, b> ZFLSXXSLHFA;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public LYTSFHXTFCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5336C70", Offset = "0x5336070", VA = "0x185336C70")]
			internal void PUNSYABAZMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a ZPGKTUZTXII
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6103BA0", Offset = "0x6102FA0", VA = "0x186103BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6103BF0", Offset = "0x6102FF0", VA = "0x186103BF0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6103C30", Offset = "0x6103030", VA = "0x186103C30")]
		protected UOTZGSYGRVF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6103CE0", Offset = "0x61030E0", VA = "0x186103CE0")]
		protected UOTZGSYGRVF(string a, long b, string c, KOPZSJWAQQR<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void WYSHOQHQGPC(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6103B50", Offset = "0x6102F50", VA = "0x186103B50")]
		private void GIPCJZSMWIN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6103C10", Offset = "0x6103010", VA = "0x186103C10")]
		[CompilerGenerated]
		private void UJHSGLIMGTA(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum ChatTokenType
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Photo,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		PlayerEvent,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Club
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class MGNUZFFIFAB : UOTZGSYGRVF<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB87E50", Offset = "0xB87250", VA = "0x180B87E50", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x80E2700", Offset = "0x80E1B00", VA = "0x1880E2700")]
		public MGNUZFFIFAB(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x80E2690", Offset = "0x80E1A90", VA = "0x1880E2690")]
		public MGNUZFFIFAB(string a, long b, string c, KOPZSJWAQQR<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x80E25C0", Offset = "0x80E19C0", VA = "0x1880E25C0", Slot = "9")]
		public override string WGAMSQLRFWJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x80E2630", Offset = "0x80E1A30", VA = "0x1880E2630", Slot = "10")]
		protected override void WYSHOQHQGPC(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ICVKVMLAQQR : UOTZGSYGRVF<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB6EB50", Offset = "0xB6DF50", VA = "0x180B6EB50", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x80E1BE0", Offset = "0x80E0FE0", VA = "0x1880E1BE0")]
		public ICVKVMLAQQR(string a, long b, string c, KOPZSJWAQQR<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x80E1B00", Offset = "0x80E0F00", VA = "0x1880E1B00", Slot = "9")]
		public override string WGAMSQLRFWJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x80E1B90", Offset = "0x80E0F90", VA = "0x1880E1B90", Slot = "10")]
		protected override void WYSHOQHQGPC(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class DLNHQZLWEEK : UOTZGSYGRVF<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x80E1A90", Offset = "0x80E0E90", VA = "0x1880E1A90")]
		public DLNHQZLWEEK(string a, long b, string c, KOPZSJWAQQR<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x80E1930", Offset = "0x80E0D30", VA = "0x1880E1930", Slot = "9")]
		public override string WGAMSQLRFWJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x80E1A20", Offset = "0x80E0E20", VA = "0x1880E1A20", Slot = "10")]
		protected override void WYSHOQHQGPC(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class NVQPXUTAQLO : UOTZGSYGRVF<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB78A10", Offset = "0xB77E10", VA = "0x180B78A10", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool SNUBYQZVLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x80E2750", Offset = "0x80E1B50", VA = "0x1880E2750", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x80E2890", Offset = "0x80E1C90", VA = "0x1880E2890")]
		public NVQPXUTAQLO(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x80E28E0", Offset = "0x80E1CE0", VA = "0x1880E28E0")]
		public NVQPXUTAQLO(string a, long b, string c, KOPZSJWAQQR<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x80E27D0", Offset = "0x80E1BD0", VA = "0x1880E27D0", Slot = "9")]
		public override string WGAMSQLRFWJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x80E2840", Offset = "0x80E1C40", VA = "0x1880E2840", Slot = "10")]
		protected override void WYSHOQHQGPC(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class TAJZNDHSPCE : UOTZGSYGRVF<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] TLDZFXPKQFU;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string EMUYCZMVRGS
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6650", Offset = "0xAA5A50", VA = "0x180AA6650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAA68B0", Offset = "0xAA5CB0", VA = "0x180AA68B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool SNUBYQZVLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x80E4880", Offset = "0x80E3C80", VA = "0x1880E4880", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x80E4BD0", Offset = "0x80E3FD0", VA = "0x1880E4BD0")]
		public TAJZNDHSPCE(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x80E4C20", Offset = "0x80E4020", VA = "0x1880E4C20")]
		public TAJZNDHSPCE(string a, long b, string c, KOPZSJWAQQR<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80E49F0", Offset = "0x80E3DF0", VA = "0x1880E49F0", Slot = "9")]
		public override string WGAMSQLRFWJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x80E4AB0", Offset = "0x80E3EB0", VA = "0x1880E4AB0", Slot = "10")]
		protected override void WYSHOQHQGPC(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class VPSHGUYZJDV<a> : QCFZWJUJITO where a : AKYHWQJFRDD.ILAKBABKYDT, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int YUTHJPFLKHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract AKYHWQJFRDD.MessageContentType SDHPMYQVTHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6252F60", Offset = "0x6252360", VA = "0x186252F60", Slot = "7")]
		private AKYHWQJFRDD.ILAKBABKYDT HANWZKBPVAQ(AKYHWQJFRDD.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x62532B0", Offset = "0x62526B0", VA = "0x1862532B0", Slot = "6")]
		private KOPZSJWAQQR<AKYHWQJFRDD.BWKKJOEVQDN> QLPXSLUQDXV(AKYHWQJFRDD.ILAKBABKYDT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6252E80", Offset = "0x6252280", VA = "0x186252E80", Slot = "10")]
		public virtual a FNISLFQUPJZ(AKYHWQJFRDD.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62530E0", Offset = "0x62524E0", VA = "0x1862530E0", Slot = "11")]
		public virtual KOPZSJWAQQR<AKYHWQJFRDD.BWKKJOEVQDN> JZXKIIGAZJW(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "12")]
		protected virtual void PZFNXMIKMAW(a a, AKYHWQJFRDD.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6253060", Offset = "0x6252460", VA = "0x186253060", Slot = "13")]
		protected virtual KOPZSJWAQQR<string> IPRPKUBOWGE(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected VPSHGUYZJDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6252F80", Offset = "0x6252380", VA = "0x186252F80")]
		[CompilerGenerated]
		private AKYHWQJFRDD.BWKKJOEVQDN HNATIVYQLIE(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface QCFZWJUJITO
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int YUTHJPFLKHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		AKYHWQJFRDD.MessageContentType SDHPMYQVTHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		KOPZSJWAQQR<AKYHWQJFRDD.BWKKJOEVQDN> JZXKIIGAZJW(AKYHWQJFRDD.ILAKBABKYDT a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		AKYHWQJFRDD.ILAKBABKYDT FNISLFQUPJZ(AKYHWQJFRDD.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface MADIMQOMXVH : QCFZWJUJITO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RZTGHQPZVII(SCPVZVHYKWE a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : VPSHGUYZJDV<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class BDJMEHURLIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool SNUBYQZVLOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int WFZTCZIPTDX;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string PDNXUMDIUTN
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType FHKJLFTGJNM
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAA8420", Offset = "0xAA7820", VA = "0x180AA8420")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAA8B20", Offset = "0xAA7F20", VA = "0x180AA8B20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int ONFGZPMXMIV
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x133B1E0", Offset = "0x133A5E0", VA = "0x18133B1E0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x133B1F0", Offset = "0x133A5F0", VA = "0x18133B1F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int CKANIYTSTWW
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xAF7490", Offset = "0xAF6890", VA = "0x180AF7490")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string RSFSEPSDBKW
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BD0", Offset = "0xAA2FD0", VA = "0x180AA3BD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x13D2400", Offset = "0x13D1800", VA = "0x1813D2400")]
			public BDJMEHURLIB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum MarkupReplacementType
		{
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			Invalid,
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			Username,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			Roomname,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			Photo
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly NKCTABFGVNS MHXQEIYMOCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly RMDUBCCZSGW SQUSPHEUFGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly LGALVUYYSSU LUANXXSQYWP;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int YUTHJPFLKHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override AKYHWQJFRDD.MessageContentType SDHPMYQVTHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAA5980", Offset = "0xAA4D80", VA = "0x180AA5980", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(AKYHWQJFRDD.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x80E2530", Offset = "0x80E1930", VA = "0x1880E2530")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] NKCTABFGVNS roomsClient, [Inject(null)] RMDUBCCZSGW accountsClient, [Inject(null)] LGALVUYYSSU imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x80E1D70", Offset = "0x80E1170", VA = "0x1880E1D70", Slot = "11")]
		public override KOPZSJWAQQR<AKYHWQJFRDD.BWKKJOEVQDN> JZXKIIGAZJW(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x80E1C50", Offset = "0x80E1050", VA = "0x1880E1C50", Slot = "10")]
		public override TextMessageDetails FNISLFQUPJZ(AKYHWQJFRDD.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x80E1DB0", Offset = "0x80E11B0", VA = "0x1880E1DB0")]
		private void XJJWPDEMRPH(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : VPSHGUYZJDV<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int YUTHJPFLKHY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override AKYHWQJFRDD.MessageContentType SDHPMYQVTHU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "9")]
			get
			{
				return default(AKYHWQJFRDD.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80E3740", Offset = "0x80E2B40", VA = "0x1880E3740")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : VPSHGUYZJDV<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int YUTHJPFLKHY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override AKYHWQJFRDD.MessageContentType SDHPMYQVTHU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910", Slot = "9")]
			get
			{
				return default(AKYHWQJFRDD.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x80E3A00", Offset = "0x80E2E00", VA = "0x1880E3A00", Slot = "12")]
		protected override void PZFNXMIKMAW(PhotoMessageDetails a, AKYHWQJFRDD.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x80E3BA0", Offset = "0x80E2FA0", VA = "0x1880E3BA0")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : VPSHGUYZJDV<TextMessageDetails>, MADIMQOMXVH, QCFZWJUJITO
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class QSAJZAFTFJW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails KYYVBHSJFHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool DRKYBDTFMNV;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public QSAJZAFTFJW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x80E3F20", Offset = "0x80E3320", VA = "0x1880E3F20")]
			internal AKYHWQJFRDD.BWKKJOEVQDN BFPVTAZOYDI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int IOOYAQNHYUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int VSBVHITNUGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, SCPVZVHYKWE> LRQQKCDFNXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, SCPVZVHYKWE> DHSHRDCKKZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TRYFVBKILZF<DLNHQZLWEEK> HQMXLGLLSOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TRYFVBKILZF<TAJZNDHSPCE> VQLSBVBJFFK;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int YUTHJPFLKHY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override AKYHWQJFRDD.MessageContentType SDHPMYQVTHU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "9")]
			get
			{
				return default(AKYHWQJFRDD.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x80E5490", Offset = "0x80E4890", VA = "0x1880E5490", Slot = "14")]
		public void RZTGHQPZVII(SCPVZVHYKWE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x80E4DD0", Offset = "0x80E41D0", VA = "0x1880E4DD0", Slot = "11")]
		public override KOPZSJWAQQR<AKYHWQJFRDD.BWKKJOEVQDN> JZXKIIGAZJW(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x80E5070", Offset = "0x80E4470", VA = "0x1880E5070", Slot = "12")]
		protected override void PZFNXMIKMAW(TextMessageDetails a, AKYHWQJFRDD.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x80E4C90", Offset = "0x80E4090", VA = "0x1880E4C90")]
		private bool BAVNJXZNMTA(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x80E5820", Offset = "0x80E4C20", VA = "0x1880E5820")]
		private static int XSKORCKVNFD(TextMessageDetails a, int b, bool c, SCPVZVHYKWE d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x80E5A60", Offset = "0x80E4E60", VA = "0x1880E5A60")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class DRLDPXLCIYV<a> : TRYFVBKILZF<a>, SCPVZVHYKWE, IEquatable<SCPVZVHYKWE>, IEquatable<ChatTokenType> where a : VKPNCEMLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] JJHBWGEYVQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string UQYRBPCDCFJ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType EWALQBWMHJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string XHZSMRPNXHR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x407F5B0", Offset = "0x407E9B0", VA = "0x18407F5B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char TUGAGIRLDFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char YFIIAIXEZJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType LRQXTBXZVRS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x407F680", Offset = "0x407EA80", VA = "0x18407F680", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x407F790", Offset = "0x407EB90", VA = "0x18407F790")]
		protected DRLDPXLCIYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x407F210", Offset = "0x407E610", VA = "0x18407F210")]
		protected string VMFTAPLLTSV(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x407F310", Offset = "0x407E710", VA = "0x18407F310", Slot = "14")]
		public bool WSHLCSULDZQ(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x407EE80", Offset = "0x407E280", VA = "0x18407EE80", Slot = "15")]
		public void GFJQCFDBWBH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a NNZXFMUVXAU(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x407EC90", Offset = "0x407E090", VA = "0x18407EC90", Slot = "8")]
		private VKPNCEMLLAF DYKWPDBBRAD(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool FPGIFLCRNQX(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string YGDTRCHTCTN(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x407F4D0", Offset = "0x407E8D0", VA = "0x18407F4D0")]
		private bool WYBPLQPSWDN(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x407EFD0", Offset = "0x407E3D0", VA = "0x18407EFD0")]
		private string JSAQVZCEEOR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x407F040", Offset = "0x407E440", VA = "0x18407F040", Slot = "6")]
		private bool TSDFYBEXHAP(string a, [Out] VKPNCEMLLAF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x407EB40", Offset = "0x407DF40", VA = "0x18407EB40", Slot = "7")]
		private void BUEYVLDALHA(VKPNCEMLLAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x407EFA0", Offset = "0x407E3A0", VA = "0x18407EFA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x407ED60", Offset = "0x407E160", VA = "0x18407ED60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x407ECE0", Offset = "0x407E0E0", VA = "0x18407ECE0", Slot = "9")]
		public bool Equals(SCPVZVHYKWE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x407ECB0", Offset = "0x407E0B0", VA = "0x18407ECB0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : IFNLMCJNJWT<MGNUZFFIFAB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly IZWZJCDVQPP JCKGRRCUINW;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType EWALQBWMHJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xB87E50", Offset = "0xB87250", VA = "0x180B87E50", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char TUGAGIRLDFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1C470C0", Offset = "0x1C464C0", VA = "0x181C470C0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char YFIIAIXEZJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x80E1770", Offset = "0x80E0B70", VA = "0x1880E1770", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x80E18D0", Offset = "0x80E0CD0", VA = "0x1880E18D0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] IZWZJCDVQPP clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x80E1780", Offset = "0x80E0B80", VA = "0x1880E1780", Slot = "19")]
		protected override MGNUZFFIFAB YTONHXAJQUY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface SCPVZVHYKWE : IEquatable<SCPVZVHYKWE>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType EWALQBWMHJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string XHZSMRPNXHR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool WSHLCSULDZQ(string a, [Out] VKPNCEMLLAF b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GFJQCFDBWBH(VKPNCEMLLAF a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		VKPNCEMLLAF NNZXFMUVXAU(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface TRYFVBKILZF<a> : SCPVZVHYKWE, IEquatable<SCPVZVHYKWE>, IEquatable<ChatTokenType> where a : VKPNCEMLLAF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : IFNLMCJNJWT<ICVKVMLAQQR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly LGALVUYYSSU LUANXXSQYWP;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType EWALQBWMHJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB6EB50", Offset = "0xB6DF50", VA = "0x180B6EB50", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char TUGAGIRLDFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1C36660", Offset = "0x1C35A60", VA = "0x181C36660", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char YFIIAIXEZJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB462C0", Offset = "0xB456C0", VA = "0x180B462C0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x80E38D0", Offset = "0x80E2CD0", VA = "0x1880E38D0")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] LGALVUYYSSU imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x80E3780", Offset = "0x80E2B80", VA = "0x1880E3780", Slot = "19")]
		protected override ICVKVMLAQQR YTONHXAJQUY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : IFNLMCJNJWT<DLNHQZLWEEK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly RMDUBCCZSGW SQUSPHEUFGZ;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType EWALQBWMHJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB8D910", Offset = "0xB8CD10", VA = "0x180B8D910", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char TUGAGIRLDFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1C8CF10", Offset = "0x1C8C310", VA = "0x181C8CF10", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char YFIIAIXEZJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x80E3BE0", Offset = "0x80E2FE0", VA = "0x1880E3BE0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x80E3D00", Offset = "0x80E3100", VA = "0x1880E3D00")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] RMDUBCCZSGW accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x80E3BF0", Offset = "0x80E2FF0", VA = "0x1880E3BF0", Slot = "19")]
		protected override DLNHQZLWEEK YTONHXAJQUY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : IFNLMCJNJWT<NVQPXUTAQLO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly UXIZXOAUHVZ LCEGGLHKOTX;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType EWALQBWMHJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB78A10", Offset = "0xB77E10", VA = "0x180B78A10", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char TUGAGIRLDFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1C470C0", Offset = "0x1C464C0", VA = "0x181C470C0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char YFIIAIXEZJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x80E3D60", Offset = "0x80E3160", VA = "0x1880E3D60", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x80E3EC0", Offset = "0x80E32C0", VA = "0x1880E3EC0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] UXIZXOAUHVZ playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x80E3D70", Offset = "0x80E3170", VA = "0x1880E3D70", Slot = "19")]
		protected override NVQPXUTAQLO YTONHXAJQUY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : IFNLMCJNJWT<TAJZNDHSPCE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly NKCTABFGVNS MHXQEIYMOCZ;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType EWALQBWMHJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char TUGAGIRLDFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x80E4700", Offset = "0x80E3B00", VA = "0x1880E4700", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char YFIIAIXEZJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1C30360", Offset = "0x1C2F760", VA = "0x181C30360", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x80E4820", Offset = "0x80E3C20", VA = "0x1880E4820")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] NKCTABFGVNS roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x80E4710", Offset = "0x80E3B10", VA = "0x1880E4710", Slot = "19")]
		protected override TAJZNDHSPCE YTONHXAJQUY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class IFNLMCJNJWT<a> : DRLDPXLCIYV<a> where a : VKPNCEMLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5015260", Offset = "0x5014660", VA = "0x185015260", Slot = "16")]
		public override a NNZXFMUVXAU(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x50152A0", Offset = "0x50146A0", VA = "0x1850152A0", Slot = "18")]
		protected override string YGDTRCHTCTN(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5015140", Offset = "0x5014540", VA = "0x185015140", Slot = "17")]
		protected override bool FPGIFLCRNQX(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a YTONHXAJQUY(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5015340", Offset = "0x5014740", VA = "0x185015340")]
		protected IFNLMCJNJWT()
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
