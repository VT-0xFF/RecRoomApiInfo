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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9881C70", Offset = "0x9880670", VA = "0x189881C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
		[Cpp2IlInjected.Address(RVA = "0x9884B10", Offset = "0x9883510", VA = "0x189884B10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : KLUIJYWJDAT
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class GHUATSDHYIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage OVVBKZQPZUC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GHUATSDHYIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x987FC70", Offset = "0x987E670", VA = "0x18987FC70")]
			internal NFPDGBDVXFD FQEZZBWVPXP(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x987FC40", Offset = "0x987E640", VA = "0x18987FC40")]
			internal void FPZTBVCYGMG(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BVQANBPWYUJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage OVVBKZQPZUC;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BVQANBPWYUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x987DF50", Offset = "0x987C950", VA = "0x18987DF50")]
			internal void INLCCEIRMEA(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class XCEEGWYISVS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ODNKFSMINWM.MessageContentType LYDSDYJEMRE;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public XCEEGWYISVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9884660", Offset = "0x9883060", VA = "0x189884660")]
			internal bool QGENIRMPJJN(LEBDQHZUUED a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ODNKFSMINWM.RHQNCVRQPDM SYNRIACYBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int RVRCNQHOPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<LEBDQHZUUED> USLKOJJYUHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly GTMOJNOMKIL KYYLEUTVOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly KYYQUYMODAZ PLIAPWNDUEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly QRPAHXMZSTA PITUOEKFDHL;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x987F950", Offset = "0x987E350", VA = "0x18987F950")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] GTMOJNOMKIL accountsClient, [Inject(null)] KYYQUYMODAZ chatClient, [Inject(null)] QRPAHXMZSTA clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x987ECA0", Offset = "0x987D6A0", VA = "0x18987ECA0", Slot = "5")]
		public bool CHPWDCITFZR(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x987F3E0", Offset = "0x987DDE0", VA = "0x18987F3E0", Slot = "6")]
		public ChatMessage MCCKHERHWOJ(long a, ODNKFSMINWM.RHQNCVRQPDM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x987EE90", Offset = "0x987D890", VA = "0x18987EE90", Slot = "7")]
		public CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(ODNKFSMINWM.RHQNCVRQPDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x987F560", Offset = "0x987DF60", VA = "0x18987F560", Slot = "4")]
		public void MIHIFLBMPWX(LEBDQHZUUED a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x987F010", Offset = "0x987DA10", VA = "0x18987F010", Slot = "8")]
		public void FGLKAGJNITK(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x987F1E0", Offset = "0x987DBE0", VA = "0x18987F1E0")]
		private ODNKFSMINWM.RHQNCVRQPDM KBCDTDGUCKW(ODNKFSMINWM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x987F670", Offset = "0x987E070", VA = "0x18987F670")]
		private void WDUGHUCYFIL(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x987EAA0", Offset = "0x987D4A0", VA = "0x18987EAA0")]
		private void BGKZWMKFAVK(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x987F100", Offset = "0x987DB00", VA = "0x18987F100")]
		private LEBDQHZUUED JYPVCRRZBLX(int a, ODNKFSMINWM.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface KLUIJYWJDAT
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MIHIFLBMPWX(LEBDQHZUUED a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CHPWDCITFZR(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage MCCKHERHWOJ(long a, ODNKFSMINWM.RHQNCVRQPDM b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(ODNKFSMINWM.RHQNCVRQPDM a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FGLKAGJNITK(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface IDUWQQXCGVW
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		ASNKAFBFVVA<IDUWQQXCGVW> ZRYVFEBNGNS
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool JYRFOKNMWVG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<OFAHGBLTYQU> KHLYTZCJGUV
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string PXUWVBIVPWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NFPDGBDVXFD TTAMQXJCGNB();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : ODNKFSMINWM.RHQNCVRQPDM
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "10")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98821D0", Offset = "0x9880BD0", VA = "0x1898821D0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9882130", Offset = "0x9880B30", VA = "0x189882130")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : ODNKFSMINWM.RHQNCVRQPDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long LYZFMQNLRLN;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD7B500", Offset = "0xD79F00", VA = "0x180D7B500", Slot = "10")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string GBRLODULFZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xF386D0", Offset = "0xF370D0", VA = "0x180F386D0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long UKFSRSVFAMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x98823D0", Offset = "0x9880DD0", VA = "0x1898823D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9882490", Offset = "0x9880E90", VA = "0x189882490")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9882450", Offset = "0x9880E50", VA = "0x189882450")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class HIGZRIWESLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9880B70", Offset = "0x987F570", VA = "0x189880B70")]
		[CXDXQIFYXBD.Root]
		internal static void KPVEPOXULCM(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9880E50", Offset = "0x987F850", VA = "0x189880E50")]
		[UnityEngine.Scripting.Preserve]
		public HIGZRIWESLE([Inject(null)] KLUIJYWJDAT chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] ZRGTJLYUSYQ textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GROSFUSLSXN
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IDUWQQXCGVW DGMTUXXTXWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool ENCWLZVYKQX;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x987FBE0", Offset = "0x987E5E0", VA = "0x18987FBE0")]
			internal string CCBIQFYVHHV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] VJQZYTYIOJN;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9880220", Offset = "0x987EC20", VA = "0x189880220")]
		public static CCAFLELIKTY<string> HRZFTAIQWQZ(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x987FF00", Offset = "0x987E900", VA = "0x18987FF00")]
		public static CCAFLELIKTY<string> HRZFTAIQWQZ(ODNKFSMINWM.RHQNCVRQPDM a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9880400", Offset = "0x987EE00", VA = "0x189880400")]
		private static string KHIEFNRBGSB(IDUWQQXCGVW a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98802F0", Offset = "0x987ECF0", VA = "0x1898802F0")]
		public static string JMSBCRHJAVZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98806C0", Offset = "0x987F0C0", VA = "0x1898806C0")]
		public static string NZYEIXMDOTO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x987FE90", Offset = "0x987E890", VA = "0x18987FE90")]
		public static bool DTCIHJUZNGP(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98807D0", Offset = "0x987F1D0", VA = "0x1898807D0")]
		public static bool RAHYPEDEGWM(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9880990", Offset = "0x987F390", VA = "0x189880990")]
		public static bool VQDDVORNBWT(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9880840", Offset = "0x987F240", VA = "0x189880840")]
		public static string TEMESFCNOXH(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : ODNKFSMINWM.RHQNCVRQPDM, IDUWQQXCGVW
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ASNKAFBFVVA<IDUWQQXCGVW> ZRYVFEBNGNS
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<OFAHGBLTYQU> KHLYTZCJGUV
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JYRFOKNMWVG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9883A40", Offset = "0x9882440", VA = "0x189883A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9883C70", Offset = "0x9882670", VA = "0x189883C70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x98844D0", Offset = "0x9882ED0", VA = "0x1898844D0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98841F0", Offset = "0x9882BF0", VA = "0x1898841F0")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98843C0", Offset = "0x9882DC0", VA = "0x1898843C0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9883B80", Offset = "0x9882580", VA = "0x189883B80", Slot = "17")]
		public void GJNSMKDNLZH(OFAHGBLTYQU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9883D00", Offset = "0x9882700", VA = "0x189883D00", Slot = "16")]
		public NFPDGBDVXFD TTAMQXJCGNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9884100", Offset = "0x9882B00", VA = "0x189884100")]
		private void XZQGEYFGDJQ(OFAHGBLTYQU a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class OFAHGBLTYQU : IEquatable<OFAHGBLTYQU>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ASNKAFBFVVA<OFAHGBLTYQU> ZRYVFEBNGNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool JYRFOKNMWVG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD19FA0", Offset = "0xD189A0", VA = "0x180D19FA0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9881ED0", Offset = "0x98808D0", VA = "0x189881ED0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string FUWPEWHGXTV
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long MIDTYYXFTXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ALFYGILKTXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object QKDYCBQYGBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public NFPDGBDVXFD KFPFTKFXBHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9881F10", Offset = "0x9880910", VA = "0x189881F10")]
		protected OFAHGBLTYQU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9881FB0", Offset = "0x98809B0", VA = "0x189881FB0")]
		protected OFAHGBLTYQU(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9882060", Offset = "0x9880A60", VA = "0x189882060")]
		protected OFAHGBLTYQU(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9881CF0", Offset = "0x98806F0", VA = "0x189881CF0")]
		protected void CNPIBPIIBQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9881DC0", Offset = "0x98807C0", VA = "0x189881DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9881EA0", Offset = "0x98808A0", VA = "0x189881EA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9881D40", Offset = "0x9880740", VA = "0x189881D40", Slot = "4")]
		public bool Equals(OFAHGBLTYQU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string BNJTJCYSFYO(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class RQKJQKYDPLA<a, b> : OFAHGBLTYQU where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class WYUZZVKPLDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public WSVTGTOMDSW IVHNZXBZDYR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public RQKJQKYDPLA<a, b> XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public WYUZZVKPLDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x873B440", Offset = "0x8739E40", VA = "0x18873B440")]
			internal void ACUCXSIDLHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a QKDYCBQYGBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7773290", Offset = "0x7771C90", VA = "0x187773290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7773300", Offset = "0x7771D00", VA = "0x187773300")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7773320", Offset = "0x7771D20", VA = "0x187773320")]
		protected RQKJQKYDPLA(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x77733D0", Offset = "0x7771DD0", VA = "0x1877733D0")]
		protected RQKJQKYDPLA(string a, long b, string c, CCAFLELIKTY<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void BVLPNHOMQIF(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7773240", Offset = "0x7771C40", VA = "0x187773240")]
		private void DKJNJZAYARS(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x77732E0", Offset = "0x7771CE0", VA = "0x1877732E0")]
		[CompilerGenerated]
		private void UXTXPTSEIGR(string a)
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
	public class LKMVFEQQQXO : RQKJQKYDPLA<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD7B6F0", Offset = "0xD7A0F0", VA = "0x180D7B6F0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9881070", Offset = "0x987FA70", VA = "0x189881070")]
		public LKMVFEQQQXO(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98810C0", Offset = "0x987FAC0", VA = "0x1898810C0")]
		public LKMVFEQQQXO(string a, long b, string c, CCAFLELIKTY<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9880FA0", Offset = "0x987F9A0", VA = "0x189880FA0", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9881010", Offset = "0x987FA10", VA = "0x189881010", Slot = "10")]
		protected override void BVLPNHOMQIF(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CDNQHPFKJIK : RQKJQKYDPLA<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD94D90", Offset = "0xD93790", VA = "0x180D94D90", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x987E830", Offset = "0x987D230", VA = "0x18987E830")]
		public CDNQHPFKJIK(string a, long b, string c, CCAFLELIKTY<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x987E750", Offset = "0x987D150", VA = "0x18987E750", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x987E7E0", Offset = "0x987D1E0", VA = "0x18987E7E0", Slot = "10")]
		protected override void BVLPNHOMQIF(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class MQKSXEKGCOT : RQKJQKYDPLA<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD7B500", Offset = "0xD79F00", VA = "0x180D7B500", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9881C00", Offset = "0x9880600", VA = "0x189881C00")]
		public MQKSXEKGCOT(string a, long b, string c, CCAFLELIKTY<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9881AA0", Offset = "0x98804A0", VA = "0x189881AA0", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9881B90", Offset = "0x9880590", VA = "0x189881B90", Slot = "10")]
		protected override void BVLPNHOMQIF(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class CXWCIYSXMFV : RQKJQKYDPLA<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD7F370", Offset = "0xD7DD70", VA = "0x180D7F370", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x987E960", Offset = "0x987D360", VA = "0x18987E960", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x987EA50", Offset = "0x987D450", VA = "0x18987EA50")]
		public CXWCIYSXMFV(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x987E9E0", Offset = "0x987D3E0", VA = "0x18987E9E0")]
		public CXWCIYSXMFV(string a, long b, string c, CCAFLELIKTY<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x987E8A0", Offset = "0x987D2A0", VA = "0x18987E8A0", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x987E910", Offset = "0x987D310", VA = "0x18987E910", Slot = "10")]
		protected override void BVLPNHOMQIF(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ZAWNNMFNTCV : RQKJQKYDPLA<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] SMWGGTOYFLN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string HCMAERJSZYR
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9884820", Offset = "0x9883220", VA = "0x189884820", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9884AC0", Offset = "0x98834C0", VA = "0x189884AC0")]
		public ZAWNNMFNTCV(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9884A50", Offset = "0x9883450", VA = "0x189884A50")]
		public ZAWNNMFNTCV(string a, long b, string c, CCAFLELIKTY<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x98846E0", Offset = "0x98830E0", VA = "0x1898846E0", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x98847A0", Offset = "0x98831A0", VA = "0x1898847A0", Slot = "10")]
		protected override void BVLPNHOMQIF(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class OGAIEEOQHOG<a> : LEBDQHZUUED where a : ODNKFSMINWM.RHQNCVRQPDM, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int YOEKAAIYPRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x73B7B40", Offset = "0x73B6540", VA = "0x1873B7B40", Slot = "7")]
		private ODNKFSMINWM.RHQNCVRQPDM PZEXJVJFUST(ODNKFSMINWM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x73B7B60", Offset = "0x73B6560", VA = "0x1873B7B60", Slot = "6")]
		private CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> RHMBCGIFQLO(ODNKFSMINWM.RHQNCVRQPDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x73B79E0", Offset = "0x73B63E0", VA = "0x1873B79E0", Slot = "10")]
		public virtual a KBCDTDGUCKW(ODNKFSMINWM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x73B7810", Offset = "0x73B6210", VA = "0x1873B7810", Slot = "11")]
		public virtual CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "12")]
		protected virtual void ACIAHYRIRCH(a a, ODNKFSMINWM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x73B7AC0", Offset = "0x73B64C0", VA = "0x1873B7AC0", Slot = "13")]
		protected virtual CCAFLELIKTY<string> KTESTKZMWEP(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected OGAIEEOQHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x73B7730", Offset = "0x73B6130", VA = "0x1873B7730")]
		[CompilerGenerated]
		private ODNKFSMINWM.IQKMMOYEJRE BLDWJCGRMZH(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface LEBDQHZUUED
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int YOEKAAIYPRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(ODNKFSMINWM.RHQNCVRQPDM a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ODNKFSMINWM.RHQNCVRQPDM KBCDTDGUCKW(ODNKFSMINWM.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface ZRGTJLYUSYQ : LEBDQHZUUED
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PKTXINUCELZ(RVNNWQATMBD a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : OGAIEEOQHOG<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class LEVKNBIOFWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool FFOFFAGVGVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int DSNRUCXHOMQ;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string YWFOPIEBYOQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType YFKMMNNXMAZ
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int GDLOFLZFYLU
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x1664600", Offset = "0x1663000", VA = "0x181664600")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1664610", Offset = "0x1663010", VA = "0x181664610")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int TVYNJKHIZEF
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string UBMXMNJQWUV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16ECD50", Offset = "0x16EB750", VA = "0x1816ECD50")]
			public LEVKNBIOFWU()
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
		private readonly HPHVJCTOAPJ UWWJWBJVJDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly GTMOJNOMKIL KYYLEUTVOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly EFPNFTWXNWR VSSEIVERLSQ;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int YOEKAAIYPRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9881A10", Offset = "0x9880410", VA = "0x189881A10")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] HPHVJCTOAPJ roomsClient, [Inject(null)] GTMOJNOMKIL accountsClient, [Inject(null)] EFPNFTWXNWR imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9881130", Offset = "0x987FB30", VA = "0x189881130", Slot = "11")]
		public override CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9881170", Offset = "0x987FB70", VA = "0x189881170", Slot = "10")]
		public override TextMessageDetails KBCDTDGUCKW(ODNKFSMINWM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9881290", Offset = "0x987FC90", VA = "0x189881290")]
		private void VEMXYHGHBHI(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : OGAIEEOQHOG<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int YOEKAAIYPRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "9")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x98821E0", Offset = "0x9880BE0", VA = "0x1898821E0")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : OGAIEEOQHOG<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int YOEKAAIYPRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD7B500", Offset = "0xD79F00", VA = "0x180D7B500", Slot = "9")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x98824A0", Offset = "0x9880EA0", VA = "0x1898824A0", Slot = "12")]
		protected override void ACIAHYRIRCH(PhotoMessageDetails a, ODNKFSMINWM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9882640", Offset = "0x9881040", VA = "0x189882640")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : OGAIEEOQHOG<TextMessageDetails>, ZRGTJLYUSYQ, LEBDQHZUUED
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class BVQANBPWYUJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails YDDBPDLRVYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool XKRFTWEOAWK;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BVQANBPWYUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x987DF80", Offset = "0x987C980", VA = "0x18987DF80")]
			internal ODNKFSMINWM.IQKMMOYEJRE ULHBGAKJLKP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int LYPGZJFVFUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int EJTDMXVQCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, RVNNWQATMBD> SGCPQBFMBEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, RVNNWQATMBD> MHJBODHFUPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private GGRGMHQSACG<MQKSXEKGCOT> GPFZZFGQBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GGRGMHQSACG<ZAWNNMFNTCV> QUHYFVMCJTZ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int YOEKAAIYPRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xD7B500", Offset = "0xD79F00", VA = "0x180D7B500", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "9")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9883350", Offset = "0x9881D50", VA = "0x189883350", Slot = "14")]
		public void PKTXINUCELZ(RVNNWQATMBD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x98830B0", Offset = "0x9881AB0", VA = "0x1898830B0", Slot = "11")]
		public override CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9882B40", Offset = "0x9881540", VA = "0x189882B40", Slot = "12")]
		protected override void ACIAHYRIRCH(TextMessageDetails a, ODNKFSMINWM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9882F70", Offset = "0x9881970", VA = "0x189882F70")]
		private bool BISNHJCHDEN(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x98836E0", Offset = "0x98820E0", VA = "0x1898836E0")]
		private static int XNOAVDSXJPW(TextMessageDetails a, int b, bool c, RVNNWQATMBD d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9883920", Offset = "0x9882320", VA = "0x189883920")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class WMIXDHVCPXY<a> : GGRGMHQSACG<a>, RVNNWQATMBD, IEquatable<RVNNWQATMBD>, IEquatable<ChatTokenType> where a : OFAHGBLTYQU
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] LUBHNWVHBSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string ZXTBFPOYOCK;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType TKGTFHKJGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string VNZDCPXZGNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8729940", Offset = "0x8728340", VA = "0x188729940", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType ZOTWEQBZJNX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x87297D0", Offset = "0x87281D0", VA = "0x1887297D0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x872A190", Offset = "0x8728B90", VA = "0x18872A190")]
		protected WMIXDHVCPXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x87297F0", Offset = "0x87281F0", VA = "0x1887297F0")]
		protected string FJWNRFGHFTW(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8729A80", Offset = "0x8728480", VA = "0x188729A80", Slot = "14")]
		public bool PPXSQRKLNWN(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8729E20", Offset = "0x8728820", VA = "0x188729E20", Slot = "15")]
		public void XJHNULWSGEQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a XLRAZXKYYVL(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8729920", Offset = "0x8728320", VA = "0x188729920", Slot = "8")]
		private OFAHGBLTYQU JIVYZMQNPBQ(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool WIQLQAYBRKA(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string IUUTVXIVGOS(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8729520", Offset = "0x8727F20", VA = "0x188729520")]
		private bool CNOFDBBSHCU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8729A10", Offset = "0x8728410", VA = "0x188729A10")]
		private string KMIQOIGZDIG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8729C40", Offset = "0x8728640", VA = "0x188729C40", Slot = "6")]
		private bool QKZKOKNESRW(string a, [Out] OFAHGBLTYQU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8729F40", Offset = "0x8728940", VA = "0x188729F40", Slot = "7")]
		private void YDJSCFXZLBB(OFAHGBLTYQU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x87298F0", Offset = "0x87282F0", VA = "0x1887298F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x87296B0", Offset = "0x87280B0", VA = "0x1887296B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8729630", Offset = "0x8728030", VA = "0x188729630", Slot = "9")]
		public bool Equals(RVNNWQATMBD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8729600", Offset = "0x8728000", VA = "0x188729600", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : BZKQUICGRHS<LKMVFEQQQXO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly QRPAHXMZSTA PITUOEKFDHL;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType TKGTFHKJGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xD7B6F0", Offset = "0xD7A0F0", VA = "0x180D7B6F0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FE6D20", Offset = "0x1FE5720", VA = "0x181FE6D20", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x987FB70", Offset = "0x987E570", VA = "0x18987FB70", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x987FB80", Offset = "0x987E580", VA = "0x18987FB80")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] QRPAHXMZSTA clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x987FA20", Offset = "0x987E420", VA = "0x18987FA20", Slot = "19")]
		protected override LKMVFEQQQXO KNSZYWKYCPF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface RVNNWQATMBD : IEquatable<RVNNWQATMBD>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType TKGTFHKJGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string VNZDCPXZGNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PPXSQRKLNWN(string a, [Out] OFAHGBLTYQU b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XJHNULWSGEQ(OFAHGBLTYQU a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		OFAHGBLTYQU XLRAZXKYYVL(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface GGRGMHQSACG<a> : RVNNWQATMBD, IEquatable<RVNNWQATMBD>, IEquatable<ChatTokenType> where a : OFAHGBLTYQU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : BZKQUICGRHS<CDNQHPFKJIK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly EFPNFTWXNWR VSSEIVERLSQ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType TKGTFHKJGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD94D90", Offset = "0xD93790", VA = "0x180D94D90", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FEBF50", Offset = "0x1FEA950", VA = "0x181FEBF50", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE1F2F0", Offset = "0xE1DCF0", VA = "0x180E1F2F0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9882370", Offset = "0x9880D70", VA = "0x189882370")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] EFPNFTWXNWR imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9882220", Offset = "0x9880C20", VA = "0x189882220", Slot = "19")]
		protected override CDNQHPFKJIK KNSZYWKYCPF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : BZKQUICGRHS<MQKSXEKGCOT>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly GTMOJNOMKIL KYYLEUTVOCG;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType TKGTFHKJGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD7B500", Offset = "0xD79F00", VA = "0x180D7B500", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x20306B0", Offset = "0x202F0B0", VA = "0x1820306B0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9882790", Offset = "0x9881190", VA = "0x189882790", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x98827A0", Offset = "0x98811A0", VA = "0x1898827A0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] GTMOJNOMKIL accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9882680", Offset = "0x9881080", VA = "0x189882680", Slot = "19")]
		protected override MQKSXEKGCOT KNSZYWKYCPF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : BZKQUICGRHS<CXWCIYSXMFV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly HGHILNXCDDA RFHPQEWIJMK;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType TKGTFHKJGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD7F370", Offset = "0xD7DD70", VA = "0x180D7F370", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FE6D20", Offset = "0x1FE5720", VA = "0x181FE6D20", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9882950", Offset = "0x9881350", VA = "0x189882950", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9882960", Offset = "0x9881360", VA = "0x189882960")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] HGHILNXCDDA playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9882800", Offset = "0x9881200", VA = "0x189882800", Slot = "19")]
		protected override CXWCIYSXMFV KNSZYWKYCPF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : BZKQUICGRHS<ZAWNNMFNTCV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly HPHVJCTOAPJ UWWJWBJVJDW;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType TKGTFHKJGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9882AD0", Offset = "0x98814D0", VA = "0x189882AD0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FD03A0", Offset = "0x1FCEDA0", VA = "0x181FD03A0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9882AE0", Offset = "0x98814E0", VA = "0x189882AE0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] HPHVJCTOAPJ roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x98829C0", Offset = "0x98813C0", VA = "0x1898829C0", Slot = "19")]
		protected override ZAWNNMFNTCV KNSZYWKYCPF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class BZKQUICGRHS<a> : WMIXDHVCPXY<a> where a : OFAHGBLTYQU
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4F29A60", Offset = "0x4F28460", VA = "0x184F29A60", Slot = "16")]
		public override a XLRAZXKYYVL(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4F298A0", Offset = "0x4F282A0", VA = "0x184F298A0", Slot = "18")]
		protected override string IUUTVXIVGOS(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4F29940", Offset = "0x4F28340", VA = "0x184F29940", Slot = "17")]
		protected override bool WIQLQAYBRKA(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a KNSZYWKYCPF(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4F29AA0", Offset = "0x4F284A0", VA = "0x184F29AA0")]
		protected BZKQUICGRHS()
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
