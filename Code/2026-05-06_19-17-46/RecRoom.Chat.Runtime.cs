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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9722090", Offset = "0x9720A90", VA = "0x189722090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9726150", Offset = "0x9724B50", VA = "0x189726150", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public DMEPAFIWFSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x97206D0", Offset = "0x971F0D0", VA = "0x1897206D0")]
			internal NKOSDRYVRPY RBVUBVPZNVQ(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x97208F0", Offset = "0x971F2F0", VA = "0x1897208F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public GYKQTNXGTKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x97210F0", Offset = "0x971FAF0", VA = "0x1897210F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LRWMZSOUZIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9721120", Offset = "0x971FB20", VA = "0x189721120")]
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
		[Cpp2IlInjected.Address(RVA = "0x9720440", Offset = "0x971EE40", VA = "0x189720440")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] IBQDEAMXLCG accountsClient, [Inject(null)] RJEZMHTQGCY chatClient, [Inject(null)] EPKVWZTSRAN clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x971FE00", Offset = "0x971E800", VA = "0x18971FE00", Slot = "5")]
		public bool XHICUVZVBSY(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x971FB90", Offset = "0x971E590", VA = "0x18971FB90", Slot = "6")]
		public ChatMessage VTESDHKGSRQ(long a, FMXLFOLPVDX.YAPWBHCPAIN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x97201D0", Offset = "0x971EBD0", VA = "0x1897201D0", Slot = "7")]
		public FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(FMXLFOLPVDX.YAPWBHCPAIN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x971FA90", Offset = "0x971E490", VA = "0x18971FA90", Slot = "4")]
		public void TYUTCOYHPES(QZMMBLJJFVC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x971FD10", Offset = "0x971E710", VA = "0x18971FD10", Slot = "8")]
		public void WCNDLPVJJEB(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x971F5B0", Offset = "0x971DFB0", VA = "0x18971F5B0")]
		private FMXLFOLPVDX.YAPWBHCPAIN FWVQBZPZLRF(FMXLFOLPVDX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x971FFF0", Offset = "0x971E9F0", VA = "0x18971FFF0")]
		private void XLNWSWILGLO(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x971F890", Offset = "0x971E290", VA = "0x18971F890")]
		private void PLESSXZHCBF(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x971F7B0", Offset = "0x971E1B0", VA = "0x18971F7B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0", Slot = "10")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x97225E0", Offset = "0x9720FE0", VA = "0x1897225E0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9722540", Offset = "0x9720F40", VA = "0x189722540")]
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
			[Cpp2IlInjected.Address(RVA = "0xD418E0", Offset = "0xD402E0", VA = "0x180D418E0", Slot = "10")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string MVACRNAXYRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xEFF5C0", Offset = "0xEFDFC0", VA = "0x180EFF5C0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long GDQSZQICAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x97227E0", Offset = "0x97211E0", VA = "0x1897227E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x97228A0", Offset = "0x97212A0", VA = "0x1897228A0")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9722860", Offset = "0x9721260", VA = "0x189722860")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MSAJPYMMTYN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9721B10", Offset = "0x9720510", VA = "0x189721B10")]
		[BQDQKYYGTTM.Root]
		internal static void ENAKDGREWFX(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9721DF0", Offset = "0x97207F0", VA = "0x189721DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x97258E0", Offset = "0x97242E0", VA = "0x1897258E0")]
			internal string XDJYGUXRRDO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] JWMRKAXHTEW;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x97231B0", Offset = "0x9721BB0", VA = "0x1897231B0")]
		public static FCGSBMYYMMV<string> NZFUCDTVMQS(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9723280", Offset = "0x9721C80", VA = "0x189723280")]
		public static FCGSBMYYMMV<string> NZFUCDTVMQS(FMXLFOLPVDX.YAPWBHCPAIN a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97235A0", Offset = "0x9721FA0", VA = "0x1897235A0")]
		private static string RPBCULGUZBA(LSMDCSSBFZZ a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9723860", Offset = "0x9722260", VA = "0x189723860")]
		public static string SINGSBJOWEE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x97230A0", Offset = "0x9721AA0", VA = "0x1897230A0")]
		public static string HSREIODBBSX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9723970", Offset = "0x9722370", VA = "0x189723970")]
		public static bool WSJZFPEQCTW(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x97239E0", Offset = "0x97223E0", VA = "0x1897239E0")]
		public static bool YPVRREXOSGZ(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9723A50", Offset = "0x9722450", VA = "0x189723A50")]
		public static bool YVJBCLBDCZU(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9722F50", Offset = "0x9721950", VA = "0x189722F50")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x9724DB0", Offset = "0x97237B0", VA = "0x189724DB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool EBAROFIKFFG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9724FE0", Offset = "0x97239E0", VA = "0x189724FE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9725750", Offset = "0x9724150", VA = "0x189725750")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9725470", Offset = "0x9723E70", VA = "0x189725470")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9725640", Offset = "0x9724040", VA = "0x189725640")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9724EF0", Offset = "0x97238F0", VA = "0x189724EF0", Slot = "17")]
		public void UAIBTGQENDQ(WKGCVHOTMSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9725070", Offset = "0x9723A70", VA = "0x189725070", Slot = "16")]
		public NKOSDRYVRPY ZFSDVMKAOLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9724CC0", Offset = "0x97236C0", VA = "0x189724CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCD8BE0", Offset = "0xCD75E0", VA = "0x180CD8BE0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool EBAROFIKFFG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9725B20", Offset = "0x9724520", VA = "0x189725B20", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long PUCTVZRIAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DB0", Offset = "0xCD57B0", VA = "0x180CD6DB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string IHYPKZXHWRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object UDVUSOHRMOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public NKOSDRYVRPY ELZWNXAEPKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E10", Offset = "0xCD5810", VA = "0x180CD6E10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9725B60", Offset = "0x9724560", VA = "0x189725B60")]
		protected WKGCVHOTMSB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9725CD0", Offset = "0x97246D0", VA = "0x189725CD0")]
		protected WKGCVHOTMSB(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9725C00", Offset = "0x9724600", VA = "0x189725C00")]
		protected WKGCVHOTMSB(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9725AD0", Offset = "0x97244D0", VA = "0x189725AD0")]
		protected void NWHXZEXMJYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x97259C0", Offset = "0x97243C0", VA = "0x1897259C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9725AA0", Offset = "0x97244A0", VA = "0x189725AA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9725940", Offset = "0x9724340", VA = "0x189725940", Slot = "4")]
		public bool Equals(WKGCVHOTMSB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public NCLLTQFRZHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x724D380", Offset = "0x724BD80", VA = "0x18724D380")]
			internal void VLJUXJXHGPB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a UDVUSOHRMOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x727C1B0", Offset = "0x727ABB0", VA = "0x18727C1B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x727C200", Offset = "0x727AC00", VA = "0x18727C200")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x727C220", Offset = "0x727AC20", VA = "0x18727C220")]
		protected NUZCMBRHWEH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x727C2D0", Offset = "0x727ACD0", VA = "0x18727C2D0")]
		protected NUZCMBRHWEH(string a, long b, string c, FCGSBMYYMMV<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void FTOPZCSSZCU(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x727C160", Offset = "0x727AB60", VA = "0x18727C160")]
		private void RZNBDUWRAJH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x727C140", Offset = "0x727AB40", VA = "0x18727C140")]
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
			[Cpp2IlInjected.Address(RVA = "0xD41AD0", Offset = "0xD404D0", VA = "0x180D41AD0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9723D70", Offset = "0x9722770", VA = "0x189723D70")]
		public TNHTYUAAQAJ(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9723D00", Offset = "0x9722700", VA = "0x189723D00")]
		public TNHTYUAAQAJ(string a, long b, string c, FCGSBMYYMMV<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9723C90", Offset = "0x9722690", VA = "0x189723C90", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9723C30", Offset = "0x9722630", VA = "0x189723C30", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5AEB0", Offset = "0xD598B0", VA = "0x180D5AEB0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9722020", Offset = "0x9720A20", VA = "0x189722020")]
		public NKZRSQIDPGF(string a, long b, string c, FCGSBMYYMMV<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9721F90", Offset = "0x9720990", VA = "0x189721F90", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9721F40", Offset = "0x9720940", VA = "0x189721F40", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD418E0", Offset = "0xD402E0", VA = "0x180D418E0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x97260E0", Offset = "0x9724AE0", VA = "0x1897260E0")]
		public XRGGQVFFQEW(string a, long b, string c, FCGSBMYYMMV<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9725FF0", Offset = "0x97249F0", VA = "0x189725FF0", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9725F80", Offset = "0x9724980", VA = "0x189725F80", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD45980", Offset = "0xD44380", VA = "0x180D45980", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool EBAROFIKFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9725E40", Offset = "0x9724840", VA = "0x189725E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9725F30", Offset = "0x9724930", VA = "0x189725F30")]
		public XGNAMJJOJVK(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9725EC0", Offset = "0x97248C0", VA = "0x189725EC0")]
		public XGNAMJJOJVK(string a, long b, string c, FCGSBMYYMMV<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9725DD0", Offset = "0x97247D0", VA = "0x189725DD0", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9725D80", Offset = "0x9724780", VA = "0x189725D80", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DF0", Offset = "0xCD57F0", VA = "0x180CD6DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool EBAROFIKFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9722250", Offset = "0x9720C50", VA = "0x189722250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9722480", Offset = "0x9720E80", VA = "0x189722480")]
		public OUMNJKRKXUM(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x97224D0", Offset = "0x9720ED0", VA = "0x1897224D0")]
		public OUMNJKRKXUM(string a, long b, string c, FCGSBMYYMMV<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9722190", Offset = "0x9720B90", VA = "0x189722190", Slot = "9")]
		public override string SKWGCLIKZVH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9722110", Offset = "0x9720B10", VA = "0x189722110", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B5AFC0", Offset = "0x7B599C0", VA = "0x187B5AFC0", Slot = "7")]
		private FMXLFOLPVDX.YAPWBHCPAIN SHXLOSECQOM(FMXLFOLPVDX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B5AF60", Offset = "0x7B59960", VA = "0x187B5AF60", Slot = "6")]
		private FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> QCYABGOUZYP(FMXLFOLPVDX.YAPWBHCPAIN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5ADA0", Offset = "0x7B597A0", VA = "0x187B5ADA0", Slot = "10")]
		public virtual a FWVQBZPZLRF(FMXLFOLPVDX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5AFE0", Offset = "0x7B599E0", VA = "0x187B5AFE0", Slot = "11")]
		public virtual FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "12")]
		protected virtual void GDBRHFWTUUC(a a, FMXLFOLPVDX.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5AD20", Offset = "0x7B59720", VA = "0x187B5AD20", Slot = "13")]
		protected virtual FCGSBMYYMMV<string> BRKZJJPFGHG(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected TYHHCPJNKDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5AE80", Offset = "0x7B59880", VA = "0x187B5AE80")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType UXYUOXCBTLU
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCE1A20", Offset = "0xCE0420", VA = "0x180CE1A20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int NFZDWJUKKDD
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x1620320", Offset = "0x161ED20", VA = "0x181620320")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1620330", Offset = "0x161ED30", VA = "0x181620330")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int SGGEJSNUKXE
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD29750", Offset = "0xD28150", VA = "0x180D29750")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string SWCCQTKEOEC
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16A3A80", Offset = "0x16A2480", VA = "0x1816A3A80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCDD3A0", Offset = "0xCDBDA0", VA = "0x180CDD3A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9721A80", Offset = "0x9720480", VA = "0x189721A80")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] XRZRJSYRWBK roomsClient, [Inject(null)] IBQDEAMXLCG accountsClient, [Inject(null)] ZERDHDXXLUI imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9721A40", Offset = "0x9720440", VA = "0x189721A40", Slot = "11")]
		public override FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x97211A0", Offset = "0x971FBA0", VA = "0x1897211A0", Slot = "10")]
		public override TextMessageDetails FWVQBZPZLRF(FMXLFOLPVDX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x97212C0", Offset = "0x971FCC0", VA = "0x1897212C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0", Slot = "9")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x97225F0", Offset = "0x9720FF0", VA = "0x1897225F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD418E0", Offset = "0xD402E0", VA = "0x180D418E0", Slot = "9")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x97228B0", Offset = "0x97212B0", VA = "0x1897228B0", Slot = "12")]
		protected override void GDBRHFWTUUC(PhotoMessageDetails a, FMXLFOLPVDX.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9722A50", Offset = "0x9721450", VA = "0x189722A50")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public GYKQTNXGTKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9720920", Offset = "0x971F320", VA = "0x189720920")]
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
			[Cpp2IlInjected.Address(RVA = "0xD418E0", Offset = "0xD402E0", VA = "0x180D418E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override FMXLFOLPVDX.MessageContentType KVMOTRLJKRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "9")]
			get
			{
				return default(FMXLFOLPVDX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9724570", Offset = "0x9722F70", VA = "0x189724570", Slot = "14")]
		public void ODXIACVEXFK(RAJCJEFSJAY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9724900", Offset = "0x9723300", VA = "0x189724900", Slot = "11")]
		public override FCGSBMYYMMV<FMXLFOLPVDX.CSHRCFZSDYL> XVOCVKNEQZO(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9723F00", Offset = "0x9722900", VA = "0x189723F00", Slot = "12")]
		protected override void GDBRHFWTUUC(TextMessageDetails a, FMXLFOLPVDX.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9723DC0", Offset = "0x97227C0", VA = "0x189723DC0")]
		private bool CNROERQTGFA(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9724330", Offset = "0x9722D30", VA = "0x189724330")]
		private static int IFJSYDACGTX(TextMessageDetails a, int b, bool c, RAJCJEFSJAY d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9724BA0", Offset = "0x97235A0", VA = "0x189724BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x64D7530", Offset = "0x64D5F30", VA = "0x1864D7530", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x64D7600", Offset = "0x64D6000", VA = "0x1864D7600", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x64D7B70", Offset = "0x64D6570", VA = "0x1864D7B70")]
		protected HNJILRIGUKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x64D72B0", Offset = "0x64D5CB0", VA = "0x1864D72B0")]
		protected string FVMWOXEIOHD(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x64D78B0", Offset = "0x64D62B0", VA = "0x1864D78B0", Slot = "14")]
		public bool SYQOKEJVQMS(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x64D7620", Offset = "0x64D6020", VA = "0x1864D7620", Slot = "15")]
		public void KUXRYBGUWHH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a QDTOZMJXNPK(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x64D7740", Offset = "0x64D6140", VA = "0x1864D7740", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x64D77D0", Offset = "0x64D61D0", VA = "0x1864D77D0")]
		private bool SBIQYTDKHOP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x64D7760", Offset = "0x64D6160", VA = "0x1864D7760")]
		private string QDNGPFOHNHX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x64D6E60", Offset = "0x64D5860", VA = "0x1864D6E60", Slot = "6")]
		private bool EGATUHSZZHN(string a, [Out] WKGCVHOTMSB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x64D73E0", Offset = "0x64D5DE0", VA = "0x1864D73E0", Slot = "7")]
		private void HJCRUKZJYLI(WKGCVHOTMSB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x64D73B0", Offset = "0x64D5DB0", VA = "0x1864D73B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x64D7130", Offset = "0x64D5B30", VA = "0x1864D7130", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x64D7030", Offset = "0x64D5A30", VA = "0x1864D7030", Slot = "9")]
		public bool Equals(RAJCJEFSJAY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x64D7100", Offset = "0x64D5B00", VA = "0x1864D7100", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD41AD0", Offset = "0xD404D0", VA = "0x180D41AD0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1C20", Offset = "0x1FB0620", VA = "0x181FB1C20", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9720510", Offset = "0x971EF10", VA = "0x189720510", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9720670", Offset = "0x971F070", VA = "0x189720670")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] EPKVWZTSRAN clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9720520", Offset = "0x971EF20", VA = "0x189720520", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5AEB0", Offset = "0xD598B0", VA = "0x180D5AEB0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FBF5C0", Offset = "0x1FBDFC0", VA = "0x181FBF5C0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xDEF120", Offset = "0xDEDB20", VA = "0x180DEF120", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9722780", Offset = "0x9721180", VA = "0x189722780")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] ZERDHDXXLUI imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9722630", Offset = "0x9721030", VA = "0x189722630", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD418E0", Offset = "0xD402E0", VA = "0x180D418E0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2000B80", Offset = "0x1FFF580", VA = "0x182000B80", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9722A90", Offset = "0x9721490", VA = "0x189722A90", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9722BB0", Offset = "0x97215B0", VA = "0x189722BB0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] IBQDEAMXLCG accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9722AA0", Offset = "0x97214A0", VA = "0x189722AA0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD45980", Offset = "0xD44380", VA = "0x180D45980", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB1C20", Offset = "0x1FB0620", VA = "0x181FB1C20", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9722C10", Offset = "0x9721610", VA = "0x189722C10", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9722D70", Offset = "0x9721770", VA = "0x189722D70")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] JNGGCWGCKIT playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9722C20", Offset = "0x9721620", VA = "0x189722C20", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char ADNMNCEIGOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9722DD0", Offset = "0x97217D0", VA = "0x189722DD0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char PEZAVZOCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F92E00", Offset = "0x1F91800", VA = "0x181F92E00", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9722EF0", Offset = "0x97218F0", VA = "0x189722EF0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] XRZRJSYRWBK roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9722DE0", Offset = "0x97217E0", VA = "0x189722DE0", Slot = "19")]
		protected override OUMNJKRKXUM QAQQFZKFYPW(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class JOCQSGYKSTR<a> : HNJILRIGUKF<a> where a : WKGCVHOTMSB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x66CF490", Offset = "0x66CDE90", VA = "0x1866CF490", Slot = "16")]
		public override a QDTOZMJXNPK(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x66CF3F0", Offset = "0x66CDDF0", VA = "0x1866CF3F0", Slot = "18")]
		protected override string GGFALICBYBN(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x66CF2D0", Offset = "0x66CDCD0", VA = "0x1866CF2D0", Slot = "17")]
		protected override bool ELEPNUTCPYD(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a QAQQFZKFYPW(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x66CF4D0", Offset = "0x66CDED0", VA = "0x1866CF4D0")]
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
