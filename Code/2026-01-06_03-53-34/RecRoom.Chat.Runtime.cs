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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8216E50", Offset = "0x8215850", VA = "0x188216E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x821ACD0", Offset = "0x82196D0", VA = "0x18821ACD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2748530", Offset = "0x2746F30", VA = "0x182748530")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public XHDCJOGKBMU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x821A6A0", Offset = "0x82190A0", VA = "0x18821A6A0")]
			internal DNXWICJZUNF OMVFGSKRWWL(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x821A670", Offset = "0x8219070", VA = "0x18821A670")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public KMOETCHCLJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x82162B0", Offset = "0x8214CB0", VA = "0x1882162B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public WKDHTAWVSFY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8219930", Offset = "0x8218330", VA = "0x188219930")]
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
		[Cpp2IlInjected.Address(RVA = "0x82154B0", Offset = "0x8213EB0", VA = "0x1882154B0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] PLABEEHJDLT accountsClient, [Inject(null)] FFTUYXIKHKP chatClient, [Inject(null)] EBFKHKAHMLG clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8214990", Offset = "0x8213390", VA = "0x188214990", Slot = "5")]
		public bool EIFPVANGMWJ(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8214810", Offset = "0x8213210", VA = "0x188214810", Slot = "6")]
		public ChatMessage DUHWMTWZVYP(long a, JAILNKMLDZM.LUJXTCUJHOY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8215130", Offset = "0x8213B30", VA = "0x188215130", Slot = "7")]
		public PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(JAILNKMLDZM.LUJXTCUJHOY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82152B0", Offset = "0x8213CB0", VA = "0x1882152B0", Slot = "4")]
		public void XKAMEJJZZQZ(KARTPJIOHDD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8215040", Offset = "0x8213A40", VA = "0x188215040", Slot = "8")]
		public void NFHXNAYYEAS(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8214610", Offset = "0x8213010", VA = "0x188214610")]
		private JAILNKMLDZM.LUJXTCUJHOY DDLPBLLROKI(JAILNKMLDZM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8214E60", Offset = "0x8213860", VA = "0x188214E60")]
		private void LAZCNIZJDFH(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8214C60", Offset = "0x8213660", VA = "0x188214C60")]
		private void IQSOQXWPAQO(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8214B80", Offset = "0x8213580", VA = "0x188214B80")]
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
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "10")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8216F70", Offset = "0x8215970", VA = "0x188216F70")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8216ED0", Offset = "0x82158D0", VA = "0x188216ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBA0AD0", Offset = "0xB9F4D0", VA = "0x180BA0AD0", Slot = "10")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string POSRCRWSMOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC441D0", Offset = "0xC42BD0", VA = "0x180C441D0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long UGDGVMEFFTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8217170", Offset = "0x8215B70", VA = "0x188217170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8217230", Offset = "0x8215C30", VA = "0x188217230")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82171F0", Offset = "0x8215BF0", VA = "0x1882171F0")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SPJFTHMAHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8217A30", Offset = "0x8216430", VA = "0x188217A30")]
		[UKOBXVXKPZF.Root]
		internal static void RHCAPTNCDGO(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8217D10", Offset = "0x8216710", VA = "0x188217D10")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8215740", Offset = "0x8214140", VA = "0x188215740")]
			internal string IZZFORLMUAN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] RIROKFWPYUV;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8219E60", Offset = "0x8218860", VA = "0x188219E60")]
		public static PVOPFDWRLHK<string> PBUGWDHOEVV(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8219F30", Offset = "0x8218930", VA = "0x188219F30")]
		public static PVOPFDWRLHK<string> PBUGWDHOEVV(JAILNKMLDZM.LUJXTCUJHOY a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82199B0", Offset = "0x82183B0", VA = "0x1882199B0")]
		private static string BHNCNCLNWBV(VCEIYFOIBJU a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x821A250", Offset = "0x8218C50", VA = "0x18821A250")]
		public static string QNMADYCPMEF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8219C70", Offset = "0x8218670", VA = "0x188219C70")]
		public static string CEBHGSUHIMC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8219DF0", Offset = "0x82187F0", VA = "0x188219DF0")]
		public static bool JYNDTVJSOCZ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8219D80", Offset = "0x8218780", VA = "0x188219D80")]
		public static bool IHMMDWYAUNY(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x821A350", Offset = "0x8218D50", VA = "0x18821A350")]
		public static bool RBZGHTWFQGB(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x821A380", Offset = "0x8218D80", VA = "0x18821A380")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x8219390", Offset = "0x8217D90", VA = "0x188219390", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8218E40", Offset = "0x8217840", VA = "0x188218E40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82197A0", Offset = "0x82181A0", VA = "0x1882197A0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82194D0", Offset = "0x8217ED0", VA = "0x1882194D0")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8219690", Offset = "0x8218090", VA = "0x188219690")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8218D50", Offset = "0x8217750", VA = "0x188218D50", Slot = "17")]
		public void GYFKHNLMALV(CSJZUSSUSLU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8218ED0", Offset = "0x82178D0", VA = "0x188218ED0", Slot = "16")]
		public DNXWICJZUNF RFWXKEZOSVP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82192A0", Offset = "0x8217CA0", VA = "0x1882192A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
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
			[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAB99A0", Offset = "0xAB83A0", VA = "0x180AB99A0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x82143B0", Offset = "0x8212DB0", VA = "0x1882143B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long WKVVRWALFCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string WQZDIZZKEQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object AWEFYYJZBNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DNXWICJZUNF SSNPVIDDTSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82143F0", Offset = "0x8212DF0", VA = "0x1882143F0")]
		protected CSJZUSSUSLU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8214560", Offset = "0x8212F60", VA = "0x188214560")]
		protected CSJZUSSUSLU(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8214490", Offset = "0x8212E90", VA = "0x188214490")]
		protected CSJZUSSUSLU(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8214360", Offset = "0x8212D60", VA = "0x188214360")]
		protected void HKJVWIWUAIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82141D0", Offset = "0x8212BD0", VA = "0x1882141D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8214330", Offset = "0x8212D30", VA = "0x188214330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x82142B0", Offset = "0x8212CB0", VA = "0x1882142B0", Slot = "4")]
		public bool Equals(CSJZUSSUSLU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public GXJZCZDFVCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4E4E000", Offset = "0x4E4CA00", VA = "0x184E4E000")]
			internal void IEKPTRHPTWE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a AWEFYYJZBNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4E40230", Offset = "0x4E3EC30", VA = "0x184E40230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4E40280", Offset = "0x4E3EC80", VA = "0x184E40280")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4E406F0", Offset = "0x4E3F0F0", VA = "0x184E406F0")]
		protected GOIGNLVMMWY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E402A0", Offset = "0x4E3ECA0", VA = "0x184E402A0")]
		protected GOIGNLVMMWY(string a, long b, string c, PVOPFDWRLHK<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void KLHLUZJFGPN(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4E401E0", Offset = "0x4E3EBE0", VA = "0x184E401E0")]
		private void LLYUOSPBXBA(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E401C0", Offset = "0x4E3EBC0", VA = "0x184E401C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB9B090", Offset = "0xB99A90", VA = "0x180B9B090", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8215AB0", Offset = "0x82144B0", VA = "0x188215AB0")]
		public KIOFPLAOSOG(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8215A40", Offset = "0x8214440", VA = "0x188215A40")]
		public KIOFPLAOSOG(string a, long b, string c, PVOPFDWRLHK<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82159D0", Offset = "0x82143D0", VA = "0x1882159D0", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8215970", Offset = "0x8214370", VA = "0x188215970", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xB82730", Offset = "0xB81130", VA = "0x180B82730", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8217840", Offset = "0x8216240", VA = "0x188217840")]
		public QJOSLJRLWXK(string a, long b, string c, PVOPFDWRLHK<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82177B0", Offset = "0x82161B0", VA = "0x1882177B0", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8217760", Offset = "0x8216160", VA = "0x188217760", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xBA0AD0", Offset = "0xB9F4D0", VA = "0x180BA0AD0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8215900", Offset = "0x8214300", VA = "0x188215900")]
		public HKMDWRCFHAV(string a, long b, string c, PVOPFDWRLHK<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8215810", Offset = "0x8214210", VA = "0x188215810", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x82157A0", Offset = "0x82141A0", VA = "0x1882157A0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xB8C200", Offset = "0xB8AC00", VA = "0x180B8C200", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8216C50", Offset = "0x8215650", VA = "0x188216C50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8216D90", Offset = "0x8215790", VA = "0x188216D90")]
		public NRZIOSBNOYV(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8216DE0", Offset = "0x82157E0", VA = "0x188216DE0")]
		public NRZIOSBNOYV(string a, long b, string c, PVOPFDWRLHK<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8216D20", Offset = "0x8215720", VA = "0x188216D20", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8216CD0", Offset = "0x82156D0", VA = "0x188216CD0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x821A8C0", Offset = "0x82192C0", VA = "0x18821A8C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x821AC80", Offset = "0x8219680", VA = "0x18821AC80")]
		public YSKBCZJNPFB(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x821AC10", Offset = "0x8219610", VA = "0x18821AC10")]
		public YSKBCZJNPFB(string a, long b, string c, PVOPFDWRLHK<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x821AAB0", Offset = "0x82194B0", VA = "0x18821AAB0", Slot = "9")]
		public override string QWCDEUURZFO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x821AA30", Offset = "0x8219430", VA = "0x18821AA30", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E09BB0", Offset = "0x3E085B0", VA = "0x183E09BB0", Slot = "7")]
		private JAILNKMLDZM.LUJXTCUJHOY TPDRQFDIUTD(JAILNKMLDZM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3E09B50", Offset = "0x3E08550", VA = "0x183E09B50", Slot = "6")]
		private PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> RWEMFNWRHLI(JAILNKMLDZM.LUJXTCUJHOY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3E09910", Offset = "0x3E08310", VA = "0x183E09910", Slot = "10")]
		public virtual a DDLPBLLROKI(JAILNKMLDZM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3E09BD0", Offset = "0x3E085D0", VA = "0x183E09BD0", Slot = "11")]
		public virtual PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "12")]
		protected virtual void UHYQIXSXSGJ(a a, JAILNKMLDZM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3E09AD0", Offset = "0x3E084D0", VA = "0x183E09AD0", Slot = "13")]
		protected virtual PVOPFDWRLHK<string> JYWJCVWISIV(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected YGNYTBNJRMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3E099F0", Offset = "0x3E083F0", VA = "0x183E099F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType BFJYMHQJKIL
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int VJYYPDMEGLO
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int YDGCAEFEIMX
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string ZXSYHZMTGKT
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x13E59A0", Offset = "0x13E43A0", VA = "0x1813E59A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8216BC0", Offset = "0x82155C0", VA = "0x188216BC0")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] CHEQRUTJYCF roomsClient, [Inject(null)] PLABEEHJDLT accountsClient, [Inject(null)] SFMVFYGJSPJ imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8216B80", Offset = "0x8215580", VA = "0x188216B80", Slot = "11")]
		public override PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x82162E0", Offset = "0x8214CE0", VA = "0x1882162E0", Slot = "10")]
		public override TextMessageDetails DDLPBLLROKI(JAILNKMLDZM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8216400", Offset = "0x8214E00", VA = "0x188216400")]
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
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "9")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8216F80", Offset = "0x8215980", VA = "0x188216F80")]
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
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xBA0AD0", Offset = "0xB9F4D0", VA = "0x180BA0AD0", Slot = "9")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8217240", Offset = "0x8215C40", VA = "0x188217240", Slot = "12")]
		protected override void UHYQIXSXSGJ(PhotoMessageDetails a, JAILNKMLDZM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82173E0", Offset = "0x8215DE0", VA = "0x1882173E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public KMOETCHCLJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8215B00", Offset = "0x8214500", VA = "0x188215B00")]
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
			[Cpp2IlInjected.Address(RVA = "0xBA0AD0", Offset = "0xB9F4D0", VA = "0x180BA0AD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override JAILNKMLDZM.MessageContentType MFJIDYCBYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "9")]
			get
			{
				return default(JAILNKMLDZM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8217E60", Offset = "0x8216860", VA = "0x188217E60", Slot = "14")]
		public void FVDBNMHLIKZ(ICROMUFPDGD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8218850", Offset = "0x8217250", VA = "0x188218850", Slot = "11")]
		public override PVOPFDWRLHK<JAILNKMLDZM.QNWWRNGAASU> WVOUHSYSWLB(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82181F0", Offset = "0x8216BF0", VA = "0x1882181F0", Slot = "12")]
		protected override void UHYQIXSXSGJ(TextMessageDetails a, JAILNKMLDZM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8218AF0", Offset = "0x82174F0", VA = "0x188218AF0")]
		private bool XRHDVDIYGQT(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8218610", Offset = "0x8217010", VA = "0x188218610")]
		private static int VMZVIKXWQXU(TextMessageDetails a, int b, bool c, ICROMUFPDGD d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8218C30", Offset = "0x8217630", VA = "0x188218C30")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B87BC0", Offset = "0x5B865C0", VA = "0x185B87BC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B87C90", Offset = "0x5B86690", VA = "0x185B87C90", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5B88200", Offset = "0x5B86C00", VA = "0x185B88200")]
		protected PBJPHDZFXEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5B874C0", Offset = "0x5B85EC0", VA = "0x185B874C0")]
		protected string ACFHXPLJLPE(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B87F40", Offset = "0x5B86940", VA = "0x185B87F40", Slot = "14")]
		public bool ZMUPFJICOJR(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5B87D90", Offset = "0x5B86790", VA = "0x185B87D90", Slot = "15")]
		public void NLCDPTDORKK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a IRKMMXBOLYD(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5B87F20", Offset = "0x5B86920", VA = "0x185B87F20", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B87CB0", Offset = "0x5B866B0", VA = "0x185B87CB0")]
		private bool LZQPQDKLIPA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5B87EB0", Offset = "0x5B868B0", VA = "0x185B87EB0")]
		private string RHSMVEJIYTS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5B875C0", Offset = "0x5B85FC0", VA = "0x185B875C0", Slot = "6")]
		private bool EENNFXTJVJA(string a, [Out] CSJZUSSUSLU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5B87A70", Offset = "0x5B86470", VA = "0x185B87A70", Slot = "7")]
		private void HOTKSJXFFXX(CSJZUSSUSLU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5B87A40", Offset = "0x5B86440", VA = "0x185B87A40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B877D0", Offset = "0x5B861D0", VA = "0x185B877D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5B87960", Offset = "0x5B86360", VA = "0x185B87960", Slot = "9")]
		public bool Equals(ICROMUFPDGD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B877A0", Offset = "0x5B861A0", VA = "0x185B877A0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xB9B090", Offset = "0xB99A90", VA = "0x180B9B090", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1C46BC0", Offset = "0x1C455C0", VA = "0x181C46BC0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x82156D0", Offset = "0x82140D0", VA = "0x1882156D0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x82156E0", Offset = "0x82140E0", VA = "0x1882156E0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] EBFKHKAHMLG clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8215580", Offset = "0x8213F80", VA = "0x188215580", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xB82730", Offset = "0xB81130", VA = "0x180B82730", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1C4BF20", Offset = "0x1C4A920", VA = "0x181C4BF20", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB54950", Offset = "0xB53350", VA = "0x180B54950", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8217110", Offset = "0x8215B10", VA = "0x188217110")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] SFMVFYGJSPJ imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8216FC0", Offset = "0x82159C0", VA = "0x188216FC0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xBA0AD0", Offset = "0xB9F4D0", VA = "0x180BA0AD0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1CB17F0", Offset = "0x1CB01F0", VA = "0x181CB17F0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8217530", Offset = "0x8215F30", VA = "0x188217530", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8217540", Offset = "0x8215F40", VA = "0x188217540")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] PLABEEHJDLT accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8217420", Offset = "0x8215E20", VA = "0x188217420", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xB8C200", Offset = "0xB8AC00", VA = "0x180B8C200", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1C46BC0", Offset = "0x1C455C0", VA = "0x181C46BC0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x82176F0", Offset = "0x82160F0", VA = "0x1882176F0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8217700", Offset = "0x8216100", VA = "0x188217700")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] AAJFJJKJFBW playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x82175A0", Offset = "0x8215FA0", VA = "0x1882175A0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char LUUCTZCSOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x82179C0", Offset = "0x82163C0", VA = "0x1882179C0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char ZGORMMCSNMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1C38850", Offset = "0x1C37250", VA = "0x181C38850", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x82179D0", Offset = "0x82163D0", VA = "0x1882179D0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] CHEQRUTJYCF roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x82178B0", Offset = "0x82162B0", VA = "0x1882178B0", Slot = "19")]
		protected override YSKBCZJNPFB OMYZJWAVCNX(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class OQQOZXHRTNM<a> : PBJPHDZFXEY<a> where a : CSJZUSSUSLU
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8C90", Offset = "0x5AB7690", VA = "0x185AB8C90", Slot = "16")]
		public override a IRKMMXBOLYD(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8BF0", Offset = "0x5AB75F0", VA = "0x185AB8BF0", Slot = "18")]
		protected override string GVVRUSZRIGQ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8CD0", Offset = "0x5AB76D0", VA = "0x185AB8CD0", Slot = "17")]
		protected override bool TLKXHJUWWWO(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a OMYZJWAVCNX(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8DF0", Offset = "0x5AB77F0", VA = "0x185AB8DF0")]
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
