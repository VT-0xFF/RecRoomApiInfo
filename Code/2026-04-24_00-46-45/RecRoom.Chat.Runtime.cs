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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9888D60", Offset = "0x9887760", VA = "0x189888D60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x988C190", Offset = "0x988AB90", VA = "0x18988C190", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : OSTEAHFBSIW
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class YMQNZVANQVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage AQCOZZJWPVJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public YMQNZVANQVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x988BF40", Offset = "0x988A940", VA = "0x18988BF40")]
			internal LTBUWQFXCGW FDCGZSYQAFU(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x988C160", Offset = "0x988AB60", VA = "0x18988C160")]
			internal void FDHNWZSNJRD(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KNTZTHNOLBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage AQCOZZJWPVJ;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KNTZTHNOLBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x98877C0", Offset = "0x98861C0", VA = "0x1898877C0")]
			internal void GMMUYRKNRJN(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class XPQTJHQZHON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public CRXJESCJKXT.MessageContentType BPDJVAWIBRZ;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XPQTJHQZHON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x988BD30", Offset = "0x988A730", VA = "0x18988BD30")]
			internal bool CBECKJBTHUG(LHLYDTZHJKY a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly CRXJESCJKXT.UPFIKJDICDX AUPVGLFGFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int LTWASDACDAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<LHLYDTZHJKY> SWWHXZTVYUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly OFUIYOTXZUS XOKFWNNTVJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly VTXIATFKQOA THBAYWTOBPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly OTUWDJDFDZL DKVMTQBGFSE;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9886680", Offset = "0x9885080", VA = "0x189886680")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] OFUIYOTXZUS accountsClient, [Inject(null)] VTXIATFKQOA chatClient, [Inject(null)] OTUWDJDFDZL clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98858E0", Offset = "0x98842E0", VA = "0x1898858E0", Slot = "5")]
		public bool FUCLJXZZUWM(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9885AD0", Offset = "0x98844D0", VA = "0x189885AD0", Slot = "6")]
		public ChatMessage HAZDINEUCXM(long a, CRXJESCJKXT.UPFIKJDICDX b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9886400", Offset = "0x9884E00", VA = "0x189886400", Slot = "7")]
		public AUAMWGBNBSF<CRXJESCJKXT.ZOHIUYYFLZB> ZDYDGNJQLHO(CRXJESCJKXT.UPFIKJDICDX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98857D0", Offset = "0x98841D0", VA = "0x1898857D0", Slot = "4")]
		public void DHKVSEGPSNE(LHLYDTZHJKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9885E30", Offset = "0x9884830", VA = "0x189885E30", Slot = "8")]
		public void KDEGZPRYISJ(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9886200", Offset = "0x9884C00", VA = "0x189886200")]
		private CRXJESCJKXT.UPFIKJDICDX QXVNRISECVR(CRXJESCJKXT.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9885C50", Offset = "0x9884650", VA = "0x189885C50")]
		private void HEXFTMNPTUY(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9886000", Offset = "0x9884A00", VA = "0x189886000")]
		private void QOYPIKOGJLV(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9885F20", Offset = "0x9884920", VA = "0x189885F20")]
		private LHLYDTZHJKY OAFWHSBNMHC(int a, CRXJESCJKXT.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface OSTEAHFBSIW
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DHKVSEGPSNE(LHLYDTZHJKY a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FUCLJXZZUWM(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage HAZDINEUCXM(long a, CRXJESCJKXT.UPFIKJDICDX b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		AUAMWGBNBSF<CRXJESCJKXT.ZOHIUYYFLZB> ZDYDGNJQLHO(CRXJESCJKXT.UPFIKJDICDX a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KDEGZPRYISJ(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface OBYGNMJSVVR
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		VEFRPOSZNGH<OBYGNMJSVVR> HMFRTWCEUER
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool JCKSVASQNRX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<QCGENCPMSSZ> LWXBAPBATLI
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string IONDNHXDBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		LTBUWQFXCGW JRNCYNLPNEW();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : CRXJESCJKXT.UPFIKJDICDX
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override CRXJESCJKXT.MessageContentType AEBPKROGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "10")]
			get
			{
				return default(CRXJESCJKXT.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9888E80", Offset = "0x9887880", VA = "0x189888E80")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9888DE0", Offset = "0x98877E0", VA = "0x189888DE0")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : CRXJESCJKXT.UPFIKJDICDX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long WPENQWIJQOU;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override CRXJESCJKXT.MessageContentType AEBPKROGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730", Slot = "10")]
			get
			{
				return default(CRXJESCJKXT.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string FJRXHVWYYEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xF312F0", Offset = "0xF2FCF0", VA = "0x180F312F0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long JLFRZMBTJWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9889080", Offset = "0x9887A80", VA = "0x189889080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9889140", Offset = "0x9887B40", VA = "0x189889140")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9889100", Offset = "0x9887B00", VA = "0x189889100")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UJSKQOIAZRD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x988B8A0", Offset = "0x988A2A0", VA = "0x18988B8A0")]
		[BRMSZAJTATI.Root]
		internal static void DZPCGUXRSGN(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x988BB80", Offset = "0x988A580", VA = "0x18988BB80")]
		[UnityEngine.Scripting.Preserve]
		public UJSKQOIAZRD([Inject(null)] OSTEAHFBSIW chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] CWGCJTKUEIB textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class HVWTOKIEWWA
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public OBYGNMJSVVR XIRKPWUBVKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool WUIELGAZQLM;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x988BCD0", Offset = "0x988A6D0", VA = "0x18988BCD0")]
			internal string SUSCKRJSOYY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] HNQVIAKITJE;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9886910", Offset = "0x9885310", VA = "0x189886910")]
		public static AUAMWGBNBSF<string> AALMVPKNMZA(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98869E0", Offset = "0x98853E0", VA = "0x1898869E0")]
		public static AUAMWGBNBSF<string> AALMVPKNMZA(CRXJESCJKXT.UPFIKJDICDX a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9886F90", Offset = "0x9885990", VA = "0x189886F90")]
		private static string LOXPXKWUIRM(OBYGNMJSVVR a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98872C0", Offset = "0x9885CC0", VA = "0x1898872C0")]
		public static string SITGPVPYCTW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9886E80", Offset = "0x9885880", VA = "0x189886E80")]
		public static string GKIDAYANPZB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9887250", Offset = "0x9885C50", VA = "0x189887250")]
		public static bool PTPLKWTJRTK(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98873D0", Offset = "0x9885DD0", VA = "0x1898873D0")]
		public static bool VAVWQJJXIBD(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9886D00", Offset = "0x9885700", VA = "0x189886D00")]
		public static bool BBYYJVGPUHY(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9886D30", Offset = "0x9885730", VA = "0x189886D30")]
		public static string FNOSJHUMNXC(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : CRXJESCJKXT.UPFIKJDICDX, OBYGNMJSVVR
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public VEFRPOSZNGH<OBYGNMJSVVR> HMFRTWCEUER
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<QCGENCPMSSZ> LWXBAPBATLI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JCKSVASQNRX
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x988AC80", Offset = "0x9889680", VA = "0x18988AC80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x988B2B0", Offset = "0x9889CB0", VA = "0x18988B2B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x988B710", Offset = "0x988A110", VA = "0x18988B710")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x988B430", Offset = "0x9889E30", VA = "0x18988B430")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x988B600", Offset = "0x988A000", VA = "0x18988B600")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x988B1C0", Offset = "0x9889BC0", VA = "0x18988B1C0", Slot = "17")]
		public void KLILSWDZTZM(QCGENCPMSSZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x988ADC0", Offset = "0x98897C0", VA = "0x18988ADC0", Slot = "16")]
		public LTBUWQFXCGW JRNCYNLPNEW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x988B340", Offset = "0x9889D40", VA = "0x18988B340")]
		private void SJYJBNKKYUR(QCGENCPMSSZ a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class QCGENCPMSSZ : IEquatable<QCGENCPMSSZ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public VEFRPOSZNGH<QCGENCPMSSZ> HMFRTWCEUER
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool JCKSVASQNRX
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD14CD0", Offset = "0xD136D0", VA = "0x180D14CD0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9889850", Offset = "0x9888250", VA = "0x189889850", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string ZOOXRPKLOGS
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long ZRUFEOXFIVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xD159E0", Offset = "0xD143E0", VA = "0x180D159E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string XNOXUCKMZXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object UTTUYWCRTKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xD15950", Offset = "0xD14350", VA = "0x180D15950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public LTBUWQFXCGW AFDEINJPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD159C0", Offset = "0xD143C0", VA = "0x180D159C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9889A10", Offset = "0x9888410", VA = "0x189889A10")]
		protected QCGENCPMSSZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9889890", Offset = "0x9888290", VA = "0x189889890")]
		protected QCGENCPMSSZ(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9889940", Offset = "0x9888340", VA = "0x189889940")]
		protected QCGENCPMSSZ(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9889800", Offset = "0x9888200", VA = "0x189889800")]
		protected void HYQMYSPSSVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9889670", Offset = "0x9888070", VA = "0x189889670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x98897D0", Offset = "0x98881D0", VA = "0x1898897D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9889750", Offset = "0x9888150", VA = "0x189889750", Slot = "4")]
		public bool Equals(QCGENCPMSSZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string EJKQYIYUTPT(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UEWDSQTHAOD<a, b> : QCGENCPMSSZ where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PKPAGNSVYSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public NWEYXMFGTGX YFIPPTHXGME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public UEWDSQTHAOD<a, b> TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PKPAGNSVYSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x73E8990", Offset = "0x73E7390", VA = "0x1873E8990")]
			internal void CMYUAFLGSYX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a UTTUYWCRTKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7D1AF80", Offset = "0x7D19980", VA = "0x187D1AF80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7D1AF10", Offset = "0x7D19910", VA = "0x187D1AF10")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B420", Offset = "0x7D19E20", VA = "0x187D1B420")]
		protected UEWDSQTHAOD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7D1AFD0", Offset = "0x7D199D0", VA = "0x187D1AFD0")]
		protected UEWDSQTHAOD(string a, long b, string c, AUAMWGBNBSF<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void OVJJPNQWBMY(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7D1AF30", Offset = "0x7D19930", VA = "0x187D1AF30")]
		private void MXOMIQJVGZH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7D1AEF0", Offset = "0x7D198F0", VA = "0x187D1AEF0")]
		[CompilerGenerated]
		private void AVERROVZHNM(string a)
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
	public class XWVGSBYQGWN : UEWDSQTHAOD<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD7C920", Offset = "0xD7B320", VA = "0x180D7C920", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x988BE80", Offset = "0x988A880", VA = "0x18988BE80")]
		public XWVGSBYQGWN(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x988BED0", Offset = "0x988A8D0", VA = "0x18988BED0")]
		public XWVGSBYQGWN(string a, long b, string c, AUAMWGBNBSF<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x988BDB0", Offset = "0x988A7B0", VA = "0x18988BDB0", Slot = "9")]
		public override string EJKQYIYUTPT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x988BE20", Offset = "0x988A820", VA = "0x18988BE20", Slot = "10")]
		protected override void OVJJPNQWBMY(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class TYCUYJTDLIZ : UEWDSQTHAOD<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD95C00", Offset = "0xD94600", VA = "0x180D95C00", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9889D10", Offset = "0x9888710", VA = "0x189889D10")]
		public TYCUYJTDLIZ(string a, long b, string c, AUAMWGBNBSF<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9889C30", Offset = "0x9888630", VA = "0x189889C30", Slot = "9")]
		public override string EJKQYIYUTPT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9889CC0", Offset = "0x98886C0", VA = "0x189889CC0", Slot = "10")]
		protected override void OVJJPNQWBMY(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class JDMIISYGSQG : UEWDSQTHAOD<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9887750", Offset = "0x9886150", VA = "0x189887750")]
		public JDMIISYGSQG(string a, long b, string c, AUAMWGBNBSF<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x98875F0", Offset = "0x9885FF0", VA = "0x1898875F0", Slot = "9")]
		public override string EJKQYIYUTPT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x98876E0", Offset = "0x98860E0", VA = "0x1898876E0", Slot = "10")]
		protected override void OVJJPNQWBMY(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ABVIWJAAIPS : UEWDSQTHAOD<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD80A40", Offset = "0xD7F440", VA = "0x180D80A40", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9885640", Offset = "0x9884040", VA = "0x189885640", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9885710", Offset = "0x9884110", VA = "0x189885710")]
		public ABVIWJAAIPS(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9885760", Offset = "0x9884160", VA = "0x189885760")]
		public ABVIWJAAIPS(string a, long b, string c, AUAMWGBNBSF<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x98855D0", Offset = "0x9883FD0", VA = "0x1898855D0", Slot = "9")]
		public override string EJKQYIYUTPT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x98856C0", Offset = "0x98840C0", VA = "0x1898856C0", Slot = "10")]
		protected override void OVJJPNQWBMY(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class LFKXWMACQHC : UEWDSQTHAOD<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] PHPHOBJGKZI;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string CCQPHDYYCLA
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD141E0", Offset = "0xD12BE0", VA = "0x180D141E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9888080", Offset = "0x9886A80", VA = "0x189888080", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x98883A0", Offset = "0x9886DA0", VA = "0x1898883A0")]
		public LFKXWMACQHC(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9888330", Offset = "0x9886D30", VA = "0x189888330")]
		public LFKXWMACQHC(string a, long b, string c, AUAMWGBNBSF<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9887FC0", Offset = "0x98869C0", VA = "0x189887FC0", Slot = "9")]
		public override string EJKQYIYUTPT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9888200", Offset = "0x9886C00", VA = "0x189888200", Slot = "10")]
		protected override void OVJJPNQWBMY(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class CTBDGTBXODF<a> : LHLYDTZHJKY where a : CRXJESCJKXT.UPFIKJDICDX, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int VHWQLHXUYAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract CRXJESCJKXT.MessageContentType AEBPKROGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x50AF9E0", Offset = "0x50AE3E0", VA = "0x1850AF9E0", Slot = "7")]
		private CRXJESCJKXT.UPFIKJDICDX QQSKICMLYEQ(CRXJESCJKXT.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x50AF980", Offset = "0x50AE380", VA = "0x1850AF980", Slot = "6")]
		private AUAMWGBNBSF<CRXJESCJKXT.ZOHIUYYFLZB> OWANCEEVXDZ(CRXJESCJKXT.UPFIKJDICDX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x50AFA00", Offset = "0x50AE400", VA = "0x1850AFA00", Slot = "10")]
		public virtual a QXVNRISECVR(CRXJESCJKXT.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x50AFAE0", Offset = "0x50AE4E0", VA = "0x1850AFAE0", Slot = "11")]
		public virtual AUAMWGBNBSF<CRXJESCJKXT.ZOHIUYYFLZB> ZDYDGNJQLHO(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "12")]
		protected virtual void YRHXFRLTHDY(a a, CRXJESCJKXT.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x50AF900", Offset = "0x50AE300", VA = "0x1850AF900", Slot = "13")]
		protected virtual AUAMWGBNBSF<string> MGURSELNVMQ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected CTBDGTBXODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x50AF820", Offset = "0x50AE220", VA = "0x1850AF820")]
		[CompilerGenerated]
		private CRXJESCJKXT.ZOHIUYYFLZB IIUOWZUWHLS(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface LHLYDTZHJKY
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int VHWQLHXUYAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		CRXJESCJKXT.MessageContentType AEBPKROGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AUAMWGBNBSF<CRXJESCJKXT.ZOHIUYYFLZB> ZDYDGNJQLHO(CRXJESCJKXT.UPFIKJDICDX a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CRXJESCJKXT.UPFIKJDICDX QXVNRISECVR(CRXJESCJKXT.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface CWGCJTKUEIB : LHLYDTZHJKY
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PQJQWEFHORG(IJCXLOGBHYQ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : CTBDGTBXODF<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class BIVRIVJCVND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool FGCJYTKVFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int COMQMKNXTRP;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string MVAATEQPOWT
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType AFHKRTOWHTU
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xD1B430", Offset = "0xD19E30", VA = "0x180D1B430")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int OKOIAQMBGDT
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x165B970", Offset = "0x165A370", VA = "0x18165B970")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x165B960", Offset = "0x165A360", VA = "0x18165B960")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int JNTVWJIDUQS
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD67210", Offset = "0xD65C10", VA = "0x180D67210")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string VDDRQJJXKJQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16DB010", Offset = "0x16D9A10", VA = "0x1816DB010")]
			public BIVRIVJCVND()
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
		private readonly YIHAFEOLCGQ HYVVHNVLSXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly OFUIYOTXZUS XOKFWNNTVJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly DLREWFTGYEE RDWWLFKVNDV;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int VHWQLHXUYAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override CRXJESCJKXT.MessageContentType AEBPKROGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(CRXJESCJKXT.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9888CD0", Offset = "0x98876D0", VA = "0x189888CD0")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] YIHAFEOLCGQ roomsClient, [Inject(null)] OFUIYOTXZUS accountsClient, [Inject(null)] DLREWFTGYEE imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9888C90", Offset = "0x9887690", VA = "0x189888C90", Slot = "11")]
		public override AUAMWGBNBSF<CRXJESCJKXT.ZOHIUYYFLZB> ZDYDGNJQLHO(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9888B70", Offset = "0x9887570", VA = "0x189888B70", Slot = "10")]
		public override TextMessageDetails QXVNRISECVR(CRXJESCJKXT.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x98883F0", Offset = "0x9886DF0", VA = "0x1898883F0")]
		private void JBHIOQEKFGN(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : CTBDGTBXODF<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int VHWQLHXUYAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override CRXJESCJKXT.MessageContentType AEBPKROGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "9")]
			get
			{
				return default(CRXJESCJKXT.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9888E90", Offset = "0x9887890", VA = "0x189888E90")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : CTBDGTBXODF<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int VHWQLHXUYAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override CRXJESCJKXT.MessageContentType AEBPKROGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730", Slot = "9")]
			get
			{
				return default(CRXJESCJKXT.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9889150", Offset = "0x9887B50", VA = "0x189889150", Slot = "12")]
		protected override void YRHXFRLTHDY(PhotoMessageDetails a, CRXJESCJKXT.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x98892F0", Offset = "0x9887CF0", VA = "0x1898892F0")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : CTBDGTBXODF<TextMessageDetails>, CWGCJTKUEIB, LHLYDTZHJKY
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class KNTZTHNOLBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails PWLTSFXFCJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool HAFPIANNUAD;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KNTZTHNOLBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x98877F0", Offset = "0x98861F0", VA = "0x1898877F0")]
			internal CRXJESCJKXT.ZOHIUYYFLZB NJZWHTMCUFQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int VLWVWYSEBHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int VRGARFKOVDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, IJCXLOGBHYQ> DGQVAZYTTSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, IJCXLOGBHYQ> PUPJZCKWVLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CLKAGMDHZHF<JDMIISYGSQG> AKJTFHOFESC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private CLKAGMDHZHF<LFKXWMACQHC> CTBDVPVCTTK;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int VHWQLHXUYAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override CRXJESCJKXT.MessageContentType AEBPKROGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "9")]
			get
			{
				return default(CRXJESCJKXT.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9889FC0", Offset = "0x98889C0", VA = "0x189889FC0", Slot = "14")]
		public void PQJQWEFHORG(IJCXLOGBHYQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x988A8C0", Offset = "0x98892C0", VA = "0x18988A8C0", Slot = "11")]
		public override AUAMWGBNBSF<CRXJESCJKXT.ZOHIUYYFLZB> ZDYDGNJQLHO(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x988A490", Offset = "0x9888E90", VA = "0x18988A490", Slot = "12")]
		protected override void YRHXFRLTHDY(TextMessageDetails a, CRXJESCJKXT.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x988A350", Offset = "0x9888D50", VA = "0x18988A350")]
		private bool XZRIWVSHFHI(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9889D80", Offset = "0x9888780", VA = "0x189889D80")]
		private static int IFAMTSFMTUB(TextMessageDetails a, int b, bool c, IJCXLOGBHYQ d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x988AB60", Offset = "0x9889560", VA = "0x18988AB60")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class XAQOVQYZBTX<a> : CLKAGMDHZHF<a>, IJCXLOGBHYQ, IEquatable<IJCXLOGBHYQ>, IEquatable<ChatTokenType> where a : QCGENCPMSSZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] KGXSNVZLRIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string AMZEQDNCFZZ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType ZGNYIVGUKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string IYSVJAIXRID
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x51135D0", Offset = "0x5111FD0", VA = "0x1851135D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char NDLWBWZDHOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char URUOSOWVDDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType HEEALXTJTWU
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x51136D0", Offset = "0x51120D0", VA = "0x1851136D0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5114070", Offset = "0x5112A70", VA = "0x185114070")]
		protected XAQOVQYZBTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x51139F0", Offset = "0x51123F0", VA = "0x1851139F0")]
		protected string XAXKGALSSLT(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5113AF0", Offset = "0x51124F0", VA = "0x185113AF0", Slot = "14")]
		public bool YMUWMWJPKES(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x51136F0", Offset = "0x51120F0", VA = "0x1851136F0", Slot = "15")]
		public void KMMSOIVZEVD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a QFOEHWGTCBK(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5113880", Offset = "0x5112280", VA = "0x185113880", Slot = "8")]
		private QCGENCPMSSZ NXYEQBBCOGP(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool FQPRTBOZVJR(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string LAPVUKZEFOH(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5113CB0", Offset = "0x51126B0", VA = "0x185113CB0")]
		private bool YNNBTWHNJCP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5113810", Offset = "0x5112210", VA = "0x185113810")]
		private string NERZKIVBPHH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5113D90", Offset = "0x5112790", VA = "0x185113D90", Slot = "6")]
		private bool ZLALNHODIKL(string a, [Out] QCGENCPMSSZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x51138A0", Offset = "0x51122A0", VA = "0x1851138A0", Slot = "7")]
		private void UIRDKICNEUG(QCGENCPMSSZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x51136A0", Offset = "0x51120A0", VA = "0x1851136A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5113410", Offset = "0x5111E10", VA = "0x185113410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5113330", Offset = "0x5111D30", VA = "0x185113330", Slot = "9")]
		public bool Equals(IJCXLOGBHYQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x51135A0", Offset = "0x5111FA0", VA = "0x1851135A0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : BVJUOEIHXOP<XWVGSBYQGWN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly OTUWDJDFDZL DKVMTQBGFSE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType ZGNYIVGUKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xD7C920", Offset = "0xD7B320", VA = "0x180D7C920", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char NDLWBWZDHOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FFBF30", Offset = "0x1FFA930", VA = "0x181FFBF30", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char URUOSOWVDDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x98868A0", Offset = "0x98852A0", VA = "0x1898868A0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x98868B0", Offset = "0x98852B0", VA = "0x1898868B0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] OTUWDJDFDZL clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9886750", Offset = "0x9885150", VA = "0x189886750", Slot = "19")]
		protected override XWVGSBYQGWN AWPSRPAGZAY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface IJCXLOGBHYQ : IEquatable<IJCXLOGBHYQ>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType ZGNYIVGUKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string IYSVJAIXRID
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool YMUWMWJPKES(string a, [Out] QCGENCPMSSZ b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KMMSOIVZEVD(QCGENCPMSSZ a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		QCGENCPMSSZ QFOEHWGTCBK(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface CLKAGMDHZHF<a> : IJCXLOGBHYQ, IEquatable<IJCXLOGBHYQ>, IEquatable<ChatTokenType> where a : QCGENCPMSSZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : BVJUOEIHXOP<TYCUYJTDLIZ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly DLREWFTGYEE RDWWLFKVNDV;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType ZGNYIVGUKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD95C00", Offset = "0xD94600", VA = "0x180D95C00", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char NDLWBWZDHOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FE41D0", Offset = "0x1FE2BD0", VA = "0x181FE41D0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char URUOSOWVDDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE39280", Offset = "0xE37C80", VA = "0x180E39280", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9889020", Offset = "0x9887A20", VA = "0x189889020")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] DLREWFTGYEE imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9888ED0", Offset = "0x98878D0", VA = "0x189888ED0", Slot = "19")]
		protected override TYCUYJTDLIZ AWPSRPAGZAY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : BVJUOEIHXOP<JDMIISYGSQG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly OFUIYOTXZUS XOKFWNNTVJP;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType ZGNYIVGUKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char NDLWBWZDHOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x20308B0", Offset = "0x202F2B0", VA = "0x1820308B0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char URUOSOWVDDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9889440", Offset = "0x9887E40", VA = "0x189889440", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9889450", Offset = "0x9887E50", VA = "0x189889450")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] OFUIYOTXZUS accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9889330", Offset = "0x9887D30", VA = "0x189889330", Slot = "19")]
		protected override JDMIISYGSQG AWPSRPAGZAY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : BVJUOEIHXOP<ABVIWJAAIPS>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly XFQYHKYLCWX OLGXIBFGDUN;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType ZGNYIVGUKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD80A40", Offset = "0xD7F440", VA = "0x180D80A40", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char NDLWBWZDHOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FFBF30", Offset = "0x1FFA930", VA = "0x181FFBF30", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char URUOSOWVDDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9889600", Offset = "0x9888000", VA = "0x189889600", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9889610", Offset = "0x9888010", VA = "0x189889610")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] XFQYHKYLCWX playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x98894B0", Offset = "0x9887EB0", VA = "0x1898894B0", Slot = "19")]
		protected override ABVIWJAAIPS AWPSRPAGZAY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : BVJUOEIHXOP<LFKXWMACQHC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly YIHAFEOLCGQ HYVVHNVLSXL;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType ZGNYIVGUKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char NDLWBWZDHOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9889BC0", Offset = "0x98885C0", VA = "0x189889BC0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char URUOSOWVDDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FD6490", Offset = "0x1FD4E90", VA = "0x181FD6490", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9889BD0", Offset = "0x98885D0", VA = "0x189889BD0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] YIHAFEOLCGQ roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9889AB0", Offset = "0x98884B0", VA = "0x189889AB0", Slot = "19")]
		protected override LFKXWMACQHC AWPSRPAGZAY(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class BVJUOEIHXOP<a> : XAQOVQYZBTX<a> where a : QCGENCPMSSZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4F40AF0", Offset = "0x4F3F4F0", VA = "0x184F40AF0", Slot = "16")]
		public override a QFOEHWGTCBK(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4F40A50", Offset = "0x4F3F450", VA = "0x184F40A50", Slot = "18")]
		protected override string LAPVUKZEFOH(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4F40930", Offset = "0x4F3F330", VA = "0x184F40930", Slot = "17")]
		protected override bool FQPRTBOZVJR(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a AWPSRPAGZAY(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4F40B30", Offset = "0x4F3F530", VA = "0x184F40B30")]
		protected BVJUOEIHXOP()
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
