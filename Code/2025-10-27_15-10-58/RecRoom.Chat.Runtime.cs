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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85EAA40", Offset = "0x85E9A40", VA = "0x1885EAA40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		[Cpp2IlInjected.Address(RVA = "0x85EF7F0", Offset = "0x85EE7F0", VA = "0x1885EF7F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29F5B20", Offset = "0x29F4B20", VA = "0x1829F5B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : YPVXMPHTJIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class WLNPPNEKMUG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage WODAIDNPBQS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> RTUFAHCJNRR;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public WLNPPNEKMUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x85EF570", Offset = "0x85EE570", VA = "0x1885EF570")]
			internal EMLXNRBUHND ZDHKCCXAEZH(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x85EF540", Offset = "0x85EE540", VA = "0x1885EF540")]
			internal void ZDCDEWDCVNY(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class RSBTJIMWGVP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage WODAIDNPBQS;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public RSBTJIMWGVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x85EBF50", Offset = "0x85EAF50", VA = "0x1885EBF50")]
			internal void TGTYSINMPBC(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class NFXTCRZLHHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public CLQEMIJICCY.MessageContentType FSSHVXTUZTU;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public NFXTCRZLHHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x85EA9C0", Offset = "0x85E99C0", VA = "0x1885EA9C0")]
			internal bool WXNCTWKPWQL(PWFFPCVLPVN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly CLQEMIJICCY.OXIPTQLRHMS IOLSLOOPDTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int ZUGFKCWVYIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<PWFFPCVLPVN> EDNJJZUQYGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly PMMPPJAHERZ FEXSWRYYXFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly OWMMLOSJOCJ WIZFTZSIUGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly DUXUAPUPDJI NANHBJDAHGF;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85E9C30", Offset = "0x85E8C30", VA = "0x1885E9C30")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] PMMPPJAHERZ accountsClient, [Inject(null)] OWMMLOSJOCJ chatClient, [Inject(null)] DUXUAPUPDJI clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85E9550", Offset = "0x85E8550", VA = "0x1885E9550", Slot = "5")]
		public bool TPASZUHMVHF(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85E91F0", Offset = "0x85E81F0", VA = "0x1885E91F0", Slot = "6")]
		public ChatMessage RTSRENOKLAR(long a, CLQEMIJICCY.OXIPTQLRHMS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85E8E80", Offset = "0x85E7E80", VA = "0x1885E8E80", Slot = "7")]
		public EHHKMPWOBWW<CLQEMIJICCY.HLJQKGEIDHI> IGDXBPTEXRL(CLQEMIJICCY.OXIPTQLRHMS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85E9A20", Offset = "0x85E8A20", VA = "0x1885E9A20", Slot = "4")]
		public void ZZAZSYMPODZ(PWFFPCVLPVN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85E8D90", Offset = "0x85E7D90", VA = "0x1885E8D90", Slot = "8")]
		public void CVQYKOZKKJW(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9740", Offset = "0x85E8740", VA = "0x1885E9740")]
		private CLQEMIJICCY.OXIPTQLRHMS TXOBKXXDEWW(CLQEMIJICCY.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85E9370", Offset = "0x85E8370", VA = "0x1885E9370")]
		private void TLSRUXXPZHV(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85E8FF0", Offset = "0x85E7FF0", VA = "0x1885E8FF0")]
		private void ITCILWICTNO(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85E9940", Offset = "0x85E8940", VA = "0x1885E9940")]
		private PWFFPCVLPVN ZHZIMRYQKEJ(int a, CLQEMIJICCY.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface YPVXMPHTJIT
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZZAZSYMPODZ(PWFFPCVLPVN a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TPASZUHMVHF(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage RTSRENOKLAR(long a, CLQEMIJICCY.OXIPTQLRHMS b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		EHHKMPWOBWW<CLQEMIJICCY.HLJQKGEIDHI> IGDXBPTEXRL(CLQEMIJICCY.OXIPTQLRHMS a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CVQYKOZKKJW(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface GYEENZHMBCA
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		BJQWATGADFY<GYEENZHMBCA> TGVJDKAVZDS
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool AUWWGGXDFRS
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<VILJQDVSJQQ> MJHALOSMUUN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string JBMRVYMFEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		EMLXNRBUHND CBUGDZEPBCD();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : CLQEMIJICCY.OXIPTQLRHMS
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override CLQEMIJICCY.MessageContentType MIOVBXBKZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "10")]
			get
			{
				return default(CLQEMIJICCY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85EAF90", Offset = "0x85E9F90", VA = "0x1885EAF90")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85EAEF0", Offset = "0x85E9EF0", VA = "0x1885EAEF0")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : CLQEMIJICCY.OXIPTQLRHMS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long PLIEVLPVVIT;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override CLQEMIJICCY.MessageContentType MIOVBXBKZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0", Slot = "10")]
			get
			{
				return default(CLQEMIJICCY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string UIVGABMUZKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB4E050", Offset = "0xB4D050", VA = "0x180B4E050", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long YKOVCEVMZXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85EB190", Offset = "0x85EA190", VA = "0x1885EB190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB250", Offset = "0x85EA250", VA = "0x1885EB250")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85EB210", Offset = "0x85EA210", VA = "0x1885EB210")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VRDFLMWZYFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85EEF10", Offset = "0x85EDF10", VA = "0x1885EEF10")]
		[OKVIBKJHYHD.Root]
		internal static void XPITZMPMBWE(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85EF1F0", Offset = "0x85EE1F0", VA = "0x1885EF1F0")]
		[UnityEngine.Scripting.Preserve]
		public VRDFLMWZYFI([Inject(null)] YPVXMPHTJIT chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] GYJCWWPKURG textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class UIVMHJTYBNV
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class XDIBTWVITXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public GYEENZHMBCA UPJIUABQNPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool IFTTSLZFPKP;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XDIBTWVITXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x85EF790", Offset = "0x85EE790", VA = "0x1885EF790")]
			internal string PWWFOUEXBUD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] MWVPOTFAOIP;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85EE3B0", Offset = "0x85ED3B0", VA = "0x1885EE3B0")]
		public static EHHKMPWOBWW<string> UVYIPWTPLVT(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85EE480", Offset = "0x85ED480", VA = "0x1885EE480")]
		public static EHHKMPWOBWW<string> UVYIPWTPLVT(CLQEMIJICCY.OXIPTQLRHMS a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85EDDF0", Offset = "0x85ECDF0", VA = "0x1885EDDF0")]
		private static string AUWYNLHQZCV(GYEENZHMBCA a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85EE0B0", Offset = "0x85ED0B0", VA = "0x1885EE0B0")]
		public static string FUIWWUCYHWD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85EE1C0", Offset = "0x85ED1C0", VA = "0x1885EE1C0")]
		public static string FUWSDDWGYAU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85EE2D0", Offset = "0x85ED2D0", VA = "0x1885EE2D0")]
		public static bool KTIKFMZHISD(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85EE340", Offset = "0x85ED340", VA = "0x1885EE340")]
		public static bool OLSTSHZPVPG(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85EE8F0", Offset = "0x85ED8F0", VA = "0x1885EE8F0")]
		public static bool VUZHLIPZIHV(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85EE7A0", Offset = "0x85ED7A0", VA = "0x1885EE7A0")]
		public static string VBKODMVYGKZ(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : CLQEMIJICCY.OXIPTQLRHMS, GYEENZHMBCA
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BJQWATGADFY<GYEENZHMBCA> TGVJDKAVZDS
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<VILJQDVSJQQ> MJHALOSMUUN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AUWWGGXDFRS
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x85ED5E0", Offset = "0x85EC5E0", VA = "0x1885ED5E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool ZRJXSFPYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x85ED720", Offset = "0x85EC720", VA = "0x1885ED720", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85EDA90", Offset = "0x85ECA90", VA = "0x1885EDA90")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85ED7B0", Offset = "0x85EC7B0", VA = "0x1885ED7B0")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85ED980", Offset = "0x85EC980", VA = "0x1885ED980")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85ED4F0", Offset = "0x85EC4F0", VA = "0x1885ED4F0", Slot = "17")]
		public void JVLWNOYTBVP(VILJQDVSJQQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85ED000", Offset = "0x85EC000", VA = "0x1885ED000", Slot = "16")]
		public EMLXNRBUHND CBUGDZEPBCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85ED400", Offset = "0x85EC400", VA = "0x1885ED400")]
		private void GTDCTUFGDFA(VILJQDVSJQQ a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class VILJQDVSJQQ : IEquatable<VILJQDVSJQQ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BJQWATGADFY<VILJQDVSJQQ> TGVJDKAVZDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool AUWWGGXDFRS
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xBF9560", Offset = "0xBF8560", VA = "0x180BF9560", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAD5FD0", Offset = "0xAD4FD0", VA = "0x180AD5FD0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool ZRJXSFPYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x85EECB0", Offset = "0x85EDCB0", VA = "0x1885EECB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string FDOWFWZRKTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xACFB10", Offset = "0xACEB10", VA = "0x180ACFB10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long UXMTOLAQFQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAD8F60", Offset = "0xAD7F60", VA = "0x180AD8F60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string HJLVHILQWZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DC0", Offset = "0xACFDC0", VA = "0x180AD0DC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object LJWELDSYKSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xACFFA0", Offset = "0xACEFA0", VA = "0x180ACFFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xACFF40", Offset = "0xACEF40", VA = "0x180ACFF40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public EMLXNRBUHND OBTLVVTXTNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAD6760", Offset = "0xAD5760", VA = "0x180AD6760")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85EECF0", Offset = "0x85EDCF0", VA = "0x1885EECF0")]
		protected VILJQDVSJQQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x85EED90", Offset = "0x85EDD90", VA = "0x1885EED90")]
		protected VILJQDVSJQQ(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x85EEE40", Offset = "0x85EDE40", VA = "0x1885EEE40")]
		protected VILJQDVSJQQ(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x85EEC30", Offset = "0x85EDC30", VA = "0x1885EEC30")]
		protected void GWOECLOSWAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x85EEAD0", Offset = "0x85EDAD0", VA = "0x1885EEAD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85EEC80", Offset = "0x85EDC80", VA = "0x1885EEC80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85EEBB0", Offset = "0x85EDBB0", VA = "0x1885EEBB0", Slot = "4")]
		public bool Equals(VILJQDVSJQQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string ZJFSHZUFATE(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class KFNKPLCNDDI<a, b> : VILJQDVSJQQ where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class MVGSWCHOTEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AUSTWJIEORM SWDOVWNKJSF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public KFNKPLCNDDI<a, b> FOYWNDAXKGX;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public MVGSWCHOTEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5AE8AD0", Offset = "0x5AE7AD0", VA = "0x185AE8AD0")]
			internal void XXYYQFBNSIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a LJWELDSYKSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5506B70", Offset = "0x5505B70", VA = "0x185506B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5506BC0", Offset = "0x5505BC0", VA = "0x185506BC0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5506C50", Offset = "0x5505C50", VA = "0x185506C50")]
		protected KFNKPLCNDDI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5506D00", Offset = "0x5505D00", VA = "0x185506D00")]
		protected KFNKPLCNDDI(string a, long b, string c, EHHKMPWOBWW<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void APHJMYIMEOR(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5506BE0", Offset = "0x5505BE0", VA = "0x185506BE0")]
		private void JLWQPVUUKJS(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5506C30", Offset = "0x5505C30", VA = "0x185506C30")]
		[CompilerGenerated]
		private void VLUKBVGAMPP(string a)
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
	public class IKBBBOVMTFO : KFNKPLCNDDI<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xE2AC50", Offset = "0xE29C50", VA = "0x180E2AC50", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85E9F90", Offset = "0x85E8F90", VA = "0x1885E9F90")]
		public IKBBBOVMTFO(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9FE0", Offset = "0x85E8FE0", VA = "0x1885E9FE0")]
		public IKBBBOVMTFO(string a, long b, string c, EHHKMPWOBWW<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x85E9F20", Offset = "0x85E8F20", VA = "0x1885E9F20", Slot = "9")]
		public override string ZJFSHZUFATE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85E9EC0", Offset = "0x85E8EC0", VA = "0x1885E9EC0", Slot = "10")]
		protected override void APHJMYIMEOR(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ASNXQMKFKSS : KFNKPLCNDDI<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xDF80A0", Offset = "0xDF70A0", VA = "0x180DF80A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x85E8D20", Offset = "0x85E7D20", VA = "0x1885E8D20")]
		public ASNXQMKFKSS(string a, long b, string c, EHHKMPWOBWW<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85E8C90", Offset = "0x85E7C90", VA = "0x1885E8C90", Slot = "9")]
		public override string ZJFSHZUFATE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x85E8C40", Offset = "0x85E7C40", VA = "0x1885E8C40", Slot = "10")]
		protected override void APHJMYIMEOR(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class UAHJBZRAVQL : KFNKPLCNDDI<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85EDD80", Offset = "0x85ECD80", VA = "0x1885EDD80")]
		public UAHJBZRAVQL(string a, long b, string c, EHHKMPWOBWW<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85EDC90", Offset = "0x85ECC90", VA = "0x1885EDC90", Slot = "9")]
		public override string ZJFSHZUFATE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85EDC20", Offset = "0x85ECC20", VA = "0x1885EDC20", Slot = "10")]
		protected override void APHJMYIMEOR(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class WJJGMRPCCVN : KFNKPLCNDDI<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC6B960", Offset = "0xC6A960", VA = "0x180C6B960", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool ZRJXSFPYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x85EF390", Offset = "0x85EE390", VA = "0x1885EF390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85EF480", Offset = "0x85EE480", VA = "0x1885EF480")]
		public WJJGMRPCCVN(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85EF4D0", Offset = "0x85EE4D0", VA = "0x1885EF4D0")]
		public WJJGMRPCCVN(string a, long b, string c, EHHKMPWOBWW<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85EF410", Offset = "0x85EE410", VA = "0x1885EF410", Slot = "9")]
		public override string ZJFSHZUFATE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85EF340", Offset = "0x85EE340", VA = "0x1885EF340", Slot = "10")]
		protected override void APHJMYIMEOR(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class OQOOJUSPFXT : KFNKPLCNDDI<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] VJKEVDSMAEP;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string BNMSFSQMAHH
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xACEE90", Offset = "0xACDE90", VA = "0x180ACEE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xACEBC0", Offset = "0xACDBC0", VA = "0x180ACEBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType OVCFCLRZRCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool ZRJXSFPYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x85EAB40", Offset = "0x85E9B40", VA = "0x1885EAB40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85EAEA0", Offset = "0x85E9EA0", VA = "0x1885EAEA0")]
		public OQOOJUSPFXT(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85EAE30", Offset = "0x85E9E30", VA = "0x1885EAE30")]
		public OQOOJUSPFXT(string a, long b, string c, EHHKMPWOBWW<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85EACC0", Offset = "0x85E9CC0", VA = "0x1885EACC0", Slot = "9")]
		public override string ZJFSHZUFATE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85EAAC0", Offset = "0x85E9AC0", VA = "0x1885EAAC0", Slot = "10")]
		protected override void APHJMYIMEOR(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class QQDXAEYOEPQ<a> : PWFFPCVLPVN where a : CLQEMIJICCY.OXIPTQLRHMS, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int JEPOXRPVYOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract CLQEMIJICCY.MessageContentType MIOVBXBKZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E4F210", Offset = "0x5E4E210", VA = "0x185E4F210", Slot = "7")]
		private CLQEMIJICCY.OXIPTQLRHMS NJFGZJUOPVZ(CLQEMIJICCY.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5E4F310", Offset = "0x5E4E310", VA = "0x185E4F310", Slot = "6")]
		private EHHKMPWOBWW<CLQEMIJICCY.HLJQKGEIDHI> UWAPLSJXQFC(CLQEMIJICCY.OXIPTQLRHMS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4F230", Offset = "0x5E4E230", VA = "0x185E4F230", Slot = "10")]
		public virtual a TXOBKXXDEWW(CLQEMIJICCY.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EEE0", Offset = "0x5E4DEE0", VA = "0x185E4EEE0", Slot = "11")]
		public virtual EHHKMPWOBWW<CLQEMIJICCY.HLJQKGEIDHI> IGDXBPTEXRL(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "12")]
		protected virtual void YKOBSKMKLNJ(a a, CLQEMIJICCY.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4F190", Offset = "0x5E4E190", VA = "0x185E4F190", Slot = "13")]
		protected virtual EHHKMPWOBWW<string> MBAYEQUBJPF(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected QQDXAEYOEPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E4F0B0", Offset = "0x5E4E0B0", VA = "0x185E4F0B0")]
		[CompilerGenerated]
		private CLQEMIJICCY.HLJQKGEIDHI LFBIJTVSKAZ(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface PWFFPCVLPVN
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int JEPOXRPVYOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		CLQEMIJICCY.MessageContentType MIOVBXBKZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EHHKMPWOBWW<CLQEMIJICCY.HLJQKGEIDHI> IGDXBPTEXRL(CLQEMIJICCY.OXIPTQLRHMS a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CLQEMIJICCY.OXIPTQLRHMS TXOBKXXDEWW(CLQEMIJICCY.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface GYJCWWPKURG : PWFFPCVLPVN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QYJOXEVEQHJ(DSMQHJTNNAR a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : QQDXAEYOEPQ<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HNMDOJQEVHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool ZRJXSFPYKWJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int ATDHTRZZUPC;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string QIGDJYXLUTG
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType OVCFCLRZRCZ
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAD13D0", Offset = "0xAD03D0", VA = "0x180AD13D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int VPEXRJYTBEO
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x16BBF00", Offset = "0x16BAF00", VA = "0x1816BBF00")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x16BBEF0", Offset = "0x16BAEF0", VA = "0x1816BBEF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int ZQIGMNWPIMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB29000", Offset = "0xB28000", VA = "0x180B29000")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string WQWHHLVJVMZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAD0DC0", Offset = "0xACFDC0", VA = "0x180AD0DC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x17689F0", Offset = "0x17679F0", VA = "0x1817689F0")]
			public HNMDOJQEVHS()
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
		private readonly DBBFHEMCPOP AZFNOUFRABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly PMMPPJAHERZ FEXSWRYYXFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly CCTSVWMMKWN KZXCFOUBVYE;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int JEPOXRPVYOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override CLQEMIJICCY.MessageContentType MIOVBXBKZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAD13C0", Offset = "0xAD03C0", VA = "0x180AD13C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(CLQEMIJICCY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x85EA930", Offset = "0x85E9930", VA = "0x1885EA930")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] DBBFHEMCPOP roomsClient, [Inject(null)] PMMPPJAHERZ accountsClient, [Inject(null)] CCTSVWMMKWN imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85EA050", Offset = "0x85E9050", VA = "0x1885EA050", Slot = "11")]
		public override EHHKMPWOBWW<CLQEMIJICCY.HLJQKGEIDHI> IGDXBPTEXRL(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x85EA810", Offset = "0x85E9810", VA = "0x1885EA810", Slot = "10")]
		public override TextMessageDetails TXOBKXXDEWW(CLQEMIJICCY.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85EA090", Offset = "0x85E9090", VA = "0x1885EA090")]
		private void NJGRLKCGBBU(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : QQDXAEYOEPQ<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int JEPOXRPVYOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override CLQEMIJICCY.MessageContentType MIOVBXBKZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "9")]
			get
			{
				return default(CLQEMIJICCY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85EAFA0", Offset = "0x85E9FA0", VA = "0x1885EAFA0")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : QQDXAEYOEPQ<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int JEPOXRPVYOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override CLQEMIJICCY.MessageContentType MIOVBXBKZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0", Slot = "9")]
			get
			{
				return default(CLQEMIJICCY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85EB260", Offset = "0x85EA260", VA = "0x1885EB260", Slot = "12")]
		protected override void YKOBSKMKLNJ(PhotoMessageDetails a, CLQEMIJICCY.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85EB400", Offset = "0x85EA400", VA = "0x1885EB400")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : QQDXAEYOEPQ<TextMessageDetails>, GYJCWWPKURG, PWFFPCVLPVN
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class RSBTJIMWGVP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails EUAXTPABLNS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool PDKBFDUUEGC;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public RSBTJIMWGVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x85EB780", Offset = "0x85EA780", VA = "0x1885EB780")]
			internal CLQEMIJICCY.HLJQKGEIDHI FGBCDISMUBF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int LJUAXDSUKKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int JHWYAZEGNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, DSMQHJTNNAR> TTQLPKJHDNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, DSMQHJTNNAR> ZDCYXHDAQXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NKKIKVFSEVQ<UAHJBZRAVQL> REBRCVAKQXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private NKKIKVFSEVQ<OQOOJUSPFXT> CYLTSRQUSKX;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int JEPOXRPVYOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override CLQEMIJICCY.MessageContentType MIOVBXBKZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "9")]
			get
			{
				return default(CLQEMIJICCY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85EC4E0", Offset = "0x85EB4E0", VA = "0x1885EC4E0", Slot = "14")]
		public void QYJOXEVEQHJ(DSMQHJTNNAR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85EC100", Offset = "0x85EB100", VA = "0x1885EC100", Slot = "11")]
		public override EHHKMPWOBWW<CLQEMIJICCY.HLJQKGEIDHI> IGDXBPTEXRL(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85ECAB0", Offset = "0x85EBAB0", VA = "0x1885ECAB0", Slot = "12")]
		protected override void YKOBSKMKLNJ(TextMessageDetails a, CLQEMIJICCY.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x85EC3A0", Offset = "0x85EB3A0", VA = "0x1885EC3A0")]
		private bool IOYVNRVNGPL(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x85EC870", Offset = "0x85EB870", VA = "0x1885EC870")]
		private static int UTZGFAHOYHK(TextMessageDetails a, int b, bool c, DSMQHJTNNAR d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x85ECEE0", Offset = "0x85EBEE0", VA = "0x1885ECEE0")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class SBWMHLMALDI<a> : NKKIKVFSEVQ<a>, DSMQHJTNNAR, IEquatable<DSMQHJTNNAR>, IEquatable<ChatTokenType> where a : VILJQDVSJQQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] YZGPAPPLTXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string AMZXHVIWJKG;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType XQBWRSKJTUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string IUVHTBDJEYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6188FC0", Offset = "0x6187FC0", VA = "0x186188FC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char LBJOPCNPKTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char BQVPIHLXJCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType SQPSJSPFTEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6188FA0", Offset = "0x6187FA0", VA = "0x186188FA0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6189CD0", Offset = "0x6188CD0", VA = "0x186189CD0")]
		protected SBWMHLMALDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6189320", Offset = "0x6188320", VA = "0x186189320")]
		protected string GNPXFSWTWEQ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6189710", Offset = "0x6188710", VA = "0x186189710", Slot = "14")]
		public bool RTJDIESGOFD(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6189AB0", Offset = "0x6188AB0", VA = "0x186189AB0", Slot = "15")]
		public void WZDCSBPVYWU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a OKJXVGWQNZX(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x61894C0", Offset = "0x61884C0", VA = "0x1861894C0", Slot = "8")]
		private VILJQDVSJQQ LYJYNJQSUVE(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool EQTBGGBRAPK(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string ZJOEZTUKTBA(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6189630", Offset = "0x6188630", VA = "0x186189630")]
		private bool OPUTANWTPEA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6189450", Offset = "0x6188450", VA = "0x186189450")]
		private string JHMERENIVTA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x61898D0", Offset = "0x61888D0", VA = "0x1861898D0", Slot = "6")]
		private bool WGBGXCCQWNG(string a, [Out] VILJQDVSJQQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x61894E0", Offset = "0x61884E0", VA = "0x1861894E0", Slot = "7")]
		private void MUFSRHYXKHB(VILJQDVSJQQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6189420", Offset = "0x6188420", VA = "0x186189420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6189090", Offset = "0x6188090", VA = "0x186189090", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6189210", Offset = "0x6188210", VA = "0x186189210", Slot = "9")]
		public bool Equals(DSMQHJTNNAR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x61892F0", Offset = "0x61882F0", VA = "0x1861892F0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : GBFRLBTJGDG<IKBBBOVMTFO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly DUXUAPUPDJI NANHBJDAHGF;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType XQBWRSKJTUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xE2AC50", Offset = "0xE29C50", VA = "0x180E2AC50", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char LBJOPCNPKTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1F7D680", Offset = "0x1F7C680", VA = "0x181F7D680", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char BQVPIHLXJCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E50", Offset = "0x85E8E50", VA = "0x1885E9E50", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E60", Offset = "0x85E8E60", VA = "0x1885E9E60")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] DUXUAPUPDJI clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D00", Offset = "0x85E8D00", VA = "0x1885E9D00", Slot = "19")]
		protected override IKBBBOVMTFO CILTVUPORYX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface DSMQHJTNNAR : IEquatable<DSMQHJTNNAR>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType XQBWRSKJTUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string IUVHTBDJEYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RTJDIESGOFD(string a, [Out] VILJQDVSJQQ b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WZDCSBPVYWU(VILJQDVSJQQ a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		VILJQDVSJQQ OKJXVGWQNZX(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface NKKIKVFSEVQ<a> : DSMQHJTNNAR, IEquatable<DSMQHJTNNAR>, IEquatable<ChatTokenType> where a : VILJQDVSJQQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : GBFRLBTJGDG<ASNXQMKFKSS>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly CCTSVWMMKWN KZXCFOUBVYE;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType XQBWRSKJTUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xDF80A0", Offset = "0xDF70A0", VA = "0x180DF80A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char LBJOPCNPKTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F83CB0", Offset = "0x1F82CB0", VA = "0x181F83CB0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char BQVPIHLXJCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xEDF380", Offset = "0xEDE380", VA = "0x180EDF380", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x85EB130", Offset = "0x85EA130", VA = "0x1885EB130")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] CCTSVWMMKWN imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85EAFE0", Offset = "0x85E9FE0", VA = "0x1885EAFE0", Slot = "19")]
		protected override ASNXQMKFKSS CILTVUPORYX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : GBFRLBTJGDG<UAHJBZRAVQL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly PMMPPJAHERZ FEXSWRYYXFE;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType XQBWRSKJTUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char LBJOPCNPKTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FFBC80", Offset = "0x1FFAC80", VA = "0x181FFBC80", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char BQVPIHLXJCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x85EB550", Offset = "0x85EA550", VA = "0x1885EB550", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x85EB560", Offset = "0x85EA560", VA = "0x1885EB560")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] PMMPPJAHERZ accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB440", Offset = "0x85EA440", VA = "0x1885EB440", Slot = "19")]
		protected override UAHJBZRAVQL CILTVUPORYX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : GBFRLBTJGDG<WJJGMRPCCVN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly YHYFQNBQYZI NRDQFOOEZMS;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType XQBWRSKJTUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xC6B960", Offset = "0xC6A960", VA = "0x180C6B960", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char LBJOPCNPKTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F7D680", Offset = "0x1F7C680", VA = "0x181F7D680", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char BQVPIHLXJCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x85EB710", Offset = "0x85EA710", VA = "0x1885EB710", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x85EB720", Offset = "0x85EA720", VA = "0x1885EB720")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] YHYFQNBQYZI playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85EB5C0", Offset = "0x85EA5C0", VA = "0x1885EB5C0", Slot = "19")]
		protected override WJJGMRPCCVN CILTVUPORYX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : GBFRLBTJGDG<OQOOJUSPFXT>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DBBFHEMCPOP AZFNOUFRABG;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType XQBWRSKJTUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char LBJOPCNPKTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x85EC090", Offset = "0x85EB090", VA = "0x1885EC090", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char BQVPIHLXJCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F6CDE0", Offset = "0x1F6BDE0", VA = "0x181F6CDE0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85EC0A0", Offset = "0x85EB0A0", VA = "0x1885EC0A0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] DBBFHEMCPOP roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85EBF80", Offset = "0x85EAF80", VA = "0x1885EBF80", Slot = "19")]
		protected override OQOOJUSPFXT CILTVUPORYX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class GBFRLBTJGDG<a> : SBWMHLMALDI<a> where a : VILJQDVSJQQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x51F7E40", Offset = "0x51F6E40", VA = "0x1851F7E40", Slot = "16")]
		public override a OKJXVGWQNZX(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x51F7E80", Offset = "0x51F6E80", VA = "0x1851F7E80", Slot = "18")]
		protected override string ZJOEZTUKTBA(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x51F7D20", Offset = "0x51F6D20", VA = "0x1851F7D20", Slot = "17")]
		protected override bool EQTBGGBRAPK(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a CILTVUPORYX(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x51F7F20", Offset = "0x51F6F20", VA = "0x1851F7F20")]
		protected GBFRLBTJGDG()
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
