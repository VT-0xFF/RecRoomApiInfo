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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x81CEF90", Offset = "0x81CD790", VA = "0x1881CEF90")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x81D2370", Offset = "0x81D0B70", VA = "0x1881D2370", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B9F0", VA = "0x18275D1F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : LRSTZYUWWJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class SJZNEKOBZSY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage TPVUVCQSDVW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> HHORJCNVOZT;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public SJZNEKOBZSY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x81CFE80", Offset = "0x81CE680", VA = "0x1881CFE80")]
			internal QNKHPYUXYMH UWEYXVMQLJJ(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x81CFE50", Offset = "0x81CE650", VA = "0x1881CFE50")]
			internal void UVZSAOSTBYA(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FICTOKKRDFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage TPVUVCQSDVW;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public FICTOKKRDFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x81CD830", Offset = "0x81CC030", VA = "0x1881CD830")]
			internal void FTJFHFGKXSC(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class IXGZENONTMW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public YISLLCKWAMK.MessageContentType SRJWLVNXQGA;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public IXGZENONTMW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x81CE160", Offset = "0x81CC960", VA = "0x1881CE160")]
			internal bool AQJNPSEWJRP(PYULUGCUHFX a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly YISLLCKWAMK.EDFRZUGFZMM OBULFRPVXZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int UHZEIUMVNWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<PYULUGCUHFX> TUZYDNXVSUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly LEELAQWBDHT EQHKTHNTOPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly BCCVHTHUELZ DRQSADDLCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XKBJRYJUSTO XARNGPECYLZ;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81CC710", Offset = "0x81CAF10", VA = "0x1881CC710")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] LEELAQWBDHT accountsClient, [Inject(null)] BCCVHTHUELZ chatClient, [Inject(null)] XKBJRYJUSTO clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81CBF40", Offset = "0x81CA740", VA = "0x1881CBF40", Slot = "5")]
		public bool LZICJKMLNLT(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81CB880", Offset = "0x81CA080", VA = "0x1881CB880", Slot = "6")]
		public ChatMessage ACZFYTKRIOP(long a, YISLLCKWAMK.EDFRZUGFZMM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81CBB00", Offset = "0x81CA300", VA = "0x1881CBB00", Slot = "7")]
		public JIREGIBPOUE<YISLLCKWAMK.QJMRPTZNLHG> ECVBFSLBFAT(YISLLCKWAMK.EDFRZUGFZMM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81CBA00", Offset = "0x81CA200", VA = "0x1881CBA00", Slot = "4")]
		public void CVGYMSELQXP(PYULUGCUHFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81CC130", Offset = "0x81CA930", VA = "0x1881CC130", Slot = "8")]
		public void NBZQBMPNTIW(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81CC220", Offset = "0x81CAA20", VA = "0x1881CC220")]
		private YISLLCKWAMK.EDFRZUGFZMM PNSWXOVIMFS(YISLLCKWAMK.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81CBD60", Offset = "0x81CA560", VA = "0x1881CBD60")]
		private void JTVPSZXASMV(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81CC420", Offset = "0x81CAC20", VA = "0x1881CC420")]
		private void XLIBEKYIUPI(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81CBC80", Offset = "0x81CA480", VA = "0x1881CBC80")]
		private PYULUGCUHFX JGTTEENGNFV(int a, YISLLCKWAMK.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface LRSTZYUWWJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CVGYMSELQXP(PYULUGCUHFX a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LZICJKMLNLT(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage ACZFYTKRIOP(long a, YISLLCKWAMK.EDFRZUGFZMM b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		JIREGIBPOUE<YISLLCKWAMK.QJMRPTZNLHG> ECVBFSLBFAT(YISLLCKWAMK.EDFRZUGFZMM a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NBZQBMPNTIW(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface KZVOIBWHMYS
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		WXSKNELZHVC<KZVOIBWHMYS> UXPIDNJGTIO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool OPTMRTPCJVI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<IZMHRGSAFZE> IMJYIJGWCLN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string AROSVOGBSTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		QNKHPYUXYMH IYJNZFGVJQF();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : YISLLCKWAMK.EDFRZUGFZMM
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override YISLLCKWAMK.MessageContentType LNHRUGTPEKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "10")]
			get
			{
				return default(YISLLCKWAMK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81CF4E0", Offset = "0x81CDCE0", VA = "0x1881CF4E0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81CF440", Offset = "0x81CDC40", VA = "0x1881CF440")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : YISLLCKWAMK.EDFRZUGFZMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long CJXDTFXBIDH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override YISLLCKWAMK.MessageContentType LNHRUGTPEKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50", Slot = "10")]
			get
			{
				return default(YISLLCKWAMK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string OREXGFCDXOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC84C50", Offset = "0xC83450", VA = "0x180C84C50", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long KUKBHLVGNSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x81CF6E0", Offset = "0x81CDEE0", VA = "0x1881CF6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81CF7A0", Offset = "0x81CDFA0", VA = "0x1881CF7A0")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81CF760", Offset = "0x81CDF60", VA = "0x1881CF760")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class PTZSADTKSLK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81CF010", Offset = "0x81CD810", VA = "0x1881CF010")]
		[SLGIUIECCXF.Root]
		internal static void WLRWCEUDSTQ(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81CF2F0", Offset = "0x81CDAF0", VA = "0x1881CF2F0")]
		[UnityEngine.Scripting.Preserve]
		public PTZSADTKSLK([Inject(null)] LRSTZYUWWJP chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] CLYQMGVKAAC textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class EAJNINLZQCN
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class WSROETRUXZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public KZVOIBWHMYS IQHUHDLLWQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool DIJQRFTURFX;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WSROETRUXZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x81D1F00", Offset = "0x81D0700", VA = "0x1881D1F00")]
			internal string DBOBPIVWCSZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] OZGEDOOIAWB;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81CCEC0", Offset = "0x81CB6C0", VA = "0x1881CCEC0")]
		public static JIREGIBPOUE<string> AWQBMGFBVOX(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81CCBA0", Offset = "0x81CB3A0", VA = "0x1881CCBA0")]
		public static JIREGIBPOUE<string> AWQBMGFBVOX(YISLLCKWAMK.EDFRZUGFZMM a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81CD000", Offset = "0x81CB800", VA = "0x1881CD000")]
		private static string RNKWZREBIWD(KZVOIBWHMYS a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81CD3D0", Offset = "0x81CBBD0", VA = "0x1881CD3D0")]
		public static string XDNIDGZYNAJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81CD2C0", Offset = "0x81CBAC0", VA = "0x1881CD2C0")]
		public static string RYWXEEAFNPY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81CCF90", Offset = "0x81CB790", VA = "0x1881CCF90")]
		public static bool QLGNSPVWXYB(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81CD4D0", Offset = "0x81CBCD0", VA = "0x1881CD4D0")]
		public static bool XDQTEBZGFUG(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81CCB70", Offset = "0x81CB370", VA = "0x1881CCB70")]
		public static bool ANJZCXRDXLL(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81CD540", Offset = "0x81CBD40", VA = "0x1881CD540")]
		public static string YAURMBZRVTZ(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : YISLLCKWAMK.EDFRZUGFZMM, KZVOIBWHMYS
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public WXSKNELZHVC<KZVOIBWHMYS> UXPIDNJGTIO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<IZMHRGSAFZE> IMJYIJGWCLN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OPTMRTPCJVI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x81D15D0", Offset = "0x81CFDD0", VA = "0x1881D15D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool WOZOQQPPCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x81D1540", Offset = "0x81CFD40", VA = "0x1881D1540", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81D19E0", Offset = "0x81D01E0", VA = "0x1881D19E0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81D1710", Offset = "0x81CFF10", VA = "0x1881D1710")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81D18D0", Offset = "0x81D00D0", VA = "0x1881D18D0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x81D1080", Offset = "0x81CF880", VA = "0x1881D1080", Slot = "17")]
		public void HCLEQAUHPXB(IZMHRGSAFZE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81D1170", Offset = "0x81CF970", VA = "0x1881D1170", Slot = "16")]
		public QNKHPYUXYMH IYJNZFGVJQF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x81D0F90", Offset = "0x81CF790", VA = "0x1881D0F90")]
		private void EFNTCVJYRAU(IZMHRGSAFZE a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class IZMHRGSAFZE : IEquatable<IZMHRGSAFZE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public WXSKNELZHVC<IZMHRGSAFZE> UXPIDNJGTIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool OPTMRTPCJVI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xC19AA0", Offset = "0xC182A0", VA = "0x180C19AA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0610", Offset = "0xAAEE10", VA = "0x180AB0610", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool WOZOQQPPCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x81CE370", Offset = "0x81CCB70", VA = "0x1881CE370", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string ZKIHANWLGSN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long GWBXXLNSIGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB2A0", VA = "0x180AACAA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string YSVIYBPADJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAB1230", Offset = "0xAAFA30", VA = "0x180AB1230")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object JQQCHYZYGRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAACAD0", Offset = "0xAAB2D0", VA = "0x180AACAD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public QNKHPYUXYMH CJPNCOGTCXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB2E0", VA = "0x180AACAE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81CE4D0", Offset = "0x81CCCD0", VA = "0x1881CE4D0")]
		protected IZMHRGSAFZE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81CE570", Offset = "0x81CCD70", VA = "0x1881CE570")]
		protected IZMHRGSAFZE(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81CE400", Offset = "0x81CCC00", VA = "0x1881CE400")]
		protected IZMHRGSAFZE(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81CE3B0", Offset = "0x81CCBB0", VA = "0x1881CE3B0")]
		protected void PHHOSULGRLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x81CE1E0", Offset = "0x81CC9E0", VA = "0x1881CE1E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81CE340", Offset = "0x81CCB40", VA = "0x1881CE340", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x81CE2C0", Offset = "0x81CCAC0", VA = "0x1881CE2C0", Slot = "4")]
		public bool Equals(IZMHRGSAFZE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string VOCMLYGTZAI(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class RUQLOCKGEXG<a, b> : IZMHRGSAFZE where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class JHXZLDGKHPS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public PVTOZSTIILK PNPVYCROUPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public RUQLOCKGEXG<a, b> BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JHXZLDGKHPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x50CC950", Offset = "0x50CB150", VA = "0x1850CC950")]
			internal void MORUMNRQDYQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a JQQCHYZYGRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5C30880", Offset = "0x5C2F080", VA = "0x185C30880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5C30860", Offset = "0x5C2F060", VA = "0x185C30860")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5C30920", Offset = "0x5C2F120", VA = "0x185C30920")]
		protected RUQLOCKGEXG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5C309D0", Offset = "0x5C2F1D0", VA = "0x185C309D0")]
		protected RUQLOCKGEXG(string a, long b, string c, JIREGIBPOUE<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void HTVVRRXZQID(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5C308D0", Offset = "0x5C2F0D0", VA = "0x185C308D0")]
		private void TYACTOJEOLQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5C30840", Offset = "0x5C2F040", VA = "0x185C30840")]
		[CompilerGenerated]
		private void KSBQBDABIHF(string a)
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
	public class WGLAHMAIIAC : RUQLOCKGEXG<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBBBDE0", Offset = "0xBBA5E0", VA = "0x180BBBDE0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x81D1EB0", Offset = "0x81D06B0", VA = "0x1881D1EB0")]
		public WGLAHMAIIAC(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81D1E40", Offset = "0x81D0640", VA = "0x1881D1E40")]
		public WGLAHMAIIAC(string a, long b, string c, JIREGIBPOUE<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81D1DD0", Offset = "0x81D05D0", VA = "0x1881D1DD0", Slot = "9")]
		public override string VOCMLYGTZAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81D1D70", Offset = "0x81D0570", VA = "0x1881D1D70", Slot = "10")]
		protected override void HTVVRRXZQID(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class GXEDQFAMAVG : RUQLOCKGEXG<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xBB3DB0", Offset = "0xBB25B0", VA = "0x180BB3DB0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x81CE0F0", Offset = "0x81CC8F0", VA = "0x1881CE0F0")]
		public GXEDQFAMAVG(string a, long b, string c, JIREGIBPOUE<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81CE060", Offset = "0x81CC860", VA = "0x1881CE060", Slot = "9")]
		public override string VOCMLYGTZAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81CE010", Offset = "0x81CC810", VA = "0x1881CE010", Slot = "10")]
		protected override void HTVVRRXZQID(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class DJTLOYUVLCZ : RUQLOCKGEXG<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81CCB00", Offset = "0x81CB300", VA = "0x1881CCB00")]
		public DJTLOYUVLCZ(string a, long b, string c, JIREGIBPOUE<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x81CCA10", Offset = "0x81CB210", VA = "0x1881CCA10", Slot = "9")]
		public override string VOCMLYGTZAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x81CC9A0", Offset = "0x81CB1A0", VA = "0x1881CC9A0", Slot = "10")]
		protected override void HTVVRRXZQID(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class UFCYJSAPBBH : RUQLOCKGEXG<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xBB6D70", Offset = "0xBB5570", VA = "0x180BB6D70", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool WOZOQQPPCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x81D1BC0", Offset = "0x81D03C0", VA = "0x1881D1BC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x81D1CB0", Offset = "0x81D04B0", VA = "0x1881D1CB0")]
		public UFCYJSAPBBH(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x81D1D00", Offset = "0x81D0500", VA = "0x1881D1D00")]
		public UFCYJSAPBBH(string a, long b, string c, JIREGIBPOUE<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x81D1C40", Offset = "0x81D0440", VA = "0x1881D1C40", Slot = "9")]
		public override string VOCMLYGTZAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x81D1B70", Offset = "0x81D0370", VA = "0x1881D1B70", Slot = "10")]
		protected override void HTVVRRXZQID(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class YRUIJUWNQNV : RUQLOCKGEXG<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] ONXTOIMYBTP;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string TZCKGKHZSWL
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAB3470", Offset = "0xAB1C70", VA = "0x180AB3470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAB3290", Offset = "0xAB1A90", VA = "0x180AB3290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool WOZOQQPPCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x81D1FE0", Offset = "0x81D07E0", VA = "0x1881D1FE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x81D22B0", Offset = "0x81D0AB0", VA = "0x1881D22B0")]
		public YRUIJUWNQNV(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81D2300", Offset = "0x81D0B00", VA = "0x1881D2300")]
		public YRUIJUWNQNV(string a, long b, string c, JIREGIBPOUE<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x81D2150", Offset = "0x81D0950", VA = "0x1881D2150", Slot = "9")]
		public override string VOCMLYGTZAI(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x81D1F60", Offset = "0x81D0760", VA = "0x1881D1F60", Slot = "10")]
		protected override void HTVVRRXZQID(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class ZXHZYWVTDFW<a> : PYULUGCUHFX where a : YISLLCKWAMK.EDFRZUGFZMM, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int GIOWEMQBGCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract YISLLCKWAMK.MessageContentType LNHRUGTPEKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3E843D0", Offset = "0x3E82BD0", VA = "0x183E843D0", Slot = "7")]
		private YISLLCKWAMK.EDFRZUGFZMM CTGZTODANUN(YISLLCKWAMK.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3E84720", Offset = "0x3E82F20", VA = "0x183E84720", Slot = "6")]
		private JIREGIBPOUE<YISLLCKWAMK.QJMRPTZNLHG> HPKVILPWZVM(YISLLCKWAMK.EDFRZUGFZMM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3E84780", Offset = "0x3E82F80", VA = "0x183E84780", Slot = "10")]
		public virtual a PNSWXOVIMFS(YISLLCKWAMK.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3E843F0", Offset = "0x3E82BF0", VA = "0x183E843F0", Slot = "11")]
		public virtual JIREGIBPOUE<YISLLCKWAMK.QJMRPTZNLHG> ECVBFSLBFAT(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "12")]
		protected virtual void QPXESOQNUCR(a a, YISLLCKWAMK.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3E845C0", Offset = "0x3E82DC0", VA = "0x183E845C0", Slot = "13")]
		protected virtual JIREGIBPOUE<string> GIHPNJAQFMJ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected ZXHZYWVTDFW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3E84640", Offset = "0x3E82E40", VA = "0x183E84640")]
		[CompilerGenerated]
		private YISLLCKWAMK.QJMRPTZNLHG GWACTAXJDSP(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface PYULUGCUHFX
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int GIOWEMQBGCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		YISLLCKWAMK.MessageContentType LNHRUGTPEKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		JIREGIBPOUE<YISLLCKWAMK.QJMRPTZNLHG> ECVBFSLBFAT(YISLLCKWAMK.EDFRZUGFZMM a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		YISLLCKWAMK.EDFRZUGFZMM PNSWXOVIMFS(YISLLCKWAMK.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface CLYQMGVKAAC : PYULUGCUHFX
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NAMGSMYOHAB(CYNTHRBZIBJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : ZXHZYWVTDFW<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HSJUJVVOACW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool WOZOQQPPCVJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int JPTHLVSXSSC;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string MYRRJPJXOXA
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType QWAVKIDXYXV
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAB1220", Offset = "0xAAFA20", VA = "0x180AB1220")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int LYUVZQGQGHO
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x136AC40", Offset = "0x1369440", VA = "0x18136AC40")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x136AC30", Offset = "0x1369430", VA = "0x18136AC30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int VQYCSLTECQP
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB02F10", Offset = "0xB01710", VA = "0x180B02F10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string UNFTTZTWCGL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAB1230", Offset = "0xAAFA30", VA = "0x180AB1230")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x140E840", Offset = "0x140D040", VA = "0x18140E840")]
			public HSJUJVVOACW()
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
		private readonly OUOLTIQGZYV IECVRQCQGJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly LEELAQWBDHT EQHKTHNTOPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly KAVETYVOSPZ QHEOHIJGPIG;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int GIOWEMQBGCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override YISLLCKWAMK.MessageContentType LNHRUGTPEKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAB1F10", Offset = "0xAB0710", VA = "0x180AB1F10", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(YISLLCKWAMK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x81CEF00", Offset = "0x81CD700", VA = "0x1881CEF00")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] OUOLTIQGZYV roomsClient, [Inject(null)] LEELAQWBDHT accountsClient, [Inject(null)] KAVETYVOSPZ imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x81CE620", Offset = "0x81CCE20", VA = "0x1881CE620", Slot = "11")]
		public override JIREGIBPOUE<YISLLCKWAMK.QJMRPTZNLHG> ECVBFSLBFAT(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x81CEDE0", Offset = "0x81CD5E0", VA = "0x1881CEDE0", Slot = "10")]
		public override TextMessageDetails PNSWXOVIMFS(YISLLCKWAMK.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81CE660", Offset = "0x81CCE60", VA = "0x1881CE660")]
		private void GQHWARUEXRC(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : ZXHZYWVTDFW<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int GIOWEMQBGCR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override YISLLCKWAMK.MessageContentType LNHRUGTPEKX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "9")]
			get
			{
				return default(YISLLCKWAMK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x81CF4F0", Offset = "0x81CDCF0", VA = "0x1881CF4F0")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : ZXHZYWVTDFW<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int GIOWEMQBGCR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override YISLLCKWAMK.MessageContentType LNHRUGTPEKX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50", Slot = "9")]
			get
			{
				return default(YISLLCKWAMK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x81CF7B0", Offset = "0x81CDFB0", VA = "0x1881CF7B0", Slot = "12")]
		protected override void QPXESOQNUCR(PhotoMessageDetails a, YISLLCKWAMK.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x81CF950", Offset = "0x81CE150", VA = "0x1881CF950")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : ZXHZYWVTDFW<TextMessageDetails>, CLYQMGVKAAC, PYULUGCUHFX
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class FICTOKKRDFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails HFMVHQZZPGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool QQWEXQEGEUY;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public FICTOKKRDFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x81CD860", Offset = "0x81CC060", VA = "0x1881CD860")]
			internal YISLLCKWAMK.QJMRPTZNLHG MGSHUEELTDT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int OJIREEMNEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int SIIQOQCBYXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, CYNTHRBZIBJ> LWPBFVDONGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, CYNTHRBZIBJ> QJRDZVJORCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private BHJDANFXUVW<DJTLOYUVLCZ> RWCPMMKTZFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BHJDANFXUVW<YRUIJUWNQNV> GBAAXEADNEV;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int GIOWEMQBGCR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override YISLLCKWAMK.MessageContentType LNHRUGTPEKX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "9")]
			get
			{
				return default(YISLLCKWAMK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x81D0340", Offset = "0x81CEB40", VA = "0x1881D0340", Slot = "14")]
		public void NAMGSMYOHAB(CYNTHRBZIBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x81D00A0", Offset = "0x81CE8A0", VA = "0x1881D00A0", Slot = "11")]
		public override JIREGIBPOUE<YISLLCKWAMK.QJMRPTZNLHG> ECVBFSLBFAT(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x81D0910", Offset = "0x81CF110", VA = "0x1881D0910", Slot = "12")]
		protected override void QPXESOQNUCR(TextMessageDetails a, YISLLCKWAMK.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x81D0D30", Offset = "0x81CF530", VA = "0x1881D0D30")]
		private bool XNZWIAASTBN(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x81D06D0", Offset = "0x81CEED0", VA = "0x1881D06D0")]
		private static int QCBWSQPRWRY(TextMessageDetails a, int b, bool c, CYNTHRBZIBJ d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81D0E70", Offset = "0x81CF670", VA = "0x1881D0E70")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class LDWTXIHFIIU<a> : BHJDANFXUVW<a>, CYNTHRBZIBJ, IEquatable<CYNTHRBZIBJ>, IEquatable<ChatTokenType> where a : IZMHRGSAFZE
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] BAOYQIFRRNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string SIRXJRCCLWA;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType VTHCCOQRRNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string FCYVMRIOFXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x52EC810", Offset = "0x52EB010", VA = "0x1852EC810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char FGWWLKKFVZR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char DYEZKXRXNSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType VCEKUIADNSP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x52ECAD0", Offset = "0x52EB2D0", VA = "0x1852ECAD0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x52ED0A0", Offset = "0x52EB8A0", VA = "0x1852ED0A0")]
		protected LDWTXIHFIIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x52ECAF0", Offset = "0x52EB2F0", VA = "0x1852ECAF0")]
		protected string NJYSJPGBCXQ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x52ECBF0", Offset = "0x52EB3F0", VA = "0x1852ECBF0", Slot = "14")]
		public bool OJCDRUUEASX(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x52ECDB0", Offset = "0x52EB5B0", VA = "0x1852ECDB0", Slot = "15")]
		public void QRJRMNPOSCO(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a TWWLVXXUQCT(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x52EC8E0", Offset = "0x52EB0E0", VA = "0x1852EC8E0", Slot = "8")]
		private IZMHRGSAFZE JYULNVUOJIE(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool MWDNAECKFKS(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string ANSKHCEIJLK(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x52ECED0", Offset = "0x52EB6D0", VA = "0x1852ECED0")]
		private bool YHEIJBIQMHA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x52EC770", Offset = "0x52EAF70", VA = "0x1852EC770")]
		private string GUCDXLINMPK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x52EC900", Offset = "0x52EB100", VA = "0x1852EC900", Slot = "6")]
		private bool MTPLZXYGOQG(string a, [Out] IZMHRGSAFZE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x52EC380", Offset = "0x52EAB80", VA = "0x1852EC380", Slot = "7")]
		private void DZEICGUBNSR(IZMHRGSAFZE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x52EC7E0", Offset = "0x52EAFE0", VA = "0x1852EC7E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x52EC5E0", Offset = "0x52EADE0", VA = "0x1852EC5E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x52EC500", Offset = "0x52EAD00", VA = "0x1852EC500", Slot = "9")]
		public bool Equals(CYNTHRBZIBJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x52EC4D0", Offset = "0x52EACD0", VA = "0x1852EC4D0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : BGFXOWGPWKG<WGLAHMAIIAC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly XKBJRYJUSTO XARNGPECYLZ;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType VTHCCOQRRNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xBBBDE0", Offset = "0xBBA5E0", VA = "0x180BBBDE0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char FGWWLKKFVZR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1D0ECD0", Offset = "0x1D0D4D0", VA = "0x181D0ECD0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char DYEZKXRXNSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x81CC7E0", Offset = "0x81CAFE0", VA = "0x1881CC7E0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x81CC940", Offset = "0x81CB140", VA = "0x1881CC940")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] XKBJRYJUSTO clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x81CC7F0", Offset = "0x81CAFF0", VA = "0x1881CC7F0", Slot = "19")]
		protected override WGLAHMAIIAC UKMAVYRZFQV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface CYNTHRBZIBJ : IEquatable<CYNTHRBZIBJ>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType VTHCCOQRRNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string FCYVMRIOFXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool OJCDRUUEASX(string a, [Out] IZMHRGSAFZE b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QRJRMNPOSCO(IZMHRGSAFZE a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IZMHRGSAFZE TWWLVXXUQCT(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface BHJDANFXUVW<a> : CYNTHRBZIBJ, IEquatable<CYNTHRBZIBJ>, IEquatable<ChatTokenType> where a : IZMHRGSAFZE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : BGFXOWGPWKG<GXEDQFAMAVG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly KAVETYVOSPZ QHEOHIJGPIG;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType VTHCCOQRRNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xBB3DB0", Offset = "0xBB25B0", VA = "0x180BB3DB0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char FGWWLKKFVZR
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1D04670", Offset = "0x1D02E70", VA = "0x181D04670", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char DYEZKXRXNSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB7D140", Offset = "0xB7B940", VA = "0x180B7D140", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x81CF680", Offset = "0x81CDE80", VA = "0x1881CF680")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] KAVETYVOSPZ imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x81CF530", Offset = "0x81CDD30", VA = "0x1881CF530", Slot = "19")]
		protected override GXEDQFAMAVG UKMAVYRZFQV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : BGFXOWGPWKG<DJTLOYUVLCZ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly LEELAQWBDHT EQHKTHNTOPS;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType VTHCCOQRRNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char FGWWLKKFVZR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1D6DCA0", Offset = "0x1D6C4A0", VA = "0x181D6DCA0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char DYEZKXRXNSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x81CF990", Offset = "0x81CE190", VA = "0x1881CF990", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x81CFAB0", Offset = "0x81CE2B0", VA = "0x1881CFAB0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] LEELAQWBDHT accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x81CF9A0", Offset = "0x81CE1A0", VA = "0x1881CF9A0", Slot = "19")]
		protected override DJTLOYUVLCZ UKMAVYRZFQV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : BGFXOWGPWKG<UFCYJSAPBBH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly TGPDFPAEFVO AGBXHYLPKCM;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType VTHCCOQRRNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xBB6D70", Offset = "0xBB5570", VA = "0x180BB6D70", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char FGWWLKKFVZR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1D0ECD0", Offset = "0x1D0D4D0", VA = "0x181D0ECD0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char DYEZKXRXNSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x81CFB10", Offset = "0x81CE310", VA = "0x1881CFB10", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x81CFC70", Offset = "0x81CE470", VA = "0x1881CFC70")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] TGPDFPAEFVO playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x81CFB20", Offset = "0x81CE320", VA = "0x1881CFB20", Slot = "19")]
		protected override UFCYJSAPBBH UKMAVYRZFQV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : BGFXOWGPWKG<YRUIJUWNQNV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly OUOLTIQGZYV IECVRQCQGJU;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType VTHCCOQRRNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char FGWWLKKFVZR
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x81CFCD0", Offset = "0x81CE4D0", VA = "0x1881CFCD0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char DYEZKXRXNSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1CE8BE0", Offset = "0x1CE73E0", VA = "0x181CE8BE0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x81CFDF0", Offset = "0x81CE5F0", VA = "0x1881CFDF0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] OUOLTIQGZYV roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x81CFCE0", Offset = "0x81CE4E0", VA = "0x1881CFCE0", Slot = "19")]
		protected override YRUIJUWNQNV UKMAVYRZFQV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class BGFXOWGPWKG<a> : LDWTXIHFIIU<a> where a : IZMHRGSAFZE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A6E0", Offset = "0x6F68EE0", VA = "0x186F6A6E0", Slot = "16")]
		public override a TWWLVXXUQCT(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A520", Offset = "0x6F68D20", VA = "0x186F6A520", Slot = "18")]
		protected override string ANSKHCEIJLK(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A5C0", Offset = "0x6F68DC0", VA = "0x186F6A5C0", Slot = "17")]
		protected override bool MWDNAECKFKS(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a UKMAVYRZFQV(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A720", Offset = "0x6F68F20", VA = "0x186F6A720")]
		protected BGFXOWGPWKG()
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
