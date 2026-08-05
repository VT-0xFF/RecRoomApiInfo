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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9700770", Offset = "0x96FF570", VA = "0x189700770")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9703610", Offset = "0x9702410", VA = "0x189703610", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29EF0F0", Offset = "0x29EDEF0", VA = "0x1829EF0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public GHUATSDHYIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x96FE770", Offset = "0x96FD570", VA = "0x1896FE770")]
			internal NFPDGBDVXFD FQEZZBWVPXP(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x96FE740", Offset = "0x96FD540", VA = "0x1896FE740")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BVQANBPWYUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x96FCA70", Offset = "0x96FB870", VA = "0x1896FCA70")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public XCEEGWYISVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9703160", Offset = "0x9701F60", VA = "0x189703160")]
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
		[Cpp2IlInjected.Address(RVA = "0x96FE450", Offset = "0x96FD250", VA = "0x1896FE450")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] GTMOJNOMKIL accountsClient, [Inject(null)] KYYQUYMODAZ chatClient, [Inject(null)] QRPAHXMZSTA clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96FD7C0", Offset = "0x96FC5C0", VA = "0x1896FD7C0", Slot = "5")]
		public bool CHPWDCITFZR(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96FDEF0", Offset = "0x96FCCF0", VA = "0x1896FDEF0", Slot = "6")]
		public ChatMessage MCCKHERHWOJ(long a, ODNKFSMINWM.RHQNCVRQPDM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x96FD9B0", Offset = "0x96FC7B0", VA = "0x1896FD9B0", Slot = "7")]
		public CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(ODNKFSMINWM.RHQNCVRQPDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x96FE070", Offset = "0x96FCE70", VA = "0x1896FE070", Slot = "4")]
		public void MIHIFLBMPWX(LEBDQHZUUED a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x96FDB20", Offset = "0x96FC920", VA = "0x1896FDB20", Slot = "8")]
		public void FGLKAGJNITK(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x96FDCF0", Offset = "0x96FCAF0", VA = "0x1896FDCF0")]
		private ODNKFSMINWM.RHQNCVRQPDM KBCDTDGUCKW(ODNKFSMINWM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x96FE170", Offset = "0x96FCF70", VA = "0x1896FE170")]
		private void WDUGHUCYFIL(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x96FD5C0", Offset = "0x96FC3C0", VA = "0x1896FD5C0")]
		private void BGKZWMKFAVK(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x96FDC10", Offset = "0x96FCA10", VA = "0x1896FDC10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "10")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9700CD0", Offset = "0x96FFAD0", VA = "0x189700CD0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9700C30", Offset = "0x96FFA30", VA = "0x189700C30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "10")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string GBRLODULFZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xEFEAF0", Offset = "0xEFD8F0", VA = "0x180EFEAF0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long UKFSRSVFAMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9700ED0", Offset = "0x96FFCD0", VA = "0x189700ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9700F90", Offset = "0x96FFD90", VA = "0x189700F90")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9700F50", Offset = "0x96FFD50", VA = "0x189700F50")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class HIGZRIWESLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x96FF670", Offset = "0x96FE470", VA = "0x1896FF670")]
		[CXDXQIFYXBD.Root]
		internal static void KPVEPOXULCM(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96FF950", Offset = "0x96FE750", VA = "0x1896FF950")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x96FE6E0", Offset = "0x96FD4E0", VA = "0x1896FE6E0")]
			internal string CCBIQFYVHHV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] VJQZYTYIOJN;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x96FED20", Offset = "0x96FDB20", VA = "0x1896FED20")]
		public static CCAFLELIKTY<string> HRZFTAIQWQZ(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x96FEA00", Offset = "0x96FD800", VA = "0x1896FEA00")]
		public static CCAFLELIKTY<string> HRZFTAIQWQZ(ODNKFSMINWM.RHQNCVRQPDM a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96FEF00", Offset = "0x96FDD00", VA = "0x1896FEF00")]
		private static string KHIEFNRBGSB(IDUWQQXCGVW a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x96FEDF0", Offset = "0x96FDBF0", VA = "0x1896FEDF0")]
		public static string JMSBCRHJAVZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x96FF1C0", Offset = "0x96FDFC0", VA = "0x1896FF1C0")]
		public static string NZYEIXMDOTO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x96FE990", Offset = "0x96FD790", VA = "0x1896FE990")]
		public static bool DTCIHJUZNGP(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x96FF2D0", Offset = "0x96FE0D0", VA = "0x1896FF2D0")]
		public static bool RAHYPEDEGWM(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x96FF490", Offset = "0x96FE290", VA = "0x1896FF490")]
		public static bool VQDDVORNBWT(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x96FF340", Offset = "0x96FE140", VA = "0x1896FF340")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x9702540", Offset = "0x9701340", VA = "0x189702540", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9702770", Offset = "0x9701570", VA = "0x189702770", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9702FD0", Offset = "0x9701DD0", VA = "0x189702FD0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9702CF0", Offset = "0x9701AF0", VA = "0x189702CF0")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9702EC0", Offset = "0x9701CC0", VA = "0x189702EC0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9702680", Offset = "0x9701480", VA = "0x189702680", Slot = "17")]
		public void GJNSMKDNLZH(OFAHGBLTYQU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9702800", Offset = "0x9701600", VA = "0x189702800", Slot = "16")]
		public NFPDGBDVXFD TTAMQXJCGNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9702C00", Offset = "0x9701A00", VA = "0x189702C00")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF90", Offset = "0xCEED90", VA = "0x180CEFF90", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x97009D0", Offset = "0x96FF7D0", VA = "0x1897009D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long MIDTYYXFTXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCE7960", Offset = "0xCE6760", VA = "0x180CE7960")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ALFYGILKTXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object QKDYCBQYGBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCE8260", Offset = "0xCE7060", VA = "0x180CE8260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public NFPDGBDVXFD KFPFTKFXBHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCE8290", Offset = "0xCE7090", VA = "0x180CE8290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9700A10", Offset = "0x96FF810", VA = "0x189700A10")]
		protected OFAHGBLTYQU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9700AB0", Offset = "0x96FF8B0", VA = "0x189700AB0")]
		protected OFAHGBLTYQU(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9700B60", Offset = "0x96FF960", VA = "0x189700B60")]
		protected OFAHGBLTYQU(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x97007F0", Offset = "0x96FF5F0", VA = "0x1897007F0")]
		protected void CNPIBPIIBQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x97008C0", Offset = "0x96FF6C0", VA = "0x1897008C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x97009A0", Offset = "0x96FF7A0", VA = "0x1897009A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9700840", Offset = "0x96FF640", VA = "0x189700840", Slot = "4")]
		public bool Equals(OFAHGBLTYQU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public WYUZZVKPLDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x85BD740", Offset = "0x85BC540", VA = "0x1885BD740")]
			internal void ACUCXSIDLHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a QKDYCBQYGBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x76395F0", Offset = "0x76383F0", VA = "0x1876395F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7639660", Offset = "0x7638460", VA = "0x187639660")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7639680", Offset = "0x7638480", VA = "0x187639680")]
		protected RQKJQKYDPLA(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7639730", Offset = "0x7638530", VA = "0x187639730")]
		protected RQKJQKYDPLA(string a, long b, string c, CCAFLELIKTY<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void BVLPNHOMQIF(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x76395A0", Offset = "0x76383A0", VA = "0x1876395A0")]
		private void DKJNJZAYARS(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7639640", Offset = "0x7638440", VA = "0x187639640")]
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
			[Cpp2IlInjected.Address(RVA = "0xD51490", Offset = "0xD50290", VA = "0x180D51490", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x96FFB70", Offset = "0x96FE970", VA = "0x1896FFB70")]
		public LKMVFEQQQXO(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x96FFBC0", Offset = "0x96FE9C0", VA = "0x1896FFBC0")]
		public LKMVFEQQQXO(string a, long b, string c, CCAFLELIKTY<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x96FFAA0", Offset = "0x96FE8A0", VA = "0x1896FFAA0", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x96FFB10", Offset = "0x96FE910", VA = "0x1896FFB10", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x96FD350", Offset = "0x96FC150", VA = "0x1896FD350")]
		public CDNQHPFKJIK(string a, long b, string c, CCAFLELIKTY<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x96FD270", Offset = "0x96FC070", VA = "0x1896FD270", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x96FD300", Offset = "0x96FC100", VA = "0x1896FD300", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9700700", Offset = "0x96FF500", VA = "0x189700700")]
		public MQKSXEKGCOT(string a, long b, string c, CCAFLELIKTY<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x97005A0", Offset = "0x96FF3A0", VA = "0x1897005A0", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9700690", Offset = "0x96FF490", VA = "0x189700690", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD550F0", Offset = "0xD53EF0", VA = "0x180D550F0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x96FD480", Offset = "0x96FC280", VA = "0x1896FD480", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x96FD570", Offset = "0x96FC370", VA = "0x1896FD570")]
		public CXWCIYSXMFV(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x96FD500", Offset = "0x96FC300", VA = "0x1896FD500")]
		public CXWCIYSXMFV(string a, long b, string c, CCAFLELIKTY<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x96FD3C0", Offset = "0x96FC1C0", VA = "0x1896FD3C0", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x96FD430", Offset = "0x96FC230", VA = "0x1896FD430", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B20", Offset = "0xCE6920", VA = "0x180CE7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCE7900", Offset = "0xCE6700", VA = "0x180CE7900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9703320", Offset = "0x9702120", VA = "0x189703320", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x97035C0", Offset = "0x97023C0", VA = "0x1897035C0")]
		public ZAWNNMFNTCV(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9703550", Offset = "0x9702350", VA = "0x189703550")]
		public ZAWNNMFNTCV(string a, long b, string c, CCAFLELIKTY<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x97031E0", Offset = "0x9701FE0", VA = "0x1897031E0", Slot = "9")]
		public override string BNJTJCYSFYO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x97032A0", Offset = "0x97020A0", VA = "0x1897032A0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7295070", Offset = "0x7293E70", VA = "0x187295070", Slot = "7")]
		private ODNKFSMINWM.RHQNCVRQPDM PZEXJVJFUST(ODNKFSMINWM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7295090", Offset = "0x7293E90", VA = "0x187295090", Slot = "6")]
		private CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> RHMBCGIFQLO(ODNKFSMINWM.RHQNCVRQPDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7294F10", Offset = "0x7293D10", VA = "0x187294F10", Slot = "10")]
		public virtual a KBCDTDGUCKW(ODNKFSMINWM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7294D40", Offset = "0x7293B40", VA = "0x187294D40", Slot = "11")]
		public virtual CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "12")]
		protected virtual void ACIAHYRIRCH(a a, ODNKFSMINWM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7294FF0", Offset = "0x7293DF0", VA = "0x187294FF0", Slot = "13")]
		protected virtual CCAFLELIKTY<string> KTESTKZMWEP(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected OGAIEEOQHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7294C60", Offset = "0x7293A60", VA = "0x187294C60")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType YFKMMNNXMAZ
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCED350", Offset = "0xCEC150", VA = "0x180CED350")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int GDLOFLZFYLU
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x162E100", Offset = "0x162CF00", VA = "0x18162E100")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x162E110", Offset = "0x162CF10", VA = "0x18162E110")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int TVYNJKHIZEF
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xCF75E0", Offset = "0xCF63E0", VA = "0x180CF75E0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD3E0B0", Offset = "0xD3CEB0", VA = "0x180D3E0B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string UBMXMNJQWUV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16B6B60", Offset = "0x16B5960", VA = "0x1816B6B60")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BE0", Offset = "0xCE79E0", VA = "0x180CE8BE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9700510", Offset = "0x96FF310", VA = "0x189700510")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] HPHVJCTOAPJ roomsClient, [Inject(null)] GTMOJNOMKIL accountsClient, [Inject(null)] EFPNFTWXNWR imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x96FFC30", Offset = "0x96FEA30", VA = "0x1896FFC30", Slot = "11")]
		public override CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x96FFC70", Offset = "0x96FEA70", VA = "0x1896FFC70", Slot = "10")]
		public override TextMessageDetails KBCDTDGUCKW(ODNKFSMINWM.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x96FFD90", Offset = "0x96FEB90", VA = "0x1896FFD90")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "9")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9700CE0", Offset = "0x96FFAE0", VA = "0x189700CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "9")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9700FA0", Offset = "0x96FFDA0", VA = "0x189700FA0", Slot = "12")]
		protected override void ACIAHYRIRCH(PhotoMessageDetails a, ODNKFSMINWM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9701140", Offset = "0x96FFF40", VA = "0x189701140")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public BVQANBPWYUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x96FCAA0", Offset = "0x96FB8A0", VA = "0x1896FCAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override ODNKFSMINWM.MessageContentType XZJJNXYHELX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "9")]
			get
			{
				return default(ODNKFSMINWM.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9701E50", Offset = "0x9700C50", VA = "0x189701E50", Slot = "14")]
		public void PKTXINUCELZ(RVNNWQATMBD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9701BB0", Offset = "0x97009B0", VA = "0x189701BB0", Slot = "11")]
		public override CCAFLELIKTY<ODNKFSMINWM.IQKMMOYEJRE> DIDLGAKJNVL(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9701640", Offset = "0x9700440", VA = "0x189701640", Slot = "12")]
		protected override void ACIAHYRIRCH(TextMessageDetails a, ODNKFSMINWM.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9701A70", Offset = "0x9700870", VA = "0x189701A70")]
		private bool BISNHJCHDEN(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x97021E0", Offset = "0x9700FE0", VA = "0x1897021E0")]
		private static int XNOAVDSXJPW(TextMessageDetails a, int b, bool c, RVNNWQATMBD d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9702420", Offset = "0x9701220", VA = "0x189702420")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AC2F0", Offset = "0x85AB0F0", VA = "0x1885AC2F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AC180", Offset = "0x85AAF80", VA = "0x1885AC180", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85ACB30", Offset = "0x85AB930", VA = "0x1885ACB30")]
		protected WMIXDHVCPXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85AC1A0", Offset = "0x85AAFA0", VA = "0x1885AC1A0")]
		protected string FJWNRFGHFTW(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85AC430", Offset = "0x85AB230", VA = "0x1885AC430", Slot = "14")]
		public bool PPXSQRKLNWN(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85AC7C0", Offset = "0x85AB5C0", VA = "0x1885AC7C0", Slot = "15")]
		public void XJHNULWSGEQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a XLRAZXKYYVL(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85AC2D0", Offset = "0x85AB0D0", VA = "0x1885AC2D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x85ABED0", Offset = "0x85AACD0", VA = "0x1885ABED0")]
		private bool CNOFDBBSHCU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85AC3C0", Offset = "0x85AB1C0", VA = "0x1885AC3C0")]
		private string KMIQOIGZDIG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85AC5F0", Offset = "0x85AB3F0", VA = "0x1885AC5F0", Slot = "6")]
		private bool QKZKOKNESRW(string a, [Out] OFAHGBLTYQU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x85AC8E0", Offset = "0x85AB6E0", VA = "0x1885AC8E0", Slot = "7")]
		private void YDJSCFXZLBB(OFAHGBLTYQU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85AC2A0", Offset = "0x85AB0A0", VA = "0x1885AC2A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85AC060", Offset = "0x85AAE60", VA = "0x1885AC060", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85ABFE0", Offset = "0x85AADE0", VA = "0x1885ABFE0", Slot = "9")]
		public bool Equals(RVNNWQATMBD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85ABFB0", Offset = "0x85AADB0", VA = "0x1885ABFB0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD51490", Offset = "0xD50290", VA = "0x180D51490", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEC30", Offset = "0x1FADA30", VA = "0x181FAEC30", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x96FE670", Offset = "0x96FD470", VA = "0x1896FE670", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x96FE680", Offset = "0x96FD480", VA = "0x1896FE680")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] QRPAHXMZSTA clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x96FE520", Offset = "0x96FD320", VA = "0x1896FE520", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB3E60", Offset = "0x1FB2C60", VA = "0x181FB3E60", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xDFB730", Offset = "0xDFA530", VA = "0x180DFB730", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9700E70", Offset = "0x96FFC70", VA = "0x189700E70")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] EFPNFTWXNWR imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9700D20", Offset = "0x96FFB20", VA = "0x189700D20", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FF8560", Offset = "0x1FF7360", VA = "0x181FF8560", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9701290", Offset = "0x9700090", VA = "0x189701290", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x97012A0", Offset = "0x97000A0", VA = "0x1897012A0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] GTMOJNOMKIL accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9701180", Offset = "0x96FFF80", VA = "0x189701180", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD550F0", Offset = "0xD53EF0", VA = "0x180D550F0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEC30", Offset = "0x1FADA30", VA = "0x181FAEC30", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9701450", Offset = "0x9700250", VA = "0x189701450", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9701460", Offset = "0x9700260", VA = "0x189701460")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] HGHILNXCDDA playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9701300", Offset = "0x9700100", VA = "0x189701300", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char POAXYDRUDNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x97015D0", Offset = "0x97003D0", VA = "0x1897015D0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char ACUBMWNZNJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F98300", Offset = "0x1F97100", VA = "0x181F98300", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x97015E0", Offset = "0x97003E0", VA = "0x1897015E0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] HPHVJCTOAPJ roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x97014C0", Offset = "0x97002C0", VA = "0x1897014C0", Slot = "19")]
		protected override ZAWNNMFNTCV KNSZYWKYCPF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class BZKQUICGRHS<a> : WMIXDHVCPXY<a> where a : OFAHGBLTYQU
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE050", Offset = "0x4EDCE50", VA = "0x184EDE050", Slot = "16")]
		public override a XLRAZXKYYVL(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDE90", Offset = "0x4EDCC90", VA = "0x184EDDE90", Slot = "18")]
		protected override string IUUTVXIVGOS(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDF30", Offset = "0x4EDCD30", VA = "0x184EDDF30", Slot = "17")]
		protected override bool WIQLQAYBRKA(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a KNSZYWKYCPF(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE090", Offset = "0x4EDCE90", VA = "0x184EDE090")]
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
