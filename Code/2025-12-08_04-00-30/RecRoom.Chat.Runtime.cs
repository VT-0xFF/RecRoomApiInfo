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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8112F90", Offset = "0x8111790", VA = "0x188112F90")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8116E10", Offset = "0x8115610", VA = "0x188116E10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2735A30", Offset = "0x2734230", VA = "0x182735A30")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : ZGXIANKOWZX
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class XHDCJOGKBMU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage UMIDRJQPYOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> VRRWHNGOOMF;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public XHDCJOGKBMU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x81167E0", Offset = "0x8114FE0", VA = "0x1881167E0")]
			internal DNXWICJZUNF OMVFGSKRWWL(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x81167B0", Offset = "0x8114FB0", VA = "0x1881167B0")]
			internal void OMPYJLQUNLC(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KMOETCHCLJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage UMIDRJQPYOI;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KMOETCHCLJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x81123F0", Offset = "0x8110BF0", VA = "0x1881123F0")]
			internal void VQYWAZIKEWO(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class WKDHTAWVSFY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public JAILNKMLDZM.MessageContentType XAMKISGEDUI;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public WKDHTAWVSFY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8115A70", Offset = "0x8114270", VA = "0x188115A70")]
			internal bool XDBDQCEKREJ(KARTPJIOHDD a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly JAILNKMLDZM.LUJXTCUJHOY EFXPWXAUQCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int VAYCBCGZMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<KARTPJIOHDD> FISLXBUQKET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly PLABEEHJDLT ADYFTCKGLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly FFTUYXIKHKP PZWODOECFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly EBFKHKAHMLG OBZTWIAFRWX;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81115F0", Offset = "0x810FDF0", VA = "0x1881115F0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] PLABEEHJDLT accountsClient, [Inject(null)] FFTUYXIKHKP chatClient, [Inject(null)] EBFKHKAHMLG clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8110AF0", Offset = "0x810F2F0", VA = "0x188110AF0", Slot = "5")]
		public bool EIFPVANGMWJ(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8110970", Offset = "0x810F170", VA = "0x188110970", Slot = "6")]
		public ChatMessage DUHWMTWZVYP(long a, JAILNKMLDZM.LUJXTCUJHOY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8111290", Offset = "0x810FA90", VA = "0x188111290", Slot = "7")]
		public PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(JAILNKMLDZM.LUJXTCUJHOY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8111400", Offset = "0x810FC00", VA = "0x188111400", Slot = "4")]
		public void XKAMEJJZZQZ(KARTPJIOHDD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81111A0", Offset = "0x810F9A0", VA = "0x1881111A0", Slot = "8")]
		public void NFHXNAYYEAS(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8110770", Offset = "0x810EF70", VA = "0x188110770")]
		private JAILNKMLDZM.LUJXTCUJHOY DDLPBLLROKI(JAILNKMLDZM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8110FC0", Offset = "0x810F7C0", VA = "0x188110FC0")]
		private void LAZCNIZJDFH(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8110DC0", Offset = "0x810F5C0", VA = "0x188110DC0")]
		private void IQSOQXWPAQO(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8110CE0", Offset = "0x810F4E0", VA = "0x188110CE0")]
		private KARTPJIOHDD GWUAVQZOGDN(int a, JAILNKMLDZM.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ZGXIANKOWZX
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XKAMEJJZZQZ(KARTPJIOHDD a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool EIFPVANGMWJ(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage DUHWMTWZVYP(long a, JAILNKMLDZM.LUJXTCUJHOY b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(JAILNKMLDZM.LUJXTCUJHOY a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NFHXNAYYEAS(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface VCEIYFOIBJU
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		IXZHGEZUADS<VCEIYFOIBJU> CVFPGCHFDHI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IOJRFCEQQGK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<CSJZUSSUSLU> CAOOBEXCKQD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string DQYIQAERBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		DNXWICJZUNF RFWXKEZOSVP();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : JAILNKMLDZM.LUJXTCUJHOY
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70", Slot = "10")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81130B0", Offset = "0x81118B0", VA = "0x1881130B0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8113010", Offset = "0x8111810", VA = "0x188113010")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : JAILNKMLDZM.LUJXTCUJHOY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long UMYZLEXJXIB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB89940", Offset = "0xB88140", VA = "0x180B89940", Slot = "10")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string POSRCRWSMOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC2CFC0", Offset = "0xC2B7C0", VA = "0x180C2CFC0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long UGDGVMEFFTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x81132B0", Offset = "0x8111AB0", VA = "0x1881132B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8113370", Offset = "0x8111B70", VA = "0x188113370")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8113330", Offset = "0x8111B30", VA = "0x188113330")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SPJFTHMAHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8113B70", Offset = "0x8112370", VA = "0x188113B70")]
		[UKOBXVXKPZF.Root]
		internal static void RHCAPTNCDGO(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8113E50", Offset = "0x8112650", VA = "0x188113E50")]
		[UnityEngine.Scripting.Preserve]
		public SPJFTHMAHBC([Inject(null)] ZGXIANKOWZX chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] YUBLSSPTFAO textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class WQAWUWCFDYN
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public VCEIYFOIBJU PERJXEHLDBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool AXLDGCUMMOJ;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8111880", Offset = "0x8110080", VA = "0x188111880")]
			internal string IZZFORLMUAN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] RIROKFWPYUV;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8115FA0", Offset = "0x81147A0", VA = "0x188115FA0")]
		public static PVOPFDWRLHK<string> PBUGWDHOEVV(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8116070", Offset = "0x8114870", VA = "0x188116070")]
		public static PVOPFDWRLHK<string> PBUGWDHOEVV(JAILNKMLDZM.LUJXTCUJHOY a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8115AF0", Offset = "0x81142F0", VA = "0x188115AF0")]
		private static string BHNCNCLNWBV(VCEIYFOIBJU a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8116390", Offset = "0x8114B90", VA = "0x188116390")]
		public static string QNMADYCPMEF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8115DB0", Offset = "0x81145B0", VA = "0x188115DB0")]
		public static string CEBHGSUHIMC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8115F30", Offset = "0x8114730", VA = "0x188115F30")]
		public static bool JYNDTVJSOCZ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8115EC0", Offset = "0x81146C0", VA = "0x188115EC0")]
		public static bool IHMMDWYAUNY(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8116490", Offset = "0x8114C90", VA = "0x188116490")]
		public static bool RBZGHTWFQGB(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81164C0", Offset = "0x8114CC0", VA = "0x1881164C0")]
		public static string YMVXSMMQZTJ(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : JAILNKMLDZM.LUJXTCUJHOY, VCEIYFOIBJU
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IXZHGEZUADS<VCEIYFOIBJU> CVFPGCHFDHI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<CSJZUSSUSLU> CAOOBEXCKQD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IOJRFCEQQGK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x81154D0", Offset = "0x8113CD0", VA = "0x1881154D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8114F80", Offset = "0x8113780", VA = "0x188114F80", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81158E0", Offset = "0x81140E0", VA = "0x1881158E0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8115610", Offset = "0x8113E10", VA = "0x188115610")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81157D0", Offset = "0x8113FD0", VA = "0x1881157D0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8114E90", Offset = "0x8113690", VA = "0x188114E90", Slot = "17")]
		public void GYFKHNLMALV(CSJZUSSUSLU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8115010", Offset = "0x8113810", VA = "0x188115010", Slot = "16")]
		public DNXWICJZUNF RFWXKEZOSVP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x81153E0", Offset = "0x8113BE0", VA = "0x1881153E0")]
		private void XHSAQPMBAEA(CSJZUSSUSLU a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class CSJZUSSUSLU : IEquatable<CSJZUSSUSLU>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IXZHGEZUADS<CSJZUSSUSLU> CVFPGCHFDHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool IOJRFCEQQGK
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xBE0F00", Offset = "0xBDF700", VA = "0x180BE0F00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAA2A00", Offset = "0xAA1200", VA = "0x180AA2A00", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8110510", Offset = "0x810ED10", VA = "0x188110510", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string AMCPSIJMOPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long WKVVRWALFCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DE0", Offset = "0xAA65E0", VA = "0x180AA7DE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string WQZDIZZKEQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA1600", Offset = "0xA9FE00", VA = "0x180AA1600")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object AWEFYYJZBNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D80", Offset = "0xAA6580", VA = "0x180AA7D80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DNXWICJZUNF SSNPVIDDTSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAA3260", Offset = "0xAA1A60", VA = "0x180AA3260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8110550", Offset = "0x810ED50", VA = "0x188110550")]
		protected CSJZUSSUSLU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81106C0", Offset = "0x810EEC0", VA = "0x1881106C0")]
		protected CSJZUSSUSLU(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81105F0", Offset = "0x810EDF0", VA = "0x1881105F0")]
		protected CSJZUSSUSLU(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81104C0", Offset = "0x810ECC0", VA = "0x1881104C0")]
		protected void HKJVWIWUAIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8110330", Offset = "0x810EB30", VA = "0x188110330", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8110490", Offset = "0x810EC90", VA = "0x188110490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8110410", Offset = "0x810EC10", VA = "0x188110410", Slot = "4")]
		public bool Equals(CSJZUSSUSLU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string QWCDEUURZFO(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class GOIGNLVMMWY<a, b> : CSJZUSSUSLU where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GXJZCZDFVCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public BCGUMWNTOSM PPRMQJHGHEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public GOIGNLVMMWY<a, b> VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GXJZCZDFVCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4DDE040", Offset = "0x4DDC840", VA = "0x184DDE040")]
			internal void IEKPTRHPTWE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a AWEFYYJZBNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4DD0860", Offset = "0x4DCF060", VA = "0x184DD0860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4DD08B0", Offset = "0x4DCF0B0", VA = "0x184DD08B0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4DD0CF0", Offset = "0x4DCF4F0", VA = "0x184DD0CF0")]
		protected GOIGNLVMMWY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4DD08D0", Offset = "0x4DCF0D0", VA = "0x184DD08D0")]
		protected GOIGNLVMMWY(string a, long b, string c, PVOPFDWRLHK<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void KLHLUZJFGPN(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4DD0810", Offset = "0x4DCF010", VA = "0x184DD0810")]
		private void LLYUOSPBXBA(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4DD07F0", Offset = "0x4DCEFF0", VA = "0x184DD07F0")]
		[CompilerGenerated]
		private void CTXIMNMCGGX(string a)
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
	public class KIOFPLAOSOG : GOIGNLVMMWY<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB83F00", Offset = "0xB82700", VA = "0x180B83F00", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8111BF0", Offset = "0x81103F0", VA = "0x188111BF0")]
		public KIOFPLAOSOG(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8111B80", Offset = "0x8110380", VA = "0x188111B80")]
		public KIOFPLAOSOG(string a, long b, string c, PVOPFDWRLHK<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8111B10", Offset = "0x8110310", VA = "0x188111B10", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8111AB0", Offset = "0x81102B0", VA = "0x188111AB0", Slot = "10")]
		protected override void KLHLUZJFGPN(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class QJOSLJRLWXK : GOIGNLVMMWY<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB6B550", Offset = "0xB69D50", VA = "0x180B6B550", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8113980", Offset = "0x8112180", VA = "0x188113980")]
		public QJOSLJRLWXK(string a, long b, string c, PVOPFDWRLHK<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81138F0", Offset = "0x81120F0", VA = "0x1881138F0", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81138A0", Offset = "0x81120A0", VA = "0x1881138A0", Slot = "10")]
		protected override void KLHLUZJFGPN(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class HKMDWRCFHAV : GOIGNLVMMWY<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB89940", Offset = "0xB88140", VA = "0x180B89940", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8111A40", Offset = "0x8110240", VA = "0x188111A40")]
		public HKMDWRCFHAV(string a, long b, string c, PVOPFDWRLHK<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8111950", Offset = "0x8110150", VA = "0x188111950", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x81118E0", Offset = "0x81100E0", VA = "0x1881118E0", Slot = "10")]
		protected override void KLHLUZJFGPN(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class NRZIOSBNOYV : GOIGNLVMMWY<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB75090", Offset = "0xB73890", VA = "0x180B75090", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8112D90", Offset = "0x8111590", VA = "0x188112D90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8112ED0", Offset = "0x81116D0", VA = "0x188112ED0")]
		public NRZIOSBNOYV(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8112F20", Offset = "0x8111720", VA = "0x188112F20")]
		public NRZIOSBNOYV(string a, long b, string c, PVOPFDWRLHK<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8112E60", Offset = "0x8111660", VA = "0x188112E60", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8112E10", Offset = "0x8111610", VA = "0x188112E10", Slot = "10")]
		protected override void KLHLUZJFGPN(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class YSKBCZJNPFB : GOIGNLVMMWY<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] EDTGMQGXTQV;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string NZYJCSUDBTV
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA9E160", Offset = "0xA9C960", VA = "0x180A9E160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA9E120", Offset = "0xA9C920", VA = "0x180A9E120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8116A00", Offset = "0x8115200", VA = "0x188116A00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8116DC0", Offset = "0x81155C0", VA = "0x188116DC0")]
		public YSKBCZJNPFB(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8116D50", Offset = "0x8115550", VA = "0x188116D50")]
		public YSKBCZJNPFB(string a, long b, string c, PVOPFDWRLHK<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8116BF0", Offset = "0x81153F0", VA = "0x188116BF0", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8116B70", Offset = "0x8115370", VA = "0x188116B70", Slot = "10")]
		protected override void KLHLUZJFGPN(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class YGNYTBNJRMA<a> : KARTPJIOHDD where a : JAILNKMLDZM.LUJXTCUJHOY, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int VJOLSNEECRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3DECA40", Offset = "0x3DEB240", VA = "0x183DECA40", Slot = "7")]
		private JAILNKMLDZM.LUJXTCUJHOY TPDRQFDIUTD(JAILNKMLDZM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC9E0", Offset = "0x3DEB1E0", VA = "0x183DEC9E0", Slot = "6")]
		private PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> RWEMFNWRHLI(JAILNKMLDZM.LUJXTCUJHOY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC7A0", Offset = "0x3DEAFA0", VA = "0x183DEC7A0", Slot = "10")]
		public virtual a DDLPBLLROKI(JAILNKMLDZM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3DECA60", Offset = "0x3DEB260", VA = "0x183DECA60", Slot = "11")]
		public virtual PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "12")]
		protected virtual void UHYQIXSXSGJ(a a, JAILNKMLDZM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC960", Offset = "0x3DEB160", VA = "0x183DEC960", Slot = "13")]
		protected virtual PVOPFDWRLHK<string> JYWJCVWISIV(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected YGNYTBNJRMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC880", Offset = "0x3DEB080", VA = "0x183DEC880")]
		[CompilerGenerated]
		private JAILNKMLDZM.QNWWRNGAASU GBNYRXQBRUL(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface KARTPJIOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int VJOLSNEECRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(JAILNKMLDZM.LUJXTCUJHOY a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		JAILNKMLDZM.LUJXTCUJHOY DDLPBLLROKI(JAILNKMLDZM.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface YUBLSSPTFAO : KARTPJIOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FVDBNMHLIKZ(ICROMUFPDGD a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : YGNYTBNJRMA<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class CNPMHOZKEJY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool TUHKJRTAHJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int INJAMCDTSOC;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string MAVXNKAKVTM
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType BFJYMHQJKIL
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAA3180", Offset = "0xAA1980", VA = "0x180AA3180")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAA4DF0", Offset = "0xAA35F0", VA = "0x180AA4DF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int VJYYPDMEGLO
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x13373D0", Offset = "0x1335BD0", VA = "0x1813373D0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x13373C0", Offset = "0x1335BC0", VA = "0x1813373C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int YDGCAEFEIMX
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF8A10", VA = "0x180AFA210")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string ZXSYHZMTGKT
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAA1600", Offset = "0xA9FE00", VA = "0x180AA1600")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x13CE4B0", Offset = "0x13CCCB0", VA = "0x1813CE4B0")]
			public CNPMHOZKEJY()
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
		private readonly CHEQRUTJYCF SUNALWBUGWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly PLABEEHJDLT ADYFTCKGLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly SFMVFYGJSPJ OSRTNXQJJTQ;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int VJOLSNEECRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAA4E00", Offset = "0xAA3600", VA = "0x180AA4E00", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8112D00", Offset = "0x8111500", VA = "0x188112D00")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] CHEQRUTJYCF roomsClient, [Inject(null)] PLABEEHJDLT accountsClient, [Inject(null)] SFMVFYGJSPJ imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8112CC0", Offset = "0x81114C0", VA = "0x188112CC0", Slot = "11")]
		public override PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8112420", Offset = "0x8110C20", VA = "0x188112420", Slot = "10")]
		public override TextMessageDetails DDLPBLLROKI(JAILNKMLDZM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8112540", Offset = "0x8110D40", VA = "0x188112540")]
		private void GRYEKWLMDFC(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : YGNYTBNJRMA<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int VJOLSNEECRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70", Slot = "9")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x81130C0", Offset = "0x81118C0", VA = "0x1881130C0")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : YGNYTBNJRMA<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int VJOLSNEECRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB89940", Offset = "0xB88140", VA = "0x180B89940", Slot = "9")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8113380", Offset = "0x8111B80", VA = "0x188113380", Slot = "12")]
		protected override void UHYQIXSXSGJ(PhotoMessageDetails a, JAILNKMLDZM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8113520", Offset = "0x8111D20", VA = "0x188113520")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : YGNYTBNJRMA<TextMessageDetails>, YUBLSSPTFAO, KARTPJIOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class KMOETCHCLJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails DDJYNHSBGTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool VAPKRDGMAJO;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KMOETCHCLJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8111C40", Offset = "0x8110440", VA = "0x188111C40")]
			internal JAILNKMLDZM.QNWWRNGAASU HHIPXNJCQRT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int VRQDHVDMOVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int VKLFZXRASLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, ICROMUFPDGD> XOJWDIGQPXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, ICROMUFPDGD> MCKNAVVEANQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private JFILJIGXNZS<HKMDWRCFHAV> EEXIXTDGCZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private JFILJIGXNZS<YSKBCZJNPFB> NHXOYVYWHNT;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int VJOLSNEECRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB89940", Offset = "0xB88140", VA = "0x180B89940", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "9")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8113FA0", Offset = "0x81127A0", VA = "0x188113FA0", Slot = "14")]
		public void FVDBNMHLIKZ(ICROMUFPDGD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8114990", Offset = "0x8113190", VA = "0x188114990", Slot = "11")]
		public override PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8114330", Offset = "0x8112B30", VA = "0x188114330", Slot = "12")]
		protected override void UHYQIXSXSGJ(TextMessageDetails a, JAILNKMLDZM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8114C30", Offset = "0x8113430", VA = "0x188114C30")]
		private bool XRHDVDIYGQT(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8114750", Offset = "0x8112F50", VA = "0x188114750")]
		private static int VMZVIKXWQXU(TextMessageDetails a, int b, bool c, ICROMUFPDGD d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8114D70", Offset = "0x8113570", VA = "0x188114D70")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class PBJPHDZFXEY<a> : JFILJIGXNZS<a>, ICROMUFPDGD, IEquatable<ICROMUFPDGD>, IEquatable<ChatTokenType> where a : CSJZUSSUSLU
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] YWMKPXDECYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string VNKOXVYXMPS;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType XVWBQTRLSIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string BJRQXOTANKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5AC18B0", Offset = "0x5AC00B0", VA = "0x185AC18B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType ISEEUJSMNIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5AC1980", Offset = "0x5AC0180", VA = "0x185AC1980", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1EE0", Offset = "0x5AC06E0", VA = "0x185AC1EE0")]
		protected PBJPHDZFXEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5AC11E0", Offset = "0x5ABF9E0", VA = "0x185AC11E0")]
		protected string ACFHXPLJLPE(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1C30", Offset = "0x5AC0430", VA = "0x185AC1C30", Slot = "14")]
		public bool ZMUPFJICOJR(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1A80", Offset = "0x5AC0280", VA = "0x185AC1A80", Slot = "15")]
		public void NLCDPTDORKK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a IRKMMXBOLYD(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1C10", Offset = "0x5AC0410", VA = "0x185AC1C10", Slot = "8")]
		private CSJZUSSUSLU SYYNATHKNZC(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool TLKXHJUWWWO(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string GVVRUSZRIGQ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5AC19A0", Offset = "0x5AC01A0", VA = "0x185AC19A0")]
		private bool LZQPQDKLIPA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1BA0", Offset = "0x5AC03A0", VA = "0x185AC1BA0")]
		private string RHSMVEJIYTS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5AC12E0", Offset = "0x5ABFAE0", VA = "0x185AC12E0", Slot = "6")]
		private bool EENNFXTJVJA(string a, [Out] CSJZUSSUSLU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1760", Offset = "0x5ABFF60", VA = "0x185AC1760", Slot = "7")]
		private void HOTKSJXFFXX(CSJZUSSUSLU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1730", Offset = "0x5ABFF30", VA = "0x185AC1730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5AC14E0", Offset = "0x5ABFCE0", VA = "0x185AC14E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1660", Offset = "0x5ABFE60", VA = "0x185AC1660", Slot = "9")]
		public bool Equals(ICROMUFPDGD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5AC14B0", Offset = "0x5ABFCB0", VA = "0x185AC14B0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : OQQOZXHRTNM<KIOFPLAOSOG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly EBFKHKAHMLG OBZTWIAFRWX;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType XVWBQTRLSIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xB83F00", Offset = "0xB82700", VA = "0x180B83F00", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1C2FF00", Offset = "0x1C2E700", VA = "0x181C2FF00", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8111810", Offset = "0x8110010", VA = "0x188111810", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8111820", Offset = "0x8110020", VA = "0x188111820")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] EBFKHKAHMLG clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x81116C0", Offset = "0x810FEC0", VA = "0x1881116C0", Slot = "19")]
		protected override KIOFPLAOSOG OMYZJWAVCNX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface ICROMUFPDGD : IEquatable<ICROMUFPDGD>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType XVWBQTRLSIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string BJRQXOTANKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ZMUPFJICOJR(string a, [Out] CSJZUSSUSLU b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NLCDPTDORKK(CSJZUSSUSLU a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CSJZUSSUSLU IRKMMXBOLYD(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface JFILJIGXNZS<a> : ICROMUFPDGD, IEquatable<ICROMUFPDGD>, IEquatable<ChatTokenType> where a : CSJZUSSUSLU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : OQQOZXHRTNM<QJOSLJRLWXK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly SFMVFYGJSPJ OSRTNXQJJTQ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType XVWBQTRLSIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB6B550", Offset = "0xB69D50", VA = "0x180B6B550", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1C35240", Offset = "0x1C33A40", VA = "0x181C35240", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB3D7F0", Offset = "0xB3BFF0", VA = "0x180B3D7F0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8113250", Offset = "0x8111A50", VA = "0x188113250")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] SFMVFYGJSPJ imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8113100", Offset = "0x8111900", VA = "0x188113100", Slot = "19")]
		protected override QJOSLJRLWXK OMYZJWAVCNX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : OQQOZXHRTNM<HKMDWRCFHAV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly PLABEEHJDLT ADYFTCKGLOI;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType XVWBQTRLSIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB89940", Offset = "0xB88140", VA = "0x180B89940", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1C9AA70", Offset = "0x1C99270", VA = "0x181C9AA70", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8113670", Offset = "0x8111E70", VA = "0x188113670", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8113680", Offset = "0x8111E80", VA = "0x188113680")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] PLABEEHJDLT accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8113560", Offset = "0x8111D60", VA = "0x188113560", Slot = "19")]
		protected override HKMDWRCFHAV OMYZJWAVCNX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : OQQOZXHRTNM<NRZIOSBNOYV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly AAJFJJKJFBW LRLSFXOVHIE;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType XVWBQTRLSIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB75090", Offset = "0xB73890", VA = "0x180B75090", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1C2FF00", Offset = "0x1C2E700", VA = "0x181C2FF00", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8113830", Offset = "0x8112030", VA = "0x188113830", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8113840", Offset = "0x8112040", VA = "0x188113840")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] AAJFJJKJFBW playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x81136E0", Offset = "0x8111EE0", VA = "0x1881136E0", Slot = "19")]
		protected override NRZIOSBNOYV OMYZJWAVCNX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : OQQOZXHRTNM<YSKBCZJNPFB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly CHEQRUTJYCF SUNALWBUGWK;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType XVWBQTRLSIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8113B00", Offset = "0x8112300", VA = "0x188113B00", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1C21BC0", Offset = "0x1C203C0", VA = "0x181C21BC0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8113B10", Offset = "0x8112310", VA = "0x188113B10")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] CHEQRUTJYCF roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x81139F0", Offset = "0x81121F0", VA = "0x1881139F0", Slot = "19")]
		protected override YSKBCZJNPFB OMYZJWAVCNX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class OQQOZXHRTNM<a> : PBJPHDZFXEY<a> where a : CSJZUSSUSLU
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x59F96C0", Offset = "0x59F7EC0", VA = "0x1859F96C0", Slot = "16")]
		public override a IRKMMXBOLYD(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x59F9620", Offset = "0x59F7E20", VA = "0x1859F9620", Slot = "18")]
		protected override string GVVRUSZRIGQ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x59F9700", Offset = "0x59F7F00", VA = "0x1859F9700", Slot = "17")]
		protected override bool TLKXHJUWWWO(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a OMYZJWAVCNX(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x59F9820", Offset = "0x59F8020", VA = "0x1859F9820")]
		protected OQQOZXHRTNM()
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
