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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x965D610", Offset = "0x965CA10", VA = "0x18965D610")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9661640", Offset = "0x9660A40", VA = "0x189661640", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29FCDD0", Offset = "0x29FC1D0", VA = "0x1829FCDD0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : GAYGVJOOIXI
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class DMEPAFIWFSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage RSZKLIDFDOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> FVWCTSGWIII;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public DMEPAFIWFSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x965BC70", Offset = "0x965B070", VA = "0x18965BC70")]
			internal NKOSDRYVRPY RBVUBVPZNVQ(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x965BE90", Offset = "0x965B290", VA = "0x18965BE90")]
			internal void RCBAZCJWXGZ(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GYKQTNXGTKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage RSZKLIDFDOP;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public GYKQTNXGTKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x965C670", Offset = "0x965BA70", VA = "0x18965C670")]
			internal void QSAOXHPNLVF(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class LRWMZSOUZIR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public FMXLFOLPVDX.MessageContentType BZFLQXHKPOH;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public LRWMZSOUZIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x965C6A0", Offset = "0x965BAA0", VA = "0x18965C6A0")]
			internal bool RVEHWOTQTBE(QZMMBLJJFVC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly FMXLFOLPVDX.YAPWBHCPAIN PUIIHMGLGPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int FAERVMQTCSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<QZMMBLJJFVC> QPRNGKRRLWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly IBQDEAMXLCG RQQCZPLSMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly RJEZMHTQGCY YHFLAQCHEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly EPKVWZTSRAN GWCUOKDSLAY;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x965B9E0", Offset = "0x965ADE0", VA = "0x18965B9E0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] IBQDEAMXLCG accountsClient, [Inject(null)] RJEZMHTQGCY chatClient, [Inject(null)] EPKVWZTSRAN clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x965B3A0", Offset = "0x965A7A0", VA = "0x18965B3A0", Slot = "5")]
		public bool XHICUVZVBSY(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x965B130", Offset = "0x965A530", VA = "0x18965B130", Slot = "6")]
		public ChatMessage VTESDHKGSRQ(long a, FMXLFOLPVDX.YAPWBHCPAIN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x965B770", Offset = "0x965AB70", VA = "0x18965B770", Slot = "7")]
		public FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(FMXLFOLPVDX.YAPWBHCPAIN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x965B030", Offset = "0x965A430", VA = "0x18965B030", Slot = "4")]
		public void TYUTCOYHPES(QZMMBLJJFVC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x965B2B0", Offset = "0x965A6B0", VA = "0x18965B2B0", Slot = "8")]
		public void WCNDLPVJJEB(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x965AB50", Offset = "0x9659F50", VA = "0x18965AB50")]
		private FMXLFOLPVDX.YAPWBHCPAIN FWVQBZPZLRF(FMXLFOLPVDX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x965B590", Offset = "0x965A990", VA = "0x18965B590")]
		private void XLNWSWILGLO(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x965AE30", Offset = "0x965A230", VA = "0x18965AE30")]
		private void PLESSXZHCBF(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x965AD50", Offset = "0x965A150", VA = "0x18965AD50")]
		private QZMMBLJJFVC PHGAGYDUAZO(int a, FMXLFOLPVDX.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface GAYGVJOOIXI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TYUTCOYHPES(QZMMBLJJFVC a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XHICUVZVBSY(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage VTESDHKGSRQ(long a, FMXLFOLPVDX.YAPWBHCPAIN b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(FMXLFOLPVDX.YAPWBHCPAIN a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WCNDLPVJJEB(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface LSMDCSSBFZZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		PCNXPJVUXFJ<LSMDCSSBFZZ> GFYGNKFOOVH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool ATNJOPRHJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<WKGCVHOTMSB> KBKDIYLHNGS
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string YVVJIHKGLFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NKOSDRYVRPY ZFSDVMKAOLM();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : FMXLFOLPVDX.YAPWBHCPAIN
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "10")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x965DB40", Offset = "0x965CF40", VA = "0x18965DB40")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x965DAA0", Offset = "0x965CEA0", VA = "0x18965DAA0")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : FMXLFOLPVDX.YAPWBHCPAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long HVUGJNBCSPS;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "10")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string MVACRNAXYRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xF16910", Offset = "0xF15D10", VA = "0x180F16910", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long GDQSZQICAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x965DD40", Offset = "0x965D140", VA = "0x18965DD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x965DE00", Offset = "0x965D200", VA = "0x18965DE00")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x965DDC0", Offset = "0x965D1C0", VA = "0x18965DDC0")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MSAJPYMMTYN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x965D090", Offset = "0x965C490", VA = "0x18965D090")]
		[BQDQKYYGTTM.Root]
		internal static void ENAKDGREWFX(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x965D370", Offset = "0x965C770", VA = "0x18965D370")]
		[UnityEngine.Scripting.Preserve]
		public MSAJPYMMTYN([Inject(null)] GAYGVJOOIXI chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] RKWIFMXSWRX textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class SYUQKMAUSLG
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class VUGRTXXDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public LSMDCSSBFZZ ZQZZGIFBUFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool NISISINMLWS;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9660DD0", Offset = "0x96601D0", VA = "0x189660DD0")]
			internal string XDJYGUXRRDO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] JWMRKAXHTEW;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x965E710", Offset = "0x965DB10", VA = "0x18965E710")]
		public static FCGSBMYYMMV<string> NZFUCDTVMQS(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x965E7E0", Offset = "0x965DBE0", VA = "0x18965E7E0")]
		public static FCGSBMYYMMV<string> NZFUCDTVMQS(FMXLFOLPVDX.YAPWBHCPAIN a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x965EB00", Offset = "0x965DF00", VA = "0x18965EB00")]
		private static string RPBCULGUZBA(LSMDCSSBFZZ a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x965EDC0", Offset = "0x965E1C0", VA = "0x18965EDC0")]
		public static string SINGSBJOWEE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x965E600", Offset = "0x965DA00", VA = "0x18965E600")]
		public static string HSREIODBBSX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x965EEC0", Offset = "0x965E2C0", VA = "0x18965EEC0")]
		public static bool WSJZFPEQCTW(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x965EF30", Offset = "0x965E330", VA = "0x18965EF30")]
		public static bool YPVRREXOSGZ(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x965EFA0", Offset = "0x965E3A0", VA = "0x18965EFA0")]
		public static bool YVJBCLBDCZU(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x965E4B0", Offset = "0x965D8B0", VA = "0x18965E4B0")]
		public static string HAIFEQYQBRW(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : FMXLFOLPVDX.YAPWBHCPAIN, LSMDCSSBFZZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public PCNXPJVUXFJ<LSMDCSSBFZZ> GFYGNKFOOVH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<WKGCVHOTMSB> KBKDIYLHNGS
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ATNJOPRHJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x96602E0", Offset = "0x965F6E0", VA = "0x1896602E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool EBAROFIKFFG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9660510", Offset = "0x965F910", VA = "0x189660510", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9660C40", Offset = "0x9660040", VA = "0x189660C40")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9660970", Offset = "0x965FD70", VA = "0x189660970")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9660B30", Offset = "0x965FF30", VA = "0x189660B30")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9660420", Offset = "0x965F820", VA = "0x189660420", Slot = "17")]
		public void UAIBTGQENDQ(WKGCVHOTMSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x96605A0", Offset = "0x965F9A0", VA = "0x1896605A0", Slot = "16")]
		public NKOSDRYVRPY ZFSDVMKAOLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x96601F0", Offset = "0x965F5F0", VA = "0x1896601F0")]
		private void KCOOXXMZSRH(WKGCVHOTMSB a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class WKGCVHOTMSB : IEquatable<WKGCVHOTMSB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PCNXPJVUXFJ<WKGCVHOTMSB> GFYGNKFOOVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool ATNJOPRHJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xEABB30", Offset = "0xEAAF30", VA = "0x180EABB30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6C00", Offset = "0xCF6000", VA = "0x180CF6C00", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool EBAROFIKFFG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9661010", Offset = "0x9660410", VA = "0x189661010", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string ESFBHRIABHM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long PUCTVZRIAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DC0", Offset = "0xCF41C0", VA = "0x180CF4DC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string IHYPKZXHWRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object UDVUSOHRMOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DE0", Offset = "0xCF41E0", VA = "0x180CF4DE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public NKOSDRYVRPY ELZWNXAEPKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E20", Offset = "0xCF4220", VA = "0x180CF4E20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9661050", Offset = "0x9660450", VA = "0x189661050")]
		protected WKGCVHOTMSB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x96611C0", Offset = "0x96605C0", VA = "0x1896611C0")]
		protected WKGCVHOTMSB(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x96610F0", Offset = "0x96604F0", VA = "0x1896610F0")]
		protected WKGCVHOTMSB(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9660FC0", Offset = "0x96603C0", VA = "0x189660FC0")]
		protected void NWHXZEXMJYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9660EB0", Offset = "0x96602B0", VA = "0x189660EB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9660F90", Offset = "0x9660390", VA = "0x189660F90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9660E30", Offset = "0x9660230", VA = "0x189660E30", Slot = "4")]
		public bool Equals(WKGCVHOTMSB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string SKWGCLIKZVH(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class NUZCMBRHWEH<a, b> : WKGCVHOTMSB where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class NCLLTQFRZHV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public WEHJUYPLKYH GKGNQENEMKQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public NUZCMBRHWEH<a, b> IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public NCLLTQFRZHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x71BAE00", Offset = "0x71BA200", VA = "0x1871BAE00")]
			internal void VLJUXJXHGPB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a UDVUSOHRMOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x71E9B10", Offset = "0x71E8F10", VA = "0x1871E9B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x71E9B60", Offset = "0x71E8F60", VA = "0x1871E9B60")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x71E9B80", Offset = "0x71E8F80", VA = "0x1871E9B80")]
		protected NUZCMBRHWEH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x71E9C30", Offset = "0x71E9030", VA = "0x1871E9C30")]
		protected NUZCMBRHWEH(string a, long b, string c, FCGSBMYYMMV<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void FTOPZCSSZCU(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x71E9AC0", Offset = "0x71E8EC0", VA = "0x1871E9AC0")]
		private void RZNBDUWRAJH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x71E9AA0", Offset = "0x71E8EA0", VA = "0x1871E9AA0")]
		[CompilerGenerated]
		private void NSRYQVRIDWS(string a)
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
	public class TNHTYUAAQAJ : NUZCMBRHWEH<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD5FC60", Offset = "0xD5F060", VA = "0x180D5FC60", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x965F2B0", Offset = "0x965E6B0", VA = "0x18965F2B0")]
		public TNHTYUAAQAJ(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x965F240", Offset = "0x965E640", VA = "0x18965F240")]
		public TNHTYUAAQAJ(string a, long b, string c, FCGSBMYYMMV<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x965F1D0", Offset = "0x965E5D0", VA = "0x18965F1D0", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x965F170", Offset = "0x965E570", VA = "0x18965F170", Slot = "10")]
		protected override void FTOPZCSSZCU(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class NKZRSQIDPGF : NUZCMBRHWEH<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x965D5A0", Offset = "0x965C9A0", VA = "0x18965D5A0")]
		public NKZRSQIDPGF(string a, long b, string c, FCGSBMYYMMV<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x965D510", Offset = "0x965C910", VA = "0x18965D510", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x965D4C0", Offset = "0x965C8C0", VA = "0x18965D4C0", Slot = "10")]
		protected override void FTOPZCSSZCU(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class XRGGQVFFQEW : NUZCMBRHWEH<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x96615D0", Offset = "0x96609D0", VA = "0x1896615D0")]
		public XRGGQVFFQEW(string a, long b, string c, FCGSBMYYMMV<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x96614E0", Offset = "0x96608E0", VA = "0x1896614E0", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9661470", Offset = "0x9660870", VA = "0x189661470", Slot = "10")]
		protected override void FTOPZCSSZCU(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class XGNAMJJOJVK : NUZCMBRHWEH<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD63AE0", Offset = "0xD62EE0", VA = "0x180D63AE0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool EBAROFIKFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9661330", Offset = "0x9660730", VA = "0x189661330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9661420", Offset = "0x9660820", VA = "0x189661420")]
		public XGNAMJJOJVK(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x96613B0", Offset = "0x96607B0", VA = "0x1896613B0")]
		public XGNAMJJOJVK(string a, long b, string c, FCGSBMYYMMV<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x96612C0", Offset = "0x96606C0", VA = "0x1896612C0", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9661270", Offset = "0x9660670", VA = "0x189661270", Slot = "10")]
		protected override void FTOPZCSSZCU(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class OUMNJKRKXUM : NUZCMBRHWEH<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] RCKQDTRRSVQ;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string TSGMYRUDFKO
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DF0", Offset = "0xCF41F0", VA = "0x180CF4DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E00", Offset = "0xCF4200", VA = "0x180CF4E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool EBAROFIKFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x965D7D0", Offset = "0x965CBD0", VA = "0x18965D7D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x965D9E0", Offset = "0x965CDE0", VA = "0x18965D9E0")]
		public OUMNJKRKXUM(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x965DA30", Offset = "0x965CE30", VA = "0x18965DA30")]
		public OUMNJKRKXUM(string a, long b, string c, FCGSBMYYMMV<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x965D710", Offset = "0x965CB10", VA = "0x18965D710", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x965D690", Offset = "0x965CA90", VA = "0x18965D690", Slot = "10")]
		protected override void FTOPZCSSZCU(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class TYHHCPJNKDN<a> : QZMMBLJJFVC where a : FMXLFOLPVDX.YAPWBHCPAIN, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int VQEKOCBEAXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE280", Offset = "0x7ABD680", VA = "0x187ABE280", Slot = "7")]
		private FMXLFOLPVDX.YAPWBHCPAIN SHXLOSECQOM(FMXLFOLPVDX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE220", Offset = "0x7ABD620", VA = "0x187ABE220", Slot = "6")]
		private FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> QCYABGOUZYP(FMXLFOLPVDX.YAPWBHCPAIN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE060", Offset = "0x7ABD460", VA = "0x187ABE060", Slot = "10")]
		public virtual a FWVQBZPZLRF(FMXLFOLPVDX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE2A0", Offset = "0x7ABD6A0", VA = "0x187ABE2A0", Slot = "11")]
		public virtual FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "12")]
		protected virtual void GDBRHFWTUUC(a a, FMXLFOLPVDX.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABDFE0", Offset = "0x7ABD3E0", VA = "0x187ABDFE0", Slot = "13")]
		protected virtual FCGSBMYYMMV<string> BRKZJJPFGHG(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected TYHHCPJNKDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE140", Offset = "0x7ABD540", VA = "0x187ABE140")]
		[CompilerGenerated]
		private FMXLFOLPVDX.CSHRCFZSDYL NCWUTKPUNZG(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface QZMMBLJJFVC
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int VQEKOCBEAXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(FMXLFOLPVDX.YAPWBHCPAIN a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		FMXLFOLPVDX.YAPWBHCPAIN FWVQBZPZLRF(FMXLFOLPVDX.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface RKWIFMXSWRX : QZMMBLJJFVC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ODXIACVEXFK(RAJCJEFSJAY a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : TYHHCPJNKDN<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class MCICTPZZPUV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool EBAROFIKFFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int WFSSXEWWSGR;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string LWQCHHCLNIL
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType UXYUOXCBTLU
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCFFA40", Offset = "0xCFEE40", VA = "0x180CFFA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int NFZDWJUKKDD
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x1631700", Offset = "0x1630B00", VA = "0x181631700")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1631710", Offset = "0x1630B10", VA = "0x181631710")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int SGGEJSNUKXE
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD47A90", Offset = "0xD46E90", VA = "0x180D47A90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string SWCCQTKEOEC
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16B4760", Offset = "0x16B3B60", VA = "0x1816B4760")]
			public MCICTPZZPUV()
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
		private readonly XRZRJSYRWBK ZBNFWGSHHTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly IBQDEAMXLCG RQQCZPLSMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly ZERDHDXXLUI BMZUHSNEADZ;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int VQEKOCBEAXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCFB3C0", Offset = "0xCFA7C0", VA = "0x180CFB3C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x965D000", Offset = "0x965C400", VA = "0x18965D000")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] XRZRJSYRWBK roomsClient, [Inject(null)] IBQDEAMXLCG accountsClient, [Inject(null)] ZERDHDXXLUI imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x965CFC0", Offset = "0x965C3C0", VA = "0x18965CFC0", Slot = "11")]
		public override FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x965C720", Offset = "0x965BB20", VA = "0x18965C720", Slot = "10")]
		public override TextMessageDetails FWVQBZPZLRF(FMXLFOLPVDX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x965C840", Offset = "0x965BC40", VA = "0x18965C840")]
		private void SAADHOHQLAZ(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : TYHHCPJNKDN<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int VQEKOCBEAXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "9")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x965DB50", Offset = "0x965CF50", VA = "0x18965DB50")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : TYHHCPJNKDN<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int VQEKOCBEAXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "9")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x965DE10", Offset = "0x965D210", VA = "0x18965DE10", Slot = "12")]
		protected override void GDBRHFWTUUC(PhotoMessageDetails a, FMXLFOLPVDX.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x965DFB0", Offset = "0x965D3B0", VA = "0x18965DFB0")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : TYHHCPJNKDN<TextMessageDetails>, RKWIFMXSWRX, QZMMBLJJFVC
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class GYKQTNXGTKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails YKJKYLQUASB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool BTDLOOBXFST;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public GYKQTNXGTKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x965BEC0", Offset = "0x965B2C0", VA = "0x18965BEC0")]
			internal FMXLFOLPVDX.CSHRCFZSDYL KXFOJKWORLI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int HDVAEPGNQIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int XBYUFYIOPRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, RAJCJEFSJAY> TFGQVWURIOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, RAJCJEFSJAY> FLWSVMGCEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NQQVOHNCKVV<XRGGQVFFQEW> XZSWIVPVHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private NQQVOHNCKVV<OUMNJKRKXUM> LNGVOLCUFEQ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int VQEKOCBEAXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "9")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x965FAA0", Offset = "0x965EEA0", VA = "0x18965FAA0", Slot = "14")]
		public void ODXIACVEXFK(RAJCJEFSJAY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x965FE30", Offset = "0x965F230", VA = "0x18965FE30", Slot = "11")]
		public override FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x965F440", Offset = "0x965E840", VA = "0x18965F440", Slot = "12")]
		protected override void GDBRHFWTUUC(TextMessageDetails a, FMXLFOLPVDX.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x965F300", Offset = "0x965E700", VA = "0x18965F300")]
		private bool CNROERQTGFA(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x965F860", Offset = "0x965EC60", VA = "0x18965F860")]
		private static int IFJSYDACGTX(TextMessageDetails a, int b, bool c, RAJCJEFSJAY d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x96600D0", Offset = "0x965F4D0", VA = "0x1896600D0")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class HNJILRIGUKF<a> : NQQVOHNCKVV<a>, RAJCJEFSJAY, IEquatable<RAJCJEFSJAY>, IEquatable<ChatTokenType> where a : WKGCVHOTMSB
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] JXYUJGSMJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string ROZZLLNUFET;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType OASHIHDKUAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string FFFCKYJLRQL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x644E2E0", Offset = "0x644D6E0", VA = "0x18644E2E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType HALIPVABGSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x644E3B0", Offset = "0x644D7B0", VA = "0x18644E3B0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x644E910", Offset = "0x644DD10", VA = "0x18644E910")]
		protected HNJILRIGUKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x644E060", Offset = "0x644D460", VA = "0x18644E060")]
		protected string FVMWOXEIOHD(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x644E660", Offset = "0x644DA60", VA = "0x18644E660", Slot = "14")]
		public bool SYQOKEJVQMS(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x644E3D0", Offset = "0x644D7D0", VA = "0x18644E3D0", Slot = "15")]
		public void KUXRYBGUWHH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a QDTOZMJXNPK(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x644E4F0", Offset = "0x644D8F0", VA = "0x18644E4F0", Slot = "8")]
		private WKGCVHOTMSB MZWHMDOPMRZ(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool ELEPNUTCPYD(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string GGFALICBYBN(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x644E580", Offset = "0x644D980", VA = "0x18644E580")]
		private bool SBIQYTDKHOP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x644E510", Offset = "0x644D910", VA = "0x18644E510")]
		private string QDNGPFOHNHX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x644DCC0", Offset = "0x644D0C0", VA = "0x18644DCC0", Slot = "6")]
		private bool EGATUHSZZHN(string a, [Out] WKGCVHOTMSB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x644E190", Offset = "0x644D590", VA = "0x18644E190", Slot = "7")]
		private void HJCRUKZJYLI(WKGCVHOTMSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x644E160", Offset = "0x644D560", VA = "0x18644E160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x644DF40", Offset = "0x644D340", VA = "0x18644DF40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x644DE90", Offset = "0x644D290", VA = "0x18644DE90", Slot = "9")]
		public bool Equals(RAJCJEFSJAY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x644DF10", Offset = "0x644D310", VA = "0x18644DF10", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : JOCQSGYKSTR<TNHTYUAAQAJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly EPKVWZTSRAN GWCUOKDSLAY;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType OASHIHDKUAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xD5FC60", Offset = "0xD5F060", VA = "0x180D5FC60", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA4F0", Offset = "0x1FB98F0", VA = "0x181FBA4F0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x965BAB0", Offset = "0x965AEB0", VA = "0x18965BAB0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x965BC10", Offset = "0x965B010", VA = "0x18965BC10")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] EPKVWZTSRAN clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x965BAC0", Offset = "0x965AEC0", VA = "0x18965BAC0", Slot = "19")]
		protected override TNHTYUAAQAJ QAQQFZKFYPW(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface RAJCJEFSJAY : IEquatable<RAJCJEFSJAY>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType OASHIHDKUAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string FFFCKYJLRQL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool SYQOKEJVQMS(string a, [Out] WKGCVHOTMSB b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KUXRYBGUWHH(WKGCVHOTMSB a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		WKGCVHOTMSB QDTOZMJXNPK(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface NQQVOHNCKVV<a> : RAJCJEFSJAY, IEquatable<RAJCJEFSJAY>, IEquatable<ChatTokenType> where a : WKGCVHOTMSB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : JOCQSGYKSTR<NKZRSQIDPGF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly ZERDHDXXLUI BMZUHSNEADZ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType OASHIHDKUAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FC7E90", Offset = "0x1FC7290", VA = "0x181FC7E90", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE0B770", Offset = "0xE0AB70", VA = "0x180E0B770", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x965DCE0", Offset = "0x965D0E0", VA = "0x18965DCE0")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] ZERDHDXXLUI imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x965DB90", Offset = "0x965CF90", VA = "0x18965DB90", Slot = "19")]
		protected override NKZRSQIDPGF QAQQFZKFYPW(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : JOCQSGYKSTR<XRGGQVFFQEW>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly IBQDEAMXLCG RQQCZPLSMBD;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType OASHIHDKUAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2009350", Offset = "0x2008750", VA = "0x182009350", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x965DFF0", Offset = "0x965D3F0", VA = "0x18965DFF0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x965E110", Offset = "0x965D510", VA = "0x18965E110")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] IBQDEAMXLCG accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x965E000", Offset = "0x965D400", VA = "0x18965E000", Slot = "19")]
		protected override XRGGQVFFQEW QAQQFZKFYPW(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : JOCQSGYKSTR<XGNAMJJOJVK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly JNGGCWGCKIT FJIKVBCSWSN;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType OASHIHDKUAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD63AE0", Offset = "0xD62EE0", VA = "0x180D63AE0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA4F0", Offset = "0x1FB98F0", VA = "0x181FBA4F0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x965E170", Offset = "0x965D570", VA = "0x18965E170", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x965E2D0", Offset = "0x965D6D0", VA = "0x18965E2D0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] JNGGCWGCKIT playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x965E180", Offset = "0x965D580", VA = "0x18965E180", Slot = "19")]
		protected override XGNAMJJOJVK QAQQFZKFYPW(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : JOCQSGYKSTR<OUMNJKRKXUM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly XRZRJSYRWBK ZBNFWGSHHTH;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType OASHIHDKUAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x965E330", Offset = "0x965D730", VA = "0x18965E330", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B610", Offset = "0x1F9AA10", VA = "0x181F9B610", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x965E450", Offset = "0x965D850", VA = "0x18965E450")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] XRZRJSYRWBK roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x965E340", Offset = "0x965D740", VA = "0x18965E340", Slot = "19")]
		protected override OUMNJKRKXUM QAQQFZKFYPW(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class JOCQSGYKSTR<a> : HNJILRIGUKF<a> where a : WKGCVHOTMSB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6644FE0", Offset = "0x66443E0", VA = "0x186644FE0", Slot = "16")]
		public override a QDTOZMJXNPK(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6644F40", Offset = "0x6644340", VA = "0x186644F40", Slot = "18")]
		protected override string GGFALICBYBN(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6644E20", Offset = "0x6644220", VA = "0x186644E20", Slot = "17")]
		protected override bool ELEPNUTCPYD(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a QAQQFZKFYPW(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6645020", Offset = "0x6644420", VA = "0x186645020")]
		protected JOCQSGYKSTR()
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
