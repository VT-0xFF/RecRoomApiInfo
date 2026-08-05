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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x834FC20", Offset = "0x834EA20", VA = "0x18834FC20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8353760", Offset = "0x8352560", VA = "0x188353760", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2993B20", Offset = "0x2992920", VA = "0x182993B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : OWUYPOYMHBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class ULGETRPVWBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage AOFUAUFQJDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> JODYNQTVHNL;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public ULGETRPVWBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x83522E0", Offset = "0x83510E0", VA = "0x1883522E0")]
			internal DQILUIFDCOX YVSVKBVXIUD(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x83522B0", Offset = "0x83510B0", VA = "0x1883522B0")]
			internal void YVNOMVBZZIU(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NBGIBOJVSSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage AOFUAUFQJDG;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public NBGIBOJVSSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x834F420", Offset = "0x834E220", VA = "0x18834F420")]
			internal void BYZLXNIJLVI(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class UHRWADSOIRM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public MOALZAZHIUW.MessageContentType KWWKPPFYTVS;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public UHRWADSOIRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8352230", Offset = "0x8351030", VA = "0x188352230")]
			internal bool JPCGFSXSRKJ(HFXKHGEZBND a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly MOALZAZHIUW.WDSTPRRTVKU BOPDBQLEQFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int LTMZMHCMRZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<HFXKHGEZBND> DTEZVNJJIWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly INXRDYLVMMJ GFIHMNYPVLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly OYVWIIVLPYX ODWKXHEXSBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly RKUPMDXBVJS VGGGOLKIALF;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x834DE80", Offset = "0x834CC80", VA = "0x18834DE80")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] INXRDYLVMMJ accountsClient, [Inject(null)] OYVWIIVLPYX chatClient, [Inject(null)] RKUPMDXBVJS clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x834D1C0", Offset = "0x834BFC0", VA = "0x18834D1C0", Slot = "5")]
		public bool GUEBRXNCWCN(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x834DC00", Offset = "0x834CA00", VA = "0x18834DC00", Slot = "6")]
		public ChatMessage YWBTSRBESYX(long a, MOALZAZHIUW.WDSTPRRTVKU b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x834D7A0", Offset = "0x834C5A0", VA = "0x18834D7A0", Slot = "7")]
		public WCGMKCSPRXW<MOALZAZHIUW.YPEEUJASBLS> WACTPUPUOLN(MOALZAZHIUW.WDSTPRRTVKU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x834D3B0", Offset = "0x834C1B0", VA = "0x18834D3B0", Slot = "4")]
		public void IVURLXAXWLD(HFXKHGEZBND a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x834D6B0", Offset = "0x834C4B0", VA = "0x18834D6B0", Slot = "8")]
		public void VGKCEZIPOGC(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x834D920", Offset = "0x834C720", VA = "0x18834D920")]
		private MOALZAZHIUW.WDSTPRRTVKU WLVAJGXYFZK(MOALZAZHIUW.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x834CFE0", Offset = "0x834BDE0", VA = "0x18834CFE0")]
		private void GFXCYKDDMEJ(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x834D4B0", Offset = "0x834C2B0", VA = "0x18834D4B0")]
		private void KSWEXHEOJZM(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x834DB20", Offset = "0x834C920", VA = "0x18834DB20")]
		private HFXKHGEZBND YOIRZFQJFOH(int a, MOALZAZHIUW.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface OWUYPOYMHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IVURLXAXWLD(HFXKHGEZBND a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GUEBRXNCWCN(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage YWBTSRBESYX(long a, MOALZAZHIUW.WDSTPRRTVKU b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		WCGMKCSPRXW<MOALZAZHIUW.YPEEUJASBLS> WACTPUPUOLN(MOALZAZHIUW.WDSTPRRTVKU a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VGKCEZIPOGC(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface PJJGGQGEUGC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		YVFAYFMDPIA<PJJGGQGEUGC> ULZPBUPJDGO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool MXVFKJTMUBY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<HBVIXYPAGLA> PHTAESIPONN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string JGQJHTLYZSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		DQILUIFDCOX XFBNCIINKZL();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : MOALZAZHIUW.WDSTPRRTVKU
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override MOALZAZHIUW.MessageContentType WWUZXWYGSYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "10")]
			get
			{
				return default(MOALZAZHIUW.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x834FDA0", Offset = "0x834EBA0", VA = "0x18834FDA0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x834FD00", Offset = "0x834EB00", VA = "0x18834FD00")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : MOALZAZHIUW.WDSTPRRTVKU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long RRPYNLSITLP;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override MOALZAZHIUW.MessageContentType WWUZXWYGSYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150", Slot = "10")]
			get
			{
				return default(MOALZAZHIUW.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string NHMCGDNMKQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB60220", Offset = "0xB5F020", VA = "0x180B60220", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long SGXOPYKNQOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x834FFA0", Offset = "0x834EDA0", VA = "0x18834FFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8350060", Offset = "0x834EE60", VA = "0x188350060")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8350020", Offset = "0x834EE20", VA = "0x188350020")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UYWJGAUASNC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8352650", Offset = "0x8351450", VA = "0x188352650")]
		[XNELNNYDNRZ.Root]
		internal static void VTTXKGNTCNY(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8352930", Offset = "0x8351730", VA = "0x188352930")]
		[UnityEngine.Scripting.Preserve]
		public UYWJGAUASNC([Inject(null)] OWUYPOYMHBH chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] NGLULKUBPOG textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class YIZWVXYGTLT
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OMGLYBCUARB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PJJGGQGEUGC FKVENVTUMPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool JNIRXXYEFPH;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OMGLYBCUARB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x834FCA0", Offset = "0x834EAA0", VA = "0x18834FCA0")]
			internal string EDQCRTSTITL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] EQQLBUCSODL;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83533A0", Offset = "0x83521A0", VA = "0x1883533A0")]
		public static WCGMKCSPRXW<string> TFXKBDVPDPB(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8353080", Offset = "0x8351E80", VA = "0x188353080")]
		public static WCGMKCSPRXW<string> TFXKBDVPDPB(MOALZAZHIUW.WDSTPRRTVKU a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8352A80", Offset = "0x8351880", VA = "0x188352A80")]
		private static string ACCQAIMAMCP(PJJGGQGEUGC a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8352F00", Offset = "0x8351D00", VA = "0x188352F00")]
		public static string NBVVZJXLLRL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83534A0", Offset = "0x83522A0", VA = "0x1883534A0")]
		public static string XWJEBZDOKHI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8353010", Offset = "0x8351E10", VA = "0x188353010")]
		public static bool PHTCXJOJDNT(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8352D40", Offset = "0x8351B40", VA = "0x188352D40")]
		public static bool FOVTNXWGYCC(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8353470", Offset = "0x8352270", VA = "0x188353470")]
		public static bool XKYPTHQTJMF(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8352DB0", Offset = "0x8351BB0", VA = "0x188352DB0")]
		public static string HXFLYRSISCT(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : MOALZAZHIUW.WDSTPRRTVKU, PJJGGQGEUGC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public YVFAYFMDPIA<PJJGGQGEUGC> ULZPBUPJDGO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<HBVIXYPAGLA> PHTAESIPONN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MXVFKJTMUBY
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8351610", Offset = "0x8350410", VA = "0x188351610", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool DMCQXHZTXXV
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8351750", Offset = "0x8350550", VA = "0x188351750", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83520A0", Offset = "0x8350EA0", VA = "0x1883520A0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8351DC0", Offset = "0x8350BC0", VA = "0x188351DC0")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8351F90", Offset = "0x8350D90", VA = "0x188351F90")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83518D0", Offset = "0x83506D0", VA = "0x1883518D0", Slot = "17")]
		public void WGVXUMIHDMD(HBVIXYPAGLA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83519C0", Offset = "0x83507C0", VA = "0x1883519C0", Slot = "16")]
		public DQILUIFDCOX XFBNCIINKZL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83517E0", Offset = "0x83505E0", VA = "0x1883517E0")]
		private void TUOPFFUSEPW(HBVIXYPAGLA a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class HBVIXYPAGLA : IEquatable<HBVIXYPAGLA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public YVFAYFMDPIA<HBVIXYPAGLA> ULZPBUPJDGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool MXVFKJTMUBY
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB869E0", VA = "0x180B87BE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD5B0", Offset = "0xAAC3B0", VA = "0x180AAD5B0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool DMCQXHZTXXV
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x834E600", Offset = "0x834D400", VA = "0x18834E600", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string XVYOZIWISMF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long NEVPWFUMRYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAA0B90", Offset = "0xA9F990", VA = "0x180AA0B90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string IVVXEUOYEWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA58C0", Offset = "0xAA46C0", VA = "0x180AA58C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object LTJHHAASIVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BD0", Offset = "0xA9F9D0", VA = "0x180AA0BD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DQILUIFDCOX NFAMDMLQYXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC10", Offset = "0xA9DA10", VA = "0x180A9EC10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x834E810", Offset = "0x834D610", VA = "0x18834E810")]
		protected HBVIXYPAGLA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x834E760", Offset = "0x834D560", VA = "0x18834E760")]
		protected HBVIXYPAGLA(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x834E690", Offset = "0x834D490", VA = "0x18834E690")]
		protected HBVIXYPAGLA(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x834E640", Offset = "0x834D440", VA = "0x18834E640")]
		protected void LEQENJATCNT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x834E4F0", Offset = "0x834D2F0", VA = "0x18834E4F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x834E5D0", Offset = "0x834D3D0", VA = "0x18834E5D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x834E470", Offset = "0x834D270", VA = "0x18834E470", Slot = "4")]
		public bool Equals(HBVIXYPAGLA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string SFOAEHTXJXO(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class MUSJFAEGBBS<a, b> : HBVIXYPAGLA where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KUZIAGTACLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public RNTACPTQADO SNHWMHESVHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public MUSJFAEGBBS<a, b> SVDPBWSVAHX;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public KUZIAGTACLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x53C7DA0", Offset = "0x53C6BA0", VA = "0x1853C7DA0")]
			internal void DYDTSNFAPRK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a LTJHHAASIVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x59B4AA0", Offset = "0x59B38A0", VA = "0x1859B4AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x59B4B40", Offset = "0x59B3940", VA = "0x1859B4B40")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x59B4B80", Offset = "0x59B3980", VA = "0x1859B4B80")]
		protected MUSJFAEGBBS(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x59B4C30", Offset = "0x59B3A30", VA = "0x1859B4C30")]
		protected MUSJFAEGBBS(string a, long b, string c, WCGMKCSPRXW<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void XGZLXZUUDNJ(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x59B4AF0", Offset = "0x59B38F0", VA = "0x1859B4AF0")]
		private void LWZVINUPUOG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x59B4B60", Offset = "0x59B3960", VA = "0x1859B4B60")]
		[CompilerGenerated]
		private void ULKITIWUZLF(string a)
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
	public class FKAUGXCCQLY : MUSJFAEGBBS<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xDDA9F0", Offset = "0xDD97F0", VA = "0x180DDA9F0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x834E250", Offset = "0x834D050", VA = "0x18834E250")]
		public FKAUGXCCQLY(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x834E1E0", Offset = "0x834CFE0", VA = "0x18834E1E0")]
		public FKAUGXCCQLY(string a, long b, string c, WCGMKCSPRXW<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x834E110", Offset = "0x834CF10", VA = "0x18834E110", Slot = "9")]
		public override string SFOAEHTXJXO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x834E180", Offset = "0x834CF80", VA = "0x18834E180", Slot = "10")]
		protected override void XGZLXZUUDNJ(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class UYPYJNMNDWM : MUSJFAEGBBS<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD864B0", Offset = "0xD852B0", VA = "0x180D864B0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83525E0", Offset = "0x83513E0", VA = "0x1883525E0")]
		public UYPYJNMNDWM(string a, long b, string c, WCGMKCSPRXW<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8352500", Offset = "0x8351300", VA = "0x188352500", Slot = "9")]
		public override string SFOAEHTXJXO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8352590", Offset = "0x8351390", VA = "0x188352590", Slot = "10")]
		protected override void XGZLXZUUDNJ(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class HATNLOOYVEJ : MUSJFAEGBBS<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x834E400", Offset = "0x834D200", VA = "0x18834E400")]
		public HATNLOOYVEJ(string a, long b, string c, WCGMKCSPRXW<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x834E2A0", Offset = "0x834D0A0", VA = "0x18834E2A0", Slot = "9")]
		public override string SFOAEHTXJXO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x834E390", Offset = "0x834D190", VA = "0x18834E390", Slot = "10")]
		protected override void XGZLXZUUDNJ(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class JPVWTYNELSR : MUSJFAEGBBS<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC07F00", Offset = "0xC06D00", VA = "0x180C07F00", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool DMCQXHZTXXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x834E8B0", Offset = "0x834D6B0", VA = "0x18834E8B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x834EA60", Offset = "0x834D860", VA = "0x18834EA60")]
		public JPVWTYNELSR(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x834E9F0", Offset = "0x834D7F0", VA = "0x18834E9F0")]
		public JPVWTYNELSR(string a, long b, string c, WCGMKCSPRXW<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x834E930", Offset = "0x834D730", VA = "0x18834E930", Slot = "9")]
		public override string SFOAEHTXJXO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x834E9A0", Offset = "0x834D7A0", VA = "0x18834E9A0", Slot = "10")]
		protected override void XGZLXZUUDNJ(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AXHQUWMMPWD : MUSJFAEGBBS<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] NSPZQENQGYF;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string XKLGBOYPMVB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAA19A0", Offset = "0xAA07A0", VA = "0x180AA19A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAA19B0", Offset = "0xAA07B0", VA = "0x180AA19B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool DMCQXHZTXXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x834CBB0", Offset = "0x834B9B0", VA = "0x18834CBB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x834CF20", Offset = "0x834BD20", VA = "0x18834CF20")]
		public AXHQUWMMPWD(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x834CF70", Offset = "0x834BD70", VA = "0x18834CF70")]
		public AXHQUWMMPWD(string a, long b, string c, WCGMKCSPRXW<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x834CD30", Offset = "0x834BB30", VA = "0x18834CD30", Slot = "9")]
		public override string SFOAEHTXJXO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x834CDF0", Offset = "0x834BBF0", VA = "0x18834CDF0", Slot = "10")]
		protected override void XGZLXZUUDNJ(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class UGRQZXREZWI<a> : HFXKHGEZBND where a : MOALZAZHIUW.WDSTPRRTVKU, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int SMFKXVOEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract MOALZAZHIUW.MessageContentType WWUZXWYGSYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62DA020", Offset = "0x62D8E20", VA = "0x1862DA020", Slot = "7")]
		private MOALZAZHIUW.WDSTPRRTVKU YLEAXBGAERL(MOALZAZHIUW.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x62D9D10", Offset = "0x62D8B10", VA = "0x1862D9D10", Slot = "6")]
		private WCGMKCSPRXW<MOALZAZHIUW.YPEEUJASBLS> REYISJMJVAS(MOALZAZHIUW.WDSTPRRTVKU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62D9F40", Offset = "0x62D8D40", VA = "0x1862D9F40", Slot = "10")]
		public virtual a WLVAJGXYFZK(MOALZAZHIUW.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62D9D70", Offset = "0x62D8B70", VA = "0x1862D9D70", Slot = "11")]
		public virtual WCGMKCSPRXW<MOALZAZHIUW.YPEEUJASBLS> WACTPUPUOLN(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "12")]
		protected virtual void VEHZDRECAPD(a a, MOALZAZHIUW.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62D9C90", Offset = "0x62D8A90", VA = "0x1862D9C90", Slot = "13")]
		protected virtual WCGMKCSPRXW<string> CPZJNAELYZH(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected UGRQZXREZWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62D9BB0", Offset = "0x62D89B0", VA = "0x1862D9BB0")]
		[CompilerGenerated]
		private MOALZAZHIUW.YPEEUJASBLS CDBZZBXGLSL(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface HFXKHGEZBND
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int SMFKXVOEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		MOALZAZHIUW.MessageContentType WWUZXWYGSYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		WCGMKCSPRXW<MOALZAZHIUW.YPEEUJASBLS> WACTPUPUOLN(MOALZAZHIUW.WDSTPRRTVKU a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		MOALZAZHIUW.WDSTPRRTVKU WLVAJGXYFZK(MOALZAZHIUW.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface NGLULKUBPOG : HFXKHGEZBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KSKTADMTTCZ(QXESOGTVTSX a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : UGRQZXREZWI<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class BPWHGKURBXU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool DMCQXHZTXXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int OSPXJRZIWJQ;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string YEOKEKMDXMW
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType QHIGGIBDJUD
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5F30", VA = "0x180AA7130")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int HFDUPHIQHEE
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x1664390", Offset = "0x1663190", VA = "0x181664390")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1664380", Offset = "0x1663180", VA = "0x181664380")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int JALMCTOJPGL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xAFF070", Offset = "0xAFDE70", VA = "0x180AFF070")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string QTUIHOHMUZB
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAA58C0", Offset = "0xAA46C0", VA = "0x180AA58C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16EAB50", Offset = "0x16E9950", VA = "0x1816EAB50")]
			public BPWHGKURBXU()
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
		private readonly CQFVHHKYRTT ILYZIZWDMTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly INXRDYLVMMJ GFIHMNYPVLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly BBUVSBRJETV ICQAHWTBOAO;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int SMFKXVOEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override MOALZAZHIUW.MessageContentType WWUZXWYGSYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAA7120", Offset = "0xAA5F20", VA = "0x180AA7120", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(MOALZAZHIUW.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x834F390", Offset = "0x834E190", VA = "0x18834F390")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] CQFVHHKYRTT roomsClient, [Inject(null)] INXRDYLVMMJ accountsClient, [Inject(null)] BBUVSBRJETV imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x834F230", Offset = "0x834E030", VA = "0x18834F230", Slot = "11")]
		public override WCGMKCSPRXW<MOALZAZHIUW.YPEEUJASBLS> WACTPUPUOLN(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x834F270", Offset = "0x834E070", VA = "0x18834F270", Slot = "10")]
		public override TextMessageDetails WLVAJGXYFZK(MOALZAZHIUW.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x834EAB0", Offset = "0x834D8B0", VA = "0x18834EAB0")]
		private void PKCIFMCGEJS(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : UGRQZXREZWI<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int SMFKXVOEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override MOALZAZHIUW.MessageContentType WWUZXWYGSYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "9")]
			get
			{
				return default(MOALZAZHIUW.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x834FDB0", Offset = "0x834EBB0", VA = "0x18834FDB0")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : UGRQZXREZWI<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int SMFKXVOEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override MOALZAZHIUW.MessageContentType WWUZXWYGSYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150", Slot = "9")]
			get
			{
				return default(MOALZAZHIUW.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8350070", Offset = "0x834EE70", VA = "0x188350070", Slot = "12")]
		protected override void VEHZDRECAPD(PhotoMessageDetails a, MOALZAZHIUW.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8350210", Offset = "0x834F010", VA = "0x188350210")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : UGRQZXREZWI<TextMessageDetails>, NGLULKUBPOG, HFXKHGEZBND
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class NBGIBOJVSSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails JAOULZQPCWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool OVWUTUMZTLS;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public NBGIBOJVSSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x834F450", Offset = "0x834E250", VA = "0x18834F450")]
			internal MOALZAZHIUW.YPEEUJASBLS LQRZRQFVWQZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int BWIGUCTKYOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int LEEXJZIWVSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, QXESOGTVTSX> VWXTJJIXZXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, QXESOGTVTSX> GCAAKVKVNJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private RBQKQSWCCRS<HATNLOOYVEJ> DQVWHOJJMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private RBQKQSWCCRS<AXHQUWMMPWD> NDADJREWDJH;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int SMFKXVOEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override MOALZAZHIUW.MessageContentType WWUZXWYGSYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "9")]
			get
			{
				return default(MOALZAZHIUW.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8350710", Offset = "0x834F510", VA = "0x188350710", Slot = "14")]
		public void KSKTADMTTCZ(QXESOGTVTSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8351250", Offset = "0x8350050", VA = "0x188351250", Slot = "11")]
		public override WCGMKCSPRXW<MOALZAZHIUW.YPEEUJASBLS> WACTPUPUOLN(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8350E20", Offset = "0x834FC20", VA = "0x188350E20", Slot = "12")]
		protected override void VEHZDRECAPD(TextMessageDetails a, MOALZAZHIUW.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8350AA0", Offset = "0x834F8A0", VA = "0x188350AA0")]
		private bool MFPZEKPEDIT(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8350BE0", Offset = "0x834F9E0", VA = "0x188350BE0")]
		private static int REPQBUIZGNM(TextMessageDetails a, int b, bool c, QXESOGTVTSX d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83514F0", Offset = "0x83502F0", VA = "0x1883514F0")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class GQEYELHRUCU<a> : RBQKQSWCCRS<a>, QXESOGTVTSX, IEquatable<QXESOGTVTSX>, IEquatable<ChatTokenType> where a : HBVIXYPAGLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] EHCIMKVEJZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string NJZDMLPCLEY;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType SBTHELZUTJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string AHUJKVBTYCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x50AF490", Offset = "0x50AE290", VA = "0x1850AF490", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char WHOWZJYXJQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char JLTXJICKORA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType MCOKVDLKHFV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x50AF9F0", Offset = "0x50AE7F0", VA = "0x1850AF9F0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x50AFC50", Offset = "0x50AEA50", VA = "0x1850AFC50")]
		protected GQEYELHRUCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x50AF000", Offset = "0x50ADE00", VA = "0x1850AF000")]
		protected string BIBSWQTVXZM(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x50AF100", Offset = "0x50ADF00", VA = "0x1850AF100", Slot = "14")]
		public bool CUOXAFRLPOP(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x50AF840", Offset = "0x50AE640", VA = "0x1850AF840", Slot = "15")]
		public void NCPLIIKVCDQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a HHIHVUBWGQT(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x50AF960", Offset = "0x50AE760", VA = "0x1850AF960", Slot = "8")]
		private HBVIXYPAGLA USEKMALZEVK(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool DZORAZMGDTM(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string GRDVLAAAJWA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x50AF760", Offset = "0x50AE560", VA = "0x1850AF760")]
		private bool MOFCUJINVCK(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x50AF980", Offset = "0x50AE780", VA = "0x1850AF980")]
		private string VGOIXDZHPWE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x50AF2C0", Offset = "0x50AE0C0", VA = "0x1850AF2C0", Slot = "6")]
		private bool DQOSHDDDRRU(string a, [Out] HBVIXYPAGLA b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x50AFA10", Offset = "0x50AE810", VA = "0x1850AFA10", Slot = "7")]
		private void YCKOCNUXWMV(HBVIXYPAGLA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x50AF730", Offset = "0x50AE530", VA = "0x1850AF730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x50AF610", Offset = "0x50AE410", VA = "0x1850AF610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x50AF560", Offset = "0x50AE360", VA = "0x1850AF560", Slot = "9")]
		public bool Equals(QXESOGTVTSX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x50AF5E0", Offset = "0x50AE3E0", VA = "0x1850AF5E0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : MQEFGAGKFIS<FKAUGXCCQLY>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly RKUPMDXBVJS VGGGOLKIALF;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType SBTHELZUTJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xDDA9F0", Offset = "0xDD97F0", VA = "0x180DDA9F0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char WHOWZJYXJQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1F0BEA0", Offset = "0x1F0ACA0", VA = "0x181F0BEA0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char JLTXJICKORA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x834DF50", Offset = "0x834CD50", VA = "0x18834DF50", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x834E0B0", Offset = "0x834CEB0", VA = "0x18834E0B0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] RKUPMDXBVJS clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x834DF60", Offset = "0x834CD60", VA = "0x18834DF60", Slot = "19")]
		protected override FKAUGXCCQLY UVHUSBCFLYZ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface QXESOGTVTSX : IEquatable<QXESOGTVTSX>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType SBTHELZUTJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string AHUJKVBTYCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CUOXAFRLPOP(string a, [Out] HBVIXYPAGLA b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NCPLIIKVCDQ(HBVIXYPAGLA a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		HBVIXYPAGLA HHIHVUBWGQT(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface RBQKQSWCCRS<a> : QXESOGTVTSX, IEquatable<QXESOGTVTSX>, IEquatable<ChatTokenType> where a : HBVIXYPAGLA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : MQEFGAGKFIS<UYPYJNMNDWM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly BBUVSBRJETV ICQAHWTBOAO;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType SBTHELZUTJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD864B0", Offset = "0xD852B0", VA = "0x180D864B0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char WHOWZJYXJQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F1D1F0", Offset = "0x1F1BFF0", VA = "0x181F1D1F0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char JLTXJICKORA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE74340", Offset = "0xE73140", VA = "0x180E74340", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x834FF40", Offset = "0x834ED40", VA = "0x18834FF40")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] BBUVSBRJETV imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x834FDF0", Offset = "0x834EBF0", VA = "0x18834FDF0", Slot = "19")]
		protected override UYPYJNMNDWM UVHUSBCFLYZ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : MQEFGAGKFIS<HATNLOOYVEJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly INXRDYLVMMJ GFIHMNYPVLC;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType SBTHELZUTJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB00150", Offset = "0xAFEF50", VA = "0x180B00150", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char WHOWZJYXJQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F6EDF0", Offset = "0x1F6DBF0", VA = "0x181F6EDF0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char JLTXJICKORA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8350250", Offset = "0x834F050", VA = "0x188350250", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8350370", Offset = "0x834F170", VA = "0x188350370")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] INXRDYLVMMJ accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8350260", Offset = "0x834F060", VA = "0x188350260", Slot = "19")]
		protected override HATNLOOYVEJ UVHUSBCFLYZ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : MQEFGAGKFIS<JPVWTYNELSR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly ZWRNYTJQJQU MCOTNITOUOQ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType SBTHELZUTJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xC07F00", Offset = "0xC06D00", VA = "0x180C07F00", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char WHOWZJYXJQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F0BEA0", Offset = "0x1F0ACA0", VA = "0x181F0BEA0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char JLTXJICKORA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x83503D0", Offset = "0x834F1D0", VA = "0x1883503D0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8350530", Offset = "0x834F330", VA = "0x188350530")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] ZWRNYTJQJQU playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83503E0", Offset = "0x834F1E0", VA = "0x1883503E0", Slot = "19")]
		protected override JPVWTYNELSR UVHUSBCFLYZ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : MQEFGAGKFIS<AXHQUWMMPWD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly CQFVHHKYRTT ILYZIZWDMTU;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType SBTHELZUTJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char WHOWZJYXJQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8350590", Offset = "0x834F390", VA = "0x188350590", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char JLTXJICKORA
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1EFFAD0", Offset = "0x1EFE8D0", VA = "0x181EFFAD0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83506B0", Offset = "0x834F4B0", VA = "0x1883506B0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] CQFVHHKYRTT roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83505A0", Offset = "0x834F3A0", VA = "0x1883505A0", Slot = "19")]
		protected override AXHQUWMMPWD UVHUSBCFLYZ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class MQEFGAGKFIS<a> : GQEYELHRUCU<a> where a : HBVIXYPAGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5996640", Offset = "0x5995440", VA = "0x185996640", Slot = "16")]
		public override a HHIHVUBWGQT(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x59965A0", Offset = "0x59953A0", VA = "0x1859965A0", Slot = "18")]
		protected override string GRDVLAAAJWA(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5996480", Offset = "0x5995280", VA = "0x185996480", Slot = "17")]
		protected override bool DZORAZMGDTM(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a UVHUSBCFLYZ(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5996680", Offset = "0x5995480", VA = "0x185996680")]
		protected MQEFGAGKFIS()
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
