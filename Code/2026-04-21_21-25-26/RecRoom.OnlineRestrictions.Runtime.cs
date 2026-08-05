using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class IXBFVIJSSFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9D9AB40", Offset = "0x9D99540", VA = "0x189D9AB40")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	public IXBFVIJSSFJ()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_OnlineRestrictions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EA10", Offset = "0x9D9D410", VA = "0x189D9EA10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : JHKJYAUZJLS
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class VKTQLLPEBJD<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<JHYASPATXAV, a> QTLVTKNPGML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a JTBPWUDBHYM;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public VKTQLLPEBJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7FED1E0", Offset = "0x7FEBBE0", VA = "0x187FED1E0")]
			internal bool QZJVTNQDMUZ(JHYASPATXAV a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BIXCMHOKINO<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> UUJZIQQXKDQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<JHYASPATXAV, a> QTLVTKNPGML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a JTBPWUDBHYM;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BIXCMHOKINO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4F1F310", Offset = "0x4F1DD10", VA = "0x184F1F310")]
			internal bool SRTOPLIADWQ(JHYASPATXAV a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<JHYASPATXAV> FKGRWEAKLUF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<JHYASPATXAV> BGIKFSNARDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9D9B780", Offset = "0x9D9A180", VA = "0x189D9B780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9D9AC20", Offset = "0x9D99620", VA = "0x189D9AC20")]
		[CXDXQIFYXBD.Root.GameOnly]
		internal static void AORJPAUYZAF(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BB50", Offset = "0x9D9A550", VA = "0x189D9BB50")]
		private bool IAAKDQSRXHR(Func<JHYASPATXAV, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C700", Offset = "0x9D9B100", VA = "0x189D9C700")]
		private bool MQLTCITFXXI(Func<JHYASPATXAV, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5EE0", Offset = "0x3DC48E0", VA = "0x183DC5EE0")]
		private bool OEDRRDGZYDZ<a>(a a, Func<JHYASPATXAV, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6240", Offset = "0x3DC4C40", VA = "0x183DC6240")]
		private bool ZMAGODMDXQY<b>(b a, Func<JHYASPATXAV, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CC40", Offset = "0x9D9B640", VA = "0x189D9CC40", Slot = "4")]
		public bool PKJBCFIRGNU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C060", Offset = "0x9D9AA60", VA = "0x189D9C060", Slot = "5")]
		public bool KBYQNHNMUQR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B1B0", Offset = "0x9D99BB0", VA = "0x189D9B1B0", Slot = "6")]
		public bool CYWCWFRVZPL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C4B0", Offset = "0x9D9AEB0", VA = "0x189D9C4B0", Slot = "7")]
		public bool LEJCHWBKLBT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B400", Offset = "0x9D99E00", VA = "0x189D9B400", Slot = "8")]
		public bool DGGIFAOHVHP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C2B0", Offset = "0x9D9ACB0", VA = "0x189D9C2B0", Slot = "9")]
		public bool KYAWHKJLMFQ(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B090", Offset = "0x9D99A90", VA = "0x189D9B090", Slot = "10")]
		public bool CWTVFIFLMJR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D260", Offset = "0x9D9BC60", VA = "0x189D9D260", Slot = "11")]
		public bool SXUHHKNSWPA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D710", Offset = "0x9D9C110", VA = "0x189D9D710", Slot = "12")]
		public bool VVBKIETMCSN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BA30", Offset = "0x9D9A430", VA = "0x189D9BA30", Slot = "13")]
		public bool HNZJMDMCVYK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9D9AF70", Offset = "0x9D99970", VA = "0x189D9AF70", Slot = "14")]
		public bool CPDAEYEJVKQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BE10", Offset = "0x9D9A810", VA = "0x189D9BE10", Slot = "15")]
		public bool JBRTIEYEQKH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DB60", Offset = "0x9D9C560", VA = "0x189D9DB60", Slot = "16")]
		public bool XHHQTMSAPLB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BCE0", Offset = "0x9D9A6E0", VA = "0x189D9BCE0", Slot = "17")]
		public bool JAFCEHYATIE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CD60", Offset = "0x9D9B760", VA = "0x189D9CD60", Slot = "18")]
		public bool POMEKFCHWZF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D380", Offset = "0x9D9BD80", VA = "0x189D9D380", Slot = "19")]
		public bool TCAWDDZYUPD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D110", Offset = "0x9D9BB10", VA = "0x189D9D110", Slot = "20")]
		public bool SPRMIKSOCBW(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C890", Offset = "0x9D9B290", VA = "0x189D9C890", Slot = "21")]
		public bool MYUCEPOIXTN(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D4B0", Offset = "0x9D9BEB0", VA = "0x189D9D4B0", Slot = "22")]
		public bool UGSTHSRLBGY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C180", Offset = "0x9D9AB80", VA = "0x189D9C180", Slot = "23")]
		public bool KDZTUUCNBQU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9D9AD10", Offset = "0x9D99710", VA = "0x189D9AD10", Slot = "24")]
		public bool BRWTILCKEUF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B520", Offset = "0x9D99F20", VA = "0x189D9B520", Slot = "25")]
		public bool DWGMZYHPXDV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CB10", Offset = "0x9D9B510", VA = "0x189D9CB10", Slot = "26")]
		public bool NOYSEINLEZQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CFE0", Offset = "0x9D9B9E0", VA = "0x189D9CFE0", Slot = "27")]
		public bool QWMKCYBUHIK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D8E0", Offset = "0x9D9C2E0", VA = "0x189D9D8E0", Slot = "28")]
		public bool WLRLBDLLDPV(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C9E0", Offset = "0x9D9B3E0", VA = "0x189D9C9E0", Slot = "29")]
		public bool NLBQJDJZTYB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9D9AE40", Offset = "0x9D99840", VA = "0x189D9AE40", Slot = "30")]
		public bool CNIUUEDRVXY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DC80", Offset = "0x9D9C680", VA = "0x189D9DC80", Slot = "31")]
		public bool YHDXPBNUTHW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DA30", Offset = "0x9D9C430", VA = "0x189D9DA30", Slot = "32")]
		public bool WQJCKTUWCDJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CE90", Offset = "0x9D9B890", VA = "0x189D9CE90", Slot = "33")]
		public bool PRYNCVYUVFD(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF30", Offset = "0x9D9A930", VA = "0x189D9BF30", Slot = "34")]
		public bool JEHDJDTZAYU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9C5D0", Offset = "0x9D9AFD0", VA = "0x189D9C5D0", Slot = "35")]
		public bool LHHWXCETNYA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B650", Offset = "0x9D9A050", VA = "0x189D9B650", Slot = "36")]
		public bool FUSKBJQCOZV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B2D0", Offset = "0x9D99CD0", VA = "0x189D9B2D0", Slot = "37")]
		public bool DDWTDDBVJEC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D5E0", Offset = "0x9D9BFE0", VA = "0x189D9D5E0", Slot = "38")]
		public bool VSMJNIOWXBX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D830", Offset = "0x9D9C230", VA = "0x189D9D830", Slot = "39")]
		public string WAQKHXNVTLT(OnlineRestrictionsSources a)
		{
			return null;
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
